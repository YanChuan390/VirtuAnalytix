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
	[Address(RVA = "0xC691C4", Offset = "0xC691C4", VA = "0xC691C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC692EC", Offset = "0xC692EC", VA = "0xC692EC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xC69414", Offset = "0xC69414", VA = "0xC69414")]
	private void OnOnlineCheckComplete(bool isConnected, NetworkReachability networkReachability)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xC6974C", Offset = "0xC6974C", VA = "0xC6974C")]
	private void OnPermissionCheckComplete()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xC696B4", Offset = "0xC696B4", VA = "0xC696B4")]
	private void TryLoadScene()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xC6997C", Offset = "0xC6997C", VA = "0xC6997C")]
	public InitializationSceneController()
	{
	}
}
[Token(Token = "0x2000004")]
public class OculusBlockListTesting : MonoBehaviour
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xC699B0", Offset = "0xC699B0", VA = "0xC699B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xC69A78", Offset = "0xC69A78", VA = "0xC69A78")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC69BC0", Offset = "0xC69BC0", VA = "0xC69BC0")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xC69D24", Offset = "0xC69D24", VA = "0xC69D24")]
	private void GetBlockedUsersCallback(Message<BlockedUserList> message)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xC69E84", Offset = "0xC69E84", VA = "0xC69E84")]
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
	[Address(RVA = "0xC69E8C", Offset = "0xC69E8C", VA = "0xC69E8C")]
	public string GetUrl()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xC69F04", Offset = "0xC69F04", VA = "0xC69F04")]
	public string GetSubdomain()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xC69F64", Offset = "0xC69F64", VA = "0xC69F64")]
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
	[Address(RVA = "0xC69F6C", Offset = "0xC69F6C", VA = "0xC69F6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xC69FA4", Offset = "0xC69FA4", VA = "0xC69FA4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xC6A018", Offset = "0xC6A018", VA = "0xC6A018")]
	private Vector3 GetClosestPointOnCircle()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xC6A220", Offset = "0xC6A220", VA = "0xC6A220")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xC6A44C", Offset = "0xC6A44C", VA = "0xC6A44C")]
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
	[Address(RVA = "0xC6A454", Offset = "0xC6A454", VA = "0xC6A454")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xC6A64C", Offset = "0xC6A64C", VA = "0xC6A64C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xC6A590", Offset = "0xC6A590", VA = "0xC6A590")]
	public void QueuePermissionRequest(string perm)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xC6A650", Offset = "0xC6A650", VA = "0xC6A650")]
	private void Permission_Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xC6AB18", Offset = "0xC6AB18", VA = "0xC6AB18")]
	private void OnPermissionGranted(string permission)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xC6ABDC", Offset = "0xC6ABDC", VA = "0xC6ABDC")]
	private void OnPermissionDenied(string permission)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xC6ACA0", Offset = "0xC6ACA0", VA = "0xC6ACA0")]
	private void OnPermissionDeniedAndDontAskAgain(string permission)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xC6AD64", Offset = "0xC6AD64", VA = "0xC6AD64")]
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
	[Address(RVA = "0xC6AE24", Offset = "0xC6AE24", VA = "0xC6AE24")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xC6AFCC", Offset = "0xC6AFCC", VA = "0xC6AFCC")]
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
	[Address(RVA = "0xC6AFD4", Offset = "0xC6AFD4", VA = "0xC6AFD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xC6B11C", Offset = "0xC6B11C", VA = "0xC6B11C")]
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
	[Address(RVA = "0xC6B124", Offset = "0xC6B124", VA = "0xC6B124")]
	private void Update()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xC6B248", Offset = "0xC6B248", VA = "0xC6B248")]
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
			[Address(RVA = "0xC6BDF8", Offset = "0xC6BDF8", VA = "0xC6BDF8", Slot = "4")]
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
			[Address(RVA = "0xC6BE40", Offset = "0xC6BE40", VA = "0xC6BE40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xC6B498", Offset = "0xC6B498", VA = "0xC6B498")]
		[DebuggerHidden]
		public <RaiseCreateAvatarEvent>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xC6BA00", Offset = "0xC6BA00", VA = "0xC6BA00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xC6BA04", Offset = "0xC6BA04", VA = "0xC6BA04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xC6BE00", Offset = "0xC6BE00", VA = "0xC6BE00", Slot = "8")]
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
	[Address(RVA = "0xC6B250", Offset = "0xC6B250", VA = "0xC6B250", Slot = "27")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xC6B2A8", Offset = "0xC6B2A8", VA = "0xC6B2A8", Slot = "28")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xC6B300", Offset = "0xC6B300", VA = "0xC6B300")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xC6B354", Offset = "0xC6B354", VA = "0xC6B354")]
	private void RejoinRoom()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xC6B430", Offset = "0xC6B430", VA = "0xC6B430")]
	[IteratorStateMachine(typeof(<RaiseCreateAvatarEvent>d__9))]
	private IEnumerator RaiseCreateAvatarEvent()
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xC6B4C0", Offset = "0xC6B4C0", VA = "0xC6B4C0")]
	private void SetupAvatar(object[] instantiationData, int senderId)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xC6B6B4", Offset = "0xC6B6B4", VA = "0xC6B6B4", Slot = "4")]
	public void OnConnected()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xC6B71C", Offset = "0xC6B71C", VA = "0xC6B71C", Slot = "5")]
	public void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xC6B7F4", Offset = "0xC6B7F4", VA = "0xC6B7F4", Slot = "6")]
	public void OnDisconnected(DisconnectCause cause)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xC6B7F8", Offset = "0xC6B7F8", VA = "0xC6B7F8", Slot = "7")]
	public void OnRegionListReceived(RegionHandler regionHandler)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xC6B7FC", Offset = "0xC6B7FC", VA = "0xC6B7FC", Slot = "8")]
	public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xC6B800", Offset = "0xC6B800", VA = "0xC6B800", Slot = "9")]
	public void OnCustomAuthenticationFailed(string debugMessage)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xC6B804", Offset = "0xC6B804", VA = "0xC6B804", Slot = "10")]
	public void OnFriendListUpdate(List<FriendInfo> friendList)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xC6B808", Offset = "0xC6B808", VA = "0xC6B808", Slot = "11")]
	public void OnCreatedRoom()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xC6B80C", Offset = "0xC6B80C", VA = "0xC6B80C", Slot = "12")]
	public void OnCreateRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xC6B810", Offset = "0xC6B810", VA = "0xC6B810", Slot = "13")]
	public void OnJoinedRoom()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xC6B830", Offset = "0xC6B830", VA = "0xC6B830", Slot = "14")]
	public void OnJoinRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xC6B834", Offset = "0xC6B834", VA = "0xC6B834", Slot = "15")]
	public void OnJoinRandomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xC6B838", Offset = "0xC6B838", VA = "0xC6B838", Slot = "16")]
	public void OnLeftRoom()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xC6B83C", Offset = "0xC6B83C", VA = "0xC6B83C", Slot = "17")]
	public void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xC6B840", Offset = "0xC6B840", VA = "0xC6B840", Slot = "18")]
	public void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xC6B844", Offset = "0xC6B844", VA = "0xC6B844", Slot = "19")]
	public void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xC6B848", Offset = "0xC6B848", VA = "0xC6B848", Slot = "20")]
	public void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xC6B84C", Offset = "0xC6B84C", VA = "0xC6B84C", Slot = "21")]
	public void OnMasterClientSwitched(Player newMasterClient)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xC6B850", Offset = "0xC6B850", VA = "0xC6B850", Slot = "22")]
	public void OnJoinedLobby()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xC6B928", Offset = "0xC6B928", VA = "0xC6B928", Slot = "23")]
	public void OnLeftLobby()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xC6B92C", Offset = "0xC6B92C", VA = "0xC6B92C", Slot = "24")]
	public void OnRoomListUpdate(List<RoomInfo> roomList)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xC6B930", Offset = "0xC6B930", VA = "0xC6B930", Slot = "25")]
	public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xC6B934", Offset = "0xC6B934", VA = "0xC6B934", Slot = "26")]
	public void OnEvent(EventData photonEvent)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xC6B9F8", Offset = "0xC6B9F8", VA = "0xC6B9F8")]
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
	[Address(RVA = "0xC6BE48", Offset = "0xC6BE48", VA = "0xC6BE48")]
	private void Start()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xC6C0E0", Offset = "0xC6C0E0", VA = "0xC6C0E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xC6C10C", Offset = "0xC6C10C", VA = "0xC6C10C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xC6C1E0", Offset = "0xC6C1E0", VA = "0xC6C1E0")]
	private void OnAvatarUrlReceived(string avatarUrl)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xC6C338", Offset = "0xC6C338", VA = "0xC6C338")]
	public void SetWebViewVisibility(bool visible)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xC6C368", Offset = "0xC6C368", VA = "0xC6C368")]
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
	[Address(RVA = "0xC6BFCC", Offset = "0xC6BFCC", VA = "0xC6BFCC")]
	public void Initialize(BaseWebViewPrefab prefab)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xC6C284", Offset = "0xC6C284", VA = "0xC6C284")]
	public void Reload()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xC6C87C", Offset = "0xC6C87C", VA = "0xC6C87C")]
	private void OnLoadProgressChanged(object sender, ProgressChangedEventArgs args)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xC6CBDC", Offset = "0xC6CBDC", VA = "0xC6CBDC")]
	private void OnJsExecuted(string result)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xC6CC94", Offset = "0xC6CC94", VA = "0xC6CC94")]
	private void OnMessageReceived(object sender, EventArgs<string> args)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xC6BFC4", Offset = "0xC6BFC4", VA = "0xC6BFC4")]
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
			[Address(RVA = "0xC6E5B4", Offset = "0xC6E5B4", VA = "0xC6E5B4", Slot = "4")]
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
			[Address(RVA = "0xC6E5FC", Offset = "0xC6E5FC", VA = "0xC6E5FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xC6D3F0", Offset = "0xC6D3F0", VA = "0xC6D3F0")]
		[DebuggerHidden]
		public <ParseDepthData>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xC6DCA4", Offset = "0xC6DCA4", VA = "0xC6DCA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xC6DCA8", Offset = "0xC6DCA8", VA = "0xC6DCA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xC6E5BC", Offset = "0xC6E5BC", VA = "0xC6E5BC", Slot = "8")]
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
	[Address(RVA = "0xC6D120", Offset = "0xC6D120", VA = "0xC6D120")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xC6D14C", Offset = "0xC6D14C", VA = "0xC6D14C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xC6D2C8", Offset = "0xC6D2C8", VA = "0xC6D2C8")]
	private void FinishedLoadingLocationHandler()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xC6D350", Offset = "0xC6D350", VA = "0xC6D350")]
	private void TryParseDepthData()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xC6D374", Offset = "0xC6D374", VA = "0xC6D374")]
	[IteratorStateMachine(typeof(<ParseDepthData>d__9))]
	private IEnumerator<float> ParseDepthData(SvData panoData, Texture2D texture2D)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xC6D418", Offset = "0xC6D418", VA = "0xC6D418")]
	public static void ConvertToPLY(List<Vector3> pointsList, List<Color32> colorList, string fileName)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xC6DC34", Offset = "0xC6DC34", VA = "0xC6DC34")]
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
		[Address(RVA = "0xC6E658", Offset = "0xC6E658", VA = "0xC6E658")]
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
			[Address(RVA = "0xC6E6A8", Offset = "0xC6E6A8", VA = "0xC6E6A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public UIGradientBlendMode BlendMode
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xC6E758", Offset = "0xC6E758", VA = "0xC6E758")]
			get
			{
				return default(UIGradientBlendMode);
			}
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xC6E760", Offset = "0xC6E760", VA = "0xC6E760")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float Intensity
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xC6E80C", Offset = "0xC6E80C", VA = "0xC6E80C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xC6E814", Offset = "0xC6E814", VA = "0xC6E814")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public UIGradientType GradientType
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xC6E830", Offset = "0xC6E830", VA = "0xC6E830")]
			get
			{
				return default(UIGradientType);
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xC6E838", Offset = "0xC6E838", VA = "0xC6E838")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Color LinearColor1
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xC6E840", Offset = "0xC6E840", VA = "0xC6E840")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xC6E84C", Offset = "0xC6E84C", VA = "0xC6E84C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Color LinearColor2
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xC6E858", Offset = "0xC6E858", VA = "0xC6E858")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0xC6E864", Offset = "0xC6E864", VA = "0xC6E864")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Color CornerColorUpperLeft
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xC6E870", Offset = "0xC6E870", VA = "0xC6E870")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xC6E87C", Offset = "0xC6E87C", VA = "0xC6E87C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color CornerColorUpperRight
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xC6E888", Offset = "0xC6E888", VA = "0xC6E888")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xC6E894", Offset = "0xC6E894", VA = "0xC6E894")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Color CornerColorLowerRight
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xC6E8A0", Offset = "0xC6E8A0", VA = "0xC6E8A0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xC6E8AC", Offset = "0xC6E8AC", VA = "0xC6E8AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Color CornerColorLowerLeft
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xC6E8B8", Offset = "0xC6E8B8", VA = "0xC6E8B8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xC6E8C4", Offset = "0xC6E8C4", VA = "0xC6E8C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float Angle
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xC6E8D0", Offset = "0xC6E8D0", VA = "0xC6E8D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xC6E8D8", Offset = "0xC6E8D8", VA = "0xC6E8D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Gradient LinearGradient
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xC6E918", Offset = "0xC6E918", VA = "0xC6E918")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xC6E920", Offset = "0xC6E920", VA = "0xC6E920")]
			set
			{
			}
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xC6E928", Offset = "0xC6E928", VA = "0xC6E928", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xC6EEB4", Offset = "0xC6EEB4", VA = "0xC6EEB4")]
		protected void CutMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xC71588", Offset = "0xC71588", VA = "0xC71588")]
		private UIVertex UIVertexLerp(UIVertex v1, UIVertex v2, float f)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xC6F880", Offset = "0xC6F880", VA = "0xC6F880")]
		private Vector2 GetCutDirection()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xC70038", Offset = "0xC70038", VA = "0xC70038")]
		private void CutTriangle(List<UIVertex> tris, int idx, List<UIVertex> list, Vector2 cutDirection, Vector2 point)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xC71A40", Offset = "0xC71A40", VA = "0xC71A40")]
		private bool IsOnLine(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xC71A00", Offset = "0xC71A00", VA = "0xC71A00")]
		private float OnLine(Vector2 p1, Vector2 p2, Vector2 o, Vector2 dir)
		{
			return default(float);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xC71A5C", Offset = "0xC71A5C", VA = "0xC71A5C")]
		private float ProjectedDistance(Vector2 p1, Vector2 p2, Vector2 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xC6F9A0", Offset = "0xC6F9A0", VA = "0xC6F9A0")]
		private Vector2 GetCutOrigin(float f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xC6F6A8", Offset = "0xC6F6A8", VA = "0xC6F6A8")]
		private Color BlendColor(Color c1, Color c2, UIGradientBlendMode mode, float intensity)
		{
			return default(Color);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xC6F4FC", Offset = "0xC6F4FC", VA = "0xC6F4FC")]
		private Vector2 RotateNormalizedPosition(Vector2 normalizedPosition, float angle)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xC6E768", Offset = "0xC6E768", VA = "0xC6E768")]
		public void ForceUpdateGraphic()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xC6F600", Offset = "0xC6F600", VA = "0xC6F600")]
		private Color GetColorInGradient(Color ul, Color ur, Color lr, Color ll, Vector2 normalizedPosition)
		{
			return default(Color);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xC71C4C", Offset = "0xC71C4C", VA = "0xC71C4C")]
		public UIGradient()
		{
		}
	}
}
