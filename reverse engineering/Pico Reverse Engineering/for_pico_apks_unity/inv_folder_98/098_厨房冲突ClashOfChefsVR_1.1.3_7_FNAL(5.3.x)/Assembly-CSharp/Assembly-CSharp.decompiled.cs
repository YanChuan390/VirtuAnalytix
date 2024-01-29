using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Photon.Chat;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.PUN;
using Photon.Voice.Unity;
using Photon.Voice.Unity.UtilityScripts;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using VRTK;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class DebugHidingController : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] objectsToHide;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	private bool activeMode;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x24")]
	public int selectedIndex;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	public GameObject debugTextPrefab;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	private GameObject debugText;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	private bool leftPressed;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x39")]
	private bool rightPressed;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xDB4B4C", Offset = "0xDB4B4C", VA = "0xDB4B4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDB4C20", Offset = "0xDB4C20", VA = "0xDB4C20")]
	private void AxisChanged(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xDB4CE0", Offset = "0xDB4CE0", VA = "0xDB4CE0")]
	private void ChangeSelectedIndex(int step)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xDB4D28", Offset = "0xDB4D28", VA = "0xDB4D28")]
	private void UpdateSelectedText()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xDB4FA4", Offset = "0xDB4FA4", VA = "0xDB4FA4")]
	private void DoGripPressed(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDB5018", Offset = "0xDB5018", VA = "0xDB5018")]
	private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDB5098", Offset = "0xDB5098", VA = "0xDB5098")]
	private void DoButtonOnePress(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDB50C8", Offset = "0xDB50C8", VA = "0xDB50C8")]
	public void ToggleMode(ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xDB4FA8", Offset = "0xDB4FA8", VA = "0xDB4FA8")]
	private void UnhideAll()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDB501C", Offset = "0xDB501C", VA = "0xDB501C")]
	private void ToggleSelected()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDB5438", Offset = "0xDB5438", VA = "0xDB5438")]
	public DebugHidingController()
	{
	}
}
[Token(Token = "0x2000003")]
public static class AppSettingsExtensions
{
	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDB0D40", Offset = "0xDB0D40", VA = "0xDB0D40")]
	public static ChatAppSettings GetChatSettings(this AppSettings appSettings)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public class ChannelSelector : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x18")]
	public string Channel;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDB1144", Offset = "0xDB1144", VA = "0xDB1144")]
	public void SetChannel(string channel)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDB11D0", Offset = "0xDB11D0", VA = "0xDB11D0", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDB147C", Offset = "0xDB147C", VA = "0xDB147C")]
	public ChannelSelector()
	{
	}
}
[Token(Token = "0x2000005")]
[ExecuteInEditMode]
public class ChatAppIdCheckerUI : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x18")]
	public Text Description;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xDB1484", Offset = "0xDB1484", VA = "0xDB1484")]
	public void Update()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xDB15C8", Offset = "0xDB15C8", VA = "0xDB15C8")]
	public ChatAppIdCheckerUI()
	{
	}
}
[Token(Token = "0x2000006")]
public class ChatGui : MonoBehaviour, IChatClientListener
{
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x18")]
	public string[] ChannelsToJoinOnConnect;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x20")]
	public string[] FriendsList;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x28")]
	public int HistoryLengthToFetch;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35910", Offset = "0xD35910")]
	private string <UserName>k__BackingField;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x38")]
	private string selectedChannelName;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x40")]
	public ChatClient chatClient;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x48")]
	protected internal ChatAppSettings chatAppSettings;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x50")]
	public GameObject missingAppIdErrorPanel;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ConnectingLabel;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x60")]
	public RectTransform ChatPanel;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x68")]
	public GameObject UserIdFormPanel;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x70")]
	public InputField InputFieldChat;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x78")]
	public Text CurrentChannelText;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x80")]
	public Toggle ChannelToggleToInstantiate;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x88")]
	public GameObject FriendListUiItemtoInstantiate;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x90")]
	private readonly Dictionary<string, Toggle> channelToggles;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x98")]
	private readonly Dictionary<string, FriendItem> friendListItemLUT;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0xA0")]
	public bool ShowState;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject Title;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0xB0")]
	public Text StateText;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xB8")]
	public Text UserIdText;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x0")]
	private static string HelpText;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0xC0")]
	public int TestLength;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0xC8")]
	private byte[] testBytes;

	[Token(Token = "0x17000001")]
	public string UserName
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0xDB1B3C", Offset = "0xDB1B3C", VA = "0xDB1B3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3605C", Offset = "0xD3605C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000013")]
		[Address(RVA = "0xDB1B44", Offset = "0xDB1B44", VA = "0xDB1B44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3606C", Offset = "0xD3606C")]
		set
		{
		}
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xDB1B4C", Offset = "0xDB1B4C", VA = "0xDB1B4C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xDB1DFC", Offset = "0xDB1DFC", VA = "0xDB1DFC")]
	public void Connect()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xDB1F84", Offset = "0xDB1F84", VA = "0xDB1F84")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xDB1F9C", Offset = "0xDB1F9C", VA = "0xDB1F9C")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xDB1FB4", Offset = "0xDB1FB4", VA = "0xDB1FB4")]
	public void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xDB20A8", Offset = "0xDB20A8", VA = "0xDB20A8")]
	public void OnEnterSend()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xDB2A1C", Offset = "0xDB2A1C", VA = "0xDB2A1C")]
	public void OnClickSend()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDB2144", Offset = "0xDB2144", VA = "0xDB2144")]
	private void SendChatMessage(string inputLine)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDB2AD0", Offset = "0xDB2AD0", VA = "0xDB2AD0")]
	public void PostHelpToCurrentChannel()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xDB2B8C", Offset = "0xDB2B8C", VA = "0xDB2B8C", Slot = "4")]
	public void DebugReturn(DebugLevel level, string message)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xDB2C74", Offset = "0xDB2C74", VA = "0xDB2C74", Slot = "6")]
	public void OnConnected()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xDB2FC0", Offset = "0xDB2FC0", VA = "0xDB2FC0", Slot = "5")]
	public void OnDisconnected()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDB2FE0", Offset = "0xDB2FE0", VA = "0xDB2FE0", Slot = "7")]
	public void OnChatStateChange(ChatState state)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDB308C", Offset = "0xDB308C", VA = "0xDB308C", Slot = "10")]
	public void OnSubscribed(string[] channels, bool[] results)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDB339C", Offset = "0xDB339C", VA = "0xDB339C")]
	public void OnSubscribed(string channel, string[] users, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDB3210", Offset = "0xDB3210", VA = "0xDB3210")]
	private void InstantiateChannelButton(string channelName)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDB2E7C", Offset = "0xDB2E7C", VA = "0xDB2E7C")]
	private void InstantiateFriendButton(string friendId)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xDB3574", Offset = "0xDB3574", VA = "0xDB3574", Slot = "11")]
	public void OnUnsubscribed(string[] channels)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xDB3944", Offset = "0xDB3944", VA = "0xDB3944", Slot = "8")]
	public void OnGetMessages(string channelName, string[] senders, object[] messages)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xDB3994", Offset = "0xDB3994", VA = "0xDB3994", Slot = "9")]
	public void OnPrivateMessage(string sender, object message, string channelName)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xDB3AA4", Offset = "0xDB3AA4", VA = "0xDB3AA4", Slot = "12")]
	public void OnStatusUpdate(string user, int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xDB3D54", Offset = "0xDB3D54", VA = "0xDB3D54", Slot = "13")]
	public void OnUserSubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xDB3E70", Offset = "0xDB3E70", VA = "0xDB3E70", Slot = "14")]
	public void OnUserUnsubscribed(string channel, string user)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xDB3F8C", Offset = "0xDB3F8C", VA = "0xDB3F8C")]
	public void OnChannelPropertiesChanged(string channel, string userId, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xDB4110", Offset = "0xDB4110", VA = "0xDB4110")]
	public void OnUserPropertiesChanged(string channel, string targetUserId, string senderUserId, Dictionary<object, object> properties)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xDB42D4", Offset = "0xDB42D4", VA = "0xDB42D4")]
	public void OnErrorInfo(string channel, string error, object data)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xDB4428", Offset = "0xDB4428", VA = "0xDB4428")]
	public void AddMessageToSelectedChannel(string msg)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xDB124C", Offset = "0xDB124C", VA = "0xDB124C")]
	public void ShowChannel(string channelName)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xDB450C", Offset = "0xDB450C", VA = "0xDB450C")]
	public void OpenDashboard()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xDB4558", Offset = "0xDB4558", VA = "0xDB4558")]
	public ChatGui()
	{
	}
}
[Token(Token = "0x2000007")]
public class FriendItem : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x18")]
	public Text NameLabel;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x20")]
	public Text StatusLabel;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x28")]
	public Text Health;

	[Token(Token = "0x17000002")]
	[HideInInspector]
	public string FriendId
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xDBB7D8", Offset = "0xDBB7D8", VA = "0xDBB7D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xDB3550", Offset = "0xDB3550", VA = "0xDB3550")]
		set
		{
		}
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xDBB7FC", Offset = "0xDBB7FC", VA = "0xDBB7FC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xDB3C2C", Offset = "0xDB3C2C", VA = "0xDB3C2C")]
	public void OnFriendStatusUpdate(int status, bool gotMessage, object message)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xDBB868", Offset = "0xDBB868", VA = "0xDBB868")]
	public FriendItem()
	{
	}
}
[Token(Token = "0x2000008")]
public class IgnoreUiRaycastWhenInactive : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x6000038")]
	[Address(RVA = "0xDBB870", Offset = "0xDBB870", VA = "0xDBB870", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xDBB894", Offset = "0xDBB894", VA = "0xDBB894")]
	public IgnoreUiRaycastWhenInactive()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD351C0", Offset = "0xD351C0")]
public class NamePickGui : MonoBehaviour
{
	[Token(Token = "0x4000025")]
	private const string UserNamePlayerPref = "NamePickUserName";

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x18")]
	public ChatGui chatNewComponent;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x20")]
	public InputField idInput;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xDBB964", Offset = "0xDBB964", VA = "0xDBB964")]
	public void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xDBBA28", Offset = "0xDBBA28", VA = "0xDBBA28")]
	public void EndEditOnEnter()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xDBBA74", Offset = "0xDBBA74", VA = "0xDBBA74")]
	public void StartChat()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xDBBB50", Offset = "0xDBBB50", VA = "0xDBBB50")]
	public NamePickGui()
	{
	}
}
[Token(Token = "0x200000A")]
public class AndroidVolumeSync : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x18")]
	private AndroidJavaObject volumeSync;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xDB0A78", Offset = "0xDB0A78", VA = "0xDB0A78")]
	private void Start()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xDB0C48", Offset = "0xDB0C48", VA = "0xDB0C48")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xDB0D38", Offset = "0xDB0D38", VA = "0xDB0D38")]
	public AndroidVolumeSync()
	{
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35224", Offset = "0xD35224")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35224", Offset = "0xD35224")]
public class ChangeColor : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x18")]
	private PhotonView photonView;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xDB0E44", Offset = "0xDB0E44", VA = "0xDB0E44")]
	private void Start()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xDB0FB4", Offset = "0xDB0FB4", VA = "0xDB0FB4")]
	[PunRPC]
	private void ChangeColour(Vector3 randomColor)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xDB1080", Offset = "0xDB1080", VA = "0xDB1080")]
	public ChangeColor()
	{
	}
}
[Token(Token = "0x200000C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD352B0", Offset = "0xD352B0")]
public class ChangeName : MonoBehaviour
{
	[Token(Token = "0x6000044")]
	[Address(RVA = "0xDB1088", Offset = "0xDB1088", VA = "0xDB1088")]
	private void Start()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xDB113C", Offset = "0xDB113C", VA = "0xDB113C")]
	public ChangeName()
	{
	}
}
[Token(Token = "0x200000D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35314", Offset = "0xD35314")]
public class PointersController : MonoBehaviour
{
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject pointerDown;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject pointerUp;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x28")]
	private PhotonVoiceView photonVoiceView;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xDC1310", Offset = "0xDC1310", VA = "0xDC1310")]
	private void Start()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xDC1370", Offset = "0xDC1370", VA = "0xDC1370")]
	private void Update()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xDC13CC", Offset = "0xDC13CC", VA = "0xDC13CC")]
	private void SetActiveSafe(GameObject go, bool active)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xDC1484", Offset = "0xDC1484", VA = "0xDC1484")]
	public PointersController()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35378", Offset = "0xD35378")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35378", Offset = "0xD35378")]
public class ProximityVoiceTrigger : VoiceComponent
{
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x28")]
	private List<byte> groupsToAdd;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x30")]
	private List<byte> groupsToRemove;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private byte[] subscribedGroups;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x40")]
	private PhotonVoiceView photonVoiceView;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x48")]
	private PhotonView photonView;

	[Token(Token = "0x17000003")]
	public byte TargetInterestGroup
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0xDC148C", Offset = "0xDC148C", VA = "0xDC148C")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xDC1520", Offset = "0xDC1520", VA = "0xDC1520", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xDC15CC", Offset = "0xDC15CC", VA = "0xDC15CC")]
	private void ToggleTransmission()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xDC1894", Offset = "0xDC1894", VA = "0xDC1894")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xDC1A78", Offset = "0xDC1A78", VA = "0xDC1A78")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xDC1C90", Offset = "0xDC1C90", VA = "0xDC1C90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xDC2248", Offset = "0xDC2248", VA = "0xDC2248")]
	public ProximityVoiceTrigger()
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public class MouseLookHelper
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x10")]
	public float XSensitivity;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x14")]
	public float YSensitivity;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x18")]
	public bool clampVerticalRotation;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x1C")]
	public float MinimumX;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x20")]
	public float MaximumX;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x24")]
	public bool smooth;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x28")]
	public float smoothTime;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x2C")]
	private Quaternion m_CharacterTargetRot;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x3C")]
	private Quaternion m_CameraTargetRot;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xDB870C", Offset = "0xDB870C", VA = "0xDB870C")]
	public void Init(Transform character, Transform camera)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xDB8A00", Offset = "0xDB8A00", VA = "0xDB8A00")]
	public void LookRotation(Transform character, Transform camera)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xDBB89C", Offset = "0xDBB89C", VA = "0xDBB89C")]
	private Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xDB8D68", Offset = "0xDB8D68", VA = "0xDB8D68")]
	public MouseLookHelper()
	{
	}
}
[Token(Token = "0x2000010")]
public class SoundsForJoinAndLeave : MonoBehaviourPunCallbacks
{
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip JoinClip;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip LeaveClip;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x30")]
	private AudioSource source;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xDC22F0", Offset = "0xDC22F0", VA = "0xDC22F0", Slot = "42")]
	public override void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xDC2400", Offset = "0xDC2400", VA = "0xDC2400", Slot = "43")]
	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xDC2510", Offset = "0xDC2510", VA = "0xDC2510")]
	public SoundsForJoinAndLeave()
	{
	}
}
[Token(Token = "0x2000011")]
public class DebugGameMenu : MonoBehaviour
{
	[Token(Token = "0x6000058")]
	[Address(RVA = "0xDB4698", Offset = "0xDB4698", VA = "0xDB4698")]
	public void ClearSaveData()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xDB4774", Offset = "0xDB4774", VA = "0xDB4774")]
	public void Finish()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xDB47C0", Offset = "0xDB47C0", VA = "0xDB47C0")]
	public void UnlockLevels()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xDB4910", Offset = "0xDB4910", VA = "0xDB4910")]
	public DebugGameMenu()
	{
	}
}
[Token(Token = "0x2000012")]
public class DebugGameMenuController : MonoBehaviour
{
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x18")]
	private bool activeMode;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject DebugGamePrefab;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x28")]
	private GameObject debugMenu;

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xDB4918", Offset = "0xDB4918", VA = "0xDB4918")]
	private void Start()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xDB4A70", Offset = "0xDB4A70", VA = "0xDB4A70")]
	private void DoButtonOnePress(object sender, ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xDB4A74", Offset = "0xDB4A74", VA = "0xDB4A74")]
	public void ToggleMode(ControllerInteractionEventArgs e)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xDB4B44", Offset = "0xDB4B44", VA = "0xDB4B44")]
	public DebugGameMenuController()
	{
	}
}
[Token(Token = "0x2000013")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x18")]
	public TMP_InputField TMP_ChatInput;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x20")]
	public TMP_Text TMP_ChatOutput;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xDB15D0", Offset = "0xDB15D0", VA = "0xDB15D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xDB1674", Offset = "0xDB1674", VA = "0xDB1674")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xDB1718", Offset = "0xDB1718", VA = "0xDB1718")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xDB1B34", Offset = "0xDB1B34", VA = "0xDB1B34")]
	public ChatController()
	{
	}
}
[Token(Token = "0x2000014")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD357F0", Offset = "0xD357F0")]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xDB577C", Offset = "0xDB577C", VA = "0xDB577C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xDB57E4", Offset = "0xDB57E4", VA = "0xDB57E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xDB5548", Offset = "0xDB5548", VA = "0xDB5548")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xDB557C", Offset = "0xDB557C", VA = "0xDB557C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xDB5580", Offset = "0xDB5580", VA = "0xDB5580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xDB5784", Offset = "0xDB5784", VA = "0xDB5784", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xDB5440", Offset = "0xDB5440", VA = "0xDB5440")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xDB54CC", Offset = "0xDB54CC", VA = "0xDB54CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD3608C", Offset = "0xD3608C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xDB5574", Offset = "0xDB5574", VA = "0xDB5574")]
	public EnvMapAnimator()
	{
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000015")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x174D6B0", Offset = "0x174D6B0", VA = "0x174D6B0", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x174D6DC", Offset = "0x174D6DC", VA = "0x174D6DC")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x174D6E4", Offset = "0x174D6E4", VA = "0x174D6E4", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x174DB2C", Offset = "0x174DB2C", VA = "0x174DB2C")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x2000057")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x174E59C", Offset = "0x174E59C", VA = "0x174E59C")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000058")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x174E5EC", Offset = "0x174E5EC", VA = "0x174E5EC")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000059")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x174E63C", Offset = "0x174E63C", VA = "0x174E63C")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005A")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x174E68C", Offset = "0x174E68C", VA = "0x174E68C")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005B")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x174E6DC", Offset = "0x174E6DC", VA = "0x174E6DC")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x17000004")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x174DB34", Offset = "0x174DB34", VA = "0x174DB34")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x174DB3C", Offset = "0x174DB3C", VA = "0x174DB3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x174DB44", Offset = "0x174DB44", VA = "0x174DB44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x174DB4C", Offset = "0x174DB4C", VA = "0x174DB4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x174DB54", Offset = "0x174DB54", VA = "0x174DB54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x174DB5C", Offset = "0x174DB5C", VA = "0x174DB5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x174DB64", Offset = "0x174DB64", VA = "0x174DB64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x174DB6C", Offset = "0x174DB6C", VA = "0x174DB6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x174DB74", Offset = "0x174DB74", VA = "0x174DB74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x174DB7C", Offset = "0x174DB7C", VA = "0x174DB7C")]
			set
			{
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x174DB84", Offset = "0x174DB84", VA = "0x174DB84")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x174DD30", Offset = "0x174DD30", VA = "0x174DD30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x174E47C", Offset = "0x174E47C", VA = "0x174E47C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x174E480", Offset = "0x174E480", VA = "0x174E480", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x174E1D4", Offset = "0x174E1D4", VA = "0x174E1D4")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x174E250", Offset = "0x174E250", VA = "0x174E250")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x174E2CC", Offset = "0x174E2CC", VA = "0x174E2CC")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x174E35C", Offset = "0x174E35C", VA = "0x174E35C")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x174E3EC", Offset = "0x174E3EC", VA = "0x174E3EC")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x174E484", Offset = "0x174E484", VA = "0x174E484")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000018")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35800", Offset = "0xD35800")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DD")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001DE")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001DF")]
			[FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x40001E0")]
			[FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600026E")]
				[Address(RVA = "0xDC2B34", Offset = "0xDC2B34", VA = "0xDC2B34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000270")]
				[Address(RVA = "0xDC2B9C", Offset = "0xDC2B9C", VA = "0xDC2B9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0xDC2594", Offset = "0xDC2594", VA = "0xDC2594")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0xDC25C8", Offset = "0xDC25C8", VA = "0xDC25C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0xDC25CC", Offset = "0xDC25CC", VA = "0xDC25CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0xDC2B3C", Offset = "0xDC2B3C", VA = "0xDC2B3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x4000059")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x400005A")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xDC2518", Offset = "0xDC2518", VA = "0xDC2518")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD360F0", Offset = "0xD360F0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xDC25C0", Offset = "0xDC25C0", VA = "0xDC25C0")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35810", Offset = "0xD35810")]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001E1")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001E2")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001E3")]
			[FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x40001E4")]
			[FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000274")]
				[Address(RVA = "0xDC30E8", Offset = "0xDC30E8", VA = "0xDC30E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000276")]
				[Address(RVA = "0xDC3150", Offset = "0xDC3150", VA = "0xDC3150", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0xDC2C20", Offset = "0xDC2C20", VA = "0xDC2C20")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000272")]
			[Address(RVA = "0xDC2C54", Offset = "0xDC2C54", VA = "0xDC2C54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0xDC2C58", Offset = "0xDC2C58", VA = "0xDC2C58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000275")]
			[Address(RVA = "0xDC30F0", Offset = "0xDC30F0", VA = "0xDC30F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x4000063")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x4000064")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xDC2BA4", Offset = "0xDC2BA4", VA = "0xDC2BA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD36154", Offset = "0xD36154")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xDC2C4C", Offset = "0xDC2C4C", VA = "0xDC2C4C")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x20")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xDC3158", Offset = "0xDC3158", VA = "0xDC3158")]
		private void Start()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xDC3778", Offset = "0xDC3778", VA = "0xDC3778")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xDC3788", Offset = "0xDC3788", VA = "0xDC3788")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xDC378C", Offset = "0xDC378C", VA = "0xDC378C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xDC3A3C", Offset = "0xDC3A3C", VA = "0xDC3A3C")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xDC3A4C", Offset = "0xDC3A4C", VA = "0xDC3A4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xDC3DC8", Offset = "0xDC3DC8", VA = "0xDC3DC8")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		public enum CameraModes
		{
			[Token(Token = "0x40001E6")]
			Follow,
			[Token(Token = "0x40001E7")]
			Isometric,
			[Token(Token = "0x40001E8")]
			Free
		}

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x4000089")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x400008A")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xDC3DE4", Offset = "0xDC3DE4", VA = "0xDC3DE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xDC3E74", Offset = "0xDC3E74", VA = "0xDC3E74")]
		private void Start()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xDC3F60", Offset = "0xDC3F60", VA = "0xDC3F60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xDC43DC", Offset = "0xDC43DC", VA = "0xDC43DC")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xDC4CF0", Offset = "0xDC4CF0", VA = "0xDC4CF0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		public enum MotionType
		{
			[Token(Token = "0x40001EA")]
			Rotation,
			[Token(Token = "0x40001EB")]
			BackAndForth,
			[Token(Token = "0x40001EC")]
			Translation
		}

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xDC4D98", Offset = "0xDC4D98", VA = "0xDC4D98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xDC4EC0", Offset = "0xDC4EC0", VA = "0xDC4EC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xDC50FC", Offset = "0xDC50FC", VA = "0xDC50FC")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35820", Offset = "0xD35820")]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001ED")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001EE")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001EF")]
			[FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x17000013")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0xDC53D8", Offset = "0xDC53D8", VA = "0xDC53D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0xDC5440", Offset = "0xDC5440", VA = "0xDC5440", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0xDC523C", Offset = "0xDC523C", VA = "0xDC523C")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0xDC5270", Offset = "0xDC5270", VA = "0xDC5270", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0xDC5274", Offset = "0xDC5274", VA = "0xDC5274", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0xDC53E0", Offset = "0xDC53E0", VA = "0xDC53E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xDC5110", Offset = "0xDC5110", VA = "0xDC5110")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xDC5194", Offset = "0xDC5194", VA = "0xDC5194")]
		private void Start()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xDC51C0", Offset = "0xDC51C0", VA = "0xDC51C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD361B8", Offset = "0xD361B8")]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xDC5268", Offset = "0xDC5268", VA = "0xDC5268")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x400009A")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xDC5448", Offset = "0xDC5448", VA = "0xDC5448")]
		private void Start()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xDC5514", Offset = "0xDC5514", VA = "0xDC5514")]
		private void Update()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xDC55B0", Offset = "0xDC55B0", VA = "0xDC55B0")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35830", Offset = "0xD35830")]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001F0")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001F1")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x40001F4")]
			[FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x40001F5")]
			[FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x17000015")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000280")]
				[Address(RVA = "0xDC66E4", Offset = "0xDC66E4", VA = "0xDC66E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000016")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000282")]
				[Address(RVA = "0xDC674C", Offset = "0xDC674C", VA = "0xDC674C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0xDC5758", Offset = "0xDC5758", VA = "0xDC5758")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0xDC59C0", Offset = "0xDC59C0", VA = "0xDC59C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0xDC59C4", Offset = "0xDC59C4", VA = "0xDC59C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0xDC66EC", Offset = "0xDC66EC", VA = "0xDC66EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xDC55B8", Offset = "0xDC55B8", VA = "0xDC55B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xDC5628", Offset = "0xDC5628", VA = "0xDC5628")]
		private void Start()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xDC56D0", Offset = "0xDC56D0", VA = "0xDC56D0")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xDC5654", Offset = "0xDC5654", VA = "0xDC5654")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD3621C", Offset = "0xD3621C")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xDC5784", Offset = "0xDC5784", VA = "0xDC5784")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x2000062")]
		public enum objectType
		{
			[Token(Token = "0x40001F7")]
			TextMeshPro,
			[Token(Token = "0x40001F8")]
			TextMeshProUGUI
		}

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x40000A3")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xDC6754", Offset = "0xDC6754", VA = "0xDC6754")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xDC693C", Offset = "0xDC693C", VA = "0xDC693C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xDC69D8", Offset = "0xDC69D8", VA = "0xDC69D8")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000063")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001FA")]
			TopLeft,
			[Token(Token = "0x40001FB")]
			BottomLeft,
			[Token(Token = "0x40001FC")]
			TopRight,
			[Token(Token = "0x40001FD")]
			BottomRight
		}

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x40000AA")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xDC69E0", Offset = "0xDC69E0", VA = "0xDC69E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xDC6E98", Offset = "0xDC6E98", VA = "0xDC6E98")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xDC6EC4", Offset = "0xDC6EC4", VA = "0xDC6EC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xDC6BF8", Offset = "0xDC6BF8", VA = "0xDC6BF8")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xDC7034", Offset = "0xDC7034", VA = "0xDC7034")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1741A20", Offset = "0x1741A20", VA = "0x1741A20")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1741C58", Offset = "0x1741C58", VA = "0x1741C58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1741E90", Offset = "0x1741E90", VA = "0x1741E90")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x17420B0", Offset = "0x17420B0", VA = "0x17420B0")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17422D0", Offset = "0x17422D0", VA = "0x17422D0")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1742578", Offset = "0x1742578", VA = "0x1742578")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1742820", Offset = "0x1742820", VA = "0x1742820")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1742AB4", Offset = "0x1742AB4", VA = "0x1742AB4")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		public bool ShowCharacters;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x19")]
		public bool ShowWords;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x1A")]
		public bool ShowLinks;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x1B")]
		public bool ShowLines;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x1C")]
		public bool ShowMeshBounds;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x1D")]
		public bool ShowTextBounds;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD359A0", Offset = "0xD359A0")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xD359A0", Offset = "0xD359A0")]
		public string ObjectStats;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x30")]
		private Transform m_Transform;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1742ABC", Offset = "0x1742ABC", VA = "0x1742ABC")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1742AC4", Offset = "0x1742AC4", VA = "0x1742AC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1742B6C", Offset = "0x1742B6C", VA = "0x1742B6C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1743490", Offset = "0x1743490", VA = "0x1743490", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x174350C", Offset = "0x174350C", VA = "0x174350C", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1743584", Offset = "0x1743584", VA = "0x1743584")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x40000C2")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x40000C3")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x174359C", Offset = "0x174359C", VA = "0x174359C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x174374C", Offset = "0x174374C", VA = "0x174374C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1743810", Offset = "0x1743810", VA = "0x1743810")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x17438D4", Offset = "0x17438D4", VA = "0x17438D4")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1743990", Offset = "0x1743990", VA = "0x1743990")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1745138", Offset = "0x1745138", VA = "0x1745138", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1745144", Offset = "0x1745144", VA = "0x1745144", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x174514C", Offset = "0x174514C", VA = "0x174514C", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1745150", Offset = "0x1745150", VA = "0x1745150", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x17448A8", Offset = "0x17448A8", VA = "0x17448A8")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1745154", Offset = "0x1745154", VA = "0x1745154")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x40001FF")]
			TopLeft,
			[Token(Token = "0x4000200")]
			BottomLeft,
			[Token(Token = "0x4000201")]
			TopRight,
			[Token(Token = "0x4000202")]
			BottomRight
		}

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x40000D2")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x174516C", Offset = "0x174516C", VA = "0x174516C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x17456C0", Offset = "0x17456C0", VA = "0x17456C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x17456EC", Offset = "0x17456EC", VA = "0x17456EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x174533C", Offset = "0x174533C", VA = "0x174533C")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x174585C", Offset = "0x174585C", VA = "0x174585C")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x2000065")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000204")]
			TopLeft,
			[Token(Token = "0x4000205")]
			BottomLeft,
			[Token(Token = "0x4000206")]
			TopRight,
			[Token(Token = "0x4000207")]
			BottomRight
		}

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x40000D7")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1745874", Offset = "0x1745874", VA = "0x1745874")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1745AB8", Offset = "0x1745AB8", VA = "0x1745AB8")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1745C08", Offset = "0x1745C08", VA = "0x1745C08")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35840", Offset = "0xD35840")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000209")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400020A")]
			[FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x400020B")]
			[FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x400020C")]
			[FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x17000017")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x1746044", Offset = "0x1746044", VA = "0x1746044", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000288")]
				[Address(RVA = "0x17460AC", Offset = "0x17460AC", VA = "0x17460AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1745D40", Offset = "0x1745D40", VA = "0x1745D40")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1745DE4", Offset = "0x1745DE4", VA = "0x1745DE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1745DE8", Offset = "0x1745DE8", VA = "0x1745DE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x174604C", Offset = "0x174604C", VA = "0x174604C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1745C18", Offset = "0x1745C18", VA = "0x1745C18")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1745CC4", Offset = "0x1745CC4", VA = "0x1745CC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD36280", Offset = "0xD36280")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1745D6C", Offset = "0x1745D6C", VA = "0x1745D6C")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35850", Offset = "0xD35850")]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400020D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x17000019")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600028C")]
				[Address(RVA = "0x17465E4", Offset = "0x17465E4", VA = "0x17465E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600028E")]
				[Address(RVA = "0x174664C", Offset = "0x174664C", VA = "0x174664C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1746380", Offset = "0x1746380", VA = "0x1746380")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x174645C", Offset = "0x174645C", VA = "0x174645C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x1746460", Offset = "0x1746460", VA = "0x1746460", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x17465EC", Offset = "0x17465EC", VA = "0x17465EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35860", Offset = "0xD35860")]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x4000219")]
			[FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x400021A")]
			[FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x1700001B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000292")]
				[Address(RVA = "0x1746850", Offset = "0x1746850", VA = "0x1746850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000294")]
				[Address(RVA = "0x17468B8", Offset = "0x17468B8", VA = "0x17468B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1746428", Offset = "0x1746428", VA = "0x1746428")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x1746654", Offset = "0x1746654", VA = "0x1746654", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x1746658", Offset = "0x1746658", VA = "0x1746658", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x1746858", Offset = "0x1746858", VA = "0x1746858", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x17460B4", Offset = "0x17460B4", VA = "0x17460B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1746124", Offset = "0x1746124", VA = "0x1746124")]
		private void Start()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x17461EC", Offset = "0x17461EC", VA = "0x17461EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x17462B0", Offset = "0x17462B0", VA = "0x17462B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1746374", Offset = "0x1746374", VA = "0x1746374")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1746154", Offset = "0x1746154", VA = "0x1746154")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD362E4", Offset = "0xD362E4")]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x17463AC", Offset = "0x17463AC", VA = "0x17463AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD36348", Offset = "0xD36348")]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1746454", Offset = "0x1746454", VA = "0x1746454")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35870", Offset = "0xD35870")]
		private sealed class <DisplayTextMeshProFloatingText>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021C")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400021D")]
			[FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x400021E")]
			[FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x400021F")]
			[FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x4000220")]
			[FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x4000221")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x4000222")]
			[FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x4000223")]
			[FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x4000224")]
			[FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x1700001D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000298")]
				[Address(RVA = "0x1747AC4", Offset = "0x1747AC4", VA = "0x1747AC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x1747B2C", Offset = "0x1747B2C", VA = "0x1747B2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1746F3C", Offset = "0x1746F3C", VA = "0x1746F3C")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x17475AC", Offset = "0x17475AC", VA = "0x17475AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x17475B0", Offset = "0x17475B0", VA = "0x17475B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x1747ACC", Offset = "0x1747ACC", VA = "0x1747ACC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35880", Offset = "0xD35880")]
		private sealed class <DisplayTextMeshFloatingText>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000225")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000226")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000227")]
			[FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x4000228")]
			[FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x4000229")]
			[FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x400022A")]
			[FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x400022B")]
			[FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x400022C")]
			[FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x400022D")]
			[FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x400022E")]
			[FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x1700001F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600029E")]
				[Address(RVA = "0x174753C", Offset = "0x174753C", VA = "0x174753C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A0")]
				[Address(RVA = "0x17475A4", Offset = "0x17475A4", VA = "0x17475A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x1746F68", Offset = "0x1746F68", VA = "0x1746F68")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x174703C", Offset = "0x174703C", VA = "0x174703C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1747040", Offset = "0x1747040", VA = "0x1747040", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1747544", Offset = "0x1747544", VA = "0x1747544", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x17468C0", Offset = "0x17468C0", VA = "0x17468C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x17469A0", Offset = "0x17469A0", VA = "0x17469A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1746E44", Offset = "0x1746E44", VA = "0x1746E44")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD363AC", Offset = "0xD363AC")]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1746EC0", Offset = "0x1746EC0", VA = "0x1746EC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD36410", Offset = "0xD36410")]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1746F94", Offset = "0x1746F94", VA = "0x1746F94")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1747B34", Offset = "0x1747B34", VA = "0x1747B34")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1747B38", Offset = "0x1747B38", VA = "0x1747B38")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1747E7C", Offset = "0x1747E7C", VA = "0x1747E7C")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35890", Offset = "0xD35890")]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400022F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000230")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000231")]
			[FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x4000232")]
			[FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000233")]
			[FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002A4")]
				[Address(RVA = "0x1748290", Offset = "0x1748290", VA = "0x1748290", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A6")]
				[Address(RVA = "0x17482F8", Offset = "0x17482F8", VA = "0x17482F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x1747F94", Offset = "0x1747F94", VA = "0x1747F94")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1747FC8", Offset = "0x1747FC8", VA = "0x1747FC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1747FCC", Offset = "0x1747FCC", VA = "0x1747FCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1748298", Offset = "0x1748298", VA = "0x1748298", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1747E8C", Offset = "0x1747E8C", VA = "0x1747E8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1747EEC", Offset = "0x1747EEC", VA = "0x1747EEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1747F18", Offset = "0x1747F18", VA = "0x1747F18")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD36474", Offset = "0xD36474")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1747FC0", Offset = "0x1747FC0", VA = "0x1747FC0")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x200006C")]
		private struct VertexAnim
		{
			[Token(Token = "0x4000234")]
			[FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x4000235")]
			[FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x4000236")]
			[FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD358A0", Offset = "0xD358A0")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000237")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000238")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000239")]
			[FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x400023C")]
			[FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x400023D")]
			[FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x17000023")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002AA")]
				[Address(RVA = "0x174914C", Offset = "0x174914C", VA = "0x174914C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000024")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002AC")]
				[Address(RVA = "0x17491B4", Offset = "0x17491B4", VA = "0x17491B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x174861C", Offset = "0x174861C", VA = "0x174861C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1748660", Offset = "0x1748660", VA = "0x1748660", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1748664", Offset = "0x1748664", VA = "0x1748664", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1749154", Offset = "0x1749154", VA = "0x1749154", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1748300", Offset = "0x1748300", VA = "0x1748300")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1748360", Offset = "0x1748360", VA = "0x1748360")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1748424", Offset = "0x1748424", VA = "0x1748424")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x17484E8", Offset = "0x17484E8", VA = "0x17484E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1748590", Offset = "0x1748590", VA = "0x1748590")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1748514", Offset = "0x1748514", VA = "0x1748514")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD364D8", Offset = "0xD364D8")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1748648", Offset = "0x1748648", VA = "0x1748648")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD358B0", Offset = "0xD358B0")]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x4000241")]
			[FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000242")]
			[FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000025")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002B0")]
				[Address(RVA = "0x174A054", Offset = "0x174A054", VA = "0x174A054", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000026")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002B2")]
				[Address(RVA = "0x174A0BC", Offset = "0x174A0BC", VA = "0x174A0BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x17494C8", Offset = "0x17494C8", VA = "0x17494C8")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1749504", Offset = "0x1749504", VA = "0x1749504", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1749508", Offset = "0x1749508", VA = "0x1749508", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x174A05C", Offset = "0x174A05C", VA = "0x174A05C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x17491BC", Offset = "0x17491BC", VA = "0x17491BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x174921C", Offset = "0x174921C", VA = "0x174921C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x17492E0", Offset = "0x17492E0", VA = "0x17492E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x17493A4", Offset = "0x17493A4", VA = "0x17493A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x174944C", Offset = "0x174944C", VA = "0x174944C")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x17493D0", Offset = "0x17493D0", VA = "0x17493D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD3653C", Offset = "0xD3653C")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x17494F4", Offset = "0x17494F4", VA = "0x17494F4")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD358C0", Offset = "0xD358C0")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000243")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000244")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000245")]
			[FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x4000246")]
			[FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000247")]
			[FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002B6")]
				[Address(RVA = "0x174B4A8", Offset = "0x174B4A8", VA = "0x174B4A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002B8")]
				[Address(RVA = "0x174B510", Offset = "0x174B510", VA = "0x174B510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x174A3D0", Offset = "0x174A3D0", VA = "0x174A3D0")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x174A414", Offset = "0x174A414", VA = "0x174A414", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x174A418", Offset = "0x174A418", VA = "0x174A418", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x174B4B0", Offset = "0x174B4B0", VA = "0x174B4B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x174A0C4", Offset = "0x174A0C4", VA = "0x174A0C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x174A124", Offset = "0x174A124", VA = "0x174A124")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x174A1E8", Offset = "0x174A1E8", VA = "0x174A1E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x174A2AC", Offset = "0x174A2AC", VA = "0x174A2AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x174A354", Offset = "0x174A354", VA = "0x174A354")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x174A2D8", Offset = "0x174A2D8", VA = "0x174A2D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD365A0", Offset = "0xD365A0")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x174A3FC", Offset = "0x174A3FC", VA = "0x174A3FC")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD358D0", Offset = "0xD358D0")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000248")]
			[FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x4000249")]
			[FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x174B878", Offset = "0x174B878", VA = "0x174B878")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x174B880", Offset = "0x174B880", VA = "0x174B880")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000071")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD358E0", Offset = "0xD358E0")]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400024A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400024B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400024C")]
			[FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x400024D")]
			[FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x400024E")]
			[FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400024F")]
			[FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x4000250")]
			[FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x17000029")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002BE")]
				[Address(RVA = "0x174C69C", Offset = "0x174C69C", VA = "0x174C69C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C0")]
				[Address(RVA = "0x174C704", Offset = "0x174C704", VA = "0x174C704", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x174B834", Offset = "0x174B834", VA = "0x174B834")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x174B944", Offset = "0x174B944", VA = "0x174B944", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x174B948", Offset = "0x174B948", VA = "0x174B948", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x174C6A4", Offset = "0x174C6A4", VA = "0x174C6A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x174B518", Offset = "0x174B518", VA = "0x174B518")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x174B578", Offset = "0x174B578", VA = "0x174B578")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x174B63C", Offset = "0x174B63C", VA = "0x174B63C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x174B700", Offset = "0x174B700", VA = "0x174B700")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x174B7A8", Offset = "0x174B7A8", VA = "0x174B7A8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x174B72C", Offset = "0x174B72C", VA = "0x174B72C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD36604", Offset = "0xD36604")]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x174B860", Offset = "0x174B860", VA = "0x174B860")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000072")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD358F0", Offset = "0xD358F0")]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000251")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000252")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000253")]
			[FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x4000254")]
			[FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000255")]
			[FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x1700002B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x174D640", Offset = "0x174D640", VA = "0x174D640", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C6")]
				[Address(RVA = "0x174D6A8", Offset = "0x174D6A8", VA = "0x174D6A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x174C8AC", Offset = "0x174C8AC", VA = "0x174C8AC")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x174CB1C", Offset = "0x174CB1C", VA = "0x174CB1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x174CB20", Offset = "0x174CB20", VA = "0x174CB20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x174D648", Offset = "0x174D648", VA = "0x174D648", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x174C70C", Offset = "0x174C70C", VA = "0x174C70C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x174C77C", Offset = "0x174C77C", VA = "0x174C77C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x174C824", Offset = "0x174C824", VA = "0x174C824")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x174C7A8", Offset = "0x174C7A8", VA = "0x174C7A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD36668", Offset = "0xD36668")]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x174C8D8", Offset = "0x174C8D8", VA = "0x174C8D8")]
		public WarpTextExample()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000034")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x174E72C", Offset = "0x174E72C", VA = "0x174E72C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x174E9F4", Offset = "0x174E9F4", VA = "0x174E9F4")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x174EB84", Offset = "0x174EB84", VA = "0x174EB84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x174EC04", Offset = "0x174EC04", VA = "0x174EC04", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x174ECEC", Offset = "0x174ECEC", VA = "0x174ECEC", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x174ED94", Offset = "0x174ED94", VA = "0x174ED94")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x174EE08", Offset = "0x174EE08", VA = "0x174EE08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x174EE0C", Offset = "0x174EE0C", VA = "0x174EE0C")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x174EEF4", Offset = "0x174EEF4", VA = "0x174EEF4")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x174EFDC", Offset = "0x174EFDC", VA = "0x174EFDC")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x174F0C4", Offset = "0x174F0C4", VA = "0x174F0C4")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x174F1AC", Offset = "0x174F1AC", VA = "0x174F1AC")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x174F294", Offset = "0x174F294", VA = "0x174F294")]
		public void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x174F298", Offset = "0x174F298", VA = "0x174F298")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000073")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000257")]
			Hardware,
			[Token(Token = "0x4000258")]
			Touch
		}

		[Token(Token = "0x2000074")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000259")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3600C", Offset = "0xD3600C")]
			private string <name>k__BackingField;

			[Token(Token = "0x400025A")]
			[FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400025B")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3601C", Offset = "0xD3601C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700002D")]
			public string name
			{
				[Token(Token = "0x60002C7")]
				[Address(RVA = "0x1750204", Offset = "0x1750204", VA = "0x1750204")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD36DF4", Offset = "0xD36DF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002C8")]
				[Address(RVA = "0x175020C", Offset = "0x175020C", VA = "0x175020C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD36E04", Offset = "0xD36E04")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60002C9")]
				[Address(RVA = "0x1750214", Offset = "0x1750214", VA = "0x1750214")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD36E14", Offset = "0xD36E14")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002CA")]
				[Address(RVA = "0x175021C", Offset = "0x175021C", VA = "0x175021C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD36E24", Offset = "0xD36E24")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float GetValue
			{
				[Token(Token = "0x60002CF")]
				[Address(RVA = "0x175027C", Offset = "0x175027C", VA = "0x175027C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000030")]
			public float GetValueRaw
			{
				[Token(Token = "0x60002D0")]
				[Address(RVA = "0x1750284", Offset = "0x1750284", VA = "0x1750284")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x174E8C4", Offset = "0x174E8C4", VA = "0x174E8C4")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1750228", Offset = "0x1750228", VA = "0x1750228")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x174EB9C", Offset = "0x174EB9C", VA = "0x174EB9C")]
			public void Remove()
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1750274", Offset = "0x1750274", VA = "0x1750274")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000075")]
		public class VirtualButton
		{
			[Token(Token = "0x400025C")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3602C", Offset = "0xD3602C")]
			private string <name>k__BackingField;

			[Token(Token = "0x400025D")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3603C", Offset = "0xD3603C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x400025E")]
			[FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x400025F")]
			[FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000260")]
			[FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000031")]
			public string name
			{
				[Token(Token = "0x60002D1")]
				[Address(RVA = "0x175028C", Offset = "0x175028C", VA = "0x175028C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD36E34", Offset = "0xD36E34")]
				get
				{
					return null;
				}
				[Token(Token = "0x60002D2")]
				[Address(RVA = "0x1750294", Offset = "0x1750294", VA = "0x1750294")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD36E44", Offset = "0xD36E44")]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60002D3")]
				[Address(RVA = "0x175029C", Offset = "0x175029C", VA = "0x175029C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD36E54", Offset = "0xD36E54")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002D4")]
				[Address(RVA = "0x17502A4", Offset = "0x17502A4", VA = "0x17502A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD36E64", Offset = "0xD36E64")]
				private set
				{
				}
			}

			[Token(Token = "0x17000033")]
			public bool GetButton
			{
				[Token(Token = "0x60002DA")]
				[Address(RVA = "0x175041C", Offset = "0x175041C", VA = "0x175041C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000034")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60002DB")]
				[Address(RVA = "0x1750424", Offset = "0x1750424", VA = "0x1750424")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000035")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60002DC")]
				[Address(RVA = "0x1750454", Offset = "0x1750454", VA = "0x1750454")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x17502B0", Offset = "0x17502B0", VA = "0x17502B0")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x17502F8", Offset = "0x17502F8", VA = "0x17502F8")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x175034C", Offset = "0x175034C", VA = "0x175034C")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x1750388", Offset = "0x1750388", VA = "0x1750388")]
			public void Released()
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x17503B4", Offset = "0x17503B4", VA = "0x17503B4")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000009")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x174FE84", Offset = "0x174FE84", VA = "0x174FE84")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x174F2A0", Offset = "0x174F2A0", VA = "0x174F2A0")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x174F354", Offset = "0x174F354", VA = "0x174F354")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x174E84C", Offset = "0x174E84C", VA = "0x174E84C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x174F474", Offset = "0x174F474", VA = "0x174F474")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x174E904", Offset = "0x174E904", VA = "0x174E904")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x174F67C", Offset = "0x174F67C", VA = "0x174F67C")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x174F81C", Offset = "0x174F81C", VA = "0x174F81C")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x174F96C", Offset = "0x174F96C", VA = "0x174F96C")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x174E97C", Offset = "0x174E97C", VA = "0x174E97C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x174FB10", Offset = "0x174FB10", VA = "0x174FB10")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x174FC08", Offset = "0x174FC08", VA = "0x174FC08")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x174FB78", Offset = "0x174FB78", VA = "0x174FB78")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x174FC70", Offset = "0x174FC70", VA = "0x174FC70")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x174FCF0", Offset = "0x174FCF0", VA = "0x174FCF0")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x174FD70", Offset = "0x174FD70", VA = "0x174FD70")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x174EE74", Offset = "0x174EE74", VA = "0x174EE74")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x174EF5C", Offset = "0x174EF5C", VA = "0x174EF5C")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x174F044", Offset = "0x174F044", VA = "0x174F044")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x174F214", Offset = "0x174F214", VA = "0x174F214")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x174F12C", Offset = "0x174F12C", VA = "0x174F12C")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x174FDF0", Offset = "0x174FDF0", VA = "0x174FDF0")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x174FF00", Offset = "0x174FF00", VA = "0x174FF00")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x174FFFC", Offset = "0x174FFFC", VA = "0x174FFFC")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1750104", Offset = "0x1750104", VA = "0x1750104")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1750484", Offset = "0x1750484", VA = "0x1750484")]
		private void Update()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1750488", Offset = "0x1750488", VA = "0x1750488")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1750508", Offset = "0x1750508", VA = "0x1750508")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000076")]
		public enum AxisOption
		{
			[Token(Token = "0x4000262")]
			Both,
			[Token(Token = "0x4000263")]
			OnlyHorizontal,
			[Token(Token = "0x4000264")]
			OnlyVertical
		}

		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1750510", Offset = "0x1750510", VA = "0x1750510")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1750688", Offset = "0x1750688", VA = "0x1750688")]
		private void Start()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x17506C4", Offset = "0x17506C4", VA = "0x17506C4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1750514", Offset = "0x1750514", VA = "0x1750514")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x17507B4", Offset = "0x17507B4", VA = "0x17507B4", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x17509A4", Offset = "0x17509A4", VA = "0x17509A4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x17509EC", Offset = "0x17509EC", VA = "0x17509EC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x17509F0", Offset = "0x17509F0", VA = "0x17509F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1750A40", Offset = "0x1750A40", VA = "0x1750A40")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1750AC0", Offset = "0x1750AC0", VA = "0x1750AC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1750AD0", Offset = "0x1750AD0", VA = "0x1750AD0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1750AC8", Offset = "0x1750AC8", VA = "0x1750AC8")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1750BAC", Offset = "0x1750BAC", VA = "0x1750BAC")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1750E18", Offset = "0x1750E18", VA = "0x1750E18")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35424", Offset = "0xD35424")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000077")]
		public enum AxisOption
		{
			[Token(Token = "0x4000266")]
			Both,
			[Token(Token = "0x4000267")]
			OnlyHorizontal,
			[Token(Token = "0x4000268")]
			OnlyVertical
		}

		[Token(Token = "0x2000078")]
		public enum ControlStyle
		{
			[Token(Token = "0x400026A")]
			Absolute,
			[Token(Token = "0x400026B")]
			Relative,
			[Token(Token = "0x400026C")]
			Swipe
		}

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1751990", Offset = "0x1751990", VA = "0x1751990")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1751B08", Offset = "0x1751B08", VA = "0x1751B08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1751994", Offset = "0x1751994", VA = "0x1751994")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1751B94", Offset = "0x1751B94", VA = "0x1751B94")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1751C00", Offset = "0x1751C00", VA = "0x1751C00", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1751CB0", Offset = "0x1751CB0", VA = "0x1751CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1751E84", Offset = "0x1751E84", VA = "0x1751E84", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1751EFC", Offset = "0x1751EFC", VA = "0x1751EFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1751FF0", Offset = "0x1751FF0", VA = "0x1751FF0")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD359E4", Offset = "0xD359E4")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000A")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1752078", Offset = "0x1752078", VA = "0x1752078")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD366CC", Offset = "0xD366CC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1752084", Offset = "0x1752084", VA = "0x1752084")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD366DC", Offset = "0xD366DC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x174F40C", Offset = "0x174F40C", VA = "0x174F40C")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x174F4EC", Offset = "0x174F4EC", VA = "0x174F4EC")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x174F554", Offset = "0x174F554", VA = "0x174F554")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x174F6F4", Offset = "0x174F6F4", VA = "0x174F6F4")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x174F8D4", Offset = "0x174F8D4", VA = "0x174F8D4")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x174F9E4", Offset = "0x174F9E4", VA = "0x174F9E4")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x174FA7C", Offset = "0x174FA7C", VA = "0x174FA7C")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x174FFB0", Offset = "0x174FFB0", VA = "0x174FFB0")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x17500B0", Offset = "0x17500B0", VA = "0x17500B0")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x17501B4", Offset = "0x17501B4", VA = "0x17501B4")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600014C")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600014D")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600014E")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x600014F")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000150")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000151")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000152")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000153")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000154")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000155")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000156")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x17515E4", Offset = "0x17515E4", VA = "0x17515E4")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200003C")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1750E20", Offset = "0x1750E20", VA = "0x1750E20")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1750EC0", Offset = "0x1750EC0", VA = "0x1750EC0")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1750F58", Offset = "0x1750F58", VA = "0x1750F58", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1750FF4", Offset = "0x1750FF4", VA = "0x1750FF4", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x17510AC", Offset = "0x17510AC", VA = "0x17510AC", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1751158", Offset = "0x1751158", VA = "0x1751158", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x17511F8", Offset = "0x17511F8", VA = "0x17511F8", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1751298", Offset = "0x1751298", VA = "0x1751298", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1751334", Offset = "0x1751334", VA = "0x1751334", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x17513DC", Offset = "0x17513DC", VA = "0x17513DC", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x175148C", Offset = "0x175148C", VA = "0x175148C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x175153C", Offset = "0x175153C", VA = "0x175153C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x17515D8", Offset = "0x17515D8", VA = "0x17515D8", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x174F34C", Offset = "0x174F34C", VA = "0x174F34C")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x17516C8", Offset = "0x17516C8", VA = "0x17516C8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x17516DC", Offset = "0x17516DC", VA = "0x17516DC", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x17516E8", Offset = "0x17516E8", VA = "0x17516E8", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x17516F4", Offset = "0x17516F4", VA = "0x17516F4", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1751700", Offset = "0x1751700", VA = "0x1751700", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x175176C", Offset = "0x175176C", VA = "0x175176C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x17517D8", Offset = "0x17517D8", VA = "0x17517D8", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1751844", Offset = "0x1751844", VA = "0x1751844", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x17518B0", Offset = "0x17518B0", VA = "0x17518B0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x175191C", Offset = "0x175191C", VA = "0x175191C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1751988", Offset = "0x1751988", VA = "0x1751988", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x174F350", Offset = "0x174F350", VA = "0x174F350")]
		public StandaloneInput()
		{
		}
	}
}
namespace ExitGames.Demos.DemoPunVoice
{
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35488", Offset = "0xD35488")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35488", Offset = "0xD35488")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35488", Offset = "0xD35488")]
	public abstract class BaseController : MonoBehaviour
	{
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x18")]
		public Camera ControllerCamera;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x20")]
		protected Rigidbody rigidBody;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x28")]
		protected Animator animator;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x30")]
		protected Transform camTrans;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x38")]
		private float h;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x3C")]
		private float v;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected float speed;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float cameraDistance;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xDB57EC", Offset = "0xDB57EC", VA = "0xDB57EC", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xDB5934", Offset = "0xDB5934", VA = "0xDB5934", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xDB5A68", Offset = "0xDB5A68", VA = "0xDB5A68", Slot = "6")]
		protected virtual void ChangePOV_CameraChanged(Camera camera)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xDB5B20", Offset = "0xDB5B20", VA = "0xDB5B20", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xDB5BBC", Offset = "0xDB5BBC", VA = "0xDB5BBC", Slot = "8")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xDB5C40", Offset = "0xDB5C40", VA = "0xDB5C40", Slot = "9")]
		protected virtual void SetCamera()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xDB5D70", Offset = "0xDB5D70", VA = "0xDB5D70", Slot = "10")]
		protected virtual void UpdateAnimator(float h, float v)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xDB5DF0", Offset = "0xDB5DF0", VA = "0xDB5DF0", Slot = "11")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xDB5F70", Offset = "0xDB5F70", VA = "0xDB5F70", Slot = "12")]
		protected virtual void ShowCamera(Camera camera)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xDB6010", Offset = "0xDB6010", VA = "0xDB6010", Slot = "13")]
		protected virtual void HideCamera(Camera camera)
		{
		}

		[Token(Token = "0x600017C")]
		protected abstract void Move(float h, float v);

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xDB60B0", Offset = "0xDB60B0", VA = "0xDB60B0")]
		protected BaseController()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD3553C", Offset = "0xD3553C")]
	[DisallowMultipleComponent]
	public class BetterToggle : MonoBehaviour
	{
		[Token(Token = "0x2000079")]
		public delegate void OnToggle(Toggle toggle);

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x18")]
		private Toggle toggle;

		[Token(Token = "0x14000001")]
		public static event OnToggle ToggleValueChanged
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xDB60C0", Offset = "0xDB60C0", VA = "0xDB60C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD366EC", Offset = "0xD366EC")]
			add
			{
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xDB6174", Offset = "0xDB6174", VA = "0xDB6174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD366FC", Offset = "0xD366FC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xDB6228", Offset = "0xDB6228", VA = "0xDB6228")]
		private void Start()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xDB62F0", Offset = "0xDB62F0", VA = "0xDB62F0")]
		public void OnToggleValueChanged()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xDB66EC", Offset = "0xDB66EC", VA = "0xDB66EC")]
		public BetterToggle()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xDB66F4", Offset = "0xDB66F4", VA = "0xDB66F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3670C", Offset = "0xD3670C")]
		private void <Start>b__5_0(bool <p0>)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class ChangePOV : MonoBehaviour, IMatchmakingCallbacks
	{
		[Token(Token = "0x200007A")]
		public delegate void OnCameraChanged(Camera newCamera);

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x18")]
		private FirstPersonController firstPersonController;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x20")]
		private ThirdPersonController thirdPersonController;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x28")]
		private OrthographicController orthographicController;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 initialCameraPosition;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion initialCameraRotation;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x50")]
		private Camera defaultCamera;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject ButtonsHolder;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button FirstPersonCamActivator;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button ThirdPersonCamActivator;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button OrthographicCamActivator;

		[Token(Token = "0x14000002")]
		public static event OnCameraChanged CameraChanged
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xDB5880", Offset = "0xDB5880", VA = "0xDB5880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3671C", Offset = "0xD3671C")]
			add
			{
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xDB59B4", Offset = "0xDB59B4", VA = "0xDB59B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3672C", Offset = "0xD3672C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xDB673C", Offset = "0xDB673C", VA = "0xDB673C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xDB68AC", Offset = "0xDB68AC", VA = "0xDB68AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xDB6A08", Offset = "0xDB6A08", VA = "0xDB6A08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xDB6C60", Offset = "0xDB6C60", VA = "0xDB6C60")]
		private void OnCharacterInstantiated(GameObject character)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xDB6D60", Offset = "0xDB6D60", VA = "0xDB6D60")]
		private void FirstPersonMode()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xDB6F04", Offset = "0xDB6F04", VA = "0xDB6F04")]
		private void ThirdPersonMode()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xDB6F0C", Offset = "0xDB6F0C", VA = "0xDB6F0C")]
		private void OrthographicMode()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xDB6D68", Offset = "0xDB6D68", VA = "0xDB6D68")]
		private void ToggleMode(BaseController controller)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xDB6F14", Offset = "0xDB6F14", VA = "0xDB6F14")]
		private void BroadcastChange(Camera camera)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xDB7344", Offset = "0xDB7344", VA = "0xDB7344", Slot = "4")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xDB7348", Offset = "0xDB7348", VA = "0xDB7348", Slot = "5")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xDB734C", Offset = "0xDB734C", VA = "0xDB734C", Slot = "6")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xDB7350", Offset = "0xDB7350", VA = "0xDB7350", Slot = "7")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xDB7354", Offset = "0xDB7354", VA = "0xDB7354", Slot = "8")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xDB7358", Offset = "0xDB7358", VA = "0xDB7358", Slot = "9")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xDB735C", Offset = "0xDB735C", VA = "0xDB735C", Slot = "10")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xDB7478", Offset = "0xDB7478", VA = "0xDB7478")]
		public ChangePOV()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class CharacterInstantiation : MonoBehaviourPunCallbacks, IOnEventCallback
	{
		[Token(Token = "0x200007B")]
		public enum SpawnSequence
		{
			[Token(Token = "0x400026E")]
			Connection,
			[Token(Token = "0x400026F")]
			Random,
			[Token(Token = "0x4000270")]
			RoundRobin
		}

		[Token(Token = "0x200007C")]
		public delegate void OnCharacterInstantiated(GameObject character);

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x20")]
		public Transform SpawnPosition;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x28")]
		public float PositionOffset;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject[] PrefabsToInstantiate;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x38")]
		public List<Transform> SpawnPoints;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x40")]
		public bool AutoSpawn;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x41")]
		public bool UseRandomOffset;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x44")]
		public SpawnSequence Sequence;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private byte manualInstantiationEventCode;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x4C")]
		protected int lastUsedSpawnPointIndex;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool manualInstantiation;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool differentPrefabs;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string localPrefabSuffix;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string remotePrefabSuffix;

		[Token(Token = "0x14000003")]
		public static event OnCharacterInstantiated CharacterInstantiated
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xDB67F8", Offset = "0xDB67F8", VA = "0xDB67F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3673C", Offset = "0xD3673C")]
			add
			{
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xDB6954", Offset = "0xDB6954", VA = "0xDB6954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3674C", Offset = "0xD3674C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xDB74B0", Offset = "0xDB74B0", VA = "0xDB74B0", Slot = "41")]
		public override void OnJoinedRoom()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xDB7718", Offset = "0xDB7718", VA = "0xDB7718")]
		private void ManualInstantiation(int index, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xDB7F90", Offset = "0xDB7F90", VA = "0xDB7F90", Slot = "54")]
		public void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xDB82B8", Offset = "0xDB82B8", VA = "0xDB82B8", Slot = "55")]
		protected virtual void GetSpawnPoint(out Vector3 spawnPos, out Quaternion spawnRot)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xDB84F4", Offset = "0xDB84F4", VA = "0xDB84F4", Slot = "56")]
		protected virtual Transform GetSpawnPoint()
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xDB8654", Offset = "0xDB8654", VA = "0xDB8654")]
		public CharacterInstantiation()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class FirstPersonController : BaseController
	{
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MouseLookHelper mouseLook;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x50")]
		private float oldYRotation;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion velRotation;

		[Token(Token = "0x1700000B")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xDB86AC", Offset = "0xDB86AC", VA = "0xDB86AC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xDB86C8", Offset = "0xDB86C8", VA = "0xDB86C8", Slot = "9")]
		protected override void SetCamera()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xDB8760", Offset = "0xDB8760", VA = "0xDB8760", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xDB887C", Offset = "0xDB887C", VA = "0xDB887C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xDB8880", Offset = "0xDB8880", VA = "0xDB8880")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xDB8CC4", Offset = "0xDB8CC4", VA = "0xDB8CC4")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD355B0", Offset = "0xD355B0")]
	public class Highlighter : MonoBehaviour
	{
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x18")]
		private Canvas canvas;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x20")]
		private PhotonVoiceView photonVoiceView;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image recorderSprite;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image speakerSprite;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text bufferLagText;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x40")]
		private bool showSpeakerLag;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xDB8D94", Offset = "0xDB8D94", VA = "0xDB8D94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xDB8F18", Offset = "0xDB8F18", VA = "0xDB8F18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xDB9088", Offset = "0xDB9088", VA = "0xDB9088")]
		private void VoiceDemoUI_DebugToggled(bool debugMode)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xDB9094", Offset = "0xDB9094", VA = "0xDB9094")]
		private void ChangePOV_CameraChanged(Camera camera)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xDB90B0", Offset = "0xDB90B0", VA = "0xDB90B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xDB91E0", Offset = "0xDB91E0", VA = "0xDB91E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xDB933C", Offset = "0xDB933C", VA = "0xDB933C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xDB94A0", Offset = "0xDB94A0", VA = "0xDB94A0")]
		public Highlighter()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class OrthographicController : ThirdPersonController
	{
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x4C")]
		public float smoothing;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 offset;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xDB94A8", Offset = "0xDB94A8", VA = "0xDB94A8", Slot = "8")]
		protected override void Init()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xDB94DC", Offset = "0xDB94DC", VA = "0xDB94DC", Slot = "9")]
		protected override void SetCamera()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xDB95C8", Offset = "0xDB95C8", VA = "0xDB95C8", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xDB9798", Offset = "0xDB9798", VA = "0xDB9798")]
		private void CameraFollow()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xDB98CC", Offset = "0xDB98CC", VA = "0xDB98CC")]
		public OrthographicController()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class ThirdPersonController : BaseController
	{
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float movingTurnSpeed;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xDB95EC", Offset = "0xDB95EC", VA = "0xDB95EC", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xDB98E8", Offset = "0xDB98E8", VA = "0xDB98E8")]
		public ThirdPersonController()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class VoiceDemoUI : MonoBehaviour
	{
		[Token(Token = "0x200007D")]
		public delegate void OnDebugToggle(bool debugMode);

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text punState;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text voiceState;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x28")]
		private PhotonVoiceNetwork punVoiceNetwork;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x30")]
		private Canvas canvas;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button punSwitch;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x40")]
		private Text punSwitchText;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button voiceSwitch;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x50")]
		private Text voiceSwitchText;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button calibrateButton;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x60")]
		private Text calibrateText;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text voiceDebugText;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x70")]
		public Recorder recorder;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject inGameSettings;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject globalSettings;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text devicesInfoText;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x90")]
		private GameObject debugGO;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x98")]
		private bool debugMode;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x9C")]
		private float volumeBeforeMute;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0xA0")]
		private DebugLevel previousDebugLevel;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int calibrationMilliSeconds;

		[Token(Token = "0x1700000C")]
		public bool DebugMode
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xDB9900", Offset = "0xDB9900", VA = "0xDB9900")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xDB9908", Offset = "0xDB9908", VA = "0xDB9908")]
			set
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event OnDebugToggle DebugToggled
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xDB8E64", Offset = "0xDB8E64", VA = "0xDB8E64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3675C", Offset = "0xD3675C")]
			add
			{
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xDB8FD4", Offset = "0xDB8FD4", VA = "0xDB8FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD3676C", Offset = "0xD3676C")]
			remove
			{
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xDB9C94", Offset = "0xDB9C94", VA = "0xDB9C94")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xDB9D08", Offset = "0xDB9D08", VA = "0xDB9D08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xDB9EDC", Offset = "0xDB9EDC", VA = "0xDB9EDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xDBA0B0", Offset = "0xDBA0B0", VA = "0xDBA0B0")]
		private void CharacterInstantiation_CharacterInstantiated(GameObject character)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xDBA174", Offset = "0xDBA174", VA = "0xDBA174")]
		private void InitToggles(Toggle[] toggles)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xDBA4C4", Offset = "0xDBA4C4", VA = "0xDBA4C4")]
		private void BetterToggle_ToggleValueChanged(Toggle toggle)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xDBA7F0", Offset = "0xDBA7F0", VA = "0xDBA7F0")]
		private void OnCameraChanged(Camera newCamera)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xDBA80C", Offset = "0xDBA80C", VA = "0xDBA80C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xDBADBC", Offset = "0xDBADBC", VA = "0xDBADBC")]
		private void PunSwitchOnClick()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xDBAEC4", Offset = "0xDBAEC4", VA = "0xDBAEC4")]
		private void VoiceSwitchOnClick()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xDBAF58", Offset = "0xDBAF58", VA = "0xDBAF58")]
		private void CalibrateButtonOnClick()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xDBB004", Offset = "0xDBB004", VA = "0xDBB004")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xDBB210", Offset = "0xDBB210", VA = "0xDBB210")]
		private void PunClientStateChanged(ClientState fromState, ClientState toState)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xDBB724", Offset = "0xDBB724", VA = "0xDBB724")]
		private void VoiceClientStateChanged(ClientState fromState, ClientState toState)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xDBB374", Offset = "0xDBB374", VA = "0xDBB374")]
		private void UpdateUiBasedOnVoiceState(ClientState voiceClientState)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xDBB72C", Offset = "0xDBB72C", VA = "0xDBB72C")]
		public VoiceDemoUI()
		{
		}
	}
}
namespace Photon.Voice.Unity.Demos
{
	[Token(Token = "0x2000047")]
	public class BackgroundMusicController : MonoBehaviour
	{
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text volumeText;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider volumeSlider;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float initialVolume;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xDBCA10", Offset = "0xDBCA10", VA = "0xDBCA10")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xDBCB68", Offset = "0xDBCB68", VA = "0xDBCB68")]
		private void OnVolumeChanged(float newValue)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xDBCC20", Offset = "0xDBCC20", VA = "0xDBCC20")]
		public BackgroundMusicController()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class SidebarToggle : MonoBehaviour
	{
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button sidebarButton;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform panelsHolder;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x28")]
		private float sidebarWidth;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x2C")]
		private bool sidebarOpen;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xDC0EF8", Offset = "0xDC0EF8", VA = "0xDC0EF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xDC0FCC", Offset = "0xDC0FCC", VA = "0xDC0FCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD3677C", Offset = "0xD3677C")]
		private void ToggleSidebar()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xDC0FB0", Offset = "0xDC0FB0", VA = "0xDC0FB0")]
		private void ToggleSidebar(bool open)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xDC1064", Offset = "0xDC1064", VA = "0xDC1064")]
		public SidebarToggle()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public static class UiExtensions
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xDC0FE4", Offset = "0xDC0FE4", VA = "0xDC0FE4")]
		public static void SetPosX(this RectTransform rectTransform, float x)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xDC107C", Offset = "0xDC107C", VA = "0xDC107C")]
		public static void SetHeight(this RectTransform rectTransform, float h)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xDBE7FC", Offset = "0xDBE7FC", VA = "0xDBE7FC")]
		public static void SetValue(this Toggle toggle, bool isOn)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xDBF834", Offset = "0xDBF834", VA = "0xDBF834")]
		public static void SetValue(this Slider slider, float v)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xDBF81C", Offset = "0xDBF81C", VA = "0xDBF81C")]
		public static void SetValue(this InputField inputField, string v)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xDC1098", Offset = "0xDC1098", VA = "0xDC1098")]
		public static void DestroyChildren(this Transform transform)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xDC11C0", Offset = "0xDC11C0", VA = "0xDC11C0")]
		public static void Hide(this CanvasGroup canvasGroup, bool blockRaycasts = false, bool interactable = false)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xDC121C", Offset = "0xDC121C", VA = "0xDC121C")]
		public static void Show(this CanvasGroup canvasGroup, bool blockRaycasts = true, bool interactable = true)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xDC1278", Offset = "0xDC1278", VA = "0xDC1278")]
		public static bool IsHidden(this CanvasGroup canvasGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xDC12A0", Offset = "0xDC12A0", VA = "0xDC12A0")]
		public static bool IsShown(this CanvasGroup canvasGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xDC12C8", Offset = "0xDC12C8", VA = "0xDC12C8")]
		public static void SetSingleOnClickCallback(this Button button, UnityAction action)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xDBF660", Offset = "0xDBF660", VA = "0xDBF660")]
		public static void SetSingleOnValueChangedCallback(this Toggle toggle, UnityAction<bool> action)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xDBCF48", Offset = "0xDBCF48", VA = "0xDBCF48")]
		public static void SetSingleOnValueChangedCallback(this InputField inputField, UnityAction<string> action)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xDBF6DC", Offset = "0xDBF6DC", VA = "0xDBF6DC")]
		public static void SetSingleOnEndEditCallback(this InputField inputField, UnityAction<string> action)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xDBCE60", Offset = "0xDBCE60", VA = "0xDBCE60")]
		public static void SetSingleOnValueChangedCallback(this Dropdown inputField, UnityAction<int> action)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xDBCAEC", Offset = "0xDBCAEC", VA = "0xDBCAEC")]
		public static void SetSingleOnValueChangedCallback(this Slider slider, UnityAction<float> action)
		{
		}
	}
}
namespace Photon.Voice.Unity.Demos.DemoVoiceUI
{
	[Token(Token = "0x200004A")]
	public class CodecSettingsUI : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dropdown frameDurationDropdown;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown samplingRateDropdown;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField bitrateInputField;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Recorder recorder;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<string> frameDurationOptions;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<string> samplingRateOptions;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xDBCC30", Offset = "0xDBCC30", VA = "0xDBCC30")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xDBD018", Offset = "0xDBD018", VA = "0xDBD018")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xDBD044", Offset = "0xDBD044", VA = "0xDBD044")]
		private void OnBitrateChanged(string newBitrateString)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xDBD0B0", Offset = "0xDBD0B0", VA = "0xDBD0B0")]
		private void OnFrameDurationChanged(int index)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xDBD120", Offset = "0xDBD120", VA = "0xDBD120")]
		private void OnSamplingRateChanged(int index)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xDBCDD0", Offset = "0xDBCDD0", VA = "0xDBCDD0")]
		private void InitFrameDuration()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xDBCEDC", Offset = "0xDBCEDC", VA = "0xDBCEDC")]
		private void InitSamplingRate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xDBCFC4", Offset = "0xDBCFC4", VA = "0xDBCFC4")]
		private void InitBitrate()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xDBD190", Offset = "0xDBD190", VA = "0xDBD190")]
		public CodecSettingsUI()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35624", Offset = "0xD35624")]
	public class DemoVoiceUI : MonoBehaviour, IInRoomCallbacks, IMatchmakingCallbacks
	{
		[Serializable]
		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD35900", Offset = "0xD35900")]
		private sealed class <>c
		{
			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x8")]
			public static Func<IAudioDesc> <>9__68_0;

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xDBFD8C", Offset = "0xDBFD8C", VA = "0xDBFD8C")]
			public <>c()
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xDBFD94", Offset = "0xDBFD94", VA = "0xDBFD94")]
			internal IAudioDesc <ToggleAudioToneFactory>b__68_0()
			{
				return null;
			}
		}

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text connectionStatusText;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text serverStatusText;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text roomStatusText;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text inputWarningText;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text rttText;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text rttVariationText;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text packetLossWarningText;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField localNicknameText;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Toggle debugEchoToggle;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Toggle reliableTransmissionToggle;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Toggle encryptionToggle;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject webRtcDspGameObject;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Toggle aecToggle;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Toggle aecHighPassToggle;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InputField reverseStreamDelayInputField;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Toggle noiseSuppressionToggle;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Toggle agcToggle;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Slider agcCompressionGainSlider;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Toggle vadToggle;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Toggle muteToggle;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Toggle streamAudioClipToggle;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Toggle audioToneToggle;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Toggle dspToggle;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Toggle highPassToggle;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Toggle photonVadToggle;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject microphoneSetupGameObject;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool defaultTransmitEnabled;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private int screenWidth;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int screenHeight;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool fullScreen;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private InputField roomNameInputField;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private InputField globalMinDelaySoftInputField;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InputField globalMaxDelaySoftInputField;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private InputField globalMaxDelayHardInputField;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private int rttYellowThreshold;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private int rttRedThreshold;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int rttVariationYellowThreshold;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private int rttVariationRedThreshold;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x128")]
		private GameObject compressionGainGameObject;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x130")]
		private Text compressionGainText;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x138")]
		private GameObject aecOptionsGameObject;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x140")]
		public Transform RemoteVoicesPanel;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x148")]
		protected VoiceConnection voiceConnection;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x150")]
		private WebRtcAudioDsp voiceAudioPreprocessor;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x158")]
		private ConnectAndJoin connectAndJoin;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x160")]
		private readonly Color warningColor;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x170")]
		private readonly Color okColor;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x180")]
		private readonly Color redColor;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x190")]
		private readonly Color defaultColor;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xDBD364", Offset = "0xDBD364", VA = "0xDBD364")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xDBDF38", Offset = "0xDBDF38", VA = "0xDBDF38", Slot = "16")]
		protected virtual void SetDefaults()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xDBDF64", Offset = "0xDBDF64", VA = "0xDBDF64")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xDBE018", Offset = "0xDBE018", VA = "0xDBE018")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xDBDE94", Offset = "0xDBDE94", VA = "0xDBDE94")]
		private void GetSavedNickname()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xDBE0CC", Offset = "0xDBE0CC", VA = "0xDBE0CC", Slot = "17")]
		protected virtual void OnSpeakerCreated(Speaker speaker)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xDBE1F0", Offset = "0xDBE1F0", VA = "0xDBE1F0")]
		private void OnRemoteVoiceRemove(Speaker speaker)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xDBE2AC", Offset = "0xDBE2AC", VA = "0xDBE2AC")]
		private void ToggleMute(bool isOn)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xDBE4B4", Offset = "0xDBE4B4", VA = "0xDBE4B4", Slot = "18")]
		protected virtual void ToggleIsRecording(bool isRecording)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xDBE4F0", Offset = "0xDBE4F0", VA = "0xDBE4F0")]
		private void ToggleDebugEcho(bool isOn)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xDBE52C", Offset = "0xDBE52C", VA = "0xDBE52C")]
		private void ToggleReliable(bool isOn)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xDBE568", Offset = "0xDBE568", VA = "0xDBE568")]
		private void ToggleEncryption(bool isOn)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xDBE5A4", Offset = "0xDBE5A4", VA = "0xDBE5A4")]
		private void ToggleAEC(bool isOn)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xDBE5EC", Offset = "0xDBE5EC", VA = "0xDBE5EC")]
		private void ToggleNoiseSuppression(bool isOn)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xDBE60C", Offset = "0xDBE60C", VA = "0xDBE60C")]
		private void ToggleAGC(bool isOn)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xDBE654", Offset = "0xDBE654", VA = "0xDBE654")]
		private void ToggleVAD(bool isOn)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xDBE674", Offset = "0xDBE674", VA = "0xDBE674")]
		private void ToggleHighPass(bool isOn)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xDBE694", Offset = "0xDBE694", VA = "0xDBE694")]
		private void ToggleDsp(bool isOn)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xDBE6F8", Offset = "0xDBE6F8", VA = "0xDBE6F8")]
		private void ToggleAudioClipStreaming(bool isOn)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xDBE818", Offset = "0xDBE818", VA = "0xDBE818")]
		private void ToggleAudioToneFactory(bool isOn)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xDBEA34", Offset = "0xDBEA34", VA = "0xDBEA34")]
		private void TogglePhotonVAD(bool isOn)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xDBEA70", Offset = "0xDBEA70", VA = "0xDBEA70")]
		private void ToggleAecHighPass(bool isOn)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xDBEA90", Offset = "0xDBEA90", VA = "0xDBEA90")]
		private void OnAgcCompressionGainChanged(float agcCompressionGain)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xDBEB60", Offset = "0xDBEB60", VA = "0xDBEB60")]
		private void OnGlobalPlaybackDelayMinSoftChanged(string newMinDelaySoftString)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xDBEC3C", Offset = "0xDBEC3C", VA = "0xDBEC3C")]
		private void OnGlobalPlaybackDelayMaxSoftChanged(string newMaxDelaySoftString)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xDBED14", Offset = "0xDBED14", VA = "0xDBED14")]
		private void OnGlobalPlaybackDelayMaxHardChanged(string newMaxDelayHardString)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xDBEDEC", Offset = "0xDBEDEC", VA = "0xDBEDEC")]
		private void OnReverseStreamDelayChanged(string newReverseStreamString)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xDBEE80", Offset = "0xDBEE80", VA = "0xDBEE80")]
		private void UpdateSyncedNickname(string nickname)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xDBEF3C", Offset = "0xDBEF3C", VA = "0xDBEF3C")]
		private void JoinOrCreateRoom(string roomName)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xDBF08C", Offset = "0xDBF08C", VA = "0xDBF08C", Slot = "19")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xDBF5E0", Offset = "0xDBF5E0", VA = "0xDBF5E0")]
		private void SetTextColor(int textValue, Text text, int yellowThreshold, int redThreshold)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xDBF5A8", Offset = "0xDBF5A8", VA = "0xDBF5A8")]
		private void ResetTextColor(Text text)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xDBD4F4", Offset = "0xDBD4F4", VA = "0xDBD4F4")]
		private void InitUiCallbacks()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xDBD9E0", Offset = "0xDBD9E0", VA = "0xDBD9E0")]
		private void InitUiValues()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xDBF854", Offset = "0xDBF854", VA = "0xDBF854")]
		private void SetRoomDebugText()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xDBFAF4", Offset = "0xDBFAF4", VA = "0xDBFAF4", Slot = "20")]
		protected virtual void OnActorPropertiesChanged(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xDBFB6C", Offset = "0xDBFB6C", VA = "0xDBFB6C", Slot = "4")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xDBFB70", Offset = "0xDBFB70", VA = "0xDBFB70", Slot = "5")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xDBFB74", Offset = "0xDBFB74", VA = "0xDBFB74", Slot = "6")]
		private void Photon.Realtime.IInRoomCallbacks.OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xDBFB78", Offset = "0xDBFB78", VA = "0xDBFB78", Slot = "7")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xDBFB88", Offset = "0xDBFB88", VA = "0xDBFB88", Slot = "8")]
		private void Photon.Realtime.IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xDBFB8C", Offset = "0xDBFB8C", VA = "0xDBFB8C", Slot = "9")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xDBFB90", Offset = "0xDBFB90", VA = "0xDBFB90", Slot = "10")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnCreatedRoom()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xDBFB94", Offset = "0xDBFB94", VA = "0xDBFB94", Slot = "11")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xDBFB98", Offset = "0xDBFB98", VA = "0xDBFB98", Slot = "12")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xDBFB9C", Offset = "0xDBFB9C", VA = "0xDBFB9C", Slot = "13")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xDBFBA0", Offset = "0xDBFBA0", VA = "0xDBFBA0", Slot = "14")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xDBFBA4", Offset = "0xDBFBA4", VA = "0xDBFBA4", Slot = "15")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnLeftRoom()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xDBFC20", Offset = "0xDBFC20", VA = "0xDBFC20")]
		public DemoVoiceUI()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public struct MicRef
	{
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x0")]
		public Recorder.MicType MicType;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x10")]
		public int PhotonId;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xDBFE0C", Offset = "0xDBFE0C", VA = "0xDBFE0C")]
		public MicRef(string name, int id)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xDBFE40", Offset = "0xDBFE40", VA = "0xDBFE40")]
		public MicRef(string name)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xDBFE70", Offset = "0xDBFE70", VA = "0xDBFE70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	public class MicrophoneDropdownFiller : MonoBehaviour
	{
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x18")]
		private List<MicRef> micOptions;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown micDropdown;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Recorder recorder;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD35EF4", Offset = "0xD35EF4")]
		private GameObject refreshButton;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD35F40", Offset = "0xD35F40")]
		private GameObject toggleButton;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x40")]
		private Toggle photonToggle;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xDBFEC4", Offset = "0xDBFEC4", VA = "0xDBFEC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xDBFF60", Offset = "0xDBFF60", VA = "0xDBFF60")]
		private void SetupMicDropdown()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xDC01A4", Offset = "0xDC01A4", VA = "0xDC01A4")]
		private void MicDropdownValueChanged(MicRef mic)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xDC023C", Offset = "0xDC023C", VA = "0xDC023C")]
		private void SetCurrentValue()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xDC05E0", Offset = "0xDC05E0", VA = "0xDC05E0")]
		public void PhotonMicToggled(bool on)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xDBFF3C", Offset = "0xDBFF3C", VA = "0xDBFF3C")]
		public void RefreshMicrophones()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xDC0690", Offset = "0xDC0690", VA = "0xDC0690")]
		private void PhotonVoiceCreated()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xDC06B4", Offset = "0xDC06B4", VA = "0xDC06B4")]
		public MicrophoneDropdownFiller()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xDC06BC", Offset = "0xDC06BC", VA = "0xDC06BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD368B4", Offset = "0xD368B4")]
		private void <SetupMicDropdown>b__7_0(int <p0>)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public static class PhotonDemoExtensions
	{
		[Token(Token = "0x40001C0")]
		internal const string IS_MUTED_PROPERTY_KEY = "mute";

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xDBE318", Offset = "0xDBE318", VA = "0xDBE318")]
		public static bool Mute(this Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xDBE3E8", Offset = "0xDBE3E8", VA = "0xDBE3E8")]
		public static bool Unmute(this Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xDBF758", Offset = "0xDBF758", VA = "0xDBF758")]
		public static bool IsMuted(this Player player)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD356B4", Offset = "0xD356B4")]
	public class RemoteSpeakerUI : MonoBehaviour, IInRoomCallbacks
	{
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text nameText;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Image remoteIsMuting;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image remoteIsTalking;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputField minDelaySoftInputField;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField maxDelaySoftInputField;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InputField maxDelayHardInputField;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text bufferLagText;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x50")]
		protected Speaker speaker;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x58")]
		protected VoiceConnection voiceConnection;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xDC0760", Offset = "0xDC0760", VA = "0xDC0760", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xDC0A68", Offset = "0xDC0A68", VA = "0xDC0A68")]
		private void OnMinDelaySoftChanged(string newMinDelaySoftString)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xDC0B44", Offset = "0xDC0B44", VA = "0xDC0B44")]
		private void OnMaxDelaySoftChanged(string newMaxDelaySoftString)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xDC0C1C", Offset = "0xDC0C1C", VA = "0xDC0C1C")]
		private void OnMaxDelayHardChanged(string newMaxDelayHardString)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xDC0CF4", Offset = "0xDC0CF4", VA = "0xDC0CF4")]
		private void Update()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xDC0DD0", Offset = "0xDC0DD0", VA = "0xDC0DD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xDC0940", Offset = "0xDC0940", VA = "0xDC0940")]
		private void SetNickname()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xDC0A28", Offset = "0xDC0A28", VA = "0xDC0A28")]
		private void SetMutedState()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xDC0E0C", Offset = "0xDC0E0C", VA = "0xDC0E0C", Slot = "10")]
		protected virtual void SetMutedState(bool isMuted)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xDC0E2C", Offset = "0xDC0E2C", VA = "0xDC0E2C", Slot = "11")]
		protected virtual void OnActorPropertiesChanged(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xDC0E88", Offset = "0xDC0E88", VA = "0xDC0E88", Slot = "12")]
		public virtual void Init(VoiceConnection vC)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xDC0ED4", Offset = "0xDC0ED4", VA = "0xDC0ED4", Slot = "4")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xDC0ED8", Offset = "0xDC0ED8", VA = "0xDC0ED8", Slot = "5")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xDC0EDC", Offset = "0xDC0EDC", VA = "0xDC0EDC", Slot = "6")]
		private void Photon.Realtime.IInRoomCallbacks.OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xDC0EE0", Offset = "0xDC0EE0", VA = "0xDC0EE0", Slot = "7")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xDC0EEC", Offset = "0xDC0EEC", VA = "0xDC0EEC", Slot = "8")]
		private void Photon.Realtime.IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xDC0EF0", Offset = "0xDC0EF0", VA = "0xDC0EF0")]
		public RemoteSpeakerUI()
		{
		}
	}
}
namespace Photon.Realtime.Demo
{
	[Token(Token = "0x2000050")]
	public class ConnectAndJoinRandomLb : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks
	{
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppSettings appSettings;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x20")]
		private LoadBalancingClient lbc;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x28")]
		private ConnectionHandler ch;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x30")]
		public Text StateUiText;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xDBC278", Offset = "0xDBC278", VA = "0xDBC278")]
		public void Start()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xDBC408", Offset = "0xDBC408", VA = "0xDBC408")]
		public void Update()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xDBC544", Offset = "0xDBC544", VA = "0xDBC544", Slot = "4")]
		public void OnConnected()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xDBC548", Offset = "0xDBC548", VA = "0xDBC548", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xDBC5D0", Offset = "0xDBC5D0", VA = "0xDBC5D0", Slot = "6")]
		public void OnDisconnected(DisconnectCause cause)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xDBC68C", Offset = "0xDBC68C", VA = "0xDBC68C", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xDBC690", Offset = "0xDBC690", VA = "0xDBC690", Slot = "9")]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xDBC694", Offset = "0xDBC694", VA = "0xDBC694", Slot = "7")]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xDBC760", Offset = "0xDBC760", VA = "0xDBC760", Slot = "19")]
		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xDBC764", Offset = "0xDBC764", VA = "0xDBC764", Slot = "20")]
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xDBC768", Offset = "0xDBC768", VA = "0xDBC768", Slot = "17")]
		public void OnJoinedLobby()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xDBC76C", Offset = "0xDBC76C", VA = "0xDBC76C", Slot = "18")]
		public void OnLeftLobby()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xDBC770", Offset = "0xDBC770", VA = "0xDBC770", Slot = "10")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xDBC774", Offset = "0xDBC774", VA = "0xDBC774", Slot = "11")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xDBC778", Offset = "0xDBC778", VA = "0xDBC778", Slot = "12")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xDBC77C", Offset = "0xDBC77C", VA = "0xDBC77C", Slot = "13")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xDBC7E8", Offset = "0xDBC7E8", VA = "0xDBC7E8", Slot = "14")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xDBC7EC", Offset = "0xDBC7EC", VA = "0xDBC7EC", Slot = "15")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xDBC894", Offset = "0xDBC894", VA = "0xDBC894", Slot = "16")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xDBC898", Offset = "0xDBC898", VA = "0xDBC898")]
		private void OnRegionPingCompleted(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xDBC99C", Offset = "0xDBC99C", VA = "0xDBC99C")]
		public ConnectAndJoinRandomLb()
		{
		}
	}
}
namespace Photon.Chat.UtilityScripts
{
	[Token(Token = "0x2000051")]
	public class EventSystemSpawner : MonoBehaviour
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xDBBB58", Offset = "0xDBBB58", VA = "0xDBBB58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xDBBC34", Offset = "0xDBBC34", VA = "0xDBBC34")]
		public EventSystemSpawner()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class OnStartDelete : MonoBehaviour
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xDBBC3C", Offset = "0xDBBC3C", VA = "0xDBBC3C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xDBBCB8", Offset = "0xDBBCB8", VA = "0xDBBCB8")]
		public OnStartDelete()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD35718", Offset = "0xD35718")]
	public class TextButtonTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x20")]
		public Selectable Selectable;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x28")]
		public Color NormalColor;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x38")]
		public Color HoverColor;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xDBBCC0", Offset = "0xDBBCC0", VA = "0xDBBCC0")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xDBBD20", Offset = "0xDBBD20", VA = "0xDBBD20")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xDBBD50", Offset = "0xDBBD50", VA = "0xDBBD50")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xDBBD80", Offset = "0xDBBD80", VA = "0xDBBD80", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xDBBE40", Offset = "0xDBBE40", VA = "0xDBBE40", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xDBBF00", Offset = "0xDBBF00", VA = "0xDBBF00")]
		public TextButtonTransition()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xD3577C", Offset = "0xD3577C")]
	public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x18")]
		public Toggle toggle;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x20")]
		private Text _text;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x28")]
		public Color NormalOnColor;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x38")]
		public Color NormalOffColor;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x48")]
		public Color HoverOnColor;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x58")]
		public Color HoverOffColor;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x68")]
		private bool isHover;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xDBBF44", Offset = "0xDBBF44", VA = "0xDBBF44")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xDBC084", Offset = "0xDBC084", VA = "0xDBC084")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xDBC020", Offset = "0xDBC020", VA = "0xDBC020")]
		public void OnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xDBC128", Offset = "0xDBC128", VA = "0xDBC128", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xDBC1A0", Offset = "0xDBC1A0", VA = "0xDBC1A0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xDBC214", Offset = "0xDBC214", VA = "0xDBC214")]
		public TextToggleIsOnTransition()
		{
		}
	}
}
