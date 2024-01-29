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

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x63EBE4", Offset = "0x63EBE4")]
public class FastList<T>
{
	[Token(Token = "0x2000003")]
	public delegate int CompareFunc(T left, T right);

	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EC1C", Offset = "0x63EC1C")]
	private sealed class <GetEnumerator>d__25 : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T <>2__current;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public FastList<T> <>4__this;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <i>5__2;

		[Token(Token = "0x17000003")]
		private T System.Collections.Generic.IEnumerator<T>.Current
		{
			[Token(Token = "0x6000022")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000024")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001F")]
		[DebuggerHidden]
		public <GetEnumerator>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000020")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000021")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public T[] array;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int size;

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Token(Token = "0x6000003")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000004")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public T Item
	{
		[Token(Token = "0x6000005")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6000006")]
		set
		{
		}
	}

	[Token(Token = "0x6000001")]
	public FastList()
	{
	}

	[Token(Token = "0x6000002")]
	public FastList(int size)
	{
	}

	[Token(Token = "0x6000007")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6000008")]
	public void AddUnique(T item)
	{
	}

	[Token(Token = "0x6000009")]
	public void AddRange(IEnumerable<T> items)
	{
	}

	[Token(Token = "0x600000A")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x600000B")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x600000C")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x600000D")]
	public bool RemoveFast(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	public void RemoveAtFast(int index)
	{
	}

	[Token(Token = "0x600000F")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[Token(Token = "0x6000011")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x6000012")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	public void Sort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x6000014")]
	public void InsertionSort(CompareFunc comparer)
	{
	}

	[Token(Token = "0x6000015")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6420E4", Offset = "0x6420E4")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	public T Find(Predicate<T> match)
	{
		return (T)null;
	}

	[Token(Token = "0x6000017")]
	private void Allocate()
	{
	}

	[Token(Token = "0x6000018")]
	private void Trim()
	{
	}

	[Token(Token = "0x6000019")]
	public void Clear()
	{
	}

	[Token(Token = "0x600001A")]
	public void Release()
	{
	}
}
[Token(Token = "0x2000005")]
public class InspectorNoteAttribute : PropertyAttribute
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string header;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string message;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD58288", Offset = "0xD58288", VA = "0xD58288")]
	public InspectorNoteAttribute(string header, string message = "")
	{
	}
}
[Token(Token = "0x2000006")]
public class InspectorCommentAttribute : PropertyAttribute
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string message;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xD5825C", Offset = "0xD5825C", VA = "0xD5825C")]
	public InspectorCommentAttribute(string message = "")
	{
	}
}
[Token(Token = "0x2000007")]
public class OvrAvatarTestDriver : OvrAvatarDriver
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 headPos;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion headRot;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB0AF1C", Offset = "0xB0AF1C", VA = "0xB0AF1C")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB0B080", Offset = "0xB0B080", VA = "0xB0B080")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB0B41C", Offset = "0xB0B41C", VA = "0xB0B41C")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xB0B5C0", Offset = "0xB0B5C0", VA = "0xB0B5C0", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xB0B5F0", Offset = "0xB0B5F0", VA = "0xB0B5F0")]
	public OvrAvatarTestDriver()
	{
	}
}
[Token(Token = "0x2000008")]
public class PoseEditHelper : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform poseRoot;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xB0ED7C", Offset = "0xB0ED7C", VA = "0xB0ED7C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xB0EE04", Offset = "0xB0EE04", VA = "0xB0EE04")]
	private void DrawJoints(Transform joint)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xB0EF78", Offset = "0xB0EF78", VA = "0xB0EF78")]
	public PoseEditHelper()
	{
	}
}
[Token(Token = "0x2000009")]
public class GazeTargetSpawner : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject GazeTargetPrefab;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int NumberOfDummyTargets;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int RadiusMultiplier;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool isVisible;

	[Token(Token = "0x17000005")]
	public bool IsVisible
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xC807EC", Offset = "0xC807EC", VA = "0xC807EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0xC807F4", Offset = "0xC807F4", VA = "0xC807F4")]
		set
		{
		}
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xC80930", Offset = "0xC80930", VA = "0xC80930")]
	private void Start()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xC80AF8", Offset = "0xC80AF8", VA = "0xC80AF8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xC80B00", Offset = "0xC80B00", VA = "0xC80B00")]
	public GazeTargetSpawner()
	{
	}
}
[Token(Token = "0x200000A")]
public class RemoteLoopbackManager : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	private class PacketLatencyPair
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] PacketData;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float FakeLatency;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xB03B60", Offset = "0xB03B60", VA = "0xB03B60")]
		public PacketLatencyPair()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200000C")]
	public class SimulatedLatencySettings
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F2EC", Offset = "0x63F2EC")]
		public float FakeLatencyMax;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F304", Offset = "0x63F304")]
		public float FakeLatencyMin;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F31C", Offset = "0x63F31C")]
		public float LatencyWeight;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63F334", Offset = "0x63F334")]
		public int MaxSamples;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal float AverageWindow;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal float LatencySum;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal LinkedList<float> LatencyValues;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xB03B68", Offset = "0xB03B68", VA = "0xB03B68")]
		public float NextValue()
		{
			return default(float);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xB03CA0", Offset = "0xB03CA0", VA = "0xB03CA0")]
		public SimulatedLatencySettings()
		{
		}
	}

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OvrAvatar LocalAvatar;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar LoopbackAvatar;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimulatedLatencySettings LatencySettings;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int PacketSequence;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LinkedList<PacketLatencyPair> packetQueue;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB10A6C", Offset = "0xB10A6C", VA = "0xB10A6C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB10BB0", Offset = "0xB10BB0", VA = "0xB10BB0")]
	private void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xB10F84", Offset = "0xB10F84", VA = "0xB10F84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xB10EDC", Offset = "0xB10EDC", VA = "0xB10EDC")]
	private void SendPacketData(byte[] data)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB112B4", Offset = "0xB112B4", VA = "0xB112B4")]
	private void ReceivePacketData(byte[] data)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB11590", Offset = "0xB11590", VA = "0xB11590")]
	public RemoteLoopbackManager()
	{
	}
}
[Token(Token = "0x200000D")]
public class P2PManager
{
	[Token(Token = "0x200000E")]
	private enum MessageType : byte
	{
		[Token(Token = "0x4000021")]
		Update = 1
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xB0C45C", Offset = "0xB0C45C", VA = "0xB0C45C")]
	public P2PManager()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xB0C53C", Offset = "0xB0C53C", VA = "0xB0C53C")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xB0C7B8", Offset = "0xB0C7B8", VA = "0xB0C7B8")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB0C910", Offset = "0xB0C910", VA = "0xB0C910")]
	private void PeerConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xB0CA74", Offset = "0xB0CA74", VA = "0xB0CA74")]
	private void ConnectionStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xB0CCA4", Offset = "0xB0CCA4", VA = "0xB0CCA4")]
	public void SendAvatarUpdate(ulong userID, Transform rootTransform, uint sequence, byte[] avatarPacket)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB0D090", Offset = "0xB0D090", VA = "0xB0D090")]
	public void GetRemotePackets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xB0D344", Offset = "0xB0D344", VA = "0xB0D344")]
	public void processAvatarPacket(RemotePlayer remote, ref byte[] packet, ref int offset)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xB0CE6C", Offset = "0xB0CE6C", VA = "0xB0CE6C")]
	private void PackByte(byte b, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xB0D278", Offset = "0xB0D278", VA = "0xB0D278")]
	private byte ReadByte(byte[] buf, ref int offset)
	{
		return default(byte);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xB0CF50", Offset = "0xB0CF50", VA = "0xB0CF50")]
	private void PackFloat(float f, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xB0D57C", Offset = "0xB0D57C", VA = "0xB0D57C")]
	private float ReadFloat(byte[] buf, ref int offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xB0CEB4", Offset = "0xB0CEB4", VA = "0xB0CEB4")]
	private void PackULong(ulong u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xB0D2BC", Offset = "0xB0D2BC", VA = "0xB0D2BC")]
	private ulong ReadULong(byte[] buf, ref int offset)
	{
		return default(ulong);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xB0CFF4", Offset = "0xB0CFF4", VA = "0xB0CFF4")]
	private void PackUInt32(uint u, byte[] buf, ref int offset)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB0D604", Offset = "0xB0D604", VA = "0xB0D604")]
	private uint ReadUInt32(byte[] buf, ref int offset)
	{
		return default(uint);
	}
}
[Token(Token = "0x200000F")]
public class PlayerController : SocialPlatformManager
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Camera spyCamera;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private GameObject cameraRig;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool showUI;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xB0E1DC", Offset = "0xB0E1DC", VA = "0xB0E1DC", Slot = "5")]
	public override void Awake()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xB0E5A4", Offset = "0xB0E5A4", VA = "0xB0E5A4", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB0E5C8", Offset = "0xB0E5C8", VA = "0xB0E5C8", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB0E978", Offset = "0xB0E978", VA = "0xB0E978")]
	private void checkInput()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xB0EB14", Offset = "0xB0EB14", VA = "0xB0EB14")]
	private void ToggleCamera()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xB0EB94", Offset = "0xB0EB94", VA = "0xB0EB94")]
	private void ToggleUI()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB0EBE8", Offset = "0xB0EBE8", VA = "0xB0EBE8")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x2000010")]
public class RemotePlayer
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong remoteUserID;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool stillInRoom;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public PeerConnectionState p2pConnectionState;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PeerConnectionState voipConnectionState;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar RemoteAvatar;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 receivedRootPosition;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 receivedRootPositionPrior;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion receivedRootRotation;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Quaternion receivedRootRotationPrior;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public VoipAudioSourceHiLevel voipSource;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB11634", Offset = "0xB11634", VA = "0xB11634")]
	public RemotePlayer()
	{
	}
}
[Token(Token = "0x2000011")]
public class RoomManager
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong roomID;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong invitedRoomID;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool amIServer;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool startupDone;

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xB1163C", Offset = "0xB1163C", VA = "0xB1163C")]
	public RoomManager()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xB11740", Offset = "0xB11740", VA = "0xB11740")]
	private void AcceptingInviteCallback(Message<string> msg)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xB11970", Offset = "0xB11970", VA = "0xB11970")]
	public bool CheckForInvite()
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xB11AA8", Offset = "0xB11AA8", VA = "0xB11AA8")]
	public void CreateRoom()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xB11B7C", Offset = "0xB11B7C", VA = "0xB11B7C")]
	private void CreateAndJoinPrivateRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xB1204C", Offset = "0xB1204C", VA = "0xB1204C")]
	private void OnLaunchInviteWorkflowComplete(Message msg)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xB119A0", Offset = "0xB119A0", VA = "0xB119A0")]
	public void JoinExistingRoom(ulong roomID)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xB120D0", Offset = "0xB120D0", VA = "0xB120D0")]
	private void JoinRoomCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xB12800", Offset = "0xB12800", VA = "0xB12800")]
	private void RoomUpdateCallback(Message<Room> msg)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xB12AF8", Offset = "0xB12AF8", VA = "0xB12AF8")]
	public void LeaveCurrentRoom()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xB123AC", Offset = "0xB123AC", VA = "0xB123AC")]
	private void ProcessRoomData(Message<Room> msg)
	{
	}
}
[Token(Token = "0x2000012")]
public class SocialPlatformManager : MonoBehaviour
{
	[Token(Token = "0x2000013")]
	public enum State
	{
		[Token(Token = "0x4000059")]
		INITIALIZING,
		[Token(Token = "0x400005A")]
		CHECKING_LAUNCH_STATE,
		[Token(Token = "0x400005B")]
		CREATING_A_ROOM,
		[Token(Token = "0x400005C")]
		WAITING_IN_A_ROOM,
		[Token(Token = "0x400005D")]
		JOINING_A_ROOM,
		[Token(Token = "0x400005E")]
		CONNECTED_IN_A_ROOM,
		[Token(Token = "0x400005F")]
		LEAVING_A_ROOM,
		[Token(Token = "0x4000060")]
		SHUTDOWN
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Vector3 START_ROTATION_ONE;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly Vector3 START_POSITION_ONE;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 START_ROTATION_TWO;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly Vector3 START_POSITION_TWO;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Vector3 START_ROTATION_THREE;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly Vector3 START_POSITION_THREE;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly Vector3 START_ROTATION_FOUR;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static readonly Vector3 START_POSITION_FOUR;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly Color BLACK;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly Color WHITE;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly Color CYAN;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static readonly Color BLUE;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static readonly Color GREEN;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float voiceCurrent;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private uint packetSequence;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OvrAvatar localAvatarPrefab;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatar remoteAvatarPrefab;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject helpPanel;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected MeshRenderer helpMesh;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Material riftMaterial;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Material gearMaterial;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected OvrAvatar localAvatar;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected GameObject localTrackingSpace;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected GameObject localPlayerHead;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected Dictionary<ulong, RemotePlayer> remoteUsers;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject roomSphere;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected MeshRenderer sphereMesh;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject roomFloor;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected MeshRenderer floorMesh;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected State currentState;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected static SocialPlatformManager s_instance;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected RoomManager roomManager;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected P2PManager p2pManager;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected VoipManager voipManager;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected ulong myID;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected string myOculusID;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static readonly float VOIP_SCALE;

	[Token(Token = "0x17000006")]
	public static State CurrentState
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xB153F4", Offset = "0xB153F4", VA = "0xB153F4")]
		get
		{
			return default(State);
		}
	}

	[Token(Token = "0x17000007")]
	public static ulong MyID
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0xB0C618", Offset = "0xB0C618", VA = "0xB0C618")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17000008")]
	public static string MyOculusID
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0xB15464", Offset = "0xB15464", VA = "0xB15464")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xB0E5EC", Offset = "0xB0E5EC", VA = "0xB0E5EC", Slot = "4")]
	public virtual void Update()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xB0E214", Offset = "0xB0E214", VA = "0xB0E214", Slot = "5")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xB14234", Offset = "0xB14234", VA = "0xB14234")]
	private void InitCallback(Message<PlatformInitialize> msg)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xB0E5C4", Offset = "0xB0E5C4", VA = "0xB0E5C4", Slot = "6")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xB143DC", Offset = "0xB143DC", VA = "0xB143DC")]
	private void IsEntitledCallback(Message msg)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xB144FC", Offset = "0xB144FC", VA = "0xB144FC")]
	private void GetLoggedInUserCallback(Message<User> msg)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xB14C10", Offset = "0xB14C10", VA = "0xB14C10")]
	private void GetLoggedInUserFriendsAndRoomsCallback(Message<UserAndRoomList> msg)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xB14FFC", Offset = "0xB14FFC", VA = "0xB14FFC")]
	public void OnLocalAvatarPacketRecorded(object sender, OvrAvatar.PacketEventArgs args)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xB15208", Offset = "0xB15208", VA = "0xB15208")]
	public void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xB15388", Offset = "0xB15388", VA = "0xB15388")]
	public void AddUser(ulong userID, ref RemotePlayer remoteUser)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xB14180", Offset = "0xB14180", VA = "0xB14180")]
	public void LogOutputLine(string line)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xB118B8", Offset = "0xB118B8", VA = "0xB118B8")]
	public static void TerminateWithError(Message msg)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xB11CA8", Offset = "0xB11CA8", VA = "0xB11CA8")]
	public static void TransitionToState(State newState)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xB1558C", Offset = "0xB1558C", VA = "0xB1558C")]
	private static void SetSphereColorForState()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xB11F68", Offset = "0xB11F68", VA = "0xB11F68")]
	public static void SetFloorColorForState(bool host)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xB12B6C", Offset = "0xB12B6C", VA = "0xB12B6C")]
	public static void MarkAllRemoteUsersAsNotInRoom()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xB12F48", Offset = "0xB12F48", VA = "0xB12F48")]
	public static void MarkRemoteUserInRoom(ulong userID)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xB1302C", Offset = "0xB1302C", VA = "0xB1302C")]
	public static void ForgetRemoteUsersNotInRoom()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xB0C6F8", Offset = "0xB0C6F8", VA = "0xB0C6F8")]
	public static void LogOutput(string line)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xB12CC8", Offset = "0xB12CC8", VA = "0xB12CC8")]
	public static bool IsUserInRoom(ulong userID)
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xB12D5C", Offset = "0xB12D5C", VA = "0xB12D5C")]
	public static void AddRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xB15708", Offset = "0xB15708", VA = "0xB15708")]
	public static void RemoveRemoteUser(ulong userID)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xB1591C", Offset = "0xB1591C", VA = "0xB1591C")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xB140FC", Offset = "0xB140FC", VA = "0xB140FC")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x642194", Offset = "0x642194")]
	public static void MicFilter(short[] pcmData, UIntPtr pcmDataLength, int frequency, int numChannels)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xB0C834", Offset = "0xB0C834", VA = "0xB0C834")]
	public static RemotePlayer GetRemoteUser(ulong userID)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xB0EC50", Offset = "0xB0EC50", VA = "0xB0EC50")]
	public SocialPlatformManager()
	{
	}
}
[Token(Token = "0x2000014")]
public class VoipManager
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0xAF8158", Offset = "0xAF8158", VA = "0xAF8158")]
	public VoipManager()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xAF8238", Offset = "0xAF8238", VA = "0xAF8238")]
	public void ConnectTo(ulong userID)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xAF831C", Offset = "0xAF831C", VA = "0xAF831C")]
	public void Disconnect(ulong userID)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xAF839C", Offset = "0xAF839C", VA = "0xAF839C")]
	private void VoipConnectRequestCallback(Message<NetworkingPeer> msg)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xAF850C", Offset = "0xAF850C", VA = "0xAF850C")]
	private void VoipStateChangedCallback(Message<NetworkingPeer> msg)
	{
	}
}
[Token(Token = "0x2000015")]
public class GazeTarget : MonoBehaviour
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarGazeTargetType Type;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ovrAvatarGazeTargets RuntimeTargetList;

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xC804C0", Offset = "0xC804C0", VA = "0xC804C0")]
	static GazeTarget()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xC80538", Offset = "0xC80538", VA = "0xC80538")]
	private void Start()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xC806A8", Offset = "0xC806A8", VA = "0xC806A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xC8070C", Offset = "0xC8070C", VA = "0xC8070C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xC80574", Offset = "0xC80574", VA = "0xC80574")]
	private void UpdateGazeTarget()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xC807CC", Offset = "0xC807CC", VA = "0xC807CC")]
	private ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xC807E4", Offset = "0xC807E4", VA = "0xC807E4")]
	public GazeTarget()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class AvatarLayer
{
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int layerIndex;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xC6F858", Offset = "0xC6F858", VA = "0xC6F858")]
	public AvatarLayer()
	{
	}
}
[Serializable]
[Token(Token = "0x2000017")]
public class PacketRecordSettings
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal bool RecordingFrames;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float UpdateRate;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal float AccumulatedTime;

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xB0D68C", Offset = "0xB0D68C", VA = "0xB0D68C")]
	public PacketRecordSettings()
	{
	}
}
[Token(Token = "0x2000018")]
public class OvrAvatar : MonoBehaviour
{
	[Token(Token = "0x2000019")]
	public class PacketEventArgs : EventArgs
	{
		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly OvrAvatarPacket Packet;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xB01CB8", Offset = "0xB01CB8", VA = "0xB01CB8")]
		public PacketEventArgs(OvrAvatarPacket packet)
		{
		}
	}

	[Token(Token = "0x200001A")]
	public enum HandType
	{
		[Token(Token = "0x40000C2")]
		Right,
		[Token(Token = "0x40000C3")]
		Left,
		[Token(Token = "0x40000C4")]
		Max
	}

	[Token(Token = "0x200001B")]
	public enum HandJoint
	{
		[Token(Token = "0x40000C6")]
		HandBase,
		[Token(Token = "0x40000C7")]
		IndexBase,
		[Token(Token = "0x40000C8")]
		IndexTip,
		[Token(Token = "0x40000C9")]
		ThumbBase,
		[Token(Token = "0x40000CA")]
		ThumbTip,
		[Token(Token = "0x40000CB")]
		Max
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EC2C", Offset = "0x63EC2C")]
	private sealed class <WaitForMouthAudioSource>d__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatar <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xB01C68", Offset = "0xB01C68", VA = "0xB01C68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xB01CB0", Offset = "0xB01CB0", VA = "0xB01CB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xB01A98", Offset = "0xB01A98", VA = "0xB01A98")]
		[DebuggerHidden]
		public <WaitForMouthAudioSource>d__137(int <>1__state)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xB01AC4", Offset = "0xB01AC4", VA = "0xB01AC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xB01AC8", Offset = "0xB01AC8", VA = "0xB01AC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xB01C70", Offset = "0xB01C70", VA = "0xB01C70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x63F34C", Offset = "0x63F34C")]
	public IntPtr sdkAvatar;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string oculusUserID;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OvrAvatarDriver Driver;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x63F384", Offset = "0x63F384")]
	public bool EnableBody;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool EnableHands;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool EnableBase;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	public bool EnableExpressive;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x63F3BC", Offset = "0x63F3BC")]
	public bool RecordPackets;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	public bool UseSDKPackets;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PacketRecordSettings PacketSettings;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x63F3F4", Offset = "0x63F3F4")]
	public bool StartWithControllers;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AvatarLayer FirstPersonLayer;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AvatarLayer ThirdPersonLayer;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ShowFirstPerson;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool ShowThirdPerson;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	internal ovrAvatarCapabilities Capabilities;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F42C", Offset = "0x63F42C")]
	[SerializeField]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x63F42C", Offset = "0x63F42C")]
	internal ovrAvatarAssetLevelOfDetail LevelOfDetail;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F49C", Offset = "0x63F49C")]
	private bool CombineMeshes;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F4D4", Offset = "0x63F4D4")]
	public bool UseTransparentRenderQueue;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x63F50C", Offset = "0x63F50C")]
	public Shader Monochrome_SurfaceShader;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Shader Monochrome_SurfaceShader_SelfOccluding;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Shader Monochrome_SurfaceShader_PBS;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Shader Skinshaded_SurfaceShader_SingleComponent;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Shader Skinshaded_VertFrag_SingleComponent;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Shader Skinshaded_VertFrag_CombinedMesh;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Shader Skinshaded_Expressive_SurfaceShader_SingleComponent;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Shader Skinshaded_Expressive_VertFrag_SingleComponent;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader Skinshaded_Expressive_VertFrag_CombinedMesh;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Shader Loader_VertFrag_CombinedMesh;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader EyeLens;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader ControllerShader;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x63F544", Offset = "0x63F544")]
	public bool CanOwnMicrophone;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F57C", Offset = "0x63F57C")]
	public bool EnableLaughter;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public GameObject MouthAnchor;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform LeftHandCustomPose;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform RightHandCustomPose;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private HashSet<ulong> assetLoadingIds;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool assetsFinishedLoading;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private OvrAvatarMaterialManager materialManager;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool waitingForCombinedMesh;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool doneExpressiveGlobalInit;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Vector4 clothingAlphaOffset;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ulong clothingAlphaTexture;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private OVRLipSyncMicInput micInput;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private OVRLipSyncContext lipsyncContext;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private OVRLipSync.Frame currentFrame;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float[] visemes;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private AudioSource audioSource;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private ONSPAudioSource spatializedSource;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private List<float[]> voiceUpdates;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ovrAvatarVisemes RuntimeVisemes;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Transform cachedLeftHandCustomPose;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Transform[] cachedCustomLeftHandJoints;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private ovrAvatarTransform[] cachedLeftHandTransforms;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cachedRightHandCustomPose;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Transform[] cachedCustomRightHandJoints;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private ovrAvatarTransform[] cachedRightHandTransforms;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private bool showLeftController;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	private bool showRightController;

	[Token(Token = "0x40000A2")]
	private const bool USE_MOBILE_TEXTURE_FORMAT = true;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly Vector3 MOUTH_HEAD_OFFSET;

	[Token(Token = "0x40000A4")]
	private const string MOUTH_HELPER_NAME = "MouthAnchor";

	[Token(Token = "0x40000A5")]
	private const int VISEME_COUNT = 16;

	[Token(Token = "0x40000A6")]
	private const float ACTION_UNIT_ONSET_SPEED = 30f;

	[Token(Token = "0x40000A7")]
	private const float ACTION_UNIT_FALLOFF_SPEED = 20f;

	[Token(Token = "0x40000A8")]
	private const float VISEME_LEVEL_MULTIPLIER = 1.5f;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	internal ulong oculusUserIDInternal;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	internal OvrAvatarBase Base;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	internal OvrAvatarTouchController ControllerLeft;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	internal OvrAvatarTouchController ControllerRight;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	internal OvrAvatarBody Body;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	internal OvrAvatarHand HandLeft;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal OvrAvatarHand HandRight;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal ovrAvatarLookAndFeelVersion LookAndFeelVersion;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
	internal ovrAvatarLookAndFeelVersion FallbackLookAndFeelVersion;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private OvrAvatarPacket CurrentUnityPacket;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public EventHandler<PacketEventArgs> PacketRecorded;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string[,] HandJoints;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Vector3 MOUTH_POSITION_OFFSET;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static string VOICE_PROPERTY;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string MOUTH_POSITION_PROPERTY;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string MOUTH_DIRECTION_PROPERTY;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static string MOUTH_SCALE_PROPERTY;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static float MOUTH_SCALE_GLOBAL;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static float MOUTH_MAX_GLOBAL;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static string NECK_JONT;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public float VoiceAmplitude;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	public bool EnableMouthVertexAnimation;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static ovrAvatarLights ovrLights;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xFEA88C", Offset = "0xFEA88C", VA = "0xFEA88C")]
	static OvrAvatar()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xFEAC78", Offset = "0xFEAC78", VA = "0xFEAC78")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xFEAD0C", Offset = "0xFEAD0C", VA = "0xFEAD0C")]
	public void AssetLoadedCallback(OvrAvatarAsset asset)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xFEAD74", Offset = "0xFEAD74", VA = "0xFEAD74")]
	public void CombinedMeshLoadedCallback(IntPtr assetPtr)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xFEAEA4", Offset = "0xFEAEA4", VA = "0xFEAEA4")]
	private OvrAvatarSkinnedMeshRenderComponent AddSkinnedMeshRenderComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xFEAF84", Offset = "0xFEAF84", VA = "0xFEAF84")]
	private OvrAvatarSkinnedMeshRenderPBSComponent AddSkinnedMeshRenderPBSComponent(GameObject gameObject, ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xFEB060", Offset = "0xFEB060", VA = "0xFEB060")]
	private OvrAvatarSkinnedMeshPBSV2RenderComponent AddSkinnedMeshRenderPBSV2Component(IntPtr renderPart, GameObject go, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRenderPBSV2, bool isBodyPartZero, bool isControllerModel)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xFEB244", Offset = "0xFEB244", VA = "0xFEB244")]
	public static IntPtr GetRenderPart(ovrAvatarComponent component, uint renderPartIndex)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xFEB320", Offset = "0xFEB320", VA = "0xFEB320")]
	private static string GetRenderPartName(ovrAvatarComponent component, uint renderPartIndex)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xFEB398", Offset = "0xFEB398", VA = "0xFEB398")]
	internal static void ConvertTransform(float[] transform, ref ovrAvatarTransform target)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xFEB480", Offset = "0xFEB480", VA = "0xFEB480")]
	internal static void ConvertTransform(ovrAvatarTransform transform, Transform target)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xFEB50C", Offset = "0xFEB50C", VA = "0xFEB50C")]
	public static ovrAvatarTransform CreateOvrAvatarTransform(Vector3 position, Quaternion orientation)
	{
		return default(ovrAvatarTransform);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xFEB594", Offset = "0xFEB594", VA = "0xFEB594")]
	private static ovrAvatarGazeTarget CreateOvrGazeTarget(uint targetId, Vector3 targetPosition, ovrAvatarGazeTargetType targetType)
	{
		return default(ovrAvatarGazeTarget);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xFEB5AC", Offset = "0xFEB5AC", VA = "0xFEB5AC")]
	private void BuildRenderComponents()
	{
	}

	[Token(Token = "0x600009A")]
	private void AddAvatarComponent<T>(ref T root, ovrAvatarComponent nativeComponent) where T : OvrAvatarComponent
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xFEBA5C", Offset = "0xFEBA5C", VA = "0xFEBA5C")]
	private void UpdateCustomPoses()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xFEBDDC", Offset = "0xFEBDDC", VA = "0xFEBDDC")]
	private static bool UpdatePoseRoot(Transform poseRoot, ref Transform cachedPoseRoot, ref Transform[] cachedPoseJoints, ref ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xFEBF84", Offset = "0xFEBF84", VA = "0xFEBF84")]
	private static bool UpdateTransforms(Transform[] joints, ovrAvatarTransform[] transforms)
	{
		return default(bool);
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xFEC1D0", Offset = "0xFEC1D0", VA = "0xFEC1D0")]
	private static void OrderJoints(Transform transform, List<Transform> joints)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xFEC2C4", Offset = "0xFEC2C4", VA = "0xFEC2C4")]
	private void AvatarSpecificationCallback(IntPtr avatarSpecification)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xFEC930", Offset = "0xFEC930", VA = "0xFEC930")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xFECC5C", Offset = "0xFECC5C", VA = "0xFECC5C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xFED6AC", Offset = "0xFED6AC", VA = "0xFED6AC")]
	public static ovrAvatarHandInputState CreateInputState(ovrAvatarTransform transform, OvrAvatarDriver.ControllerPose pose)
	{
		return default(ovrAvatarHandInputState);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xFED700", Offset = "0xFED700", VA = "0xFED700")]
	public void ShowControllers(bool show)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xFEC580", Offset = "0xFEC580", VA = "0xFEC580")]
	public void ShowLeftController(bool show)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xFEC624", Offset = "0xFEC624", VA = "0xFEC624")]
	public void ShowRightController(bool show)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xFED730", Offset = "0xFED730", VA = "0xFED730")]
	public void UpdateVoiceVisualization(float[] voiceSamples)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xFED034", Offset = "0xFED034", VA = "0xFED034")]
	private void RecordFrame()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xFED9A4", Offset = "0xFED9A4", VA = "0xFED9A4")]
	private void RecordUnityFrame()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xFED794", Offset = "0xFED794", VA = "0xFED794")]
	private void RecordSDKFrame()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xFEDC54", Offset = "0xFEDC54", VA = "0xFEDC54")]
	private void AddRenderParts(OvrAvatarComponent ovrComponent, ovrAvatarComponent component, Transform parent)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xFEE0D0", Offset = "0xFEE0D0", VA = "0xFEE0D0")]
	public void RefreshBodyParts()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xFEE4D4", Offset = "0xFEE4D4", VA = "0xFEE4D4")]
	public ovrAvatarBodyComponent? GetBodyComponent()
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xFEE628", Offset = "0xFEE628", VA = "0xFEE628")]
	public Transform GetHandTransform(HandType hand, HandJoint joint)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xFEE80C", Offset = "0xFEE80C", VA = "0xFEE80C")]
	public void GetPointingDirection(HandType hand, ref Vector3 forward, ref Vector3 up)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xFED22C", Offset = "0xFED22C", VA = "0xFED22C")]
	private void UpdateVoiceBehavior()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xFEE8E0", Offset = "0xFEE8E0", VA = "0xFEE8E0")]
	private bool IsValidMic()
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xFED044", Offset = "0xFED044", VA = "0xFED044")]
	private void InitPostLoad()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xFEE9D0", Offset = "0xFEE9D0", VA = "0xFEE9D0")]
	private static void ExpressiveGlobalInit()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xFEF028", Offset = "0xFEF028", VA = "0xFEF028")]
	private static void InitializeLights()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xFEF50C", Offset = "0xFEF50C", VA = "0xFEF50C")]
	private static ovrAvatarLight CreateLightDirectional(uint id, Vector3 direction, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xFEF534", Offset = "0xFEF534", VA = "0xFEF534")]
	private static ovrAvatarLight CreateLightPoint(uint id, Vector3 position, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xFEF55C", Offset = "0xFEF55C", VA = "0xFEF55C")]
	private static ovrAvatarLight CreateLightSpot(uint id, Vector3 position, Vector3 direction, float spotAngleDeg, float range, float intensity, ref ovrAvatarLight light)
	{
		return default(ovrAvatarLight);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xFED538", Offset = "0xFED538", VA = "0xFED538")]
	private void UpdateExpressive()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xFEEA94", Offset = "0xFEEA94", VA = "0xFEEA94")]
	private void ConfigureHelpers()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xFEF97C", Offset = "0xFEF97C", VA = "0xFEF97C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6421F4", Offset = "0x6421F4")]
	private IEnumerator WaitForMouthAudioSource()
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xFEF9E8", Offset = "0xFEF9E8", VA = "0xFEF9E8")]
	public void DestroyHelperObjects()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xFEF83C", Offset = "0xFEF83C", VA = "0xFEF83C")]
	public GameObject CreateHelperObject(Transform parent, Vector3 localPositionOffset, string helperName, string helperTag = "")
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xFEFAAC", Offset = "0xFEFAAC", VA = "0xFEFAAC")]
	public void UpdateVoiceData(short[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xFEFB90", Offset = "0xFEFB90", VA = "0xFEFB90")]
	public void UpdateVoiceData(float[] pcmData, int numChannels)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xFEF598", Offset = "0xFEF598", VA = "0xFEF598")]
	private void UpdateFacewave()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xFEFC74", Offset = "0xFEFC74", VA = "0xFEFC74")]
	public OvrAvatar()
	{
	}
}
[Token(Token = "0x200001D")]
public class OvrAvatarAsset
{
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong assetID;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xFEFE34", Offset = "0xFEFE34", VA = "0xFEFE34")]
	public OvrAvatarAsset()
	{
	}
}
[Token(Token = "0x200001E")]
public class OvrAvatarAssetMesh : OvrAvatarAsset
{
	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mesh mesh;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAvatarSkinnedMeshPose skinnedBindPose;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string[] jointNames;

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xFEFEF8", Offset = "0xFEFEF8", VA = "0xFEFEF8")]
	public OvrAvatarAssetMesh(ulong _assetId, IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xFF117C", Offset = "0xFF117C", VA = "0xFF117C")]
	private void LoadSubmeshes(IntPtr asset, IntPtr indexBufferPtr, ulong indexCount)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xFF0D50", Offset = "0xFF0D50", VA = "0xFF0D50")]
	private void LoadBlendShapes(IntPtr asset, long vertexCount)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xFF0AE0", Offset = "0xFF0AE0", VA = "0xFF0AE0")]
	private void SetSkinnedBindPose(IntPtr asset, ovrAvatarAssetType meshType)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xFF0BBC", Offset = "0xFF0BBC", VA = "0xFF0BBC")]
	private void GetVertexAndIndexData(IntPtr asset, ovrAvatarAssetType meshType, out long vertexCount, out IntPtr vertexBuffer, out uint indexCount, out IntPtr indexBuffer)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xFF140C", Offset = "0xFF140C", VA = "0xFF140C")]
	public SkinnedMeshRenderer CreateSkinnedMeshRendererOnObject(GameObject target)
	{
		return null;
	}
}
[Token(Token = "0x200001F")]
public class OvrAvatarAssetTexture : OvrAvatarAsset
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D texture;

	[Token(Token = "0x40000D4")]
	private const int ASTCHeaderSize = 16;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xFF1994", Offset = "0xFF1994", VA = "0xFF1994")]
	public OvrAvatarAssetTexture(ulong _assetId, IntPtr asset)
	{
	}
}
[Token(Token = "0x2000020")]
public class OvrAvatarBase : OvrAvatarComponent
{
	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ovrAvatarBaseComponent component;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xFF1C00", Offset = "0xFF1C00", VA = "0xFF1C00")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xFF2054", Offset = "0xFF2054", VA = "0xFF2054")]
	public OvrAvatarBase()
	{
	}
}
[Token(Token = "0x2000021")]
public class OvrAvatarBody : OvrAvatarComponent
{
	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ovrAvatarBodyComponent component;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xFEE364", Offset = "0xFEE364", VA = "0xFEE364")]
	public ovrAvatarComponent? GetNativeAvatarComponent()
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xFF216C", Offset = "0xFF216C", VA = "0xFF216C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xFF2290", Offset = "0xFF2290", VA = "0xFF2290")]
	public OvrAvatarBody()
	{
	}
}
[Token(Token = "0x2000022")]
public class OvrAvatarComponent : MonoBehaviour
{
	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string[] LayerKeywords;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] LayerSampleModeParameters;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] LayerBlendModeParameters;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string[] LayerMaskTypeParameters;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string[] LayerColorParameters;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string[] LayerSurfaceParameters;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string[] LayerSampleParametersParameters;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string[] LayerMaskParametersParameters;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string[] LayerMaskAxisParameters;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Dictionary<Material, ovrAvatarMaterialState> materialStates;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<OvrAvatarRenderComponent> RenderParts;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected OvrAvatar owner;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ovrAvatarComponent nativeAvatarComponent;

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xFF22F0", Offset = "0xFF22F0", VA = "0xFF22F0")]
	public void SetOvrAvatarOwner(OvrAvatar ovrAvatarOwner)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xFF1D24", Offset = "0xFF1D24", VA = "0xFF1D24")]
	public void UpdateAvatar(IntPtr nativeComponent)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xFF22F8", Offset = "0xFF22F8", VA = "0xFF22F8")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xFF2358", Offset = "0xFF2358", VA = "0xFF2358")]
	public void UpdateAvatarMaterial(Material mat, ovrAvatarMaterialState matState)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xFF2B0C", Offset = "0xFF2B0C", VA = "0xFF2B0C")]
	public static Texture2D GetLoadedTexture(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xFF20B4", Offset = "0xFF20B4", VA = "0xFF20B4")]
	public OvrAvatarComponent()
	{
	}
}
[Token(Token = "0x2000023")]
public abstract class OvrAvatarDriver : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	public enum PacketMode
	{
		[Token(Token = "0x40000E8")]
		SDK,
		[Token(Token = "0x40000E9")]
		Unity
	}

	[Token(Token = "0x2000025")]
	public struct ControllerPose
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarButton buttons;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ovrAvatarTouch touches;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 joystickPosition;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float indexTrigger;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float handTrigger;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isActive;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xB01D30", Offset = "0xB01D30", VA = "0xB01D30")]
		public static ControllerPose Interpolate(ControllerPose a, ControllerPose b, float t)
		{
			return default(ControllerPose);
		}
	}

	[Token(Token = "0x2000026")]
	public struct PoseFrame
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 headPosition;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Quaternion headRotation;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 handLeftPosition;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Quaternion handLeftRotation;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 handRightPosition;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Quaternion handRightRotation;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float voiceAmplitude;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ControllerPose controllerLeftPose;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ControllerPose controllerRightPose;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xB01E0C", Offset = "0xB01E0C", VA = "0xB01E0C")]
		public static PoseFrame Interpolate(PoseFrame a, PoseFrame b, float t)
		{
			return default(PoseFrame);
		}
	}

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PacketMode Mode;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected PoseFrame CurrentPose;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private ovrAvatarControllerType ControllerType;

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xFF3F70", Offset = "0xFF3F70", VA = "0xFF3F70")]
	public PoseFrame GetCurrentPose()
	{
		return default(PoseFrame);
	}

	[Token(Token = "0x60000DC")]
	public abstract void UpdateTransforms(IntPtr sdkAvatar);

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xFF3F80", Offset = "0xFF3F80", VA = "0xFF3F80")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xFEC6C8", Offset = "0xFEC6C8", VA = "0xFEC6C8")]
	public void UpdateTransformsFromPose(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xFF4008", Offset = "0xFF4008", VA = "0xFF4008")]
	public static bool GetIsTrackedRemote()
	{
		return default(bool);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xFF4010", Offset = "0xFF4010", VA = "0xFF4010")]
	protected OvrAvatarDriver()
	{
	}
}
[Token(Token = "0x2000027")]
public class OvrAvatarHand : OvrAvatarComponent
{
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarHandComponent component;

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xFF4020", Offset = "0xFF4020", VA = "0xFF4020")]
	private void Update()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xFF4184", Offset = "0xFF4184", VA = "0xFF4184")]
	public OvrAvatarHand()
	{
	}
}
[Token(Token = "0x2000028")]
public class OvrAvatarLocalDriver : OvrAvatarDriver
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 centerEyePosition;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Quaternion centerEyeRotation;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float voiceAmplitude;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xFF41EC", Offset = "0xFF41EC", VA = "0xFF41EC")]
	private ControllerPose GetMalibuControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xFF4350", Offset = "0xFF4350", VA = "0xFF4350")]
	private ControllerPose GetControllerPose(OVRInput.Controller controller)
	{
		return default(ControllerPose);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xFF46EC", Offset = "0xFF46EC", VA = "0xFF46EC")]
	private void CalculateCurrentPose()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xFF4910", Offset = "0xFF4910", VA = "0xFF4910", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xFF493C", Offset = "0xFF493C", VA = "0xFF493C")]
	public OvrAvatarLocalDriver()
	{
	}
}
[Token(Token = "0x2000029")]
public class OvrAvatarMaterialManager : MonoBehaviour
{
	[Token(Token = "0x200002A")]
	public enum TextureType
	{
		[Token(Token = "0x400011F")]
		DiffuseTextures,
		[Token(Token = "0x4000120")]
		NormalMaps,
		[Token(Token = "0x4000121")]
		RoughnessMaps,
		[Token(Token = "0x4000122")]
		Count
	}

	[Token(Token = "0x200002B")]
	public struct AvatarComponentMaterialProperties
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ovrAvatarBodyPartType TypeIndex;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Color Color;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D[] Textures;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DiffuseIntensity;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RimIntensity;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ReflectionIntensity;
	}

	[Token(Token = "0x200002C")]
	public struct AvatarTextureArrayProperties
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture2D[] Textures;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2DArray TextureArray;
	}

	[Token(Token = "0x200002D")]
	public struct AvatarMaterialPropertyBlock
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector4[] Colors;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] DiffuseIntensities;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] RimIntensities;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] ReflectionIntensities;
	}

	[Serializable]
	[Token(Token = "0x200002E")]
	public class AvatarMaterialConfig
	{
		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AvatarComponentMaterialProperties[] ComponentMaterialProperties;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AvatarMaterialPropertyBlock MaterialPropertyBlock;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xB02808", Offset = "0xB02808", VA = "0xB02808")]
		public AvatarMaterialConfig()
		{
		}
	}

	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EC3C", Offset = "0x63EC3C")]
	private sealed class <RunLoadingAnimation>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public OvrAvatarMaterialManager <>4__this;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callBack;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <srcBlend>5__2;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <dstBlend>5__3;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string <lightModeTag>5__4;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <renderTypeTag>5__5;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string <renderQueueTag>5__6;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string <ignoreProjectorTag>5__7;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int <renderQueue>5__8;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool <transparentQueue>5__9;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xB027B8", Offset = "0xB027B8", VA = "0xB027B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xB02800", Offset = "0xB02800", VA = "0xB02800", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xB02110", Offset = "0xB02110", VA = "0xB02110")]
		[DebuggerHidden]
		public <RunLoadingAnimation>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xB0213C", Offset = "0xB0213C", VA = "0xB0213C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xB02140", Offset = "0xB02140", VA = "0xB02140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xB027C0", Offset = "0xB027C0", VA = "0xB027C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer TargetRenderer;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AvatarTextureArrayProperties[] TextureArrays;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string[] TextureTypeToShaderProperties;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AvatarMaterialConfig LocalAvatarConfig;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<ReflectionProbeBlendInfo> ReflectionProbes;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader CombinedShader;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string AVATAR_SHADER_LOADER;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string AVATAR_SHADER_MAINTEX;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string AVATAR_SHADER_NORMALMAP;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string AVATAR_SHADER_ROUGHNESSMAP;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string AVATAR_SHADER_COLOR;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string AVATAR_SHADER_DIFFUSEINTENSITY;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string AVATAR_SHADER_RIMINTENSITY;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string AVATAR_SHADER_REFLECTIONINTENSITY;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string AVATAR_SHADER_CUBEMAP;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string AVATAR_SHADER_ALPHA;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string AVATAR_SHADER_LOADING_DIMMER;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string AVATAR_SHADER_IRIS_COLOR;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string AVATAR_SHADER_LIP_COLOR;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string AVATAR_SHADER_BROW_COLOR;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string AVATAR_SHADER_LASH_COLOR;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string AVATAR_SHADER_SCLERA_COLOR;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string AVATAR_SHADER_GUM_COLOR;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string AVATAR_SHADER_TEETH_COLOR;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string AVATAR_SHADER_LIP_SMOOTHNESS;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static float[] DiffuseIntensities;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static float[] RimIntensities;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static float[] ReflectionIntensities;

	[Token(Token = "0x400011A")]
	private const float LOADING_ANIMATION_AMPLITUDE = 0.5f;

	[Token(Token = "0x400011B")]
	private const float LOADING_ANIMATION_PERIOD = 0.35f;

	[Token(Token = "0x400011C")]
	private const float LOADING_ANIMATION_CURVE_SCALE = 0.25f;

	[Token(Token = "0x400011D")]
	private const float LOADING_ANIMATION_DIMMER_MIN = 0.3f;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xFF4988", Offset = "0xFF4988", VA = "0xFF4988")]
	public void CreateTextureArrays()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xFF4B14", Offset = "0xFF4B14", VA = "0xFF4B14")]
	public void SetRenderer(Renderer renderer)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xFF4B3C", Offset = "0xFF4B3C", VA = "0xFF4B3C")]
	public void OnCombinedMeshReady()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xFF5298", Offset = "0xFF5298", VA = "0xFF5298")]
	public void AddTextureIDToTextureManager(ulong assetID, bool isSingleComponent)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xFF5304", Offset = "0xFF5304", VA = "0xFF5304")]
	private void DeleteTextureSet()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xFF4BD8", Offset = "0xFF4BD8", VA = "0xFF4BD8")]
	public void InitTextureArrays()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xFF5358", Offset = "0xFF5358", VA = "0xFF5358")]
	private void ProcessTexturesWithMips(Texture2D[] textures, int texArrayResolution, Texture2DArray texArray)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xFF5010", Offset = "0xFF5010", VA = "0xFF5010")]
	private void SetMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xFF5448", Offset = "0xFF5448", VA = "0xFF5448")]
	private void ApplyMaterialPropertyBlock()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xFF56EC", Offset = "0xFF56EC", VA = "0xFF56EC")]
	public static ovrAvatarBodyPartType GetComponentType(string objectName)
	{
		return default(ovrAvatarBodyPartType);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xFF5814", Offset = "0xFF5814", VA = "0xFF5814")]
	private ulong GetTextureIDForType(ovrAvatarPBSMaterialState materialState, TextureType type)
	{
		return default(ulong);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xFF584C", Offset = "0xFF584C", VA = "0xFF584C")]
	public void ValidateTextures(ovrAvatarPBSMaterialState[] materialStates)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xFF5220", Offset = "0xFF5220", VA = "0xFF5220")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6422A4", Offset = "0x6422A4")]
	private IEnumerator RunLoadingAnimation(Action callBack)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xFF66C4", Offset = "0xFF66C4", VA = "0xFF66C4")]
	public OvrAvatarMaterialManager()
	{
	}
}
[Token(Token = "0x2000030")]
public class OvrAvatarPacket
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr ovrNativePacket;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<float> frameTimes;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<OvrAvatarDriver.PoseFrame> frames;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte[]> encodedAudioPackets;

	[Token(Token = "0x1700000D")]
	public float Duration
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xB05B8C", Offset = "0xB05B8C", VA = "0xB05B8C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700000E")]
	public OvrAvatarDriver.PoseFrame FinalFrame
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xB05C00", Offset = "0xB05C00", VA = "0xB05C00")]
		get
		{
			return default(OvrAvatarDriver.PoseFrame);
		}
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xB05C90", Offset = "0xB05C90", VA = "0xB05C90")]
	public OvrAvatarPacket()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xB05D98", Offset = "0xB05D98", VA = "0xB05D98")]
	public OvrAvatarPacket(OvrAvatarDriver.PoseFrame initialPose)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xB05F34", Offset = "0xB05F34", VA = "0xB05F34")]
	private OvrAvatarPacket(List<float> frameTimes, List<OvrAvatarDriver.PoseFrame> frames, List<byte[]> audioPackets)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xB06054", Offset = "0xB06054", VA = "0xB06054")]
	public void AddFrame(OvrAvatarDriver.PoseFrame frame, float deltaSeconds)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xB0612C", Offset = "0xB0612C", VA = "0xB0612C")]
	public OvrAvatarDriver.PoseFrame GetPoseFrame(float seconds)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xB0635C", Offset = "0xB0635C", VA = "0xB0635C")]
	public static OvrAvatarPacket Read(Stream stream)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xB06638", Offset = "0xB06638", VA = "0xB06638")]
	public void Write(Stream stream)
	{
	}
}
[Token(Token = "0x2000031")]
internal static class BinaryWriterExtensions
{
	[Token(Token = "0x6000109")]
	[Address(RVA = "0xC6FF50", Offset = "0xC6FF50", VA = "0xC6FF50")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.PoseFrame frame)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xC70064", Offset = "0xC70064", VA = "0xC70064")]
	public static void Write(this BinaryWriter writer, Vector3 vec3)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xC70210", Offset = "0xC70210", VA = "0xC70210")]
	public static void Write(this BinaryWriter writer, Vector2 vec2)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xC700D4", Offset = "0xC700D4", VA = "0xC700D4")]
	public static void Write(this BinaryWriter writer, Quaternion quat)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xC70168", Offset = "0xC70168", VA = "0xC70168")]
	public static void Write(this BinaryWriter writer, OvrAvatarDriver.ControllerPose pose)
	{
	}
}
[Token(Token = "0x2000032")]
internal static class BinaryReaderExtensions
{
	[Token(Token = "0x600010E")]
	[Address(RVA = "0xC6FB50", Offset = "0xC6FB50", VA = "0xC6FB50")]
	public static OvrAvatarDriver.PoseFrame ReadPoseFrame(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.PoseFrame);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xC6FEF4", Offset = "0xC6FEF4", VA = "0xC6FEF4")]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xC6FCF0", Offset = "0xC6FCF0", VA = "0xC6FCF0")]
	public static Vector3 ReadVector3(this BinaryReader reader)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xC6FD68", Offset = "0xC6FD68", VA = "0xC6FD68")]
	public static Quaternion ReadQuaternion(this BinaryReader reader)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xC6FE04", Offset = "0xC6FE04", VA = "0xC6FE04")]
	public static OvrAvatarDriver.ControllerPose ReadControllerPose(this BinaryReader reader)
	{
		return default(OvrAvatarDriver.ControllerPose);
	}
}
[Token(Token = "0x2000033")]
public class OvrAvatarRemoteDriver : OvrAvatarDriver
{
	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Queue<OvrAvatarPacket> packetQueue;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private IntPtr CurrentSDKPacket;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float CurrentPacketTime;

	[Token(Token = "0x4000144")]
	private const int MinPacketQueue = 1;

	[Token(Token = "0x4000145")]
	private const int MaxPacketQueue = 4;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int CurrentSequence;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private bool isStreaming;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private OvrAvatarPacket currentPacket;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xB06860", Offset = "0xB06860", VA = "0xB06860")]
	public void QueuePacket(int sequence, OvrAvatarPacket packet)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xB068E8", Offset = "0xB068E8", VA = "0xB068E8", Slot = "4")]
	public override void UpdateTransforms(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xB06904", Offset = "0xB06904", VA = "0xB06904")]
	private void UpdateFromSDKPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xB06AA8", Offset = "0xB06AA8", VA = "0xB06AA8")]
	private void UpdateFromUnityPacket(IntPtr sdkAvatar)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xB06C5C", Offset = "0xB06C5C", VA = "0xB06C5C")]
	public OvrAvatarRemoteDriver()
	{
	}
}
[Token(Token = "0x2000034")]
public class OvrAvatarRenderComponent : MonoBehaviour
{
	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool firstSkinnedUpdate;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SkinnedMeshRenderer mesh;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] bones;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isBodyComponent;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xB06CE8", Offset = "0xB06CE8", VA = "0xB06CE8")]
	protected void UpdateActive(OvrAvatar avatar, ovrAvatarVisibilityFlags mask)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xB06DCC", Offset = "0xB06DCC", VA = "0xB06DCC")]
	protected SkinnedMeshRenderer CreateSkinnedMesh(ulong assetID, ovrAvatarVisibilityFlags visibilityMask, int thirdPersonLayer, int firstPersonLayer)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xB07214", Offset = "0xB07214", VA = "0xB07214")]
	protected void UpdateSkinnedMesh(OvrAvatar avatar, Transform[] bones, ovrAvatarTransform localTransform, ovrAvatarVisibilityFlags visibilityMask, IntPtr renderPart)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xB075D4", Offset = "0xB075D4", VA = "0xB075D4")]
	protected Material CreateAvatarMaterial(string name, Shader shader)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xB076E0", Offset = "0xB076E0", VA = "0xB076E0")]
	public OvrAvatarRenderComponent()
	{
	}
}
[Token(Token = "0x2000035")]
[Flags]
public enum ovrAvatarCapabilities
{
	[Token(Token = "0x400014E")]
	Body = 1,
	[Token(Token = "0x400014F")]
	Hands = 2,
	[Token(Token = "0x4000150")]
	Base = 4,
	[Token(Token = "0x4000151")]
	BodyTilt = 0x10,
	[Token(Token = "0x4000152")]
	Expressive = 0x20,
	[Token(Token = "0x4000153")]
	All = -1
}
[Token(Token = "0x2000036")]
public enum ovrAvatarMessageType
{
	[Token(Token = "0x4000155")]
	AvatarSpecification,
	[Token(Token = "0x4000156")]
	AssetLoaded,
	[Token(Token = "0x4000157")]
	Count
}
[Token(Token = "0x2000037")]
public struct ovrAvatarMessage_AvatarSpecification
{
	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public IntPtr avatarSpec;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong oculusUserID;
}
[Token(Token = "0x2000038")]
public struct ovrAvatarMessage_AssetLoaded
{
	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong assetID;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr asset;
}
[Token(Token = "0x2000039")]
public enum ovrAvatarAssetType
{
	[Token(Token = "0x400015D")]
	Mesh,
	[Token(Token = "0x400015E")]
	Texture,
	[Token(Token = "0x400015F")]
	Pose,
	[Token(Token = "0x4000160")]
	Material,
	[Token(Token = "0x4000161")]
	CombinedMesh,
	[Token(Token = "0x4000162")]
	PBSMaterial,
	[Token(Token = "0x4000163")]
	FailedLoad,
	[Token(Token = "0x4000164")]
	Count
}
[Token(Token = "0x200003A")]
public struct ovrAvatarMeshVertex
{
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float tw;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float u;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float v;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public byte[] blendIndices;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float[] blendWeights;
}
[Token(Token = "0x200003B")]
public struct ovrAvatarMeshVertexV2
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
	public float r;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float g;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float b;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float a;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public byte[] blendIndices;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float[] blendWeights;
}
[Token(Token = "0x200003C")]
public struct ovrAvatarBlendVertex
{
	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float x;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float y;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float z;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float nx;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float ny;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float nz;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float tx;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ty;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float tz;
}
[Token(Token = "0x200003D")]
public struct ovrAvatarMeshAssetData
{
	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200003E")]
public struct ovrAvatarMeshAssetDataV2
{
	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint vertexCount;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public uint indexCount;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr indexBuffer;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ovrAvatarSkinnedMeshPose skinnedBindPose;
}
[Token(Token = "0x200003F")]
public enum ovrAvatarTextureFormat
{
	[Token(Token = "0x4000199")]
	RGB24,
	[Token(Token = "0x400019A")]
	DXT1,
	[Token(Token = "0x400019B")]
	DXT5,
	[Token(Token = "0x400019C")]
	ASTC_RGB_6x6,
	[Token(Token = "0x400019D")]
	ASTC_RGB_6x6_MIPMAPS,
	[Token(Token = "0x400019E")]
	Count
}
[Token(Token = "0x2000040")]
public struct ovrAvatarTextureAssetData
{
	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTextureFormat format;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint sizeX;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public uint sizeY;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public uint mipCount;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong textureDataSize;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr textureData;
}
[Token(Token = "0x2000041")]
public enum ovrAvatarRenderPartType
{
	[Token(Token = "0x40001A6")]
	SkinnedMeshRender,
	[Token(Token = "0x40001A7")]
	SkinnedMeshRenderPBS,
	[Token(Token = "0x40001A8")]
	ProjectorRender,
	[Token(Token = "0x40001A9")]
	SkinnedMeshRenderPBS_V2,
	[Token(Token = "0x40001AA")]
	Count
}
[Token(Token = "0x2000042")]
public enum ovrAvatarLogLevel
{
	[Token(Token = "0x40001AC")]
	Unknown,
	[Token(Token = "0x40001AD")]
	Default,
	[Token(Token = "0x40001AE")]
	Verbose,
	[Token(Token = "0x40001AF")]
	Debug,
	[Token(Token = "0x40001B0")]
	Info,
	[Token(Token = "0x40001B1")]
	Warn,
	[Token(Token = "0x40001B2")]
	Error,
	[Token(Token = "0x40001B3")]
	Fatal,
	[Token(Token = "0x40001B4")]
	Silent
}
[Token(Token = "0x2000043")]
public struct ovrAvatarTransform
{
	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Quaternion orientation;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 scale;
}
[Token(Token = "0x2000044")]
[Flags]
public enum ovrAvatarButton
{
	[Token(Token = "0x40001B9")]
	One = 1,
	[Token(Token = "0x40001BA")]
	Two = 2,
	[Token(Token = "0x40001BB")]
	Three = 4,
	[Token(Token = "0x40001BC")]
	Joystick = 8
}
[Token(Token = "0x2000045")]
[Flags]
public enum ovrAvatarTouch
{
	[Token(Token = "0x40001BE")]
	One = 1,
	[Token(Token = "0x40001BF")]
	Two = 2,
	[Token(Token = "0x40001C0")]
	Joystick = 4,
	[Token(Token = "0x40001C1")]
	ThumbRest = 8,
	[Token(Token = "0x40001C2")]
	Index = 0x10,
	[Token(Token = "0x40001C3")]
	Pointing = 0x40,
	[Token(Token = "0x40001C4")]
	ThumbUp = 0x80
}
[Token(Token = "0x2000046")]
public struct ovrAvatarHandInputState
{
	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarButton buttonMask;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public ovrAvatarTouch touchMask;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float joystickX;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float joystickY;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float indexTrigger;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float handTrigger;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isActive;
}
[Token(Token = "0x2000047")]
public struct ovrAvatarComponent
{
	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint renderPartCount;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr renderParts;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string name;
}
[Token(Token = "0x2000048")]
internal struct ovrAvatarComponent_Offsets
{
	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long transform;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int renderPartCount;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int renderParts;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int name;
}
[Token(Token = "0x2000049")]
public struct ovrAvatarBaseComponent
{
	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 basePosition;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200004A")]
public struct ovrAvatarBodyComponent
{
	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform leftEyeTransform;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarTransform rightEyeTransform;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ovrAvatarTransform centerEyeTransform;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200004B")]
public struct ovrAvatarBodyComponent_Offsets
{
	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long leftEyeTransform;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long rightEyeTransform;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long centerEyeTransform;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long renderComponent;
}
[Token(Token = "0x200004C")]
public struct ovrAvatarControllerComponent
{
	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200004D")]
public struct ovrAvatarHandComponent
{
	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarHandInputState inputState;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IntPtr renderComponent;
}
[Token(Token = "0x200004E")]
public enum ovrAvatarMaterialLayerBlendMode
{
	[Token(Token = "0x40001E4")]
	Add,
	[Token(Token = "0x40001E5")]
	Multiply,
	[Token(Token = "0x40001E6")]
	Count
}
[Token(Token = "0x200004F")]
public enum ovrAvatarMaterialLayerSampleMode
{
	[Token(Token = "0x40001E8")]
	Color,
	[Token(Token = "0x40001E9")]
	Texture,
	[Token(Token = "0x40001EA")]
	TextureSingleChannel,
	[Token(Token = "0x40001EB")]
	Parallax,
	[Token(Token = "0x40001EC")]
	Count
}
[Token(Token = "0x2000050")]
public enum ovrAvatarMaterialMaskType
{
	[Token(Token = "0x40001EE")]
	None,
	[Token(Token = "0x40001EF")]
	Positional,
	[Token(Token = "0x40001F0")]
	ViewReflection,
	[Token(Token = "0x40001F1")]
	Fresnel,
	[Token(Token = "0x40001F2")]
	Pulse,
	[Token(Token = "0x40001F3")]
	Count
}
[Token(Token = "0x2000051")]
public enum ovrAvatarControllerType
{
	[Token(Token = "0x40001F5")]
	Touch,
	[Token(Token = "0x40001F6")]
	Malibu,
	[Token(Token = "0x40001F7")]
	Go,
	[Token(Token = "0x40001F8")]
	Quest,
	[Token(Token = "0x40001F9")]
	Count
}
[Token(Token = "0x2000052")]
public enum ovrAvatarAssetLevelOfDetail
{
	[Token(Token = "0x40001FB")]
	Lowest = 1,
	[Token(Token = "0x40001FC")]
	Medium = 3,
	[Token(Token = "0x40001FD")]
	Highest = 5
}
[Token(Token = "0x2000053")]
public enum ovrAvatarLookAndFeelVersion
{
	[Token(Token = "0x40001FF")]
	Unknown = -1,
	[Token(Token = "0x4000200")]
	One,
	[Token(Token = "0x4000201")]
	Two
}
[Token(Token = "0x2000054")]
public struct ovrAvatarMaterialLayerState
{
	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarMaterialLayerBlendMode blendMode;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarMaterialMaskType maskType;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector4 layerColor;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector4 sampleParameters;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong sampleTexture;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector4 sampleScaleOffset;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector4 maskParameters;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 maskAxis;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xAFA4AC", Offset = "0xAFA4AC", VA = "0xAFA4AC")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xAFA4DC", Offset = "0xAFA4DC", VA = "0xAFA4DC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xAFA6F8", Offset = "0xAFA6F8", VA = "0xAFA6F8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000055")]
public struct ovrAvatarMaterialState
{
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarMaterialMaskType baseMaskType;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector4 baseMaskParameters;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector4 baseMaskAxis;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public ovrAvatarMaterialLayerSampleMode sampleMode;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong alphaMaskTextureID;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 alphaMaskScaleOffset;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong normalMapTextureID;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 normalMapScaleOffset;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong parallaxMapTextureID;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector4 parallaxMapScaleOffset;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public ulong roughnessMapTextureID;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector4 roughnessMapScaleOffset;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public uint layerCount;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public ovrAvatarMaterialLayerState[] layers;

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xAFA7DC", Offset = "0xAFA7DC", VA = "0xAFA7DC")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xAFA80C", Offset = "0xAFA80C", VA = "0xAFA80C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xAFABA8", Offset = "0xAFABA8", VA = "0xAFABA8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000056")]
public struct ovrAvatarExpressiveParameters
{
	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 irisColor;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector4 scleraColor;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector4 lashColor;

	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector4 browColor;

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector4 lipColor;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4 teethColor;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector4 gumColor;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float browLashIntensity;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float lipSmoothness;

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xAF9A3C", Offset = "0xAF9A3C", VA = "0xAF9A3C")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xAF9A6C", Offset = "0xAF9A6C", VA = "0xAF9A6C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xAF9CFC", Offset = "0xAF9CFC", VA = "0xAF9CFC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000057")]
public struct ovrAvatarPBSMaterialState
{
	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector4 baseColor;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong albedoTextureID;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector4 albedoMultiplier;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong metallicnessTextureID;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float glossinessScale;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong normalTextureID;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong heightTextureID;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ulong occlusionTextureID;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public ulong emissionTextureID;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector4 emissionMultiplier;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public ulong detailMaskTextureID;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ulong detailAlbedoTextureID;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public ulong detailNormalTextureID;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xAFAD10", Offset = "0xAFAD10", VA = "0xAFAD10")]
	private static bool VectorEquals(Vector4 a, Vector4 b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xAFAD40", Offset = "0xAFAD40", VA = "0xAFAD40", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xAFAF30", Offset = "0xAFAF30", VA = "0xAFAF30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Token(Token = "0x2000058")]
public class OvrAvatarAssetMaterial : OvrAvatarAsset
{
	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ovrAvatarMaterialState material;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xFEFE3C", Offset = "0xFEFE3C", VA = "0xFEFE3C")]
	public OvrAvatarAssetMaterial(ulong id, IntPtr mat)
	{
	}
}
[Token(Token = "0x2000059")]
public struct ovrAvatarSkinnedMeshPose
{
	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint jointCount;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarTransform[] jointTransform;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int[] jointParents;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr[] jointNames;
}
[Token(Token = "0x200005A")]
[Flags]
public enum ovrAvatarVisibilityFlags
{
	[Token(Token = "0x4000236")]
	FirstPerson = 1,
	[Token(Token = "0x4000237")]
	ThirdPerson = 2,
	[Token(Token = "0x4000238")]
	SelfOccluding = 4
}
[Token(Token = "0x200005B")]
public struct ovrAvatarRenderPart_SkinnedMeshRender
{
	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarMaterialState materialState;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200005C")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS
{
	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong albedoTextureAssetID;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong surfaceTextureAssetID;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200005D")]
public struct ovrAvatarRenderPart_ProjectorRender
{
	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public uint componentIndex;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public uint renderPartIndex;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ovrAvatarMaterialState materialState;
}
[Token(Token = "0x200005E")]
public struct ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2
{
	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform localTransform;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarVisibilityFlags visibilityMask;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ulong meshAssetID;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ovrAvatarPBSMaterialState materialState;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ovrAvatarSkinnedMeshPose skinnedPose;
}
[Token(Token = "0x200005F")]
public enum ovrAvatarHandGesture
{
	[Token(Token = "0x400024E")]
	Default,
	[Token(Token = "0x400024F")]
	GripSphere,
	[Token(Token = "0x4000250")]
	GripCube,
	[Token(Token = "0x4000251")]
	Count
}
[Token(Token = "0x2000060")]
public enum ovrAvatarBodyPartType
{
	[Token(Token = "0x4000253")]
	Body,
	[Token(Token = "0x4000254")]
	Clothing,
	[Token(Token = "0x4000255")]
	Eyewear,
	[Token(Token = "0x4000256")]
	Hair,
	[Token(Token = "0x4000257")]
	Beard,
	[Token(Token = "0x4000258")]
	Count
}
[Token(Token = "0x2000061")]
public struct ovrAvatarBlendShapeParams
{
	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint blendShapeParamCount;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] blendShapeParams;
}
[Token(Token = "0x2000062")]
internal struct ovrAvatarBlendShapeParams_Offsets
{
	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int blendShapeParamCount;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long blendShapeParams;
}
[Token(Token = "0x2000063")]
public struct ovrAvatarVisemes
{
	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint visemeParamCount;

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float[] visemeParams;
}
[Token(Token = "0x2000064")]
internal struct ovrAvatarVisemes_Offsets
{
	[Token(Token = "0x400025F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int visemeParamCount;

	[Token(Token = "0x4000260")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long visemeParams;
}
[Token(Token = "0x2000065")]
public enum ovrAvatarGazeTargetType
{
	[Token(Token = "0x4000262")]
	AvatarHead,
	[Token(Token = "0x4000263")]
	AvatarHand,
	[Token(Token = "0x4000264")]
	Object,
	[Token(Token = "0x4000265")]
	ObjectStatic,
	[Token(Token = "0x4000266")]
	Count
}
[Token(Token = "0x2000066")]
public struct ovrAvatarGazeTarget
{
	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public Vector3 worldPosition;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ovrAvatarGazeTargetType type;
}
[Token(Token = "0x2000067")]
internal struct ovrAvatarGazeTarget_Offsets
{
	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int id;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int worldPosition;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int type;
}
[Token(Token = "0x2000068")]
public struct ovrAvatarGazeTargets
{
	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint targetCount;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarGazeTarget[] targets;
}
[Token(Token = "0x2000069")]
internal struct ovrAvatarGazeTargets_Offsets
{
	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int targetCount;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long targets;
}
[Token(Token = "0x200006A")]
public enum ovrAvatarLightType
{
	[Token(Token = "0x4000272")]
	Point,
	[Token(Token = "0x4000273")]
	Direction,
	[Token(Token = "0x4000274")]
	Spot,
	[Token(Token = "0x4000275")]
	Count
}
[Token(Token = "0x200006B")]
public struct ovrAvatarLight
{
	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public ovrAvatarLightType type;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float intensity;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 worldDirection;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 worldPosition;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float spotAngleDeg;
}
[Token(Token = "0x200006C")]
internal struct ovrAvatarLight_Offsets
{
	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long id;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long type;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long intensity;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static long worldDirection;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static long worldPosition;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static long range;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static long spotAngleDeg;
}
[Token(Token = "0x200006D")]
public struct ovrAvatarLights
{
	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float ambientIntensity;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public uint lightCount;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ovrAvatarLight[] lights;
}
[Token(Token = "0x200006E")]
internal struct ovrAvatarLights_Offsets
{
	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static long ambientIntensity;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static long lightCount;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static long lights;
}
[Token(Token = "0x200006F")]
[Flags]
public enum ovrAvatarDebugContext : uint
{
	[Token(Token = "0x400028B")]
	None = 0u,
	[Token(Token = "0x400028C")]
	GazeTarget = 1u,
	[Token(Token = "0x400028D")]
	Any = uint.MaxValue
}
[Token(Token = "0x2000070")]
public struct ovrAvatarDebugLine
{
	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 startPoint;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 endPoint;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 color;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public IntPtr text;
}
[Token(Token = "0x2000071")]
public struct ovrAvatarDebugTransform
{
	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ovrAvatarTransform transform;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ovrAvatarDebugContext context;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public IntPtr text;
}
[Token(Token = "0x2000072")]
public delegate void specificationCallback(IntPtr specification);
[Token(Token = "0x2000073")]
public delegate void assetLoadedCallback(OvrAvatarAsset asset);
[Token(Token = "0x2000074")]
public delegate void combinedMeshLoadedCallback(IntPtr asset);
[Token(Token = "0x2000075")]
public class OvrAvatarSDKManager : MonoBehaviour
{
	[Token(Token = "0x2000076")]
	public struct AvatarSpecRequestParams
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong _userId;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public specificationCallback _callback;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool _useCombinedMesh;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ovrAvatarAssetLevelOfDetail _lod;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool _forceMobileTextureFormat;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ovrAvatarLookAndFeelVersion _lookVersion;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ovrAvatarLookAndFeelVersion _fallbackVersion;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _enableExpressive;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xB02810", Offset = "0xB02810", VA = "0xB02810")]
		public AvatarSpecRequestParams(ulong userId, specificationCallback callback, bool useCombinedMesh, ovrAvatarAssetLevelOfDetail lod, bool forceMobileTextureFormat, ovrAvatarLookAndFeelVersion lookVersion, ovrAvatarLookAndFeelVersion fallbackVersion, bool enableExpressive)
		{
		}
	}

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSDKManager _instance;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool initialized;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, HashSet<specificationCallback>> specificationCallbacks;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, HashSet<assetLoadedCallback>> assetLoadedCallbacks;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<IntPtr, combinedMeshLoadedCallback> combinedMeshLoadedCallbacks;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, OvrAvatarAsset> assetCache;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OvrAvatarTextureCopyManager textureCopyManager;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ovrAvatarLogLevel LoggingLevel;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Queue<AvatarSpecRequestParams> avatarSpecificationQueue;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<int> loadingAvatars;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool avatarSpecRequestAvailable;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float lastDispatchedAvatarSpecRequestTime;

	[Token(Token = "0x40002A2")]
	private const float AVATAR_SPEC_REQUEST_TIMEOUT = 5f;

	[Token(Token = "0x1700000F")]
	public static OvrAvatarSDKManager Instance
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0xB06FC4", Offset = "0xB06FC4", VA = "0xB06FC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xB076F0", Offset = "0xB076F0", VA = "0xB076F0")]
	private bool Initialize()
	{
		return default(bool);
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xB079F8", Offset = "0xB079F8", VA = "0xB079F8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xB07A68", Offset = "0xB07A68", VA = "0xB07A68")]
	private void Update()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xB08448", Offset = "0xB08448", VA = "0xB08448")]
	public bool IsAvatarSpecWaiting()
	{
		return default(bool);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xB0849C", Offset = "0xB0849C", VA = "0xB0849C")]
	public bool IsAvatarLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xB084F0", Offset = "0xB084F0", VA = "0xB084F0")]
	public void AddLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xB08554", Offset = "0xB08554", VA = "0xB08554")]
	public void RemoveLoadingAvatar(int gameobjectID)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xB085B8", Offset = "0xB085B8", VA = "0xB085B8")]
	public void RequestAvatarSpecification(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xB08248", Offset = "0xB08248", VA = "0xB08248")]
	private void DispatchAvatarSpecificationRequest(AvatarSpecRequestParams avatarSpecRequest)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xB08694", Offset = "0xB08694", VA = "0xB08694")]
	public void BeginLoadingAsset(ulong assetId, ovrAvatarAssetLevelOfDetail lod, assetLoadedCallback callback)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xB087E8", Offset = "0xB087E8", VA = "0xB087E8")]
	public void RegisterCombinedMeshCallback(IntPtr sdkAvatar, combinedMeshLoadedCallback callback)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xB07198", Offset = "0xB07198", VA = "0xB07198")]
	public OvrAvatarAsset GetAsset(ulong assetId)
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xB088DC", Offset = "0xB088DC", VA = "0xB088DC")]
	public void DeleteAssetFromCache(ulong assetId)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xB079AC", Offset = "0xB079AC", VA = "0xB079AC")]
	public string GetAppId()
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xB089BC", Offset = "0xB089BC", VA = "0xB089BC")]
	public OvrAvatarTextureCopyManager GetTextureCopyManager()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xB08A3C", Offset = "0xB08A3C", VA = "0xB08A3C")]
	public OvrAvatarSDKManager()
	{
	}
}
[Token(Token = "0x2000077")]
public sealed class OvrAvatarSettings : ScriptableObject
{
	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OvrAvatarSettings instance;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string ovrAppID;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string ovrGearAppID;

	[Token(Token = "0x17000010")]
	public static string AppID
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xB0897C", Offset = "0xB0897C", VA = "0xB0897C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xB08B94", Offset = "0xB08B94", VA = "0xB08B94")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public static string MobileAppID
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xB0899C", Offset = "0xB0899C", VA = "0xB0899C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xB08BC0", Offset = "0xB08BC0", VA = "0xB08BC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public static OvrAvatarSettings Instance
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xB08A54", Offset = "0xB08A54", VA = "0xB08A54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xB08BEC", Offset = "0xB08BEC", VA = "0xB08BEC")]
		set
		{
		}
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xB08C3C", Offset = "0xB08C3C", VA = "0xB08C3C")]
	public OvrAvatarSettings()
	{
	}
}
[Token(Token = "0x2000078")]
public class OvrAvatarSkinnedMeshRenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Shader surface;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Shader surfaceSelfOccluding;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool previouslyActive;

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xB0A6E0", Offset = "0xB0A6E0", VA = "0xB0A6E0")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRender skinnedMeshRender, Shader surface, Shader surfaceSelfOccluding, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xB0A9A0", Offset = "0xB0A9A0", VA = "0xB0A9A0")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xB0A838", Offset = "0xB0A838", VA = "0xB0A838")]
	private void UpdateMeshMaterial(ovrAvatarVisibilityFlags visibilityMask, SkinnedMeshRenderer rootMesh)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xB0ABE0", Offset = "0xB0ABE0", VA = "0xB0ABE0")]
	public OvrAvatarSkinnedMeshRenderComponent()
	{
	}
}
[Token(Token = "0x2000079")]
public class OvrAvatarSkinnedMeshRenderPBSComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isMaterialInitilized;

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xB0ABF0", Offset = "0xB0ABF0", VA = "0xB0ABF0")]
	internal void Initialize(ovrAvatarRenderPart_SkinnedMeshRenderPBS skinnedMeshRenderPBS, Shader shader, int thirdPersonLayer, int firstPersonLayer)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xB0AD34", Offset = "0xB0AD34", VA = "0xB0AD34")]
	internal void UpdateSkinnedMeshRenderPBS(OvrAvatar avatar, IntPtr renderPart, Material mat)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xB0AF0C", Offset = "0xB0AF0C", VA = "0xB0AF0C")]
	public OvrAvatarSkinnedMeshRenderPBSComponent()
	{
	}
}
[Token(Token = "0x200007A")]
public class OvrAvatarSkinnedMeshPBSV2RenderComponent : OvrAvatarRenderComponent
{
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OvrAvatarMaterialManager avatarMaterialManager;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool previouslyActive;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool isCombinedMaterial;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private ovrAvatarExpressiveParameters ExpressiveParameters;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool EnableExpressive;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int blendShapeCount;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private ovrAvatarBlendShapeParams blendShapeParams;

	[Token(Token = "0x40002B9")]
	private const string MAIN_MATERIAL_NAME = "main_material";

	[Token(Token = "0x40002BA")]
	private const string EYE_MATERIAL_NAME = "eye_material";

	[Token(Token = "0x40002BB")]
	private const string DEFAULT_MATERIAL_NAME = "_material";

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xB08C90", Offset = "0xB08C90", VA = "0xB08C90")]
	internal void Initialize(IntPtr renderPart, ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 skinnedMeshRender, OvrAvatarMaterialManager materialManager, int thirdPersonLayer, int firstPersonLayer, bool combinedMesh, ovrAvatarAssetLevelOfDetail lod, bool assignExpressiveParams, OvrAvatar avatar, bool isControllerModel)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xB09C0C", Offset = "0xB09C0C", VA = "0xB09C0C")]
	public void UpdateSkinnedMeshRender(OvrAvatarComponent component, OvrAvatar avatar, IntPtr renderPart)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xB09E48", Offset = "0xB09E48", VA = "0xB09E48")]
	private void InitializeSingleComponentMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xB09360", Offset = "0xB09360", VA = "0xB09360")]
	private void InitializeCombinedMaterial(IntPtr renderPart, int lodIndex)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xB09084", Offset = "0xB09084", VA = "0xB09084")]
	private void SetMaterialTransparent(Material mat)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xB091E8", Offset = "0xB091E8", VA = "0xB091E8")]
	private void SetMaterialOpaque(Material mat)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xB0A6D0", Offset = "0xB0A6D0", VA = "0xB0A6D0")]
	public OvrAvatarSkinnedMeshPBSV2RenderComponent()
	{
	}
}
[Token(Token = "0x200007B")]
public class OvrAvatarTextureCopyManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200007C")]
	public struct FallbackTextureSet
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool Initialized;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture2D DiffuseRoughness;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Texture2D Normal;
	}

	[Token(Token = "0x200007D")]
	private struct CopyTextureParams
	{
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Texture Src;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Dst;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Mip;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int SrcSize;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int DstElement;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xB02EA4", Offset = "0xB02EA4", VA = "0xB02EA4")]
		public CopyTextureParams(Texture src, Texture dst, int mip, int srcSize, int dstElement)
		{
		}
	}

	[Token(Token = "0x200007E")]
	public struct TextureSet
	{
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Dictionary<ulong, bool> TextureIDSingleMeshPair;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsProcessed;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xB02EB4", Offset = "0xB02EB4", VA = "0xB02EB4")]
		public TextureSet(Dictionary<ulong, bool> textureIDSingleMeshPair, bool isProcessed)
		{
		}
	}

	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63ECBC", Offset = "0x63ECBC")]
	private sealed class <DeleteTextureSetCoroutine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextureSet textureSetToDelete;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public OvrAvatarTextureCopyManager <>4__this;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int gameobjectID;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xB02E54", Offset = "0xB02E54", VA = "0xB02E54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xB02E9C", Offset = "0xB02E9C", VA = "0xB02E9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xB0283C", Offset = "0xB0283C", VA = "0xB0283C")]
		[DebuggerHidden]
		public <DeleteTextureSetCoroutine>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xB02868", Offset = "0xB02868", VA = "0xB02868", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xB0286C", Offset = "0xB0286C", VA = "0xB0286C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xB02E5C", Offset = "0xB02E5C", VA = "0xB02E5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FallbackTextureSet[] FallbackTextureSets;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Queue<CopyTextureParams> texturesToCopy;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<int, TextureSet> textureSets;

	[Token(Token = "0x40002BF")]
	private const int TEXTURES_TO_COPY_QUEUE_CAPACITY = 256;

	[Token(Token = "0x40002C0")]
	private const int COPIES_PER_FRAME = 8;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_DIFFUSE_ROUGHNESS;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string[] FALLBACK_TEXTURE_PATHS_NORMAL;

	[Token(Token = "0x40002C3")]
	private const string PATH_HIGHEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_2048";

	[Token(Token = "0x40002C4")]
	private const string PATH_MEDIUM_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_1024";

	[Token(Token = "0x40002C5")]
	private const string PATH_LOWEST_DIFFUSE_ROUGHNESS = "FallbackTextures/fallback_diffuse_roughness_256";

	[Token(Token = "0x40002C6")]
	private const string PATH_HIGHEST_NORMAL = "FallbackTextures/fallback_normal_2048";

	[Token(Token = "0x40002C7")]
	private const string PATH_MEDIUM_NORMAL = "FallbackTextures/fallback_normal_1024";

	[Token(Token = "0x40002C8")]
	private const string PATH_LOWEST_NORMAL = "FallbackTextures/fallback_normal_256";

	[Token(Token = "0x40002C9")]
	private const int GPU_TEXTURE_COPY_WAIT_TIME = 10;

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xB0B634", Offset = "0xB0B634", VA = "0xB0B634")]
	public OvrAvatarTextureCopyManager()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xB0BA1C", Offset = "0xB0BA1C", VA = "0xB0BA1C")]
	public void Update()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xB0BC1C", Offset = "0xB0BC1C", VA = "0xB0BC1C")]
	public int GetTextureCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xB0BC68", Offset = "0xB0BC68", VA = "0xB0BC68")]
	public void CopyTexture(Texture src, Texture dst, int mipLevel, int mipSize, int dstElement, bool useQueue = true)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xB0BB90", Offset = "0xB0BB90", VA = "0xB0BB90")]
	private void CopyTexture(CopyTextureParams copyTextureParams)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xB0BE14", Offset = "0xB0BE14", VA = "0xB0BE14")]
	public void AddTextureIDToTextureSet(int gameobjectID, ulong textureID, bool isSingleMesh)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xB0C01C", Offset = "0xB0C01C", VA = "0xB0C01C")]
	public void DeleteTextureSet(int gameobjectID)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xB0C0C0", Offset = "0xB0C0C0", VA = "0xB0C0C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6423F4", Offset = "0x6423F4")]
	private IEnumerator DeleteTextureSetCoroutine(TextureSet textureSetToDelete, int gameobjectID)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xB08648", Offset = "0xB08648", VA = "0xB08648")]
	public void CheckFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xB0C150", Offset = "0xB0C150", VA = "0xB0C150")]
	private void InitFallbackTextureSet(ovrAvatarAssetLevelOfDetail lod)
	{
	}
}
[Token(Token = "0x2000080")]
public class OvrAvatarTouchController : OvrAvatarComponent
{
	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool isLeftHand;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ovrAvatarControllerComponent component;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xB0C288", Offset = "0xB0C288", VA = "0xB0C288")]
	private void Update()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xB0C3F0", Offset = "0xB0C3F0", VA = "0xB0C3F0")]
	public OvrAvatarTouchController()
	{
	}
}
[Token(Token = "0x2000081")]
public class EnableSwitch : MonoBehaviour
{
	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] SwitchTargets;

	[Token(Token = "0x6000179")]
	public bool SetActive<T>(int target) where T : MonoBehaviour
	{
		return default(bool);
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xC7F630", Offset = "0xC7F630", VA = "0xC7F630")]
	public EnableSwitch()
	{
	}
}
[Token(Token = "0x2000082")]
public class LipSyncDemo_Control : MonoBehaviour
{
	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F5D4", Offset = "0x63F5D4")]
	public KeyCode rotateLeftKey;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F60C", Offset = "0x63F60C")]
	public KeyCode rotateRightKey;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F644", Offset = "0x63F644")]
	public KeyCode resetRotationKey;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float resetRotation;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float rotationAmount;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float rotationMax;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xD5ADA0", Offset = "0xD5ADA0", VA = "0xD5ADA0")]
	private void Start()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xD5ADA4", Offset = "0xD5ADA4", VA = "0xD5ADA4")]
	private void Update()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xD5AE24", Offset = "0xD5AE24", VA = "0xD5AE24")]
	private void RotateObject(float amountDegrees, bool absolute = false)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xD5B030", Offset = "0xD5B030", VA = "0xD5B030")]
	public LipSyncDemo_Control()
	{
	}
}
[Token(Token = "0x2000083")]
public class LipSyncDemo_SetCurrentTarget : MonoBehaviour
{
	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public EnableSwitch[] SwitchTargets;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int targetSet;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int maxTarget;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool XRButtonBeingPressed;

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xD5B060", Offset = "0xD5B060", VA = "0xD5B060")]
	private void Start()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xD5B190", Offset = "0xD5B190", VA = "0xD5B190")]
	private void Update()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xD5B4E8", Offset = "0xD5B4E8", VA = "0xD5B4E8")]
	private void SetCurrentTarget()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xD5B788", Offset = "0xD5B788", VA = "0xD5B788")]
	private void LocalTouchEventCallback(OVRTouchpad.TouchEvent touchEvent)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xD5B7D8", Offset = "0xD5B7D8", VA = "0xD5B7D8")]
	public LipSyncDemo_SetCurrentTarget()
	{
	}
}
[Token(Token = "0x2000084")]
public class OVRLipSyncDebugConsole : MonoBehaviour
{
	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ArrayList messages;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int maxMessages;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text textMsg;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OVRLipSyncDebugConsole s_Instance;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool clearTimeoutOn;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float clearTimeout;

	[Token(Token = "0x17000015")]
	public static OVRLipSyncDebugConsole instance
	{
		[Token(Token = "0x6000184")]
		[Address(RVA = "0xFE474C", Offset = "0xFE474C", VA = "0xFE474C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xFE4A48", Offset = "0xFE4A48", VA = "0xFE4A48")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xFE4BA0", Offset = "0xFE4BA0", VA = "0xFE4BA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xFE4AB4", Offset = "0xFE4AB4", VA = "0xFE4AB4")]
	public void Init()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xFE27BC", Offset = "0xFE27BC", VA = "0xFE27BC")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xFE4D20", Offset = "0xFE4D20", VA = "0xFE4D20")]
	public static void Log(string message, Color color)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xFE2758", Offset = "0xFE2758", VA = "0xFE2758")]
	public static void Clear()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xFE2838", Offset = "0xFE2838", VA = "0xFE2838")]
	public static void ClearTimeout(float timeToClear)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xFE4C34", Offset = "0xFE4C34", VA = "0xFE4C34")]
	public void AddMessage(string message, Color color)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xFE4DBC", Offset = "0xFE4DBC", VA = "0xFE4DBC")]
	public void ClearMessages()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xFE4DF8", Offset = "0xFE4DF8", VA = "0xFE4DF8")]
	public void SetClearTimeout(float timeout)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xFE500C", Offset = "0xFE500C", VA = "0xFE500C")]
	private void Prune()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xFE4E08", Offset = "0xFE4E08", VA = "0xFE4E08")]
	private void Display()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xFE50BC", Offset = "0xFE50BC", VA = "0xFE50BC")]
	public OVRLipSyncDebugConsole()
	{
	}
}
[Token(Token = "0x2000085")]
public class OVRNamedArrayAttribute : PropertyAttribute
{
	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string[] names;

	[Token(Token = "0x6000193")]
	[Address(RVA = "0xFE5B68", Offset = "0xFE5B68", VA = "0xFE5B68")]
	public OVRNamedArrayAttribute(string[] names)
	{
	}
}
[Token(Token = "0x2000086")]
public static class OVRTouchpad
{
	[Token(Token = "0x2000087")]
	public enum TouchEvent
	{
		[Token(Token = "0x40002F2")]
		SingleTap,
		[Token(Token = "0x40002F3")]
		DoubleTap,
		[Token(Token = "0x40002F4")]
		Left,
		[Token(Token = "0x40002F5")]
		Right,
		[Token(Token = "0x40002F6")]
		Up,
		[Token(Token = "0x40002F7")]
		Down
	}

	[Token(Token = "0x2000088")]
	public delegate void OVRTouchpadCallback<TouchEvent>(TouchEvent arg);

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector3 moveAmountMouse;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static float minMovMagnitudeMouse;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Delegate touchPadCallbacks;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static OVRTouchpadHelper touchpadHelper;

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xFE14B0", Offset = "0xFE14B0", VA = "0xFE14B0")]
	public static void Create()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xFE867C", Offset = "0xFE867C", VA = "0xFE867C")]
	public static void Update()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xFE892C", Offset = "0xFE892C", VA = "0xFE892C")]
	public static void OnDisable()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xFE879C", Offset = "0xFE879C", VA = "0xFE879C")]
	private static void HandleInputMouse(ref Vector3 move)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xFE2284", Offset = "0xFE2284", VA = "0xFE2284")]
	public static void AddListener(OVRTouchpadCallback<TouchEvent> handler)
	{
	}
}
[Token(Token = "0x2000089")]
public sealed class OVRTouchpadHelper : MonoBehaviour
{
	[Token(Token = "0x600019E")]
	[Address(RVA = "0xFE89FC", Offset = "0xFE89FC", VA = "0xFE89FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xFE8A74", Offset = "0xFE8A74", VA = "0xFE8A74")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xFE8B2C", Offset = "0xFE8B2C", VA = "0xFE8B2C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xFE8B84", Offset = "0xFE8B84", VA = "0xFE8B84")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xFE8BE4", Offset = "0xFE8BE4", VA = "0xFE8BE4")]
	private void LocalTouchEventCallback(OVRTouchpad.TouchEvent touchEvent)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xFE8BE8", Offset = "0xFE8BE8", VA = "0xFE8BE8")]
	public OVRTouchpadHelper()
	{
	}
}
[Token(Token = "0x200008A")]
public class OVRLipSync : MonoBehaviour
{
	[Token(Token = "0x200008B")]
	public enum Result
	{
		[Token(Token = "0x40002FE")]
		Success = 0,
		[Token(Token = "0x40002FF")]
		Unknown = -2200,
		[Token(Token = "0x4000300")]
		CannotCreateContext = -2201,
		[Token(Token = "0x4000301")]
		InvalidParam = -2202,
		[Token(Token = "0x4000302")]
		BadSampleRate = -2203,
		[Token(Token = "0x4000303")]
		MissingDLL = -2204,
		[Token(Token = "0x4000304")]
		BadVersion = -2205,
		[Token(Token = "0x4000305")]
		UndefinedFunction = -2206
	}

	[Token(Token = "0x200008C")]
	public enum AudioDataType
	{
		[Token(Token = "0x4000307")]
		S16_Mono,
		[Token(Token = "0x4000308")]
		S16_Stereo,
		[Token(Token = "0x4000309")]
		F32_Mono,
		[Token(Token = "0x400030A")]
		F32_Stereo
	}

	[Token(Token = "0x200008D")]
	public enum Viseme
	{
		[Token(Token = "0x400030C")]
		sil,
		[Token(Token = "0x400030D")]
		PP,
		[Token(Token = "0x400030E")]
		FF,
		[Token(Token = "0x400030F")]
		TH,
		[Token(Token = "0x4000310")]
		DD,
		[Token(Token = "0x4000311")]
		kk,
		[Token(Token = "0x4000312")]
		CH,
		[Token(Token = "0x4000313")]
		SS,
		[Token(Token = "0x4000314")]
		nn,
		[Token(Token = "0x4000315")]
		RR,
		[Token(Token = "0x4000316")]
		aa,
		[Token(Token = "0x4000317")]
		E,
		[Token(Token = "0x4000318")]
		ih,
		[Token(Token = "0x4000319")]
		oh,
		[Token(Token = "0x400031A")]
		ou
	}

	[Token(Token = "0x200008E")]
	public enum Signals
	{
		[Token(Token = "0x400031C")]
		VisemeOn,
		[Token(Token = "0x400031D")]
		VisemeOff,
		[Token(Token = "0x400031E")]
		VisemeAmount,
		[Token(Token = "0x400031F")]
		VisemeSmoothing,
		[Token(Token = "0x4000320")]
		LaughterAmount
	}

	[Token(Token = "0x200008F")]
	public enum ContextProviders
	{
		[Token(Token = "0x4000322")]
		Original,
		[Token(Token = "0x4000323")]
		Enhanced,
		[Token(Token = "0x4000324")]
		Enhanced_with_Laughter
	}

	[Serializable]
	[Token(Token = "0x2000090")]
	public class Frame
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameNumber;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int frameDelay;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] Visemes;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float laughterScore;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xB01260", Offset = "0xB01260", VA = "0xB01260")]
		public void CopyInput(Frame input)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xB012B8", Offset = "0xB012B8", VA = "0xB012B8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xB01344", Offset = "0xB01344", VA = "0xB01344")]
		public Frame()
		{
		}
	}

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly int VisemeCount;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static readonly int SignalCount;

	[Token(Token = "0x40002FA")]
	public const string strOVRLS = "OVRLipSync";

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Result sInitialized;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static OVRLipSync sInstance;

	[PreserveSig]
	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xFE0A20", Offset = "0xFE0A20", VA = "0xFE0A20")]
	private static extern int ovrLipSyncDll_Initialize(int samplerate, int buffersize);

	[PreserveSig]
	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xFE0AB0", Offset = "0xFE0AB0", VA = "0xFE0AB0")]
	private static extern void ovrLipSyncDll_Shutdown();

	[PreserveSig]
	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xFE0B20", Offset = "0xFE0B20", VA = "0xFE0B20")]
	private static extern IntPtr ovrLipSyncDll_GetVersion(ref int Major, ref int Minor, ref int Patch);

	[PreserveSig]
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xFE0BB4", Offset = "0xFE0BB4", VA = "0xFE0BB4")]
	private static extern int ovrLipSyncDll_CreateContextEx(ref uint context, ContextProviders provider, int sampleRate, bool enableAcceleration);

	[PreserveSig]
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xFE0C5C", Offset = "0xFE0C5C", VA = "0xFE0C5C")]
	private static extern int ovrLipSyncDll_CreateContextWithModelFile(ref uint context, ContextProviders provider, string modelPath, int sampleRate, bool enableAcceleration);

	[PreserveSig]
	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xFE0D28", Offset = "0xFE0D28", VA = "0xFE0D28")]
	private static extern int ovrLipSyncDll_DestroyContext(uint context);

	[PreserveSig]
	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xFE0DA8", Offset = "0xFE0DA8", VA = "0xFE0DA8")]
	private static extern int ovrLipSyncDll_ResetContext(uint context);

	[PreserveSig]
	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xFE0E28", Offset = "0xFE0E28", VA = "0xFE0E28")]
	private static extern int ovrLipSyncDll_SendSignal(uint context, Signals signal, int arg1, int arg2);

	[PreserveSig]
	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xFE0ED0", Offset = "0xFE0ED0", VA = "0xFE0ED0")]
	private static extern int ovrLipSyncDll_ProcessFrameEx(uint context, IntPtr audioBuffer, uint bufferSize, AudioDataType dataType, ref int frameNumber, ref int frameDelay, float[] visemes, int visemeCount, ref float laughterScore, float[] laughterCategories, int laughterCategoriesLength);

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xFE0FD8", Offset = "0xFE0FD8", VA = "0xFE0FD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xFE14B4", Offset = "0xFE14B4", VA = "0xFE14B4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xFE1358", Offset = "0xFE1358", VA = "0xFE1358")]
	public static Result Initialize()
	{
		return default(Result);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xFE15B4", Offset = "0xFE15B4", VA = "0xFE15B4")]
	public static Result Initialize(int sampleRate, int bufferSize)
	{
		return default(Result);
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xFE16E8", Offset = "0xFE16E8", VA = "0xFE16E8")]
	public static void Shutdown()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xFE1754", Offset = "0xFE1754", VA = "0xFE1754")]
	public static Result IsInitialized()
	{
		return default(Result);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xFE17B8", Offset = "0xFE17B8", VA = "0xFE17B8")]
	public static Result CreateContext(ref uint context, ContextProviders provider, int sampleRate = 0, bool enableAcceleration = false)
	{
		return default(Result);
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xFE18D4", Offset = "0xFE18D4", VA = "0xFE18D4")]
	public static Result CreateContextWithModelFile(ref uint context, ContextProviders provider, string modelPath, int sampleRate = 0, bool enableAcceleration = false)
	{
		return default(Result);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xFE1A04", Offset = "0xFE1A04", VA = "0xFE1A04")]
	public static Result DestroyContext(uint context)
	{
		return default(Result);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xFE1ADC", Offset = "0xFE1ADC", VA = "0xFE1ADC")]
	public static Result ResetContext(uint context)
	{
		return default(Result);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xFE1BB4", Offset = "0xFE1BB4", VA = "0xFE1BB4")]
	public static Result SendSignal(uint context, Signals signal, int arg1, int arg2)
	{
		return default(Result);
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xFE1CB0", Offset = "0xFE1CB0", VA = "0xFE1CB0")]
	public static Result ProcessFrame(uint context, float[] audioBuffer, Frame frame, bool stereo = true)
	{
		return default(Result);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xFE1E4C", Offset = "0xFE1E4C", VA = "0xFE1E4C")]
	public static Result ProcessFrame(uint context, short[] audioBuffer, Frame frame, bool stereo = true)
	{
		return default(Result);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xFE1FE0", Offset = "0xFE1FE0", VA = "0xFE1FE0")]
	public OVRLipSync()
	{
	}
}
[Token(Token = "0x2000091")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x63ECCC", Offset = "0x63ECCC")]
public class OVRLipSyncContext : OVRLipSyncContextBase
{
	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F67C", Offset = "0x63F67C")]
	public bool enableKeyboardInput;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F6B4", Offset = "0x63F6B4")]
	public bool enableTouchInput;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F6EC", Offset = "0x63F6EC")]
	public bool audioLoopback;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F724", Offset = "0x63F724")]
	public KeyCode loopbackKey;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F75C", Offset = "0x63F75C")]
	public bool showVisemes;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F794", Offset = "0x63F794")]
	public KeyCode debugVisemesKey;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F7CC", Offset = "0x63F7CC")]
	public bool skipAudioSource;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F804", Offset = "0x63F804")]
	public float gain;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool hasDebugConsole;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public KeyCode debugLaughterKey;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showLaughter;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float laughterScore;

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xFE2124", Offset = "0xFE2124", VA = "0xFE2124")]
	private void Start()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xFE234C", Offset = "0xFE234C", VA = "0xFE234C")]
	private void HandleKeyboard()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xFE28B4", Offset = "0xFE28B4", VA = "0xFE28B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xFE2BDC", Offset = "0xFE2BDC", VA = "0xFE2BDC")]
	public void PreprocessAudioSamples(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xFE2C40", Offset = "0xFE2C40", VA = "0xFE2C40")]
	public void PostprocessAudioSamples(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xFE2CAC", Offset = "0xFE2CAC", VA = "0xFE2CAC")]
	public void ProcessAudioSamplesRaw(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xFE2E50", Offset = "0xFE2E50", VA = "0xFE2E50")]
	public void ProcessAudioSamplesRaw(short[] data, int channels)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xFE2FF4", Offset = "0xFE2FF4", VA = "0xFE2FF4")]
	public void ProcessAudioSamples(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xFE312C", Offset = "0xFE312C", VA = "0xFE312C")]
	private void OnAudioFilterRead(float[] data, int channels)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xFE28F8", Offset = "0xFE28F8", VA = "0xFE28F8")]
	private void DebugShowVisemesAndLaughter()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xFE2670", Offset = "0xFE2670", VA = "0xFE2670")]
	private void ToggleAudioLoopback()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xFE313C", Offset = "0xFE313C", VA = "0xFE313C")]
	private void LocalTouchEventCallback(OVRTouchpad.TouchEvent touchEvent)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xFE325C", Offset = "0xFE325C", VA = "0xFE325C")]
	public OVRLipSyncContext()
	{
	}
}
[Token(Token = "0x2000092")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x63ED2C", Offset = "0x63ED2C")]
public class OVRLipSyncContextBase : MonoBehaviour
{
	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource audioSource;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F83C", Offset = "0x63F83C")]
	public OVRLipSync.ContextProviders provider;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F874", Offset = "0x63F874")]
	public bool enableAcceleration;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRLipSync.Frame frame;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private uint context;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int _smoothing;

	[Token(Token = "0x17000016")]
	public int Smoothing
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xFE33FC", Offset = "0xFE33FC", VA = "0xFE33FC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xFE32F0", Offset = "0xFE32F0", VA = "0xFE32F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public uint Context
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xFE3404", Offset = "0xFE3404", VA = "0xFE3404")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17000018")]
	protected OVRLipSync.Frame Frame
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xFE340C", Offset = "0xFE340C", VA = "0xFE340C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xFE3414", Offset = "0xFE3414", VA = "0xFE3414")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xFE35FC", Offset = "0xFE35FC", VA = "0xFE35FC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xFE3760", Offset = "0xFE3760", VA = "0xFE3760")]
	public OVRLipSync.Frame GetCurrentPhonemeFrame()
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xFE3768", Offset = "0xFE3768", VA = "0xFE3768")]
	public void SetVisemeBlend(int viseme, int amount)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xFE387C", Offset = "0xFE387C", VA = "0xFE387C")]
	public void SetLaughterBlend(int amount)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xFE3958", Offset = "0xFE3958", VA = "0xFE3958")]
	public OVRLipSync.Result ResetContext()
	{
		return default(OVRLipSync.Result);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xFE3280", Offset = "0xFE3280", VA = "0xFE3280")]
	public OVRLipSyncContextBase()
	{
	}
}
[Token(Token = "0x2000093")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x63ED8C", Offset = "0x63ED8C")]
public class OVRLipSyncContextCanned : OVRLipSyncContextBase
{
	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F8AC", Offset = "0x63F8AC")]
	public OVRLipSyncSequence currentSequence;

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xFE39D0", Offset = "0xFE39D0", VA = "0xFE39D0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xFE3B60", Offset = "0xFE3B60", VA = "0xFE3B60")]
	public OVRLipSyncContextCanned()
	{
	}
}
[Token(Token = "0x2000094")]
public class OVRLipSyncContextMorphTarget : MonoBehaviour
{
	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F8E4", Offset = "0x63F8E4")]
	public SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F91C", Offset = "0x63F91C")]
	public int[] visemeToBlendTargets;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F954", Offset = "0x63F954")]
	public bool enableVisemeTestKeys;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F98C", Offset = "0x63F98C")]
	public KeyCode[] visemeTestKeys;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F9C4", Offset = "0x63F9C4")]
	public KeyCode laughterKey;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63F9FC", Offset = "0x63F9FC")]
	public int laughterBlendTarget;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FA34", Offset = "0x63FA34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FA34", Offset = "0x63FA34")]
	public float laughterThreshold;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FA88", Offset = "0x63FA88")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FA88", Offset = "0x63FA88")]
	public float laughterMultiplier;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FADC", Offset = "0x63FADC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FADC", Offset = "0x63FADC")]
	public int smoothAmount;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private OVRLipSyncContextBase lipsyncContext;

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xFE3B64", Offset = "0xFE3B64", VA = "0xFE3B64")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xFE3CD4", Offset = "0xFE3CD4", VA = "0xFE3CD4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xFE3F2C", Offset = "0xFE3F2C", VA = "0xFE3F2C")]
	private void CheckForKeys()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xFE3DDC", Offset = "0xFE3DDC", VA = "0xFE3DDC")]
	private void SetVisemeToMorphTarget(OVRLipSync.Frame frame)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xFE3E90", Offset = "0xFE3E90", VA = "0xFE3E90")]
	private void SetLaughterToMorphTarget(OVRLipSync.Frame frame)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xFE3FF8", Offset = "0xFE3FF8", VA = "0xFE3FF8")]
	private void CheckVisemeKey(KeyCode key, int viseme, int amount)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xFE40BC", Offset = "0xFE40BC", VA = "0xFE40BC")]
	private void CheckLaughterKey()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xFE4124", Offset = "0xFE4124", VA = "0xFE4124")]
	public OVRLipSyncContextMorphTarget()
	{
	}
}
[Token(Token = "0x2000095")]
public class OVRLipSyncContextTextureFlip : MonoBehaviour
{
	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material material;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "OVRNamedArrayAttribute", RVA = "0x63FB34", Offset = "0x63FB34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FB34", Offset = "0x63FB34")]
	public Texture[] Textures;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FCAC", Offset = "0x63FCAC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FCAC", Offset = "0x63FCAC")]
	public int smoothAmount;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private OVRLipSyncContextBase lipsyncContext;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OVRLipSync.Frame oldFrame;

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xFE423C", Offset = "0xFE423C", VA = "0xFE423C")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xFE43BC", Offset = "0xFE43BC", VA = "0xFE43BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xFE455C", Offset = "0xFE455C", VA = "0xFE455C")]
	private void SetVisemeToTexture()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xFE4688", Offset = "0xFE4688", VA = "0xFE4688")]
	public OVRLipSyncContextTextureFlip()
	{
	}
}
[Token(Token = "0x2000096")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x63EDEC", Offset = "0x63EDEC")]
public class OVRLipSyncMicInput : MonoBehaviour
{
	[Token(Token = "0x2000097")]
	public enum micActivation
	{
		[Token(Token = "0x4000359")]
		HoldToSpeak,
		[Token(Token = "0x400035A")]
		PushToSpeak,
		[Token(Token = "0x400035B")]
		ConstantSpeak
	}

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FD04", Offset = "0x63FD04")]
	public AudioSource audioSource;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FD3C", Offset = "0x63FD3C")]
	public bool enableMicSelectionGUI;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FD74", Offset = "0x63FD74")]
	public KeyCode micSelectionGUIKey;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x63FDAC", Offset = "0x63FDAC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FDAC", Offset = "0x63FDAC")]
	private float micInputVolume;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FE14", Offset = "0x63FE14")]
	private int micFrequency;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FE60", Offset = "0x63FE60")]
	public micActivation micControl;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FE98", Offset = "0x63FE98")]
	public KeyCode micActivationKey;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FED0", Offset = "0x63FED0")]
	public string selectedDevice;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool micSelected;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int minFreq;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int maxFreq;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool focused;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool initialized;

	[Token(Token = "0x17000019")]
	public float MicFrequency
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xFE512C", Offset = "0xFE512C", VA = "0xFE512C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xFE5138", Offset = "0xFE5138", VA = "0xFE5138")]
		set
		{
		}
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xFE5188", Offset = "0xFE5188", VA = "0xFE5188")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xFE5250", Offset = "0xFE5250", VA = "0xFE5250")]
	private void Start()
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xFE529C", Offset = "0xFE529C", VA = "0xFE529C")]
	private void InitializeMicrophone()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xFE53E8", Offset = "0xFE53E8", VA = "0xFE53E8")]
	private void Update()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xFE5834", Offset = "0xFE5834", VA = "0xFE5834")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xFE5848", Offset = "0xFE5848", VA = "0xFE5848")]
	private void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xFE5860", Offset = "0xFE5860", VA = "0xFE5860")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xFE5864", Offset = "0xFE5864", VA = "0xFE5864")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xFE58DC", Offset = "0xFE58DC", VA = "0xFE58DC")]
	public void MicDeviceGUI(float left, float top, float width, float height, float buttonSpaceTop, float buttonSpaceLeft)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xFE5324", Offset = "0xFE5324", VA = "0xFE5324")]
	public void GetMicCaps()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xFE56A0", Offset = "0xFE56A0", VA = "0xFE56A0")]
	public void StartMicrophone()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xFE5544", Offset = "0xFE5544", VA = "0xFE5544")]
	public void StopMicrophone()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xFE5AB8", Offset = "0xFE5AB8", VA = "0xFE5AB8")]
	private float GetAveragedVolume()
	{
		return default(float);
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xFE5AC0", Offset = "0xFE5AC0", VA = "0xFE5AC0")]
	public OVRLipSyncMicInput()
	{
	}
}
[Serializable]
[Token(Token = "0x2000098")]
public class OVRLipSyncSequence : ScriptableObject
{
	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<OVRLipSync.Frame> entries;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float length;

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xFE3A9C", Offset = "0xFE3A9C", VA = "0xFE3A9C")]
	public OVRLipSync.Frame GetFrameAtTime(float time)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xFE5AF0", Offset = "0xFE5AF0", VA = "0xFE5AF0")]
	public OVRLipSyncSequence()
	{
	}
}
[Token(Token = "0x2000099")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200009A")]
	public delegate void OnClick();

	[Token(Token = "0x200009B")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x200009C")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x200009D")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EE4C", Offset = "0x63EE4C")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnClick handler;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xAFBCF4", Offset = "0xAFBCF4", VA = "0xAFBCF4")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xAFBCFC", Offset = "0xAFBCFC", VA = "0xAFBCFC")]
		internal void <AddButton>b__0()
		{
		}
	}

	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EE5C", Offset = "0x63EE5C")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnSlider onValueChanged;

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xAFBF20", Offset = "0xAFBF20", VA = "0xAFBF20")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xAFBF28", Offset = "0xAFBF28", VA = "0xAFBF28")]
		internal void <AddSlider>b__0(float f)
		{
		}
	}

	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EE6C", Offset = "0x63EE6C")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xAFC174", Offset = "0xAFC174", VA = "0xAFC174")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xAFC17C", Offset = "0xAFC17C", VA = "0xAFC17C")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EE7C", Offset = "0x63EE7C")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange onValueChanged;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle t;

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xAFC510", Offset = "0xAFC510", VA = "0xAFC510")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xAFC518", Offset = "0xAFC518", VA = "0xAFC518")]
		internal void <AddToggle>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EE8C", Offset = "0x63EE8C")]
	private sealed class <>c__DisplayClass42_0
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OnToggleValueChange handler;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Toggle tb;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xAFC538", Offset = "0xAFC538", VA = "0xAFC538")]
		public <>c__DisplayClass42_0()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xAFC540", Offset = "0xAFC540", VA = "0xAFC540")]
		internal void <AddRadio>b__0(bool <p0>)
		{
		}
	}

	[Token(Token = "0x400035E")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x400035F")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000360")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool[] reEnable;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x400036E")]
	private const float elementSpacing = 16f;

	[Token(Token = "0x400036F")]
	private const float marginH = 16f;

	[Token(Token = "0x4000370")]
	private const float marginV = 16f;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2[] insertPositions;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 menuOffset;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private OVRCameraRig rig;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private LaserPointer lp;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private LineRenderer lr;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xC7B818", Offset = "0xC7B818", VA = "0xC7B818")]
	public void Awake()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xC68DD8", Offset = "0xC68DD8", VA = "0xC68DD8")]
	public void Show()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xC69400", Offset = "0xC69400", VA = "0xC69400")]
	public void Hide()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xC7BCCC", Offset = "0xC7BCCC", VA = "0xC7BCCC")]
	private void Relayout()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xC7BEEC", Offset = "0xC7BEEC", VA = "0xC7BEEC")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xC68840", Offset = "0xC68840", VA = "0xC68840")]
	public RectTransform AddButton(string label, OnClick handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xC68698", Offset = "0xC68698", VA = "0xC68698")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xC7C1C4", Offset = "0xC7C1C4", VA = "0xC7C1C4")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xC6879C", Offset = "0xC6879C", VA = "0xC6879C")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xC7C39C", Offset = "0xC7C39C", VA = "0xC7C39C")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xC7C56C", Offset = "0xC7C56C", VA = "0xC7C56C")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xC7C754", Offset = "0xC7C754", VA = "0xC7C754")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xC7CA3C", Offset = "0xC7CA3C", VA = "0xC7CA3C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xC68D2C", Offset = "0xC68D2C", VA = "0xC68D2C")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xC7CB38", Offset = "0xC7CB38", VA = "0xC7CB38")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x20000A3")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xC81B28", Offset = "0xC81B28", VA = "0xC81B28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xC81BC4", Offset = "0xC81BC4", VA = "0xC81BC4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xC81C84", Offset = "0xC81C84", VA = "0xC81C84")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xC81CC0", Offset = "0xC81CC0", VA = "0xC81CC0")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x20000A4")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x20000A5")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x400038D")]
		On,
		[Token(Token = "0x400038E")]
		Off,
		[Token(Token = "0x400038F")]
		OnWhenHitTarget
	}

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x1700001A")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x6000225")]
		[Address(RVA = "0xD5A5B4", Offset = "0xD5A5B4", VA = "0xD5A5B4")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x6000224")]
		[Address(RVA = "0xD5A570", Offset = "0xD5A570", VA = "0xD5A570")]
		set
		{
		}
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xD5A5BC", Offset = "0xD5A5BC", VA = "0xD5A5BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xD5A610", Offset = "0xD5A610", VA = "0xD5A610")]
	private void Start()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xD5A754", Offset = "0xD5A754", VA = "0xD5A754", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xD5A770", Offset = "0xD5A770", VA = "0xD5A770", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xD5A7C4", Offset = "0xD5A7C4", VA = "0xD5A7C4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xD5A980", Offset = "0xD5A980", VA = "0xD5A980")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xD5AA94", Offset = "0xD5AA94", VA = "0xD5AA94")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xD5AB24", Offset = "0xD5AB24", VA = "0xD5AB24")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xD5ABF0", Offset = "0xD5ABF0", VA = "0xD5ABF0")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xD5ACA4", Offset = "0xD5ACA4", VA = "0xD5ACA4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xD5AD90", Offset = "0xD5AD90", VA = "0xD5AD90")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x20000A6")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x4000390")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x4000391")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x4000392")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FFB8", Offset = "0x63FFB8")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x63FFF0", Offset = "0x63FFF0")]
	public LayerMask CollideLayers;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640028", Offset = "0x640028")]
	public float HeightOffset;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640060", Offset = "0x640060")]
	public float MinimumHeight;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640098", Offset = "0x640098")]
	public float MaximumHeight;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xC794E0", Offset = "0xC794E0", VA = "0xC794E0")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xC794E8", Offset = "0xC794E8", VA = "0xC794E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xC79560", Offset = "0xC79560", VA = "0xC79560")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xC795F4", Offset = "0xC795F4", VA = "0xC795F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xC79688", Offset = "0xC79688", VA = "0xC79688")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xC799B4", Offset = "0xC799B4", VA = "0xC799B4")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xC79BE4", Offset = "0xC79BE4", VA = "0xC79BE4")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000A7")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xD5B7E8", Offset = "0xD5B7E8", VA = "0xD5B7E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xD5B89C", Offset = "0xD5B89C", VA = "0xD5B89C")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x20000A8")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x20000A9")]
	public enum States
	{
		[Token(Token = "0x40003C0")]
		Ready,
		[Token(Token = "0x40003C1")]
		Aim,
		[Token(Token = "0x40003C2")]
		CancelAim,
		[Token(Token = "0x40003C3")]
		PreTeleport,
		[Token(Token = "0x40003C4")]
		CancelTeleport,
		[Token(Token = "0x40003C5")]
		Teleporting,
		[Token(Token = "0x40003C6")]
		PostTeleport
	}

	[Token(Token = "0x20000AA")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x40003C8")]
		None,
		[Token(Token = "0x40003C9")]
		Aim,
		[Token(Token = "0x40003CA")]
		PreTeleport,
		[Token(Token = "0x40003CB")]
		Teleport
	}

	[Token(Token = "0x20000AB")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x40003CD")]
		Point,
		[Token(Token = "0x40003CE")]
		Sphere,
		[Token(Token = "0x40003CF")]
		Capsule
	}

	[Token(Token = "0x20000AC")]
	public class AimData
	{
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6404B0", Offset = "0x6404B0")]
		private List<Vector3> <Points>k__BackingField;

		[Token(Token = "0x1700001E")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xAFE194", Offset = "0xAFE194", VA = "0xAFE194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64291C", Offset = "0x64291C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xAFE19C", Offset = "0xAFE19C", VA = "0xAFE19C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64292C", Offset = "0x64292C")]
			private set
			{
			}
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xAFE118", Offset = "0xAFE118", VA = "0xAFE118")]
		public AimData()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xAFE1A4", Offset = "0xAFE1A4", VA = "0xAFE1A4")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EE9C", Offset = "0x63EE9C")]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0xAFDF70", Offset = "0xAFDF70", VA = "0xAFDF70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0xAFDFB8", Offset = "0xAFDFB8", VA = "0xAFDFB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xAFDE54", Offset = "0xAFDE54", VA = "0xAFDE54")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xAFDE80", Offset = "0xAFDE80", VA = "0xAFDE80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xAFDE84", Offset = "0xAFDE84", VA = "0xAFDE84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xAFDF78", Offset = "0xAFDF78", VA = "0xAFDF78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EEAC", Offset = "0x63EEAC")]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xAFD8FC", Offset = "0xAFD8FC", VA = "0xAFD8FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0xAFD944", Offset = "0xAFD944", VA = "0xAFD944", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xAFD78C", Offset = "0xAFD78C", VA = "0xAFD78C")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xAFD7B8", Offset = "0xAFD7B8", VA = "0xAFD7B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xAFD7BC", Offset = "0xAFD7BC", VA = "0xAFD7BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xAFD904", Offset = "0xAFD904", VA = "0xAFD904", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EEBC", Offset = "0x63EEBC")]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0xAFDA1C", Offset = "0xAFDA1C", VA = "0xAFDA1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0xAFDA64", Offset = "0xAFDA64", VA = "0xAFDA64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xAFD94C", Offset = "0xAFD94C", VA = "0xAFD94C")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xAFD978", Offset = "0xAFD978", VA = "0xAFD978", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xAFD97C", Offset = "0xAFD97C", VA = "0xAFD97C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xAFDA24", Offset = "0xAFDA24", VA = "0xAFDA24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EECC", Offset = "0x63EECC")]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0xAFDE04", Offset = "0xAFDE04", VA = "0xAFDE04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xAFDE4C", Offset = "0xAFDE4C", VA = "0xAFDE4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xAFDCF4", Offset = "0xAFDCF4", VA = "0xAFDCF4")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xAFDD20", Offset = "0xAFDD20", VA = "0xAFDD20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xAFDD24", Offset = "0xAFDD24", VA = "0xAFDD24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xAFDE0C", Offset = "0xAFDE0C", VA = "0xAFDE0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EEDC", Offset = "0x63EEDC")]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xAFDB3C", Offset = "0xAFDB3C", VA = "0xAFDB3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xAFDB84", Offset = "0xAFDB84", VA = "0xAFDB84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xAFDA6C", Offset = "0xAFDA6C", VA = "0xAFDA6C")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xAFDA98", Offset = "0xAFDA98", VA = "0xAFDA98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xAFDA9C", Offset = "0xAFDA9C", VA = "0xAFDA9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xAFDB44", Offset = "0xAFDB44", VA = "0xAFDB44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EEEC", Offset = "0x63EEEC")]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0xAFE0C8", Offset = "0xAFE0C8", VA = "0xAFE0C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0xAFE110", Offset = "0xAFE110", VA = "0xAFE110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xAFDFC0", Offset = "0xAFDFC0", VA = "0xAFDFC0")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xAFDFEC", Offset = "0xAFDFEC", VA = "0xAFDFEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xAFDFF0", Offset = "0xAFDFF0", VA = "0xAFDFF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xAFE0D0", Offset = "0xAFE0D0", VA = "0xAFE0D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EEFC", Offset = "0x63EEFC")]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0xAFDCA4", Offset = "0xAFDCA4", VA = "0xAFDCA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0xAFDCEC", Offset = "0xAFDCEC", VA = "0xAFDCEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xAFDB8C", Offset = "0xAFDB8C", VA = "0xAFDB8C")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xAFDBB8", Offset = "0xAFDBB8", VA = "0xAFDBB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xAFDBBC", Offset = "0xAFDBBC", VA = "0xAFDBBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xAFDCAC", Offset = "0xAFDCAC", VA = "0xAFDCAC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6400D0", Offset = "0x6400D0")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640108", Offset = "0x640108")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640140", Offset = "0x640140")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640178", Offset = "0x640178")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6401B0", Offset = "0x6401B0")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6401E8", Offset = "0x6401E8")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640220", Offset = "0x640220")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640258", Offset = "0x640258")]
	public bool EnableRotationDuringPostTeleport;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640290", Offset = "0x640290")]
	private States <CurrentState>k__BackingField;

	[NonSerialized]
	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6402A0", Offset = "0x6402A0")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6402D8", Offset = "0x6402D8")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640320", Offset = "0x640320")]
	private LocomotionController <LocomotionController>k__BackingField;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640330", Offset = "0x640330")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640368", Offset = "0x640368")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6403A0", Offset = "0x6403A0")]
	public float AimCollisionRadius;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6403D8", Offset = "0x6403D8")]
	public float AimCollisionHeight;

	[Token(Token = "0x1700001B")]
	public States CurrentState
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xD5C36C", Offset = "0xD5C36C", VA = "0xD5C36C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6424A4", Offset = "0x6424A4")]
		get
		{
			return default(States);
		}
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xD5C374", Offset = "0xD5C374", VA = "0xD5C374")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6424B4", Offset = "0x6424B4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xD5C598", Offset = "0xD5C598", VA = "0xD5C598")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700001D")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x6000242")]
		[Address(RVA = "0xD5C5C0", Offset = "0xD5C5C0", VA = "0xD5C5C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6424E4", Offset = "0x6424E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xD5C5C8", Offset = "0xD5C5C8", VA = "0xD5C5C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6424F4", Offset = "0x6424F4")]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xD5C37C", Offset = "0xD5C37C", VA = "0xD5C37C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6424C4", Offset = "0x6424C4")]
		add
		{
		}
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xD5C41C", Offset = "0xD5C41C", VA = "0xD5C41C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6424D4", Offset = "0x6424D4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xD5CBC0", Offset = "0xD5CBC0", VA = "0xD5CBC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64253C", Offset = "0x64253C")]
		add
		{
		}
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xD5CC60", Offset = "0xD5CC60", VA = "0xD5CC60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64254C", Offset = "0x64254C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD5CD00", Offset = "0xD5CD00", VA = "0xD5CD00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425BC", Offset = "0x6425BC")]
		add
		{
		}
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xD5CDA0", Offset = "0xD5CDA0", VA = "0xD5CDA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425CC", Offset = "0x6425CC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xD5CE40", Offset = "0xD5CE40", VA = "0xD5CE40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425DC", Offset = "0x6425DC")]
		add
		{
		}
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xD5CEE0", Offset = "0xD5CEE0", VA = "0xD5CEE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425EC", Offset = "0x6425EC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xD5CFF0", Offset = "0xD5CFF0", VA = "0xD5CFF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6425FC", Offset = "0x6425FC")]
		add
		{
		}
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xD5D090", Offset = "0xD5D090", VA = "0xD5D090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64260C", Offset = "0x64260C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xD5D19C", Offset = "0xD5D19C", VA = "0xD5D19C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64267C", Offset = "0x64267C")]
		add
		{
		}
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xD5D23C", Offset = "0xD5D23C", VA = "0xD5D23C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64268C", Offset = "0x64268C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xD5D348", Offset = "0xD5D348", VA = "0xD5D348")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6426FC", Offset = "0x6426FC")]
		add
		{
		}
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xD5D3E8", Offset = "0xD5D3E8", VA = "0xD5D3E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64270C", Offset = "0x64270C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xD5D4F4", Offset = "0xD5D4F4", VA = "0xD5D4F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64277C", Offset = "0x64277C")]
		add
		{
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0xD5D594", Offset = "0xD5D594", VA = "0xD5D594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64278C", Offset = "0x64278C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x6000261")]
		[Address(RVA = "0xD5D6A0", Offset = "0xD5D6A0", VA = "0xD5D6A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6427FC", Offset = "0x6427FC")]
		add
		{
		}
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xD5D740", Offset = "0xD5D740", VA = "0xD5D740")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64280C", Offset = "0x64280C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0xD5D84C", Offset = "0xD5D84C", VA = "0xD5D84C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64287C", Offset = "0x64287C")]
		add
		{
		}
		[Token(Token = "0x6000265")]
		[Address(RVA = "0xD5D8EC", Offset = "0xD5D8EC", VA = "0xD5D8EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64288C", Offset = "0x64288C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xD5D9F8", Offset = "0xD5D9F8", VA = "0xD5D9F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6428FC", Offset = "0x6428FC")]
		add
		{
		}
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xD5DA98", Offset = "0xD5DA98", VA = "0xD5DA98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64290C", Offset = "0x64290C")]
		remove
		{
		}
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xD5C018", Offset = "0xD5C018", VA = "0xD5C018")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xD5C03C", Offset = "0xD5C03C", VA = "0xD5C03C")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xD5C4BC", Offset = "0xD5C4BC", VA = "0xD5C4BC")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xD5C5D0", Offset = "0xD5C5D0", VA = "0xD5C5D0")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xD5C81C", Offset = "0xD5C81C", VA = "0xD5C81C")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x642504", Offset = "0x642504")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xD5C8D0", Offset = "0xD5C8D0", VA = "0xD5C8D0")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xD5C9A0", Offset = "0xD5C9A0", VA = "0xD5C9A0")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xD5C9BC", Offset = "0xD5C9BC", VA = "0xD5C9BC")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xD5CA80", Offset = "0xD5CA80", VA = "0xD5CA80")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xD5CAC4", Offset = "0xD5CAC4", VA = "0xD5CAC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xD5CB1C", Offset = "0xD5CB1C", VA = "0xD5CB1C", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xD5CBB8", Offset = "0xD5CBB8", VA = "0xD5CBB8", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xD5CB4C", Offset = "0xD5CB4C", VA = "0xD5CB4C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64255C", Offset = "0x64255C")]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xD5CF80", Offset = "0xD5CF80", VA = "0xD5CF80")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xD5D130", Offset = "0xD5D130", VA = "0xD5D130")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64261C", Offset = "0x64261C")]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xD5D2DC", Offset = "0xD5D2DC", VA = "0xD5D2DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64269C", Offset = "0x64269C")]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xD5D488", Offset = "0xD5D488", VA = "0xD5D488")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64271C", Offset = "0x64271C")]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xD5D634", Offset = "0xD5D634", VA = "0xD5D634")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64279C", Offset = "0x64279C")]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xD5D7E0", Offset = "0xD5D7E0", VA = "0xD5D7E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64281C", Offset = "0x64281C")]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xD5D98C", Offset = "0xD5D98C", VA = "0xD5D98C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64289C", Offset = "0x64289C")]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xD5DB38", Offset = "0xD5DB38", VA = "0xD5DB38")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xD5DC78", Offset = "0xD5DC78", VA = "0xD5DC78")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xD5DCAC", Offset = "0xD5DCAC", VA = "0xD5DCAC")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xD5DD74", Offset = "0xD5DD74", VA = "0xD5DD74")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xD5DE6C", Offset = "0xD5DE6C", VA = "0xD5DE6C")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x20000B4")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0xB13814", Offset = "0xB13814", VA = "0xB13814")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642B6C", Offset = "0x642B6C")]
		add
		{
		}
		[Token(Token = "0x600029D")]
		[Address(RVA = "0xB138B4", Offset = "0xB138B4", VA = "0xB138B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642B7C", Offset = "0x642B7C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0xB13954", Offset = "0xB13954", VA = "0xB13954")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642B8C", Offset = "0x642B8C")]
		add
		{
		}
		[Token(Token = "0x600029F")]
		[Address(RVA = "0xB139F4", Offset = "0xB139F4", VA = "0xB139F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642B9C", Offset = "0x642B9C")]
		remove
		{
		}
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xB13A94", Offset = "0xB13A94", VA = "0xB13A94")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xB13B50", Offset = "0xB13B50", VA = "0xB13B50")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xB13B54", Offset = "0xB13B54", VA = "0xB13B54")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xB13BC8", Offset = "0xB13BC8", VA = "0xB13BC8")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xB13CEC", Offset = "0xB13CEC", VA = "0xB13CEC")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xB13ED4", Offset = "0xB13ED4", VA = "0xB13ED4")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xB140DC", Offset = "0xB140DC", VA = "0xB140DC")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x20000B5")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xB18290", Offset = "0xB18290", VA = "0xB18290", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xB18320", Offset = "0xB18320", VA = "0xB18320", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60002A9")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xB183EC", Offset = "0xB183EC", VA = "0xB183EC")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x20000B6")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6404E0", Offset = "0x6404E0")]
	public float Range;

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xB183FC", Offset = "0xB183FC", VA = "0xB183FC", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xB184F8", Offset = "0xB184F8", VA = "0xB184F8")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x20000B7")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640518", Offset = "0x640518")]
	public float Range;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640550", Offset = "0x640550")]
	public float MinimumElevation;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640588", Offset = "0x640588")]
	public float Gravity;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6405C0", Offset = "0x6405C0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6405C0", Offset = "0x6405C0")]
	public float AimVelocity;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64061C", Offset = "0x64061C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64061C", Offset = "0x64061C")]
	public float AimStep;

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xB18508", Offset = "0xB18508", VA = "0xB18508", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xB18698", Offset = "0xB18698", VA = "0xB18698")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x20000B8")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640674", Offset = "0x640674")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xB186AC", Offset = "0xB186AC", VA = "0xB186AC")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xB187C8", Offset = "0xB187C8", VA = "0xB187C8")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xB187F8", Offset = "0xB187F8", VA = "0xB187F8")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xB18828", Offset = "0xB18828", VA = "0xB18828")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xB188D0", Offset = "0xB188D0", VA = "0xB188D0", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xB1893C", Offset = "0xB1893C", VA = "0xB1893C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xB189A4", Offset = "0xB189A4", VA = "0xB189A4")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x20000B9")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6406AC", Offset = "0x6406AC")]
	private bool <IsValidDestination>k__BackingField;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6406BC", Offset = "0x6406BC")]
	public Transform PositionIndicator;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6406F4", Offset = "0x6406F4")]
	public Transform OrientationIndicator;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64072C", Offset = "0x64072C")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700002D")]
	public bool IsValidDestination
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xB18AC8", Offset = "0xB18AC8", VA = "0xB18AC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642BAC", Offset = "0x642BAC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xB18AD0", Offset = "0xB18AD0", VA = "0xB18AD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642BBC", Offset = "0x642BBC")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xB18C84", Offset = "0xB18C84", VA = "0xB18C84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642BCC", Offset = "0x642BCC")]
		add
		{
		}
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xB18D24", Offset = "0xB18D24", VA = "0xB18D24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642BDC", Offset = "0x642BDC")]
		remove
		{
		}
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xB18ADC", Offset = "0xB18ADC", VA = "0xB18ADC")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xB18B6C", Offset = "0xB18B6C", VA = "0xB18B6C")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xB18C40", Offset = "0xB18C40", VA = "0xB18C40")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xB18C80", Offset = "0xB18C80", VA = "0xB18C80")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xB18DC4", Offset = "0xB18DC4", VA = "0xB18DC4")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xB18E28", Offset = "0xB18E28", VA = "0xB18E28")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xB18E48", Offset = "0xB18E48", VA = "0xB18E48", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x20000BA")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF0C", Offset = "0x63EF0C")]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xB04A20", Offset = "0xB04A20", VA = "0xB04A20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xB04A68", Offset = "0xB04A68", VA = "0xB04A68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xB04964", Offset = "0xB04964", VA = "0xB04964")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xB04990", Offset = "0xB04990", VA = "0xB04990", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xB04994", Offset = "0xB04994", VA = "0xB04994", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xB04A28", Offset = "0xB04A28", VA = "0xB04A28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF1C", Offset = "0x63EF1C")]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xB04914", Offset = "0xB04914", VA = "0xB04914", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xB0495C", Offset = "0xB0495C", VA = "0xB0495C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xB04854", Offset = "0xB04854", VA = "0xB04854")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xB04880", Offset = "0xB04880", VA = "0xB04880", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xB04884", Offset = "0xB04884", VA = "0xB04884", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xB0491C", Offset = "0xB0491C", VA = "0xB0491C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xB19054", Offset = "0xB19054", VA = "0xB19054")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xB19114", Offset = "0xB19114", VA = "0xB19114", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xB1916C", Offset = "0xB1916C", VA = "0xB1916C", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xB19224", Offset = "0xB19224", VA = "0xB19224")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x642BEC", Offset = "0x642BEC")]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xB19290", Offset = "0xB19290", VA = "0xB19290")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x642C4C", Offset = "0x642C4C")]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002C6")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x60002C7")]
	public abstract void GetAimData(out Ray aimRay);

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xB192FC", Offset = "0xB192FC", VA = "0xB192FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642CAC", Offset = "0x642CAC")]
	private void <.ctor>b__2_0()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xB19328", Offset = "0xB19328", VA = "0xB19328")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642CBC", Offset = "0x642CBC")]
	private void <.ctor>b__2_1()
	{
	}
}
[Token(Token = "0x20000BD")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640774", Offset = "0x640774")]
	private Transform <Pointer>k__BackingField;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640784", Offset = "0x640784")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6407BC", Offset = "0x6407BC")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6407F4", Offset = "0x6407F4")]
	public bool FastTeleport;

	[Token(Token = "0x17000032")]
	public Transform Pointer
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xB19354", Offset = "0xB19354", VA = "0xB19354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642D6C", Offset = "0x642D6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xB1935C", Offset = "0xB1935C", VA = "0xB1935C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642D7C", Offset = "0x642D7C")]
		private set
		{
		}
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xB19364", Offset = "0xB19364", VA = "0xB19364", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xB194BC", Offset = "0xB194BC", VA = "0xB194BC", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xB19574", Offset = "0xB19574", VA = "0xB19574")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x20000BE")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x20000BF")]
	public enum InputModes
	{
		[Token(Token = "0x4000420")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x4000421")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x4000422")]
		ThumbstickTeleport,
		[Token(Token = "0x4000423")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x20000C0")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x4000425")]
		A,
		[Token(Token = "0x4000426")]
		B,
		[Token(Token = "0x4000427")]
		LeftTrigger,
		[Token(Token = "0x4000428")]
		LeftThumbstick,
		[Token(Token = "0x4000429")]
		RightTrigger,
		[Token(Token = "0x400042A")]
		RightThumbstick,
		[Token(Token = "0x400042B")]
		X,
		[Token(Token = "0x400042C")]
		Y
	}

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64082C", Offset = "0x64082C")]
	public InputModes InputMode;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640864", Offset = "0x640864")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64089C", Offset = "0x64089C")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6408D4", Offset = "0x6408D4")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xB19578", Offset = "0xB19578", VA = "0xB19578")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xB1957C", Offset = "0xB1957C", VA = "0xB1957C", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xB19964", Offset = "0xB19964", VA = "0xB19964", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xB19A24", Offset = "0xB19A24", VA = "0xB19A24")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x20000C1")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x20000C2")]
	public enum OrientationModes
	{
		[Token(Token = "0x4000431")]
		HeadRelative,
		[Token(Token = "0x4000432")]
		ForwardFacing
	}

	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF2C", Offset = "0x63EF2C")]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xB04B44", Offset = "0xB04B44", VA = "0xB04B44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xB04B8C", Offset = "0xB04B8C", VA = "0xB04B8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xB04A70", Offset = "0xB04A70", VA = "0xB04A70")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xB04A9C", Offset = "0xB04A9C", VA = "0xB04A9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xB04AA0", Offset = "0xB04AA0", VA = "0xB04AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xB04B4C", Offset = "0xB04B4C", VA = "0xB04B4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xB19AF0", Offset = "0xB19AF0", VA = "0xB19AF0")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xB19BD0", Offset = "0xB19BD0", VA = "0xB19BD0")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xB19BD8", Offset = "0xB19BD8", VA = "0xB19BD8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xB19C24", Offset = "0xB19C24", VA = "0xB19C24", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xB19C6C", Offset = "0xB19C6C", VA = "0xB19C6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x642D8C", Offset = "0x642D8C")]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60002E4")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x60002E5")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xB19CD8", Offset = "0xB19CD8", VA = "0xB19CD8")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xB19D94", Offset = "0xB19D94", VA = "0xB19D94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642DEC", Offset = "0x642DEC")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000C4")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xB19DC0", Offset = "0xB19DC0", VA = "0xB19DC0", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xB19DC4", Offset = "0xB19DC4", VA = "0xB19DC4", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xB19E40", Offset = "0xB19E40", VA = "0xB19E40")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x20000C5")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64090C", Offset = "0x64090C")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640944", Offset = "0x640944")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x64097C", Offset = "0x64097C")]
	public float AimDistanceThreshold;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6409B4", Offset = "0x6409B4")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xB19E44", Offset = "0xB19E44", VA = "0xB19E44", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xB19E70", Offset = "0xB19E70", VA = "0xB19E70", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xB1A220", Offset = "0xB1A220", VA = "0xB1A220")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x20000C6")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6409EC", Offset = "0x6409EC")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640A24", Offset = "0x640A24")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640A5C", Offset = "0x640A5C")]
	public float RotateStickThreshold;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xB1A224", Offset = "0xB1A224", VA = "0xB1A224", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xB1A268", Offset = "0xB1A268", VA = "0xB1A268", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xB1A610", Offset = "0xB1A610", VA = "0xB1A610")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x20000C7")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xB1A620", Offset = "0xB1A620", VA = "0xB1A620")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xB1A624", Offset = "0xB1A624", VA = "0xB1A624")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xB1A62C", Offset = "0xB1A62C", VA = "0xB1A62C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xB1A6E8", Offset = "0xB1A6E8", VA = "0xB1A6E8")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xB1A710", Offset = "0xB1A710", VA = "0xB1A710")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x20000C8")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640A94", Offset = "0x640A94")]
	private LocomotionTeleport <LocomotionTeleport>k__BackingField;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000035")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xB1A728", Offset = "0xB1A728", VA = "0xB1A728")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642E4C", Offset = "0x642E4C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xB1A730", Offset = "0xB1A730", VA = "0xB1A730")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642E5C", Offset = "0x642E5C")]
		private set
		{
		}
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xB182C0", Offset = "0xB182C0", VA = "0xB182C0", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xB183C0", Offset = "0xB183C0", VA = "0xB183C0", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xB1A738", Offset = "0xB1A738", VA = "0xB1A738")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x642E6C", Offset = "0x642E6C")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xB18930", Offset = "0xB18930", VA = "0xB18930", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xB1899C", Offset = "0xB1899C", VA = "0xB1899C", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xB183F4", Offset = "0xB183F4", VA = "0xB183F4")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x20000C9")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF3C", Offset = "0x63EF3C")]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xB04E58", Offset = "0xB04E58", VA = "0xB04E58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xB04EA0", Offset = "0xB04EA0", VA = "0xB04EA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xB04B94", Offset = "0xB04B94", VA = "0xB04B94")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xB04BC0", Offset = "0xB04BC0", VA = "0xB04BC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xB04BC4", Offset = "0xB04BC4", VA = "0xB04BC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xB04E60", Offset = "0xB04E60", VA = "0xB04E60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640AA4", Offset = "0x640AA4")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x400044C")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xB1A814", Offset = "0xB1A814", VA = "0xB1A814")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xB1A904", Offset = "0xB1A904", VA = "0xB1A904", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xB1A930", Offset = "0xB1A930", VA = "0xB1A930", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xB1A958", Offset = "0xB1A958", VA = "0xB1A958")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x642EA4", Offset = "0x642EA4")]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xB1A9C4", Offset = "0xB1A9C4", VA = "0xB1A9C4", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x6000309")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xB1A9E0", Offset = "0xB1A9E0", VA = "0xB1A9E0", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xB1AB00", Offset = "0xB1AB00", VA = "0xB1AB00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x642F04", Offset = "0x642F04")]
	private void <.ctor>b__3_0()
	{
	}
}
[Token(Token = "0x20000CB")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xAF4144", Offset = "0xAF4144", VA = "0xAF4144")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xAF41A0", Offset = "0xAF41A0", VA = "0xAF41A0", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0xAF4298", Offset = "0xAF4298", VA = "0xAF4298", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xAF4394", Offset = "0xAF4394", VA = "0xAF4394")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x642F64", Offset = "0x642F64")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xAF4398", Offset = "0xAF4398", VA = "0xAF4398")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x20000CC")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640ADC", Offset = "0x640ADC")]
	public float LOSOffset;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640B14", Offset = "0x640B14")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xAF43A8", Offset = "0xAF43A8", VA = "0xAF43A8", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xAF45B4", Offset = "0xAF45B4", VA = "0xAF45B4")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x20000CD")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x6000319")]
	[Address(RVA = "0xAF45C4", Offset = "0xAF45C4", VA = "0xAF45C4", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xAF46BC", Offset = "0xAF46BC", VA = "0xAF46BC")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x20000CE")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x600031B")]
	[Address(RVA = "0xAF46C4", Offset = "0xAF46C4", VA = "0xAF46C4", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xAF4758", Offset = "0xAF4758", VA = "0xAF4758", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600031D")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xAF47EC", Offset = "0xAF47EC", VA = "0xAF47EC")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x20000CF")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x20000D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF4C", Offset = "0x63EF4C")]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0xB04FA8", Offset = "0xB04FA8", VA = "0xB04FA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xB04FF0", Offset = "0xB04FF0", VA = "0xB04FF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xAF488C", Offset = "0xAF488C", VA = "0xAF488C")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xB04EA8", Offset = "0xB04EA8", VA = "0xB04EA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xB04EAC", Offset = "0xB04EAC", VA = "0xB04EAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xB04FB0", Offset = "0xB04FB0", VA = "0xB04FB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640B4C", Offset = "0x640B4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640B4C", Offset = "0x640B4C")]
	public float TransitionDuration;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640BA4", Offset = "0x640BA4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640BA4", Offset = "0x640BA4")]
	public float TeleportDelay;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640BF8", Offset = "0x640BF8")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xAF47F4", Offset = "0xAF47F4", VA = "0xAF47F4", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xAF4820", Offset = "0xAF4820", VA = "0xAF4820")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x642F9C", Offset = "0x642F9C")]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xAF48B8", Offset = "0xAF48B8", VA = "0xAF48B8")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x20000D1")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x6000328")]
	[Address(RVA = "0xAF4A58", Offset = "0xAF4A58", VA = "0xAF4A58", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xAF4A74", Offset = "0xAF4A74", VA = "0xAF4A74")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x20000D2")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF5C", Offset = "0x63EF5C")]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xB0512C", Offset = "0xB0512C", VA = "0xB0512C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xB05174", Offset = "0xB05174", VA = "0xB05174", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xAF4B14", Offset = "0xAF4B14", VA = "0xAF4B14")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xB04FF8", Offset = "0xB04FF8", VA = "0xB04FF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xB04FFC", Offset = "0xB04FFC", VA = "0xB04FFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xB05134", Offset = "0xB05134", VA = "0xB05134", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640C30", Offset = "0x640C30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640C30", Offset = "0x640C30")]
	public float TransitionDuration;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xAF4A7C", Offset = "0xAF4A7C", VA = "0xAF4A7C", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xAF4AA8", Offset = "0xAF4AA8", VA = "0xAF4AA8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64304C", Offset = "0x64304C")]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xAF4B40", Offset = "0xAF4B40", VA = "0xAF4B40")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x20000D4")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x20000D5")]
	public enum PlabackState
	{
		[Token(Token = "0x400047C")]
		Idle = 1,
		[Token(Token = "0x400047D")]
		Preparing,
		[Token(Token = "0x400047E")]
		Buffering,
		[Token(Token = "0x400047F")]
		Ready,
		[Token(Token = "0x4000480")]
		Ended
	}

	[Token(Token = "0x20000D6")]
	public enum StereoMode
	{
		[Token(Token = "0x4000482")]
		Unknown = -1,
		[Token(Token = "0x4000483")]
		Mono,
		[Token(Token = "0x4000484")]
		TopBottom,
		[Token(Token = "0x4000485")]
		LeftRight,
		[Token(Token = "0x4000486")]
		Mesh
	}

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x1700003C")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x6000333")]
		[Address(RVA = "0xD624A8", Offset = "0xD624A8", VA = "0xD624A8")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700003D")]
	private static IntPtr Activity
	{
		[Token(Token = "0x6000334")]
		[Address(RVA = "0xD627D8", Offset = "0xD627D8", VA = "0xD627D8")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700003E")]
	public static bool IsAvailable
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0xD5FA00", Offset = "0xD5FA00", VA = "0xD5FA00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003F")]
	public static bool IsPlaying
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0xD61190", Offset = "0xD61190", VA = "0xD61190")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000040")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0xD62AA8", Offset = "0xD62AA8", VA = "0xD62AA8")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x17000041")]
	public static long Duration
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xD613B4", Offset = "0xD613B4", VA = "0xD613B4")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000042")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x6000339")]
		[Address(RVA = "0xD60028", Offset = "0xD60028", VA = "0xD60028")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000043")]
	public static int VideoWidth
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0xD5FE00", Offset = "0xD5FE00", VA = "0xD5FE00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000044")]
	public static int VideoHeight
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0xD5FF14", Offset = "0xD5FF14", VA = "0xD5FF14")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000045")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x600033C")]
		[Address(RVA = "0xD612A0", Offset = "0xD612A0", VA = "0xD612A0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600033D")]
		[Address(RVA = "0xD60890", Offset = "0xD60890", VA = "0xD60890")]
		set
		{
		}
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xD62BBC", Offset = "0xD62BBC", VA = "0xD62BBC")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xD6177C", Offset = "0xD6177C", VA = "0xD6177C")]
	public static void Stop()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xD604DC", Offset = "0xD604DC", VA = "0xD604DC")]
	public static void Play()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xD6067C", Offset = "0xD6067C", VA = "0xD6067C")]
	public static void Pause()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xD6157C", Offset = "0xD6157C", VA = "0xD6157C")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xD62DDC", Offset = "0xD62DDC", VA = "0xD62DDC")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xD60FA8", Offset = "0xD60FA8", VA = "0xD60FA8")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x20000D7")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x6000346")]
		[Address(RVA = "0xC71418", Offset = "0xC71418", VA = "0xC71418")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6430FC", Offset = "0x6430FC")]
		add
		{
		}
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xC714B8", Offset = "0xC714B8", VA = "0xC714B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64310C", Offset = "0x64310C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xC71558", Offset = "0xC71558", VA = "0xC71558", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xC7156C", Offset = "0xC7156C", VA = "0xC7156C")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x20000D8")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x20000D9")]
	public enum ButtonType
	{
		[Token(Token = "0x400048A")]
		Play,
		[Token(Token = "0x400048B")]
		Pause,
		[Token(Token = "0x400048C")]
		FastForward,
		[Token(Token = "0x400048D")]
		Rewind,
		[Token(Token = "0x400048E")]
		SkipForward,
		[Token(Token = "0x400048F")]
		SkipBack,
		[Token(Token = "0x4000490")]
		Stop
	}

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000046")]
	public ButtonType buttonType
	{
		[Token(Token = "0x600034A")]
		[Address(RVA = "0xD5DE7C", Offset = "0xD5DE7C", VA = "0xD5DE7C")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xD5DE84", Offset = "0xD5DE84", VA = "0xD5DE84")]
		set
		{
		}
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xD5DEA8", Offset = "0xD5DEA8", VA = "0xD5DEA8", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xD5F340", Offset = "0xD5F340", VA = "0xD5F340")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x20000DA")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x20000DB")]
	public enum VideoShape
	{
		[Token(Token = "0x40004A5")]
		_360,
		[Token(Token = "0x40004A6")]
		_180,
		[Token(Token = "0x40004A7")]
		Quad
	}

	[Token(Token = "0x20000DC")]
	public enum VideoStereo
	{
		[Token(Token = "0x40004A9")]
		Mono,
		[Token(Token = "0x40004AA")]
		TopBottom,
		[Token(Token = "0x40004AB")]
		LeftRight,
		[Token(Token = "0x40004AC")]
		BottomTop
	}

	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF6C", Offset = "0x63EF6C")]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0xAFE4E4", Offset = "0xAFE4E4", VA = "0xAFE4E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0xAFE52C", Offset = "0xAFE52C", VA = "0xAFE52C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xAFE2FC", Offset = "0xAFE2FC", VA = "0xAFE2FC")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xAFE328", Offset = "0xAFE328", VA = "0xAFE328", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xAFE32C", Offset = "0xAFE32C", VA = "0xAFE32C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xAFE4EC", Offset = "0xAFE4EC", VA = "0xAFE4EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF7C", Offset = "0x63EF7C")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string moviePath;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string drmLicencesUrl;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xAFE204", Offset = "0xAFE204", VA = "0xAFE204")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xAFE20C", Offset = "0xAFE20C", VA = "0xAFE20C")]
		internal void <Play>b__0()
		{
		}
	}

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CB8", Offset = "0x640CB8")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CC8", Offset = "0x640CC8")]
	private long <Duration>k__BackingField;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x640CD8", Offset = "0x640CD8")]
	private long <PlaybackPosition>k__BackingField;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000047")]
	public bool IsPlaying
	{
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xD5F758", Offset = "0xD5F758", VA = "0xD5F758")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64311C", Offset = "0x64311C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xD5F760", Offset = "0xD5F760", VA = "0xD5F760")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64312C", Offset = "0x64312C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public long Duration
	{
		[Token(Token = "0x6000350")]
		[Address(RVA = "0xD5F76C", Offset = "0xD5F76C", VA = "0xD5F76C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64313C", Offset = "0x64313C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xD5F774", Offset = "0xD5F774", VA = "0xD5F774")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64314C", Offset = "0x64314C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public long PlaybackPosition
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0xD5F77C", Offset = "0xD5F77C", VA = "0xD5F77C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64315C", Offset = "0x64315C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000353")]
		[Address(RVA = "0xD5F784", Offset = "0xD5F784", VA = "0xD5F784")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64316C", Offset = "0x64316C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xD5F78C", Offset = "0xD5F78C", VA = "0xD5F78C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0xD5FA70", Offset = "0xD5FA70", VA = "0xD5FA70")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0xD5FAD4", Offset = "0xD5FAD4", VA = "0xD5FAD4")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0xD6013C", Offset = "0xD6013C", VA = "0xD6013C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64317C", Offset = "0x64317C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0xD601A8", Offset = "0xD601A8", VA = "0xD601A8")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0xD6044C", Offset = "0xD6044C", VA = "0xD6044C")]
	public void Play()
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xD605F0", Offset = "0xD605F0", VA = "0xD605F0")]
	public void Pause()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xD60790", Offset = "0xD60790", VA = "0xD60790")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xD609FC", Offset = "0xD609FC", VA = "0xD609FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xD614C8", Offset = "0xD614C8", VA = "0xD614C8")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xD616F0", Offset = "0xD616F0", VA = "0xD616F0")]
	public void Stop()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xD61890", Offset = "0xD61890", VA = "0xD61890")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xD6197C", Offset = "0xD6197C", VA = "0xD6197C")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x20000DF")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x20000E0")]
	private enum PlaybackState
	{
		[Token(Token = "0x40004C9")]
		Playing,
		[Token(Token = "0x40004CA")]
		Paused,
		[Token(Token = "0x40004CB")]
		Rewinding,
		[Token(Token = "0x40004CC")]
		FastForwarding
	}

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xD6198C", Offset = "0xD6198C", VA = "0xD6198C")]
	private void Start()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xD61CE0", Offset = "0xD61CE0", VA = "0xD61CE0")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xD61EBC", Offset = "0xD61EBC", VA = "0xD61EBC")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xD61FF0", Offset = "0xD61FF0", VA = "0xD61FF0")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xD620F8", Offset = "0xD620F8", VA = "0xD620F8")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xD61FC4", Offset = "0xD61FC4", VA = "0xD61FC4")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xD62158", Offset = "0xD62158", VA = "0xD62158")]
	private void Update()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xD61BCC", Offset = "0xD61BCC", VA = "0xD61BCC")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xD62498", Offset = "0xD62498", VA = "0xD62498")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x20000E1")]
public static class VectorUtil
{
	[Token(Token = "0x6000372")]
	[Address(RVA = "0xAF80C4", Offset = "0xAF80C4", VA = "0xAF80C4")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x20000E2")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x40004CD")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x40004CE")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xC68320", Offset = "0xC68320", VA = "0xC68320")]
	private void Start()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xC6917C", Offset = "0xC6917C", VA = "0xC6917C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xC695BC", Offset = "0xC695BC", VA = "0xC695BC")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xC69724", Offset = "0xC69724", VA = "0xC69724")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xC69890", Offset = "0xC69890", VA = "0xC69890")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xC69A20", Offset = "0xC69A20", VA = "0xC69A20")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x20000E3")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x40004D7")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xC7B588", Offset = "0xC7B588", VA = "0xC7B588")]
	private void Awake()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xC7B5D8", Offset = "0xC7B5D8", VA = "0xC7B5D8")]
	private void Start()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xC7B5DC", Offset = "0xC7B5DC", VA = "0xC7B5DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xC68AD0", Offset = "0xC68AD0", VA = "0xC68AD0")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xC7B5E0", Offset = "0xC7B5E0", VA = "0xC7B5E0")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xC7B810", Offset = "0xC7B810", VA = "0xC7B810")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x20000E4")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xC7CBB0", Offset = "0xC7CBB0", VA = "0xC7CBB0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xC7D0B4", Offset = "0xC7D0B4", VA = "0xC7D0B4")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xC7D174", Offset = "0xC7D174", VA = "0xC7D174")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xC7D3A0", Offset = "0xC7D3A0", VA = "0xC7D3A0")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xC7D480", Offset = "0xC7D480", VA = "0xC7D480")]
	private void Update()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xC7D564", Offset = "0xC7D564", VA = "0xC7D564")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xC7D5D8", Offset = "0xC7D5D8", VA = "0xC7D5D8")]
	public DebugUISample()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xC7D5E0", Offset = "0xC7D5E0", VA = "0xC7D5E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64323C", Offset = "0x64323C")]
	private void <Start>b__2_0(Toggle t)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xC7D644", Offset = "0xC7D644", VA = "0xC7D644")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64324C", Offset = "0x64324C")]
	private void <Start>b__2_1(Toggle t)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xC7D6A8", Offset = "0xC7D6A8", VA = "0xC7D6A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64325C", Offset = "0x64325C")]
	private void <Start>b__2_2(Toggle t)
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xC7D70C", Offset = "0xC7D70C", VA = "0xC7D70C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64326C", Offset = "0x64326C")]
	private void <Start>b__2_3(Toggle t)
	{
	}
}
[Token(Token = "0x20000E5")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EF9C", Offset = "0x63EF9C")]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0xAFCF54", Offset = "0xAFCF54", VA = "0xAFCF54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0xAFCF9C", Offset = "0xAFCF9C", VA = "0xAFCF9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xAFCE04", Offset = "0xAFCE04", VA = "0xAFCE04")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xAFCE30", Offset = "0xAFCE30", VA = "0xAFCE30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xAFCE34", Offset = "0xAFCE34", VA = "0xAFCE34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xAFCF5C", Offset = "0xAFCF5C", VA = "0xAFCF5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xC81CC8", Offset = "0xC81CC8", VA = "0xC81CC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xC81DCC", Offset = "0xC81DCC", VA = "0xC81DCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xC81D60", Offset = "0xC81D60", VA = "0xC81D60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x64327C", Offset = "0x64327C")]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xC81F78", Offset = "0xC81F78", VA = "0xC81F78")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x20000E7")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640D08", Offset = "0x640D08")]
	public int SubdivisionsU;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x640D24", Offset = "0x640D24")]
	public int SubdivisionsV;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xC7A0B0", Offset = "0xC7A0B0", VA = "0xC7A0B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xC7AABC", Offset = "0xC7AABC", VA = "0xC7AABC")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x20000E8")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700004E")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x6000396")]
		[Address(RVA = "0xD5B8A4", Offset = "0xD5B8A4", VA = "0xD5B8A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xD5B8F8", Offset = "0xD5B8F8", VA = "0xD5B8F8")]
	public void Start()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xD5BCF4", Offset = "0xD5BCF4", VA = "0xD5BCF4")]
	public void Update()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xD5BDE0", Offset = "0xD5BDE0", VA = "0xD5BDE0")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x64332C", Offset = "0x64332C")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x600039A")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600039B")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x600039C")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x600039D")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x600039E")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x600039F")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x60003A0")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x60003A1")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xD5BE44", Offset = "0xD5BE44", VA = "0xD5BE44")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xD5BE80", Offset = "0xD5BE80", VA = "0xD5BE80")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0xD5BEF0", Offset = "0xD5BEF0", VA = "0xD5BEF0")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xD5C060", Offset = "0xD5C060", VA = "0xD5C060")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0xD5C13C", Offset = "0xD5C13C", VA = "0xD5C13C")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0xD5BBEC", Offset = "0xD5BBEC", VA = "0xD5BBEC")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xD5C204", Offset = "0xD5C204", VA = "0xD5C204")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xD5C26C", Offset = "0xD5C26C", VA = "0xD5C26C")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xD5C364", Offset = "0xD5C364", VA = "0xD5C364")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x20000E9")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x63EFBC", Offset = "0x63EFBC")]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x20000EA")]
	public enum DrawMode
	{
		[Token(Token = "0x4000502")]
		Opaque,
		[Token(Token = "0x4000503")]
		OpaqueWithClip,
		[Token(Token = "0x4000504")]
		TransparentDefaultAlpha,
		[Token(Token = "0x4000505")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private Shader _transparentShader;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700004F")]
	public bool overlayEnabled
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xFE705C", Offset = "0xFE705C", VA = "0xFE705C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xFE70EC", Offset = "0xFE70EC", VA = "0xFE70EC")]
		set
		{
		}
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xFE5B94", Offset = "0xFE5B94", VA = "0xFE5B94")]
	private void Start()
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xFE66C8", Offset = "0xFE66C8", VA = "0xFE66C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xFE6748", Offset = "0xFE6748", VA = "0xFE6748")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xFE6838", Offset = "0xFE6838", VA = "0xFE6838")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xFE6928", Offset = "0xFE6928", VA = "0xFE6928", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xFE6B34", Offset = "0xFE6B34", VA = "0xFE6B34")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xFE71B8", Offset = "0xFE71B8", VA = "0xFE71B8")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x20000EB")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F01C", Offset = "0x63F01C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int sceneIndex;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StartMenu <>4__this;

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xB04300", Offset = "0xB04300", VA = "0xB04300")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xB04308", Offset = "0xB04308", VA = "0xB04308")]
		internal void <Start>b__0()
		{
		}
	}

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xB17D6C", Offset = "0xB17D6C", VA = "0xB17D6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xB17F70", Offset = "0xB17F70", VA = "0xB17F70")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xB18080", Offset = "0xB18080", VA = "0xB18080")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000ED")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x63F02C", Offset = "0x63F02C")]
public class MouseLook : MonoBehaviour
{
	[Token(Token = "0x20000EE")]
	public enum RotationAxes
	{
		[Token(Token = "0x4000514")]
		MouseXAndY,
		[Token(Token = "0x4000515")]
		MouseX,
		[Token(Token = "0x4000516")]
		MouseY
	}

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RotationAxes axes;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sensitivityX;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sensitivityY;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumX;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maximumX;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float minimumY;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maximumY;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float rotationY;

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xD5F498", Offset = "0xD5F498", VA = "0xD5F498")]
	private void Update()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xD5F670", Offset = "0xD5F670", VA = "0xD5F670")]
	private void Start()
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xD5F738", Offset = "0xD5F738", VA = "0xD5F738")]
	public MouseLook()
	{
	}
}
[Token(Token = "0x20000EF")]
public class ONSPAmbisonicsNative : MonoBehaviour
{
	[Token(Token = "0x20000F0")]
	public enum ovrAmbisonicsNativeStatus
	{
		[Token(Token = "0x400051C")]
		Uninitialized = -1,
		[Token(Token = "0x400051D")]
		NotEnabled,
		[Token(Token = "0x400051E")]
		Success,
		[Token(Token = "0x400051F")]
		StreamError,
		[Token(Token = "0x4000520")]
		ProcessError,
		[Token(Token = "0x4000521")]
		MaxStatValue
	}

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioSource source;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int numFOAChannels;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int paramAmbiStat;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ovrAmbisonicsNativeStatus currentStatus;

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0xD62FB8", Offset = "0xD62FB8", VA = "0xD62FB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0xD6323C", Offset = "0xD6323C", VA = "0xD6323C")]
	private void Update()
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xD63490", Offset = "0xD63490", VA = "0xD63490")]
	public ONSPAmbisonicsNative()
	{
	}
}
[Token(Token = "0x20000F1")]
public class ONSPAudioSource : MonoBehaviour
{
	[Token(Token = "0x20000F2")]
	private enum Parameters
	{
		[Token(Token = "0x400052D")]
		P_GAIN,
		[Token(Token = "0x400052E")]
		P_USEINVSQR,
		[Token(Token = "0x400052F")]
		P_NEAR,
		[Token(Token = "0x4000530")]
		P_FAR,
		[Token(Token = "0x4000531")]
		P_RADIUS,
		[Token(Token = "0x4000532")]
		P_DISABLE_RFL,
		[Token(Token = "0x4000533")]
		P_AMBISTAT,
		[Token(Token = "0x4000534")]
		P_READONLY_GLOBAL_RFL_ENABLED,
		[Token(Token = "0x4000535")]
		P_READONLY_NUM_VOICES,
		[Token(Token = "0x4000536")]
		P_SENDLEVEL,
		[Token(Token = "0x4000537")]
		P_NUM
	}

	[Token(Token = "0x4000522")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool enableSpatialization;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float gain;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool useInvSqr;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float near;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float far;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float volumetricRadius;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float reverbSend;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool enableRfl;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPAudioSource RoomReflectionGizmoAS;

	[Token(Token = "0x17000050")]
	public bool EnableSpatialization
	{
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xD636D4", Offset = "0xD636D4", VA = "0xD636D4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xD636DC", Offset = "0xD636DC", VA = "0xD636DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000051")]
	public float Gain
	{
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xD636E8", Offset = "0xD636E8", VA = "0xD636E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xD636F0", Offset = "0xD636F0", VA = "0xD636F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public bool UseInvSqr
	{
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xD63720", Offset = "0xD63720", VA = "0xD63720")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xD63728", Offset = "0xD63728", VA = "0xD63728")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public float Near
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xD63734", Offset = "0xD63734", VA = "0xD63734")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xD6373C", Offset = "0xD6373C", VA = "0xD6373C")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public float Far
	{
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xD63770", Offset = "0xD63770", VA = "0xD63770")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xD63778", Offset = "0xD63778", VA = "0xD63778")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public float VolumetricRadius
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xD637AC", Offset = "0xD637AC", VA = "0xD637AC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xD637B4", Offset = "0xD637B4", VA = "0xD637B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public float ReverbSend
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xD637E8", Offset = "0xD637E8", VA = "0xD637E8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xD637F0", Offset = "0xD637F0", VA = "0xD637F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000057")]
	public bool EnableRfl
	{
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xD63824", Offset = "0xD63824", VA = "0xD63824")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xD6382C", Offset = "0xD6382C", VA = "0xD6382C")]
		set
		{
		}
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xD63500", Offset = "0xD63500", VA = "0xD63500")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x643364", Offset = "0x643364")]
	private static void OnBeforeSceneLoadRuntimeMethod()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xD635F4", Offset = "0xD635F4", VA = "0xD635F4")]
	private static extern void ONSP_GetGlobalRoomReflectionValues(ref bool reflOn, ref bool reverbOn, ref float width, ref float height, ref float length);

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xD63838", Offset = "0xD63838", VA = "0xD63838")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xD639A8", Offset = "0xD639A8", VA = "0xD639A8")]
	private void Start()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xD639AC", Offset = "0xD639AC", VA = "0xD639AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xD638A0", Offset = "0xD638A0", VA = "0xD638A0")]
	public void SetParameters(ref AudioSource source)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xD63A70", Offset = "0xD63A70", VA = "0xD63A70")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xD63E60", Offset = "0xD63E60", VA = "0xD63E60")]
	private void OnDestroy()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0xD63574", Offset = "0xD63574", VA = "0xD63574")]
	private static extern int OSP_SetGlobalVoiceLimit(int VoiceLimit);

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xD63F38", Offset = "0xD63F38", VA = "0xD63F38")]
	public ONSPAudioSource()
	{
	}
}
[Token(Token = "0x20000F3")]
public class ONSPProfiler : MonoBehaviour
{
	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool profilerEnabled;

	[Token(Token = "0x4000539")]
	private const int DEFAULT_PORT = 2121;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int port;

	[Token(Token = "0x400053B")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0xD63F58", Offset = "0xD63F58", VA = "0xD63F58")]
	private void Start()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0xD63F64", Offset = "0xD63F64", VA = "0xD63F64")]
	private void Update()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0xD6401C", Offset = "0xD6401C", VA = "0xD6401C")]
	private static extern int ONSP_SetProfilerEnabled(bool enabled);

	[PreserveSig]
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0xD63F9C", Offset = "0xD63F9C", VA = "0xD63F9C")]
	private static extern int ONSP_SetProfilerPort(int port);

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0xD6409C", Offset = "0xD6409C", VA = "0xD6409C")]
	public ONSPProfiler()
	{
	}
}
[Token(Token = "0x20000F4")]
public class ONSPPropagationGeometry : MonoBehaviour
{
	[Token(Token = "0x20000F5")]
	private struct MeshMaterial
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MeshFilter meshFilter;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;
	}

	[Token(Token = "0x20000F6")]
	private struct TerrainMaterial
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Terrain terrain;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ONSPPropagationMaterial[] materials;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh[] treePrototypeMeshes;
	}

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string GeometryAssetDirectory;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string filePathRelative;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool fileEnabled;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool includeChildMeshes;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IntPtr geometryHandle;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int OSPSuccess;

	[Token(Token = "0x4000542")]
	public const string GEOMETRY_FILE_EXTENSION = "ovramesh";

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static int terrainDecimation;

	[Token(Token = "0x17000058")]
	public static string GeometryAssetPath
	{
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xD643A8", Offset = "0xD643A8", VA = "0xD643A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000059")]
	public string filePath
	{
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xD6443C", Offset = "0xD6443C", VA = "0xD6443C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0xD644BC", Offset = "0xD644BC", VA = "0xD644BC")]
	private static string GetPath(Transform current)
	{
		return null;
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0xD64624", Offset = "0xD64624", VA = "0xD64624")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0xD64628", Offset = "0xD64628", VA = "0xD64628")]
	private void CreatePropagationGeometry()
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0xD64C00", Offset = "0xD64C00", VA = "0xD64C00")]
	private void Update()
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xD64FAC", Offset = "0xD64FAC", VA = "0xD64FAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xD65128", Offset = "0xD65128", VA = "0xD65128")]
	private static void traverseMeshHierarchy(GameObject obj, ONSPPropagationMaterial[] currentMaterials, bool includeChildren, List<MeshMaterial> meshMaterials, List<TerrainMaterial> terrainMaterials, bool ignoreStatic, ref int ignoredMeshCount)
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xD658CC", Offset = "0xD658CC", VA = "0xD658CC")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal)
	{
		return default(int);
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xD65908", Offset = "0xD65908", VA = "0xD65908")]
	private int uploadMesh(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal, bool ignoreStatic, ref int ignoredMeshCount)
	{
		return default(int);
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xD67174", Offset = "0xD67174", VA = "0xD67174")]
	private static void uploadMeshFilter(List<Vector3> tempVertices, List<int> tempIndices, MeshGroup[] groups, float[] vertices, int[] indices, ref int vertexOffset, ref int indexOffset, ref int groupOffset, Mesh mesh, ONSPPropagationMaterial[] materials, Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xD66EB8", Offset = "0xD66EB8", VA = "0xD66EB8")]
	private static void updateCountsForMesh(ref int totalVertexCount, ref uint totalIndexCount, ref int totalFaceCount, ref int totalMaterialCount, Mesh mesh)
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xD64A18", Offset = "0xD64A18", VA = "0xD64A18")]
	public void UploadGeometry()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xD64820", Offset = "0xD64820", VA = "0xD64820")]
	public bool ReadFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xD677FC", Offset = "0xD677FC", VA = "0xD677FC")]
	public bool WriteToObj()
	{
		return default(bool);
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xD67C94", Offset = "0xD67C94", VA = "0xD67C94")]
	public ONSPPropagationGeometry()
	{
	}
}
[Token(Token = "0x20000F7")]
internal class ONSPPropagation
{
	[Token(Token = "0x20000F8")]
	public enum ovrAudioScalarType : uint
	{
		[Token(Token = "0x400054B")]
		Int8,
		[Token(Token = "0x400054C")]
		UInt8,
		[Token(Token = "0x400054D")]
		Int16,
		[Token(Token = "0x400054E")]
		UInt16,
		[Token(Token = "0x400054F")]
		Int32,
		[Token(Token = "0x4000550")]
		UInt32,
		[Token(Token = "0x4000551")]
		Int64,
		[Token(Token = "0x4000552")]
		UInt64,
		[Token(Token = "0x4000553")]
		Float16,
		[Token(Token = "0x4000554")]
		Float32,
		[Token(Token = "0x4000555")]
		Float64
	}

	[Token(Token = "0x20000F9")]
	public class ClientType
	{
		[Token(Token = "0x4000556")]
		public const uint OVRA_CLIENT_TYPE_NATIVE = 0u;

		[Token(Token = "0x4000557")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2016 = 1u;

		[Token(Token = "0x4000558")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_1 = 2u;

		[Token(Token = "0x4000559")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2017_2 = 3u;

		[Token(Token = "0x400055A")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2018_1 = 4u;

		[Token(Token = "0x400055B")]
		public const uint OVRA_CLIENT_TYPE_FMOD = 5u;

		[Token(Token = "0x400055C")]
		public const uint OVRA_CLIENT_TYPE_UNITY = 6u;

		[Token(Token = "0x400055D")]
		public const uint OVRA_CLIENT_TYPE_UE4 = 7u;

		[Token(Token = "0x400055E")]
		public const uint OVRA_CLIENT_TYPE_VST = 8u;

		[Token(Token = "0x400055F")]
		public const uint OVRA_CLIENT_TYPE_AAX = 9u;

		[Token(Token = "0x4000560")]
		public const uint OVRA_CLIENT_TYPE_TEST = 10u;

		[Token(Token = "0x4000561")]
		public const uint OVRA_CLIENT_TYPE_OTHER = 11u;

		[Token(Token = "0x4000562")]
		public const uint OVRA_CLIENT_TYPE_WWISE_UNKNOWN = 12u;

		[Token(Token = "0x4000563")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_1 = 13u;

		[Token(Token = "0x4000564")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2019_2 = 14u;

		[Token(Token = "0x4000565")]
		public const uint OVRA_CLIENT_TYPE_WWISE_2021_1 = 15u;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xAFE534", Offset = "0xAFE534", VA = "0xAFE534")]
		public ClientType()
		{
		}
	}

	[Token(Token = "0x20000FA")]
	public interface PropagationInterface
	{
		[Token(Token = "0x60003F6")]
		int SetPropagationQuality(float quality);

		[Token(Token = "0x60003F7")]
		int SetPropagationThreadAffinity(ulong cpuMask);

		[Token(Token = "0x60003F8")]
		int CreateAudioGeometry(out IntPtr geometry);

		[Token(Token = "0x60003F9")]
		int DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x60003FA")]
		int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount);

		[Token(Token = "0x60003FB")]
		int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x60003FC")]
		int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x60003FD")]
		int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60003FE")]
		int AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x60003FF")]
		int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x6000400")]
		int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000401")]
		int CreateAudioMaterial(out IntPtr material);

		[Token(Token = "0x6000402")]
		int DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000403")]
		int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000404")]
		int AudioMaterialReset(IntPtr material, MaterialProperty property);
	}

	[Token(Token = "0x20000FB")]
	public class UnityNativeInterface : PropagationInterface
	{
		[Token(Token = "0x4000566")]
		public const string strOSPS = "AudioPluginOculusSpatializer";

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x1700005B")]
		private IntPtr context
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xAFF270", Offset = "0xAFF270", VA = "0xAFF270")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000406")]
		[Address(RVA = "0xAFF2D0", Offset = "0xAFF2D0", VA = "0xAFF2D0")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000407")]
		[Address(RVA = "0xAFF360", Offset = "0xAFF360", VA = "0xAFF360")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xAFF3F0", Offset = "0xAFF3F0", VA = "0xAFF3F0", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000409")]
		[Address(RVA = "0xAFF414", Offset = "0xAFF414", VA = "0xAFF414")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xAFF4A4", Offset = "0xAFF4A4", VA = "0xAFF4A4", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600040B")]
		[Address(RVA = "0xAFF4C8", Offset = "0xAFF4C8", VA = "0xAFF4C8")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xAFF554", Offset = "0xAFF554", VA = "0xAFF554", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600040D")]
		[Address(RVA = "0xAFF578", Offset = "0xAFF578", VA = "0xAFF578")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xAFF5F8", Offset = "0xAFF5F8", VA = "0xAFF5F8", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600040F")]
		[Address(RVA = "0xAFF600", Offset = "0xAFF600", VA = "0xAFF600")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xAFF720", Offset = "0xAFF720", VA = "0xAFF720", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000411")]
		[Address(RVA = "0xAFF814", Offset = "0xAFF814", VA = "0xAFF814")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xAFF8AC", Offset = "0xAFF8AC", VA = "0xAFF8AC", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000413")]
		[Address(RVA = "0xAFF8B8", Offset = "0xAFF8B8", VA = "0xAFF8B8")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xAFF9E0", Offset = "0xAFF9E0", VA = "0xAFF9E0", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000415")]
		[Address(RVA = "0xAFF9EC", Offset = "0xAFF9EC", VA = "0xAFF9EC")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xAFFA98", Offset = "0xAFFA98", VA = "0xAFFA98", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xAFFAA4", Offset = "0xAFFAA4", VA = "0xAFFAA4")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xAFFB50", Offset = "0xAFFB50", VA = "0xAFFB50", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000419")]
		[Address(RVA = "0xAFFB5C", Offset = "0xAFFB5C", VA = "0xAFFB5C")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xAFFC08", Offset = "0xAFFC08", VA = "0xAFFC08", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600041B")]
		[Address(RVA = "0xAFFC14", Offset = "0xAFFC14", VA = "0xAFFC14")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xAFFCA0", Offset = "0xAFFCA0", VA = "0xAFFCA0", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600041D")]
		[Address(RVA = "0xAFFCC4", Offset = "0xAFFCC4", VA = "0xAFFCC4")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xAFFD44", Offset = "0xAFFD44", VA = "0xAFFD44", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600041F")]
		[Address(RVA = "0xAFFD4C", Offset = "0xAFFD4C", VA = "0xAFFD4C")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xAFFDF4", Offset = "0xAFFDF4", VA = "0xAFFDF4", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000421")]
		[Address(RVA = "0xAFFE00", Offset = "0xAFFE00", VA = "0xAFFE00")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xAFFEA8", Offset = "0xAFFEA8", VA = "0xAFFEA8", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000423")]
		[Address(RVA = "0xAFFEB8", Offset = "0xAFFEB8", VA = "0xAFFEB8")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xAFFF48", Offset = "0xAFFF48", VA = "0xAFFF48", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xAFFF54", Offset = "0xAFFF54", VA = "0xAFFF54")]
		public UnityNativeInterface()
		{
		}
	}

	[Token(Token = "0x20000FC")]
	public class WwisePluginInterface : PropagationInterface
	{
		[Token(Token = "0x4000568")]
		public const string strOSPS = "OculusSpatializerWwise";

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x1700005C")]
		private IntPtr context
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xAFFF9C", Offset = "0xAFFF9C", VA = "0xAFFF9C")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000427")]
		[Address(RVA = "0xAFFFFC", Offset = "0xAFFFFC", VA = "0xAFFFFC")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000428")]
		[Address(RVA = "0xB0008C", Offset = "0xB0008C", VA = "0xB0008C")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xB0011C", Offset = "0xB0011C", VA = "0xB0011C", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600042A")]
		[Address(RVA = "0xB00140", Offset = "0xB00140", VA = "0xB00140")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xB001D0", Offset = "0xB001D0", VA = "0xB001D0", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600042C")]
		[Address(RVA = "0xB001F4", Offset = "0xB001F4", VA = "0xB001F4")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xB00284", Offset = "0xB00284", VA = "0xB00284", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600042E")]
		[Address(RVA = "0xB002A8", Offset = "0xB002A8", VA = "0xB002A8")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xB00328", Offset = "0xB00328", VA = "0xB00328", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000430")]
		[Address(RVA = "0xB00330", Offset = "0xB00330", VA = "0xB00330")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xB00450", Offset = "0xB00450", VA = "0xB00450", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000432")]
		[Address(RVA = "0xB00544", Offset = "0xB00544", VA = "0xB00544")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xB005DC", Offset = "0xB005DC", VA = "0xB005DC", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000434")]
		[Address(RVA = "0xB005E8", Offset = "0xB005E8", VA = "0xB005E8")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xB00710", Offset = "0xB00710", VA = "0xB00710", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000436")]
		[Address(RVA = "0xB0071C", Offset = "0xB0071C", VA = "0xB0071C")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xB007C8", Offset = "0xB007C8", VA = "0xB007C8", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000438")]
		[Address(RVA = "0xB007D4", Offset = "0xB007D4", VA = "0xB007D4")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xB00880", Offset = "0xB00880", VA = "0xB00880", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600043A")]
		[Address(RVA = "0xB0088C", Offset = "0xB0088C", VA = "0xB0088C")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB00938", Offset = "0xB00938", VA = "0xB00938", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600043C")]
		[Address(RVA = "0xB00944", Offset = "0xB00944", VA = "0xB00944")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xB009D4", Offset = "0xB009D4", VA = "0xB009D4", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600043E")]
		[Address(RVA = "0xB009F8", Offset = "0xB009F8", VA = "0xB009F8")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xB00A78", Offset = "0xB00A78", VA = "0xB00A78", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000440")]
		[Address(RVA = "0xB00A80", Offset = "0xB00A80", VA = "0xB00A80")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xB00B28", Offset = "0xB00B28", VA = "0xB00B28", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000442")]
		[Address(RVA = "0xB00B34", Offset = "0xB00B34", VA = "0xB00B34")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xB00BDC", Offset = "0xB00BDC", VA = "0xB00BDC", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000444")]
		[Address(RVA = "0xB00BEC", Offset = "0xB00BEC", VA = "0xB00BEC")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xB00C7C", Offset = "0xB00C7C", VA = "0xB00C7C", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xB00C88", Offset = "0xB00C88", VA = "0xB00C88")]
		public WwisePluginInterface()
		{
		}
	}

	[Token(Token = "0x20000FD")]
	public class FMODPluginInterface : PropagationInterface
	{
		[Token(Token = "0x400056A")]
		public const string strOSPS = "OculusSpatializerFMOD";

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr context_;

		[Token(Token = "0x1700005D")]
		private IntPtr context
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xAFE53C", Offset = "0xAFE53C", VA = "0xAFE53C")]
			get
			{
				return default(IntPtr);
			}
		}

		[PreserveSig]
		[Token(Token = "0x6000448")]
		[Address(RVA = "0xAFE59C", Offset = "0xAFE59C", VA = "0xAFE59C")]
		public static extern int ovrAudio_GetPluginContext(out IntPtr context, uint clientType);

		[PreserveSig]
		[Token(Token = "0x6000449")]
		[Address(RVA = "0xAFE62C", Offset = "0xAFE62C", VA = "0xAFE62C")]
		private static extern int ovrAudio_SetPropagationQuality(IntPtr context, float quality);

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xAFE6BC", Offset = "0xAFE6BC", VA = "0xAFE6BC", Slot = "4")]
		public int SetPropagationQuality(float quality)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600044B")]
		[Address(RVA = "0xAFE6E0", Offset = "0xAFE6E0", VA = "0xAFE6E0")]
		private static extern int ovrAudio_SetPropagationThreadAffinity(IntPtr context, ulong cpuMask);

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xAFE770", Offset = "0xAFE770", VA = "0xAFE770", Slot = "5")]
		public int SetPropagationThreadAffinity(ulong cpuMask)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600044D")]
		[Address(RVA = "0xAFE794", Offset = "0xAFE794", VA = "0xAFE794")]
		private static extern int ovrAudio_CreateAudioGeometry(IntPtr context, out IntPtr geometry);

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xAFE824", Offset = "0xAFE824", VA = "0xAFE824", Slot = "6")]
		public int CreateAudioGeometry(out IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600044F")]
		[Address(RVA = "0xAFE848", Offset = "0xAFE848", VA = "0xAFE848")]
		private static extern int ovrAudio_DestroyAudioGeometry(IntPtr geometry);

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xAFE8C8", Offset = "0xAFE8C8", VA = "0xAFE8C8", Slot = "7")]
		public int DestroyAudioGeometry(IntPtr geometry)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000451")]
		[Address(RVA = "0xAFE8D0", Offset = "0xAFE8D0", VA = "0xAFE8D0")]
		private static extern int ovrAudio_AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, UIntPtr verticesBytesOffset, UIntPtr vertexCount, UIntPtr vertexStride, ovrAudioScalarType vertexType, int[] indices, UIntPtr indicesByteOffset, UIntPtr indexCount, ovrAudioScalarType indexType, MeshGroup[] groups, UIntPtr groupCount);

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xAFE9F0", Offset = "0xAFE9F0", VA = "0xAFE9F0", Slot = "8")]
		public int AudioGeometryUploadMeshArrays(IntPtr geometry, float[] vertices, int vertexCount, int[] indices, int indexCount, MeshGroup[] groups, int groupCount)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000453")]
		[Address(RVA = "0xAFEAE4", Offset = "0xAFEAE4", VA = "0xAFEAE4")]
		private static extern int ovrAudio_AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4);

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xAFEB7C", Offset = "0xAFEB7C", VA = "0xAFEB7C", Slot = "9")]
		public int AudioGeometrySetTransform(IntPtr geometry, float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000455")]
		[Address(RVA = "0xAFEB88", Offset = "0xAFEB88", VA = "0xAFEB88")]
		private static extern int ovrAudio_AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4);

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xAFECB0", Offset = "0xAFECB0", VA = "0xAFECB0", Slot = "10")]
		public int AudioGeometryGetTransform(IntPtr geometry, out float[] matrix4x4)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000457")]
		[Address(RVA = "0xAFECBC", Offset = "0xAFECBC", VA = "0xAFECBC")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xAFED68", Offset = "0xAFED68", VA = "0xAFED68", Slot = "11")]
		public int AudioGeometryWriteMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000459")]
		[Address(RVA = "0xAFED74", Offset = "0xAFED74", VA = "0xAFED74")]
		private static extern int ovrAudio_AudioGeometryReadMeshFile(IntPtr geometry, string filePath);

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xAFEE20", Offset = "0xAFEE20", VA = "0xAFEE20", Slot = "12")]
		public int AudioGeometryReadMeshFile(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600045B")]
		[Address(RVA = "0xAFEE2C", Offset = "0xAFEE2C", VA = "0xAFEE2C")]
		private static extern int ovrAudio_AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath);

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xAFEED8", Offset = "0xAFEED8", VA = "0xAFEED8", Slot = "13")]
		public int AudioGeometryWriteMeshFileObj(IntPtr geometry, string filePath)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600045D")]
		[Address(RVA = "0xAFEEE4", Offset = "0xAFEEE4", VA = "0xAFEEE4")]
		private static extern int ovrAudio_CreateAudioMaterial(IntPtr context, out IntPtr material);

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xAFEF74", Offset = "0xAFEF74", VA = "0xAFEF74", Slot = "15")]
		public int CreateAudioMaterial(out IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600045F")]
		[Address(RVA = "0xAFEF98", Offset = "0xAFEF98", VA = "0xAFEF98")]
		private static extern int ovrAudio_DestroyAudioMaterial(IntPtr material);

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xAFF018", Offset = "0xAFF018", VA = "0xAFF018", Slot = "16")]
		public int DestroyAudioMaterial(IntPtr material)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000461")]
		[Address(RVA = "0xAFF020", Offset = "0xAFF020", VA = "0xAFF020")]
		private static extern int ovrAudio_AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value);

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xAFF0C8", Offset = "0xAFF0C8", VA = "0xAFF0C8", Slot = "17")]
		public int AudioMaterialSetFrequency(IntPtr material, MaterialProperty property, float frequency, float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000463")]
		[Address(RVA = "0xAFF0D4", Offset = "0xAFF0D4", VA = "0xAFF0D4")]
		private static extern int ovrAudio_AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value);

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xAFF17C", Offset = "0xAFF17C", VA = "0xAFF17C", Slot = "14")]
		public int AudioMaterialGetFrequency(IntPtr material, MaterialProperty property, float frequency, out float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x6000465")]
		[Address(RVA = "0xAFF18C", Offset = "0xAFF18C", VA = "0xAFF18C")]
		private static extern int ovrAudio_AudioMaterialReset(IntPtr material, MaterialProperty property);

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xAFF21C", Offset = "0xAFF21C", VA = "0xAFF21C", Slot = "18")]
		public int AudioMaterialReset(IntPtr material, MaterialProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xAFF228", Offset = "0xAFF228", VA = "0xAFF228")]
		public FMODPluginInterface()
		{
		}
	}

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PropagationInterface CachedInterface;

	[Token(Token = "0x1700005A")]
	public static PropagationInterface Interface
	{
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xD640AC", Offset = "0xD640AC", VA = "0xD640AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xD64118", Offset = "0xD64118", VA = "0xD64118")]
	private static PropagationInterface FindInterface()
	{
		return null;
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xD643A0", Offset = "0xD643A0", VA = "0xD643A0")]
	public ONSPPropagation()
	{
	}
}
[Token(Token = "0x20000FE")]
public sealed class ONSPPropagationMaterial : MonoBehaviour
{
	[Token(Token = "0x20000FF")]
	public enum Preset
	{
		[Token(Token = "0x4000572")]
		Custom,
		[Token(Token = "0x4000573")]
		AcousticTile,
		[Token(Token = "0x4000574")]
		Brick,
		[Token(Token = "0x4000575")]
		BrickPainted,
		[Token(Token = "0x4000576")]
		Carpet,
		[Token(Token = "0x4000577")]
		CarpetHeavy,
		[Token(Token = "0x4000578")]
		CarpetHeavyPadded,
		[Token(Token = "0x4000579")]
		CeramicTile,
		[Token(Token = "0x400057A")]
		Concrete,
		[Token(Token = "0x400057B")]
		ConcreteRough,
		[Token(Token = "0x400057C")]
		ConcreteBlock,
		[Token(Token = "0x400057D")]
		ConcreteBlockPainted,
		[Token(Token = "0x400057E")]
		Curtain,
		[Token(Token = "0x400057F")]
		Foliage,
		[Token(Token = "0x4000580")]
		Glass,
		[Token(Token = "0x4000581")]
		GlassHeavy,
		[Token(Token = "0x4000582")]
		Grass,
		[Token(Token = "0x4000583")]
		Gravel,
		[Token(Token = "0x4000584")]
		GypsumBoard,
		[Token(Token = "0x4000585")]
		PlasterOnBrick,
		[Token(Token = "0x4000586")]
		PlasterOnConcreteBlock,
		[Token(Token = "0x4000587")]
		Soil,
		[Token(Token = "0x4000588")]
		SoundProof,
		[Token(Token = "0x4000589")]
		Snow,
		[Token(Token = "0x400058A")]
		Steel,
		[Token(Token = "0x400058B")]
		Water,
		[Token(Token = "0x400058C")]
		WoodThin,
		[Token(Token = "0x400058D")]
		WoodThick,
		[Token(Token = "0x400058E")]
		WoodFloor,
		[Token(Token = "0x400058F")]
		WoodOnConcrete
	}

	[Serializable]
	[Token(Token = "0x2000100")]
	public sealed class Point
	{
		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frequency;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float data;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xB00CD0", Offset = "0xB00CD0", VA = "0xB00CD0")]
		public Point(float frequency = 0f, float data = 0f)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xB00D08", Offset = "0xB00D08", VA = "0xB00D08")]
		public static implicit operator Point(Vector2 v)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xB00D74", Offset = "0xB00D74", VA = "0xB00D74")]
		public static implicit operator Vector2(Point point)
		{
			return default(Vector2);
		}
	}

	[Serializable]
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x63F064", Offset = "0x63F064")]
	public sealed class Spectrum
	{
		[Serializable]
		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F09C", Offset = "0x63F09C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Point, float> <>9__3_0;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Point, float> <>9__3_1;

			[Token(Token = "0x6000494")]
			[Address(RVA = "0xB05B54", Offset = "0xB05B54", VA = "0xB05B54")]
			public <>c()
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0xB05B5C", Offset = "0xB05B5C", VA = "0xB05B5C")]
			internal float <get_Item>b__3_0(Point p)
			{
				return default(float);
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0xB05B74", Offset = "0xB05B74", VA = "0xB05B74")]
			internal float <get_Item>b__3_1(Point p)
			{
				return default(float);
			}
		}

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int selection;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Point> points;

		[Token(Token = "0x1700005F")]
		public float Item
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xB00D8C", Offset = "0xB00D8C", VA = "0xB00D8C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xB011E0", Offset = "0xB011E0", VA = "0xB011E0")]
		public Spectrum()
		{
		}
	}

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public IntPtr materialHandle;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640E30", Offset = "0x640E30")]
	public Spectrum absorption;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640E68", Offset = "0x640E68")]
	public Spectrum transmission;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x640EA0", Offset = "0x640EA0")]
	public Spectrum scattering;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Preset preset_;

	[Token(Token = "0x1700005E")]
	public Preset preset
	{
		[Token(Token = "0x6000468")]
		[Address(RVA = "0xD67D7C", Offset = "0xD67D7C", VA = "0xD67D7C")]
		get
		{
			return default(Preset);
		}
		[Token(Token = "0x6000469")]
		[Address(RVA = "0xD67D84", Offset = "0xD67D84", VA = "0xD67D84")]
		set
		{
		}
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0xD67DAC", Offset = "0xD67DAC", VA = "0xD67DAC")]
	private void Start()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0xD67670", Offset = "0xD67670", VA = "0xD67670")]
	public void StartInternal()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0xD6841C", Offset = "0xD6841C", VA = "0xD6841C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0xD68420", Offset = "0xD68420", VA = "0xD68420")]
	public void DestroyInternal()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0xD67DB0", Offset = "0xD67DB0", VA = "0xD67DB0")]
	public void UploadMaterial()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0xD66FE0", Offset = "0xD66FE0", VA = "0xD66FE0")]
	public void SetPreset(Preset preset)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xD6850C", Offset = "0xD6850C", VA = "0xD6850C")]
	private static void AcousticTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xD689CC", Offset = "0xD689CC", VA = "0xD689CC")]
	private static void Brick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xD68E90", Offset = "0xD68E90", VA = "0xD68E90")]
	private static void BrickPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xD69350", Offset = "0xD69350", VA = "0xD69350")]
	private static void Carpet(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xD69824", Offset = "0xD69824", VA = "0xD69824")]
	private static void CarpetHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xD69CE4", Offset = "0xD69CE4", VA = "0xD69CE4")]
	private static void CarpetHeavyPadded(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xD6A1A4", Offset = "0xD6A1A4", VA = "0xD6A1A4")]
	private static void CeramicTile(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xD6A66C", Offset = "0xD6A66C", VA = "0xD6A66C")]
	private static void Concrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xD6AB34", Offset = "0xD6AB34", VA = "0xD6AB34")]
	private static void ConcreteRough(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xD6B000", Offset = "0xD6B000", VA = "0xD6B000")]
	private static void ConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xD6B4C8", Offset = "0xD6B4C8", VA = "0xD6B4C8")]
	private static void ConcreteBlockPainted(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xD6B998", Offset = "0xD6B998", VA = "0xD6B998")]
	private static void Curtain(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xD6BE58", Offset = "0xD6BE58", VA = "0xD6BE58")]
	private static void Foliage(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xD6C324", Offset = "0xD6C324", VA = "0xD6C324")]
	private static void Glass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0xD6C7D4", Offset = "0xD6C7D4", VA = "0xD6C7D4")]
	private static void GlassHeavy(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0xD6CC90", Offset = "0xD6CC90", VA = "0xD6CC90")]
	private static void Grass(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0xD6D038", Offset = "0xD6D038", VA = "0xD6D038")]
	private static void Gravel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0xD6D3D8", Offset = "0xD6D3D8", VA = "0xD6D3D8")]
	private static void GypsumBoard(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0xD6D8A8", Offset = "0xD6D8A8", VA = "0xD6D8A8")]
	private static void PlasterOnBrick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0xD6DD74", Offset = "0xD6DD74", VA = "0xD6DD74")]
	private static void PlasterOnConcreteBlock(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0xD6E238", Offset = "0xD6E238", VA = "0xD6E238")]
	private static void Soil(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0xD6E5E4", Offset = "0xD6E5E4", VA = "0xD6E5E4")]
	private static void SoundProof(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0xD6E768", Offset = "0xD6E768", VA = "0xD6E768")]
	private static void Snow(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0xD6EB04", Offset = "0xD6EB04", VA = "0xD6EB04")]
	private static void Steel(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0xD6EFB4", Offset = "0xD6EFB4", VA = "0xD6EFB4")]
	private static void Water(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xD6F478", Offset = "0xD6F478", VA = "0xD6F478")]
	private static void WoodThin(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xD6F930", Offset = "0xD6F930", VA = "0xD6F930")]
	private static void WoodThick(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xD6FDF0", Offset = "0xD6FDF0", VA = "0xD6FDF0")]
	private static void WoodFloor(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xD702B8", Offset = "0xD702B8", VA = "0xD702B8")]
	private static void WoodOnConcrete(ref ONSPPropagationMaterial material)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xD7077C", Offset = "0xD7077C", VA = "0xD7077C")]
	public ONSPPropagationMaterial()
	{
	}
}
[Token(Token = "0x2000103")]
public class ONSPPropagationSettings : MonoBehaviour
{
	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float quality;

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xFDFFAC", Offset = "0xFDFFAC", VA = "0xFDFFAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0xFE007C", Offset = "0xFE007C", VA = "0xFE007C")]
	public ONSPPropagationSettings()
	{
	}
}
[Token(Token = "0x2000104")]
public sealed class ONSPSettings : ScriptableObject
{
	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int voiceLimit;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ONSPSettings instance;

	[Token(Token = "0x17000060")]
	public static ONSPSettings Instance
	{
		[Token(Token = "0x6000499")]
		[Address(RVA = "0xFE06BC", Offset = "0xFE06BC", VA = "0xFE06BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xFE07FC", Offset = "0xFE07FC", VA = "0xFE07FC")]
	public ONSPSettings()
	{
	}
}
[Token(Token = "0x2000105")]
public class ONSPVersion : MonoBehaviour
{
	[Token(Token = "0x400059A")]
	public const string strONSPS = "AudioPluginOculusSpatializer";

	[PreserveSig]
	[Token(Token = "0x600049B")]
	[Address(RVA = "0xFE080C", Offset = "0xFE080C", VA = "0xFE080C")]
	private static extern void ONSP_GetVersion(ref int Major, ref int Minor, ref int Patch);

	[Token(Token = "0x600049C")]
	[Address(RVA = "0xFE08A4", Offset = "0xFE08A4", VA = "0xFE08A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0xFE09C4", Offset = "0xFE09C4", VA = "0xFE09C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0xFE09C8", Offset = "0xFE09C8", VA = "0xFE09C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0xFE09CC", Offset = "0xFE09CC", VA = "0xFE09CC")]
	public ONSPVersion()
	{
	}
}
[Token(Token = "0x2000106")]
public class OculusSpatializerUnity : MonoBehaviour
{
	[Token(Token = "0x2000107")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data);

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float particleSize;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float particleOffset;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject room;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float[] dims;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] coefs;

	[Token(Token = "0x40005A9")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3[] points;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] normals;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem sys;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x40005AF")]
	private const string strOSP = "AudioPluginOculusSpatializer";

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0xFE8D60", Offset = "0xFE8D60", VA = "0xFE8D60")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0xFE8BF0", Offset = "0xFE8BF0", VA = "0xFE8BF0")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x643378", Offset = "0x643378")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0xFE8D68", Offset = "0xFE8D68", VA = "0xFE8D68")]
	private void Start()
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0xFE8EAC", Offset = "0xFE8EAC", VA = "0xFE8EAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0xFE8FA8", Offset = "0xFE8FA8", VA = "0xFE8FA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0xFE98C4", Offset = "0xFE98C4", VA = "0xFE98C4")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0xFE8E18", Offset = "0xFE8E18", VA = "0xFE8E18")]
	private static extern int OSP_Unity_AssignRaycastCallback(AudioRaycastCallback callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xFE8F18", Offset = "0xFE8F18", VA = "0xFE8F18")]
	private static extern int OSP_Unity_AssignRaycastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xFE962C", Offset = "0xFE962C", VA = "0xFE962C")]
	private static extern int OSP_Unity_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xFE96AC", Offset = "0xFE96AC", VA = "0xFE96AC")]
	private static extern int OSP_Unity_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xFE9734", Offset = "0xFE9734", VA = "0xFE9734")]
	private static extern int OSP_Unity_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0xFE97BC", Offset = "0xFE97BC", VA = "0xFE97BC")]
	private static extern int OSP_Unity_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x60004AC")]
	[Address(RVA = "0xFE983C", Offset = "0xFE983C", VA = "0xFE983C")]
	private static extern int OSP_Unity_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0xFEA58C", Offset = "0xFEA58C", VA = "0xFEA58C")]
	private static extern int OSP_Unity_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position);

	[PreserveSig]
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0xFEA634", Offset = "0xFEA634", VA = "0xFEA634")]
	private static extern int OSP_Unity_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0xFEA6DC", Offset = "0xFEA6DC", VA = "0xFEA6DC")]
	public OculusSpatializerUnity()
	{
	}
}
[Token(Token = "0x2000108")]
public struct ReflectionSnapshot
{
	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float fadeTime;
}
[Token(Token = "0x2000109")]
public class ONSPReflectionZone : MonoBehaviour
{
	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixerSnapshot mixerSnapshot;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fadeTime;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Stack<ReflectionSnapshot> snapshotList;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ReflectionSnapshot currentSnapshot;

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0xFE008C", Offset = "0xFE008C", VA = "0xFE008C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0xFE0090", Offset = "0xFE0090", VA = "0xFE0090")]
	private void Update()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0xFE0094", Offset = "0xFE0094", VA = "0xFE0094")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0xFE020C", Offset = "0xFE020C", VA = "0xFE020C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0xFE00E0", Offset = "0xFE00E0", VA = "0xFE00E0")]
	private bool CheckForAudioListener(GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0xFE0178", Offset = "0xFE0178", VA = "0xFE0178")]
	private void PushCurrentMixerShapshot()
	{
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0xFE0258", Offset = "0xFE0258", VA = "0xFE0258")]
	private void PopCurrentMixerSnapshot()
	{
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0xFE02F8", Offset = "0xFE02F8", VA = "0xFE02F8")]
	private void SetReflectionValues()
	{
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0xFE048C", Offset = "0xFE048C", VA = "0xFE048C")]
	private void SetReflectionValues(ref ReflectionSnapshot mss)
	{
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0xFE0620", Offset = "0xFE0620", VA = "0xFE0620")]
	public ONSPReflectionZone()
	{
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x200010A")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x17000061")]
		public bool Highlight
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xC7AAC4", Offset = "0xC7AAC4", VA = "0xC7AAC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xC7AACC", Offset = "0xC7AACC", VA = "0xC7AACC")]
			set
			{
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xC7AAD8", Offset = "0xC7AAD8", VA = "0xC7AAD8")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xC7ACA0", Offset = "0xC7ACA0", VA = "0xC7ACA0", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xC7ACC8", Offset = "0xC7ACC8", VA = "0xC7ACC8", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xC7ACF0", Offset = "0xC7ACF0", VA = "0xC7ACF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xC7ABA0", Offset = "0xC7ABA0", VA = "0xC7ABA0")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xC7AF88", Offset = "0xC7AF88", VA = "0xC7AF88")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x17000062")]
		public bool InRange
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xC7D770", Offset = "0xC7D770", VA = "0xC7D770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xC7D778", Offset = "0xC7D778", VA = "0xC7D778")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool Targeted
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xC7D8F0", Offset = "0xC7D8F0", VA = "0xC7D8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xC7D8F8", Offset = "0xC7D8F8", VA = "0xC7D8F8")]
			set
			{
			}
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xC7D904", Offset = "0xC7D904", VA = "0xC7D904", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xC7D784", Offset = "0xC7D784", VA = "0xC7D784")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xC7DAD0", Offset = "0xC7DAD0", VA = "0xC7DAD0")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x63F0AC", Offset = "0x63F0AC")]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x17000064")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xC7DAD8", Offset = "0xC7DAD8", VA = "0xC7DAD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xC7DAE0", Offset = "0xC7DAE0", VA = "0xC7DAE0")]
			set
			{
			}
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xC7DAFC", Offset = "0xC7DAFC", VA = "0xC7DAFC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xC7DD2C", Offset = "0xC7DD2C", VA = "0xC7DD2C", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xC7E5EC", Offset = "0xC7E5EC", VA = "0xC7E5EC", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xC7EA64", Offset = "0xC7EA64", VA = "0xC7EA64", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xC7ED24", Offset = "0xC7ED24", VA = "0xC7ED24")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xC7DF80", Offset = "0xC7DF80", VA = "0xC7DF80")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xC7EE14", Offset = "0xC7EE14", VA = "0xC7EE14")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xC7F210", Offset = "0xC7F210", VA = "0xC7F210", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xC7F228", Offset = "0xC7F228", VA = "0xC7F228", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xC7F230", Offset = "0xC7F230", VA = "0xC7F230")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xC80B14", Offset = "0xC80B14", VA = "0xC80B14")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xC80BCC", Offset = "0xC80BCC", VA = "0xC80BCC")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xC80C80", Offset = "0xC80C80", VA = "0xC80C80")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x200010F")]
		public enum CrosshairState
		{
			[Token(Token = "0x40005D8")]
			Disabled,
			[Token(Token = "0x40005D9")]
			Enabled,
			[Token(Token = "0x40005DA")]
			Targeted
		}

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xC80C88", Offset = "0xC80C88", VA = "0xC80C88")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xC7DA34", Offset = "0xC7DA34", VA = "0xC7DA34")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xC80CEC", Offset = "0xC80CEC", VA = "0xC80CEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xC80D34", Offset = "0xC80D34", VA = "0xC80D34")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xB0DDA4", Offset = "0xB0DDA4", VA = "0xB0DDA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xB0DE90", Offset = "0xB0DE90", VA = "0xB0DE90")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xB0DE9C", Offset = "0xB0DE9C", VA = "0xB0DE9C")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xB0DEA8", Offset = "0xB0DEA8", VA = "0xB0DEA8")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xC70264", Offset = "0xC70264", VA = "0xC70264")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xC702B8", Offset = "0xC702B8", VA = "0xC702B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xC70624", Offset = "0xC70624", VA = "0xC70624")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xC70728", Offset = "0xC70728", VA = "0xC70728")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xC702BC", Offset = "0xC702BC", VA = "0xC702BC")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xC7082C", Offset = "0xC7082C", VA = "0xC7082C")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x2000113")]
		public enum ContactTest
		{
			[Token(Token = "0x40005EC")]
			PerpenTest,
			[Token(Token = "0x40005ED")]
			BackwardsPress
		}

		[Token(Token = "0x40005DE")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x40005DF")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private InteractableState _currentButtonState;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x17000065")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xC708E4", Offset = "0xC708E4", VA = "0xC708E4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000066")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xC708EC", Offset = "0xC708EC", VA = "0xC708EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xC708F8", Offset = "0xC708F8", VA = "0xC708F8", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xC709E4", Offset = "0xC709E4", VA = "0xC709E4")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xC70BE4", Offset = "0xC70BE4", VA = "0xC70BE4", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xC71184", Offset = "0xC71184", VA = "0xC71184")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xC7109C", Offset = "0xC7109C", VA = "0xC7109C")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xC71230", Offset = "0xC71230", VA = "0xC71230")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xC712B4", Offset = "0xC712B4", VA = "0xC712B4")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xC71340", Offset = "0xC71340", VA = "0xC71340")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641028", Offset = "0x641028")]
		private Collider <Collider>k__BackingField;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641038", Offset = "0x641038")]
		private Interactable <ParentInteractable>k__BackingField;

		[Token(Token = "0x17000067")]
		public Collider Collider
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xC71574", Offset = "0xC71574", VA = "0xC71574", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6433D8", Offset = "0x6433D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xC7157C", Offset = "0xC7157C", VA = "0xC7157C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6433E8", Offset = "0x6433E8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xC71584", Offset = "0xC71584", VA = "0xC71584", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6433F8", Offset = "0x6433F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0xC7158C", Offset = "0xC7158C", VA = "0xC7158C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643408", Offset = "0x643408")]
			private set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xC71594", Offset = "0xC71594", VA = "0xC71594", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xC715E4", Offset = "0xC715E4", VA = "0xC715E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xC71668", Offset = "0xC71668", VA = "0xC71668")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public interface ColliderZone
	{
		[Token(Token = "0x1700006A")]
		Collider Collider
		{
			[Token(Token = "0x60004FE")]
			get;
		}

		[Token(Token = "0x1700006B")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x60004FF")]
			get;
		}

		[Token(Token = "0x1700006C")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000500")]
			get;
		}
	}
	[Token(Token = "0x2000116")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xC70B44", Offset = "0xC70B44", VA = "0xC70B44")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x2000117")]
	public enum InteractionType
	{
		[Token(Token = "0x40005F6")]
		Enter,
		[Token(Token = "0x40005F7")]
		Stay,
		[Token(Token = "0x40005F8")]
		Exit
	}
	[Token(Token = "0x2000118")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x2000119")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x400060A")]
			Mesh,
			[Token(Token = "0x400060B")]
			Skeleton,
			[Token(Token = "0x400060C")]
			Both
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F10C", Offset = "0x63F10C")]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x17000078")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000523")]
				[Address(RVA = "0xAFD204", Offset = "0xAFD204", VA = "0xAFD204", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000525")]
				[Address(RVA = "0xAFD24C", Offset = "0xAFD24C", VA = "0xAFD24C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000520")]
			[Address(RVA = "0xAFCFA4", Offset = "0xAFCFA4", VA = "0xAFCFA4")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0xAFCFD0", Offset = "0xAFCFD0", VA = "0xAFCFD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000522")]
			[Address(RVA = "0xAFCFD4", Offset = "0xAFCFD4", VA = "0xAFCFD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xAFD20C", Offset = "0xAFD20C", VA = "0xAFD20C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005F9")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641068", Offset = "0x641068")]
		private static HandsManager <Instance>k__BackingField;

		[Token(Token = "0x1700006D")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xD56FD4", Offset = "0xD56FD4", VA = "0xD56FD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xD5700C", Offset = "0xD5700C", VA = "0xD5700C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xD57074", Offset = "0xD57074", VA = "0xD57074")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0xD570AC", Offset = "0xD570AC", VA = "0xD570AC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0xD57114", Offset = "0xD57114", VA = "0xD57114")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xD5714C", Offset = "0xD5714C", VA = "0xD5714C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0xD571B4", Offset = "0xD571B4", VA = "0xD571B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xD571EC", Offset = "0xD571EC", VA = "0xD571EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0xD57254", Offset = "0xD57254", VA = "0xD57254")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0xD5728C", Offset = "0xD5728C", VA = "0xD5728C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xD572F4", Offset = "0xD572F4", VA = "0xD572F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xD57328", Offset = "0xD57328", VA = "0xD57328")]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xD5738C", Offset = "0xD5738C", VA = "0xD5738C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xD573C0", Offset = "0xD573C0", VA = "0xD573C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0xD57424", Offset = "0xD57424", VA = "0xD57424")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0xD57458", Offset = "0xD57458", VA = "0xD57458")]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0xD574BC", Offset = "0xD574BC", VA = "0xD574BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0xD574F0", Offset = "0xD574F0", VA = "0xD574F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0xD57554", Offset = "0xD57554", VA = "0xD57554")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0xD57588", Offset = "0xD57588", VA = "0xD57588")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public static HandsManager Instance
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0xD575EC", Offset = "0xD575EC", VA = "0xD575EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643418", Offset = "0x643418")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0xD57638", Offset = "0xD57638", VA = "0xD57638")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643428", Offset = "0x643428")]
			private set
			{
			}
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xD57688", Offset = "0xD57688", VA = "0xD57688")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xD57A30", Offset = "0xD57A30", VA = "0xD57A30")]
		private void Update()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xD579C4", Offset = "0xD579C4", VA = "0xD579C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643438", Offset = "0x643438")]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xD57AB8", Offset = "0xD57AB8", VA = "0xD57AB8")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xD57B9C", Offset = "0xD57B9C", VA = "0xD57B9C")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xD57D7C", Offset = "0xD57D7C", VA = "0xD57D7C")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xD57FB8", Offset = "0xD57FB8", VA = "0xD57FB8")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xD58144", Offset = "0xD58144", VA = "0xD58144")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xAFD254", Offset = "0xAFD254", VA = "0xAFD254")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x1700007A")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0xD582C0", Offset = "0xD582C0", VA = "0xD582C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xD582C8", Offset = "0xD582C8", VA = "0xD582C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xD582D0", Offset = "0xD582D0", VA = "0xD582D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0xD582D8", Offset = "0xD582D8", VA = "0xD582D8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0xD582E0", Offset = "0xD582E0", VA = "0xD582E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6434E8", Offset = "0x6434E8")]
			add
			{
			}
			[Token(Token = "0x600052B")]
			[Address(RVA = "0xD58380", Offset = "0xD58380", VA = "0xD58380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6434F8", Offset = "0x6434F8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0xD58490", Offset = "0xD58490", VA = "0xD58490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643508", Offset = "0x643508")]
			add
			{
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0xD58530", Offset = "0xD58530", VA = "0xD58530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643518", Offset = "0x643518")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xD58640", Offset = "0xD58640", VA = "0xD58640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643528", Offset = "0x643528")]
			add
			{
			}
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xD586E0", Offset = "0xD586E0", VA = "0xD586E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643538", Offset = "0x643538")]
			remove
			{
			}
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xD58420", Offset = "0xD58420", VA = "0xD58420", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xD585D0", Offset = "0xD585D0", VA = "0xD585D0", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xD58780", Offset = "0xD58780", VA = "0xD58780", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000533")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xD587F0", Offset = "0xD587F0", VA = "0xD587F0", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xD5891C", Offset = "0xD5891C", VA = "0xD5891C", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xD58A48", Offset = "0xD58A48", VA = "0xD58A48")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000618")]
		None,
		[Token(Token = "0x4000619")]
		Proximity,
		[Token(Token = "0x400061A")]
		Contact,
		[Token(Token = "0x400061B")]
		Action
	}
	[Token(Token = "0x200011E")]
	public enum InteractableState
	{
		[Token(Token = "0x400061D")]
		Default,
		[Token(Token = "0x400061E")]
		ProximityState,
		[Token(Token = "0x400061F")]
		ContactState,
		[Token(Token = "0x4000620")]
		ActionState
	}
	[Token(Token = "0x200011F")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xD58B88", Offset = "0xD58B88", VA = "0xD58B88")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x1700007E")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xD58A94", Offset = "0xD58A94", VA = "0xD58A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xD58850", Offset = "0xD58850", VA = "0xD58850")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xD5897C", Offset = "0xD5897C", VA = "0xD5897C")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xD58AF8", Offset = "0xD58AF8", VA = "0xD58AF8")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F11C", Offset = "0x63F11C")]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x1700007F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000546")]
				[Address(RVA = "0xAFD73C", Offset = "0xAFD73C", VA = "0xAFD73C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0xAFD784", Offset = "0xAFD784", VA = "0xAFD784", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0xAFD2A0", Offset = "0xAFD2A0", VA = "0xAFD2A0")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000543")]
			[Address(RVA = "0xAFD2CC", Offset = "0xAFD2CC", VA = "0xAFD2CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0xAFD33C", Offset = "0xAFD33C", VA = "0xAFD33C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0xAFD2E8", Offset = "0xAFD2E8", VA = "0xAFD2E8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0xAFD744", Offset = "0xAFD744", VA = "0xAFD744", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xD59874", Offset = "0xD59874", VA = "0xD59874")]
		private void Awake()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xD598F0", Offset = "0xD598F0", VA = "0xD598F0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643548", Offset = "0x643548")]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xD59978", Offset = "0xD59978", VA = "0xD59978")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xD59A60", Offset = "0xD59A60", VA = "0xD59A60")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x17000081")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xD59A68", Offset = "0xD59A68", VA = "0xD59A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xD59BE4", Offset = "0xD59BE4", VA = "0xD59BE4")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xD59C8C", Offset = "0xD59C8C", VA = "0xD59C8C")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xD59D34", Offset = "0xD59D34", VA = "0xD59D34")]
		private void Update()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xD59FE0", Offset = "0xD59FE0", VA = "0xD59FE0")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xD5A028", Offset = "0xD5A028", VA = "0xD5A028")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xD5A2BC", Offset = "0xD5A2BC", VA = "0xD5A2BC")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xD5A408", Offset = "0xD5A408", VA = "0xD5A408")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F12C", Offset = "0x63F12C")]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000562")]
				[Address(RVA = "0xAFCD20", Offset = "0xAFCD20", VA = "0xAFCD20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000564")]
				[Address(RVA = "0xAFCD68", Offset = "0xAFCD68", VA = "0xAFCD68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xAFC90C", Offset = "0xAFC90C", VA = "0xAFC90C")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0xAFC938", Offset = "0xAFC938", VA = "0xAFC938", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000561")]
			[Address(RVA = "0xAFC93C", Offset = "0xAFC93C", VA = "0xAFC93C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000563")]
			[Address(RVA = "0xAFCD28", Offset = "0xAFCD28", VA = "0xAFCD28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000639")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x17000082")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xC7F638", Offset = "0xC7F638", VA = "0xC7F638", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x17000083")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xC7F640", Offset = "0xC7F640", VA = "0xC7F640", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x17000084")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xC7F648", Offset = "0xC7F648", VA = "0xC7F648", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public override bool EnableState
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xC7F650", Offset = "0xC7F650", VA = "0xC7F650", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0xC7F67C", Offset = "0xC7F67C", VA = "0xC7F67C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xC7F6B8", Offset = "0xC7F6B8", VA = "0xC7F6B8", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xC7F758", Offset = "0xC7F758", VA = "0xC7F758")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6435F8", Offset = "0x6435F8")]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xC7F7C4", Offset = "0xC7F7C4", VA = "0xC7F7C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xC7FA64", Offset = "0xC7FA64", VA = "0xC7FA64")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xC7FBF0", Offset = "0xC7FBF0", VA = "0xC7FBF0")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xC7FCE8", Offset = "0xC7FCE8", VA = "0xC7FCE8", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xC7FFE0", Offset = "0xC7FFE0", VA = "0xC7FFE0", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xC7FFE4", Offset = "0xC7FFE4", VA = "0xC7FFE4", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xC7FFE8", Offset = "0xC7FFE8", VA = "0xC7FFE8")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6410F8", Offset = "0x6410F8")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641108", Offset = "0x641108")]
		private bool <ToolActivateState>k__BackingField;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641118", Offset = "0x641118")]
		private float <SphereRadius>k__BackingField;

		[Token(Token = "0x17000088")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xC80000", Offset = "0xC80000", VA = "0xC80000", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6436A8", Offset = "0x6436A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xC80008", Offset = "0xC80008", VA = "0xC80008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6436B8", Offset = "0x6436B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public bool EnableState
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0xC80010", Offset = "0xC80010", VA = "0xC80010", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xC8002C", Offset = "0xC8002C", VA = "0xC8002C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0xC8004C", Offset = "0xC8004C", VA = "0xC8004C", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6436C8", Offset = "0x6436C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0xC80054", Offset = "0xC80054", VA = "0xC80054", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6436D8", Offset = "0x6436D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public float SphereRadius
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0xC80060", Offset = "0xC80060", VA = "0xC80060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6436E8", Offset = "0x6436E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xC80068", Offset = "0xC80068", VA = "0xC80068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6436F8", Offset = "0x6436F8")]
			private set
			{
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xC80070", Offset = "0xC80070", VA = "0xC80070")]
		private void Awake()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xC800B8", Offset = "0xC800B8", VA = "0xC800B8", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xC800BC", Offset = "0xC800BC", VA = "0xC800BC")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x2000127")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x400064C")]
		None = 0,
		[Token(Token = "0x400064D")]
		Ray = 1,
		[Token(Token = "0x400064E")]
		Poke = 4,
		[Token(Token = "0x400064F")]
		All = -1
	}
	[Token(Token = "0x2000128")]
	public enum ToolInputState
	{
		[Token(Token = "0x4000651")]
		Inactive,
		[Token(Token = "0x4000652")]
		PrimaryInputDown,
		[Token(Token = "0x4000653")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000654")]
		PrimaryInputUp
	}
	[Token(Token = "0x2000129")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xD58A50", Offset = "0xD58A50", VA = "0xD58A50")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x200012A")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641128", Offset = "0x641128")]
		private bool <IsRightHandedTool>k__BackingField;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641138", Offset = "0x641138")]
		private Vector3 <Velocity>k__BackingField;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641148", Offset = "0x641148")]
		private Vector3 <InteractionPosition>k__BackingField;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x1700008C")]
		public Transform ToolTransform
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0xD58C28", Offset = "0xD58C28", VA = "0xD58C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xD58C30", Offset = "0xD58C30", VA = "0xD58C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643708", Offset = "0x643708")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0xD58C38", Offset = "0xD58C38", VA = "0xD58C38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643718", Offset = "0x643718")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000574")]
			get;
		}

		[Token(Token = "0x1700008F")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x6000575")]
			get;
		}

		[Token(Token = "0x17000090")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x6000576")]
			get;
		}

		[Token(Token = "0x17000091")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xD58C44", Offset = "0xD58C44", VA = "0xD58C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643728", Offset = "0x643728")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xD58C50", Offset = "0xD58C50", VA = "0xD58C50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643738", Offset = "0x643738")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xD58C5C", Offset = "0xD58C5C", VA = "0xD58C5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643748", Offset = "0x643748")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xD58C68", Offset = "0xD58C68", VA = "0xD58C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643758", Offset = "0x643758")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public abstract bool EnableState
		{
			[Token(Token = "0x600057F")]
			get;
			[Token(Token = "0x6000580")]
			set;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xD58C74", Offset = "0xD58C74", VA = "0xD58C74")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x600057D")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x600057E")]
		public abstract void DeFocus();

		[Token(Token = "0x6000581")]
		public abstract void Initialize();

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xD58C7C", Offset = "0xD58C7C", VA = "0xD58C7C")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xD58CC8", Offset = "0xD58CC8", VA = "0xD58CC8")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xD58D1C", Offset = "0xD58D1C", VA = "0xD58D1C", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xD58FB0", Offset = "0xD58FB0", VA = "0xD58FB0", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xD5972C", Offset = "0xD5972C", VA = "0xD5972C")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public interface InteractableToolView
	{
		[Token(Token = "0x17000094")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x6000587")]
			get;
		}

		[Token(Token = "0x17000095")]
		bool EnableState
		{
			[Token(Token = "0x6000589")]
			get;
			[Token(Token = "0x600058A")]
			set;
		}

		[Token(Token = "0x17000096")]
		bool ToolActivateState
		{
			[Token(Token = "0x600058B")]
			get;
			[Token(Token = "0x600058C")]
			set;
		}

		[Token(Token = "0x6000588")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x200012C")]
	public class PinchStateModule
	{
		[Token(Token = "0x200012D")]
		private enum PinchState
		{
			[Token(Token = "0x4000665")]
			None,
			[Token(Token = "0x4000666")]
			PinchDown,
			[Token(Token = "0x4000667")]
			PinchStay,
			[Token(Token = "0x4000668")]
			PinchUp
		}

		[Token(Token = "0x4000661")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x17000097")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xB0DEB0", Offset = "0xB0DEB0", VA = "0xB0DEB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000098")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xB0DF38", Offset = "0xB0DF38", VA = "0xB0DF38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xB0DFC0", Offset = "0xB0DFC0", VA = "0xB0DFC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xB0E048", Offset = "0xB0E048", VA = "0xB0E048")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xB0E074", Offset = "0xB0E074", VA = "0xB0E074")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000669")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x400066A")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x400066B")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x400066C")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x400066D")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641168", Offset = "0x641168")]
		private float _coneAngleDegrees;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x1700009A")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xB0F09C", Offset = "0xB0F09C", VA = "0xB0F09C", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x1700009B")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0xB0F0A4", Offset = "0xB0F0A4", VA = "0xB0F0A4", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x1700009C")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xB0F10C", Offset = "0xB0F10C", VA = "0xB0F10C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public override bool EnableState
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0xB0F114", Offset = "0xB0F114", VA = "0xB0F114", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xB0F158", Offset = "0xB0F158", VA = "0xB0F158", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xB0F1CC", Offset = "0xB0F1CC", VA = "0xB0F1CC", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xB0F22C", Offset = "0xB0F22C", VA = "0xB0F22C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xB0F2D0", Offset = "0xB0F2D0", VA = "0xB0F2D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xB0F588", Offset = "0xB0F588", VA = "0xB0F588")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xB0F610", Offset = "0xB0F610", VA = "0xB0F610", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xB0F9B8", Offset = "0xB0F9B8", VA = "0xB0F9B8")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xB0FAC8", Offset = "0xB0FAC8", VA = "0xB0FAC8")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xB0FBEC", Offset = "0xB0FBEC", VA = "0xB0FBEC")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xB0FEF0", Offset = "0xB0FEF0", VA = "0xB0FEF0")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xB10284", Offset = "0xB10284", VA = "0xB10284", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xB10354", Offset = "0xB10354", VA = "0xB10354", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xB10388", Offset = "0xB10388", VA = "0xB10388")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000679")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x400067A")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6411DC", Offset = "0x6411DC")]
		private InteractableTool <InteractableTool>k__BackingField;

		[Token(Token = "0x1700009E")]
		public bool EnableState
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0xB0F13C", Offset = "0xB0F13C", VA = "0xB0F13C", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xB0F174", Offset = "0xB0F174", VA = "0xB0F174", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xB10458", Offset = "0xB10458", VA = "0xB10458", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0xB0F54C", Offset = "0xB0F54C", VA = "0xB0F54C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xB1069C", Offset = "0xB1069C", VA = "0xB1069C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643768", Offset = "0x643768")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xB106A4", Offset = "0xB106A4", VA = "0xB106A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643778", Offset = "0x643778")]
			set
			{
			}
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xB10460", Offset = "0xB10460", VA = "0xB10460")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xB102B8", Offset = "0xB102B8", VA = "0xB102B8", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xB106AC", Offset = "0xB106AC", VA = "0xB106AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xB10920", Offset = "0xB10920", VA = "0xB10920")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xB10A10", Offset = "0xB10A10", VA = "0xB10A10")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000A1")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xC7F250", Offset = "0xC7F250", VA = "0xC7F250")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xC7F258", Offset = "0xC7F258", VA = "0xC7F258")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xC7F2E0", Offset = "0xC7F2E0", VA = "0xC7F2E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xC7F2E8", Offset = "0xC7F2E8", VA = "0xC7F2E8")]
			set
			{
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xC7F354", Offset = "0xC7F354", VA = "0xC7F354")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xC7F608", Offset = "0xC7F608", VA = "0xC7F608")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xC7F618", Offset = "0xC7F618", VA = "0xC7F618")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xC7F628", Offset = "0xC7F628", VA = "0xC7F628")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xC7B070", Offset = "0xC7B070", VA = "0xC7B070")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xC7B074", Offset = "0xC7B074", VA = "0xC7B074")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xC7B0AC", Offset = "0xC7B0AC", VA = "0xC7B0AC")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xC7B0E4", Offset = "0xC7B0E4", VA = "0xC7B0E4")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xC7B11C", Offset = "0xC7B11C", VA = "0xC7B11C")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xC7B154", Offset = "0xC7B154", VA = "0xC7B154")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xC7B18C", Offset = "0xC7B18C", VA = "0xC7B18C")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xC7B1C4", Offset = "0xC7B1C4", VA = "0xC7B1C4")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xC7B238", Offset = "0xC7B238", VA = "0xC7B238")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xC7B2A8", Offset = "0xC7B2A8", VA = "0xC7B2A8")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xC7B2B0", Offset = "0xC7B2B0", VA = "0xC7B2B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xC7B2B4", Offset = "0xC7B2B4", VA = "0xC7B2B4")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xC7B26C", Offset = "0xC7B26C", VA = "0xC7B26C")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xC7B2F4", Offset = "0xC7B2F4", VA = "0xC7B2F4")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F14C", Offset = "0x63F14C")]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000A3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0xB03B10", Offset = "0xB03B10", VA = "0xB03B10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005CE")]
				[Address(RVA = "0xB03B58", Offset = "0xB03B58", VA = "0xB03B58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xB03934", Offset = "0xB03934", VA = "0xB03934")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xB03960", Offset = "0xB03960", VA = "0xB03960", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xB03964", Offset = "0xB03964", VA = "0xB03964", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xB03B18", Offset = "0xB03B18", VA = "0xB03B18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400068A")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x400068B")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xB0DA18", Offset = "0xB0DA18", VA = "0xB0DA18")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xB0DAB8", Offset = "0xB0DAB8", VA = "0xB0DAB8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xB0DCEC", Offset = "0xB0DCEC", VA = "0xB0DCEC")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xB0DC80", Offset = "0xB0DC80", VA = "0xB0DC80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643788", Offset = "0x643788")]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xB0DD38", Offset = "0xB0DD38", VA = "0xB0DD38")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x2000136")]
		public enum SelectionState
		{
			[Token(Token = "0x40006A1")]
			Off,
			[Token(Token = "0x40006A2")]
			Selected,
			[Token(Token = "0x40006A3")]
			Highlighted
		}

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000A5")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xB13360", Offset = "0xB13360", VA = "0xB13360")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xB13368", Offset = "0xB13368", VA = "0xB13368")]
			set
			{
			}
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xB134EC", Offset = "0xB134EC", VA = "0xB134EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xB136B4", Offset = "0xB136B4", VA = "0xB136B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xB133F0", Offset = "0xB133F0", VA = "0xB133F0")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xB137A0", Offset = "0xB137A0", VA = "0xB137A0")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x2000138")]
		public enum SegmentType
		{
			[Token(Token = "0x40006B2")]
			Straight,
			[Token(Token = "0x40006B3")]
			LeftTurn,
			[Token(Token = "0x40006B4")]
			RightTurn,
			[Token(Token = "0x40006B5")]
			Switch
		}

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x40006AA")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x40006AB")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6412BC", Offset = "0x6412BC")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000A6")]
		public float StartDistance
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xAF4FCC", Offset = "0xAF4FCC", VA = "0xAF4FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643838", Offset = "0x643838")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xAF4FD4", Offset = "0xAF4FD4", VA = "0xAF4FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643848", Offset = "0x643848")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public float GridSize
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xAF4FDC", Offset = "0xAF4FDC", VA = "0xAF4FDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xAF4FE4", Offset = "0xAF4FE4", VA = "0xAF4FE4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public int SubDivCount
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xAF4FEC", Offset = "0xAF4FEC", VA = "0xAF4FEC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xAF4FF4", Offset = "0xAF4FF4", VA = "0xAF4FF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public SegmentType Type
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xAF4FFC", Offset = "0xAF4FFC", VA = "0xAF4FFC")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000AA")]
		public Pose EndPose
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xAF5004", Offset = "0xAF5004", VA = "0xAF5004")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public float Radius
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xAF5360", Offset = "0xAF5360", VA = "0xAF5360")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AC")]
		public float SegmentLength
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xAF506C", Offset = "0xAF506C", VA = "0xAF506C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xAF5370", Offset = "0xAF5370", VA = "0xAF5370")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xAF5388", Offset = "0xAF5388", VA = "0xAF5388")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xAF50AC", Offset = "0xAF50AC", VA = "0xAF50AC")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xAF538C", Offset = "0xAF538C", VA = "0xAF538C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xAF5390", Offset = "0xAF5390", VA = "0xAF5390")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xAF53F8", Offset = "0xAF53F8", VA = "0xAF53F8")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xAF5CC0", Offset = "0xAF5CC0", VA = "0xAF5CC0")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xAF5F4C", Offset = "0xAF5F4C", VA = "0xAF5F4C")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F15C", Offset = "0x63F15C")]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0xB052E4", Offset = "0xB052E4", VA = "0xB052E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0xB0532C", Offset = "0xB0532C", VA = "0xB0532C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xAF6840", Offset = "0xAF6840", VA = "0xAF6840")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xB0517C", Offset = "0xB0517C", VA = "0xB0517C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xB05180", Offset = "0xB05180", VA = "0xB05180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0xB052EC", Offset = "0xB052EC", VA = "0xB052EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006B6")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x40006B7")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xAF5FF8", Offset = "0xAF5FF8", VA = "0xAF5FF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xAF60A0", Offset = "0xAF60A0", VA = "0xAF60A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xAF6150", Offset = "0xAF6150", VA = "0xAF6150")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xAF62C8", Offset = "0xAF62C8", VA = "0xAF62C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xAF6490", Offset = "0xAF6490", VA = "0xAF6490")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xAF6578", Offset = "0xAF6578", VA = "0xAF6578")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xAF677C", Offset = "0xAF677C", VA = "0xAF677C")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xAF668C", Offset = "0xAF668C", VA = "0xAF668C")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xAF66A0", Offset = "0xAF66A0", VA = "0xAF66A0")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xAF67D4", Offset = "0xAF67D4", VA = "0xAF67D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643858", Offset = "0x643858")]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xAF686C", Offset = "0xAF686C", VA = "0xAF686C")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000AF")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xAF691C", Offset = "0xAF691C", VA = "0xAF691C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xAF692C", Offset = "0xAF692C", VA = "0xAF692C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xAF6934", Offset = "0xAF6934", VA = "0xAF6934", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xAF6C78", Offset = "0xAF6C78", VA = "0xAF6C78")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x40006CF")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x40006D0")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6413BC", Offset = "0x6413BC")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000B0")]
		public float Distance
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xAF6D70", Offset = "0xAF6D70", VA = "0xAF6D70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643908", Offset = "0x643908")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xAF6D78", Offset = "0xAF6D78", VA = "0xAF6D78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643918", Offset = "0x643918")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public float Scale
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xAF6D80", Offset = "0xAF6D80", VA = "0xAF6D80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000600")]
			[Address(RVA = "0xAF6D88", Offset = "0xAF6D88", VA = "0xAF6D88")]
			set
			{
			}
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xAF6930", Offset = "0xAF6930", VA = "0xAF6930", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xAF6D90", Offset = "0xAF6D90", VA = "0xAF6D90")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xAF697C", Offset = "0xAF697C", VA = "0xAF697C")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xAF6BA0", Offset = "0xAF6BA0", VA = "0xAF6BA0")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x6000605")]
		public abstract void UpdatePosition();

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xAF6CE4", Offset = "0xAF6CE4", VA = "0xAF6CE4")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F16C", Offset = "0x63F16C")]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000614")]
				[Address(RVA = "0xB05558", Offset = "0xB05558", VA = "0xB05558", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000616")]
				[Address(RVA = "0xB055A0", Offset = "0xB055A0", VA = "0xB055A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0xAF733C", Offset = "0xAF733C", VA = "0xAF733C")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0xB05334", Offset = "0xB05334", VA = "0xB05334", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0xB05338", Offset = "0xB05338", VA = "0xB05338", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0xB05560", Offset = "0xB05560", VA = "0xB05560", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xAF6F30", Offset = "0xAF6F30", VA = "0xAF6F30")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xAF6F7C", Offset = "0xAF6F7C", VA = "0xAF6F7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xAF7084", Offset = "0xAF7084", VA = "0xAF7084")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xAF71E4", Offset = "0xAF71E4", VA = "0xAF71E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xAF70E0", Offset = "0xAF70E0", VA = "0xAF70E0")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xAF72C0", Offset = "0xAF72C0", VA = "0xAF72C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643928", Offset = "0x643928")]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xAF7368", Offset = "0xAF7368", VA = "0xAF7368")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xAF7414", Offset = "0xAF7414", VA = "0xAF7414")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xAF7474", Offset = "0xAF7474", VA = "0xAF7474")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x2000140")]
		private enum EngineSoundState
		{
			[Token(Token = "0x400070D")]
			Start,
			[Token(Token = "0x400070E")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x400070F")]
			Stop
		}

		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F17C", Offset = "0x63F17C")]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000629")]
				[Address(RVA = "0xB057C8", Offset = "0xB057C8", VA = "0xB057C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0xB05810", Offset = "0xB05810", VA = "0xB05810", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000626")]
			[Address(RVA = "0xAF77CC", Offset = "0xAF77CC", VA = "0xAF77CC")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0xB055A8", Offset = "0xB055A8", VA = "0xB055A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0xB055AC", Offset = "0xB055AC", VA = "0xB055AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0xB057D0", Offset = "0xB057D0", VA = "0xB057D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006EF")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x40006F0")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x40006F1")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x40006F2")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x64141C", Offset = "0x64141C")]
		protected float _initialSpeed;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xAF74D0", Offset = "0xAF74D0", VA = "0xAF74D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xAF7624", Offset = "0xAF7624", VA = "0xAF7624")]
		private void Update()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xAF7630", Offset = "0xAF7630", VA = "0xAF7630", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xAF7780", Offset = "0xAF7780", VA = "0xAF7780")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xAF75A4", Offset = "0xAF75A4", VA = "0xAF75A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6439D8", Offset = "0x6439D8")]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xAF77F8", Offset = "0xAF77F8", VA = "0xAF77F8")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xAF771C", Offset = "0xAF771C", VA = "0xAF771C")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xAF7A14", Offset = "0xAF7A14", VA = "0xAF7A14")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xAF7B50", Offset = "0xAF7B50", VA = "0xAF7B50")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xAF7A80", Offset = "0xAF7A80", VA = "0xAF7A80")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xAF7BBC", Offset = "0xAF7BBC", VA = "0xAF7BBC")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xAF7BDC", Offset = "0xAF7BDC", VA = "0xAF7BDC")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xAF7C68", Offset = "0xAF7C68", VA = "0xAF7C68")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xAF7D20", Offset = "0xAF7D20", VA = "0xAF7D20")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xAF7D30", Offset = "0xAF7D30", VA = "0xAF7D30")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000B6")]
		public float TrackLength
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0xAF7D98", Offset = "0xAF7D98", VA = "0xAF7D98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0xAF7DA0", Offset = "0xAF7DA0", VA = "0xAF7DA0")]
			private set
			{
			}
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xAF7DA8", Offset = "0xAF7DA8", VA = "0xAF7DA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xAF6E10", Offset = "0xAF6E10", VA = "0xAF6E10")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xAF7DAC", Offset = "0xAF7DAC", VA = "0xAF7DAC")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xAF7FAC", Offset = "0xAF7FAC", VA = "0xAF7FAC")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xAF80A8", Offset = "0xAF80A8", VA = "0xAF80A8")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class Pose
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xB0ECC8", Offset = "0xB0ECC8", VA = "0xB0ECC8")]
		public Pose()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xB0ED0C", Offset = "0xB0ED0C", VA = "0xB0ED0C")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F18C", Offset = "0x63F18C")]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000641")]
				[Address(RVA = "0xB0598C", Offset = "0xB0598C", VA = "0xB0598C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000643")]
				[Address(RVA = "0xB059D4", Offset = "0xB059D4", VA = "0xB059D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0xAF8964", Offset = "0xAF8964", VA = "0xAF8964")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xB05818", Offset = "0xB05818", VA = "0xB05818", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xB0581C", Offset = "0xB0581C", VA = "0xB0581C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0xB05994", Offset = "0xB05994", VA = "0xB05994", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F19C", Offset = "0x63F19C")]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0xB05AA4", Offset = "0xB05AA4", VA = "0xB05AA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0xB05AEC", Offset = "0xB05AEC", VA = "0xB05AEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xAF8A20", Offset = "0xAF8A20", VA = "0xAF8A20")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xB059DC", Offset = "0xB059DC", VA = "0xB059DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xB059E0", Offset = "0xB059E0", VA = "0xB059E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xB05AAC", Offset = "0xB05AAC", VA = "0xB05AAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000722")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x641604", Offset = "0x641604")]
		private bool <IsMoving>k__BackingField;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000B7")]
		public bool IsMoving
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0xAF874C", Offset = "0xAF874C", VA = "0xAF874C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643A88", Offset = "0x643A88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xAF8754", Offset = "0xAF8754", VA = "0xAF8754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643A98", Offset = "0x643A98")]
			private set
			{
			}
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xAF8760", Offset = "0xAF8760", VA = "0xAF8760")]
		private void Start()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xAF879C", Offset = "0xAF879C", VA = "0xAF879C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xAF8880", Offset = "0xAF8880", VA = "0xAF8880")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xAF88E8", Offset = "0xAF88E8", VA = "0xAF88E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643AA8", Offset = "0x643AA8")]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xAF8990", Offset = "0xAF8990", VA = "0xAF8990")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643B08", Offset = "0x643B08")]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xAF8A4C", Offset = "0xAF8A4C", VA = "0xAF8A4C")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xAF8AB8", Offset = "0xAF8AB8", VA = "0xAF8AB8")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x2000147")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xAF8AC0", Offset = "0xAF8AC0", VA = "0xAF8AC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xAF8B24", Offset = "0xAF8B24", VA = "0xAF8B24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xAF8C08", Offset = "0xAF8C08", VA = "0xAF8C08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xAF8D40", Offset = "0xAF8D40", VA = "0xAF8D40")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xAF8DBC", Offset = "0xAF8DBC", VA = "0xAF8DBC")]
		private void Update()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xAF8E98", Offset = "0xAF8E98", VA = "0xAF8E98")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x2000148")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x400073F")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x4000740")]
		EUDT_OverlayQuad,
		[Token(Token = "0x4000741")]
		EUDT_None,
		[Token(Token = "0x4000742")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x2000149")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F1AC", Offset = "0x63F1AC")]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000663")]
				[Address(RVA = "0xB015E8", Offset = "0xB015E8", VA = "0xB015E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000665")]
				[Address(RVA = "0xB01630", Offset = "0xB01630", VA = "0xB01630", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0xB013D4", Offset = "0xB013D4", VA = "0xB013D4")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0xB01400", Offset = "0xB01400", VA = "0xB01400", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0xB01404", Offset = "0xB01404", VA = "0xB01404", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xB015F0", Offset = "0xB015F0", VA = "0xB015F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000744")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000745")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000746")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x641644", Offset = "0x641644")]
		public GameObject mainCamera;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x64167C", Offset = "0x64167C")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xFE7278", Offset = "0xFE7278", VA = "0xFE7278")]
		private void Start()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xFE7AA0", Offset = "0xFE7AA0", VA = "0xFE7AA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xFE7BE8", Offset = "0xFE7BE8", VA = "0xFE7BE8")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xFE7D18", Offset = "0xFE7D18", VA = "0xFE7D18")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xFE7E48", Offset = "0xFE7E48", VA = "0xFE7E48")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xFE7BBC", Offset = "0xFE7BBC", VA = "0xFE7BBC")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xFE7F28", Offset = "0xFE7F28", VA = "0xFE7F28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643C08", Offset = "0x643C08")]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xFE7F94", Offset = "0xFE7F94", VA = "0xFE7F94")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xFE76B8", Offset = "0xFE76B8", VA = "0xFE76B8")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xFE80E8", Offset = "0xFE80E8", VA = "0xFE80E8")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xFE7FC8", Offset = "0xFE7FC8", VA = "0xFE7FC8")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xFE8400", Offset = "0xFE8400", VA = "0xFE8400")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xFE84F0", Offset = "0xFE84F0", VA = "0xFE84F0")]
		public OVROverlaySample()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xFE8574", Offset = "0xFE8574", VA = "0xFE8574")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643C68", Offset = "0x643C68")]
		private void <Start>b__24_0(Toggle t)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xFE85CC", Offset = "0xFE85CC", VA = "0xFE85CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643C78", Offset = "0x643C78")]
		private void <Start>b__24_1(Toggle t)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xFE8624", Offset = "0xFE8624", VA = "0xFE8624")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x643C88", Offset = "0x643C88")]
		private void <Start>b__24_2(Toggle t)
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x63F1BC", Offset = "0x63F1BC")]
	public class Hand : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F21C", Offset = "0x63F21C")]
		private sealed class <>c
		{
			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Collider, bool> <>9__28_0;

			[Token(Token = "0x6000673")]
			[Address(RVA = "0xAFCDD0", Offset = "0xAFCDD0", VA = "0xAFCDD0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0xAFCDD8", Offset = "0xAFCDD8", VA = "0xAFCDD8")]
			internal bool <Start>b__28_0(Collider childCollider)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400075E")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x400075F")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x4000760")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x4000761")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000762")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x4000763")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000764")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000765")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000766")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000767")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000768")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xC80D3C", Offset = "0xC80D3C", VA = "0xC80D3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xC80D90", Offset = "0xC80D90", VA = "0xC80D90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xC81204", Offset = "0xC81204", VA = "0xC81204")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xC812F0", Offset = "0xC812F0", VA = "0xC812F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xC81454", Offset = "0xC81454", VA = "0xC81454")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xC8175C", Offset = "0xC8175C", VA = "0xC8175C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xC81854", Offset = "0xC81854", VA = "0xC81854")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xC819B4", Offset = "0xC819B4", VA = "0xC819B4")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xC814EC", Offset = "0xC814EC", VA = "0xC814EC")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xC81540", Offset = "0xC81540", VA = "0xC81540")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xC810A8", Offset = "0xC810A8", VA = "0xC810A8")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xC81AF0", Offset = "0xC81AF0", VA = "0xC81AF0")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x200014D")]
	public enum HandPoseId
	{
		[Token(Token = "0x400077D")]
		Default,
		[Token(Token = "0x400077E")]
		Generic,
		[Token(Token = "0x400077F")]
		PingPongBall,
		[Token(Token = "0x4000780")]
		Controller
	}
	[Token(Token = "0x200014E")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000BE")]
		public bool AllowPointing
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0xC81B08", Offset = "0xC81B08", VA = "0xC81B08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0xC81B10", Offset = "0xC81B10", VA = "0xC81B10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0xC81B18", Offset = "0xC81B18", VA = "0xC81B18")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xC81B20", Offset = "0xC81B20", VA = "0xC81B20")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xAF4C3C", Offset = "0xAF4C3C", VA = "0xAF4C3C")]
		private void Update()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xAF4F24", Offset = "0xAF4F24", VA = "0xAF4F24")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xAF4F80", Offset = "0xAF4F80", VA = "0xAF4F80")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xAF4FC4", Offset = "0xAF4FC4", VA = "0xAF4FC4")]
		public TouchController()
		{
		}
	}
}
namespace Oculus.Spatializer.Propagation
{
	[Token(Token = "0x2000150")]
	public enum FaceType : uint
	{
		[Token(Token = "0x4000788")]
		TRIANGLES,
		[Token(Token = "0x4000789")]
		QUADS
	}
	[Token(Token = "0x2000151")]
	public enum MaterialProperty : uint
	{
		[Token(Token = "0x400078B")]
		ABSORPTION,
		[Token(Token = "0x400078C")]
		TRANSMISSION,
		[Token(Token = "0x400078D")]
		SCATTERING
	}
	[Token(Token = "0x2000152")]
	public struct MeshGroup
	{
		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public UIntPtr indexOffset;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public UIntPtr faceCount;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FaceType faceType;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public IntPtr material;
	}
}
namespace Oculus.Avatar
{
	[Token(Token = "0x2000153")]
	public static class AvatarLogger
	{
		[Token(Token = "0x4000792")]
		public const string LogAvatar = "[Avatars] - ";

		[Token(Token = "0x4000793")]
		public const string Tab = "    ";

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xC6F860", Offset = "0xC6F860", VA = "0xC6F860")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643CE8", Offset = "0x643CE8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643CE8", Offset = "0x643CE8")]
		public static void Log(string logMsg)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xC6F8F0", Offset = "0xC6F8F0", VA = "0xC6F8F0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643D48", Offset = "0x643D48")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643D48", Offset = "0x643D48")]
		public static void Log(string logMsg, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xC6F990", Offset = "0xC6F990", VA = "0xC6F990")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643DA8", Offset = "0x643DA8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643DA8", Offset = "0x643DA8")]
		public static void LogWarning(string logMsg)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xC6FA20", Offset = "0xC6FA20", VA = "0xC6FA20")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643E08", Offset = "0x643E08")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643E08", Offset = "0x643E08")]
		public static void LogError(string logMsg)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xC6FAB0", Offset = "0xC6FAB0", VA = "0xC6FAB0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643E68", Offset = "0x643E68")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x643E68", Offset = "0x643E68")]
		public static void LogError(string logMsg, UnityEngine.Object context)
		{
		}
	}
	[Token(Token = "0x2000154")]
	public class CAPI
	{
		[Token(Token = "0x2000155")]
		public delegate void LoggingDelegate(IntPtr str);

		[Token(Token = "0x2000156")]
		public enum Result
		{
			[Token(Token = "0x400079F")]
			Success = 0,
			[Token(Token = "0x40007A0")]
			Failure = -1000,
			[Token(Token = "0x40007A1")]
			Failure_InvalidParameter = -1001,
			[Token(Token = "0x40007A2")]
			Failure_NotInitialized = -1002,
			[Token(Token = "0x40007A3")]
			Failure_InvalidOperation = -1003,
			[Token(Token = "0x40007A4")]
			Failure_Unsupported = -1004,
			[Token(Token = "0x40007A5")]
			Failure_NotYetImplemented = -1005,
			[Token(Token = "0x40007A6")]
			Failure_OperationFailed = -1006,
			[Token(Token = "0x40007A7")]
			Failure_InsufficientSize = -1007
		}

		[Token(Token = "0x2000157")]
		private static class OVRP_1_30_0
		{
			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly Version version;

			[PreserveSig]
			[Token(Token = "0x6000716")]
			[Address(RVA = "0xAFB8EC", Offset = "0xAFB8EC", VA = "0xAFB8EC")]
			public static extern Result ovrp_SendEvent2(string name, string param, string source);
		}

		[Token(Token = "0x4000794")]
		private const string LibFile = "ovravatarloader";

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IntPtr nativeVisemeData;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IntPtr nativeGazeTargetsData;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IntPtr nativeAvatarLightsData;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IntPtr DebugLineCountData;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float[] scratchBufferFloat;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject debugLineGo;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string SDKRuntimePrefix;

		[Token(Token = "0x400079C")]
		private const string ovrPluginDLL = "OVRPlugin";

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Version ovrPluginVersion;

		[PreserveSig]
		[Token(Token = "0x6000682")]
		[Address(RVA = "0xC716D4", Offset = "0xC716D4", VA = "0xC716D4")]
		public static extern void ovrAvatar_InitializeAndroidUnity(string appID);

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xC71764", Offset = "0xC71764", VA = "0xC71764")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xC7197C", Offset = "0xC7197C", VA = "0xC7197C")]
		public static void Shutdown()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000685")]
		[Address(RVA = "0xC71A64", Offset = "0xC71A64", VA = "0xC71A64")]
		public static extern void ovrAvatar_Shutdown();

		[PreserveSig]
		[Token(Token = "0x6000686")]
		[Address(RVA = "0xC71AD4", Offset = "0xC71AD4", VA = "0xC71AD4")]
		public static extern IntPtr ovrAvatarMessage_Pop();

		[PreserveSig]
		[Token(Token = "0x6000687")]
		[Address(RVA = "0xC71B48", Offset = "0xC71B48", VA = "0xC71B48")]
		public static extern ovrAvatarMessageType ovrAvatarMessage_GetType(IntPtr msg);

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xC71BC8", Offset = "0xC71BC8", VA = "0xC71BC8")]
		public static ovrAvatarMessage_AvatarSpecification ovrAvatarMessage_GetAvatarSpecification(IntPtr msg)
		{
			return default(ovrAvatarMessage_AvatarSpecification);
		}

		[PreserveSig]
		[Token(Token = "0x6000689")]
		[Address(RVA = "0xC71D0C", Offset = "0xC71D0C", VA = "0xC71D0C")]
		private static extern IntPtr ovrAvatarMessage_GetAvatarSpecification_Native(IntPtr msg);

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xC71D8C", Offset = "0xC71D8C", VA = "0xC71D8C")]
		public static ovrAvatarMessage_AssetLoaded ovrAvatarMessage_GetAssetLoaded(IntPtr msg)
		{
			return default(ovrAvatarMessage_AssetLoaded);
		}

		[PreserveSig]
		[Token(Token = "0x600068B")]
		[Address(RVA = "0xC71ED0", Offset = "0xC71ED0", VA = "0xC71ED0")]
		private static extern IntPtr ovrAvatarMessage_GetAssetLoaded_Native(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x600068C")]
		[Address(RVA = "0xC71F50", Offset = "0xC71F50", VA = "0xC71F50")]
		public static extern void ovrAvatarMessage_Free(IntPtr msg);

		[PreserveSig]
		[Token(Token = "0x600068D")]
		[Address(RVA = "0xC71FD0", Offset = "0xC71FD0", VA = "0xC71FD0")]
		public static extern IntPtr ovrAvatarSpecificationRequest_Create(ulong userID);

		[PreserveSig]
		[Token(Token = "0x600068E")]
		[Address(RVA = "0xC72050", Offset = "0xC72050", VA = "0xC72050")]
		public static extern void ovrAvatarSpecificationRequest_Destroy(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x600068F")]
		[Address(RVA = "0xC720D0", Offset = "0xC720D0", VA = "0xC720D0")]
		public static extern void ovrAvatarSpecificationRequest_SetCombineMeshes(IntPtr specificationRequest, bool useCombinedMesh);

		[PreserveSig]
		[Token(Token = "0x6000690")]
		[Address(RVA = "0xC72160", Offset = "0xC72160", VA = "0xC72160")]
		public static extern void ovrAvatarSpecificationRequest_SetLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000691")]
		[Address(RVA = "0xC721F0", Offset = "0xC721F0", VA = "0xC721F0")]
		public static extern void ovrAvatarSpecificationRequest_SetLevelOfDetail(IntPtr specificationRequest, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x6000692")]
		[Address(RVA = "0xC72280", Offset = "0xC72280", VA = "0xC72280")]
		public static extern void ovrAvatar_RequestAvatarSpecification(ulong userID);

		[PreserveSig]
		[Token(Token = "0x6000693")]
		[Address(RVA = "0xC72300", Offset = "0xC72300", VA = "0xC72300")]
		public static extern void ovrAvatar_RequestAvatarSpecificationFromSpecRequest(IntPtr specificationRequest);

		[PreserveSig]
		[Token(Token = "0x6000694")]
		[Address(RVA = "0xC72380", Offset = "0xC72380", VA = "0xC72380")]
		public static extern void ovrAvatarSpecificationRequest_SetFallbackLookAndFeelVersion(IntPtr specificationRequest, ovrAvatarLookAndFeelVersion version);

		[PreserveSig]
		[Token(Token = "0x6000695")]
		[Address(RVA = "0xC72410", Offset = "0xC72410", VA = "0xC72410")]
		public static extern void ovrAvatarSpecificationRequest_SetExpressiveFlag(IntPtr specificationRequest, bool enable);

		[PreserveSig]
		[Token(Token = "0x6000696")]
		[Address(RVA = "0xC724A0", Offset = "0xC724A0", VA = "0xC724A0")]
		public static extern IntPtr ovrAvatar_Create(IntPtr avatarSpecification, ovrAvatarCapabilities capabilities);

		[PreserveSig]
		[Token(Token = "0x6000697")]
		[Address(RVA = "0xC72530", Offset = "0xC72530", VA = "0xC72530")]
		public static extern void ovrAvatar_Destroy(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x6000698")]
		[Address(RVA = "0xC725B0", Offset = "0xC725B0", VA = "0xC725B0")]
		public static extern void ovrAvatarPose_UpdateBody(IntPtr avatar, ovrAvatarTransform headPose);

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xC72650", Offset = "0xC72650", VA = "0xC72650")]
		public static void ovrAvatarPose_UpdateVoiceVisualization(IntPtr avatar, float[] pcmData)
		{
		}

		[PreserveSig]
		[Token(Token = "0x600069A")]
		[Address(RVA = "0xC726CC", Offset = "0xC726CC", VA = "0xC726CC")]
		private static extern void ovrAvatarPose_UpdateVoiceVisualization_Native(IntPtr avatar, uint pcmDataSize, [In] float[] pcmData);

		[PreserveSig]
		[Token(Token = "0x600069B")]
		[Address(RVA = "0xC7276C", Offset = "0xC7276C", VA = "0xC7276C")]
		public static extern void ovrAvatarPose_UpdateHands(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight);

		[PreserveSig]
		[Token(Token = "0x600069C")]
		[Address(RVA = "0xC7282C", Offset = "0xC7282C", VA = "0xC7282C")]
		public static extern void ovrAvatarPose_UpdateHandsWithType(IntPtr avatar, ovrAvatarHandInputState inputStateLeft, ovrAvatarHandInputState inputStateRight, ovrAvatarControllerType type);

		[PreserveSig]
		[Token(Token = "0x600069D")]
		[Address(RVA = "0xC728FC", Offset = "0xC728FC", VA = "0xC728FC")]
		public static extern void ovrAvatarPose_Finalize(IntPtr avatar, float elapsedSeconds);

		[PreserveSig]
		[Token(Token = "0x600069E")]
		[Address(RVA = "0xC7298C", Offset = "0xC7298C", VA = "0xC7298C")]
		public static extern void ovrAvatar_SetLeftControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x600069F")]
		[Address(RVA = "0xC72A1C", Offset = "0xC72A1C", VA = "0xC72A1C")]
		public static extern void ovrAvatar_SetRightControllerVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xC72AAC", Offset = "0xC72AAC", VA = "0xC72AAC")]
		public static extern void ovrAvatar_SetLeftHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xC72B3C", Offset = "0xC72B3C", VA = "0xC72B3C")]
		public static extern void ovrAvatar_SetRightHandVisibility(IntPtr avatar, bool show);

		[PreserveSig]
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xC72BCC", Offset = "0xC72BCC", VA = "0xC72BCC")]
		public static extern uint ovrAvatarComponent_Count(IntPtr avatar);

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xC72C4C", Offset = "0xC72C4C", VA = "0xC72C4C")]
		public static void ovrAvatarComponent_Get(IntPtr avatar, uint index, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xC72D68", Offset = "0xC72D68", VA = "0xC72D68")]
		public static void ovrAvatarComponent_Get(IntPtr componentPtr, bool includeName, ref ovrAvatarComponent component)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xC72CD8", Offset = "0xC72CD8", VA = "0xC72CD8")]
		public static extern IntPtr ovrAvatarComponent_Get_Native(IntPtr avatar, uint index);

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xC72F7C", Offset = "0xC72F7C", VA = "0xC72F7C")]
		public static bool ovrAvatarPose_GetBaseComponent(IntPtr avatar, ref ovrAvatarBaseComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xC730EC", Offset = "0xC730EC", VA = "0xC730EC")]
		private static extern IntPtr ovrAvatarPose_GetBaseComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006A8")]
		public static IntPtr MarshalRenderComponent<T>(IntPtr ptr) where T : struct
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xC7316C", Offset = "0xC7316C", VA = "0xC7316C")]
		public static bool ovrAvatarPose_GetBodyComponent(IntPtr avatar, ref ovrAvatarBodyComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xC73414", Offset = "0xC73414", VA = "0xC73414")]
		private static extern IntPtr ovrAvatarPose_GetBodyComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xC73494", Offset = "0xC73494", VA = "0xC73494")]
		public static bool ovrAvatarPose_GetLeftControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xC73604", Offset = "0xC73604", VA = "0xC73604")]
		private static extern IntPtr ovrAvatarPose_GetLeftControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xC73684", Offset = "0xC73684", VA = "0xC73684")]
		public static bool ovrAvatarPose_GetRightControllerComponent(IntPtr avatar, ref ovrAvatarControllerComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xC737F4", Offset = "0xC737F4", VA = "0xC737F4")]
		private static extern IntPtr ovrAvatarPose_GetRightControllerComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xC73874", Offset = "0xC73874", VA = "0xC73874")]
		public static bool ovrAvatarPose_GetLeftHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xC739E4", Offset = "0xC739E4", VA = "0xC739E4")]
		private static extern IntPtr ovrAvatarPose_GetLeftHandComponent_Native(IntPtr avatar);

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xC73A64", Offset = "0xC73A64", VA = "0xC73A64")]
		public static bool ovrAvatarPose_GetRightHandComponent(IntPtr avatar, ref ovrAvatarHandComponent component)
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xC73BD4", Offset = "0xC73BD4", VA = "0xC73BD4")]
		private static extern IntPtr ovrAvatarPose_GetRightHandComponent_Native(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xC73C54", Offset = "0xC73C54", VA = "0xC73C54")]
		public static extern void ovrAvatarAsset_BeginLoading(ulong assetID);

		[PreserveSig]
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xC73CD4", Offset = "0xC73CD4", VA = "0xC73CD4")]
		public static extern bool ovrAvatarAsset_BeginLoadingLOD(ulong assetId, ovrAvatarAssetLevelOfDetail lod);

		[PreserveSig]
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xC73D6C", Offset = "0xC73D6C", VA = "0xC73D6C")]
		public static extern ovrAvatarAssetType ovrAvatarAsset_GetType(IntPtr assetHandle);

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xC73DEC", Offset = "0xC73DEC", VA = "0xC73DEC")]
		public static ovrAvatarMeshAssetData ovrAvatarAsset_GetMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetData);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xC73FC4", Offset = "0xC73FC4", VA = "0xC73FC4")]
		public static ovrAvatarMeshAssetDataV2 ovrAvatarAsset_GetCombinedMeshData(IntPtr assetPtr)
		{
			return default(ovrAvatarMeshAssetDataV2);
		}

		[PreserveSig]
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xC7411C", Offset = "0xC7411C", VA = "0xC7411C")]
		private static extern IntPtr ovrAvatarAsset_GetCombinedMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xC73F44", Offset = "0xC73F44", VA = "0xC73F44")]
		private static extern IntPtr ovrAvatarAsset_GetMeshData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xC7419C", Offset = "0xC7419C", VA = "0xC7419C")]
		public static extern uint ovrAvatarAsset_GetMeshBlendShapeCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xC7421C", Offset = "0xC7421C", VA = "0xC7421C")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeName(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xC742AC", Offset = "0xC742AC", VA = "0xC742AC")]
		public static extern uint ovrAvatarAsset_GetSubmeshCount(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xC7432C", Offset = "0xC7432C", VA = "0xC7432C")]
		public static extern uint ovrAvatarAsset_GetSubmeshLastIndex(IntPtr assetPtr, uint index);

		[PreserveSig]
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xC743BC", Offset = "0xC743BC", VA = "0xC743BC")]
		public static extern IntPtr ovrAvatarAsset_GetMeshBlendShapeVertices(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xC7443C", Offset = "0xC7443C", VA = "0xC7443C")]
		public static extern IntPtr ovrAvatarAsset_GetAvatar(IntPtr assetHandle);

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xC744BC", Offset = "0xC744BC", VA = "0xC744BC")]
		public static ulong[] ovrAvatarAsset_GetCombinedMeshIDs(IntPtr assetHandle)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xC74748", Offset = "0xC74748", VA = "0xC74748")]
		public static extern IntPtr ovrAvatarAsset_GetCombinedMeshIDs_Native(IntPtr assetHandle, IntPtr count);

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xC747D8", Offset = "0xC747D8", VA = "0xC747D8")]
		public static void ovrAvatar_GetCombinedMeshAlphaData(IntPtr avatar, ref ulong textureID, ref Vector4 offset)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xC74A08", Offset = "0xC74A08", VA = "0xC74A08")]
		public static extern IntPtr ovrAvatar_GetCombinedMeshAlphaData_Native(IntPtr avatar, IntPtr textureIDPtr, IntPtr offsetPtr);

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xC74AA0", Offset = "0xC74AA0", VA = "0xC74AA0")]
		public static ovrAvatarTextureAssetData ovrAvatarAsset_GetTextureData(IntPtr assetPtr)
		{
			return default(ovrAvatarTextureAssetData);
		}

		[PreserveSig]
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xC74BF0", Offset = "0xC74BF0", VA = "0xC74BF0")]
		private static extern IntPtr ovrAvatarAsset_GetTextureData_Native(IntPtr assetPtr);

		[PreserveSig]
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xC74C70", Offset = "0xC74C70", VA = "0xC74C70")]
		private static extern IntPtr ovrAvatarAsset_GetMaterialData_Native(IntPtr assetPtr);

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xC74CF0", Offset = "0xC74CF0", VA = "0xC74CF0")]
		public static ovrAvatarMaterialState ovrAvatarAsset_GetMaterialState(IntPtr assetPtr)
		{
			return default(ovrAvatarMaterialState);
		}

		[PreserveSig]
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xC74E44", Offset = "0xC74E44", VA = "0xC74E44")]
		public static extern ovrAvatarRenderPartType ovrAvatarRenderPart_GetType(IntPtr renderPart);

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xC74EC4", Offset = "0xC74EC4", VA = "0xC74EC4")]
		public static ovrAvatarRenderPart_SkinnedMeshRender ovrAvatarRenderPart_GetSkinnedMeshRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRender);
		}

		[PreserveSig]
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xC75018", Offset = "0xC75018", VA = "0xC75018")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xC75098", Offset = "0xC75098", VA = "0xC75098")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xC75128", Offset = "0xC75128", VA = "0xC75128")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xC751B8", Offset = "0xC751B8", VA = "0xC751B8")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetTransform(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xC75248", Offset = "0xC75248", VA = "0xC75248")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRender_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xC752C8", Offset = "0xC752C8", VA = "0xC752C8")]
		public static extern bool ovrAvatarSkinnedMeshRender_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xC75350", Offset = "0xC75350", VA = "0xC75350")]
		public static extern bool ovrAvatarSkinnedMeshRenderPBSV2_MaterialStateChanged(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xC753D8", Offset = "0xC753D8", VA = "0xC753D8")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBS_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xC75458", Offset = "0xC75458", VA = "0xC75458")]
		public static extern ovrAvatarVisibilityFlags ovrAvatarSkinnedMeshRenderPBSV2_GetVisibilityMask(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xC754D8", Offset = "0xC754D8", VA = "0xC754D8")]
		public static extern ovrAvatarMaterialState ovrAvatarSkinnedMeshRender_GetMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xC7558C", Offset = "0xC7558C", VA = "0xC7558C")]
		public static extern ovrAvatarPBSMaterialState ovrAvatarSkinnedMeshRenderPBSV2_GetPBSMaterialState(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xC7561C", Offset = "0xC7561C", VA = "0xC7561C")]
		public static extern ovrAvatarExpressiveParameters ovrAvatar_GetExpressiveParameters(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xC756AC", Offset = "0xC756AC", VA = "0xC756AC")]
		public static extern ulong ovrAvatarSkinnedMeshRender_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xC7572C", Offset = "0xC7572C", VA = "0xC7572C")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xC757AC", Offset = "0xC757AC", VA = "0xC757AC")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBSV2_GetDirtyJoints(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xC7582C", Offset = "0xC7582C", VA = "0xC7582C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRender_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xC758C4", Offset = "0xC758C4", VA = "0xC758C4")]
		public static extern void ovrAvatar_SetActionUnitOnsetSpeed(IntPtr avatar, float onsetSpeed);

		[PreserveSig]
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xC75954", Offset = "0xC75954", VA = "0xC75954")]
		public static extern void ovrAvatar_SetActionUnitFalloffSpeed(IntPtr avatar, float falloffSpeed);

		[PreserveSig]
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xC759E4", Offset = "0xC759E4", VA = "0xC759E4")]
		public static extern void ovrAvatar_SetVisemeMultiplier(IntPtr avatar, float visemeMultiplier);

		[PreserveSig]
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xC75A74", Offset = "0xC75A74", VA = "0xC75A74")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBS_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xC75B0C", Offset = "0xC75B0C", VA = "0xC75B0C")]
		public static extern ovrAvatarTransform ovrAvatarSkinnedMeshRenderPBSV2_GetJointTransform(IntPtr renderPart, uint jointIndex);

		[PreserveSig]
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xC75BA4", Offset = "0xC75BA4", VA = "0xC75BA4")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetAlbedoTextureAssetID(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xC75C24", Offset = "0xC75C24", VA = "0xC75C24")]
		public static extern ulong ovrAvatarSkinnedMeshRenderPBS_GetSurfaceTextureAssetID(IntPtr renderPart);

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xC75CA4", Offset = "0xC75CA4", VA = "0xC75CA4")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS ovrAvatarRenderPart_GetSkinnedMeshRenderPBS(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS);
		}

		[PreserveSig]
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xC75DF8", Offset = "0xC75DF8", VA = "0xC75DF8")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBS_Native(IntPtr renderPart);

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xC75E78", Offset = "0xC75E78", VA = "0xC75E78")]
		public static ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2 ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_SkinnedMeshRenderPBS_V2);
		}

		[PreserveSig]
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xC75FCC", Offset = "0xC75FCC", VA = "0xC75FCC")]
		private static extern IntPtr ovrAvatarRenderPart_GetSkinnedMeshRenderPBSV2_Native(IntPtr renderPart);

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xC7604C", Offset = "0xC7604C", VA = "0xC7604C")]
		public static void ovrAvatarSkinnedMeshRender_GetBlendShapeParams(IntPtr renderPart, ref ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xC76188", Offset = "0xC76188", VA = "0xC76188")]
		private static extern IntPtr ovrAvatarSkinnedMeshRender_GetBlendShapeParams_Native(IntPtr renderPart);

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xC76208", Offset = "0xC76208", VA = "0xC76208")]
		public static ovrAvatarRenderPart_ProjectorRender ovrAvatarRenderPart_GetProjectorRender(IntPtr renderPart)
		{
			return default(ovrAvatarRenderPart_ProjectorRender);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xC763DC", Offset = "0xC763DC", VA = "0xC763DC")]
		public static ovrAvatarPBSMaterialState[] ovrAvatar_GetBodyPBSMaterialStates(IntPtr renderPart)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xC766BC", Offset = "0xC766BC", VA = "0xC766BC")]
		private static extern IntPtr ovrAvatar_GetBodyPBSMaterialStates_Native(IntPtr avatar, IntPtr count);

		[PreserveSig]
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xC7635C", Offset = "0xC7635C", VA = "0xC7635C")]
		private static extern IntPtr ovrAvatarRenderPart_GetProjectorRender_Native(IntPtr renderPart);

		[PreserveSig]
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xC7674C", Offset = "0xC7674C", VA = "0xC7674C")]
		public static extern uint ovrAvatar_GetReferencedAssetCount(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xC767CC", Offset = "0xC767CC", VA = "0xC767CC")]
		public static extern ulong ovrAvatar_GetReferencedAsset(IntPtr avatar, uint index);

		[PreserveSig]
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xC7685C", Offset = "0xC7685C", VA = "0xC7685C")]
		public static extern void ovrAvatar_SetLeftHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xC768EC", Offset = "0xC768EC", VA = "0xC768EC")]
		public static extern void ovrAvatar_SetRightHandGesture(IntPtr avatar, ovrAvatarHandGesture gesture);

		[PreserveSig]
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xC7697C", Offset = "0xC7697C", VA = "0xC7697C")]
		public static extern void ovrAvatar_SetLeftHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xC76A1C", Offset = "0xC76A1C", VA = "0xC76A1C")]
		public static extern void ovrAvatar_SetRightHandCustomGesture(IntPtr avatar, uint jointCount, [In] ovrAvatarTransform[] customJointTransforms);

		[PreserveSig]
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xC76ABC", Offset = "0xC76ABC", VA = "0xC76ABC")]
		public static extern void ovrAvatar_UpdatePoseFromPacket(IntPtr avatar, IntPtr packet, float secondsFromStart);

		[PreserveSig]
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xC76B5C", Offset = "0xC76B5C", VA = "0xC76B5C")]
		public static extern void ovrAvatarPacket_BeginRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xC76BDC", Offset = "0xC76BDC", VA = "0xC76BDC")]
		public static extern IntPtr ovrAvatarPacket_EndRecording(IntPtr avatar);

		[PreserveSig]
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xC76C5C", Offset = "0xC76C5C", VA = "0xC76C5C")]
		public static extern uint ovrAvatarPacket_GetSize(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xC76CDC", Offset = "0xC76CDC", VA = "0xC76CDC")]
		public static extern float ovrAvatarPacket_GetDurationSeconds(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xC76D5C", Offset = "0xC76D5C", VA = "0xC76D5C")]
		public static extern void ovrAvatarPacket_Free(IntPtr packet);

		[PreserveSig]
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xC76DDC", Offset = "0xC76DDC", VA = "0xC76DDC")]
		public static extern bool ovrAvatarPacket_Write(IntPtr packet, uint bufferSize, [Out] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xC76F04", Offset = "0xC76F04", VA = "0xC76F04")]
		public static extern IntPtr ovrAvatarPacket_Read(uint bufferSize, [In] byte[] buffer);

		[PreserveSig]
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xC76F9C", Offset = "0xC76F9C", VA = "0xC76F9C")]
		private static extern void ovrAvatar_SetInternalForceASTCTextures(bool value);

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xC7701C", Offset = "0xC7701C", VA = "0xC7701C")]
		public static void ovrAvatar_SetForceASTCTextures(bool value)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xC7707C", Offset = "0xC7707C", VA = "0xC7707C")]
		public static void ovrAvatar_OverrideExpressiveLogic(IntPtr avatar, ovrAvatarBlendShapeParams blendParams)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xC771C4", Offset = "0xC771C4", VA = "0xC771C4")]
		private static extern void ovrAvatar_OverrideExpressiveLogic_Native(IntPtr avatar, IntPtr state);

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xC77254", Offset = "0xC77254", VA = "0xC77254")]
		public static void ovrAvatar_SetVisemes(IntPtr avatar, ovrAvatarVisemes visemes)
		{
		}

		[PreserveSig]
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xC773AC", Offset = "0xC773AC", VA = "0xC773AC")]
		private static extern void ovrAvatar_SetVisemes_Native(IntPtr avatar, IntPtr visemes);

		[PreserveSig]
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xC7743C", Offset = "0xC7743C", VA = "0xC7743C")]
		public static extern void ovrAvatar_UpdateWorldTransform(IntPtr avatar, ovrAvatarTransform transform);

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xC774DC", Offset = "0xC774DC", VA = "0xC774DC")]
		public static void ovrAvatar_UpdateGazeTargets(ovrAvatarGazeTargets targets)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000701")]
		[Address(RVA = "0xC778AC", Offset = "0xC778AC", VA = "0xC778AC")]
		private static extern void ovrAvatar_UpdateGazeTargets_Native(IntPtr targets);

		[PreserveSig]
		[Token(Token = "0x6000702")]
		[Address(RVA = "0xC7792C", Offset = "0xC7792C", VA = "0xC7792C")]
		public static extern void ovrAvatar_RemoveGazeTargets(uint targetCount, uint[] ids);

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xC779C4", Offset = "0xC779C4", VA = "0xC779C4")]
		public static void ovrAvatar_UpdateLights(ovrAvatarLights lights)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000704")]
		[Address(RVA = "0xC78224", Offset = "0xC78224", VA = "0xC78224")]
		private static extern void ovrAvatar_UpdateLights_Native(IntPtr lights);

		[PreserveSig]
		[Token(Token = "0x6000705")]
		[Address(RVA = "0xC782A4", Offset = "0xC782A4", VA = "0xC782A4")]
		public static extern void ovrAvatar_RemoveLights(uint lightCount, uint[] ids);

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xC71670", Offset = "0xC71670", VA = "0xC71670")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x643EC8", Offset = "0x643EC8")]
		public static void LoggingCallback(IntPtr str)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000707")]
		[Address(RVA = "0xC7833C", Offset = "0xC7833C", VA = "0xC7833C")]
		public static extern void ovrAvatar_RegisterLoggingCallback(LoggingDelegate callback);

		[PreserveSig]
		[Token(Token = "0x6000708")]
		[Address(RVA = "0xC783C0", Offset = "0xC783C0", VA = "0xC783C0")]
		public static extern void ovrAvatar_SetLoggingLevel(ovrAvatarLogLevel level);

		[PreserveSig]
		[Token(Token = "0x6000709")]
		[Address(RVA = "0xC78440", Offset = "0xC78440", VA = "0xC78440")]
		public static extern IntPtr ovrAvatar_GetDebugTransforms_Native(IntPtr count);

		[PreserveSig]
		[Token(Token = "0x600070A")]
		[Address(RVA = "0xC784C0", Offset = "0xC784C0", VA = "0xC784C0")]
		public static extern IntPtr ovrAvatar_GetDebugLines_Native(IntPtr count);

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xC78540", Offset = "0xC78540", VA = "0xC78540")]
		public static void ovrAvatar_DrawDebugLines()
		{
		}

		[PreserveSig]
		[Token(Token = "0x600070C")]
		[Address(RVA = "0xC78F04", Offset = "0xC78F04", VA = "0xC78F04")]
		public static extern void ovrAvatar_SetDebugDrawContext(uint context);

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xC78F84", Offset = "0xC78F84", VA = "0xC78F84")]
		public static bool SendEvent(string name, string param = "", string source = "")
		{
			return default(bool);
		}

		[PreserveSig]
		[Token(Token = "0x600070E")]
		[Address(RVA = "0xC793A4", Offset = "0xC793A4", VA = "0xC793A4")]
		private static extern IntPtr _ovrp_GetVersion();

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xC7930C", Offset = "0xC7930C", VA = "0xC7930C")]
		public static string ovrp_GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xC79418", Offset = "0xC79418", VA = "0xC79418")]
		public CAPI()
		{
		}
	}
}
namespace OVR
{
	[Token(Token = "0x2000158")]
	public class TestScript : MonoBehaviour
	{
		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InspectorNoteAttribute", RVA = "0x641734", Offset = "0x641734")]
		public SoundFXRef testSound1;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundFXRef testSound2;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xAF4B88", Offset = "0xAF4B88", VA = "0xAF4B88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xAF4B8C", Offset = "0xAF4B8C", VA = "0xAF4B8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xAF4C34", Offset = "0xAF4C34", VA = "0xAF4C34")]
		public TestScript()
		{
		}
	}
	[Token(Token = "0x2000159")]
	public class AmbienceEmitter : MonoBehaviour
	{
		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFXRef[] ambientSounds;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool autoActivate;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641780", Offset = "0x641780")]
		public bool autoRetrigger;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x6417B8", Offset = "0x6417B8")]
		public Vector2 randomRetriggerDelaySecs;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6417DC", Offset = "0x6417DC")]
		public Transform[] playPositions;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool activated;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int playingIdx;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float nextPlayTime;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float fadeTime;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int lastPosIdx;

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xC67CC8", Offset = "0xC67CC8", VA = "0xC67CC8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xC67E6C", Offset = "0xC67E6C", VA = "0xC67E6C")]
		private void Update()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xC68048", Offset = "0xC68048", VA = "0xC68048")]
		public void OnTriggerEnter(Collider col)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xC67ECC", Offset = "0xC67ECC", VA = "0xC67ECC")]
		public void Play()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xC68108", Offset = "0xC68108", VA = "0xC68108")]
		public void EnableEmitter(bool enable)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xC68278", Offset = "0xC68278", VA = "0xC68278")]
		public AmbienceEmitter()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public enum PreloadSounds
	{
		[Token(Token = "0x40007B6")]
		Default,
		[Token(Token = "0x40007B7")]
		Preload,
		[Token(Token = "0x40007B8")]
		ManualPreload
	}
	[Token(Token = "0x200015B")]
	public enum Fade
	{
		[Token(Token = "0x40007BA")]
		In,
		[Token(Token = "0x40007BB")]
		Out
	}
	[Serializable]
	[Token(Token = "0x200015C")]
	public class SoundGroup
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SoundFX[] soundList;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioMixerGroup mixerGroup;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641814", Offset = "0x641814")]
		public int maxPlayingSounds;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PreloadSounds preloadAudio;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float volumeOverride;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public int playingSoundCount;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xB17C3C", Offset = "0xB17C3C", VA = "0xB17C3C")]
		public SoundGroup(string name)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xB17CD8", Offset = "0xB17CD8", VA = "0xB17CD8")]
		public SoundGroup()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xB160A0", Offset = "0xB160A0", VA = "0xB160A0")]
		public void IncrementPlayCount()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xB163A8", Offset = "0xB163A8", VA = "0xB163A8")]
		public void DecrementPlayCount()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xB1720C", Offset = "0xB1720C", VA = "0xB1720C")]
		public bool CanPlaySound()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200015D")]
	public class AudioManager : MonoBehaviour
	{
		[Token(Token = "0x200015E")]
		public enum Fade
		{
			[Token(Token = "0x40007E3")]
			In,
			[Token(Token = "0x40007E4")]
			Out
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F22C", Offset = "0x63F22C")]
		private sealed class <>c__DisplayClass77_0
		{
			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SoundPriority priority;

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xAFB578", Offset = "0xAFB578", VA = "0xAFB578")]
			public <>c__DisplayClass77_0()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xAFB580", Offset = "0xAFB580", VA = "0xAFB580")]
			internal bool <FindFreeEmitter>b__0(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F23C", Offset = "0x63F23C")]
		private sealed class <>c
		{
			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<SoundEmitter> <>9__77_1;

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xAFB4E4", Offset = "0xAFB4E4", VA = "0xAFB4E4")]
			public <>c()
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0xAFB4EC", Offset = "0xAFB4EC", VA = "0xAFB4EC")]
			internal bool <FindFreeEmitter>b__77_1(SoundEmitter item)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641840", Offset = "0x641840")]
		public bool makePersistent;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641878", Offset = "0x641878")]
		public bool enableSpatializedAudio;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6418B0", Offset = "0x6418B0")]
		public bool enableSpatializedFastOverride;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6418E8", Offset = "0x6418E8")]
		public AudioMixer audioMixer;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641920", Offset = "0x641920")]
		public AudioMixerGroup defaultMixerGroup;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641958", Offset = "0x641958")]
		public AudioMixerGroup reservedMixerGroup;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641990", Offset = "0x641990")]
		public AudioMixerGroup voiceChatMixerGroup;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6419C8", Offset = "0x6419C8")]
		public bool verboseLogging;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641A00", Offset = "0x641A00")]
		public int maxSoundEmitters;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641A38", Offset = "0x641A38")]
		public float volumeSoundFX;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641A70", Offset = "0x641A70")]
		public float soundFxFadeSecs;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float audioMinFallOffDistance;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float audioMaxFallOffDistance;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SoundGroup[] soundGroupings;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, SoundFX> soundFXCache;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioManager theAudioManager;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static FastList<string> names;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string[] defaultSound;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static SoundFX nullSound;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool hideWarnings;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float audioMaxFallOffDistanceSqr;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SoundEmitter[] soundEmitters;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private FastList<SoundEmitter> playingEmitters;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FastList<SoundEmitter> nextFreeEmitters;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MixerSnapshot currentSnapshot;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static GameObject soundEmitterParent;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Transform staticListenerPosition;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool showPlayingEmitterCount;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private static bool forceShowEmitterCount;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private static bool soundEnabled;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly AnimationCurve defaultReverbZoneMix;

		[Token(Token = "0x170000C1")]
		public static bool enableSpatialization
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xC69A30", Offset = "0xC69A30", VA = "0xC69A30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		public static AudioManager Instance
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0xC69B18", Offset = "0xC69B18", VA = "0xC69B18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public static float NearFallOff
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0xC69B7C", Offset = "0xC69B7C", VA = "0xC69B7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C4")]
		public static float FarFallOff
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0xC69BEC", Offset = "0xC69BEC", VA = "0xC69BEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C5")]
		public static AudioMixerGroup EmitterGroup
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0xC69C5C", Offset = "0xC69C5C", VA = "0xC69C5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public static AudioMixerGroup ReservedGroup
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0xC69CCC", Offset = "0xC69CCC", VA = "0xC69CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public static AudioMixerGroup VoipGroup
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0xC69D3C", Offset = "0xC69D3C", VA = "0xC69D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public static bool SoundEnabled
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xC6BBE4", Offset = "0xC6BBE4", VA = "0xC6BBE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xC69DAC", Offset = "0xC69DAC", VA = "0xC69DAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xC69FE8", Offset = "0xC69FE8", VA = "0xC69FE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xC69DB0", Offset = "0xC69DB0", VA = "0xC69DB0")]
		private void Init()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xC6AC40", Offset = "0xC6AC40", VA = "0xC6AC40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xC6A148", Offset = "0xC6A148", VA = "0xC6A148")]
		private void RebuildSoundFXCache()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xC6B2EC", Offset = "0xC6B2EC", VA = "0xC6B2EC")]
		public static SoundFX FindSoundFX(string name, bool rebuildCache = false)
		{
			return null;
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xC6B480", Offset = "0xC6B480", VA = "0xC6B480")]
		private static bool FindAudioManager()
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xC6B654", Offset = "0xC6B654", VA = "0xC6B654")]
		public static GameObject GetGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xC6B75C", Offset = "0xC6B75C", VA = "0xC6B75C")]
		public static string NameMinusGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xC6B7E8", Offset = "0xC6B7E8", VA = "0xC6B7E8")]
		public static string[] GetSoundFXNames(string currentValue, out int currentIdx)
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xC6BC48", Offset = "0xC6BC48", VA = "0xC6BC48")]
		private static int CalculateMaxEmittersSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xC6BCBC", Offset = "0xC6BCBC", VA = "0xC6BCBC")]
		private static bool ValidateEmitterIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xC6A5FC", Offset = "0xC6A5FC", VA = "0xC6A5FC")]
		private void InitializeSoundSystem()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xC6AC44", Offset = "0xC6AC44", VA = "0xC6AC44")]
		private void UpdateFreeEmitters()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xC6BE04", Offset = "0xC6BE04", VA = "0xC6BE04")]
		private string Fmt(int count)
		{
			return null;
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xC6BF34", Offset = "0xC6BF34", VA = "0xC6BF34")]
		private string FmtFree(int count)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xC6C068", Offset = "0xC6C068", VA = "0xC6C068")]
		private void OnPreSceneLoad()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xC6BD30", Offset = "0xC6BD30", VA = "0xC6BD30")]
		private void ResetFreeEmitters()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xC6C1B0", Offset = "0xC6C1B0", VA = "0xC6C1B0")]
		public static void FadeOutSoundChannel(int channel, float delaySecs, float fadeTime)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xC6C268", Offset = "0xC6C268", VA = "0xC6C268")]
		public static bool StopSound(int idx, bool fadeOut = true, bool stopReserved = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xC6C384", Offset = "0xC6C384", VA = "0xC6C384")]
		public static void FadeInSound(int idx, float fadeTime, float volume)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xC68058", Offset = "0xC68058", VA = "0xC68058")]
		public static void FadeInSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xC681C8", Offset = "0xC681C8", VA = "0xC681C8")]
		public static void FadeOutSound(int idx, float fadeTime)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xC6C43C", Offset = "0xC6C43C", VA = "0xC6C43C")]
		public static void StopAllSounds(bool fadeOut, bool stopReserved = false)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xC6C504", Offset = "0xC6C504", VA = "0xC6C504")]
		public void MuteAllSounds(bool mute, bool muteReserved = false)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xC6C598", Offset = "0xC6C598", VA = "0xC6C598")]
		public void UnMuteAllSounds(bool unmute, bool unmuteReserved = false)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xC6C65C", Offset = "0xC6C65C", VA = "0xC6C65C")]
		public static float GetEmitterEndTime(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xC6C6FC", Offset = "0xC6C6FC", VA = "0xC6C6FC")]
		public static float SetEmitterTime(int idx, float time)
		{
			return default(float);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xC6C7B4", Offset = "0xC6C7B4", VA = "0xC6C7B4")]
		public static int PlaySound(AudioClip clip, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitchVariance = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xC6D244", Offset = "0xC6D244", VA = "0xC6D244")]
		private static int FindFreeEmitter(EmitterChannel src, SoundPriority priority)
		{
			return default(int);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xC6D93C", Offset = "0xC6D93C", VA = "0xC6D93C")]
		public static int PlaySound(SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xC6DB00", Offset = "0xC6DB00", VA = "0xC6DB00")]
		public static int PlaySoundAt(Vector3 position, SoundFX soundFX, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xC6E624", Offset = "0xC6E624", VA = "0xC6E624")]
		public static int PlayRandomSoundAt(Vector3 position, AudioClip[] clips, float volume, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xC6C9A0", Offset = "0xC6C9A0", VA = "0xC6C9A0")]
		public static int PlaySoundAt(Vector3 position, AudioClip clip, float volume = 1f, EmitterChannel src = EmitterChannel.Any, float delay = 0f, float pitch = 1f, bool loop = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xC6E740", Offset = "0xC6E740", VA = "0xC6E740")]
		public static void SetOnFinished(int emitterIdx, Action onFinished)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xC6E810", Offset = "0xC6E810", VA = "0xC6E810")]
		public static void SetOnFinished(int emitterIdx, Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xC6E8FC", Offset = "0xC6E8FC", VA = "0xC6E8FC")]
		public static void AttachSoundToParent(int idx, Transform parent)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xC6EB24", Offset = "0xC6EB24", VA = "0xC6EB24")]
		public static void DetachSoundFromParent(int idx)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xC6EC78", Offset = "0xC6EC78", VA = "0xC6EC78")]
		public static void DetachSoundsFromParent(SoundEmitter[] emitters, bool stopSounds = true)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xC6ED9C", Offset = "0xC6ED9C", VA = "0xC6ED9C")]
		public static void SetEmitterMixerGroup(int idx, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xC6EEC8", Offset = "0xC6EEC8", VA = "0xC6EEC8")]
		public static MixerSnapshot GetActiveSnapshot()
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xC6EFA8", Offset = "0xC6EFA8", VA = "0xC6EFA8")]
		public static void SetCurrentSnapshot(MixerSnapshot mixerSnapshot)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xC6F0E4", Offset = "0xC6F0E4", VA = "0xC6F0E4")]
		public static void BlendWithCurrentSnapshot(MixerSnapshot blendSnapshot, float weight, float blendTime = 0f)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xC6F4E8", Offset = "0xC6F4E8", VA = "0xC6F4E8")]
		public AudioManager()
		{
		}
	}
	[Token(Token = "0x2000161")]
	public enum EmitterChannel
	{
		[Token(Token = "0x40007E9")]
		None = -1,
		[Token(Token = "0x40007EA")]
		Reserved,
		[Token(Token = "0x40007EB")]
		Any
	}
	[Serializable]
	[Token(Token = "0x2000162")]
	public class MixerSnapshot
	{
		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixerSnapshot snapshot;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float transitionTime;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xD5F488", Offset = "0xD5F488", VA = "0xD5F488")]
		public MixerSnapshot()
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class MinMaxAttribute : PropertyAttribute
	{
		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minDefaultVal;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maxDefaultVal;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float min;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float max;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xD5F42C", Offset = "0xD5F42C", VA = "0xD5F42C")]
		public MinMaxAttribute(float minDefaultVal, float maxDefaultVal, float min, float max)
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class SoundEmitter : MonoBehaviour
	{
		[Token(Token = "0x2000165")]
		public enum FadeState
		{
			[Token(Token = "0x4000802")]
			Null,
			[Token(Token = "0x4000803")]
			FadingIn,
			[Token(Token = "0x4000804")]
			FadingOut,
			[Token(Token = "0x4000805")]
			Ducking
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F24C", Offset = "0x63F24C")]
		private sealed class <DelayedSyncTo>d__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundEmitter other;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float fadeTime;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float toVolume;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600078E")]
				[Address(RVA = "0xB03E44", Offset = "0xB03E44", VA = "0xB03E44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000790")]
				[Address(RVA = "0xB03E8C", Offset = "0xB03E8C", VA = "0xB03E8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0xB03D30", Offset = "0xB03D30", VA = "0xB03D30")]
			[DebuggerHidden]
			public <DelayedSyncTo>d__57(int <>1__state)
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0xB03D5C", Offset = "0xB03D5C", VA = "0xB03D5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0xB03D60", Offset = "0xB03D60", VA = "0xB03D60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0xB03E4C", Offset = "0xB03E4C", VA = "0xB03E4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F25C", Offset = "0x63F25C")]
		private sealed class <FadeSoundChannelTo>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float toVolume;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float fadeTime;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <start>5__2;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <end>5__3;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <elapsedTime>5__5;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000794")]
				[Address(RVA = "0xB042B0", Offset = "0xB042B0", VA = "0xB042B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000796")]
				[Address(RVA = "0xB042F8", Offset = "0xB042F8", VA = "0xB042F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xB04150", Offset = "0xB04150", VA = "0xB04150")]
			[DebuggerHidden]
			public <FadeSoundChannelTo>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xB0417C", Offset = "0xB0417C", VA = "0xB0417C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0xB04180", Offset = "0xB04180", VA = "0xB04180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0xB042B8", Offset = "0xB042B8", VA = "0xB042B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F26C", Offset = "0x63F26C")]
		private sealed class <FadeSoundChannel>d__64 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delaySecs;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Fade fadeType;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float defaultVolume;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundEmitter <>4__this;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float fadeTime;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <start>5__2;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <end>5__3;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool <restartPlay>5__4;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <startTime>5__5;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <elapsedTime>5__6;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079A")]
				[Address(RVA = "0xB04100", Offset = "0xB04100", VA = "0xB04100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079C")]
				[Address(RVA = "0xB04148", Offset = "0xB04148", VA = "0xB04148", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0xB03E94", Offset = "0xB03E94", VA = "0xB03E94")]
			[DebuggerHidden]
			public <FadeSoundChannel>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0xB03EC0", Offset = "0xB03EC0", VA = "0xB03EC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0xB03EC4", Offset = "0xB03EC4", VA = "0xB03EC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0xB04108", Offset = "0xB04108", VA = "0xB04108", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EmitterChannel channel;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSpatialization;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FadeState state;

		[NonSerialized]
		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public AudioSource audioSource;

		[NonSerialized]
		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public SoundPriority priority;

		[NonSerialized]
		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public ONSPAudioSource osp;

		[NonSerialized]
		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float endPlayTime;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform lastParentTransform;

		[NonSerialized]
		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float defaultVolume;

		[NonSerialized]
		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Transform defaultParent;

		[NonSerialized]
		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public int originalIdx;

		[NonSerialized]
		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public Action onFinished;

		[NonSerialized]
		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Action<object> onFinishedObject;

		[NonSerialized]
		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public object onFinishedParam;

		[NonSerialized]
		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public SoundGroup playingSoundGroup;

		[Token(Token = "0x170000C9")]
		public float volume
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0xB15C44", Offset = "0xB15C44", VA = "0xB15C44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000763")]
			[Address(RVA = "0xB15C60", Offset = "0xB15C60", VA = "0xB15C60")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public float pitch
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0xB15C7C", Offset = "0xB15C7C", VA = "0xB15C7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000765")]
			[Address(RVA = "0xB15C98", Offset = "0xB15C98", VA = "0xB15C98")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public AudioClip clip
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0xB15CB4", Offset = "0xB15CB4", VA = "0xB15CB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xB15CD0", Offset = "0xB15CD0", VA = "0xB15CD0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public float time
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0xB15CEC", Offset = "0xB15CEC", VA = "0xB15CEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000769")]
			[Address(RVA = "0xB15D08", Offset = "0xB15D08", VA = "0xB15D08")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public float length
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0xB15D24", Offset = "0xB15D24", VA = "0xB15D24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CE")]
		public bool loop
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0xB15DD8", Offset = "0xB15DD8", VA = "0xB15DD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600076C")]
			[Address(RVA = "0xB15DF4", Offset = "0xB15DF4", VA = "0xB15DF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public bool mute
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0xB15E14", Offset = "0xB15E14", VA = "0xB15E14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600076E")]
			[Address(RVA = "0xB15E30", Offset = "0xB15E30", VA = "0xB15E30")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public AudioVelocityUpdateMode velocityUpdateMode
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0xB15E50", Offset = "0xB15E50", VA = "0xB15E50")]
			get
			{
				return default(AudioVelocityUpdateMode);
			}
			[Token(Token = "0x6000770")]
			[Address(RVA = "0xB15E6C", Offset = "0xB15E6C", VA = "0xB15E6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public bool isPlaying
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0xB15E88", Offset = "0xB15E88", VA = "0xB15E88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xB15EA4", Offset = "0xB15EA4", VA = "0xB15EA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xB1605C", Offset = "0xB1605C", VA = "0xB1605C")]
		public void SetPlayingSoundGroup(SoundGroup soundGroup)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xB160DC", Offset = "0xB160DC", VA = "0xB160DC")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xB160E4", Offset = "0xB160E4", VA = "0xB160E4")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xB160EC", Offset = "0xB160EC", VA = "0xB160EC")]
		public void SetChannel(int _channel)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xB160F4", Offset = "0xB160F4", VA = "0xB160F4")]
		public void SetDefaultParent(Transform parent)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xB160FC", Offset = "0xB160FC", VA = "0xB160FC")]
		public void SetAudioMixer(AudioMixerGroup _mixer)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xB161A0", Offset = "0xB161A0", VA = "0xB161A0")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xB1620C", Offset = "0xB1620C", VA = "0xB1620C")]
		public void Play()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xB1626C", Offset = "0xB1626C", VA = "0xB1626C")]
		public void Pause()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xB162A4", Offset = "0xB162A4", VA = "0xB162A4")]
		public void Stop()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xB163E4", Offset = "0xB163E4", VA = "0xB163E4")]
		private int GetSampleTime()
		{
			return default(int);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xB1643C", Offset = "0xB1643C", VA = "0xB1643C")]
		public void ParentTo(Transform parent)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xB1654C", Offset = "0xB1654C", VA = "0xB1654C")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xB16600", Offset = "0xB16600", VA = "0xB16600")]
		public void ResetParent(Transform parent)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xB16640", Offset = "0xB16640", VA = "0xB16640")]
		public void SyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xB1666C", Offset = "0xB1666C", VA = "0xB1666C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643F28", Offset = "0x643F28")]
		private IEnumerator DelayedSyncTo(SoundEmitter other, float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xB166F8", Offset = "0xB166F8", VA = "0xB166F8")]
		public void FadeTo(float fadeTime, float toVolume)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xB167E0", Offset = "0xB167E0", VA = "0xB167E0")]
		public void FadeIn(float fadeTime, float defaultVolume)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xB16900", Offset = "0xB16900", VA = "0xB16900")]
		public void FadeIn(float fadeTime)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xB16978", Offset = "0xB16978", VA = "0xB16978")]
		public void FadeOut(float fadeTime)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0xB16A10", Offset = "0xB16A10", VA = "0xB16A10")]
		public void FadeOutDelayed(float delayedSecs, float fadeTime)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xB16760", Offset = "0xB16760", VA = "0xB16760")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643F88", Offset = "0x643F88")]
		private IEnumerator FadeSoundChannelTo(float fadeTime, float toVolume)
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xB1685C", Offset = "0xB1685C", VA = "0xB1685C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x643FE8", Offset = "0x643FE8")]
		private IEnumerator FadeSoundChannel(float delaySecs, float fadeTime, Fade fadeType, float defaultVolume)
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xB16AAC", Offset = "0xB16AAC", VA = "0xB16AAC")]
		public SoundEmitter()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public enum SoundFXNext
	{
		[Token(Token = "0x4000822")]
		Random,
		[Token(Token = "0x4000823")]
		Sequential
	}
	[Token(Token = "0x200016A")]
	public enum FreqHint
	{
		[Token(Token = "0x4000825")]
		None,
		[Token(Token = "0x4000826")]
		Wide,
		[Token(Token = "0x4000827")]
		Narrow
	}
	[Token(Token = "0x200016B")]
	public enum SoundPriority
	{
		[Token(Token = "0x4000829")]
		VeryLow = -2,
		[Token(Token = "0x400082A")]
		Low,
		[Token(Token = "0x400082B")]
		Default,
		[Token(Token = "0x400082C")]
		High,
		[Token(Token = "0x400082D")]
		VeryHigh
	}
	[Serializable]
	[Token(Token = "0x200016C")]
	public class OSPProps
	{
		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641B58", Offset = "0x641B58")]
		public bool enableSpatialization;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641B90", Offset = "0x641B90")]
		public bool useFastOverride;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641BC8", Offset = "0x641BC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641BC8", Offset = "0x641BC8")]
		public float gain;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641C1C", Offset = "0x641C1C")]
		public bool enableInvSquare;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641C54", Offset = "0x641C54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641C54", Offset = "0x641C54")]
		public float volumetric;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641CAC", Offset = "0x641CAC")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x641CAC", Offset = "0x641CAC")]
		public Vector2 invSquareFalloff;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xFE09D4", Offset = "0xFE09D4", VA = "0xFE09D4")]
		public OSPProps()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016D")]
	public class SoundFX
	{
		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641D0C", Offset = "0x641D0C")]
		public string name;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641D44", Offset = "0x641D44")]
		public SoundFXNext playback;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641D7C", Offset = "0x641D7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641D7C", Offset = "0x641D7C")]
		public float volume;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641DD0", Offset = "0x641DD0")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x641DD0", Offset = "0x641DD0")]
		public Vector2 pitchVariance;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641E2C", Offset = "0x641E2C")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x641E2C", Offset = "0x641E2C")]
		public Vector2 falloffDistance;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641E8C", Offset = "0x641E8C")]
		public AudioRolloffMode falloffCurve;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641EC4", Offset = "0x641EC4")]
		public AnimationCurve volumeFalloffCurve;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641EFC", Offset = "0x641EFC")]
		public AnimationCurve reverbZoneMix;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641F34", Offset = "0x641F34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641F34", Offset = "0x641F34")]
		public float spread;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641F8C", Offset = "0x641F8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x641F8C", Offset = "0x641F8C")]
		public float pctChanceToPlay;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x641FE0", Offset = "0x641FE0")]
		public SoundPriority priority;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642018", Offset = "0x642018")]
		[AttributeAttribute(Name = "MinMaxAttribute", RVA = "0x642018", Offset = "0x642018")]
		public Vector2 delay;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x642074", Offset = "0x642074")]
		public bool looping;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OSPProps ospProps;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6420AC", Offset = "0x6420AC")]
		public AudioClip[] soundClips;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool visibilityToggle;

		[NonSerialized]
		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private SoundGroup soundGroup;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int lastIdx;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int playingIdx;

		[Token(Token = "0x170000D8")]
		public int Length
		{
			[Token(Token = "0x600079F")]
			[Address(RVA = "0xB16F88", Offset = "0xB16F88", VA = "0xB16F88")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D9")]
		public bool IsValid
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xB16FA4", Offset = "0xB16FA4", VA = "0xB16FA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DA")]
		public SoundGroup Group
		{
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0xB17044", Offset = "0xB17044", VA = "0xB17044")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0xB1704C", Offset = "0xB1704C", VA = "0xB1704C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public float MaxFalloffDistSquared
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xB17054", Offset = "0xB17054", VA = "0xB17054")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000DC")]
		public float GroupVolumeOverride
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xB17060", Offset = "0xB17060", VA = "0xB17060")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xB16AC4", Offset = "0xB16AC4", VA = "0xB16AC4")]
		public SoundFX()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xB17078", Offset = "0xB17078", VA = "0xB17078")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xB17148", Offset = "0xB17148", VA = "0xB17148")]
		public AudioMixerGroup GetMixerGroup(AudioMixerGroup defaultMixerGroup)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xB171E4", Offset = "0xB171E4", VA = "0xB171E4")]
		public bool ReachedGroupPlayLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xB1722C", Offset = "0xB1722C", VA = "0xB1722C")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xB17324", Offset = "0xB17324", VA = "0xB17324")]
		public float GetPitch()
		{
			return default(float);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xB17330", Offset = "0xB17330", VA = "0xB17330")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xB1740C", Offset = "0xB1740C", VA = "0xB1740C")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volumeOverride = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xB17520", Offset = "0xB17520", VA = "0xB17520")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xB175AC", Offset = "0xB175AC", VA = "0xB175AC")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xB17640", Offset = "0xB17640", VA = "0xB17640")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xB176CC", Offset = "0xB176CC", VA = "0xB176CC")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xB17758", Offset = "0xB17758", VA = "0xB17758")]
		public void DetachFromParent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016E")]
	public class SoundFXRef
	{
		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundFXName;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool initialized;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SoundFX soundFXCached;

		[Token(Token = "0x170000DD")]
		public SoundFX soundFX
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xB177D0", Offset = "0xB177D0", VA = "0xB177D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public string name
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xB178D4", Offset = "0xB178D4", VA = "0xB178D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xB178DC", Offset = "0xB178DC", VA = "0xB178DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public int Length
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xB178E4", Offset = "0xB178E4", VA = "0xB178E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public bool IsValid
		{
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0xB17928", Offset = "0xB17928", VA = "0xB17928")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xB17800", Offset = "0xB17800", VA = "0xB17800")]
		private void Init()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xB17960", Offset = "0xB17960", VA = "0xB17960")]
		public AudioClip GetClip()
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xB17998", Offset = "0xB17998", VA = "0xB17998")]
		public float GetClipLength(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xB179D8", Offset = "0xB179D8", VA = "0xB179D8")]
		public int PlaySound(float delaySecs = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xB17A20", Offset = "0xB17A20", VA = "0xB17A20")]
		public int PlaySoundAt(Vector3 pos, float delaySecs = 0f, float volume = 1f, float pitchMultiplier = 1f)
		{
			return default(int);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xB17AA0", Offset = "0xB17AA0", VA = "0xB17AA0")]
		public void SetOnFinished(Action onFinished)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xB17AE0", Offset = "0xB17AE0", VA = "0xB17AE0")]
		public void SetOnFinished(Action<object> onFinished, object obj)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xB17B30", Offset = "0xB17B30", VA = "0xB17B30")]
		public bool StopSound()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xB17B68", Offset = "0xB17B68", VA = "0xB17B68")]
		public void AttachToParent(Transform parent)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xB17BA8", Offset = "0xB17BA8", VA = "0xB17BA8")]
		public void DetachFromParent()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xB17BE0", Offset = "0xB17BE0", VA = "0xB17BE0")]
		public SoundFXRef()
		{
		}
	}
}
namespace Silhouette
{
	[Token(Token = "0x200016F")]
	public class CreditsLanternManager : MonoBehaviour
	{
		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F27C", Offset = "0x63F27C")]
		private sealed class <LightFade>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool onOff;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CreditsLanternManager <>4__this;

			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lerpValue>5__2;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <speed>5__3;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool <fadeFinished>5__4;

			[Token(Token = "0x170000E1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0xAFBCA4", Offset = "0xAFBCA4", VA = "0xAFBCA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0xAFBCEC", Offset = "0xAFBCEC", VA = "0xAFBCEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xAFBA48", Offset = "0xAFBA48", VA = "0xAFBA48")]
			[DebuggerHidden]
			public <LightFade>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xAFBA74", Offset = "0xAFBA74", VA = "0xAFBA74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xAFBA78", Offset = "0xAFBA78", VA = "0xAFBA78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xAFBCAC", Offset = "0xAFBCAC", VA = "0xAFBCAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TeleportNode teleportNode;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator lanternAnimator;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine lightCoroutine;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Light _lanternSpotLight;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource lanternAudioSource;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float lightInstensityAtStart;

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xC7B2FC", Offset = "0xC7B2FC", VA = "0xC7B2FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xC7B3F8", Offset = "0xC7B3F8", VA = "0xC7B3F8")]
		public void SwitchLight(bool onOff)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xC7B450", Offset = "0xC7B450", VA = "0xC7B450")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x644138", Offset = "0x644138")]
		private IEnumerator LightFade(bool onOff)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xC7B4D0", Offset = "0xC7B4D0", VA = "0xC7B4D0")]
		public CreditsLanternManager()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public class CreditsOptionalAnimsManager : MonoBehaviour
	{
		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int minFinishedPuzzles;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject creditsAnim;

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xC7B4D8", Offset = "0xC7B4D8", VA = "0xC7B4D8")]
		public void ActivateAnim()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xC7B578", Offset = "0xC7B578", VA = "0xC7B578")]
		public CreditsOptionalAnimsManager()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class FollowEyes : MonoBehaviour
	{
		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cameraFollow;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float cameraDistance;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float smoothTime;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 velocity;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool axeYfree;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 cameraPos;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 targetPos;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 projection;

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xC800C4", Offset = "0xC800C4", VA = "0xC800C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xC80214", Offset = "0xC80214", VA = "0xC80214")]
		private void Update()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xC80478", Offset = "0xC80478", VA = "0xC80478")]
		public FollowEyes()
		{
		}
	}
	[Token(Token = "0x2000173")]
	public class IntroAnimLaunchBeachOnEnd : StateMachineBehaviour
	{
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xD5A4D0", Offset = "0xD5A4D0", VA = "0xD5A4D0", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xD5A568", Offset = "0xD5A568", VA = "0xD5A568")]
		public IntroAnimLaunchBeachOnEnd()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class MenuCreditsActivator : MonoBehaviour
	{
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xD5F3A4", Offset = "0xD5F3A4", VA = "0xD5F3A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xD5F424", Offset = "0xD5F424", VA = "0xD5F424")]
		public MenuCreditsActivator()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class PanelController : MonoBehaviour
	{
		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F28C", Offset = "0x63F28C")]
		private sealed class <StartPanelShow>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelController <>4__this;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <index>5__2;

			[Token(Token = "0x170000E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E1")]
				[Address(RVA = "0xB038E4", Offset = "0xB038E4", VA = "0xB038E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E3")]
				[Address(RVA = "0xB0392C", Offset = "0xB0392C", VA = "0xB0392C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0xB031FC", Offset = "0xB031FC", VA = "0xB031FC")]
			[DebuggerHidden]
			public <StartPanelShow>d__32(int <>1__state)
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xB03228", Offset = "0xB03228", VA = "0xB03228", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0xB0322C", Offset = "0xB0322C", VA = "0xB0322C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0xB038EC", Offset = "0xB038EC", VA = "0xB038EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F29C", Offset = "0x63F29C")]
		private sealed class <Fade>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject go;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PanelController <>4__this;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool fadeIn;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Image <image>5__2;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TextMeshProUGUI <text>5__3;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <time>5__4;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <ratio>5__5;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float <t>5__6;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Color <start>5__7;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private Color <end>5__8;

			[Token(Token = "0x170000E5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E7")]
				[Address(RVA = "0xB031AC", Offset = "0xB031AC", VA = "0xB031AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E9")]
				[Address(RVA = "0xB031F4", Offset = "0xB031F4", VA = "0xB031F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0xB02EC4", Offset = "0xB02EC4", VA = "0xB02EC4")]
			[DebuggerHidden]
			public <Fade>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0xB02EF0", Offset = "0xB02EF0", VA = "0xB02EF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0xB02EF4", Offset = "0xB02EF4", VA = "0xB02EF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0xB031B4", Offset = "0xB031B4", VA = "0xB031B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject instantLogo;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject instantPanel;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject instantText;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[] panelsArray;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI[] textArray;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Sprite[] spritesArray;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int imageId;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float timePanel;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float timeBetweenPanels;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int panelId;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int stringId;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string sceneToLoad;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool fadeIsRunning;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool fadeTextIsRunning;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool theEndOfPanel;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool isSkipping;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float timeFadeInFadeOut;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool isNextClicked;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int currentCounting;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool isCoroutineRunning;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float timerC;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Coroutine panelCoroutine;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent whenThePanelStarts;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent whenThePanelFinish;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public ParticleSystem particles;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool lastText;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool lastLogo;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int caseLast;

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xB0D6A0", Offset = "0xB0D6A0", VA = "0xB0D6A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xB0D748", Offset = "0xB0D748", VA = "0xB0D748")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xB0D860", Offset = "0xB0D860", VA = "0xB0D860")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xB0D828", Offset = "0xB0D828", VA = "0xB0D828")]
		private void StartCoroutinePanel()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xB0D898", Offset = "0xB0D898", VA = "0xB0D898")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6441E8", Offset = "0x6441E8")]
		private IEnumerator StartPanelShow()
		{
			return null;
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xB0D904", Offset = "0xB0D904", VA = "0xB0D904")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x644248", Offset = "0x644248")]
		private IEnumerator Fade(GameObject go, bool fadeIn)
		{
			return null;
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xB0D988", Offset = "0xB0D988", VA = "0xB0D988")]
		public void NextInfo()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xB0D994", Offset = "0xB0D994", VA = "0xB0D994")]
		public PanelController()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xB0D9F8", Offset = "0xB0D9F8", VA = "0xB0D9F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6442A8", Offset = "0x6442A8")]
		private bool <StartPanelShow>b__32_0()
		{
			return default(bool);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xB0DA08", Offset = "0xB0DA08", VA = "0xB0DA08")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6442B8", Offset = "0x6442B8")]
		private bool <StartPanelShow>b__32_1()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000178")]
	public class PostIntroAnimSceneLoad : StateMachineBehaviour
	{
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xB0EF80", Offset = "0xB0EF80", VA = "0xB0EF80", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xB0F018", Offset = "0xB0F018", VA = "0xB0F018")]
		public PostIntroAnimSceneLoad()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class PostIntroSceneLaunch : MonoBehaviour
	{
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xB0F020", Offset = "0xB0F020", VA = "0xB0F020")]
		public void SceneLaunch()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xB0F094", Offset = "0xB0F094", VA = "0xB0F094")]
		public PostIntroSceneLaunch()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public class SwappingLogo : MonoBehaviour
	{
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F2AC", Offset = "0x63F2AC")]
		private sealed class <Swap>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SwappingLogo <>4__this;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Image <image>5__2;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <index>5__3;

			[Token(Token = "0x170000E7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007F9")]
				[Address(RVA = "0xB04804", Offset = "0xB04804", VA = "0xB04804", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007FB")]
				[Address(RVA = "0xB0484C", Offset = "0xB0484C", VA = "0xB0484C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0xB04520", Offset = "0xB04520", VA = "0xB04520")]
			[DebuggerHidden]
			public <Swap>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0xB0454C", Offset = "0xB0454C", VA = "0xB0454C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0xB04550", Offset = "0xB04550", VA = "0xB04550", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0xB0480C", Offset = "0xB0480C", VA = "0xB0480C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200017C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F2BC", Offset = "0x63F2BC")]
		private sealed class <Fade>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SwappingLogo <>4__this;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Image image;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool fadeIn;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <time>5__2;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <ratio>5__3;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <t>5__4;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color <start>5__5;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <end>5__6;

			[Token(Token = "0x170000E9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007FF")]
				[Address(RVA = "0xB044D0", Offset = "0xB044D0", VA = "0xB044D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000801")]
				[Address(RVA = "0xB04518", Offset = "0xB04518", VA = "0xB04518", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0xB0432C", Offset = "0xB0432C", VA = "0xB0432C")]
			[DebuggerHidden]
			public <Fade>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xB04358", Offset = "0xB04358", VA = "0xB04358", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xB0435C", Offset = "0xB0435C", VA = "0xB0435C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0xB044D8", Offset = "0xB044D8", VA = "0xB044D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite[] logos;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float timeBetweenLogos;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float timeFadeInFadeOut;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool fadeIsRunning;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool logosEnd;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string sceneToLoad;

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xB18088", Offset = "0xB18088", VA = "0xB18088")]
		private void Start()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xB18120", Offset = "0xB18120", VA = "0xB18120")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xB180B4", Offset = "0xB180B4", VA = "0xB180B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x644368", Offset = "0x644368")]
		private IEnumerator Swap()
		{
			return null;
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xB18198", Offset = "0xB18198", VA = "0xB18198")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6443C8", Offset = "0x6443C8")]
		private IEnumerator Fade(Image image, bool fadeIn)
		{
			return null;
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xB18130", Offset = "0xB18130", VA = "0xB18130")]
		public void LoadScene()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xB1821C", Offset = "0xB1821C", VA = "0xB1821C")]
		public SwappingLogo()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xB18270", Offset = "0xB18270", VA = "0xB18270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644428", Offset = "0x644428")]
		private bool <Swap>b__8_0()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xB18280", Offset = "0xB18280", VA = "0xB18280")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x644438", Offset = "0x644438")]
		private bool <Swap>b__8_1()
		{
			return default(bool);
		}
	}
}
