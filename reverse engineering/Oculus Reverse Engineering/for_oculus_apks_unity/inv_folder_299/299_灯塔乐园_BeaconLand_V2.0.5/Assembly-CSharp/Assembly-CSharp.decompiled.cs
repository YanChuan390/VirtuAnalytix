using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Facebook.WitAi;
using Facebook.WitAi.Lib;
using Il2CppDummyDll;
using Oculus.Platform;
using Oculus.Platform.Models;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MoveCamera : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float turnSpeed;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float panSpeed;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float zoomSpeed;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 mouseOrigin;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isPanning;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isRotating;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool isZooming;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x91C24C", Offset = "0x91C24C", VA = "0x91C24C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x91C588", Offset = "0x91C588", VA = "0x91C588")]
	public MoveCamera()
	{
	}
}
[Token(Token = "0x2000003")]
public class ModelCustomizer : MonoBehaviour
{
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x91B858", Offset = "0x91B858", VA = "0x91B858")]
	public ModelCustomizer()
	{
	}
}
[Token(Token = "0x2000004")]
public class ContinuousMovement : MonoBehaviour
{
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public XRNode inputSource;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float gravity;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask groundLayer;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float additionalHeight;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float fallingSpeed;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XRRig rig;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector2 inputAxis;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CharacterController character;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x75A5B8", Offset = "0x75A5B8", VA = "0x75A5B8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x75A644", Offset = "0x75A644", VA = "0x75A644")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x75A6D8", Offset = "0x75A6D8", VA = "0x75A6D8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x75A7F4", Offset = "0x75A7F4", VA = "0x75A7F4")]
	private void CapsuleFollowHeadet()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x75A8E0", Offset = "0x75A8E0", VA = "0x75A8E0")]
	private bool CheckifGrounded()
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x75A9F8", Offset = "0x75A9F8", VA = "0x75A9F8")]
	public ContinuousMovement()
	{
	}
}
[Token(Token = "0x2000005")]
public class HandPresence : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showController;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public InputDeviceCharacteristics controllerCharacteristics;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> controllerPrefabs;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject handModelPrefab;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private InputDevice targetDevice;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject spawnedController;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject spawnedHandModel;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x863D2C", Offset = "0x863D2C", VA = "0x863D2C")]
	private void Start()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x864194", Offset = "0x864194", VA = "0x864194")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x8641FC", Offset = "0x8641FC", VA = "0x8641FC")]
	public HandPresence()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x864204", Offset = "0x864204", VA = "0x864204")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470A04", Offset = "0x470A04")]
	private bool <Start>b__7_0(GameObject controller)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000006")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x7AB248", Offset = "0x7AB248", VA = "0x7AB248")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x7AB3AC", Offset = "0x7AB3AC", VA = "0x7AB3AC")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x7AB748", Offset = "0x7AB748", VA = "0x7AB748")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x7AB8EC", Offset = "0x7AB8EC", VA = "0x7AB8EC", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x7AB918", Offset = "0x7AB918", VA = "0x7AB918")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x2000007")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x7AFA4C", Offset = "0x7AFA4C", VA = "0x7AFA4C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x7AFAD4", Offset = "0x7AFAD4", VA = "0x7AFAD4")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x7AFC48", Offset = "0x7AFC48", VA = "0x7AFC48")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x2000008")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x17000001")]
	public bool IsVisible
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x85D828", Offset = "0x85D828", VA = "0x85D828")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x85D830", Offset = "0x85D830", VA = "0x85D830")]
		set
		{
		}
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x85D96C", Offset = "0x85D96C", VA = "0x85D96C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x85DB34", Offset = "0x85DB34", VA = "0x85DB34")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x85DB3C", Offset = "0x85DB3C", VA = "0x85DB3C")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x2000009")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x200000A")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x9AE944", Offset = "0x9AE944", VA = "0x9AE944")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000B")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46CC54", Offset = "0x46CC54")]
		public float FakeLatencyMax;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46CC6C", Offset = "0x46CC6C")]
		public float FakeLatencyMin;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46CC84", Offset = "0x46CC84")]
		public float LatencyWeight;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46CC9C", Offset = "0x46CC9C")]
		public int MaxSamples;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x9AE94C", Offset = "0x9AE94C", VA = "0x9AE94C")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x9AEA84", Offset = "0x9AEA84", VA = "0x9AEA84")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x7B3E60", Offset = "0x7B3E60", VA = "0x7B3E60")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x7B3FB8", Offset = "0x7B3FB8", VA = "0x7B3FB8")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x7B4398", Offset = "0x7B4398", VA = "0x7B4398")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x7B42E4", Offset = "0x7B42E4", VA = "0x7B42E4")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x7B46C8", Offset = "0x7B46C8", VA = "0x7B46C8")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x7B49A4", Offset = "0x7B49A4", VA = "0x7B49A4")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x200000C")]
public class P2PManager
{
	[Token(Token = "0x200000D")]
	private enum MessageType : byte
	{
		[Token(Token = "0x400002F")]
		Update = 1
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x7AC494", Offset = "0x7AC494", VA = "0x7AC494")]
	public P2PManager()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x7AC574", Offset = "0x7AC574", VA = "0x7AC574")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x7AC658", Offset = "0x7AC658", VA = "0x7AC658")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x7AC6D8", Offset = "0x7AC6D8", VA = "0x7AC6D8")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x7AC848", Offset = "0x7AC848", VA = "0x7AC848")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x7ACA88", Offset = "0x7ACA88", VA = "0x7ACA88")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x7ACE78", Offset = "0x7ACE78", VA = "0x7ACE78")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x7AD134", Offset = "0x7AD134", VA = "0x7AD134")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x7ACC54", Offset = "0x7ACC54", VA = "0x7ACC54")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x7AD068", Offset = "0x7AD068", VA = "0x7AD068")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x7ACD38", Offset = "0x7ACD38", VA = "0x7ACD38")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x7AD36C", Offset = "0x7AD36C", VA = "0x7AD36C")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x7ACC9C", Offset = "0x7ACC9C", VA = "0x7ACC9C")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x7AD0AC", Offset = "0x7AD0AC", VA = "0x7AD0AC")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x7ACDDC", Offset = "0x7ACDDC", VA = "0x7ACDDC")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x7AD3F4", Offset = "0x7AD3F4", VA = "0x7AD3F4")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x200000E")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x7AF618", Offset = "0x7AF618", VA = "0x7AF618", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x7AF65C", Offset = "0x7AF65C", VA = "0x7AF65C", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x7AF694", Offset = "0x7AF694", VA = "0x7AF694", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x7AF6BC", Offset = "0x7AF6BC", VA = "0x7AF6BC")]
	private void checkInput()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x7AF858", Offset = "0x7AF858", VA = "0x7AF858")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x7AF8D8", Offset = "0x7AF8D8", VA = "0x7AF8D8")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x7AF92C", Offset = "0x7AF92C", VA = "0x7AF92C")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x200000F")]
public class RemotePlayer
{
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x7B4A60", Offset = "0x7B4A60", VA = "0x7B4A60")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000010")]
public class RoomManager
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x7B4C98", Offset = "0x7B4C98", VA = "0x7B4C98")]
	public RoomManager()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x7B4D9C", Offset = "0x7B4D9C", VA = "0x7B4D9C")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x7B4F1C", Offset = "0x7B4F1C", VA = "0x7B4F1C")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x7B5058", Offset = "0x7B5058", VA = "0x7B5058")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x7B512C", Offset = "0x7B512C", VA = "0x7B512C")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x7B5268", Offset = "0x7B5268", VA = "0x7B5268")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x7B4F4C", Offset = "0x7B4F4C", VA = "0x7B4F4C")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x7B52F0", Offset = "0x7B52F0", VA = "0x7B52F0")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x7B5A9C", Offset = "0x7B5A9C", VA = "0x7B5A9C")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x7B5DF0", Offset = "0x7B5DF0", VA = "0x7B5DF0")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x7B5624", Offset = "0x7B5624", VA = "0x7B5624")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x2000011")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000012")]
	public enum State
	{
		[Token(Token = "0x4000067")]
		INITIALIZING,
		[Token(Token = "0x4000068")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x4000069")]
		CREATING_A_ROOM,
		[Token(Token = "0x400006A")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x400006B")]
		JOINING_A_ROOM,
		[Token(Token = "0x400006C")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x400006D")]
		LEAVING_A_ROOM,
		[Token(Token = "0x400006E")]
		SHUTDOWN
	}

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x17000002")]
	public static State CurrentState
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x893FB4", Offset = "0x893FB4", VA = "0x893FB4")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x17000003")]
	public static ulong MyID
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x894024", Offset = "0x894024", VA = "0x894024")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17000004")]
	public static string MyOculusID
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x894104", Offset = "0x894104", VA = "0x894104")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x891FBC", Offset = "0x891FBC", VA = "0x891FBC", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x892360", Offset = "0x892360", VA = "0x892360", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x892BAC", Offset = "0x892BAC", VA = "0x892BAC")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x892ECC", Offset = "0x892ECC", VA = "0x892ECC", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x892ED0", Offset = "0x892ED0", VA = "0x892ED0")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x892FF0", Offset = "0x892FF0", VA = "0x892FF0")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x893744", Offset = "0x893744", VA = "0x893744")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x893B38", Offset = "0x893B38", VA = "0x893B38")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x893D48", Offset = "0x893D48", VA = "0x893D48")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x893F48", Offset = "0x893F48", VA = "0x893F48")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x892758", Offset = "0x892758", VA = "0x892758")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x892D54", Offset = "0x892D54", VA = "0x892D54")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x89280C", Offset = "0x89280C", VA = "0x89280C")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x89422C", Offset = "0x89422C", VA = "0x89422C")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x8943A8", Offset = "0x8943A8", VA = "0x8943A8")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x89448C", Offset = "0x89448C", VA = "0x89448C")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x8945E8", Offset = "0x8945E8", VA = "0x8945E8")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x8946CC", Offset = "0x8946CC", VA = "0x8946CC")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x892E0C", Offset = "0x892E0C", VA = "0x892E0C")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x894C14", Offset = "0x894C14", VA = "0x894C14")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x894CA8", Offset = "0x894CA8", VA = "0x894CA8")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x894A00", Offset = "0x894A00", VA = "0x894A00")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x894F8C", Offset = "0x894F8C", VA = "0x894F8C")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x891F38", Offset = "0x891F38", VA = "0x891F38")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x470A14", Offset = "0x470A14")]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x8950D0", Offset = "0x8950D0", VA = "0x8950D0")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x8951AC", Offset = "0x8951AC", VA = "0x8951AC")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x2000013")]
public class VoipManager
{
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x892ACC", Offset = "0x892ACC", VA = "0x892ACC")]
	public VoipManager()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x894EB0", Offset = "0x894EB0", VA = "0x894EB0")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x893ECC", Offset = "0x893ECC", VA = "0x893ECC")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x8A09D0", Offset = "0x8A09D0", VA = "0x8A09D0")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x8A0B34", Offset = "0x8A0B34", VA = "0x8A0B34")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x2000014")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x85D4E4", Offset = "0x85D4E4", VA = "0x85D4E4")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x85D56C", Offset = "0x85D56C", VA = "0x85D56C")]
	private void Start()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x85D6E0", Offset = "0x85D6E0", VA = "0x85D6E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x85D744", Offset = "0x85D744", VA = "0x85D744")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x85D5A8", Offset = "0x85D5A8", VA = "0x85D5A8")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x85D808", Offset = "0x85D808", VA = "0x85D808")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x85D820", Offset = "0x85D820", VA = "0x85D820")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x2000015")]
public class AvatarLayer
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x74A3B4", Offset = "0x74A3B4", VA = "0x74A3B4")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class PacketRecordSettings
{
	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x7AD47C", Offset = "0x7AD47C", VA = "0x7AD47C")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x2000017")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x9ACF30", Offset = "0x9ACF30", VA = "0x9ACF30")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x2000019")]
	public enum HandType
	{
		[Token(Token = "0x40000D0")]
		Right,
		[Token(Token = "0x40000D1")]
		Left,
		[Token(Token = "0x40000D2")]
		Max
	}

	[Token(Token = "0x200001A")]
	public enum HandJoint
	{
		[Token(Token = "0x40000D4")]
		HandBase,
		[Token(Token = "0x40000D5")]
		IndexBase,
		[Token(Token = "0x40000D6")]
		IndexTip,
		[Token(Token = "0x40000D7")]
		ThumbBase,
		[Token(Token = "0x40000D8")]
		ThumbTip,
		[Token(Token = "0x40000D9")]
		Max
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C624", Offset = "0x46C624")]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x9ACEE0", Offset = "0x9ACEE0", VA = "0x9ACEE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x9ACF28", Offset = "0x9ACF28", VA = "0x9ACF28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x9ACD04", Offset = "0x9ACD04", VA = "0x9ACD04")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x9ACD30", Offset = "0x9ACD30", VA = "0x9ACD30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x9ACD34", Offset = "0x9ACD34", VA = "0x9ACD34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9ACEE8", Offset = "0x9ACEE8", VA = "0x9ACEE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46CCB4", Offset = "0x46CCB4")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46CCEC", Offset = "0x46CCEC")]
	public bool EnableBody;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46CD24", Offset = "0x46CD24")]
	public bool RecordPackets;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46CD5C", Offset = "0x46CD5C")]
	public bool StartWithControllers;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46CD94", Offset = "0x46CD94")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46CD94", Offset = "0x46CD94")]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46CE04", Offset = "0x46CE04")]
	private bool CombineMeshes;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46CE3C", Offset = "0x46CE3C")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46CE74", Offset = "0x46CE74")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46CEAC", Offset = "0x46CEAC")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46CEE4", Offset = "0x46CEE4")]
	public bool EnableLaughter;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x40000B0")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x40000B2")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x40000B3")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x40000B4")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x40000B5")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x40000B6")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x924D30", Offset = "0x924D30", VA = "0x924D30")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9251D0", Offset = "0x9251D0", VA = "0x9251D0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x925264", Offset = "0x925264", VA = "0x925264")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x9252CC", Offset = "0x9252CC", VA = "0x9252CC")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x9253FC", Offset = "0x9253FC", VA = "0x9253FC")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x9254DC", Offset = "0x9254DC", VA = "0x9254DC")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x9255B8", Offset = "0x9255B8", VA = "0x9255B8")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x92579C", Offset = "0x92579C", VA = "0x92579C")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x925878", Offset = "0x925878", VA = "0x925878")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x9258F0", Offset = "0x9258F0", VA = "0x9258F0")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x9259D8", Offset = "0x9259D8", VA = "0x9259D8")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x925A64", Offset = "0x925A64", VA = "0x925A64")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x925AEC", Offset = "0x925AEC", VA = "0x925AEC")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x925B04", Offset = "0x925B04", VA = "0x925B04")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x6000081")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x925FB4", Offset = "0x925FB4", VA = "0x925FB4")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x926334", Offset = "0x926334", VA = "0x926334")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x926520", Offset = "0x926520", VA = "0x926520")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x92676C", Offset = "0x92676C", VA = "0x92676C")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x926860", Offset = "0x926860", VA = "0x926860")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x926C68", Offset = "0x926C68", VA = "0x926C68")]
	private void Start()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x926FA0", Offset = "0x926FA0", VA = "0x926FA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x9279D8", Offset = "0x9279D8", VA = "0x9279D8")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x927A2C", Offset = "0x927A2C", VA = "0x927A2C")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x926B20", Offset = "0x926B20", VA = "0x926B20")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x926BC4", Offset = "0x926BC4", VA = "0x926BC4")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x927A5C", Offset = "0x927A5C", VA = "0x927A5C")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x927378", Offset = "0x927378", VA = "0x927378")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x927CD0", Offset = "0x927CD0", VA = "0x927CD0")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x927AC0", Offset = "0x927AC0", VA = "0x927AC0")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x927FA4", Offset = "0x927FA4", VA = "0x927FA4")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x928420", Offset = "0x928420", VA = "0x928420")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x928824", Offset = "0x928824", VA = "0x928824")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x928978", Offset = "0x928978", VA = "0x928978")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x928B5C", Offset = "0x928B5C", VA = "0x928B5C")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x927558", Offset = "0x927558", VA = "0x927558")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x928C30", Offset = "0x928C30", VA = "0x928C30")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x927388", Offset = "0x927388", VA = "0x927388")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x928D20", Offset = "0x928D20", VA = "0x928D20")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x9293D4", Offset = "0x9293D4", VA = "0x9293D4")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x9298B8", Offset = "0x9298B8", VA = "0x9298B8")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x9298E0", Offset = "0x9298E0", VA = "0x9298E0")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x929908", Offset = "0x929908", VA = "0x929908")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x927864", Offset = "0x927864", VA = "0x927864")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x928DF0", Offset = "0x928DF0", VA = "0x928DF0")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x929D38", Offset = "0x929D38", VA = "0x929D38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x470A74", Offset = "0x470A74")]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x929DB0", Offset = "0x929DB0", VA = "0x929DB0")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x929BF8", Offset = "0x929BF8", VA = "0x929BF8")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x929E74", Offset = "0x929E74", VA = "0x929E74")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x929F5C", Offset = "0x929F5C", VA = "0x929F5C")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x929944", Offset = "0x929944", VA = "0x929944")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x92A044", Offset = "0x92A044", VA = "0x92A044")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x200001C")]
public class OvrAvatarAsset
{
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x92A240", Offset = "0x92A240", VA = "0x92A240")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x200001D")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x92A310", Offset = "0x92A310", VA = "0x92A310")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x92B5C8", Offset = "0x92B5C8", VA = "0x92B5C8")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x92B19C", Offset = "0x92B19C", VA = "0x92B19C")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x92AF20", Offset = "0x92AF20", VA = "0x92AF20")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x92B008", Offset = "0x92B008", VA = "0x92B008")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x92B858", Offset = "0x92B858", VA = "0x92B858")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x200001E")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x40000E2")]
	private const int ASTCHeaderSize = 16;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x92BE20", Offset = "0x92BE20", VA = "0x92BE20")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x200001F")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x92C09C", Offset = "0x92C09C", VA = "0x92C09C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x92C4FC", Offset = "0x92C4FC", VA = "0x92C4FC")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x2000020")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x9286B4", Offset = "0x9286B4", VA = "0x9286B4")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x92C62C", Offset = "0x92C62C", VA = "0x92C62C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x92C75C", Offset = "0x92C75C", VA = "0x92C75C")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x2000021")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x92C7BC", Offset = "0x92C7BC", VA = "0x92C7BC")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x92C1CC", Offset = "0x92C1CC", VA = "0x92C1CC")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x92C7C4", Offset = "0x92C7C4", VA = "0x92C7C4")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x92C824", Offset = "0x92C824", VA = "0x92C824")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x92CFD8", Offset = "0x92CFD8", VA = "0x92CFD8")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x92C55C", Offset = "0x92C55C", VA = "0x92C55C")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x2000022")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x2000023")]
	public enum PacketMode
	{
		[Token(Token = "0x40000F6")]
		SDK,
		[Token(Token = "0x40000F7")]
		Unity
	}

	[Token(Token = "0x2000024")]
	public struct ControllerPose
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x9ACFB0", Offset = "0x9ACFB0", VA = "0x9ACFB0")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x2000025")]
	public struct PoseFrame
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x9AD08C", Offset = "0x9AD08C", VA = "0x9AD08C")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x7A265C", Offset = "0x7A265C", VA = "0x7A265C")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x60000C3")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x7A266C", Offset = "0x7A266C", VA = "0x7A266C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x7A26F4", Offset = "0x7A26F4", VA = "0x7A26F4")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x7A2970", Offset = "0x7A2970", VA = "0x7A2970")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x7A2978", Offset = "0x7A2978", VA = "0x7A2978")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x2000026")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x7A2988", Offset = "0x7A2988", VA = "0x7A2988")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x7A2AFC", Offset = "0x7A2AFC", VA = "0x7A2AFC")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x2000027")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x7A2B68", Offset = "0x7A2B68", VA = "0x7A2B68")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x7A2CCC", Offset = "0x7A2CCC", VA = "0x7A2CCC")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x7A3068", Offset = "0x7A3068", VA = "0x7A3068")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x7A328C", Offset = "0x7A328C", VA = "0x7A328C", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x7A32B8", Offset = "0x7A32B8", VA = "0x7A32B8")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x2000028")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	public enum TextureType
	{
		[Token(Token = "0x400012D")]
		DiffuseTextures,
		[Token(Token = "0x400012E")]
		NormalMaps,
		[Token(Token = "0x400012F")]
		RoughnessMaps,
		[Token(Token = "0x4000130")]
		Count
	}

	[Token(Token = "0x200002A")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x200002B")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x200002C")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x200002D")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x9ADAD0", Offset = "0x9ADAD0", VA = "0x9ADAD0")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C634", Offset = "0x46C634")]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x9ADA80", Offset = "0x9ADA80", VA = "0x9ADA80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x9ADAC8", Offset = "0x9ADAC8", VA = "0x9ADAC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x9AD390", Offset = "0x9AD390", VA = "0x9AD390")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x9AD3BC", Offset = "0x9AD3BC", VA = "0x9AD3BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x9AD3C0", Offset = "0x9AD3C0", VA = "0x9AD3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x9ADA88", Offset = "0x9ADA88", VA = "0x9ADA88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x4000128")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x4000129")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x400012A")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x400012B")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x7A3304", Offset = "0x7A3304", VA = "0x7A3304")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x7A34E4", Offset = "0x7A34E4", VA = "0x7A34E4")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x7A3524", Offset = "0x7A3524", VA = "0x7A3524")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x7A3CB8", Offset = "0x7A3CB8", VA = "0x7A3CB8")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x7A4198", Offset = "0x7A4198", VA = "0x7A4198")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x7A35C0", Offset = "0x7A35C0", VA = "0x7A35C0")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x7A4284", Offset = "0x7A4284", VA = "0x7A4284")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x7A3A14", Offset = "0x7A3A14", VA = "0x7A3A14")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x7A4514", Offset = "0x7A4514", VA = "0x7A4514")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x7A47B8", Offset = "0x7A47B8", VA = "0x7A47B8")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x7A48E0", Offset = "0x7A48E0", VA = "0x7A48E0")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x7A4918", Offset = "0x7A4918", VA = "0x7A4918")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x7A3C24", Offset = "0x7A3C24", VA = "0x7A3C24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x470B24", Offset = "0x470B24")]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x7A5880", Offset = "0x7A5880", VA = "0x7A5880")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x200002F")]
public class OvrAvatarPacket
{
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x17000009")]
	public float Duration
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x7A5EBC", Offset = "0x7A5EBC", VA = "0x7A5EBC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700000A")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x7A5F30", Offset = "0x7A5F30", VA = "0x7A5F30")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x7A5FC0", Offset = "0x7A5FC0", VA = "0x7A5FC0")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x7A60EC", Offset = "0x7A60EC", VA = "0x7A60EC")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x7A62B8", Offset = "0x7A62B8", VA = "0x7A62B8")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x7A6424", Offset = "0x7A6424", VA = "0x7A6424")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x7A64FC", Offset = "0x7A64FC", VA = "0x7A64FC")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x7A672C", Offset = "0x7A672C", VA = "0x7A672C")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x7A6A08", Offset = "0x7A6A08", VA = "0x7A6A08")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x2000030")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x74AAAC", Offset = "0x74AAAC", VA = "0x74AAAC")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x74ABC0", Offset = "0x74ABC0", VA = "0x74ABC0")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x74AD6C", Offset = "0x74AD6C", VA = "0x74AD6C")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x74AC30", Offset = "0x74AC30", VA = "0x74AC30")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x74ACC4", Offset = "0x74ACC4", VA = "0x74ACC4")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x2000031")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x74A6AC", Offset = "0x74A6AC", VA = "0x74A6AC")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x74AA50", Offset = "0x74AA50", VA = "0x74AA50")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x74A84C", Offset = "0x74A84C", VA = "0x74A84C")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x74A8C4", Offset = "0x74A8C4", VA = "0x74A8C4")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x74A960", Offset = "0x74A960", VA = "0x74A960")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x2000032")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x4000152")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x4000153")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x7A6C30", Offset = "0x7A6C30", VA = "0x7A6C30")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x7A6CB8", Offset = "0x7A6CB8", VA = "0x7A6CB8", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x7A6CD4", Offset = "0x7A6CD4", VA = "0x7A6CD4")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x7A6E78", Offset = "0x7A6E78", VA = "0x7A6E78")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x7A7064", Offset = "0x7A7064", VA = "0x7A7064")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x2000033")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x7A7108", Offset = "0x7A7108", VA = "0x7A7108")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x7A71EC", Offset = "0x7A71EC", VA = "0x7A71EC")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x7A7460", Offset = "0x7A7460", VA = "0x7A7460")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x7A7820", Offset = "0x7A7820", VA = "0x7A7820")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x7A792C", Offset = "0x7A792C", VA = "0x7A792C")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x2000034")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x400015C")]
	Body = 1,
	[Token(Token = "0x400015D")]
	Hands = 2,
	[Token(Token = "0x400015E")]
	Base = 4,
	[Token(Token = "0x400015F")]
	BodyTilt = 0x10,
	[Token(Token = "0x4000160")]
	Expressive = 0x20,
	[Token(Token = "0x4000161")]
	All = -1
}
[Token(Token = "0x2000035")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x4000163")]
	AvatarSpecification,
	[Token(Token = "0x4000164")]
	AssetLoaded,
	[Token(Token = "0x4000165")]
	Count
}
[Token(Token = "0x2000036")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x2000037")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x2000038")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x400016B")]
	Mesh,
	[Token(Token = "0x400016C")]
	Texture,
	[Token(Token = "0x400016D")]
	Pose,
	[Token(Token = "0x400016E")]
	Material,
	[Token(Token = "0x400016F")]
	CombinedMesh,
	[Token(Token = "0x4000170")]
	PBSMaterial,
	[Token(Token = "0x4000171")]
	FailedLoad,
	[Token(Token = "0x4000172")]
	Count
}
[Token(Token = "0x2000039")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x200003A")]
public struct ovrAvatarMeshVertexV2
{
	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float r;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x200003B")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x200003C")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200003D")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200003E")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x40001A7")]
	RGB24,
	[Token(Token = "0x40001A8")]
	DXT1,
	[Token(Token = "0x40001A9")]
	DXT5,
	[Token(Token = "0x40001AA")]
	ASTC_RGB_6x6,
	[Token(Token = "0x40001AB")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x40001AC")]
	Count
}
[Token(Token = "0x200003F")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x2000040")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x40001B4")]
	SkinnedMeshRender,
	[Token(Token = "0x40001B5")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x40001B6")]
	ProjectorRender,
	[Token(Token = "0x40001B7")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x40001B8")]
	Count
}
[Token(Token = "0x2000041")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x40001BA")]
	Unknown,
	[Token(Token = "0x40001BB")]
	Default,
	[Token(Token = "0x40001BC")]
	Verbose,
	[Token(Token = "0x40001BD")]
	Debug,
	[Token(Token = "0x40001BE")]
	Info,
	[Token(Token = "0x40001BF")]
	Warn,
	[Token(Token = "0x40001C0")]
	Error,
	[Token(Token = "0x40001C1")]
	Fatal,
	[Token(Token = "0x40001C2")]
	Silent
}
[Token(Token = "0x2000042")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x2000043")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x40001C7")]
	One = 1,
	[Token(Token = "0x40001C8")]
	Two = 2,
	[Token(Token = "0x40001C9")]
	Three = 4,
	[Token(Token = "0x40001CA")]
	Joystick = 8
}
[Token(Token = "0x2000044")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x40001CC")]
	One = 1,
	[Token(Token = "0x40001CD")]
	Two = 2,
	[Token(Token = "0x40001CE")]
	Joystick = 4,
	[Token(Token = "0x40001CF")]
	ThumbRest = 8,
	[Token(Token = "0x40001D0")]
	Index = 0x10,
	[Token(Token = "0x40001D1")]
	Pointing = 0x40,
	[Token(Token = "0x40001D2")]
	ThumbUp = 0x80
}
[Token(Token = "0x2000045")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x2000046")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x2000047")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x2000048")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x2000049")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200004A")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x200004B")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200004C")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200004D")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x40001F2")]
	Add,
	[Token(Token = "0x40001F3")]
	Multiply,
	[Token(Token = "0x40001F4")]
	Count
}
[Token(Token = "0x200004E")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x40001F6")]
	Color,
	[Token(Token = "0x40001F7")]
	Texture,
	[Token(Token = "0x40001F8")]
	TextureSingleChannel,
	[Token(Token = "0x40001F9")]
	Parallax,
	[Token(Token = "0x40001FA")]
	Count
}
[Token(Token = "0x200004F")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x40001FC")]
	None,
	[Token(Token = "0x40001FD")]
	Positional,
	[Token(Token = "0x40001FE")]
	ViewReflection,
	[Token(Token = "0x40001FF")]
	Fresnel,
	[Token(Token = "0x4000200")]
	Pulse,
	[Token(Token = "0x4000201")]
	Count
}
[Token(Token = "0x2000050")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x4000203")]
	Touch,
	[Token(Token = "0x4000204")]
	Malibu,
	[Token(Token = "0x4000205")]
	Go,
	[Token(Token = "0x4000206")]
	Quest,
	[Token(Token = "0x4000207")]
	Count
}
[Token(Token = "0x2000051")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x4000209")]
	Lowest = 1,
	[Token(Token = "0x400020A")]
	Medium = 3,
	[Token(Token = "0x400020B")]
	Highest = 5
}
[Token(Token = "0x2000052")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x400020D")]
	Unknown = -1,
	[Token(Token = "0x400020E")]
	One,
	[Token(Token = "0x400020F")]
	Two
}
[Token(Token = "0x2000053")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x8A2D34", Offset = "0x8A2D34", VA = "0x8A2D34")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x8A2D64", Offset = "0x8A2D64", VA = "0x8A2D64", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x8A2F80", Offset = "0x8A2F80", VA = "0x8A2F80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000054")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x8A3064", Offset = "0x8A3064", VA = "0x8A3064")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x8A3094", Offset = "0x8A3094", VA = "0x8A3094", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x8A3430", Offset = "0x8A3430", VA = "0x8A3430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000055")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x8A22C4", Offset = "0x8A22C4", VA = "0x8A22C4")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x8A22F4", Offset = "0x8A22F4", VA = "0x8A22F4", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x8A2584", Offset = "0x8A2584", VA = "0x8A2584", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000056")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x8A3598", Offset = "0x8A3598", VA = "0x8A3598")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x8A35C8", Offset = "0x8A35C8", VA = "0x8A35C8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x8A37B8", Offset = "0x8A37B8", VA = "0x8A37B8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000057")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x92A248", Offset = "0x92A248", VA = "0x92A248")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x2000058")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x2000059")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x4000244")]
	FirstPerson = 1,
	[Token(Token = "0x4000245")]
	ThirdPerson = 2,
	[Token(Token = "0x4000246")]
	SelfOccluding = 4
}
[Token(Token = "0x200005A")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200005B")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200005C")]
public struct ovrAvatarRenderPart_ProjectorRender
{
	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint componentIndex;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint renderPartIndex;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ovrAvatarMaterialState materialState;
}
[Token(Token = "0x200005D")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200005E")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x400025C")]
	Default,
	[Token(Token = "0x400025D")]
	GripSphere,
	[Token(Token = "0x400025E")]
	GripCube,
	[Token(Token = "0x400025F")]
	Count
}
[Token(Token = "0x200005F")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x4000261")]
	Body,
	[Token(Token = "0x4000262")]
	Clothing,
	[Token(Token = "0x4000263")]
	Eyewear,
	[Token(Token = "0x4000264")]
	Hair,
	[Token(Token = "0x4000265")]
	Beard,
	[Token(Token = "0x4000266")]
	Count
}
[Token(Token = "0x2000060")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x2000061")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x2000062")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x2000063")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x2000064")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x4000270")]
	AvatarHead,
	[Token(Token = "0x4000271")]
	AvatarHand,
	[Token(Token = "0x4000272")]
	Object,
	[Token(Token = "0x4000273")]
	ObjectStatic,
	[Token(Token = "0x4000274")]
	Count
}
[Token(Token = "0x2000065")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x2000066")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x2000067")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x2000068")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x2000069")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x4000280")]
	Point,
	[Token(Token = "0x4000281")]
	Direction,
	[Token(Token = "0x4000282")]
	Spot,
	[Token(Token = "0x4000283")]
	Count
}
[Token(Token = "0x200006A")]
public struct ovrAvatarLight
{
	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x200006B")]
internal struct ovrAvatarLight_Offsets
{
	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long id;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long type;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long intensity;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long worldDirection;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static long worldPosition;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static long range;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static long spotAngleDeg;
}
[Token(Token = "0x200006C")]
public struct ovrAvatarLights
{
	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x200006D")]
internal struct ovrAvatarLights_Offsets
{
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long ambientIntensity;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long lightCount;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long lights;
}
[Token(Token = "0x200006E")]
[Flags]
public enum ovrAvatarDebugContext : uint
{
	[Token(Token = "0x4000299")]
	None = 0u,
	[Token(Token = "0x400029A")]
	GazeTarget = 1u,
	[Token(Token = "0x400029B")]
	Any = uint.MaxValue
}
[Token(Token = "0x200006F")]
public struct ovrAvatarDebugLine
{
	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 startPoint;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 endPoint;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 color;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public IntPtr text;
}
[Token(Token = "0x2000070")]
public struct ovrAvatarDebugTransform
{
	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr text;
}
[Token(Token = "0x2000071")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x2000072")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x2000073")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x2000074")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x2000075")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x9ADAD8", Offset = "0x9ADAD8", VA = "0x9ADAD8")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x40002B0")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x1700000B")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x7A3D18", Offset = "0x7A3D18", VA = "0x7A3D18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x7A793C", Offset = "0x7A793C", VA = "0x7A793C")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x7A7C8C", Offset = "0x7A7C8C", VA = "0x7A7C8C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x7A7CFC", Offset = "0x7A7CFC", VA = "0x7A7CFC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x7A86DC", Offset = "0x7A86DC", VA = "0x7A86DC")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x7A8730", Offset = "0x7A8730", VA = "0x7A8730")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x7A8784", Offset = "0x7A8784", VA = "0x7A8784")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x7A87E8", Offset = "0x7A87E8", VA = "0x7A87E8")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x7A884C", Offset = "0x7A884C", VA = "0x7A884C")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x7A84DC", Offset = "0x7A84DC", VA = "0x7A84DC")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x7A8928", Offset = "0x7A8928", VA = "0x7A8928")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x7A8A7C", Offset = "0x7A8A7C", VA = "0x7A8A7C")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x7A73E4", Offset = "0x7A73E4", VA = "0x7A73E4")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x7A8B70", Offset = "0x7A8B70", VA = "0x7A8B70")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x7A7C40", Offset = "0x7A7C40", VA = "0x7A7C40")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x7A3F10", Offset = "0x7A3F10", VA = "0x7A3F10")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x7A8C50", Offset = "0x7A8C50", VA = "0x7A8C50")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x2000076")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x1700000C")]
	public static string AppID
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x7A8C10", Offset = "0x7A8C10", VA = "0x7A8C10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x7A8DC0", Offset = "0x7A8DC0", VA = "0x7A8DC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public static string MobileAppID
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x7A8C30", Offset = "0x7A8C30", VA = "0x7A8C30")]
		get
		{
			return null;
		}
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x7A8DF0", Offset = "0x7A8DF0", VA = "0x7A8DF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x7A8C68", Offset = "0x7A8C68", VA = "0x7A8C68")]
		get
		{
			return null;
		}
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x7A8E20", Offset = "0x7A8E20", VA = "0x7A8E20")]
		set
		{
		}
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x7A8E74", Offset = "0x7A8E74", VA = "0x7A8E74")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x2000077")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x7AA9C0", Offset = "0x7AA9C0", VA = "0x7AA9C0")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x7AACB4", Offset = "0x7AACB4", VA = "0x7AACB4")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x7AAB4C", Offset = "0x7AAB4C", VA = "0x7AAB4C")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x7AAEF4", Offset = "0x7AAEF4", VA = "0x7AAEF4")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x2000078")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x7AAF04", Offset = "0x7AAF04", VA = "0x7AAF04")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x7AB060", Offset = "0x7AB060", VA = "0x7AB060")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x7AB238", Offset = "0x7AB238", VA = "0x7AB238")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x2000079")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x40002C7")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x40002C8")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x40002C9")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x7A8EE0", Offset = "0x7A8EE0", VA = "0x7A8EE0")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x7A9EFC", Offset = "0x7A9EFC", VA = "0x7A9EFC")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x7AA138", Offset = "0x7AA138", VA = "0x7AA138")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x7A9610", Offset = "0x7A9610", VA = "0x7A9610")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x7A9334", Offset = "0x7A9334", VA = "0x7A9334")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x7A9498", Offset = "0x7A9498", VA = "0x7A9498")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x7AA9B0", Offset = "0x7AA9B0", VA = "0x7AA9B0")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x200007A")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200007B")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x200007C")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x9AE1D4", Offset = "0x9AE1D4", VA = "0x9AE1D4")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x200007D")]
	public struct TextureSet
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x9AE230", Offset = "0x9AE230", VA = "0x9AE230")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C6B4", Offset = "0x46C6B4")]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x9AE184", Offset = "0x9AE184", VA = "0x9AE184", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x9AE1CC", Offset = "0x9AE1CC", VA = "0x9AE1CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x9ADB54", Offset = "0x9ADB54", VA = "0x9ADB54")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x9ADB80", Offset = "0x9ADB80", VA = "0x9ADB80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x9ADB84", Offset = "0x9ADB84", VA = "0x9ADB84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x9AE18C", Offset = "0x9AE18C", VA = "0x9AE18C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x40002CD")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x40002CE")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x40002D1")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x40002D2")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x40002D3")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x40002D4")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x40002D5")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x40002D6")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x40002D7")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x7AB964", Offset = "0x7AB964", VA = "0x7AB964")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x7ABE44", Offset = "0x7ABE44", VA = "0x7ABE44")]
	public void Update()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x7AC044", Offset = "0x7AC044", VA = "0x7AC044")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x7A4368", Offset = "0x7A4368", VA = "0x7A4368")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x7ABFB8", Offset = "0x7ABFB8", VA = "0x7ABFB8")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x7A3F90", Offset = "0x7A3F90", VA = "0x7A3F90")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x7A41E0", Offset = "0x7A41E0", VA = "0x7A41E0")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x7AC090", Offset = "0x7AC090", VA = "0x7AC090")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x470C74", Offset = "0x470C74")]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x7A88DC", Offset = "0x7A88DC", VA = "0x7A88DC")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x7AC13C", Offset = "0x7AC13C", VA = "0x7AC13C")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x200007F")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x7AC2B4", Offset = "0x7AC2B4", VA = "0x7AC2B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x7AC428", Offset = "0x7AC428", VA = "0x7AC428")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x2000080")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x2000081")]
	public delegate void OnClick();

	[Token(Token = "0x2000082")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x2000083")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000084")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C6C4", Offset = "0x46C6C4")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x9A6E54", Offset = "0x9A6E54", VA = "0x9A6E54")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x9A6E5C", Offset = "0x9A6E5C", VA = "0x9A6E5C")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C6D4", Offset = "0x46C6D4")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x9A7080", Offset = "0x9A7080", VA = "0x9A7080")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x9A7088", Offset = "0x9A7088", VA = "0x9A7088")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C6E4", Offset = "0x46C6E4")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x9A72D4", Offset = "0x9A72D4", VA = "0x9A72D4")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x9A72DC", Offset = "0x9A72DC", VA = "0x9A72DC")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C6F4", Offset = "0x46C6F4")]
	private sealed class <>c__DisplayClass43_0
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x9A7670", Offset = "0x9A7670", VA = "0x9A7670")]
		public <>c__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x9A7678", Offset = "0x9A7678", VA = "0x9A7678")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C704", Offset = "0x46C704")]
	private sealed class <>c__DisplayClass44_0
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x9A7698", Offset = "0x9A7698", VA = "0x9A7698")]
		public <>c__DisplayClass44_0()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x9A76A0", Offset = "0x9A76A0", VA = "0x9A76A0")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x40002E9")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x40002EA")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x40002EB")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x40002FA")]
	private const float elementSpacing = 16f;

	[Token(Token = "0x40002FB")]
	public const float marginH = 16f;

	[Token(Token = "0x40002FC")]
	public const float marginV = 16f;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector2[] insertPositions;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private OVRCameraRig rig;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private LaserPointer lp;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private LineRenderer lr;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public bool isHorizontal;

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x75AF40", Offset = "0x75AF40", VA = "0x75AF40")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x7493C0", Offset = "0x7493C0", VA = "0x7493C0")]
	public void Show()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x7499FC", Offset = "0x7499FC", VA = "0x7499FC")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x75B470", Offset = "0x75B470", VA = "0x75B470")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x75B6B4", Offset = "0x75B6B4", VA = "0x75B6B4")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x748CD8", Offset = "0x748CD8", VA = "0x748CD8")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x748B30", Offset = "0x748B30", VA = "0x748B30")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x75B9D4", Offset = "0x75B9D4", VA = "0x75B9D4")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x748C34", Offset = "0x748C34", VA = "0x748C34")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x75BBB8", Offset = "0x75BBB8", VA = "0x75BBB8")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x75BDA8", Offset = "0x75BDA8", VA = "0x75BDA8")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x75BFB0", Offset = "0x75BFB0", VA = "0x75BFB0")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x75C2B4", Offset = "0x75C2B4", VA = "0x75C2B4")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x749314", Offset = "0x749314", VA = "0x749314")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x75C3B0", Offset = "0x75C3B0", VA = "0x75C3B0")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x200008A")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x864250", Offset = "0x864250", VA = "0x864250")]
	private void Start()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x864300", Offset = "0x864300", VA = "0x864300")]
	private void Update()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x8643C0", Offset = "0x8643C0", VA = "0x8643C0")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x8643FC", Offset = "0x8643FC", VA = "0x8643FC")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x200008B")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x200008C")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x400031A")]
		On,
		[Token(Token = "0x400031B")]
		Off,
		[Token(Token = "0x400031C")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000011")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x868164", Offset = "0x868164", VA = "0x868164")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x868120", Offset = "0x868120", VA = "0x868120")]
		set
		{
		}
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x86816C", Offset = "0x86816C", VA = "0x86816C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x8681C8", Offset = "0x8681C8", VA = "0x8681C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x86830C", Offset = "0x86830C", VA = "0x86830C", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x868328", Offset = "0x868328", VA = "0x868328", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x86837C", Offset = "0x86837C", VA = "0x86837C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x868538", Offset = "0x868538", VA = "0x868538")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x86864C", Offset = "0x86864C", VA = "0x86864C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x8686DC", Offset = "0x8686DC", VA = "0x8686DC")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x8687A8", Offset = "0x8687A8", VA = "0x8687A8")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x86885C", Offset = "0x86885C", VA = "0x86885C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x868948", Offset = "0x868948", VA = "0x868948")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x200008D")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x400031D")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400031E")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400031F")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46CFFC", Offset = "0x46CFFC")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D034", Offset = "0x46D034")]
	public LayerMask CollideLayers;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D06C", Offset = "0x46D06C")]
	public float HeightOffset;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D0A4", Offset = "0x46D0A4")]
	public float MinimumHeight;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D0DC", Offset = "0x46D0DC")]
	public float MaximumHeight;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x756420", Offset = "0x756420", VA = "0x756420")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x756428", Offset = "0x756428", VA = "0x756428")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x7564B4", Offset = "0x7564B4", VA = "0x7564B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x756548", Offset = "0x756548", VA = "0x756548")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x7565DC", Offset = "0x7565DC", VA = "0x7565DC")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x756908", Offset = "0x756908", VA = "0x756908")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x756B38", Offset = "0x756B38", VA = "0x756B38")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200008E")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x868958", Offset = "0x868958", VA = "0x868958")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x868A24", Offset = "0x868A24", VA = "0x868A24")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200008F")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	public enum States
	{
		[Token(Token = "0x400034D")]
		Ready,
		[Token(Token = "0x400034E")]
		Aim,
		[Token(Token = "0x400034F")]
		CancelAim,
		[Token(Token = "0x4000350")]
		PreTeleport,
		[Token(Token = "0x4000351")]
		CancelTeleport,
		[Token(Token = "0x4000352")]
		Teleporting,
		[Token(Token = "0x4000353")]
		PostTeleport
	}

	[Token(Token = "0x2000091")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000355")]
		None,
		[Token(Token = "0x4000356")]
		Aim,
		[Token(Token = "0x4000357")]
		PreTeleport,
		[Token(Token = "0x4000358")]
		Teleport
	}

	[Token(Token = "0x2000092")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x400035A")]
		Point,
		[Token(Token = "0x400035B")]
		Sphere,
		[Token(Token = "0x400035C")]
		Capsule
	}

	[Token(Token = "0x2000093")]
	public class AimData
	{
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46D4F4", Offset = "0x46D4F4")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x17000015")]
		public List<Vector3> Points
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x9AA710", Offset = "0x9AA710", VA = "0x9AA710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47119C", Offset = "0x47119C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x9AA718", Offset = "0x9AA718", VA = "0x9AA718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4711AC", Offset = "0x4711AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x9AA68C", Offset = "0x9AA68C", VA = "0x9AA68C")]
		public AimData()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x9AA720", Offset = "0x9AA720", VA = "0x9AA720")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C714", Offset = "0x46C714")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x9AA4D8", Offset = "0x9AA4D8", VA = "0x9AA4D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x9AA520", Offset = "0x9AA520", VA = "0x9AA520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x9AA39C", Offset = "0x9AA39C", VA = "0x9AA39C")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x9AA3C8", Offset = "0x9AA3C8", VA = "0x9AA3C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x9AA3CC", Offset = "0x9AA3CC", VA = "0x9AA3CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x9AA4E0", Offset = "0x9AA4E0", VA = "0x9AA4E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C724", Offset = "0x46C724")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x9A9E08", Offset = "0x9A9E08", VA = "0x9A9E08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x9A9E50", Offset = "0x9A9E50", VA = "0x9A9E50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x9A9C80", Offset = "0x9A9C80", VA = "0x9A9C80")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x9A9CAC", Offset = "0x9A9CAC", VA = "0x9A9CAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x9A9CB0", Offset = "0x9A9CB0", VA = "0x9A9CB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x9A9E10", Offset = "0x9A9E10", VA = "0x9A9E10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C734", Offset = "0x46C734")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x9A9F34", Offset = "0x9A9F34", VA = "0x9A9F34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x9A9F7C", Offset = "0x9A9F7C", VA = "0x9A9F7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x9A9E58", Offset = "0x9A9E58", VA = "0x9A9E58")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x9A9E84", Offset = "0x9A9E84", VA = "0x9A9E84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x9A9E88", Offset = "0x9A9E88", VA = "0x9A9E88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x9A9F3C", Offset = "0x9A9F3C", VA = "0x9A9F3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C744", Offset = "0x46C744")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x9AA34C", Offset = "0x9AA34C", VA = "0x9AA34C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x9AA394", Offset = "0x9AA394", VA = "0x9AA394", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x9AA230", Offset = "0x9AA230", VA = "0x9AA230")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x9AA25C", Offset = "0x9AA25C", VA = "0x9AA25C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x9AA260", Offset = "0x9AA260", VA = "0x9AA260", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x9AA354", Offset = "0x9AA354", VA = "0x9AA354", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C754", Offset = "0x46C754")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x9AA060", Offset = "0x9AA060", VA = "0x9AA060", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x9AA0A8", Offset = "0x9AA0A8", VA = "0x9AA0A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x9A9F84", Offset = "0x9A9F84", VA = "0x9A9F84")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x9A9FB0", Offset = "0x9A9FB0", VA = "0x9A9FB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x9A9FB4", Offset = "0x9A9FB4", VA = "0x9A9FB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x9AA068", Offset = "0x9AA068", VA = "0x9AA068", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C764", Offset = "0x46C764")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x9AA63C", Offset = "0x9AA63C", VA = "0x9AA63C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x9AA684", Offset = "0x9AA684", VA = "0x9AA684", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x9AA528", Offset = "0x9AA528", VA = "0x9AA528")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x9AA554", Offset = "0x9AA554", VA = "0x9AA554", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x9AA558", Offset = "0x9AA558", VA = "0x9AA558", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x9AA644", Offset = "0x9AA644", VA = "0x9AA644", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C774", Offset = "0x46C774")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x9AA1E0", Offset = "0x9AA1E0", VA = "0x9AA1E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x9AA228", Offset = "0x9AA228", VA = "0x9AA228", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x9AA0B0", Offset = "0x9AA0B0", VA = "0x9AA0B0")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x9AA0DC", Offset = "0x9AA0DC", VA = "0x9AA0DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x9AA0E0", Offset = "0x9AA0E0", VA = "0x9AA0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x9AA1E8", Offset = "0x9AA1E8", VA = "0x9AA1E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D114", Offset = "0x46D114")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D14C", Offset = "0x46D14C")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D184", Offset = "0x46D184")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D1BC", Offset = "0x46D1BC")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D1F4", Offset = "0x46D1F4")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D22C", Offset = "0x46D22C")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D264", Offset = "0x46D264")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D29C", Offset = "0x46D29C")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46D2D4", Offset = "0x46D2D4")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D2E4", Offset = "0x46D2E4")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D31C", Offset = "0x46D31C")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46D364", Offset = "0x46D364")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D374", Offset = "0x46D374")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D3AC", Offset = "0x46D3AC")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D3E4", Offset = "0x46D3E4")]
	public float AimCollisionRadius;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D41C", Offset = "0x46D41C")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000012")]
	public States CurrentState
	{
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x869520", Offset = "0x869520", VA = "0x869520")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470D24", Offset = "0x470D24")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x869528", Offset = "0x869528", VA = "0x869528")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470D34", Offset = "0x470D34")]
		private set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x86974C", Offset = "0x86974C", VA = "0x86974C")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000014")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x869774", Offset = "0x869774", VA = "0x869774")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470D64", Offset = "0x470D64")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x86977C", Offset = "0x86977C", VA = "0x86977C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470D74", Offset = "0x470D74")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x869530", Offset = "0x869530", VA = "0x869530")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470D44", Offset = "0x470D44")]
		add
		{
		}
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x8695D0", Offset = "0x8695D0", VA = "0x8695D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470D54", Offset = "0x470D54")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x869DBC", Offset = "0x869DBC", VA = "0x869DBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470DBC", Offset = "0x470DBC")]
		add
		{
		}
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x869E5C", Offset = "0x869E5C", VA = "0x869E5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470DCC", Offset = "0x470DCC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x869EFC", Offset = "0x869EFC", VA = "0x869EFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470E3C", Offset = "0x470E3C")]
		add
		{
		}
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x869F9C", Offset = "0x869F9C", VA = "0x869F9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470E4C", Offset = "0x470E4C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x86A03C", Offset = "0x86A03C", VA = "0x86A03C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470E5C", Offset = "0x470E5C")]
		add
		{
		}
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x86A0DC", Offset = "0x86A0DC", VA = "0x86A0DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470E6C", Offset = "0x470E6C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x86A1EC", Offset = "0x86A1EC", VA = "0x86A1EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470E7C", Offset = "0x470E7C")]
		add
		{
		}
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x86A28C", Offset = "0x86A28C", VA = "0x86A28C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470E8C", Offset = "0x470E8C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x86A3A4", Offset = "0x86A3A4", VA = "0x86A3A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470EFC", Offset = "0x470EFC")]
		add
		{
		}
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x86A444", Offset = "0x86A444", VA = "0x86A444")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470F0C", Offset = "0x470F0C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x86A55C", Offset = "0x86A55C", VA = "0x86A55C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470F7C", Offset = "0x470F7C")]
		add
		{
		}
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x86A5FC", Offset = "0x86A5FC", VA = "0x86A5FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470F8C", Offset = "0x470F8C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x86A714", Offset = "0x86A714", VA = "0x86A714")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470FFC", Offset = "0x470FFC")]
		add
		{
		}
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x86A7B4", Offset = "0x86A7B4", VA = "0x86A7B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47100C", Offset = "0x47100C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x86A8CC", Offset = "0x86A8CC", VA = "0x86A8CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47107C", Offset = "0x47107C")]
		add
		{
		}
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x86A96C", Offset = "0x86A96C", VA = "0x86A96C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47108C", Offset = "0x47108C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x86AA84", Offset = "0x86AA84", VA = "0x86AA84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4710FC", Offset = "0x4710FC")]
		add
		{
		}
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x86AB24", Offset = "0x86AB24", VA = "0x86AB24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47110C", Offset = "0x47110C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x86AC3C", Offset = "0x86AC3C", VA = "0x86AC3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47117C", Offset = "0x47117C")]
		add
		{
		}
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x86ACDC", Offset = "0x86ACDC", VA = "0x86ACDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47118C", Offset = "0x47118C")]
		remove
		{
		}
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x8691CC", Offset = "0x8691CC", VA = "0x8691CC")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x8691F0", Offset = "0x8691F0", VA = "0x8691F0")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x869670", Offset = "0x869670", VA = "0x869670")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x869784", Offset = "0x869784", VA = "0x869784")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x8699D0", Offset = "0x8699D0", VA = "0x8699D0")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x470D84", Offset = "0x470D84")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x869A84", Offset = "0x869A84", VA = "0x869A84")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x869B84", Offset = "0x869B84", VA = "0x869B84")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x869BA0", Offset = "0x869BA0", VA = "0x869BA0")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x869C64", Offset = "0x869C64", VA = "0x869C64")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x869CA8", Offset = "0x869CA8", VA = "0x869CA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x869D0C", Offset = "0x869D0C", VA = "0x869D0C", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x869DB4", Offset = "0x869DB4", VA = "0x869DB4", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x869D3C", Offset = "0x869D3C", VA = "0x869D3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x470DDC", Offset = "0x470DDC")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x86A17C", Offset = "0x86A17C", VA = "0x86A17C")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x86A32C", Offset = "0x86A32C", VA = "0x86A32C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x470E9C", Offset = "0x470E9C")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x86A4E4", Offset = "0x86A4E4", VA = "0x86A4E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x470F1C", Offset = "0x470F1C")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x86A69C", Offset = "0x86A69C", VA = "0x86A69C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x470F9C", Offset = "0x470F9C")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x86A854", Offset = "0x86A854", VA = "0x86A854")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47101C", Offset = "0x47101C")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x86AA0C", Offset = "0x86AA0C", VA = "0x86AA0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47109C", Offset = "0x47109C")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x86ABC4", Offset = "0x86ABC4", VA = "0x86ABC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47111C", Offset = "0x47111C")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x86AD7C", Offset = "0x86AD7C", VA = "0x86AD7C")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x86AEBC", Offset = "0x86AEBC", VA = "0x86AEBC")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x86AEF0", Offset = "0x86AEF0", VA = "0x86AEF0")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x86AFB8", Offset = "0x86AFB8", VA = "0x86AFB8")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x86B0B0", Offset = "0x86B0B0", VA = "0x86B0B0")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x200009B")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x891174", Offset = "0x891174", VA = "0x891174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4713EC", Offset = "0x4713EC")]
		add
		{
		}
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x891214", Offset = "0x891214", VA = "0x891214")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4713FC", Offset = "0x4713FC")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x8912B4", Offset = "0x8912B4", VA = "0x8912B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47140C", Offset = "0x47140C")]
		add
		{
		}
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x891354", Offset = "0x891354", VA = "0x891354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47141C", Offset = "0x47141C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x8913F4", Offset = "0x8913F4", VA = "0x8913F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x8914E0", Offset = "0x8914E0", VA = "0x8914E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x8914E4", Offset = "0x8914E4", VA = "0x8914E4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x891558", Offset = "0x891558", VA = "0x891558")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x89167C", Offset = "0x89167C", VA = "0x89167C")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x891864", Offset = "0x891864", VA = "0x891864")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x891A6C", Offset = "0x891A6C", VA = "0x891A6C")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x200009C")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x898D2C", Offset = "0x898D2C", VA = "0x898D2C", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x898DCC", Offset = "0x898DCC", VA = "0x898DCC", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000212")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x898EBC", Offset = "0x898EBC", VA = "0x898EBC")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x200009D")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D524", Offset = "0x46D524")]
	public float Range;

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x898ECC", Offset = "0x898ECC", VA = "0x898ECC", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x898FC8", Offset = "0x898FC8", VA = "0x898FC8")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200009E")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D55C", Offset = "0x46D55C")]
	public float Range;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D594", Offset = "0x46D594")]
	public float MinimumElevation;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D5CC", Offset = "0x46D5CC")]
	public float Gravity;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46D604", Offset = "0x46D604")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D604", Offset = "0x46D604")]
	public float AimVelocity;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46D660", Offset = "0x46D660")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D660", Offset = "0x46D660")]
	public float AimStep;

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x898FD8", Offset = "0x898FD8", VA = "0x898FD8", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x899168", Offset = "0x899168", VA = "0x899168")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x200009F")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D6B8", Offset = "0x46D6B8")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x89917C", Offset = "0x89917C", VA = "0x89917C")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x8992B8", Offset = "0x8992B8", VA = "0x8992B8")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x8992E8", Offset = "0x8992E8", VA = "0x8992E8")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x899318", Offset = "0x899318", VA = "0x899318")]
	private void Awake()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x8993C8", Offset = "0x8993C8", VA = "0x8993C8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x899434", Offset = "0x899434", VA = "0x899434", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x89949C", Offset = "0x89949C", VA = "0x89949C")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x20000A0")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46D6F0", Offset = "0x46D6F0")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D700", Offset = "0x46D700")]
	public Transform PositionIndicator;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D738", Offset = "0x46D738")]
	public Transform OrientationIndicator;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D770", Offset = "0x46D770")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x17000024")]
	public bool IsValidDestination
	{
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x8995C0", Offset = "0x8995C0", VA = "0x8995C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47142C", Offset = "0x47142C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x8995C8", Offset = "0x8995C8", VA = "0x8995C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47143C", Offset = "0x47143C")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x899784", Offset = "0x899784", VA = "0x899784")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47144C", Offset = "0x47144C")]
		add
		{
		}
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x899824", Offset = "0x899824", VA = "0x899824")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47145C", Offset = "0x47145C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x8995D4", Offset = "0x8995D4", VA = "0x8995D4")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x89966C", Offset = "0x89966C", VA = "0x89966C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x899740", Offset = "0x899740", VA = "0x899740")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x899780", Offset = "0x899780", VA = "0x899780")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x8998C4", Offset = "0x8998C4", VA = "0x8998C4")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x899928", Offset = "0x899928", VA = "0x899928")]
	public void Recycle()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x899948", Offset = "0x899948", VA = "0x899948", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000A1")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C784", Offset = "0x46C784")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x9AF4E4", Offset = "0x9AF4E4", VA = "0x9AF4E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x9AF52C", Offset = "0x9AF52C", VA = "0x9AF52C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x9AF41C", Offset = "0x9AF41C", VA = "0x9AF41C")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x9AF448", Offset = "0x9AF448", VA = "0x9AF448", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x9AF44C", Offset = "0x9AF44C", VA = "0x9AF44C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x9AF4EC", Offset = "0x9AF4EC", VA = "0x9AF4EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C794", Offset = "0x46C794")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x9AF3CC", Offset = "0x9AF3CC", VA = "0x9AF3CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x9AF414", Offset = "0x9AF414", VA = "0x9AF414", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x9AF300", Offset = "0x9AF300", VA = "0x9AF300")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x9AF32C", Offset = "0x9AF32C", VA = "0x9AF32C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x9AF330", Offset = "0x9AF330", VA = "0x9AF330", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x9AF3D4", Offset = "0x9AF3D4", VA = "0x9AF3D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x899B54", Offset = "0x899B54", VA = "0x899B54")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x899C28", Offset = "0x899C28", VA = "0x899C28", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x899C88", Offset = "0x899C88", VA = "0x899C88", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x899D48", Offset = "0x899D48", VA = "0x899D48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47146C", Offset = "0x47146C")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x899DC0", Offset = "0x899DC0", VA = "0x899DC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4714CC", Offset = "0x4714CC")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x6000230")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x899E38", Offset = "0x899E38", VA = "0x899E38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47152C", Offset = "0x47152C")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x899E64", Offset = "0x899E64", VA = "0x899E64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47153C", Offset = "0x47153C")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x20000A4")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46D7B8", Offset = "0x46D7B8")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D7C8", Offset = "0x46D7C8")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D800", Offset = "0x46D800")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D838", Offset = "0x46D838")]
	public bool FastTeleport;

	[Token(Token = "0x17000029")]
	public Transform Pointer
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x899E90", Offset = "0x899E90", VA = "0x899E90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4715EC", Offset = "0x4715EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x899E98", Offset = "0x899E98", VA = "0x899E98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4715FC", Offset = "0x4715FC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x899EA0", Offset = "0x899EA0", VA = "0x899EA0", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x899FF8", Offset = "0x899FF8", VA = "0x899FF8", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x89A0B0", Offset = "0x89A0B0", VA = "0x89A0B0")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000A5")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x20000A6")]
	public enum InputModes
	{
		[Token(Token = "0x40003AD")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x40003AE")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x40003AF")]
		ThumbstickTeleport,
		[Token(Token = "0x40003B0")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x20000A7")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x40003B2")]
		A,
		[Token(Token = "0x40003B3")]
		B,
		[Token(Token = "0x40003B4")]
		LeftTrigger,
		[Token(Token = "0x40003B5")]
		LeftThumbstick,
		[Token(Token = "0x40003B6")]
		RightTrigger,
		[Token(Token = "0x40003B7")]
		RightThumbstick,
		[Token(Token = "0x40003B8")]
		X,
		[Token(Token = "0x40003B9")]
		Y
	}

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D870", Offset = "0x46D870")]
	public InputModes InputMode;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D8A8", Offset = "0x46D8A8")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D8E0", Offset = "0x46D8E0")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D918", Offset = "0x46D918")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x89A0B4", Offset = "0x89A0B4", VA = "0x89A0B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x89A0B8", Offset = "0x89A0B8", VA = "0x89A0B8", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x89A4A0", Offset = "0x89A4A0", VA = "0x89A4A0", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x89A560", Offset = "0x89A560", VA = "0x89A560")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000A8")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x20000A9")]
	public enum OrientationModes
	{
		[Token(Token = "0x40003BE")]
		HeadRelative,
		[Token(Token = "0x40003BF")]
		ForwardFacing
	}

	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C7A4", Offset = "0x46C7A4")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x9AF614", Offset = "0x9AF614", VA = "0x9AF614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x9AF65C", Offset = "0x9AF65C", VA = "0x9AF65C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x9AF534", Offset = "0x9AF534", VA = "0x9AF534")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x9AF560", Offset = "0x9AF560", VA = "0x9AF560", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x9AF564", Offset = "0x9AF564", VA = "0x9AF564", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x9AF61C", Offset = "0x9AF61C", VA = "0x9AF61C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x89A644", Offset = "0x89A644", VA = "0x89A644")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x89A738", Offset = "0x89A738", VA = "0x89A738")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x89A740", Offset = "0x89A740", VA = "0x89A740", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x89A78C", Offset = "0x89A78C", VA = "0x89A78C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x89A7D4", Offset = "0x89A7D4", VA = "0x89A7D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47160C", Offset = "0x47160C")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x600024E")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x89A84C", Offset = "0x89A84C", VA = "0x89A84C")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x89A908", Offset = "0x89A908", VA = "0x89A908")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47166C", Offset = "0x47166C")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000AB")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x6000257")]
	[Address(RVA = "0x89A934", Offset = "0x89A934", VA = "0x89A934", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x89A938", Offset = "0x89A938", VA = "0x89A938", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x89A9B4", Offset = "0x89A9B4", VA = "0x89A9B4")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000AC")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D950", Offset = "0x46D950")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D988", Offset = "0x46D988")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D9C0", Offset = "0x46D9C0")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46D9F8", Offset = "0x46D9F8")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x89A9B8", Offset = "0x89A9B8", VA = "0x89A9B8", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x89A9E4", Offset = "0x89A9E4", VA = "0x89A9E4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x89AD94", Offset = "0x89AD94", VA = "0x89AD94")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x20000AD")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DA30", Offset = "0x46DA30")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DA68", Offset = "0x46DA68")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DAA0", Offset = "0x46DAA0")]
	public float RotateStickThreshold;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x89AD98", Offset = "0x89AD98", VA = "0x89AD98", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x89ADDC", Offset = "0x89ADDC", VA = "0x89ADDC", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x89B184", Offset = "0x89B184", VA = "0x89B184")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x20000AE")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x89B194", Offset = "0x89B194", VA = "0x89B194")]
	private void Start()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x89B198", Offset = "0x89B198", VA = "0x89B198")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x89B1A0", Offset = "0x89B1A0", VA = "0x89B1A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x89B25C", Offset = "0x89B25C", VA = "0x89B25C")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x89B284", Offset = "0x89B284", VA = "0x89B284")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20000AF")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46DAD8", Offset = "0x46DAD8")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x1700002C")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x89B29C", Offset = "0x89B29C", VA = "0x89B29C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4716CC", Offset = "0x4716CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x89B2A4", Offset = "0x89B2A4", VA = "0x89B2A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4716DC", Offset = "0x4716DC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x898D60", Offset = "0x898D60", VA = "0x898D60", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x898E88", Offset = "0x898E88", VA = "0x898E88", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x89B2AC", Offset = "0x89B2AC", VA = "0x89B2AC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x4716EC", Offset = "0x4716EC")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x899428", Offset = "0x899428", VA = "0x899428", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x899494", Offset = "0x899494", VA = "0x899494", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x898EC4", Offset = "0x898EC4", VA = "0x898EC4")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x20000B0")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C7B4", Offset = "0x46C7B4")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x9AF934", Offset = "0x9AF934", VA = "0x9AF934", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x9AF97C", Offset = "0x9AF97C", VA = "0x9AF97C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x9AF664", Offset = "0x9AF664", VA = "0x9AF664")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x9AF690", Offset = "0x9AF690", VA = "0x9AF690", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x9AF694", Offset = "0x9AF694", VA = "0x9AF694", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x9AF93C", Offset = "0x9AF93C", VA = "0x9AF93C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DAE8", Offset = "0x46DAE8")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x40003D9")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x89B388", Offset = "0x89B388", VA = "0x89B388")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x89B498", Offset = "0x89B498", VA = "0x89B498", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x89B4C4", Offset = "0x89B4C4", VA = "0x89B4C4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x89B4EC", Offset = "0x89B4EC", VA = "0x89B4EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x471724", Offset = "0x471724")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x89B564", Offset = "0x89B564", VA = "0x89B564", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x6000272")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x89B580", Offset = "0x89B580", VA = "0x89B580", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x89B6A0", Offset = "0x89B6A0", VA = "0x89B6A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x471784", Offset = "0x471784")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000B2")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x89B6CC", Offset = "0x89B6CC", VA = "0x89B6CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x89B730", Offset = "0x89B730", VA = "0x89B730", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x89B828", Offset = "0x89B828", VA = "0x89B828", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x89B920", Offset = "0x89B920", VA = "0x89B920")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x4717E4", Offset = "0x4717E4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x89B924", Offset = "0x89B924", VA = "0x89B924")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x20000B3")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DB20", Offset = "0x46DB20")]
	public float LOSOffset;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DB58", Offset = "0x46DB58")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x89B930", Offset = "0x89B930", VA = "0x89B930", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x89BB3C", Offset = "0x89BB3C", VA = "0x89BB3C")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x20000B4")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x89BB48", Offset = "0x89BB48", VA = "0x89BB48", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x89BC40", Offset = "0x89BC40", VA = "0x89BC40")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x20000B5")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x89BC44", Offset = "0x89BC44", VA = "0x89BC44", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x89BCD8", Offset = "0x89BCD8", VA = "0x89BCD8", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000286")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x89BD68", Offset = "0x89BD68", VA = "0x89BD68")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20000B6")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C7C4", Offset = "0x46C7C4")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x9AFABC", Offset = "0x9AFABC", VA = "0x9AFABC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x9AFB04", Offset = "0x9AFB04", VA = "0x9AFB04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x9AF984", Offset = "0x9AF984", VA = "0x9AF984")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x9AF9B0", Offset = "0x9AF9B0", VA = "0x9AF9B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x9AF9B4", Offset = "0x9AF9B4", VA = "0x9AF9B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x9AFAC4", Offset = "0x9AFAC4", VA = "0x9AFAC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46DB90", Offset = "0x46DB90")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DB90", Offset = "0x46DB90")]
	public float TransitionDuration;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46DBE8", Offset = "0x46DBE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DBE8", Offset = "0x46DBE8")]
	public float TeleportDelay;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DC3C", Offset = "0x46DC3C")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x89BD70", Offset = "0x89BD70", VA = "0x89BD70", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x89BD9C", Offset = "0x89BD9C", VA = "0x89BD9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47181C", Offset = "0x47181C")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x89BE14", Offset = "0x89BE14", VA = "0x89BE14")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x20000B8")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x89BFC0", Offset = "0x89BFC0", VA = "0x89BFC0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x89BFDC", Offset = "0x89BFDC", VA = "0x89BFDC")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x20000B9")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C7D4", Offset = "0x46C7D4")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x9AFC78", Offset = "0x9AFC78", VA = "0x9AFC78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x9AFCC0", Offset = "0x9AFCC0", VA = "0x9AFCC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x9AFB0C", Offset = "0x9AFB0C", VA = "0x9AFB0C")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x9AFB38", Offset = "0x9AFB38", VA = "0x9AFB38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x9AFB3C", Offset = "0x9AFB3C", VA = "0x9AFB3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x9AFC80", Offset = "0x9AFC80", VA = "0x9AFC80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DC74", Offset = "0x46DC74")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46DC74", Offset = "0x46DC74")]
	public float TransitionDuration;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x89BFE4", Offset = "0x89BFE4", VA = "0x89BFE4", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x89C010", Offset = "0x89C010", VA = "0x89C010")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4718CC", Offset = "0x4718CC")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x89C088", Offset = "0x89C088", VA = "0x89C088")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x20000BB")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x20000BC")]
	public enum PlabackState
	{
		[Token(Token = "0x4000409")]
		Idle = 1,
		[Token(Token = "0x400040A")]
		Preparing,
		[Token(Token = "0x400040B")]
		Buffering,
		[Token(Token = "0x400040C")]
		Ready,
		[Token(Token = "0x400040D")]
		Ended
	}

	[Token(Token = "0x20000BD")]
	public enum StereoMode
	{
		[Token(Token = "0x400040F")]
		Unknown = -1,
		[Token(Token = "0x4000410")]
		Mono,
		[Token(Token = "0x4000411")]
		TopBottom,
		[Token(Token = "0x4000412")]
		LeftRight,
		[Token(Token = "0x4000413")]
		Mesh
	}

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000033")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x91F3BC", Offset = "0x91F3BC", VA = "0x91F3BC")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000034")]
	private static IntPtr Activity
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x91F6EC", Offset = "0x91F6EC", VA = "0x91F6EC")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x17000035")]
	public static bool IsAvailable
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x91C87C", Offset = "0x91C87C", VA = "0x91C87C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000036")]
	public static bool IsPlaying
	{
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x91E078", Offset = "0x91E078", VA = "0x91E078")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000037")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x91F9BC", Offset = "0x91F9BC", VA = "0x91F9BC")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000038")]
	public static long Duration
	{
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x91E29C", Offset = "0x91E29C", VA = "0x91E29C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000039")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x91CEA4", Offset = "0x91CEA4", VA = "0x91CEA4")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x1700003A")]
	public static int VideoWidth
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x91CC7C", Offset = "0x91CC7C", VA = "0x91CC7C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003B")]
	public static int VideoHeight
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x91CD90", Offset = "0x91CD90", VA = "0x91CD90")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003C")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x91E188", Offset = "0x91E188", VA = "0x91E188")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x91D75C", Offset = "0x91D75C", VA = "0x91D75C")]
		set
		{
		}
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x91FAD0", Offset = "0x91FAD0", VA = "0x91FAD0")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x91E66C", Offset = "0x91E66C", VA = "0x91E66C")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x91D3A8", Offset = "0x91D3A8", VA = "0x91D3A8")]
	public static void Play()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x91D548", Offset = "0x91D548", VA = "0x91D548")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x91E464", Offset = "0x91E464", VA = "0x91E464")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x91FCFC", Offset = "0x91FCFC", VA = "0x91FCFC")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x91DE88", Offset = "0x91DE88", VA = "0x91DE88")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x20000BE")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x74DFC8", Offset = "0x74DFC8", VA = "0x74DFC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47197C", Offset = "0x47197C")]
		add
		{
		}
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x74E068", Offset = "0x74E068", VA = "0x74E068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47198C", Offset = "0x47198C")]
		remove
		{
		}
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x74E108", Offset = "0x74E108", VA = "0x74E108", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x74E11C", Offset = "0x74E11C", VA = "0x74E11C")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x20000BF")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x20000C0")]
	public enum ButtonType
	{
		[Token(Token = "0x4000417")]
		Play,
		[Token(Token = "0x4000418")]
		Pause,
		[Token(Token = "0x4000419")]
		FastForward,
		[Token(Token = "0x400041A")]
		Rewind,
		[Token(Token = "0x400041B")]
		SkipForward,
		[Token(Token = "0x400041C")]
		SkipBack,
		[Token(Token = "0x400041D")]
		Stop
	}

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x1700003D")]
	public ButtonType buttonType
	{
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x91A2FC", Offset = "0x91A2FC", VA = "0x91A2FC")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x91A304", Offset = "0x91A304", VA = "0x91A304")]
		set
		{
		}
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x91A328", Offset = "0x91A328", VA = "0x91A328", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x91B7C0", Offset = "0x91B7C0", VA = "0x91B7C0")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x20000C1")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x20000C2")]
	public enum VideoShape
	{
		[Token(Token = "0x4000432")]
		_360,
		[Token(Token = "0x4000433")]
		_180,
		[Token(Token = "0x4000434")]
		Quad
	}

	[Token(Token = "0x20000C3")]
	public enum VideoStereo
	{
		[Token(Token = "0x4000436")]
		Mono,
		[Token(Token = "0x4000437")]
		TopBottom,
		[Token(Token = "0x4000438")]
		LeftRight,
		[Token(Token = "0x4000439")]
		BottomTop
	}

	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C7E4", Offset = "0x46C7E4")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000041")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x9AC714", Offset = "0x9AC714", VA = "0x9AC714", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x9AC75C", Offset = "0x9AC75C", VA = "0x9AC75C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x9AC520", Offset = "0x9AC520", VA = "0x9AC520")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x9AC54C", Offset = "0x9AC54C", VA = "0x9AC54C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x9AC550", Offset = "0x9AC550", VA = "0x9AC550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x9AC71C", Offset = "0x9AC71C", VA = "0x9AC71C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C7F4", Offset = "0x46C7F4")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x9AC428", Offset = "0x9AC428", VA = "0x9AC428")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x9AC430", Offset = "0x9AC430", VA = "0x9AC430")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46DCFC", Offset = "0x46DCFC")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46DD0C", Offset = "0x46DD0C")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46DD1C", Offset = "0x46DD1C")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x1700003E")]
	public bool IsPlaying
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x91C5A0", Offset = "0x91C5A0", VA = "0x91C5A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47199C", Offset = "0x47199C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x91C5A8", Offset = "0x91C5A8", VA = "0x91C5A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4719AC", Offset = "0x4719AC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public long Duration
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x91C5B4", Offset = "0x91C5B4", VA = "0x91C5B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4719BC", Offset = "0x4719BC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x91C5BC", Offset = "0x91C5BC", VA = "0x91C5BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4719CC", Offset = "0x4719CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public long PlaybackPosition
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x91C5C4", Offset = "0x91C5C4", VA = "0x91C5C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4719DC", Offset = "0x4719DC")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x91C5CC", Offset = "0x91C5CC", VA = "0x91C5CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4719EC", Offset = "0x4719EC")]
		private set
		{
		}
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x91C5D4", Offset = "0x91C5D4", VA = "0x91C5D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x91C8EC", Offset = "0x91C8EC", VA = "0x91C8EC")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x91C950", Offset = "0x91C950", VA = "0x91C950")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x91CFB8", Offset = "0x91CFB8", VA = "0x91CFB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4719FC", Offset = "0x4719FC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x91D030", Offset = "0x91D030", VA = "0x91D030")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x91D318", Offset = "0x91D318", VA = "0x91D318")]
	public void Play()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x91D4BC", Offset = "0x91D4BC", VA = "0x91D4BC")]
	public void Pause()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x91D65C", Offset = "0x91D65C", VA = "0x91D65C")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x91D8D0", Offset = "0x91D8D0", VA = "0x91D8D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x91E3B0", Offset = "0x91E3B0", VA = "0x91E3B0")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x91E5E0", Offset = "0x91E5E0", VA = "0x91E5E0")]
	public void Stop()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x91E780", Offset = "0x91E780", VA = "0x91E780")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x91E86C", Offset = "0x91E86C", VA = "0x91E86C")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20000C6")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x20000C7")]
	private enum PlaybackState
	{
		[Token(Token = "0x4000456")]
		Playing,
		[Token(Token = "0x4000457")]
		Paused,
		[Token(Token = "0x4000458")]
		Rewinding,
		[Token(Token = "0x4000459")]
		FastForwarding
	}

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x91E87C", Offset = "0x91E87C", VA = "0x91E87C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x91EBD0", Offset = "0x91EBD0", VA = "0x91EBD0")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x91EDAC", Offset = "0x91EDAC", VA = "0x91EDAC")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x91EEE0", Offset = "0x91EEE0", VA = "0x91EEE0")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x91EFE8", Offset = "0x91EFE8", VA = "0x91EFE8")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x91EEB4", Offset = "0x91EEB4", VA = "0x91EEB4")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x91F048", Offset = "0x91F048", VA = "0x91F048")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x91EABC", Offset = "0x91EABC", VA = "0x91EABC")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x91F3AC", Offset = "0x91F3AC", VA = "0x91F3AC")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20000C8")]
public static class VectorUtil
{
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x8A0490", Offset = "0x8A0490", VA = "0x8A0490")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000C9")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x400045A")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x400045B")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x74874C", Offset = "0x74874C", VA = "0x74874C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x749778", Offset = "0x749778", VA = "0x749778")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x749BB8", Offset = "0x749BB8", VA = "0x749BB8")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x749D20", Offset = "0x749D20", VA = "0x749D20")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x749E8C", Offset = "0x749E8C", VA = "0x749E8C")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x74A01C", Offset = "0x74A01C", VA = "0x74A01C")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x20000CA")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x4000464")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x75ACAC", Offset = "0x75ACAC", VA = "0x75ACAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x75AD00", Offset = "0x75AD00", VA = "0x75AD00")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x75AD04", Offset = "0x75AD04", VA = "0x75AD04")]
	private void Update()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x7490A0", Offset = "0x7490A0", VA = "0x7490A0")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x75AD08", Offset = "0x75AD08", VA = "0x75AD08")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x75AF38", Offset = "0x75AF38", VA = "0x75AF38")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x20000CB")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x75C434", Offset = "0x75C434", VA = "0x75C434")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x75C950", Offset = "0x75C950", VA = "0x75C950")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x75CA10", Offset = "0x75CA10", VA = "0x75CA10")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x75CC90", Offset = "0x75CC90", VA = "0x75CC90")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x75CD70", Offset = "0x75CD70", VA = "0x75CD70")]
	private void Update()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x75CE54", Offset = "0x75CE54", VA = "0x75CE54")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x75CEC8", Offset = "0x75CEC8", VA = "0x75CEC8")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x75CED0", Offset = "0x75CED0", VA = "0x75CED0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x471ABC", Offset = "0x471ABC")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x75CF34", Offset = "0x75CF34", VA = "0x75CF34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x471ACC", Offset = "0x471ACC")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x75CF98", Offset = "0x75CF98", VA = "0x75CF98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x471ADC", Offset = "0x471ADC")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x75CFFC", Offset = "0x75CFFC", VA = "0x75CFFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x471AEC", Offset = "0x471AEC")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x20000CC")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x7463AC", Offset = "0x7463AC", VA = "0x7463AC")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x20000CD")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x7B6404", Offset = "0x7B6404", VA = "0x7B6404")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x7B64A8", Offset = "0x7B64A8", VA = "0x7B64A8")]
	private void Update()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x7B6594", Offset = "0x7B6594", VA = "0x7B6594")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x7B65F4", Offset = "0x7B65F4", VA = "0x7B65F4")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x20000CE")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x897A14", Offset = "0x897A14", VA = "0x897A14")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x20000CF")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C814", Offset = "0x46C814")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000043")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x9A9398", Offset = "0x9A9398", VA = "0x9A9398", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x9A93E0", Offset = "0x9A93E0", VA = "0x9A93E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x9A921C", Offset = "0x9A921C", VA = "0x9A921C")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x9A9248", Offset = "0x9A9248", VA = "0x9A9248", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x9A924C", Offset = "0x9A924C", VA = "0x9A924C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x9A93A0", Offset = "0x9A93A0", VA = "0x9A93A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x864404", Offset = "0x864404", VA = "0x864404")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x864520", Offset = "0x864520", VA = "0x864520")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x8644A8", Offset = "0x8644A8", VA = "0x8644A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x471AFC", Offset = "0x471AFC")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x8646CC", Offset = "0x8646CC", VA = "0x8646CC")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000D1")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46DD4C", Offset = "0x46DD4C")]
	public int SubdivisionsU;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46DD68", Offset = "0x46DD68")]
	public int SubdivisionsV;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x757004", Offset = "0x757004", VA = "0x757004")]
	private void Update()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x757A4C", Offset = "0x757A4C", VA = "0x757A4C")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000D2")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x17000045")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x868A2C", Offset = "0x868A2C", VA = "0x868A2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x868A80", Offset = "0x868A80", VA = "0x868A80")]
	public void Start()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x868EA8", Offset = "0x868EA8", VA = "0x868EA8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x868F94", Offset = "0x868F94", VA = "0x868F94")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x471BAC", Offset = "0x471BAC")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x6000309")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600030A")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x600030B")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x600030C")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x600030D")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x600030E")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x600030F")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x6000310")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x868FF8", Offset = "0x868FF8", VA = "0x868FF8")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x869034", Offset = "0x869034", VA = "0x869034")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x8690A4", Offset = "0x8690A4", VA = "0x8690A4")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x869214", Offset = "0x869214", VA = "0x869214")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x8692F0", Offset = "0x8692F0", VA = "0x8692F0")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x868DA0", Offset = "0x868DA0", VA = "0x868DA0")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x8693B8", Offset = "0x8693B8", VA = "0x8693B8")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x869420", Offset = "0x869420", VA = "0x869420")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x869518", Offset = "0x869518", VA = "0x869518")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000D3")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x46C834", Offset = "0x46C834")]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20000D4")]
	public enum DrawMode
	{
		[Token(Token = "0x4000493")]
		Opaque,
		[Token(Token = "0x4000494")]
		OpaqueWithClip,
		[Token(Token = "0x4000495")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000496")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private Shader _transparentShader;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x17000046")]
	public bool overlayEnabled
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x92146C", Offset = "0x92146C", VA = "0x92146C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x9214FC", Offset = "0x9214FC", VA = "0x9214FC")]
		set
		{
		}
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x91FEE8", Offset = "0x91FEE8", VA = "0x91FEE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x920AD8", Offset = "0x920AD8", VA = "0x920AD8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x920B58", Offset = "0x920B58", VA = "0x920B58")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x920C48", Offset = "0x920C48", VA = "0x920C48")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x920D38", Offset = "0x920D38", VA = "0x920D38", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x920F44", Offset = "0x920F44", VA = "0x920F44")]
	private void Update()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x9215C8", Offset = "0x9215C8", VA = "0x9215C8")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000D5")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x74A02C", Offset = "0x74A02C", VA = "0x74A02C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x74A214", Offset = "0x74A214", VA = "0x74A214")]
	private void Update()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x74A39C", Offset = "0x74A39C", VA = "0x74A39C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x74A3A4", Offset = "0x74A3A4", VA = "0x74A3A4")]
	public void Release()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x74A38C", Offset = "0x74A38C", VA = "0x74A38C")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x74A3AC", Offset = "0x74A3AC", VA = "0x74A3AC")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x20000D6")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x20000D7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C894", Offset = "0x46C894")]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000047")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x9A53E0", Offset = "0x9A53E0", VA = "0x9A53E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x9A5428", Offset = "0x9A5428", VA = "0x9A5428", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x9A52B0", Offset = "0x9A52B0", VA = "0x9A52B0")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x9A52DC", Offset = "0x9A52DC", VA = "0x9A52DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x9A52E0", Offset = "0x9A52E0", VA = "0x9A52E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x9A53E8", Offset = "0x9A53E8", VA = "0x9A53E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C8A4", Offset = "0x46C8A4")]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x9A55E8", Offset = "0x9A55E8", VA = "0x9A55E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x9A5630", Offset = "0x9A5630", VA = "0x9A5630", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x9A5430", Offset = "0x9A5430", VA = "0x9A5430")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x9A545C", Offset = "0x9A545C", VA = "0x9A545C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x9A5460", Offset = "0x9A5460", VA = "0x9A5460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x9A55F0", Offset = "0x9A55F0", VA = "0x9A55F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x74C05C", Offset = "0x74C05C", VA = "0x74C05C")]
	private void Start()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x74C330", Offset = "0x74C330", VA = "0x74C330")]
	private void Update()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x74C38C", Offset = "0x74C38C", VA = "0x74C38C")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x74C50C", Offset = "0x74C50C", VA = "0x74C50C")]
	public void Release()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x74C5E0", Offset = "0x74C5E0", VA = "0x74C5E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x471BE4", Offset = "0x471BE4")]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x74C448", Offset = "0x74C448", VA = "0x74C448")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x471C44", Offset = "0x471C44")]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x74C67C", Offset = "0x74C67C", VA = "0x74C67C")]
	public BrushController()
	{
	}
}
[Token(Token = "0x20000D9")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x859224", Offset = "0x859224", VA = "0x859224")]
	private void Start()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x859284", Offset = "0x859284", VA = "0x859284")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x20000DA")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x40004AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x85B884", Offset = "0x85B884", VA = "0x85B884")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x85B9B8", Offset = "0x85B9B8", VA = "0x85B9B8")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x85BA4C", Offset = "0x85BA4C", VA = "0x85BA4C")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x85BAB4", Offset = "0x85BAB4", VA = "0x85BAB4")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x20000DB")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C8B4", Offset = "0x46C8B4")]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x9A85F4", Offset = "0x9A85F4", VA = "0x9A85F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x9A863C", Offset = "0x9A863C", VA = "0x9A863C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x9A83E8", Offset = "0x9A83E8", VA = "0x9A83E8")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x9A8414", Offset = "0x9A8414", VA = "0x9A8414", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x9A8418", Offset = "0x9A8418", VA = "0x9A8418", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x9A85FC", Offset = "0x9A85FC", VA = "0x9A85FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x85BABC", Offset = "0x85BABC", VA = "0x85BABC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x85BDA0", Offset = "0x85BDA0", VA = "0x85BDA0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x85C0F0", Offset = "0x85C0F0", VA = "0x85C0F0")]
	private void FindHands()
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x85C44C", Offset = "0x85C44C", VA = "0x85C44C")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x85C750", Offset = "0x85C750", VA = "0x85C750")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x85C844", Offset = "0x85C844", VA = "0x85C844")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x85CA10", Offset = "0x85CA10", VA = "0x85CA10")]
	public void Release()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x85C95C", Offset = "0x85C95C", VA = "0x85C95C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x471D44", Offset = "0x471D44")]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x85CAF8", Offset = "0x85CAF8", VA = "0x85CAF8")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x20000DD")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x20000DE")]
	public enum ManipulationType
	{
		[Token(Token = "0x40004CB")]
		Default,
		[Token(Token = "0x40004CC")]
		ForcedHand,
		[Token(Token = "0x40004CD")]
		DollyHand,
		[Token(Token = "0x40004CE")]
		DollyAttached,
		[Token(Token = "0x40004CF")]
		HorizontalScaled,
		[Token(Token = "0x40004D0")]
		VerticalScaled,
		[Token(Token = "0x40004D1")]
		Menu
	}

	[Token(Token = "0x20000DF")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x20000E0")]
	public delegate void ReleasedObject();

	[Token(Token = "0x20000E1")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x46DDF4", Offset = "0x46DDF4")]
	public string ObjectName;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x46DE04", Offset = "0x46DE04")]
	public string ObjectInstructions;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x85DCF8", Offset = "0x85DCF8", VA = "0x85DCF8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x85DD54", Offset = "0x85DD54", VA = "0x85DD54")]
	public void Release()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x85DD68", Offset = "0x85DD68", VA = "0x85DD68")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x85DD7C", Offset = "0x85DD7C", VA = "0x85DD7C")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x20000E2")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DE24", Offset = "0x46DE24")]
	public int radialDivisions;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DE5C", Offset = "0x46DE5C")]
	public float borderSize;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DE94", Offset = "0x46DE94")]
	public float fingerTaper;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DECC", Offset = "0x46DECC")]
	public float fingerTipLength;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46DF04", Offset = "0x46DF04")]
	public float webOffset;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x85F8C8", Offset = "0x85F8C8", VA = "0x85F8C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x85FAC8", Offset = "0x85FAC8", VA = "0x85FAC8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x85FCD4", Offset = "0x85FCD4", VA = "0x85FCD4")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x860358", Offset = "0x860358", VA = "0x860358")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x860988", Offset = "0x860988", VA = "0x860988")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x863004", Offset = "0x863004", VA = "0x863004")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x8630C0", Offset = "0x8630C0", VA = "0x8630C0")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x20000E3")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x8630E4", Offset = "0x8630E4", VA = "0x8630E4")]
	private void Start()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x86341C", Offset = "0x86341C", VA = "0x86341C")]
	private void Update()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x86318C", Offset = "0x86318C", VA = "0x86318C")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x86380C", Offset = "0x86380C", VA = "0x86380C")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x863CFC", Offset = "0x863CFC", VA = "0x863CFC")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x20000E4")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C8C4", Offset = "0x46C8C4")]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x9ACCB4", Offset = "0x9ACCB4", VA = "0x9ACCB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x9ACCFC", Offset = "0x9ACCFC", VA = "0x9ACCFC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x9AC9E4", Offset = "0x9AC9E4", VA = "0x9AC9E4")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x9ACA10", Offset = "0x9ACA10", VA = "0x9ACA10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x9ACA14", Offset = "0x9ACA14", VA = "0x9ACA14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x9ACCBC", Offset = "0x9ACCBC", VA = "0x9ACCBC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x922AF8", Offset = "0x922AF8", VA = "0x922AF8")]
	private void Start()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x922D30", Offset = "0x922D30", VA = "0x922D30")]
	private void Update()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x923980", Offset = "0x923980", VA = "0x923980")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x924588", Offset = "0x924588", VA = "0x924588")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x922CB8", Offset = "0x922CB8", VA = "0x922CB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x471DF4", Offset = "0x471DF4")]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x922F9C", Offset = "0x922F9C", VA = "0x922F9C")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x923C44", Offset = "0x923C44", VA = "0x923C44")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x92484C", Offset = "0x92484C", VA = "0x92484C")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x9248D8", Offset = "0x9248D8", VA = "0x9248D8")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x924908", Offset = "0x924908", VA = "0x924908")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x924714", Offset = "0x924714", VA = "0x924714")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x924A2C", Offset = "0x924A2C", VA = "0x924A2C")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x20000E6")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x924AC8", Offset = "0x924AC8", VA = "0x924AC8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x924C60", Offset = "0x924C60", VA = "0x924C60")]
	private void Update()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x924D28", Offset = "0x924D28", VA = "0x924D28")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x20000E7")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x20000E8")]
	public enum BrushState
	{
		[Token(Token = "0x400050E")]
		Idle,
		[Token(Token = "0x400050F")]
		Inking
	}

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x7AD844", Offset = "0x7AD844", VA = "0x7AD844")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x7AD84C", Offset = "0x7AD84C", VA = "0x7AD84C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x7ADB34", Offset = "0x7ADB34", VA = "0x7ADB34")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x7ADD2C", Offset = "0x7ADD2C", VA = "0x7ADD2C")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x7ADED4", Offset = "0x7ADED4", VA = "0x7ADED4")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x7ADA40", Offset = "0x7ADA40", VA = "0x7ADA40")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x7ADFB0", Offset = "0x7ADFB0", VA = "0x7ADFB0")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x20000E9")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x7AE048", Offset = "0x7AE048", VA = "0x7AE048")]
	private void Start()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x7AE1E0", Offset = "0x7AE1E0", VA = "0x7AE1E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x7AE344", Offset = "0x7AE344", VA = "0x7AE344")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x20000EA")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x7AE34C", Offset = "0x7AE34C", VA = "0x7AE34C")]
	private void Start()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x7AE560", Offset = "0x7AE560", VA = "0x7AE560")]
	private void Update()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x7AE730", Offset = "0x7AE730", VA = "0x7AE730")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x20000EB")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C8D4", Offset = "0x46C8D4")]
	private sealed class <FadeToCurrentStyle>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x9AE680", Offset = "0x9AE680", VA = "0x9AE680", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x9AE6C8", Offset = "0x9AE6C8", VA = "0x9AE6C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9AE49C", Offset = "0x9AE49C", VA = "0x9AE49C")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9AE4C8", Offset = "0x9AE4C8", VA = "0x9AE4C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x9AE4CC", Offset = "0x9AE4CC", VA = "0x9AE4CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x9AE688", Offset = "0x9AE688", VA = "0x9AE688", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C8E4", Offset = "0x46C8E4")]
	private sealed class <FadeToDefaultPassthrough>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x17000051")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x9AE8F4", Offset = "0x9AE8F4", VA = "0x9AE8F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x9AE93C", Offset = "0x9AE93C", VA = "0x9AE93C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x9AE6D0", Offset = "0x9AE6D0", VA = "0x9AE6D0")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x9AE6FC", Offset = "0x9AE6FC", VA = "0x9AE6FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x9AE700", Offset = "0x9AE700", VA = "0x9AE700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x9AE8FC", Offset = "0x9AE8FC", VA = "0x9AE8FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float savedPosterize;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] compactObjects;

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x7AE738", Offset = "0x7AE738", VA = "0x7AE738")]
	private void Start()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x7AEA70", Offset = "0x7AEA70", VA = "0x7AEA70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x7AECC8", Offset = "0x7AECC8", VA = "0x7AECC8")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x7AEE4C", Offset = "0x7AEE4C", VA = "0x7AEE4C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x7AEDC4", Offset = "0x7AEDC4", VA = "0x7AEDC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x471EA4", Offset = "0x471EA4")]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x7AEF3C", Offset = "0x7AEF3C", VA = "0x7AEF3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x471F04", Offset = "0x471F04")]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x7AEFC4", Offset = "0x7AEFC4", VA = "0x7AEFC4")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x7AEFE4", Offset = "0x7AEFE4", VA = "0x7AEFE4")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x7AF004", Offset = "0x7AF004", VA = "0x7AF004")]
	public void OnPosterizeChanged(float newValue)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x7AF024", Offset = "0x7AF024", VA = "0x7AF024")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x7AE9F4", Offset = "0x7AE9F4", VA = "0x7AE9F4")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x7AF088", Offset = "0x7AF088", VA = "0x7AF088")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x7AF094", Offset = "0x7AF094", VA = "0x7AF094")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x7AEA88", Offset = "0x7AEA88", VA = "0x7AEA88")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x7AF0A0", Offset = "0x7AF0A0", VA = "0x7AF0A0")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x20000EE")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x7AF0E4", Offset = "0x7AF0E4", VA = "0x7AF0E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x7AF1A4", Offset = "0x7AF1A4", VA = "0x7AF1A4")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x20000EF")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x7B6114", Offset = "0x7B6114", VA = "0x7B6114")]
	private void Start()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x7B6358", Offset = "0x7B6358", VA = "0x7B6358")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x7B63B0", Offset = "0x7B63B0", VA = "0x7B63B0")]
	public void Release()
	{
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x7B63FC", Offset = "0x7B63FC", VA = "0x7B63FC")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x20000F0")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x7B65FC", Offset = "0x7B65FC", VA = "0x7B65FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x7B6674", Offset = "0x7B6674", VA = "0x7B6674")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x7B6998", Offset = "0x7B6998", VA = "0x7B6998")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x20000F1")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x890CE4", Offset = "0x890CE4", VA = "0x890CE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x89116C", Offset = "0x89116C", VA = "0x89116C")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x20000F2")]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong anchorHandle_;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas canvas_;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform pivot_;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject anchorMenu_;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isSelected_;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isHovered_;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI anchorName_;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject saveIcon_;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image labelImage_;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color labelBaseColor_;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Color labelHighlightColor_;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Color labelSelectedColor_;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AnchorUIManager uiManager_;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private MeshRenderer[] renderers_;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int menuIndex_;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Button selectedButton_;

	[Token(Token = "0x17000053")]
	public ulong anchorHandle
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x7463B4", Offset = "0x7463B4", VA = "0x7463B4")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x7463BC", Offset = "0x7463BC", VA = "0x7463BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x7464A4", Offset = "0x7464A4", VA = "0x7464A4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x74670C", Offset = "0x74670C", VA = "0x74670C")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x746774", Offset = "0x746774", VA = "0x746774")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x7467D8", Offset = "0x7467D8", VA = "0x7467D8")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x74683C", Offset = "0x74683C", VA = "0x74683C")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x746944", Offset = "0x746944", VA = "0x746944")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x746A64", Offset = "0x746A64", VA = "0x746A64")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x746B98", Offset = "0x746B98", VA = "0x746B98")]
	public void SetAnchorHandle(ulong handle)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x746C2C", Offset = "0x746C2C", VA = "0x746C2C")]
	public void ShowSaveIcon()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x7464E8", Offset = "0x7464E8", VA = "0x7464E8")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x7465FC", Offset = "0x7465FC", VA = "0x7465FC")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x746C4C", Offset = "0x746C4C", VA = "0x746C4C")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x746D64", Offset = "0x746D64", VA = "0x746D64")]
	public Anchor()
	{
	}
}
[Token(Token = "0x20000F3")]
public class AnchorHelpers
{
	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera camera;

	[Token(Token = "0x17000054")]
	private static Camera MainCamera
	{
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x746D6C", Offset = "0x746D6C", VA = "0x746D6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x746E24", Offset = "0x746E24", VA = "0x746E24")]
	public static OVRPlugin.Posef UnityWorldSpacePoseToTrackingSpacePose(Transform pose)
	{
		return default(OVRPlugin.Posef);
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x746EA0", Offset = "0x746EA0", VA = "0x746EA0")]
	public static OVRPose TrackingSpacePoseToUnityWorldSpacePose(OVRPlugin.Posef pose)
	{
		return default(OVRPose);
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x746F14", Offset = "0x746F14", VA = "0x746F14")]
	public static OVRPose getTransformUnityWorldFromDevice()
	{
		return default(OVRPose);
	}

	[Token(Token = "0x60003C9")]
	public static T ByteArrayToStruct<T>(byte[] bytes) where T : struct
	{
		return (T)null;
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x746F6C", Offset = "0x746F6C", VA = "0x746F6C")]
	public static string UuidToString(byte[] encodedMessage)
	{
		return null;
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x747210", Offset = "0x747210", VA = "0x747210")]
	public static byte[] StringToUuid(string str)
	{
		return null;
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x747388", Offset = "0x747388", VA = "0x747388")]
	private static int GetHexVal(char hex)
	{
		return default(int);
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x74744C", Offset = "0x74744C", VA = "0x74744C")]
	public AnchorHelpers()
	{
	}
}
[Token(Token = "0x20000F4")]
public abstract class AnchorSession : MonoBehaviour
{
	[Token(Token = "0x20000F5")]
	public enum StorageLocation
	{
		[Token(Token = "0x4000557")]
		LOCAL
	}

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSession Instance;

	[Token(Token = "0x4000551")]
	public const ulong kInvalidHandle = ulong.MaxValue;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<ulong, Anchor> handleToAnchor;

	[Token(Token = "0x4000553")]
	protected const int maxEvents = 5;

	[Token(Token = "0x4000554")]
	protected const float eventPollingRate = 0.1f;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected GameObject anchorPrefab_;

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x747454", Offset = "0x747454", VA = "0x747454", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x747180", Offset = "0x747180", VA = "0x747180")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x74755C", Offset = "0x74755C", VA = "0x74755C")]
	protected static bool isFlagSet(uint bitset, uint flag)
	{
		return default(bool);
	}

	[Token(Token = "0x60003D1")]
	public abstract ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor);

	[Token(Token = "0x60003D2")]
	public abstract void DestroyAnchor(ulong anchorHandle);

	[Token(Token = "0x60003D3")]
	public abstract void SaveAnchor(ulong anchorHandle, StorageLocation location);

	[Token(Token = "0x60003D4")]
	public abstract void EraseAnchor(ulong anchorHandle);

	[Token(Token = "0x60003D5")]
	public abstract void QueryAllLocalAnchors();

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x747568", Offset = "0x747568", VA = "0x747568")]
	protected AnchorSession()
	{
	}
}
[Token(Token = "0x20000F6")]
public class AnchorSpawner : MonoBehaviour
{
	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSpawner Instance;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject anchorPrefab_;

	[Token(Token = "0x17000055")]
	public GameObject AnchorPrefab
	{
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x7475EC", Offset = "0x7475EC", VA = "0x7475EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x7475F4", Offset = "0x7475F4", VA = "0x7475F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x7476F4", Offset = "0x7476F4", VA = "0x7476F4")]
	public void PlaceAnchorAtTransform(Transform transform)
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x747928", Offset = "0x747928", VA = "0x747928")]
	public AnchorSpawner()
	{
	}
}
[Token(Token = "0x20000F7")]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000F8")]
	public enum AnchorMode
	{
		[Token(Token = "0x400056D")]
		Create,
		[Token(Token = "0x400056E")]
		Select
	}

	[Token(Token = "0x20000F9")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject mainMenu_;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject createModeButton_;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject selectModeButton_;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform trackedDevice_;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform raycastOrigin_;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool drawRaycast_;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LineRenderer lineRenderer_;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor hoveredAnchor_;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Anchor selectedAnchor_;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AnchorMode mode_;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int menuIndex_;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Button selectedButton_;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject placementPreview_;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform anchorPlacementTransform_;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate primaryPressDelegate_;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool isFocused_;

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x747930", Offset = "0x747930", VA = "0x747930")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x747A08", Offset = "0x747A08", VA = "0x747A08")]
	private void Start()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x747B74", Offset = "0x747B74", VA = "0x747B74")]
	private void Update()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x747FC8", Offset = "0x747FC8", VA = "0x747FC8")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x748038", Offset = "0x748038", VA = "0x748038")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x747AFC", Offset = "0x747AFC", VA = "0x747AFC")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x7480C0", Offset = "0x7480C0", VA = "0x7480C0")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x748148", Offset = "0x748148", VA = "0x748148")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x748174", Offset = "0x748174", VA = "0x748174")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x748094", Offset = "0x748094", VA = "0x748094")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x747EB8", Offset = "0x747EB8", VA = "0x747EB8")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x7482B0", Offset = "0x7482B0", VA = "0x7482B0")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x7481FC", Offset = "0x7481FC", VA = "0x7481FC")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x74821C", Offset = "0x74821C", VA = "0x74821C")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x7483C8", Offset = "0x7483C8", VA = "0x7483C8")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x74823C", Offset = "0x74823C", VA = "0x74823C")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x748278", Offset = "0x748278", VA = "0x748278")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x747C80", Offset = "0x747C80", VA = "0x747C80")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x748424", Offset = "0x748424", VA = "0x748424")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x748458", Offset = "0x748458", VA = "0x748458")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x7484F4", Offset = "0x7484F4", VA = "0x7484F4")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x748670", Offset = "0x748670", VA = "0x748670")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000FA")]
public class SpatialAnchorSession : AnchorSession
{
	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Dictionary<ulong, ulong> locateAnchorRequest;

	[Token(Token = "0x4000570")]
	private const string numUuids = "numUuids";

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x895420", Offset = "0x895420", VA = "0x895420")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x89566C", Offset = "0x89566C", VA = "0x89566C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x8958B8", Offset = "0x8958B8", VA = "0x8958B8")]
	private void SpatialEntitySetComponentEnabled(ulong requestId, bool result, OVRPlugin.SpatialEntityComponentType componentType, ulong space)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x895AC8", Offset = "0x895AC8", VA = "0x895AC8")]
	private void SpatialAnchorSaved(ulong requestId, ulong space, bool result, OVRPlugin.SpatialEntityUuid uuid)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x895FB8", Offset = "0x895FB8", VA = "0x895FB8")]
	private void SpatialEntityStorageErase(ulong requestId, bool result, OVRPlugin.SpatialEntityUuid uuid, OVRPlugin.SpatialEntityStorageLocation location)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x8962E8", Offset = "0x8962E8", VA = "0x8962E8")]
	private void SpatialEntityQueryResults(ulong requestId, int numResults, OVRPlugin.SpatialEntityQueryResult[] results)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x896A0C", Offset = "0x896A0C", VA = "0x896A0C")]
	private void SpatialEntityQueryComplete(ulong requestId, bool result, int numFound)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x895EDC", Offset = "0x895EDC", VA = "0x895EDC")]
	private string GetUuidString(OVRPlugin.SpatialEntityUuid uuid)
	{
		return null;
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x8965D0", Offset = "0x8965D0", VA = "0x8965D0")]
	private void tryEnableComponent(ulong anchorHandle, OVRPlugin.SpatialEntityComponentType type)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x8959A8", Offset = "0x8959A8", VA = "0x8959A8")]
	private void CreateAnchorGameobject(ulong anchorHandle)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x896C60", Offset = "0x896C60", VA = "0x896C60")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x896F10", Offset = "0x896F10", VA = "0x896F10", Slot = "5")]
	public override ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x8970B0", Offset = "0x8970B0", VA = "0x8970B0", Slot = "6")]
	public override void DestroyAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x89726C", Offset = "0x89726C", VA = "0x89726C", Slot = "8")]
	public override void EraseAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x897438", Offset = "0x897438", VA = "0x897438")]
	public void QueryAnchorByUuid()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x897730", Offset = "0x897730", VA = "0x897730", Slot = "9")]
	public override void QueryAllLocalAnchors()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x897820", Offset = "0x897820", VA = "0x897820", Slot = "7")]
	public override void SaveAnchor(ulong anchorHandle, StorageLocation location)
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x897990", Offset = "0x897990", VA = "0x897990")]
	public SpatialAnchorSession()
	{
	}
}
[Token(Token = "0x20000FB")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46C8F4", Offset = "0x46C8F4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x9AF1B8", Offset = "0x9AF1B8", VA = "0x9AF1B8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x9AF1C0", Offset = "0x9AF1C0", VA = "0x9AF1C0")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x897A1C", Offset = "0x897A1C", VA = "0x897A1C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x897C38", Offset = "0x897C38", VA = "0x897C38")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x897D48", Offset = "0x897D48", VA = "0x897D48")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000FD")]
public class Rotation : MonoBehaviour
{
	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 vectorRotation;

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x7B60A0", Offset = "0x7B60A0", VA = "0x7B60A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x7B60A4", Offset = "0x7B60A4", VA = "0x7B60A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x7B610C", Offset = "0x7B610C", VA = "0x7B610C")]
	public Rotation()
	{
	}
}
[Token(Token = "0x20000FE")]
public class ExampleWheelController : MonoBehaviour
{
	[Token(Token = "0x20000FF")]
	private static class Uniforms
	{
		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly int _MotionAmount;
	}

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float acceleration;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer motionVectorRenderer;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Rigidbody m_Rigidbody;

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x85928C", Offset = "0x85928C", VA = "0x85928C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x859304", Offset = "0x859304", VA = "0x859304")]
	private void Update()
	{
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x859480", Offset = "0x859480", VA = "0x859480")]
	public ExampleWheelController()
	{
	}
}
[Token(Token = "0x2000100")]
public class FPSController : MonoBehaviour
{
	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController characterController;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46E08C", Offset = "0x46E08C")]
	public float walkSpeed;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float runSpeed;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float jumpSpeed;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float gravity;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x46E0C4", Offset = "0x46E0C4")]
	public Camera cam;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float mouseHorizontal;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float mouseVertical;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float minRotation;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float maxRotation;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float h_mouse;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float v_mouse;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 move;

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x85A510", Offset = "0x85A510", VA = "0x85A510")]
	private void Start()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x85A578", Offset = "0x85A578", VA = "0x85A578")]
	private void Update()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x85A79C", Offset = "0x85A79C", VA = "0x85A79C")]
	public FPSController()
	{
	}
}
[Token(Token = "0x2000101")]
public class RotateMoveCamera : MonoBehaviour
{
	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Camera;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minX;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float maxX;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float minY;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float maxY;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sensX;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float sensY;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float rotationY;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float rotationX;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float MouseX;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float MouseY;

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x7B5E68", Offset = "0x7B5E68", VA = "0x7B5E68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x7B6080", Offset = "0x7B6080", VA = "0x7B6080")]
	public RotateMoveCamera()
	{
	}
}
[Token(Token = "0x2000102")]
public class buttonhandler : MonoBehaviour
{
	[Token(Token = "0x6000418")]
	[Address(RVA = "0x8A1A34", Offset = "0x8A1A34", VA = "0x8A1A34")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x8A1AD8", Offset = "0x8A1AD8", VA = "0x8A1AD8")]
	public buttonhandler()
	{
	}
}
[Token(Token = "0x2000103")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x46C904", Offset = "0x46C904")]
public class SimpleWater : MonoBehaviour
{
	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int xSize;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int ySize;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3[] vertices;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Mesh mesh;

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x891A8C", Offset = "0x891A8C", VA = "0x891A8C")]
	private void Start()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x891A90", Offset = "0x891A90", VA = "0x891A90")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x472004", Offset = "0x472004")]
	private void Generate()
	{
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x891F30", Offset = "0x891F30", VA = "0x891F30")]
	public SimpleWater()
	{
	}
}
namespace UnityEngine.PostProcessing
{
	[Token(Token = "0x2000104")]
	public sealed class GetSetAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string name;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool dirty;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x85DB50", Offset = "0x85DB50", VA = "0x85DB50")]
		public GetSetAttribute(string name)
		{
		}
	}
	[Token(Token = "0x2000105")]
	public sealed class MinAttribute : PropertyAttribute
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x91B824", Offset = "0x91B824", VA = "0x91B824")]
		public MinAttribute(float min)
		{
		}
	}
	[Token(Token = "0x2000106")]
	public sealed class TrackballAttribute : PropertyAttribute
	{
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string method;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x89DEB8", Offset = "0x89DEB8", VA = "0x89DEB8")]
		public TrackballAttribute(string method)
		{
		}
	}
	[Token(Token = "0x2000107")]
	public sealed class TrackballGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x89DEEC", Offset = "0x89DEEC", VA = "0x89DEEC")]
		public TrackballGroupAttribute()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public sealed class AmbientOcclusionComponent : PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
	{
		[Token(Token = "0x2000109")]
		private static class Uniforms
		{
			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _Intensity;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Radius;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _FogParams;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _Downsample;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _SampleCount;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _OcclusionTexture1;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _OcclusionTexture2;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _OcclusionTexture;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _MainTex;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _TempRT;
		}

		[Token(Token = "0x200010A")]
		private enum OcclusionSource
		{
			[Token(Token = "0x40005A9")]
			DepthTexture,
			[Token(Token = "0x40005AA")]
			DepthNormalsTexture,
			[Token(Token = "0x40005AB")]
			GBuffer
		}

		[Token(Token = "0x400059B")]
		private const string k_BlitShaderString = "Hidden/Post FX/Blit";

		[Token(Token = "0x400059C")]
		private const string k_ShaderString = "Hidden/Post FX/Ambient Occlusion";

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly RenderTargetIdentifier[] m_MRT;

		[Token(Token = "0x17000056")]
		private OcclusionSource occlusionSource
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x745550", Offset = "0x745550", VA = "0x745550")]
			get
			{
				return default(OcclusionSource);
			}
		}

		[Token(Token = "0x17000057")]
		private bool ambientOnlySupported
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x7455F8", Offset = "0x7455F8", VA = "0x7455F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public override bool active
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x74568C", Offset = "0x74568C", VA = "0x74568C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x745704", Offset = "0x745704", VA = "0x745704", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x745740", Offset = "0x745740", VA = "0x745740", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x745784", Offset = "0x745784", VA = "0x745784", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x7457F0", Offset = "0x7457F0", VA = "0x7457F0", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x746200", Offset = "0x746200", VA = "0x746200")]
		public AmbientOcclusionComponent()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
	{
		[Token(Token = "0x200010C")]
		private static class Uniforms
		{
			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _AutoExposure;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Threshold;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Curve;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _PrefilterOffs;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _SampleScale;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _BaseTex;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _BloomTex;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _Bloom_Settings;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _Bloom_DirtTex;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _Bloom_DirtIntensity;
		}

		[Token(Token = "0x40005AC")]
		private const int k_MaxPyramidBlurLevel = 16;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly RenderTexture[] m_BlurBuffer1;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly RenderTexture[] m_BlurBuffer2;

		[Token(Token = "0x17000059")]
		public override bool active
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x74ADC0", Offset = "0x74ADC0", VA = "0x74ADC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x74AE38", Offset = "0x74AE38", VA = "0x74AE38")]
		public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x74B824", Offset = "0x74B824", VA = "0x74B824")]
		public BloomComponent()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public sealed class BuiltinDebugViewsComponent : PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
	{
		[Token(Token = "0x200010E")]
		private static class Uniforms
		{
			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _DepthScale;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _TempRT;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Opacity;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _MainTex;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _TempRT2;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _Amplitude;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _Scale;
		}

		[Token(Token = "0x200010F")]
		private enum Pass
		{
			[Token(Token = "0x40005C3")]
			Depth,
			[Token(Token = "0x40005C4")]
			Normals,
			[Token(Token = "0x40005C5")]
			MovecOpacity,
			[Token(Token = "0x40005C6")]
			MovecImaging,
			[Token(Token = "0x40005C7")]
			MovecArrows
		}

		[Token(Token = "0x2000110")]
		private class ArrowArray
		{
			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46E0FC", Offset = "0x46E0FC")]
			private Mesh <mesh>k__BackingField;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46E10C", Offset = "0x46E10C")]
			private int <columnCount>k__BackingField;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46E11C", Offset = "0x46E11C")]
			private int <rowCount>k__BackingField;

			[Token(Token = "0x1700005B")]
			public Mesh mesh
			{
				[Token(Token = "0x600043A")]
				[Address(RVA = "0x9A5638", Offset = "0x9A5638", VA = "0x9A5638")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47203C", Offset = "0x47203C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600043B")]
				[Address(RVA = "0x9A5640", Offset = "0x9A5640", VA = "0x9A5640")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47204C", Offset = "0x47204C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005C")]
			public int columnCount
			{
				[Token(Token = "0x600043C")]
				[Address(RVA = "0x9A5648", Offset = "0x9A5648", VA = "0x9A5648")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47205C", Offset = "0x47205C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600043D")]
				[Address(RVA = "0x9A5650", Offset = "0x9A5650", VA = "0x9A5650")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47206C", Offset = "0x47206C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700005D")]
			public int rowCount
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x9A5658", Offset = "0x9A5658", VA = "0x9A5658")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47207C", Offset = "0x47207C")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x9A5660", Offset = "0x9A5660", VA = "0x9A5660")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47208C", Offset = "0x47208C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x9A5668", Offset = "0x9A5668", VA = "0x9A5668")]
			public void BuildMesh(int columns, int rows)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x9A5A28", Offset = "0x9A5A28", VA = "0x9A5A28")]
			public void Release()
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x9A5A5C", Offset = "0x9A5A5C", VA = "0x9A5A5C")]
			public ArrowArray()
			{
			}
		}

		[Token(Token = "0x40005B9")]
		private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ArrowArray m_Arrows;

		[Token(Token = "0x1700005A")]
		public override bool active
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x74C684", Offset = "0x74C684", VA = "0x74C684", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x74C6EC", Offset = "0x74C6EC", VA = "0x74C6EC", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x74C758", Offset = "0x74C758", VA = "0x74C758", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x74C7B4", Offset = "0x74C7B4", VA = "0x74C7B4", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x74C7F8", Offset = "0x74C7F8", VA = "0x74C7F8", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x74C91C", Offset = "0x74C91C", VA = "0x74C91C")]
		private void DepthPass(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x74CA48", Offset = "0x74CA48", VA = "0x74CA48")]
		private void DepthNormalsPass(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x74CB18", Offset = "0x74CB18", VA = "0x74CB18")]
		private void MotionVectorsPass(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x74D0A4", Offset = "0x74D0A4", VA = "0x74D0A4")]
		private void PrepareArrows()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x74D1B4", Offset = "0x74D1B4", VA = "0x74D1B4", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x74D1EC", Offset = "0x74D1EC", VA = "0x74D1EC")]
		public BuiltinDebugViewsComponent()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public sealed class ChromaticAberrationComponent : PostProcessingComponentRenderTexture<ChromaticAberrationModel>
	{
		[Token(Token = "0x2000112")]
		private static class Uniforms
		{
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _ChromaticAberration_Amount;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _ChromaticAberration_Spectrum;
		}

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture2D m_SpectrumLut;

		[Token(Token = "0x1700005E")]
		public override bool active
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x757A54", Offset = "0x757A54", VA = "0x757A54", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x757ACC", Offset = "0x757ACC", VA = "0x757ACC", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x757B00", Offset = "0x757B00", VA = "0x757B00", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x757E08", Offset = "0x757E08", VA = "0x757E08")]
		public ChromaticAberrationComponent()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
	{
		[Token(Token = "0x2000114")]
		private static class Uniforms
		{
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _LutParams;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _NeutralTonemapperParams1;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _NeutralTonemapperParams2;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _HueShift;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _Saturation;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _Contrast;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _Balance;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _Lift;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _InvGamma;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _Gain;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal static readonly int _Slope;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal static readonly int _Power;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal static readonly int _Offset;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal static readonly int _ChannelMixerRed;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal static readonly int _ChannelMixerGreen;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal static readonly int _ChannelMixerBlue;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal static readonly int _Curves;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal static readonly int _LogLut;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal static readonly int _LogLut_Params;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal static readonly int _ExposureEV;
		}

		[Token(Token = "0x40005CE")]
		private const int k_InternalLogLutSize = 32;

		[Token(Token = "0x40005CF")]
		private const int k_CurvePrecision = 128;

		[Token(Token = "0x40005D0")]
		private const float k_CurveStep = 1f / 128f;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture2D m_GradingCurves;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] m_pixels;

		[Token(Token = "0x1700005F")]
		public override bool active
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x7587D4", Offset = "0x7587D4", VA = "0x7587D4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x758840", Offset = "0x758840", VA = "0x758840")]
		private float StandardIlluminantY(float x)
		{
			return default(float);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x75886C", Offset = "0x75886C", VA = "0x75886C")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x7588FC", Offset = "0x7588FC", VA = "0x7588FC")]
		private Vector3 CalculateColorBalance(float temperature, float tint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x758A1C", Offset = "0x758A1C", VA = "0x758A1C")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x758AC4", Offset = "0x758AC4", VA = "0x758AC4")]
		private static Vector3 ClampVector(Vector3 v, float min, float max)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x758B48", Offset = "0x758B48", VA = "0x758B48")]
		public static Vector3 GetLiftValue(Color lift)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x758BAC", Offset = "0x758BAC", VA = "0x758BAC")]
		public static Vector3 GetGammaValue(Color gamma)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x758CA0", Offset = "0x758CA0", VA = "0x758CA0")]
		public static Vector3 GetGainValue(Color gain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x758D3C", Offset = "0x758D3C", VA = "0x758D3C")]
		public static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x758DE4", Offset = "0x758DE4", VA = "0x758DE4")]
		public static Vector3 GetSlopeValue(Color slope)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x758E60", Offset = "0x758E60", VA = "0x758E60")]
		public static Vector3 GetPowerValue(Color power)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x758F34", Offset = "0x758F34", VA = "0x758F34")]
		public static Vector3 GetOffsetValue(Color offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x758FA8", Offset = "0x758FA8", VA = "0x758FA8")]
		public static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x759050", Offset = "0x759050", VA = "0x759050")]
		private TextureFormat GetCurveFormat()
		{
			return default(TextureFormat);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x759084", Offset = "0x759084", VA = "0x759084")]
		private Texture2D GetCurveTexture()
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x759664", Offset = "0x759664", VA = "0x759664")]
		private bool IsLogLutValid(RenderTexture lut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x75970C", Offset = "0x75970C", VA = "0x75970C")]
		private RenderTextureFormat GetLutFormat()
		{
			return default(RenderTextureFormat);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x75973C", Offset = "0x75973C", VA = "0x75973C")]
		private void GenerateLut()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x759FC4", Offset = "0x759FC4", VA = "0x759FC4", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x75A1B4", Offset = "0x75A1B4", VA = "0x75A1B4")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x75A2E0", Offset = "0x75A2E0", VA = "0x75A2E0", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x75A368", Offset = "0x75A368", VA = "0x75A368")]
		public ColorGradingComponent()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
	{
		[Token(Token = "0x2000116")]
		private static class Uniforms
		{
			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _DepthOfFieldTex;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _DepthOfFieldCoCTex;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Distance;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _LensCoeff;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _MaxCoC;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _RcpMaxCoC;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _RcpAspect;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _MainTex;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _CoCTex;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _TaaParams;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal static readonly int _DepthOfFieldParams;
		}

		[Token(Token = "0x40005E7")]
		private const string k_ShaderString = "Hidden/Post FX/Depth Of Field";

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture m_CoCHistory;

		[Token(Token = "0x40005E9")]
		private const float k_FilmHeight = 0.024f;

		[Token(Token = "0x17000060")]
		public override bool active
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x8561DC", Offset = "0x8561DC", VA = "0x8561DC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x856248", Offset = "0x856248", VA = "0x856248", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x856250", Offset = "0x856250", VA = "0x856250")]
		private float CalculateFocalLength()
		{
			return default(float);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x8562F0", Offset = "0x8562F0", VA = "0x8562F0")]
		private float CalculateMaxCoCRadius(int screenHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x856370", Offset = "0x856370", VA = "0x856370")]
		private bool CheckHistory(int width, int height)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x85644C", Offset = "0x85644C", VA = "0x85644C")]
		private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
		{
			return default(RenderTextureFormat);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x85649C", Offset = "0x85649C", VA = "0x85649C")]
		public void Prepare(RenderTexture source, Material uberMaterial, bool antialiasCoC, Vector2 taaJitter, float taaBlending)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x856C44", Offset = "0x856C44", VA = "0x856C44", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x856CD0", Offset = "0x856CD0", VA = "0x856CD0")]
		public DepthOfFieldComponent()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
	{
		[Token(Token = "0x2000118")]
		private static class Uniforms
		{
			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _DitheringTex;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _DitheringCoords;
		}

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture2D[] noiseTextures;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int textureIndex;

		[Token(Token = "0x40005F7")]
		private const int k_TextureCount = 64;

		[Token(Token = "0x17000061")]
		public override bool active
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x858DE0", Offset = "0x858DE0", VA = "0x858DE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x858E4C", Offset = "0x858E4C", VA = "0x858E4C", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x858E58", Offset = "0x858E58", VA = "0x858E58")]
		private void LoadNoiseTextures()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x858F98", Offset = "0x858F98", VA = "0x858F98", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x859170", Offset = "0x859170", VA = "0x859170")]
		public DitheringComponent()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public sealed class EyeAdaptationComponent : PostProcessingComponentRenderTexture<EyeAdaptationModel>
	{
		[Token(Token = "0x200011A")]
		private static class Uniforms
		{
			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _Params;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Speed;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _ScaleOffsetRes;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _ExposureCompensation;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _AutoExposure;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _DebugWidth;
		}

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ComputeShader m_EyeCompute;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_HistogramBuffer;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly RenderTexture[] m_AutoExposurePool;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_AutoExposurePingPing;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_CurrentAutoExposure;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_DebugHistogram;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint[] s_EmptyHistogramBuffer;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_FirstFrame;

		[Token(Token = "0x4000602")]
		private const int k_HistogramBins = 64;

		[Token(Token = "0x4000603")]
		private const int k_HistogramThreadX = 16;

		[Token(Token = "0x4000604")]
		private const int k_HistogramThreadY = 16;

		[Token(Token = "0x17000062")]
		public override bool active
		{
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x859488", Offset = "0x859488", VA = "0x859488", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x859500", Offset = "0x859500", VA = "0x859500")]
		public void ResetHistory()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x85950C", Offset = "0x85950C", VA = "0x85950C", Slot = "6")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x859518", Offset = "0x859518", VA = "0x859518", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x8596C0", Offset = "0x8596C0", VA = "0x8596C0")]
		private Vector4 GetHistogramScaleOffsetRes()
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x8597AC", Offset = "0x8597AC", VA = "0x8597AC")]
		public Texture Prepare(RenderTexture source, Material uberMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x85A224", Offset = "0x85A224", VA = "0x85A224")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x85A3A0", Offset = "0x85A3A0", VA = "0x85A3A0")]
		public EyeAdaptationComponent()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
	{
		[Token(Token = "0x200011C")]
		private static class Uniforms
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _FogColor;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Density;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Start;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _End;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _TempRT;
		}

		[Token(Token = "0x400060B")]
		private const string k_ShaderString = "Hidden/Post FX/Fog";

		[Token(Token = "0x17000063")]
		public override bool active
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x85CB44", Offset = "0x85CB44", VA = "0x85CB44", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x85CBD0", Offset = "0x85CBD0", VA = "0x85CBD0", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x85CC14", Offset = "0x85CC14", VA = "0x85CC14", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x85CC1C", Offset = "0x85CC1C", VA = "0x85CC1C", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x85CC24", Offset = "0x85CC24", VA = "0x85CC24", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x85D10C", Offset = "0x85D10C", VA = "0x85D10C")]
		public FogComponent()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		[Token(Token = "0x200011E")]
		private static class Uniforms
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _QualitySettings;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _ConsoleSettings;
		}

		[Token(Token = "0x17000064")]
		public override bool active
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x85D1C0", Offset = "0x85D1C0", VA = "0x85D1C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x85D234", Offset = "0x85D234", VA = "0x85D234")]
		public void Render(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x85D498", Offset = "0x85D498", VA = "0x85D498")]
		public FxaaComponent()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
	{
		[Token(Token = "0x2000120")]
		private static class Uniforms
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _Grain_Params1;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Grain_Params2;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _GrainTex;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _Phase;
		}

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture m_GrainLookupRT;

		[Token(Token = "0x17000065")]
		public override bool active
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x85DE6C", Offset = "0x85DE6C", VA = "0x85DE6C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x85DEF4", Offset = "0x85DEF4", VA = "0x85DEF4", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x85DF24", Offset = "0x85DF24", VA = "0x85DF24", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x85E314", Offset = "0x85E314", VA = "0x85E314")]
		public GrainComponent()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
	{
		[Token(Token = "0x2000122")]
		private static class Uniforms
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _VelocityScale;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _MaxBlurRadius;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _RcpMaxBlurRadius;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _VelocityTex;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _MainTex;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _Tile2RT;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _Tile4RT;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _Tile8RT;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _TileMaxOffs;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _TileMaxLoop;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal static readonly int _TileVRT;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal static readonly int _NeighborMaxTex;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal static readonly int _LoopCount;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal static readonly int _TempRT;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal static readonly int _History1LumaTex;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal static readonly int _History2LumaTex;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal static readonly int _History3LumaTex;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal static readonly int _History4LumaTex;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal static readonly int _History1ChromaTex;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal static readonly int _History2ChromaTex;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal static readonly int _History3ChromaTex;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal static readonly int _History4ChromaTex;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal static readonly int _History1Weight;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal static readonly int _History2Weight;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal static readonly int _History3Weight;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal static readonly int _History4Weight;
		}

		[Token(Token = "0x2000123")]
		private enum Pass
		{
			[Token(Token = "0x4000636")]
			VelocitySetup,
			[Token(Token = "0x4000637")]
			TileMax1,
			[Token(Token = "0x4000638")]
			TileMax2,
			[Token(Token = "0x4000639")]
			TileMaxV,
			[Token(Token = "0x400063A")]
			NeighborMax,
			[Token(Token = "0x400063B")]
			Reconstruction,
			[Token(Token = "0x400063C")]
			FrameCompression,
			[Token(Token = "0x400063D")]
			FrameBlendingChroma,
			[Token(Token = "0x400063E")]
			FrameBlendingRaw
		}

		[Token(Token = "0x2000124")]
		public class ReconstructionFilter
		{
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private RenderTextureFormat m_VectorRTFormat;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private RenderTextureFormat m_PackedRTFormat;

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x9AB600", Offset = "0x9AB600", VA = "0x9AB600")]
			public ReconstructionFilter()
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x9AB644", Offset = "0x9AB644", VA = "0x9AB644")]
			private void CheckTextureFormatSupport()
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x9AB674", Offset = "0x9AB674", VA = "0x9AB674")]
			public bool IsSupported()
			{
				return default(bool);
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x9AB67C", Offset = "0x9AB67C", VA = "0x9AB67C")]
			public void ProcessImage(PostProcessingContext context, CommandBuffer cb, ref MotionBlurModel.Settings settings, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
			}
		}

		[Token(Token = "0x2000125")]
		public class FrameBlendingFilter
		{
			[Token(Token = "0x2000126")]
			private struct Frame
			{
				[Token(Token = "0x4000645")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public RenderTexture lumaTexture;

				[Token(Token = "0x4000646")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public RenderTexture chromaTexture;

				[Token(Token = "0x4000647")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private float m_Time;

				[Token(Token = "0x4000648")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private RenderTargetIdentifier[] m_MRT;

				[Token(Token = "0x60004A0")]
				[Address(RVA = "0x9AB584", Offset = "0x9AB584", VA = "0x9AB584")]
				public float CalculateWeight(float strength, float currentTime)
				{
					return default(float);
				}

				[Token(Token = "0x60004A1")]
				[Address(RVA = "0x9AA994", Offset = "0x9AA994", VA = "0x9AA994")]
				public void Release()
				{
				}

				[Token(Token = "0x60004A2")]
				[Address(RVA = "0x9AABAC", Offset = "0x9AABAC", VA = "0x9AABAC")]
				public void MakeRecord(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
				{
				}

				[Token(Token = "0x60004A3")]
				[Address(RVA = "0x9AAE88", Offset = "0x9AAE88", VA = "0x9AAE88")]
				public void MakeRecordRaw(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, RenderTextureFormat format)
				{
				}
			}

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_UseCompression;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private RenderTextureFormat m_RawTextureFormat;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Frame[] m_FrameList;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_LastFrameCount;

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x9AA780", Offset = "0x9AA780", VA = "0x9AA780")]
			public FrameBlendingFilter()
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x9AA90C", Offset = "0x9AA90C", VA = "0x9AA90C")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x9AAA78", Offset = "0x9AAA78", VA = "0x9AAA78")]
			public void PushFrame(CommandBuffer cb, RenderTargetIdentifier source, int width, int height, Material material)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x9AB004", Offset = "0x9AB004", VA = "0x9AB004")]
			public void BlendFrames(CommandBuffer cb, float strength, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x9AA7FC", Offset = "0x9AA7FC", VA = "0x9AA7FC")]
			private static bool CheckSupportCompression()
			{
				return default(bool);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x9AA834", Offset = "0x9AA834", VA = "0x9AA834")]
			private static RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				return default(RenderTextureFormat);
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x9AB50C", Offset = "0x9AB50C", VA = "0x9AB50C")]
			private Frame GetFrameRelative(int offset)
			{
				return default(Frame);
			}
		}

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReconstructionFilter m_ReconstructionFilter;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FrameBlendingFilter m_FrameBlendingFilter;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_FirstFrame;

		[Token(Token = "0x17000066")]
		public ReconstructionFilter reconstructionFilter
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x91B860", Offset = "0x91B860", VA = "0x91B860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public FrameBlendingFilter frameBlendingFilter
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x91B8D4", Offset = "0x91B8D4", VA = "0x91B8D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public override bool active
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x91B948", Offset = "0x91B948", VA = "0x91B948", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x91BA08", Offset = "0x91BA08", VA = "0x91BA08", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x91BA4C", Offset = "0x91BA4C", VA = "0x91BA4C")]
		public void ResetHistory()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x91BA84", Offset = "0x91BA84", VA = "0x91BA84", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x91BA8C", Offset = "0x91BA8C", VA = "0x91BA8C", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x91BA94", Offset = "0x91BA94", VA = "0x91BA94", Slot = "6")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x91BAA0", Offset = "0x91BAA0", VA = "0x91BAA0", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x91C168", Offset = "0x91C168", VA = "0x91C168", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x91C17C", Offset = "0x91C17C", VA = "0x91C17C")]
		public MotionBlurComponent()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public sealed class ScreenSpaceReflectionComponent : PostProcessingComponentCommandBuffer<ScreenSpaceReflectionModel>
	{
		[Token(Token = "0x2000128")]
		private static class Uniforms
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _RayStepSize;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _AdditiveReflection;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _BilateralUpsampling;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _TreatBackfaceHitAsMiss;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _AllowBackwardsRays;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal static readonly int _TraceBehindObjects;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal static readonly int _MaxSteps;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal static readonly int _FullResolutionFiltering;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal static readonly int _HalfResolution;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal static readonly int _HighlightSuppression;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal static readonly int _PixelsPerMeterAtOneMeter;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal static readonly int _ScreenEdgeFading;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal static readonly int _ReflectionBlur;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal static readonly int _MaxRayTraceDistance;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal static readonly int _FadeDistance;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal static readonly int _LayerThickness;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal static readonly int _SSRMultiplier;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			internal static readonly int _FresnelFade;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal static readonly int _FresnelFadePower;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			internal static readonly int _ReflectionBufferSize;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal static readonly int _ScreenSize;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			internal static readonly int _InvScreenSize;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal static readonly int _ProjInfo;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			internal static readonly int _CameraClipInfo;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal static readonly int _ProjectToPixelMatrix;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			internal static readonly int _WorldToCameraMatrix;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal static readonly int _CameraToWorldMatrix;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			internal static readonly int _Axis;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal static readonly int _CurrentMipLevel;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			internal static readonly int _NormalAndRoughnessTexture;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal static readonly int _HitPointTexture;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			internal static readonly int _BlurTexture;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal static readonly int _FilteredReflections;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			internal static readonly int _FinalReflectionTexture;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal static readonly int _TempTexture;
		}

		[Token(Token = "0x2000129")]
		private enum PassIndex
		{
			[Token(Token = "0x4000672")]
			RayTraceStep,
			[Token(Token = "0x4000673")]
			CompositeFinal,
			[Token(Token = "0x4000674")]
			Blur,
			[Token(Token = "0x4000675")]
			CompositeSSR,
			[Token(Token = "0x4000676")]
			MinMipGeneration,
			[Token(Token = "0x4000677")]
			HitPointToReflections,
			[Token(Token = "0x4000678")]
			BilateralKeyPack,
			[Token(Token = "0x4000679")]
			BlitDepthAsCSZ,
			[Token(Token = "0x400067A")]
			PoissonBlur
		}

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool k_HighlightSuppression;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool k_TraceBehindObjects;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool k_TreatBackfaceHitAsMiss;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		private bool k_BilateralUpsample;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int[] m_ReflectionTextures;

		[Token(Token = "0x17000069")]
		public override bool active
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x7B69A8", Offset = "0x7B69A8", VA = "0x7B69A8", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x7B69A0", Offset = "0x7B69A0", VA = "0x7B69A0", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x7B6A24", Offset = "0x7B6A24", VA = "0x7B6A24", Slot = "6")]
		public override void OnEnable()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x7B6B78", Offset = "0x7B6B78", VA = "0x7B6B78", Slot = "11")]
		public override string GetName()
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x7B6BBC", Offset = "0x7B6BBC", VA = "0x7B6BBC", Slot = "10")]
		public override CameraEvent GetCameraEvent()
		{
			return default(CameraEvent);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x7B6BC4", Offset = "0x7B6BC4", VA = "0x7B6BC4", Slot = "12")]
		public override void PopulateCommandBuffer(CommandBuffer cb)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x7B05AC", Offset = "0x7B05AC", VA = "0x7B05AC")]
		public ScreenSpaceReflectionComponent()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		[Token(Token = "0x200012B")]
		private static class Uniforms
		{
			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static int _Jitter;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static int _SharpenParameters;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static int _FinalBlendParameters;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static int _HistoryTex;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static int _MainTex;
		}

		[Token(Token = "0x400067B")]
		private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing";

		[Token(Token = "0x400067C")]
		private const int k_SampleCount = 8;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly RenderBuffer[] m_MRT;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_SampleIndex;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_ResetHistory;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture m_HistoryTexture;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46E12C", Offset = "0x46E12C")]
		private Vector2 <jitterVector>k__BackingField;

		[Token(Token = "0x1700006A")]
		public override bool active
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x897D50", Offset = "0x897D50", VA = "0x897D50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public Vector2 jitterVector
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x897DEC", Offset = "0x897DEC", VA = "0x897DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47209C", Offset = "0x47209C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x897DF4", Offset = "0x897DF4", VA = "0x897DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4720AC", Offset = "0x4720AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x897DE4", Offset = "0x897DE4", VA = "0x897DE4", Slot = "4")]
		public override DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x897DFC", Offset = "0x897DFC", VA = "0x897DFC")]
		public void ResetHistory()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x897E08", Offset = "0x897E08", VA = "0x897E08")]
		public void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x8986E8", Offset = "0x8986E8", VA = "0x8986E8")]
		public void Render(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x898BBC", Offset = "0x898BBC", VA = "0x898BBC")]
		private float GetHaltonValue(int index, int radix)
		{
			return default(float);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x898090", Offset = "0x898090", VA = "0x898090")]
		private Vector2 GenerateRandomOffset()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x898124", Offset = "0x898124", VA = "0x898124")]
		private Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x898594", Offset = "0x898594", VA = "0x898594")]
		private Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x898C00", Offset = "0x898C00", VA = "0x898C00", Slot = "7")]
		public override void OnDisable()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x898CA8", Offset = "0x898CA8", VA = "0x898CA8")]
		public TaaComponent()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		[Token(Token = "0x200012D")]
		private static class Uniforms
		{
			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _UserLut;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _UserLut_Params;
		}

		[Token(Token = "0x1700006C")]
		public override bool active
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0x89FFF0", Offset = "0x89FFF0", VA = "0x89FFF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x8A0118", Offset = "0x8A0118", VA = "0x8A0118", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x8A0284", Offset = "0x8A0284", VA = "0x8A0284")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x8A03B0", Offset = "0x8A03B0", VA = "0x8A03B0")]
		public UserLutComponent()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
	{
		[Token(Token = "0x200012F")]
		private static class Uniforms
		{
			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal static readonly int _Vignette_Color;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal static readonly int _Vignette_Center;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal static readonly int _Vignette_Settings;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal static readonly int _Vignette_Mask;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal static readonly int _Vignette_Opacity;
		}

		[Token(Token = "0x1700006D")]
		public override bool active
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x8A0524", Offset = "0x8A0524", VA = "0x8A0524", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x8A0590", Offset = "0x8A0590", VA = "0x8A0590", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x8A084C", Offset = "0x8A084C", VA = "0x8A084C")]
		public VignetteComponent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000130")]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		[Token(Token = "0x2000131")]
		public enum SampleCount
		{
			[Token(Token = "0x4000690")]
			Lowest = 3,
			[Token(Token = "0x4000691")]
			Low = 6,
			[Token(Token = "0x4000692")]
			Medium = 10,
			[Token(Token = "0x4000693")]
			High = 16
		}

		[Serializable]
		[Token(Token = "0x2000132")]
		public struct Settings
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E14C", Offset = "0x46E14C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E14C", Offset = "0x46E14C")]
			public float intensity;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E1A0", Offset = "0x46E1A0")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46E1A0", Offset = "0x46E1A0")]
			public float radius;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E1F4", Offset = "0x46E1F4")]
			public SampleCount sampleCount;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E22C", Offset = "0x46E22C")]
			public bool downsampling;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E264", Offset = "0x46E264")]
			public bool forceForwardCompatibility;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E29C", Offset = "0x46E29C")]
			public bool ambientOnly;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E2D4", Offset = "0x46E2D4")]
			public bool highPrecision;

			[Token(Token = "0x1700006F")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004C7")]
				[Address(RVA = "0x8A3F08", Offset = "0x8A3F08", VA = "0x8A3F08")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700006E")]
		public Settings settings
		{
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x746330", Offset = "0x746330", VA = "0x746330")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x746340", Offset = "0x746340", VA = "0x746340")]
			set
			{
			}
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x74634C", Offset = "0x74634C", VA = "0x74634C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x746378", Offset = "0x746378", VA = "0x746378")]
		public AmbientOcclusionModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000133")]
	public class AntialiasingModel : PostProcessingModel
	{
		[Token(Token = "0x2000134")]
		public enum Method
		{
			[Token(Token = "0x400069D")]
			Fxaa,
			[Token(Token = "0x400069E")]
			Taa
		}

		[Token(Token = "0x2000135")]
		public enum FxaaPreset
		{
			[Token(Token = "0x40006A0")]
			ExtremePerformance,
			[Token(Token = "0x40006A1")]
			Performance,
			[Token(Token = "0x40006A2")]
			Default,
			[Token(Token = "0x40006A3")]
			Quality,
			[Token(Token = "0x40006A4")]
			ExtremeQuality
		}

		[Serializable]
		[Token(Token = "0x2000136")]
		public struct FxaaQualitySettings
		{
			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E31C", Offset = "0x46E31C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E31C", Offset = "0x46E31C")]
			public float subpixelAliasingRemovalAmount;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E370", Offset = "0x46E370")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E370", Offset = "0x46E370")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E3CC", Offset = "0x46E3CC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E3CC", Offset = "0x46E3CC")]
			public float minimumRequiredLuminance;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static FxaaQualitySettings[] presets;
		}

		[Serializable]
		[Token(Token = "0x2000137")]
		public struct FxaaConsoleSettings
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E424", Offset = "0x46E424")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E424", Offset = "0x46E424")]
			public float subpixelSpreadAmount;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E47C", Offset = "0x46E47C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E47C", Offset = "0x46E47C")]
			public float edgeSharpnessAmount;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E4D0", Offset = "0x46E4D0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E4D0", Offset = "0x46E4D0")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E524", Offset = "0x46E524")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E524", Offset = "0x46E524")]
			public float minimumRequiredLuminance;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static FxaaConsoleSettings[] presets;
		}

		[Serializable]
		[Token(Token = "0x2000138")]
		public struct FxaaSettings
		{
			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FxaaPreset preset;

			[Token(Token = "0x17000071")]
			public static FxaaSettings defaultSettings
			{
				[Token(Token = "0x60004CE")]
				[Address(RVA = "0x8A4374", Offset = "0x8A4374", VA = "0x8A4374")]
				get
				{
					return default(FxaaSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000139")]
		public struct TaaSettings
		{
			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E580", Offset = "0x46E580")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E580", Offset = "0x46E580")]
			public float jitterSpread;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E5D8", Offset = "0x46E5D8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E5D8", Offset = "0x46E5D8")]
			public float sharpen;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E62C", Offset = "0x46E62C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E62C", Offset = "0x46E62C")]
			public float stationaryBlending;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E684", Offset = "0x46E684")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E684", Offset = "0x46E684")]
			public float motionBlending;

			[Token(Token = "0x17000072")]
			public static TaaSettings defaultSettings
			{
				[Token(Token = "0x60004CF")]
				[Address(RVA = "0x8A4398", Offset = "0x8A4398", VA = "0x8A4398")]
				get
				{
					return default(TaaSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200013A")]
		public struct Settings
		{
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Method method;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public FxaaSettings fxaaSettings;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public TaaSettings taaSettings;

			[Token(Token = "0x17000073")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004D0")]
				[Address(RVA = "0x8A437C", Offset = "0x8A437C", VA = "0x8A437C")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000070")]
		public Settings settings
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x748680", Offset = "0x748680", VA = "0x748680")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x748694", Offset = "0x748694", VA = "0x748694")]
			set
			{
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x7486A8", Offset = "0x7486A8", VA = "0x7486A8", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x7486F4", Offset = "0x7486F4", VA = "0x7486F4")]
		public AntialiasingModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013B")]
	public class BloomModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x200013C")]
		public struct BloomSettings
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46E6EC", Offset = "0x46E6EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E6EC", Offset = "0x46E6EC")]
			public float intensity;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46E73C", Offset = "0x46E73C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E73C", Offset = "0x46E73C")]
			public float threshold;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E78C", Offset = "0x46E78C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E78C", Offset = "0x46E78C")]
			public float softKnee;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E7E0", Offset = "0x46E7E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E7E0", Offset = "0x46E7E0")]
			public float radius;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E834", Offset = "0x46E834")]
			public bool antiFlicker;

			[Token(Token = "0x17000075")]
			public float thresholdLinear
			{
				[Token(Token = "0x60004D6")]
				[Address(RVA = "0x9A51D0", Offset = "0x9A51D0", VA = "0x9A51D0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004D5")]
				[Address(RVA = "0x9A51A8", Offset = "0x9A51A8", VA = "0x9A51A8")]
				set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public static BloomSettings defaultSettings
			{
				[Token(Token = "0x60004D7")]
				[Address(RVA = "0x9A51DC", Offset = "0x9A51DC", VA = "0x9A51DC")]
				get
				{
					return default(BloomSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200013D")]
		public struct LensDirtSettings
		{
			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E86C", Offset = "0x46E86C")]
			public Texture texture;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E8A4", Offset = "0x46E8A4")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46E8A4", Offset = "0x46E8A4")]
			public float intensity;

			[Token(Token = "0x17000077")]
			public static LensDirtSettings defaultSettings
			{
				[Token(Token = "0x60004D8")]
				[Address(RVA = "0x9A51F8", Offset = "0x9A51F8", VA = "0x9A51F8")]
				get
				{
					return default(LensDirtSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200013E")]
		public struct Settings
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BloomSettings bloom;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LensDirtSettings lensDirt;

			[Token(Token = "0x17000078")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004D9")]
				[Address(RVA = "0x9A522C", Offset = "0x9A522C", VA = "0x9A522C")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000074")]
		public Settings settings
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x74B8BC", Offset = "0x74B8BC", VA = "0x74B8BC")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x74B8D4", Offset = "0x74B8D4", VA = "0x74B8D4")]
			set
			{
			}
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x74B8F8", Offset = "0x74B8F8", VA = "0x74B8F8", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x74B958", Offset = "0x74B958", VA = "0x74B958")]
		public BloomModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013F")]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000140")]
		public struct DepthSettings
		{
			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E904", Offset = "0x46E904")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E904", Offset = "0x46E904")]
			public float scale;

			[Token(Token = "0x1700007B")]
			public static DepthSettings defaultSettings
			{
				[Token(Token = "0x60004E0")]
				[Address(RVA = "0x9A5BD8", Offset = "0x9A5BD8", VA = "0x9A5BD8")]
				get
				{
					return default(DepthSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000141")]
		public struct MotionVectorsSettings
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E958", Offset = "0x46E958")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E958", Offset = "0x46E958")]
			public float sourceOpacity;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46E9AC", Offset = "0x46E9AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46E9AC", Offset = "0x46E9AC")]
			public float motionImageOpacity;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46EA00", Offset = "0x46EA00")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EA00", Offset = "0x46EA00")]
			public float motionImageAmplitude;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EA50", Offset = "0x46EA50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EA50", Offset = "0x46EA50")]
			public float motionVectorsOpacity;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EAA4", Offset = "0x46EAA4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EAA4", Offset = "0x46EAA4")]
			public int motionVectorsResolution;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EAFC", Offset = "0x46EAFC")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46EAFC", Offset = "0x46EAFC")]
			public float motionVectorsAmplitude;

			[Token(Token = "0x1700007C")]
			public static MotionVectorsSettings defaultSettings
			{
				[Token(Token = "0x60004E1")]
				[Address(RVA = "0x9A5BE0", Offset = "0x9A5BE0", VA = "0x9A5BE0")]
				get
				{
					return default(MotionVectorsSettings);
				}
			}
		}

		[Token(Token = "0x2000142")]
		public enum Mode
		{
			[Token(Token = "0x40006C9")]
			None,
			[Token(Token = "0x40006CA")]
			Depth,
			[Token(Token = "0x40006CB")]
			Normals,
			[Token(Token = "0x40006CC")]
			MotionVectors,
			[Token(Token = "0x40006CD")]
			AmbientOcclusion,
			[Token(Token = "0x40006CE")]
			EyeAdaptation,
			[Token(Token = "0x40006CF")]
			FocusPlane,
			[Token(Token = "0x40006D0")]
			PreGradingLog,
			[Token(Token = "0x40006D1")]
			LogLut,
			[Token(Token = "0x40006D2")]
			UserLut
		}

		[Serializable]
		[Token(Token = "0x2000143")]
		public struct Settings
		{
			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Mode mode;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public DepthSettings depth;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MotionVectorsSettings motionVectors;

			[Token(Token = "0x1700007D")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004E2")]
				[Address(RVA = "0x9A5BFC", Offset = "0x9A5BFC", VA = "0x9A5BFC")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000079")]
		public Settings settings
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x74D238", Offset = "0x74D238", VA = "0x74D238")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x74D248", Offset = "0x74D248", VA = "0x74D248")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool willInterrupt
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x74D258", Offset = "0x74D258", VA = "0x74D258")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x74D27C", Offset = "0x74D27C", VA = "0x74D27C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x7457E0", Offset = "0x7457E0", VA = "0x7457E0")]
		public bool IsModeActive(Mode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x74D2C0", Offset = "0x74D2C0", VA = "0x74D2C0")]
		public BuiltinDebugViewsModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000144")]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000145")]
		public struct Settings
		{
			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EB5C", Offset = "0x46EB5C")]
			public Texture2D spectralTexture;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EB94", Offset = "0x46EB94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EB94", Offset = "0x46EB94")]
			public float intensity;

			[Token(Token = "0x1700007F")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0x9A60F0", Offset = "0x9A60F0", VA = "0x9A60F0")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700007E")]
		public Settings settings
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x757E54", Offset = "0x757E54", VA = "0x757E54")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x757E60", Offset = "0x757E60", VA = "0x757E60")]
			set
			{
			}
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x757E70", Offset = "0x757E70", VA = "0x757E70", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x757EA4", Offset = "0x757EA4", VA = "0x757EA4")]
		public ChromaticAberrationModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000146")]
	public class ColorGradingModel : PostProcessingModel
	{
		[Token(Token = "0x2000147")]
		public enum Tonemapper
		{
			[Token(Token = "0x40006DD")]
			None,
			[Token(Token = "0x40006DE")]
			ACES,
			[Token(Token = "0x40006DF")]
			Neutral
		}

		[Serializable]
		[Token(Token = "0x2000148")]
		public struct TonemappingSettings
		{
			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EC18", Offset = "0x46EC18")]
			public Tonemapper tonemapper;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EC50", Offset = "0x46EC50")]
			public float neutralBlackIn;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EC70", Offset = "0x46EC70")]
			public float neutralWhiteIn;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EC88", Offset = "0x46EC88")]
			public float neutralBlackOut;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46ECA8", Offset = "0x46ECA8")]
			public float neutralWhiteOut;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46ECC0", Offset = "0x46ECC0")]
			public float neutralWhiteLevel;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46ECDC", Offset = "0x46ECDC")]
			public float neutralWhiteClip;

			[Token(Token = "0x17000083")]
			public static TonemappingSettings defaultSettings
			{
				[Token(Token = "0x60004F1")]
				[Address(RVA = "0x9A6E2C", Offset = "0x9A6E2C", VA = "0x9A6E2C")]
				get
				{
					return default(TonemappingSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000149")]
		public struct BasicSettings
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46ECF4", Offset = "0x46ECF4")]
			public float postExposure;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46ED2C", Offset = "0x46ED2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46ED2C", Offset = "0x46ED2C")]
			public float temperature;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46ED88", Offset = "0x46ED88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46ED88", Offset = "0x46ED88")]
			public float tint;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EDE4", Offset = "0x46EDE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EDE4", Offset = "0x46EDE4")]
			public float hueShift;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EE40", Offset = "0x46EE40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EE40", Offset = "0x46EE40")]
			public float saturation;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46EE94", Offset = "0x46EE94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46EE94", Offset = "0x46EE94")]
			public float contrast;

			[Token(Token = "0x17000084")]
			public static BasicSettings defaultSettings
			{
				[Token(Token = "0x60004F2")]
				[Address(RVA = "0x9A64D8", Offset = "0x9A64D8", VA = "0x9A64D8")]
				get
				{
					return default(BasicSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200014A")]
		public struct ChannelMixerSettings
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 red;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 green;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 blue;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[HideInInspector]
			public int currentEditingChannel;

			[Token(Token = "0x17000085")]
			public static ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x60004F3")]
				[Address(RVA = "0x9A64E8", Offset = "0x9A64E8", VA = "0x9A64E8")]
				get
				{
					return default(ChannelMixerSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200014B")]
		public struct LogWheelsSettings
		{
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x46EEF8", Offset = "0x46EEF8")]
			public Color slope;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x46EF30", Offset = "0x46EF30")]
			public Color power;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x46EF68", Offset = "0x46EF68")]
			public Color offset;

			[Token(Token = "0x17000086")]
			public static LogWheelsSettings defaultSettings
			{
				[Token(Token = "0x60004F4")]
				[Address(RVA = "0x9A657C", Offset = "0x9A657C", VA = "0x9A657C")]
				get
				{
					return default(LogWheelsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200014C")]
		public struct LinearWheelsSettings
		{
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x46EFA0", Offset = "0x46EFA0")]
			public Color lift;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x46EFD8", Offset = "0x46EFD8")]
			public Color gamma;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TrackballAttribute", RVA = "0x46F010", Offset = "0x46F010")]
			public Color gain;

			[Token(Token = "0x17000087")]
			public static LinearWheelsSettings defaultSettings
			{
				[Token(Token = "0x60004F5")]
				[Address(RVA = "0x9A6608", Offset = "0x9A6608", VA = "0x9A6608")]
				get
				{
					return default(LinearWheelsSettings);
				}
			}
		}

		[Token(Token = "0x200014D")]
		public enum ColorWheelMode
		{
			[Token(Token = "0x40006F8")]
			Linear,
			[Token(Token = "0x40006F9")]
			Log
		}

		[Serializable]
		[Token(Token = "0x200014E")]
		public struct ColorWheelsSettings
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ColorWheelMode mode;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[TrackballGroup]
			public LogWheelsSettings log;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[TrackballGroup]
			public LinearWheelsSettings linear;

			[Token(Token = "0x17000088")]
			public static ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x60004F6")]
				[Address(RVA = "0x9A6500", Offset = "0x9A6500", VA = "0x9A6500")]
				get
				{
					return default(ColorWheelsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200014F")]
		public struct CurvesSettings
		{
			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ColorGradingCurve master;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ColorGradingCurve red;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ColorGradingCurve green;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColorGradingCurve blue;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColorGradingCurve hueVShue;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColorGradingCurve hueVSsat;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ColorGradingCurve satVSsat;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ColorGradingCurve lumVSsat;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[HideInInspector]
			public int e_CurrentEditingCurve;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[HideInInspector]
			public bool e_CurveY;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			[HideInInspector]
			public bool e_CurveR;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
			[HideInInspector]
			public bool e_CurveG;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
			[HideInInspector]
			public bool e_CurveB;

			[Token(Token = "0x17000089")]
			public static CurvesSettings defaultSettings
			{
				[Token(Token = "0x60004F7")]
				[Address(RVA = "0x9A6694", Offset = "0x9A6694", VA = "0x9A6694")]
				get
				{
					return default(CurvesSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000150")]
		public struct Settings
		{
			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TonemappingSettings tonemapping;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public BasicSettings basic;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public ChannelMixerSettings channelMixer;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public ColorWheelsSettings colorWheels;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public CurvesSettings curves;

			[Token(Token = "0x1700008A")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004F8")]
				[Address(RVA = "0x9A6CD8", Offset = "0x9A6CD8", VA = "0x9A6CD8")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46EBF8", Offset = "0x46EBF8")]
		private bool <isDirty>k__BackingField;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46EC08", Offset = "0x46EC08")]
		private RenderTexture <bakedLut>k__BackingField;

		[Token(Token = "0x17000080")]
		public Settings settings
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x75A45C", Offset = "0x75A45C", VA = "0x75A45C")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x75A46C", Offset = "0x75A46C", VA = "0x75A46C")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool isDirty
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x75A4AC", Offset = "0x75A4AC", VA = "0x75A4AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4720BC", Offset = "0x4720BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x75A4B4", Offset = "0x75A4B4", VA = "0x75A4B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4720CC", Offset = "0x4720CC")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public RenderTexture bakedLut
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x75A4C0", Offset = "0x75A4C0", VA = "0x75A4C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4720DC", Offset = "0x4720DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x75A4C8", Offset = "0x75A4C8", VA = "0x75A4C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4720EC", Offset = "0x4720EC")]
			internal set
			{
			}
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x75A4D8", Offset = "0x75A4D8", VA = "0x75A4D8", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x75A544", Offset = "0x75A544", VA = "0x75A544", Slot = "5")]
		public override void OnValidate()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x75A550", Offset = "0x75A550", VA = "0x75A550")]
		public ColorGradingModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000151")]
	public class DepthOfFieldModel : PostProcessingModel
	{
		[Token(Token = "0x2000152")]
		public enum KernelSize
		{
			[Token(Token = "0x4000711")]
			Small,
			[Token(Token = "0x4000712")]
			Medium,
			[Token(Token = "0x4000713")]
			Large,
			[Token(Token = "0x4000714")]
			VeryLarge
		}

		[Serializable]
		[Token(Token = "0x2000153")]
		public struct Settings
		{
			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46F0C8", Offset = "0x46F0C8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F0C8", Offset = "0x46F0C8")]
			public float focusDistance;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F11C", Offset = "0x46F11C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F11C", Offset = "0x46F11C")]
			public float aperture;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F178", Offset = "0x46F178")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F178", Offset = "0x46F178")]
			public float focalLength;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F1D0", Offset = "0x46F1D0")]
			public bool useCameraFov;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F208", Offset = "0x46F208")]
			public KernelSize kernelSize;

			[Token(Token = "0x1700008C")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60004FD")]
				[Address(RVA = "0x9A7CA0", Offset = "0x9A7CA0", VA = "0x9A7CA0")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700008B")]
		public Settings settings
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x856D1C", Offset = "0x856D1C", VA = "0x856D1C")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x856D30", Offset = "0x856D30", VA = "0x856D30")]
			set
			{
			}
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x856D44", Offset = "0x856D44", VA = "0x856D44", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x856D94", Offset = "0x856D94", VA = "0x856D94")]
		public DepthOfFieldModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000154")]
	public class DitheringModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000155")]
		public struct Settings
		{
			[Token(Token = "0x1700008E")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000502")]
				[Address(RVA = "0x9A7D64", Offset = "0x9A7D64", VA = "0x9A7D64")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700008D")]
		public Settings settings
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x8591BC", Offset = "0x8591BC", VA = "0x8591BC")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x8591C4", Offset = "0x8591C4", VA = "0x8591C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x8591CC", Offset = "0x8591CC", VA = "0x8591CC", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x8591F4", Offset = "0x8591F4", VA = "0x8591F4")]
		public DitheringModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000156")]
	public class EyeAdaptationModel : PostProcessingModel
	{
		[Token(Token = "0x2000157")]
		public enum EyeAdaptationType
		{
			[Token(Token = "0x400071D")]
			Progressive,
			[Token(Token = "0x400071E")]
			Fixed
		}

		[Serializable]
		[Token(Token = "0x2000158")]
		public struct Settings
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F260", Offset = "0x46F260")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F260", Offset = "0x46F260")]
			public float lowPercent;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F2B8", Offset = "0x46F2B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F2B8", Offset = "0x46F2B8")]
			public float highPercent;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F310", Offset = "0x46F310")]
			public float minLuminance;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F348", Offset = "0x46F348")]
			public float maxLuminance;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46F380", Offset = "0x46F380")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F380", Offset = "0x46F380")]
			public float keyValue;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F3D0", Offset = "0x46F3D0")]
			public bool dynamicKeyValue;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F408", Offset = "0x46F408")]
			public EyeAdaptationType adaptationType;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46F440", Offset = "0x46F440")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F440", Offset = "0x46F440")]
			public float speedUp;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x46F490", Offset = "0x46F490")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F490", Offset = "0x46F490")]
			public float speedDown;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F4E0", Offset = "0x46F4E0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F4E0", Offset = "0x46F4E0")]
			public int logMin;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F534", Offset = "0x46F534")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F534", Offset = "0x46F534")]
			public int logMax;

			[Token(Token = "0x17000090")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000507")]
				[Address(RVA = "0x9A7F20", Offset = "0x9A7F20", VA = "0x9A7F20")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700008F")]
		public Settings settings
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x85A424", Offset = "0x85A424", VA = "0x85A424")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x85A43C", Offset = "0x85A43C", VA = "0x85A43C")]
			set
			{
			}
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x85A45C", Offset = "0x85A45C", VA = "0x85A45C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x85A4B0", Offset = "0x85A4B0", VA = "0x85A4B0")]
		public EyeAdaptationModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000159")]
	public class FogModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x200015A")]
		public struct Settings
		{
			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F598", Offset = "0x46F598")]
			public bool excludeSkybox;

			[Token(Token = "0x17000092")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x9A8760", Offset = "0x9A8760", VA = "0x9A8760")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000091")]
		public Settings settings
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x85D158", Offset = "0x85D158", VA = "0x85D158")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x85D160", Offset = "0x85D160", VA = "0x85D160")]
			set
			{
			}
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x85D168", Offset = "0x85D168", VA = "0x85D168", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x85D190", Offset = "0x85D190", VA = "0x85D190")]
		public FogModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015B")]
	public class GrainModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x200015C")]
		public struct Settings
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F5E0", Offset = "0x46F5E0")]
			public bool colored;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F618", Offset = "0x46F618")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F618", Offset = "0x46F618")]
			public float intensity;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F66C", Offset = "0x46F66C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F66C", Offset = "0x46F66C")]
			public float size;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F6C4", Offset = "0x46F6C4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F6C4", Offset = "0x46F6C4")]
			public float luminanceContribution;

			[Token(Token = "0x17000094")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000511")]
				[Address(RVA = "0x9A916C", Offset = "0x9A916C", VA = "0x9A916C")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000093")]
		public Settings settings
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x85E360", Offset = "0x85E360", VA = "0x85E360")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x85E370", Offset = "0x85E370", VA = "0x85E370")]
			set
			{
			}
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x85E37C", Offset = "0x85E37C", VA = "0x85E37C", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x85E3A8", Offset = "0x85E3A8", VA = "0x85E3A8")]
		public GrainModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015D")]
	public class MotionBlurModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x200015E")]
		public struct Settings
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F728", Offset = "0x46F728")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F728", Offset = "0x46F728")]
			public float shutterAngle;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F780", Offset = "0x46F780")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F780", Offset = "0x46F780")]
			public int sampleCount;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F7D8", Offset = "0x46F7D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F7D8", Offset = "0x46F7D8")]
			public float frameBlending;

			[Token(Token = "0x17000096")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000516")]
				[Address(RVA = "0x9AC418", Offset = "0x9AC418", VA = "0x9AC418")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000095")]
		public Settings settings
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x91C1D0", Offset = "0x91C1D0", VA = "0x91C1D0")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x91C1E0", Offset = "0x91C1E0", VA = "0x91C1E0")]
			set
			{
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x91C1EC", Offset = "0x91C1EC", VA = "0x91C1EC", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x91C218", Offset = "0x91C218", VA = "0x91C218")]
		public MotionBlurModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015F")]
	public class ScreenSpaceReflectionModel : PostProcessingModel
	{
		[Token(Token = "0x2000160")]
		public enum SSRResolution
		{
			[Token(Token = "0x4000737")]
			High = 0,
			[Token(Token = "0x4000738")]
			Low = 2
		}

		[Token(Token = "0x2000161")]
		public enum SSRReflectionBlendType
		{
			[Token(Token = "0x400073A")]
			PhysicallyBased,
			[Token(Token = "0x400073B")]
			Additive
		}

		[Serializable]
		[Token(Token = "0x2000162")]
		public struct IntensitySettings
		{
			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F83C", Offset = "0x46F83C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F83C", Offset = "0x46F83C")]
			public float reflectionMultiplier;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F890", Offset = "0x46F890")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F890", Offset = "0x46F890")]
			public float fadeDistance;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F8E8", Offset = "0x46F8E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F8E8", Offset = "0x46F8E8")]
			public float fresnelFade;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F93C", Offset = "0x46F93C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46F93C", Offset = "0x46F93C")]
			public float fresnelFadePower;
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		public struct ReflectionSettings
		{
			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F994", Offset = "0x46F994")]
			public SSRReflectionBlendType blendType;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46F9CC", Offset = "0x46F9CC")]
			public SSRResolution reflectionQuality;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FA04", Offset = "0x46FA04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FA04", Offset = "0x46FA04")]
			public float maxDistance;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FA60", Offset = "0x46FA60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FA60", Offset = "0x46FA60")]
			public int iterationCount;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FAB8", Offset = "0x46FAB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FAB8", Offset = "0x46FAB8")]
			public int stepSize;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FB0C", Offset = "0x46FB0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FB0C", Offset = "0x46FB0C")]
			public float widthModifier;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FB64", Offset = "0x46FB64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FB64", Offset = "0x46FB64")]
			public float reflectionBlur;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FBBC", Offset = "0x46FBBC")]
			public bool reflectBackfaces;
		}

		[Serializable]
		[Token(Token = "0x2000164")]
		public struct ScreenEdgeMask
		{
			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FBF4", Offset = "0x46FBF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FBF4", Offset = "0x46FBF4")]
			public float intensity;
		}

		[Serializable]
		[Token(Token = "0x2000165")]
		public struct Settings
		{
			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ReflectionSettings reflection;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IntensitySettings intensity;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ScreenEdgeMask screenEdgeMask;

			[Token(Token = "0x17000098")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x600051B")]
				[Address(RVA = "0x9AF164", Offset = "0x9AF164", VA = "0x9AF164")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000097")]
		public Settings settings
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x8906D8", Offset = "0x8906D8", VA = "0x8906D8")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x8906F8", Offset = "0x8906F8", VA = "0x8906F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x890718", Offset = "0x890718", VA = "0x890718", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x890780", Offset = "0x890780", VA = "0x890780")]
		public ScreenSpaceReflectionModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000166")]
	public class UserLutModel : PostProcessingModel
	{
		[Serializable]
		[Token(Token = "0x2000167")]
		public struct Settings
		{
			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FC58", Offset = "0x46FC58")]
			public Texture2D lut;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FC90", Offset = "0x46FC90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FC90", Offset = "0x46FC90")]
			public float contribution;

			[Token(Token = "0x1700009A")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x9B0500", Offset = "0x9B0500", VA = "0x9B0500")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x17000099")]
		public Settings settings
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x8A03FC", Offset = "0x8A03FC", VA = "0x8A03FC")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x8A0408", Offset = "0x8A0408", VA = "0x8A0408")]
			set
			{
			}
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x8A0418", Offset = "0x8A0418", VA = "0x8A0418", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x8A044C", Offset = "0x8A044C", VA = "0x8A044C")]
		public UserLutModel()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000168")]
	public class VignetteModel : PostProcessingModel
	{
		[Token(Token = "0x2000169")]
		public enum Mode
		{
			[Token(Token = "0x4000751")]
			Classic,
			[Token(Token = "0x4000752")]
			Masked
		}

		[Serializable]
		[Token(Token = "0x200016A")]
		public struct Settings
		{
			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FCF4", Offset = "0x46FCF4")]
			public Mode mode;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x46FD2C", Offset = "0x46FD2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FD2C", Offset = "0x46FD2C")]
			public Color color;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FD7C", Offset = "0x46FD7C")]
			public Vector2 center;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FDB4", Offset = "0x46FDB4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FDB4", Offset = "0x46FDB4")]
			public float intensity;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FE08", Offset = "0x46FE08")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FE08", Offset = "0x46FE08")]
			public float smoothness;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FE60", Offset = "0x46FE60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FE60", Offset = "0x46FE60")]
			public float roundness;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FEB4", Offset = "0x46FEB4")]
			public Texture mask;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FEEC", Offset = "0x46FEEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x46FEEC", Offset = "0x46FEEC")]
			public float opacity;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x46FF40", Offset = "0x46FF40")]
			public bool rounded;

			[Token(Token = "0x1700009C")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000525")]
				[Address(RVA = "0x9B0650", Offset = "0x9B0650", VA = "0x9B0650")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings m_Settings;

		[Token(Token = "0x1700009B")]
		public Settings settings
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x8A0898", Offset = "0x8A0898", VA = "0x8A0898")]
			get
			{
				return default(Settings);
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x8A08B8", Offset = "0x8A08B8", VA = "0x8A08B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x8A08E4", Offset = "0x8A08E4", VA = "0x8A08E4", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x8A0954", Offset = "0x8A0954", VA = "0x8A0954")]
		public VignetteModel()
		{
		}
	}
	[Token(Token = "0x200016B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x46C98C", Offset = "0x46C98C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x46C98C", Offset = "0x46C98C")]
	[DisallowMultipleComponent]
	[ImageEffectAllowedInSceneView]
	public class PostProcessingBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PostProcessingProfile profile;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<Vector2, Matrix4x4> jitteredMatrixFunc;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<PostProcessingComponentBase> m_Components;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<PostProcessingComponentBase, bool> m_ComponentStates;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MaterialFactory m_MaterialFactory;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTextureFactory m_RenderTextureFactory;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PostProcessingContext m_Context;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Camera m_Camera;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PostProcessingProfile m_PreviousProfile;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_RenderingInSceneView;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BuiltinDebugViewsComponent m_DebugViews;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AmbientOcclusionComponent m_AmbientOcclusion;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ScreenSpaceReflectionComponent m_ScreenSpaceReflection;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FogComponent m_FogComponent;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private MotionBlurComponent m_MotionBlur;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TaaComponent m_Taa;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private EyeAdaptationComponent m_EyeAdaptation;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DepthOfFieldComponent m_DepthOfField;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BloomComponent m_Bloom;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ChromaticAberrationComponent m_ChromaticAberration;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private ColorGradingComponent m_ColorGrading;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UserLutComponent m_UserLut;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GrainComponent m_Grain;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private VignetteComponent m_Vignette;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private DitheringComponent m_Dithering;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private FxaaComponent m_Fxaa;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<PostProcessingComponentBase> m_ComponentsToEnable;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<PostProcessingComponentBase> m_ComponentsToDisable;

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x7AFC50", Offset = "0x7AFC50", VA = "0x7AFC50")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x7B0634", Offset = "0x7B0634", VA = "0x7B0634")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x7B1064", Offset = "0x7B1064", VA = "0x7B1064")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x7B119C", Offset = "0x7B119C", VA = "0x7B119C")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x7B12AC", Offset = "0x7B12AC", VA = "0x7B12AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x7B1A50", Offset = "0x7B1A50", VA = "0x7B1A50")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x7B1C18", Offset = "0x7B1C18", VA = "0x7B1C18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x7B1E5C", Offset = "0x7B1E5C", VA = "0x7B1E5C")]
		public void ResetTemporalEffects()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x7B0D40", Offset = "0x7B0D40", VA = "0x7B0D40")]
		private void CheckObservers()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x7B0C00", Offset = "0x7B0C00", VA = "0x7B0C00")]
		private void DisableComponents()
		{
		}

		[Token(Token = "0x6000530")]
		private CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		private void RemoveCommandBuffer<T>() where T : PostProcessingModel
		{
		}

		[Token(Token = "0x6000532")]
		private CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		private void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) where T : PostProcessingModel
		{
		}

		[Token(Token = "0x6000534")]
		private bool TryPrepareUberImageEffect<T>(PostProcessingComponentRenderTexture<T> component, Material material) where T : PostProcessingModel
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		private T AddComponent<T>(T component) where T : PostProcessingComponentBase
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x7B1EA8", Offset = "0x7B1EA8", VA = "0x7B1EA8")]
		public PostProcessingBehaviour()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public abstract class PostProcessingComponentBase
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PostProcessingContext context;

		[Token(Token = "0x1700009D")]
		public abstract bool active
		{
			[Token(Token = "0x6000538")]
			get;
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x7B1F58", Offset = "0x7B1F58", VA = "0x7B1F58", Slot = "4")]
		public virtual DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x7B1F60", Offset = "0x7B1F60", VA = "0x7B1F60", Slot = "6")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x7B1F64", Offset = "0x7B1F64", VA = "0x7B1F64", Slot = "7")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x600053B")]
		public abstract PostProcessingModel GetModel();

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x7B1F68", Offset = "0x7B1F68", VA = "0x7B1F68")]
		protected PostProcessingComponentBase()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public abstract class PostProcessingComponent<T> : PostProcessingComponentBase where T : PostProcessingModel
	{
		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46FF78", Offset = "0x46FF78")]
		private T <model>k__BackingField;

		[Token(Token = "0x1700009E")]
		public T model
		{
			[Token(Token = "0x600053D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4720FC", Offset = "0x4720FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600053E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47210C", Offset = "0x47210C")]
			internal set
			{
			}
		}

		[Token(Token = "0x600053F")]
		public virtual void Init(PostProcessingContext pcontext, T pmodel)
		{
		}

		[Token(Token = "0x6000540")]
		public override PostProcessingModel GetModel()
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		protected PostProcessingComponent()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public abstract class PostProcessingComponentCommandBuffer<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		[Token(Token = "0x6000542")]
		public abstract CameraEvent GetCameraEvent();

		[Token(Token = "0x6000543")]
		public abstract string GetName();

		[Token(Token = "0x6000544")]
		public abstract void PopulateCommandBuffer(CommandBuffer cb);

		[Token(Token = "0x6000545")]
		protected PostProcessingComponentCommandBuffer()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public abstract class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
	{
		[Token(Token = "0x6000546")]
		public virtual void Prepare(Material material)
		{
		}

		[Token(Token = "0x6000547")]
		protected PostProcessingComponentRenderTexture()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class PostProcessingContext
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PostProcessingProfile profile;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera camera;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MaterialFactory materialFactory;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RenderTextureFactory renderTextureFactory;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46FF88", Offset = "0x46FF88")]
		private bool <interrupted>k__BackingField;

		[Token(Token = "0x1700009F")]
		public bool interrupted
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x7B1F70", Offset = "0x7B1F70", VA = "0x7B1F70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47211C", Offset = "0x47211C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x7B1F78", Offset = "0x7B1F78", VA = "0x7B1F78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47212C", Offset = "0x47212C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public bool isGBufferAvailable
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x7B1F90", Offset = "0x7B1F90", VA = "0x7B1F90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public bool isHdr
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x7B1FBC", Offset = "0x7B1FBC", VA = "0x7B1FBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		public int width
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x7B1FD8", Offset = "0x7B1FD8", VA = "0x7B1FD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A3")]
		public int height
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x7B1FF4", Offset = "0x7B1FF4", VA = "0x7B1FF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A4")]
		public Rect viewport
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x7B2010", Offset = "0x7B2010", VA = "0x7B2010")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x7B1F84", Offset = "0x7B1F84", VA = "0x7B1F84")]
		public void Interrupt()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x7B0BA0", Offset = "0x7B0BA0", VA = "0x7B0BA0")]
		public PostProcessingContext Reset()
		{
			return null;
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x7B05A4", Offset = "0x7B05A4", VA = "0x7B05A4")]
		public PostProcessingContext()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000171")]
	public abstract class PostProcessingModel
	{
		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "GetSetAttribute", RVA = "0x46FF98", Offset = "0x46FF98")]
		private bool m_Enabled;

		[Token(Token = "0x170000A5")]
		public bool enabled
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x7B202C", Offset = "0x7B202C", VA = "0x7B202C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x7B2034", Offset = "0x7B2034", VA = "0x7B2034")]
			set
			{
			}
		}

		[Token(Token = "0x6000554")]
		public abstract void Reset();

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x7B2050", Offset = "0x7B2050", VA = "0x7B2050", Slot = "5")]
		public virtual void OnValidate()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x7B2054", Offset = "0x7B2054", VA = "0x7B2054")]
		protected PostProcessingModel()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class PostProcessingProfile : ScriptableObject
	{
		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BuiltinDebugViewsModel debugViews;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FogModel fog;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AntialiasingModel antialiasing;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AmbientOcclusionModel ambientOcclusion;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ScreenSpaceReflectionModel screenSpaceReflection;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DepthOfFieldModel depthOfField;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MotionBlurModel motionBlur;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public EyeAdaptationModel eyeAdaptation;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BloomModel bloom;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ColorGradingModel colorGrading;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UserLutModel userLut;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ChromaticAberrationModel chromaticAberration;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GrainModel grain;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public VignetteModel vignette;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DitheringModel dithering;

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x7B205C", Offset = "0x7B205C", VA = "0x7B205C")]
		public PostProcessingProfile()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000173")]
	public sealed class ColorGradingCurve
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Loop;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_ZeroValue;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_Range;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AnimationCurve m_InternalLoopingCurve;

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x75A3E4", Offset = "0x75A3E4", VA = "0x75A3E4")]
		public ColorGradingCurve(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x7593F0", Offset = "0x7593F0", VA = "0x7593F0")]
		public void Cache()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x7595D8", Offset = "0x7595D8", VA = "0x7595D8")]
		public float Evaluate(float t)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000174")]
	public static class GraphicsUtils
	{
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D s_WhiteTexture;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Mesh s_Quad;

		[Token(Token = "0x170000A6")]
		public static bool isLinearColorSpace
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x85D0EC", Offset = "0x85D0EC", VA = "0x85D0EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		public static bool supportsDX11
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x85E3DC", Offset = "0x85E3DC", VA = "0x85E3DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		public static Texture2D whiteTexture
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x85E40C", Offset = "0x85E40C", VA = "0x85E40C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public static Mesh quad
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x85E560", Offset = "0x85E560", VA = "0x85E560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x85E7EC", Offset = "0x85E7EC", VA = "0x85E7EC")]
		public static void Blit(Material material, int pass)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x85E8F0", Offset = "0x85E8F0", VA = "0x85E8F0")]
		public static void ClearAndBlit(Texture source, RenderTexture destination, Material material, int pass, bool clearColor = true, bool clearDepth = false)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x859624", Offset = "0x859624", VA = "0x859624")]
		public static void Destroy(Object obj)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x85EA88", Offset = "0x85EA88", VA = "0x85EA88")]
		public static void Dispose()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public sealed class MaterialFactory : IDisposable
	{
		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, Material> m_Materials;

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x919F8C", Offset = "0x919F8C", VA = "0x919F8C")]
		public MaterialFactory()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x91A010", Offset = "0x91A010", VA = "0x91A010")]
		public Material Get(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x91A218", Offset = "0x91A218", VA = "0x91A218", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000176")]
	public sealed class RenderTextureFactory : IDisposable
	{
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HashSet<RenderTexture> m_TemporaryRTs;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x7B0520", Offset = "0x7B0520", VA = "0x7B0520")]
		public RenderTextureFactory()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x7B1864", Offset = "0x7B1864", VA = "0x7B1864")]
		public RenderTexture Get(RenderTexture baseRenderTexture)
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x7B4A68", Offset = "0x7B4A68", VA = "0x7B4A68")]
		public RenderTexture Get(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite rw = RenderTextureReadWrite.Default, FilterMode filterMode = FilterMode.Bilinear, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "FactoryTempTexture")
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x7B4B58", Offset = "0x7B4B58", VA = "0x7B4B58")]
		public void Release(RenderTexture rt)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x7B1980", Offset = "0x7B1980", VA = "0x7B1980")]
		public void ReleaseAll()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x7B1E58", Offset = "0x7B1E58", VA = "0x7B1E58", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x2000177")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x170000AA")]
		public bool Highlight
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x7581EC", Offset = "0x7581EC", VA = "0x7581EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x7581F4", Offset = "0x7581F4", VA = "0x7581F4")]
			set
			{
			}
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x758200", Offset = "0x758200", VA = "0x758200")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x7583C8", Offset = "0x7583C8", VA = "0x7583C8", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x7583F0", Offset = "0x7583F0", VA = "0x7583F0", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x758418", Offset = "0x758418", VA = "0x758418")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x7582C8", Offset = "0x7582C8", VA = "0x7582C8")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x7586EC", Offset = "0x7586EC", VA = "0x7586EC")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x2000178")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x170000AB")]
		public bool InRange
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x856DF0", Offset = "0x856DF0", VA = "0x856DF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x856DF8", Offset = "0x856DF8", VA = "0x856DF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public bool Targeted
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x856F70", Offset = "0x856F70", VA = "0x856F70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x856F78", Offset = "0x856F78", VA = "0x856F78")]
			set
			{
			}
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x856F84", Offset = "0x856F84", VA = "0x856F84", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x856E04", Offset = "0x856E04", VA = "0x856E04")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x85718C", Offset = "0x85718C", VA = "0x85718C")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x2000179")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x46CA44", Offset = "0x46CA44")]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x170000AD")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x857194", Offset = "0x857194", VA = "0x857194")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x85719C", Offset = "0x85719C", VA = "0x85719C")]
			set
			{
			}
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x8571B8", Offset = "0x8571B8", VA = "0x8571B8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x8573F8", Offset = "0x8573F8", VA = "0x8573F8", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x857D10", Offset = "0x857D10", VA = "0x857D10", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x8581A4", Offset = "0x8581A4", VA = "0x8581A4", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x858464", Offset = "0x858464", VA = "0x858464")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x85766C", Offset = "0x85766C", VA = "0x85766C")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x858554", Offset = "0x858554", VA = "0x858554")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x8589B0", Offset = "0x8589B0", VA = "0x8589B0", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x8589C8", Offset = "0x8589C8", VA = "0x8589C8", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x8589D0", Offset = "0x8589D0", VA = "0x8589D0")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x85DB84", Offset = "0x85DB84", VA = "0x85DB84")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x85DC3C", Offset = "0x85DC3C", VA = "0x85DC3C")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x85DCF0", Offset = "0x85DCF0", VA = "0x85DCF0")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x200017B")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x200017C")]
		public enum CrosshairState
		{
			[Token(Token = "0x40007BB")]
			Disabled,
			[Token(Token = "0x40007BC")]
			Enabled,
			[Token(Token = "0x40007BD")]
			Targeted
		}

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x85DDB0", Offset = "0x85DDB0", VA = "0x85DDB0")]
		private void Start()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x8570F0", Offset = "0x8570F0", VA = "0x8570F0")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x85DE1C", Offset = "0x85DE1C", VA = "0x85DE1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x85DE64", Offset = "0x85DE64", VA = "0x85DE64")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x7AF1AC", Offset = "0x7AF1AC", VA = "0x7AF1AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x7AF298", Offset = "0x7AF298", VA = "0x7AF298")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x7AF2A4", Offset = "0x7AF2A4", VA = "0x7AF2A4")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x7AF2B0", Offset = "0x7AF2B0", VA = "0x7AF2B0")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x74B9C4", Offset = "0x74B9C4", VA = "0x74B9C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x74BA18", Offset = "0x74BA18", VA = "0x74BA18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x74BD84", Offset = "0x74BD84", VA = "0x74BD84")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x74BE88", Offset = "0x74BE88", VA = "0x74BE88")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x74BA1C", Offset = "0x74BA1C", VA = "0x74BA1C")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x74BF8C", Offset = "0x74BF8C", VA = "0x74BF8C")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000180")]
		public enum ContactTest
		{
			[Token(Token = "0x40007D0")]
			PerpenTest,
			[Token(Token = "0x40007D1")]
			BackwardsPress
		}

		[Token(Token = "0x40007C1")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x40007C2")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470144", Offset = "0x470144")]
		private InteractableState <CurrentButtonState>k__BackingField;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x170000AE")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x74D310", Offset = "0x74D310", VA = "0x74D310", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AF")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x74D318", Offset = "0x74D318", VA = "0x74D318")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B0")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x74D324", Offset = "0x74D324", VA = "0x74D324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47213C", Offset = "0x47213C")]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x74D32C", Offset = "0x74D32C", VA = "0x74D32C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47214C", Offset = "0x47214C")]
			private set
			{
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x74D334", Offset = "0x74D334", VA = "0x74D334", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x74D448", Offset = "0x74D448", VA = "0x74D448")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x74D660", Offset = "0x74D660", VA = "0x74D660", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x74DC14", Offset = "0x74DC14", VA = "0x74DC14")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x74DCC0", Offset = "0x74DCC0", VA = "0x74DCC0")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x74DB2C", Offset = "0x74DB2C", VA = "0x74DB2C")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x74DDC8", Offset = "0x74DDC8", VA = "0x74DDC8")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x74DE4C", Offset = "0x74DE4C", VA = "0x74DE4C")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x74DED8", Offset = "0x74DED8", VA = "0x74DED8")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000181")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470164", Offset = "0x470164")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470174", Offset = "0x470174")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x170000B1")]
		public Collider Collider
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x74E124", Offset = "0x74E124", VA = "0x74E124", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47215C", Offset = "0x47215C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x74E12C", Offset = "0x74E12C", VA = "0x74E12C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47216C", Offset = "0x47216C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x74E134", Offset = "0x74E134", VA = "0x74E134", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47217C", Offset = "0x47217C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x74E13C", Offset = "0x74E13C", VA = "0x74E13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47218C", Offset = "0x47218C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x74E144", Offset = "0x74E144", VA = "0x74E144", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x74E194", Offset = "0x74E194", VA = "0x74E194")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x74E228", Offset = "0x74E228", VA = "0x74E228")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public interface ColliderZone
	{
		[Token(Token = "0x170000B4")]
		Collider Collider
		{
			[Token(Token = "0x60005AD")]
			get;
		}

		[Token(Token = "0x170000B5")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x60005AE")]
			get;
		}

		[Token(Token = "0x170000B6")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60005AF")]
			get;
		}
	}
	[Token(Token = "0x2000183")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x74D5A8", Offset = "0x74D5A8", VA = "0x74D5A8")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000184")]
	public enum InteractionType
	{
		[Token(Token = "0x40007DA")]
		Enter,
		[Token(Token = "0x40007DB")]
		Stay,
		[Token(Token = "0x40007DC")]
		Exit
	}
	[Token(Token = "0x2000185")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x2000186")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x40007EE")]
			Mesh,
			[Token(Token = "0x40007EF")]
			Skeleton,
			[Token(Token = "0x40007F0")]
			Both
		}

		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CAA4", Offset = "0x46CAA4")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D2")]
				[Address(RVA = "0x9A967C", Offset = "0x9A967C", VA = "0x9A967C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x9A96C4", Offset = "0x9A96C4", VA = "0x9A96C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x9A93E8", Offset = "0x9A93E8", VA = "0x9A93E8")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x9A9414", Offset = "0x9A9414", VA = "0x9A9414", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x9A9418", Offset = "0x9A9418", VA = "0x9A9418", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x9A9684", Offset = "0x9A9684", VA = "0x9A9684", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007DD")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4701A4", Offset = "0x4701A4")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x170000B7")]
		public OVRHand RightHand
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x85B010", Offset = "0x85B010", VA = "0x85B010")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x8646D4", Offset = "0x8646D4", VA = "0x8646D4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x864744", Offset = "0x864744", VA = "0x864744")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x86477C", Offset = "0x86477C", VA = "0x86477C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x8647EC", Offset = "0x8647EC", VA = "0x8647EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x864824", Offset = "0x864824", VA = "0x864824")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x864894", Offset = "0x864894", VA = "0x864894")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x8648CC", Offset = "0x8648CC", VA = "0x8648CC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x86493C", Offset = "0x86493C", VA = "0x86493C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x864974", Offset = "0x864974", VA = "0x864974")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x85AFDC", Offset = "0x85AFDC", VA = "0x85AFDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x8649E4", Offset = "0x8649E4", VA = "0x8649E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x864A50", Offset = "0x864A50", VA = "0x864A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x864A84", Offset = "0x864A84", VA = "0x864A84")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x864AF0", Offset = "0x864AF0", VA = "0x864AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x864B24", Offset = "0x864B24", VA = "0x864B24")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x864B90", Offset = "0x864B90", VA = "0x864B90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x864BC4", Offset = "0x864BC4", VA = "0x864BC4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x864C30", Offset = "0x864C30", VA = "0x864C30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x864C64", Offset = "0x864C64", VA = "0x864C64")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public static HandsManager Instance
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x864CD0", Offset = "0x864CD0", VA = "0x864CD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47219C", Offset = "0x47219C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x864D1C", Offset = "0x864D1C", VA = "0x864D1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4721AC", Offset = "0x4721AC")]
			private set
			{
			}
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x864D70", Offset = "0x864D70", VA = "0x864D70")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x865144", Offset = "0x865144", VA = "0x865144")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x8650CC", Offset = "0x8650CC", VA = "0x8650CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4721BC", Offset = "0x4721BC")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x8651CC", Offset = "0x8651CC", VA = "0x8651CC")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x8652B0", Offset = "0x8652B0", VA = "0x8652B0")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x865490", Offset = "0x865490", VA = "0x865490")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x85AE50", Offset = "0x85AE50", VA = "0x85AE50")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x8656CC", Offset = "0x8656CC", VA = "0x8656CC")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000189")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x9A96CC", Offset = "0x9A96CC", VA = "0x9A96CC")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x170000C4")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x865B9C", Offset = "0x865B9C", VA = "0x865B9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x865BA4", Offset = "0x865BA4", VA = "0x865BA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x865BAC", Offset = "0x865BAC", VA = "0x865BAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x865BB4", Offset = "0x865BB4", VA = "0x865BB4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x865BBC", Offset = "0x865BBC", VA = "0x865BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47226C", Offset = "0x47226C")]
			add
			{
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x865C5C", Offset = "0x865C5C", VA = "0x865C5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47227C", Offset = "0x47227C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x865D6C", Offset = "0x865D6C", VA = "0x865D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47228C", Offset = "0x47228C")]
			add
			{
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x865E0C", Offset = "0x865E0C", VA = "0x865E0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47229C", Offset = "0x47229C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x865F1C", Offset = "0x865F1C", VA = "0x865F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4722AC", Offset = "0x4722AC")]
			add
			{
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x865FBC", Offset = "0x865FBC", VA = "0x865FBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4722BC", Offset = "0x4722BC")]
			remove
			{
			}
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x865CFC", Offset = "0x865CFC", VA = "0x865CFC", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x865EAC", Offset = "0x865EAC", VA = "0x865EAC", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x86605C", Offset = "0x86605C", VA = "0x86605C", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x60005E2")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x8660CC", Offset = "0x8660CC", VA = "0x8660CC", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x8661F8", Offset = "0x8661F8", VA = "0x8661F8", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x866324", Offset = "0x866324", VA = "0x866324")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x40007FC")]
		None,
		[Token(Token = "0x40007FD")]
		Proximity,
		[Token(Token = "0x40007FE")]
		Contact,
		[Token(Token = "0x40007FF")]
		Action
	}
	[Token(Token = "0x200018B")]
	public enum InteractableState
	{
		[Token(Token = "0x4000801")]
		Default,
		[Token(Token = "0x4000802")]
		ProximityState,
		[Token(Token = "0x4000803")]
		ContactState,
		[Token(Token = "0x4000804")]
		ActionState
	}
	[Token(Token = "0x200018C")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x866424", Offset = "0x866424", VA = "0x866424")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x170000C8")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x86632C", Offset = "0x86632C", VA = "0x86632C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x86612C", Offset = "0x86612C", VA = "0x86612C")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x866258", Offset = "0x866258", VA = "0x866258")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x866390", Offset = "0x866390", VA = "0x866390")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x200018F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CAB4", Offset = "0x46CAB4")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x9A9C30", Offset = "0x9A9C30", VA = "0x9A9C30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x9A9C78", Offset = "0x9A9C78", VA = "0x9A9C78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x9A9718", Offset = "0x9A9718", VA = "0x9A9718")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x9A9744", Offset = "0x9A9744", VA = "0x9A9744", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x9A97B4", Offset = "0x9A97B4", VA = "0x9A97B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x9A9760", Offset = "0x9A9760", VA = "0x9A9760")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x9A9C38", Offset = "0x9A9C38", VA = "0x9A9C38", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x867018", Offset = "0x867018", VA = "0x867018")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x867094", Offset = "0x867094", VA = "0x867094")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4722CC", Offset = "0x4722CC")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x867134", Offset = "0x867134", VA = "0x867134")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x86721C", Offset = "0x86721C", VA = "0x86721C")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x170000CB")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x85A918", Offset = "0x85A918", VA = "0x85A918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x85AA98", Offset = "0x85AA98", VA = "0x85AA98")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x867224", Offset = "0x867224", VA = "0x867224")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x8672CC", Offset = "0x8672CC", VA = "0x8672CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x867578", Offset = "0x867578", VA = "0x867578")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x8675C0", Offset = "0x8675C0", VA = "0x8675C0")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x867870", Offset = "0x867870", VA = "0x867870")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x8679BC", Offset = "0x8679BC", VA = "0x8679BC")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CAC4", Offset = "0x46CAC4")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000611")]
				[Address(RVA = "0x9A8398", Offset = "0x9A8398", VA = "0x9A8398", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x9A83E0", Offset = "0x9A83E0", VA = "0x9A83E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x9A7F64", Offset = "0x9A7F64", VA = "0x9A7F64")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x9A7F90", Offset = "0x9A7F90", VA = "0x9A7F90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x9A7F94", Offset = "0x9A7F94", VA = "0x9A7F94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x9A83A0", Offset = "0x9A83A0", VA = "0x9A83A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400081D")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x170000CC")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x85A7E8", Offset = "0x85A7E8", VA = "0x85A7E8", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000CD")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x85A7F0", Offset = "0x85A7F0", VA = "0x85A7F0", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000CE")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x85A7F8", Offset = "0x85A7F8", VA = "0x85A7F8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public override bool EnableState
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x85A800", Offset = "0x85A800", VA = "0x85A800", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x85A82C", Offset = "0x85A82C", VA = "0x85A82C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x85A868", Offset = "0x85A868", VA = "0x85A868", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x85AB40", Offset = "0x85AB40", VA = "0x85AB40")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47237C", Offset = "0x47237C")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x85ABB8", Offset = "0x85ABB8", VA = "0x85ABB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x85B048", Offset = "0x85B048", VA = "0x85B048")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x85B1D4", Offset = "0x85B1D4", VA = "0x85B1D4")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x85B2C8", Offset = "0x85B2C8", VA = "0x85B2C8", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x85B614", Offset = "0x85B614", VA = "0x85B614", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x85B618", Offset = "0x85B618", VA = "0x85B618", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x85B61C", Offset = "0x85B61C", VA = "0x85B61C")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470234", Offset = "0x470234")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470244", Offset = "0x470244")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470254", Offset = "0x470254")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x170000D2")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x85B7C0", Offset = "0x85B7C0", VA = "0x85B7C0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47242C", Offset = "0x47242C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x85B7C8", Offset = "0x85B7C8", VA = "0x85B7C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47243C", Offset = "0x47243C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool EnableState
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x85B7D0", Offset = "0x85B7D0", VA = "0x85B7D0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x85B7EC", Offset = "0x85B7EC", VA = "0x85B7EC", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x85B80C", Offset = "0x85B80C", VA = "0x85B80C", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47244C", Offset = "0x47244C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x85B814", Offset = "0x85B814", VA = "0x85B814", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47245C", Offset = "0x47245C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public float SphereRadius
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x85B820", Offset = "0x85B820", VA = "0x85B820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47246C", Offset = "0x47246C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x85B828", Offset = "0x85B828", VA = "0x85B828")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47247C", Offset = "0x47247C")]
			private set
			{
			}
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x85B830", Offset = "0x85B830", VA = "0x85B830")]
		private void Awake()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x85B878", Offset = "0x85B878", VA = "0x85B878", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x85B87C", Offset = "0x85B87C", VA = "0x85B87C")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x2000194")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x4000830")]
		None = 0,
		[Token(Token = "0x4000831")]
		Ray = 1,
		[Token(Token = "0x4000832")]
		Poke = 4,
		[Token(Token = "0x4000833")]
		All = -1
	}
	[Token(Token = "0x2000195")]
	public enum ToolInputState
	{
		[Token(Token = "0x4000835")]
		Inactive,
		[Token(Token = "0x4000836")]
		PrimaryInputDown,
		[Token(Token = "0x4000837")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000838")]
		PrimaryInputUp
	}
	[Token(Token = "0x2000196")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x85B5BC", Offset = "0x85B5BC", VA = "0x85B5BC")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x2000197")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470264", Offset = "0x470264")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470274", Offset = "0x470274")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470284", Offset = "0x470284")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000D6")]
		public Transform ToolTransform
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x8664E8", Offset = "0x8664E8", VA = "0x8664E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x8664F0", Offset = "0x8664F0", VA = "0x8664F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47248C", Offset = "0x47248C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x8664F8", Offset = "0x8664F8", VA = "0x8664F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47249C", Offset = "0x47249C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000623")]
			get;
		}

		[Token(Token = "0x170000D9")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x6000624")]
			get;
		}

		[Token(Token = "0x170000DA")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x6000625")]
			get;
		}

		[Token(Token = "0x170000DB")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x866504", Offset = "0x866504", VA = "0x866504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4724AC", Offset = "0x4724AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x866510", Offset = "0x866510", VA = "0x866510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4724BC", Offset = "0x4724BC")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x86651C", Offset = "0x86651C", VA = "0x86651C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4724CC", Offset = "0x4724CC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x866528", Offset = "0x866528", VA = "0x866528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4724DC", Offset = "0x4724DC")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public abstract bool EnableState
		{
			[Token(Token = "0x600062E")]
			get;
			[Token(Token = "0x600062F")]
			set;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x866534", Offset = "0x866534", VA = "0x866534")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x600062C")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x600062D")]
		public abstract void DeFocus();

		[Token(Token = "0x6000630")]
		public abstract void Initialize();

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x86653C", Offset = "0x86653C", VA = "0x86653C")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x866588", Offset = "0x866588", VA = "0x866588")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x8665DC", Offset = "0x8665DC", VA = "0x8665DC", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x86688C", Offset = "0x86688C", VA = "0x86688C", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x85B630", Offset = "0x85B630", VA = "0x85B630")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170000DE")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x6000636")]
			get;
		}

		[Token(Token = "0x170000DF")]
		bool EnableState
		{
			[Token(Token = "0x6000638")]
			get;
			[Token(Token = "0x6000639")]
			set;
		}

		[Token(Token = "0x170000E0")]
		bool ToolActivateState
		{
			[Token(Token = "0x600063A")]
			get;
			[Token(Token = "0x600063B")]
			set;
		}

		[Token(Token = "0x6000637")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x2000199")]
	public class PinchStateModule
	{
		[Token(Token = "0x200019A")]
		private enum PinchState
		{
			[Token(Token = "0x4000849")]
			None,
			[Token(Token = "0x400084A")]
			PinchDown,
			[Token(Token = "0x400084B")]
			PinchStay,
			[Token(Token = "0x400084C")]
			PinchUp
		}

		[Token(Token = "0x4000845")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000E1")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x7AF2B8", Offset = "0x7AF2B8", VA = "0x7AF2B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E2")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x7AF340", Offset = "0x7AF340", VA = "0x7AF340")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x7AF3C8", Offset = "0x7AF3C8", VA = "0x7AF3C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x7AF450", Offset = "0x7AF450", VA = "0x7AF450")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x7AF484", Offset = "0x7AF484", VA = "0x7AF484")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x200019B")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x400084D")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x400084E")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x400084F")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x4000850")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x4000851")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4702A4", Offset = "0x4702A4")]
		[SerializeField]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000E4")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x7B23DC", Offset = "0x7B23DC", VA = "0x7B23DC", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000E5")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x7B23E4", Offset = "0x7B23E4", VA = "0x7B23E4", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000E6")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x7B244C", Offset = "0x7B244C", VA = "0x7B244C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E7")]
		public override bool EnableState
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x7B2454", Offset = "0x7B2454", VA = "0x7B2454", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x7B2498", Offset = "0x7B2498", VA = "0x7B2498", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x7B250C", Offset = "0x7B250C", VA = "0x7B250C", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x7B2574", Offset = "0x7B2574", VA = "0x7B2574")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x7B2618", Offset = "0x7B2618", VA = "0x7B2618")]
		private void Update()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x7B28D0", Offset = "0x7B28D0", VA = "0x7B28D0")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x7B2958", Offset = "0x7B2958", VA = "0x7B2958", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x7B2D28", Offset = "0x7B2D28", VA = "0x7B2D28")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x7B2E38", Offset = "0x7B2E38", VA = "0x7B2E38")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x7B2F5C", Offset = "0x7B2F5C", VA = "0x7B2F5C")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x7B3260", Offset = "0x7B3260", VA = "0x7B3260")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x7B35F4", Offset = "0x7B35F4", VA = "0x7B35F4", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x7B36DC", Offset = "0x7B36DC", VA = "0x7B36DC", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x7B3718", Offset = "0x7B3718", VA = "0x7B3718")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x400085D")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x400085E")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470318", Offset = "0x470318")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x170000E8")]
		public bool EnableState
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x7B247C", Offset = "0x7B247C", VA = "0x7B247C", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x7B24B4", Offset = "0x7B24B4", VA = "0x7B24B4", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x7B3824", Offset = "0x7B3824", VA = "0x7B3824", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x7B2894", Offset = "0x7B2894", VA = "0x7B2894", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x7B3A84", Offset = "0x7B3A84", VA = "0x7B3A84", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4724EC", Offset = "0x4724EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x7B3A8C", Offset = "0x7B3A8C", VA = "0x7B3A8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4724FC", Offset = "0x4724FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x7B382C", Offset = "0x7B382C", VA = "0x7B382C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x7B3630", Offset = "0x7B3630", VA = "0x7B3630", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x7B3A94", Offset = "0x7B3A94", VA = "0x7B3A94")]
		private void Update()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x7B3D08", Offset = "0x7B3D08", VA = "0x7B3D08")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x7B3DF8", Offset = "0x7B3DF8", VA = "0x7B3DF8")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x200019D")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000EB")]
		public bool UseSpherecast
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x8589F0", Offset = "0x8589F0", VA = "0x8589F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x8589F8", Offset = "0x8589F8", VA = "0x8589F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x858A80", Offset = "0x858A80", VA = "0x858A80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x858A88", Offset = "0x858A88", VA = "0x858A88")]
			set
			{
			}
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x858AF4", Offset = "0x858AF4", VA = "0x858AF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x858DB8", Offset = "0x858DB8", VA = "0x858DB8")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x858DC8", Offset = "0x858DC8", VA = "0x858DC8")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x858DD8", Offset = "0x858DD8", VA = "0x858DD8")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x200019E")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x75AA20", Offset = "0x75AA20", VA = "0x75AA20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x75AA24", Offset = "0x75AA24", VA = "0x75AA24")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x75AA5C", Offset = "0x75AA5C", VA = "0x75AA5C")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x75AA94", Offset = "0x75AA94", VA = "0x75AA94")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x75AACC", Offset = "0x75AACC", VA = "0x75AACC")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x75AB04", Offset = "0x75AB04", VA = "0x75AB04")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x75AB3C", Offset = "0x75AB3C", VA = "0x75AB3C")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x75AB74", Offset = "0x75AB74", VA = "0x75AB74")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x75ABE8", Offset = "0x75ABE8", VA = "0x75ABE8")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x75AC58", Offset = "0x75AC58", VA = "0x75AC58")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x75AC60", Offset = "0x75AC60", VA = "0x75AC60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x75AC64", Offset = "0x75AC64", VA = "0x75AC64")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x75AC1C", Offset = "0x75AC1C", VA = "0x75AC1C")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x75ACA4", Offset = "0x75ACA4", VA = "0x75ACA4")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20001A0")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20001A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CAE4", Offset = "0x46CAE4")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000ED")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600067B")]
				[Address(RVA = "0x9AE44C", Offset = "0x9AE44C", VA = "0x9AE44C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x9AE494", Offset = "0x9AE494", VA = "0x9AE494", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x9AE260", Offset = "0x9AE260", VA = "0x9AE260")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x9AE28C", Offset = "0x9AE28C", VA = "0x9AE28C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x9AE290", Offset = "0x9AE290", VA = "0x9AE290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x9AE454", Offset = "0x9AE454", VA = "0x9AE454", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400086E")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x400086F")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x7AD490", Offset = "0x7AD490", VA = "0x7AD490")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x7AD53C", Offset = "0x7AD53C", VA = "0x7AD53C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x7AD78C", Offset = "0x7AD78C", VA = "0x7AD78C")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x7AD714", Offset = "0x7AD714", VA = "0x7AD714")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47250C", Offset = "0x47250C")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x7AD7D8", Offset = "0x7AD7D8", VA = "0x7AD7D8")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20001A3")]
		public enum SelectionState
		{
			[Token(Token = "0x4000885")]
			Off,
			[Token(Token = "0x4000886")]
			Selected,
			[Token(Token = "0x4000887")]
			Highlighted
		}

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000EF")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x8907F4", Offset = "0x8907F4", VA = "0x8907F4")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x8907FC", Offset = "0x8907FC", VA = "0x8907FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x890980", Offset = "0x890980", VA = "0x890980")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x890B84", Offset = "0x890B84", VA = "0x890B84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x890884", Offset = "0x890884", VA = "0x890884")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x890C70", Offset = "0x890C70", VA = "0x890C70")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20001A5")]
		public enum SegmentType
		{
			[Token(Token = "0x4000896")]
			Straight,
			[Token(Token = "0x4000897")]
			LeftTurn,
			[Token(Token = "0x4000898")]
			RightTurn,
			[Token(Token = "0x4000899")]
			Switch
		}

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x400088E")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x400088F")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4703F8", Offset = "0x4703F8")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000F0")]
		public float StartDistance
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x89CE48", Offset = "0x89CE48", VA = "0x89CE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4725BC", Offset = "0x4725BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x89CE50", Offset = "0x89CE50", VA = "0x89CE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4725CC", Offset = "0x4725CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public float GridSize
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x89CE58", Offset = "0x89CE58", VA = "0x89CE58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x89CE60", Offset = "0x89CE60", VA = "0x89CE60")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public int SubDivCount
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x89CE68", Offset = "0x89CE68", VA = "0x89CE68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x89CE70", Offset = "0x89CE70", VA = "0x89CE70")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public SegmentType Type
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x89CE78", Offset = "0x89CE78", VA = "0x89CE78")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000F4")]
		public Pose EndPose
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x89CE80", Offset = "0x89CE80", VA = "0x89CE80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		public float Radius
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x89D1DC", Offset = "0x89D1DC", VA = "0x89D1DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F6")]
		public float SegmentLength
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x89CEE8", Offset = "0x89CEE8", VA = "0x89CEE8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x89D1EC", Offset = "0x89D1EC", VA = "0x89D1EC")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x89D204", Offset = "0x89D204", VA = "0x89D204")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x89CF28", Offset = "0x89CF28", VA = "0x89CF28")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x89D208", Offset = "0x89D208", VA = "0x89D208")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x89D20C", Offset = "0x89D20C", VA = "0x89D20C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x89D274", Offset = "0x89D274", VA = "0x89D274")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x89DB3C", Offset = "0x89DB3C", VA = "0x89DB3C")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x89DDE8", Offset = "0x89DDE8", VA = "0x89DDE8")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20001A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CAF4", Offset = "0x46CAF4")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000F7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0x9AFE6C", Offset = "0x9AFE6C", VA = "0x9AFE6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A7")]
				[Address(RVA = "0x9AFEB4", Offset = "0x9AFEB4", VA = "0x9AFEB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x9AFCC8", Offset = "0x9AFCC8", VA = "0x9AFCC8")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x9AFCF4", Offset = "0x9AFCF4", VA = "0x9AFCF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x9AFCF8", Offset = "0x9AFCF8", VA = "0x9AFCF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x9AFE74", Offset = "0x9AFE74", VA = "0x9AFE74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400089A")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x400089B")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x89DEF4", Offset = "0x89DEF4", VA = "0x89DEF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x89DFB0", Offset = "0x89DFB0", VA = "0x89DFB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x89E060", Offset = "0x89E060", VA = "0x89E060")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x89E1D8", Offset = "0x89E1D8", VA = "0x89E1D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x89E3A0", Offset = "0x89E3A0", VA = "0x89E3A0")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x89E488", Offset = "0x89E488", VA = "0x89E488")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x89E69C", Offset = "0x89E69C", VA = "0x89E69C")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x89E59C", Offset = "0x89E59C", VA = "0x89E59C")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x89E5B0", Offset = "0x89E5B0", VA = "0x89E5B0")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x89E6F4", Offset = "0x89E6F4", VA = "0x89E6F4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4725DC", Offset = "0x4725DC")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x89E76C", Offset = "0x89E76C", VA = "0x89E76C")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000F9")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x89E81C", Offset = "0x89E81C", VA = "0x89E81C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x89E82C", Offset = "0x89E82C", VA = "0x89E82C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x89E834", Offset = "0x89E834", VA = "0x89E834", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x89EB78", Offset = "0x89EB78", VA = "0x89EB78")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x40008B3")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x40008B4")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4704F8", Offset = "0x4704F8")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000FA")]
		public float Distance
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x89EC88", Offset = "0x89EC88", VA = "0x89EC88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47268C", Offset = "0x47268C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x89EC90", Offset = "0x89EC90", VA = "0x89EC90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47269C", Offset = "0x47269C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public float Scale
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x89EC98", Offset = "0x89EC98", VA = "0x89EC98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x89ECA0", Offset = "0x89ECA0", VA = "0x89ECA0")]
			set
			{
			}
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x89E830", Offset = "0x89E830", VA = "0x89E830", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x89ECA8", Offset = "0x89ECA8", VA = "0x89ECA8")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x89E87C", Offset = "0x89E87C", VA = "0x89E87C")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x89EAA0", Offset = "0x89EAA0", VA = "0x89EAA0")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x60006B4")]
		public abstract void UpdatePosition();

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x89EBE4", Offset = "0x89EBE4", VA = "0x89EBE4")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20001AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CB04", Offset = "0x46CB04")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000FC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x9B0154", Offset = "0x9B0154", VA = "0x9B0154", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x9B019C", Offset = "0x9B019C", VA = "0x9B019C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x9AFEBC", Offset = "0x9AFEBC", VA = "0x9AFEBC")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x9AFEE8", Offset = "0x9AFEE8", VA = "0x9AFEE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x9AFEEC", Offset = "0x9AFEEC", VA = "0x9AFEEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x9B015C", Offset = "0x9B015C", VA = "0x9B015C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x89EE48", Offset = "0x89EE48", VA = "0x89EE48")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x89EEA8", Offset = "0x89EEA8", VA = "0x89EEA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x89EFB0", Offset = "0x89EFB0", VA = "0x89EFB0")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x89F120", Offset = "0x89F120", VA = "0x89F120")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x89F010", Offset = "0x89F010", VA = "0x89F010")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x89F1F8", Offset = "0x89F1F8", VA = "0x89F1F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x4726AC", Offset = "0x4726AC")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x89F280", Offset = "0x89F280", VA = "0x89F280")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x89F32C", Offset = "0x89F32C", VA = "0x89F32C")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x89F38C", Offset = "0x89F38C", VA = "0x89F38C")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20001AC")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20001AD")]
		private enum EngineSoundState
		{
			[Token(Token = "0x40008F1")]
			Start,
			[Token(Token = "0x40008F2")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x40008F3")]
			Stop
		}

		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CB14", Offset = "0x46CB14")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x9B0418", Offset = "0x9B0418", VA = "0x9B0418", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006DA")]
				[Address(RVA = "0x9B0460", Offset = "0x9B0460", VA = "0x9B0460", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x9B01A4", Offset = "0x9B01A4", VA = "0x9B01A4")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x9B01D0", Offset = "0x9B01D0", VA = "0x9B01D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x9B01D4", Offset = "0x9B01D4", VA = "0x9B01D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x9B0420", Offset = "0x9B0420", VA = "0x9B0420", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008D3")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x40008D4")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x40008D5")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x40008D6")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x470558", Offset = "0x470558")]
		[SerializeField]
		protected float _initialSpeed;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x89F3E8", Offset = "0x89F3E8", VA = "0x89F3E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x89F554", Offset = "0x89F554", VA = "0x89F554")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x89F560", Offset = "0x89F560", VA = "0x89F560", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x89F6B0", Offset = "0x89F6B0", VA = "0x89F6B0")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x89F4C8", Offset = "0x89F4C8", VA = "0x89F4C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47275C", Offset = "0x47275C")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x89F710", Offset = "0x89F710", VA = "0x89F710")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x89F64C", Offset = "0x89F64C", VA = "0x89F64C")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x89F92C", Offset = "0x89F92C", VA = "0x89F92C")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x89FA68", Offset = "0x89FA68", VA = "0x89FA68")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x89F998", Offset = "0x89F998", VA = "0x89F998")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x89FAD4", Offset = "0x89FAD4", VA = "0x89FAD4")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x89FAF4", Offset = "0x89FAF4", VA = "0x89FAF4")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x89FB80", Offset = "0x89FB80", VA = "0x89FB80")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x89FC38", Offset = "0x89FC38", VA = "0x89FC38")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x89FC48", Offset = "0x89FC48", VA = "0x89FC48")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x17000100")]
		public float TrackLength
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x89FCB0", Offset = "0x89FCB0", VA = "0x89FCB0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x89FCB8", Offset = "0x89FCB8", VA = "0x89FCB8")]
			private set
			{
			}
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x89FCC0", Offset = "0x89FCC0", VA = "0x89FCC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x89ED28", Offset = "0x89ED28", VA = "0x89ED28")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x89FCC4", Offset = "0x89FCC4", VA = "0x89FCC4")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x89FED8", Offset = "0x89FED8", VA = "0x89FED8")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x89FFD4", Offset = "0x89FFD4", VA = "0x89FFD4")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	public class Pose
	{
		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x7AF998", Offset = "0x7AF998", VA = "0x7AF998")]
		public Pose()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x7AF9DC", Offset = "0x7AF9DC", VA = "0x7AF9DC")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x20001B1")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20001B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CB24", Offset = "0x46CB24")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000915")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000916")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x17000102")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006F0")]
				[Address(RVA = "0x9B08D0", Offset = "0x9B08D0", VA = "0x9B08D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0x9B0918", Offset = "0x9B0918", VA = "0x9B0918", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x9B0700", Offset = "0x9B0700", VA = "0x9B0700")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x9B072C", Offset = "0x9B072C", VA = "0x9B072C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x9B0730", Offset = "0x9B0730", VA = "0x9B0730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x9B08D8", Offset = "0x9B08D8", VA = "0x9B08D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CB34", Offset = "0x46CB34")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000917")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000918")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000919")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x9B0A28", Offset = "0x9B0A28", VA = "0x9B0A28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x9B0A70", Offset = "0x9B0A70", VA = "0x9B0A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x9B0920", Offset = "0x9B0920", VA = "0x9B0920")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x9B094C", Offset = "0x9B094C", VA = "0x9B094C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x9B0950", Offset = "0x9B0950", VA = "0x9B0950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x9B0A30", Offset = "0x9B0A30", VA = "0x9B0A30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000906")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x470740", Offset = "0x470740")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x17000101")]
		public bool IsMoving
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x8A0D64", Offset = "0x8A0D64", VA = "0x8A0D64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47280C", Offset = "0x47280C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x8A0D6C", Offset = "0x8A0D6C", VA = "0x8A0D6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47281C", Offset = "0x47281C")]
			private set
			{
			}
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x8A0D78", Offset = "0x8A0D78", VA = "0x8A0D78")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x8A0DB4", Offset = "0x8A0DB4", VA = "0x8A0DB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x8A0E98", Offset = "0x8A0E98", VA = "0x8A0E98")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x8A0F0C", Offset = "0x8A0F0C", VA = "0x8A0F0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47282C", Offset = "0x47282C")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x8A0F94", Offset = "0x8A0F94", VA = "0x8A0F94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47288C", Offset = "0x47288C")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x8A104C", Offset = "0x8A104C", VA = "0x8A104C")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x8A10B8", Offset = "0x8A10B8", VA = "0x8A10B8")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x8A10C0", Offset = "0x8A10C0", VA = "0x8A10C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x8A1134", Offset = "0x8A1134", VA = "0x8A1134")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x8A1218", Offset = "0x8A1218", VA = "0x8A1218")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x8A1350", Offset = "0x8A1350", VA = "0x8A1350")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x8A13D0", Offset = "0x8A13D0", VA = "0x8A13D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x8A14A8", Offset = "0x8A14A8", VA = "0x8A14A8")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x4000923")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x4000924")]
		EUDT_OverlayQuad,
		[Token(Token = "0x4000925")]
		EUDT_None,
		[Token(Token = "0x4000926")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x20001B6")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20001B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CB44", Offset = "0x46CB44")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400093F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000940")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000712")]
				[Address(RVA = "0x9AC994", Offset = "0x9AC994", VA = "0x9AC994", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000714")]
				[Address(RVA = "0x9AC9DC", Offset = "0x9AC9DC", VA = "0x9AC9DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x9AC764", Offset = "0x9AC764", VA = "0x9AC764")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x9AC790", Offset = "0x9AC790", VA = "0x9AC790", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x9AC794", Offset = "0x9AC794", VA = "0x9AC794", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x9AC99C", Offset = "0x9AC99C", VA = "0x9AC99C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000928")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000929")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x400092A")]
		private const string noneID = "NoneID";

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x470780", Offset = "0x470780")]
		public GameObject mainCamera;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4707B8", Offset = "0x4707B8")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x921690", Offset = "0x921690", VA = "0x921690")]
		private void Start()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x921EEC", Offset = "0x921EEC", VA = "0x921EEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x922034", Offset = "0x922034", VA = "0x922034")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x922170", Offset = "0x922170", VA = "0x922170")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x9222AC", Offset = "0x9222AC", VA = "0x9222AC")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x922008", Offset = "0x922008", VA = "0x922008")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x92238C", Offset = "0x92238C", VA = "0x92238C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x47298C", Offset = "0x47298C")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x922404", Offset = "0x922404", VA = "0x922404")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x921AF8", Offset = "0x921AF8", VA = "0x921AF8")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x922558", Offset = "0x922558", VA = "0x922558")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x922438", Offset = "0x922438", VA = "0x922438")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x922870", Offset = "0x922870", VA = "0x922870")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x922960", Offset = "0x922960", VA = "0x922960")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x9229F0", Offset = "0x9229F0", VA = "0x9229F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4729EC", Offset = "0x4729EC")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x922A48", Offset = "0x922A48", VA = "0x922A48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4729FC", Offset = "0x4729FC")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x922AA0", Offset = "0x922AA0", VA = "0x922AA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x472A0C", Offset = "0x472A0C")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20001B8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x46CB54", Offset = "0x46CB54")]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x46CBB4", Offset = "0x46CBB4")]
		private sealed class <>c
		{
			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x9A91E8", Offset = "0x9A91E8", VA = "0x9A91E8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x9A91F0", Offset = "0x9A91F0", VA = "0x9A91F0")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000942")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x4000943")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000944")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000945")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000946")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x4000947")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000948")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000949")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x400094A")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x400094B")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x400094C")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x4000955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x85EAD4", Offset = "0x85EAD4", VA = "0x85EAD4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x85EB30", Offset = "0x85EB30", VA = "0x85EB30")]
		private void Start()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x85EFC4", Offset = "0x85EFC4", VA = "0x85EFC4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x85F0B0", Offset = "0x85F0B0", VA = "0x85F0B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x85F214", Offset = "0x85F214", VA = "0x85F214")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x85F51C", Offset = "0x85F51C", VA = "0x85F51C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x85F614", Offset = "0x85F614", VA = "0x85F614")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x85F774", Offset = "0x85F774", VA = "0x85F774")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x85F2AC", Offset = "0x85F2AC", VA = "0x85F2AC")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x85F300", Offset = "0x85F300", VA = "0x85F300")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x85EE68", Offset = "0x85EE68", VA = "0x85EE68")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x85F8B0", Offset = "0x85F8B0", VA = "0x85F8B0")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20001BA")]
	public enum HandPoseId
	{
		[Token(Token = "0x4000961")]
		Default,
		[Token(Token = "0x4000962")]
		Generic,
		[Token(Token = "0x4000963")]
		PingPongBall,
		[Token(Token = "0x4000964")]
		Controller
	}
	[Token(Token = "0x20001BB")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x17000108")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x863D0C", Offset = "0x863D0C", VA = "0x863D0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x863D14", Offset = "0x863D14", VA = "0x863D14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010A")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x863D1C", Offset = "0x863D1C", VA = "0x863D1C")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x863D24", Offset = "0x863D24", VA = "0x863D24")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x89CAB8", Offset = "0x89CAB8", VA = "0x89CAB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x89CDA0", Offset = "0x89CDA0", VA = "0x89CDA0")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x89CDFC", Offset = "0x89CDFC", VA = "0x89CDFC")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x89CE40", Offset = "0x89CE40", VA = "0x89CE40")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Voice.Demo.UIShapesDemo
{
	[Token(Token = "0x20001BD")]
	public class InteractionHandler : MonoBehaviour
	{
		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Multiline]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x470870", Offset = "0x470870")]
		private string freshStateText;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x4708CC", Offset = "0x4708CC")]
		private Text textArea;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool showJson;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x470928", Offset = "0x470928")]
		private AppVoiceExperience appVoiceExperience;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string pendingText;

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x867AB4", Offset = "0x867AB4", VA = "0x867AB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x867B80", Offset = "0x867B80", VA = "0x867B80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x867C4C", Offset = "0x867C4C", VA = "0x867C4C")]
		private void OnRequestStarted(WitRequest r)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x867D0C", Offset = "0x867D0C", VA = "0x867D0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x867D64", Offset = "0x867D64", VA = "0x867D64")]
		public void OnResponse(WitResponseNode response)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x867E54", Offset = "0x867E54", VA = "0x867E54")]
		public void OnError(string error, string message)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x86805C", Offset = "0x86805C", VA = "0x86805C")]
		public void ToggleActivation()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x8680BC", Offset = "0x8680BC", VA = "0x8680BC")]
		public InteractionHandler()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x868118", Offset = "0x868118", VA = "0x868118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x472A6C", Offset = "0x472A6C")]
		private void <OnRequestStarted>b__7_0(string response)
		{
		}
	}
	[Token(Token = "0x20001BE")]
	public class ColorChanger : MonoBehaviour
	{
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x757EE8", Offset = "0x757EE8", VA = "0x757EE8")]
		private void SetColor(Transform trans, Color color)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x757F84", Offset = "0x757F84", VA = "0x757F84")]
		public void UpdateColor(WitResponseNode commandResult)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x7581A8", Offset = "0x7581A8", VA = "0x7581A8")]
		public void UpdateColor(string[] results)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x758018", Offset = "0x758018", VA = "0x758018")]
		public void UpdateColor(string colorName, string shape)
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x7581E4", Offset = "0x7581E4", VA = "0x7581E4")]
		public ColorChanger()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	[ExecuteAlways]
	public class Instructions : MonoBehaviour
	{
		[Token(Token = "0x20001C0")]
		internal enum Step
		{
			[Token(Token = "0x4000974")]
			SetupWit,
			[Token(Token = "0x4000975")]
			MissingServerToken,
			[Token(Token = "0x4000976")]
			MissingClientToken,
			[Token(Token = "0x4000977")]
			AddConfig,
			[Token(Token = "0x4000978")]
			AddVoiceExperiences,
			[Token(Token = "0x4000979")]
			SetConfig,
			[Token(Token = "0x400097A")]
			Ready
		}

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] steps;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text instructionText;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Step currentStep;

		[Token(Token = "0x1700010B")]
		internal Step CurrentStep
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x865820", Offset = "0x865820", VA = "0x865820")]
			get
			{
				return default(Step);
			}
		}

		[Token(Token = "0x1700010C")]
		internal string CurrentStepText
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x865828", Offset = "0x865828", VA = "0x865828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x8658BC", Offset = "0x8658BC", VA = "0x8658BC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x8658C4", Offset = "0x8658C4", VA = "0x8658C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x8658C8", Offset = "0x8658C8", VA = "0x8658C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x8658C0", Offset = "0x8658C0", VA = "0x8658C0")]
		private void UpdateStep()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x8658CC", Offset = "0x8658CC", VA = "0x8658CC")]
		public Instructions()
		{
		}
	}
}
namespace Oculus.Voice.Demo.BuiltInDemo
{
	[Token(Token = "0x20001C1")]
	public class TimerController : MonoBehaviour
	{
		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _time;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _timerExist;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool _timerRunning;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x470984", Offset = "0x470984")]
		public Text logText;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4709BC", Offset = "0x4709BC")]
		public AudioClip buzzSound;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x89C0DC", Offset = "0x89C0DC", VA = "0x89C0DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x89C1AC", Offset = "0x89C1AC", VA = "0x89C1AC")]
		private void Log(string msg)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x89C140", Offset = "0x89C140", VA = "0x89C140")]
		private void OnElapsedTime()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x89C23C", Offset = "0x89C23C", VA = "0x89C23C")]
		public void DeleteTimer()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x89C2B0", Offset = "0x89C2B0", VA = "0x89C2B0")]
		public void CreateTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x89C684", Offset = "0x89C684", VA = "0x89C684")]
		public void GetTimerIntent()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x89C734", Offset = "0x89C734", VA = "0x89C734")]
		public void PauseTimer()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x89C784", Offset = "0x89C784", VA = "0x89C784")]
		public void ResumeTimer()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x89C7D8", Offset = "0x89C7D8", VA = "0x89C7D8")]
		public void SubtractTimeTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x89C8F0", Offset = "0x89C8F0", VA = "0x89C8F0")]
		public void AddTimeToTimer(string[] entityValues)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x89C9FC", Offset = "0x89C9FC", VA = "0x89C9FC")]
		public float GetRemainingTime()
		{
			return default(float);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x89C6AC", Offset = "0x89C6AC", VA = "0x89C6AC")]
		public string GetFormattedTimeFromSeconds()
		{
			return null;
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x89C510", Offset = "0x89C510", VA = "0x89C510")]
		private bool ParseTime(string[] entityValues, out float time)
		{
			return default(bool);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x89CA04", Offset = "0x89CA04", VA = "0x89CA04")]
		public TimerController()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	public class TimerDisplay : MonoBehaviour
	{
		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TimerController timer;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text _uiText;

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x89CA0C", Offset = "0x89CA0C", VA = "0x89CA0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x89CA68", Offset = "0x89CA68", VA = "0x89CA68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x89CAB0", Offset = "0x89CAB0", VA = "0x89CAB0")]
		public TimerDisplay()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	public class WitActivation : MonoBehaviour
	{
		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppVoiceExperience voiceExperience;

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x8A14B8", Offset = "0x8A14B8", VA = "0x8A14B8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x8A1570", Offset = "0x8A1570", VA = "0x8A1570")]
		private void Start()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x8A15CC", Offset = "0x8A15CC", VA = "0x8A15CC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x8A1650", Offset = "0x8A1650", VA = "0x8A1650")]
		public void ActivateWit()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x8A1674", Offset = "0x8A1674", VA = "0x8A1674")]
		public WitActivation()
		{
		}
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x20001C4")]
	public static class AvatarLogger
	{
		[Token(Token = "0x4000983")]
		public const string LogAvatar = "[Avatars] - ";

		[Token(Token = "0x4000984")]
		public const string Tab = "    ";

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x74A3BC", Offset = "0x74A3BC", VA = "0x74A3BC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472A7C", Offset = "0x472A7C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472A7C", Offset = "0x472A7C")]
		public static void Log(string logMsg)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x74A44C", Offset = "0x74A44C", VA = "0x74A44C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472ADC", Offset = "0x472ADC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472ADC", Offset = "0x472ADC")]
		public static void Log(string logMsg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x74A4EC", Offset = "0x74A4EC", VA = "0x74A4EC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472B3C", Offset = "0x472B3C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472B3C", Offset = "0x472B3C")]
		public static void LogWarning(string logMsg)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x74A57C", Offset = "0x74A57C", VA = "0x74A57C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472B9C", Offset = "0x472B9C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472B9C", Offset = "0x472B9C")]
		public static void LogError(string logMsg)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x74A60C", Offset = "0x74A60C", VA = "0x74A60C")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472BFC", Offset = "0x472BFC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x472BFC", Offset = "0x472BFC")]
		public static void LogError(string logMsg, UnityEngine.Object context)
		{
		}
	}
	[Token(Token = "0x20001C5")]
	public class CAPI
	{
		[Token(Token = "0x20001C6")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x20001C7")]
		public enum Result
		{
			[Token(Token = "0x4000990")]
			Success = 0,
			[Token(Token = "0x4000991")]
			Failure = -1000,
			[Token(Token = "0x4000992")]
			Failure_InvalidParameter = -1001,
			[Token(Token = "0x4000993")]
			Failure_NotInitialized = -1002,
			[Token(Token = "0x4000994")]
			Failure_InvalidOperation = -1003,
			[Token(Token = "0x4000995")]
			Failure_Unsupported = -1004,
			[Token(Token = "0x4000996")]
			Failure_NotYetImplemented = -1005,
			[Token(Token = "0x4000997")]
			Failure_OperationFailed = -1006,
			[Token(Token = "0x4000998")]
			Failure_InsufficientSize = -1007
		}

		[Token(Token = "0x20001C8")]
		private static class OVRP_1_30_0
		{
			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Version version;

			[PreserveSig]
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x9A5EF8", Offset = "0x9A5EF8", VA = "0x9A5EF8")]
			public static extern Result ovrp_SendEvent2(string name, string param, string source);
		}

		[Token(Token = "0x4000985")]
		private const string LibFile = "ovravatarloader";

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[Token(Token = "0x400098D")]
		private const string ovrPluginDLL = "OVRPlugin";

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Version ovrPluginVersion;

		[PreserveSig]
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x74E294", Offset = "0x74E294", VA = "0x74E294")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x74E324", Offset = "0x74E324", VA = "0x74E324")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x74E548", Offset = "0x74E548", VA = "0x74E548")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x74E634", Offset = "0x74E634", VA = "0x74E634")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x74E6A4", Offset = "0x74E6A4", VA = "0x74E6A4")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x74E718", Offset = "0x74E718", VA = "0x74E718")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x74E798", Offset = "0x74E798", VA = "0x74E798")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x74E8DC", Offset = "0x74E8DC", VA = "0x74E8DC")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x74E95C", Offset = "0x74E95C", VA = "0x74E95C")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x74EAA0", Offset = "0x74EAA0", VA = "0x74EAA0")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x74EB20", Offset = "0x74EB20", VA = "0x74EB20")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x74EBA0", Offset = "0x74EBA0", VA = "0x74EBA0")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x74EC20", Offset = "0x74EC20", VA = "0x74EC20")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x74ECA0", Offset = "0x74ECA0", VA = "0x74ECA0")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x74ED30", Offset = "0x74ED30", VA = "0x74ED30")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x74EDC0", Offset = "0x74EDC0", VA = "0x74EDC0")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x74EE50", Offset = "0x74EE50", VA = "0x74EE50")]
		public static extern void ovrAvatar_RequestAvatarSpecification(ulong userID);

		[PreserveSig]
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x74EED0", Offset = "0x74EED0", VA = "0x74EED0")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x74EF50", Offset = "0x74EF50", VA = "0x74EF50")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x74EFE0", Offset = "0x74EFE0", VA = "0x74EFE0")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x74F070", Offset = "0x74F070", VA = "0x74F070")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x74F100", Offset = "0x74F100", VA = "0x74F100")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x74F180", Offset = "0x74F180", VA = "0x74F180")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x74F220", Offset = "0x74F220", VA = "0x74F220")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x74F29C", Offset = "0x74F29C", VA = "0x74F29C")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x74F33C", Offset = "0x74F33C", VA = "0x74F33C")]
		public static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight);

		[PreserveSig]
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x74F3FC", Offset = "0x74F3FC", VA = "0x74F3FC")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x74F4CC", Offset = "0x74F4CC", VA = "0x74F4CC")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x74F55C", Offset = "0x74F55C", VA = "0x74F55C")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x74F5EC", Offset = "0x74F5EC", VA = "0x74F5EC")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x74F67C", Offset = "0x74F67C", VA = "0x74F67C")]
		public static extern void ovrAvatar_SetLeftHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x74F70C", Offset = "0x74F70C", VA = "0x74F70C")]
		public static extern void ovrAvatar_SetRightHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x74F79C", Offset = "0x74F79C", VA = "0x74F79C")]
		public static extern uint ovrAvatarComponent_Count(IntPtr avatar);

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x74F81C", Offset = "0x74F81C", VA = "0x74F81C")]
		public static void ovrAvatarComponent_Get(IntPtr avatar, uint index, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x74F938", Offset = "0x74F938", VA = "0x74F938")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x74F8A8", Offset = "0x74F8A8", VA = "0x74F8A8")]
		public static extern IntPtr ovrAvatarComponent_Get_Native(IntPtr avatar, uint index);

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x74FB58", Offset = "0x74FB58", VA = "0x74FB58")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x74FCC8", Offset = "0x74FCC8", VA = "0x74FCC8")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000783")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x74FD48", Offset = "0x74FD48", VA = "0x74FD48")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x74FFF0", Offset = "0x74FFF0", VA = "0x74FFF0")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x750070", Offset = "0x750070", VA = "0x750070")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x7501E0", Offset = "0x7501E0", VA = "0x7501E0")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x750260", Offset = "0x750260", VA = "0x750260")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x7503D0", Offset = "0x7503D0", VA = "0x7503D0")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x750450", Offset = "0x750450", VA = "0x750450")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x7505C0", Offset = "0x7505C0", VA = "0x7505C0")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x750640", Offset = "0x750640", VA = "0x750640")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x7507B0", Offset = "0x7507B0", VA = "0x7507B0")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x750830", Offset = "0x750830", VA = "0x750830")]
		public static extern void ovrAvatarAsset_BeginLoading(ulong assetID);

		[PreserveSig]
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x7508B0", Offset = "0x7508B0", VA = "0x7508B0")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x750948", Offset = "0x750948", VA = "0x750948")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x7509C8", Offset = "0x7509C8", VA = "0x7509C8")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x750BA0", Offset = "0x750BA0", VA = "0x750BA0")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x750CF8", Offset = "0x750CF8", VA = "0x750CF8")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x750B20", Offset = "0x750B20", VA = "0x750B20")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x750D78", Offset = "0x750D78", VA = "0x750D78")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x750DF8", Offset = "0x750DF8", VA = "0x750DF8")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x750E88", Offset = "0x750E88", VA = "0x750E88")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x750F08", Offset = "0x750F08", VA = "0x750F08")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x750F98", Offset = "0x750F98", VA = "0x750F98")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x751018", Offset = "0x751018", VA = "0x751018")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x751098", Offset = "0x751098", VA = "0x751098")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x751324", Offset = "0x751324", VA = "0x751324")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x7513B4", Offset = "0x7513B4", VA = "0x7513B4")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x7515E4", Offset = "0x7515E4", VA = "0x7515E4")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x75167C", Offset = "0x75167C", VA = "0x75167C")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x7517CC", Offset = "0x7517CC", VA = "0x7517CC")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x75184C", Offset = "0x75184C", VA = "0x75184C")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x7518CC", Offset = "0x7518CC", VA = "0x7518CC")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x751A20", Offset = "0x751A20", VA = "0x751A20")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x751AA0", Offset = "0x751AA0", VA = "0x751AA0")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x751BF4", Offset = "0x751BF4", VA = "0x751BF4")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x751C74", Offset = "0x751C74", VA = "0x751C74")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x751D04", Offset = "0x751D04", VA = "0x751D04")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x751D94", Offset = "0x751D94", VA = "0x751D94")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x751E24", Offset = "0x751E24", VA = "0x751E24")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x751EA4", Offset = "0x751EA4", VA = "0x751EA4")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x751F2C", Offset = "0x751F2C", VA = "0x751F2C")]
		public static extern bool ovrAvatarSkinnedMeshRenderPBSV2_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x751FB4", Offset = "0x751FB4", VA = "0x751FB4")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x752034", Offset = "0x752034", VA = "0x752034")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x7520B4", Offset = "0x7520B4", VA = "0x7520B4")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x752168", Offset = "0x752168", VA = "0x752168")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x7521F8", Offset = "0x7521F8", VA = "0x7521F8")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x752288", Offset = "0x752288", VA = "0x752288")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x752308", Offset = "0x752308", VA = "0x752308")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x752388", Offset = "0x752388", VA = "0x752388")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x752408", Offset = "0x752408", VA = "0x752408")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x7524A0", Offset = "0x7524A0", VA = "0x7524A0")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x752530", Offset = "0x752530", VA = "0x752530")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x7525C0", Offset = "0x7525C0", VA = "0x7525C0")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x752650", Offset = "0x752650", VA = "0x752650")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x7526E8", Offset = "0x7526E8", VA = "0x7526E8")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x752780", Offset = "0x752780", VA = "0x752780")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x752800", Offset = "0x752800", VA = "0x752800")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x752880", Offset = "0x752880", VA = "0x752880")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x7529D4", Offset = "0x7529D4", VA = "0x7529D4")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x752A54", Offset = "0x752A54", VA = "0x752A54")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x752BA8", Offset = "0x752BA8", VA = "0x752BA8")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x752C28", Offset = "0x752C28", VA = "0x752C28")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x752D64", Offset = "0x752D64", VA = "0x752D64")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x752DE4", Offset = "0x752DE4", VA = "0x752DE4")]
		public static ovrAvatarRenderPart_ProjectorRender ovrAvatarRenderPart_GetProjectorRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_ProjectorRender);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x752FB8", Offset = "0x752FB8", VA = "0x752FB8")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x753298", Offset = "0x753298", VA = "0x753298")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x752F38", Offset = "0x752F38", VA = "0x752F38")]
		private static extern IntPtr ovrAvatarRenderPart_GetProjectorRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x753328", Offset = "0x753328", VA = "0x753328")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x7533A8", Offset = "0x7533A8", VA = "0x7533A8")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x753438", Offset = "0x753438", VA = "0x753438")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x7534C8", Offset = "0x7534C8", VA = "0x7534C8")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x753558", Offset = "0x753558", VA = "0x753558")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x7535F8", Offset = "0x7535F8", VA = "0x7535F8")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x753698", Offset = "0x753698", VA = "0x753698")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x753738", Offset = "0x753738", VA = "0x753738")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x7537B8", Offset = "0x7537B8", VA = "0x7537B8")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x753838", Offset = "0x753838", VA = "0x753838")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x7538B8", Offset = "0x7538B8", VA = "0x7538B8")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x753938", Offset = "0x753938", VA = "0x753938")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x7539B8", Offset = "0x7539B8", VA = "0x7539B8")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x753AE0", Offset = "0x753AE0", VA = "0x753AE0")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x753B78", Offset = "0x753B78", VA = "0x753B78")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x753BF8", Offset = "0x753BF8", VA = "0x753BF8")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x753C58", Offset = "0x753C58", VA = "0x753C58")]
		public static void ovrAvatar_OverrideExpressiveLogic(IntPtr avatar, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x753DA0", Offset = "0x753DA0", VA = "0x753DA0")]
		private static extern void ovrAvatar_OverrideExpressiveLogic_Native(IntPtr avatar, IntPtr state);

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x753E30", Offset = "0x753E30", VA = "0x753E30")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x753F88", Offset = "0x753F88", VA = "0x753F88")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x754018", Offset = "0x754018", VA = "0x754018")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x7540B8", Offset = "0x7540B8", VA = "0x7540B8")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x754488", Offset = "0x754488", VA = "0x754488")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x754508", Offset = "0x754508", VA = "0x754508")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x7545A0", Offset = "0x7545A0", VA = "0x7545A0")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x754E00", Offset = "0x754E00", VA = "0x754E00")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[PreserveSig]
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x754E80", Offset = "0x754E80", VA = "0x754E80")]
		public static extern void ovrAvatar_RemoveLights(uint lightCount, uint[] ids);

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x74E230", Offset = "0x74E230", VA = "0x74E230")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x472C5C", Offset = "0x472C5C")]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x754F18", Offset = "0x754F18", VA = "0x754F18")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x754F9C", Offset = "0x754F9C", VA = "0x754F9C")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);

		[PreserveSig]
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x75501C", Offset = "0x75501C", VA = "0x75501C")]
		public static extern IntPtr ovrAvatar_GetDebugTransforms_Native(IntPtr count);

		[PreserveSig]
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x75509C", Offset = "0x75509C", VA = "0x75509C")]
		public static extern IntPtr ovrAvatar_GetDebugLines_Native(IntPtr count);

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x75511C", Offset = "0x75511C", VA = "0x75511C")]
		public static void ovrAvatar_DrawDebugLines()
		{
		}

		[PreserveSig]
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x755AE0", Offset = "0x755AE0", VA = "0x755AE0")]
		public static extern void ovrAvatar_SetDebugDrawContext(uint context);

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x755B60", Offset = "0x755B60", VA = "0x755B60")]
		public static bool SendEvent(string name, string param = "", string source = "")
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x755F9C", Offset = "0x755F9C", VA = "0x755F9C")]
		private static extern IntPtr _ovrp_GetVersion();

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x755F04", Offset = "0x755F04", VA = "0x755F04")]
		public static string ovrp_GetVersion()
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x756010", Offset = "0x756010", VA = "0x756010")]
		public CAPI()
		{
		}
	}
}
namespace CTI
{
	[Token(Token = "0x20001C9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x46CBD4", Offset = "0x46CBD4")]
	public class CTI_CustomWind : MonoBehaviour
	{
		[Token(Token = "0x400099A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private WindZone m_WindZone;

		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 WindDirection;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float WindStrength;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float WindTurbulence;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float WindMultiplier;

		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool init;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int TerrainLODWindPID;

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x7560E8", Offset = "0x7560E8", VA = "0x7560E8")]
		private void Init()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x75616C", Offset = "0x75616C", VA = "0x75616C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x756170", Offset = "0x756170", VA = "0x756170")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x75638C", Offset = "0x75638C", VA = "0x75638C")]
		public CTI_CustomWind()
		{
		}
	}
	[Token(Token = "0x20001CA")]
	public static class CTI_Utils
	{
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x75639C", Offset = "0x75639C", VA = "0x75639C")]
		public static void SetTranslucentLightingFade(float TranslucentLightingRange, float FadeLengthFactor)
		{
		}
	}
}
