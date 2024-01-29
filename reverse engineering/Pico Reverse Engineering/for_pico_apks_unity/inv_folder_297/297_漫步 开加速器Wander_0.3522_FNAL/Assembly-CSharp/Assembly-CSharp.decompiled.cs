using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Crosstales.OnlineCheck;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Oculus.Avatar2;
using Oculus.Platform;
using Oculus.Platform.Models;
using Pcx;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Vuplex.WebView;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public enum SupportedLanguages
{
	[Token(Token = "0x4000002")]
	Chinese = 6,
	[Token(Token = "0x4000003")]
	English = 10,
	[Token(Token = "0x4000004")]
	French = 14,
	[Token(Token = "0x4000005")]
	German = 15,
	[Token(Token = "0x4000006")]
	Italian = 21,
	[Token(Token = "0x4000007")]
	Japanese = 22,
	[Token(Token = "0x4000008")]
	Korean = 23,
	[Token(Token = "0x4000009")]
	Spanish = 34
}
[Token(Token = "0x2000003")]
public class InitializationSceneController : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x18")]
	public OnlineCheck m_OnlineCheck;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x20")]
	public WanderPermissionsController m_PermissionsController;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_NetworkErrorPanel;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x30")]
	public TMP_Text m_NetworkErrorText;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x38")]
	public TMP_Text m_NetworkErrorSubText;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x40")]
	private bool _PermissionChecksComplete;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x41")]
	private bool _OnlineCheckComplete;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x42")]
	private bool _SceneLoadingStarted;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xC67784", Offset = "0xC67784", VA = "0xC67784")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC678AC", Offset = "0xC678AC", VA = "0xC678AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xC679D4", Offset = "0xC679D4", VA = "0xC679D4")]
	private void OnOnlineCheckComplete(bool isConnected, NetworkReachability networkReachability)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xC67D0C", Offset = "0xC67D0C", VA = "0xC67D0C")]
	private void OnPermissionCheckComplete()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xC67C74", Offset = "0xC67C74", VA = "0xC67C74")]
	private void TryLoadScene()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xC67F3C", Offset = "0xC67F3C", VA = "0xC67F3C")]
	public InitializationSceneController()
	{
	}
}
[Token(Token = "0x2000004")]
public class OculusBlockListTesting : MonoBehaviour
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xC67F70", Offset = "0xC67F70", VA = "0xC67F70")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xC68038", Offset = "0xC68038", VA = "0xC68038")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC68180", Offset = "0xC68180", VA = "0xC68180")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xC682E4", Offset = "0xC682E4", VA = "0xC682E4")]
	private void GetBlockedUsersCallback(Message<BlockedUserList> message)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xC68444", Offset = "0xC68444", VA = "0xC68444")]
	public OculusBlockListTesting()
	{
	}
}
[Token(Token = "0x2000005")]
public class PartnerSO : ScriptableObject
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	public string Subdomain;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xC6844C", Offset = "0xC6844C", VA = "0xC6844C")]
	public string GetUrl()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xC684C4", Offset = "0xC684C4", VA = "0xC684C4")]
	public string GetSubdomain()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xC68524", Offset = "0xC68524", VA = "0xC68524")]
	public PartnerSO()
	{
	}
}
[Token(Token = "0x2000006")]
public class StayInFrontOfCamera : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x18")]
	public float m_TargetDistanceFromCamera;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x1C")]
	public float m_StartMovingDistanceThreshold;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x20")]
	public float m_StopMovingDistanceThreshold;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x24")]
	public float m_MoveSpeed;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x28")]
	private Transform _CameraTransform;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x30")]
	private Transform _MovingTransform;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x38")]
	private bool _IsMoving;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 _TargetPosition;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xC6852C", Offset = "0xC6852C", VA = "0xC6852C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xC68564", Offset = "0xC68564", VA = "0xC68564")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xC685D8", Offset = "0xC685D8", VA = "0xC685D8")]
	private Vector3 GetClosestPointOnCircle()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xC687E0", Offset = "0xC687E0", VA = "0xC687E0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xC68A0C", Offset = "0xC68A0C", VA = "0xC68A0C")]
	public StayInFrontOfCamera()
	{
	}
}
[Token(Token = "0x2000007")]
public class WanderPermissionsController : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	private enum PermissionState
	{
		[Token(Token = "0x4000021")]
		None,
		[Token(Token = "0x4000022")]
		Requesting,
		[Token(Token = "0x4000023")]
		Granted,
		[Token(Token = "0x4000024")]
		Denied,
		[Token(Token = "0x4000025")]
		DeniedNoAsk
	}

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	public Action m_OnPermissionCheckComplete;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	private readonly Queue<string> _PermissionQueue;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x28")]
	private readonly Dictionary<string, PermissionState> _PermissionCache;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	private bool _PermissionManagerWaiting;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x31")]
	private bool _PermissionCheckCompleteInvoked;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xC68A14", Offset = "0xC68A14", VA = "0xC68A14")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xC68B18", Offset = "0xC68B18", VA = "0xC68B18")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xC68A5C", Offset = "0xC68A5C", VA = "0xC68A5C")]
	public void QueuePermissionRequest(string perm)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xC68B1C", Offset = "0xC68B1C", VA = "0xC68B1C")]
	private void Permission_Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xC68FE4", Offset = "0xC68FE4", VA = "0xC68FE4")]
	private void OnPermissionGranted(string permission)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xC690A8", Offset = "0xC690A8", VA = "0xC690A8")]
	private void OnPermissionDenied(string permission)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xC6916C", Offset = "0xC6916C", VA = "0xC6916C")]
	private void OnPermissionDeniedAndDontAskAgain(string permission)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xC69230", Offset = "0xC69230", VA = "0xC69230")]
	public WanderPermissionsController()
	{
	}
}
[Token(Token = "0x2000009")]
public class PortalCamera : MonoBehaviour
{
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x18")]
	public Transform playerCamera;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x20")]
	public Transform portal;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x28")]
	public Transform otherPortal;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xC692F0", Offset = "0xC692F0", VA = "0xC692F0")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xC69498", Offset = "0xC69498", VA = "0xC69498")]
	public PortalCamera()
	{
	}
}
[Token(Token = "0x200000A")]
public class PortalTextureSetup : MonoBehaviour
{
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x18")]
	public Camera _Camera;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x20")]
	public Renderer _PortalRenderer;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xC694A0", Offset = "0xC694A0", VA = "0xC694A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xC695E8", Offset = "0xC695E8", VA = "0xC695E8")]
	public PortalTextureSetup()
	{
	}
}
[Token(Token = "0x200000B")]
public class RotationScript : MonoBehaviour
{
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xC695F0", Offset = "0xC695F0", VA = "0xC695F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xC69714", Offset = "0xC69714", VA = "0xC69714")]
	public RotationScript()
	{
	}
}
[Token(Token = "0x200000C")]
public class OculusAvatarsTestNetworkController : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, IInRoomCallbacks, ILobbyCallbacks, IOnEventCallback
{
	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <RaiseCreateAvatarEvent>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x20")]
		public OculusAvatarsTestNetworkController <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xC6A2C4", Offset = "0xC6A2C4", VA = "0xC6A2C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xC6A30C", Offset = "0xC6A30C", VA = "0xC6A30C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xC69964", Offset = "0xC69964", VA = "0xC69964")]
		[DebuggerHidden]
		public <RaiseCreateAvatarEvent>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xC69ECC", Offset = "0xC69ECC", VA = "0xC69ECC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xC69ED0", Offset = "0xC69ED0", VA = "0xC69ED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xC6A2CC", Offset = "0xC6A2CC", VA = "0xC6A2CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject m_LocalAvatarPrefab;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_RemoteAvatarPrefab;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x28")]
	public OvrAvatarBodyTrackingBehavior m_BodyTrackingBehavior;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x30")]
	public OvrAvatarLipSyncBehavior m_LipSyncBehavior;

	[NonSerialized]
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x38")]
	public OvrAvatarEntity m_LocalAvatar;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xC6971C", Offset = "0xC6971C", VA = "0xC6971C", Slot = "27")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xC69774", Offset = "0xC69774", VA = "0xC69774", Slot = "28")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xC697CC", Offset = "0xC697CC", VA = "0xC697CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xC69820", Offset = "0xC69820", VA = "0xC69820")]
	private void RejoinRoom()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xC698FC", Offset = "0xC698FC", VA = "0xC698FC")]
	[IteratorStateMachine(typeof(<RaiseCreateAvatarEvent>d__9))]
	private IEnumerator RaiseCreateAvatarEvent()
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xC6998C", Offset = "0xC6998C", VA = "0xC6998C")]
	private void SetupAvatar(object[] instantiationData, int senderId)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xC69B80", Offset = "0xC69B80", VA = "0xC69B80", Slot = "4")]
	public void OnConnected()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xC69BE8", Offset = "0xC69BE8", VA = "0xC69BE8", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xC69CC0", Offset = "0xC69CC0", VA = "0xC69CC0", Slot = "6")]
	public void OnDisconnected(DisconnectCause cause)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xC69CC4", Offset = "0xC69CC4", VA = "0xC69CC4", Slot = "7")]
	public void OnRegionListReceived(RegionHandler regionHandler)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xC69CC8", Offset = "0xC69CC8", VA = "0xC69CC8", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xC69CCC", Offset = "0xC69CCC", VA = "0xC69CCC", Slot = "9")]
	public void OnCustomAuthenticationFailed(string debugMessage)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xC69CD0", Offset = "0xC69CD0", VA = "0xC69CD0", Slot = "10")]
	public void OnFriendListUpdate(List<FriendInfo> friendList)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xC69CD4", Offset = "0xC69CD4", VA = "0xC69CD4", Slot = "11")]
	public void OnCreatedRoom()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xC69CD8", Offset = "0xC69CD8", VA = "0xC69CD8", Slot = "12")]
	public void OnCreateRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xC69CDC", Offset = "0xC69CDC", VA = "0xC69CDC", Slot = "13")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xC69CFC", Offset = "0xC69CFC", VA = "0xC69CFC", Slot = "14")]
	public void OnJoinRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xC69D00", Offset = "0xC69D00", VA = "0xC69D00", Slot = "15")]
	public void OnJoinRandomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xC69D04", Offset = "0xC69D04", VA = "0xC69D04", Slot = "16")]
	public void OnLeftRoom()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xC69D08", Offset = "0xC69D08", VA = "0xC69D08", Slot = "17")]
	public void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xC69D0C", Offset = "0xC69D0C", VA = "0xC69D0C", Slot = "18")]
	public void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xC69D10", Offset = "0xC69D10", VA = "0xC69D10", Slot = "19")]
	public void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xC69D14", Offset = "0xC69D14", VA = "0xC69D14", Slot = "20")]
	public void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xC69D18", Offset = "0xC69D18", VA = "0xC69D18", Slot = "21")]
	public void OnMasterClientSwitched(Player newMasterClient)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xC69D1C", Offset = "0xC69D1C", VA = "0xC69D1C", Slot = "22")]
	public void OnJoinedLobby()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xC69DF4", Offset = "0xC69DF4", VA = "0xC69DF4", Slot = "23")]
	public void OnLeftLobby()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xC69DF8", Offset = "0xC69DF8", VA = "0xC69DF8", Slot = "24")]
	public void OnRoomListUpdate(List<RoomInfo> roomList)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xC69DFC", Offset = "0xC69DFC", VA = "0xC69DFC", Slot = "25")]
	public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xC69E00", Offset = "0xC69E00", VA = "0xC69E00", Slot = "26")]
	public void OnEvent(EventData photonEvent)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xC69EC4", Offset = "0xC69EC4", VA = "0xC69EC4")]
	public OculusAvatarsTestNetworkController()
	{
	}
}
[Token(Token = "0x200000E")]
public struct WebMessage
{
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x0")]
	public string type;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x8")]
	public string source;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x10")]
	public string eventName;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<string, string> data;
}
[Token(Token = "0x200000F")]
public class ReadyPlayerMeWebView : MonoBehaviour
{
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x18")]
	private GameObject avatar;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x20")]
	private VuplexWebView vuplexWebView;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MultiplayerUserConfigurationPanel multiplayerUserConfigurationPanel;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BaseWebViewPrefab canvasWebView;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xC6A314", Offset = "0xC6A314", VA = "0xC6A314")]
	private void Start()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xC6A5AC", Offset = "0xC6A5AC", VA = "0xC6A5AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xC6A5D8", Offset = "0xC6A5D8", VA = "0xC6A5D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xC6A700", Offset = "0xC6A700", VA = "0xC6A700")]
	private void OnAvatarUrlReceived(string avatarUrl)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xC6A858", Offset = "0xC6A858", VA = "0xC6A858")]
	public void SetWebViewVisibility(bool visible)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xC6A888", Offset = "0xC6A888", VA = "0xC6A888")]
	public ReadyPlayerMeWebView()
	{
	}
}
[Token(Token = "0x2000010")]
public class VuplexWebView
{
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x10")]
	public BaseWebViewPrefab webView;

	[Token(Token = "0x400003D")]
	private const string DataUrlFieldName = "url";

	[Token(Token = "0x400003E")]
	private const string AvatarExportEventName = "v1.avatar.exported";

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x18")]
	public Action OnInitialized;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x20")]
	public Action<string> OnAvatarUrlReceived;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xC6A498", Offset = "0xC6A498", VA = "0xC6A498")]
	public void Initialize(BaseWebViewPrefab prefab)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xC6A7A4", Offset = "0xC6A7A4", VA = "0xC6A7A4")]
	public void Reload()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xC6AD9C", Offset = "0xC6AD9C", VA = "0xC6AD9C")]
	private void OnLoadProgressChanged(object sender, ProgressChangedEventArgs args)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xC6B0FC", Offset = "0xC6B0FC", VA = "0xC6B0FC")]
	private void OnJsExecuted(string result)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xC6B1B4", Offset = "0xC6B1B4", VA = "0xC6B1B4")]
	private void OnMessageReceived(object sender, EventArgs<string> args)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xC6A490", Offset = "0xC6A490", VA = "0xC6A490")]
	public VuplexWebView()
	{
	}
}
[Token(Token = "0x2000011")]
public class SvPointCloud : MonoBehaviour
{
	[Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class <ParseDepthData>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x18")]
		public SvPointCloud <>4__this;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x20")]
		public SvData panoData;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D texture2D;

		[Token(Token = "0x17000003")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xC6CAD4", Offset = "0xC6CAD4", VA = "0xC6CAD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xC6CB1C", Offset = "0xC6CB1C", VA = "0xC6CB1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xC6B910", Offset = "0xC6B910", VA = "0xC6B910")]
		[DebuggerHidden]
		public <ParseDepthData>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xC6C1C4", Offset = "0xC6C1C4", VA = "0xC6C1C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xC6C1C8", Offset = "0xC6C1C8", VA = "0xC6C1C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xC6CADC", Offset = "0xC6CADC", VA = "0xC6CADC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int BackgroundTex;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x18")]
	public PointCloudData m_Data;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	public PointCloudRenderer m_PointCloudRenderer;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x28")]
	private SvData _CurrentSvData;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D _CurrentTexture2D;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xC6B640", Offset = "0xC6B640", VA = "0xC6B640")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xC6B66C", Offset = "0xC6B66C", VA = "0xC6B66C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xC6B7E8", Offset = "0xC6B7E8", VA = "0xC6B7E8")]
	private void FinishedLoadingLocationHandler()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xC6B870", Offset = "0xC6B870", VA = "0xC6B870")]
	private void TryParseDepthData()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xC6B894", Offset = "0xC6B894", VA = "0xC6B894")]
	[IteratorStateMachine(typeof(<ParseDepthData>d__9))]
	private IEnumerator<float> ParseDepthData(SvData panoData, Texture2D texture2D)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xC6B938", Offset = "0xC6B938", VA = "0xC6B938")]
	public static void ConvertToPLY(List<Vector3> pointsList, List<Color32> colorList, string fileName)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xC6C154", Offset = "0xC6C154", VA = "0xC6C154")]
	public SvPointCloud()
	{
	}
}
namespace JoshH.Extensions
{
	[Token(Token = "0x2000013")]
	public static class Vector2Extension
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0xC6CB78", Offset = "0xC6CB78", VA = "0xC6CB78")]
		public static Vector2 Rotate(this Vector2 v, float degrees)
		{
			return default(Vector2);
		}
	}
}
namespace JoshH.UI
{
	[Token(Token = "0x2000014")]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Effects/UI Gradient")]
	public class UIGradient : BaseMeshEffect
	{
		[Token(Token = "0x2000015")]
		public enum UIGradientBlendMode
		{
			[Token(Token = "0x4000058")]
			Override,
			[Token(Token = "0x4000059")]
			Multiply
		}

		[Token(Token = "0x2000016")]
		public enum UIGradientType
		{
			[Token(Token = "0x400005B")]
			Linear,
			[Token(Token = "0x400005C")]
			Corner,
			[Token(Token = "0x400005D")]
			ComplexLinear
		}

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("How the gradient color will be blended with the graphics color.")]
		private UIGradientBlendMode blendMode;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		private float intensity;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIGradientType gradientType;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color linearColor1;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color linearColor2;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color cornerColorUpperLeft;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Color cornerColorUpperRight;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color cornerColorLowerRight;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Color cornerColorLowerLeft;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Gradient linearGradient;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Range(0f, 360f)]
		private float angle;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransform;

		[Token(Token = "0x17000005")]
		protected RectTransform rectTransform
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0xC6CBC8", Offset = "0xC6CBC8", VA = "0xC6CBC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public UIGradientBlendMode BlendMode
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xC6CC78", Offset = "0xC6CC78", VA = "0xC6CC78")]
			get
			{
				return default(UIGradientBlendMode);
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xC6CC80", Offset = "0xC6CC80", VA = "0xC6CC80")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float Intensity
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xC6CD2C", Offset = "0xC6CD2C", VA = "0xC6CD2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xC6CD34", Offset = "0xC6CD34", VA = "0xC6CD34")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public UIGradientType GradientType
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xC6CD50", Offset = "0xC6CD50", VA = "0xC6CD50")]
			get
			{
				return default(UIGradientType);
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xC6CD58", Offset = "0xC6CD58", VA = "0xC6CD58")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Color LinearColor1
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xC6CD60", Offset = "0xC6CD60", VA = "0xC6CD60")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xC6CD6C", Offset = "0xC6CD6C", VA = "0xC6CD6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Color LinearColor2
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xC6CD78", Offset = "0xC6CD78", VA = "0xC6CD78")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0xC6CD84", Offset = "0xC6CD84", VA = "0xC6CD84")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Color CornerColorUpperLeft
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xC6CD90", Offset = "0xC6CD90", VA = "0xC6CD90")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xC6CD9C", Offset = "0xC6CD9C", VA = "0xC6CD9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color CornerColorUpperRight
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xC6CDA8", Offset = "0xC6CDA8", VA = "0xC6CDA8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xC6CDB4", Offset = "0xC6CDB4", VA = "0xC6CDB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Color CornerColorLowerRight
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xC6CDC0", Offset = "0xC6CDC0", VA = "0xC6CDC0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xC6CDCC", Offset = "0xC6CDCC", VA = "0xC6CDCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Color CornerColorLowerLeft
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xC6CDD8", Offset = "0xC6CDD8", VA = "0xC6CDD8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xC6CDE4", Offset = "0xC6CDE4", VA = "0xC6CDE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float Angle
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xC6CDF0", Offset = "0xC6CDF0", VA = "0xC6CDF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xC6CDF8", Offset = "0xC6CDF8", VA = "0xC6CDF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Gradient LinearGradient
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xC6CE38", Offset = "0xC6CE38", VA = "0xC6CE38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xC6CE40", Offset = "0xC6CE40", VA = "0xC6CE40")]
			set
			{
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xC6CE48", Offset = "0xC6CE48", VA = "0xC6CE48", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xC6D3D4", Offset = "0xC6D3D4", VA = "0xC6D3D4")]
		protected void CutMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xC6FAA8", Offset = "0xC6FAA8", VA = "0xC6FAA8")]
		private UIVertex UIVertexLerp(UIVertex v1, UIVertex v2, float f)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xC6DDA0", Offset = "0xC6DDA0", VA = "0xC6DDA0")]
		private Vector2 GetCutDirection()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xC6E558", Offset = "0xC6E558", VA = "0xC6E558")]
		private void CutTriangle(List<UIVertex> tris, int idx, List<UIVertex> list, Vector2 cutDirection, Vector2 point)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xC6FF60", Offset = "0xC6FF60", VA = "0xC6FF60")]
		private bool IsOnLine(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xC6FF20", Offset = "0xC6FF20", VA = "0xC6FF20")]
		private float OnLine(Vector2 p1, Vector2 p2, Vector2 o, Vector2 dir)
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xC6FF7C", Offset = "0xC6FF7C", VA = "0xC6FF7C")]
		private float ProjectedDistance(Vector2 p1, Vector2 p2, Vector2 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xC6DEC0", Offset = "0xC6DEC0", VA = "0xC6DEC0")]
		private Vector2 GetCutOrigin(float f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xC6DBC8", Offset = "0xC6DBC8", VA = "0xC6DBC8")]
		private Color BlendColor(Color c1, Color c2, UIGradientBlendMode mode, float intensity)
		{
			return default(Color);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xC6DA1C", Offset = "0xC6DA1C", VA = "0xC6DA1C")]
		private Vector2 RotateNormalizedPosition(Vector2 normalizedPosition, float angle)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xC6CC88", Offset = "0xC6CC88", VA = "0xC6CC88")]
		public void ForceUpdateGraphic()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xC6DB20", Offset = "0xC6DB20", VA = "0xC6DB20")]
		private Color GetColorInGradient(Color ul, Color ur, Color lr, Color ll, Vector2 normalizedPosition)
		{
			return default(Color);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xC7016C", Offset = "0xC7016C", VA = "0xC7016C")]
		public UIGradient()
		{
		}
	}
}
