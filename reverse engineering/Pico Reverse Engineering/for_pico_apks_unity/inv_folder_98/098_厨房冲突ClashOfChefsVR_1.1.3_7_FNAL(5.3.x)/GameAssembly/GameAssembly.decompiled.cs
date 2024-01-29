using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Doozy.Engine.Nody;
using Doozy.Engine.UI;
using Doozy.Engine.UI.Internal;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using Photon.Chat;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityEngine.UI;
using UnityEngine.Video;
using VRTK;
using VRTK.Highlighters;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class AvatarBody : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28488", Offset = "0xD28488")]
	public GameObject[] face;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material skinMaterial;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material handsMaterial;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string[] skinColor;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int[] eyeShapes;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD284C0", Offset = "0xD284C0")]
	public GameObject[] hair;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string[] hairColor;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD284F8", Offset = "0xD284F8")]
	public Texture[] eyesColor;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject eyes;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AvatarData avatarData;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject selectedFace;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE06D5C", Offset = "0xE06D5C", VA = "0xE06D5C")]
	public void LoadBody(AvatarData avatarData)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE06DD0", Offset = "0xE06DD0", VA = "0xE06DD0")]
	private void SelectFace(int faceIndex)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE06EA4", Offset = "0xE06EA4", VA = "0xE06EA4")]
	private void SelectHair(int hairIndex)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE07044", Offset = "0xE07044", VA = "0xE07044")]
	private void SelectSkinColor(int skinColorIndex)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE06F30", Offset = "0xE06F30", VA = "0xE06F30")]
	private void SelectHairColor(int hairColorIndex)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE0713C", Offset = "0xE0713C", VA = "0xE0713C")]
	private void SelectEyesColor(int eyesColorIndex)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE071EC", Offset = "0xE071EC", VA = "0xE071EC")]
	private void SelectEyesShape(int eyeShapeIndex)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE072E4", Offset = "0xE072E4", VA = "0xE072E4")]
	public AvatarBody()
	{
	}
}
[Token(Token = "0x2000003")]
public class AvatarGroup : MonoBehaviourPun
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28530", Offset = "0xD28530")]
	public AvatarBody[] body;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AvatarData avatarData;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public WaiterController[] waiterControllers;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int currentWaiterController;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool isOpponent;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE07CC8", Offset = "0xE07CC8", VA = "0xE07CC8")]
	private void Start()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE07E74", Offset = "0xE07E74", VA = "0xE07E74")]
	private void LoadAvatarFromSettings()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE07F5C", Offset = "0xE07F5C", VA = "0xE07F5C")]
	public void LoadAvatarDataFromString(string waiterID)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE08058", Offset = "0xE08058", VA = "0xE08058")]
	private void SelectBody(int bodyIndex)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE07FE8", Offset = "0xE07FE8", VA = "0xE07FE8")]
	public void LoadAvatar(AvatarData avatarData)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE080E8", Offset = "0xE080E8", VA = "0xE080E8")]
	public AvatarData GetAvatarData()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE080F0", Offset = "0xE080F0", VA = "0xE080F0")]
	public WaiterController GetWaiterController()
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE08158", Offset = "0xE08158", VA = "0xE08158")]
	public AvatarGroup()
	{
	}
}
[Token(Token = "0x2000004")]
public class AvatarData
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int body;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int face;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int hair;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int hairColor;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int skinColor;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int eyesColor;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int eyesShape;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE078A0", Offset = "0xE078A0", VA = "0xE078A0")]
	public void FromString(string data)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE07A14", Offset = "0xE07A14", VA = "0xE07A14", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE07CC0", Offset = "0xE07CC0", VA = "0xE07CC0")]
	public AvatarData()
	{
	}
}
[Token(Token = "0x2000005")]
public class PlayerAvatar : MonoBehaviour
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar myAvatar;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool userIdAcquired;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool sdkLoaded;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlayerAvatar instance;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x22BD8A0", Offset = "0x22BD8A0", VA = "0x22BD8A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x22BDAE4", Offset = "0x22BDAE4", VA = "0x22BDAE4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x22BDC6C", Offset = "0x22BDC6C", VA = "0x22BDC6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x22BDAD8", Offset = "0x22BDAD8", VA = "0x22BDAD8")]
	public void UserIdAcquired(string id)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x22BDC78", Offset = "0x22BDC78", VA = "0x22BDC78")]
	public void EnableAvatar()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x22AC810", Offset = "0x22AC810", VA = "0x22AC810")]
	public void ShowHands(bool show, GameObject hand)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x22BDD3C", Offset = "0x22BDD3C", VA = "0x22BDD3C")]
	public PlayerAvatar()
	{
	}
}
[Token(Token = "0x2000006")]
public class Bend : MonoBehaviour
{
	[Token(Token = "0x2000137")]
	public enum BendAxis
	{
		[Token(Token = "0x4000709")]
		X,
		[Token(Token = "0x400070A")]
		Y,
		[Token(Token = "0x400070B")]
		Z
	}

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float rotate;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fromPosition;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BendAxis axis;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Mesh mesh;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] vertices;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE095DC", Offset = "0xE095DC", VA = "0xE095DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE09B8C", Offset = "0xE09B8C", VA = "0xE09B8C")]
	public Bend()
	{
	}
}
[Token(Token = "0x2000007")]
public class CircularMotionDetection : MonoBehaviourPun
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] velocityHistory;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3[] pointsHistory;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int startPointsIndex;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int lastPointsIndex;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int startVelocityIndex;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int lastVelocityIndex;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isFilled;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject center;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float timeMonitoring;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int updateInterval;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int currentElapsedInterval;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float goodMotion;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float goodMotionThreshold;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float velocityThreshold;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float distanceThreashold;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float coeffIncreaseMotion;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float coeffDropoffMotion;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Rigidbody rb;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UnityEvent OnAction;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE14990", Offset = "0xE14990", VA = "0xE14990")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xE14A6C", Offset = "0xE14A6C", VA = "0xE14A6C")]
	private void Update()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE14A70", Offset = "0xE14A70", VA = "0xE14A70")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE14CD8", Offset = "0xE14CD8", VA = "0xE14CD8")]
	public void UpdatePoints()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE14B88", Offset = "0xE14B88", VA = "0xE14B88")]
	public void UpdateVelocity()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE14DAC", Offset = "0xE14DAC", VA = "0xE14DAC")]
	public void Calculate()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE1500C", Offset = "0xE1500C", VA = "0xE1500C")]
	public CircularMotionDetection()
	{
	}
}
[Token(Token = "0x2000008")]
public class CircularMoverTest : MonoBehaviour
{
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ellipseA;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ellipseB;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float step;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 circleCenter;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE15024", Offset = "0xE15024", VA = "0xE15024")]
	private void Start()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE15060", Offset = "0xE15060", VA = "0xE15060")]
	private void Update()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE151B0", Offset = "0xE151B0", VA = "0xE151B0")]
	public CircularMoverTest()
	{
	}
}
[Token(Token = "0x2000009")]
public class ButtonListener : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent triggerPressEvents;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent triggerReleaseEvents;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEvent gripPressEvents;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UnityEvent gripReleaseEvents;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UnityEvent buttonTwoPressEvents;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UnityEvent buttonTwoReleaseEvents;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UnityEvent startMenuPressEvents;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UnityEvent startMenuReleaseEvents;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 previousPosition;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float handVelocity;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE10F28", Offset = "0xE10F28", VA = "0xE10F28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE111E8", Offset = "0xE111E8", VA = "0xE111E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE11308", Offset = "0xE11308", VA = "0xE11308")]
	private void DoGripPressed(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE11384", Offset = "0xE11384", VA = "0xE11384")]
	private void DoGripReleased(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE11400", Offset = "0xE11400", VA = "0xE11400")]
	private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE1141C", Offset = "0xE1141C", VA = "0xE1141C")]
	private void DoTriggerReleased(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE11438", Offset = "0xE11438", VA = "0xE11438")]
	private void DoButtonTwoPress(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE11454", Offset = "0xE11454", VA = "0xE11454")]
	private void DoButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE11470", Offset = "0xE11470", VA = "0xE11470")]
	private void DoStartMenuPress(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE1148C", Offset = "0xE1148C", VA = "0xE1148C")]
	private void DoStartMenuReleased(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE114A8", Offset = "0xE114A8", VA = "0xE114A8")]
	public void DoTouch(object sender, ObjectInteractEventArgs e)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xE115C0", Offset = "0xE115C0", VA = "0xE115C0")]
	public ButtonListener()
	{
	}
}
[Token(Token = "0x200000A")]
public class CoolingController : MonoBehaviourPun, IPunObservable
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isHot;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timeToCool;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEvent onCool;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float timeCooling;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem particlesSmokeTea;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xE16AA8", Offset = "0xE16AA8", VA = "0xE16AA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xE16CC8", Offset = "0xE16CC8", VA = "0xE16CC8", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xE16DFC", Offset = "0xE16DFC", VA = "0xE16DFC")]
	[PunRPC]
	public void SetHot(bool isHot)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE16BD4", Offset = "0xE16BD4", VA = "0xE16BD4")]
	[PunRPC]
	public void Cooling()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xE16EE0", Offset = "0xE16EE0", VA = "0xE16EE0")]
	[PunRPC]
	public void PlayParticles()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xE16EFC", Offset = "0xE16EFC", VA = "0xE16EFC")]
	[PunRPC]
	public void StopParticles()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xE16F18", Offset = "0xE16F18", VA = "0xE16F18")]
	public CoolingController()
	{
	}
}
[Token(Token = "0x200000B")]
public class CardManager : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image orderPanelSmall;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image orderPanelBig;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image cardPrefab;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cardPosition;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image backPanel;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Image> currentCards;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CustomerManager customerManager;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Image card;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int sign1;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int sign2;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float groupOffset;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xE1284C", Offset = "0xE1284C", VA = "0xE1284C")]
	private void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xE12850", Offset = "0xE12850", VA = "0xE12850")]
	private void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xE12854", Offset = "0xE12854", VA = "0xE12854")]
	public void DeleteInstructions()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xE1299C", Offset = "0xE1299C", VA = "0xE1299C")]
	public void RefreshInstruction()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xE12E94", Offset = "0xE12E94", VA = "0xE12E94")]
	public void PlayPickOrderSound()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xE12F4C", Offset = "0xE12F4C", VA = "0xE12F4C")]
	public void PlayLeftOrderSound()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE13004", Offset = "0xE13004", VA = "0xE13004")]
	public CardManager()
	{
	}
}
[Token(Token = "0x200000C")]
public class CustomerController : MonoBehaviour, IPoolable
{
	[Token(Token = "0x2000138")]
	public enum State
	{
		[Token(Token = "0x400070D")]
		WAITING_FOR_PLACE_TO_SIT,
		[Token(Token = "0x400070E")]
		ENTERING,
		[Token(Token = "0x400070F")]
		WAITING_TO_ORDER,
		[Token(Token = "0x4000710")]
		WAITING_FOR_FOOD,
		[Token(Token = "0x4000711")]
		WAITING_FOR_PICKUP,
		[Token(Token = "0x4000712")]
		EATING,
		[Token(Token = "0x4000713")]
		LEAVING
	}

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CustomerManager customerManager;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CustomerMoods moodManager;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RecipeInstance order;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public NavMeshAgent navMeshAgent;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform placeToSit;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Animator anim;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public State state;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float timer;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool isServed;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool orderTaken;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int orderIndex;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int currentAnim;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public PhotonView photonView;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xE19794", Offset = "0xE19794", VA = "0xE19794")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xE1979C", Offset = "0xE1979C", VA = "0xE1979C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE19894", Offset = "0xE19894", VA = "0xE19894")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE19A44", Offset = "0xE19A44", VA = "0xE19A44")]
	public void PauseSync()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xE19B2C", Offset = "0xE19B2C", VA = "0xE19B2C")]
	public void ContinueSync()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xE19C0C", Offset = "0xE19C0C", VA = "0xE19C0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xE19CAC", Offset = "0xE19CAC", VA = "0xE19CAC", Slot = "4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xE19D34", Offset = "0xE19D34", VA = "0xE19D34")]
	public void CustomerSit()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xE19DF8", Offset = "0xE19DF8", VA = "0xE19DF8")]
	[PunRPC]
	public void CustomerSitRPC()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xE19F40", Offset = "0xE19F40", VA = "0xE19F40")]
	[PunRPC]
	public void SetPlaceToSit(int placeToSitIndex)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xE19FEC", Offset = "0xE19FEC", VA = "0xE19FEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xE1AA30", Offset = "0xE1AA30", VA = "0xE1AA30")]
	public void Serve()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xE1A81C", Offset = "0xE1A81C", VA = "0xE1A81C")]
	public void SpawnRandomCustomer()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xE1A95C", Offset = "0xE1A95C", VA = "0xE1A95C")]
	[PunRPC]
	private void DestroyCustomer()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xE1AA88", Offset = "0xE1AA88", VA = "0xE1AA88")]
	[PunRPC]
	public void SyncOrder(int customerOrder, int customerManagerPID, string orderUiD)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xE1AC44", Offset = "0xE1AC44", VA = "0xE1AC44")]
	public void DestroyFinishedOrder()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xE1B320", Offset = "0xE1B320", VA = "0xE1B320")]
	[PunRPC]
	private void UnparentObject(int[] photonViews)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xE1B418", Offset = "0xE1B418", VA = "0xE1B418")]
	[PunRPC]
	private void DestroyOrder(int[] photonViews)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xE1B608", Offset = "0xE1B608", VA = "0xE1B608")]
	public void OrderTaken()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xE1B718", Offset = "0xE1B718", VA = "0xE1B718")]
	[PunRPC]
	public void ShowInstruction()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xE1B7B0", Offset = "0xE1B7B0", VA = "0xE1B7B0")]
	[PunRPC]
	public void OrderLeft()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xE1B844", Offset = "0xE1B844", VA = "0xE1B844")]
	[PunRPC]
	public void OrderPicked()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xE19988", Offset = "0xE19988", VA = "0xE19988")]
	public void ChangeAnimation(Animator anim, int stateInt)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xE1B8D8", Offset = "0xE1B8D8", VA = "0xE1B8D8")]
	public void Step()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xE1B8DC", Offset = "0xE1B8DC", VA = "0xE1B8DC")]
	public CustomerController()
	{
	}
}
[Token(Token = "0x200000D")]
public class CustomerManager : MonoBehaviour
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MatchManager matchManager;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CardManager cardManager;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AvatarGroup waiter;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform UImanagerPosition;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28568", Offset = "0xD28568")]
	public GameObject bambooRollerPosition;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ScoringSystem scoringSystem;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD285A0", Offset = "0xD285A0")]
	public GameObject[] customersPlayerPrefab;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform[] placesToSit;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public bool[] occupied;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<GameObject> customers;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<CustomerController> currentCustomers;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform customerSpawnPoint;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform customerLeavePoint;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TrayController trayController;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public int nextOrder;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public bool orderShown;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int totalScore;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public int happyCount;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public int indieCount;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[HideInInspector]
	public int madCount;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public int customersLeft;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28658", Offset = "0xD28658")]
	public TextMeshProUGUI levelNumber;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject moodCounts;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshProUGUI happyCountText;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TextMeshProUGUI indieCountText;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public TextMeshProUGUI madCountText;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public TextMeshProUGUI costomersLeftText;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28690", Offset = "0xD28690")]
	public Slider[] scoreSliders;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public TextMeshProUGUI[] scoreNumberTexts;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string playerNameString;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public TextMeshPro[] playerNameTexts;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private RandomSequencePool randomPool;

	[Token(Token = "0x17000001")]
	public string playerName
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x22D737C", Offset = "0x22D737C", VA = "0x22D737C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x22D7384", Offset = "0x22D7384", VA = "0x22D7384")]
		set
		{
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x22D7430", Offset = "0x22D7430", VA = "0x22D7430")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x22D77A4", Offset = "0x22D77A4", VA = "0x22D77A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x22D7B50", Offset = "0x22D7B50", VA = "0x22D7B50")]
	public void OpponentsObjectsOff()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x22D73AC", Offset = "0x22D73AC", VA = "0x22D73AC")]
	public void UpdatePlayerNames()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x22D7CD4", Offset = "0x22D7CD4", VA = "0x22D7CD4", Slot = "4")]
	public virtual bool IsCustomerManagerMine()
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x22D7DA4", Offset = "0x22D7DA4", VA = "0x22D7DA4")]
	public void HideCustomers()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x22D7E60", Offset = "0x22D7E60", VA = "0x22D7E60")]
	public GameObject GetCustomerWaitingToOrder()
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x22D7FA8", Offset = "0x22D7FA8", VA = "0x22D7FA8")]
	public GameObject GetCustomerWaitingForFood()
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x22D8090", Offset = "0x22D8090", VA = "0x22D8090")]
	public Transform GetSeat()
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x22D8118", Offset = "0x22D8118", VA = "0x22D8118")]
	public void ReleaseSeat(Transform seat)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x22D8220", Offset = "0x22D8220", VA = "0x22D8220")]
	public GameObject SpawnCustomer(RecipeInstance orderPlayer)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x22D8708", Offset = "0x22D8708", VA = "0x22D8708")]
	public void ShowInstructions(CustomerController customer)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x22D87CC", Offset = "0x22D87CC", VA = "0x22D87CC")]
	public void OrderPicked(CustomerController customer)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x22D8860", Offset = "0x22D8860", VA = "0x22D8860")]
	public void OrderLeft(CustomerController customer)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x22D8780", Offset = "0x22D8780", VA = "0x22D8780")]
	public void RefreshInstruction()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x22D88F4", Offset = "0x22D88F4", VA = "0x22D88F4")]
	public void MoodCount(GameObject currentCustomer)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x22D8DBC", Offset = "0x22D8DBC", VA = "0x22D8DBC")]
	public void SyncPlayerLeftCount()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x22D8FC8", Offset = "0x22D8FC8", VA = "0x22D8FC8")]
	[PunRPC]
	public void SyncCustomerLeftRPC(int customerLeftSync)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x22D8D34", Offset = "0x22D8D34", VA = "0x22D8D34")]
	[PunRPC]
	public void MoodCountRPC(int mood)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x22D7560", Offset = "0x22D7560", VA = "0x22D7560")]
	[PunRPC]
	public void SetMoodText()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x22D8FD0", Offset = "0x22D8FD0", VA = "0x22D8FD0", Slot = "5")]
	public virtual void ShowMoodsCount()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x22D8FD4", Offset = "0x22D8FD4", VA = "0x22D8FD4")]
	[PunRPC]
	public void UpdateScore(int score)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x22D913C", Offset = "0x22D913C", VA = "0x22D913C")]
	public void SetSlidersMaxValue(int maxValue)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x22D8FDC", Offset = "0x22D8FDC", VA = "0x22D8FDC")]
	public void UpdateScoreGraphics()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x22D9210", Offset = "0x22D9210", VA = "0x22D9210")]
	public CustomerManager()
	{
	}
}
[Token(Token = "0x200000E")]
public class CustomerMoodVisuals : MonoBehaviour
{
	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image moodFace;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject endMarker;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject moodScaleObject;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CardManager cardManager;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CustomerMoods customer;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float moodScale;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource newOrderSound;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource alertSound;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioSource orderSound;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI orderNumberText;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int orderNumber;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject ingridientsParent;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool playAlertSound;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioClip orderPicked;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AudioClip orderLeft;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 offsetPosition;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x22D92EC", Offset = "0x22D92EC", VA = "0x22D92EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x22D9538", Offset = "0x22D9538", VA = "0x22D9538")]
	private void Update()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x22D9850", Offset = "0x22D9850", VA = "0x22D9850")]
	public void PlayAlertSound()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x22D98B4", Offset = "0x22D98B4", VA = "0x22D98B4")]
	public CustomerMoodVisuals()
	{
	}
}
[Token(Token = "0x200000F")]
public class CustomerMoods : MonoBehaviourPun, IPunObservable, IRecordingSerializable, IPoolable
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Canvas moodCanvas;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image moodPanel;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite happySmile;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Sprite indieSmile;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Sprite madSmile;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool shouldLeave;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float moodTimer;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Image moodImage;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float totalTimeToDeliver;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform canvasPosition;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float previousMoodTimer;

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x22D98BC", Offset = "0x22D98BC", VA = "0x22D98BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x22D998C", Offset = "0x22D998C", VA = "0x22D998C", Slot = "7")]
	public void Reset()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x22D99BC", Offset = "0x22D99BC", VA = "0x22D99BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x22D9AF4", Offset = "0x22D9AF4", VA = "0x22D9AF4")]
	public void SetOffest()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x22D9B48", Offset = "0x22D9B48", VA = "0x22D9B48")]
	public void UpdateMood()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x22D861C", Offset = "0x22D861C", VA = "0x22D861C")]
	public void SetTotalTime()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x22D9B80", Offset = "0x22D9B80", VA = "0x22D9B80")]
	[PunRPC]
	public void SetTotalTimeRPC(float totalTime)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x22D9B88", Offset = "0x22D9B88", VA = "0x22D9B88", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x22D9A6C", Offset = "0x22D9A6C", VA = "0x22D9A6C")]
	public void RefreshMood()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x22D9C54", Offset = "0x22D9C54", VA = "0x22D9C54")]
	public void ShowMood()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x22D9E08", Offset = "0x22D9E08", VA = "0x22D9E08")]
	[PunRPC]
	public void ShowMoodRPC()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x22D9E28", Offset = "0x22D9E28", VA = "0x22D9E28")]
	[PunRPC]
	public void HideMood()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x22D9E6C", Offset = "0x22D9E6C", VA = "0x22D9E6C")]
	public void HideMoodRPC()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x22D9F14", Offset = "0x22D9F14", VA = "0x22D9F14", Slot = "5")]
	public string SerializeWrite()
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x22D9F98", Offset = "0x22D9F98", VA = "0x22D9F98", Slot = "6")]
	public void SerializeRead(params string[] objects)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x22D9FE0", Offset = "0x22D9FE0", VA = "0x22D9FE0")]
	public CustomerMoods()
	{
	}
}
[Token(Token = "0x2000010")]
public class FeedbackController : MonoBehaviour
{
	[Token(Token = "0x2000139")]
	public enum Mode
	{
		[Token(Token = "0x4000715")]
		STACKING,
		[Token(Token = "0x4000716")]
		RADIAL
	}

	[Serializable]
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27FC8", Offset = "0xD27FC8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<int, bool> <>9__11_0;

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x22E36B8", Offset = "0x22E36B8", VA = "0x22E36B8")]
		public <>c()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x22E36C0", Offset = "0x22E36C0", VA = "0x22E36C0")]
		internal bool <CreateFeedbackCanvas>b__11_0(int x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Image checkPrefab;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image ingredientPrefab;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image ingredientIconPrefab;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI suhiCounterText;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float groupOffset;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform panel;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Sprite[] feedbackStates;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected List<GameObject> recipeCards;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected List<GameObject> feedbackCards;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Mode mode;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x22E1A80", Offset = "0x22E1A80", VA = "0x22E1A80")]
	public void CreateFeedbackCanvas(Ingredient[][] ingredients, int[][] results, int objectsPlaced)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x22E2710", Offset = "0x22E2710", VA = "0x22E2710")]
	private bool CheckSameOrder(Ingredient[] ingredients1, Ingredient[] ingredients2)
	{
		return default(bool);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x22E2818", Offset = "0x22E2818", VA = "0x22E2818")]
	private void CreateReceipeImage(Ingredient[] ingredients, Vector3 position, Transform parent)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x22E2C68", Offset = "0x22E2C68", VA = "0x22E2C68")]
	private void CreateFeedbackImage(Ingredient[] ingredients, int[] results, Vector3 position, Transform parent)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x22E3434", Offset = "0x22E3434", VA = "0x22E3434", Slot = "4")]
	public virtual void UpdateFeedbackStates(int[][] results)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x22E359C", Offset = "0x22E359C", VA = "0x22E359C")]
	public FeedbackController()
	{
	}
}
[Token(Token = "0x2000011")]
public class OrderPlacementController : MonoBehaviour
{
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject sitPoint;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject platePoint;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lookTarget;

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x22B4634", Offset = "0x22B4634", VA = "0x22B4634")]
	private void Start()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x22B4638", Offset = "0x22B4638", VA = "0x22B4638")]
	private void Update()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x22B463C", Offset = "0x22B463C", VA = "0x22B463C")]
	public OrderPlacementController()
	{
	}
}
[Token(Token = "0x2000012")]
public class TrayController : MonoBehaviour
{
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GameObject> _activeObjectReferences;

	[Token(Token = "0x17000002")]
	public List<GameObject> activeObjectReferences
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x106005C", Offset = "0x106005C", VA = "0x106005C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1060064", Offset = "0x1060064", VA = "0x1060064")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x10600D4", Offset = "0x10600D4", VA = "0x10600D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x10600D8", Offset = "0x10600D8", VA = "0x10600D8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x10602A0", Offset = "0x10602A0", VA = "0x10602A0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1060238", Offset = "0x1060238", VA = "0x1060238")]
	public void AddItem(GameObject item)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x10602D8", Offset = "0x10602D8", VA = "0x10602D8")]
	public void RemoveItem(GameObject item)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1060380", Offset = "0x1060380", VA = "0x1060380")]
	public TrayController()
	{
	}
}
[Token(Token = "0x2000013")]
public class WaiterController : MonoBehaviour, IPunObservable
{
	[Token(Token = "0x200013B")]
	public enum State
	{
		[Token(Token = "0x400071A")]
		GOING_TO_TAKE_ORDER,
		[Token(Token = "0x400071B")]
		TAKING_ORDER,
		[Token(Token = "0x400071C")]
		WAITING_FOR_ORDER,
		[Token(Token = "0x400071D")]
		SERVING,
		[Token(Token = "0x400071E")]
		IDLE
	}

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CustomerManager customerManager;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject servicePlate;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private NavMeshAgent navMeshAgent;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject waiterWaitPoint;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Animator anim;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Animator headAnim;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Animator neckAnim;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private State state;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject waiterPlatePrefab;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform stickPointRight;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform stickPointLeft;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject platePositionRight;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject platePositionLeft;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GameObject waiterPlateRight;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject waiterPlateLeft;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool leftPlateFull;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	private bool rightPlateFull;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject currentServingCustomer;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool served;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float distance;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private PhotonView photonView;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool shouldShowOrder;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private RecipeInstance currentOrder;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public FeedbackController feedbackController;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private RecipeDefinition feedbackOrder;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool running;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private AudioSource audioSource;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public AudioClip[] stepSound;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public AudioClip hitWaiter;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool navMeshDisabled;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
	private bool navMeshEnabled;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
	public bool isFeedbackVisibleToOther;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public GameObject navMeshObstacle;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int currentAnim;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private int[][] lastResults;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1065ED4", Offset = "0x1065ED4", VA = "0x1065ED4")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1065EDC", Offset = "0x1065EDC", VA = "0x1065EDC")]
	private void Start()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x10661C8", Offset = "0x10661C8", VA = "0x10661C8")]
	public void DisableNavMesh()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x10662B0", Offset = "0x10662B0", VA = "0x10662B0")]
	public void EnableNavMesh()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1066360", Offset = "0x1066360", VA = "0x1066360")]
	private void Update()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1067E44", Offset = "0x1067E44", VA = "0x1067E44", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1067E48", Offset = "0x1067E48", VA = "0x1067E48")]
	private RecipeDefinition GetFeedbackOrder()
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x10673FC", Offset = "0x10673FC", VA = "0x10673FC")]
	public void RefreshFeedbackCanvas()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x10681B8", Offset = "0x10681B8", VA = "0x10681B8")]
	[PunRPC]
	public void UpdateFeedbackCanvas(int[][] results)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x10680A4", Offset = "0x10680A4", VA = "0x10680A4")]
	[PunRPC]
	public void ShowFeedbackCanvas(string feedbackOrderId, int[][] results)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1067290", Offset = "0x1067290", VA = "0x1067290")]
	public void HideFeedbackCanvas()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x10681D8", Offset = "0x10681D8", VA = "0x10681D8")]
	[PunRPC]
	public void HideFeedbackCanvasRPC()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1068238", Offset = "0x1068238", VA = "0x1068238")]
	[PunRPC]
	public void ServeCustomerRPC(int customerViewId)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x10679B0", Offset = "0x10679B0", VA = "0x10679B0")]
	public void ServeCustomer(GameObject customer)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x10682E0", Offset = "0x10682E0", VA = "0x10682E0")]
	public void PrepareForTakingOrder()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1066CCC", Offset = "0x1066CCC", VA = "0x1066CCC")]
	public CustomerController HasValidOrder()
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x10688D8", Offset = "0x10688D8", VA = "0x10688D8")]
	public void SwitchToTakeOrderState()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x10688E0", Offset = "0x10688E0", VA = "0x10688E0")]
	public void SwitchToServingState()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x10660E8", Offset = "0x10660E8", VA = "0x10660E8")]
	public void SwitchState(State newState)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1068968", Offset = "0x1068968", VA = "0x1068968")]
	public void TryPickOrder()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1068A74", Offset = "0x1068A74", VA = "0x1068A74")]
	public void PickOrder(CustomerController customerControl)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x106A8D0", Offset = "0x106A8D0", VA = "0x106A8D0")]
	[PunRPC]
	public void SetScore(int scoreRed, int scoreBlue)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x106A8EC", Offset = "0x106A8EC", VA = "0x106A8EC")]
	[PunRPC]
	public void LinkPlateRPC(int spawnedPlateId, int spawnedPlateIdLeft)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x106A0B4", Offset = "0x106A0B4", VA = "0x106A0B4")]
	public void LinkPlate()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x106AA04", Offset = "0x106AA04", VA = "0x106AA04")]
	[PunRPC]
	public void StickToPlateRPC(int recipeId, Vector3 offset)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x106A258", Offset = "0x106A258", VA = "0x106A258")]
	public void StickToPlate(GameObject recipe, Vector3 offset)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1068528", Offset = "0x1068528", VA = "0x1068528")]
	public bool IsOrderOnTray()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x10686BC", Offset = "0x10686BC", VA = "0x10686BC")]
	public bool CheckOrder(RecipeInstance recipe)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x106AAAC", Offset = "0x106AAAC", VA = "0x106AAAC")]
	public void HitWaiter()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x106AC54", Offset = "0x106AC54", VA = "0x106AC54")]
	public void CancelHit()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x106AC5C", Offset = "0x106AC5C", VA = "0x106AC5C")]
	public void ShouldRun()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x106AD50", Offset = "0x106AD50", VA = "0x106AD50")]
	[PunRPC]
	public void ShouldRunRPC()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x106AE20", Offset = "0x106AE20", VA = "0x106AE20")]
	public void ShouldNotRun()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1066C10", Offset = "0x1066C10", VA = "0x1066C10")]
	public void ChangeAnimation(Animator anim, int stateInt)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x106AEDC", Offset = "0x106AEDC", VA = "0x106AEDC")]
	public void Step()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x106AF94", Offset = "0x106AF94", VA = "0x106AF94")]
	public void RunningStep()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x106735C", Offset = "0x106735C", VA = "0x106735C")]
	public void SetHappyHeadAnimation()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x10678B0", Offset = "0x10678B0", VA = "0x10678B0")]
	public void SetShakingHeadAnimation(bool enable)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x106AB4C", Offset = "0x106AB4C", VA = "0x106AB4C")]
	public void SetAngryHeadAnimation(bool enable)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x106AF98", Offset = "0x106AF98", VA = "0x106AF98")]
	public void PauseSync()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x106B078", Offset = "0x106B078", VA = "0x106B078")]
	public void ContinueSync()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x106995C", Offset = "0x106995C", VA = "0x106995C")]
	public void DeliverCountAchievements()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x106B148", Offset = "0x106B148", VA = "0x106B148")]
	public WaiterController()
	{
	}
}
[Token(Token = "0x2000014")]
public class DebugMenu : MonoBehaviour
{
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x22DCFC8", Offset = "0x22DCFC8", VA = "0x22DCFC8")]
	public void OpenMainMenu()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x22DD054", Offset = "0x22DD054", VA = "0x22DD054")]
	public void MatchEndSingleplayer()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x22DD0E0", Offset = "0x22DD0E0", VA = "0x22DD0E0")]
	public void ShowMatchEndMultiplayer()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x22DD16C", Offset = "0x22DD16C", VA = "0x22DD16C")]
	public void OpenPlayerLeft()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x22DD200", Offset = "0x22DD200", VA = "0x22DD200")]
	public void OpenIngameMenu()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x22DD2BC", Offset = "0x22DD2BC", VA = "0x22DD2BC")]
	public void OpenInviteMenu()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x22DD350", Offset = "0x22DD350", VA = "0x22DD350")]
	public void ShowMessage()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x22DD3E4", Offset = "0x22DD3E4", VA = "0x22DD3E4")]
	public void ShowRecenter()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x22DD470", Offset = "0x22DD470", VA = "0x22DD470")]
	public void CloseAllActive()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x22DD4E0", Offset = "0x22DD4E0", VA = "0x22DD4E0")]
	public DebugMenu()
	{
	}
}
[Token(Token = "0x2000015")]
public class DebugRecipeSpawner : MonoBehaviour
{
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RecipeDefinition[] recipeDefinitions;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] ingridientsPrefabs;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform spawnPoint;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 offset;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float spawnDistance;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RecipeDefinition recipeToSpawn;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject sushiRollPrefab;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int numIngredients;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject ingredientPrefab;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x22DD4E8", Offset = "0x22DD4E8", VA = "0x22DD4E8")]
	public void Spawn()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x22DDB8C", Offset = "0x22DDB8C", VA = "0x22DDB8C")]
	public void SpawnIngridients()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x22DD4F0", Offset = "0x22DD4F0", VA = "0x22DD4F0")]
	private void Spawn(RecipeDefinition recipeDefinitionVar)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x22DDDB0", Offset = "0x22DDDB0", VA = "0x22DDDB0")]
	private void SpawnSnapping(SnappingRecipeDefinition recipeDefinition)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x22DE66C", Offset = "0x22DE66C", VA = "0x22DE66C")]
	public DebugRecipeSpawner()
	{
	}
}
[Token(Token = "0x2000016")]
public class EventManager : MonoBehaviour
{
	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, UnityEvent> eventDictionary;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, Action<object[]>> actionDictionary;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EventManager eventManager;

	[Token(Token = "0x17000003")]
	public static EventManager instance
	{
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x22E12F8", Offset = "0x22E12F8", VA = "0x22E12F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x22E1568", Offset = "0x22E1568", VA = "0x22E1568")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x22E14A0", Offset = "0x22E14A0", VA = "0x22E14A0")]
	private void Init()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x22D76B0", Offset = "0x22D76B0", VA = "0x22D76B0")]
	public static void StartListening(string eventName, UnityAction listener)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x22E1618", Offset = "0x22E1618", VA = "0x22E1618")]
	public static void StopListening(string eventName, UnityAction listener)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x22DCF34", Offset = "0x22DCF34", VA = "0x22DCF34")]
	public static void TriggerEvent(string eventName)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x22E16F4", Offset = "0x22E16F4", VA = "0x22E16F4")]
	public static void StartListening(string eventName, Action<object[]> listener)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x22E17EC", Offset = "0x22E17EC", VA = "0x22E17EC")]
	public static void StopListening(string eventName, Action<object[]> listener)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x22E1950", Offset = "0x22E1950", VA = "0x22E1950")]
	public static void TriggerAction(string eventName, params object[] list)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x22E19EC", Offset = "0x22E19EC", VA = "0x22E19EC")]
	public EventManager()
	{
	}
}
[Token(Token = "0x2000017")]
public class FireExtinguisher : MonoBehaviour
{
	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PhotonView photonView;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject particles;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isItemGrabbed;

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x22E3AD4", Offset = "0x22E3AD4", VA = "0x22E3AD4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x22E3BE4", Offset = "0x22E3BE4", VA = "0x22E3BE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x22E3BE8", Offset = "0x22E3BE8", VA = "0x22E3BE8")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x22E3BF0", Offset = "0x22E3BF0", VA = "0x22E3BF0")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x22E3BFC", Offset = "0x22E3BFC", VA = "0x22E3BFC")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x22E3EA4", Offset = "0x22E3EA4", VA = "0x22E3EA4")]
	[PunRPC]
	public void ShowFoam(bool show)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x22E3F68", Offset = "0x22E3F68", VA = "0x22E3F68")]
	public void Activate()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x22E40A4", Offset = "0x22E40A4", VA = "0x22E40A4")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x22E41DC", Offset = "0x22E41DC", VA = "0x22E41DC")]
	public FireExtinguisher()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class AchievementsInfo
{
	[Token(Token = "0x200013C")]
	public enum Type
	{
		[Token(Token = "0x4000720")]
		AMERICAN_BURGER_KING,
		[Token(Token = "0x4000721")]
		AMERICAN_SAUCERER,
		[Token(Token = "0x4000722")]
		AMERICAN_MAD_CUTER,
		[Token(Token = "0x4000723")]
		AMERICAN_BRAIN_FRIED,
		[Token(Token = "0x4000724")]
		AMERICAN_GRILL_MASTER,
		[Token(Token = "0x4000725")]
		AMERICAN_YOU_HAD_ME_AT_BACON,
		[Token(Token = "0x4000726")]
		AMERICAN_AMERICAN_CHEF,
		[Token(Token = "0x4000727")]
		AMERICAN_AMERICAN_MASTER_CHEF,
		[Token(Token = "0x4000728")]
		ITALIAN_PIZZA_MAESTRO,
		[Token(Token = "0x4000729")]
		ITALIAN_PASTA_LA_VISTA,
		[Token(Token = "0x400072A")]
		ITALIAN_ROLLINGPIN,
		[Token(Token = "0x400072B")]
		ITALIAN_EXTRA_CHEESE_PLEASE,
		[Token(Token = "0x400072C")]
		ITALIAN_FEELIN_SAUCY,
		[Token(Token = "0x400072D")]
		ITALIAN_PASTASTICO,
		[Token(Token = "0x400072E")]
		ITALIAN_ITALIAN_CHEF,
		[Token(Token = "0x400072F")]
		ITALIAN_ITALIAN_MASTER_CHEF,
		[Token(Token = "0x4000730")]
		JAPANESE_RAMEN_100,
		[Token(Token = "0x4000731")]
		JAPANESE_SUSHI_100,
		[Token(Token = "0x4000732")]
		JAPANESE_SUSHININJA,
		[Token(Token = "0x4000733")]
		JAPANESE_ICETEA,
		[Token(Token = "0x4000734")]
		JAPANESE_NOODLENESS,
		[Token(Token = "0x4000735")]
		JAPANESE_BAD_TO_THE_BROTH,
		[Token(Token = "0x4000736")]
		JAPANESE_JAPANESE_CHEF,
		[Token(Token = "0x4000737")]
		JAPANESE_JAPANESE_MASTER_CHEF,
		[Token(Token = "0x4000738")]
		MEXICAN_NACHOS_LIBRE,
		[Token(Token = "0x4000739")]
		MEXICAN_TACO_LOCO,
		[Token(Token = "0x400073A")]
		MEXICAN_BURITO_100,
		[Token(Token = "0x400073B")]
		MEXICAN_FRUITY_LOOPS,
		[Token(Token = "0x400073C")]
		MEXICAN_SALSATION,
		[Token(Token = "0x400073D")]
		MEXICAN_ROLLIN_BURRITOS,
		[Token(Token = "0x400073E")]
		MEXICAN_MEXICAN_CHEF,
		[Token(Token = "0x400073F")]
		MEXICAN_MEXICAN_MASTER_CHEF,
		[Token(Token = "0x4000740")]
		GENERAL_AT_YOUR_SERVICE,
		[Token(Token = "0x4000741")]
		GENERAL_CARDIO_COACH,
		[Token(Token = "0x4000742")]
		GENERAL_WAITER_HATER,
		[Token(Token = "0x4000743")]
		GENERAL_PERFECT_CHEF,
		[Token(Token = "0x4000744")]
		GENERAL_MULTIPLAYER_WIN,
		[Token(Token = "0x4000745")]
		GENERAL_WASTER,
		[Token(Token = "0x4000746")]
		GENERAL_INVITE_FRIEND,
		[Token(Token = "0x4000747")]
		GENERAL_MULTIPLAYER_WIN_50,
		[Token(Token = "0x4000748")]
		MAX_ACHIEVEMENTS
	}

	[Token(Token = "0x200013D")]
	public class AchievementsData
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] achievementCounters;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool[] achievementUnlocked;

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xE049F8", Offset = "0xE049F8", VA = "0xE049F8")]
		public AchievementsData()
		{
		}
	}

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AchievementsData achievementsData;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int[] achievementsTargets;

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xE04434", Offset = "0xE04434", VA = "0xE04434")]
	public static void AchievementIncrement(Type achievementType)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xE04700", Offset = "0xE04700", VA = "0xE04700")]
	public static void AchievementUnlock(Type achievementType)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xE04574", Offset = "0xE04574", VA = "0xE04574")]
	private static void UpdateAchievementProgress(Type achievementType)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xE047A4", Offset = "0xE047A4", VA = "0xE047A4")]
	public static void UpdateUnlockedStates()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xE048F0", Offset = "0xE048F0", VA = "0xE048F0")]
	public AchievementsInfo()
	{
	}
}
[Serializable]
[Token(Token = "0x2000019")]
public class BadgesInfo
{
	[Token(Token = "0x200013E")]
	public class BadgesInfoData
	{
		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int platesBroken;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float drinkSpilled;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int fireStarted;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int toppingUsed;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int cuttedItems;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int droppedItems;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int cryCount;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int waiterHit;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int rollingCount;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int graterCount;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int carbonCount;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int iceTeaCount;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int noodleCount;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int sushiCount;

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xE083CC", Offset = "0xE083CC", VA = "0xE083CC")]
		public BadgesInfoData()
		{
		}
	}

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static BadgesInfo instance;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int platesBroken;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float drinkSpilled;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int fireStarted;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int toppingUsed;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int cuttedItems;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int droppedItems;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int cryCount;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int waiterHit;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rollingCount;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int graterCount;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int carbonCount;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int iceTeaCount;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int noodleCount;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int sushiCount;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public BadgesInfoData[] badgesInfo;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int badgesRecieved;

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xE082AC", Offset = "0xE082AC", VA = "0xE082AC")]
	public BadgesInfo()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xE083D4", Offset = "0xE083D4", VA = "0xE083D4")]
	public static BadgesInfo Instance()
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public class CameraManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27FD8", Offset = "0xD27FD8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Camera, bool> <>9__6_0;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Camera, bool> <>9__11_0;

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xE12648", Offset = "0xE12648", VA = "0xE12648")]
		public <>c()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xE12650", Offset = "0xE12650", VA = "0xE12650")]
		internal bool <Awake>b__6_0(Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0xE1267C", Offset = "0xE1267C", VA = "0xE1267C")]
		internal bool <RefreshCameras>b__11_0(Camera camera)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PlayableDirector director;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<TimelineAsset> timelines;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Camera[] cameras;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Camera hmdCamera;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int primaryMonitorCamera;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int secondaryMonitorCamera;

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xE11EF8", Offset = "0xE11EF8", VA = "0xE11EF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xE12044", Offset = "0xE12044", VA = "0xE12044")]
	protected void ActivateMonitor(int index)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xE1211C", Offset = "0xE1211C", VA = "0xE1211C", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xE123A0", Offset = "0xE123A0", VA = "0xE123A0", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xE12418", Offset = "0xE12418", VA = "0xE12418")]
	private void SwitchCameras()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xE1219C", Offset = "0xE1219C", VA = "0xE1219C")]
	private void RefreshCameras()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE12508", Offset = "0xE12508", VA = "0xE12508")]
	private void SwitchTimelines()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xE125D0", Offset = "0xE125D0", VA = "0xE125D0")]
	public CameraManager()
	{
	}
}
[Token(Token = "0x200001B")]
public class GameManager : MonoBehaviour
{
	[Token(Token = "0x2000140")]
	public enum Store
	{
		[Token(Token = "0x400075D")]
		Oculus,
		[Token(Token = "0x400075E")]
		Steam,
		[Token(Token = "0x400075F")]
		Viveport,
		[Token(Token = "0x4000760")]
		Springboard,
		[Token(Token = "0x4000761")]
		StoveVR,
		[Token(Token = "0x4000762")]
		Netvios,
		[Token(Token = "0x4000763")]
		CtrlV,
		[Token(Token = "0x4000764")]
		Pico,
		[Token(Token = "0x4000765")]
		Qiyu
	}

	[Token(Token = "0x2000141")]
	public enum StoreAndroid
	{
		[Token(Token = "0x4000767")]
		Oculus,
		[Token(Token = "0x4000768")]
		Pico,
		[Token(Token = "0x4000769")]
		Qiyu
	}

	[Token(Token = "0x2000142")]
	public enum Restaurant
	{
		[Token(Token = "0x400076B")]
		American,
		[Token(Token = "0x400076C")]
		Italian,
		[Token(Token = "0x400076D")]
		Japanese,
		[Token(Token = "0x400076E")]
		Mexican
	}

	[Token(Token = "0x2000143")]
	public enum GameState
	{
		[Token(Token = "0x4000770")]
		NONE,
		[Token(Token = "0x4000771")]
		INTRO,
		[Token(Token = "0x4000772")]
		MAIN_MENU,
		[Token(Token = "0x4000773")]
		TUTORIAL,
		[Token(Token = "0x4000774")]
		PLAYING_SINGLEPLAYER,
		[Token(Token = "0x4000775")]
		PLAYING_MULTIPLAYER_ASYNC,
		[Token(Token = "0x4000776")]
		PLAYING_MULTIPLAYER_REALTIME,
		[Token(Token = "0x4000777")]
		PLAYING_ENDLESS,
		[Token(Token = "0x4000778")]
		PLAYING_CASUAL,
		[Token(Token = "0x4000779")]
		PLAYING_DUMMY
	}

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int restaurantIndexOffset;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Restaurant restaurantSelected;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Restaurant currentRestaurant;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Store store;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] storeManagers;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AbstractPlatformManager platformManager;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameManager instance;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameState state;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public GameState nextState;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<GameObject> menuStack;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int currentLevel;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int currentLayout;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD286C8", Offset = "0xD286C8")]
	public Color highlightColor;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float hapticStrength;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float hapticDuration;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float hapticPulseInterval;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28700", Offset = "0xD28700")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28700", Offset = "0xD28700")]
	public int alertTime;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isTutorialDisabled;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float timeMultiplier;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool isSpectating;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool isLoading;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	public bool isMatchmaking;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string opponentWaiterID;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string waiterID;

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x22E87F0", Offset = "0x22E87F0", VA = "0x22E87F0", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x22E8918", Offset = "0x22E8918", VA = "0x22E8918")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x22E8988", Offset = "0x22E8988", VA = "0x22E8988")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x22E8994", Offset = "0x22E8994", VA = "0x22E8994")]
	public bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x22E89B4", Offset = "0x22E89B4", VA = "0x22E89B4")]
	public bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x22E89D4", Offset = "0x22E89D4", VA = "0x22E89D4")]
	public bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x22E89F4", Offset = "0x22E89F4", VA = "0x22E89F4", Slot = "5")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x22E8D40", Offset = "0x22E8D40", VA = "0x22E8D40")]
	public void Haptics(VRTK_ControllerReference controllerReference)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x22DBBE4", Offset = "0x22DBBE4", VA = "0x22DBBE4")]
	public void Haptics(VRTK_ControllerReference controllerReference, float duration, float pulseInterval)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x22E8D48", Offset = "0x22E8D48", VA = "0x22E8D48")]
	public void CancelHaptics(VRTK_ControllerReference controllerReference)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x22E8D54", Offset = "0x22E8D54", VA = "0x22E8D54")]
	public void PauseGame()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x22E8DD8", Offset = "0x22E8DD8", VA = "0x22E8DD8")]
	public void ResumeGame()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x22E8E10", Offset = "0x22E8E10", VA = "0x22E8E10", Slot = "6")]
	public virtual int AvatarIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x22E8E18", Offset = "0x22E8E18", VA = "0x22E8E18", Slot = "7")]
	public virtual string PlayerName()
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x22E8E60", Offset = "0x22E8E60", VA = "0x22E8E60", Slot = "8")]
	public virtual int PlayerNumber()
	{
		return default(int);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x22E8E68", Offset = "0x22E8E68", VA = "0x22E8E68", Slot = "9")]
	public virtual float PlayerHeight()
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x22E8E74", Offset = "0x22E8E74", VA = "0x22E8E74", Slot = "10")]
	public virtual bool TrackerEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x22E8E7C", Offset = "0x22E8E7C", VA = "0x22E8E7C")]
	public static string GetLocationId(int restaurant, int mode, int level)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x22E8FE0", Offset = "0x22E8FE0", VA = "0x22E8FE0")]
	public GameManager()
	{
	}
}
[Token(Token = "0x200001C")]
public class IntroController : MonoBehaviour
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material darknessMaterial;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Arrow;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform waiterPosition;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject waiter;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool ShouldStartIntro;

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xD99E1C", Offset = "0xD99E1C", VA = "0xD99E1C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xD99E20", Offset = "0xD99E20", VA = "0xD99E20")]
	public void SetupIntro()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xD99E90", Offset = "0xD99E90", VA = "0xD99E90")]
	public void StartTutorial()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xD99F90", Offset = "0xD99F90", VA = "0xD99F90")]
	private void StartLevel()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xD99F94", Offset = "0xD99F94", VA = "0xD99F94", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xD9A064", Offset = "0xD9A064", VA = "0xD9A064", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xD9A068", Offset = "0xD9A068", VA = "0xD9A068")]
	public IntroController()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class RecipeSet
{
	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RecipeDefinition recipe;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float weigth;

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x22C3740", Offset = "0x22C3740", VA = "0x22C3740")]
	public RecipeSet()
	{
	}
}
[Token(Token = "0x200001E")]
public class Level : MonoBehaviour
{
	[Token(Token = "0x2000144")]
	public enum SPEED
	{
		[Token(Token = "0x400077B")]
		SLOW,
		[Token(Token = "0x400077C")]
		MEDIUM,
		[Token(Token = "0x400077D")]
		FAST
	}

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SPEED gameSpeed;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int tutorialIndex;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RecipeSet[] recipesInLevel;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RecipeDefinition[] recipesOrder;

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xD9BA90", Offset = "0xD9BA90", VA = "0xD9BA90")]
	public RecipeInstance[] getOrders()
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xD9BC6C", Offset = "0xD9BC6C", VA = "0xD9BC6C")]
	public RecipeInstance getRandomOrder()
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xD9BD3C", Offset = "0xD9BD3C", VA = "0xD9BD3C")]
	public Level()
	{
	}
}
[Token(Token = "0x200001F")]
public class LevelManager : MonoBehaviour
{
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject recipesHolder;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Level[] levels;

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xD9BD4C", Offset = "0xD9BD4C", VA = "0xD9BD4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xD9BDAC", Offset = "0xD9BDAC", VA = "0xD9BDAC")]
	public Level GetLevel(int level)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xD9BDE8", Offset = "0xD9BDE8", VA = "0xD9BDE8")]
	public RecipeInstance[] getOrders(int level)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xD9BE28", Offset = "0xD9BE28", VA = "0xD9BE28")]
	public RecipeInstance[] getOrders(string orderSet)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xD9C2DC", Offset = "0xD9C2DC", VA = "0xD9C2DC")]
	public RecipeDefinition findRecipe(string uid)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xD9C400", Offset = "0xD9C400", VA = "0xD9C400")]
	private RecipeDefinition MakeGroupRecipe(string uid)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xD9C6A0", Offset = "0xD9C6A0", VA = "0xD9C6A0")]
	public RecipeInstance GetRandomOrder(int level)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xD9C6E0", Offset = "0xD9C6E0", VA = "0xD9C6E0")]
	public LevelManager()
	{
	}
}
[Token(Token = "0x2000020")]
public class AbstractMatchController : MonoBehaviour
{
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MatchManager matchManager;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool started;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float timePassed;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE03BAC", Offset = "0xE03BAC", VA = "0xE03BAC", Slot = "4")]
	public virtual void Run()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE03BB0", Offset = "0xE03BB0", VA = "0xE03BB0", Slot = "5")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xE03BF0", Offset = "0xE03BF0", VA = "0xE03BF0", Slot = "6")]
	public virtual void Finish()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xE03BF8", Offset = "0xE03BF8", VA = "0xE03BF8")]
	public AbstractMatchController()
	{
	}
}
[Token(Token = "0x2000021")]
public class CasualMatchController : AbstractMatchController
{
	[Token(Token = "0x6000121")]
	[Address(RVA = "0xE1308C", Offset = "0xE1308C", VA = "0xE1308C", Slot = "4")]
	public override void Run()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE13270", Offset = "0xE13270", VA = "0xE13270")]
	public CasualMatchController()
	{
	}
}
[Token(Token = "0x2000022")]
public class EndlessMatchController : AbstractMatchController
{
	[Token(Token = "0x2000145")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27FE8", Offset = "0xD27FE8")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EndlessMatchController <>4__this;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool win;

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x22E10C0", Offset = "0x22E10C0", VA = "0x22E10C0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x22E11D0", Offset = "0x22E11D0", VA = "0x22E11D0")]
		internal void <Finish>b__0(bool success)
		{
		}
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x22E0B24", Offset = "0x22E0B24", VA = "0x22E0B24", Slot = "4")]
	public override void Run()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x22E0D1C", Offset = "0x22E0D1C", VA = "0x22E0D1C", Slot = "5")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x22E0E70", Offset = "0x22E0E70", VA = "0x22E0E70", Slot = "6")]
	public override void Finish()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x22E10C8", Offset = "0x22E10C8", VA = "0x22E10C8")]
	public void ShowLeaderboardEndless(bool win)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x22E11C8", Offset = "0x22E11C8", VA = "0x22E11C8")]
	public EndlessMatchController()
	{
	}
}
[Token(Token = "0x2000023")]
public class MultiplayerAsyncMatchController : AbstractMatchController
{
	[Token(Token = "0x2000146")]
	public delegate void MultiplayerCallback();

	[Token(Token = "0x2000147")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27FF8", Offset = "0xD27FF8")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool win;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int leaderboardsPoints;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MultiplayerAsyncMatchController <>4__this;

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0xDA2E74", Offset = "0xDA2E74", VA = "0xDA2E74")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xDA40D8", Offset = "0xDA40D8", VA = "0xDA40D8")]
		internal void <Finish>b__0(bool success)
		{
		}
	}

	[Token(Token = "0x2000148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28008", Offset = "0xD28008")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MultiplayerGameData gameData;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MultiplayerAsyncMatchController <>4__this;

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xDA3514", Offset = "0xDA3514", VA = "0xDA3514")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xDA423C", Offset = "0xDA423C", VA = "0xDA423C")]
		internal void <RunMultiplayerMatch>b__1(MultiplayerGameData loadedGameData)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000149")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28018", Offset = "0xD28018")]
	private sealed class <>c
	{
		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__7_0;

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xDA3F94", Offset = "0xDA3F94", VA = "0xDA3F94")]
		public <>c()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xDA3F9C", Offset = "0xDA3F9C", VA = "0xDA3F9C")]
		internal void <RunMultiplayerMatch>b__7_0(int progress)
		{
		}
	}

	[Token(Token = "0x200014A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28028", Offset = "0xD28028")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MultiplayerCallback callback;

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xDA384C", Offset = "0xDA384C", VA = "0xDA384C")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xDA404C", Offset = "0xDA404C", VA = "0xDA404C")]
		internal void <StartMultiplayerMatch>b__0(MultiplayerGameData gameData)
		{
		}
	}

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MultiplayerGameData opponentGame;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<MatchData> matchData;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string mathcDataFilename;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xDA1C10", Offset = "0xDA1C10", VA = "0xDA1C10", Slot = "4")]
	public override void Run()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xDA279C", Offset = "0xDA279C", VA = "0xDA279C", Slot = "5")]
	public override void Update()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xDA2A4C", Offset = "0xDA2A4C", VA = "0xDA2A4C", Slot = "6")]
	public override void Finish()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xDA1D44", Offset = "0xDA1D44", VA = "0xDA1D44")]
	private void RunMultiplayerMatch()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xDA3238", Offset = "0xDA3238", VA = "0xDA3238")]
	private void UploadGame(string filename, int totalScore)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xDA2F3C", Offset = "0xDA2F3C", VA = "0xDA2F3C")]
	private string saveReplay()
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xDA3608", Offset = "0xDA3608", VA = "0xDA3608")]
	public void StartMultiplayerMatch(MultiplayerCallback callback, Action<int> progressCallback)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xDA3B0C", Offset = "0xDA3B0C", VA = "0xDA3B0C")]
	public MultiplayerAsyncMatchController()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xDA3BE4", Offset = "0xDA3BE4", VA = "0xDA3BE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD295A8", Offset = "0xD295A8")]
	private void <UploadGame>b__8_0(bool success)
	{
	}
}
[Token(Token = "0x2000024")]
public class MultiplayerMatchController : AbstractMatchController
{
	[Serializable]
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28038", Offset = "0xD28038")]
	private sealed class <>c
	{
		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<bool> <>9__7_0;

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x22A65B0", Offset = "0x22A65B0", VA = "0x22A65B0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x22A65B8", Offset = "0x22A65B8", VA = "0x22A65B8")]
		internal void <OnPhotonEvent>b__7_0(bool success)
		{
		}
	}

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool matchStarted;

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xDADC88", Offset = "0xDADC88", VA = "0xDADC88")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xDADD88", Offset = "0xDADD88", VA = "0xDADD88")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xDADE3C", Offset = "0xDADE3C", VA = "0xDADE3C")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xDADEF8", Offset = "0xDADEF8", VA = "0xDADEF8", Slot = "4")]
	public override void Run()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xDAE048", Offset = "0xDAE048", VA = "0xDAE048")]
	public void OnLevelLoadedChanged()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xDAE34C", Offset = "0xDAE34C", VA = "0xDAE34C", Slot = "5")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xDAE628", Offset = "0xDAE628", VA = "0xDAE628")]
	public void OnPhotonEvent(EventData photonEvent)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xDAECCC", Offset = "0xDAECCC", VA = "0xDAECCC")]
	private void RunRealtimeMultiplayerMatch(string orders)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xDAF238", Offset = "0xDAF238", VA = "0xDAF238")]
	private void SetOpponentName()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xDAF6C8", Offset = "0xDAF6C8", VA = "0xDAF6C8", Slot = "6")]
	public override void Finish()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xDAE11C", Offset = "0xDAE11C", VA = "0xDAE11C")]
	public void OnStartMultiplayerMatch(bool success)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xDAF9F0", Offset = "0xDAF9F0", VA = "0xDAF9F0")]
	public MultiplayerMatchController()
	{
	}
}
[Token(Token = "0x2000025")]
public class RecordingMatchController : AbstractMatchController
{
	[Token(Token = "0x200014C")]
	public delegate void MultiplayerCallback();

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MultiplayerGameData opponentGame;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<MatchData> matchData;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string mathcDataFilename;

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x22C9C30", Offset = "0x22C9C30", VA = "0x22C9C30", Slot = "4")]
	public override void Run()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x22C9D7C", Offset = "0x22C9D7C", VA = "0x22C9D7C")]
	private void RunMultiplayerMatch()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x22CA030", Offset = "0x22CA030", VA = "0x22CA030", Slot = "5")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x22CA2EC", Offset = "0x22CA2EC", VA = "0x22CA2EC", Slot = "6")]
	public override void Finish()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x22CA680", Offset = "0x22CA680", VA = "0x22CA680")]
	private void UploadGame(string filename, int totalScore)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x22CA390", Offset = "0x22CA390", VA = "0x22CA390")]
	private string saveReplay()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x22CA83C", Offset = "0x22CA83C", VA = "0x22CA83C")]
	public RecordingMatchController()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x22CA914", Offset = "0x22CA914", VA = "0x22CA914")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD295B8", Offset = "0xD295B8")]
	private void <UploadGame>b__8_0(bool success)
	{
	}
}
[Token(Token = "0x2000026")]
public class SingleMatchController : AbstractMatchController
{
	[Token(Token = "0x200014D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28048", Offset = "0xD28048")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SingleMatchController <>4__this;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool win;

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x22F41B4", Offset = "0x22F41B4", VA = "0x22F41B4")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x22F42C4", Offset = "0x22F42C4", VA = "0x22F42C4")]
		internal void <Finish>b__0(bool success)
		{
		}
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x22F3A24", Offset = "0x22F3A24", VA = "0x22F3A24", Slot = "4")]
	public override void Run()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x22F3C54", Offset = "0x22F3C54", VA = "0x22F3C54")]
	public void ShowTutorialView()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x22F3D18", Offset = "0x22F3D18", VA = "0x22F3D18", Slot = "5")]
	public override void Update()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x22F3E6C", Offset = "0x22F3E6C", VA = "0x22F3E6C", Slot = "6")]
	public override void Finish()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x22F41BC", Offset = "0x22F41BC", VA = "0x22F41BC")]
	public void ShowLeaderboardSinglePlayer(bool win)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x22F42BC", Offset = "0x22F42BC", VA = "0x22F42BC")]
	public SingleMatchController()
	{
	}
}
[Token(Token = "0x2000027")]
public class MatchManager : MonoBehaviour
{
	[Token(Token = "0x200014E")]
	public enum CardLayout
	{
		[Token(Token = "0x400078D")]
		Vertical,
		[Token(Token = "0x400078E")]
		Horizontal
	}

	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28058", Offset = "0xD28058")]
	private sealed class <LoadAsynchronously>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sceneIndex;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0xDA1200", Offset = "0xDA1200", VA = "0xDA1200", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0xDA1268", Offset = "0xDA1268", VA = "0xDA1268", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xDA0F3C", Offset = "0xDA0F3C", VA = "0xDA0F3C")]
		[DebuggerHidden]
		public <LoadAsynchronously>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xDA0FE4", Offset = "0xDA0FE4", VA = "0xDA0FE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xDA0FE8", Offset = "0xDA0FE8", VA = "0xDA0FE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xDA1208", Offset = "0xDA1208", VA = "0xDA1208", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MatchManager instance;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LevelPanelController levelPanel;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CustomerManager[] customerManagers;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int currentCustomerManager;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject spawner;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CardLayout cardLayout;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LevelManager levelManager;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public List<RecipeInstance> ordersPlayer;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public int currentOrderSet;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28780", Offset = "0xD28780")]
	public float[] customerDelays;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD287B8", Offset = "0xD287B8")]
	public TextMeshPro playerNameText;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshPro opponentNameText;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ReplayManager replayManager;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject removableTables;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD287F0", Offset = "0xD287F0")]
	public CloneManager cloneManager;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28828", Offset = "0xD28828")]
	public TextMeshPro[] timeLeftTexts;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public string opponentId;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public string opponentName;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28880", Offset = "0xD28880")]
	public ObjectPool objectPool;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject[] instructionPanels;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD288B8", Offset = "0xD288B8")]
	public AbstractMatchController matchController;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int numOrders;

	[Token(Token = "0x17000004")]
	public bool started
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xD9FBC0", Offset = "0xD9FBC0", VA = "0xD9FBC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xD9FC54", Offset = "0xD9FC54", VA = "0xD9FC54")]
	public int GetCurrentLevel()
	{
		return default(int);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xD9FC60", Offset = "0xD9FC60", VA = "0xD9FC60")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xD9FE30", Offset = "0xD9FE30", VA = "0xD9FE30", Slot = "4")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xDA06E8", Offset = "0xDA06E8", VA = "0xDA06E8")]
	public void ChangeState(GameManager.GameState state)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xDA0838", Offset = "0xDA0838", VA = "0xDA0838")]
	public string GetOrderSet()
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xDA093C", Offset = "0xDA093C", VA = "0xDA093C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xDA0940", Offset = "0xDA0940", VA = "0xDA0940")]
	public void DebugFinishGame()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xDA0370", Offset = "0xDA0370", VA = "0xDA0370")]
	public void SetUIManagerPosition()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xDA09D8", Offset = "0xDA09D8", VA = "0xDA09D8")]
	public void HideWaiterOnPlayerLeft()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xDA0A5C", Offset = "0xDA0A5C", VA = "0xDA0A5C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xDA0AF8", Offset = "0xDA0AF8", VA = "0xDA0AF8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xDA0B94", Offset = "0xDA0B94", VA = "0xDA0B94", Slot = "5")]
	public virtual void StartOrder()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xDA0594", Offset = "0xDA0594", VA = "0xDA0594")]
	public void InstructionPanelsControl()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xD9EB0C", Offset = "0xD9EB0C", VA = "0xD9EB0C")]
	public void SetActiveOpponentsObj()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xDA0C44", Offset = "0xDA0C44", VA = "0xDA0C44")]
	public void LoadScene(int sceneIndex)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xDA0E80", Offset = "0xDA0E80", VA = "0xDA0E80")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xDA0E10", Offset = "0xDA0E10", VA = "0xDA0E10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD295C8", Offset = "0xD295C8")]
	private IEnumerator LoadAsynchronously(int sceneIndex)
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xDA0618", Offset = "0xDA0618", VA = "0xDA0618")]
	public void SetAllSlidersMaxValue(int maxValue)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xDA0F68", Offset = "0xDA0F68", VA = "0xDA0F68")]
	public MatchManager()
	{
	}
}
[Token(Token = "0x2000028")]
public class OptionsManager : MonoBehaviour
{
	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isRestart;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool isBack;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x22B3C20", Offset = "0x22B3C20", VA = "0x22B3C20")]
	public void ToggleMusic()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x22B3CF8", Offset = "0x22B3CF8", VA = "0x22B3CF8")]
	public void ToggleEffects()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x22B3DD0", Offset = "0x22B3DD0", VA = "0x22B3DD0")]
	public void ToggleHandle()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x22B3E74", Offset = "0x22B3E74", VA = "0x22B3E74")]
	public void ToggleVibration()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x22B3F04", Offset = "0x22B3F04", VA = "0x22B3F04")]
	public void Restart()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x22B3FE8", Offset = "0x22B3FE8", VA = "0x22B3FE8")]
	public void BackToMainMenu()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x22B422C", Offset = "0x22B422C", VA = "0x22B422C")]
	public void PlayNextLevel()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x22B42F0", Offset = "0x22B42F0", VA = "0x22B42F0")]
	public void OpenTutorialMenu()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x22B4378", Offset = "0x22B4378", VA = "0x22B4378")]
	public void OpenWaiterCustomizationMenu()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x22B4400", Offset = "0x22B4400", VA = "0x22B4400")]
	public OptionsManager()
	{
	}
}
[Token(Token = "0x2000029")]
public class ScoringSystem : MonoBehaviour
{
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x22D5E68", Offset = "0x22D5E68", VA = "0x22D5E68")]
	public float GetScoreMultiplier(float time, float totalTimeToDeliver)
	{
		return default(float);
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x22D5E88", Offset = "0x22D5E88", VA = "0x22D5E88")]
	public ScoringSystem()
	{
	}
}
[Token(Token = "0x200002A")]
public class Survival : MonoBehaviour
{
	[Token(Token = "0x2000150")]
	public enum SPEED
	{
		[Token(Token = "0x4000793")]
		SLOW,
		[Token(Token = "0x4000794")]
		MEDIUM,
		[Token(Token = "0x4000795")]
		FAST
	}

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float[] StarsTime;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SPEED gameSpeed;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RecipeSet[] recipesInLevel;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RecipeDefinition[] recipesOrder;

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x23034AC", Offset = "0x23034AC", VA = "0x23034AC")]
	private void Start()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x23034B0", Offset = "0x23034B0", VA = "0x23034B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x23034B4", Offset = "0x23034B4", VA = "0x23034B4")]
	public RecipeInstance[] getOrders()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x2303614", Offset = "0x2303614", VA = "0x2303614")]
	public Survival()
	{
	}
}
[Token(Token = "0x200002B")]
public class VoiceSettings : MonoBehaviour
{
	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static VoiceSettings instance;

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1065BD4", Offset = "0x1065BD4", VA = "0x1065BD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1065C2C", Offset = "0x1065C2C", VA = "0x1065C2C")]
	public void SettingsOnStart()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1065CCC", Offset = "0x1065CCC", VA = "0x1065CCC")]
	public void DisableMicOnPermissionDenied()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1065D30", Offset = "0x1065D30", VA = "0x1065D30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1065D34", Offset = "0x1065D34", VA = "0x1065D34")]
	public void ToggleMic()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1065E08", Offset = "0x1065E08", VA = "0x1065E08")]
	public void ToggleSpeaker()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1065ECC", Offset = "0x1065ECC", VA = "0x1065ECC")]
	public VoiceSettings()
	{
	}
}
[Token(Token = "0x200002C")]
public class GongContoller : MonoBehaviourPun
{
	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource audioSource;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AvatarGroup waiter;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isActiveSound;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VRTK_ControllerReference controllerReference;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Collision collisonObject;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool shouldActivateOnCollison;

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x22E9404", Offset = "0x22E9404", VA = "0x22E9404")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x22E94B8", Offset = "0x22E94B8", VA = "0x22E94B8")]
	public void ActivateSound()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x22E9680", Offset = "0x22E9680", VA = "0x22E9680")]
	public void GongSound()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x22E973C", Offset = "0x22E973C", VA = "0x22E973C")]
	[PunRPC]
	public void GongSoundRPC()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x22E97A0", Offset = "0x22E97A0", VA = "0x22E97A0")]
	public void DeactivateGongSound()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x22E97A8", Offset = "0x22E97A8", VA = "0x22E97A8")]
	public GongContoller()
	{
	}
}
[Token(Token = "0x200002D")]
public class BottleController : MonoBehaviour
{
	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool sprayUpsideDown;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28900", Offset = "0xD28900")]
	public Texture splashTexture;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28938", Offset = "0xD28938")]
	public IngredientState.ToppingState toppingState;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem particles;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem squeezeParicles;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioSource sound;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float SpillingDelay;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float SpillingAngle;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 centerOfMass;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool isSpilling;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isDownward;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool isSquized;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float timeDownward;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool isItemGrabbed;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private PhotonView photonView;

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xE0A7C0", Offset = "0xE0A7C0", VA = "0xE0A7C0")]
	private void Start()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xE0AA30", Offset = "0xE0AA30", VA = "0xE0AA30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xE0AE40", Offset = "0xE0AE40", VA = "0xE0AE40")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xE0B0C4", Offset = "0xE0B0C4", VA = "0xE0B0C4")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xE0B1CC", Offset = "0xE0B1CC", VA = "0xE0B1CC")]
	public void StartSquish()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xE0AF4C", Offset = "0xE0AF4C", VA = "0xE0AF4C")]
	public void StopSquish()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xE0ACF8", Offset = "0xE0ACF8", VA = "0xE0ACF8")]
	[PunRPC]
	public void DoSpill(bool spill)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xE0B354", Offset = "0xE0B354", VA = "0xE0B354")]
	public void SetItemGrabbed()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xE0B3DC", Offset = "0xE0B3DC", VA = "0xE0B3DC")]
	public void StopParticlesIfConnectoinIsLost()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xE0B46C", Offset = "0xE0B46C", VA = "0xE0B46C")]
	public void OnSqueeze()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xE0B488", Offset = "0xE0B488", VA = "0xE0B488")]
	public BottleController()
	{
	}
}
[Token(Token = "0x200002E")]
public class BreakableController : MonoBehaviourPun
{
	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minVelocity;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject breakableObject;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool broken;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject brokenObject;

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xE0B8E4", Offset = "0xE0B8E4", VA = "0xE0B8E4")]
	private void Start()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xE0B8E8", Offset = "0xE0B8E8", VA = "0xE0B8E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xE0B8EC", Offset = "0xE0B8EC", VA = "0xE0B8EC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xE0BDE8", Offset = "0xE0BDE8", VA = "0xE0BDE8")]
	[PunRPC]
	public void BrakePlateRPC(int photonID)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xE0BB58", Offset = "0xE0BB58", VA = "0xE0BB58")]
	public void BrakePlate()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xE0BED0", Offset = "0xE0BED0", VA = "0xE0BED0")]
	public void DoAction()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xE0C080", Offset = "0xE0C080", VA = "0xE0C080")]
	public void DoActionReplay()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xE0C1B0", Offset = "0xE0C1B0", VA = "0xE0C1B0")]
	private void OnCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xE0C1B4", Offset = "0xE0C1B4", VA = "0xE0C1B4")]
	public BreakableController()
	{
	}
}
[Token(Token = "0x200002F")]
public class BrokenController : MonoBehaviourPun
{
	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timer;

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xE0C1C4", Offset = "0xE0C1C4", VA = "0xE0C1C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xE0C244", Offset = "0xE0C244", VA = "0xE0C244")]
	private void Update()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xE0C35C", Offset = "0xE0C35C", VA = "0xE0C35C")]
	public BrokenController()
	{
	}
}
[Token(Token = "0x2000030")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD27DA4", Offset = "0xD27DA4")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD27DA4", Offset = "0xD27DA4")]
public class BurnController : MonoBehaviour
{
	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture burnedTexture;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float burningTime;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public IngredientState.State burningState;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource burningSound;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem smokeParticles;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isBurned;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public IngredientState stateComponent;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UnityEvent OnBurnedEvent;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected PhotonView photonView;

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xE0D6E4", Offset = "0xE0D6E4", VA = "0xE0D6E4")]
	public bool IsBurning()
	{
		return default(bool);
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xE0D744", Offset = "0xE0D744", VA = "0xE0D744")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xE0D7F4", Offset = "0xE0D7F4", VA = "0xE0D7F4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xE0D7F8", Offset = "0xE0D7F8", VA = "0xE0D7F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xE0D890", Offset = "0xE0D890", VA = "0xE0D890", Slot = "4")]
	protected virtual void UpdateStates()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xE0DB78", Offset = "0xE0DB78", VA = "0xE0DB78")]
	public void StopCookedParticles()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xE0DBE8", Offset = "0xE0DBE8", VA = "0xE0DBE8")]
	public void PlayCookedParticles()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xE0DC04", Offset = "0xE0DC04", VA = "0xE0DC04")]
	public void RevertBurning()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xE0DCA8", Offset = "0xE0DCA8", VA = "0xE0DCA8")]
	public void RevertBurningDelayed()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xE0DD5C", Offset = "0xE0DD5C", VA = "0xE0DD5C")]
	public void RevertState()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xE0DD78", Offset = "0xE0DD78", VA = "0xE0DD78")]
	public void SetFire()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xE0DE80", Offset = "0xE0DE80", VA = "0xE0DE80")]
	public void StopSmokeParticles()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xE0DEFC", Offset = "0xE0DEFC", VA = "0xE0DEFC")]
	public void CookBurgerCount()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xE0DF5C", Offset = "0xE0DF5C", VA = "0xE0DF5C")]
	public void InvokeStopSound()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xE0DFB4", Offset = "0xE0DFB4", VA = "0xE0DFB4")]
	public void StopBurnedSound()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xE0E054", Offset = "0xE0E054", VA = "0xE0E054")]
	public BurnController()
	{
	}
}
[Token(Token = "0x2000031")]
public class BurnControllerHelper : MonoBehaviourPun, IPunObservable, IRecordingSerializable
{
	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isBurning;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float heatTotal;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject heatingSurface;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isRawStopped;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isCookedStopped;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float previousHeatTotal;

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xE0E068", Offset = "0xE0E068", VA = "0xE0E068")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xE0E06C", Offset = "0xE0E06C", VA = "0xE0E06C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xE0E2A4", Offset = "0xE0E2A4", VA = "0xE0E2A4")]
	public void DisableParticlesOnChangeState()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xE0EC48", Offset = "0xE0EC48", VA = "0xE0EC48")]
	[PunRPC]
	public void StopCookParticlesRPC(int burningState)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xE0EC14", Offset = "0xE0EC14", VA = "0xE0EC14")]
	[PunRPC]
	public void StopRawParticlesRPC(int burningState)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xE0EC7C", Offset = "0xE0EC7C", VA = "0xE0EC7C")]
	[PunRPC]
	public void StartCookParticlesRPC(int burningState)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xE0ECBC", Offset = "0xE0ECBC", VA = "0xE0ECBC")]
	[PunRPC]
	public void StartBurnedParticlesRPC(int burningState)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xE0EB5C", Offset = "0xE0EB5C", VA = "0xE0EB5C")]
	public BurnController GetBurnController(IngredientState.State burningState)
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xE0E828", Offset = "0xE0E828", VA = "0xE0E828")]
	public void SetBurning(bool burning, [Optional] GameObject heatingSurface)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xE0F158", Offset = "0xE0F158", VA = "0xE0F158")]
	[PunRPC]
	public void StartBurningRPC(bool burning, int burningState, int heatingSurfaceId)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xE0ECFC", Offset = "0xE0ECFC", VA = "0xE0ECFC")]
	public void StartBurning(bool burning, int burningState, GameObject heatingSurface)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xE0F22C", Offset = "0xE0F22C", VA = "0xE0F22C")]
	public void ReplayBurnParticles(bool enabled, int state)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xE0DA44", Offset = "0xE0DA44", VA = "0xE0DA44")]
	[PunRPC]
	public void DoBurn(int burningState)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xE0F32C", Offset = "0xE0F32C", VA = "0xE0F32C", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xE0F3F8", Offset = "0xE0F3F8", VA = "0xE0F3F8", Slot = "5")]
	public string SerializeWrite()
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xE0F47C", Offset = "0xE0F47C", VA = "0xE0F47C", Slot = "6")]
	public void SerializeRead(params string[] objects)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xE0F4C4", Offset = "0xE0F4C4", VA = "0xE0F4C4")]
	public void StopSmokeparticles()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xE0F520", Offset = "0xE0F520", VA = "0xE0F520")]
	public BurnControllerHelper()
	{
	}
}
[Token(Token = "0x2000032")]
public class CupLiquid : MonoBehaviourPun, IPunObservable, IRecordingSerializable
{
	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject liquidParent;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cupParentCollider;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject squezzeParentCollider;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem spillingParticlesFull;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem spillingParticles;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem TeaHotParticles;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem squeezeParicles;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioSource spillingSound;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform topPosition;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform bottomPosition;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject cupMesh;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float speed;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Color? pouringLiquid;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float sloshIncrement;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD28970", Offset = "0xD28970")]
	public float currentFill;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int spillsPosition;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform[] spillingPoints;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float sloshSpeed;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Vector3 rigScaleMin;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 rigScaleMax;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Color currentColor;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private bool startSpill;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
	public bool isSqueeze;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float spillingFill;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Color baseColor;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float fillTimer;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool isFull;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
	public bool shouldStick;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
	private bool liquidLevelBelow;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF3")]
	public bool isHotCurrentTea;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float coolingTime;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public string snappedFruit;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool hasFruit;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
	public bool isGoodRotation;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private float previouscurrentFill;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool shouldSpill;

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xE17AA0", Offset = "0xE17AA0", VA = "0xE17AA0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xE18B84", Offset = "0xE18B84", VA = "0xE18B84", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xE18E20", Offset = "0xE18E20", VA = "0xE18E20", Slot = "5")]
	public string SerializeWrite()
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xE19150", Offset = "0xE19150", VA = "0xE19150", Slot = "6")]
	public void SerializeRead(params string[] objects)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xE17D6C", Offset = "0xE17D6C", VA = "0xE17D6C")]
	private void Slosh()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xE17FF8", Offset = "0xE17FF8", VA = "0xE17FF8")]
	public void LevelLiquid()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xE18438", Offset = "0xE18438", VA = "0xE18438")]
	private float SpillingCheck()
	{
		return default(float);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xE1920C", Offset = "0xE1920C", VA = "0xE1920C")]
	public void ParticlesPlayReplay(bool spill, float r, float g, float b, float a, float fill)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xE189B0", Offset = "0xE189B0", VA = "0xE189B0")]
	private bool DoFill()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xE19244", Offset = "0xE19244", VA = "0xE19244")]
	public void SetFill(Color color)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xE192EC", Offset = "0xE192EC", VA = "0xE192EC")]
	public void IsHotTea(bool isHot)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xE188D0", Offset = "0xE188D0", VA = "0xE188D0")]
	public void StopTeaHotParticles()
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xE193FC", Offset = "0xE193FC", VA = "0xE193FC")]
	[PunRPC]
	public void PlayTeaHotParticles()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xE19418", Offset = "0xE19418", VA = "0xE19418")]
	[PunRPC]
	public void StopTeaHotParticle()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xE19458", Offset = "0xE19458", VA = "0xE19458")]
	public void OnSqueeze()
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xE196C4", Offset = "0xE196C4", VA = "0xE196C4")]
	public CupLiquid()
	{
	}
}
[Token(Token = "0x2000033")]
public class CuttableController : MonoBehaviour, ICuttable
{
	[Token(Token = "0x2000151")]
	public enum Axis
	{
		[Token(Token = "0x4000797")]
		x,
		[Token(Token = "0x4000798")]
		y,
		[Token(Token = "0x4000799")]
		z
	}

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Axis axis;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject cutCup;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject slicePrefab;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject spawnPoint;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _cuttablePoint;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioSource audioCut;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject wholeObjectCollider;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public BoxCollider triggerCollider;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float cutOffValue;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float wholeCutOffValue;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int numOfSlices;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float startMaskValue;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float endMaskValue;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject wholeCuttableObject;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject cuttingTutorial;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Vector3 rotationOffset;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float maskIncrement;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float moveIncrement;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private Vector3 startScale;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 startMeshScale;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public int cutIndex;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float scaleIncrement;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float meshDecrementX;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float meshDecrementZ;

	[Token(Token = "0x17000005")]
	public GameObject cuttablePoint
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x22D9FE8", Offset = "0x22D9FE8", VA = "0x22D9FE8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x22D9FF0", Offset = "0x22D9FF0", VA = "0x22D9FF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x22DA138", Offset = "0x22DA138", VA = "0x22DA138")]
	private void Update()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x22DA348", Offset = "0x22DA348", VA = "0x22DA348")]
	public void SpawnSlice()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x22DA4FC", Offset = "0x22DA4FC", VA = "0x22DA4FC")]
	public void ShrinkCuttable()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x22DAFD8", Offset = "0x22DAFD8", VA = "0x22DAFD8")]
	public void SetCutOffValue()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x22DA198", Offset = "0x22DA198", VA = "0x22DA198", Slot = "5")]
	public void Cut()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x22DB068", Offset = "0x22DB068", VA = "0x22DB068")]
	[PunRPC]
	public void CutNetwork()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x22DB06C", Offset = "0x22DB06C", VA = "0x22DB06C")]
	public CuttableController()
	{
	}
}
[Token(Token = "0x2000034")]
public class CuttingController : MonoBehaviour
{
	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float stickMinSpeed;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject cutPointFirst;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cutPointSec;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isItemGrabbed;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject cuttablePoint;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool bladeDown;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject grabObject;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject grabObjectOculus;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject grabObjectOculusRight;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject grabObjectOculusLeft;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float bladeDownOffset;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private VRTK_ControllerReference controllerReference;

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x22DB074", Offset = "0x22DB074", VA = "0x22DB074")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x22DB254", Offset = "0x22DB254", VA = "0x22DB254")]
	public void SetGrabHandTrackingPoint()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x22DB368", Offset = "0x22DB368", VA = "0x22DB368")]
	public void SetGrabControllersPoint()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x22DB47C", Offset = "0x22DB47C", VA = "0x22DB47C")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x22DB5BC", Offset = "0x22DB5BC", VA = "0x22DB5BC")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x22DB5CC", Offset = "0x22DB5CC", VA = "0x22DB5CC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x22DBCA0", Offset = "0x22DBCA0", VA = "0x22DBCA0")]
	public CuttingController()
	{
	}
}
[Token(Token = "0x2000035")]
public class DestroyFries : MonoBehaviour
{
	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string fry;

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x22DEB7C", Offset = "0x22DEB7C", VA = "0x22DEB7C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x22DEB80", Offset = "0x22DEB80", VA = "0x22DEB80")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x22DEB84", Offset = "0x22DEB84", VA = "0x22DEB84")]
	private void Destroy()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x22DEB88", Offset = "0x22DEB88", VA = "0x22DEB88")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x22DEC54", Offset = "0x22DEC54", VA = "0x22DEC54")]
	public DestroyFries()
	{
	}
}
[Token(Token = "0x2000036")]
public class FrenchFriesController : MonoBehaviour
{
	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isCompleted;

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x22E4360", Offset = "0x22E4360", VA = "0x22E4360")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x22E4364", Offset = "0x22E4364", VA = "0x22E4364")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x22E4368", Offset = "0x22E4368", VA = "0x22E4368")]
	public FrenchFriesController()
	{
	}
}
[Token(Token = "0x2000037")]
public class FriesNetHelper : MonoBehaviour
{
	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject friesNet;

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x22E45C8", Offset = "0x22E45C8", VA = "0x22E45C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x22E45CC", Offset = "0x22E45CC", VA = "0x22E45CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x22E45D0", Offset = "0x22E45D0", VA = "0x22E45D0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x22E4694", Offset = "0x22E4694", VA = "0x22E4694")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x22E4814", Offset = "0x22E4814", VA = "0x22E4814")]
	public FriesNetHelper()
	{
	}
}
[Token(Token = "0x2000038")]
public class FrozenFriesController : MonoBehaviour
{
	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject friesPrefab;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float spawnRate;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float lastSpawn;

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x22E583C", Offset = "0x22E583C", VA = "0x22E583C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x22E5840", Offset = "0x22E5840", VA = "0x22E5840")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x22E5A90", Offset = "0x22E5A90", VA = "0x22E5A90")]
	public FrozenFriesController()
	{
	}
}
[Token(Token = "0x2000039")]
public class FryController : MonoBehaviour
{
	[Token(Token = "0x2000152")]
	private enum FRY_STATE
	{
		[Token(Token = "0x400079B")]
		RAW,
		[Token(Token = "0x400079C")]
		COOKED,
		[Token(Token = "0x400079D")]
		BURNED,
		[Token(Token = "0x400079E")]
		ROTTEN
	}

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MaterialStates materialStates;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fryDoneTime;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float fryBurnedTime;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fryRottenTime;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string panObjectTag;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isFryInPan;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float cookingTime;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float rottingTime;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private FRY_STATE state;

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x22E6988", Offset = "0x22E6988", VA = "0x22E6988")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x22E69E8", Offset = "0x22E69E8", VA = "0x22E69E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x22E6A0C", Offset = "0x22E6A0C", VA = "0x22E6A0C")]
	private void UpdateStates()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x22E6AB0", Offset = "0x22E6AB0", VA = "0x22E6AB0")]
	private void UpdateGraphics()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x22E6AD4", Offset = "0x22E6AD4", VA = "0x22E6AD4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x22E6B2C", Offset = "0x22E6B2C", VA = "0x22E6B2C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x22E6B80", Offset = "0x22E6B80", VA = "0x22E6B80")]
	public FryController()
	{
	}
}
[Token(Token = "0x200003A")]
public class FryDryerController : MonoBehaviour
{
	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject fryPackObject;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject panFriesObject;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioSource fryPackSound;

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x22E6B9C", Offset = "0x22E6B9C", VA = "0x22E6B9C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x22E6BA0", Offset = "0x22E6BA0", VA = "0x22E6BA0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x22E6BA4", Offset = "0x22E6BA4", VA = "0x22E6BA4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x22E6EAC", Offset = "0x22E6EAC", VA = "0x22E6EAC")]
	private void ShowFullPack()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x22E7048", Offset = "0x22E7048", VA = "0x22E7048")]
	public FryDryerController()
	{
	}
}
[Token(Token = "0x200003B")]
public class FryPanFryController : MonoBehaviour
{
	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject activeWholeFryObject;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject wholeFryObjectPrefab;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject friesNetSpawnPostion;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int fryCount;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<GameObject> fries;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 startPosition;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool shouldFixPostion;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 startRotation;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool isItemGrabbed;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject instanceObject;

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x22E7050", Offset = "0x22E7050", VA = "0x22E7050")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x22E71F8", Offset = "0x22E71F8", VA = "0x22E71F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x22E71FC", Offset = "0x22E71FC", VA = "0x22E71FC")]
	private void UpdatePostion()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x22E73A4", Offset = "0x22E73A4", VA = "0x22E73A4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x22E7784", Offset = "0x22E7784", VA = "0x22E7784")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x22E78E8", Offset = "0x22E78E8", VA = "0x22E78E8")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x22E78F0", Offset = "0x22E78F0", VA = "0x22E78F0")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x22E78FC", Offset = "0x22E78FC", VA = "0x22E78FC")]
	public FryPanFryController()
	{
	}
}
[Token(Token = "0x200003C")]
public class SauceController : MonoBehaviour
{
	[Token(Token = "0x2000153")]
	public enum State
	{
		[Token(Token = "0x40007A0")]
		NONE,
		[Token(Token = "0x40007A1")]
		KETCHUP,
		[Token(Token = "0x40007A2")]
		MUSTARD
	}

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ketchupParticlesName;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string mustardParticlesName;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture[] ketchupRawList;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture[] ketchupCookedList;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture[] ketchupBurnedList;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture[] ketchupRottenList;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture[] mustarRawList;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture[] mustarCookedList;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture[] mustarBurnedList;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Texture[] mustarRottenList;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Renderer meshRenderer;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public State state;

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x22D54D4", Offset = "0x22D54D4", VA = "0x22D54D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x22D554C", Offset = "0x22D554C", VA = "0x22D554C")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x22D55BC", Offset = "0x22D55BC", VA = "0x22D55BC")]
	private void MeatTextureChanger(string particleType)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x22D5894", Offset = "0x22D5894", VA = "0x22D5894")]
	private void ObjectTextureChanger(string particleType)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x22D59DC", Offset = "0x22D59DC", VA = "0x22D59DC")]
	public SauceController()
	{
	}
}
[Token(Token = "0x200003D")]
public class DetachableController : MonoBehaviourPun, ICuttable
{
	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public GameObject _cuttablePoint;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int markerIndex;

	[Token(Token = "0x17000006")]
	public GameObject cuttablePoint
	{
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x22DEE48", Offset = "0x22DEE48", VA = "0x22DEE48", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x22DEE50", Offset = "0x22DEE50", VA = "0x22DEE50", Slot = "5")]
	public void Cut()
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x22DEF58", Offset = "0x22DEF58", VA = "0x22DEF58")]
	[PunRPC]
	public void DetachSliceRPC()
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x22DEFBC", Offset = "0x22DEFBC", VA = "0x22DEFBC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x22DEFF8", Offset = "0x22DEFF8", VA = "0x22DEFF8")]
	public DetachableController()
	{
	}
}
[Token(Token = "0x200003E")]
public class FilteredBurn : BurnController
{
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string heatingSufaceTag;

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x22E36CC", Offset = "0x22E36CC", VA = "0x22E36CC", Slot = "4")]
	protected override void UpdateStates()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x22E37B4", Offset = "0x22E37B4", VA = "0x22E37B4")]
	public FilteredBurn()
	{
	}
}
[Token(Token = "0x200003F")]
public class FireController : BurnController
{
	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject fireParticles;

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x22E37BC", Offset = "0x22E37BC", VA = "0x22E37BC")]
	public void ExtinguishFire()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x22E3864", Offset = "0x22E3864", VA = "0x22E3864")]
	[PunRPC]
	public void ExtinguishFireRPC()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x22E3928", Offset = "0x22E3928", VA = "0x22E3928")]
	public void RevertBurn()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x22E39B4", Offset = "0x22E39B4", VA = "0x22E39B4")]
	[PunRPC]
	public void RevertBurnRPC()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x22E3ACC", Offset = "0x22E3ACC", VA = "0x22E3ACC")]
	public FireController()
	{
	}
}
[Token(Token = "0x2000040")]
public class FriesDestroyer : MonoBehaviour
{
	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string tagToDestroy;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeToDestroy;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FryerNetController fryNet;

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x22E4450", Offset = "0x22E4450", VA = "0x22E4450")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x22E455C", Offset = "0x22E455C", VA = "0x22E455C")]
	public void PreDestroy(GameObject gameObject)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x22E4560", Offset = "0x22E4560", VA = "0x22E4560")]
	public FriesDestroyer()
	{
	}
}
[Token(Token = "0x2000041")]
public class FriesPackController : MonoBehaviourPun
{
	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem fryParticles;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource spillingSound;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isItemGrabbed;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 centerOfMass;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isSpilling;

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x22E481C", Offset = "0x22E481C", VA = "0x22E481C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x22E49EC", Offset = "0x22E49EC", VA = "0x22E49EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x22E4E20", Offset = "0x22E4E20", VA = "0x22E4E20")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x22E4E28", Offset = "0x22E4E28", VA = "0x22E4E28")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x22E4C88", Offset = "0x22E4C88", VA = "0x22E4C88")]
	[PunRPC]
	public void DoSpillFries(bool spill)
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x22E4E34", Offset = "0x22E4E34", VA = "0x22E4E34")]
	public void StopParticlesIfConnectoinIsLost()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x22E4E90", Offset = "0x22E4E90", VA = "0x22E4E90")]
	public FriesPackController()
	{
	}
}
[Token(Token = "0x2000042")]
public class FriesPickController : MonoBehaviourPun
{
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject friesCutOut;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float cutOffValue;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool isFull;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource friesPick;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool canCollect;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool bottomTrigger;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	private bool topTrigger;

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x22E4E98", Offset = "0x22E4E98", VA = "0x22E4E98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x22E4E9C", Offset = "0x22E4E9C", VA = "0x22E4E9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x22E4EA0", Offset = "0x22E4EA0", VA = "0x22E4EA0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x22E4EA4", Offset = "0x22E4EA4", VA = "0x22E4EA4")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x22E527C", Offset = "0x22E527C", VA = "0x22E527C")]
	public void BottomTrigger(bool state)
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x22E5288", Offset = "0x22E5288", VA = "0x22E5288")]
	public void TopTrigger(bool state)
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x22E5294", Offset = "0x22E5294", VA = "0x22E5294")]
	public void FillFriesPack()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x22E51C0", Offset = "0x22E51C0", VA = "0x22E51C0")]
	[PunRPC]
	public void FillFriesPackRPC()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x22E53D8", Offset = "0x22E53D8", VA = "0x22E53D8")]
	public FriesPickController()
	{
	}
}
[Token(Token = "0x2000043")]
public class FryerNetController : MonoBehaviourPun, IPunObservable
{
	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] friesStack;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] spillPoints;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isDownward;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isSpilling;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool canFill;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float fill;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD289A8", Offset = "0xD289A8")]
	public int fillAmount;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool isFull;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool hasFilling;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float fillingSpeed;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float spillingSpeed;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem particles;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem particlesInside;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioSource spillingFriesSound;

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x22E7978", Offset = "0x22E7978", VA = "0x22E7978")]
	private void Start()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x22E7998", Offset = "0x22E7998", VA = "0x22E7998")]
	private void Update()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x22E80EC", Offset = "0x22E80EC", VA = "0x22E80EC")]
	public void Fill()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x22E8480", Offset = "0x22E8480", VA = "0x22E8480", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x22E8300", Offset = "0x22E8300", VA = "0x22E8300")]
	[PunRPC]
	public void UpdateFriesNetGraphics(int spilling, float tFill)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x22E7EBC", Offset = "0x22E7EBC", VA = "0x22E7EBC")]
	public void Spilling()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x22E854C", Offset = "0x22E854C", VA = "0x22E854C")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x22E7C58", Offset = "0x22E7C58", VA = "0x22E7C58")]
	[PunRPC]
	public void DoSpillFriesNet(bool spill)
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x22E866C", Offset = "0x22E866C", VA = "0x22E866C")]
	public void SetParticlesTexture()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x22E87E0", Offset = "0x22E87E0", VA = "0x22E87E0")]
	public FryerNetController()
	{
	}
}
[Token(Token = "0x2000044")]
public class HeatingSurfaceController : MonoBehaviourPun
{
	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VRTK_ControllerReference controllerReference;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float heatingStrength;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem cookSmoke;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource cookSound;

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x22ECFE8", Offset = "0x22ECFE8", VA = "0x22ECFE8")]
	public void StartCookingSmoke()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x22ED088", Offset = "0x22ED088", VA = "0x22ED088")]
	[PunRPC]
	public void StartCookingSmokeRPC()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x22ED17C", Offset = "0x22ED17C", VA = "0x22ED17C")]
	public void StopCookingSmoke()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x22ED21C", Offset = "0x22ED21C", VA = "0x22ED21C")]
	[PunRPC]
	public void StopCookingSmokeRPC()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x22ED310", Offset = "0x22ED310", VA = "0x22ED310")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x22ED59C", Offset = "0x22ED59C", VA = "0x22ED59C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x22ED81C", Offset = "0x22ED81C", VA = "0x22ED81C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x22ED890", Offset = "0x22ED890", VA = "0x22ED890")]
	public HeatingSurfaceController()
	{
	}
}
[Token(Token = "0x2000045")]
public interface ICuttable
{
	[Token(Token = "0x17000007")]
	GameObject cuttablePoint
	{
		[Token(Token = "0x6000231")]
		get;
	}

	[Token(Token = "0x6000232")]
	void Cut();
}
[Token(Token = "0x2000046")]
public class IngredientState : MonoBehaviour
{
	[Token(Token = "0x2000154")]
	public enum State
	{
		[Token(Token = "0x40007A4")]
		RAW,
		[Token(Token = "0x40007A5")]
		COOKED,
		[Token(Token = "0x40007A6")]
		BURNED,
		[Token(Token = "0x40007A7")]
		ROTTEN,
		[Token(Token = "0x40007A8")]
		ONFIRE,
		[Token(Token = "0x40007A9")]
		EXTINGUISHED
	}

	[Token(Token = "0x2000155")]
	public enum ToppingState
	{
		[Token(Token = "0x40007AB")]
		NONE,
		[Token(Token = "0x40007AC")]
		KETCHUP,
		[Token(Token = "0x40007AD")]
		MUSTARD
	}

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public State state;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ToppingState toppingState;

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xD99E14", Offset = "0xD99E14", VA = "0xD99E14")]
	public IngredientState()
	{
	}
}
[Token(Token = "0x2000047")]
public class KnifeController : MonoBehaviour
{
	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float stickMinSpeed;

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xD9A838", Offset = "0xD9A838", VA = "0xD9A838")]
	private void Start()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xD9A96C", Offset = "0xD9A96C", VA = "0xD9A96C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xD9A970", Offset = "0xD9A970", VA = "0xD9A970")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xD9A9E0", Offset = "0xD9A9E0", VA = "0xD9A9E0")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xD9AA50", Offset = "0xD9AA50", VA = "0xD9AA50")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xD9AB40", Offset = "0xD9AB40", VA = "0xD9AB40")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xD9ABA4", Offset = "0xD9ABA4", VA = "0xD9ABA4")]
	public KnifeController()
	{
	}
}
[Token(Token = "0x2000048")]
public class ParticleLauncher : MonoBehaviourPun
{
	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem particleLauncher;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleLauncher otherParticleLauncher;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color liquidColor;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material lightColor;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource drinkSound;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool isPouring;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private CupLiquid currentCup;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float timeStopParticles;

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x22B4A18", Offset = "0x22B4A18", VA = "0x22B4A18")]
	private void Start()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x22B4AAC", Offset = "0x22B4AAC", VA = "0x22B4AAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x22B4AB0", Offset = "0x22B4AB0", VA = "0x22B4AB0")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x22B4F44", Offset = "0x22B4F44", VA = "0x22B4F44")]
	public void PlayDrinkParticles()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x22B51C0", Offset = "0x22B51C0", VA = "0x22B51C0")]
	[PunRPC]
	public void PourDrink()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x22B5268", Offset = "0x22B5268", VA = "0x22B5268")]
	public void PourDrinkReplay()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x22B5310", Offset = "0x22B5310", VA = "0x22B5310")]
	public void StopDrinkParticles()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x22B53D8", Offset = "0x22B53D8", VA = "0x22B53D8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x22B5588", Offset = "0x22B5588", VA = "0x22B5588")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x22B50BC", Offset = "0x22B50BC", VA = "0x22B50BC")]
	public void HapticOnButton()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x22B572C", Offset = "0x22B572C", VA = "0x22B572C")]
	public void ParticleLauncherController()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x22B57D0", Offset = "0x22B57D0", VA = "0x22B57D0")]
	public ParticleLauncher()
	{
	}
}
[Token(Token = "0x2000049")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD27E30", Offset = "0xD27E30")]
public class RottingController : MonoBehaviour
{
	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture rottenTexture;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem rottenSmoke;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem flyParticle;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rottingTime;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isRotten;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float time;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IngredientState stateComponent;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isPlayParticles;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool isStopParticles;

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x22D30A8", Offset = "0x22D30A8", VA = "0x22D30A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x22D3108", Offset = "0x22D3108", VA = "0x22D3108")]
	private void Update()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x22D310C", Offset = "0x22D310C", VA = "0x22D310C")]
	private void UpdateStates()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x22D3254", Offset = "0x22D3254", VA = "0x22D3254")]
	public void PlayRottingParticles()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x22D3258", Offset = "0x22D3258", VA = "0x22D3258")]
	public void StopRottingParticles()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x22D325C", Offset = "0x22D325C", VA = "0x22D325C")]
	public RottingController()
	{
	}
}
[Token(Token = "0x200004A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD27E94", Offset = "0xD27E94")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD27E94", Offset = "0xD27E94")]
public class ToppingController : MonoBehaviourPun
{
	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IngredientState stateComponent;

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x105E46C", Offset = "0x105E46C", VA = "0x105E46C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x105E4CC", Offset = "0x105E4CC", VA = "0x105E4CC")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x105E7D4", Offset = "0x105E7D4", VA = "0x105E7D4")]
	public void CheckHit(GameObject particleObject, List<ParticleCollisionEvent> particles)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x105EAE0", Offset = "0x105EAE0", VA = "0x105EAE0")]
	[PunRPC]
	public void ActivateDecalRPC(int bottleIndex)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x105E70C", Offset = "0x105E70C", VA = "0x105E70C")]
	private void ActivateDecal(BottleController bottleContoller)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x105EB9C", Offset = "0x105EB9C", VA = "0x105EB9C")]
	public ToppingController()
	{
	}
}
[Token(Token = "0x200004B")]
public class DryerController : MonoBehaviourPun
{
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] friesStack;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hasFilling;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int emptyIndex;

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x22E02C0", Offset = "0x22E02C0", VA = "0x22E02C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x22E02C4", Offset = "0x22E02C4", VA = "0x22E02C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x22E02C8", Offset = "0x22E02C8", VA = "0x22E02C8")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x22E056C", Offset = "0x22E056C", VA = "0x22E056C")]
	[PunRPC]
	public void FillDryer()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x22E05F0", Offset = "0x22E05F0", VA = "0x22E05F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x22E07BC", Offset = "0x22E07BC", VA = "0x22E07BC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x22E0748", Offset = "0x22E0748", VA = "0x22E0748")]
	[PunRPC]
	public void EmptyDryer()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x22E0894", Offset = "0x22E0894", VA = "0x22E0894")]
	public DryerController()
	{
	}
}
[Token(Token = "0x200004C")]
public class GraterControl : MonoBehaviour
{
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem cheeseParticles;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool canGrate;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool isGrating;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject grater;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float cheeseVelocity;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float graterVelocity;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float minGratingSpeed;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioSource graterSound;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool graterSoundPlayed;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private PhotonView photonView;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool hasStopped;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject grabObjectRight;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject grabObjectLeft;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject grabObjectOculusRight;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject grabObjectOculusLeft;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VRTK_ControllerReference controllerReference;

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x22E9AA0", Offset = "0x22E9AA0", VA = "0x22E9AA0")]
	private void Start()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x22E9CAC", Offset = "0x22E9CAC", VA = "0x22E9CAC")]
	public void SetGrabHandTrackingPointGrater()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x22E9DC0", Offset = "0x22E9DC0", VA = "0x22E9DC0")]
	public void SetGrabControllersPointGrater()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x22E9ED4", Offset = "0x22E9ED4", VA = "0x22E9ED4")]
	private void Update()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x22EA30C", Offset = "0x22EA30C", VA = "0x22EA30C")]
	[PunRPC]
	public void PlayingParticlesRPC(bool notOnGrater)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x22EA3F0", Offset = "0x22EA3F0", VA = "0x22EA3F0")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x22EA4B4", Offset = "0x22EA4B4", VA = "0x22EA4B4")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x22EA4BC", Offset = "0x22EA4BC", VA = "0x22EA4BC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x22EA7AC", Offset = "0x22EA7AC", VA = "0x22EA7AC")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x22EA874", Offset = "0x22EA874", VA = "0x22EA874")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x22EAA70", Offset = "0x22EAA70", VA = "0x22EAA70")]
	public GraterControl()
	{
	}
}
[Token(Token = "0x200004D")]
public class ParticlesFillingCheese : MonoBehaviourPun, IPunObservable
{
	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject particlesObject;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool particlesHitting;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float particlesAmount;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float timeOfLastParticle;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float sleepThreshold;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float fillingSpeed;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int state;

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x22B5E40", Offset = "0x22B5E40", VA = "0x22B5E40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x22B5E44", Offset = "0x22B5E44", VA = "0x22B5E44")]
	private void Update()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x22B5FC0", Offset = "0x22B5FC0", VA = "0x22B5FC0")]
	[PunRPC]
	public void UpdateGraphicsRPC()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x22B6084", Offset = "0x22B6084", VA = "0x22B6084", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x22B6150", Offset = "0x22B6150", VA = "0x22B6150")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x22B6564", Offset = "0x22B6564", VA = "0x22B6564")]
	[PunRPC]
	public void SetActiveCheeseOnPizza()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x22B6404", Offset = "0x22B6404", VA = "0x22B6404")]
	[PunRPC]
	public void SetActiveCheeseOnPasta()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x22B6700", Offset = "0x22B6700", VA = "0x22B6700")]
	public ParticlesFillingCheese()
	{
	}
}
[Token(Token = "0x200004E")]
public class ParticlesFillingSauce : MonoBehaviourPun, IPunObservable
{
	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] particlesObject;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int currentParticlesObject;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool particlesHitting;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float particlesAmountSauce;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float timeOfLastParticle;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float sleepThreshold;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float fillingSpeed;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float maxAngle;

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x22B6710", Offset = "0x22B6710", VA = "0x22B6710")]
	private void Start()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x22B6714", Offset = "0x22B6714", VA = "0x22B6714")]
	private void Update()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x22B72B0", Offset = "0x22B72B0", VA = "0x22B72B0", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x22B6944", Offset = "0x22B6944", VA = "0x22B6944")]
	[PunRPC]
	public void UpdateGraphics(int tcurrentParticlesObject, float tparticlesAmountSauce)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x22B737C", Offset = "0x22B737C", VA = "0x22B737C")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x22B7BD4", Offset = "0x22B7BD4", VA = "0x22B7BD4")]
	[PunRPC]
	public void SetCurrentSauce(int index)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x22B7D40", Offset = "0x22B7D40", VA = "0x22B7D40")]
	public void SetSauceOnTaco(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x22B7B70", Offset = "0x22B7B70", VA = "0x22B7B70")]
	[PunRPC]
	public void SetReadyRPC()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x22B7E58", Offset = "0x22B7E58", VA = "0x22B7E58")]
	public ParticlesFillingSauce()
	{
	}
}
[Token(Token = "0x200004F")]
public class PastaController : MonoBehaviourPun
{
	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] currentPasta;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int currentPastaIndex;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] penePastas;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] fusilliPastas;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isFilling;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int fillAmount;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float fill;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float fillingSpeed;

	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool sauceActive;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool pastaActive;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	public bool cheeseActive;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	public bool peletActive;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ParticleSystem pastaSmokeParticles;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool smokeParticlesPlaying;

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastFillingTime;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD289E0", Offset = "0xD289E0")]
	public float fillingDelay;

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x22B7E70", Offset = "0x22B7E70", VA = "0x22B7E70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x22B7EA8", Offset = "0x22B7EA8", VA = "0x22B7EA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x22B7F6C", Offset = "0x22B7F6C", VA = "0x22B7F6C")]
	public void Filling()
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x22B8268", Offset = "0x22B8268", VA = "0x22B8268")]
	[PunRPC]
	public void UpdatePastaGraphics(float tFill)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x22B830C", Offset = "0x22B830C", VA = "0x22B830C")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x22B882C", Offset = "0x22B882C", VA = "0x22B882C")]
	[PunRPC]
	public void CheckCurrentPasta(int index)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x22B8230", Offset = "0x22B8230", VA = "0x22B8230")]
	public void PlaySmokeParticles()
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x22B7E74", Offset = "0x22B7E74", VA = "0x22B7E74")]
	public void StopSmokeParticles()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x22B8940", Offset = "0x22B8940", VA = "0x22B8940")]
	public PastaController()
	{
	}
}
[Token(Token = "0x2000050")]
public class PastaNetControl : MonoBehaviourPun, IPunObservable
{
	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] currentPasta;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int currentPastaIndex;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] penePastas;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] fusilliPastas;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem[] peneParticles;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ParticleSystem[] fusilliParticles;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ParticleSystem[] currentPastaParticles;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material cookedPastaMaterial;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material rawPastaMaterial;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool isCooked;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool isSpilling;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	private bool isDownward;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject fryerObject;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool hasFilling;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool isFilling;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	private bool hasPene;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7B")]
	private bool hasFusilli;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public int fillAmount;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float fill;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float spillingSpeed;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float fillingSpeed;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool isPastaCooked;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float lastFillingTime;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool isAvailable;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28A18", Offset = "0xD28A18")]
	public float fillingDelay;

	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public AudioSource pastaSpillingSound;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool pastaSpillingPlayed;

	[Token(Token = "0x4000261")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public AudioSource pastaInWather;

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x22B895C", Offset = "0x22B895C", VA = "0x22B895C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x22B8964", Offset = "0x22B8964", VA = "0x22B8964")]
	private void Update()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x22B92F4", Offset = "0x22B92F4", VA = "0x22B92F4", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x22B8758", Offset = "0x22B8758", VA = "0x22B8758")]
	public bool CheckIsCooked()
	{
		return default(bool);
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x22B91E4", Offset = "0x22B91E4", VA = "0x22B91E4")]
	public void ChangeParticlesMaterial()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x22B8D88", Offset = "0x22B8D88", VA = "0x22B8D88")]
	public void Spilling()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x22B93C0", Offset = "0x22B93C0", VA = "0x22B93C0")]
	[PunRPC]
	public void UpdateNetGraphics(int spilling, float tFill)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x22B8FB4", Offset = "0x22B8FB4", VA = "0x22B8FB4")]
	public void Filling()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x22B94DC", Offset = "0x22B94DC", VA = "0x22B94DC")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x22B98F8", Offset = "0x22B98F8", VA = "0x22B98F8")]
	[PunRPC]
	public void CheckCurrentPasta(int index)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x22B8C68", Offset = "0x22B8C68", VA = "0x22B8C68")]
	[PunRPC]
	public void DoSpillNet(bool spill)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x22B994C", Offset = "0x22B994C", VA = "0x22B994C")]
	public void PastaCookedCount()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x22B99B0", Offset = "0x22B99B0", VA = "0x22B99B0")]
	public PastaNetControl()
	{
	}
}
[Token(Token = "0x2000051")]
public class PizzaControl : MonoBehaviourPun
{
	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isItemGrabbed;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] pelet;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject cheese;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject colliderRound;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject colliderStreched;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool peletActive;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool cheeseActive;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float blendShapeValue;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ParticleSystem poofParticle;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ParticleSystem hotParticles;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isReady;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioSource poofSound;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isPlayPoofParticles;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private VRTK_ControllerReference controllerReference;

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x22BC6A0", Offset = "0x22BC6A0", VA = "0x22BC6A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x22BC7B0", Offset = "0x22BC7B0", VA = "0x22BC7B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x22BCA6C", Offset = "0x22BCA6C", VA = "0x22BCA6C")]
	[PunRPC]
	public void PoofParticleRPC()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x22BCB2C", Offset = "0x22BCB2C", VA = "0x22BCB2C")]
	public void TouchDough(GameObject controller)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x22BCBB4", Offset = "0x22BCBB4", VA = "0x22BCBB4")]
	public void Grow()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x22BCC54", Offset = "0x22BCC54", VA = "0x22BCC54")]
	[PunRPC]
	public void GrowRPC()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x22BCDC4", Offset = "0x22BCDC4", VA = "0x22BCDC4")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x22BCE50", Offset = "0x22BCE50", VA = "0x22BCE50")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x22BCE58", Offset = "0x22BCE58", VA = "0x22BCE58")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x22BCF28", Offset = "0x22BCF28", VA = "0x22BCF28")]
	public void ChangePeletTexture()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x22BCFC8", Offset = "0x22BCFC8", VA = "0x22BCFC8")]
	[PunRPC]
	public void ChangePeletTextureRPC()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x22BD0DC", Offset = "0x22BD0DC", VA = "0x22BD0DC")]
	public void ChangeCheeseMesh()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x22BD17C", Offset = "0x22BD17C", VA = "0x22BD17C")]
	[PunRPC]
	public void ChangeCheeseMeshRPC()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x22BD24C", Offset = "0x22BD24C", VA = "0x22BD24C")]
	[PunRPC]
	public void PlayHotParticles()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x22BD340", Offset = "0x22BD340", VA = "0x22BD340")]
	[PunRPC]
	public void StopHotParticles()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x22BD42C", Offset = "0x22BD42C", VA = "0x22BD42C")]
	public PizzaControl()
	{
	}
}
[Token(Token = "0x2000052")]
public class SauceControl : MonoBehaviourPun
{
	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] sauces;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture[] saucesTextures;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int currentSauce;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject top;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject bottom;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform[] spillPoints;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform[] edgePoints;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public ParticleSystem particlesDown;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ParticleSystem particlesSplash;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color? currentColor;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Color[] splashColor;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isDownward;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float timeDownward;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool canSpill;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Vector3 sauceStartPosition;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector3 sauceStartScale;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float timeNeededToSpill;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool spillingSauceSoundPlayed;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public AudioSource spillSauceSound;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD28A50", Offset = "0xD28A50")]
	public float filled;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public int levelLiquidStepMax;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Quaternion lastLevelLiquid;

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x22D448C", Offset = "0x22D448C", VA = "0x22D448C")]
	private void Start()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x22D4518", Offset = "0x22D4518", VA = "0x22D4518")]
	private void Update()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x22D4CCC", Offset = "0x22D4CCC", VA = "0x22D4CCC")]
	[PunRPC]
	public void HideSauce()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x22D4AA4", Offset = "0x22D4AA4", VA = "0x22D4AA4")]
	[PunRPC]
	public void PlayParticles()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x22D44FC", Offset = "0x22D44FC", VA = "0x22D44FC")]
	[PunRPC]
	public void StopParticles()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x22D4AC0", Offset = "0x22D4AC0", VA = "0x22D4AC0")]
	[PunRPC]
	public void SoundPlay()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x22D4C68", Offset = "0x22D4C68", VA = "0x22D4C68")]
	[PunRPC]
	public void SoundStop()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x22D4D3C", Offset = "0x22D4D3C", VA = "0x22D4D3C")]
	public void CheckShouldLevelLiquid()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x22D4E5C", Offset = "0x22D4E5C", VA = "0x22D4E5C")]
	[PunRPC]
	public void LevelLiquid()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x22D5248", Offset = "0x22D5248", VA = "0x22D5248")]
	public void FillLadle(int sauceIndex)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x22D53FC", Offset = "0x22D53FC", VA = "0x22D53FC")]
	public void FullLadle()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x22D4B24", Offset = "0x22D4B24", VA = "0x22D4B24")]
	[PunRPC]
	private void ReduceSauce(int sauceIndex)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x22D540C", Offset = "0x22D540C", VA = "0x22D540C")]
	public SauceControl()
	{
	}
}
[Token(Token = "0x2000053")]
public class SpillingController : MonoBehaviourPun, IPunObservable
{
	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] pastas;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool isItemGrabbed;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	private bool isDownward;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem pastaParticles;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform[] spillPoints;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool shouldReturn;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform returnPosition;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject triggerObject;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject pastaDispanser;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject cooker;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool isFilling;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int fillAmount;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float fill;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float spillingSpeed;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float fillingSpeed;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private bool spillingSoundPlayed;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioSource fillingSound;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AudioSource spillingSound;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool hasStopped;

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x22FD5F0", Offset = "0x22FD5F0", VA = "0x22FD5F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x22FD70C", Offset = "0x22FD70C", VA = "0x22FD70C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x22FE220", Offset = "0x22FE220", VA = "0x22FE220", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x22FE2EC", Offset = "0x22FE2EC", VA = "0x22FE2EC")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x22FE464", Offset = "0x22FE464", VA = "0x22FE464")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x22FDCB8", Offset = "0x22FDCB8", VA = "0x22FDCB8")]
	public void Spilling()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x22FE48C", Offset = "0x22FE48C", VA = "0x22FE48C")]
	[PunRPC]
	public void UpdateGraphics(int spilling, float tFill)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x22FDEA4", Offset = "0x22FDEA4", VA = "0x22FDEA4")]
	public void Filling()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x22F6EFC", Offset = "0x22F6EFC", VA = "0x22F6EFC")]
	[PunRPC]
	public void ReturnToPlace()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x22FDAC8", Offset = "0x22FDAC8", VA = "0x22FDAC8")]
	[PunRPC]
	public void DoSpill(bool spill)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x22FE540", Offset = "0x22FE540", VA = "0x22FE540")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x22FE318", Offset = "0x22FE318", VA = "0x22FE318")]
	public void EnablePhysics(bool enable)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x22FE7D8", Offset = "0x22FE7D8", VA = "0x22FE7D8")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x22FE870", Offset = "0x22FE870", VA = "0x22FE870")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x22FE914", Offset = "0x22FE914", VA = "0x22FE914")]
	public SpillingController()
	{
	}
}
[Token(Token = "0x2000054")]
public class BamboRollControl : MonoBehaviour
{
	[Token(Token = "0x2000156")]
	public enum SushiRollingState
	{
		[Token(Token = "0x40007AF")]
		NONE,
		[Token(Token = "0x40007B0")]
		ROLLING,
		[Token(Token = "0x40007B1")]
		ROLLING_BACK,
		[Token(Token = "0x40007B2")]
		ROLL
	}

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform startPoint;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform middlePosition;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform middle2Position;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform endPosition;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform pointToLookAt;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isGrabbed;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float t;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Transform startPosition;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD28A68", Offset = "0xD28A68")]
	public float step;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public SushiRollingState state;

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xE08458", Offset = "0xE08458", VA = "0xE08458")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xE085F8", Offset = "0xE085F8", VA = "0xE085F8")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xE08600", Offset = "0xE08600", VA = "0xE08600")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xE0860C", Offset = "0xE0860C", VA = "0xE0860C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xE08E30", Offset = "0xE08E30", VA = "0xE08E30")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xE09004", Offset = "0xE09004", VA = "0xE09004")]
	public BamboRollControl()
	{
	}
}
[Token(Token = "0x2000055")]
public class CookTeaController : MonoBehaviour
{
	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float teaIsHotIn;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool onlyFirsTime;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float teaInTrigger;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool isHot;

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xE16910", Offset = "0xE16910", VA = "0xE16910")]
	public void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xE169E8", Offset = "0xE169E8", VA = "0xE169E8")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xE16A90", Offset = "0xE16A90", VA = "0xE16A90")]
	public void IsNotHot()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xE16A98", Offset = "0xE16A98", VA = "0xE16A98")]
	public CookTeaController()
	{
	}
}
[Token(Token = "0x2000056")]
public class MoverController : SpawnableController
{
	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject moverGrabObject;

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xDA1A80", Offset = "0xDA1A80", VA = "0xDA1A80", Slot = "4")]
	public override void Spawn(SpawnButtonListener spawnController)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xDA1C08", Offset = "0xDA1C08", VA = "0xDA1C08")]
	public MoverController()
	{
	}
}
[Token(Token = "0x2000057")]
public class NoodlePotController : MonoBehaviourPun
{
	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject noodlesCooked;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isCooked;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem cookSmoke;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource cookSound;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isPlaying;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isSpoonInTrigger;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static NoodlePotController instance;

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x22ACA94", Offset = "0x22ACA94", VA = "0x22ACA94")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x22ACAEC", Offset = "0x22ACAEC", VA = "0x22ACAEC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x22ACAF0", Offset = "0x22ACAF0", VA = "0x22ACAF0")]
	public void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x22ACF54", Offset = "0x22ACF54", VA = "0x22ACF54")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x22ACEC4", Offset = "0x22ACEC4", VA = "0x22ACEC4")]
	public void PlayEfects()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x22AD030", Offset = "0x22AD030", VA = "0x22AD030")]
	public void StopEfects()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x22AD0BC", Offset = "0x22AD0BC", VA = "0x22AD0BC")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x22AD324", Offset = "0x22AD324", VA = "0x22AD324")]
	[PunRPC]
	public void ActivateNoodlesCooked()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x22AD3AC", Offset = "0x22AD3AC", VA = "0x22AD3AC")]
	[PunRPC]
	public void RemoveNoodlesCooked()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x22AD434", Offset = "0x22AD434", VA = "0x22AD434")]
	public NoodlePotController()
	{
	}
}
[Token(Token = "0x2000058")]
public class NoodleSpoonController : MonoBehaviourPun
{
	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool noodlesActive;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject noodles;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Collider[] boxCollider;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform[] spillPoints;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject noodleToSpawn;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isDownward;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool isSpilling;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool isFree;

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x22AD264", Offset = "0x22AD264", VA = "0x22AD264")]
	public void ActivateNoodles()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x22AD43C", Offset = "0x22AD43C", VA = "0x22AD43C")]
	[PunRPC]
	public void ActivateNoodlesRPC()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x22AD45C", Offset = "0x22AD45C", VA = "0x22AD45C")]
	[PunRPC]
	public void DeactivateNoodlesRPC()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x22AD47C", Offset = "0x22AD47C", VA = "0x22AD47C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x22AD690", Offset = "0x22AD690", VA = "0x22AD690")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x22AD768", Offset = "0x22AD768", VA = "0x22AD768")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x22AD76C", Offset = "0x22AD76C", VA = "0x22AD76C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x22AD8EC", Offset = "0x22AD8EC", VA = "0x22AD8EC")]
	public void DoSpillNoodleSpoon(bool spill)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x22ADB64", Offset = "0x22ADB64", VA = "0x22ADB64")]
	public NoodleSpoonController()
	{
	}
}
[Token(Token = "0x2000059")]
public class NoodlesPackController : MonoBehaviour
{
	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem noodleParticles;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isItemGrabbed;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool isSpilling;

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x22ADB6C", Offset = "0x22ADB6C", VA = "0x22ADB6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x22ADC7C", Offset = "0x22ADC7C", VA = "0x22ADC7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x22ADDFC", Offset = "0x22ADDFC", VA = "0x22ADDFC")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x22ADE04", Offset = "0x22ADE04", VA = "0x22ADE04")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x22ADDB0", Offset = "0x22ADDB0", VA = "0x22ADDB0")]
	public void DoSpillNoodles(bool spill)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x22ADE10", Offset = "0x22ADE10", VA = "0x22ADE10")]
	public NoodlesPackController()
	{
	}
}
[Token(Token = "0x200005A")]
public class ParticleLauncherTea : MonoBehaviourPun
{
	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color liquidColor;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CoolingController coolingController;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isFilling;

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x22B57D8", Offset = "0x22B57D8", VA = "0x22B57D8")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x22B5C48", Offset = "0x22B5C48", VA = "0x22B5C48")]
	public ParticleLauncherTea()
	{
	}
}
[Token(Token = "0x200005B")]
public class ParticlesFillingBroth : MonoBehaviour
{
	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool particlesHitting;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float fillingSpeed;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float currentFill;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float timeOfLastParticle;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float sleepThreshold;

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x22B5C50", Offset = "0x22B5C50", VA = "0x22B5C50")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x22B5C54", Offset = "0x22B5C54", VA = "0x22B5C54")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x22B5CCC", Offset = "0x22B5CCC", VA = "0x22B5CCC")]
	public void FillBowl()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x22B5D54", Offset = "0x22B5D54", VA = "0x22B5D54")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x22B5E24", Offset = "0x22B5E24", VA = "0x22B5E24")]
	public ParticlesFillingBroth()
	{
	}
}
[Token(Token = "0x200005C")]
public class RamenController : MonoBehaviourPun
{
	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject noodles;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject broth;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject pork;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool noodlesActive;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool brothActive;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem brothParticles;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool particlesPlaying;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource audioSource;

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x22C1BD0", Offset = "0x22C1BD0", VA = "0x22C1BD0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x22C1C08", Offset = "0x22C1C08", VA = "0x22C1C08")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x22C1C58", Offset = "0x22C1C58", VA = "0x22C1C58")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x22C2034", Offset = "0x22C2034", VA = "0x22C2034")]
	[PunRPC]
	public void NoodlesSoundRPC()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x22C1C20", Offset = "0x22C1C20", VA = "0x22C1C20")]
	public void PlayBrothParticles()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x22C1BD4", Offset = "0x22C1BD4", VA = "0x22C1BD4")]
	public void StopBrothParticles()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x22C20B8", Offset = "0x22C20B8", VA = "0x22C20B8")]
	public RamenController()
	{
	}
}
[Token(Token = "0x200005D")]
public class RollingController : MonoBehaviourPun, IPunObservable, IRecordingSerializable
{
	[Token(Token = "0x2000157")]
	public enum RollingState
	{
		[Token(Token = "0x40007B4")]
		NONE,
		[Token(Token = "0x40007B5")]
		ROLLING,
		[Token(Token = "0x40007B6")]
		ROLLING_BACK
	}

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator rollAnimation;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject mover;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject grabObject;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public BoxCollider tortilaSide;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public BoxCollider workingBounds;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float fullRollValue;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float speedAnim;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform startPosition;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28A80", Offset = "0xD28A80")]
	public float rollingSpeed;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD28AB8", Offset = "0xD28AB8")]
	public float step;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RollingState state;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform[] movingBounds;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float movingDistance;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28AD0", Offset = "0xD28AD0")]
	public int sideSign;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float stepWrite;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private int stateWrite;

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x22D1E28", Offset = "0x22D1E28", VA = "0x22D1E28")]
	private void Start()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x22D1F84", Offset = "0x22D1F84", VA = "0x22D1F84", Slot = "7")]
	public virtual void CalculateMovingDistance()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x22D2050", Offset = "0x22D2050", VA = "0x22D2050", Slot = "8")]
	public virtual void SetMovingBoundPosition()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x22D2268", Offset = "0x22D2268", VA = "0x22D2268")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x22D2364", Offset = "0x22D2364", VA = "0x22D2364")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x22D2330", Offset = "0x22D2330", VA = "0x22D2330")]
	[PunRPC]
	public void SwitchState(RollingState newState)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x22D259C", Offset = "0x22D259C", VA = "0x22D259C", Slot = "9")]
	[PunRPC]
	public virtual void UpdateRollingGraphics()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x22D2628", Offset = "0x22D2628", VA = "0x22D2628", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x22D26F4", Offset = "0x22D26F4", VA = "0x22D26F4", Slot = "10")]
	public virtual float CalculateStep()
	{
		return default(float);
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x22D27F8", Offset = "0x22D27F8", VA = "0x22D27F8")]
	public void ForceReleaseMover()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x22D2438", Offset = "0x22D2438", VA = "0x22D2438")]
	public void RollingBack()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x22D29EC", Offset = "0x22D29EC", VA = "0x22D29EC")]
	public void OnMoverExit()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x22D2A18", Offset = "0x22D2A18", VA = "0x22D2A18", Slot = "5")]
	private string IRecordingSerializable.SerializeWrite()
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x22D2AE0", Offset = "0x22D2AE0", VA = "0x22D2AE0", Slot = "6")]
	private void IRecordingSerializable.SerializeRead(params string[] objects)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x22D2B48", Offset = "0x22D2B48", VA = "0x22D2B48")]
	public RollingController()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x22D2B64", Offset = "0x22D2B64", VA = "0x22D2B64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD299EC", Offset = "0xD299EC")]
	private float <RollingBack>b__25_0()
	{
		return default(float);
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x22D2B6C", Offset = "0x22D2B6C", VA = "0x22D2B6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD299FC", Offset = "0xD299FC")]
	private void <RollingBack>b__25_1(float x)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x22D2B74", Offset = "0x22D2B74", VA = "0x22D2B74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD29A0C", Offset = "0xD29A0C")]
	private void <RollingBack>b__25_2()
	{
	}
}
[Token(Token = "0x200005E")]
public class SushiController : MonoBehaviourPun
{
	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject sushiRollPrefab;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform spawnPoint;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<GameObject> ingridientsInSushi;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider[] collidersToIgnore;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject pultCollider;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameObject> pultColiders;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject seaweedBamboo;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool seaweedActive;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool riceActive;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject riceStreched;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool canRoll;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string[] onStartValidTags;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioSource spawnSound;

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x2303698", Offset = "0x2303698", VA = "0x2303698")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x2303760", Offset = "0x2303760", VA = "0x2303760")]
	public void ClearIngredientsList()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x2303C58", Offset = "0x2303C58", VA = "0x2303C58")]
	[PunRPC]
	public void SpawnSushiRPC()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x2303C5C", Offset = "0x2303C5C", VA = "0x2303C5C")]
	public void SpawnSushi()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x2303F18", Offset = "0x2303F18", VA = "0x2303F18")]
	public void SyncIngredientsInSushiRoll(GameObject sushiRoll)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x2304E80", Offset = "0x2304E80", VA = "0x2304E80")]
	[PunRPC]
	public void RollSushi()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x2304F88", Offset = "0x2304F88", VA = "0x2304F88")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x23054A0", Offset = "0x23054A0", VA = "0x23054A0")]
	[PunRPC]
	public void SetSeaweedActive()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x2305490", Offset = "0x2305490", VA = "0x2305490")]
	[PunRPC]
	public void SetSeaweedAndRice()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x2304C8C", Offset = "0x2304C8C", VA = "0x2304C8C")]
	public void ChangeTextureToMatchState(GameObject ingredientObject, GameObject snappedObject)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x2303AC8", Offset = "0x2303AC8", VA = "0x2303AC8")]
	public void RevertTexture(GameObject ingredientObject)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x23054AC", Offset = "0x23054AC", VA = "0x23054AC")]
	public SushiController()
	{
	}
}
[Token(Token = "0x200005F")]
public class SushiPlateControl : MonoBehaviour
{
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] SnapPoints;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool[] isFilled;

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x2305554", Offset = "0x2305554", VA = "0x2305554")]
	private void Start()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x23055C0", Offset = "0x23055C0", VA = "0x23055C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x23055C4", Offset = "0x23055C4", VA = "0x23055C4")]
	public int GetSnappingPlace()
	{
		return default(int);
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x2305620", Offset = "0x2305620", VA = "0x2305620")]
	public void ReleaseSnappingPlace(int freeIndex)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x2305664", Offset = "0x2305664", VA = "0x2305664")]
	public RecipeController[] GetSnappedObjects()
	{
		return null;
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x23056B4", Offset = "0x23056B4", VA = "0x23056B4")]
	public SushiPlateControl()
	{
	}
}
[Token(Token = "0x2000060")]
public class SushiRollController : MonoBehaviourPun
{
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] sushiSlice;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] markers;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] cutMasks;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject middleMask;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Color baseColor;

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x23056BC", Offset = "0x23056BC", VA = "0x23056BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x2305A40", Offset = "0x2305A40", VA = "0x2305A40")]
	private void Update()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x2305A44", Offset = "0x2305A44", VA = "0x2305A44")]
	public void HighlightSushiRoll(bool highlight)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x2306034", Offset = "0x2306034", VA = "0x2306034")]
	[PunRPC]
	public void DetachSlice(int markerIndex)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x2306C98", Offset = "0x2306C98", VA = "0x2306C98")]
	[PunRPC]
	public void UnparentSliceRPC(int sliceId)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x23057B0", Offset = "0x23057B0", VA = "0x23057B0")]
	[PunRPC]
	public void RefreshMarkers()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x2304268", Offset = "0x2304268", VA = "0x2304268")]
	public void ShowIngredient(GameObject snappedIngredient, int state)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x2306DD4", Offset = "0x2306DD4", VA = "0x2306DD4")]
	[PunRPC]
	public void SyncRecipeData(int sliceIndex, int ingredientIndex)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x2306EF0", Offset = "0x2306EF0", VA = "0x2306EF0")]
	[PunRPC]
	public void ShowIngredientRPC(int ingredientIndex, int state)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x23070DC", Offset = "0x23070DC", VA = "0x23070DC")]
	public SushiRollController()
	{
	}
}
[Token(Token = "0x2000061")]
public class SushiRollingController : RollingController
{
	[Token(Token = "0x600031A")]
	[Address(RVA = "0x105B190", Offset = "0x105B190", VA = "0x105B190")]
	private void Update()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x105B524", Offset = "0x105B524", VA = "0x105B524")]
	public SushiRollingController()
	{
	}
}
[Token(Token = "0x2000062")]
public class SushiSliceController : MonoBehaviourPun
{
	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isSnapped;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<GameObject> ingridientsInCutSushi;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isCuted;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject snappingBase;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int freeIndex;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool isItemGrabbed;

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x105B52C", Offset = "0x105B52C", VA = "0x105B52C")]
	private void Start()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x105B63C", Offset = "0x105B63C", VA = "0x105B63C")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x105B9D8", Offset = "0x105B9D8", VA = "0x105B9D8")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x105BA9C", Offset = "0x105BA9C", VA = "0x105BA9C")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x105C1C8", Offset = "0x105C1C8", VA = "0x105C1C8")]
	[PunRPC]
	public void SnapSushiRPC(int otherObjectId)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x105C2B4", Offset = "0x105C2B4", VA = "0x105C2B4")]
	public void SnapSushiRecording(GameObject plateObject, GameObject sliceObject)
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x105BE54", Offset = "0x105BE54", VA = "0x105BE54")]
	public void Snap(GameObject other)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x105C32C", Offset = "0x105C32C", VA = "0x105C32C")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x105B720", Offset = "0x105B720", VA = "0x105B720")]
	[PunRPC]
	public void UnSnap()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x105C48C", Offset = "0x105C48C", VA = "0x105C48C")]
	public SushiSliceController()
	{
	}
}
[Token(Token = "0x2000063")]
public class TeaPotSpill : MonoBehaviour
{
	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem particles;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource sound;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float SpillingDelay;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 centerOfMass;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isSpilling;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isDownward;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	private bool isSquized;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float timeDownward;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isItemGrabbed;

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x105DA18", Offset = "0x105DA18", VA = "0x105DA18")]
	private void Start()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x105DBF4", Offset = "0x105DBF4", VA = "0x105DBF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x105DDFC", Offset = "0x105DDFC", VA = "0x105DDFC")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x105DF44", Offset = "0x105DF44", VA = "0x105DF44")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x105E04C", Offset = "0x105E04C", VA = "0x105E04C")]
	public void StartSquish()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x105DF2C", Offset = "0x105DF2C", VA = "0x105DF2C")]
	public void StopSquish()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x105DD48", Offset = "0x105DD48", VA = "0x105DD48")]
	public void DoSpill(bool spill)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x105E070", Offset = "0x105E070", VA = "0x105E070")]
	public void SetItemGrabbed()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x105E07C", Offset = "0x105E07C", VA = "0x105E07C")]
	public TeaPotSpill()
	{
	}
}
[Token(Token = "0x2000064")]
public class LoadingController : MonoBehaviour
{
	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LoadingController instance;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay cubemapOverlay;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay loadingTextQuadOverlay;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool waitingToShowLoading;

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xD9C898", Offset = "0xD9C898", VA = "0xD9C898", Slot = "4")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xD9C944", Offset = "0xD9C944", VA = "0xD9C944")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xD9C9F4", Offset = "0xD9C9F4", VA = "0xD9C9F4")]
	public void LoadedSetupChangeEventHandler(VRTK_SDKManager sender, VRTK_SDKManager.LoadedSetupChangeEventArgs e)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xD9CA88", Offset = "0xD9CA88", VA = "0xD9CA88")]
	public GameObject GetCurrentCamera()
	{
		return null;
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xD9CC20", Offset = "0xD9CC20", VA = "0xD9CC20")]
	public void ShowLoading()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xD9CE8C", Offset = "0xD9CE8C", VA = "0xD9CE8C")]
	public void HideLoading()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xD9CED8", Offset = "0xD9CED8", VA = "0xD9CED8")]
	public LoadingController()
	{
	}
}
[Token(Token = "0x2000065")]
public class BurritoController : MonoBehaviourPun
{
	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isItemGrabbed;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Collider[] burritoColliders;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SideRollingController[] sideRollers;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider[] collidersToIgnore;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRolled;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isSnapped;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool isSauceActive;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	public bool isMeatSnapped;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject snappingBase;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int sideCount;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 centerOfMass;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool isMeat;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool isChicken;

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xE0F528", Offset = "0xE0F528", VA = "0xE0F528")]
	private void Start()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xE0F620", Offset = "0xE0F620", VA = "0xE0F620")]
	private void Update()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xE0FACC", Offset = "0xE0FACC", VA = "0xE0FACC")]
	public void CheckIsRolled(int sideIndex)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xE0FBC8", Offset = "0xE0FBC8", VA = "0xE0FBC8")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xE0FBD4", Offset = "0xE0FBD4", VA = "0xE0FBD4")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xE0FC98", Offset = "0xE0FC98", VA = "0xE0FC98")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xE103A0", Offset = "0xE103A0", VA = "0xE103A0")]
	public void Snap(GameObject other)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xE10808", Offset = "0xE10808", VA = "0xE10808")]
	public void DoSnapBuritoRpc(GameObject other)
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xE10970", Offset = "0xE10970", VA = "0xE10970")]
	[PunRPC]
	public void SnapBuritoRPC(int otherObjectId)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xE10A74", Offset = "0xE10A74", VA = "0xE10A74")]
	public void SnapBurritoRecording(GameObject plateObject, GameObject burrito)
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xE10AEC", Offset = "0xE10AEC", VA = "0xE10AEC")]
	public void DoUnSnap()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xE10B84", Offset = "0xE10B84", VA = "0xE10B84")]
	[PunRPC]
	public void UnSnap()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xE10E38", Offset = "0xE10E38", VA = "0xE10E38")]
	public void RefreshRecipesController()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xE0FA68", Offset = "0xE0FA68", VA = "0xE0FA68")]
	public void EnablePickUp()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xE10EB0", Offset = "0xE10EB0", VA = "0xE10EB0")]
	public void DisablePickUp()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xE10F14", Offset = "0xE10F14", VA = "0xE10F14")]
	[PunRPC]
	public void RolledRPC()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xE10F20", Offset = "0xE10F20", VA = "0xE10F20")]
	public BurritoController()
	{
	}
}
[Token(Token = "0x2000066")]
public class NachosController : MonoBehaviourPun
{
	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject nachos;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isPeletActive;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool nachosActive;

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x22A9CB8", Offset = "0x22A9CB8", VA = "0x22A9CB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x22A9CBC", Offset = "0x22A9CBC", VA = "0x22A9CBC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x22A9CC0", Offset = "0x22A9CC0", VA = "0x22A9CC0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x22A9E00", Offset = "0x22A9E00", VA = "0x22A9E00")]
	private void OnParticleCollision(GameObject particleHolderObject)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x22AA118", Offset = "0x22AA118", VA = "0x22AA118")]
	[PunRPC]
	public void ActivateNachosRPC()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x22AA200", Offset = "0x22AA200", VA = "0x22AA200")]
	public NachosController()
	{
	}
}
[Token(Token = "0x2000067")]
public class SideRollingController : RollingController
{
	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public string animName;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28B08", Offset = "0xD28B08")]
	public int sideIndex;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool sideFinish;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	public bool sideActive;

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x22F28B8", Offset = "0x22F28B8", VA = "0x22F28B8")]
	public void Awake()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x22F2A08", Offset = "0x22F2A08", VA = "0x22F2A08")]
	private void Update()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x22F2CBC", Offset = "0x22F2CBC", VA = "0x22F2CBC")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x22F2CEC", Offset = "0x22F2CEC", VA = "0x22F2CEC")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x22F2E48", Offset = "0x22F2E48", VA = "0x22F2E48")]
	private void IsMoverGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x22F3060", Offset = "0x22F3060", VA = "0x22F3060", Slot = "7")]
	public override void CalculateMovingDistance()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x22F312C", Offset = "0x22F312C", VA = "0x22F312C", Slot = "8")]
	public override void SetMovingBoundPosition()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x22F333C", Offset = "0x22F333C", VA = "0x22F333C", Slot = "10")]
	public override float CalculateStep()
	{
		return default(float);
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x22F2B04", Offset = "0x22F2B04", VA = "0x22F2B04")]
	public void FinishRolling()
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x22F3440", Offset = "0x22F3440", VA = "0x22F3440")]
	public void UpdateSideRollingGraphics()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x22F3490", Offset = "0x22F3490", VA = "0x22F3490")]
	public SideRollingController()
	{
	}
}
[Token(Token = "0x2000068")]
public class SideRollingHelper : MonoBehaviourPun
{
	[Token(Token = "0x6000358")]
	[Address(RVA = "0x22F3498", Offset = "0x22F3498", VA = "0x22F3498")]
	private void Start()
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x22F349C", Offset = "0x22F349C", VA = "0x22F349C")]
	private void Update()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x22F2C1C", Offset = "0x22F2C1C", VA = "0x22F2C1C")]
	public void DoSideRolling()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x22F2EC0", Offset = "0x22F2EC0", VA = "0x22F2EC0")]
	public void SyncShouldRoll(int index, bool enabled)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x22F354C", Offset = "0x22F354C", VA = "0x22F354C")]
	[PunRPC]
	public void SyncShouldRollRPC(int index, bool enabled)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x22F34A0", Offset = "0x22F34A0", VA = "0x22F34A0")]
	[PunRPC]
	public void DoSideRollingRPC()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x22F3698", Offset = "0x22F3698", VA = "0x22F3698")]
	public SideRollingHelper()
	{
	}
}
[Token(Token = "0x2000069")]
public class SideRollingLeftController : SideRollingController
{
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x22F36A0", Offset = "0x22F36A0", VA = "0x22F36A0")]
	public SideRollingLeftController()
	{
	}
}
[Token(Token = "0x200006A")]
public class SideRollingRightController : SideRollingController
{
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x22F36A8", Offset = "0x22F36A8", VA = "0x22F36A8")]
	public SideRollingRightController()
	{
	}
}
[Token(Token = "0x200006B")]
public class SnapOnPlateController : MonoBehaviourPun
{
	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isOccupate;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] Anchors;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject snappedObj;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<GameObject> inTrigger;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool[] occupied;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform burritoSnapPlace;

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x22F62B8", Offset = "0x22F62B8", VA = "0x22F62B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x22F6324", Offset = "0x22F6324", VA = "0x22F6324")]
	private void Update()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x22F6328", Offset = "0x22F6328", VA = "0x22F6328")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x22F67C0", Offset = "0x22F67C0", VA = "0x22F67C0")]
	public bool CanSnap()
	{
		return default(bool);
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x22F6834", Offset = "0x22F6834", VA = "0x22F6834")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x22F69FC", Offset = "0x22F69FC", VA = "0x22F69FC")]
	public int GetPlace()
	{
		return default(int);
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x22F6A58", Offset = "0x22F6A58", VA = "0x22F6A58")]
	public void ReleasePlace(int freeIndex)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x22F6804", Offset = "0x22F6804", VA = "0x22F6804")]
	public bool CheckBools()
	{
		return default(bool);
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x22F6A9C", Offset = "0x22F6A9C", VA = "0x22F6A9C")]
	public RecipeController[] GetSnappedObjects()
	{
		return null;
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x22F6AEC", Offset = "0x22F6AEC", VA = "0x22F6AEC")]
	public SnapOnPlateController()
	{
	}
}
[Token(Token = "0x200006C")]
public class TacosController : MonoBehaviourPun
{
	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isSauceActive;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool isSnapped;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	private bool isMeatSnapped;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int freeIndex;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject snappingBase;

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x105C494", Offset = "0x105C494", VA = "0x105C494")]
	private void Start()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x105C5A4", Offset = "0x105C5A4", VA = "0x105C5A4")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x105C8E0", Offset = "0x105C8E0", VA = "0x105C8E0")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x105C9A0", Offset = "0x105C9A0", VA = "0x105C9A0")]
	private void Update()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x105C9A4", Offset = "0x105C9A4", VA = "0x105C9A4")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x105D0A0", Offset = "0x105D0A0", VA = "0x105D0A0")]
	public void DoSnapTacosRpc(GameObject other)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x105D208", Offset = "0x105D208", VA = "0x105D208")]
	[PunRPC]
	public void SnapTacosRPC(int otherObjectId)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x105D794", Offset = "0x105D794", VA = "0x105D794")]
	public void SnapTacosRecording(GameObject plateObject, GameObject tacos)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x105D2F4", Offset = "0x105D2F4", VA = "0x105D2F4")]
	public void SnapTacos(GameObject other)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x105C658", Offset = "0x105C658", VA = "0x105C658")]
	[PunRPC]
	public void UnSnapTacos()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x105D80C", Offset = "0x105D80C", VA = "0x105D80C")]
	public void CheckHit(GameObject particleObject, List<ParticleCollisionEvent> particles)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x105DA10", Offset = "0x105DA10", VA = "0x105DA10")]
	public TacosController()
	{
	}
}
[Token(Token = "0x200006D")]
public class TortilaHighlightController : MonoBehaviour
{
	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int materialIndex;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Color baseColor;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] objectToHighlight;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] objectTransform;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float minDistance;

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x105EBA4", Offset = "0x105EBA4", VA = "0x105EBA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x105EBA8", Offset = "0x105EBA8", VA = "0x105EBA8")]
	public void CalculateDistanceToHighlight()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x105EE00", Offset = "0x105EE00", VA = "0x105EE00")]
	public void SetTortilaHighlight(bool highlight, GameObject objectToHighlight)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x105EF18", Offset = "0x105EF18", VA = "0x105EF18")]
	public TortilaHighlightController()
	{
	}
}
[Token(Token = "0x200006E")]
public class ChatManager : MonoBehaviour, IChatClientListener
{
	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28068", Offset = "0xD28068")]
	private sealed class <GetOnlineUsersFromChannel>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ChatManager <>4__this;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string channelName;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000915")]
			[Address(RVA = "0xE14920", Offset = "0xE14920", VA = "0xE14920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000917")]
			[Address(RVA = "0xE14988", Offset = "0xE14988", VA = "0xE14988", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xE13A80", Offset = "0xE13A80", VA = "0xE13A80")]
		[DebuggerHidden]
		public <GetOnlineUsersFromChannel>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xE147F4", Offset = "0xE147F4", VA = "0xE147F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xE147F8", Offset = "0xE147F8", VA = "0xE147F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xE14928", Offset = "0xE14928", VA = "0xE14928", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28078", Offset = "0xD28078")]
	private sealed class <>c
	{
		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<PlayerData, string> <>9__17_1;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<PlayerDataArray> <>9__17_0;

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xE1461C", Offset = "0xE1461C", VA = "0xE1461C")]
		public <>c()
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xE14624", Offset = "0xE14624", VA = "0xE14624")]
		internal void <OnConnected>b__17_0(PlayerDataArray callback)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xE147B8", Offset = "0xE147B8", VA = "0xE147B8")]
		internal string <OnConnected>b__17_1(PlayerData p)
		{
			return null;
		}
	}

	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28088", Offset = "0xD28088")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string user;

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xE14474", Offset = "0xE14474", VA = "0xE14474")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xE147D0", Offset = "0xE147D0", VA = "0xE147D0")]
		internal bool <OnStatusUpdate>b__0(PlayerData f)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ChatClient chatClient;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string chatAppId;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ChatManager s_instance;

	[Token(Token = "0x17000008")]
	public static ChatManager Instance
	{
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xE13278", Offset = "0xE13278", VA = "0xE13278")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xE13344", Offset = "0xE13344", VA = "0xE13344")]
	private void Awake()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xE13460", Offset = "0xE13460", VA = "0xE13460")]
	private void Start()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xE134E0", Offset = "0xE134E0", VA = "0xE134E0")]
	private void OnLogin()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xE13628", Offset = "0xE13628", VA = "0xE13628")]
	private void Update()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xE1363C", Offset = "0xE1363C", VA = "0xE1363C")]
	public void InvitePlayer(ulong uuid)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xE13724", Offset = "0xE13724", VA = "0xE13724")]
	public void InvitePlayerCancel(ulong uuid)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xE137BC", Offset = "0xE137BC", VA = "0xE137BC")]
	public void InvitePlayerAccept(ulong uuid)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xE13854", Offset = "0xE13854", VA = "0xE13854")]
	public void InvitePlayerReject(ulong uuid)
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xE138EC", Offset = "0xE138EC", VA = "0xE138EC")]
	public void GetOnlinePlayers()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xE139E8", Offset = "0xE139E8", VA = "0xE139E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29B4C", Offset = "0xD29B4C")]
	private IEnumerator GetOnlineUsersFromChannel(string channelName)
	{
		return null;
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xE13AAC", Offset = "0xE13AAC", VA = "0xE13AAC", Slot = "4")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xE13B34", Offset = "0xE13B34", VA = "0xE13B34", Slot = "5")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xE13BA0", Offset = "0xE13BA0", VA = "0xE13BA0", Slot = "6")]
	public void OnConnected()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xE13D28", Offset = "0xE13D28", VA = "0xE13D28", Slot = "7")]
	public void OnChatStateChange(ChatState state)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xE13DD8", Offset = "0xE13DD8", VA = "0xE13DD8", Slot = "8")]
	public void OnGetMessages(string channelName, string[] senders, object[] messages)
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xE13E60", Offset = "0xE13E60", VA = "0xE13E60", Slot = "9")]
	public void OnPrivateMessage(string sender, object message, string channelName)
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xE14104", Offset = "0xE14104", VA = "0xE14104", Slot = "10")]
	public void OnSubscribed(string[] channels, bool[] results)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xE14170", Offset = "0xE14170", VA = "0xE14170", Slot = "11")]
	public void OnUnsubscribed(string[] channels)
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xE141DC", Offset = "0xE141DC", VA = "0xE141DC", Slot = "12")]
	public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xE1447C", Offset = "0xE1447C", VA = "0xE1447C", Slot = "13")]
	public void OnUserSubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xE144E8", Offset = "0xE144E8", VA = "0xE144E8", Slot = "14")]
	public void OnUserUnsubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xE14554", Offset = "0xE14554", VA = "0xE14554")]
	public ChatManager()
	{
	}
}
[Token(Token = "0x200006F")]
public class CloneManager : MonoBehaviour
{
	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> cloneObjects;

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xE151C0", Offset = "0xE151C0", VA = "0xE151C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xE151C4", Offset = "0xE151C4", VA = "0xE151C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xE151C8", Offset = "0xE151C8", VA = "0xE151C8")]
	public void ShowCounter()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xE15264", Offset = "0xE15264", VA = "0xE15264")]
	public void RequestOwnership()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xE158B0", Offset = "0xE158B0", VA = "0xE158B0")]
	public CloneManager()
	{
	}
}
[Serializable]
[Token(Token = "0x2000070")]
public class LeaderboardData
{
	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int restaurant;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int mode;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int level;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool win;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int score;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int happyCustomers;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int satisfiedCustomers;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int madCustomers;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int failedCustomers;

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xD9AFD8", Offset = "0xD9AFD8", VA = "0xD9AFD8")]
	public LeaderboardData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000071")]
public class MatchData
{
	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int playerId;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string playerName;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeElapsed;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string fileName;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int orderId;

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xD9E474", Offset = "0xD9E474", VA = "0xD9E474")]
	public MatchData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000072")]
public class RecordingData
{
	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 objectPosition;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Quaternion objectRotation;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float time;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public char type;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int materialState;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool enabled;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RecordingObjects recordingObject;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int recordingObjectId;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int orderIndex;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int data2;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float r;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float b;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float g;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float a;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float fillAmount;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string functionName;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string functionArguments;

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x22C44B4", Offset = "0x22C44B4", VA = "0x22C44B4")]
	public RecordingData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000073")]
public class RecordingObjects
{
	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject gameObject;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string objectName;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int id;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string prefabName;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MaterialStates materialStates;

	[NonSerialized]
	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RecordingData lastRecordedData;

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x22C8FBC", Offset = "0x22C8FBC", VA = "0x22C8FBC")]
	public RecordingObjects()
	{
	}
}
[Token(Token = "0x2000074")]
public class ReplayData
{
	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 objectPosition;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Quaternion objectRotation;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float time;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public char type;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int materialState;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool enabled;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int orderIndex;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float r;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float b;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float g;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float a;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float fillAmount;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string functionName;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string[] functionArguments;

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x22CAF98", Offset = "0x22CAF98", VA = "0x22CAF98")]
	public ReplayData()
	{
	}
}
[Token(Token = "0x2000075")]
public class ReplayObject
{
	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject prefab;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject gameObject;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string objectName;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int id;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int currentIndex;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MaterialStates materialStates;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReplayData> replayData;

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x22D0598", Offset = "0x22D0598", VA = "0x22D0598")]
	public ReplayObject()
	{
	}
}
[Token(Token = "0x2000076")]
public interface IRecordingSerializable
{
	[Token(Token = "0x600039D")]
	string SerializeWrite();

	[Token(Token = "0x600039E")]
	void SerializeRead(params string[] objects);
}
[Token(Token = "0x2000077")]
public class MultiplayerEventCodes
{
	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static byte MULTIPLAYER_ALL_READY;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static byte MULTIPLAYER_START;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static byte MULTIPLAYER_END;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	public static byte MULTIPLAYER_TEARS_PARTICLES;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static byte MULTIPLAYER_MATCH_FOUND;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public static byte MULTIPLAYER_PREFERRED_KITCHEN;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
	public static byte MULTIPLAYER_KITCHEN_CHOSEN;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
	public static byte MULTIPLAYER_ACCEPT_INVITE;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static byte MULTIPLAYER_KITCHEN_INVITED;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public static byte BADGES_INFO;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
	public static byte MULTIPLAYER_REMATCH;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
	public static byte MULTIPLAYER_REMATCH_READY;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static byte REQUEST_TIME_SYNC;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public static byte SEND_TIME_SYNC;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public static byte ON_HMD_REMOVED;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
	public static byte ON_HMD_ON;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static byte DEBUG_VR_ATTACHED;

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xDA51EC", Offset = "0xDA51EC", VA = "0xDA51EC")]
	public MultiplayerEventCodes()
	{
	}
}
[Token(Token = "0x2000078")]
public class MultiplayerEvents : MonoBehaviour
{
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xDA5328", Offset = "0xDA5328", VA = "0xDA5328", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xDA53E4", Offset = "0xDA53E4", VA = "0xDA53E4", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xDA54A0", Offset = "0xDA54A0", VA = "0xDA54A0", Slot = "6")]
	public virtual void OnPhotonEvent(EventData photonEvent)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xDA6570", Offset = "0xDA6570", VA = "0xDA6570")]
	public MultiplayerEvents()
	{
	}
}
[Serializable]
[Token(Token = "0x2000079")]
public class MultiplayerGameData
{
	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string orderSet;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int points;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string file;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string fileData;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MultiplayerGameDataPlayer player;

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xDA351C", Offset = "0xDA351C", VA = "0xDA351C")]
	public MultiplayerGameData()
	{
	}
}
[Serializable]
[Token(Token = "0x200007A")]
public class MultiplayerGameDataPlayer
{
	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string username;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string platformId;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string avatarId;

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xDA3524", Offset = "0xDA3524", VA = "0xDA3524")]
	public MultiplayerGameDataPlayer()
	{
	}
}
[Serializable]
[Token(Token = "0x200007B")]
public class MultiplayerLeaderboardData
{
	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string username;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int score;

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xDA76C4", Offset = "0xDA76C4", VA = "0xDA76C4")]
	public MultiplayerLeaderboardData()
	{
	}
}
[Serializable]
[Token(Token = "0x200007C")]
public class LeaderboardUserData
{
	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MultiplayerLeaderboardData user;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MultiplayerLeaderboardData[] leaderboard;

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xD9AFE0", Offset = "0xD9AFE0", VA = "0xD9AFE0")]
	public LeaderboardUserData()
	{
	}
}
[Serializable]
[Token(Token = "0x200007D")]
public class PlayerData
{
	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string username;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string uuid;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string token;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool online;

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x22AACF4", Offset = "0x22AACF4", VA = "0x22AACF4")]
	public PlayerData()
	{
	}
}
[Serializable]
[Token(Token = "0x200007E")]
public class PlayerDataArray
{
	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PlayerData[] players;

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x22BDD44", Offset = "0x22BDD44", VA = "0x22BDD44")]
	public PlayerDataArray()
	{
	}
}
[Token(Token = "0x200007F")]
public class MultiplayerManager : MonoBehaviourPunCallbacks
{
	[Serializable]
	[Token(Token = "0x200015B")]
	private class MatchData
	{
		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int game_id;

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xDADC80", Offset = "0xDADC80", VA = "0xDADC80")]
		public MatchData()
		{
		}
	}

	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28098", Offset = "0xD28098")]
	private sealed class <Login>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0xDACB70", Offset = "0xDACB70", VA = "0xDACB70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0xDACBD8", Offset = "0xDACBD8", VA = "0xDACBD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xDA87B0", Offset = "0xDA87B0", VA = "0xDA87B0")]
		[DebuggerHidden]
		public <Login>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xDAC7F8", Offset = "0xDAC7F8", VA = "0xDAC7F8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xDAC7FC", Offset = "0xDAC7FC", VA = "0xDAC7FC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xDACB78", Offset = "0xDACB78", VA = "0xDACB78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD280A8", Offset = "0xD280A8")]
	private sealed class <GetLocalFriends>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<PlayerDataArray> callback;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0xDABB94", Offset = "0xDABB94", VA = "0xDABB94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0xDABBFC", Offset = "0xDABBFC", VA = "0xDABBFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xDA8874", Offset = "0xDA8874", VA = "0xDA8874")]
		[DebuggerHidden]
		public <GetLocalFriends>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xDAB908", Offset = "0xDAB908", VA = "0xDAB908", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xDAB90C", Offset = "0xDAB90C", VA = "0xDAB90C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xDABB9C", Offset = "0xDABB9C", VA = "0xDABB9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD280B8", Offset = "0xD280B8")]
	private sealed class <UploadSampleGame>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string orderSet;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int pointsEarned;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string filename;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<bool> callback;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xDADA38", Offset = "0xDADA38", VA = "0xDADA38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0xDADAA0", Offset = "0xDADAA0", VA = "0xDADAA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xDA898C", Offset = "0xDA898C", VA = "0xDA898C")]
		[DebuggerHidden]
		public <UploadSampleGame>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xDAD68C", Offset = "0xDAD68C", VA = "0xDAD68C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xDAD690", Offset = "0xDAD690", VA = "0xDAD690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xDADA40", Offset = "0xDADA40", VA = "0xDADA40", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD280C8", Offset = "0xD280C8")]
	private sealed class <UploadGame>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int matchId;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string filename;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string absoluteFilename;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<bool> callback;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0xDAD204", Offset = "0xDAD204", VA = "0xDAD204", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0xDAD26C", Offset = "0xDAD26C", VA = "0xDAD26C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xDA8A88", Offset = "0xDA8A88", VA = "0xDA8A88")]
		[DebuggerHidden]
		public <UploadGame>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xDACF20", Offset = "0xDACF20", VA = "0xDACF20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xDACF24", Offset = "0xDACF24", VA = "0xDACF24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xDAD20C", Offset = "0xDAD20C", VA = "0xDAD20C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD280D8", Offset = "0xD280D8")]
	private sealed class <UploadMatch>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string opponentGameId;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int pointsEarned;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string orderSet;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<bool> callback;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string name;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0xDAD61C", Offset = "0xDAD61C", VA = "0xDAD61C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0xDAD684", Offset = "0xDAD684", VA = "0xDAD684", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xDA8AB4", Offset = "0xDA8AB4", VA = "0xDA8AB4")]
		[DebuggerHidden]
		public <UploadMatch>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xDAD274", Offset = "0xDAD274", VA = "0xDAD274", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xDAD278", Offset = "0xDAD278", VA = "0xDAD278", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0xDAD624", Offset = "0xDAD624", VA = "0xDAD624", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD280E8", Offset = "0xD280E8")]
	private sealed class <GetMatch>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<MultiplayerGameData> callback;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<int> progressCallback;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0xDAC260", Offset = "0xDAC260", VA = "0xDAC260", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0xDAC2C8", Offset = "0xDAC2C8", VA = "0xDAC2C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xDA8AE0", Offset = "0xDA8AE0", VA = "0xDA8AE0")]
		[DebuggerHidden]
		public <GetMatch>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0xDABC04", Offset = "0xDABC04", VA = "0xDABC04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xDABC08", Offset = "0xDABC08", VA = "0xDABC08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xDAC268", Offset = "0xDAC268", VA = "0xDAC268", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD280F8", Offset = "0xD280F8")]
	private sealed class <GetGame>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerGameData loadedGameData;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<int> progressCallback;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<MultiplayerGameData> callback;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <zipFile>5__2;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityWebRequest <www>5__3;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000946")]
			[Address(RVA = "0xDAB898", Offset = "0xDAB898", VA = "0xDAB898", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000948")]
			[Address(RVA = "0xDAB900", Offset = "0xDAB900", VA = "0xDAB900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xDA8B0C", Offset = "0xDA8B0C", VA = "0xDA8B0C")]
		[DebuggerHidden]
		public <GetGame>d__63(int <>1__state)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xDAB274", Offset = "0xDAB274", VA = "0xDAB274", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xDAB278", Offset = "0xDAB278", VA = "0xDAB278", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xDAB8A0", Offset = "0xDAB8A0", VA = "0xDAB8A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000163")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28108", Offset = "0xD28108")]
	private sealed class <Leaderboards>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int restaurant;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int mode;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int level;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<LeaderboardUserData> callback;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600094C")]
			[Address(RVA = "0xDAC788", Offset = "0xDAC788", VA = "0xDAC788", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0xDAC7F0", Offset = "0xDAC7F0", VA = "0xDAC7F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xDA8B38", Offset = "0xDA8B38", VA = "0xDA8B38")]
		[DebuggerHidden]
		public <Leaderboards>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xDAC2D0", Offset = "0xDAC2D0", VA = "0xDAC2D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xDAC2D4", Offset = "0xDAC2D4", VA = "0xDAC2D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xDAC790", Offset = "0xDAC790", VA = "0xDAC790", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28118", Offset = "0xD28118")]
	private sealed class <PostLeaderboardResult>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerManager <>4__this;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int restaurant;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int mode;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int level;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int score;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<bool> callback;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityWebRequest <www>5__2;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0xDACEB0", Offset = "0xDACEB0", VA = "0xDACEB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0xDACF18", Offset = "0xDACF18", VA = "0xDACF18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xDA8B64", Offset = "0xDA8B64", VA = "0xDA8B64")]
		[DebuggerHidden]
		public <PostLeaderboardResult>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xDACBE0", Offset = "0xDACBE0", VA = "0xDACBE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xDACBE4", Offset = "0xDACBE4", VA = "0xDACBE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0xDACEB8", Offset = "0xDACEB8", VA = "0xDACEB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28128", Offset = "0xD28128")]
	private sealed class <reportProgress>d__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<int> progressCallback;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityWebRequest req;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0xDADC10", Offset = "0xDADC10", VA = "0xDADC10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0xDADC78", Offset = "0xDADC78", VA = "0xDADC78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xDAA838", Offset = "0xDAA838", VA = "0xDAA838")]
		[DebuggerHidden]
		public <reportProgress>d__86(int <>1__state)
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0xDADAA8", Offset = "0xDADAA8", VA = "0xDADAA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0xDADAAC", Offset = "0xDADAAC", VA = "0xDADAAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xDADC18", Offset = "0xDADC18", VA = "0xDADC18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string REALTIME_VERSION;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int RECORDING_VERSION;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject mainPlayer;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string roomName;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float timeLimit;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int maxSliderValue;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int currentSliderValue;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool Initialized;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool playerLeft;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string serverUrl;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool autoJoinRoom;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool autoJoinInvite;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ulong inviteeId;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int playerLeftActorNumber;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool disconnectingFromMaster;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public PlayerData player;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public PlayerData[] friends;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public MultiplayerGameData currentGameData;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MultiplayerLeaderboardData[] currentLeaderboardData;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected UnityAction<bool> joinCallback;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private UnityAction<bool> onConnectCallback;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool voiceChatInitialized;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject voiceChatPrefab;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string roomCode;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static MultiplayerManager s_instance;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject recordingCenter;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject replayingCenter;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject[] opponentSpawnPoints;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public int playerID;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public string opponentInviteName;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject[] endPanelSpawnPoints;

	[Token(Token = "0x17000009")]
	public static MultiplayerManager Instance
	{
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xD990F4", Offset = "0xD990F4", VA = "0xD990F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xDA76CC", Offset = "0xDA76CC", VA = "0xDA76CC")]
	public void Awake()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xDA7830", Offset = "0xDA7830", VA = "0xDA7830")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xDA7988", Offset = "0xDA7988", VA = "0xDA7988")]
	public void CheckVoicePermission()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xDA7AA8", Offset = "0xDA7AA8", VA = "0xDA7AA8", Slot = "54")]
	public virtual void Connect()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xDA4560", Offset = "0xDA4560", VA = "0xDA4560")]
	public void Connect(UnityAction<bool> callback)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xDA0528", Offset = "0xDA0528", VA = "0xDA0528")]
	public void Disconnect()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xDA7BA0", Offset = "0xDA7BA0", VA = "0xDA7BA0")]
	public GameObject InstantiatePrefab(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xDA7C84", Offset = "0xDA7C84", VA = "0xDA7C84")]
	public void DestroyObject(GameObject gameObject)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xDA7CEC", Offset = "0xDA7CEC", VA = "0xDA7CEC")]
	public bool IsMine(PhotonView photonView)
	{
		return default(bool);
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xDA7E3C", Offset = "0xDA7E3C", VA = "0xDA7E3C")]
	public void RPC(PhotonView photonView, string functionName)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xDA7FD8", Offset = "0xDA7FD8", VA = "0xDA7FD8")]
	public void RPC(PhotonView photonView, string functionName, params object[] objects)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xDA8100", Offset = "0xDA8100", VA = "0xDA8100")]
	public string GetID()
	{
		return null;
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xD998CC", Offset = "0xD998CC", VA = "0xD998CC")]
	public string GetName()
	{
		return null;
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xDA8168", Offset = "0xDA8168", VA = "0xDA8168")]
	public string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xDA6BB0", Offset = "0xDA6BB0", VA = "0xDA6BB0")]
	public void GetFriends(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xDA72B0", Offset = "0xDA72B0", VA = "0xDA72B0")]
	public void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xDA81D0", Offset = "0xDA81D0", VA = "0xDA81D0")]
	public void InviteCallback(ulong friendId, string friendName)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xD9A1B4", Offset = "0xD9A1B4", VA = "0xD9A1B4")]
	public void JoinInvitedGame()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xDA8280", Offset = "0xDA8280", VA = "0xDA8280")]
	public void JoinInvitedPhotonRoom()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xD9A220", Offset = "0xD9A220", VA = "0xD9A220")]
	public void DeclineInvite()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xDA75C0", Offset = "0xDA75C0", VA = "0xDA75C0")]
	public void CancelInvite()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xDA854C", Offset = "0xDA854C", VA = "0xDA854C", Slot = "55")]
	public virtual void OnReady()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xDA8704", Offset = "0xDA8704", VA = "0xDA8704")]
	public void OnVRTKLoaded(VRTK_SDKManager sender, VRTK_SDKManager.LoadedSetupChangeEventArgs e)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xDA8688", Offset = "0xDA8688", VA = "0xDA8688")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29BB0", Offset = "0xD29BB0")]
	public IEnumerator Login()
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xDA87DC", Offset = "0xDA87DC", VA = "0xDA87DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29C14", Offset = "0xD29C14")]
	public IEnumerator GetLocalFriends(Action<PlayerDataArray> callback)
	{
		return null;
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xDA88A0", Offset = "0xDA88A0", VA = "0xDA88A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29C78", Offset = "0xD29C78")]
	public IEnumerator UploadSampleGame(string name, string filename, string orderSet, int pointsEarned, Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xDA89B8", Offset = "0xDA89B8", VA = "0xDA89B8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29CDC", Offset = "0xD29CDC")]
	public IEnumerator UploadGame(string filename, string absoluteFilename, int matchId, Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xDA3760", Offset = "0xDA3760", VA = "0xDA3760")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29D40", Offset = "0xD29D40")]
	public IEnumerator UploadMatch(string name, string filename, string orderSet, string opponentGameId, int pointsEarned, Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0xDA3A60", Offset = "0xDA3A60", VA = "0xDA3A60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29DA4", Offset = "0xD29DA4")]
	public IEnumerator GetMatch(Action<MultiplayerGameData> callback, [Optional] Action<int> progressCallback)
	{
		return null;
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0xDA352C", Offset = "0xDA352C", VA = "0xDA352C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29E08", Offset = "0xD29E08")]
	public IEnumerator GetGame(MultiplayerGameData loadedGameData, Action<MultiplayerGameData> callback, [Optional] Action<int> progressCallback)
	{
		return null;
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xD9B17C", Offset = "0xD9B17C", VA = "0xD9B17C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29E6C", Offset = "0xD29E6C")]
	public IEnumerator Leaderboards(Action<LeaderboardUserData> callback, int restaurant, int mode, int level)
	{
		return null;
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xDA2E7C", Offset = "0xDA2E7C", VA = "0xDA2E7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29ED0", Offset = "0xD29ED0")]
	public IEnumerator PostLeaderboardResult(Action<bool> callback, int restaurant, int mode, int level, int score)
	{
		return null;
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xDA8B90", Offset = "0xDA8B90", VA = "0xDA8B90", Slot = "45")]
	public override void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xDA8E1C", Offset = "0xDA8E1C", VA = "0xDA8E1C", Slot = "38")]
	public override void OnDisconnected(DisconnectCause cause)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xDA92F4", Offset = "0xDA92F4", VA = "0xDA92F4")]
	public void OfflineJoin(bool joined)
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xDA9394", Offset = "0xDA9394", VA = "0xDA9394")]
	public void OnStartMultiplayer(bool success)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xDA9490", Offset = "0xDA9490", VA = "0xDA9490")]
	public void OnStartInvitedMultiplayer(bool success)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xDA958C", Offset = "0xDA958C", VA = "0xDA958C", Slot = "56")]
	public virtual void JoinOrCreateRoom(UnityAction<bool> function)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xDA96B4", Offset = "0xDA96B4", VA = "0xDA96B4", Slot = "57")]
	public virtual void JoinOrCreateRoom(string roomName, UnityAction<bool> function)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xDA491C", Offset = "0xDA491C", VA = "0xDA491C")]
	public void ExitRoom(UnityAction<bool> callback)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xDA97FC", Offset = "0xDA97FC", VA = "0xDA97FC")]
	public void OnStartMultiplayerCallback(bool success)
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xDA9B14", Offset = "0xDA9B14", VA = "0xDA9B14")]
	public void JoinRandomRoom()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xDA9A00", Offset = "0xDA9A00", VA = "0xDA9A00")]
	public void CreateRandomRoom()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xDA9BEC", Offset = "0xDA9BEC", VA = "0xDA9BEC", Slot = "35")]
	public override void OnCreatedRoom()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xD9A6C8", Offset = "0xD9A6C8", VA = "0xD9A6C8")]
	public void JoinViaCode(string newCode)
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xDA9C58", Offset = "0xDA9C58", VA = "0xDA9C58")]
	public void ShowRematch(bool success)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xDA9E88", Offset = "0xDA9E88", VA = "0xDA9E88", Slot = "41")]
	public override void OnJoinedRoom()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0xDAA100", Offset = "0xDAA100", VA = "0xDAA100", Slot = "34")]
	public override void OnJoinRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xDAA270", Offset = "0xDAA270", VA = "0xDAA270", Slot = "44")]
	public override void OnJoinRandomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xDAA2CC", Offset = "0xDAA2CC", VA = "0xDAA2CC", Slot = "43")]
	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xDAA3B0", Offset = "0xDAA3B0", VA = "0xDAA3B0")]
	public void DisableOnPlayerLeft()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xDAA598", Offset = "0xDAA598", VA = "0xDAA598", Slot = "58")]
	public virtual void SpawnPlayer(bool isOpponent)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xDAA7A0", Offset = "0xDAA7A0", VA = "0xDAA7A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29F34", Offset = "0xD29F34")]
	private IEnumerator reportProgress(UnityWebRequest req, Action<int> progressCallback)
	{
		return null;
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0xDAA864", Offset = "0xDAA864", VA = "0xDAA864", Slot = "47")]
	public override void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0xDAA918", Offset = "0xDAA918", VA = "0xDAA918")]
	public bool CheckAllLevelLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xDAAA58", Offset = "0xDAAA58", VA = "0xDAAA58")]
	public void OnHMDRemoved()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xDAAB50", Offset = "0xDAAB50", VA = "0xDAAB50")]
	public void OnHMDOn()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xDAAC4C", Offset = "0xDAAC4C", VA = "0xDAAC4C")]
	public void SendTimeSyncRequest()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xDAAD3C", Offset = "0xDAAD3C", VA = "0xDAAD3C", Slot = "59")]
	public virtual void OnStartMultiplayerEvent()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xDAAF10", Offset = "0xDAAF10", VA = "0xDAAF10")]
	public MultiplayerManager()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xDAAFEC", Offset = "0xDAAFEC", VA = "0xDAAFEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD29F98", Offset = "0xD29F98")]
	private void <JoinInvitedPhotonRoom>b__51_0(bool connected)
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xDAB130", Offset = "0xDAB130", VA = "0xDAB130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD29FA8", Offset = "0xD29FA8")]
	private void <JoinInvitedPhotonRoom>b__51_1(bool successful)
	{
	}
}
[Token(Token = "0x2000080")]
public class NetworkGrabInteractableObject : MonoBehaviourPun
{
	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VRTK_InteractableObject interactibleObject;

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x22ABCC4", Offset = "0x22ABCC4", VA = "0x22ABCC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x22ABF18", Offset = "0x22ABF18", VA = "0x22ABF18")]
	private void HandleGrab(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x22AC438", Offset = "0x22AC438", VA = "0x22AC438")]
	public void OnOwnershipRequest(object[] viewAndPlayer)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x22AC534", Offset = "0x22AC534", VA = "0x22AC534")]
	private void HandleUngrab(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x22AC6E8", Offset = "0x22AC6E8", VA = "0x22AC6E8")]
	[PunRPC]
	public void SyncRigidbody(bool isKinematic)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x22AC758", Offset = "0x22AC758", VA = "0x22AC758")]
	public void ShowHands(object sender, InteractControllerAppearanceEventArgs e)
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x22AC9D4", Offset = "0x22AC9D4", VA = "0x22AC9D4")]
	public void HideHands(object sender, InteractControllerAppearanceEventArgs e)
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x22ACA8C", Offset = "0x22ACA8C", VA = "0x22ACA8C")]
	public NetworkGrabInteractableObject()
	{
	}
}
[Token(Token = "0x2000081")]
public class PhotonPlayer : MonoBehaviour, IPunObservable
{
	[Token(Token = "0x2000166")]
	private enum AvatarType
	{
		[Token(Token = "0x4000807")]
		NONE,
		[Token(Token = "0x4000808")]
		CUSTOM,
		[Token(Token = "0x4000809")]
		OCULUS
	}

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PhotonPlayer player;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PhotonView photonView;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject tearsParticles;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro playerTextName;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture[] textures;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color[] nameTextColor;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Color colorPlayerName;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioSource speaker;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected int playerActorNumber;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float height;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool isSynced;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int playerNumber;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string playerName;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject activeCameraRig;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject activeLeftHand;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject activeRightHand;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject leftController;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject rightController;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject head;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public OvrAvatar localAvatar;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RecordingAvatar recordingAvatar;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public HandTrackingRecorder leftHand;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public HandTrackingRecorder rightHand;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected bool IsHandtrackingActive;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int PacketSequence;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private AvatarType avatarType;

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x22B9AEC", Offset = "0x22B9AEC", VA = "0x22B9AEC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x22B9B64", Offset = "0x22B9B64", VA = "0x22B9B64")]
	public void EnableSpeaker()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x22B9C00", Offset = "0x22B9C00", VA = "0x22B9C00")]
	public void DisableSpeaker()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x22B9C9C", Offset = "0x22B9C9C", VA = "0x22B9C9C")]
	private void SetAvatarType(AvatarType newType)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x22BA0F8", Offset = "0x22BA0F8", VA = "0x22BA0F8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x22BA850", Offset = "0x22BA850", VA = "0x22BA850")]
	[PunRPC]
	public void ChangeAvatarTexture(int textureIndex)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x22BA854", Offset = "0x22BA854", VA = "0x22BA854")]
	[PunRPC]
	public void SendActorNumber(int actorNumber)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x22BA85C", Offset = "0x22BA85C", VA = "0x22BA85C")]
	[PunRPC]
	public void SyncPlayerName(string playerNamePar, int colorIndex, float height, int playerNum)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x22BA7C4", Offset = "0x22BA7C4", VA = "0x22BA7C4")]
	public void SetSpeaker()
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x22BA970", Offset = "0x22BA970", VA = "0x22BA970")]
	public void HideAvatarOnLeave()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x22BAA14", Offset = "0x22BAA14", VA = "0x22BAA14")]
	public void HideAvatarsOnDisconnect()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x22BAA3C", Offset = "0x22BAA3C", VA = "0x22BAA3C")]
	public void SendTearParticles()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x22BAAC0", Offset = "0x22BAAC0", VA = "0x22BAAC0")]
	[PunRPC]
	public void EnableTearParticles()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x22BAB30", Offset = "0x22BAB30", VA = "0x22BAB30")]
	public void DisableParticles()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x22BAB50", Offset = "0x22BAB50", VA = "0x22BAB50", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x22BAC08", Offset = "0x22BAC08", VA = "0x22BAC08", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x22BAC80", Offset = "0x22BAC80", VA = "0x22BAC80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x22BAF50", Offset = "0x22BAF50", VA = "0x22BAF50")]
	[PunRPC]
	public void ShowHand(bool show, bool isLeftHand, bool isHandTracking)
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x22AC290", Offset = "0x22AC290", VA = "0x22AC290")]
	public void RefreshHands(bool show, bool isLeftHand, bool isHandTracking)
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x22BB17C", Offset = "0x22BB17C", VA = "0x22BB17C")]
	private void SyncHand(PhotonStream stream, GameObject activeHand, HandTrackingRecorder handRecorder)
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x22BB568", Offset = "0x22BB568", VA = "0x22BB568", Slot = "4")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x22BB77C", Offset = "0x22BB77C", VA = "0x22BB77C")]
	public PhotonPlayer()
	{
	}
}
[Token(Token = "0x2000082")]
public class PrefabPool : MonoBehaviour, IPunPrefabPool
{
	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] spawnablePrefabs;

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x22C1480", Offset = "0x22C1480", VA = "0x22C1480", Slot = "5")]
	private void Photon.Pun.IPunPrefabPool.Destroy(GameObject gameObject)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x22C14E8", Offset = "0x22C14E8", VA = "0x22C14E8", Slot = "4")]
	private GameObject Photon.Pun.IPunPrefabPool.Instantiate(string prefabId, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x22C167C", Offset = "0x22C167C", VA = "0x22C167C")]
	public PrefabPool()
	{
	}
}
[Token(Token = "0x2000083")]
public class RecordingAvatar : MonoBehaviour, IRecordingSerializable
{
	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int PacketSequence;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string avatarData;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool hasChanged;

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x22C3748", Offset = "0x22C3748", VA = "0x22C3748")]
	private void Awake()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x22C3808", Offset = "0x22C3808", VA = "0x22C3808")]
	private void Start()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x22C3954", Offset = "0x22C3954", VA = "0x22C3954")]
	public void StartRecording()
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x22C3A34", Offset = "0x22C3A34", VA = "0x22C3A34")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x22C3B50", Offset = "0x22C3B50", VA = "0x22C3B50", Slot = "4")]
	public string SerializeWrite()
	{
		return null;
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x22C3B68", Offset = "0x22C3B68", VA = "0x22C3B68", Slot = "5")]
	public void SerializeRead(params string[] objects)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x22C3CB4", Offset = "0x22C3CB4", VA = "0x22C3CB4")]
	public RecordingAvatar()
	{
	}
}
[Token(Token = "0x2000084")]
public class RecordingController : MonoBehaviour, IPoolable
{
	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string prefabName;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject linkedObject;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isRecording;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool isReplaying;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool hasNoParent;

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x22C3CBC", Offset = "0x22C3CBC", VA = "0x22C3CBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x22C423C", Offset = "0x22C423C", VA = "0x22C423C", Slot = "4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x22C4248", Offset = "0x22C4248", VA = "0x22C4248")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x22C44A4", Offset = "0x22C44A4", VA = "0x22C44A4")]
	public RecordingController()
	{
	}
}
[Token(Token = "0x2000085")]
public class RecordingManager : MonoBehaviour
{
	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28138", Offset = "0xD28138")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject hand;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x22C4B90", Offset = "0x22C4B90", VA = "0x22C4B90")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x22C93FC", Offset = "0x22C93FC", VA = "0x22C93FC")]
		internal bool <HideHands>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28148", Offset = "0xD28148")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Animator anim;

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x22C4D0C", Offset = "0x22C4D0C", VA = "0x22C4D0C")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x22C9484", Offset = "0x22C9484", VA = "0x22C9484")]
		internal bool <AnimationState>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28158", Offset = "0xD28158")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject textureChangeObj;

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x22C4F44", Offset = "0x22C4F44", VA = "0x22C4F44")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x22C9520", Offset = "0x22C9520", VA = "0x22C9520")]
		internal bool <TextureChange>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28168", Offset = "0xD28168")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject colorChangeObj;

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x22C50D8", Offset = "0x22C50D8", VA = "0x22C50D8")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x22C95BC", Offset = "0x22C95BC", VA = "0x22C95BC")]
		internal bool <ColorChange>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200016B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28178", Offset = "0xD28178")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x22C52C8", Offset = "0x22C52C8", VA = "0x22C52C8")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x22C9658", Offset = "0x22C9658", VA = "0x22C9658")]
		internal bool <DoAction>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200016C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28188", Offset = "0xD28188")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x22C5440", Offset = "0x22C5440", VA = "0x22C5440")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x22C96E0", Offset = "0x22C96E0", VA = "0x22C96E0")]
		internal bool <AddRPC>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200016D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28198", Offset = "0xD28198")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x22C55EC", Offset = "0x22C55EC", VA = "0x22C55EC")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x22C9768", Offset = "0x22C9768", VA = "0x22C9768")]
		internal bool <AddRPC>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200016E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD281A8", Offset = "0xD281A8")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x22C5744", Offset = "0x22C5744", VA = "0x22C5744")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x22C97F0", Offset = "0x22C97F0", VA = "0x22C97F0")]
		internal bool <SetCutOffValue>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200016F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD281B8", Offset = "0xD281B8")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x22C58B4", Offset = "0x22C58B4", VA = "0x22C58B4")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x22C9878", Offset = "0x22C9878", VA = "0x22C9878")]
		internal bool <ParticlesPlay>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD281C8", Offset = "0xD281C8")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject otherGameObject;

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x22C5A88", Offset = "0x22C5A88", VA = "0x22C5A88")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x22C9900", Offset = "0x22C9900", VA = "0x22C9900")]
		internal bool <SnapRecording>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x22C9988", Offset = "0x22C9988", VA = "0x22C9988")]
		internal bool <SnapRecording>b__1(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD281D8", Offset = "0xD281D8")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x22C9094", Offset = "0x22C9094", VA = "0x22C9094")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x22C9A10", Offset = "0x22C9A10", VA = "0x22C9A10")]
		internal bool <GetRecordingObject>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000172")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD281E8", Offset = "0xD281E8")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x22C909C", Offset = "0x22C909C", VA = "0x22C909C")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x22C9A98", Offset = "0x22C9A98", VA = "0x22C9A98")]
		internal bool <RemoveRecordingObject>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000173")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD281F8", Offset = "0xD281F8")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x22C91E4", Offset = "0x22C91E4", VA = "0x22C91E4")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x22C9B20", Offset = "0x22C9B20", VA = "0x22C9B20")]
		internal bool <MachineParticles>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000174")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28208", Offset = "0xD28208")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x22C932C", Offset = "0x22C932C", VA = "0x22C932C")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x22C9BA8", Offset = "0x22C9BA8", VA = "0x22C9BA8")]
		internal bool <FraiesPackFill>b__0(RecordingObjects recordingObject)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string dataPath;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string filename;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string saveDirectory;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RecordingManager instance;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RecordingData> recordingData;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RecordingObjects> recordingObjects;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture[] textures;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isRecording;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float currentTime;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int lastObjectId;

	[Token(Token = "0x1700000A")]
	public bool isAsync
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x22C38E4", Offset = "0x22C38E4", VA = "0x22C38E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x22C44BC", Offset = "0x22C44BC", VA = "0x22C44BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x22C4614", Offset = "0x22C4614", VA = "0x22C4614")]
	private void Start()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x22C4848", Offset = "0x22C4848", VA = "0x22C4848")]
	public void StartRecording()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x22C499C", Offset = "0x22C499C", VA = "0x22C499C")]
	private void OrderFinished()
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x22C4A28", Offset = "0x22C4A28", VA = "0x22C4A28")]
	public void HideHands(GameObject hand, bool isEnabled)
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x22C4B98", Offset = "0x22C4B98", VA = "0x22C4B98")]
	public void AnimationState(Animator anim, string stateName, int stateInt)
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x22C4D14", Offset = "0x22C4D14", VA = "0x22C4D14")]
	public void TextureChange(GameObject textureChangeObj, Texture mainTexture, Texture decalTexture)
	{
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x22C4F4C", Offset = "0x22C4F4C", VA = "0x22C4F4C")]
	public void ColorChange(GameObject colorChangeObj, bool isEnabled, float Colorr, float Colorg, float Colorb, float Colora, float fill)
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x22C50E0", Offset = "0x22C50E0", VA = "0x22C50E0")]
	public void EndGame()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x22C516C", Offset = "0x22C516C", VA = "0x22C516C")]
	public void DoAction(GameObject gameObject, bool isEnabled, int state)
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x22C52D0", Offset = "0x22C52D0", VA = "0x22C52D0")]
	public void AddRPC(GameObject gameObject, string rpcName)
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x22C5448", Offset = "0x22C5448", VA = "0x22C5448")]
	public void AddRPC(GameObject gameObject, string rpcName, params object[] objects)
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x22C55F4", Offset = "0x22C55F4", VA = "0x22C55F4")]
	public void SetCutOffValue(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x22C574C", Offset = "0x22C574C", VA = "0x22C574C")]
	public void ParticlesPlay(GameObject gameObject, bool spill)
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x22C58BC", Offset = "0x22C58BC", VA = "0x22C58BC")]
	public void SnapRecording(GameObject gameObject, GameObject otherGameObject)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x22C5A90", Offset = "0x22C5A90", VA = "0x22C5A90")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x22C5AD8", Offset = "0x22C5AD8", VA = "0x22C5AD8")]
	public void RecordData()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x22C6508", Offset = "0x22C6508", VA = "0x22C6508")]
	public string SaveRecordedData()
	{
		return null;
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x22C8F40", Offset = "0x22C8F40", VA = "0x22C8F40")]
	public string getAbsolutePath(string filename)
	{
		return null;
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x22C3F18", Offset = "0x22C3F18", VA = "0x22C3F18")]
	public void AddToRecordingObjects(GameObject gameObject)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x22C8FC4", Offset = "0x22C8FC4", VA = "0x22C8FC4")]
	public RecordingObjects GetRecordingObject(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x22C430C", Offset = "0x22C430C", VA = "0x22C430C")]
	public void RemoveRecordingObject(GameObject gameObject)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x22C90A4", Offset = "0x22C90A4", VA = "0x22C90A4")]
	public void MachineParticles(GameObject gameObject)
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x22C91EC", Offset = "0x22C91EC", VA = "0x22C91EC")]
	public void FraiesPackFill(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x22C9334", Offset = "0x22C9334", VA = "0x22C9334")]
	public RecordingManager()
	{
	}
}
[Token(Token = "0x2000086")]
public class RecordingPrefabData : MonoBehaviour
{
	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] prefabs;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ReplayManager replayManager;

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x22CADFC", Offset = "0x22CADFC", VA = "0x22CADFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x22CAE28", Offset = "0x22CAE28", VA = "0x22CAE28")]
	private void Update()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x22CAE2C", Offset = "0x22CAE2C", VA = "0x22CAE2C")]
	public RecordingPrefabData()
	{
	}
}
[Token(Token = "0x2000087")]
public class RecordingStaticManager : MonoBehaviour
{
	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RecordingController[] recordingObjects;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RecordingStaticManager instance;

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x22CAE34", Offset = "0x22CAE34", VA = "0x22CAE34")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x22CAEE0", Offset = "0x22CAEE0", VA = "0x22CAEE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x22C4698", Offset = "0x22C4698", VA = "0x22C4698")]
	public void AddToRecording()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x22CAF90", Offset = "0x22CAF90", VA = "0x22CAF90")]
	public RecordingStaticManager()
	{
	}
}
[Token(Token = "0x2000088")]
public class ReplayManager : MonoBehaviour
{
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28218", Offset = "0xD28218")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ReplayManager <>4__this;

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x22CDA30", Offset = "0x22CDA30", VA = "0x22CDA30")]
		public <>c__DisplayClass22_0()
		{
		}
	}

	[Token(Token = "0x2000176")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28228", Offset = "0xD28228")]
	private sealed class <>c__DisplayClass22_1
	{
		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int j;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public <>c__DisplayClass22_0 CS$<>8__locals1;

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x22CDA38", Offset = "0x22CDA38", VA = "0x22CDA38")]
		public <>c__DisplayClass22_1()
		{
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x22D0764", Offset = "0x22D0764", VA = "0x22D0764")]
		internal bool <ReplayData>b__0(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28238", Offset = "0xD28238")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x22D05A0", Offset = "0x22D05A0", VA = "0x22D05A0")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x22D0838", Offset = "0x22D0838", VA = "0x22D0838")]
		internal bool <LoadData>b__0(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28248", Offset = "0xD28248")]
	private sealed class <>c__DisplayClass27_1
	{
		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x22D05A8", Offset = "0x22D05A8", VA = "0x22D05A8")]
		public <>c__DisplayClass27_1()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x22D085C", Offset = "0x22D085C", VA = "0x22D085C")]
		internal bool <LoadData>b__1(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28258", Offset = "0xD28258")]
	private sealed class <>c__DisplayClass27_2
	{
		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x22D05B0", Offset = "0x22D05B0", VA = "0x22D05B0")]
		public <>c__DisplayClass27_2()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x22D0934", Offset = "0x22D0934", VA = "0x22D0934")]
		internal bool <LoadData>b__2(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200017A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28268", Offset = "0xD28268")]
	private sealed class <>c__DisplayClass27_3
	{
		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x22D05B8", Offset = "0x22D05B8", VA = "0x22D05B8")]
		public <>c__DisplayClass27_3()
		{
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x22D0958", Offset = "0x22D0958", VA = "0x22D0958")]
		internal bool <LoadData>b__3(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200017B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28278", Offset = "0xD28278")]
	private sealed class <>c__DisplayClass27_4
	{
		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x22D05C0", Offset = "0x22D05C0", VA = "0x22D05C0")]
		public <>c__DisplayClass27_4()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x22D097C", Offset = "0x22D097C", VA = "0x22D097C")]
		internal bool <LoadData>b__4(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28288", Offset = "0xD28288")]
	private sealed class <>c__DisplayClass27_5
	{
		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x22D05C8", Offset = "0x22D05C8", VA = "0x22D05C8")]
		public <>c__DisplayClass27_5()
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x22D09A0", Offset = "0x22D09A0", VA = "0x22D09A0")]
		internal bool <LoadData>b__5(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200017D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28298", Offset = "0xD28298")]
	private sealed class <>c__DisplayClass27_6
	{
		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x22D05D0", Offset = "0x22D05D0", VA = "0x22D05D0")]
		public <>c__DisplayClass27_6()
		{
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x22D09C4", Offset = "0x22D09C4", VA = "0x22D09C4")]
		internal bool <LoadData>b__6(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200017E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD282A8", Offset = "0xD282A8")]
	private sealed class <>c__DisplayClass27_7
	{
		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x22D05D8", Offset = "0x22D05D8", VA = "0x22D05D8")]
		public <>c__DisplayClass27_7()
		{
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x22D09E8", Offset = "0x22D09E8", VA = "0x22D09E8")]
		internal bool <LoadData>b__7(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200017F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD282B8", Offset = "0xD282B8")]
	private sealed class <>c__DisplayClass27_8
	{
		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x22D05E0", Offset = "0x22D05E0", VA = "0x22D05E0")]
		public <>c__DisplayClass27_8()
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x22D0A0C", Offset = "0x22D0A0C", VA = "0x22D0A0C")]
		internal bool <LoadData>b__8(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000180")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD282C8", Offset = "0xD282C8")]
	private sealed class <>c__DisplayClass27_9
	{
		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x22D05E8", Offset = "0x22D05E8", VA = "0x22D05E8")]
		public <>c__DisplayClass27_9()
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x22D0A30", Offset = "0x22D0A30", VA = "0x22D0A30")]
		internal bool <LoadData>b__9(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000181")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD282D8", Offset = "0xD282D8")]
	private sealed class <>c__DisplayClass27_10
	{
		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x22D05F0", Offset = "0x22D05F0", VA = "0x22D05F0")]
		public <>c__DisplayClass27_10()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x22D0880", Offset = "0x22D0880", VA = "0x22D0880")]
		internal bool <LoadData>b__10(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000182")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD282E8", Offset = "0xD282E8")]
	private sealed class <>c__DisplayClass27_11
	{
		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x22D05F8", Offset = "0x22D05F8", VA = "0x22D05F8")]
		public <>c__DisplayClass27_11()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x22D08A4", Offset = "0x22D08A4", VA = "0x22D08A4")]
		internal bool <LoadData>b__11(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000183")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD282F8", Offset = "0xD282F8")]
	private sealed class <>c__DisplayClass27_12
	{
		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x22D0600", Offset = "0x22D0600", VA = "0x22D0600")]
		public <>c__DisplayClass27_12()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x22D08C8", Offset = "0x22D08C8", VA = "0x22D08C8")]
		internal bool <LoadData>b__12(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28308", Offset = "0xD28308")]
	private sealed class <>c__DisplayClass27_13
	{
		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x22D0608", Offset = "0x22D0608", VA = "0x22D0608")]
		public <>c__DisplayClass27_13()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x22D08EC", Offset = "0x22D08EC", VA = "0x22D08EC")]
		internal bool <LoadData>b__13(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000185")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28318", Offset = "0xD28318")]
	private sealed class <>c__DisplayClass27_14
	{
		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int objectId;

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x22D0610", Offset = "0x22D0610", VA = "0x22D0610")]
		public <>c__DisplayClass27_14()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x22D0910", Offset = "0x22D0910", VA = "0x22D0910")]
		internal bool <LoadData>b__14(ReplayObject it)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string replayFile;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string replayFileFromServer;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string replayFilename;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float replayTime;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool isPlaying;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float rotation;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float speedMultiplayer;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<ReplayObject> replayObjects;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject recordingCenter;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject replayingCenter;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static char TYPE_ADD_TO_RECORDING_OBJECTS;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static char TYPE_RECORD_DATA;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static char TYPE_ORDER_FINISHED;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
	public static char TYPE_REMOVE_RECORNING_OBJECT;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static char TYPE_ANIMATION;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
	public static char TYPE_CALL_RPC;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static char TYPE_WAITER_ID;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool initializedUnique;

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x22CAFA0", Offset = "0x22CAFA0", VA = "0x22CAFA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x22CAFA4", Offset = "0x22CAFA4", VA = "0x22CAFA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x22CB054", Offset = "0x22CB054", VA = "0x22CB054")]
	private void InitializeUniqueIds()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x22CB0D4", Offset = "0x22CB0D4", VA = "0x22CB0D4")]
	private void Update()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x22CB124", Offset = "0x22CB124", VA = "0x22CB124")]
	public void ReplayData()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x22CDB70", Offset = "0x22CDB70", VA = "0x22CDB70")]
	public void ChangeTexture(GameObject replayObject, int mainTextureIndex, int decalTextureIndex)
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x22CDA40", Offset = "0x22CDA40", VA = "0x22CDA40")]
	public void StopGame()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x22CDD2C", Offset = "0x22CDD2C", VA = "0x22CDD2C")]
	public void StartReplayingFromFile(string filename)
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x22CDE94", Offset = "0x22CDE94", VA = "0x22CDE94")]
	public void StartReplayingFromString(string data)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x22CDEBC", Offset = "0x22CDEBC", VA = "0x22CDEBC")]
	private void LoadData(string dataString)
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x22D0618", Offset = "0x22D0618", VA = "0x22D0618")]
	public ReplayManager()
	{
	}
}
[Token(Token = "0x2000089")]
public class ReplayUploader : MonoBehaviour
{
	[Token(Token = "0x2000186")]
	private class UploadData
	{
		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string filename;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int matchId;

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x22D0F40", Offset = "0x22D0F40", VA = "0x22D0F40")]
		public UploadData()
		{
		}
	}

	[Token(Token = "0x2000187")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28328", Offset = "0xD28328")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UploadData uploadData;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ReplayUploader <>4__this;

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x22D110C", Offset = "0x22D110C", VA = "0x22D110C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x22D1498", Offset = "0x22D1498", VA = "0x22D1498")]
		internal void <Update>b__0(bool success)
		{
		}
	}

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<UploadData> gamesToUpload;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool Uploading;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string saveFile;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ReplayUploader s_instance;

	[Token(Token = "0x1700000B")]
	public static ReplayUploader Instance
	{
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x22D0A54", Offset = "0x22D0A54", VA = "0x22D0A54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x22D0B20", Offset = "0x22D0B20", VA = "0x22D0B20")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x22D0C3C", Offset = "0x22D0C3C", VA = "0x22D0C3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x22D0F48", Offset = "0x22D0F48", VA = "0x22D0F48")]
	private void Update()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x22D1114", Offset = "0x22D1114", VA = "0x22D1114")]
	public void AddGameToQueue(string filename, int matchId)
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x22D1214", Offset = "0x22D1214", VA = "0x22D1214")]
	private void SaveCachedData()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x22D1404", Offset = "0x22D1404", VA = "0x22D1404")]
	public ReplayUploader()
	{
	}
}
[Token(Token = "0x200008A")]
public class ObjectActivator : MonoBehaviour
{
	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isObjActivate;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject objectToDeactivate;

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x22ADE78", Offset = "0x22ADE78", VA = "0x22ADE78")]
	private void Start()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x22ADEB0", Offset = "0x22ADEB0", VA = "0x22ADEB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x22ADE88", Offset = "0x22ADE88", VA = "0x22ADE88")]
	public void DeactivateObject()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x22ADEB4", Offset = "0x22ADEB4", VA = "0x22ADEB4")]
	public void DeactivatePublicObject()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x22ADF4C", Offset = "0x22ADF4C", VA = "0x22ADF4C")]
	public ObjectActivator()
	{
	}
}
[Token(Token = "0x200008B")]
public class PhotonButtons : MonoBehaviour
{
	[Token(Token = "0x6000450")]
	[Address(RVA = "0x22B99D0", Offset = "0x22B99D0", VA = "0x22B99D0")]
	public void onClickJoinRoom()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x22B9AE4", Offset = "0x22B9AE4", VA = "0x22B9AE4")]
	public PhotonButtons()
	{
	}
}
[Token(Token = "0x200008C")]
public abstract class AbstractPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000188")]
	public delegate void AcquiredID(string id);

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string avatarId;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AcquiredID acquiredIdEvent;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityAction<ulong, string> inviteCallback;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isPaused;

	[Token(Token = "0x6000452")]
	public abstract bool IsInitialized();

	[Token(Token = "0x6000453")]
	public abstract bool ShowLeaderboards();

	[Token(Token = "0x6000454")]
	public abstract bool ShowInvite();

	[Token(Token = "0x6000455")]
	public abstract bool ShowAsyncronousMultiplayer();

	[Token(Token = "0x6000456")]
	public abstract void Initialize(UnityAction callback);

	[Token(Token = "0x6000457")]
	public abstract void FillLoginData(WWWForm form);

	[Token(Token = "0x6000458")]
	public abstract string GetID();

	[Token(Token = "0x6000459")]
	public abstract string GetName();

	[Token(Token = "0x600045A")]
	public abstract string GetRoomCode();

	[Token(Token = "0x600045B")]
	public abstract void GetFriendsList(Action<Dictionary<ulong, string>> callback);

	[Token(Token = "0x600045C")]
	public abstract void InviteFriendToGame(ulong id);

	[Token(Token = "0x600045D")]
	public abstract void JoinInvitedGame();

	[Token(Token = "0x600045E")]
	public abstract void CancelInvite();

	[Token(Token = "0x600045F")]
	[Address(RVA = "0xE03C00", Offset = "0xE03C00", VA = "0xE03C00", Slot = "17")]
	public virtual void DeclineInvite()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0xE03C04", Offset = "0xE03C04", VA = "0xE03C04", Slot = "18")]
	public virtual string GetAvatarId()
	{
		return null;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0xE03C0C", Offset = "0xE03C0C", VA = "0xE03C0C", Slot = "19")]
	public virtual Language GetLanguage()
	{
		return default(Language);
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0xE04044", Offset = "0xE04044", VA = "0xE04044", Slot = "20")]
	public virtual void ReportMatchEnd(int restuarant, int mode, int level, bool win, int score, int happyCount, int indieCount, int madCount, int customersLeft)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0xE04048", Offset = "0xE04048", VA = "0xE04048", Slot = "21")]
	public virtual void SetLocation(string locationId)
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0xE0404C", Offset = "0xE0404C", VA = "0xE0404C", Slot = "22")]
	public virtual void AchievementAddCount(AchievementsInfo.Type type, int step)
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0xE04050", Offset = "0xE04050", VA = "0xE04050", Slot = "23")]
	public virtual void AchievementUnlock(AchievementsInfo.Type type)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0xE04054", Offset = "0xE04054", VA = "0xE04054")]
	protected AbstractPlatformManager()
	{
	}
}
[Token(Token = "0x200008D")]
public class ControllerSetup : MonoBehaviour
{
	[Token(Token = "0x2000189")]
	public enum ControlerState
	{
		[Token(Token = "0x4000831")]
		NONE,
		[Token(Token = "0x4000832")]
		CONTROLLER,
		[Token(Token = "0x4000833")]
		HANDS
	}

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 _spawnOffset;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ControlerState controlerState;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private VRTK_Pointer pointer;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private VRTK_UIPointer uiPointer;

	[Token(Token = "0x1700000C")]
	public Vector3 spawnOffset
	{
		[Token(Token = "0x6000467")]
		[Address(RVA = "0xE1665C", Offset = "0xE1665C", VA = "0xE1665C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0xE166DC", Offset = "0xE166DC", VA = "0xE166DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0xE16760", Offset = "0xE16760", VA = "0xE16760")]
	public void Update()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xE16908", Offset = "0xE16908", VA = "0xE16908")]
	public ControllerSetup()
	{
	}
}
[Token(Token = "0x200008E")]
public class CtrlVManager : AbstractPlatformManager
{
	[Serializable]
	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28338", Offset = "0xD28338")]
	private sealed class <>c
	{
		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<PlayerData, bool> <>9__16_0;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<PlayerData, ulong> <>9__16_1;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<PlayerData, string> <>9__16_2;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xE17A4C", Offset = "0xE17A4C", VA = "0xE17A4C")]
		public <>c()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xE17A54", Offset = "0xE17A54", VA = "0xE17A54")]
		internal bool <GetFriendsList>b__16_0(PlayerData p)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xE17A6C", Offset = "0xE17A6C", VA = "0xE17A6C")]
		internal ulong <GetFriendsList>b__16_1(PlayerData item)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xE17A88", Offset = "0xE17A88", VA = "0xE17A88")]
		internal string <GetFriendsList>b__16_2(PlayerData item)
		{
			return null;
		}
	}

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool shouldShowLeaderboards;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool shouldShowInvite;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool shouldShowAsyncronousMultiplayer;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string platformName;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string username;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string id;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string roomCode;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private UnityAction callback;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public PlayerNameEditor playerNameEditor;

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xE16F20", Offset = "0xE16F20", VA = "0xE16F20", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xE170F4", Offset = "0xE170F4", VA = "0xE170F4")]
	public void ChangeUsername(string newUsername)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xE170FC", Offset = "0xE170FC", VA = "0xE170FC")]
	private void OnLogin()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xE17180", Offset = "0xE17180", VA = "0xE17180", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xE17188", Offset = "0xE17188", VA = "0xE17188", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xE171F0", Offset = "0xE171F0", VA = "0xE171F0", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xE17258", Offset = "0xE17258", VA = "0xE17258", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xE172C0", Offset = "0xE172C0", VA = "0xE172C0", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xE17560", Offset = "0xE17560", VA = "0xE17560", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xE17624", Offset = "0xE17624", VA = "0xE17624", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xE17754", Offset = "0xE17754", VA = "0xE17754", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xE1775C", Offset = "0xE1775C", VA = "0xE1775C", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xE17764", Offset = "0xE17764", VA = "0xE17764", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xE1776C", Offset = "0xE1776C", VA = "0xE1776C", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xE177DC", Offset = "0xE177DC", VA = "0xE177DC", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xE177E0", Offset = "0xE177E0", VA = "0xE177E0", Slot = "20")]
	public override void ReportMatchEnd(int restuarant, int mode, int level, bool win, int score, int happyCount, int indieCount, int madCount, int customersLeft)
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xE178D8", Offset = "0xE178D8", VA = "0xE178D8")]
	public CtrlVManager()
	{
	}
}
[Token(Token = "0x200008F")]
public enum Language
{
	[Token(Token = "0x4000403")]
	EN,
	[Token(Token = "0x4000404")]
	FR,
	[Token(Token = "0x4000405")]
	JA,
	[Token(Token = "0x4000406")]
	KO,
	[Token(Token = "0x4000407")]
	IT,
	[Token(Token = "0x4000408")]
	DE,
	[Token(Token = "0x4000409")]
	RU,
	[Token(Token = "0x400040A")]
	ZH,
	[Token(Token = "0x400040B")]
	ES
}
[Token(Token = "0x2000090")]
public static class LanguageExtensions
{
	[Token(Token = "0x600047D")]
	[Address(RVA = "0xD9ABAC", Offset = "0xD9ABAC", VA = "0xD9ABAC")]
	public static Language FromAndroidString(string languageCode)
	{
		return default(Language);
	}
}
[Token(Token = "0x2000091")]
public class NetviosManager : AbstractPlatformManager
{
	[Token(Token = "0x200018B")]
	public delegate void NetViosSDK_OnInitCompleteFP(int code, string sdkData);

	[Token(Token = "0x200018C")]
	public delegate void NetViosSDK_OnDataReportCompleteFP(int code, string respData);

	[Serializable]
	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28348", Offset = "0xD28348")]
	private sealed class <>c
	{
		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<PlayerData, bool> <>9__35_0;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<PlayerData, ulong> <>9__35_1;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<PlayerData, string> <>9__35_2;

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x22AB61C", Offset = "0x22AB61C", VA = "0x22AB61C")]
		public <>c()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x22AB624", Offset = "0x22AB624", VA = "0x22AB624")]
		internal bool <GetFriendsList>b__35_0(PlayerData p)
		{
			return default(bool);
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x22AB63C", Offset = "0x22AB63C", VA = "0x22AB63C")]
		internal ulong <GetFriendsList>b__35_1(PlayerData item)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x22AB658", Offset = "0x22AB658", VA = "0x22AB658")]
		internal string <GetFriendsList>b__35_2(PlayerData item)
		{
			return null;
		}
	}

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool shouldShowLeaderboards;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool shouldShowInvite;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool shouldShowAsyncronousMultiplayer;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string platformName;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string username;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string id;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string roomCode;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ulong currentLobby;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string appId;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string appSecret;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private UnityAction callback;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public PlayerNameEditor playerNameEditor;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool ShouldStartSDK;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private NetViosSDK_OnInitCompleteFP netviosCallback;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private NetViosSDK_OnDataReportCompleteFP netviosReportCallback;

	[PreserveSig]
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x22AA208", Offset = "0x22AA208", VA = "0x22AA208")]
	private static extern void NetViosSDK_Init(string appID, string appKey, NetViosSDK_OnInitCompleteFP onInitComplete);

	[PreserveSig]
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x22AA2D0", Offset = "0x22AA2D0", VA = "0x22AA2D0")]
	private static extern void NetViosSDK_Start();

	[PreserveSig]
	[Token(Token = "0x6000480")]
	[Address(RVA = "0x22AA340", Offset = "0x22AA340", VA = "0x22AA340")]
	private static extern void NetViosSDK_Close();

	[PreserveSig]
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x22AA3B0", Offset = "0x22AA3B0", VA = "0x22AA3B0")]
	private static extern int NetViosSDK_IsInitialized();

	[PreserveSig]
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x22AA424", Offset = "0x22AA424", VA = "0x22AA424")]
	private static extern void NetViosSDK_ReportGameData(string gameName, string appID, string appKey, string data, NetViosSDK_OnDataReportCompleteFP onInitComplete);

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x22AA52C", Offset = "0x22AA52C", VA = "0x22AA52C")]
	private void OnInitComplete(int code, string sdkData)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x22AA734", Offset = "0x22AA734", VA = "0x22AA734")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x22AA890", Offset = "0x22AA890", VA = "0x22AA890")]
	private void Start()
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x22AA894", Offset = "0x22AA894", VA = "0x22AA894")]
	private void Update()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x22AA938", Offset = "0x22AA938", VA = "0x22AA938")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x22AA994", Offset = "0x22AA994", VA = "0x22AA994", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x22AABA4", Offset = "0x22AABA4", VA = "0x22AABA4")]
	public void ChangeUsername(string newUsername)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x22AABAC", Offset = "0x22AABAC", VA = "0x22AABAC")]
	private void OnLogin()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x22AAC30", Offset = "0x22AAC30", VA = "0x22AAC30")]
	private void OnLoginFailed()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x22AACFC", Offset = "0x22AACFC", VA = "0x22AACFC", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x22AAD04", Offset = "0x22AAD04", VA = "0x22AAD04", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x22AAD6C", Offset = "0x22AAD6C", VA = "0x22AAD6C", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x22AADD4", Offset = "0x22AADD4", VA = "0x22AADD4", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x22AAE3C", Offset = "0x22AAE3C", VA = "0x22AAE3C", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x22AB0DC", Offset = "0x22AB0DC", VA = "0x22AB0DC", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x22AB18C", Offset = "0x22AB18C", VA = "0x22AB18C", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x22AB2BC", Offset = "0x22AB2BC", VA = "0x22AB2BC", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x22AB2C4", Offset = "0x22AB2C4", VA = "0x22AB2C4", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x22AB2CC", Offset = "0x22AB2CC", VA = "0x22AB2CC", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x22AB2D4", Offset = "0x22AB2D4", VA = "0x22AB2D4", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x22AB344", Offset = "0x22AB344", VA = "0x22AB344", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x22AB348", Offset = "0x22AB348", VA = "0x22AB348", Slot = "19")]
	public override Language GetLanguage()
	{
		return default(Language);
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x22AB350", Offset = "0x22AB350", VA = "0x22AB350", Slot = "20")]
	public override void ReportMatchEnd(int restuarant, int mode, int level, bool win, int score, int happyCount, int indieCount, int madCount, int customersLeft)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x22AB478", Offset = "0x22AB478", VA = "0x22AB478")]
	public NetviosManager()
	{
	}
}
[Token(Token = "0x2000092")]
public class OculusManager : AbstractPlatformManager
{
	[Serializable]
	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28358", Offset = "0xD28358")]
	private sealed class <>c
	{
		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Message<string>.Callback <>9__40_1;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Message<Oculus.Platform.Models.Room>.Callback <>9__54_0;

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x22B3334", Offset = "0x22B3334", VA = "0x22B3334")]
		public <>c()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x22B333C", Offset = "0x22B333C", VA = "0x22B333C")]
		internal void <Initialize>b__40_1(Message<string> msg)
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x22B338C", Offset = "0x22B338C", VA = "0x22B338C")]
		internal void <JoinInvitedGame>b__54_0(Message<Oculus.Platform.Models.Room> msgRoom)
		{
		}
	}

	[Token(Token = "0x200018F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28368", Offset = "0xD28368")]
	private sealed class <>c__DisplayClass51_0
	{
		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OculusManager <>4__this;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Dictionary<ulong, string>> callback;

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x22B25D0", Offset = "0x22B25D0", VA = "0x22B25D0")]
		public <>c__DisplayClass51_0()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x22B34A4", Offset = "0x22B34A4", VA = "0x22B34A4")]
		internal void <GetFriendsList>b__0(Message<Oculus.Platform.Models.Room> msg)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x22B3584", Offset = "0x22B3584", VA = "0x22B3584")]
		internal void <GetFriendsList>b__1(Message<UserList> msgInvite)
		{
		}
	}

	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28378", Offset = "0xD28378")]
	private sealed class <>c__DisplayClass52_0
	{
		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OculusManager <>4__this;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong id;

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x22B289C", Offset = "0x22B289C", VA = "0x22B289C")]
		public <>c__DisplayClass52_0()
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x22B389C", Offset = "0x22B389C", VA = "0x22B389C")]
		internal void <InviteFriendToGame>b__0(Message<Oculus.Platform.Models.Room> msgInvite)
		{
		}
	}

	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28388", Offset = "0xD28388")]
	private sealed class <>c__DisplayClass53_0
	{
		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RoomInviteNotification roomInvite;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OculusManager <>4__this;

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x22B2AA4", Offset = "0x22B2AA4", VA = "0x22B2AA4")]
		public <>c__DisplayClass53_0()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x22B3AEC", Offset = "0x22B3AEC", VA = "0x22B3AEC")]
		internal void <OnInvited>b__0(Message<User> msgUser)
		{
		}
	}

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool shouldShowLeaderboards;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool shouldShowInvite;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool shouldShowAsyncronousMultiplayer;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string platformName;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string oculusName;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string oculusId;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string oculus_nonce;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string roomName;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ulong roomCodeName;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private ulong currentLobby;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private UnityAction callback;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<ulong, string> friendsList;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Dictionary<ulong, string> friendsTokens;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private OvrAvatarHand[] objectsToHide;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Oculus.Platform.Models.Room currentRoom;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string trackingID;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string cloudStoragePath;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private bool wasInvitedUserInRoom;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	private bool focusEventsInitialized;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
	private bool shouldLoad;

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x22B0578", Offset = "0x22B0578", VA = "0x22B0578")]
	private void Start()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x22B06AC", Offset = "0x22B06AC", VA = "0x22B06AC")]
	private void Update()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x22B07B4", Offset = "0x22B07B4", VA = "0x22B07B4")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x22B0B38", Offset = "0x22B0B38", VA = "0x22B0B38")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x22B0BF0", Offset = "0x22B0BF0", VA = "0x22B0BF0")]
	private void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x22B0E50", Offset = "0x22B0E50", VA = "0x22B0E50")]
	private void OnInputFocusLost()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x22B0AB8", Offset = "0x22B0AB8", VA = "0x22B0AB8")]
	private void OnHMDMounted()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x22B0950", Offset = "0x22B0950", VA = "0x22B0950")]
	private void OnHMDUnmounted()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x22B0EC8", Offset = "0x22B0EC8", VA = "0x22B0EC8")]
	public void PauseGame()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x22B0C70", Offset = "0x22B0C70", VA = "0x22B0C70")]
	public void ResumeGame()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x22B0D28", Offset = "0x22B0D28", VA = "0x22B0D28")]
	public void ResumeGameWithIngameMenu()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x22B0FC0", Offset = "0x22B0FC0", VA = "0x22B0FC0")]
	public void ForceReleaseOnPause()
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x22B121C", Offset = "0x22B121C", VA = "0x22B121C")]
	private void ShowObjects()
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x22B09C8", Offset = "0x22B09C8", VA = "0x22B09C8")]
	private void ShowObjects(bool show)
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x22B1224", Offset = "0x22B1224", VA = "0x22B1224", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x22B1324", Offset = "0x22B1324", VA = "0x22B1324", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x22B132C", Offset = "0x22B132C", VA = "0x22B132C", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x22B1334", Offset = "0x22B1334", VA = "0x22B1334", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x22B13D4", Offset = "0x22B13D4", VA = "0x22B13D4", Slot = "18")]
	public override string GetAvatarId()
	{
		return null;
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x22B13DC", Offset = "0x22B13DC", VA = "0x22B13DC")]
	public void GetDestinationDetails()
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x22B1B08", Offset = "0x22B1B08", VA = "0x22B1B08", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x22B1C1C", Offset = "0x22B1C1C", VA = "0x22B1C1C")]
	private void OnSaveUpdated(string savefile)
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x22B1CC8", Offset = "0x22B1CC8", VA = "0x22B1CC8")]
	private void UserProof(Message msg)
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x22B1F40", Offset = "0x22B1F40", VA = "0x22B1F40")]
	private void UserCallback(Message msg)
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x22B2108", Offset = "0x22B2108", VA = "0x22B2108", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x22B2110", Offset = "0x22B2110", VA = "0x22B2110")]
	private void OnLaunchIntentChangeNotif(Message<string> message)
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x22B1570", Offset = "0x22B1570", VA = "0x22B1570")]
	private void ProcessDeeplink(string deeplink)
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x22B2228", Offset = "0x22B2228", VA = "0x22B2228", Slot = "21")]
	public override void SetLocation(string locationId)
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x22B23A0", Offset = "0x22B23A0", VA = "0x22B23A0", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x22B2408", Offset = "0x22B2408", VA = "0x22B2408", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x22B2470", Offset = "0x22B2470", VA = "0x22B2470", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x22B24D8", Offset = "0x22B24D8", VA = "0x22B24D8", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x22B25D8", Offset = "0x22B25D8", VA = "0x22B25D8", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x22B28A4", Offset = "0x22B28A4", VA = "0x22B28A4")]
	private void OnInvited(Message<RoomInviteNotification> msg)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x22B2AAC", Offset = "0x22B2AAC", VA = "0x22B2AAC", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x22B2BFC", Offset = "0x22B2BFC", VA = "0x22B2BFC")]
	public void OnRoomUpdated(Message<Oculus.Platform.Models.Room> msgRoom)
	{
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x22B2D10", Offset = "0x22B2D10", VA = "0x22B2D10", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x22B2D28", Offset = "0x22B2D28", VA = "0x22B2D28", Slot = "17")]
	public override void DeclineInvite()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x22B2DD8", Offset = "0x22B2DD8", VA = "0x22B2DD8", Slot = "20")]
	public override void ReportMatchEnd(int restuarant, int mode, int level, bool win, int score, int happyCount, int indieCount, int madCount, int customersLeft)
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x22B2E24", Offset = "0x22B2E24", VA = "0x22B2E24", Slot = "22")]
	public override void AchievementAddCount(AchievementsInfo.Type type, int step)
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x22B2EC0", Offset = "0x22B2EC0", VA = "0x22B2EC0", Slot = "23")]
	public override void AchievementUnlock(AchievementsInfo.Type type)
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x22B2F54", Offset = "0x22B2F54", VA = "0x22B2F54")]
	public OculusManager()
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x22B30E8", Offset = "0x22B30E8", VA = "0x22B30E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A018", Offset = "0xD2A018")]
	private void <Initialize>b__40_0(Message<PlatformInitialize> initMessage)
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x22B3274", Offset = "0x22B3274", VA = "0x22B3274")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A028", Offset = "0xD2A028")]
	private void <SetLocation>b__47_0(Message message)
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x22B32C0", Offset = "0x22B32C0", VA = "0x22B32C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A038", Offset = "0xD2A038")]
	private void <DeclineInvite>b__57_0(Message<Oculus.Platform.Models.Room> msgRoom)
	{
	}
}
[Token(Token = "0x2000093")]
public class PicoCallbacks : MonoBehaviour
{
	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string IS_SUCCESS;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string MSG;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string CODE;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static UnityAction<bool> OnUserInfo;

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x22BB790", Offset = "0x22BB790", VA = "0x22BB790")]
	public void LoginCallback(string LoginInfo)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x22BB9DC", Offset = "0x22BB9DC", VA = "0x22BB9DC")]
	public void UserInfoCallback(string userInfo)
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x22BBAC4", Offset = "0x22BBAC4", VA = "0x22BBAC4")]
	public PicoCallbacks()
	{
	}
}
[Token(Token = "0x2000094")]
public class PicoManager : AbstractPlatformManager
{
	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool shouldShowLeaderboards;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool shouldShowInvite;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool shouldShowAsyncronousMultiplayer;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string platformName;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string username;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string id;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string roomCode;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private UnityAction callback;

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x22BBB60", Offset = "0x22BBB60", VA = "0x22BBB60", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x22BBC70", Offset = "0x22BBC70", VA = "0x22BBC70")]
	public void LoginCallback(bool success)
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x22BBE24", Offset = "0x22BBE24", VA = "0x22BBE24", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x22BBE2C", Offset = "0x22BBE2C", VA = "0x22BBE2C", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x22BBE94", Offset = "0x22BBE94", VA = "0x22BBE94", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x22BBEFC", Offset = "0x22BBEFC", VA = "0x22BBEFC", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x22BBF04", Offset = "0x22BBF04", VA = "0x22BBF04", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x22BBF6C", Offset = "0x22BBF6C", VA = "0x22BBF6C", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x22BBF70", Offset = "0x22BBF70", VA = "0x22BBF70", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x22BC020", Offset = "0x22BC020", VA = "0x22BC020", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x22BC0E8", Offset = "0x22BC0E8", VA = "0x22BC0E8", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x22BC0F0", Offset = "0x22BC0F0", VA = "0x22BC0F0", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x22BC0F8", Offset = "0x22BC0F8", VA = "0x22BC0F8", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x22BC168", Offset = "0x22BC168", VA = "0x22BC168", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x22BC16C", Offset = "0x22BC16C", VA = "0x22BC16C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x22BC234", Offset = "0x22BC234", VA = "0x22BC234")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x22BC2C8", Offset = "0x22BC2C8", VA = "0x22BC2C8")]
	private void HandelEntitlementCheckResult(int resultCode)
	{
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x22BC594", Offset = "0x22BC594", VA = "0x22BC594")]
	public PicoManager()
	{
	}
}
[Token(Token = "0x2000095")]
public class QiyuManager : AbstractPlatformManager
{
	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool shouldShowLeaderboards;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool shouldShowInvite;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool shouldShowAsyncronousMultiplayer;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string platformName;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string username;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string id;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string roomCode;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private UnityAction callback;

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x22C176C", Offset = "0x22C176C", VA = "0x22C176C", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x22C1774", Offset = "0x22C1774", VA = "0x22C1774", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x22C177C", Offset = "0x22C177C", VA = "0x22C177C", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x22C17E4", Offset = "0x22C17E4", VA = "0x22C17E4", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x22C184C", Offset = "0x22C184C", VA = "0x22C184C", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x22C1854", Offset = "0x22C1854", VA = "0x22C1854", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x22C18BC", Offset = "0x22C18BC", VA = "0x22C18BC", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x22C18C0", Offset = "0x22C18C0", VA = "0x22C18C0", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x22C1970", Offset = "0x22C1970", VA = "0x22C1970", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x22C1A38", Offset = "0x22C1A38", VA = "0x22C1A38", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x22C1A40", Offset = "0x22C1A40", VA = "0x22C1A40", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x22C1A48", Offset = "0x22C1A48", VA = "0x22C1A48", Slot = "19")]
	public override Language GetLanguage()
	{
		return default(Language);
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x22C1A50", Offset = "0x22C1A50", VA = "0x22C1A50", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x22C1AC0", Offset = "0x22C1AC0", VA = "0x22C1AC0", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x22C1AC4", Offset = "0x22C1AC4", VA = "0x22C1AC4")]
	public QiyuManager()
	{
	}
}
[Token(Token = "0x2000096")]
public class SpringboardManager : AbstractPlatformManager
{
	[Serializable]
	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28398", Offset = "0xD28398")]
	private sealed class <>c
	{
		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<PlayerData, bool> <>9__16_0;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<PlayerData, ulong> <>9__16_1;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<PlayerData, string> <>9__16_2;

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x22FF8C4", Offset = "0x22FF8C4", VA = "0x22FF8C4")]
		public <>c()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x22FF8CC", Offset = "0x22FF8CC", VA = "0x22FF8CC")]
		internal bool <GetFriendsList>b__16_0(PlayerData p)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x22FF8E4", Offset = "0x22FF8E4", VA = "0x22FF8E4")]
		internal ulong <GetFriendsList>b__16_1(PlayerData item)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x22FF900", Offset = "0x22FF900", VA = "0x22FF900")]
		internal string <GetFriendsList>b__16_2(PlayerData item)
		{
			return null;
		}
	}

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string authTicket;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool shouldShowLeaderboards;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool shouldShowInvite;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool shouldShowAsyncronousMultiplayer;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string platformName;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string username;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string id;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string roomCode;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private ulong currentLobby;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private UnityAction callback;

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x22FED0C", Offset = "0x22FED0C", VA = "0x22FED0C", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x22FEF6C", Offset = "0x22FEF6C", VA = "0x22FEF6C")]
	private void OnLogin()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x22FEFF0", Offset = "0x22FEFF0", VA = "0x22FEFF0", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x22FEFF8", Offset = "0x22FEFF8", VA = "0x22FEFF8", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x22FF060", Offset = "0x22FF060", VA = "0x22FF060", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x22FF0C8", Offset = "0x22FF0C8", VA = "0x22FF0C8", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x22FF130", Offset = "0x22FF130", VA = "0x22FF130", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x22FF3D0", Offset = "0x22FF3D0", VA = "0x22FF3D0", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x22FF49C", Offset = "0x22FF49C", VA = "0x22FF49C", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x22FF5CC", Offset = "0x22FF5CC", VA = "0x22FF5CC", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x22FF5D4", Offset = "0x22FF5D4", VA = "0x22FF5D4", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x60004FC")]
	[Address(RVA = "0x22FF5DC", Offset = "0x22FF5DC", VA = "0x22FF5DC", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x60004FD")]
	[Address(RVA = "0x22FF5E4", Offset = "0x22FF5E4", VA = "0x22FF5E4", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x22FF654", Offset = "0x22FF654", VA = "0x22FF654", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x22FF658", Offset = "0x22FF658", VA = "0x22FF658", Slot = "20")]
	public override void ReportMatchEnd(int restuarant, int mode, int level, bool win, int score, int happyCount, int indieCount, int madCount, int customersLeft)
	{
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0x22FF750", Offset = "0x22FF750", VA = "0x22FF750")]
	public SpringboardManager()
	{
	}
}
[Token(Token = "0x2000097")]
public class SteamworksManager : AbstractPlatformManager
{
	[Token(Token = "0x6000502")]
	[Address(RVA = "0x2302398", Offset = "0x2302398", VA = "0x2302398", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x23023F8", Offset = "0x23023F8", VA = "0x23023F8", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x2302458", Offset = "0x2302458", VA = "0x2302458", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x23024B8", Offset = "0x23024B8", VA = "0x23024B8", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x2302518", Offset = "0x2302518", VA = "0x2302518", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x2302578", Offset = "0x2302578", VA = "0x2302578", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x23025D8", Offset = "0x23025D8", VA = "0x23025D8", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x2302638", Offset = "0x2302638", VA = "0x2302638", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x2302698", Offset = "0x2302698", VA = "0x2302698", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x23026F8", Offset = "0x23026F8", VA = "0x23026F8", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x2302758", Offset = "0x2302758", VA = "0x2302758", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x23027B8", Offset = "0x23027B8", VA = "0x23027B8", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x2302818", Offset = "0x2302818", VA = "0x2302818", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x2302878", Offset = "0x2302878", VA = "0x2302878")]
	public SteamworksManager()
	{
	}
}
[Token(Token = "0x2000098")]
public class StoveVRManager : AbstractPlatformManager
{
	[Serializable]
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD283A8", Offset = "0xD283A8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<PlayerData, bool> <>9__19_0;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<PlayerData, ulong> <>9__19_1;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<PlayerData, string> <>9__19_2;

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x2303458", Offset = "0x2303458", VA = "0x2303458")]
		public <>c()
		{
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x2303460", Offset = "0x2303460", VA = "0x2303460")]
		internal bool <GetFriendsList>b__19_0(PlayerData p)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x2303478", Offset = "0x2303478", VA = "0x2303478")]
		internal ulong <GetFriendsList>b__19_1(PlayerData item)
		{
			return default(ulong);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x2303494", Offset = "0x2303494", VA = "0x2303494")]
		internal string <GetFriendsList>b__19_2(PlayerData item)
		{
			return null;
		}
	}

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool shouldShowLeaderboards;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool shouldShowInvite;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool shouldShowAsyncronousMultiplayer;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string platformName;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string username;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string id;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string roomCode;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ulong currentLobby;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private UnityAction callback;

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x2302880", Offset = "0x2302880", VA = "0x2302880")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x2302884", Offset = "0x2302884", VA = "0x2302884")]
	private void Start()
	{
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x2302888", Offset = "0x2302888", VA = "0x2302888")]
	public void ProcessOverlayBeforeShow()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x2302894", Offset = "0x2302894", VA = "0x2302894")]
	public void ProcessOverlayAfterHide()
	{
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x23028A0", Offset = "0x23028A0", VA = "0x23028A0", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x2302B00", Offset = "0x2302B00", VA = "0x2302B00")]
	private void OnLogin()
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x2302B84", Offset = "0x2302B84", VA = "0x2302B84", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x2302B8C", Offset = "0x2302B8C", VA = "0x2302B8C", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x2302BF4", Offset = "0x2302BF4", VA = "0x2302BF4", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x2302C5C", Offset = "0x2302C5C", VA = "0x2302C5C", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x2302CC4", Offset = "0x2302CC4", VA = "0x2302CC4", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x2302F64", Offset = "0x2302F64", VA = "0x2302F64", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x2303030", Offset = "0x2303030", VA = "0x2303030", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x2303160", Offset = "0x2303160", VA = "0x2303160", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x2303168", Offset = "0x2303168", VA = "0x2303168", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x2303170", Offset = "0x2303170", VA = "0x2303170", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x2303178", Offset = "0x2303178", VA = "0x2303178", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x23031E8", Offset = "0x23031E8", VA = "0x23031E8", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x23031EC", Offset = "0x23031EC", VA = "0x23031EC", Slot = "20")]
	public override void ReportMatchEnd(int restuarant, int mode, int level, bool win, int score, int happyCount, int indieCount, int madCount, int customersLeft)
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x23032E4", Offset = "0x23032E4", VA = "0x23032E4")]
	public StoveVRManager()
	{
	}
}
[Token(Token = "0x2000099")]
public class ViveportManager : AbstractPlatformManager
{
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x10656EC", Offset = "0x10656EC", VA = "0x10656EC", Slot = "16")]
	public override void CancelInvite()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x106574C", Offset = "0x106574C", VA = "0x106574C", Slot = "9")]
	public override void FillLoginData(WWWForm form)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x10657AC", Offset = "0x10657AC", VA = "0x10657AC", Slot = "13")]
	public override void GetFriendsList(Action<Dictionary<ulong, string>> callback)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x106580C", Offset = "0x106580C", VA = "0x106580C", Slot = "10")]
	public override string GetID()
	{
		return null;
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x106586C", Offset = "0x106586C", VA = "0x106586C", Slot = "11")]
	public override string GetName()
	{
		return null;
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x10658CC", Offset = "0x10658CC", VA = "0x10658CC", Slot = "12")]
	public override string GetRoomCode()
	{
		return null;
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x106592C", Offset = "0x106592C", VA = "0x106592C", Slot = "8")]
	public override void Initialize(UnityAction callback)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x106598C", Offset = "0x106598C", VA = "0x106598C", Slot = "14")]
	public override void InviteFriendToGame(ulong id)
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x10659EC", Offset = "0x10659EC", VA = "0x10659EC", Slot = "4")]
	public override bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x1065A4C", Offset = "0x1065A4C", VA = "0x1065A4C", Slot = "15")]
	public override void JoinInvitedGame()
	{
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x1065AAC", Offset = "0x1065AAC", VA = "0x1065AAC", Slot = "6")]
	public override bool ShowInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x1065B0C", Offset = "0x1065B0C", VA = "0x1065B0C", Slot = "5")]
	public override bool ShowLeaderboards()
	{
		return default(bool);
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x1065B6C", Offset = "0x1065B6C", VA = "0x1065B6C", Slot = "7")]
	public override bool ShowAsyncronousMultiplayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x1065BCC", Offset = "0x1065BCC", VA = "0x1065BCC")]
	public ViveportManager()
	{
	}
}
[Token(Token = "0x200009A")]
public class LevelPanelController : MonoBehaviour
{
	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro levelPanelText;

	[Token(Token = "0x6000533")]
	[Address(RVA = "0xD9C6E8", Offset = "0xD9C6E8", VA = "0xD9C6E8")]
	public void ShowLevelPanel(int level)
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0xD9C7FC", Offset = "0xD9C7FC", VA = "0xD9C7FC")]
	public void ShowDojoLevelPanel()
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0xD9C868", Offset = "0xD9C868", VA = "0xD9C868")]
	public void HideLevelPanel()
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0xD9C890", Offset = "0xD9C890", VA = "0xD9C890")]
	public LevelPanelController()
	{
	}
}
[Token(Token = "0x200009B")]
public class PopupPoints : MonoBehaviourPun
{
	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject PopUpPrefab;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 offset;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Quaternion offsetRotation;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AudioSource sound;

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x22BFA7C", Offset = "0x22BFA7C", VA = "0x22BFA7C")]
	[PunRPC]
	public void ShowPopupRPC(int score, int popUpId)
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x22BFBD4", Offset = "0x22BFBD4", VA = "0x22BFBD4")]
	public void ShowPopup(int score)
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x22BFF54", Offset = "0x22BFF54", VA = "0x22BFF54")]
	public PopupPoints()
	{
	}
}
[Token(Token = "0x200009C")]
internal class TextMeshProGui
{
	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal string text;

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x105E090", Offset = "0x105E090", VA = "0x105E090")]
	public TextMeshProGui()
	{
	}
}
[Token(Token = "0x200009D")]
public class RecenterManager : MonoBehaviour
{
	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RecenterManager instance;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool recentered;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float offsetAngle;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 offsetPosition;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject activeCamera;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform[] spawnPoints;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int sign;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public GameObject vrtk;

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x22C269C", Offset = "0x22C269C", VA = "0x22C269C")]
	private void Start()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x22C2AC0", Offset = "0x22C2AC0", VA = "0x22C2AC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x22C2BBC", Offset = "0x22C2BBC", VA = "0x22C2BBC")]
	private void Update()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x22C2BC0", Offset = "0x22C2BC0", VA = "0x22C2BC0")]
	public void ShowRecenterMenu()
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x22C2724", Offset = "0x22C2724", VA = "0x22C2724")]
	public void RefreshRecenterPosition()
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x22C2CCC", Offset = "0x22C2CCC", VA = "0x22C2CCC")]
	public void RecenterPosition()
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x22C31CC", Offset = "0x22C31CC", VA = "0x22C31CC")]
	public void ClearPosition()
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x22C3400", Offset = "0x22C3400", VA = "0x22C3400")]
	public void SwitchToPosition(int position)
	{
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x22C3404", Offset = "0x22C3404", VA = "0x22C3404")]
	public RecenterManager()
	{
	}
}
[Token(Token = "0x200009E")]
public class RecenterMenu : MonoBehaviour
{
	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject activeCameraRig;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject recenterView;

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x22C3414", Offset = "0x22C3414", VA = "0x22C3414")]
	private void Start()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x22C3418", Offset = "0x22C3418", VA = "0x22C3418")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x22C341C", Offset = "0x22C341C", VA = "0x22C341C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x22C3420", Offset = "0x22C3420", VA = "0x22C3420")]
	public void HideRecenterMenu()
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x22C3440", Offset = "0x22C3440", VA = "0x22C3440")]
	private void Update()
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x22C3444", Offset = "0x22C3444", VA = "0x22C3444")]
	public RecenterMenu()
	{
	}
}
[Token(Token = "0x200009F")]
public class BurgerRecipeDefinition : RecipeDefinition
{
	[Serializable]
	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD283B8", Offset = "0xD283B8")]
	private sealed class <>c
	{
		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<int, bool> <>9__3_0;

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xE0D6D0", Offset = "0xE0D6D0", VA = "0xE0D6D0")]
		public <>c()
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xE0D6D8", Offset = "0xE0D6D8", VA = "0xE0D6D8")]
		internal bool <CheckRecipeState>b__3_0(int state)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Ingredient[] ingredients;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<GameObject> orderCards;

	[Token(Token = "0x600054A")]
	[Address(RVA = "0xE0C364", Offset = "0xE0C364", VA = "0xE0C364", Slot = "4")]
	public override bool CheckRecipe(List<GameObject> objectPlaced)
	{
		return default(bool);
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0xE0C3F0", Offset = "0xE0C3F0", VA = "0xE0C3F0", Slot = "6")]
	public override int[][] CheckRecipeState(List<GameObject> objectsPlaced)
	{
		return null;
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0xE0C8D8", Offset = "0xE0C8D8", VA = "0xE0C8D8")]
	private int[] IsGood(GameObject objectPlaced)
	{
		return null;
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0xE0D1EC", Offset = "0xE0D1EC", VA = "0xE0D1EC", Slot = "5")]
	public override void SetOrderCard(Image ingredientPrefab, Vector3 position, Transform parent, float offset, float groupOffset)
	{
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0xE0D494", Offset = "0xE0D494", VA = "0xE0D494", Slot = "8")]
	public override int NumRecipes()
	{
		return default(int);
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0xE0D49C", Offset = "0xE0D49C", VA = "0xE0D49C", Slot = "7")]
	public override Ingredient[][] GetIngredients()
	{
		return null;
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0xE0D570", Offset = "0xE0D570", VA = "0xE0D570", Slot = "11")]
	public override int CalculateRecipePoints()
	{
		return default(int);
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0xE0D5EC", Offset = "0xE0D5EC", VA = "0xE0D5EC")]
	public BurgerRecipeDefinition()
	{
	}
}
[Token(Token = "0x20000A0")]
public class DrinkRecipeDefinition : RecipeDefinition
{
	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Ingredient ingredient;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool checkIsHot;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Color color;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string type;

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x22DFA5C", Offset = "0x22DFA5C", VA = "0x22DFA5C", Slot = "4")]
	public override bool CheckRecipe(List<GameObject> objectsPlaced)
	{
		return default(bool);
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x22DFD70", Offset = "0x22DFD70", VA = "0x22DFD70", Slot = "6")]
	public override int[][] CheckRecipeState(List<GameObject> objectPlaced)
	{
		return null;
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x22DFBE0", Offset = "0x22DFBE0", VA = "0x22DFBE0")]
	private int IsCupGood(CupLiquid cupLiquid)
	{
		return default(int);
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x22E0020", Offset = "0x22E0020", VA = "0x22E0020", Slot = "8")]
	public override int NumRecipes()
	{
		return default(int);
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x22E0028", Offset = "0x22E0028", VA = "0x22E0028", Slot = "7")]
	public override Ingredient[][] GetIngredients()
	{
		return null;
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x22E015C", Offset = "0x22E015C", VA = "0x22E015C", Slot = "5")]
	public override void SetOrderCard(Image ingredientPrefab, Vector3 position, Transform parent, float offset, float groupOffset)
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x22E0290", Offset = "0x22E0290", VA = "0x22E0290", Slot = "11")]
	public override int CalculateRecipePoints()
	{
		return default(int);
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x22E02B8", Offset = "0x22E02B8", VA = "0x22E02B8")]
	public DrinkRecipeDefinition()
	{
	}
}
[Token(Token = "0x20000A1")]
public class FriesRecipeDefinition : RecipeDefinition
{
	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Ingredient ingredient;

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x22E53E8", Offset = "0x22E53E8", VA = "0x22E53E8", Slot = "4")]
	public override bool CheckRecipe(List<GameObject> objectsPlaced)
	{
		return default(bool);
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x22E559C", Offset = "0x22E559C", VA = "0x22E559C", Slot = "8")]
	public override int NumRecipes()
	{
		return default(int);
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x22E55A4", Offset = "0x22E55A4", VA = "0x22E55A4", Slot = "7")]
	public override Ingredient[][] GetIngredients()
	{
		return null;
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0x22E56D8", Offset = "0x22E56D8", VA = "0x22E56D8", Slot = "5")]
	public override void SetOrderCard(Image ingredientPrefab, Vector3 position, Transform parent, float offset, float groupOffset)
	{
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x22E580C", Offset = "0x22E580C", VA = "0x22E580C", Slot = "11")]
	public override int CalculateRecipePoints()
	{
		return default(int);
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x22E5834", Offset = "0x22E5834", VA = "0x22E5834")]
	public FriesRecipeDefinition()
	{
	}
}
[Token(Token = "0x20000A2")]
public class GroupRecipeDefinition : RecipeDefinition
{
	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RecipeDefinition[] recipes;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float groupOrderOffset;

	[Token(Token = "0x6000560")]
	[Address(RVA = "0x22EAA84", Offset = "0x22EAA84", VA = "0x22EAA84", Slot = "4")]
	public override bool CheckRecipe(List<GameObject> objectsPlaced)
	{
		return default(bool);
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x22EAB14", Offset = "0x22EAB14", VA = "0x22EAB14", Slot = "6")]
	public override int[][] CheckRecipeState(List<GameObject> objectPlaced)
	{
		return null;
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x22EACB0", Offset = "0x22EACB0", VA = "0x22EACB0", Slot = "7")]
	public override Ingredient[][] GetIngredients()
	{
		return null;
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x22EAE3C", Offset = "0x22EAE3C", VA = "0x22EAE3C", Slot = "8")]
	public override int NumRecipes()
	{
		return default(int);
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x22EAEC8", Offset = "0x22EAEC8", VA = "0x22EAEC8", Slot = "5")]
	public override void SetOrderCard(Image ingredientPrefab, Vector3 position, Transform parent, float orderOffset, float groupOffset)
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x22EB770", Offset = "0x22EB770", VA = "0x22EB770", Slot = "9")]
	public override RecipeDefinition GetRecipe()
	{
		return null;
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x22EB95C", Offset = "0x22EB95C", VA = "0x22EB95C", Slot = "10")]
	public override string GetId()
	{
		return null;
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x22EBA6C", Offset = "0x22EBA6C", VA = "0x22EBA6C", Slot = "11")]
	public override int CalculateRecipePoints()
	{
		return default(int);
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x22EBAF8", Offset = "0x22EBAF8", VA = "0x22EBAF8")]
	public GroupRecipeDefinition()
	{
	}
}
[Token(Token = "0x20000A3")]
public class HolderRecipeDefinition : GroupRecipeDefinition
{
	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<GameObject> unpackedObjects;

	[Token(Token = "0x6000569")]
	[Address(RVA = "0xD983C8", Offset = "0xD983C8", VA = "0xD983C8")]
	private void UnpackSnappedObjects(GameObject objectPlaced)
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0xD98660", Offset = "0xD98660", VA = "0xD98660", Slot = "4")]
	public override bool CheckRecipe(List<GameObject> objectsPlaced)
	{
		return default(bool);
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0xD98988", Offset = "0xD98988", VA = "0xD98988", Slot = "6")]
	public override int[][] CheckRecipeState(List<GameObject> objectsPlaced)
	{
		return null;
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0xD98E28", Offset = "0xD98E28", VA = "0xD98E28", Slot = "10")]
	public override string GetId()
	{
		return null;
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0xD98E94", Offset = "0xD98E94", VA = "0xD98E94", Slot = "11")]
	public override int CalculateRecipePoints()
	{
		return default(int);
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0xD98EE4", Offset = "0xD98EE4", VA = "0xD98EE4")]
	public HolderRecipeDefinition()
	{
	}
}
[Token(Token = "0x20000A4")]
public class Ingredient : MonoBehaviour
{
	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite image;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite feedbackImage;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string type;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int points;

	[Token(Token = "0x600056F")]
	[Address(RVA = "0xD99E0C", Offset = "0xD99E0C", VA = "0xD99E0C")]
	public Ingredient()
	{
	}
}
[Token(Token = "0x20000A5")]
public class RandomRecipeDefinition : RecipeDefinition
{
	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RecipeDefinition[] randomRecipes;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int lastOrderIndex;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int[] randomPool;

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x22C20C0", Offset = "0x22C20C0", VA = "0x22C20C0", Slot = "4")]
	public override bool CheckRecipe(List<GameObject> objectsPlaced)
	{
		return default(bool);
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x22C2120", Offset = "0x22C2120", VA = "0x22C2120", Slot = "6")]
	public override int[][] CheckRecipeState(List<GameObject> objectPlaced)
	{
		return null;
	}

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x22C2180", Offset = "0x22C2180", VA = "0x22C2180", Slot = "8")]
	public override int NumRecipes()
	{
		return default(int);
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x22C2188", Offset = "0x22C2188", VA = "0x22C2188", Slot = "5")]
	public override void SetOrderCard(Image ingredientPrefab, Vector3 position, Transform parent, float offset, float groupOffset)
	{
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x22C21E8", Offset = "0x22C21E8", VA = "0x22C21E8", Slot = "9")]
	public override RecipeDefinition GetRecipe()
	{
		return null;
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x22C2350", Offset = "0x22C2350", VA = "0x22C2350", Slot = "7")]
	public override Ingredient[][] GetIngredients()
	{
		return null;
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0x22C23B0", Offset = "0x22C23B0", VA = "0x22C23B0", Slot = "11")]
	public override int CalculateRecipePoints()
	{
		return default(int);
	}

	[Token(Token = "0x6000577")]
	[Address(RVA = "0x22C2410", Offset = "0x22C2410", VA = "0x22C2410")]
	public RandomRecipeDefinition()
	{
	}
}
[Token(Token = "0x20000A6")]
public abstract class RecipeDefinition : MonoBehaviour
{
	[Token(Token = "0x2000195")]
	public enum IngredientStateCode
	{
		[Token(Token = "0x4000850")]
		MISSING,
		[Token(Token = "0x4000851")]
		GOOD,
		[Token(Token = "0x4000852")]
		BURNED,
		[Token(Token = "0x4000853")]
		ROTTEN,
		[Token(Token = "0x4000854")]
		RAW,
		[Token(Token = "0x4000855")]
		NOT_FULL,
		[Token(Token = "0x4000856")]
		WRONGTYPE,
		[Token(Token = "0x4000857")]
		COLD
	}

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int recipePoints;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28B60", Offset = "0xD28B60")]
	public bool isSingleOrder;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28B98", Offset = "0xD28B98")]
	public int uid;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int maxUid;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float totalTimeToDeliver;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected int[][] cachedResult;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Ingredient[][] cachedIngredientsArray;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected List<GameObject> feedbackCards;

	[Token(Token = "0x6000578")]
	public abstract bool CheckRecipe(List<GameObject> objectsPlaced);

	[Token(Token = "0x6000579")]
	public abstract void SetOrderCard(Image ingredientPrefab, Vector3 position, Transform parent, float offset, float groupOffset);

	[Token(Token = "0x600057A")]
	[Address(RVA = "0x22C3520", Offset = "0x22C3520", VA = "0x22C3520", Slot = "6")]
	public virtual int[][] CheckRecipeState(List<GameObject> objectPlaced)
	{
		return null;
	}

	[Token(Token = "0x600057B")]
	public abstract Ingredient[][] GetIngredients();

	[Token(Token = "0x600057C")]
	public abstract int NumRecipes();

	[Token(Token = "0x600057D")]
	[Address(RVA = "0x22C3650", Offset = "0x22C3650", VA = "0x22C3650", Slot = "9")]
	public virtual RecipeDefinition GetRecipe()
	{
		return null;
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x22C3654", Offset = "0x22C3654", VA = "0x22C3654", Slot = "10")]
	public virtual string GetId()
	{
		return null;
	}

	[Token(Token = "0x600057F")]
	[Address(RVA = "0x22C36C0", Offset = "0x22C36C0", VA = "0x22C36C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x22C372C", Offset = "0x22C372C", VA = "0x22C372C", Slot = "11")]
	public virtual int CalculateRecipePoints()
	{
		return default(int);
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x22C2414", Offset = "0x22C2414", VA = "0x22C2414")]
	protected RecipeDefinition()
	{
	}
}
[Token(Token = "0x20000A7")]
public class RecipeInstance
{
	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RecipeDefinition recipeDefinition;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int orderIndex;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isComplete;

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x22C3738", Offset = "0x22C3738", VA = "0x22C3738")]
	public RecipeInstance()
	{
	}
}
[Token(Token = "0x20000A8")]
public class SnappingRecipeDefinition : RecipeDefinition
{
	[Token(Token = "0x2000196")]
	public enum OffsetModeEnum
	{
		[Token(Token = "0x4000859")]
		CONSTANT_OFFSET,
		[Token(Token = "0x400085A")]
		RAMEN_OFFSET,
		[Token(Token = "0x400085B")]
		NO_OFFSET,
		[Token(Token = "0x400085C")]
		SUSHI_OFFSET,
		[Token(Token = "0x400085D")]
		TACO_OFFSET
	}

	[Serializable]
	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD283C8", Offset = "0xD283C8")]
	private sealed class <>c
	{
		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<int, bool> <>9__8_0;

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x22F9B48", Offset = "0x22F9B48", VA = "0x22F9B48")]
		public <>c()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x22F9B50", Offset = "0x22F9B50", VA = "0x22F9B50")]
		internal bool <CheckRecipeState>b__8_0(int state)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Ingredient[] ingredients;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28BD0", Offset = "0xD28BD0")]
	public bool ignoreCheckState;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28C08", Offset = "0xD28C08")]
	public OffsetModeEnum offsetMode;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private OffsetMode.OffsetModeParam offsetModeParams;

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x22F8994", Offset = "0x22F8994", VA = "0x22F8994")]
	private void Start()
	{
	}

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x22F8AE4", Offset = "0x22F8AE4", VA = "0x22F8AE4", Slot = "7")]
	public override Ingredient[][] GetIngredients()
	{
		return null;
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x22F8B94", Offset = "0x22F8B94", VA = "0x22F8B94", Slot = "4")]
	public override bool CheckRecipe(List<GameObject> objectsPlaced)
	{
		return default(bool);
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x22F8E04", Offset = "0x22F8E04", VA = "0x22F8E04", Slot = "6")]
	public override int[][] CheckRecipeState(List<GameObject> objectsPlaced)
	{
		return null;
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x22F92FC", Offset = "0x22F92FC", VA = "0x22F92FC")]
	private int[] IsGood(GameObject objectPlaced)
	{
		return null;
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x22F9730", Offset = "0x22F9730", VA = "0x22F9730", Slot = "5")]
	public override void SetOrderCard(Image ingredientPrefab, Vector3 position, Transform parent, float offset, float groupOffset)
	{
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x22F9A54", Offset = "0x22F9A54", VA = "0x22F9A54", Slot = "8")]
	public override int NumRecipes()
	{
		return default(int);
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x22F9A5C", Offset = "0x22F9A5C", VA = "0x22F9A5C", Slot = "11")]
	public override int CalculateRecipePoints()
	{
		return default(int);
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x22F9AD8", Offset = "0x22F9AD8", VA = "0x22F9AD8")]
	public SnappingRecipeDefinition()
	{
	}
}
[Token(Token = "0x20000A9")]
public class SceneSwitcher : MonoBehaviour
{
	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator switchAnimator;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource sceneSwitchSound;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float clickDelay;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float timeFromClick;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isClicked;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject music;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AudioClip[] switchAudio;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int lastChoosenIndex;

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x22D5A54", Offset = "0x22D5A54", VA = "0x22D5A54")]
	private void Start()
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x22D5C24", Offset = "0x22D5C24", VA = "0x22D5C24")]
	private void Update()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x22D5AE0", Offset = "0x22D5AE0", VA = "0x22D5AE0")]
	public void SceneSwitch()
	{
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x22D5C74", Offset = "0x22D5C74", VA = "0x22D5C74")]
	public void PlaySceneSwitchSound()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x22D5CD8", Offset = "0x22D5CD8", VA = "0x22D5CD8")]
	public void SwitchAmerican()
	{
	}

	[Token(Token = "0x6000591")]
	[Address(RVA = "0x22D5D38", Offset = "0x22D5D38", VA = "0x22D5D38")]
	public void SwitchItalian()
	{
	}

	[Token(Token = "0x6000592")]
	[Address(RVA = "0x22D5D98", Offset = "0x22D5D98", VA = "0x22D5D98")]
	public void SwitchJapanese()
	{
	}

	[Token(Token = "0x6000593")]
	[Address(RVA = "0x22D5DF8", Offset = "0x22D5DF8", VA = "0x22D5DF8")]
	public void SwitchMexican()
	{
	}

	[Token(Token = "0x6000594")]
	[Address(RVA = "0x22D5E58", Offset = "0x22D5E58", VA = "0x22D5E58")]
	public SceneSwitcher()
	{
	}
}
[Token(Token = "0x20000AA")]
public class Settings
{
	[Token(Token = "0x2000198")]
	public delegate void SaveFileUpdated(string filepath);

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float HEIGHT_START;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool persistentVoiceSettings;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool shouldSave;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Settings _instance;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	private bool _soundOn;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	private bool _musicOn;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private bool _handleOn;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	private bool _vibrationOn;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	private bool _isRecentered;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	private bool _disableTutorials;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float _recenterOffsetAngle;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float _recenterOffsetPositionX;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float _recenterOffsetPositionY;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float _recenterOffsetPositionZ;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _PultHight;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int _LanguageIndex;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _micOn;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool _speakerOn;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _waiterID;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SaveFileUpdated saveFileUpdated;

	[Token(Token = "0x1700000D")]
	public static Settings Instance
	{
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x22F131C", Offset = "0x22F131C", VA = "0x22F131C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public bool SoundOn
	{
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x22F1454", Offset = "0x22F1454", VA = "0x22F1454")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x22F145C", Offset = "0x22F145C", VA = "0x22F145C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public bool MusicOn
	{
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x22F172C", Offset = "0x22F172C", VA = "0x22F172C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x22F1734", Offset = "0x22F1734", VA = "0x22F1734")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public bool HandleOn
	{
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x22F1740", Offset = "0x22F1740", VA = "0x22F1740")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x22F1748", Offset = "0x22F1748", VA = "0x22F1748")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool VibrationOn
	{
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x22F1754", Offset = "0x22F1754", VA = "0x22F1754")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x22F175C", Offset = "0x22F175C", VA = "0x22F175C")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public bool Recentered
	{
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x22F1768", Offset = "0x22F1768", VA = "0x22F1768")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x22F1770", Offset = "0x22F1770", VA = "0x22F1770")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public bool DisableTutorials
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x22F177C", Offset = "0x22F177C", VA = "0x22F177C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x22F1784", Offset = "0x22F1784", VA = "0x22F1784")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float RecenterOffsetAngle
	{
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x22F1790", Offset = "0x22F1790", VA = "0x22F1790")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x22F1798", Offset = "0x22F1798", VA = "0x22F1798")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public float RecenterOffsetPositionX
	{
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x22F17A0", Offset = "0x22F17A0", VA = "0x22F17A0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x22F17A8", Offset = "0x22F17A8", VA = "0x22F17A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public float RecenterOffsetPositionY
	{
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x22F17B0", Offset = "0x22F17B0", VA = "0x22F17B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x22F17B8", Offset = "0x22F17B8", VA = "0x22F17B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public float RecenterOffsetPositionZ
	{
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x22F17C0", Offset = "0x22F17C0", VA = "0x22F17C0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x22F17C8", Offset = "0x22F17C8", VA = "0x22F17C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public float PultHight
	{
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x22F17D0", Offset = "0x22F17D0", VA = "0x22F17D0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x22F17D8", Offset = "0x22F17D8", VA = "0x22F17D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public int Language
	{
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x22F1868", Offset = "0x22F1868", VA = "0x22F1868")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x22F1870", Offset = "0x22F1870", VA = "0x22F1870")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public bool MicOn
	{
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x22F1878", Offset = "0x22F1878", VA = "0x22F1878")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x22F1880", Offset = "0x22F1880", VA = "0x22F1880")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public bool SpeakerOn
	{
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x22F188C", Offset = "0x22F188C", VA = "0x22F188C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x22F1894", Offset = "0x22F1894", VA = "0x22F1894")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public string WaiterID
	{
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x22F18A0", Offset = "0x22F18A0", VA = "0x22F18A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x22F18A8", Offset = "0x22F18A8", VA = "0x22F18A8")]
		set
		{
		}
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x22F13E4", Offset = "0x22F13E4", VA = "0x22F13E4")]
	public Settings()
	{
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x22F18D0", Offset = "0x22F18D0", VA = "0x22F18D0")]
	public void Load()
	{
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x22F1468", Offset = "0x22F1468", VA = "0x22F1468")]
	public void Save()
	{
	}

	[Token(Token = "0x60005B7")]
	[Address(RVA = "0x22F17E0", Offset = "0x22F17E0", VA = "0x22F17E0")]
	public void SetPultHight()
	{
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x22F1EC0", Offset = "0x22F1EC0", VA = "0x22F1EC0")]
	public bool IsLevelUnlocked(GameManager.Restaurant restaurant, int level)
	{
		return default(bool);
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x22F1FC4", Offset = "0x22F1FC4", VA = "0x22F1FC4")]
	public void SetLevelCompleted(GameManager.Restaurant restaurant, int level, int score)
	{
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x22F2120", Offset = "0x22F2120", VA = "0x22F2120")]
	public void SaveAchievements()
	{
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x22F1E38", Offset = "0x22F1E38", VA = "0x22F1E38")]
	public void SaveSettings()
	{
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x22F22C0", Offset = "0x22F22C0", VA = "0x22F22C0")]
	public void SaveToFile()
	{
	}
}
[Token(Token = "0x20000AB")]
public class SmoothGrabbingController : MonoBehaviourPun, IPunObservable
{
	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject grabbingObject;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform snapPosition;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 fixedRotation;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 startRotation;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool locked;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool disableForceRelease;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 goodRotation;

	[Token(Token = "0x60005BE")]
	[Address(RVA = "0x22F4E74", Offset = "0x22F4E74", VA = "0x22F4E74")]
	private void Start()
	{
	}

	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x22F4E78", Offset = "0x22F4E78", VA = "0x22F4E78")]
	public void SetStartRotation()
	{
	}

	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x22F4FE4", Offset = "0x22F4FE4", VA = "0x22F4FE4")]
	public void Lock()
	{
	}

	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x22F504C", Offset = "0x22F504C", VA = "0x22F504C")]
	public void Unlock()
	{
	}

	[Token(Token = "0x60005C2")]
	[Address(RVA = "0x22F51C4", Offset = "0x22F51C4", VA = "0x22F51C4")]
	[PunRPC]
	public void UnlockRPC()
	{
	}

	[Token(Token = "0x60005C3")]
	[Address(RVA = "0x22F522C", Offset = "0x22F522C", VA = "0x22F522C")]
	public void FixRotation()
	{
	}

	[Token(Token = "0x60005C4")]
	[Address(RVA = "0x22F5334", Offset = "0x22F5334", VA = "0x22F5334")]
	public void ReturnToFixedPosition()
	{
	}

	[Token(Token = "0x60005C5")]
	[Address(RVA = "0x22F5500", Offset = "0x22F5500", VA = "0x22F5500")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005C6")]
	[Address(RVA = "0x22F575C", Offset = "0x22F575C", VA = "0x22F575C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x22F58F0", Offset = "0x22F58F0", VA = "0x22F58F0", Slot = "4")]
	private void Photon.Pun.IPunObservable.OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x22F59BC", Offset = "0x22F59BC", VA = "0x22F59BC")]
	public SmoothGrabbingController()
	{
	}
}
[Token(Token = "0x20000AC")]
public class FruitSnappingController : MonoBehaviourPun
{
	[Token(Token = "0x40004A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isSnapped;

	[Token(Token = "0x40004AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string fruitName;

	[Token(Token = "0x40004AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject snappingBase;

	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject squeezeColliders;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isSqueeze;

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x22E5AA0", Offset = "0x22E5AA0", VA = "0x22E5AA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x22E5BB0", Offset = "0x22E5BB0", VA = "0x22E5BB0")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x22E5E70", Offset = "0x22E5E70", VA = "0x22E5E70")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0x22E5F30", Offset = "0x22E5F30", VA = "0x22E5F30")]
	private void Update()
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0x22E5F34", Offset = "0x22E5F34", VA = "0x22E5F34")]
	public void DoSnapFruit(GameObject other)
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0x22E609C", Offset = "0x22E609C", VA = "0x22E609C")]
	[PunRPC]
	public void SnapFruitRPC(int otherObjectId)
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x22E6294", Offset = "0x22E6294", VA = "0x22E6294")]
	public void SnapFruit(GameObject other, Vector3 transformPoint, Quaternion newTransform, GameObject parentObject)
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x22E5C64", Offset = "0x22E5C64", VA = "0x22E5C64")]
	[PunRPC]
	public void UnSnapFruit()
	{
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x22E6680", Offset = "0x22E6680", VA = "0x22E6680")]
	public void SnapFruitRecording(GameObject cupObject, GameObject friuit)
	{
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x22E6858", Offset = "0x22E6858", VA = "0x22E6858")]
	public void OnSqueeze()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x22E6980", Offset = "0x22E6980", VA = "0x22E6980")]
	public FruitSnappingController()
	{
	}
}
[Token(Token = "0x20000AD")]
public class PlacingController : MonoBehaviour
{
	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string objectTagToSnap;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float customRotationX;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float customRotationY;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float customRotationZ;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool DontSnapOnAwake;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool DetectGrab;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	private bool isItemGrabbed;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	private bool isItemSnapped;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public GameObject activeObjectReference;

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x22BD448", Offset = "0x22BD448", VA = "0x22BD448")]
	private void Start()
	{
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x22BD47C", Offset = "0x22BD47C", VA = "0x22BD47C")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x22BD480", Offset = "0x22BD480", VA = "0x22BD480")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x22BD80C", Offset = "0x22BD80C", VA = "0x22BD80C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x22BD87C", Offset = "0x22BD87C", VA = "0x22BD87C")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x22BD888", Offset = "0x22BD888", VA = "0x22BD888")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x22BD890", Offset = "0x22BD890", VA = "0x22BD890")]
	public PlacingController()
	{
	}
}
[Token(Token = "0x20000AE")]
public class RecipeController : MonoBehaviour
{
	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool CanSnapOnTray;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> stackedObjects;

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x22C349C", Offset = "0x22C349C", VA = "0x22C349C")]
	public RecipeController()
	{
	}
}
[Token(Token = "0x20000AF")]
public class SnapOnCup : MonoBehaviourPun
{
	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isOccupate;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] anchors;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float SnapDistance;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float SnapMax;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Quaternion newRotation;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject snappedObj;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<GameObject> inTrigger;

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x22F59C4", Offset = "0x22F59C4", VA = "0x22F59C4")]
	private void Start()
	{
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x22F59C8", Offset = "0x22F59C8", VA = "0x22F59C8")]
	private void Update()
	{
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x22F59CC", Offset = "0x22F59CC", VA = "0x22F59CC")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x22F6014", Offset = "0x22F6014", VA = "0x22F6014")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x22F6230", Offset = "0x22F6230", VA = "0x22F6230")]
	public SnapOnCup()
	{
	}
}
[Token(Token = "0x20000B0")]
public class SnappingBaseController : MonoBehaviour
{
	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isReady;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] validTags;

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x22F7120", Offset = "0x22F7120", VA = "0x22F7120")]
	private void Start()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x22F71D4", Offset = "0x22F71D4", VA = "0x22F71D4")]
	private void Update()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x22F71D8", Offset = "0x22F71D8", VA = "0x22F71D8")]
	public bool IsValidTag(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x22F7270", Offset = "0x22F7270", VA = "0x22F7270")]
	public SnappingBaseController()
	{
	}
}
[Token(Token = "0x20000B1")]
public class SnappingController : MonoBehaviourPun
{
	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] validTagsOnSnap;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RecipeController recipeController;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject PreviousSnapped;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject NextSnapped;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject LastSnappedObject;

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x22F7278", Offset = "0x22F7278", VA = "0x22F7278")]
	public GameObject GetNext()
	{
		return null;
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x22F7280", Offset = "0x22F7280", VA = "0x22F7280")]
	public RecipeController GetRecipeController()
	{
		return null;
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x22F7288", Offset = "0x22F7288", VA = "0x22F7288")]
	private void Start()
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x22F7398", Offset = "0x22F7398", VA = "0x22F7398")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x22F739C", Offset = "0x22F739C", VA = "0x22F739C")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x22F7C14", Offset = "0x22F7C14", VA = "0x22F7C14")]
	private void Update()
	{
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x22F7C18", Offset = "0x22F7C18", VA = "0x22F7C18")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x22F7D3C", Offset = "0x22F7D3C", VA = "0x22F7D3C")]
	public void Snapping(GameObject other)
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x22F7F5C", Offset = "0x22F7F5C", VA = "0x22F7F5C")]
	public bool CanSnap(GameObject other)
	{
		return default(bool);
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x22F769C", Offset = "0x22F769C", VA = "0x22F769C")]
	public void Snap(GameObject other)
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x22F85AC", Offset = "0x22F85AC", VA = "0x22F85AC")]
	[PunRPC]
	public void DoSnapRPC(int ingridientID, int recipeControllerID)
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x22F86A8", Offset = "0x22F86A8", VA = "0x22F86A8")]
	public void DoSnapReplay(GameObject otherObj, GameObject baseObj)
	{
	}

	[Token(Token = "0x60005F1")]
	[Address(RVA = "0x22F8300", Offset = "0x22F8300", VA = "0x22F8300")]
	public void DoSnap(GameObject ingridient, RecipeController recipeController)
	{
	}

	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x22F898C", Offset = "0x22F898C", VA = "0x22F898C")]
	public SnappingController()
	{
	}
}
[Token(Token = "0x20000B2")]
public class StackingController : MonoBehaviour
{
	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IsItemSnapped;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float height;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RecipeController recipeController;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject PreviousSnapped;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject NextSnapped;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool shouldSetDefaultScale;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject LastSnappedObject;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject BaseSnappedObject;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private PhotonView photonView;

	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x22FFF20", Offset = "0x22FFF20", VA = "0x22FFF20")]
	public GameObject GetNext()
	{
		return null;
	}

	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x22FFF28", Offset = "0x22FFF28", VA = "0x22FFF28")]
	public GameObject GetPrevious()
	{
		return null;
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x22FFF30", Offset = "0x22FFF30", VA = "0x22FFF30")]
	public GameObject GetLast()
	{
		return null;
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x22FFFF0", Offset = "0x22FFFF0", VA = "0x22FFFF0")]
	public int GetNumIngredients()
	{
		return default(int);
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x2300100", Offset = "0x2300100", VA = "0x2300100")]
	public RecipeController GetRecipeController()
	{
		return null;
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x2300108", Offset = "0x2300108", VA = "0x2300108")]
	private void Awake()
	{
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x2300214", Offset = "0x2300214", VA = "0x2300214")]
	private void Start()
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x23004AC", Offset = "0x23004AC", VA = "0x23004AC")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x2300938", Offset = "0x2300938", VA = "0x2300938")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x23015F4", Offset = "0x23015F4", VA = "0x23015F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x2301738", Offset = "0x2301738", VA = "0x2301738")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x2301D80", Offset = "0x2301D80", VA = "0x2301D80")]
	public void SetSnapParentReplay(GameObject parentObject, GameObject childObject)
	{
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x2301F28", Offset = "0x2301F28", VA = "0x2301F28")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x2301BBC", Offset = "0x2301BBC", VA = "0x2301BBC")]
	private bool CanSnap(GameObject other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x2302234", Offset = "0x2302234", VA = "0x2302234")]
	[PunRPC]
	private void SnapRPC(int objectId, int otherRecipeControler)
	{
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x2300E9C", Offset = "0x2300E9C", VA = "0x2300E9C")]
	private void Snap(GameObject other, RecipeController newRecipeController)
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x2302330", Offset = "0x2302330", VA = "0x2302330")]
	[PunRPC]
	public void UnsnapRPC()
	{
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x2300590", Offset = "0x2300590", VA = "0x2300590")]
	private void Unsnap()
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x23020D4", Offset = "0x23020D4", VA = "0x23020D4")]
	public void EnablePhysics(bool enable, GameObject collidingObject)
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x230236C", Offset = "0x230236C", VA = "0x230236C")]
	public StackingController()
	{
	}
}
[Token(Token = "0x20000B3")]
public class SpawnButtonListener : MonoBehaviour, VRTK_ITouch
{
	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public GameObject currentGameObject;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> triggeredGameObjects;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private VRTK_ControllerReference controllerReference;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isMirroringSpawnObject;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isInSpawnPoint;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public VRTK_ControllerEvents.ButtonAlias spawnedButton;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VRTK_InteractGrab[] interactGrabs;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private VRTK_InteractTouch interactTouch;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isKnuckles;

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x22F9B5C", Offset = "0x22F9B5C", VA = "0x22F9B5C", Slot = "4")]
	public bool IsTouched()
	{
		return default(bool);
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x22F9B64", Offset = "0x22F9B64", VA = "0x22F9B64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x22F9CB0", Offset = "0x22F9CB0", VA = "0x22F9CB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x22F9DC4", Offset = "0x22F9DC4", VA = "0x22F9DC4")]
	public void GetCurrentControllerType()
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x22F9F58", Offset = "0x22F9F58", VA = "0x22F9F58")]
	public bool IsSomethingGrabbed()
	{
		return default(bool);
	}

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x22FA03C", Offset = "0x22FA03C", VA = "0x22FA03C")]
	public bool IsSomethingTouched()
	{
		return default(bool);
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x22FA0C8", Offset = "0x22FA0C8", VA = "0x22FA0C8")]
	public void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x22FA234", Offset = "0x22FA234", VA = "0x22FA234")]
	public void DoGripPressed(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x22FA370", Offset = "0x22FA370", VA = "0x22FA370")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x22FA67C", Offset = "0x22FA67C", VA = "0x22FA67C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x22FA870", Offset = "0x22FA870", VA = "0x22FA870")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x22FAB30", Offset = "0x22FAB30", VA = "0x22FAB30")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x22FA708", Offset = "0x22FA708", VA = "0x22FA708")]
	private void ReleaseSpawnPoint()
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x22FABEC", Offset = "0x22FABEC", VA = "0x22FABEC")]
	public SpawnButtonListener()
	{
	}
}
[Token(Token = "0x20000B4")]
public class SpawnableController : MonoBehaviour
{
	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 initialRotation;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int materialIndex;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject prefabToSpawn;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AudioSource spawnSound;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool hasStartObject;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject currentObject;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject currentObjectPosition;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28C60", Offset = "0xD28C60")]
	public bool shouldMirrorOnSpawn;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject spawnedObject;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color baseColor;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private PhotonView photonView;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool shouldSpawn;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool shouldRemoveHightlight;

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x22FAE14", Offset = "0x22FAE14", VA = "0x22FAE14")]
	private void Start()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x22FAF44", Offset = "0x22FAF44", VA = "0x22FAF44")]
	private void Update()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x22FAF48", Offset = "0x22FAF48", VA = "0x22FAF48")]
	public void SetShouldSpawn()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x22FA554", Offset = "0x22FA554", VA = "0x22FA554")]
	public void Highlight(bool highlight)
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x22FAF54", Offset = "0x22FAF54", VA = "0x22FAF54")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x22FB774", Offset = "0x22FB774", VA = "0x22FB774")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x22FBA48", Offset = "0x22FBA48", VA = "0x22FBA48")]
	public void InstantiateCurrentObject()
	{
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x22FBD14", Offset = "0x22FBD14", VA = "0x22FBD14")]
	[PunRPC]
	public void SyncSpawnedObject(int photonId)
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x22FC004", Offset = "0x22FC004", VA = "0x22FC004")]
	[PunRPC]
	public void SyncCurrentObject(int photonId)
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x22FC150", Offset = "0x22FC150", VA = "0x22FC150")]
	[PunRPC]
	public void RemoveCurrentObject()
	{
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x22FC184", Offset = "0x22FC184", VA = "0x22FC184", Slot = "4")]
	public virtual void Spawn(SpawnButtonListener spawnController)
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x22FC78C", Offset = "0x22FC78C", VA = "0x22FC78C")]
	public SpawnableController()
	{
	}
}
[Token(Token = "0x20000B5")]
public class SpawnedItemController : MonoBehaviourPun
{
	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool JustSpawned;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject SpawnPoint;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool InSpawnPoint;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool ItemInHand;

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x22FC7F0", Offset = "0x22FC7F0", VA = "0x22FC7F0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x22FC900", Offset = "0x22FC900", VA = "0x22FC900")]
	private void ItemTaken(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x22FCA10", Offset = "0x22FCA10", VA = "0x22FCA10")]
	private void ItemDropped(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x22FCBD8", Offset = "0x22FCBD8", VA = "0x22FCBD8")]
	[PunRPC]
	public void SyncIsItemGrabbed(bool isGrabbed)
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x22FB138", Offset = "0x22FB138", VA = "0x22FB138")]
	public void SetInSpawnPoint(bool inSpawn)
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x22FCBE4", Offset = "0x22FCBE4", VA = "0x22FCBE4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x22FCB4C", Offset = "0x22FCB4C", VA = "0x22FCB4C")]
	public void ReturnObjectToSpawn()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x22FBED4", Offset = "0x22FBED4", VA = "0x22FBED4")]
	public void EnableSpawnPointPhysics(bool enable)
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x22FCCF4", Offset = "0x22FCCF4", VA = "0x22FCCF4")]
	public SpawnedItemController()
	{
	}
}
[Token(Token = "0x20000B6")]
public class SpreadingController : MonoBehaviour
{
	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28C98", Offset = "0xD28C98")]
	public SpreadingController[] adjacentObjects;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28CD0", Offset = "0xD28CD0")]
	public GameObject objectToActivate;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float activationFactor;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28D08", Offset = "0xD28D08")]
	public float spreadingSpeed;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool IsActivated;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private PhotonView photonView;

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x22FE930", Offset = "0x22FE930", VA = "0x22FE930")]
	private void Start()
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x22FE9BC", Offset = "0x22FE9BC", VA = "0x22FE9BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x22FEB4C", Offset = "0x22FEB4C", VA = "0x22FEB4C")]
	public void Activate()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x22FEAC0", Offset = "0x22FEAC0", VA = "0x22FEAC0")]
	public void Deactivate()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x22FEC1C", Offset = "0x22FEC1C", VA = "0x22FEC1C")]
	[PunRPC]
	public void DeactivateRPC()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x22FEBD8", Offset = "0x22FEBD8", VA = "0x22FEBD8")]
	[PunRPC]
	public void ActivateRPC()
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x22FEAA8", Offset = "0x22FEAA8", VA = "0x22FEAA8")]
	public void Spread(float power)
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x22FECA0", Offset = "0x22FECA0", VA = "0x22FECA0")]
	public void ResetSpread()
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x22FED04", Offset = "0x22FED04", VA = "0x22FED04")]
	public SpreadingController()
	{
	}
}
[Token(Token = "0x20000B7")]
public class CuttingHelperController : MonoBehaviour
{
	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject tutorialAnim;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CuttableController cuttableObject;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float animTimer;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool isItemGrabbed;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	private bool wrongCut;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private VRTK_ControllerReference controllerReference;

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x22DBCBC", Offset = "0x22DBCBC", VA = "0x22DBCBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x22DBDE0", Offset = "0x22DBDE0", VA = "0x22DBDE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x22DBF08", Offset = "0x22DBF08", VA = "0x22DBF08")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x22DC124", Offset = "0x22DC124", VA = "0x22DC124")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x22DC16C", Offset = "0x22DC16C", VA = "0x22DC16C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x22DBE90", Offset = "0x22DBE90", VA = "0x22DBE90")]
	public void ShowTutorialAnimation()
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x22DC200", Offset = "0x22DC200", VA = "0x22DC200")]
	public CuttingHelperController()
	{
	}
}
[Token(Token = "0x20000B8")]
public class TutorialController : MonoBehaviourSingleton<TutorialController>
{
	[Serializable]
	[Token(Token = "0x2000199")]
	public class TutorialPanel
	{
		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public VideoClip[] videoClip;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI[] texts;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int tutorialGroupIndex;

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x1061BA0", Offset = "0x1061BA0", VA = "0x1061BA0")]
		public TutorialPanel()
		{
		}
	}

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UIButtonGroup chooseRestaurant;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UIViewCategoryName[] pages;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TutorialPanel[] tutorials;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public VideoPlayer zoomVideo;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI zoomText;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool disableTutorials;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject boxCheckImage;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int selectedPage;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private bool isZoomViewActive;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject zoomView;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject tutorialButtonGroup;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool isPlaying;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	private bool shouldPrepareVideo;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject popUpView;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public UIView loadingVideo;

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x1060A7C", Offset = "0x1060A7C", VA = "0x1060A7C", Slot = "4")]
	public override void Start()
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x1060B7C", Offset = "0x1060B7C", VA = "0x1060B7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x1060B8C", Offset = "0x1060B8C", VA = "0x1060B8C")]
	public void PrepareVideo()
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x1060C18", Offset = "0x1060C18", VA = "0x1060C18")]
	public void PauseVideo()
	{
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x1060C34", Offset = "0x1060C34", VA = "0x1060C34")]
	public void ResumeVideo()
	{
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x1060C50", Offset = "0x1060C50", VA = "0x1060C50")]
	public void ToggleTutorialButton()
	{
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x1060DCC", Offset = "0x1060DCC", VA = "0x1060DCC")]
	public void ShowTutorial()
	{
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x1061020", Offset = "0x1061020", VA = "0x1061020")]
	public void ShowPage(int pageIndex)
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x1061268", Offset = "0x1061268", VA = "0x1061268")]
	public void ShowZoomView(int buttonIndex)
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x106136C", Offset = "0x106136C", VA = "0x106136C")]
	public void BeforeZoomView(int buttonIndex)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x10614B8", Offset = "0x10614B8", VA = "0x10614B8")]
	public void CloseButton()
	{
	}

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x1061620", Offset = "0x1061620", VA = "0x1061620")]
	public void HideTutorial()
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x10616DC", Offset = "0x10616DC", VA = "0x10616DC")]
	public void CloseZoomView()
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x1061740", Offset = "0x1061740", VA = "0x1061740")]
	public void PopUpViewButton(bool enable)
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x106182C", Offset = "0x106182C", VA = "0x106182C")]
	public void TutorialsInLevels()
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x1061AE0", Offset = "0x1061AE0", VA = "0x1061AE0")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x1061B50", Offset = "0x1061B50", VA = "0x1061B50")]
	public TutorialController()
	{
	}
}
[Token(Token = "0x20000B9")]
public class TutorialManager : MonoBehaviour
{
	[Token(Token = "0x200019A")]
	public enum State
	{
		[Token(Token = "0x4000864")]
		TUTORIAL_PICK_PLATE,
		[Token(Token = "0x4000865")]
		TUTORIAL_PLACE_PLATE_ON_PULT,
		[Token(Token = "0x4000866")]
		TUTORIAL_PICK_BOTTOMBUN,
		[Token(Token = "0x4000867")]
		TUTORIAL_PLACE_BOTTOMBUN_ON_PULT,
		[Token(Token = "0x4000868")]
		TUTORIAL_PICK_MEAT,
		[Token(Token = "0x4000869")]
		TUTORIAL_PLACE_MEAT_ON_GRILL,
		[Token(Token = "0x400086A")]
		TUTORIAL_WAITING_FOR_MEAT_TO_COOK,
		[Token(Token = "0x400086B")]
		TUTORIAL_PICK_MEAT_FROM_GRILL,
		[Token(Token = "0x400086C")]
		TUTORIAL_PLACE_MEAT_ON_PULT,
		[Token(Token = "0x400086D")]
		TUTORIAL_PICK_TOPBUN,
		[Token(Token = "0x400086E")]
		TUTORIAL_PLACE_TOPBUN_ON_PULT,
		[Token(Token = "0x400086F")]
		TUTORIAL_PICK_BURGER,
		[Token(Token = "0x4000870")]
		TUTORIAL_PLACE_BURGER_ON_SERVICEPLATE
	}

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject tutorialArrow;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject tutorialTimer;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<GameObject> controllers;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TutorialTriggerListener tutorialTrigger;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TutorialTriggerListener tutorialGrillTrigger;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TutorialTriggerListener tutorialServicePlateTrigger;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public CustomerManager customerManager;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TrayController trayController;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject plateArrowPosition;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject bottomBunArrowPosition;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject meatArrowPosition;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject grillArrowPosition;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject topBunArrowPosition;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject servicePlateArrowPosition;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject pultArrowPosition;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 offsetUp;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 offsetLeft;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 offsetAngle;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Quaternion arrowStartRotation;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private bool tutorialActive;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private State state;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public string plate;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public string meat;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public string bottomBun;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public string topBun;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool itemPicked;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float timeElapsed;

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x1061BA8", Offset = "0x1061BA8", VA = "0x1061BA8")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x1061BB0", Offset = "0x1061BB0", VA = "0x1061BB0")]
	private void Start()
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x1061BF4", Offset = "0x1061BF4", VA = "0x1061BF4")]
	private void Update()
	{
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x1063144", Offset = "0x1063144", VA = "0x1063144")]
	public void ActivateTutorial()
	{
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x10629E4", Offset = "0x10629E4", VA = "0x10629E4")]
	public void ShowArrow()
	{
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x1062F18", Offset = "0x1062F18", VA = "0x1062F18")]
	public void HideArrow()
	{
	}

	[Token(Token = "0x6000651")]
	[Address(RVA = "0x1062BB0", Offset = "0x1062BB0", VA = "0x1062BB0")]
	public void MoveArrow(Vector3 position)
	{
	}

	[Token(Token = "0x6000652")]
	[Address(RVA = "0x1062F38", Offset = "0x1062F38", VA = "0x1062F38")]
	public void ShowTimer()
	{
	}

	[Token(Token = "0x6000653")]
	[Address(RVA = "0x1062F58", Offset = "0x1062F58", VA = "0x1062F58")]
	public void HideTimer()
	{
	}

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x106303C", Offset = "0x106303C", VA = "0x106303C")]
	public void RotateArrowStart()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x1062F78", Offset = "0x1062F78", VA = "0x1062F78")]
	public void RotateArrowDown()
	{
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x1063154", Offset = "0x1063154", VA = "0x1063154")]
	public void RotateArrowLeft()
	{
	}

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x1062E50", Offset = "0x1062E50", VA = "0x1062E50")]
	public void RotateArrowFront()
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x106307C", Offset = "0x106307C", VA = "0x106307C")]
	public void RotateArrowAngle()
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x1062A38", Offset = "0x1062A38", VA = "0x1062A38")]
	private bool CheckItemPicked(string tag)
	{
		return default(bool);
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x1062D38", Offset = "0x1062D38", VA = "0x1062D38")]
	private bool CheckOrder(GameObject placedObject, string tag, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x1062C04", Offset = "0x1062C04", VA = "0x1062C04")]
	private void SwitchToPreviousState(string tag, bool itemPlaced, GameObject arrowPosition, State previousState)
	{
	}

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x1063220", Offset = "0x1063220", VA = "0x1063220")]
	public TutorialManager()
	{
	}
}
[Token(Token = "0x20000BA")]
public class TutorialTriggerListener : MonoBehaviour
{
	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool platePlaced;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool bottomBunPlaced;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool meatPlaced;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool topBunPlaced;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool meatCooked;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 placedPosition;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 placedGrillPosition;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject placedPlateObject;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject placedBottomBunObject;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject placedMeatObject;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject placedTopBunObject;

	[Token(Token = "0x600065D")]
	[Address(RVA = "0x10633A4", Offset = "0x10633A4", VA = "0x10633A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600065E")]
	[Address(RVA = "0x10633A8", Offset = "0x10633A8", VA = "0x10633A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x1063450", Offset = "0x1063450", VA = "0x1063450")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x10636A0", Offset = "0x10636A0", VA = "0x10636A0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x1063618", Offset = "0x1063618", VA = "0x1063618")]
	public void CheckPlacedPosition(GameObject placedObject)
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x106365C", Offset = "0x106365C", VA = "0x106365C")]
	public void CheckGrillPlacedPosition(GameObject placedObject)
	{
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x10636A4", Offset = "0x10636A4", VA = "0x10636A4")]
	public TutorialTriggerListener()
	{
	}
}
[Token(Token = "0x20000BB")]
public class ConnectionLostMenu : MonoBehaviourSingleton<ConnectionLostMenu>
{
	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI message;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isActive;

	[Token(Token = "0x6000664")]
	[Address(RVA = "0xE162C0", Offset = "0xE162C0", VA = "0xE162C0")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0xE1644C", Offset = "0xE1644C", VA = "0xE1644C")]
	public void BackButton()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0xE1660C", Offset = "0xE1660C", VA = "0xE1660C")]
	public ConnectionLostMenu()
	{
	}
}
[Token(Token = "0x20000BC")]
public class CanvasCameraHelper : MonoBehaviour
{
	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool hasCamera;

	[Token(Token = "0x6000667")]
	[Address(RVA = "0xE126A8", Offset = "0xE126A8", VA = "0xE126A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0xE12844", Offset = "0xE12844", VA = "0xE12844")]
	public CanvasCameraHelper()
	{
	}
}
[Token(Token = "0x20000BD")]
public class TriggerEventHelper : MonoBehaviour
{
	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EventSystemConfig eventSystem;

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x1060624", Offset = "0x1060624", VA = "0x1060624")]
	private void Start()
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x1060724", Offset = "0x1060724", VA = "0x1060724")]
	public void MenuGoBack()
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x10607A4", Offset = "0x10607A4", VA = "0x10607A4")]
	public void DisableEventSystem()
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x106080C", Offset = "0x106080C", VA = "0x106080C")]
	public void EnableEventSystem()
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x1060874", Offset = "0x1060874", VA = "0x1060874")]
	public void ToggleIngameMenu()
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x10609F4", Offset = "0x10609F4", VA = "0x10609F4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x1060A74", Offset = "0x1060A74", VA = "0x1060A74")]
	public TriggerEventHelper()
	{
	}
}
[Token(Token = "0x20000BE")]
public class IngameMenu : MonoBehaviourSingleton<IngameMenu>
{
	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject inGameButtonGroup;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UIButtonToggle music;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UIButtonToggle effects;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UIButtonToggle vibration;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UIButtonToggle handleLocked;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject restartButton;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject recenterButton;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject tutorialButton;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject tutorialButtonOculus;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool menuClosed;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject voiceSettings;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public UIButtonToggle mic;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public UIButtonToggle speaker;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshProUGUI playerName;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshProUGUI opponentName;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshProUGUI headingText;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public bool canResume;

	[Token(Token = "0x6000670")]
	[Address(RVA = "0xD98F60", Offset = "0xD98F60", VA = "0xD98F60")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0xD992B4", Offset = "0xD992B4", VA = "0xD992B4")]
	public void Show(bool canRestart)
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0xD99714", Offset = "0xD99714", VA = "0xD99714")]
	private void SetHeading()
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0xD999CC", Offset = "0xD999CC", VA = "0xD999CC")]
	public void Toggle(bool canRestart)
	{
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0xD99A80", Offset = "0xD99A80", VA = "0xD99A80")]
	public void CloseIngameMenu()
	{
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0xD99AC4", Offset = "0xD99AC4", VA = "0xD99AC4")]
	public void ShowAfterPause()
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0xD99680", Offset = "0xD99680", VA = "0xD99680")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0xD99A24", Offset = "0xD99A24", VA = "0xD99A24")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0xD99D4C", Offset = "0xD99D4C", VA = "0xD99D4C")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0xD99AF0", Offset = "0xD99AF0", VA = "0xD99AF0")]
	public void ForceReleaseOnPause()
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0xD991F4", Offset = "0xD991F4", VA = "0xD991F4")]
	public void DisabeMicOnPermissionDenied()
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0xD99DBC", Offset = "0xD99DBC", VA = "0xD99DBC")]
	public IngameMenu()
	{
	}
}
[Token(Token = "0x20000BF")]
public class InviteMenu : MonoBehaviourSingleton<InviteMenu>
{
	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TMP_Text inviteText;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isVisible;

	[Token(Token = "0x600067C")]
	[Address(RVA = "0xD9A070", Offset = "0xD9A070", VA = "0xD9A070")]
	public void Show(string opponentName)
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0xD9A15C", Offset = "0xD9A15C", VA = "0xD9A15C", Slot = "6")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0xD995CC", Offset = "0xD995CC", VA = "0xD995CC")]
	public void RespondInvite(bool accept)
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0xD9A28C", Offset = "0xD9A28C", VA = "0xD9A28C")]
	public InviteMenu()
	{
	}
}
[Token(Token = "0x20000C0")]
public class JoinGameMenu : MonoBehaviourSingleton<JoinGameMenu>
{
	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28D40", Offset = "0xD28D40")]
	public TextMeshProUGUI code;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject messageRoomFailed;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string newCode;

	[Token(Token = "0x6000680")]
	[Address(RVA = "0xD9A2DC", Offset = "0xD9A2DC", VA = "0xD9A2DC")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0xD9A3F8", Offset = "0xD9A3F8", VA = "0xD9A3F8")]
	public void EnterCodeFunction(string newNuber)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0xD9A4B8", Offset = "0xD9A4B8", VA = "0xD9A4B8")]
	public void BackSpaceButton()
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0xD9A320", Offset = "0xD9A320", VA = "0xD9A320")]
	public void DeleteCodeButton()
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0xD9A63C", Offset = "0xD9A63C", VA = "0xD9A63C")]
	public void JoinGame()
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0xD9A7B8", Offset = "0xD9A7B8", VA = "0xD9A7B8")]
	public void ShowMessage()
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0xD9A7E8", Offset = "0xD9A7E8", VA = "0xD9A7E8")]
	public JoinGameMenu()
	{
	}
}
[Token(Token = "0x20000C1")]
public class LanguageMenu : MonoBehaviourSingleton<LanguageMenu>
{
	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UIButtonGroup languageButtonGroup;

	[Token(Token = "0x6000687")]
	[Address(RVA = "0xD9ADCC", Offset = "0xD9ADCC", VA = "0xD9ADCC")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0xD9AE60", Offset = "0xD9AE60", VA = "0xD9AE60")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0xD9AE64", Offset = "0xD9AE64", VA = "0xD9AE64")]
	public void SetNewLanguage(int languageIndex)
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0xD9AF88", Offset = "0xD9AF88", VA = "0xD9AF88")]
	public LanguageMenu()
	{
	}
}
[Token(Token = "0x20000C2")]
public class LeaderboardWidget : MonoBehaviour
{
	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD283D8", Offset = "0xD283D8")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LeaderboardWidget <>4__this;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string headerText;

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xD9B174", Offset = "0xD9B174", VA = "0xD9B174")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xD9B238", Offset = "0xD9B238", VA = "0xD9B238")]
		internal void <ShowLeaderboardList>b__0(LeaderboardUserData gameData)
		{
		}
	}

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI[] leaderboardNames;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI[] leaderboardScores;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI leaderboardPlayerName;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI leaderboardPlayerScore;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI headlineText;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UIView leaderboardWidget;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UIView loadingLeaderboardBurger;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject onlinePanel;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject offlinePanel;

	[Token(Token = "0x600068B")]
	[Address(RVA = "0xD9AFE8", Offset = "0xD9AFE8", VA = "0xD9AFE8")]
	public void ShowLeaderboardList(string headerText, int mode, int level)
	{
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0xD9B230", Offset = "0xD9B230", VA = "0xD9B230")]
	public LeaderboardWidget()
	{
	}
}
[Token(Token = "0x20000C3")]
public class MainMenu : MonoBehaviourSingleton<MainMenu>
{
	[Token(Token = "0x600068D")]
	[Address(RVA = "0xD9E380", Offset = "0xD9E380", VA = "0xD9E380")]
	public void CloseMenu()
	{
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0xD9E424", Offset = "0xD9E424", VA = "0xD9E424")]
	public MainMenu()
	{
	}
}
[Token(Token = "0x20000C4")]
public class MatchEndMultiplayerMenu : MonoBehaviourSingleton<MatchEndMultiplayerMenu>
{
	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject multiplayerEndPanel;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject leaderboard;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject backToMenuButton;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject playAgainButton;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject rematchButton;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject playAgainMessage;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI resultText;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI playAgainMessageText;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject leaderboardsResult;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28D78", Offset = "0xD28D78")]
	public TextMeshProUGUI playerName;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI opponentPlayerName;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string nameOfPlayer;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string nameOfOpponent;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28DB0", Offset = "0xD28DB0")]
	public TextMeshProUGUI totalScore;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshProUGUI totalPoints;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshProUGUI opponentTotalScore;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28DE8", Offset = "0xD28DE8")]
	public Slider scoreSlider;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Slider scoreSliderOpponent;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28E20", Offset = "0xD28E20")]
	public TextMeshProUGUI happyCountText;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public TextMeshProUGUI indieCountText;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public TextMeshProUGUI madCountText;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public TextMeshProUGUI leftCountText;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28E58", Offset = "0xD28E58")]
	public TextMeshProUGUI happyCountTextOpponent;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public TextMeshProUGUI indieCountTextOpponent;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public TextMeshProUGUI madCountTextOpponent;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public TextMeshProUGUI leftCountTextOpponent;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28E90", Offset = "0xD28E90")]
	public AudioClip winClip;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public AudioClip loseClip;

	[Token(Token = "0x600068F")]
	[Address(RVA = "0xD9E47C", Offset = "0xD9E47C", VA = "0xD9E47C")]
	public void Show(bool win, int leaderboardsPoints, string name, string opponentName, int score, int opponentScore, int happyCount, int indieCount, int madCount, int customersLeft, int happyCountOpponent, int indieCountOpponent, int madCountOpponent, int leftCountOpponent)
	{
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0xD9EBA8", Offset = "0xD9EBA8", VA = "0xD9EBA8")]
	public void ShowLeaderboardList()
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0xD9EC1C", Offset = "0xD9EC1C", VA = "0xD9EC1C")]
	public void ShowDownloadingView()
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0xD9ECB4", Offset = "0xD9ECB4", VA = "0xD9ECB4")]
	public void ShowRematchView()
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0xD9ED94", Offset = "0xD9ED94", VA = "0xD9ED94")]
	public void ShowRematchMessage(string name)
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0xD9EE78", Offset = "0xD9EE78", VA = "0xD9EE78")]
	public void ShowTotalPoints(int points)
	{
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0xD9EF70", Offset = "0xD9EF70", VA = "0xD9EF70")]
	public MatchEndMultiplayerMenu()
	{
	}
}
[Token(Token = "0x20000C5")]
public class MatchEndSingleplayerMenu : MonoBehaviourSingleton<MatchEndSingleplayerMenu>
{
	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject playNextButton;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject singleplayerEndPanel;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI levelNumber;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI winLoseText;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI scoreText;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI timeText;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28EC8", Offset = "0xD28EC8")]
	public AudioClip winClip;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioClip loseClip;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28F00", Offset = "0xD28F00")]
	public TextMeshProUGUI happySingleCountText;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI indieSingleCountText;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI madSingleCountText;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI leftSingleCountText;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28F38", Offset = "0xD28F38")]
	public LeaderboardWidget leaderboardCampaign;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public LeaderboardWidget leaderboardEndless;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private int moodsCount;

	[Token(Token = "0x6000696")]
	[Address(RVA = "0xD9EFC0", Offset = "0xD9EFC0", VA = "0xD9EFC0")]
	public void Show(int level, bool win, float timePassed, int score, int happyCount, int indieCount, int madCount, int customersLeft)
	{
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0xD9FAF0", Offset = "0xD9FAF0", VA = "0xD9FAF0")]
	private void PlaySoundSingleplayer()
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0xD9F8A0", Offset = "0xD9F8A0", VA = "0xD9F8A0")]
	public void UnlockAchievementInLevels(int level)
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0xD9F7EC", Offset = "0xD9F7EC", VA = "0xD9F7EC")]
	public void CountHappyMoods(int happyCount, int indieCount, int madCount, int customersLeft)
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0xD9FB70", Offset = "0xD9FB70", VA = "0xD9FB70")]
	public MatchEndSingleplayerMenu()
	{
	}
}
[Token(Token = "0x20000C6")]
public class MenuController : MonoBehaviour
{
	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MenuController instance;

	[Token(Token = "0x600069B")]
	[Address(RVA = "0xDA1430", Offset = "0xDA1430", VA = "0xDA1430")]
	private void Awake()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0xDA1510", Offset = "0xDA1510", VA = "0xDA1510")]
	private void Start()
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0xDA1514", Offset = "0xDA1514", VA = "0xDA1514")]
	public void OpenMenu()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0xD9E3F0", Offset = "0xD9E3F0", VA = "0xD9E3F0")]
	public void ShowBook(bool enable)
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0xDA15B0", Offset = "0xDA15B0", VA = "0xDA15B0")]
	public void Navigate(Type classType)
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0xDA1754", Offset = "0xDA1754", VA = "0xDA1754")]
	private void OpenSingleplayer()
	{
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0xDA1880", Offset = "0xDA1880", VA = "0xDA1880")]
	private void MultiplayerAutoConnect()
	{
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0xDA1A28", Offset = "0xDA1A28", VA = "0xDA1A28")]
	public MenuController()
	{
	}
}
[Token(Token = "0x20000C7")]
public class MessageMenu : MonoBehaviourSingleton<MessageMenu>
{
	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TMP_Text messageText;

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0xDA0D78", Offset = "0xDA0D78", VA = "0xDA0D78")]
	public void Show(string message)
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0xDA1A30", Offset = "0xDA1A30", VA = "0xDA1A30")]
	public MessageMenu()
	{
	}
}
[Token(Token = "0x20000C8")]
public class MultiplayerConnectingMenu : MonoBehaviourSingleton<MultiplayerConnectingMenu>
{
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0xDA43F8", Offset = "0xDA43F8", VA = "0xDA43F8")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0xDA4728", Offset = "0xDA4728", VA = "0xDA4728")]
	public void OnConnected(bool isConnected)
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0xDA47A0", Offset = "0xDA47A0", VA = "0xDA47A0")]
	public void NotLoggedView()
	{
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0xDA47FC", Offset = "0xDA47FC", VA = "0xDA47FC")]
	public MultiplayerConnectingMenu()
	{
	}
}
[Token(Token = "0x20000C9")]
public class MultiplayerDownloadingMenu : MonoBehaviourSingleton<MultiplayerDownloadingMenu>
{
	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI messageConnectingText;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ProgressController progressObject;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isCancelled;

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0xDA484C", Offset = "0xDA484C", VA = "0xDA484C")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0xDA49D4", Offset = "0xDA49D4", VA = "0xDA49D4")]
	public void StartReplayGame(bool connected)
	{
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0xDA4B08", Offset = "0xDA4B08", VA = "0xDA4B08")]
	public void GoToMultipayer()
	{
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0xDA4BD8", Offset = "0xDA4BD8", VA = "0xDA4BD8")]
	public void CancelAsync()
	{
	}

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0xDA4BE4", Offset = "0xDA4BE4", VA = "0xDA4BE4")]
	public MultiplayerDownloadingMenu()
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0xDA4C34", Offset = "0xDA4C34", VA = "0xDA4C34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A118", Offset = "0xD2A118")]
	private void <StartReplayGame>b__4_0(MultiplayerGameData gameData)
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0xDA4D94", Offset = "0xDA4D94", VA = "0xDA4D94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A128", Offset = "0xD2A128")]
	private void <StartReplayGame>b__4_1(int progress)
	{
	}
}
[Token(Token = "0x20000CA")]
public class MultiplayerEndPanelDownloadingMenu : MonoBehaviourSingleton<MultiplayerEndPanelDownloadingMenu>
{
	[Serializable]
	[Token(Token = "0x200019C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD283E8", Offset = "0xD283E8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> <>9__1_1;

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xDA51E0", Offset = "0xDA51E0", VA = "0xDA51E0")]
		public <>c()
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xDA51E8", Offset = "0xDA51E8", VA = "0xDA51E8")]
		internal void <StartReplayGame>b__1_1(int progress)
		{
		}
	}

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI messageConnectingText;

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0xDA4DB0", Offset = "0xDA4DB0", VA = "0xDA4DB0")]
	public void StartReplayGame()
	{
	}

	[Token(Token = "0x60006B1")]
	[Address(RVA = "0xDA4F20", Offset = "0xDA4F20", VA = "0xDA4F20")]
	public void GoToMultipayer()
	{
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0xDA5048", Offset = "0xDA5048", VA = "0xDA5048")]
	public MultiplayerEndPanelDownloadingMenu()
	{
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0xDA5098", Offset = "0xDA5098", VA = "0xDA5098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A138", Offset = "0xD2A138")]
	private void <StartReplayGame>b__1_0(MultiplayerGameData gameData)
	{
	}
}
[Token(Token = "0x20000CB")]
public class MultiplayerInviteMenu : MonoBehaviourSingleton<MultiplayerInviteMenu>
{
	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD283F8", Offset = "0xD283F8")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public KeyValuePair<ulong, string> friend;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MultiplayerInviteMenu <>4__this;

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xDA7238", Offset = "0xDA7238", VA = "0xDA7238")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xDA73F8", Offset = "0xDA73F8", VA = "0xDA73F8")]
		internal void <BeforeShow>b__1()
		{
		}
	}

	[Token(Token = "0x200019E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28408", Offset = "0xD28408")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong friendId;

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xDA6E08", Offset = "0xDA6E08", VA = "0xDA6E08")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xDA7240", Offset = "0xDA7240", VA = "0xDA7240")]
		internal void <SendFriendInvite>b__0(bool successful)
		{
		}
	}

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public VerticalLayoutGroup scrollList;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject itemTemplate;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UIButtonGroup restaurant;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UIButtonGroup difficulty;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI username;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool isVisible;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI codeText;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public string code;

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0xDA6578", Offset = "0xDA6578", VA = "0xDA6578")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0xDA6C24", Offset = "0xDA6C24", VA = "0xDA6C24")]
	public void GoToMatchmaking(bool success)
	{
	}

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0xDA6C28", Offset = "0xDA6C28", VA = "0xDA6C28")]
	public void LeaveRoom()
	{
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0xDA6CCC", Offset = "0xDA6CCC", VA = "0xDA6CCC")]
	public void SendFriendInvite(ulong friendId)
	{
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0xDA6AEC", Offset = "0xDA6AEC", VA = "0xDA6AEC")]
	public void SetDifficultyMood()
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0xDA6E10", Offset = "0xDA6E10", VA = "0xDA6E10")]
	public void SetCurrentRestaurant(int currentRestaurant)
	{
	}

	[Token(Token = "0x60006BA")]
	[Address(RVA = "0xDA6E70", Offset = "0xDA6E70", VA = "0xDA6E70")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0xDA6E78", Offset = "0xDA6E78", VA = "0xDA6E78")]
	public MultiplayerInviteMenu()
	{
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0xDA6EE0", Offset = "0xDA6EE0", VA = "0xDA6EE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A148", Offset = "0xD2A148")]
	private void <BeforeShow>b__8_0(Dictionary<ulong, string> friends)
	{
	}
}
[Token(Token = "0x20000CC")]
public class MultiplayerInviteWaiting : MonoBehaviourSingleton<MultiplayerInviteWaiting>
{
	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI message;

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0xDA7448", Offset = "0xDA7448", VA = "0xDA7448")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0xDA74D0", Offset = "0xDA74D0", VA = "0xDA74D0")]
	public void OnDeclineMessage()
	{
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0xDA7558", Offset = "0xDA7558", VA = "0xDA7558")]
	public void CancelInvite()
	{
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0xDA7674", Offset = "0xDA7674", VA = "0xDA7674")]
	public MultiplayerInviteWaiting()
	{
	}
}
[Token(Token = "0x20000CD")]
public class MultiplayerMatchmakingMenu : MonoBehaviourSingleton<MultiplayerMatchmakingMenu>
{
	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI gameStartsTimerText;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float countdownTimer;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] playerPreferredKitchen;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject[] opponentPreferredKitchen;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI playerPreferredKitchenText;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI opponentPreferredKitchenText;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Animator matchAnim;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private int randomMatchIndex;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float duration;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int opponentPreferedKitchenIndex;

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x22A6640", Offset = "0x22A6640", VA = "0x22A6640", Slot = "4")]
	public override void Start()
	{
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x22A67AC", Offset = "0x22A67AC", VA = "0x22A67AC")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x22A6AC8", Offset = "0x22A6AC8", VA = "0x22A6AC8")]
	public void SetPrefferedKitchen(int opponentKitchen, string opponentName)
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x22A6C30", Offset = "0x22A6C30", VA = "0x22A6C30")]
	private void Update()
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x22A6C68", Offset = "0x22A6C68", VA = "0x22A6C68")]
	public void PrepareMultiplayerRealtimeDelayed()
	{
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x22A6CDC", Offset = "0x22A6CDC", VA = "0x22A6CDC")]
	public void MultiplayerCountdownTimer()
	{
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x22A6DF8", Offset = "0x22A6DF8", VA = "0x22A6DF8")]
	public void ShowPreferredKitchen(params object[] data)
	{
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x22A70C4", Offset = "0x22A70C4", VA = "0x22A70C4")]
	public void KitchenChoosen(params object[] data)
	{
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x22A71D4", Offset = "0x22A71D4", VA = "0x22A71D4")]
	public void RunRandomMultiplayerMatch()
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x22A7398", Offset = "0x22A7398", VA = "0x22A7398")]
	public void CancelMachmaking()
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x22A760C", Offset = "0x22A760C", VA = "0x22A760C")]
	public MultiplayerMatchmakingMenu()
	{
	}
}
[Token(Token = "0x20000CE")]
public class MultiplayerMenu : MonoBehaviourSingleton<MultiplayerMenu>
{
	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI username;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject inviteButton;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UIButtonGroup kitchenButtonsGroup;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LeaderboardWidget leaderboard;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool isVisible;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool autoJoin;

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x22A7664", Offset = "0x22A7664", VA = "0x22A7664")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x22A78FC", Offset = "0x22A78FC", VA = "0x22A78FC")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x22A7980", Offset = "0x22A7980", VA = "0x22A7980")]
	public void DisconectFromServer()
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x22A79F0", Offset = "0x22A79F0", VA = "0x22A79F0")]
	public void SetCurrentRestaurant(int currentRestaurant)
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x22A7A50", Offset = "0x22A7A50", VA = "0x22A7A50")]
	public void ShowMultiplayerLeaderboards()
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x22A7B50", Offset = "0x22A7B50", VA = "0x22A7B50")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x22A7BAC", Offset = "0x22A7BAC", VA = "0x22A7BAC")]
	public MultiplayerMenu()
	{
	}
}
[Token(Token = "0x20000CF")]
public class MultiplayerNotConnectedMenu : MonoBehaviourSingleton<MultiplayerNotConnectedMenu>
{
	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI message;

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x22A7BFC", Offset = "0x22A7BFC", VA = "0x22A7BFC")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x22A7CB4", Offset = "0x22A7CB4", VA = "0x22A7CB4")]
	public MultiplayerNotConnectedMenu()
	{
	}
}
[Token(Token = "0x20000D0")]
public class MultiplayerNotLoggedinMenu : MonoBehaviourSingleton<MultiplayerNotLoggedinMenu>
{
	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI message;

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x22A7D04", Offset = "0x22A7D04", VA = "0x22A7D04")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x22A7D90", Offset = "0x22A7D90", VA = "0x22A7D90")]
	public MultiplayerNotLoggedinMenu()
	{
	}
}
[Token(Token = "0x20000D1")]
public class MultiplayerRematchMenu : MonoBehaviourSingleton<MultiplayerRematchMenu>
{
	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject backToMenuButton;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject readyButton;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UIButtonGroup kitchenButtonsGroup;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI waitingMessageText;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI playerLeftText;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI readyTextPlayer;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI readyTextOpponent;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject readyPlayer;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject readyOpponent;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool isReady;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool isOpponentReady;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public int restaurantSelectedOpponent;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD28F70", Offset = "0xD28F70")]
	public TextMeshProUGUI playerName;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI opponentPlayerName;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public GameObject playerNameBox;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject opponentNameBox;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool isInvited;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
	public bool isRematchShown;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
	public bool isSender;

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x22A7DE0", Offset = "0x22A7DE0", VA = "0x22A7DE0")]
	public void Show(string name, string opponentName, bool isRematch)
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x22A829C", Offset = "0x22A829C", VA = "0x22A829C")]
	public void RefreshState()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x22A8854", Offset = "0x22A8854", VA = "0x22A8854")]
	public void SetCurrentRematchRestaurant(int currentRestaurant)
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x22A88B4", Offset = "0x22A88B4", VA = "0x22A88B4")]
	public void SetReadyPlayer()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x22A83C8", Offset = "0x22A83C8", VA = "0x22A83C8")]
	public void RefreshReadyState()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x22A8D74", Offset = "0x22A8D74", VA = "0x22A8D74")]
	public void SetReadyOpponent()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x22A8C40", Offset = "0x22A8C40", VA = "0x22A8C40")]
	public void StartMatchmaking()
	{
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x22A8F58", Offset = "0x22A8F58", VA = "0x22A8F58")]
	public void OnOpponentFound()
	{
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x22A819C", Offset = "0x22A819C", VA = "0x22A819C")]
	public void DisableUIButtons()
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x22A9028", Offset = "0x22A9028", VA = "0x22A9028")]
	public MultiplayerRematchMenu()
	{
	}
}
[Token(Token = "0x20000D2")]
public class MultiplayerSearchingMenu : MonoBehaviourSingleton<MultiplayerSearchingMenu>
{
	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject skipToAsyncronousMultiplayer;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject cancelButton;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float connectingTimer;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI timerText;

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x22A9078", Offset = "0x22A9078", VA = "0x22A9078", Slot = "4")]
	public override void Start()
	{
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x22A913C", Offset = "0x22A913C", VA = "0x22A913C")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x22A9260", Offset = "0x22A9260", VA = "0x22A9260")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x22A92E0", Offset = "0x22A92E0", VA = "0x22A92E0")]
	private void Update()
	{
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x22A9318", Offset = "0x22A9318", VA = "0x22A9318")]
	public void Cancel()
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x22A9444", Offset = "0x22A9444", VA = "0x22A9444")]
	public void OnCancel(bool success)
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x22A94A0", Offset = "0x22A94A0", VA = "0x22A94A0")]
	private void MultiplayerLiveTimer()
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x22A954C", Offset = "0x22A954C", VA = "0x22A954C")]
	public void ShowSkipToAsynchronousMultiplayerButton()
	{
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x22A95D0", Offset = "0x22A95D0", VA = "0x22A95D0")]
	public void OnOpponentFound()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x22A962C", Offset = "0x22A962C", VA = "0x22A962C")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x22A9688", Offset = "0x22A9688", VA = "0x22A9688")]
	public MultiplayerSearchingMenu()
	{
	}
}
[Token(Token = "0x20000D3")]
public class NotificationMenu : MonoBehaviourSingleton<NotificationMenu>
{
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x22ADE18", Offset = "0x22ADE18", VA = "0x22ADE18")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x22ADE1C", Offset = "0x22ADE1C", VA = "0x22ADE1C")]
	public void ClosePanel()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x22ADE28", Offset = "0x22ADE28", VA = "0x22ADE28")]
	public NotificationMenu()
	{
	}
}
[Token(Token = "0x20000D4")]
public class OptionsMenu : MonoBehaviourSingleton<OptionsMenu>
{
	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UIButtonToggle music;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UIButtonToggle effects;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UIButtonToggle vibration;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UIButtonToggle handleLocked;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject recenterButton;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject tutorials;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject tutorialsOculus;

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x22B4408", Offset = "0x22B4408", VA = "0x22B4408")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x22B4574", Offset = "0x22B4574", VA = "0x22B4574")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x22B45E4", Offset = "0x22B45E4", VA = "0x22B45E4")]
	public OptionsMenu()
	{
	}
}
[Token(Token = "0x20000D5")]
public class PlayerLeftMenu : MonoBehaviourSingleton<PlayerLeftMenu>
{
	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TMP_Text opponentLeftText;

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x22BDD4C", Offset = "0x22BDD4C", VA = "0x22BDD4C")]
	public void Show(string opponentName)
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x22BDEFC", Offset = "0x22BDEFC", VA = "0x22BDEFC")]
	public PlayerLeftMenu()
	{
	}
}
[Token(Token = "0x20000D6")]
public class RecenterUIMenu : MonoBehaviourSingleton<RecenterUIMenu>
{
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x22C3108", Offset = "0x22C3108", VA = "0x22C3108")]
	public void HideRecenterView()
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x22C344C", Offset = "0x22C344C", VA = "0x22C344C")]
	public RecenterUIMenu()
	{
	}
}
[Token(Token = "0x20000D7")]
public class SingleplayerMenu : MonoBehaviourSingleton<SingleplayerMenu>
{
	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UIViewCategoryName[] pages;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UIButtonGroup levelGroup;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UIButtonGroup gameMode;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LeaderboardWidget leaderboardCampaign;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LeaderboardWidget leaderboardEndless;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float clickDelay;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float timeFromClick;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isClicked;

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x22F42E4", Offset = "0x22F42E4", VA = "0x22F42E4")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x22F4418", Offset = "0x22F4418", VA = "0x22F4418")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x22F44B8", Offset = "0x22F44B8", VA = "0x22F44B8")]
	public void ShowStartPage()
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x22F468C", Offset = "0x22F468C", VA = "0x22F468C")]
	public void ShowPage(int pageIndex)
	{
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x22F4798", Offset = "0x22F4798", VA = "0x22F4798")]
	public void ShowEndlessLeaderboards()
	{
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x22F4888", Offset = "0x22F4888", VA = "0x22F4888")]
	public void ShowLevelLeaderboards()
	{
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x22F49C4", Offset = "0x22F49C4", VA = "0x22F49C4")]
	public void StartSingleplayerMatch()
	{
	}

	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x22F4C7C", Offset = "0x22F4C7C", VA = "0x22F4C7C")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x60006FE")]
	[Address(RVA = "0x22F4D50", Offset = "0x22F4D50", VA = "0x22F4D50")]
	public void BackWithDelay()
	{
	}

	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x22F4D6C", Offset = "0x22F4D6C", VA = "0x22F4D6C")]
	public SingleplayerMenu()
	{
	}
}
[Token(Token = "0x20000D8")]
public class SingleplayerRestaurantMenu : MonoBehaviourSingleton<SingleplayerRestaurantMenu>
{
	[Token(Token = "0x6000700")]
	[Address(RVA = "0x22F4DC4", Offset = "0x22F4DC4", VA = "0x22F4DC4")]
	public void SetCurrentRestaurant(int currentRestaurant)
	{
	}

	[Token(Token = "0x6000701")]
	[Address(RVA = "0x22F4E24", Offset = "0x22F4E24", VA = "0x22F4E24")]
	public SingleplayerRestaurantMenu()
	{
	}
}
[Token(Token = "0x20000D9")]
public class WaiterCustomizationMenu : MonoBehaviourSingleton<WaiterCustomizationMenu>
{
	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UIViewCategoryName[] pages;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UIButtonGroup chooseCategoryGroup;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UIButtonGroup bodyGroup;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UIButtonGroup headTypeGroup;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UIButtonGroup hairTypeGroup;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public UIButtonGroup hairColorGroup;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public UIButtonGroup skinToneGroup;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public UIButtonGroup eyesColorGroup;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UIButtonGroup eyesTypeGroup;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AvatarGroup waiter;

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x106B158", Offset = "0x106B158", VA = "0x106B158")]
	public void ShowWaiterMenu()
	{
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x106B21C", Offset = "0x106B21C", VA = "0x106B21C")]
	public void HideWaiterMenu()
	{
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x106B2BC", Offset = "0x106B2BC", VA = "0x106B2BC")]
	public void BeforeShow()
	{
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x106B4B0", Offset = "0x106B4B0", VA = "0x106B4B0")]
	public void ShowPage(int pageIndex)
	{
	}

	[Token(Token = "0x6000706")]
	[Address(RVA = "0x106B5BC", Offset = "0x106B5BC", VA = "0x106B5BC")]
	public void RefreshAvatar()
	{
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x106B728", Offset = "0x106B728", VA = "0x106B728")]
	public void BeforeHide()
	{
	}

	[Token(Token = "0x6000708")]
	[Address(RVA = "0x106B798", Offset = "0x106B798", VA = "0x106B798")]
	public WaiterCustomizationMenu()
	{
	}
}
[Token(Token = "0x20000DA")]
public class AmbientAudioManager : MonoBehaviour
{
	[Token(Token = "0x200019F")]
	public enum AmbientState
	{
		[Token(Token = "0x4000879")]
		NONE,
		[Token(Token = "0x400087A")]
		FADE_IN_NEXT,
		[Token(Token = "0x400087B")]
		GOTO_NEXT,
		[Token(Token = "0x400087C")]
		GOTO_PREVIOUS,
		[Token(Token = "0x400087D")]
		FADE_IN_PREVIOUS
	}

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource[] audioSource;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int currentAudioSourceIndex;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float fadeInDuration;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fadeInVolume;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float fadeOutVolume;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float fadeOutDuration;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip[] audioClips;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float maxVolume;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int previousClipIndex;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int currentClipIndex;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public AmbientState state;

	[Token(Token = "0x6000709")]
	[Address(RVA = "0xE04A00", Offset = "0xE04A00", VA = "0xE04A00")]
	private void Awake()
	{
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0xE04AA0", Offset = "0xE04AA0", VA = "0xE04AA0")]
	private void Start()
	{
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0xE04B64", Offset = "0xE04B64", VA = "0xE04B64")]
	public void PlayAmbient()
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0xE04BD4", Offset = "0xE04BD4", VA = "0xE04BD4")]
	public void StopAmbient()
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0xE04C44", Offset = "0xE04C44", VA = "0xE04C44")]
	private void Update()
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0xE05240", Offset = "0xE05240", VA = "0xE05240")]
	public void SwitchState(AmbientState newState)
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0xE04C7C", Offset = "0xE04C7C", VA = "0xE04C7C")]
	public void FadeInNext()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0xE04DF4", Offset = "0xE04DF4", VA = "0xE04DF4")]
	public void GoToNextSound()
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0xE050C8", Offset = "0xE050C8", VA = "0xE050C8")]
	public void FadeInPrevious()
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0xE04F60", Offset = "0xE04F60", VA = "0xE04F60")]
	public void GoToPreviousSound()
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0xE05248", Offset = "0xE05248", VA = "0xE05248")]
	public void PlayNextSound()
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0xE05320", Offset = "0xE05320", VA = "0xE05320")]
	public void BackToPreviusSound()
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0xE05278", Offset = "0xE05278", VA = "0xE05278")]
	public int GetCustomersCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0xE05350", Offset = "0xE05350", VA = "0xE05350")]
	public AmbientAudioManager()
	{
	}
}
[Token(Token = "0x20000DB")]
public class Analytics
{
	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool Enabled;

	[Token(Token = "0x6000717")]
	[Address(RVA = "0xE05360", Offset = "0xE05360", VA = "0xE05360")]
	public static void SessionStart(string platform)
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0xE05538", Offset = "0xE05538", VA = "0xE05538")]
	public static void LevelStart(int restaurant, int level)
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0xE055F8", Offset = "0xE055F8", VA = "0xE055F8")]
	public static void LevelStartMultiplayerAsync(int restaurant)
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0xE05710", Offset = "0xE05710", VA = "0xE05710")]
	public static void LevelCompleteMultiplayerAsync(int restaurant, int points, bool win)
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0xE058A4", Offset = "0xE058A4", VA = "0xE058A4")]
	public static void LevelStartMultiplayerRealtime(int restaurant)
	{
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0xE059BC", Offset = "0xE059BC", VA = "0xE059BC")]
	public static void LevelCompleteMultiplayerRealtime(int restaurant, int points, bool win)
	{
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0xE05B50", Offset = "0xE05B50", VA = "0xE05B50")]
	public static void LevelComplete(int restaurant, int level, bool complete)
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0xE05C4C", Offset = "0xE05C4C", VA = "0xE05C4C")]
	public static void LevelQuit(int level)
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0xE05CF4", Offset = "0xE05CF4", VA = "0xE05CF4")]
	public Analytics()
	{
	}
}
[Token(Token = "0x20000DC")]
public class AnimateHands : MonoBehaviour
{
	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator handAnimator;

	[Token(Token = "0x6000721")]
	[Address(RVA = "0xE05D50", Offset = "0xE05D50", VA = "0xE05D50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0xE05ED8", Offset = "0xE05ED8", VA = "0xE05ED8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0xE05EDC", Offset = "0xE05EDC", VA = "0xE05EDC")]
	public void ButtonPressed()
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0xE06024", Offset = "0xE06024", VA = "0xE06024")]
	public void ButtonReleased()
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0xE0616C", Offset = "0xE0616C", VA = "0xE0616C")]
	public AnimateHands()
	{
	}
}
[Token(Token = "0x20000DD")]
public class AppEntitlementCheck : MonoBehaviour
{
	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject failedText;

	[Token(Token = "0x6000726")]
	[Address(RVA = "0xE06174", Offset = "0xE06174", VA = "0xE06174")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0xE06314", Offset = "0xE06314", VA = "0xE06314")]
	private void Start()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0xE06318", Offset = "0xE06318", VA = "0xE06318")]
	private void DelayedQuit()
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0xE06320", Offset = "0xE06320", VA = "0xE06320")]
	private void EntitlementCallback(Message msg)
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0xE06424", Offset = "0xE06424", VA = "0xE06424")]
	public AppEntitlementCheck()
	{
	}
}
[Token(Token = "0x20000DE")]
public class ArtificialPhysics : MonoBehaviour
{
	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 artificialVelocity;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 previousPosition;

	[Token(Token = "0x600072B")]
	[Address(RVA = "0xE0642C", Offset = "0xE0642C", VA = "0xE0642C")]
	private void Start()
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0xE06468", Offset = "0xE06468", VA = "0xE06468")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0xE065B0", Offset = "0xE065B0", VA = "0xE065B0")]
	public ArtificialPhysics()
	{
	}
}
[Token(Token = "0x20000DF")]
public class AudioHelper : MonoBehaviourPun
{
	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource soundOnAwake;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioSource specificSound;

	[Token(Token = "0x600072E")]
	[Address(RVA = "0xE065B8", Offset = "0xE065B8", VA = "0xE065B8")]
	private void Start()
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0xE0672C", Offset = "0xE0672C", VA = "0xE0672C")]
	public void PlaySound(AudioSource sound)
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0xE0678C", Offset = "0xE0678C", VA = "0xE0678C")]
	public void PlaySpecificSound()
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0xE0682C", Offset = "0xE0682C", VA = "0xE0682C")]
	[PunRPC]
	public void PlaySpecificSoundRPC()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0xE068D0", Offset = "0xE068D0", VA = "0xE068D0")]
	public AudioHelper()
	{
	}
}
[Token(Token = "0x20000E0")]
public class AudioManager : MonoBehaviour
{
	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AudioManager instance;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<AudioSource> sounds;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioSource music;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AmbientAudioManager ambient;

	[Token(Token = "0x6000733")]
	[Address(RVA = "0xE068D8", Offset = "0xE068D8", VA = "0xE068D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000734")]
	[Address(RVA = "0xE069B8", Offset = "0xE069B8", VA = "0xE069B8")]
	public void SetAudio()
	{
	}

	[Token(Token = "0x6000735")]
	[Address(RVA = "0xE06658", Offset = "0xE06658", VA = "0xE06658")]
	public void PlaySound(AudioSource sound)
	{
	}

	[Token(Token = "0x6000736")]
	[Address(RVA = "0xE06B6C", Offset = "0xE06B6C", VA = "0xE06B6C")]
	public void StopSound(AudioSource sound)
	{
	}

	[Token(Token = "0x6000737")]
	[Address(RVA = "0xE06A74", Offset = "0xE06A74", VA = "0xE06A74")]
	public void PauseAllSounds()
	{
	}

	[Token(Token = "0x6000738")]
	[Address(RVA = "0xE06BE4", Offset = "0xE06BE4", VA = "0xE06BE4")]
	public void UnPauseAllSounds()
	{
	}

	[Token(Token = "0x6000739")]
	[Address(RVA = "0xE06B30", Offset = "0xE06B30", VA = "0xE06B30")]
	public void PauseMusic()
	{
	}

	[Token(Token = "0x600073A")]
	[Address(RVA = "0xE06CA0", Offset = "0xE06CA0", VA = "0xE06CA0")]
	public void UnPauseMusic()
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0xE06CE0", Offset = "0xE06CE0", VA = "0xE06CE0")]
	public AudioManager()
	{
	}
}
[Token(Token = "0x20000E1")]
public class AvatarMovement : MonoBehaviour
{
	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject avatarHead;

	[Token(Token = "0x600073C")]
	[Address(RVA = "0xE08160", Offset = "0xE08160", VA = "0xE08160")]
	private void Start()
	{
	}

	[Token(Token = "0x600073D")]
	[Address(RVA = "0xE0818C", Offset = "0xE0818C", VA = "0xE0818C")]
	private void Update()
	{
	}

	[Token(Token = "0x600073E")]
	[Address(RVA = "0xE082A4", Offset = "0xE082A4", VA = "0xE082A4")]
	public AvatarMovement()
	{
	}
}
[Token(Token = "0x20000E2")]
public class BambooRollerSpawner : MonoBehaviourPun
{
	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28FA8", Offset = "0xD28FA8")]
	public GameObject bambooRollerPrefab;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static BambooRollerSpawner instance;

	[Token(Token = "0x600073F")]
	[Address(RVA = "0xE0900C", Offset = "0xE0900C", VA = "0xE0900C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000740")]
	[Address(RVA = "0xE090EC", Offset = "0xE090EC", VA = "0xE090EC", Slot = "4")]
	public virtual void SetBambooRollerPosition()
	{
	}

	[Token(Token = "0x6000741")]
	[Address(RVA = "0xE09440", Offset = "0xE09440", VA = "0xE09440")]
	[PunRPC]
	public void SetBambooParent(int bambooIndex, int currentCustomerManager)
	{
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0xE095D4", Offset = "0xE095D4", VA = "0xE095D4")]
	public BambooRollerSpawner()
	{
	}
}
[Token(Token = "0x20000E3")]
public class BeziereCurve : MonoBehaviour
{
	[Token(Token = "0x6000743")]
	[Address(RVA = "0xE09BA0", Offset = "0xE09BA0", VA = "0xE09BA0")]
	public Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0xE09D2C", Offset = "0xE09D2C", VA = "0xE09D2C")]
	public Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0xE08C38", Offset = "0xE08C38", VA = "0xE08C38")]
	public Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0xE09E88", Offset = "0xE09E88", VA = "0xE09E88")]
	public Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0xE0A0C4", Offset = "0xE0A0C4", VA = "0xE0A0C4")]
	public BeziereCurve()
	{
	}
}
[Token(Token = "0x20000E4")]
public class BillboardSprite : MonoBehaviour
{
	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject activeCameraRig;

	[Token(Token = "0x6000748")]
	[Address(RVA = "0xE0A0CC", Offset = "0xE0A0CC", VA = "0xE0A0CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0xE0A144", Offset = "0xE0A144", VA = "0xE0A144")]
	private void Start()
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0xE0A148", Offset = "0xE0A148", VA = "0xE0A148", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0xE0A1A8", Offset = "0xE0A1A8", VA = "0xE0A1A8", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0xE0A220", Offset = "0xE0A220", VA = "0xE0A220")]
	private void Update()
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0xE0A314", Offset = "0xE0A314", VA = "0xE0A314")]
	public BillboardSprite()
	{
	}
}
[Token(Token = "0x20000E5")]
public class BlendShapeTween : MonoBehaviour
{
	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD28FE0", Offset = "0xD28FE0")]
	public SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29018", Offset = "0xD29018")]
	public float blendSpeed;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29050", Offset = "0xD29050")]
	public int startValue;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29088", Offset = "0xD29088")]
	public float endValue;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD290C0", Offset = "0xD290C0")]
	public int blendShapeIndex;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD290F8", Offset = "0xD290F8")]
	public UnityEvent OnTweenFinished;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isReversed;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isTweening;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float blendValue;

	[Token(Token = "0x600074E")]
	[Address(RVA = "0xE0A31C", Offset = "0xE0A31C", VA = "0xE0A31C")]
	private void Update()
	{
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0xE0A3E4", Offset = "0xE0A3E4", VA = "0xE0A3E4")]
	public void StartShape()
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0xE0A408", Offset = "0xE0A408", VA = "0xE0A408")]
	public BlendShapeTween()
	{
	}
}
[Token(Token = "0x20000E6")]
public class BoundObjectsController : MonoBehaviour
{
	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> boundObjects;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> boundObjectsStartPosition;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Quaternion> boundObjectsStartRotation;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject otherGameObject;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isInstantiated;

	[Token(Token = "0x6000751")]
	[Address(RVA = "0xE0B49C", Offset = "0xE0B49C", VA = "0xE0B49C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0xE0B630", Offset = "0xE0B630", VA = "0xE0B630")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0xE0B868", Offset = "0xE0B868", VA = "0xE0B868")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0xE0B870", Offset = "0xE0B870", VA = "0xE0B870")]
	private void DestroyBoundObjects()
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0xE0B8DC", Offset = "0xE0B8DC", VA = "0xE0B8DC")]
	public BoundObjectsController()
	{
	}
}
[Token(Token = "0x20000E7")]
public class CameraHelper : MonoBehaviour
{
	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera _camera;

	[Token(Token = "0x1700001D")]
	public static Camera main
	{
		[Token(Token = "0x6000756")]
		[Address(RVA = "0xE11BFC", Offset = "0xE11BFC", VA = "0xE11BFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0xE11E44", Offset = "0xE11E44", VA = "0xE11E44")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0xE11E98", Offset = "0xE11E98", VA = "0xE11E98")]
	public static void SetCamera(Camera newCamera)
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0xE11D6C", Offset = "0xE11D6C", VA = "0xE11D6C")]
	protected static Camera FindCamera()
	{
		return null;
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0xE11EF0", Offset = "0xE11EF0", VA = "0xE11EF0")]
	public CameraHelper()
	{
	}
}
[Token(Token = "0x20000E8")]
public class DarknessPostProcessing : MonoBehaviour
{
	[Token(Token = "0x20001A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28418", Offset = "0xD28418")]
	private sealed class <DoFade>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DarknessPostProcessing <>4__this;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <step>5__2;

		[Token(Token = "0x1700003D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x22DC59C", Offset = "0x22DC59C", VA = "0x22DC59C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x22DC604", Offset = "0x22DC604", VA = "0x22DC604", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x22DC46C", Offset = "0x22DC46C", VA = "0x22DC46C")]
		[DebuggerHidden]
		public <DoFade>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x22DC4A8", Offset = "0x22DC4A8", VA = "0x22DC4A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x22DC4AC", Offset = "0x22DC4AC", VA = "0x22DC4AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x22DC5A4", Offset = "0x22DC5A4", VA = "0x22DC5A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material material;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float FadeTime;

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x22DC208", Offset = "0x22DC208", VA = "0x22DC208")]
	private void Start()
	{
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x22DC28C", Offset = "0x22DC28C", VA = "0x22DC28C")]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x22DC310", Offset = "0x22DC310", VA = "0x22DC310")]
	public void StartFade()
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x22DC388", Offset = "0x22DC388", VA = "0x22DC388")]
	private void End()
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x22DC3F0", Offset = "0x22DC3F0", VA = "0x22DC3F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD2A178", Offset = "0xD2A178")]
	private IEnumerator DoFade()
	{
		return null;
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x22DC498", Offset = "0x22DC498", VA = "0x22DC498")]
	public DarknessPostProcessing()
	{
	}
}
[Token(Token = "0x20000E9")]
public class DebugController : MonoBehaviour
{
	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MatchManager matchManager;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CustomerManager customerManager;

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x22DC60C", Offset = "0x22DC60C", VA = "0x22DC60C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x22DC610", Offset = "0x22DC610", VA = "0x22DC610")]
	public void DebugShowOrder()
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x22DC6D0", Offset = "0x22DC6D0", VA = "0x22DC6D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x22DCFC0", Offset = "0x22DCFC0", VA = "0x22DCFC0")]
	public DebugController()
	{
	}
}
[Token(Token = "0x20000EA")]
public class DelayedDestroyController : MonoBehaviour
{
	[Token(Token = "0x20001A1")]
	public delegate void PreDestroy(GameObject gameObject);

	[Token(Token = "0x40005F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PreDestroy preDestroyFunc;

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x22DE67C", Offset = "0x22DE67C", VA = "0x22DE67C")]
	public void DelayedDestroy(float time, PreDestroy preDestroyFunc)
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x22DE6FC", Offset = "0x22DE6FC", VA = "0x22DE6FC")]
	private void SelfDestroy()
	{
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x22DEB30", Offset = "0x22DEB30", VA = "0x22DEB30")]
	public DelayedDestroyController()
	{
	}
}
[Token(Token = "0x20000EB")]
public class MaterialStates : MonoBehaviour
{
	[Token(Token = "0x40005FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material[] materials;

	[Token(Token = "0x40005FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int currentMaterialState;

	[Token(Token = "0x40005FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer meshRenderer;

	[Token(Token = "0x1700001E")]
	public int materialState
	{
		[Token(Token = "0x6000768")]
		[Address(RVA = "0xDA1270", Offset = "0xDA1270", VA = "0xDA1270")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0xDA1278", Offset = "0xDA1278", VA = "0xDA1278")]
	private void Start()
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0xDA12E8", Offset = "0xDA12E8", VA = "0xDA12E8")]
	public void UpdateState(int state)
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0xDA1428", Offset = "0xDA1428", VA = "0xDA1428")]
	public MaterialStates()
	{
	}
}
[Token(Token = "0x20000EC")]
public class TextureStates : MonoBehaviour
{
	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28428", Offset = "0xD28428")]
	private sealed class <ChangeTexture>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureStates <>4__this;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <step>5__2;

		[Token(Token = "0x1700003F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x105E3FC", Offset = "0x105E3FC", VA = "0x105E3FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x105E464", Offset = "0x105E464", VA = "0x105E464", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x105E2C4", Offset = "0x105E2C4", VA = "0x105E2C4")]
		[DebuggerHidden]
		public <ChangeTexture>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x105E300", Offset = "0x105E300", VA = "0x105E300", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x105E304", Offset = "0x105E304", VA = "0x105E304", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x105E404", Offset = "0x105E404", VA = "0x105E404", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D[] textures;

	[Token(Token = "0x40005FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int currentTextureState;

	[Token(Token = "0x40005FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Renderer meshRenderer;

	[Token(Token = "0x4000600")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Shader blendShader;

	[Token(Token = "0x4000601")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float blendSpeed;

	[Token(Token = "0x1700001F")]
	public int textureState
	{
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x105E0A0", Offset = "0x105E0A0", VA = "0x105E0A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x105E0A8", Offset = "0x105E0A8", VA = "0x105E0A8")]
	private void Start()
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x105E118", Offset = "0x105E118", VA = "0x105E118")]
	public void UpdateState(int state)
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x105E248", Offset = "0x105E248", VA = "0x105E248")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD2A1DC", Offset = "0xD2A1DC")]
	public IEnumerator ChangeTexture()
	{
		return null;
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x105E2F0", Offset = "0x105E2F0", VA = "0x105E2F0")]
	public TextureStates()
	{
	}
}
[Token(Token = "0x20000ED")]
public class TrashBin_Controller : MonoBehaviour
{
	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject objectToDestroy;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> boundObjects;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> boundObjectsStartPosition;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Quaternion> boundObjectsStartRotation;

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x105EF20", Offset = "0x105EF20", VA = "0x105EF20")]
	private void Start()
	{
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x105F0B4", Offset = "0x105F0B4", VA = "0x105F0B4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x105F0B8", Offset = "0x105F0B8", VA = "0x105F0B8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x105F1C8", Offset = "0x105F1C8", VA = "0x105F1C8")]
	private void DestroyObjects()
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0x105F4AC", Offset = "0x105F4AC", VA = "0x105F4AC")]
	public TrashBin_Controller()
	{
	}
}
[Token(Token = "0x20000EE")]
public class DestroyPopupPoint : MonoBehaviour
{
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x22DED38", Offset = "0x22DED38", VA = "0x22DED38")]
	public void DestoryPopup()
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x22DEDB4", Offset = "0x22DEDB4", VA = "0x22DEDB4")]
	public void DestroyObject()
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x22DEE40", Offset = "0x22DEE40", VA = "0x22DEE40")]
	public DestroyPopupPoint()
	{
	}
}
[Token(Token = "0x20000EF")]
public class DestroyHelper : MonoBehaviour
{
	[Token(Token = "0x6000779")]
	[Address(RVA = "0x22DECB4", Offset = "0x22DECB4", VA = "0x22DECB4")]
	public void DestoryPopup()
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x22DED30", Offset = "0x22DED30", VA = "0x22DED30")]
	public DestroyHelper()
	{
	}
}
[Token(Token = "0x20000F0")]
public class DrawerController : MonoBehaviour
{
	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int DrawerPosition;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29130", Offset = "0xD29130")]
	public float drawerPullOutLimit;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 startPostion;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Quaternion startRotation;

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x22DF000", Offset = "0x22DF000", VA = "0x22DF000")]
	private void Start()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x22DF1F0", Offset = "0x22DF1F0", VA = "0x22DF1F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x22DF1F4", Offset = "0x22DF1F4", VA = "0x22DF1F4")]
	private void checkPostionBounds()
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x22DF794", Offset = "0x22DF794", VA = "0x22DF794")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x22DF82C", Offset = "0x22DF82C", VA = "0x22DF82C")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x22DF8FC", Offset = "0x22DF8FC", VA = "0x22DF8FC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x22DFA54", Offset = "0x22DFA54", VA = "0x22DFA54")]
	public DrawerController()
	{
	}
}
[Token(Token = "0x20000F1")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD27F20", Offset = "0xD27F20")]
public class DynamicBoneController : MonoBehaviour
{
	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float customStiffness;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float startStiffness;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DynamicBone dynamicBone;

	[Token(Token = "0x6000782")]
	[Address(RVA = "0x22E089C", Offset = "0x22E089C", VA = "0x22E089C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x22E0994", Offset = "0x22E0994", VA = "0x22E0994")]
	public void SetCustomDynamicBone()
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0x22E0A58", Offset = "0x22E0A58", VA = "0x22E0A58")]
	public void ResetDynamicBone()
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0x22E0B1C", Offset = "0x22E0B1C", VA = "0x22E0B1C")]
	public DynamicBoneController()
	{
	}
}
[Token(Token = "0x20000F2")]
public class EntranceController : MonoBehaviour
{
	[Token(Token = "0x6000786")]
	[Address(RVA = "0x22E11F0", Offset = "0x22E11F0", VA = "0x22E11F0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x22E11F4", Offset = "0x22E11F4", VA = "0x22E11F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0x22E11F8", Offset = "0x22E11F8", VA = "0x22E11F8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0x22E12F0", Offset = "0x22E12F0", VA = "0x22E12F0")]
	public EntranceController()
	{
	}
}
[Token(Token = "0x20000F3")]
public class EventSystemConfig : MonoBehaviour
{
	[Token(Token = "0x600078A")]
	[Address(RVA = "0x22E19F4", Offset = "0x22E19F4", VA = "0x22E19F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600078B")]
	[Address(RVA = "0x22E1A78", Offset = "0x22E1A78", VA = "0x22E1A78")]
	public EventSystemConfig()
	{
	}
}
[Token(Token = "0x20000F4")]
public class FloatingController : MonoBehaviour
{
	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 offset;

	[Token(Token = "0x600078C")]
	[Address(RVA = "0x22E41E4", Offset = "0x22E41E4", VA = "0x22E41E4")]
	private void Update()
	{
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0x22E4358", Offset = "0x22E4358", VA = "0x22E4358")]
	public FloatingController()
	{
	}
}
[Token(Token = "0x20000F5")]
public class FridgeConroller : MonoBehaviour
{
	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftDoor;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightDoor;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float leftDoorPositionX;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float rightDoorPositionX;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool leftDoorOpen;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool rightDoorOpen;

	[Token(Token = "0x600078E")]
	[Address(RVA = "0x22E4370", Offset = "0x22E4370", VA = "0x22E4370")]
	private void Start()
	{
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0x22E43D0", Offset = "0x22E43D0", VA = "0x22E43D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0x22E4448", Offset = "0x22E4448", VA = "0x22E4448")]
	public FridgeConroller()
	{
	}
}
[Token(Token = "0x20000F6")]
public class GimbalObjectTracker : MonoBehaviour
{
	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ObjectToTrack;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Step;

	[Token(Token = "0x6000791")]
	[Address(RVA = "0x22E9074", Offset = "0x22E9074", VA = "0x22E9074")]
	private void Start()
	{
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0x22E910C", Offset = "0x22E910C", VA = "0x22E910C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0x22E933C", Offset = "0x22E933C", VA = "0x22E933C")]
	public void SwitchCameras()
	{
	}

	[Token(Token = "0x6000794")]
	[Address(RVA = "0x22E93F0", Offset = "0x22E93F0", VA = "0x22E93F0")]
	public GimbalObjectTracker()
	{
	}
}
[Token(Token = "0x20000F7")]
public class GrabFeedbackEffects : MonoBehaviour
{
	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource grabSound;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRTK_ControllerReference controllerReference;

	[Token(Token = "0x6000795")]
	[Address(RVA = "0x22E97B0", Offset = "0x22E97B0", VA = "0x22E97B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0x22E98C0", Offset = "0x22E98C0", VA = "0x22E98C0")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0x22E9A94", Offset = "0x22E9A94", VA = "0x22E9A94")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0x22E9988", Offset = "0x22E9988", VA = "0x22E9988")]
	public void PlayGrabEffects()
	{
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0x22E9A98", Offset = "0x22E9A98", VA = "0x22E9A98")]
	public GrabFeedbackEffects()
	{
	}
}
[Token(Token = "0x20000F8")]
public class HandTrackingGrabber : OVRGrabber
{
	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private OVRHand hand;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float pinchThreshold;

	[Token(Token = "0x600079A")]
	[Address(RVA = "0x22EBB00", Offset = "0x22EBB00", VA = "0x22EBB00", Slot = "5")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600079B")]
	[Address(RVA = "0x22EBB6C", Offset = "0x22EBB6C", VA = "0x22EBB6C", Slot = "6")]
	public override void Update()
	{
	}

	[Token(Token = "0x600079C")]
	[Address(RVA = "0x22EBB94", Offset = "0x22EBB94", VA = "0x22EBB94")]
	public void CheckIndexPinch()
	{
	}

	[Token(Token = "0x600079D")]
	[Address(RVA = "0x22EBCC0", Offset = "0x22EBCC0", VA = "0x22EBCC0", Slot = "9")]
	protected override void GrabEnd()
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0x22EBEA4", Offset = "0x22EBEA4", VA = "0x22EBEA4")]
	public HandTrackingGrabber()
	{
	}
}
[Token(Token = "0x20000F9")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xD27F84", Offset = "0xD27F84")]
public class HandTrackingRecorder : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001A3")]
	public class BoneMap
	{
		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OVRSkeleton.BoneId id;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform transform;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 rotationOffset;

		[Token(Token = "0x17000041")]
		public Quaternion RotationOffset
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x22EC57C", Offset = "0x22EC57C", VA = "0x22EC57C")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000042")]
		public Quaternion TrackedRotation
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x22ECA90", Offset = "0x22ECA90", VA = "0x22ECA90")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x22ECB78", Offset = "0x22ECB78", VA = "0x22ECB78")]
		public BoneMap()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20001A4")]
	public class BoneCollection : Dictionary<OVRSkeleton.BoneId, BoneMap>, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private List<OVRSkeleton.BoneId> serialisedKeys;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[HideInInspector]
		private List<BoneMap> serialisedValues;

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x22EC828", Offset = "0x22EC828", VA = "0x22EC828", Slot = "43")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x22EC91C", Offset = "0x22EC91C", VA = "0x22EC91C", Slot = "42")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x22EC768", Offset = "0x22EC768", VA = "0x22EC768")]
		public BoneCollection()
		{
		}
	}

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OVRSkeleton ovrSkeleton;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OVRHand ovrHand;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private BonePose[] _fingers;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BonePose _hand;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<BoneMap> boneMaps;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private BoneCollection _bonesCache;

	[Token(Token = "0x17000020")]
	public BonePose[] Fingers
	{
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x22EBEB8", Offset = "0x22EBEB8", VA = "0x22EBEB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000021")]
	public BonePose Hand
	{
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x22EBEC0", Offset = "0x22EBEC0", VA = "0x22EBEC0")]
		get
		{
			return default(BonePose);
		}
	}

	[Token(Token = "0x17000022")]
	public List<BoneMap> Bones
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x22EBECC", Offset = "0x22EBECC", VA = "0x22EBECC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000023")]
	private BoneCollection BonesCache
	{
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x22EBED4", Offset = "0x22EBED4", VA = "0x22EBED4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x22EC050", Offset = "0x22EC050", VA = "0x22EC050")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x22EC0BC", Offset = "0x22EC0BC", VA = "0x22EC0BC")]
	public void SetOVRSkeleton(OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x60007A5")]
	[Address(RVA = "0x22EC0C4", Offset = "0x22EC0C4", VA = "0x22EC0C4")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x60007A6")]
	[Address(RVA = "0x22EC31C", Offset = "0x22EC31C", VA = "0x22EC31C")]
	public void UpdatePose()
	{
	}

	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x22EC320", Offset = "0x22EC320", VA = "0x22EC320")]
	private void SetLivePose()
	{
	}

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x22EC604", Offset = "0x22EC604", VA = "0x22EC604")]
	private void SetRootPose(Pose rootPose)
	{
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x22EC0C8", Offset = "0x22EC0C8", VA = "0x22EC0C8")]
	protected void UpdateBones()
	{
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x22EC650", Offset = "0x22EC650", VA = "0x22EC650")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x22EC6DC", Offset = "0x22EC6DC", VA = "0x22EC6DC")]
	public void Deserialize(BinaryReader reader)
	{
	}

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x22EBF18", Offset = "0x22EBF18", VA = "0x22EBF18")]
	private BoneCollection CacheBones()
	{
		return null;
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x22EC820", Offset = "0x22EC820", VA = "0x22EC820")]
	public HandTrackingRecorder()
	{
	}
}
[Serializable]
[Token(Token = "0x20000FA")]
public struct BonePose
{
	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public OVRSkeleton.BoneId boneID;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Quaternion rotation;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector3 position;

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0xE0A420", Offset = "0xE0A420", VA = "0xE0A420")]
	public static BonePose? Lerp(BonePose from, BonePose to, float t)
	{
		return null;
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0xE0A5F4", Offset = "0xE0A5F4", VA = "0xE0A5F4")]
	public void Serialize(BinaryWriter writer)
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0xE0A6D8", Offset = "0xE0A6D8", VA = "0xE0A6D8")]
	public void Deserialize(BinaryReader reader)
	{
	}
}
[Token(Token = "0x20000FB")]
public static class PoseUtils
{
	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x22BFF5C", Offset = "0x22BFF5C", VA = "0x22BFF5C")]
	public static void SetPose(this Transform transform, Pose pose, Space space = Space.World)
	{
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x22BFFD4", Offset = "0x22BFFD4", VA = "0x22BFFD4")]
	public static Pose GetPose(this Transform transform, Space space = Space.World)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x22C0094", Offset = "0x22C0094", VA = "0x22C0094")]
	public static Pose Multiply(Pose a, Pose b)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x22C01F0", Offset = "0x22C01F0", VA = "0x22C01F0")]
	public static Pose Lerp(Pose a, Pose b, float t)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x22C034C", Offset = "0x22C034C", VA = "0x22C034C")]
	public static Pose Inverse(this Pose a)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x22C0450", Offset = "0x22C0450", VA = "0x22C0450")]
	public static Pose RelativeOffset(this Transform to, Transform from)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x22C06D0", Offset = "0x22C06D0", VA = "0x22C06D0")]
	public static Pose RelativeOffset(this Transform to, Pose from)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x22C0788", Offset = "0x22C0788", VA = "0x22C0788")]
	public static Pose RelativeOffset(Pose from, Pose to)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x22C0534", Offset = "0x22C0534", VA = "0x22C0534")]
	public static Pose RelativeOffset(Vector3 fromPosition, Quaternion fromRotation, Vector3 toPosition, Quaternion toRotation)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x22C07D8", Offset = "0x22C07D8", VA = "0x22C07D8")]
	public static Pose GlobalPose(this Transform reference, Pose offset)
	{
		return default(Pose);
	}

	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x22C0974", Offset = "0x22C0974", VA = "0x22C0974")]
	public static float Similitude(Pose from, Pose to, float maxDistance)
	{
		return default(float);
	}

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x22C0A88", Offset = "0x22C0A88", VA = "0x22C0A88")]
	public static float RotationDifference(Quaternion from, Quaternion to)
	{
		return default(float);
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x22C0C88", Offset = "0x22C0C88", VA = "0x22C0C88")]
	public static Pose MirrorPose(this Pose pose, Vector3 normal, Vector3 tangent)
	{
		return default(Pose);
	}
}
[Token(Token = "0x20000FC")]
public class HapticsController : MonoBehaviour
{
	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRTK_ControllerReference controllerReference;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnEnter;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEvent OnExit;

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x22ECB80", Offset = "0x22ECB80", VA = "0x22ECB80")]
	private void Start()
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x22ECB84", Offset = "0x22ECB84", VA = "0x22ECB84")]
	private void Update()
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x22ECB88", Offset = "0x22ECB88", VA = "0x22ECB88")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x22ECCF4", Offset = "0x22ECCF4", VA = "0x22ECCF4")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x22ECE14", Offset = "0x22ECE14", VA = "0x22ECE14")]
	public void HapticOn()
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x22ECF00", Offset = "0x22ECF00", VA = "0x22ECF00")]
	public void HapticOff()
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x22ECFE0", Offset = "0x22ECFE0", VA = "0x22ECFE0")]
	public HapticsController()
	{
	}
}
[Token(Token = "0x20000FD")]
public class HeightController : MonoBehaviourPun, IPunOwnershipCallbacks
{
	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isItemGrabbed;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject movableObject;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 offset;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float minHeight;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float maxHeight;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject[] dynamicalObjects;

	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool isOpponent;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool changeHeight;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool objectsLocked;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	private bool heightLoaded;

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x22ED898", Offset = "0x22ED898", VA = "0x22ED898")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x22ED900", Offset = "0x22ED900", VA = "0x22ED900")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x22ED968", Offset = "0x22ED968", VA = "0x22ED968")]
	private void Start()
	{
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x22EDDAC", Offset = "0x22EDDAC", VA = "0x22EDDAC")]
	public void SetStartHeight()
	{
	}

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x22EE318", Offset = "0x22EE318", VA = "0x22EE318")]
	private void Update()
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x22EE424", Offset = "0x22EE424", VA = "0x22EE424")]
	public void MoveObjects()
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x22EE784", Offset = "0x22EE784", VA = "0x22EE784")]
	[PunRPC]
	public void Lock()
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x22EE888", Offset = "0x22EE888", VA = "0x22EE888")]
	[PunRPC]
	public void Unlock()
	{
	}

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x22EE964", Offset = "0x22EE964", VA = "0x22EE964")]
	public void LockObjectsRPC(int dynamicObjID, bool enable)
	{
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x22EDD0C", Offset = "0x22EDD0C", VA = "0x22EDD0C")]
	public void RefreshHandleState()
	{
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x22EEA40", Offset = "0x22EEA40", VA = "0x22EEA40")]
	public void LockObjects(bool enable)
	{
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x22EECA4", Offset = "0x22EECA4", VA = "0x22EECA4")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x22EECB0", Offset = "0x22EECB0", VA = "0x22EECB0")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x22EED78", Offset = "0x22EED78", VA = "0x22EED78")]
	public void HandleHeight()
	{
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x22EEEB0", Offset = "0x22EEEB0", VA = "0x22EEEB0")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x22EEF98", Offset = "0x22EEF98", VA = "0x22EEF98", Slot = "4")]
	private void Photon.Pun.IPunOwnershipCallbacks.OnOwnershipRequest(PhotonView targetView, Player requestingPlayer)
	{
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x22EEF9C", Offset = "0x22EEF9C", VA = "0x22EEF9C", Slot = "5")]
	private void Photon.Pun.IPunOwnershipCallbacks.OnOwnershipTransfered(PhotonView targetView, Player previousOwner)
	{
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x22EF16C", Offset = "0x22EF16C", VA = "0x22EF16C")]
	public void DisableSmoothSync()
	{
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x22EF21C", Offset = "0x22EF21C", VA = "0x22EF21C")]
	public HeightController()
	{
	}
}
[Token(Token = "0x20000FE")]
public class HitDetect : MonoBehaviour
{
	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29198", Offset = "0xD29198")]
	public string hitObject;

	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnHitEvent;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isHit;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool isOnionHit;

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0xD97FC8", Offset = "0xD97FC8", VA = "0xD97FC8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0xD98194", Offset = "0xD98194", VA = "0xD98194")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0xD98234", Offset = "0xD98234", VA = "0xD98234")]
	private void OnCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0xD9830C", Offset = "0xD9830C", VA = "0xD9830C")]
	public void SetVignette()
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0xD98364", Offset = "0xD98364", VA = "0xD98364")]
	public void RemoveVignette()
	{
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0xD98368", Offset = "0xD98368", VA = "0xD98368")]
	public HitDetect()
	{
	}
}
[Token(Token = "0x20000FF")]
public static class JsonHelper
{
	[Serializable]
	[Token(Token = "0x20001A5")]
	private class Wrapper<T>
	{
		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] Items;

		[Token(Token = "0x60009F1")]
		public Wrapper()
		{
		}
	}

	[Token(Token = "0x60007DE")]
	public static T[] FromJson<T>(string json)
	{
		return null;
	}

	[Token(Token = "0x60007DF")]
	public static string ToJson<T>(T[] array)
	{
		return null;
	}

	[Token(Token = "0x60007E0")]
	public static string ToJson<T>(T[] array, bool prettyPrint)
	{
		return null;
	}
}
[Token(Token = "0x2000100")]
public class CSVReader : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28438", Offset = "0xD28438")]
	private sealed class <>c
	{
		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Match, string> <>9__4_0;

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xE11BB4", Offset = "0xE11BB4", VA = "0xE11BB4")]
		public <>c()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xE11BBC", Offset = "0xE11BBC", VA = "0xE11BBC")]
		internal string <SplitCsvLine>b__4_0(Match m)
		{
			return null;
		}
	}

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextAsset csvFile;

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0xE115C8", Offset = "0xE115C8", VA = "0xE115C8")]
	public void Start()
	{
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0xE118A0", Offset = "0xE118A0", VA = "0xE118A0")]
	public static void DebugOutputGrid(string[,] grid)
	{
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0xE115F0", Offset = "0xE115F0", VA = "0xE115F0")]
	public static string[,] SplitCsvGrid(string csvText)
	{
		return null;
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0xE119E8", Offset = "0xE119E8", VA = "0xE119E8")]
	public static string[] SplitCsvLine(string line)
	{
		return null;
	}

	[Token(Token = "0x60007E5")]
	[Address(RVA = "0xE11B44", Offset = "0xE11B44", VA = "0xE11B44")]
	public CSVReader()
	{
	}
}
[Token(Token = "0x2000101")]
public class LocalizationController : MonoBehaviour
{
	[Token(Token = "0x20001A7")]
	public enum LocalizationType
	{
		[Token(Token = "0x400088F")]
		TEXT,
		[Token(Token = "0x4000890")]
		AUDIO
	}

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LocalizationType type;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string key;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string suffix;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string suffixKey;

	[Token(Token = "0x60007E6")]
	[Address(RVA = "0xD9CEE0", Offset = "0xD9CEE0", VA = "0xD9CEE0")]
	private void Start()
	{
	}

	[Token(Token = "0x60007E7")]
	[Address(RVA = "0xD9D26C", Offset = "0xD9D26C", VA = "0xD9D26C")]
	private void Update()
	{
	}

	[Token(Token = "0x60007E8")]
	[Address(RVA = "0xD9CF48", Offset = "0xD9CF48", VA = "0xD9CF48")]
	public void SetText()
	{
	}

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0xD9D270", Offset = "0xD9D270", VA = "0xD9D270")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0xD9D3A4", Offset = "0xD9D3A4", VA = "0xD9D3A4")]
	public LocalizationController()
	{
	}
}
[Serializable]
[Token(Token = "0x2000102")]
public class LocalizationData
{
	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LocalizationItem[] items;

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0xD9D3AC", Offset = "0xD9D3AC", VA = "0xD9D3AC")]
	public LocalizationData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000103")]
public class LocalizationItem
{
	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string value;

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0xD9D634", Offset = "0xD9D634", VA = "0xD9D634")]
	public LocalizationItem()
	{
	}
}
[Token(Token = "0x2000104")]
public class LocalizationGroup : MonoBehaviour
{
	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool hasChanged;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<LocalizationController> localizationControllers;

	[Token(Token = "0x60007ED")]
	[Address(RVA = "0xD9D3B4", Offset = "0xD9D3B4", VA = "0xD9D3B4")]
	public void UpdateLocalization()
	{
	}

	[Token(Token = "0x60007EE")]
	[Address(RVA = "0xD9D3E0", Offset = "0xD9D3E0", VA = "0xD9D3E0")]
	public void RefreshTexts()
	{
	}

	[Token(Token = "0x60007EF")]
	[Address(RVA = "0xD9D474", Offset = "0xD9D474", VA = "0xD9D474")]
	public void AddToLocalizationObject(LocalizationController controller)
	{
	}

	[Token(Token = "0x60007F0")]
	[Address(RVA = "0xD9D4DC", Offset = "0xD9D4DC", VA = "0xD9D4DC")]
	public void RemoveFromLocalizationObject(LocalizationController controller)
	{
	}

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0xD9D544", Offset = "0xD9D544", VA = "0xD9D544")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0xD9D5B8", Offset = "0xD9D5B8", VA = "0xD9D5B8")]
	public LocalizationGroup()
	{
	}
}
[Token(Token = "0x2000105")]
internal struct LocalizationLoadingJob : IJob
{
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0xD9D63C", Offset = "0xD9D63C", VA = "0xD9D63C", Slot = "4")]
	public void Execute()
	{
	}
}
[Token(Token = "0x2000106")]
public class LocalizationManager : MonoBehaviour
{
	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static LocalizationManager instance;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<string, string> localizedText;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isReady;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string missingTextString;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<LocalizationController> localizationControllers;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<LocalizationGroup> localizationGroups;

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Language language;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextAsset csv;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string localizationRawText;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string[,] loadedData;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private JobHandle loadingJob;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isLoading;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool queueLoading;

	[Token(Token = "0x60007F4")]
	[Address(RVA = "0xD9D7E4", Offset = "0xD9D7E4", VA = "0xD9D7E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0xD9D9AC", Offset = "0xD9D9AC", VA = "0xD9D9AC")]
	public void Start()
	{
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0xD9DAA0", Offset = "0xD9DAA0", VA = "0xD9DAA0")]
	private void Update()
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0xD9D9B0", Offset = "0xD9D9B0", VA = "0xD9D9B0")]
	public void SetLocalization()
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0xD9D694", Offset = "0xD9D694", VA = "0xD9D694")]
	public void LoadLocalizedText()
	{
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0xD9DF2C", Offset = "0xD9DF2C", VA = "0xD9DF2C")]
	public void VerboseLocalization()
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0xD99934", Offset = "0xD99934", VA = "0xD99934")]
	public string GetLocalizedValue(string key)
	{
		return null;
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0xD9E0A8", Offset = "0xD9E0A8", VA = "0xD9E0A8")]
	public bool GetIsReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0xD9E0B0", Offset = "0xD9E0B0", VA = "0xD9E0B0")]
	public AudioClip GetLocalizedAudio(string key)
	{
		return null;
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0xD9AEFC", Offset = "0xD9AEFC", VA = "0xD9AEFC")]
	public void ChangeLanguage(Language newLanguage)
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0xD9DB4C", Offset = "0xD9DB4C", VA = "0xD9DB4C")]
	public void RefreshLanguageMenu()
	{
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0xD9DD78", Offset = "0xD9DD78", VA = "0xD9DD78")]
	public void RefreshTexts()
	{
	}

	[Token(Token = "0x6000800")]
	[Address(RVA = "0xD9D15C", Offset = "0xD9D15C", VA = "0xD9D15C")]
	public void AddToLocalizationObject(LocalizationController controller)
	{
	}

	[Token(Token = "0x6000801")]
	[Address(RVA = "0xD9D2D0", Offset = "0xD9D2D0", VA = "0xD9D2D0")]
	public void RemoveFromLocalizationObject(LocalizationController controller)
	{
	}

	[Token(Token = "0x6000802")]
	[Address(RVA = "0xD9E168", Offset = "0xD9E168", VA = "0xD9E168")]
	public LocalizationManager()
	{
	}
}
[Token(Token = "0x2000107")]
public class Logging : MonoBehaviour
{
	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Logging instance;

	[Token(Token = "0x6000803")]
	[Address(RVA = "0xD9E230", Offset = "0xD9E230", VA = "0xD9E230")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000804")]
	[Address(RVA = "0xD9E310", Offset = "0xD9E310", VA = "0xD9E310", Slot = "4")]
	public virtual void Log(int type, string tag, string message)
	{
	}

	[Token(Token = "0x6000805")]
	[Address(RVA = "0xD9E378", Offset = "0xD9E378", VA = "0xD9E378")]
	public Logging()
	{
	}
}
[Token(Token = "0x2000108")]
public class MonoBehaviourSingleton<T> : MonoBehaviour where T : Component
{
	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD291D0", Offset = "0xD291D0")]
	private static T <Instance>k__BackingField;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public UIViewCategoryName category;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string canvasName;

	[Token(Token = "0x400064F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GraphController graphController;

	[Token(Token = "0x4000650")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public GameObject parentHolder;

	[Token(Token = "0x4000651")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public UIButton backButton;

	[Token(Token = "0x17000024")]
	public static T Instance
	{
		[Token(Token = "0x6000806")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A2D0", Offset = "0xD2A2D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000807")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A2E0", Offset = "0xD2A2E0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000808")]
	public void GoBack()
	{
	}

	[Token(Token = "0x6000809")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600080A")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600080B")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x600080C")]
	public void ActivateMenuHolder()
	{
	}

	[Token(Token = "0x600080D")]
	public void DectivateMenuHolder()
	{
	}

	[Token(Token = "0x600080E")]
	public virtual void Show()
	{
	}

	[Token(Token = "0x600080F")]
	public virtual void Hide()
	{
	}

	[Token(Token = "0x6000810")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000811")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000812")]
	public MonoBehaviourSingleton()
	{
	}
}
[Token(Token = "0x2000109")]
public class MusicManager : MonoBehaviour
{
	[Token(Token = "0x4000652")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] musicClips;

	[Token(Token = "0x4000653")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource audioSource;

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int currentMusicClip;

	[Token(Token = "0x6000813")]
	[Address(RVA = "0x22A96D8", Offset = "0x22A96D8", VA = "0x22A96D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0x22A978C", Offset = "0x22A978C", VA = "0x22A978C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0x22A9790", Offset = "0x22A9790", VA = "0x22A9790")]
	public void PlayMusicInOrder()
	{
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0x22A9844", Offset = "0x22A9844", VA = "0x22A9844")]
	public MusicManager()
	{
	}
}
[Token(Token = "0x200010A")]
public class MusicPlayer : MonoBehaviour
{
	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource audioSource;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator anim;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject cassettePlace;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentMusic;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip[] clipNames;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool stop;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Slider musicLength;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject radioDoor;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool isOpen;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float openTimer;

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x22A984C", Offset = "0x22A984C", VA = "0x22A984C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000818")]
	[Address(RVA = "0x22A98F0", Offset = "0x22A98F0", VA = "0x22A98F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000819")]
	[Address(RVA = "0x22A99F0", Offset = "0x22A99F0", VA = "0x22A99F0")]
	public void StartAudio(int changeMusic = 0)
	{
	}

	[Token(Token = "0x600081A")]
	[Address(RVA = "0x22A9B60", Offset = "0x22A9B60", VA = "0x22A9B60")]
	public void StopAudio()
	{
	}

	[Token(Token = "0x600081B")]
	[Address(RVA = "0x22A9BF4", Offset = "0x22A9BF4", VA = "0x22A9BF4")]
	public void OpenRadioDoor()
	{
	}

	[Token(Token = "0x600081C")]
	[Address(RVA = "0x22A9CA8", Offset = "0x22A9CA8", VA = "0x22A9CA8")]
	public MusicPlayer()
	{
	}
}
[Token(Token = "0x200010B")]
public class ObjectCleaner : MonoBehaviourPun
{
	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ObjectCleaner instance;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> objectsList;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int numOfObjects;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string[] validTags;

	[Token(Token = "0x600081D")]
	[Address(RVA = "0x22ADF54", Offset = "0x22ADF54", VA = "0x22ADF54")]
	private void Awake()
	{
	}

	[Token(Token = "0x600081E")]
	[Address(RVA = "0x22AE034", Offset = "0x22AE034", VA = "0x22AE034")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600081F")]
	[Address(RVA = "0x22AE534", Offset = "0x22AE534", VA = "0x22AE534")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000820")]
	[Address(RVA = "0x22AE2BC", Offset = "0x22AE2BC", VA = "0x22AE2BC")]
	public void CleanUp()
	{
	}

	[Token(Token = "0x6000821")]
	[Address(RVA = "0x22AE938", Offset = "0x22AE938", VA = "0x22AE938")]
	[PunRPC]
	public void DestroyRPC(int photonViewId)
	{
	}

	[Token(Token = "0x6000822")]
	[Address(RVA = "0x22AEA30", Offset = "0x22AEA30", VA = "0x22AEA30")]
	public void RemoveObject(GameObject objectToDestroy)
	{
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0x22AEAC8", Offset = "0x22AEAC8", VA = "0x22AEAC8")]
	public ObjectCleaner()
	{
	}
}
[Token(Token = "0x200010C")]
public class ObjectFinder
{
	[Token(Token = "0x6000824")]
	public static T[] FindEvenInactiveComponents<T>(bool searchAllScenes = false) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000825")]
	private static IEnumerable<T> FindEvenInactiveComponentsInValidScenes<T>(bool searchAllScenes, bool stopOnMatch = false) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000826")]
	private static IEnumerable<T> FindEvenInactiveComponentsInScene<T>(Scene scene, bool stopOnMatch = false)
	{
		return null;
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0x22AEB44", Offset = "0x22AEB44", VA = "0x22AEB44")]
	public ObjectFinder()
	{
	}
}
[Token(Token = "0x200010D")]
public interface IPoolable
{
	[Token(Token = "0x6000828")]
	void Reset();
}
[Token(Token = "0x200010E")]
public class ObjectPool : MonoBehaviour, IPunPrefabPool
{
	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly Dictionary<string, GameObject> ResourceCache;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Dictionary<string, List<GameObject>> pooledObjectsDict;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int amountToPool;

	[Token(Token = "0x6000829")]
	[Address(RVA = "0x22AEB4C", Offset = "0x22AEB4C", VA = "0x22AEB4C")]
	public void PreloadObjects(GameObject[] objectsToLoad)
	{
	}

	[Token(Token = "0x600082A")]
	[Address(RVA = "0x22AED60", Offset = "0x22AED60", VA = "0x22AED60", Slot = "4")]
	public GameObject Instantiate(string prefabId, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0x22AF18C", Offset = "0x22AF18C", VA = "0x22AF18C", Slot = "5")]
	public void Destroy(GameObject gameObject)
	{
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0x22AEF30", Offset = "0x22AEF30", VA = "0x22AEF30")]
	private GameObject InstantiateFromResources(string prefabId, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600082D")]
	[Address(RVA = "0x22AF3A4", Offset = "0x22AF3A4", VA = "0x22AF3A4")]
	public ObjectPool()
	{
	}
}
[Token(Token = "0x200010F")]
public class ObjectTracker : MonoBehaviourPun
{
	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<GameObject> allObjects;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<string, List<GameObject>> objectsByType;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int maxTotalObjects;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static Dictionary<string, int> maxSameObjectsByTag;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static int maxSameObjects;

	[Token(Token = "0x600082E")]
	[Address(RVA = "0x22AF454", Offset = "0x22AF454", VA = "0x22AF454")]
	private void Start()
	{
	}

	[Token(Token = "0x600082F")]
	[Address(RVA = "0x22AF558", Offset = "0x22AF558", VA = "0x22AF558")]
	public static void Clean()
	{
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0x22AF7AC", Offset = "0x22AF7AC", VA = "0x22AF7AC")]
	public static void CleanByType(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000831")]
	[Address(RVA = "0x22AFAF4", Offset = "0x22AFAF4", VA = "0x22AFAF4")]
	public static bool CanBeDestroyed(GameObject objectToDestroy)
	{
		return default(bool);
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x22AE640", Offset = "0x22AE640", VA = "0x22AE640")]
	public static void RemoveObject(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x22AFC98", Offset = "0x22AFC98", VA = "0x22AFC98")]
	[PunRPC]
	public void DestroyRPC()
	{
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x22AFDB4", Offset = "0x22AFDB4", VA = "0x22AFDB4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x22AFE2C", Offset = "0x22AFE2C", VA = "0x22AFE2C")]
	public static void AddToList(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x22AFEBC", Offset = "0x22AFEBC", VA = "0x22AFEBC")]
	public ObjectTracker()
	{
	}
}
[Token(Token = "0x2000110")]
public class OffsetMode
{
	[Token(Token = "0x20001A8")]
	public struct OffsetModeParam
	{
		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float offsetValue;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numIngredientsToSkip;
	}

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly OffsetModeParam ConstantOffset;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly OffsetModeParam RamenOffset;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly OffsetModeParam NoOffset;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly OffsetModeParam SushiOffset;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly OffsetModeParam TacoOffset;

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x22B3B8C", Offset = "0x22B3B8C", VA = "0x22B3B8C")]
	public OffsetMode()
	{
	}
}
[Token(Token = "0x2000111")]
public class ParticleCollisionForwarder : MonoBehaviourPun
{
	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x600083A")]
	[Address(RVA = "0x22B4644", Offset = "0x22B4644", VA = "0x22B4644")]
	private void Start()
	{
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0x22B46B4", Offset = "0x22B46B4", VA = "0x22B46B4")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x22B4A10", Offset = "0x22B4A10", VA = "0x22B4A10")]
	public ParticleCollisionForwarder()
	{
	}
}
[Token(Token = "0x2000112")]
public class PlayerNameEditor : MonoBehaviour
{
	[Token(Token = "0x20001A9")]
	public delegate void OnPlayerNameChanged(string newPlayerName);

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI playerNameText;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_InputField playerNameEdit;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OnPlayerNameChanged onPlayerNameChanged;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool editMode;

	[Token(Token = "0x600083D")]
	[Address(RVA = "0x22BEF4C", Offset = "0x22BEF4C", VA = "0x22BEF4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600083E")]
	[Address(RVA = "0x22BF180", Offset = "0x22BF180", VA = "0x22BF180")]
	public string GetPlayerName()
	{
		return null;
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0x22BF0CC", Offset = "0x22BF0CC", VA = "0x22BF0CC")]
	public void SetPlayerName(string playerName)
	{
	}

	[Token(Token = "0x6000840")]
	[Address(RVA = "0x22BF538", Offset = "0x22BF538", VA = "0x22BF538")]
	public void ToggleEditMode()
	{
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0x22BF590", Offset = "0x22BF590", VA = "0x22BF590")]
	public void EnterEditMode()
	{
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0x22BF5EC", Offset = "0x22BF5EC", VA = "0x22BF5EC")]
	public void ExitEditMode()
	{
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0x22BF648", Offset = "0x22BF648", VA = "0x22BF648")]
	public PlayerNameEditor()
	{
	}
}
[Token(Token = "0x2000113")]
public static class PlayerPrefsWrapper
{
	[Token(Token = "0x4000675")]
	private const string String_Empty = "";

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool supportsAsyncSave;

	[Token(Token = "0x6000844")]
	[Address(RVA = "0x22BF694", Offset = "0x22BF694", VA = "0x22BF694")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0x22BF698", Offset = "0x22BF698", VA = "0x22BF698")]
	public static void SetString(string key, string value = "")
	{
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0x22BF710", Offset = "0x22BF710", VA = "0x22BF710")]
	public static string GetString(string key, string defaultValue = "")
	{
		return null;
	}

	[Token(Token = "0x6000847")]
	[Address(RVA = "0x22BF788", Offset = "0x22BF788", VA = "0x22BF788")]
	public static void SetInt(string key, int value = 0)
	{
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0x22BF800", Offset = "0x22BF800", VA = "0x22BF800")]
	public static int GetInt(string key, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0x22BF878", Offset = "0x22BF878", VA = "0x22BF878")]
	public static void SetFloat(string key, float value = 0f)
	{
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0x22BF8F0", Offset = "0x22BF8F0", VA = "0x22BF8F0")]
	public static float GetFloat(string key, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x600084B")]
	[Address(RVA = "0x22BF968", Offset = "0x22BF968", VA = "0x22BF968")]
	public static void Save()
	{
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0x22BF9C8", Offset = "0x22BF9C8", VA = "0x22BF9C8")]
	public static string GetSaveFilePath()
	{
		return null;
	}
}
[Token(Token = "0x2000114")]
public class PosterRandomizer : MonoBehaviour
{
	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] placeHolderPosters;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] posterMaterial;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material frameMaterial;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int lastMaterial;

	[Token(Token = "0x600084E")]
	[Address(RVA = "0x22C0EDC", Offset = "0x22C0EDC", VA = "0x22C0EDC")]
	private void Start()
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0x22C123C", Offset = "0x22C123C", VA = "0x22C123C")]
	public PosterRandomizer()
	{
	}
}
[Token(Token = "0x2000115")]
public class PrefabLauncher : MonoBehaviour
{
	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefabToSpawn;

	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Force;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 angularForce;

	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public KeyCode launchButton;

	[Token(Token = "0x6000850")]
	[Address(RVA = "0x22C1244", Offset = "0x22C1244", VA = "0x22C1244")]
	private void Start()
	{
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0x22C1248", Offset = "0x22C1248", VA = "0x22C1248")]
	private void Update()
	{
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0x22C1284", Offset = "0x22C1284", VA = "0x22C1284")]
	public void Launch()
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0x22C1470", Offset = "0x22C1470", VA = "0x22C1470")]
	public PrefabLauncher()
	{
	}
}
[Token(Token = "0x2000116")]
public class ProgressController : MonoBehaviour
{
	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material cutoutObject;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI text;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float cutoffStart;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float cutoffEnd;

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x22C1684", Offset = "0x22C1684", VA = "0x22C1684")]
	private void Start()
	{
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0x22C1688", Offset = "0x22C1688", VA = "0x22C1688")]
	private void Update()
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x22C168C", Offset = "0x22C168C", VA = "0x22C168C")]
	public void UpdateProgress(int progress)
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0x22C1764", Offset = "0x22C1764", VA = "0x22C1764")]
	public ProgressController()
	{
	}
}
[Token(Token = "0x2000117")]
public class RandomSequencePool
{
	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int[] indexes;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int nextItem;

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x22C2498", Offset = "0x22C2498", VA = "0x22C2498")]
	public void Init(int numItems)
	{
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x22C2558", Offset = "0x22C2558", VA = "0x22C2558")]
	private void Randomize()
	{
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0x22C2620", Offset = "0x22C2620", VA = "0x22C2620")]
	public int GetNext()
	{
		return default(int);
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0x22C2694", Offset = "0x22C2694", VA = "0x22C2694")]
	public RandomSequencePool()
	{
	}
}
[Token(Token = "0x2000118")]
public class ReturnToPlace : MonoBehaviour
{
	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool isDropped;

	[Token(Token = "0x600085C")]
	[Address(RVA = "0x22D1588", Offset = "0x22D1588", VA = "0x22D1588")]
	private void Start()
	{
	}

	[Token(Token = "0x600085D")]
	[Address(RVA = "0x22D158C", Offset = "0x22D158C", VA = "0x22D158C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0x22D1774", Offset = "0x22D1774", VA = "0x22D1774")]
	public ReturnToPlace()
	{
	}
}
[Token(Token = "0x2000119")]
public class ReturnableObject : MonoBehaviourPun
{
	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool shouldReturn;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool waitingForReturn;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float returnDelay;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isReturned;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float delayForReturn;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isItemGrabbed;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform returnPlace;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool triggerReturn;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float minDistance;

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x22D177C", Offset = "0x22D177C", VA = "0x22D177C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x22D188C", Offset = "0x22D188C", VA = "0x22D188C")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x22D18EC", Offset = "0x22D18EC", VA = "0x22D18EC")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x22D1A1C", Offset = "0x22D1A1C", VA = "0x22D1A1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0x22D1760", Offset = "0x22D1760", VA = "0x22D1760")]
	public void ShouldReturnToPlace(float delay)
	{
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0x22D1AF4", Offset = "0x22D1AF4", VA = "0x22D1AF4")]
	public void ReturnToPlace()
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x22D1B94", Offset = "0x22D1B94", VA = "0x22D1B94")]
	[PunRPC]
	public void ReturnToPlaceRPC()
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x22D1E0C", Offset = "0x22D1E0C", VA = "0x22D1E0C")]
	public ReturnableObject()
	{
	}
}
[Token(Token = "0x200011A")]
public class RotateTowards : MonoBehaviour
{
	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform currentTarget;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform start;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool isRotating;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float step;

	[Token(Token = "0x6000867")]
	[Address(RVA = "0x22D2DEC", Offset = "0x22D2DEC", VA = "0x22D2DEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0x22D2DFC", Offset = "0x22D2DFC", VA = "0x22D2DFC")]
	private void RotateToward()
	{
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0x22D3050", Offset = "0x22D3050", VA = "0x22D3050")]
	public void StartRotating(Transform target)
	{
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0x22D30A0", Offset = "0x22D30A0", VA = "0x22D30A0")]
	public RotateTowards()
	{
	}
}
[Token(Token = "0x200011B")]
public class ScreenFadeHelper : MonoBehaviour
{
	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRScreenFade camera;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool isCameraFind;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool isFadeIn;

	[Token(Token = "0x600086B")]
	[Address(RVA = "0x22D5E90", Offset = "0x22D5E90", VA = "0x22D5E90")]
	private void Update()
	{
	}

	[Token(Token = "0x600086C")]
	[Address(RVA = "0x22D60EC", Offset = "0x22D60EC", VA = "0x22D60EC")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600086D")]
	[Address(RVA = "0x22D6184", Offset = "0x22D6184", VA = "0x22D6184")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600086E")]
	[Address(RVA = "0x22D621C", Offset = "0x22D621C", VA = "0x22D621C")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x600086F")]
	[Address(RVA = "0x22D62C8", Offset = "0x22D62C8", VA = "0x22D62C8")]
	public void FadeIn()
	{
	}

	[Token(Token = "0x6000870")]
	[Address(RVA = "0x22D6374", Offset = "0x22D6374", VA = "0x22D6374")]
	public ScreenFadeHelper()
	{
	}
}
[Token(Token = "0x200011C")]
public class ScrollList : MonoBehaviour
{
	[Token(Token = "0x20001AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28448", Offset = "0xD28448")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<ulong> inviteFunction;

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x22F0CC4", Offset = "0x22F0CC4", VA = "0x22F0CC4")]
		public <>c__DisplayClass14_0()
		{
		}
	}

	[Token(Token = "0x20001AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28458", Offset = "0xD28458")]
	private sealed class <>c__DisplayClass14_1
	{
		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public KeyValuePair<ulong, string> friend;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public <>c__DisplayClass14_0 CS$<>8__locals1;

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x22F0CCC", Offset = "0x22F0CCC", VA = "0x22F0CCC")]
		public <>c__DisplayClass14_1()
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x22F0F78", Offset = "0x22F0F78", VA = "0x22F0F78")]
		internal void <AddItems>b__0(object <p0>, InteractableObjectEventArgs <p1>)
		{
		}
	}

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<ZoomHighlighter> items;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 startPosition;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 targetPosition;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int currentScrollIndex;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int MaxItems;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject scrollUp;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject scrollDown;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float itemHeight;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float offsetY;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float scrollSpeed;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject friendItemTemplate;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject friendListHolder;

	[Token(Token = "0x6000871")]
	[Address(RVA = "0x22F0224", Offset = "0x22F0224", VA = "0x22F0224")]
	private void Start()
	{
	}

	[Token(Token = "0x6000872")]
	[Address(RVA = "0x22F0228", Offset = "0x22F0228", VA = "0x22F0228")]
	private void Update()
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0x22F0620", Offset = "0x22F0620", VA = "0x22F0620")]
	public void AddItems(Dictionary<ulong, string> friends, Action<ulong> inviteFunction)
	{
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0x22F0E5C", Offset = "0x22F0E5C", VA = "0x22F0E5C")]
	public void ScrollDown()
	{
	}

	[Token(Token = "0x6000875")]
	[Address(RVA = "0x22F0ED4", Offset = "0x22F0ED4", VA = "0x22F0ED4")]
	public void ScrollUp()
	{
	}

	[Token(Token = "0x6000876")]
	[Address(RVA = "0x22F0CD4", Offset = "0x22F0CD4", VA = "0x22F0CD4")]
	private void RefreshState()
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0x22F0EEC", Offset = "0x22F0EEC", VA = "0x22F0EEC")]
	public ScrollList()
	{
	}
}
[Token(Token = "0x200011D")]
public class SelfDestroy : MonoBehaviourPun
{
	[Token(Token = "0x6000878")]
	[Address(RVA = "0x22F0FDC", Offset = "0x22F0FDC", VA = "0x22F0FDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000879")]
	[Address(RVA = "0x22F0FE0", Offset = "0x22F0FE0", VA = "0x22F0FE0")]
	public void SetDestroy(bool destroy)
	{
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0x22F1090", Offset = "0x22F1090", VA = "0x22F1090")]
	public void CleanUp()
	{
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0x22F121C", Offset = "0x22F121C", VA = "0x22F121C")]
	[PunRPC]
	public void DestroyObjectRPC(int photonViewId)
	{
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0x22F1314", Offset = "0x22F1314", VA = "0x22F1314")]
	public SelfDestroy()
	{
	}
}
[Token(Token = "0x200011E")]
internal struct SettingsSaveJob : IJob
{
	[Token(Token = "0x600087D")]
	[Address(RVA = "0x22F27A4", Offset = "0x22F27A4", VA = "0x22F27A4", Slot = "4")]
	public void Execute()
	{
	}
}
[Token(Token = "0x200011F")]
public class SettingsSaveWorker : MonoBehaviour
{
	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private JobHandle saveJob;

	[Token(Token = "0x600087E")]
	[Address(RVA = "0x22F280C", Offset = "0x22F280C", VA = "0x22F280C")]
	private void Update()
	{
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0x22F28B0", Offset = "0x22F28B0", VA = "0x22F28B0")]
	public SettingsSaveWorker()
	{
	}
}
[Token(Token = "0x2000120")]
public class SnapToPosition : MonoBehaviour
{
	[Token(Token = "0x40006A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject objectToSnap;

	[Token(Token = "0x40006A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform snappingPosition;

	[Token(Token = "0x40006A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string objectToSnapTag;

	[Token(Token = "0x40006A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isSnapped;

	[Token(Token = "0x40006A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject snappedObj;

	[Token(Token = "0x6000880")]
	[Address(RVA = "0x22F6B68", Offset = "0x22F6B68", VA = "0x22F6B68")]
	private void Start()
	{
	}

	[Token(Token = "0x6000881")]
	[Address(RVA = "0x22F6B6C", Offset = "0x22F6B6C", VA = "0x22F6B6C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000882")]
	[Address(RVA = "0x22F6B70", Offset = "0x22F6B70", VA = "0x22F6B70")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000883")]
	[Address(RVA = "0x22F706C", Offset = "0x22F706C", VA = "0x22F706C")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000884")]
	[Address(RVA = "0x22F7118", Offset = "0x22F7118", VA = "0x22F7118")]
	public SnapToPosition()
	{
	}
}
[Token(Token = "0x2000121")]
public class SpawnObjectHelper : MonoBehaviourPun
{
	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject prefabToSpawn;

	[Token(Token = "0x6000885")]
	[Address(RVA = "0x22FAC70", Offset = "0x22FAC70", VA = "0x22FAC70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0x22FAE0C", Offset = "0x22FAE0C", VA = "0x22FAE0C")]
	public SpawnObjectHelper()
	{
	}
}
[Token(Token = "0x2000122")]
public class SpawnerController : MonoBehaviour
{
	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AvatarGroup waiterAvatar;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] activeMenus;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool menuActive;

	[Token(Token = "0x6000887")]
	[Address(RVA = "0x22FCD04", Offset = "0x22FCD04", VA = "0x22FCD04")]
	private void Start()
	{
	}

	[Token(Token = "0x6000888")]
	[Address(RVA = "0x22FCF34", Offset = "0x22FCF34", VA = "0x22FCF34")]
	public void OnStartMultiplayerEvent()
	{
	}

	[Token(Token = "0x6000889")]
	[Address(RVA = "0x22FCFAC", Offset = "0x22FCFAC", VA = "0x22FCFAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0x22FD024", Offset = "0x22FD024", VA = "0x22FD024", Slot = "4")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0x22FCEC4", Offset = "0x22FCEC4", VA = "0x22FCEC4")]
	public void CloseActiveMenus()
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0x22FD09C", Offset = "0x22FD09C", VA = "0x22FD09C")]
	public SpawnerController()
	{
	}
}
[Token(Token = "0x2000123")]
public class SpectatorCameraController : MonoBehaviour
{
	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x600088D")]
	[Address(RVA = "0x22FD0A4", Offset = "0x22FD0A4", VA = "0x22FD0A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x22FD0A8", Offset = "0x22FD0A8", VA = "0x22FD0A8")]
	private void Update()
	{
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x22FD5D0", Offset = "0x22FD5D0", VA = "0x22FD5D0")]
	public SpectatorCameraController()
	{
	}
}
[Token(Token = "0x2000124")]
public class SqueezeController : MonoBehaviourPun
{
	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD291E0", Offset = "0xD291E0")]
	public float MinSqueezeTreshold;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29218", Offset = "0xD29218")]
	public float MaxSqueezeTreshold;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29250", Offset = "0xD29250")]
	public float DelayAfterGrab;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29288", Offset = "0xD29288")]
	public float DelayAfterSqueeze;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD292C0", Offset = "0xD292C0")]
	public float MaxTime;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD292F8", Offset = "0xD292F8")]
	public float SamplesPerSecond;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool sampling;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int FramesToSkip;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int SkippedFrames;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] GrabSamples;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int FirstSample;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int SampleIndex;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float MinGrabValue;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private int MinGrabIndex;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OculusHandTrackingGrab handGrab;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD29330", Offset = "0xD29330")]
	public UnityEvent OnSqueeze;

	[Token(Token = "0x6000890")]
	[Address(RVA = "0x22FF918", Offset = "0x22FF918", VA = "0x22FF918")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0x22FFAF4", Offset = "0x22FFAF4", VA = "0x22FFAF4")]
	private void IsItemGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x22FFBD0", Offset = "0x22FFBD0", VA = "0x22FFBD0")]
	private void ItemNotGrabbed(object sender, InteractableObjectEventArgs e)
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x22FFBE4", Offset = "0x22FFBE4", VA = "0x22FFBE4")]
	public void StartSampling()
	{
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x22FFBDC", Offset = "0x22FFBDC", VA = "0x22FFBDC")]
	public void StopSampling()
	{
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0x22FFA18", Offset = "0x22FFA18", VA = "0x22FFA18")]
	private void CalculateSamplingData()
	{
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0x22FFC48", Offset = "0x22FFC48", VA = "0x22FFC48")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000897")]
	[Address(RVA = "0x22FFD44", Offset = "0x22FFD44", VA = "0x22FFD44")]
	private void CheckSqueeze()
	{
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0x22FFE40", Offset = "0x22FFE40", VA = "0x22FFE40")]
	private void DoSqueeze()
	{
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0x22FFEE8", Offset = "0x22FFEE8", VA = "0x22FFEE8")]
	[PunRPC]
	private void DoSqueezeRPC()
	{
	}

	[Token(Token = "0x600089A")]
	[Address(RVA = "0x22FFF04", Offset = "0x22FFF04", VA = "0x22FFF04")]
	public SqueezeController()
	{
	}
}
[Token(Token = "0x2000125")]
public class StartEvents : MonoBehaviour
{
	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent OnStart;

	[Token(Token = "0x600089B")]
	[Address(RVA = "0x2302374", Offset = "0x2302374", VA = "0x2302374")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600089C")]
	[Address(RVA = "0x2302390", Offset = "0x2302390", VA = "0x2302390")]
	public StartEvents()
	{
	}
}
[Token(Token = "0x2000126")]
public class ComplexTextureChanger : TextureChanger
{
	[Token(Token = "0x20001AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28468", Offset = "0xD28468")]
	private sealed class <DoChangeTexture>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ComplexTextureChanger <>4__this;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <step>5__2;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0xE16250", Offset = "0xE16250", VA = "0xE16250", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0xE162B8", Offset = "0xE162B8", VA = "0xE162B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xE15DE0", Offset = "0xE15DE0", VA = "0xE15DE0")]
		[DebuggerHidden]
		public <DoChangeTexture>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xE16154", Offset = "0xE16154", VA = "0xE16154", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xE16158", Offset = "0xE16158", VA = "0xE16158", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xE16258", Offset = "0xE16258", VA = "0xE16258", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20001AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28478", Offset = "0xD28478")]
	private sealed class <DoChangeDecal>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ComplexTextureChanger <>4__this;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <step>5__2;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0xE160E4", Offset = "0xE160E4", VA = "0xE160E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xE1614C", Offset = "0xE1614C", VA = "0xE1614C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xE15F70", Offset = "0xE15F70", VA = "0xE15F70")]
		[DebuggerHidden]
		public <DoChangeDecal>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xE15FAC", Offset = "0xE15FAC", VA = "0xE15FAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xE15FB0", Offset = "0xE15FB0", VA = "0xE15FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0xE160EC", Offset = "0xE160EC", VA = "0xE160EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer meshRenderer;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeSpeed;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Texture oldTexture;

	[Token(Token = "0x600089D")]
	[Address(RVA = "0xE1592C", Offset = "0xE1592C", VA = "0xE1592C")]
	private void Start()
	{
	}

	[Token(Token = "0x600089E")]
	[Address(RVA = "0xE15B38", Offset = "0xE15B38", VA = "0xE15B38", Slot = "4")]
	public override void ChangeTexture(Texture texture)
	{
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0xE15CB4", Offset = "0xE15CB4", VA = "0xE15CB4", Slot = "5")]
	public override void RevertTexture()
	{
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0xE15D64", Offset = "0xE15D64", VA = "0xE15D64")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD2A340", Offset = "0xD2A340")]
	private IEnumerator DoChangeTexture()
	{
		return null;
	}

	[Token(Token = "0x60008A1")]
	[Address(RVA = "0xE15E0C", Offset = "0xE15E0C", VA = "0xE15E0C")]
	public void ChangeDecal(Texture texture)
	{
	}

	[Token(Token = "0x60008A2")]
	[Address(RVA = "0xE15EF4", Offset = "0xE15EF4", VA = "0xE15EF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD2A3A4", Offset = "0xD2A3A4")]
	private IEnumerator DoChangeDecal()
	{
		return null;
	}

	[Token(Token = "0x60008A3")]
	[Address(RVA = "0xE15F9C", Offset = "0xE15F9C", VA = "0xE15F9C")]
	public ComplexTextureChanger()
	{
	}
}
[Token(Token = "0x2000127")]
public class SimpleTextureChanger : TextureChanger
{
	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer meshRenderer;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Texture oldTexture;

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x22F36B0", Offset = "0x22F36B0", VA = "0x22F36B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x22F388C", Offset = "0x22F388C", VA = "0x22F388C", Slot = "4")]
	public override void ChangeTexture(Texture texture)
	{
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x22F396C", Offset = "0x22F396C", VA = "0x22F396C", Slot = "5")]
	public override void RevertTexture()
	{
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x22F3A1C", Offset = "0x22F3A1C", VA = "0x22F3A1C")]
	public SimpleTextureChanger()
	{
	}
}
[Token(Token = "0x2000128")]
public abstract class TextureChanger : MonoBehaviour
{
	[Token(Token = "0x60008A8")]
	public abstract void ChangeTexture(Texture texture);

	[Token(Token = "0x60008A9")]
	public abstract void RevertTexture();

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x105E098", Offset = "0x105E098", VA = "0x105E098")]
	protected TextureChanger()
	{
	}
}
[Token(Token = "0x2000129")]
public class TrashDestoyer : MonoBehaviourPun
{
	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> objectsToDestroy;

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x105F4B4", Offset = "0x105F4B4", VA = "0x105F4B4")]
	public void OnTriggerEnter(Collider collision)
	{
	}

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x105F834", Offset = "0x105F834", VA = "0x105F834")]
	public void OnTriggerExit(Collider collision)
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x105FB20", Offset = "0x105FB20", VA = "0x105FB20")]
	[PunRPC]
	public void RemoveSelfDestroyRPC(int photonViewId)
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x105FBD4", Offset = "0x105FBD4", VA = "0x105FBD4")]
	[PunRPC]
	public void AddSelfDestroyRPC(int photonViewId)
	{
	}

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x105FD08", Offset = "0x105FD08", VA = "0x105FD08")]
	public TrashDestoyer()
	{
	}
}
[Token(Token = "0x200012A")]
public class TrashDestroyManager : MonoBehaviour
{
	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] trashBins;

	[Token(Token = "0x40006CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static TrashDestroyManager instance;

	[Token(Token = "0x40006CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] validTags;

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x105FD84", Offset = "0x105FD84", VA = "0x105FD84")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x105FE64", Offset = "0x105FE64", VA = "0x105FE64")]
	public void RemoveObject(GameObject objectToDestroy)
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x1060054", Offset = "0x1060054", VA = "0x1060054")]
	public TrashDestroyManager()
	{
	}
}
[Token(Token = "0x200012B")]
public class TriggerController : MonoBehaviour
{
	[Token(Token = "0x40006D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent OnEnter;

	[Token(Token = "0x40006D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnExit;

	[Token(Token = "0x40006D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string TriggerTag;

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject TriggerObject;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioSource soundEfect;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool firstTime;

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x1060388", Offset = "0x1060388", VA = "0x1060388")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x106038C", Offset = "0x106038C", VA = "0x106038C")]
	private void Update()
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x1060390", Offset = "0x1060390", VA = "0x1060390")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0x1060504", Offset = "0x1060504", VA = "0x1060504")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x106061C", Offset = "0x106061C", VA = "0x106061C")]
	public TriggerController()
	{
	}
}
[Token(Token = "0x200012C")]
public class UIButtonGroup : MonoBehaviour
{
	[Token(Token = "0x40006D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIButtonToggle[] buttons;

	[Token(Token = "0x40006D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int selected;

	[Token(Token = "0x40006D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float clickDelay;

	[Token(Token = "0x40006D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float timeFromClick;

	[Token(Token = "0x40006DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool isClicked;

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0x10636AC", Offset = "0x10636AC", VA = "0x10636AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x10636FC", Offset = "0x10636FC", VA = "0x10636FC")]
	public void ShowButtons()
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x1061160", Offset = "0x1061160", VA = "0x1061160")]
	public void Select(UIButtonToggle button)
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x1063764", Offset = "0x1063764", VA = "0x1063764")]
	public void SelectWithDelay(UIButtonToggle button)
	{
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x1063878", Offset = "0x1063878", VA = "0x1063878")]
	public UIButtonGroup()
	{
	}
}
[Token(Token = "0x200012D")]
public class UIButtonToggle : MonoBehaviour
{
	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject on;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject off;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject locked;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isOn;

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x1063888", Offset = "0x1063888", VA = "0x1063888")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x1063A80", Offset = "0x1063A80", VA = "0x1063A80")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x1063700", Offset = "0x1063700", VA = "0x1063700")]
	public void Set(bool enable, bool forced = false)
	{
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x1063968", Offset = "0x1063968", VA = "0x1063968")]
	private void SetVisibility(GameObject obj, bool visible)
	{
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x1063A94", Offset = "0x1063A94", VA = "0x1063A94")]
	public void Lock(bool isLocked)
	{
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x1063B44", Offset = "0x1063B44", VA = "0x1063B44")]
	public UIButtonToggle()
	{
	}
}
[Token(Token = "0x200012E")]
[ExecuteInEditMode]
public class UniqueID : MonoBehaviour
{
	[Token(Token = "0x40006DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<string, UniqueID> allGuids;

	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string uniqueId;

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x1063B4C", Offset = "0x1063B4C", VA = "0x1063B4C")]
	public static void InitializeUniqueIds()
	{
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x1063C70", Offset = "0x1063C70", VA = "0x1063C70")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x1063C74", Offset = "0x1063C74", VA = "0x1063C74")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x1063CF8", Offset = "0x1063CF8", VA = "0x1063CF8")]
	public UniqueID()
	{
	}
}
[Token(Token = "0x200012F")]
public class Util
{
	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x1063D78", Offset = "0x1063D78", VA = "0x1063D78")]
	public static Vector3 StringToVector3(string vectorString)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x1063F50", Offset = "0x1063F50", VA = "0x1063F50")]
	public static Quaternion StringToQuaternion(string vectorString)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60008CA")]
	public static T[] Shuffle<T>(T[] array)
	{
		return null;
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x106415C", Offset = "0x106415C", VA = "0x106415C")]
	public static string Vector3ToString(Vector3 vector)
	{
		return null;
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x1064390", Offset = "0x1064390", VA = "0x1064390")]
	public static string QuaternionToString(Quaternion quatern)
	{
		return null;
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x106465C", Offset = "0x106465C", VA = "0x106465C")]
	public static int BoolArrayToInt(bool[] array)
	{
		return default(int);
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x10646D8", Offset = "0x10646D8", VA = "0x10646D8")]
	public static bool[] IntToBoolArray(int value, int arraySize)
	{
		return null;
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x1064784", Offset = "0x1064784", VA = "0x1064784")]
	public Util()
	{
	}
}
[Token(Token = "0x2000130")]
public class VRTKSpawner : MonoBehaviour
{
	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefabToInstantiate;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static GameObject vrtk;

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x106478C", Offset = "0x106478C", VA = "0x106478C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x106490C", Offset = "0x106490C", VA = "0x106490C")]
	public VRTKSpawner()
	{
	}
}
[Token(Token = "0x2000131")]
public class ViewTrackingController : MonoBehaviour
{
	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float trackSpeed;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float viewAngle;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float deadZone;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject trackedObject;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 targetPosition;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 trackedPosition;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool moving;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float distanceToTarget;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool calculateDistance;

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x1064914", Offset = "0x1064914", VA = "0x1064914")]
	private void Start()
	{
	}

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x1064CE0", Offset = "0x1064CE0", VA = "0x1064CE0")]
	private void Update()
	{
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x1065458", Offset = "0x1065458", VA = "0x1065458")]
	private void StartMoving()
	{
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x1065518", Offset = "0x1065518", VA = "0x1065518")]
	private void CalculateTargetPosition()
	{
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x10656DC", Offset = "0x10656DC", VA = "0x10656DC")]
	public ViewTrackingController()
	{
	}
}
[Token(Token = "0x2000132")]
public class ZoomHighlighter : VRTK_BaseHighlighter
{
	[Token(Token = "0x20001AE")]
	public enum STATE
	{
		[Token(Token = "0x400089F")]
		NONE,
		[Token(Token = "0x40008A0")]
		IN,
		[Token(Token = "0x40008A1")]
		OUT,
		[Token(Token = "0x40008A2")]
		ZOOMED
	}

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scaleFactor;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float offset;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float transitionSpeed;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 startScale;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 startPosition;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector3 targetScale;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 targetPosition;

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float transitionFactor;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioSource zoomIn;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private STATE state;

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x106B7E8", Offset = "0x106B7E8", VA = "0x106B7E8")]
	public STATE GetState()
	{
		return default(STATE);
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x106B7F0", Offset = "0x106B7F0", VA = "0x106B7F0", Slot = "4")]
	public override void Initialise([Optional] Color? color, [Optional] GameObject affectObject, [Optional] Dictionary<string, object> options)
	{
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x106B7F4", Offset = "0x106B7F4", VA = "0x106B7F4", Slot = "5")]
	public override void ResetHighlighter()
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x106B7F8", Offset = "0x106B7F8", VA = "0x106B7F8")]
	public void Start()
	{
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x106B978", Offset = "0x106B978", VA = "0x106B978", Slot = "6")]
	public override void Highlight([Optional] Color? color, float duration = 0f)
	{
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x106BA28", Offset = "0x106BA28", VA = "0x106BA28", Slot = "7")]
	public override void Unhighlight([Optional] Color? color, float duration = 0f)
	{
	}

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x106BA34", Offset = "0x106BA34", VA = "0x106BA34")]
	public void Update()
	{
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x106BBF4", Offset = "0x106BBF4", VA = "0x106BBF4")]
	public ZoomHighlighter()
	{
	}
}
[Token(Token = "0x2000133")]
public class SDK_OculusControllerSetup : MonoBehaviour
{
	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject controller;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ControllerSetup controllerSetup;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject oculusOrigin;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject oculusOriginHand;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject steamCollider;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public OVRHand handController;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private VRTK_Pointer pointer;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private VRTK_UIPointer uiPointer;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool grabbedWithHand;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool wasTrackingLost;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	private bool isLowConfidenceTracking;

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x22D326C", Offset = "0x22D326C", VA = "0x22D326C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x22D332C", Offset = "0x22D332C", VA = "0x22D332C")]
	private void Start()
	{
	}

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x22D34D0", Offset = "0x22D34D0", VA = "0x22D34D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x22D33A0", Offset = "0x22D33A0", VA = "0x22D33A0")]
	private void SetupOculus()
	{
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x22D3C4C", Offset = "0x22D3C4C", VA = "0x22D3C4C")]
	private void ActivateLowConfidenceTracking(bool activate)
	{
	}

	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x22D3E10", Offset = "0x22D3E10", VA = "0x22D3E10")]
	private void PauseTracking(bool pause)
	{
	}

	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x22D3F88", Offset = "0x22D3F88", VA = "0x22D3F88")]
	public SDK_OculusControllerSetup()
	{
	}
}
[Token(Token = "0x2000134")]
public class SDK_PicoControllerSetup : MonoBehaviour
{
	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject pointerOrigin;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isRightController;

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x22D3F90", Offset = "0x22D3F90", VA = "0x22D3F90")]
	private void Start()
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x22D42B4", Offset = "0x22D42B4", VA = "0x22D42B4")]
	public SDK_PicoControllerSetup()
	{
	}
}
[Token(Token = "0x2000135")]
public class SDK_UnityControllerSetup : MonoBehaviour
{
	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isRightController;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject pointerOrigin;

	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x22D42BC", Offset = "0x22D42BC", VA = "0x22D42BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x22D4484", Offset = "0x22D4484", VA = "0x22D4484")]
	public SDK_UnityControllerSetup()
	{
	}
}
