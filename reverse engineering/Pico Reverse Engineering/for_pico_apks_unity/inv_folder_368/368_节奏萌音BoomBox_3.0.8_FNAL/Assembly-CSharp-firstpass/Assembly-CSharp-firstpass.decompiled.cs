using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using LiteNetLib.Layers;
using LiteNetLib.Utils;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace LiteNetLib
{
	[Token(Token = "0x2000002")]
	internal abstract class BaseChannel
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly NetPeer Peer;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly Queue<NetPacket> OutgoingQueue;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _isAddedToPeerChannelSendQueue;

		[Token(Token = "0x17000001")]
		public int PacketsInQueue
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x1540A98", Offset = "0x1540A98", VA = "0x1540A98")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1540AE8", Offset = "0x1540AE8", VA = "0x1540AE8")]
		protected BaseChannel(NetPeer peer)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1540B70", Offset = "0x1540B70", VA = "0x1540B70")]
		public void AddToQueue(NetPacket packet)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1540C44", Offset = "0x1540C44", VA = "0x1540C44")]
		protected void AddToPeerChannelSendQueue()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1540D60", Offset = "0x1540D60", VA = "0x1540D60")]
		public bool SendAndCheckQueue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		protected abstract bool SendNextPackets();

		[Token(Token = "0x6000007")]
		public abstract bool ProcessPacket(NetPacket packet);
	}
	[Token(Token = "0x2000003")]
	internal enum ConnectionRequestResult
	{
		[Token(Token = "0x4000005")]
		None,
		[Token(Token = "0x4000006")]
		Accept,
		[Token(Token = "0x4000007")]
		Reject,
		[Token(Token = "0x4000008")]
		RejectForce
	}
	[Token(Token = "0x2000004")]
	public class ConnectionRequest
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetManager _listener;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _used;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly NetDataReader Data;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA048", Offset = "0xBDA048")]
		private ConnectionRequestResult <Result>k__BackingField;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal long ConnectionTime;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal byte ConnectionNumber;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly IPEndPoint RemoteEndPoint;

		[Token(Token = "0x17000002")]
		internal ConnectionRequestResult Result
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1540DA4", Offset = "0x1540DA4", VA = "0x1540DA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA308", Offset = "0xBDA308")]
			get
			{
				return default(ConnectionRequestResult);
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1540DAC", Offset = "0x1540DAC", VA = "0x1540DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA318", Offset = "0xBDA318")]
			private set
			{
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1540DB4", Offset = "0x1540DB4", VA = "0x1540DB4")]
		private bool TryActivate()
		{
			return default(bool);
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1540DE0", Offset = "0x1540DE0", VA = "0x1540DE0")]
		internal void UpdateRequest(NetConnectRequestPacket connRequest)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1540E10", Offset = "0x1540E10", VA = "0x1540E10")]
		internal ConnectionRequest(long connectionId, byte connectionNumber, NetDataReader netDataReader, IPEndPoint endPoint, NetManager listener)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1540E6C", Offset = "0x1540E6C", VA = "0x1540E6C")]
		public NetPeer AcceptIfKey(string key)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x15414F0", Offset = "0x15414F0", VA = "0x15414F0")]
		public NetPeer Accept()
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1541558", Offset = "0x1541558", VA = "0x1541558")]
		public void Reject(byte[] rejectData, int start, int length, bool force)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x15415F0", Offset = "0x15415F0", VA = "0x15415F0")]
		public void Reject(byte[] rejectData, int start, int length)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x15415F8", Offset = "0x15415F8", VA = "0x15415F8")]
		public void RejectForce(byte[] rejectData, int start, int length)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1541600", Offset = "0x1541600", VA = "0x1541600")]
		public void RejectForce()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1541614", Offset = "0x1541614", VA = "0x1541614")]
		public void RejectForce(byte[] rejectData)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1541634", Offset = "0x1541634", VA = "0x1541634")]
		public void RejectForce(NetDataWriter rejectData)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x154165C", Offset = "0x154165C", VA = "0x154165C")]
		public void Reject()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1541670", Offset = "0x1541670", VA = "0x1541670")]
		public void Reject(byte[] rejectData)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1541690", Offset = "0x1541690", VA = "0x1541690")]
		public void Reject(NetDataWriter rejectData)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public enum UnconnectedMessageType
	{
		[Token(Token = "0x4000011")]
		BasicMessage,
		[Token(Token = "0x4000012")]
		Broadcast
	}
	[Token(Token = "0x2000006")]
	public enum DisconnectReason
	{
		[Token(Token = "0x4000014")]
		ConnectionFailed,
		[Token(Token = "0x4000015")]
		Timeout,
		[Token(Token = "0x4000016")]
		HostUnreachable,
		[Token(Token = "0x4000017")]
		NetworkUnreachable,
		[Token(Token = "0x4000018")]
		RemoteConnectionClose,
		[Token(Token = "0x4000019")]
		DisconnectPeerCalled,
		[Token(Token = "0x400001A")]
		ConnectionRejected,
		[Token(Token = "0x400001B")]
		InvalidProtocol,
		[Token(Token = "0x400001C")]
		UnknownHost,
		[Token(Token = "0x400001D")]
		Reconnect,
		[Token(Token = "0x400001E")]
		PeerToPeerConnection
	}
	[Token(Token = "0x2000007")]
	public struct DisconnectInfo
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DisconnectReason Reason;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public SocketError SocketErrorCode;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public NetPacketReader AdditionalData;
	}
	[Token(Token = "0x2000008")]
	public interface INetEventListener
	{
		[Token(Token = "0x6000018")]
		void OnPeerConnected(NetPeer peer);

		[Token(Token = "0x6000019")]
		void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

		[Token(Token = "0x600001A")]
		void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

		[Token(Token = "0x600001B")]
		void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod);

		[Token(Token = "0x600001C")]
		void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

		[Token(Token = "0x600001D")]
		void OnNetworkLatencyUpdate(NetPeer peer, int latency);

		[Token(Token = "0x600001E")]
		void OnConnectionRequest(ConnectionRequest request);
	}
	[Token(Token = "0x2000009")]
	public interface IDeliveryEventListener
	{
		[Token(Token = "0x600001F")]
		void OnMessageDelivered(NetPeer peer, object userData);
	}
	[Token(Token = "0x200000A")]
	public interface INtpEventListener
	{
		[Token(Token = "0x6000020")]
		void OnNtpResponse(NtpPacket packet);
	}
	[Token(Token = "0x200000B")]
	public class EventBasedNetListener : INetEventListener, IDeliveryEventListener, INtpEventListener
	{
		[Token(Token = "0x200007D")]
		public delegate void OnPeerConnected(NetPeer peer);

		[Token(Token = "0x200007E")]
		public delegate void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

		[Token(Token = "0x200007F")]
		public delegate void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

		[Token(Token = "0x2000080")]
		public delegate void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod);

		[Token(Token = "0x2000081")]
		public delegate void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

		[Token(Token = "0x2000082")]
		public delegate void OnNetworkLatencyUpdate(NetPeer peer, int latency);

		[Token(Token = "0x2000083")]
		public delegate void OnConnectionRequest(ConnectionRequest request);

		[Token(Token = "0x2000084")]
		public delegate void OnDeliveryEvent(NetPeer peer, object userData);

		[Token(Token = "0x2000085")]
		public delegate void OnNtpResponseEvent(NtpPacket packet);

		[Token(Token = "0x14000001")]
		public event OnPeerConnected PeerConnectedEvent
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x15422BC", Offset = "0x15422BC", VA = "0x15422BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA328", Offset = "0xBDA328")]
			add
			{
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1542360", Offset = "0x1542360", VA = "0x1542360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA338", Offset = "0xBDA338")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event OnPeerDisconnected PeerDisconnectedEvent
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1542404", Offset = "0x1542404", VA = "0x1542404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA348", Offset = "0xBDA348")]
			add
			{
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x15424A8", Offset = "0x15424A8", VA = "0x15424A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA358", Offset = "0xBDA358")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event OnNetworkError NetworkErrorEvent
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x154254C", Offset = "0x154254C", VA = "0x154254C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA368", Offset = "0xBDA368")]
			add
			{
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x15425F0", Offset = "0x15425F0", VA = "0x15425F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA378", Offset = "0xBDA378")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event OnNetworkReceive NetworkReceiveEvent
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1542694", Offset = "0x1542694", VA = "0x1542694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA388", Offset = "0xBDA388")]
			add
			{
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1542738", Offset = "0x1542738", VA = "0x1542738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA398", Offset = "0xBDA398")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event OnNetworkReceiveUnconnected NetworkReceiveUnconnectedEvent
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x15427DC", Offset = "0x15427DC", VA = "0x15427DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA3A8", Offset = "0xBDA3A8")]
			add
			{
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1542880", Offset = "0x1542880", VA = "0x1542880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA3B8", Offset = "0xBDA3B8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event OnNetworkLatencyUpdate NetworkLatencyUpdateEvent
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1542924", Offset = "0x1542924", VA = "0x1542924")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA3C8", Offset = "0xBDA3C8")]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x15429C8", Offset = "0x15429C8", VA = "0x15429C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA3D8", Offset = "0xBDA3D8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event OnConnectionRequest ConnectionRequestEvent
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1542A6C", Offset = "0x1542A6C", VA = "0x1542A6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA3E8", Offset = "0xBDA3E8")]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1542B10", Offset = "0x1542B10", VA = "0x1542B10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA3F8", Offset = "0xBDA3F8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event OnDeliveryEvent DeliveryEvent
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x1542BB4", Offset = "0x1542BB4", VA = "0x1542BB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA408", Offset = "0xBDA408")]
			add
			{
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x1542C58", Offset = "0x1542C58", VA = "0x1542C58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA418", Offset = "0xBDA418")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event OnNtpResponseEvent NtpResponseEvent
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x1542CFC", Offset = "0x1542CFC", VA = "0x1542CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA428", Offset = "0xBDA428")]
			add
			{
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x1542DA0", Offset = "0x1542DA0", VA = "0x1542DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA438", Offset = "0xBDA438")]
			remove
			{
			}
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1542E44", Offset = "0x1542E44", VA = "0x1542E44")]
		public void ClearPeerConnectedEvent()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1542E4C", Offset = "0x1542E4C", VA = "0x1542E4C")]
		public void ClearPeerDisconnectedEvent()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1542E54", Offset = "0x1542E54", VA = "0x1542E54")]
		public void ClearNetworkErrorEvent()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1542E5C", Offset = "0x1542E5C", VA = "0x1542E5C")]
		public void ClearNetworkReceiveEvent()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1542E64", Offset = "0x1542E64", VA = "0x1542E64")]
		public void ClearNetworkReceiveUnconnectedEvent()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1542E6C", Offset = "0x1542E6C", VA = "0x1542E6C")]
		public void ClearNetworkLatencyUpdateEvent()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1542E74", Offset = "0x1542E74", VA = "0x1542E74")]
		public void ClearConnectionRequestEvent()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1542E7C", Offset = "0x1542E7C", VA = "0x1542E7C")]
		public void ClearDeliveryEvent()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1542E84", Offset = "0x1542E84", VA = "0x1542E84")]
		public void ClearNtpResponseEvent()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1542E8C", Offset = "0x1542E8C", VA = "0x1542E8C", Slot = "4")]
		private void LiteNetLib.INetEventListener.OnPeerConnected(NetPeer peer)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1543230", Offset = "0x1543230", VA = "0x1543230", Slot = "5")]
		private void LiteNetLib.INetEventListener.OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1543660", Offset = "0x1543660", VA = "0x1543660", Slot = "6")]
		private void LiteNetLib.INetEventListener.OnNetworkError(IPEndPoint endPoint, SocketError socketErrorCode)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1543A7C", Offset = "0x1543A7C", VA = "0x1543A7C", Slot = "7")]
		private void LiteNetLib.INetEventListener.OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1543E9C", Offset = "0x1543E9C", VA = "0x1543E9C", Slot = "8")]
		private void LiteNetLib.INetEventListener.OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x15442BC", Offset = "0x15442BC", VA = "0x15442BC", Slot = "9")]
		private void LiteNetLib.INetEventListener.OnNetworkLatencyUpdate(NetPeer peer, int latency)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x15446D8", Offset = "0x15446D8", VA = "0x15446D8", Slot = "10")]
		private void LiteNetLib.INetEventListener.OnConnectionRequest(ConnectionRequest request)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1544A7C", Offset = "0x1544A7C", VA = "0x1544A7C", Slot = "11")]
		private void LiteNetLib.IDeliveryEventListener.OnMessageDelivered(NetPeer peer, object userData)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1544E74", Offset = "0x1544E74", VA = "0x1544E74", Slot = "12")]
		private void LiteNetLib.INtpEventListener.OnNtpResponse(NtpPacket packet)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1545218", Offset = "0x1545218", VA = "0x1545218")]
		public EventBasedNetListener()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public enum NatAddressType
	{
		[Token(Token = "0x400002C")]
		Internal,
		[Token(Token = "0x400002D")]
		External
	}
	[Token(Token = "0x200000D")]
	public interface INatPunchListener
	{
		[Token(Token = "0x6000046")]
		void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

		[Token(Token = "0x6000047")]
		void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);
	}
	[Token(Token = "0x200000E")]
	public class EventBasedNatPunchListener : INatPunchListener
	{
		[Token(Token = "0x2000086")]
		public delegate void OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token);

		[Token(Token = "0x2000087")]
		public delegate void OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token);

		[Token(Token = "0x1400000A")]
		public event OnNatIntroductionRequest NatIntroductionRequest
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x15416B8", Offset = "0x15416B8", VA = "0x15416B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA448", Offset = "0xBDA448")]
			add
			{
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x154175C", Offset = "0x154175C", VA = "0x154175C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA458", Offset = "0xBDA458")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event OnNatIntroductionSuccess NatIntroductionSuccess
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1541800", Offset = "0x1541800", VA = "0x1541800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA468", Offset = "0xBDA468")]
			add
			{
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x15418A4", Offset = "0x15418A4", VA = "0x15418A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA478", Offset = "0xBDA478")]
			remove
			{
			}
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1541948", Offset = "0x1541948", VA = "0x1541948", Slot = "4")]
		private void LiteNetLib.INatPunchListener.OnNatIntroductionRequest(IPEndPoint localEndPoint, IPEndPoint remoteEndPoint, string token)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1541D68", Offset = "0x1541D68", VA = "0x1541D68", Slot = "5")]
		private void LiteNetLib.INatPunchListener.OnNatIntroductionSuccess(IPEndPoint targetEndPoint, NatAddressType type, string token)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x15421AC", Offset = "0x15421AC", VA = "0x15421AC")]
		public EventBasedNatPunchListener()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public sealed class NatPunchModule
	{
		[Token(Token = "0x2000088")]
		private struct RequestEventData
		{
			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IPEndPoint LocalEndPoint;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IPEndPoint RemoteEndPoint;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Token;
		}

		[Token(Token = "0x2000089")]
		private struct SuccessEventData
		{
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IPEndPoint TargetEndPoint;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public NatAddressType Type;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Token;
		}

		[Token(Token = "0x200008A")]
		private class NatIntroduceRequestPacket
		{
			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA298", Offset = "0xBDA298")]
			private IPEndPoint <Internal>k__BackingField;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA2A8", Offset = "0xBDA2A8")]
			private string <Token>k__BackingField;

			[Token(Token = "0x17000050")]
			public IPEndPoint Internal
			{
				[Token(Token = "0x60003D7")]
				[Address(RVA = "0x1546C54", Offset = "0x1546C54", VA = "0x1546C54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB3D8", Offset = "0xBDB3D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D8")]
				[Address(RVA = "0x1546C5C", Offset = "0x1546C5C", VA = "0x1546C5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB3E8", Offset = "0xBDB3E8")]
				set
				{
				}
			}

			[Token(Token = "0x17000051")]
			public string Token
			{
				[Token(Token = "0x60003D9")]
				[Address(RVA = "0x1546C64", Offset = "0x1546C64", VA = "0x1546C64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB3F8", Offset = "0xBDB3F8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DA")]
				[Address(RVA = "0x1546C6C", Offset = "0x1546C6C", VA = "0x1546C6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB408", Offset = "0xBDB408")]
				set
				{
				}
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1546514", Offset = "0x1546514", VA = "0x1546514")]
			public NatIntroduceRequestPacket()
			{
			}
		}

		[Token(Token = "0x200008B")]
		private class NatIntroduceResponsePacket
		{
			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA2B8", Offset = "0xBDA2B8")]
			private IPEndPoint <Internal>k__BackingField;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA2C8", Offset = "0xBDA2C8")]
			private IPEndPoint <External>k__BackingField;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA2D8", Offset = "0xBDA2D8")]
			private string <Token>k__BackingField;

			[Token(Token = "0x17000052")]
			public IPEndPoint Internal
			{
				[Token(Token = "0x60003DC")]
				[Address(RVA = "0x1546C74", Offset = "0x1546C74", VA = "0x1546C74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB418", Offset = "0xBDB418")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DD")]
				[Address(RVA = "0x1546C7C", Offset = "0x1546C7C", VA = "0x1546C7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB428", Offset = "0xBDB428")]
				set
				{
				}
			}

			[Token(Token = "0x17000053")]
			public IPEndPoint External
			{
				[Token(Token = "0x60003DE")]
				[Address(RVA = "0x1546C84", Offset = "0x1546C84", VA = "0x1546C84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB438", Offset = "0xBDB438")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003DF")]
				[Address(RVA = "0x1546C8C", Offset = "0x1546C8C", VA = "0x1546C8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB448", Offset = "0xBDB448")]
				set
				{
				}
			}

			[Token(Token = "0x17000054")]
			public string Token
			{
				[Token(Token = "0x60003E0")]
				[Address(RVA = "0x1546C94", Offset = "0x1546C94", VA = "0x1546C94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB458", Offset = "0xBDB458")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003E1")]
				[Address(RVA = "0x1546C9C", Offset = "0x1546C9C", VA = "0x1546C9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB468", Offset = "0xBDB468")]
				set
				{
				}
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1545FFC", Offset = "0x1545FFC", VA = "0x1545FFC")]
			public NatIntroduceResponsePacket()
			{
			}
		}

		[Token(Token = "0x200008C")]
		private class NatPunchPacket
		{
			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA2E8", Offset = "0xBDA2E8")]
			private string <Token>k__BackingField;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA2F8", Offset = "0xBDA2F8")]
			private bool <IsExternal>k__BackingField;

			[Token(Token = "0x17000055")]
			public string Token
			{
				[Token(Token = "0x60003E3")]
				[Address(RVA = "0x1546CA4", Offset = "0x1546CA4", VA = "0x1546CA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB478", Offset = "0xBDB478")]
				get
				{
					return null;
				}
				[Token(Token = "0x60003E4")]
				[Address(RVA = "0x1546CAC", Offset = "0x1546CAC", VA = "0x1546CAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB488", Offset = "0xBDB488")]
				set
				{
				}
			}

			[Token(Token = "0x17000056")]
			public bool IsExternal
			{
				[Token(Token = "0x60003E5")]
				[Address(RVA = "0x1546CB4", Offset = "0x1546CB4", VA = "0x1546CB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB498", Offset = "0xBDB498")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003E6")]
				[Address(RVA = "0x1546CBC", Offset = "0x1546CBC", VA = "0x1546CBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDB4A8", Offset = "0xBDB4A8")]
				set
				{
				}
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1546750", Offset = "0x1546750", VA = "0x1546750")]
			public NatPunchPacket()
			{
			}
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSocket _socket;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Queue<RequestEventData> _requestEvents;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Queue<SuccessEventData> _successEvents;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly NetDataReader _cacheReader;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly NetDataWriter _cacheWriter;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacketProcessor _netPacketProcessor;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private INatPunchListener _natPunchListener;

		[Token(Token = "0x4000037")]
		public const int MaxTokenLength = 256;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1545C40", Offset = "0x1545C40", VA = "0x1545C40")]
		internal NatPunchModule(NetSocket socket)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1545E4C", Offset = "0x1545E4C", VA = "0x1545E4C")]
		internal void ProcessMessage(IPEndPoint senderEndPoint, NetPacket packet)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1545F2C", Offset = "0x1545F2C", VA = "0x1545F2C")]
		public void Init(INatPunchListener listener)
		{
		}

		[Token(Token = "0x6000052")]
		private void Send<T>(T packet, IPEndPoint target) where T : class, new()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1545F34", Offset = "0x1545F34", VA = "0x1545F34")]
		public void NatIntroduce(IPEndPoint hostInternal, IPEndPoint hostExternal, IPEndPoint clientInternal, IPEndPoint clientExternal, string additionalInfo)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1546004", Offset = "0x1546004", VA = "0x1546004")]
		public void PollEvents()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x154634C", Offset = "0x154634C", VA = "0x154634C")]
		public void SendNatIntroduceRequest(string host, int port, string additionalInfo)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x15463E4", Offset = "0x15463E4", VA = "0x15463E4")]
		public void SendNatIntroduceRequest(IPEndPoint masterServerEndPoint, string additionalInfo)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x154651C", Offset = "0x154651C", VA = "0x154651C")]
		private void OnNatIntroductionRequest(NatIntroduceRequestPacket req, IPEndPoint senderEndPoint)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x154660C", Offset = "0x154660C", VA = "0x154660C")]
		private void OnNatIntroductionResponse(NatIntroduceResponsePacket req)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1546B34", Offset = "0x1546B34", VA = "0x1546B34")]
		private void OnNatPunch(NatPunchPacket req, IPEndPoint senderEndPoint)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public enum DeliveryMethod : byte
	{
		[Token(Token = "0x4000039")]
		Unreliable = 4,
		[Token(Token = "0x400003A")]
		ReliableUnordered = 0,
		[Token(Token = "0x400003B")]
		Sequenced = 1,
		[Token(Token = "0x400003C")]
		ReliableOrdered = 2,
		[Token(Token = "0x400003D")]
		ReliableSequenced = 3
	}
	[Token(Token = "0x2000011")]
	public static class NetConstants
	{
		[Token(Token = "0x400003E")]
		public const int DefaultWindowSize = 64;

		[Token(Token = "0x400003F")]
		public const int SocketBufferSize = 1048576;

		[Token(Token = "0x4000040")]
		public const int SocketTTL = 255;

		[Token(Token = "0x4000041")]
		public const int HeaderSize = 1;

		[Token(Token = "0x4000042")]
		public const int ChanneledHeaderSize = 4;

		[Token(Token = "0x4000043")]
		public const int FragmentHeaderSize = 6;

		[Token(Token = "0x4000044")]
		public const int FragmentedHeaderTotalSize = 10;

		[Token(Token = "0x4000045")]
		public const ushort MaxSequence = 32768;

		[Token(Token = "0x4000046")]
		public const ushort HalfMaxSequence = 16384;

		[Token(Token = "0x4000047")]
		internal const int ProtocolId = 11;

		[Token(Token = "0x4000048")]
		internal const int MaxUdpHeaderSize = 68;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly int[] PossibleMtu;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly int MaxPacketSize;

		[Token(Token = "0x400004B")]
		public const byte MaxConnectionNumber = 4;

		[Token(Token = "0x400004C")]
		public const int PacketPoolSize = 1000;
	}
	[Token(Token = "0x2000012")]
	public class InvalidPacketException : ArgumentException
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x15456CC", Offset = "0x15456CC", VA = "0x15456CC")]
		public InvalidPacketException(string message)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class TooBigPacketException : InvalidPacketException
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1E76124", Offset = "0x1E76124", VA = "0x1E76124")]
		public TooBigPacketException(string message)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public enum NetLogLevel
	{
		[Token(Token = "0x400004E")]
		Warning,
		[Token(Token = "0x400004F")]
		Error,
		[Token(Token = "0x4000050")]
		Trace,
		[Token(Token = "0x4000051")]
		Info
	}
	[Token(Token = "0x2000015")]
	public interface INetLogger
	{
		[Token(Token = "0x600005D")]
		void WriteNet(NetLogLevel level, string str, params object[] args);
	}
	[Token(Token = "0x2000016")]
	public static class NetDebug
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static INetLogger Logger;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object DebugLogLock;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1547460", Offset = "0x1547460", VA = "0x1547460")]
		private static void WriteLogic(NetLogLevel logLevel, string str, params object[] args)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1547660", Offset = "0x1547660", VA = "0x1547660")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xBDA488", Offset = "0xBDA488")]
		internal static void Write(string str, params object[] args)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x15476D8", Offset = "0x15476D8", VA = "0x15476D8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xBDA4C0", Offset = "0xBDA4C0")]
		internal static void Write(NetLogLevel level, string str, params object[] args)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1547754", Offset = "0x1547754", VA = "0x1547754")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xBDA4F8", Offset = "0xBDA4F8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xBDA4F8", Offset = "0xBDA4F8")]
		internal static void WriteForce(string str, params object[] args)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x15477CC", Offset = "0x15477CC", VA = "0x15477CC")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xBDA558", Offset = "0xBDA558")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xBDA558", Offset = "0xBDA558")]
		internal static void WriteForce(NetLogLevel level, string str, params object[] args)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1541094", Offset = "0x1541094", VA = "0x1541094")]
		internal static void WriteError(string str, params object[] args)
		{
		}
	}
	[Token(Token = "0x2000017")]
	public enum IPv6Mode
	{
		[Token(Token = "0x4000055")]
		Disabled,
		[Token(Token = "0x4000056")]
		SeparateSocket,
		[Token(Token = "0x4000057")]
		DualMode
	}
	[Token(Token = "0x2000018")]
	public sealed class NetPacketReader : NetDataReader
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private NetPacket _packet;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly NetManager _manager;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetEvent _evt;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x154793C", Offset = "0x154793C", VA = "0x154793C")]
		internal NetPacketReader(NetManager manager, NetEvent evt)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1549138", Offset = "0x1549138", VA = "0x1549138")]
		internal void SetSource(NetPacket packet, int headerSize)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x154977C", Offset = "0x154977C", VA = "0x154977C")]
		internal void RecycleInternal()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x154EA24", Offset = "0x154EA24", VA = "0x154EA24")]
		public void Recycle()
		{
		}
	}
	[Token(Token = "0x2000019")]
	internal sealed class NetEvent
	{
		[Token(Token = "0x200008D")]
		public enum EType
		{
			[Token(Token = "0x400028B")]
			Connect,
			[Token(Token = "0x400028C")]
			Disconnect,
			[Token(Token = "0x400028D")]
			Receive,
			[Token(Token = "0x400028E")]
			ReceiveUnconnected,
			[Token(Token = "0x400028F")]
			Error,
			[Token(Token = "0x4000290")]
			ConnectionLatencyUpdated,
			[Token(Token = "0x4000291")]
			Broadcast,
			[Token(Token = "0x4000292")]
			ConnectionRequest,
			[Token(Token = "0x4000293")]
			MessageDelivered
		}

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NetEvent Next;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EType Type;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NetPeer Peer;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IPEndPoint RemoteEndPoint;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public object UserData;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Latency;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public SocketError ErrorCode;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DisconnectReason DisconnectReason;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ConnectionRequest ConnectionRequest;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DeliveryMethod DeliveryMethod;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly NetPacketReader DataReader;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x15478C0", Offset = "0x15478C0", VA = "0x15478C0")]
		public NetEvent(NetManager manager)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class NetManager : IEnumerable<NetPeer>, IEnumerable
	{
		[Token(Token = "0x200008E")]
		private class IPEndPointComparer : IEqualityComparer<IPEndPoint>
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x154E3C8", Offset = "0x154E3C8", VA = "0x154E3C8", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x154E428", Offset = "0x154E428", VA = "0x154E428", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return default(int);
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1548374", Offset = "0x1548374", VA = "0x1548374")]
			public IPEndPointComparer()
			{
			}
		}

		[Token(Token = "0x200008F")]
		public struct NetPeerEnumerator : IEnumerator<NetPeer>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly NetPeer _initialPeer;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private NetPeer _p;

			[Token(Token = "0x17000057")]
			public NetPeer Current
			{
				[Token(Token = "0x60003EF")]
				[Address(RVA = "0x154E4EC", Offset = "0x154E4EC", VA = "0x154E4EC", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F0")]
				[Address(RVA = "0x154E4F4", Offset = "0x154E4F4", VA = "0x154E4F4", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x154E2F0", Offset = "0x154E2F0", VA = "0x154E2F0")]
			public NetPeerEnumerator(NetPeer p)
			{
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x154E448", Offset = "0x154E448", VA = "0x154E448", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x154E44C", Offset = "0x154E44C", VA = "0x154E44C", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x154E48C", Offset = "0x154E48C", VA = "0x154E48C", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSocket _socket;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Thread _logicThread;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _manualMode;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly AutoResetEvent _updateTriggerEvent;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Queue<NetEvent> _netEventsQueue;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NetEvent _netEventPoolHead;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly INetEventListener _netEventListener;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly IDeliveryEventListener _deliveryEventListener;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly INtpEventListener _ntpEventListener;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<IPEndPoint, NetPeer> _peersDict;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly Dictionary<IPEndPoint, ConnectionRequest> _requestsDict;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Dictionary<IPEndPoint, NtpRequest> _ntpRequests;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly ReaderWriterLockSlim _peersLock;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NetPeer _headPeer;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _connectedPeersCount;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<NetPeer> _connectedPeerListCache;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NetPeer[] _peersArray;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly PacketLayerBase _extraPacketLayer;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastPeerId;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Queue<int> _peerIds;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private byte _channelsCount;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly object _eventLock;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal readonly NetPacketPool NetPacketPool;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool UnconnectedMessagesEnabled;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool NatPunchEnabled;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public int UpdateTime;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int PingInterval;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int DisconnectTimeout;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool SimulatePacketLoss;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool SimulateLatency;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int SimulationPacketLossChance;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public int SimulationMinLatency;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int SimulationMaxLatency;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool UnsyncedEvents;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		public bool UnsyncedReceiveEvent;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		public bool UnsyncedDeliveryEvent;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		public bool BroadcastReceiveEnabled;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public int ReconnectDelay;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int MaxConnectAttempts;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool ReuseAddress;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly NetStatistics Statistics;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool EnableStatistics;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public readonly NatPunchModule NatPunchModule;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool AutoRecycle;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public IPv6Mode IPv6Enabled;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int MtuOverride;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool UseSafeMtu;

		[Token(Token = "0x17000003")]
		public bool IsRunning
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x1547974", Offset = "0x1547974", VA = "0x1547974")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		public int LocalPort
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x15479A4", Offset = "0x15479A4", VA = "0x15479A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000005")]
		public NetPeer FirstPeer
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x15479C0", Offset = "0x15479C0", VA = "0x15479C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public byte ChannelsCount
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x15479E4", Offset = "0x15479E4", VA = "0x15479E4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x15479EC", Offset = "0x15479EC", VA = "0x15479EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public List<NetPeer> ConnectedPeerList
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x1547A88", Offset = "0x1547A88", VA = "0x1547A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public int ConnectedPeersCount
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x1547BBC", Offset = "0x1547BBC", VA = "0x1547BBC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000009")]
		public int ExtraPacketSizeForLayer
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x1547BE0", Offset = "0x1547BE0", VA = "0x1547BE0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1547B80", Offset = "0x1547B80", VA = "0x1547B80")]
		public NetPeer GetPeerById(int id)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1547BF8", Offset = "0x1547BF8", VA = "0x1547BF8")]
		private bool TryGetPeer(IPEndPoint endPoint, out NetPeer peer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1547C98", Offset = "0x1547C98", VA = "0x1547C98")]
		private void AddPeer(NetPeer peer)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1547DF0", Offset = "0x1547DF0", VA = "0x1547DF0")]
		private void RemovePeer(NetPeer peer)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1547E3C", Offset = "0x1547E3C", VA = "0x1547E3C")]
		private void RemovePeerInternal(NetPeer peer)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1547FC4", Offset = "0x1547FC4", VA = "0x1547FC4")]
		public NetManager(INetEventListener listener, [Optional] PacketLayerBase extraPacketLayer)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x154837C", Offset = "0x154837C", VA = "0x154837C")]
		internal void ConnectionLatencyUpdated(NetPeer fromPeer, int latency)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1548688", Offset = "0x1548688", VA = "0x1548688")]
		internal void MessageDelivered(NetPeer fromPeer, object userData)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15486D8", Offset = "0x15486D8", VA = "0x15486D8")]
		internal int SendRawAndRecycle(NetPacket packet, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1548ADC", Offset = "0x1548ADC", VA = "0x1548ADC")]
		internal int SendRaw(NetPacket packet, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1548730", Offset = "0x1548730", VA = "0x1548730")]
		internal int SendRaw(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
		{
			return default(int);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1548CE8", Offset = "0x1548CE8", VA = "0x1548CE8")]
		internal void DisconnectPeerForce(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, NetPacket eventData)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1548D1C", Offset = "0x1548D1C", VA = "0x1548D1C")]
		private void DisconnectPeer(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, bool force, byte[] data, int start, int count, NetPacket eventData)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x15483C0", Offset = "0x15483C0", VA = "0x15483C0")]
		private void CreateEvent(NetEvent.EType type, [Optional] NetPeer peer, [Optional] IPEndPoint remoteEndPoint, SocketError errorCode = SocketError.Success, int latency = 0, DisconnectReason disconnectReason = DisconnectReason.ConnectionFailed, [Optional] ConnectionRequest connectionRequest, DeliveryMethod deliveryMethod = DeliveryMethod.Unreliable, [Optional] NetPacket readerSource, [Optional] object userData)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1549158", Offset = "0x1549158", VA = "0x1549158")]
		private void ProcessEvent(NetEvent evt)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x15496CC", Offset = "0x15496CC", VA = "0x15496CC")]
		internal void RecycleEvent(NetEvent evt)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x15497D0", Offset = "0x15497D0", VA = "0x15497D0")]
		private void UpdateLogic()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x154A140", Offset = "0x154A140", VA = "0x154A140")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xBDA5B8", Offset = "0xBDA5B8")]
		private void ProcessDelayedPackets()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1549EDC", Offset = "0x1549EDC", VA = "0x1549EDC")]
		private void ProcessNtpRequests(int elapsedMilliseconds)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x154A144", Offset = "0x154A144", VA = "0x154A144")]
		public void ManualUpdate(int elapsedMilliseconds)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x154A1CC", Offset = "0x154A1CC", VA = "0x154A1CC")]
		public void ManualReceive()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x154A240", Offset = "0x154A240", VA = "0x154A240")]
		internal void OnMessageReceived(NetPacket packet, SocketError errorCode, IPEndPoint remoteEndPoint)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x154110C", Offset = "0x154110C", VA = "0x154110C")]
		internal NetPeer OnConnectionSolved(ConnectionRequest request, byte[] rejectData, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x154AD44", Offset = "0x154AD44", VA = "0x154AD44")]
		private int GetNextPeerId()
		{
			return default(int);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x154B180", Offset = "0x154B180", VA = "0x154B180")]
		private void ProcessConnectRequest(IPEndPoint remoteEndPoint, NetPeer netPeer, NetConnectRequestPacket connRequest)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x154A4EC", Offset = "0x154A4EC", VA = "0x154A4EC")]
		private void DataReceived(NetPacket packet, IPEndPoint remoteEndPoint)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x154BEAC", Offset = "0x154BEAC", VA = "0x154BEAC")]
		internal void CreateReceiveEvent(NetPacket packet, DeliveryMethod method, int headerSize, NetPeer fromPeer)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x154C0E4", Offset = "0x154C0E4", VA = "0x154C0E4")]
		public void SendToAll(NetDataWriter writer, DeliveryMethod options)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x154C11C", Offset = "0x154C11C", VA = "0x154C11C")]
		public void SendToAll(byte[] data, DeliveryMethod options)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x154C110", Offset = "0x154C110", VA = "0x154C110")]
		public void SendToAll(byte[] data, int start, int length, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x154C224", Offset = "0x154C224", VA = "0x154C224")]
		public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x154C250", Offset = "0x154C250", VA = "0x154C250")]
		public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x154C140", Offset = "0x154C140", VA = "0x154C140")]
		public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x154C27C", Offset = "0x154C27C", VA = "0x154C27C")]
		public void SendToAll(NetDataWriter writer, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x154C39C", Offset = "0x154C39C", VA = "0x154C39C")]
		public void SendToAll(byte[] data, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x154C3C4", Offset = "0x154C3C4", VA = "0x154C3C4")]
		public void SendToAll(byte[] data, int start, int length, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x154C3D4", Offset = "0x154C3D4", VA = "0x154C3D4")]
		public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x154C404", Offset = "0x154C404", VA = "0x154C404")]
		public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x154C2AC", Offset = "0x154C2AC", VA = "0x154C2AC")]
		public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x154C42C", Offset = "0x154C42C", VA = "0x154C42C")]
		public bool Start()
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x154C4B8", Offset = "0x154C4B8", VA = "0x154C4B8")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x154CA88", Offset = "0x154CA88", VA = "0x154CA88")]
		public bool Start(string addressIPv4, string addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x154C434", Offset = "0x154C434", VA = "0x154C434")]
		public bool Start(int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x154CB30", Offset = "0x154CB30", VA = "0x154CB30")]
		public bool StartInManualMode(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x154CB60", Offset = "0x154CB60", VA = "0x154CB60")]
		public bool StartInManualMode(string addressIPv4, string addressIPv6, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x154CC08", Offset = "0x154CC08", VA = "0x154CC08")]
		public bool StartInManualMode(int port)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x154CC8C", Offset = "0x154CC8C", VA = "0x154CC8C")]
		public bool SendUnconnectedMessage(byte[] message, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x154CD04", Offset = "0x154CD04", VA = "0x154CD04")]
		public bool SendUnconnectedMessage(NetDataWriter writer, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x154CCAC", Offset = "0x154CCAC", VA = "0x154CCAC")]
		public bool SendUnconnectedMessage(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x154CDF8", Offset = "0x154CDF8", VA = "0x154CDF8")]
		public bool SendBroadcast(NetDataWriter writer, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x154CFA4", Offset = "0x154CFA4", VA = "0x154CFA4")]
		public bool SendBroadcast(byte[] data, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x154CE20", Offset = "0x154CE20", VA = "0x154CE20")]
		public bool SendBroadcast(byte[] data, int start, int length, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x154D3A0", Offset = "0x154D3A0", VA = "0x154D3A0")]
		public void TriggerUpdate()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x154D3BC", Offset = "0x154D3BC", VA = "0x154D3BC")]
		public void PollEvents()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x154D5B8", Offset = "0x154D5B8", VA = "0x154D5B8")]
		public NetPeer Connect(string address, int port, string key)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x154D600", Offset = "0x154D600", VA = "0x154D600")]
		public NetPeer Connect(string address, int port, NetDataWriter connectionData)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x154D9B0", Offset = "0x154D9B0", VA = "0x154D9B0")]
		public NetPeer Connect(IPEndPoint target, string key)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x154D75C", Offset = "0x154D75C", VA = "0x154D75C")]
		public NetPeer Connect(IPEndPoint target, NetDataWriter connectionData)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x154DB08", Offset = "0x154DB08", VA = "0x154DB08")]
		public void Stop()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x154DB10", Offset = "0x154DB10", VA = "0x154DB10")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x154DE58", Offset = "0x154DE58", VA = "0x154DE58")]
		public int GetPeersCount(ConnectionState peerState)
		{
			return default(int);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1547AB4", Offset = "0x1547AB4", VA = "0x1547AB4")]
		public void GetPeersNonAlloc(List<NetPeer> peers, ConnectionState peerState)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x154DED0", Offset = "0x154DED0", VA = "0x154DED0")]
		public void DisconnectAll()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x154DEE0", Offset = "0x154DEE0", VA = "0x154DEE0")]
		public void DisconnectAll(byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x154DF7C", Offset = "0x154DF7C", VA = "0x154DF7C")]
		public void DisconnectPeerForce(NetPeer peer)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x154DFB4", Offset = "0x154DFB4", VA = "0x154DFB4")]
		public void DisconnectPeer(NetPeer peer)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x154E024", Offset = "0x154E024", VA = "0x154E024")]
		public void DisconnectPeer(NetPeer peer, byte[] data)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x154E064", Offset = "0x154E064", VA = "0x154E064")]
		public void DisconnectPeer(NetPeer peer, NetDataWriter writer)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x154DFEC", Offset = "0x154DFEC", VA = "0x154DFEC")]
		public void DisconnectPeer(NetPeer peer, byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x154E0A4", Offset = "0x154E0A4", VA = "0x154E0A4")]
		public void CreateNtpRequest(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x154E134", Offset = "0x154E134", VA = "0x154E134")]
		public void CreateNtpRequest(string ntpServerAddress, int port)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x154E200", Offset = "0x154E200", VA = "0x154E200")]
		public void CreateNtpRequest(string ntpServerAddress)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x154E2C8", Offset = "0x154E2C8", VA = "0x154E2C8")]
		public NetPeerEnumerator GetEnumerator()
		{
			return default(NetPeerEnumerator);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x154E2F8", Offset = "0x154E2F8", VA = "0x154E2F8", Slot = "4")]
		private IEnumerator<NetPeer> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x154E360", Offset = "0x154E360", VA = "0x154E360", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x200001B")]
	internal enum PacketProperty : byte
	{
		[Token(Token = "0x4000096")]
		Unreliable,
		[Token(Token = "0x4000097")]
		Channeled,
		[Token(Token = "0x4000098")]
		Ack,
		[Token(Token = "0x4000099")]
		Ping,
		[Token(Token = "0x400009A")]
		Pong,
		[Token(Token = "0x400009B")]
		ConnectRequest,
		[Token(Token = "0x400009C")]
		ConnectAccept,
		[Token(Token = "0x400009D")]
		Disconnect,
		[Token(Token = "0x400009E")]
		UnconnectedMessage,
		[Token(Token = "0x400009F")]
		MtuCheck,
		[Token(Token = "0x40000A0")]
		MtuOk,
		[Token(Token = "0x40000A1")]
		Broadcast,
		[Token(Token = "0x40000A2")]
		Merged,
		[Token(Token = "0x40000A3")]
		ShutdownOk,
		[Token(Token = "0x40000A4")]
		PeerNotFound,
		[Token(Token = "0x40000A5")]
		InvalidProtocol,
		[Token(Token = "0x40000A6")]
		NatMessage,
		[Token(Token = "0x40000A7")]
		Empty
	}
	[Token(Token = "0x200001C")]
	internal sealed class NetPacket
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int LastProperty;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] HeaderSizes;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] RawData;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Size;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public object UserData;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public NetPacket Next;

		[Token(Token = "0x1700000A")]
		public PacketProperty Property
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x154B694", Offset = "0x154B694", VA = "0x154B694")]
			get
			{
				return default(PacketProperty);
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x154D05C", Offset = "0x154D05C", VA = "0x154D05C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public byte ConnectionNumber
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x154720C", Offset = "0x154720C", VA = "0x154720C")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x154AD04", Offset = "0x154AD04", VA = "0x154AD04")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public ushort Sequence
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x154E6B8", Offset = "0x154E6B8", VA = "0x154E6B8")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x154E728", Offset = "0x154E728", VA = "0x154E728")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool IsFragmented
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x154E73C", Offset = "0x154E73C", VA = "0x154E73C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public byte ChannelId
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x154E7B4", Offset = "0x154E7B4", VA = "0x154E7B4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x154E7EC", Offset = "0x154E7EC", VA = "0x154E7EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public ushort FragmentId
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x154E824", Offset = "0x154E824", VA = "0x154E824")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x154E894", Offset = "0x154E894", VA = "0x154E894")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public ushort FragmentPart
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x154E8A8", Offset = "0x154E8A8", VA = "0x154E8A8")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x154E918", Offset = "0x154E918", VA = "0x154E918")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public ushort FragmentsTotal
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x154E92C", Offset = "0x154E92C", VA = "0x154E92C")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x154E99C", Offset = "0x154E99C", VA = "0x154E99C")]
			set
			{
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x154E4FC", Offset = "0x154E4FC", VA = "0x154E4FC")]
		static NetPacket()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x154E778", Offset = "0x154E778", VA = "0x154E778")]
		public void MarkFragmented()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x154E9B0", Offset = "0x154E9B0", VA = "0x154E9B0")]
		public NetPacket(int size)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1546EF0", Offset = "0x1546EF0", VA = "0x1546EF0")]
		public NetPacket(PacketProperty property, int size)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x154CFC4", Offset = "0x154CFC4", VA = "0x154CFC4")]
		public static int GetHeaderSize(PacketProperty property)
		{
			return default(int);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x154908C", Offset = "0x154908C", VA = "0x154908C")]
		public int GetHeaderSize()
		{
			return default(int);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x154B578", Offset = "0x154B578", VA = "0x154B578")]
		public bool Verify()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001D")]
	internal sealed class NetConnectRequestPacket
	{
		[Token(Token = "0x40000AE")]
		public const int HeaderSize = 14;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly long ConnectionTime;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly byte ConnectionNumber;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly byte[] TargetAddress;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly NetDataReader Data;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1546FA4", Offset = "0x1546FA4", VA = "0x1546FA4")]
		private NetConnectRequestPacket(long connectionTime, byte connectionNumber, byte[] targetAddress, NetDataReader data)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1546FF4", Offset = "0x1546FF4", VA = "0x1546FF4")]
		public static int GetProtocolId(NetPacket packet)
		{
			return default(int);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x154706C", Offset = "0x154706C", VA = "0x154706C")]
		public static NetConnectRequestPacket FromData(NetPacket packet)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1547244", Offset = "0x1547244", VA = "0x1547244")]
		public static NetPacket Make(NetDataWriter connectData, SocketAddress addressBytes, long connectId)
		{
			return null;
		}
	}
	[Token(Token = "0x200001E")]
	internal sealed class NetConnectAcceptPacket
	{
		[Token(Token = "0x40000B3")]
		public const int Size = 11;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly long ConnectionId;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly byte ConnectionNumber;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public readonly bool IsReusedPeer;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1546CC8", Offset = "0x1546CC8", VA = "0x1546CC8")]
		private NetConnectAcceptPacket(long connectionId, byte connectionNumber, bool isReusedPeer)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1546D10", Offset = "0x1546D10", VA = "0x1546D10")]
		public static NetConnectAcceptPacket FromData(NetPacket packet)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1546E20", Offset = "0x1546E20", VA = "0x1546E20")]
		public static NetPacket Make(long connectId, byte connectNum, bool reusedPeer)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	internal sealed class NetPacketPool
	{
		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NetPacket _head;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _count;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly object _lock;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x154CD2C", Offset = "0x154CD2C", VA = "0x154CD2C")]
		public NetPacket GetWithData(PacketProperty property, byte[] data, int start, int length)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x154AC68", Offset = "0x154AC68", VA = "0x154AC68")]
		public NetPacket GetWithProperty(PacketProperty property, int size)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x154B6CC", Offset = "0x154B6CC", VA = "0x154B6CC")]
		public NetPacket GetWithProperty(PacketProperty property)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1548B04", Offset = "0x1548B04", VA = "0x1548B04")]
		public NetPacket GetPacket(int size)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x154899C", Offset = "0x154899C", VA = "0x154899C")]
		public void Recycle(NetPacket packet)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x154830C", Offset = "0x154830C", VA = "0x154830C")]
		public NetPacketPool()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[Flags]
	public enum ConnectionState : byte
	{
		[Token(Token = "0x40000BB")]
		Outgoing = 2,
		[Token(Token = "0x40000BC")]
		Connected = 4,
		[Token(Token = "0x40000BD")]
		ShutdownRequested = 8,
		[Token(Token = "0x40000BE")]
		Disconnected = 0x10,
		[Token(Token = "0x40000BF")]
		Any = 0xE
	}
	[Token(Token = "0x2000021")]
	internal enum ConnectRequestResult
	{
		[Token(Token = "0x40000C1")]
		None,
		[Token(Token = "0x40000C2")]
		P2PLose,
		[Token(Token = "0x40000C3")]
		Reconnection,
		[Token(Token = "0x40000C4")]
		NewConnection
	}
	[Token(Token = "0x2000022")]
	internal enum DisconnectResult
	{
		[Token(Token = "0x40000C6")]
		None,
		[Token(Token = "0x40000C7")]
		Reject,
		[Token(Token = "0x40000C8")]
		Disconnect
	}
	[Token(Token = "0x2000023")]
	internal enum ShutdownResult
	{
		[Token(Token = "0x40000CA")]
		None,
		[Token(Token = "0x40000CB")]
		Success,
		[Token(Token = "0x40000CC")]
		WasConnected
	}
	[Token(Token = "0x2000024")]
	public class NetPeer
	{
		[Token(Token = "0x2000090")]
		private class IncomingFragments
		{
			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NetPacket[] Fragments;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int ReceivedCount;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int TotalSize;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte ChannelId;

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x154FD68", Offset = "0x154FD68", VA = "0x154FD68")]
			public IncomingFragments()
			{
			}
		}

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _rtt;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _avgRtt;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _rttCount;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double _resendDelay;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _pingSendTimer;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _rttResetTimer;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Stopwatch _pingTimer;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _timeSinceLastPacket;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long _remoteDelta;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly NetPacketPool _packetPool;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly object _shutdownLock;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal NetPeer NextPeer;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal NetPeer PrevPeer;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Queue<NetPacket> _unreliableChannel;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly Queue<BaseChannel> _channelSendQueue;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly BaseChannel[] _channels;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _mtu;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _mtuIdx;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _finishMtu;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _mtuCheckTimer;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _mtuCheckAttempts;

		[Token(Token = "0x40000E2")]
		private const int MtuCheckDelay = 1000;

		[Token(Token = "0x40000E3")]
		private const int MaxMtuCheckAttempts = 4;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly object _mtuMutex;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _fragmentId;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Dictionary<ushort, IncomingFragments> _holdedFragments;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<ushort, ushort> _deliveredFragments;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly NetPacket _mergeData;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int _mergePos;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _mergeCount;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _connectAttempts;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _connectTimer;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private long _connectTime;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private byte _connectNum;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private ConnectionState _connectionState;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NetPacket _shutdownPacket;

		[Token(Token = "0x40000F1")]
		private const int ShutdownDelay = 300;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int _shutdownTimer;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly NetPacket _pingPacket;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly NetPacket _pongPacket;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly NetPacket _connectRequestPacket;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly NetPacket _connectAcceptPacket;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public readonly IPEndPoint EndPoint;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public readonly NetManager NetManager;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public readonly int Id;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public object Tag;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public readonly NetStatistics Statistics;

		[Token(Token = "0x17000012")]
		internal byte ConnectionNum
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x154EAB8", Offset = "0x154EAB8", VA = "0x154EAB8")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x154EAC0", Offset = "0x154EAC0", VA = "0x154EAC0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public ConnectionState ConnectionState
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x154EB10", Offset = "0x154EB10", VA = "0x154EB10")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Token(Token = "0x17000014")]
		internal long ConnectTime
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x154EB18", Offset = "0x154EB18", VA = "0x154EB18")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000015")]
		public int Ping
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x154EB20", Offset = "0x154EB20", VA = "0x154EB20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000016")]
		public int Mtu
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x154EB34", Offset = "0x154EB34", VA = "0x154EB34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000017")]
		public long RemoteTimeDelta
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x154EB3C", Offset = "0x154EB3C", VA = "0x154EB3C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000018")]
		public DateTime RemoteUtcTime
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x154EB44", Offset = "0x154EB44", VA = "0x154EB44")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000019")]
		public int TimeSinceLastPacket
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x154EBE4", Offset = "0x154EBE4", VA = "0x154EBE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001A")]
		internal double ResendDelay
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x154EBEC", Offset = "0x154EBEC", VA = "0x154EBEC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x154AE40", Offset = "0x154AE40", VA = "0x154AE40")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x154EC04", Offset = "0x154EC04", VA = "0x154EC04")]
		private void SetMtu(int mtuIdx)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x154EBF4", Offset = "0x154EBF4", VA = "0x154EBF4")]
		private void OverrideMtu(int mtuValue)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x154ECC4", Offset = "0x154ECC4", VA = "0x154ECC4")]
		public int GetPacketsCountInReliableQueue(byte channelNumber, bool ordered)
		{
			return default(int);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x154ED84", Offset = "0x154ED84", VA = "0x154ED84")]
		private BaseChannel CreateChannel(byte idx)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x154D9E8", Offset = "0x154D9E8", VA = "0x154D9E8")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, byte connectNum, NetDataWriter connectData)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x154B10C", Offset = "0x154B10C", VA = "0x154B10C")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, long connectId, byte connectNum)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x154B0F0", Offset = "0x154B0F0", VA = "0x154B0F0")]
		internal void Reject(long connectionId, byte connectionNumber, byte[] data, int start, int length)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x154B848", Offset = "0x154B848", VA = "0x154B848")]
		internal bool ProcessConnectAccept(NetConnectAcceptPacket packet)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x154EEF0", Offset = "0x154EEF0", VA = "0x154EEF0")]
		public int GetMaxSinglePacketSize(DeliveryMethod options)
		{
			return default(int);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x154EF78", Offset = "0x154EF78", VA = "0x154EF78")]
		public void SendWithDeliveryEvent(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x154F4C8", Offset = "0x154F4C8", VA = "0x154F4C8")]
		public void SendWithDeliveryEvent(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x154F5A0", Offset = "0x154F5A0", VA = "0x154F5A0")]
		public void SendWithDeliveryEvent(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x154F670", Offset = "0x154F670", VA = "0x154F670")]
		public void Send(byte[] data, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x154F698", Offset = "0x154F698", VA = "0x154F698")]
		public void Send(NetDataWriter dataWriter, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x154F6C8", Offset = "0x154F6C8", VA = "0x154F6C8")]
		public void Send(byte[] data, int start, int length, DeliveryMethod options)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x154F6D8", Offset = "0x154F6D8", VA = "0x154F6D8")]
		public void Send(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x154F700", Offset = "0x154F700", VA = "0x154F700")]
		public void Send(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x154C274", Offset = "0x154C274", VA = "0x154C274")]
		public void Send(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x154F048", Offset = "0x154F048", VA = "0x154F048")]
		private void SendInternal(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x154F730", Offset = "0x154F730", VA = "0x154F730")]
		public void Disconnect(byte[] data)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x154F754", Offset = "0x154F754", VA = "0x154F754")]
		public void Disconnect(NetDataWriter writer)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x154F778", Offset = "0x154F778", VA = "0x154F778")]
		public void Disconnect(byte[] data, int start, int count)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x154F7C4", Offset = "0x154F7C4", VA = "0x154F7C4")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x154B764", Offset = "0x154B764", VA = "0x154B764")]
		internal DisconnectResult ProcessDisconnect(NetPacket packet)
		{
			return default(DisconnectResult);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1540C94", Offset = "0x1540C94", VA = "0x1540C94")]
		internal void AddToReliableChannelSendQueue(BaseChannel channel)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1548DD8", Offset = "0x1548DD8", VA = "0x1548DD8")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return default(ShutdownResult);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x154F80C", Offset = "0x154F80C", VA = "0x154F80C")]
		private void UpdateRoundTripTime(int roundTripTime)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x154F848", Offset = "0x154F848", VA = "0x154F848")]
		internal void AddReliablePacket(DeliveryMethod method, NetPacket p)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x154FD70", Offset = "0x154FD70", VA = "0x154FD70")]
		private void ProcessMtuPacket(NetPacket packet)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1550128", Offset = "0x1550128", VA = "0x1550128")]
		private void UpdateMtuLogic(int deltaTime)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x154B434", Offset = "0x154B434", VA = "0x154B434")]
		internal ConnectRequestResult ProcessConnectRequest(NetConnectRequestPacket connRequest)
		{
			return default(ConnectRequestResult);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x154B8B8", Offset = "0x154B8B8", VA = "0x154B8B8")]
		internal void ProcessPacket(NetPacket packet)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1550384", Offset = "0x1550384", VA = "0x1550384")]
		private void SendMerged()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1550420", Offset = "0x1550420", VA = "0x1550420")]
		internal void SendUserData(NetPacket packet)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x15499EC", Offset = "0x15499EC", VA = "0x15499EC")]
		internal void Update(int deltaTime)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x155053C", Offset = "0x155053C", VA = "0x155053C")]
		internal void RecycleAndDeliver(NetPacket packet)
		{
		}
	}
	[Token(Token = "0x2000025")]
	internal sealed class NetSocket
	{
		[Token(Token = "0x40000FC")]
		public const int ReceivePollingTime = 500000;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Socket _udpSocketv4;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Socket _udpSocketv6;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Thread _threadv4;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Thread _threadv6;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IPEndPoint _bufferEndPointv4;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IPEndPoint _bufferEndPointv6;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly NetManager _listener;

		[Token(Token = "0x4000104")]
		private const int SioUdpConnreset = -1744830452;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IPAddress MulticastAddressV6;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly bool IPv6Support;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA108", Offset = "0xBDA108")]
		private int <LocalPort>k__BackingField;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool IsRunning;

		[Token(Token = "0x1700001B")]
		public int LocalPort
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x155068C", Offset = "0x155068C", VA = "0x155068C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA5F0", Offset = "0xBDA5F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1550694", Offset = "0x1550694", VA = "0x1550694")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA600", Offset = "0xBDA600")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public short Ttl
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x155069C", Offset = "0x155069C", VA = "0x155069C")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1546758", Offset = "0x1546758", VA = "0x1546758")]
			set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1550744", Offset = "0x1550744", VA = "0x1550744")]
		static NetSocket()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x15482E0", Offset = "0x15482E0", VA = "0x15482E0")]
		public NetSocket(NetManager listener)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1550800", Offset = "0x1550800", VA = "0x1550800")]
		private bool IsActive()
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1550824", Offset = "0x1550824", VA = "0x1550824")]
		private bool ProcessError(SocketException ex, EndPoint bufferEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x154A1F0", Offset = "0x154A1F0", VA = "0x154A1F0")]
		public void ManualReceive()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1550A48", Offset = "0x1550A48", VA = "0x1550A48")]
		private bool ManualReceive(Socket socket, EndPoint bufferEndPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1550C8C", Offset = "0x1550C8C", VA = "0x1550C8C")]
		private void ReceiveLogic(object state)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x154C5D8", Offset = "0x154C5D8", VA = "0x154C5D8")]
		public bool Bind(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool reuseAddress, IPv6Mode ipv6Mode, bool manualMode)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1550FA4", Offset = "0x1550FA4", VA = "0x1550FA4")]
		private bool BindSocket(Socket socket, IPEndPoint ep, bool reuseAddress, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x154D09C", Offset = "0x154D09C", VA = "0x154D09C")]
		public bool SendBroadcast(byte[] data, int offset, int size, int port)
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1546794", Offset = "0x1546794", VA = "0x1546794")]
		public int SendTo(byte[] data, int offset, int size, IPEndPoint remoteEndPoint, ref SocketError errorCode)
		{
			return default(int);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x154DD8C", Offset = "0x154DD8C", VA = "0x154DD8C")]
		public void Close(bool suspend)
		{
		}
	}
	[Token(Token = "0x2000026")]
	public sealed class NetStatistics
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private long _packetsSent;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long _packetsReceived;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long _bytesSent;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long _bytesReceived;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _packetLoss;

		[Token(Token = "0x1700001D")]
		public long PacketsSent
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1E735C8", Offset = "0x1E735C8", VA = "0x1E735C8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700001E")]
		public long PacketsReceived
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1E735D4", Offset = "0x1E735D4", VA = "0x1E735D4")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700001F")]
		public long BytesSent
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1E735E0", Offset = "0x1E735E0", VA = "0x1E735E0")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000020")]
		public long BytesReceived
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1E735EC", Offset = "0x1E735EC", VA = "0x1E735EC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000021")]
		public long PacketLoss
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1E735F8", Offset = "0x1E735F8", VA = "0x1E735F8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000022")]
		public long PacketLossPercent
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1E73604", Offset = "0x1E73604", VA = "0x1E73604")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1E73654", Offset = "0x1E73654", VA = "0x1E73654")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1E736BC", Offset = "0x1E736BC", VA = "0x1E736BC")]
		public void IncrementPacketsSent()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1E736C8", Offset = "0x1E736C8", VA = "0x1E736C8")]
		public void IncrementPacketsReceived()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1E736D4", Offset = "0x1E736D4", VA = "0x1E736D4")]
		public void AddBytesSent(long bytesSent)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1E736E0", Offset = "0x1E736E0", VA = "0x1E736E0")]
		public void AddBytesReceived(long bytesReceived)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1E736EC", Offset = "0x1E736EC", VA = "0x1E736EC")]
		public void IncrementPacketLoss()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1E736F8", Offset = "0x1E736F8", VA = "0x1E736F8")]
		public void AddPacketLoss(long packetLoss)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1E73704", Offset = "0x1E73704", VA = "0x1E73704", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1E7396C", Offset = "0x1E7396C", VA = "0x1E7396C")]
		public NetStatistics()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[Flags]
	public enum LocalAddrType
	{
		[Token(Token = "0x400010F")]
		IPv4 = 1,
		[Token(Token = "0x4000110")]
		IPv6 = 2,
		[Token(Token = "0x4000111")]
		All = 3
	}
	[Token(Token = "0x2000028")]
	public static class NetUtils
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> IpList;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1E73974", Offset = "0x1E73974", VA = "0x1E73974")]
		public static IPEndPoint MakeEndPoint(string hostStr, int port)
		{
			return null;
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1E73A18", Offset = "0x1E73A18", VA = "0x1E73A18")]
		public static IPAddress ResolveAddress(string hostStr)
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1E73BE0", Offset = "0x1E73BE0", VA = "0x1E73BE0")]
		public static IPAddress ResolveAddress(string hostStr, AddressFamily addressFamily)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1E73CB4", Offset = "0x1E73CB4", VA = "0x1E73CB4")]
		public static IPAddress[] ResolveAddresses(string hostStr)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1E73CD8", Offset = "0x1E73CD8", VA = "0x1E73CD8")]
		public static List<string> GetLocalIpList(LocalAddrType addrType)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1E73D6C", Offset = "0x1E73D6C", VA = "0x1E73D6C")]
		public static void GetLocalIpList(IList<string> targetList, LocalAddrType addrType)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1E74560", Offset = "0x1E74560", VA = "0x1E74560")]
		public static string GetLocalIp(LocalAddrType addrType)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1E74718", Offset = "0x1E74718", VA = "0x1E74718")]
		internal static void PrintInterfaceInfos()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1E74AEC", Offset = "0x1E74AEC", VA = "0x1E74AEC")]
		internal static int RelativeSequenceNumber(int number, int expected)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000029")]
	internal sealed class ReliableChannel : BaseChannel
	{
		[Token(Token = "0x2000091")]
		private struct PendingPacket
		{
			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private NetPacket _packet;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private long _timeStamp;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool _isSent;

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x1E75AD4", Offset = "0x1E75AD4", VA = "0x1E75AD4", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1E75528", Offset = "0x1E75528", VA = "0x1E75528")]
			public void Init(NetPacket packet)
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1E75534", Offset = "0x1E75534", VA = "0x1E75534")]
			public void TrySend(long currentTime, NetPeer peer, out bool hasPacket)
			{
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1E7504C", Offset = "0x1E7504C", VA = "0x1E7504C")]
			public bool Clear(NetPeer peer)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly NetPacket _outgoingAcks;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly PendingPacket[] _pendingPackets;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacket[] _receivedPackets;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly bool[] _earlyReceived;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _localSeqence;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _remoteSequence;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _localWindowStart;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _remoteWindowStart;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _mustSendAcks;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private readonly DeliveryMethod _deliveryMethod;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private readonly bool _ordered;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private readonly int _windowSize;

		[Token(Token = "0x400011F")]
		private const int BitsInByte = 8;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly byte _id;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1E74B88", Offset = "0x1E74B88", VA = "0x1E74B88")]
		public ReliableChannel(NetPeer peer, bool ordered, byte id)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1E74D0C", Offset = "0x1E74D0C", VA = "0x1E74D0C")]
		private void ProcessAck(NetPacket packet)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1E75098", Offset = "0x1E75098", VA = "0x1E75098", Slot = "4")]
		protected override bool SendNextPackets()
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1E755BC", Offset = "0x1E755BC", VA = "0x1E755BC", Slot = "5")]
		public override bool ProcessPacket(NetPacket packet)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002A")]
	internal sealed class SequencedChannel : BaseChannel
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _localSequence;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ushort _remoteSequence;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private readonly bool _reliable;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NetPacket _lastPacket;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly NetPacket _ackPacket;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _mustSendAck;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private readonly byte _id;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long _lastPacketSendTime;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1E75B50", Offset = "0x1E75B50", VA = "0x1E75B50")]
		public SequencedChannel(NetPeer peer, bool reliable, byte id)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1E75C0C", Offset = "0x1E75C0C", VA = "0x1E75C0C", Slot = "4")]
		protected override bool SendNextPackets()
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1E75F04", Offset = "0x1E75F04", VA = "0x1E75F04", Slot = "5")]
		public override bool ProcessPacket(NetPacket packet)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Utils
{
	[Token(Token = "0x200002B")]
	public static class CRC32C
	{
		[Token(Token = "0x4000129")]
		public const int ChecksumSize = 4;

		[Token(Token = "0x400012A")]
		private const uint Poly = 2197175160u;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly uint[] Table;

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1E7612C", Offset = "0x1E7612C", VA = "0x1E7612C")]
		static CRC32C()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1E76214", Offset = "0x1E76214", VA = "0x1E76214")]
		public static uint Compute(byte[] input, int offset, int length)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x200002C")]
	public static class FastBitConverter
	{
		[StructLayout(2)]
		[Token(Token = "0x2000092")]
		private struct ConverterHelperDouble
		{
			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong Along;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double Adouble;
		}

		[StructLayout(2)]
		[Token(Token = "0x2000093")]
		private struct ConverterHelperFloat
		{
			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Aint;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float Afloat;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1E766B8", Offset = "0x1E766B8", VA = "0x1E766B8")]
		private static void WriteLittleEndian(byte[] buffer, int offset, ulong data)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1E767B4", Offset = "0x1E767B4", VA = "0x1E767B4")]
		private static void WriteLittleEndian(byte[] buffer, int offset, int data)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1E76840", Offset = "0x1E76840", VA = "0x1E76840")]
		public static void WriteLittleEndian(byte[] buffer, int offset, short data)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1E76894", Offset = "0x1E76894", VA = "0x1E76894")]
		public static void GetBytes(byte[] bytes, int startIndex, double value)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1E7689C", Offset = "0x1E7689C", VA = "0x1E7689C")]
		public static void GetBytes(byte[] bytes, int startIndex, float value)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1E768A4", Offset = "0x1E768A4", VA = "0x1E768A4")]
		public static void GetBytes(byte[] bytes, int startIndex, short value)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1E768A8", Offset = "0x1E768A8", VA = "0x1E768A8")]
		public static void GetBytes(byte[] bytes, int startIndex, ushort value)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1E768AC", Offset = "0x1E768AC", VA = "0x1E768AC")]
		public static void GetBytes(byte[] bytes, int startIndex, int value)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1E768B0", Offset = "0x1E768B0", VA = "0x1E768B0")]
		public static void GetBytes(byte[] bytes, int startIndex, uint value)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1E768B4", Offset = "0x1E768B4", VA = "0x1E768B4")]
		public static void GetBytes(byte[] bytes, int startIndex, long value)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1E768B8", Offset = "0x1E768B8", VA = "0x1E768B8")]
		public static void GetBytes(byte[] bytes, int startIndex, ulong value)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public interface INetSerializable
	{
		[Token(Token = "0x600014C")]
		void Serialize(NetDataWriter writer);

		[Token(Token = "0x600014D")]
		void Deserialize(NetDataReader reader);
	}
	[Token(Token = "0x200002E")]
	public class NetDataReader
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected byte[] _data;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int _position;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected int _dataSize;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _offset;

		[Token(Token = "0x17000023")]
		public byte[] RawData
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1E768C4", Offset = "0x1E768C4", VA = "0x1E768C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public int RawDataSize
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1E768CC", Offset = "0x1E768CC", VA = "0x1E768CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public int UserDataOffset
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1E768D4", Offset = "0x1E768D4", VA = "0x1E768D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public int UserDataSize
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1E768DC", Offset = "0x1E768DC", VA = "0x1E768DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		public bool IsNull
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1E768E8", Offset = "0x1E768E8", VA = "0x1E768E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		public int Position
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1E768F8", Offset = "0x1E768F8", VA = "0x1E768F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public bool EndOfData
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1E76900", Offset = "0x1E76900", VA = "0x1E76900")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public int AvailableBytes
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1E76910", Offset = "0x1E76910", VA = "0x1E76910")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1E7691C", Offset = "0x1E7691C", VA = "0x1E7691C")]
		public void SkipBytes(int count)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1E7692C", Offset = "0x1E7692C", VA = "0x1E7692C")]
		public void SetSource(NetDataWriter dataWriter)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1E76958", Offset = "0x1E76958", VA = "0x1E76958")]
		public void SetSource(byte[] source)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1E76980", Offset = "0x1E76980", VA = "0x1E76980")]
		public void SetSource(byte[] source, int offset)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1E769A8", Offset = "0x1E769A8", VA = "0x1E769A8")]
		public void SetSource(byte[] source, int offset, int maxSize)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1E769B8", Offset = "0x1E769B8", VA = "0x1E769B8")]
		public NetDataReader()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1E769C0", Offset = "0x1E769C0", VA = "0x1E769C0")]
		public NetDataReader(NetDataWriter writer)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1E76A08", Offset = "0x1E76A08", VA = "0x1E76A08")]
		public NetDataReader(byte[] source)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1E76A4C", Offset = "0x1E76A4C", VA = "0x1E76A4C")]
		public NetDataReader(byte[] source, int offset)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1E76A9C", Offset = "0x1E76A9C", VA = "0x1E76A9C")]
		public NetDataReader(byte[] source, int offset, int maxSize)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1E76AE0", Offset = "0x1E76AE0", VA = "0x1E76AE0")]
		public IPEndPoint GetNetEndPoint()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1E76CE0", Offset = "0x1E76CE0", VA = "0x1E76CE0")]
		public byte GetByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1E76D2C", Offset = "0x1E76D2C", VA = "0x1E76D2C")]
		public sbyte GetSByte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1E76D78", Offset = "0x1E76D78", VA = "0x1E76D78")]
		public bool[] GetBoolArray()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1E76E58", Offset = "0x1E76E58", VA = "0x1E76E58")]
		public ushort[] GetUShortArray()
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1E76F34", Offset = "0x1E76F34", VA = "0x1E76F34")]
		public short[] GetShortArray()
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1E77010", Offset = "0x1E77010", VA = "0x1E77010")]
		public long[] GetLongArray()
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1E770EC", Offset = "0x1E770EC", VA = "0x1E770EC")]
		public ulong[] GetULongArray()
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1E771C8", Offset = "0x1E771C8", VA = "0x1E771C8")]
		public int[] GetIntArray()
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1E772A4", Offset = "0x1E772A4", VA = "0x1E772A4")]
		public uint[] GetUIntArray()
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1E77380", Offset = "0x1E77380", VA = "0x1E77380")]
		public float[] GetFloatArray()
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1E7745C", Offset = "0x1E7745C", VA = "0x1E7745C")]
		public double[] GetDoubleArray()
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1E77538", Offset = "0x1E77538", VA = "0x1E77538")]
		public string[] GetStringArray()
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1E77708", Offset = "0x1E77708", VA = "0x1E77708")]
		public string[] GetStringArray(int maxStringLength)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1E77844", Offset = "0x1E77844", VA = "0x1E77844")]
		public bool GetBool()
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1E77898", Offset = "0x1E77898", VA = "0x1E77898")]
		public char GetChar()
		{
			return default(char);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1E77924", Offset = "0x1E77924", VA = "0x1E77924")]
		public ushort GetUShort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1E779B0", Offset = "0x1E779B0", VA = "0x1E779B0")]
		public short GetShort()
		{
			return default(short);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1E77A3C", Offset = "0x1E77A3C", VA = "0x1E77A3C")]
		public long GetLong()
		{
			return default(long);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1E77AC8", Offset = "0x1E77AC8", VA = "0x1E77AC8")]
		public ulong GetULong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1E76C54", Offset = "0x1E76C54", VA = "0x1E76C54")]
		public int GetInt()
		{
			return default(int);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1E77B54", Offset = "0x1E77B54", VA = "0x1E77B54")]
		public uint GetUInt()
		{
			return default(uint);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1E77BE0", Offset = "0x1E77BE0", VA = "0x1E77BE0")]
		public float GetFloat()
		{
			return default(float);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1E77C6C", Offset = "0x1E77C6C", VA = "0x1E77C6C")]
		public double GetDouble()
		{
			return default(double);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1E76B68", Offset = "0x1E76B68", VA = "0x1E76B68")]
		public string GetString(int maxLength)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1E77664", Offset = "0x1E77664", VA = "0x1E77664")]
		public string GetString()
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1E77CF8", Offset = "0x1E77CF8", VA = "0x1E77CF8")]
		public ArraySegment<byte> GetRemainingBytesSegment()
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x600017B")]
		public T Get<T>() where T : INetSerializable, new()
		{
			return (T)null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1E77D7C", Offset = "0x1E77D7C", VA = "0x1E77D7C")]
		public byte[] GetRemainingBytes()
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1E77E0C", Offset = "0x1E77E0C", VA = "0x1E77E0C")]
		public void GetBytes(byte[] destination, int start, int count)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1E77E58", Offset = "0x1E77E58", VA = "0x1E77E58")]
		public void GetBytes(byte[] destination, int count)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1E77EA4", Offset = "0x1E77EA4", VA = "0x1E77EA4")]
		public sbyte[] GetSBytesWithLength()
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1E77F44", Offset = "0x1E77F44", VA = "0x1E77F44")]
		public byte[] GetBytesWithLength()
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1E77FE4", Offset = "0x1E77FE4", VA = "0x1E77FE4")]
		public byte PeekByte()
		{
			return default(byte);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1E78024", Offset = "0x1E78024", VA = "0x1E78024")]
		public sbyte PeekSByte()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1E78064", Offset = "0x1E78064", VA = "0x1E78064")]
		public bool PeekBool()
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1E780AC", Offset = "0x1E780AC", VA = "0x1E780AC")]
		public char PeekChar()
		{
			return default(char);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1E78120", Offset = "0x1E78120", VA = "0x1E78120")]
		public ushort PeekUShort()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1E78194", Offset = "0x1E78194", VA = "0x1E78194")]
		public short PeekShort()
		{
			return default(short);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1E78208", Offset = "0x1E78208", VA = "0x1E78208")]
		public long PeekLong()
		{
			return default(long);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1E7827C", Offset = "0x1E7827C", VA = "0x1E7827C")]
		public ulong PeekULong()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1E782F0", Offset = "0x1E782F0", VA = "0x1E782F0")]
		public int PeekInt()
		{
			return default(int);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1E78364", Offset = "0x1E78364", VA = "0x1E78364")]
		public uint PeekUInt()
		{
			return default(uint);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1E783D8", Offset = "0x1E783D8", VA = "0x1E783D8")]
		public float PeekFloat()
		{
			return default(float);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1E7844C", Offset = "0x1E7844C", VA = "0x1E7844C")]
		public double PeekDouble()
		{
			return default(double);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1E784C0", Offset = "0x1E784C0", VA = "0x1E784C0")]
		public string PeekString(int maxLength)
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1E785E0", Offset = "0x1E785E0", VA = "0x1E785E0")]
		public string PeekString()
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1E786BC", Offset = "0x1E786BC", VA = "0x1E786BC")]
		public bool TryGetByte(out byte result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1E78704", Offset = "0x1E78704", VA = "0x1E78704")]
		public bool TryGetSByte(out sbyte result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1E7874C", Offset = "0x1E7874C", VA = "0x1E7874C")]
		public bool TryGetBool(out bool result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1E78794", Offset = "0x1E78794", VA = "0x1E78794")]
		public bool TryGetChar(out char result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1E787DC", Offset = "0x1E787DC", VA = "0x1E787DC")]
		public bool TryGetShort(out short result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1E78824", Offset = "0x1E78824", VA = "0x1E78824")]
		public bool TryGetUShort(out ushort result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1E7886C", Offset = "0x1E7886C", VA = "0x1E7886C")]
		public bool TryGetInt(out int result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1E788B4", Offset = "0x1E788B4", VA = "0x1E788B4")]
		public bool TryGetUInt(out uint result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1E788FC", Offset = "0x1E788FC", VA = "0x1E788FC")]
		public bool TryGetLong(out long result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1E78944", Offset = "0x1E78944", VA = "0x1E78944")]
		public bool TryGetULong(out ulong result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1E7898C", Offset = "0x1E7898C", VA = "0x1E7898C")]
		public bool TryGetFloat(out float result)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1E789D0", Offset = "0x1E789D0", VA = "0x1E789D0")]
		public bool TryGetDouble(out double result)
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1E78A14", Offset = "0x1E78A14", VA = "0x1E78A14")]
		public bool TryGetString(out string result)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1E78A7C", Offset = "0x1E78A7C", VA = "0x1E78A7C")]
		public bool TryGetStringArray(out string[] result)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1E78B74", Offset = "0x1E78B74", VA = "0x1E78B74")]
		public bool TryGetBytesWithLength(out byte[] result)
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1E78BE0", Offset = "0x1E78BE0", VA = "0x1E78BE0")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class NetDataWriter
	{
		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected byte[] _data;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int _position;

		[Token(Token = "0x4000132")]
		private const int InitialSize = 64;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly bool _autoResize;

		[Token(Token = "0x1700002B")]
		public int Capacity
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1E78BE8", Offset = "0x1E78BE8", VA = "0x1E78BE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		public byte[] Data
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1E79168", Offset = "0x1E79168", VA = "0x1E79168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public int Length
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1E79170", Offset = "0x1E79170", VA = "0x1E79170")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1E78C04", Offset = "0x1E78C04", VA = "0x1E78C04")]
		public NetDataWriter()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1E78C8C", Offset = "0x1E78C8C", VA = "0x1E78C8C")]
		public NetDataWriter(bool autoResize)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1E78C10", Offset = "0x1E78C10", VA = "0x1E78C10")]
		public NetDataWriter(bool autoResize, int initialSize)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1E78C98", Offset = "0x1E78C98", VA = "0x1E78C98")]
		public static NetDataWriter FromBytes(byte[] bytes, bool copy)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1E78DD4", Offset = "0x1E78DD4", VA = "0x1E78DD4")]
		public static NetDataWriter FromBytes(byte[] bytes, int offset, int length)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1E78ED8", Offset = "0x1E78ED8", VA = "0x1E78ED8")]
		public static NetDataWriter FromString(string value)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1E7902C", Offset = "0x1E7902C", VA = "0x1E7902C")]
		public void ResizeIfNeed(int newSize)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1E790C0", Offset = "0x1E790C0", VA = "0x1E790C0")]
		public void Reset(int size)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1E790E4", Offset = "0x1E790E4", VA = "0x1E790E4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1E790EC", Offset = "0x1E790EC", VA = "0x1E790EC")]
		public byte[] CopyData()
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1E79178", Offset = "0x1E79178", VA = "0x1E79178")]
		public int SetPosition(int position)
		{
			return default(int);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1E79188", Offset = "0x1E79188", VA = "0x1E79188")]
		public void Put(float value)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1E791E4", Offset = "0x1E791E4", VA = "0x1E791E4")]
		public void Put(double value)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1E79240", Offset = "0x1E79240", VA = "0x1E79240")]
		public void Put(long value)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1E79294", Offset = "0x1E79294", VA = "0x1E79294")]
		public void Put(ulong value)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1E792E8", Offset = "0x1E792E8", VA = "0x1E792E8")]
		public void Put(int value)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1E7933C", Offset = "0x1E7933C", VA = "0x1E7933C")]
		public void Put(uint value)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1E79390", Offset = "0x1E79390", VA = "0x1E79390")]
		public void Put(char value)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1E793E4", Offset = "0x1E793E4", VA = "0x1E793E4")]
		public void Put(ushort value)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1E79438", Offset = "0x1E79438", VA = "0x1E79438")]
		public void Put(short value)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1E7948C", Offset = "0x1E7948C", VA = "0x1E7948C")]
		public void Put(sbyte value)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1E79500", Offset = "0x1E79500", VA = "0x1E79500")]
		public void Put(byte value)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1E78E68", Offset = "0x1E78E68", VA = "0x1E78E68")]
		public void Put(byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1E78D5C", Offset = "0x1E78D5C", VA = "0x1E78D5C")]
		public void Put(byte[] data)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1E79574", Offset = "0x1E79574", VA = "0x1E79574")]
		public void PutSBytesWithLength(sbyte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1E7960C", Offset = "0x1E7960C", VA = "0x1E7960C")]
		public void PutSBytesWithLength(sbyte[] data)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1E796A0", Offset = "0x1E796A0", VA = "0x1E796A0")]
		public void PutBytesWithLength(byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1E79738", Offset = "0x1E79738", VA = "0x1E79738")]
		public void PutBytesWithLength(byte[] data)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1E797CC", Offset = "0x1E797CC", VA = "0x1E797CC")]
		public void Put(bool value)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1E79844", Offset = "0x1E79844", VA = "0x1E79844")]
		private void PutArray(Array arr, int sz)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1E798F4", Offset = "0x1E798F4", VA = "0x1E798F4")]
		public void PutArray(float[] value)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1E798FC", Offset = "0x1E798FC", VA = "0x1E798FC")]
		public void PutArray(double[] value)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1E79904", Offset = "0x1E79904", VA = "0x1E79904")]
		public void PutArray(long[] value)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1E7990C", Offset = "0x1E7990C", VA = "0x1E7990C")]
		public void PutArray(ulong[] value)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1E79914", Offset = "0x1E79914", VA = "0x1E79914")]
		public void PutArray(int[] value)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1E7991C", Offset = "0x1E7991C", VA = "0x1E7991C")]
		public void PutArray(uint[] value)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1E79924", Offset = "0x1E79924", VA = "0x1E79924")]
		public void PutArray(ushort[] value)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1E7992C", Offset = "0x1E7992C", VA = "0x1E7992C")]
		public void PutArray(short[] value)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1E79934", Offset = "0x1E79934", VA = "0x1E79934")]
		public void PutArray(bool[] value)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1E7993C", Offset = "0x1E7993C", VA = "0x1E7993C")]
		public void PutArray(string[] value)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1E799DC", Offset = "0x1E799DC", VA = "0x1E799DC")]
		public void PutArray(string[] value, int maxLength)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1E79B70", Offset = "0x1E79B70", VA = "0x1E79B70")]
		public void Put(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1E78F50", Offset = "0x1E78F50", VA = "0x1E78F50")]
		public void Put(string value)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1E79A84", Offset = "0x1E79A84", VA = "0x1E79A84")]
		public void Put(string value, int maxLength)
		{
		}

		[Token(Token = "0x60001CE")]
		public void Put<T>(T obj) where T : INetSerializable
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class NetPacketProcessor
	{
		[Token(Token = "0x2000094")]
		private static class HashCache<T>
		{
			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static bool Initialized;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static ulong Id;
		}

		[Token(Token = "0x2000095")]
		protected delegate void SubscribeDelegate(NetDataReader reader, object userData);

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8C70", Offset = "0xBD8C70")]
		private sealed class <>c__DisplayClass25_0<T> where T : class, new()
		{
			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> packetConstructor;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NetPacketProcessor <>4__this;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onReceive;

			[Token(Token = "0x60003FA")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60003FB")]
			internal void <Subscribe>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8C80", Offset = "0xBD8C80")]
		private sealed class <>c__DisplayClass26_0<T, TUserData> where T : class, new()
		{
			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> packetConstructor;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NetPacketProcessor <>4__this;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, TUserData> onReceive;

			[Token(Token = "0x60003FC")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60003FD")]
			internal void <Subscribe>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8C90", Offset = "0xBD8C90")]
		private sealed class <>c__DisplayClass27_0<T> where T : class, new()
		{
			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NetPacketProcessor <>4__this;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onReceive;

			[Token(Token = "0x60003FE")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60003FF")]
			internal void <SubscribeReusable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8CA0", Offset = "0xBD8CA0")]
		private sealed class <>c__DisplayClass28_0<T, TUserData> where T : class, new()
		{
			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NetPacketProcessor <>4__this;

			[Token(Token = "0x40002AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, TUserData> onReceive;

			[Token(Token = "0x6000400")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000401")]
			internal void <SubscribeReusable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8CB0", Offset = "0xBD8CB0")]
		private sealed class <>c__DisplayClass29_0<T, TUserData> where T : INetSerializable
		{
			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> packetConstructor;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, TUserData> onReceive;

			[Token(Token = "0x6000402")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000403")]
			internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8CC0", Offset = "0xBD8CC0")]
		private sealed class <>c__DisplayClass30_0<T> where T : INetSerializable
		{
			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<T> packetConstructor;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onReceive;

			[Token(Token = "0x6000404")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000405")]
			internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8CD0", Offset = "0xBD8CD0")]
		private sealed class <>c__DisplayClass31_0<T, TUserData> where T : INetSerializable, new()
		{
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, TUserData> onReceive;

			[Token(Token = "0x6000406")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000407")]
			internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8CE0", Offset = "0xBD8CE0")]
		private sealed class <>c__DisplayClass32_0<T> where T : INetSerializable, new()
		{
			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onReceive;

			[Token(Token = "0x6000408")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000409")]
			internal void <SubscribeNetSerializable>b__0(NetDataReader reader, object userData)
			{
			}
		}

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSerializer _netSerializer;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<ulong, SubscribeDelegate> _callbacks;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly NetDataWriter _netDataWriter;

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1E79BC0", Offset = "0x1E79BC0", VA = "0x1E79BC0")]
		public NetPacketProcessor()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1E79C80", Offset = "0x1E79C80", VA = "0x1E79C80")]
		public NetPacketProcessor(int maxStringLength)
		{
		}

		[Token(Token = "0x60001D1")]
		public virtual ulong GetHash<T>()
		{
			return default(ulong);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1E79DC8", Offset = "0x1E79DC8", VA = "0x1E79DC8", Slot = "5")]
		protected virtual SubscribeDelegate GetCallbackFromData(NetDataReader reader)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		protected virtual void WriteHash<T>(NetDataWriter writer)
		{
		}

		[Token(Token = "0x60001D4")]
		public void RegisterNestedType<T>() where T : struct, INetSerializable
		{
		}

		[Token(Token = "0x60001D5")]
		public void RegisterNestedType<T>(Action<NetDataWriter, T> writeDelegate, Func<NetDataReader, T> readDelegate)
		{
		}

		[Token(Token = "0x60001D6")]
		public void RegisterNestedType<T>(Func<T> constructor) where T : class, INetSerializable
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1E79F04", Offset = "0x1E79F04", VA = "0x1E79F04")]
		public void ReadAllPackets(NetDataReader reader)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1E79F64", Offset = "0x1E79F64", VA = "0x1E79F64")]
		public void ReadAllPackets(NetDataReader reader, object userData)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1E79F5C", Offset = "0x1E79F5C", VA = "0x1E79F5C")]
		public void ReadPacket(NetDataReader reader)
		{
		}

		[Token(Token = "0x60001DA")]
		public void Send<T>(NetPeer peer, T packet, DeliveryMethod options) where T : class, new()
		{
		}

		[Token(Token = "0x60001DB")]
		public void SendNetSerializable<T>(NetPeer peer, T packet, DeliveryMethod options) where T : INetSerializable
		{
		}

		[Token(Token = "0x60001DC")]
		public void Send<T>(NetManager manager, T packet, DeliveryMethod options) where T : class, new()
		{
		}

		[Token(Token = "0x60001DD")]
		public void SendNetSerializable<T>(NetManager manager, T packet, DeliveryMethod options) where T : INetSerializable
		{
		}

		[Token(Token = "0x60001DE")]
		public void Write<T>(NetDataWriter writer, T packet) where T : class, new()
		{
		}

		[Token(Token = "0x60001DF")]
		public void WriteNetSerializable<T>(NetDataWriter writer, T packet) where T : INetSerializable
		{
		}

		[Token(Token = "0x60001E0")]
		public byte[] Write<T>(T packet) where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		public byte[] WriteNetSerializable<T>(T packet) where T : INetSerializable
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1E79FC8", Offset = "0x1E79FC8", VA = "0x1E79FC8")]
		public void ReadPacket(NetDataReader reader, object userData)
		{
		}

		[Token(Token = "0x60001E3")]
		public void Subscribe<T>(Action<T> onReceive, Func<T> packetConstructor) where T : class, new()
		{
		}

		[Token(Token = "0x60001E4")]
		public void Subscribe<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : class, new()
		{
		}

		[Token(Token = "0x60001E5")]
		public void SubscribeReusable<T>(Action<T> onReceive) where T : class, new()
		{
		}

		[Token(Token = "0x60001E6")]
		public void SubscribeReusable<T, TUserData>(Action<T, TUserData> onReceive) where T : class, new()
		{
		}

		[Token(Token = "0x60001E7")]
		public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive, Func<T> packetConstructor) where T : INetSerializable
		{
		}

		[Token(Token = "0x60001E8")]
		public void SubscribeNetSerializable<T>(Action<T> onReceive, Func<T> packetConstructor) where T : INetSerializable
		{
		}

		[Token(Token = "0x60001E9")]
		public void SubscribeNetSerializable<T, TUserData>(Action<T, TUserData> onReceive) where T : INetSerializable, new()
		{
		}

		[Token(Token = "0x60001EA")]
		public void SubscribeNetSerializable<T>(Action<T> onReceive) where T : INetSerializable, new()
		{
		}

		[Token(Token = "0x60001EB")]
		public bool RemoveSubscription<T>()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000031")]
	public class InvalidTypeException : ArgumentException
	{
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1E768BC", Offset = "0x1E768BC", VA = "0x1E768BC")]
		public InvalidTypeException(string message)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class ParseException : Exception
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1E79E8C", Offset = "0x1E79E8C", VA = "0x1E79E8C")]
		public ParseException(string message)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class NetSerializer
	{
		[Token(Token = "0x200009E")]
		private enum CallType
		{
			[Token(Token = "0x40002B8")]
			Basic,
			[Token(Token = "0x40002B9")]
			Array,
			[Token(Token = "0x40002BA")]
			List
		}

		[Token(Token = "0x200009F")]
		private abstract class FastCall<T>
		{
			[Token(Token = "0x40002BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CallType Type;

			[Token(Token = "0x600040A")]
			public virtual void Init(MethodInfo getMethod, MethodInfo setMethod, CallType type)
			{
			}

			[Token(Token = "0x600040B")]
			public abstract void Read(T inf, NetDataReader r);

			[Token(Token = "0x600040C")]
			public abstract void Write(T inf, NetDataWriter w);

			[Token(Token = "0x600040D")]
			public abstract void ReadArray(T inf, NetDataReader r);

			[Token(Token = "0x600040E")]
			public abstract void WriteArray(T inf, NetDataWriter w);

			[Token(Token = "0x600040F")]
			public abstract void ReadList(T inf, NetDataReader r);

			[Token(Token = "0x6000410")]
			public abstract void WriteList(T inf, NetDataWriter w);

			[Token(Token = "0x6000411")]
			protected FastCall()
			{
			}
		}

		[Token(Token = "0x20000A0")]
		private abstract class FastCallSpecific<TClass, TProperty> : FastCall<TClass>
		{
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, TProperty> Getter;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, TProperty> Setter;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, TProperty[]> GetterArr;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, TProperty[]> SetterArr;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Func<TClass, List<TProperty>> GetterList;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected Action<TClass, List<TProperty>> SetterList;

			[Token(Token = "0x6000412")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000413")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000414")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000415")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000416")]
			protected TProperty[] ReadArrayHelper(TClass inf, NetDataReader r)
			{
				return null;
			}

			[Token(Token = "0x6000417")]
			protected TProperty[] WriteArrayHelper(TClass inf, NetDataWriter w)
			{
				return null;
			}

			[Token(Token = "0x6000418")]
			protected List<TProperty> ReadListHelper(TClass inf, NetDataReader r, out int len)
			{
				return null;
			}

			[Token(Token = "0x6000419")]
			protected List<TProperty> WriteListHelper(TClass inf, NetDataWriter w, out int len)
			{
				return null;
			}

			[Token(Token = "0x600041A")]
			public override void Init(MethodInfo getMethod, MethodInfo setMethod, CallType type)
			{
			}

			[Token(Token = "0x600041B")]
			protected FastCallSpecific()
			{
			}
		}

		[Token(Token = "0x20000A1")]
		private abstract class FastCallSpecificAuto<TClass, TProperty> : FastCallSpecific<TClass, TProperty>
		{
			[Token(Token = "0x600041C")]
			protected abstract void ElementRead(NetDataReader r, out TProperty prop);

			[Token(Token = "0x600041D")]
			protected abstract void ElementWrite(NetDataWriter w, ref TProperty prop);

			[Token(Token = "0x600041E")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600041F")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000420")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000421")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000422")]
			protected FastCallSpecificAuto()
			{
			}
		}

		[Token(Token = "0x20000A2")]
		private sealed class FastCallStatic<TClass, TProperty> : FastCallSpecific<TClass, TProperty>
		{
			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Action<NetDataWriter, TProperty> _writer;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<NetDataReader, TProperty> _reader;

			[Token(Token = "0x6000423")]
			public FastCallStatic(Action<NetDataWriter, TProperty> write, Func<NetDataReader, TProperty> read)
			{
			}

			[Token(Token = "0x6000424")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000425")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000426")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000427")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000428")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000429")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x20000A3")]
		private sealed class FastCallStruct<TClass, TProperty> : FastCallSpecific<TClass, TProperty> where TProperty : struct, INetSerializable
		{
			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TProperty _p;

			[Token(Token = "0x600042A")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600042B")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600042C")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600042D")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600042E")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600042F")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000430")]
			public FastCallStruct()
			{
			}
		}

		[Token(Token = "0x20000A4")]
		private sealed class FastCallClass<TClass, TProperty> : FastCallSpecific<TClass, TProperty> where TProperty : class, INetSerializable
		{
			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<TProperty> _constructor;

			[Token(Token = "0x6000431")]
			public FastCallClass(Func<TProperty> constructor)
			{
			}

			[Token(Token = "0x6000432")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000433")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000434")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000435")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000436")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000437")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x20000A5")]
		private class IntSerializer<T> : FastCallSpecific<T, int>
		{
			[Token(Token = "0x6000438")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000439")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600043A")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600043B")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600043C")]
			public IntSerializer()
			{
			}
		}

		[Token(Token = "0x20000A6")]
		private class UIntSerializer<T> : FastCallSpecific<T, uint>
		{
			[Token(Token = "0x600043D")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600043E")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600043F")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000440")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000441")]
			public UIntSerializer()
			{
			}
		}

		[Token(Token = "0x20000A7")]
		private class ShortSerializer<T> : FastCallSpecific<T, short>
		{
			[Token(Token = "0x6000442")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000443")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000444")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000445")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000446")]
			public ShortSerializer()
			{
			}
		}

		[Token(Token = "0x20000A8")]
		private class UShortSerializer<T> : FastCallSpecific<T, ushort>
		{
			[Token(Token = "0x6000447")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000448")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000449")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600044A")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600044B")]
			public UShortSerializer()
			{
			}
		}

		[Token(Token = "0x20000A9")]
		private class LongSerializer<T> : FastCallSpecific<T, long>
		{
			[Token(Token = "0x600044C")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600044D")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600044E")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600044F")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000450")]
			public LongSerializer()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		private class ULongSerializer<T> : FastCallSpecific<T, ulong>
		{
			[Token(Token = "0x6000451")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000452")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000453")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000454")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000455")]
			public ULongSerializer()
			{
			}
		}

		[Token(Token = "0x20000AB")]
		private class ByteSerializer<T> : FastCallSpecific<T, byte>
		{
			[Token(Token = "0x6000456")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000457")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000458")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000459")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600045A")]
			public ByteSerializer()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		private class SByteSerializer<T> : FastCallSpecific<T, sbyte>
		{
			[Token(Token = "0x600045B")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600045C")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600045D")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600045E")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600045F")]
			public SByteSerializer()
			{
			}
		}

		[Token(Token = "0x20000AD")]
		private class FloatSerializer<T> : FastCallSpecific<T, float>
		{
			[Token(Token = "0x6000460")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000461")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000462")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000463")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000464")]
			public FloatSerializer()
			{
			}
		}

		[Token(Token = "0x20000AE")]
		private class DoubleSerializer<T> : FastCallSpecific<T, double>
		{
			[Token(Token = "0x6000465")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000466")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000467")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000468")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000469")]
			public DoubleSerializer()
			{
			}
		}

		[Token(Token = "0x20000AF")]
		private class BoolSerializer<T> : FastCallSpecific<T, bool>
		{
			[Token(Token = "0x600046A")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600046B")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600046C")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600046D")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600046E")]
			public BoolSerializer()
			{
			}
		}

		[Token(Token = "0x20000B0")]
		private class CharSerializer<T> : FastCallSpecificAuto<T, char>
		{
			[Token(Token = "0x600046F")]
			protected override void ElementWrite(NetDataWriter w, ref char prop)
			{
			}

			[Token(Token = "0x6000470")]
			protected override void ElementRead(NetDataReader r, out char prop)
			{
			}

			[Token(Token = "0x6000471")]
			public CharSerializer()
			{
			}
		}

		[Token(Token = "0x20000B1")]
		private class IPEndPointSerializer<T> : FastCallSpecificAuto<T, IPEndPoint>
		{
			[Token(Token = "0x6000472")]
			protected override void ElementWrite(NetDataWriter w, ref IPEndPoint prop)
			{
			}

			[Token(Token = "0x6000473")]
			protected override void ElementRead(NetDataReader r, out IPEndPoint prop)
			{
			}

			[Token(Token = "0x6000474")]
			public IPEndPointSerializer()
			{
			}
		}

		[Token(Token = "0x20000B2")]
		private class StringSerializer<T> : FastCallSpecific<T, string>
		{
			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int _maxLength;

			[Token(Token = "0x6000475")]
			public StringSerializer(int maxLength)
			{
			}

			[Token(Token = "0x6000476")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000477")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x6000478")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000479")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x20000B3")]
		private class EnumByteSerializer<T> : FastCall<T>
		{
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected readonly PropertyInfo Property;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected readonly Type PropertyType;

			[Token(Token = "0x600047A")]
			public EnumByteSerializer(PropertyInfo property, Type propertyType)
			{
			}

			[Token(Token = "0x600047B")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600047C")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600047D")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x600047E")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			[Token(Token = "0x600047F")]
			public override void ReadList(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000480")]
			public override void WriteList(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x20000B4")]
		private class EnumIntSerializer<T> : EnumByteSerializer<T>
		{
			[Token(Token = "0x6000481")]
			public EnumIntSerializer(PropertyInfo property, Type propertyType)
			{
			}

			[Token(Token = "0x6000482")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			[Token(Token = "0x6000483")]
			public override void Write(T inf, NetDataWriter w)
			{
			}
		}

		[Token(Token = "0x20000B5")]
		private sealed class ClassInfo<T>
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static ClassInfo<T> Instance;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly FastCall<T>[] _serializers;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int _membersCount;

			[Token(Token = "0x6000484")]
			public ClassInfo(List<FastCall<T>> serializers)
			{
			}

			[Token(Token = "0x6000485")]
			public void Write(T obj, NetDataWriter writer)
			{
			}

			[Token(Token = "0x6000486")]
			public void Read(T obj, NetDataReader reader)
			{
			}
		}

		[Token(Token = "0x20000B6")]
		private abstract class CustomType
		{
			[Token(Token = "0x6000487")]
			public abstract FastCall<T> Get<T>();

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x1E7A438", Offset = "0x1E7A438", VA = "0x1E7A438")]
			protected CustomType()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		private sealed class CustomTypeStruct<TProperty> : CustomType where TProperty : struct, INetSerializable
		{
			[Token(Token = "0x6000489")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}

			[Token(Token = "0x600048A")]
			public CustomTypeStruct()
			{
			}
		}

		[Token(Token = "0x20000B8")]
		private sealed class CustomTypeClass<TProperty> : CustomType where TProperty : class, INetSerializable
		{
			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<TProperty> _constructor;

			[Token(Token = "0x600048B")]
			public CustomTypeClass(Func<TProperty> constructor)
			{
			}

			[Token(Token = "0x600048C")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}
		}

		[Token(Token = "0x20000B9")]
		private sealed class CustomTypeStatic<TProperty> : CustomType
		{
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Action<NetDataWriter, TProperty> _writer;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly Func<NetDataReader, TProperty> _reader;

			[Token(Token = "0x600048D")]
			public CustomTypeStatic(Action<NetDataWriter, TProperty> writer, Func<NetDataReader, TProperty> reader)
			{
			}

			[Token(Token = "0x600048E")]
			public override FastCall<T> Get<T>()
			{
				return null;
			}
		}

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NetDataWriter _writer;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int _maxStringLength;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<Type, CustomType> _registeredTypes;

		[Token(Token = "0x60001EE")]
		public void RegisterNestedType<T>() where T : struct, INetSerializable
		{
		}

		[Token(Token = "0x60001EF")]
		public void RegisterNestedType<T>(Func<T> constructor) where T : class, INetSerializable
		{
		}

		[Token(Token = "0x60001F0")]
		public void RegisterNestedType<T>(Action<NetDataWriter, T> writer, Func<NetDataReader, T> reader)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1E79C78", Offset = "0x1E79C78", VA = "0x1E79C78")]
		public NetSerializer()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1E79D44", Offset = "0x1E79D44", VA = "0x1E79D44")]
		public NetSerializer(int maxStringLength)
		{
		}

		[Token(Token = "0x60001F3")]
		private ClassInfo<T> RegisterInternal<T>()
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		public void Register<T>()
		{
		}

		[Token(Token = "0x60001F5")]
		public T Deserialize<T>(NetDataReader reader) where T : class, new()
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		public bool Deserialize<T>(NetDataReader reader, T target) where T : class, new()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		public void Serialize<T>(NetDataWriter writer, T obj) where T : class, new()
		{
		}

		[Token(Token = "0x60001F8")]
		public byte[] Serialize<T>(T obj) where T : class, new()
		{
			return null;
		}
	}
	[Token(Token = "0x2000034")]
	public class NtpPacket
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly DateTime Epoch;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA118", Offset = "0xBDA118")]
		private byte[] <Bytes>k__BackingField;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA128", Offset = "0xBDA128")]
		private DateTime? <DestinationTimestamp>k__BackingField;

		[Token(Token = "0x1700002E")]
		public byte[] Bytes
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x1E7A440", Offset = "0x1E7A440", VA = "0x1E7A440")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA610", Offset = "0xBDA610")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x1E7A448", Offset = "0x1E7A448", VA = "0x1E7A448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA620", Offset = "0xBDA620")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public NtpLeapIndicator LeapIndicator
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x1E7A450", Offset = "0x1E7A450", VA = "0x1E7A450")]
			get
			{
				return default(NtpLeapIndicator);
			}
		}

		[Token(Token = "0x17000030")]
		public int VersionNumber
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x1E7A488", Offset = "0x1E7A488", VA = "0x1E7A488")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x1E7A4C0", Offset = "0x1E7A4C0", VA = "0x1E7A4C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public NtpMode Mode
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1E7A500", Offset = "0x1E7A500", VA = "0x1E7A500")]
			get
			{
				return default(NtpMode);
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x1E7A538", Offset = "0x1E7A538", VA = "0x1E7A538")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public int Stratum
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x1E7A578", Offset = "0x1E7A578", VA = "0x1E7A578")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000033")]
		public int Poll
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x1E7A5B0", Offset = "0x1E7A5B0", VA = "0x1E7A5B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000034")]
		public int Precision
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x1E7A5E8", Offset = "0x1E7A5E8", VA = "0x1E7A5E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000035")]
		public TimeSpan RootDelay
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1E7A620", Offset = "0x1E7A620", VA = "0x1E7A620")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x17000036")]
		public TimeSpan RootDispersion
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x1E7A6BC", Offset = "0x1E7A6BC", VA = "0x1E7A6BC")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x17000037")]
		public uint ReferenceId
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x1E7A6C4", Offset = "0x1E7A6C4", VA = "0x1E7A6C4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000038")]
		public DateTime? ReferenceTimestamp
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x1E7A778", Offset = "0x1E7A778", VA = "0x1E7A778")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public DateTime? OriginTimestamp
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x1E7A8A4", Offset = "0x1E7A8A4", VA = "0x1E7A8A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public DateTime? ReceiveTimestamp
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x1E7A8AC", Offset = "0x1E7A8AC", VA = "0x1E7A8AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public DateTime? TransmitTimestamp
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1E7A8B4", Offset = "0x1E7A8B4", VA = "0x1E7A8B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x1E7A8BC", Offset = "0x1E7A8BC", VA = "0x1E7A8BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public DateTime? DestinationTimestamp
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x1E7AA00", Offset = "0x1E7AA00", VA = "0x1E7AA00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA630", Offset = "0xBDA630")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x1E7AA0C", Offset = "0x1E7AA0C", VA = "0x1E7AA0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA640", Offset = "0xBDA640")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public TimeSpan RoundTripTime
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1E7AA14", Offset = "0x1E7AA14", VA = "0x1E7AA14")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x1700003E")]
		public TimeSpan CorrectionOffset
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x1E7AC88", Offset = "0x1E7AC88", VA = "0x1E7AC88")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1E7ADFC", Offset = "0x1E7ADFC", VA = "0x1E7ADFC")]
		public NtpPacket()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1E7AED0", Offset = "0x1E7AED0", VA = "0x1E7AED0")]
		internal NtpPacket(byte[] bytes)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1E7AF88", Offset = "0x1E7AF88", VA = "0x1E7AF88")]
		public static NtpPacket FromServerResponse(byte[] bytes, DateTime destinationTimestamp)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1E7B028", Offset = "0x1E7B028", VA = "0x1E7B028")]
		internal void ValidateRequest()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1E7B10C", Offset = "0x1E7B10C", VA = "0x1E7B10C")]
		internal void ValidateReply()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1E7AB74", Offset = "0x1E7AB74", VA = "0x1E7AB74")]
		private void CheckTimestamps()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1E7A780", Offset = "0x1E7A780", VA = "0x1E7A780")]
		private DateTime? GetDateTime64(int offset)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1E7A8CC", Offset = "0x1E7A8CC", VA = "0x1E7A8CC")]
		private void SetDateTime64(int offset, DateTime? value)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1E7A628", Offset = "0x1E7A628", VA = "0x1E7A628")]
		private TimeSpan GetTimeSpan32(int offset)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1E7B280", Offset = "0x1E7B280", VA = "0x1E7B280")]
		private ulong GetUInt64BE(int offset)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1E7B32C", Offset = "0x1E7B32C", VA = "0x1E7B32C")]
		private void SetUInt64BE(int offset, ulong value)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1E7B3B4", Offset = "0x1E7B3B4", VA = "0x1E7B3B4")]
		private int GetInt32BE(int offset)
		{
			return default(int);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1E7A6CC", Offset = "0x1E7A6CC", VA = "0x1E7A6CC")]
		private uint GetUInt32BE(int offset)
		{
			return default(uint);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1E7B428", Offset = "0x1E7B428", VA = "0x1E7B428")]
		private static uint SwapEndianness(uint x)
		{
			return default(uint);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1E7B3B8", Offset = "0x1E7B3B8", VA = "0x1E7B3B8")]
		private static ulong SwapEndianness(ulong x)
		{
			return default(ulong);
		}
	}
	[Token(Token = "0x2000035")]
	public enum NtpLeapIndicator
	{
		[Token(Token = "0x400013E")]
		NoWarning,
		[Token(Token = "0x400013F")]
		LastMinuteHas61Seconds,
		[Token(Token = "0x4000140")]
		LastMinuteHas59Seconds,
		[Token(Token = "0x4000141")]
		AlarmCondition
	}
	[Token(Token = "0x2000036")]
	public enum NtpMode
	{
		[Token(Token = "0x4000143")]
		Client = 3,
		[Token(Token = "0x4000144")]
		Server
	}
	[Token(Token = "0x2000037")]
	internal sealed class NtpRequest
	{
		[Token(Token = "0x4000145")]
		private const int ResendTimer = 1000;

		[Token(Token = "0x4000146")]
		private const int KillTimer = 10000;

		[Token(Token = "0x4000147")]
		public const int DefaultPort = 123;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IPEndPoint _ntpEndPoint;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _resendTime;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _killTime;

		[Token(Token = "0x1700003F")]
		public bool NeedToKill
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1E7B4D4", Offset = "0x1E7B4D4", VA = "0x1E7B4D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1E7B4A0", Offset = "0x1E7B4A0", VA = "0x1E7B4A0")]
		public NtpRequest(IPEndPoint endPoint)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1E7B4E8", Offset = "0x1E7B4E8", VA = "0x1E7B4E8")]
		public bool Send(NetSocket socket, int time)
		{
			return default(bool);
		}
	}
}
namespace LiteNetLib.Layers
{
	[Token(Token = "0x2000038")]
	public sealed class Crc32cLayer : PacketLayerBase
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x15456D4", Offset = "0x15456D4", VA = "0x15456D4")]
		public Crc32cLayer()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x154572C", Offset = "0x154572C", VA = "0x154572C", Slot = "4")]
		public override void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x15458E4", Offset = "0x15458E4", VA = "0x15458E4", Slot = "5")]
		public override void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}
	}
	[Token(Token = "0x2000039")]
	public abstract class PacketLayerBase
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int ExtraPacketSizeForLayer;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1545700", Offset = "0x1545700", VA = "0x1545700")]
		protected PacketLayerBase(int extraPacketSizeForLayer)
		{
		}

		[Token(Token = "0x6000226")]
		public abstract void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);

		[Token(Token = "0x6000227")]
		public abstract void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);
	}
	[Token(Token = "0x200003A")]
	public class XorEncryptLayer : PacketLayerBase
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte[] _byteKey;

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1545994", Offset = "0x1545994", VA = "0x1545994")]
		public XorEncryptLayer()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x15459BC", Offset = "0x15459BC", VA = "0x15459BC")]
		public XorEncryptLayer(byte[] key)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1545A94", Offset = "0x1545A94", VA = "0x1545A94")]
		public XorEncryptLayer(string key)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1545AC8", Offset = "0x1545AC8", VA = "0x1545AC8")]
		public void SetKey(string key)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x15459F0", Offset = "0x15459F0", VA = "0x15459F0")]
		public void SetKey(byte[] key)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1545B10", Offset = "0x1545B10", VA = "0x1545B10", Slot = "4")]
		public override void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1545BA8", Offset = "0x1545BA8", VA = "0x1545BA8", Slot = "5")]
		public override void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}
	}
}
namespace Discord
{
	[Token(Token = "0x200003B")]
	public class ActivityManager
	{
		[Token(Token = "0x20000BA")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000151")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9030", Offset = "0xBD9030")]
			internal delegate void ActivityJoinHandler(IntPtr ptr, string secret);

			[Token(Token = "0x2000152")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9044", Offset = "0xBD9044")]
			internal delegate void ActivitySpectateHandler(IntPtr ptr, string secret);

			[Token(Token = "0x2000153")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9058", Offset = "0xBD9058")]
			internal delegate void ActivityJoinRequestHandler(IntPtr ptr, ref User user);

			[Token(Token = "0x2000154")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD906C", Offset = "0xBD906C")]
			internal delegate void ActivityInviteHandler(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity);

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ActivityJoinHandler OnActivityJoin;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ActivitySpectateHandler OnActivitySpectate;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ActivityJoinRequestHandler OnActivityJoinRequest;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ActivityInviteHandler OnActivityInvite;
		}

		[Token(Token = "0x20000BB")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000155")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9080", Offset = "0xBD9080")]
			internal delegate Result RegisterCommandMethod(IntPtr methodsPtr, string command);

			[Token(Token = "0x2000156")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9094", Offset = "0xBD9094")]
			internal delegate Result RegisterSteamMethod(IntPtr methodsPtr, uint steamId);

			[Token(Token = "0x2000157")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD90A8", Offset = "0xBD90A8")]
			internal delegate void UpdateActivityCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000158")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD90BC", Offset = "0xBD90BC")]
			internal delegate void UpdateActivityMethod(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, UpdateActivityCallback callback);

			[Token(Token = "0x2000159")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD90D0", Offset = "0xBD90D0")]
			internal delegate void ClearActivityCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200015A")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD90E4", Offset = "0xBD90E4")]
			internal delegate void ClearActivityMethod(IntPtr methodsPtr, IntPtr callbackData, ClearActivityCallback callback);

			[Token(Token = "0x200015B")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD90F8", Offset = "0xBD90F8")]
			internal delegate void SendRequestReplyCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200015C")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD910C", Offset = "0xBD910C")]
			internal delegate void SendRequestReplyMethod(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, SendRequestReplyCallback callback);

			[Token(Token = "0x200015D")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9120", Offset = "0xBD9120")]
			internal delegate void SendInviteCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200015E")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9134", Offset = "0xBD9134")]
			internal delegate void SendInviteMethod(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, SendInviteCallback callback);

			[Token(Token = "0x200015F")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9148", Offset = "0xBD9148")]
			internal delegate void AcceptInviteCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000160")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD915C", Offset = "0xBD915C")]
			internal delegate void AcceptInviteMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, AcceptInviteCallback callback);

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal RegisterCommandMethod RegisterCommand;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RegisterSteamMethod RegisterSteam;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal UpdateActivityMethod UpdateActivity;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal ClearActivityMethod ClearActivity;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal SendRequestReplyMethod SendRequestReply;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal SendInviteMethod SendInvite;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal AcceptInviteMethod AcceptInvite;
		}

		[Token(Token = "0x20000BC")]
		public delegate void UpdateActivityHandler(Result result);

		[Token(Token = "0x20000BD")]
		public delegate void ClearActivityHandler(Result result);

		[Token(Token = "0x20000BE")]
		public delegate void SendRequestReplyHandler(Result result);

		[Token(Token = "0x20000BF")]
		public delegate void SendInviteHandler(Result result);

		[Token(Token = "0x20000C0")]
		public delegate void AcceptInviteHandler(Result result);

		[Token(Token = "0x20000C1")]
		public delegate void ActivityJoinHandler(string secret);

		[Token(Token = "0x20000C2")]
		public delegate void ActivitySpectateHandler(string secret);

		[Token(Token = "0x20000C3")]
		public delegate void ActivityJoinRequestHandler(ref User user);

		[Token(Token = "0x20000C4")]
		public delegate void ActivityInviteHandler(ActivityActionType type, ref User user, ref Activity activity);

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000040")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1242BD4", Offset = "0x1242BD4", VA = "0x1242BD4")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x1400000C")]
		public event ActivityJoinHandler OnActivityJoin
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x1242CE8", Offset = "0x1242CE8", VA = "0x1242CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA650", Offset = "0xBDA650")]
			add
			{
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x1242D8C", Offset = "0x1242D8C", VA = "0x1242D8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA660", Offset = "0xBDA660")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event ActivitySpectateHandler OnActivitySpectate
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1242E30", Offset = "0x1242E30", VA = "0x1242E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA670", Offset = "0xBDA670")]
			add
			{
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1242ED4", Offset = "0x1242ED4", VA = "0x1242ED4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA680", Offset = "0xBDA680")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event ActivityJoinRequestHandler OnActivityJoinRequest
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x1242F78", Offset = "0x1242F78", VA = "0x1242F78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA690", Offset = "0xBDA690")]
			add
			{
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x124301C", Offset = "0x124301C", VA = "0x124301C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA6A0", Offset = "0xBDA6A0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event ActivityInviteHandler OnActivityInvite
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x12430C0", Offset = "0x12430C0", VA = "0x12430C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA6B0", Offset = "0xBDA6B0")]
			add
			{
			}
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x1243164", Offset = "0x1243164", VA = "0x1243164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA6C0", Offset = "0xBDA6C0")]
			remove
			{
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1242B18", Offset = "0x1242B18", VA = "0x1242B18")]
		public void RegisterCommand()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1243208", Offset = "0x1243208", VA = "0x1243208")]
		internal ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x12432DC", Offset = "0x12432DC", VA = "0x12432DC")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1242B20", Offset = "0x1242B20", VA = "0x1242B20")]
		public void RegisterCommand(string command)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x12436F0", Offset = "0x12436F0", VA = "0x12436F0")]
		public void RegisterSteam(uint steamId)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x12424B8", Offset = "0x12424B8", VA = "0x12424B8")]
		[MonoPInvokeCallback]
		private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1243C98", Offset = "0x1243C98", VA = "0x1243C98")]
		public void UpdateActivity(Activity activity, UpdateActivityHandler callback)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1242560", Offset = "0x1242560", VA = "0x1242560")]
		[MonoPInvokeCallback]
		private static void ClearActivityCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x12442A0", Offset = "0x12442A0", VA = "0x12442A0")]
		public void ClearActivity(ClearActivityHandler callback)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1242608", Offset = "0x1242608", VA = "0x1242608")]
		[MonoPInvokeCallback]
		private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1244884", Offset = "0x1244884", VA = "0x1244884")]
		public void SendRequestReply(long userId, ActivityJoinRequestReply reply, SendRequestReplyHandler callback)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x12426B0", Offset = "0x12426B0", VA = "0x12426B0")]
		[MonoPInvokeCallback]
		private static void SendInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1244EB8", Offset = "0x1244EB8", VA = "0x1244EB8")]
		public void SendInvite(long userId, ActivityActionType type, string content, SendInviteHandler callback)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1242758", Offset = "0x1242758", VA = "0x1242758")]
		[MonoPInvokeCallback]
		private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1245518", Offset = "0x1245518", VA = "0x1245518")]
		public void AcceptInvite(long userId, AcceptInviteHandler callback)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1242800", Offset = "0x1242800", VA = "0x1242800")]
		[MonoPInvokeCallback]
		private static void OnActivityJoinImpl(IntPtr ptr, string secret)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x12428C0", Offset = "0x12428C0", VA = "0x12428C0")]
		[MonoPInvokeCallback]
		private static void OnActivitySpectateImpl(IntPtr ptr, string secret)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1242980", Offset = "0x1242980", VA = "0x1242980")]
		[MonoPInvokeCallback]
		private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1242A40", Offset = "0x1242A40", VA = "0x1242A40")]
		[MonoPInvokeCallback]
		private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity)
		{
		}
	}
	[Token(Token = "0x200003C")]
	internal static class Constants
	{
		[Token(Token = "0x4000153")]
		public const string DllName = "discord_game_sdk";
	}
	[Token(Token = "0x200003D")]
	public enum Result
	{
		[Token(Token = "0x4000155")]
		Ok,
		[Token(Token = "0x4000156")]
		ServiceUnavailable,
		[Token(Token = "0x4000157")]
		InvalidVersion,
		[Token(Token = "0x4000158")]
		LockFailed,
		[Token(Token = "0x4000159")]
		InternalError,
		[Token(Token = "0x400015A")]
		InvalidPayload,
		[Token(Token = "0x400015B")]
		InvalidCommand,
		[Token(Token = "0x400015C")]
		InvalidPermissions,
		[Token(Token = "0x400015D")]
		NotFetched,
		[Token(Token = "0x400015E")]
		NotFound,
		[Token(Token = "0x400015F")]
		Conflict,
		[Token(Token = "0x4000160")]
		InvalidSecret,
		[Token(Token = "0x4000161")]
		InvalidJoinSecret,
		[Token(Token = "0x4000162")]
		NoEligibleActivity,
		[Token(Token = "0x4000163")]
		InvalidInvite,
		[Token(Token = "0x4000164")]
		NotAuthenticated,
		[Token(Token = "0x4000165")]
		InvalidAccessToken,
		[Token(Token = "0x4000166")]
		ApplicationMismatch,
		[Token(Token = "0x4000167")]
		InvalidDataUrl,
		[Token(Token = "0x4000168")]
		InvalidBase64,
		[Token(Token = "0x4000169")]
		NotFiltered,
		[Token(Token = "0x400016A")]
		LobbyFull,
		[Token(Token = "0x400016B")]
		InvalidLobbySecret,
		[Token(Token = "0x400016C")]
		InvalidFilename,
		[Token(Token = "0x400016D")]
		InvalidFileSize,
		[Token(Token = "0x400016E")]
		InvalidEntitlement,
		[Token(Token = "0x400016F")]
		NotInstalled,
		[Token(Token = "0x4000170")]
		NotRunning,
		[Token(Token = "0x4000171")]
		InsufficientBuffer,
		[Token(Token = "0x4000172")]
		PurchaseCanceled,
		[Token(Token = "0x4000173")]
		InvalidGuild,
		[Token(Token = "0x4000174")]
		InvalidEvent,
		[Token(Token = "0x4000175")]
		InvalidChannel,
		[Token(Token = "0x4000176")]
		InvalidOrigin,
		[Token(Token = "0x4000177")]
		RateLimited,
		[Token(Token = "0x4000178")]
		OAuth2Error,
		[Token(Token = "0x4000179")]
		SelectChannelTimeout,
		[Token(Token = "0x400017A")]
		GetGuildTimeout,
		[Token(Token = "0x400017B")]
		SelectVoiceForceRequired,
		[Token(Token = "0x400017C")]
		CaptureShortcutAlreadyListening,
		[Token(Token = "0x400017D")]
		UnauthorizedForAchievement,
		[Token(Token = "0x400017E")]
		InvalidGiftCode,
		[Token(Token = "0x400017F")]
		PurchaseError,
		[Token(Token = "0x4000180")]
		TransactionAborted,
		[Token(Token = "0x4000181")]
		DrawingInitFailed
	}
	[Token(Token = "0x200003E")]
	public enum CreateFlags
	{
		[Token(Token = "0x4000183")]
		Default,
		[Token(Token = "0x4000184")]
		NoRequireDiscord
	}
	[Token(Token = "0x200003F")]
	public enum LogLevel
	{
		[Token(Token = "0x4000186")]
		Error = 1,
		[Token(Token = "0x4000187")]
		Warn,
		[Token(Token = "0x4000188")]
		Info,
		[Token(Token = "0x4000189")]
		Debug
	}
	[Token(Token = "0x2000040")]
	public enum UserFlag
	{
		[Token(Token = "0x400018B")]
		Partner = 2,
		[Token(Token = "0x400018C")]
		HypeSquadEvents = 4,
		[Token(Token = "0x400018D")]
		HypeSquadHouse1 = 0x40,
		[Token(Token = "0x400018E")]
		HypeSquadHouse2 = 0x80,
		[Token(Token = "0x400018F")]
		HypeSquadHouse3 = 0x100
	}
	[Token(Token = "0x2000041")]
	public enum PremiumType
	{
		[Token(Token = "0x4000191")]
		None,
		[Token(Token = "0x4000192")]
		Tier1,
		[Token(Token = "0x4000193")]
		Tier2
	}
	[Token(Token = "0x2000042")]
	public enum ImageType
	{
		[Token(Token = "0x4000195")]
		User
	}
	[Token(Token = "0x2000043")]
	public enum ActivityType
	{
		[Token(Token = "0x4000197")]
		Playing,
		[Token(Token = "0x4000198")]
		Streaming,
		[Token(Token = "0x4000199")]
		Listening,
		[Token(Token = "0x400019A")]
		Watching
	}
	[Token(Token = "0x2000044")]
	public enum ActivityActionType
	{
		[Token(Token = "0x400019C")]
		Join = 1,
		[Token(Token = "0x400019D")]
		Spectate
	}
	[Token(Token = "0x2000045")]
	public enum ActivityJoinRequestReply
	{
		[Token(Token = "0x400019F")]
		No,
		[Token(Token = "0x40001A0")]
		Yes,
		[Token(Token = "0x40001A1")]
		Ignore
	}
	[Token(Token = "0x2000046")]
	public enum Status
	{
		[Token(Token = "0x40001A3")]
		Offline,
		[Token(Token = "0x40001A4")]
		Online,
		[Token(Token = "0x40001A5")]
		Idle,
		[Token(Token = "0x40001A6")]
		DoNotDisturb
	}
	[Token(Token = "0x2000047")]
	public enum RelationshipType
	{
		[Token(Token = "0x40001A8")]
		None,
		[Token(Token = "0x40001A9")]
		Friend,
		[Token(Token = "0x40001AA")]
		Blocked,
		[Token(Token = "0x40001AB")]
		PendingIncoming,
		[Token(Token = "0x40001AC")]
		PendingOutgoing,
		[Token(Token = "0x40001AD")]
		Implicit
	}
	[Token(Token = "0x2000048")]
	public enum LobbyType
	{
		[Token(Token = "0x40001AF")]
		Private = 1,
		[Token(Token = "0x40001B0")]
		Public
	}
	[Token(Token = "0x2000049")]
	public enum LobbySearchComparison
	{
		[Token(Token = "0x40001B2")]
		LessThanOrEqual = -2,
		[Token(Token = "0x40001B3")]
		LessThan,
		[Token(Token = "0x40001B4")]
		Equal,
		[Token(Token = "0x40001B5")]
		GreaterThan,
		[Token(Token = "0x40001B6")]
		GreaterThanOrEqual,
		[Token(Token = "0x40001B7")]
		NotEqual
	}
	[Token(Token = "0x200004A")]
	public enum LobbySearchCast
	{
		[Token(Token = "0x40001B9")]
		String = 1,
		[Token(Token = "0x40001BA")]
		Number
	}
	[Token(Token = "0x200004B")]
	public enum LobbySearchDistance
	{
		[Token(Token = "0x40001BC")]
		Local,
		[Token(Token = "0x40001BD")]
		Default,
		[Token(Token = "0x40001BE")]
		Extended,
		[Token(Token = "0x40001BF")]
		Global
	}
	[Token(Token = "0x200004C")]
	public enum KeyVariant
	{
		[Token(Token = "0x40001C1")]
		Normal,
		[Token(Token = "0x40001C2")]
		Right,
		[Token(Token = "0x40001C3")]
		Left
	}
	[Token(Token = "0x200004D")]
	public enum MouseButton
	{
		[Token(Token = "0x40001C5")]
		Left,
		[Token(Token = "0x40001C6")]
		Middle,
		[Token(Token = "0x40001C7")]
		Right
	}
	[Token(Token = "0x200004E")]
	public enum EntitlementType
	{
		[Token(Token = "0x40001C9")]
		Purchase = 1,
		[Token(Token = "0x40001CA")]
		PremiumSubscription,
		[Token(Token = "0x40001CB")]
		DeveloperGift,
		[Token(Token = "0x40001CC")]
		TestModePurchase,
		[Token(Token = "0x40001CD")]
		FreePurchase,
		[Token(Token = "0x40001CE")]
		UserGift,
		[Token(Token = "0x40001CF")]
		PremiumPurchase
	}
	[Token(Token = "0x200004F")]
	public enum SkuType
	{
		[Token(Token = "0x40001D1")]
		Application = 1,
		[Token(Token = "0x40001D2")]
		DLC,
		[Token(Token = "0x40001D3")]
		Consumable,
		[Token(Token = "0x40001D4")]
		Bundle
	}
	[Token(Token = "0x2000050")]
	public enum InputModeType
	{
		[Token(Token = "0x40001D6")]
		VoiceActivity,
		[Token(Token = "0x40001D7")]
		PushToTalk
	}
	[Token(Token = "0x2000051")]
	public struct User
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Id;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Username;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Discriminator;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Avatar;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Bot;
	}
	[Token(Token = "0x2000052")]
	public struct OAuth2Token
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string AccessToken;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Scopes;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long Expires;
	}
	[Token(Token = "0x2000053")]
	public struct ImageHandle
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ImageType Type;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long Id;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint Size;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1B0BFFC", Offset = "0x1B0BFFC", VA = "0x1B0BFFC")]
		public static ImageHandle User(long id)
		{
			return default(ImageHandle);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1B0C010", Offset = "0x1B0C010", VA = "0x1B0C010")]
		public static ImageHandle User(long id, uint size)
		{
			return default(ImageHandle);
		}
	}
	[Token(Token = "0x2000054")]
	public struct ImageDimensions
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Width;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint Height;
	}
	[Token(Token = "0x2000055")]
	public struct ActivityTimestamps
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Start;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long End;
	}
	[Token(Token = "0x2000056")]
	public struct ActivityAssets
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LargeImage;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string LargeText;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string SmallImage;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string SmallText;
	}
	[Token(Token = "0x2000057")]
	public struct PartySize
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int CurrentSize;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int MaxSize;
	}
	[Token(Token = "0x2000058")]
	public struct ActivityParty
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Id;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PartySize Size;
	}
	[Token(Token = "0x2000059")]
	public struct ActivitySecrets
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Match;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Join;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Spectate;
	}
	[Token(Token = "0x200005A")]
	public struct Activity
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ActivityType Type;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long ApplicationId;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string State;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Details;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ActivityTimestamps Timestamps;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ActivityAssets Assets;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ActivityParty Party;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ActivitySecrets Secrets;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool Instance;
	}
	[Token(Token = "0x200005B")]
	public struct Presence
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Status Status;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Activity Activity;
	}
	[Token(Token = "0x200005C")]
	public struct Relationship
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RelationshipType Type;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public User User;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Presence Presence;
	}
	[Token(Token = "0x200005D")]
	public struct Lobby
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Id;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public LobbyType Type;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long OwnerId;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Secret;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint Capacity;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool Locked;
	}
	[Token(Token = "0x200005E")]
	public struct ImeUnderline
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int From;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int To;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint Color;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint BackgroundColor;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool Thick;
	}
	[Token(Token = "0x200005F")]
	public struct Rect
	{
		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Left;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Top;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int Right;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int Bottom;
	}
	[Token(Token = "0x2000060")]
	public struct FileStat
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Filename;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong Size;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ulong LastModified;
	}
	[Token(Token = "0x2000061")]
	public struct Entitlement
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Id;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public EntitlementType Type;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long SkuId;
	}
	[Token(Token = "0x2000062")]
	public struct SkuPrice
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Amount;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Currency;
	}
	[Token(Token = "0x2000063")]
	public struct Sku
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long Id;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SkuType Type;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SkuPrice Price;
	}
	[Token(Token = "0x2000064")]
	public struct InputMode
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public InputModeType Type;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Shortcut;
	}
	[Token(Token = "0x2000065")]
	public struct UserAchievement
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long UserId;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long AchievementId;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte PercentComplete;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string UnlockedAt;
	}
	[Token(Token = "0x2000066")]
	public struct LobbyTransaction
	{
		[Token(Token = "0x20000C5")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000161")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9170", Offset = "0xBD9170")]
			internal delegate Result SetTypeMethod(IntPtr methodsPtr, LobbyType type);

			[Token(Token = "0x2000162")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9184", Offset = "0xBD9184")]
			internal delegate Result SetOwnerMethod(IntPtr methodsPtr, long ownerId);

			[Token(Token = "0x2000163")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9198", Offset = "0xBD9198")]
			internal delegate Result SetCapacityMethod(IntPtr methodsPtr, uint capacity);

			[Token(Token = "0x2000164")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD91AC", Offset = "0xBD91AC")]
			internal delegate Result SetMetadataMethod(IntPtr methodsPtr, string key, string value);

			[Token(Token = "0x2000165")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD91C0", Offset = "0xBD91C0")]
			internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, string key);

			[Token(Token = "0x2000166")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD91D4", Offset = "0xBD91D4")]
			internal delegate Result SetLockedMethod(IntPtr methodsPtr, bool locked);

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SetTypeMethod SetType;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SetOwnerMethod SetOwner;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SetCapacityMethod SetCapacity;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal SetMetadataMethod SetMetadata;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal DeleteMetadataMethod DeleteMetadata;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal SetLockedMethod SetLocked;
		}

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal IntPtr MethodsPtr;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal object MethodsStructure;

		[Token(Token = "0x17000041")]
		private FFIMethods Methods
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x1B22CF8", Offset = "0x1B22CF8", VA = "0x1B22CF8")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1B22E04", Offset = "0x1B22E04", VA = "0x1B22E04")]
		public void SetType(LobbyType type)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1B22ED0", Offset = "0x1B22ED0", VA = "0x1B22ED0")]
		public void SetOwner(long ownerId)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1B22F9C", Offset = "0x1B22F9C", VA = "0x1B22F9C")]
		public void SetCapacity(uint capacity)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1B23068", Offset = "0x1B23068", VA = "0x1B23068")]
		public void SetMetadata(string key, string value)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1B2313C", Offset = "0x1B2313C", VA = "0x1B2313C")]
		public void DeleteMetadata(string key)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1B23208", Offset = "0x1B23208", VA = "0x1B23208")]
		public void SetLocked(bool locked)
		{
		}
	}
	[Token(Token = "0x2000067")]
	public struct LobbyMemberTransaction
	{
		[Token(Token = "0x20000C6")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000167")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD91E8", Offset = "0xBD91E8")]
			internal delegate Result SetMetadataMethod(IntPtr methodsPtr, string key, string value);

			[Token(Token = "0x2000168")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD91FC", Offset = "0xBD91FC")]
			internal delegate Result DeleteMetadataMethod(IntPtr methodsPtr, string key);

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SetMetadataMethod SetMetadata;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal DeleteMetadataMethod DeleteMetadata;
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal IntPtr MethodsPtr;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal object MethodsStructure;

		[Token(Token = "0x17000042")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1B210E4", Offset = "0x1B210E4", VA = "0x1B210E4")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1B211E4", Offset = "0x1B211E4", VA = "0x1B211E4")]
		public void SetMetadata(string key, string value)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1B21540", Offset = "0x1B21540", VA = "0x1B21540")]
		public void DeleteMetadata(string key)
		{
		}
	}
	[Token(Token = "0x2000068")]
	public struct LobbySearchQuery
	{
		[Token(Token = "0x20000C7")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000169")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9210", Offset = "0xBD9210")]
			internal delegate Result FilterMethod(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value);

			[Token(Token = "0x200016A")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9224", Offset = "0xBD9224")]
			internal delegate Result SortMethod(IntPtr methodsPtr, string key, LobbySearchCast cast, string value);

			[Token(Token = "0x200016B")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9238", Offset = "0xBD9238")]
			internal delegate Result LimitMethod(IntPtr methodsPtr, uint limit);

			[Token(Token = "0x200016C")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD924C", Offset = "0xBD924C")]
			internal delegate Result DistanceMethod(IntPtr methodsPtr, LobbySearchDistance distance);

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal FilterMethod Filter;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SortMethod Sort;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal LimitMethod Limit;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal DistanceMethod Distance;
		}

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal IntPtr MethodsPtr;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal object MethodsStructure;

		[Token(Token = "0x17000043")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x1B21A2C", Offset = "0x1B21A2C", VA = "0x1B21A2C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1B21B30", Offset = "0x1B21B30", VA = "0x1B21B30")]
		public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1B21EEC", Offset = "0x1B21EEC", VA = "0x1B21EEC")]
		public void Sort(string key, LobbySearchCast cast, string value)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1B22284", Offset = "0x1B22284", VA = "0x1B22284")]
		public void Limit(uint limit)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1B225D0", Offset = "0x1B225D0", VA = "0x1B225D0")]
		public void Distance(LobbySearchDistance distance)
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class ResultException : Exception
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public readonly Result Result;

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1AF089C", Offset = "0x1AF089C", VA = "0x1AF089C")]
		public ResultException(Result result)
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class Discord : IDisposable
	{
		[Token(Token = "0x20000C8")]
		internal struct FFIEvents
		{
		}

		[Token(Token = "0x20000C9")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200016D")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9260", Offset = "0xBD9260")]
			internal delegate void DestroyHandler(IntPtr MethodsPtr);

			[Token(Token = "0x200016E")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9274", Offset = "0xBD9274")]
			internal delegate Result RunCallbacksMethod(IntPtr methodsPtr);

			[Token(Token = "0x200016F")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9288", Offset = "0xBD9288")]
			internal delegate void SetLogHookCallback(IntPtr ptr, LogLevel level, string message);

			[Token(Token = "0x2000170")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD929C", Offset = "0xBD929C")]
			internal delegate void SetLogHookMethod(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, SetLogHookCallback callback);

			[Token(Token = "0x2000171")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD92B0", Offset = "0xBD92B0")]
			internal delegate IntPtr GetApplicationManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x2000172")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD92C4", Offset = "0xBD92C4")]
			internal delegate IntPtr GetUserManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x2000173")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD92D8", Offset = "0xBD92D8")]
			internal delegate IntPtr GetImageManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x2000174")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD92EC", Offset = "0xBD92EC")]
			internal delegate IntPtr GetActivityManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x2000175")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9300", Offset = "0xBD9300")]
			internal delegate IntPtr GetRelationshipManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x2000176")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9314", Offset = "0xBD9314")]
			internal delegate IntPtr GetLobbyManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x2000177")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9328", Offset = "0xBD9328")]
			internal delegate IntPtr GetNetworkManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x2000178")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD933C", Offset = "0xBD933C")]
			internal delegate IntPtr GetOverlayManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x2000179")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9350", Offset = "0xBD9350")]
			internal delegate IntPtr GetStorageManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x200017A")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9364", Offset = "0xBD9364")]
			internal delegate IntPtr GetStoreManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x200017B")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9378", Offset = "0xBD9378")]
			internal delegate IntPtr GetVoiceManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x200017C")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD938C", Offset = "0xBD938C")]
			internal delegate IntPtr GetAchievementManagerMethod(IntPtr discordPtr);

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal DestroyHandler Destroy;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RunCallbacksMethod RunCallbacks;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SetLogHookMethod SetLogHook;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetApplicationManagerMethod GetApplicationManager;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal GetUserManagerMethod GetUserManager;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal GetImageManagerMethod GetImageManager;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal GetActivityManagerMethod GetActivityManager;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal GetRelationshipManagerMethod GetRelationshipManager;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GetLobbyManagerMethod GetLobbyManager;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal GetNetworkManagerMethod GetNetworkManager;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal GetOverlayManagerMethod GetOverlayManager;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal GetStorageManagerMethod GetStorageManager;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal GetStoreManagerMethod GetStoreManager;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal GetVoiceManagerMethod GetVoiceManager;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal GetAchievementManagerMethod GetAchievementManager;
		}

		[Token(Token = "0x20000CA")]
		internal struct FFICreateParams
		{
			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal long ClientId;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ulong Flags;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IntPtr Events;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal IntPtr EventData;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal IntPtr ApplicationEvents;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint ApplicationVersion;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal IntPtr UserEvents;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal uint UserVersion;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal IntPtr ImageEvents;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal uint ImageVersion;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal IntPtr ActivityEvents;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal uint ActivityVersion;

			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal IntPtr RelationshipEvents;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal uint RelationshipVersion;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal IntPtr LobbyEvents;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal uint LobbyVersion;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal IntPtr NetworkEvents;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal uint NetworkVersion;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal IntPtr OverlayEvents;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal uint OverlayVersion;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			internal IntPtr StorageEvents;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal uint StorageVersion;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal IntPtr StoreEvents;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal uint StoreVersion;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			internal IntPtr VoiceEvents;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			internal uint VoiceVersion;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal IntPtr AchievementEvents;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			internal uint AchievementVersion;
		}

		[Token(Token = "0x20000CB")]
		public delegate void SetLogHookHandler(LogLevel level, string message);

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private GCHandle SelfHandle;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IntPtr EventsPtr;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FFIEvents Events;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr ApplicationEventsPtr;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ApplicationManager.FFIEvents ApplicationEvents;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal ApplicationManager ApplicationManagerInstance;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IntPtr UserEventsPtr;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UserManager.FFIEvents UserEvents;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal UserManager UserManagerInstance;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IntPtr ImageEventsPtr;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ImageManager.FFIEvents ImageEvents;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal ImageManager ImageManagerInstance;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private IntPtr ActivityEventsPtr;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ActivityManager.FFIEvents ActivityEvents;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal ActivityManager ActivityManagerInstance;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private IntPtr RelationshipEventsPtr;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RelationshipManager.FFIEvents RelationshipEvents;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal RelationshipManager RelationshipManagerInstance;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private IntPtr LobbyEventsPtr;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private LobbyManager.FFIEvents LobbyEvents;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		internal LobbyManager LobbyManagerInstance;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private IntPtr NetworkEventsPtr;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private NetworkManager.FFIEvents NetworkEvents;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		internal NetworkManager NetworkManagerInstance;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private IntPtr OverlayEventsPtr;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private OverlayManager.FFIEvents OverlayEvents;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal OverlayManager OverlayManagerInstance;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private IntPtr StorageEventsPtr;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private StorageManager.FFIEvents StorageEvents;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal StorageManager StorageManagerInstance;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private IntPtr StoreEventsPtr;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private StoreManager.FFIEvents StoreEvents;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		internal StoreManager StoreManagerInstance;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private IntPtr VoiceEventsPtr;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private VoiceManager.FFIEvents VoiceEvents;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		internal VoiceManager VoiceManagerInstance;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private IntPtr AchievementEventsPtr;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private AchievementManager.FFIEvents AchievementEvents;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		internal AchievementManager AchievementManagerInstance;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private object MethodsStructure;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private GCHandle? setLogHook;

		[Token(Token = "0x17000044")]
		private FFIMethods Methods
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x124BC7C", Offset = "0x124BC7C", VA = "0x124BC7C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[PreserveSig]
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x124BBE0", Offset = "0x124BBE0", VA = "0x124BBE0")]
		private static extern Result DiscordCreate(uint version, ref FFICreateParams createParams, out IntPtr manager);

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x124BD84", Offset = "0x124BD84", VA = "0x124BD84")]
		public Discord(long clientId, ulong flags)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x124C108", Offset = "0x124C108", VA = "0x124C108")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x124C17C", Offset = "0x124C17C", VA = "0x124C17C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x124C2F8", Offset = "0x124C2F8", VA = "0x124C2F8")]
		public void RunCallbacks()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x124BB38", Offset = "0x124BB38", VA = "0x124BB38")]
		[MonoPInvokeCallback]
		private static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x124C3A0", Offset = "0x124C3A0", VA = "0x124C3A0")]
		public void SetLogHook(LogLevel minLevel, SetLogHookHandler callback)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x124C4F0", Offset = "0x124C4F0", VA = "0x124C4F0")]
		public ApplicationManager GetApplicationManager()
		{
			return null;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x124C5AC", Offset = "0x124C5AC", VA = "0x124C5AC")]
		public UserManager GetUserManager()
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x124C66C", Offset = "0x124C66C", VA = "0x124C66C")]
		public ImageManager GetImageManager()
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x124C72C", Offset = "0x124C72C", VA = "0x124C72C")]
		public ActivityManager GetActivityManager()
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x124C7E8", Offset = "0x124C7E8", VA = "0x124C7E8")]
		public RelationshipManager GetRelationshipManager()
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x124C8A8", Offset = "0x124C8A8", VA = "0x124C8A8")]
		public LobbyManager GetLobbyManager()
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x124C968", Offset = "0x124C968", VA = "0x124C968")]
		public NetworkManager GetNetworkManager()
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x124CA28", Offset = "0x124CA28", VA = "0x124CA28")]
		public OverlayManager GetOverlayManager()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x124CAE8", Offset = "0x124CAE8", VA = "0x124CAE8")]
		public StorageManager GetStorageManager()
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x124CBA8", Offset = "0x124CBA8", VA = "0x124CBA8")]
		public StoreManager GetStoreManager()
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x124CC68", Offset = "0x124CC68", VA = "0x124CC68")]
		public VoiceManager GetVoiceManager()
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x124CD28", Offset = "0x124CD28", VA = "0x124CD28")]
		public AchievementManager GetAchievementManager()
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	internal class MonoPInvokeCallbackAttribute : Attribute
	{
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1AF0218", Offset = "0x1AF0218", VA = "0x1AF0218")]
		public MonoPInvokeCallbackAttribute()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class ApplicationManager
	{
		[Token(Token = "0x20000CC")]
		internal struct FFIEvents
		{
		}

		[Token(Token = "0x20000CD")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200017D")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD93A0", Offset = "0xBD93A0")]
			internal delegate void ValidateOrExitCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200017E")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD93B4", Offset = "0xBD93B4")]
			internal delegate void ValidateOrExitMethod(IntPtr methodsPtr, IntPtr callbackData, ValidateOrExitCallback callback);

			[Token(Token = "0x200017F")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD93C8", Offset = "0xBD93C8")]
			internal delegate void GetCurrentLocaleMethod(IntPtr methodsPtr, StringBuilder locale);

			[Token(Token = "0x2000180")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD93DC", Offset = "0xBD93DC")]
			internal delegate void GetCurrentBranchMethod(IntPtr methodsPtr, StringBuilder branch);

			[Token(Token = "0x2000181")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD93F0", Offset = "0xBD93F0")]
			internal delegate void GetOAuth2TokenCallback(IntPtr ptr, Result result, ref OAuth2Token oauth2Token);

			[Token(Token = "0x2000182")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9404", Offset = "0xBD9404")]
			internal delegate void GetOAuth2TokenMethod(IntPtr methodsPtr, IntPtr callbackData, GetOAuth2TokenCallback callback);

			[Token(Token = "0x2000183")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9418", Offset = "0xBD9418")]
			internal delegate void GetTicketCallback(IntPtr ptr, Result result, ref string data);

			[Token(Token = "0x2000184")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD942C", Offset = "0xBD942C")]
			internal delegate void GetTicketMethod(IntPtr methodsPtr, IntPtr callbackData, GetTicketCallback callback);

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ValidateOrExitMethod ValidateOrExit;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GetCurrentLocaleMethod GetCurrentLocale;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetCurrentBranchMethod GetCurrentBranch;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetOAuth2TokenMethod GetOAuth2Token;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal GetTicketMethod GetTicket;
		}

		[Token(Token = "0x20000CE")]
		public delegate void ValidateOrExitHandler(Result result);

		[Token(Token = "0x20000CF")]
		public delegate void GetOAuth2TokenHandler(Result result, ref OAuth2Token oauth2Token);

		[Token(Token = "0x20000D0")]
		public delegate void GetTicketHandler(Result result, ref string data);

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000045")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1249074", Offset = "0x1249074", VA = "0x1249074")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1249180", Offset = "0x1249180", VA = "0x1249180")]
		internal ApplicationManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1249244", Offset = "0x1249244", VA = "0x1249244")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1248E5C", Offset = "0x1248E5C", VA = "0x1248E5C")]
		[MonoPInvokeCallback]
		private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1249528", Offset = "0x1249528", VA = "0x1249528")]
		public void ValidateOrExit(ValidateOrExitHandler callback)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x124989C", Offset = "0x124989C", VA = "0x124989C")]
		public string GetCurrentLocale()
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1249BB8", Offset = "0x1249BB8", VA = "0x1249BB8")]
		public string GetCurrentBranch()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1248F04", Offset = "0x1248F04", VA = "0x1248F04")]
		[MonoPInvokeCallback]
		private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x124A164", Offset = "0x124A164", VA = "0x124A164")]
		public void GetOAuth2Token(GetOAuth2TokenHandler callback)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1248FBC", Offset = "0x1248FBC", VA = "0x1248FBC")]
		[MonoPInvokeCallback]
		private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x124A768", Offset = "0x124A768", VA = "0x124A768")]
		public void GetTicket(GetTicketHandler callback)
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class UserManager
	{
		[Token(Token = "0x20000D1")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000185")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9440", Offset = "0xBD9440")]
			internal delegate void CurrentUserUpdateHandler(IntPtr ptr);

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal CurrentUserUpdateHandler OnCurrentUserUpdate;
		}

		[Token(Token = "0x20000D2")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000186")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9454", Offset = "0xBD9454")]
			internal delegate Result GetCurrentUserMethod(IntPtr methodsPtr, ref User currentUser);

			[Token(Token = "0x2000187")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9468", Offset = "0xBD9468")]
			internal delegate void GetUserCallback(IntPtr ptr, Result result, ref User user);

			[Token(Token = "0x2000188")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD947C", Offset = "0xBD947C")]
			internal delegate void GetUserMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, GetUserCallback callback);

			[Token(Token = "0x2000189")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9490", Offset = "0xBD9490")]
			internal delegate Result GetCurrentUserPremiumTypeMethod(IntPtr methodsPtr, ref PremiumType premiumType);

			[Token(Token = "0x200018A")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD94A4", Offset = "0xBD94A4")]
			internal delegate Result CurrentUserHasFlagMethod(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag);

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal GetCurrentUserMethod GetCurrentUser;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GetUserMethod GetUser;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal CurrentUserHasFlagMethod CurrentUserHasFlag;
		}

		[Token(Token = "0x20000D3")]
		public delegate void GetUserHandler(Result result, ref User user);

		[Token(Token = "0x20000D4")]
		public delegate void CurrentUserUpdateHandler();

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000046")]
		private FFIMethods Methods
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x153ACE0", Offset = "0x153ACE0", VA = "0x153ACE0")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000010")]
		public event CurrentUserUpdateHandler OnCurrentUserUpdate
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x153ADE4", Offset = "0x153ADE4", VA = "0x153ADE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA7A0", Offset = "0xBDA7A0")]
			add
			{
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x153AE88", Offset = "0x153AE88", VA = "0x153AE88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA7B0", Offset = "0xBDA7B0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x153AF2C", Offset = "0x153AF2C", VA = "0x153AF2C")]
		internal UserManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x153B000", Offset = "0x153B000", VA = "0x153B000")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x153B0C4", Offset = "0x153B0C4", VA = "0x153B0C4")]
		public User GetCurrentUser()
		{
			return default(User);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x153AB70", Offset = "0x153AB70", VA = "0x153AB70")]
		[MonoPInvokeCallback]
		private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x153B6AC", Offset = "0x153B6AC", VA = "0x153B6AC")]
		public void GetUser(long userId, GetUserHandler callback)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x153BA44", Offset = "0x153BA44", VA = "0x153BA44")]
		public PremiumType GetCurrentUserPremiumType()
		{
			return default(PremiumType);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x153BD78", Offset = "0x153BD78", VA = "0x153BD78")]
		public bool CurrentUserHasFlag(UserFlag flag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x153AC28", Offset = "0x153AC28", VA = "0x153AC28")]
		[MonoPInvokeCallback]
		private static void OnCurrentUserUpdateImpl(IntPtr ptr)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class ImageManager
	{
		[Token(Token = "0x20000D5")]
		internal struct FFIEvents
		{
		}

		[Token(Token = "0x20000D6")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200018B")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD94B8", Offset = "0xBD94B8")]
			internal delegate void FetchCallback(IntPtr ptr, Result result, ImageHandle handleResult);

			[Token(Token = "0x200018C")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD94CC", Offset = "0xBD94CC")]
			internal delegate void FetchMethod(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback);

			[Token(Token = "0x200018D")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD94E0", Offset = "0xBD94E0")]
			internal delegate Result GetDimensionsMethod(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions);

			[Token(Token = "0x200018E")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD94F4", Offset = "0xBD94F4")]
			internal delegate Result GetDataMethod(IntPtr methodsPtr, ImageHandle handle, byte[] data, int dataLen);

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal FetchMethod Fetch;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GetDimensionsMethod GetDimensions;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetDataMethod GetData;
		}

		[Token(Token = "0x20000D7")]
		public delegate void FetchHandler(Result result, ImageHandle handleResult);

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000047")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1B0C0F8", Offset = "0x1B0C0F8", VA = "0x1B0C0F8")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1B0C204", Offset = "0x1B0C204", VA = "0x1B0C204")]
		internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1B0C2C8", Offset = "0x1B0C2C8", VA = "0x1B0C2C8")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1B0C01C", Offset = "0x1B0C01C", VA = "0x1B0C01C")]
		[MonoPInvokeCallback]
		private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1B0C6B8", Offset = "0x1B0C6B8", VA = "0x1B0C6B8")]
		public void Fetch(ImageHandle handle, bool refresh, FetchHandler callback)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1B0CB7C", Offset = "0x1B0CB7C", VA = "0x1B0CB7C")]
		public ImageDimensions GetDimensions(ImageHandle handle)
		{
			return default(ImageDimensions);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1B0CFD0", Offset = "0x1B0CFD0", VA = "0x1B0CFD0")]
		public void GetData(ImageHandle handle, byte[] data)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1B0D444", Offset = "0x1B0D444", VA = "0x1B0D444")]
		public void Fetch(ImageHandle handle, FetchHandler callback)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1B0D47C", Offset = "0x1B0D47C", VA = "0x1B0D47C")]
		public byte[] GetData(ImageHandle handle)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	public class RelationshipManager
	{
		[Token(Token = "0x20000D8")]
		internal struct FFIEvents
		{
			[Token(Token = "0x200018F")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9508", Offset = "0xBD9508")]
			internal delegate void RefreshHandler(IntPtr ptr);

			[Token(Token = "0x2000190")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD951C", Offset = "0xBD951C")]
			internal delegate void RelationshipUpdateHandler(IntPtr ptr, ref Relationship relationship);

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal RefreshHandler OnRefresh;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RelationshipUpdateHandler OnRelationshipUpdate;
		}

		[Token(Token = "0x20000D9")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000191")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9530", Offset = "0xBD9530")]
			internal delegate bool FilterCallback(IntPtr ptr, ref Relationship relationship);

			[Token(Token = "0x2000192")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9544", Offset = "0xBD9544")]
			internal delegate void FilterMethod(IntPtr methodsPtr, IntPtr callbackData, FilterCallback callback);

			[Token(Token = "0x2000193")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9558", Offset = "0xBD9558")]
			internal delegate Result CountMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x2000194")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD956C", Offset = "0xBD956C")]
			internal delegate Result GetMethod(IntPtr methodsPtr, long userId, ref Relationship relationship);

			[Token(Token = "0x2000195")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9580", Offset = "0xBD9580")]
			internal delegate Result GetAtMethod(IntPtr methodsPtr, uint index, ref Relationship relationship);

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal FilterMethod Filter;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal CountMethod Count;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetMethod Get;

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetAtMethod GetAt;
		}

		[Token(Token = "0x20000DA")]
		public delegate bool FilterHandler(ref Relationship relationship);

		[Token(Token = "0x20000DB")]
		public delegate void RefreshHandler();

		[Token(Token = "0x20000DC")]
		public delegate void RelationshipUpdateHandler(ref Relationship relationship);

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000048")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x1AFBFC4", Offset = "0x1AFBFC4", VA = "0x1AFBFC4")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000011")]
		public event RefreshHandler OnRefresh
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x1AFC0C8", Offset = "0x1AFC0C8", VA = "0x1AFC0C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA7F0", Offset = "0xBDA7F0")]
			add
			{
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x1AFC16C", Offset = "0x1AFC16C", VA = "0x1AFC16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA800", Offset = "0xBDA800")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event RelationshipUpdateHandler OnRelationshipUpdate
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x1AFC210", Offset = "0x1AFC210", VA = "0x1AFC210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA810", Offset = "0xBDA810")]
			add
			{
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1AFC2B4", Offset = "0x1AFC2B4", VA = "0x1AFC2B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA820", Offset = "0xBDA820")]
			remove
			{
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1AFC358", Offset = "0x1AFC358", VA = "0x1AFC358")]
		internal RelationshipManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1AFC428", Offset = "0x1AFC428", VA = "0x1AFC428")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1AFBDB4", Offset = "0x1AFBDB4", VA = "0x1AFBDB4")]
		[MonoPInvokeCallback]
		private static bool FilterCallbackImpl(IntPtr ptr, ref Relationship relationship)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1AFC790", Offset = "0x1AFC790", VA = "0x1AFC790")]
		public void Filter(FilterHandler callback)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x1AFCB14", Offset = "0x1AFCB14", VA = "0x1AFCB14")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1AFCE44", Offset = "0x1AFCE44", VA = "0x1AFCE44")]
		public Relationship Get(long userId)
		{
			return default(Relationship);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1AFD1C0", Offset = "0x1AFD1C0", VA = "0x1AFD1C0")]
		public Relationship GetAt(uint index)
		{
			return default(Relationship);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1AFBE4C", Offset = "0x1AFBE4C", VA = "0x1AFBE4C")]
		[MonoPInvokeCallback]
		private static void OnRefreshImpl(IntPtr ptr)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1AFBF04", Offset = "0x1AFBF04", VA = "0x1AFBF04")]
		[MonoPInvokeCallback]
		private static void OnRelationshipUpdateImpl(IntPtr ptr, ref Relationship relationship)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class LobbyManager
	{
		[Token(Token = "0x20000DD")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000196")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9594", Offset = "0xBD9594")]
			internal delegate void LobbyUpdateHandler(IntPtr ptr, long lobbyId);

			[Token(Token = "0x2000197")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD95A8", Offset = "0xBD95A8")]
			internal delegate void LobbyDeleteHandler(IntPtr ptr, long lobbyId, uint reason);

			[Token(Token = "0x2000198")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD95BC", Offset = "0xBD95BC")]
			internal delegate void MemberConnectHandler(IntPtr ptr, long lobbyId, long userId);

			[Token(Token = "0x2000199")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD95D0", Offset = "0xBD95D0")]
			internal delegate void MemberUpdateHandler(IntPtr ptr, long lobbyId, long userId);

			[Token(Token = "0x200019A")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD95E4", Offset = "0xBD95E4")]
			internal delegate void MemberDisconnectHandler(IntPtr ptr, long lobbyId, long userId);

			[Token(Token = "0x200019B")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD95F8", Offset = "0xBD95F8")]
			internal delegate void LobbyMessageHandler(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x200019C")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD960C", Offset = "0xBD960C")]
			internal delegate void SpeakingHandler(IntPtr ptr, long lobbyId, long userId, bool speaking);

			[Token(Token = "0x200019D")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9620", Offset = "0xBD9620")]
			internal delegate void NetworkMessageHandler(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal LobbyUpdateHandler OnLobbyUpdate;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal LobbyDeleteHandler OnLobbyDelete;

			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MemberConnectHandler OnMemberConnect;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal MemberUpdateHandler OnMemberUpdate;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal MemberDisconnectHandler OnMemberDisconnect;

			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal LobbyMessageHandler OnLobbyMessage;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal SpeakingHandler OnSpeaking;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal NetworkMessageHandler OnNetworkMessage;
		}

		[Token(Token = "0x20000DE")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200019E")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9634", Offset = "0xBD9634")]
			internal delegate Result GetLobbyCreateTransactionMethod(IntPtr methodsPtr, ref IntPtr transaction);

			[Token(Token = "0x200019F")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9648", Offset = "0xBD9648")]
			internal delegate Result GetLobbyUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction);

			[Token(Token = "0x20001A0")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD965C", Offset = "0xBD965C")]
			internal delegate Result GetMemberUpdateTransactionMethod(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction);

			[Token(Token = "0x20001A1")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9670", Offset = "0xBD9670")]
			internal delegate void CreateLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

			[Token(Token = "0x20001A2")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9684", Offset = "0xBD9684")]
			internal delegate void CreateLobbyMethod(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, CreateLobbyCallback callback);

			[Token(Token = "0x20001A3")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9698", Offset = "0xBD9698")]
			internal delegate void UpdateLobbyCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001A4")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD96AC", Offset = "0xBD96AC")]
			internal delegate void UpdateLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, UpdateLobbyCallback callback);

			[Token(Token = "0x20001A5")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD96C0", Offset = "0xBD96C0")]
			internal delegate void DeleteLobbyCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001A6")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD96D4", Offset = "0xBD96D4")]
			internal delegate void DeleteLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DeleteLobbyCallback callback);

			[Token(Token = "0x20001A7")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD96E8", Offset = "0xBD96E8")]
			internal delegate void ConnectLobbyCallback(IntPtr ptr, Result result, ref Lobby lobby);

			[Token(Token = "0x20001A8")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD96FC", Offset = "0xBD96FC")]
			internal delegate void ConnectLobbyMethod(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, ConnectLobbyCallback callback);

			[Token(Token = "0x20001A9")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9710", Offset = "0xBD9710")]
			internal delegate void ConnectLobbyWithActivitySecretCallback(IntPtr ptr, Result result, ref Lobby lobby);

			[Token(Token = "0x20001AA")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9724", Offset = "0xBD9724")]
			internal delegate void ConnectLobbyWithActivitySecretMethod(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, ConnectLobbyWithActivitySecretCallback callback);

			[Token(Token = "0x20001AB")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9738", Offset = "0xBD9738")]
			internal delegate void DisconnectLobbyCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001AC")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD974C", Offset = "0xBD974C")]
			internal delegate void DisconnectLobbyMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectLobbyCallback callback);

			[Token(Token = "0x20001AD")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9760", Offset = "0xBD9760")]
			internal delegate Result GetLobbyMethod(IntPtr methodsPtr, long lobbyId, ref Lobby lobby);

			[Token(Token = "0x20001AE")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9774", Offset = "0xBD9774")]
			internal delegate Result GetLobbyActivitySecretMethod(IntPtr methodsPtr, long lobbyId, StringBuilder secret);

			[Token(Token = "0x20001AF")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9788", Offset = "0xBD9788")]
			internal delegate Result GetLobbyMetadataValueMethod(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value);

			[Token(Token = "0x20001B0")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD979C", Offset = "0xBD979C")]
			internal delegate Result GetLobbyMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key);

			[Token(Token = "0x20001B1")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD97B0", Offset = "0xBD97B0")]
			internal delegate Result LobbyMetadataCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

			[Token(Token = "0x20001B2")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD97C4", Offset = "0xBD97C4")]
			internal delegate Result MemberCountMethod(IntPtr methodsPtr, long lobbyId, ref int count);

			[Token(Token = "0x20001B3")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD97D8", Offset = "0xBD97D8")]
			internal delegate Result GetMemberUserIdMethod(IntPtr methodsPtr, long lobbyId, int index, ref long userId);

			[Token(Token = "0x20001B4")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD97EC", Offset = "0xBD97EC")]
			internal delegate Result GetMemberUserMethod(IntPtr methodsPtr, long lobbyId, long userId, ref User user);

			[Token(Token = "0x20001B5")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9800", Offset = "0xBD9800")]
			internal delegate Result GetMemberMetadataValueMethod(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value);

			[Token(Token = "0x20001B6")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9814", Offset = "0xBD9814")]
			internal delegate Result GetMemberMetadataKeyMethod(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key);

			[Token(Token = "0x20001B7")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9828", Offset = "0xBD9828")]
			internal delegate Result MemberMetadataCountMethod(IntPtr methodsPtr, long lobbyId, long userId, ref int count);

			[Token(Token = "0x20001B8")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD983C", Offset = "0xBD983C")]
			internal delegate void UpdateMemberCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001B9")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9850", Offset = "0xBD9850")]
			internal delegate void UpdateMemberMethod(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, UpdateMemberCallback callback);

			[Token(Token = "0x20001BA")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9864", Offset = "0xBD9864")]
			internal delegate void SendLobbyMessageCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001BB")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9878", Offset = "0xBD9878")]
			internal delegate void SendLobbyMessageMethod(IntPtr methodsPtr, long lobbyId, byte[] data, int dataLen, IntPtr callbackData, SendLobbyMessageCallback callback);

			[Token(Token = "0x20001BC")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD988C", Offset = "0xBD988C")]
			internal delegate Result GetSearchQueryMethod(IntPtr methodsPtr, ref IntPtr query);

			[Token(Token = "0x20001BD")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD98A0", Offset = "0xBD98A0")]
			internal delegate void SearchCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001BE")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD98B4", Offset = "0xBD98B4")]
			internal delegate void SearchMethod(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, SearchCallback callback);

			[Token(Token = "0x20001BF")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD98C8", Offset = "0xBD98C8")]
			internal delegate void LobbyCountMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x20001C0")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD98DC", Offset = "0xBD98DC")]
			internal delegate Result GetLobbyIdMethod(IntPtr methodsPtr, int index, ref long lobbyId);

			[Token(Token = "0x20001C1")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD98F0", Offset = "0xBD98F0")]
			internal delegate void ConnectVoiceCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001C2")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9904", Offset = "0xBD9904")]
			internal delegate void ConnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, ConnectVoiceCallback callback);

			[Token(Token = "0x20001C3")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9918", Offset = "0xBD9918")]
			internal delegate void DisconnectVoiceCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001C4")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD992C", Offset = "0xBD992C")]
			internal delegate void DisconnectVoiceMethod(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, DisconnectVoiceCallback callback);

			[Token(Token = "0x20001C5")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9940", Offset = "0xBD9940")]
			internal delegate Result ConnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

			[Token(Token = "0x20001C6")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9954", Offset = "0xBD9954")]
			internal delegate Result DisconnectNetworkMethod(IntPtr methodsPtr, long lobbyId);

			[Token(Token = "0x20001C7")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9968", Offset = "0xBD9968")]
			internal delegate Result FlushNetworkMethod(IntPtr methodsPtr);

			[Token(Token = "0x20001C8")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD997C", Offset = "0xBD997C")]
			internal delegate Result OpenNetworkChannelMethod(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable);

			[Token(Token = "0x20001C9")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9990", Offset = "0xBD9990")]
			internal delegate Result SendNetworkMessageMethod(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, byte[] data, int dataLen);

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal GetLobbyCreateTransactionMethod GetLobbyCreateTransaction;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetMemberUpdateTransactionMethod GetMemberUpdateTransaction;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal CreateLobbyMethod CreateLobby;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal UpdateLobbyMethod UpdateLobby;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal DeleteLobbyMethod DeleteLobby;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ConnectLobbyMethod ConnectLobby;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal DisconnectLobbyMethod DisconnectLobby;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal GetLobbyMethod GetLobby;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal GetLobbyActivitySecretMethod GetLobbyActivitySecret;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal GetLobbyMetadataValueMethod GetLobbyMetadataValue;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal GetLobbyMetadataKeyMethod GetLobbyMetadataKey;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal LobbyMetadataCountMethod LobbyMetadataCount;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal MemberCountMethod MemberCount;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal GetMemberUserIdMethod GetMemberUserId;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal GetMemberUserMethod GetMemberUser;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal GetMemberMetadataValueMethod GetMemberMetadataValue;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal GetMemberMetadataKeyMethod GetMemberMetadataKey;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal MemberMetadataCountMethod MemberMetadataCount;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			internal UpdateMemberMethod UpdateMember;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			internal SendLobbyMessageMethod SendLobbyMessage;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal GetSearchQueryMethod GetSearchQuery;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal SearchMethod Search;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			internal LobbyCountMethod LobbyCount;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			internal GetLobbyIdMethod GetLobbyId;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			internal ConnectVoiceMethod ConnectVoice;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			internal DisconnectVoiceMethod DisconnectVoice;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			internal ConnectNetworkMethod ConnectNetwork;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			internal DisconnectNetworkMethod DisconnectNetwork;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			internal FlushNetworkMethod FlushNetwork;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			internal OpenNetworkChannelMethod OpenNetworkChannel;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			internal SendNetworkMessageMethod SendNetworkMessage;
		}

		[Token(Token = "0x20000DF")]
		public delegate void CreateLobbyHandler(Result result, ref Lobby lobby);

		[Token(Token = "0x20000E0")]
		public delegate void UpdateLobbyHandler(Result result);

		[Token(Token = "0x20000E1")]
		public delegate void DeleteLobbyHandler(Result result);

		[Token(Token = "0x20000E2")]
		public delegate void ConnectLobbyHandler(Result result, ref Lobby lobby);

		[Token(Token = "0x20000E3")]
		public delegate void ConnectLobbyWithActivitySecretHandler(Result result, ref Lobby lobby);

		[Token(Token = "0x20000E4")]
		public delegate void DisconnectLobbyHandler(Result result);

		[Token(Token = "0x20000E5")]
		public delegate void UpdateMemberHandler(Result result);

		[Token(Token = "0x20000E6")]
		public delegate void SendLobbyMessageHandler(Result result);

		[Token(Token = "0x20000E7")]
		public delegate void SearchHandler(Result result);

		[Token(Token = "0x20000E8")]
		public delegate void ConnectVoiceHandler(Result result);

		[Token(Token = "0x20000E9")]
		public delegate void DisconnectVoiceHandler(Result result);

		[Token(Token = "0x20000EA")]
		public delegate void LobbyUpdateHandler(long lobbyId);

		[Token(Token = "0x20000EB")]
		public delegate void LobbyDeleteHandler(long lobbyId, uint reason);

		[Token(Token = "0x20000EC")]
		public delegate void MemberConnectHandler(long lobbyId, long userId);

		[Token(Token = "0x20000ED")]
		public delegate void MemberUpdateHandler(long lobbyId, long userId);

		[Token(Token = "0x20000EE")]
		public delegate void MemberDisconnectHandler(long lobbyId, long userId);

		[Token(Token = "0x20000EF")]
		public delegate void LobbyMessageHandler(long lobbyId, long userId, byte[] data);

		[Token(Token = "0x20000F0")]
		public delegate void SpeakingHandler(long lobbyId, long userId, bool speaking);

		[Token(Token = "0x20000F1")]
		public delegate void NetworkMessageHandler(long lobbyId, long userId, byte channelId, byte[] data);

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x17000049")]
		private FFIMethods Methods
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1B0EC78", Offset = "0x1B0EC78", VA = "0x1B0EC78")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000013")]
		public event LobbyUpdateHandler OnLobbyUpdate
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x1B0ED80", Offset = "0x1B0ED80", VA = "0x1B0ED80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA860", Offset = "0xBDA860")]
			add
			{
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x1B0EE24", Offset = "0x1B0EE24", VA = "0x1B0EE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA870", Offset = "0xBDA870")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event LobbyDeleteHandler OnLobbyDelete
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1B0EEC8", Offset = "0x1B0EEC8", VA = "0x1B0EEC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA880", Offset = "0xBDA880")]
			add
			{
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1B0EF6C", Offset = "0x1B0EF6C", VA = "0x1B0EF6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA890", Offset = "0xBDA890")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event MemberConnectHandler OnMemberConnect
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1B0F010", Offset = "0x1B0F010", VA = "0x1B0F010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA8A0", Offset = "0xBDA8A0")]
			add
			{
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1B0F0B4", Offset = "0x1B0F0B4", VA = "0x1B0F0B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA8B0", Offset = "0xBDA8B0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event MemberUpdateHandler OnMemberUpdate
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1B0F158", Offset = "0x1B0F158", VA = "0x1B0F158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA8C0", Offset = "0xBDA8C0")]
			add
			{
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1B0F1FC", Offset = "0x1B0F1FC", VA = "0x1B0F1FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA8D0", Offset = "0xBDA8D0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event MemberDisconnectHandler OnMemberDisconnect
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1B0F2A0", Offset = "0x1B0F2A0", VA = "0x1B0F2A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA8E0", Offset = "0xBDA8E0")]
			add
			{
			}
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x1B0F344", Offset = "0x1B0F344", VA = "0x1B0F344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA8F0", Offset = "0xBDA8F0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event LobbyMessageHandler OnLobbyMessage
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1B0F3E8", Offset = "0x1B0F3E8", VA = "0x1B0F3E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA900", Offset = "0xBDA900")]
			add
			{
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x1B0F48C", Offset = "0x1B0F48C", VA = "0x1B0F48C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA910", Offset = "0xBDA910")]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event SpeakingHandler OnSpeaking
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1B0F530", Offset = "0x1B0F530", VA = "0x1B0F530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA920", Offset = "0xBDA920")]
			add
			{
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x1B0F5D4", Offset = "0x1B0F5D4", VA = "0x1B0F5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA930", Offset = "0xBDA930")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event NetworkMessageHandler OnNetworkMessage
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1B0F678", Offset = "0x1B0F678", VA = "0x1B0F678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA940", Offset = "0xBDA940")]
			add
			{
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1B0F71C", Offset = "0x1B0F71C", VA = "0x1B0F71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDA950", Offset = "0xBDA950")]
			remove
			{
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1B0F7C0", Offset = "0x1B0F7C0", VA = "0x1B0F7C0")]
		internal LobbyManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1B0F894", Offset = "0x1B0F894", VA = "0x1B0F894")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1B0FB24", Offset = "0x1B0FB24", VA = "0x1B0FB24")]
		public LobbyTransaction GetLobbyCreateTransaction()
		{
			return default(LobbyTransaction);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1B0FE60", Offset = "0x1B0FE60", VA = "0x1B0FE60")]
		public LobbyTransaction GetLobbyUpdateTransaction(long lobbyId)
		{
			return default(LobbyTransaction);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1B101BC", Offset = "0x1B101BC", VA = "0x1B101BC")]
		public LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId)
		{
			return default(LobbyMemberTransaction);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1B0DD90", Offset = "0x1B0DD90", VA = "0x1B0DD90")]
		[MonoPInvokeCallback]
		private static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1B107D4", Offset = "0x1B107D4", VA = "0x1B107D4")]
		public void CreateLobby(LobbyTransaction transaction, CreateLobbyHandler callback)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1B0DE48", Offset = "0x1B0DE48", VA = "0x1B0DE48")]
		[MonoPInvokeCallback]
		private static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1B10DE4", Offset = "0x1B10DE4", VA = "0x1B10DE4")]
		public void UpdateLobby(long lobbyId, LobbyTransaction transaction, UpdateLobbyHandler callback)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1B0DEF0", Offset = "0x1B0DEF0", VA = "0x1B0DEF0")]
		[MonoPInvokeCallback]
		private static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1B11418", Offset = "0x1B11418", VA = "0x1B11418")]
		public void DeleteLobby(long lobbyId, DeleteLobbyHandler callback)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1B0DF98", Offset = "0x1B0DF98", VA = "0x1B0DF98")]
		[MonoPInvokeCallback]
		private static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1B11A48", Offset = "0x1B11A48", VA = "0x1B11A48")]
		public void ConnectLobby(long lobbyId, string secret, ConnectLobbyHandler callback)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1B0E050", Offset = "0x1B0E050", VA = "0x1B0E050")]
		[MonoPInvokeCallback]
		private static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1B1209C", Offset = "0x1B1209C", VA = "0x1B1209C")]
		public void ConnectLobbyWithActivitySecret(string activitySecret, ConnectLobbyWithActivitySecretHandler callback)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1B0E108", Offset = "0x1B0E108", VA = "0x1B0E108")]
		[MonoPInvokeCallback]
		private static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1B126AC", Offset = "0x1B126AC", VA = "0x1B126AC")]
		public void DisconnectLobby(long lobbyId, DisconnectLobbyHandler callback)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1B12A4C", Offset = "0x1B12A4C", VA = "0x1B12A4C")]
		public Lobby GetLobby(long lobbyId)
		{
			return default(Lobby);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1B12DCC", Offset = "0x1B12DCC", VA = "0x1B12DCC")]
		public string GetLobbyActivitySecret(long lobbyId)
		{
			return null;
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1B13150", Offset = "0x1B13150", VA = "0x1B13150")]
		public string GetLobbyMetadataValue(long lobbyId, string key)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1B13500", Offset = "0x1B13500", VA = "0x1B13500")]
		public string GetLobbyMetadataKey(long lobbyId, int index)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1B138B0", Offset = "0x1B138B0", VA = "0x1B138B0")]
		public int LobbyMetadataCount(long lobbyId)
		{
			return default(int);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1B13C0C", Offset = "0x1B13C0C", VA = "0x1B13C0C")]
		public int MemberCount(long lobbyId)
		{
			return default(int);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1B13F68", Offset = "0x1B13F68", VA = "0x1B13F68")]
		public long GetMemberUserId(long lobbyId, int index)
		{
			return default(long);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1B142F0", Offset = "0x1B142F0", VA = "0x1B142F0")]
		public User GetMemberUser(long lobbyId, long userId)
		{
			return default(User);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1B1469C", Offset = "0x1B1469C", VA = "0x1B1469C")]
		public string GetMemberMetadataValue(long lobbyId, long userId, string key)
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1B14A70", Offset = "0x1B14A70", VA = "0x1B14A70")]
		public string GetMemberMetadataKey(long lobbyId, long userId, int index)
		{
			return null;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1B14E44", Offset = "0x1B14E44", VA = "0x1B14E44")]
		public int MemberMetadataCount(long lobbyId, long userId)
		{
			return default(int);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1B0E1B0", Offset = "0x1B0E1B0", VA = "0x1B0E1B0")]
		[MonoPInvokeCallback]
		private static void UpdateMemberCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1B1543C", Offset = "0x1B1543C", VA = "0x1B1543C")]
		public void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, UpdateMemberHandler callback)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1B0E258", Offset = "0x1B0E258", VA = "0x1B0E258")]
		[MonoPInvokeCallback]
		private static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1B15AA4", Offset = "0x1B15AA4", VA = "0x1B15AA4")]
		public void SendLobbyMessage(long lobbyId, byte[] data, SendLobbyMessageHandler callback)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1B15E94", Offset = "0x1B15E94", VA = "0x1B15E94")]
		public LobbySearchQuery GetSearchQuery()
		{
			return default(LobbySearchQuery);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1B0E300", Offset = "0x1B0E300", VA = "0x1B0E300")]
		[MonoPInvokeCallback]
		private static void SearchCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1B16440", Offset = "0x1B16440", VA = "0x1B16440")]
		public void Search(LobbySearchQuery query, SearchHandler callback)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1B167E0", Offset = "0x1B167E0", VA = "0x1B167E0")]
		public int LobbyCount()
		{
			return default(int);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1B16AA8", Offset = "0x1B16AA8", VA = "0x1B16AA8")]
		public long GetLobbyId(int index)
		{
			return default(long);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1B0E3A8", Offset = "0x1B0E3A8", VA = "0x1B0E3A8")]
		[MonoPInvokeCallback]
		private static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1B17074", Offset = "0x1B17074", VA = "0x1B17074")]
		public void ConnectVoice(long lobbyId, ConnectVoiceHandler callback)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1B0E450", Offset = "0x1B0E450", VA = "0x1B0E450")]
		[MonoPInvokeCallback]
		private static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1B17684", Offset = "0x1B17684", VA = "0x1B17684")]
		public void DisconnectVoice(long lobbyId, DisconnectVoiceHandler callback)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1B17A24", Offset = "0x1B17A24", VA = "0x1B17A24")]
		public void ConnectNetwork(long lobbyId)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1B17D5C", Offset = "0x1B17D5C", VA = "0x1B17D5C")]
		public void DisconnectNetwork(long lobbyId)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1B18094", Offset = "0x1B18094", VA = "0x1B18094")]
		public void FlushNetwork()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1B183A4", Offset = "0x1B183A4", VA = "0x1B183A4")]
		public void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1B1872C", Offset = "0x1B1872C", VA = "0x1B1872C")]
		public void SendNetworkMessage(long lobbyId, long userId, byte channelId, byte[] data)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1B0E4F8", Offset = "0x1B0E4F8", VA = "0x1B0E4F8")]
		[MonoPInvokeCallback]
		private static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1B0E5B8", Offset = "0x1B0E5B8", VA = "0x1B0E5B8")]
		[MonoPInvokeCallback]
		private static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1B0E688", Offset = "0x1B0E688", VA = "0x1B0E688")]
		[MonoPInvokeCallback]
		private static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1B0E758", Offset = "0x1B0E758", VA = "0x1B0E758")]
		[MonoPInvokeCallback]
		private static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1B0E828", Offset = "0x1B0E828", VA = "0x1B0E828")]
		[MonoPInvokeCallback]
		private static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1B0E8F8", Offset = "0x1B0E8F8", VA = "0x1B0E8F8")]
		[MonoPInvokeCallback]
		private static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1B0EA48", Offset = "0x1B0EA48", VA = "0x1B0EA48")]
		[MonoPInvokeCallback]
		private static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1B0EB20", Offset = "0x1B0EB20", VA = "0x1B0EB20")]
		[MonoPInvokeCallback]
		private static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1B19F30", Offset = "0x1B19F30", VA = "0x1B19F30")]
		public IEnumerable<User> GetMemberUsers(long lobbyID)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1B1A038", Offset = "0x1B1A038", VA = "0x1B1A038")]
		public void SendLobbyMessage(long lobbyID, string data, SendLobbyMessageHandler handler)
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class NetworkManager
	{
		[Token(Token = "0x20000F2")]
		internal struct FFIEvents
		{
			[Token(Token = "0x20001CA")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD99A4", Offset = "0xBD99A4")]
			internal delegate void MessageHandler(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x20001CB")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD99B8", Offset = "0xBD99B8")]
			internal delegate void RouteUpdateHandler(IntPtr ptr, string routeData);

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal MessageHandler OnMessage;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal RouteUpdateHandler OnRouteUpdate;
		}

		[Token(Token = "0x20000F3")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001CC")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD99CC", Offset = "0xBD99CC")]
			internal delegate void GetPeerIdMethod(IntPtr methodsPtr, ref ulong peerId);

			[Token(Token = "0x20001CD")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD99E0", Offset = "0xBD99E0")]
			internal delegate Result FlushMethod(IntPtr methodsPtr);

			[Token(Token = "0x20001CE")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD99F4", Offset = "0xBD99F4")]
			internal delegate Result OpenPeerMethod(IntPtr methodsPtr, ulong peerId, string routeData);

			[Token(Token = "0x20001CF")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9A08", Offset = "0xBD9A08")]
			internal delegate Result UpdatePeerMethod(IntPtr methodsPtr, ulong peerId, string routeData);

			[Token(Token = "0x20001D0")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9A1C", Offset = "0xBD9A1C")]
			internal delegate Result ClosePeerMethod(IntPtr methodsPtr, ulong peerId);

			[Token(Token = "0x20001D1")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9A30", Offset = "0xBD9A30")]
			internal delegate Result OpenChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId, bool reliable);

			[Token(Token = "0x20001D2")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9A44", Offset = "0xBD9A44")]
			internal delegate Result CloseChannelMethod(IntPtr methodsPtr, ulong peerId, byte channelId);

			[Token(Token = "0x20001D3")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9A58", Offset = "0xBD9A58")]
			internal delegate Result SendMessageMethod(IntPtr methodsPtr, ulong peerId, byte channelId, byte[] data, int dataLen);

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal GetPeerIdMethod GetPeerId;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal FlushMethod Flush;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal OpenPeerMethod OpenPeer;

			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal UpdatePeerMethod UpdatePeer;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal ClosePeerMethod ClosePeer;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal OpenChannelMethod OpenChannel;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal CloseChannelMethod CloseChannel;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal SendMessageMethod SendMessage;
		}

		[Token(Token = "0x20000F4")]
		public delegate void MessageHandler(ulong peerId, byte channelId, byte[] data);

		[Token(Token = "0x20000F5")]
		public delegate void RouteUpdateHandler(string routeData);

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700004A")]
		private FFIMethods Methods
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x1AF0430", Offset = "0x1AF0430", VA = "0x1AF0430")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x1400001B")]
		public event MessageHandler OnMessage
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x1AF053C", Offset = "0x1AF053C", VA = "0x1AF053C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAA90", Offset = "0xBDAA90")]
			add
			{
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x1AF05E0", Offset = "0x1AF05E0", VA = "0x1AF05E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAAA0", Offset = "0xBDAAA0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public event RouteUpdateHandler OnRouteUpdate
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x1AF0684", Offset = "0x1AF0684", VA = "0x1AF0684")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAAB0", Offset = "0xBDAAB0")]
			add
			{
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x1AF0728", Offset = "0x1AF0728", VA = "0x1AF0728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAAC0", Offset = "0xBDAAC0")]
			remove
			{
			}
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1AF07CC", Offset = "0x1AF07CC", VA = "0x1AF07CC")]
		internal NetworkManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1AF0958", Offset = "0x1AF0958", VA = "0x1AF0958")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1AF0A60", Offset = "0x1AF0A60", VA = "0x1AF0A60")]
		public ulong GetPeerId()
		{
			return default(ulong);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1AF0D28", Offset = "0x1AF0D28", VA = "0x1AF0D28")]
		public void Flush()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1AF102C", Offset = "0x1AF102C", VA = "0x1AF102C")]
		public void OpenPeer(ulong peerId, string routeData)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1AF1380", Offset = "0x1AF1380", VA = "0x1AF1380")]
		public void UpdatePeer(ulong peerId, string routeData)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1AF16D4", Offset = "0x1AF16D4", VA = "0x1AF16D4")]
		public void ClosePeer(ulong peerId)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1AF1A08", Offset = "0x1AF1A08", VA = "0x1AF1A08")]
		public void OpenChannel(ulong peerId, byte channelId, bool reliable)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1AF1D8C", Offset = "0x1AF1D8C", VA = "0x1AF1D8C")]
		public void CloseChannel(ulong peerId, byte channelId)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1AF20E0", Offset = "0x1AF20E0", VA = "0x1AF20E0")]
		public void SendMessage(ulong peerId, byte channelId, byte[] data)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1AF0220", Offset = "0x1AF0220", VA = "0x1AF0220")]
		[MonoPInvokeCallback]
		private static void OnMessageImpl(IntPtr ptr, ulong peerId, byte channelId, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1AF0370", Offset = "0x1AF0370", VA = "0x1AF0370")]
		[MonoPInvokeCallback]
		private static void OnRouteUpdateImpl(IntPtr ptr, string routeData)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class OverlayManager
	{
		[Token(Token = "0x20000F6")]
		internal struct FFIEvents
		{
			[Token(Token = "0x20001D4")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9A6C", Offset = "0xBD9A6C")]
			internal delegate void ToggleHandler(IntPtr ptr, bool locked);

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ToggleHandler OnToggle;
		}

		[Token(Token = "0x20000F7")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001D5")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9A80", Offset = "0xBD9A80")]
			internal delegate void IsEnabledMethod(IntPtr methodsPtr, ref bool enabled);

			[Token(Token = "0x20001D6")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9A94", Offset = "0xBD9A94")]
			internal delegate void IsLockedMethod(IntPtr methodsPtr, ref bool locked);

			[Token(Token = "0x20001D7")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9AA8", Offset = "0xBD9AA8")]
			internal delegate void SetLockedCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001D8")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9ABC", Offset = "0xBD9ABC")]
			internal delegate void SetLockedMethod(IntPtr methodsPtr, bool locked, IntPtr callbackData, SetLockedCallback callback);

			[Token(Token = "0x20001D9")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9AD0", Offset = "0xBD9AD0")]
			internal delegate void OpenActivityInviteCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001DA")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9AE4", Offset = "0xBD9AE4")]
			internal delegate void OpenActivityInviteMethod(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OpenActivityInviteCallback callback);

			[Token(Token = "0x20001DB")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9AF8", Offset = "0xBD9AF8")]
			internal delegate void OpenGuildInviteCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001DC")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9B0C", Offset = "0xBD9B0C")]
			internal delegate void OpenGuildInviteMethod(IntPtr methodsPtr, string code, IntPtr callbackData, OpenGuildInviteCallback callback);

			[Token(Token = "0x20001DD")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9B20", Offset = "0xBD9B20")]
			internal delegate void OpenVoiceSettingsCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001DE")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9B34", Offset = "0xBD9B34")]
			internal delegate void OpenVoiceSettingsMethod(IntPtr methodsPtr, IntPtr callbackData, OpenVoiceSettingsCallback callback);

			[Token(Token = "0x20001DF")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9B48", Offset = "0xBD9B48")]
			internal delegate Result InitDrawingDxgiMethod(IntPtr methodsPtr, IntPtr swapchain, bool useMessageForwarding);

			[Token(Token = "0x20001E0")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9B5C", Offset = "0xBD9B5C")]
			internal delegate void OnPresentMethod(IntPtr methodsPtr);

			[Token(Token = "0x20001E1")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9B70", Offset = "0xBD9B70")]
			internal delegate void ForwardMessageMethod(IntPtr methodsPtr, IntPtr message);

			[Token(Token = "0x20001E2")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9B84", Offset = "0xBD9B84")]
			internal delegate void KeyEventMethod(IntPtr methodsPtr, bool down, string keyCode, KeyVariant variant);

			[Token(Token = "0x20001E3")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9B98", Offset = "0xBD9B98")]
			internal delegate void CharEventMethod(IntPtr methodsPtr, string character);

			[Token(Token = "0x20001E4")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9BAC", Offset = "0xBD9BAC")]
			internal delegate void MouseButtonEventMethod(IntPtr methodsPtr, byte down, int clickCount, MouseButton which, int x, int y);

			[Token(Token = "0x20001E5")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9BC0", Offset = "0xBD9BC0")]
			internal delegate void MouseMotionEventMethod(IntPtr methodsPtr, int x, int y);

			[Token(Token = "0x20001E6")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9BD4", Offset = "0xBD9BD4")]
			internal delegate void ImeCommitTextMethod(IntPtr methodsPtr, string text);

			[Token(Token = "0x20001E7")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9BE8", Offset = "0xBD9BE8")]
			internal delegate void ImeSetCompositionMethod(IntPtr methodsPtr, string text, ref ImeUnderline underlines, int from, int to);

			[Token(Token = "0x20001E8")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9BFC", Offset = "0xBD9BFC")]
			internal delegate void ImeCancelCompositionMethod(IntPtr methodsPtr);

			[Token(Token = "0x20001E9")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9C10", Offset = "0xBD9C10")]
			internal delegate void SetImeCompositionRangeCallbackCallback(IntPtr ptr, int from, int to, ref Rect bounds);

			[Token(Token = "0x20001EA")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9C24", Offset = "0xBD9C24")]
			internal delegate void SetImeCompositionRangeCallbackMethod(IntPtr methodsPtr, IntPtr callbackData, SetImeCompositionRangeCallbackCallback callback);

			[Token(Token = "0x20001EB")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9C38", Offset = "0xBD9C38")]
			internal delegate void SetImeSelectionBoundsCallbackCallback(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst);

			[Token(Token = "0x20001EC")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9C4C", Offset = "0xBD9C4C")]
			internal delegate void SetImeSelectionBoundsCallbackMethod(IntPtr methodsPtr, IntPtr callbackData, SetImeSelectionBoundsCallbackCallback callback);

			[Token(Token = "0x20001ED")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9C60", Offset = "0xBD9C60")]
			internal delegate bool IsPointInsideClickZoneMethod(IntPtr methodsPtr, int x, int y);

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal IsEnabledMethod IsEnabled;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal IsLockedMethod IsLocked;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal SetLockedMethod SetLocked;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal OpenActivityInviteMethod OpenActivityInvite;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal OpenGuildInviteMethod OpenGuildInvite;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal OpenVoiceSettingsMethod OpenVoiceSettings;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal InitDrawingDxgiMethod InitDrawingDxgi;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal OnPresentMethod OnPresent;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal ForwardMessageMethod ForwardMessage;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal KeyEventMethod KeyEvent;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal CharEventMethod CharEvent;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal MouseButtonEventMethod MouseButtonEvent;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal MouseMotionEventMethod MouseMotionEvent;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal ImeCommitTextMethod ImeCommitText;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal ImeSetCompositionMethod ImeSetComposition;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal ImeCancelCompositionMethod ImeCancelComposition;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			internal SetImeCompositionRangeCallbackMethod SetImeCompositionRangeCallback;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			internal SetImeSelectionBoundsCallbackMethod SetImeSelectionBoundsCallback;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			internal IsPointInsideClickZoneMethod IsPointInsideClickZone;
		}

		[Token(Token = "0x20000F8")]
		public delegate void SetLockedHandler(Result result);

		[Token(Token = "0x20000F9")]
		public delegate void OpenActivityInviteHandler(Result result);

		[Token(Token = "0x20000FA")]
		public delegate void OpenGuildInviteHandler(Result result);

		[Token(Token = "0x20000FB")]
		public delegate void OpenVoiceSettingsHandler(Result result);

		[Token(Token = "0x20000FC")]
		public delegate void SetImeCompositionRangeCallbackHandler(int from, int to, ref Rect bounds);

		[Token(Token = "0x20000FD")]
		public delegate void SetImeSelectionBoundsCallbackHandler(Rect anchor, Rect focus, bool isAnchorFirst);

		[Token(Token = "0x20000FE")]
		public delegate void ToggleHandler(bool locked);

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700004B")]
		private FFIMethods Methods
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x1AF3F88", Offset = "0x1AF3F88", VA = "0x1AF3F88")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x1400001D")]
		public event ToggleHandler OnToggle
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x1AF4090", Offset = "0x1AF4090", VA = "0x1AF4090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAAF0", Offset = "0xBDAAF0")]
			add
			{
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x1AF4134", Offset = "0x1AF4134", VA = "0x1AF4134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAB00", Offset = "0xBDAB00")]
			remove
			{
			}
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1AF41D8", Offset = "0x1AF41D8", VA = "0x1AF41D8")]
		internal OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1AF42A8", Offset = "0x1AF42A8", VA = "0x1AF42A8")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1AF436C", Offset = "0x1AF436C", VA = "0x1AF436C")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1AF4634", Offset = "0x1AF4634", VA = "0x1AF4634")]
		public bool IsLocked()
		{
			return default(bool);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1AF3A8C", Offset = "0x1AF3A8C", VA = "0x1AF3A8C")]
		[MonoPInvokeCallback]
		private static void SetLockedCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1AF4B6C", Offset = "0x1AF4B6C", VA = "0x1AF4B6C")]
		public void SetLocked(bool locked, SetLockedHandler callback)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1AF3B34", Offset = "0x1AF3B34", VA = "0x1AF3B34")]
		[MonoPInvokeCallback]
		private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1AF5178", Offset = "0x1AF5178", VA = "0x1AF5178")]
		public void OpenActivityInvite(ActivityActionType type, OpenActivityInviteHandler callback)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1AF3BDC", Offset = "0x1AF3BDC", VA = "0x1AF3BDC")]
		[MonoPInvokeCallback]
		private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1AF5780", Offset = "0x1AF5780", VA = "0x1AF5780")]
		public void OpenGuildInvite(string code, OpenGuildInviteHandler callback)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1AF3C84", Offset = "0x1AF3C84", VA = "0x1AF3C84")]
		[MonoPInvokeCallback]
		private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1AF5D88", Offset = "0x1AF5D88", VA = "0x1AF5D88")]
		public void OpenVoiceSettings(OpenVoiceSettingsHandler callback)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1AF60FC", Offset = "0x1AF60FC", VA = "0x1AF60FC")]
		public void InitDrawingDxgi(IntPtr swapchain, bool useMessageForwarding)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1AF6454", Offset = "0x1AF6454", VA = "0x1AF6454")]
		public void OnPresent()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1AF66F0", Offset = "0x1AF66F0", VA = "0x1AF66F0")]
		public void ForwardMessage(IntPtr message)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1AF69B4", Offset = "0x1AF69B4", VA = "0x1AF69B4")]
		public void KeyEvent(bool down, string keyCode, KeyVariant variant)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1AF6CC8", Offset = "0x1AF6CC8", VA = "0x1AF6CC8")]
		public void CharEvent(string character)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1AF6F8C", Offset = "0x1AF6F8C", VA = "0x1AF6F8C")]
		public void MouseButtonEvent(byte down, int clickCount, MouseButton which, int x, int y)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1AF72F4", Offset = "0x1AF72F4", VA = "0x1AF72F4")]
		public void MouseMotionEvent(int x, int y)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1AF75E0", Offset = "0x1AF75E0", VA = "0x1AF75E0")]
		public void ImeCommitText(string text)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1AF78A4", Offset = "0x1AF78A4", VA = "0x1AF78A4")]
		public void ImeSetComposition(string text, ImeUnderline underlines, int from, int to)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1AF7BE0", Offset = "0x1AF7BE0", VA = "0x1AF7BE0")]
		public void ImeCancelComposition()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1AF3D2C", Offset = "0x1AF3D2C", VA = "0x1AF3D2C")]
		[MonoPInvokeCallback]
		private static void SetImeCompositionRangeCallbackCallbackImpl(IntPtr ptr, int from, int to, ref Rect bounds)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1AF8114", Offset = "0x1AF8114", VA = "0x1AF8114")]
		public void SetImeCompositionRangeCallback(SetImeCompositionRangeCallbackHandler callback)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1AF3DEC", Offset = "0x1AF3DEC", VA = "0x1AF3DEC")]
		[MonoPInvokeCallback]
		private static void SetImeSelectionBoundsCallbackCallbackImpl(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1AF878C", Offset = "0x1AF878C", VA = "0x1AF878C")]
		public void SetImeSelectionBoundsCallback(SetImeSelectionBoundsCallbackHandler callback)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1AF8B00", Offset = "0x1AF8B00", VA = "0x1AF8B00")]
		public void IsPointInsideClickZone(int x, int y)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1AF3EC8", Offset = "0x1AF3EC8", VA = "0x1AF3EC8")]
		[MonoPInvokeCallback]
		private static void OnToggleImpl(IntPtr ptr, bool locked)
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class StorageManager
	{
		[Token(Token = "0x20000FF")]
		internal struct FFIEvents
		{
		}

		[Token(Token = "0x2000100")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001EE")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9C74", Offset = "0xBD9C74")]
			internal delegate Result ReadMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen, ref uint read);

			[Token(Token = "0x20001EF")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9C88", Offset = "0xBD9C88")]
			internal delegate void ReadAsyncCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x20001F0")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9C9C", Offset = "0xBD9C9C")]
			internal delegate void ReadAsyncMethod(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback);

			[Token(Token = "0x20001F1")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9CB0", Offset = "0xBD9CB0")]
			internal delegate void ReadAsyncPartialCallback(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen);

			[Token(Token = "0x20001F2")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9CC4", Offset = "0xBD9CC4")]
			internal delegate void ReadAsyncPartialMethod(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback);

			[Token(Token = "0x20001F3")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9CD8", Offset = "0xBD9CD8")]
			internal delegate Result WriteMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen);

			[Token(Token = "0x20001F4")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9CEC", Offset = "0xBD9CEC")]
			internal delegate void WriteAsyncCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001F5")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9D00", Offset = "0xBD9D00")]
			internal delegate void WriteAsyncMethod(IntPtr methodsPtr, string name, byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback);

			[Token(Token = "0x20001F6")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9D14", Offset = "0xBD9D14")]
			internal delegate Result DeleteMethod(IntPtr methodsPtr, string name);

			[Token(Token = "0x20001F7")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9D28", Offset = "0xBD9D28")]
			internal delegate Result ExistsMethod(IntPtr methodsPtr, string name, ref bool exists);

			[Token(Token = "0x20001F8")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9D3C", Offset = "0xBD9D3C")]
			internal delegate void CountMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x20001F9")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9D50", Offset = "0xBD9D50")]
			internal delegate Result StatMethod(IntPtr methodsPtr, string name, ref FileStat stat);

			[Token(Token = "0x20001FA")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9D64", Offset = "0xBD9D64")]
			internal delegate Result StatAtMethod(IntPtr methodsPtr, int index, ref FileStat stat);

			[Token(Token = "0x20001FB")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9D78", Offset = "0xBD9D78")]
			internal delegate Result GetPathMethod(IntPtr methodsPtr, StringBuilder path);

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ReadMethod Read;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal ReadAsyncMethod ReadAsync;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ReadAsyncPartialMethod ReadAsyncPartial;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal WriteMethod Write;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal WriteAsyncMethod WriteAsync;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal DeleteMethod Delete;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal ExistsMethod Exists;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal CountMethod Count;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal StatMethod Stat;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal StatAtMethod StatAt;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal GetPathMethod GetPath;
		}

		[Token(Token = "0x2000101")]
		public delegate void ReadAsyncHandler(Result result, byte[] data);

		[Token(Token = "0x2000102")]
		public delegate void ReadAsyncPartialHandler(Result result, byte[] data);

		[Token(Token = "0x2000103")]
		public delegate void WriteAsyncHandler(Result result);

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700004C")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x1AFEC00", Offset = "0x1AFEC00", VA = "0x1AFEC00")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1AFED08", Offset = "0x1AFED08", VA = "0x1AFED08")]
		internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1AFEDC8", Offset = "0x1AFEDC8", VA = "0x1AFEDC8")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1AFEE3C", Offset = "0x1AFEE3C", VA = "0x1AFEE3C")]
		public uint Read(string name, byte[] data)
		{
			return default(uint);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1AFE938", Offset = "0x1AFE938", VA = "0x1AFE938")]
		[MonoPInvokeCallback]
		private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1AFF46C", Offset = "0x1AFF46C", VA = "0x1AFF46C")]
		public void ReadAsync(string name, ReadAsyncHandler callback)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1AFEA48", Offset = "0x1AFEA48", VA = "0x1AFEA48")]
		[MonoPInvokeCallback]
		private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1AFFA94", Offset = "0x1AFFA94", VA = "0x1AFFA94")]
		public void ReadAsyncPartial(string name, ulong offset, ulong length, ReadAsyncPartialHandler callback)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1AFFE84", Offset = "0x1AFFE84", VA = "0x1AFFE84")]
		public void Write(string name, byte[] data)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1AFEB58", Offset = "0x1AFEB58", VA = "0x1AFEB58")]
		[MonoPInvokeCallback]
		private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1B0046C", Offset = "0x1B0046C", VA = "0x1B0046C")]
		public void WriteAsync(string name, byte[] data, WriteAsyncHandler callback)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1B0085C", Offset = "0x1B0085C", VA = "0x1B0085C")]
		public void Delete(string name)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1B00B90", Offset = "0x1B00B90", VA = "0x1B00B90")]
		public bool Exists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1B00EE8", Offset = "0x1B00EE8", VA = "0x1B00EE8")]
		public int Count()
		{
			return default(int);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1B011B0", Offset = "0x1B011B0", VA = "0x1B011B0")]
		public FileStat Stat(string name)
		{
			return default(FileStat);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1B0151C", Offset = "0x1B0151C", VA = "0x1B0151C")]
		public FileStat StatAt(int index)
		{
			return default(FileStat);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1B01888", Offset = "0x1B01888", VA = "0x1B01888")]
		public string GetPath()
		{
			return null;
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1B01BE0", Offset = "0x1B01BE0", VA = "0x1B01BE0")]
		public IEnumerable<FileStat> Files()
		{
			return null;
		}
	}
	[Token(Token = "0x2000074")]
	public class StoreManager
	{
		[Token(Token = "0x2000104")]
		internal struct FFIEvents
		{
			[Token(Token = "0x20001FC")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9D8C", Offset = "0xBD9D8C")]
			internal delegate void EntitlementCreateHandler(IntPtr ptr, ref Entitlement entitlement);

			[Token(Token = "0x20001FD")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9DA0", Offset = "0xBD9DA0")]
			internal delegate void EntitlementDeleteHandler(IntPtr ptr, ref Entitlement entitlement);

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal EntitlementCreateHandler OnEntitlementCreate;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal EntitlementDeleteHandler OnEntitlementDelete;
		}

		[Token(Token = "0x2000105")]
		internal struct FFIMethods
		{
			[Token(Token = "0x20001FE")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9DB4", Offset = "0xBD9DB4")]
			internal delegate void FetchSkusCallback(IntPtr ptr, Result result);

			[Token(Token = "0x20001FF")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9DC8", Offset = "0xBD9DC8")]
			internal delegate void FetchSkusMethod(IntPtr methodsPtr, IntPtr callbackData, FetchSkusCallback callback);

			[Token(Token = "0x2000200")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9DDC", Offset = "0xBD9DDC")]
			internal delegate void CountSkusMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x2000201")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9DF0", Offset = "0xBD9DF0")]
			internal delegate Result GetSkuMethod(IntPtr methodsPtr, long skuId, ref Sku sku);

			[Token(Token = "0x2000202")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9E04", Offset = "0xBD9E04")]
			internal delegate Result GetSkuAtMethod(IntPtr methodsPtr, int index, ref Sku sku);

			[Token(Token = "0x2000203")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9E18", Offset = "0xBD9E18")]
			internal delegate void FetchEntitlementsCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000204")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9E2C", Offset = "0xBD9E2C")]
			internal delegate void FetchEntitlementsMethod(IntPtr methodsPtr, IntPtr callbackData, FetchEntitlementsCallback callback);

			[Token(Token = "0x2000205")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9E40", Offset = "0xBD9E40")]
			internal delegate void CountEntitlementsMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x2000206")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9E54", Offset = "0xBD9E54")]
			internal delegate Result GetEntitlementMethod(IntPtr methodsPtr, long entitlementId, ref Entitlement entitlement);

			[Token(Token = "0x2000207")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9E68", Offset = "0xBD9E68")]
			internal delegate Result GetEntitlementAtMethod(IntPtr methodsPtr, int index, ref Entitlement entitlement);

			[Token(Token = "0x2000208")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9E7C", Offset = "0xBD9E7C")]
			internal delegate Result HasSkuEntitlementMethod(IntPtr methodsPtr, long skuId, ref bool hasEntitlement);

			[Token(Token = "0x2000209")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9E90", Offset = "0xBD9E90")]
			internal delegate void StartPurchaseCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200020A")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9EA4", Offset = "0xBD9EA4")]
			internal delegate void StartPurchaseMethod(IntPtr methodsPtr, long skuId, IntPtr callbackData, StartPurchaseCallback callback);

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal FetchSkusMethod FetchSkus;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal CountSkusMethod CountSkus;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal GetSkuMethod GetSku;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetSkuAtMethod GetSkuAt;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal FetchEntitlementsMethod FetchEntitlements;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal CountEntitlementsMethod CountEntitlements;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal GetEntitlementMethod GetEntitlement;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal GetEntitlementAtMethod GetEntitlementAt;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal HasSkuEntitlementMethod HasSkuEntitlement;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal StartPurchaseMethod StartPurchase;
		}

		[Token(Token = "0x2000106")]
		public delegate void FetchSkusHandler(Result result);

		[Token(Token = "0x2000107")]
		public delegate void FetchEntitlementsHandler(Result result);

		[Token(Token = "0x2000108")]
		public delegate void StartPurchaseHandler(Result result);

		[Token(Token = "0x2000109")]
		public delegate void EntitlementCreateHandler(ref Entitlement entitlement);

		[Token(Token = "0x200010A")]
		public delegate void EntitlementDeleteHandler(ref Entitlement entitlement);

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700004D")]
		private FFIMethods Methods
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1B0376C", Offset = "0x1B0376C", VA = "0x1B0376C")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x1400001E")]
		public event EntitlementCreateHandler OnEntitlementCreate
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1B03874", Offset = "0x1B03874", VA = "0x1B03874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDABB0", Offset = "0xBDABB0")]
			add
			{
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1B03918", Offset = "0x1B03918", VA = "0x1B03918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDABC0", Offset = "0xBDABC0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event EntitlementDeleteHandler OnEntitlementDelete
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1B039BC", Offset = "0x1B039BC", VA = "0x1B039BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDABD0", Offset = "0xBDABD0")]
			add
			{
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1B03A60", Offset = "0x1B03A60", VA = "0x1B03A60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDABE0", Offset = "0xBDABE0")]
			remove
			{
			}
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1B03B04", Offset = "0x1B03B04", VA = "0x1B03B04")]
		internal StoreManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1B03BD4", Offset = "0x1B03BD4", VA = "0x1B03BD4")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1B033F4", Offset = "0x1B033F4", VA = "0x1B033F4")]
		[MonoPInvokeCallback]
		private static void FetchSkusCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1B03F4C", Offset = "0x1B03F4C", VA = "0x1B03F4C")]
		public void FetchSkus(FetchSkusHandler callback)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1B042C0", Offset = "0x1B042C0", VA = "0x1B042C0")]
		public int CountSkus()
		{
			return default(int);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1B04588", Offset = "0x1B04588", VA = "0x1B04588")]
		public Sku GetSku(long skuId)
		{
			return default(Sku);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1B04900", Offset = "0x1B04900", VA = "0x1B04900")]
		public Sku GetSkuAt(int index)
		{
			return default(Sku);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1B0349C", Offset = "0x1B0349C", VA = "0x1B0349C")]
		[MonoPInvokeCallback]
		private static void FetchEntitlementsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1B04EE8", Offset = "0x1B04EE8", VA = "0x1B04EE8")]
		public void FetchEntitlements(FetchEntitlementsHandler callback)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1B0525C", Offset = "0x1B0525C", VA = "0x1B0525C")]
		public int CountEntitlements()
		{
			return default(int);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1B05524", Offset = "0x1B05524", VA = "0x1B05524")]
		public Entitlement GetEntitlement(long entitlementId)
		{
			return default(Entitlement);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1B05890", Offset = "0x1B05890", VA = "0x1B05890")]
		public Entitlement GetEntitlementAt(int index)
		{
			return default(Entitlement);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1B05BFC", Offset = "0x1B05BFC", VA = "0x1B05BFC")]
		public bool HasSkuEntitlement(long skuId)
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1B03544", Offset = "0x1B03544", VA = "0x1B03544")]
		[MonoPInvokeCallback]
		private static void StartPurchaseCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1B061C4", Offset = "0x1B061C4", VA = "0x1B061C4")]
		public void StartPurchase(long skuId, StartPurchaseHandler callback)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1B035EC", Offset = "0x1B035EC", VA = "0x1B035EC")]
		[MonoPInvokeCallback]
		private static void OnEntitlementCreateImpl(IntPtr ptr, ref Entitlement entitlement)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1B036AC", Offset = "0x1B036AC", VA = "0x1B036AC")]
		[MonoPInvokeCallback]
		private static void OnEntitlementDeleteImpl(IntPtr ptr, ref Entitlement entitlement)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1B06A04", Offset = "0x1B06A04", VA = "0x1B06A04")]
		public IEnumerable<Entitlement> GetEntitlements()
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1B06AEC", Offset = "0x1B06AEC", VA = "0x1B06AEC")]
		public IEnumerable<Sku> GetSkus()
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public class VoiceManager
	{
		[Token(Token = "0x200010B")]
		internal struct FFIEvents
		{
			[Token(Token = "0x200020B")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9EB8", Offset = "0xBD9EB8")]
			internal delegate void SettingsUpdateHandler(IntPtr ptr);

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SettingsUpdateHandler OnSettingsUpdate;
		}

		[Token(Token = "0x200010C")]
		internal struct FFIMethods
		{
			[Token(Token = "0x200020C")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9ECC", Offset = "0xBD9ECC")]
			internal delegate Result GetInputModeMethod(IntPtr methodsPtr, ref InputMode inputMode);

			[Token(Token = "0x200020D")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9EE0", Offset = "0xBD9EE0")]
			internal delegate void SetInputModeCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200020E")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9EF4", Offset = "0xBD9EF4")]
			internal delegate void SetInputModeMethod(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, SetInputModeCallback callback);

			[Token(Token = "0x200020F")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9F08", Offset = "0xBD9F08")]
			internal delegate Result IsSelfMuteMethod(IntPtr methodsPtr, ref bool mute);

			[Token(Token = "0x2000210")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9F1C", Offset = "0xBD9F1C")]
			internal delegate Result SetSelfMuteMethod(IntPtr methodsPtr, bool mute);

			[Token(Token = "0x2000211")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9F30", Offset = "0xBD9F30")]
			internal delegate Result IsSelfDeafMethod(IntPtr methodsPtr, ref bool deaf);

			[Token(Token = "0x2000212")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9F44", Offset = "0xBD9F44")]
			internal delegate Result SetSelfDeafMethod(IntPtr methodsPtr, bool deaf);

			[Token(Token = "0x2000213")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9F58", Offset = "0xBD9F58")]
			internal delegate Result IsLocalMuteMethod(IntPtr methodsPtr, long userId, ref bool mute);

			[Token(Token = "0x2000214")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9F6C", Offset = "0xBD9F6C")]
			internal delegate Result SetLocalMuteMethod(IntPtr methodsPtr, long userId, bool mute);

			[Token(Token = "0x2000215")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9F80", Offset = "0xBD9F80")]
			internal delegate Result GetLocalVolumeMethod(IntPtr methodsPtr, long userId, ref byte volume);

			[Token(Token = "0x2000216")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9F94", Offset = "0xBD9F94")]
			internal delegate Result SetLocalVolumeMethod(IntPtr methodsPtr, long userId, byte volume);

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal GetInputModeMethod GetInputMode;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal SetInputModeMethod SetInputMode;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal IsSelfMuteMethod IsSelfMute;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal SetSelfMuteMethod SetSelfMute;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal IsSelfDeafMethod IsSelfDeaf;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal SetSelfDeafMethod SetSelfDeaf;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal IsLocalMuteMethod IsLocalMute;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal SetLocalMuteMethod SetLocalMute;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal GetLocalVolumeMethod GetLocalVolume;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal SetLocalVolumeMethod SetLocalVolume;
		}

		[Token(Token = "0x200010D")]
		public delegate void SetInputModeHandler(Result result);

		[Token(Token = "0x200010E")]
		public delegate void SettingsUpdateHandler();

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700004E")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x153CFEC", Offset = "0x153CFEC", VA = "0x153CFEC")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000020")]
		public event SettingsUpdateHandler OnSettingsUpdate
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x153D0F4", Offset = "0x153D0F4", VA = "0x153D0F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAC40", Offset = "0xBDAC40")]
			add
			{
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x153D198", Offset = "0x153D198", VA = "0x153D198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAC50", Offset = "0xBDAC50")]
			remove
			{
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x153D23C", Offset = "0x153D23C", VA = "0x153D23C")]
		internal VoiceManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x153D310", Offset = "0x153D310", VA = "0x153D310")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x153D3D4", Offset = "0x153D3D4", VA = "0x153D3D4")]
		public InputMode GetInputMode()
		{
			return default(InputMode);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x153CE8C", Offset = "0x153CE8C", VA = "0x153CE8C")]
		[MonoPInvokeCallback]
		private static void SetInputModeCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x153D978", Offset = "0x153D978", VA = "0x153D978")]
		public void SetInputMode(InputMode inputMode, SetInputModeHandler callback)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x153DD3C", Offset = "0x153DD3C", VA = "0x153DD3C")]
		public bool IsSelfMute()
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x153E070", Offset = "0x153E070", VA = "0x153E070")]
		public void SetSelfMute(bool mute)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x153E3AC", Offset = "0x153E3AC", VA = "0x153E3AC")]
		public bool IsSelfDeaf()
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x153E6E0", Offset = "0x153E6E0", VA = "0x153E6E0")]
		public void SetSelfDeaf(bool deaf)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x153EA1C", Offset = "0x153EA1C", VA = "0x153EA1C")]
		public bool IsLocalMute(long userId)
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x153ED78", Offset = "0x153ED78", VA = "0x153ED78")]
		public void SetLocalMute(long userId, bool mute)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x153F0D4", Offset = "0x153F0D4", VA = "0x153F0D4")]
		public byte GetLocalVolume(long userId)
		{
			return default(byte);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x153F430", Offset = "0x153F430", VA = "0x153F430")]
		public void SetLocalVolume(long userId, byte volume)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x153CF34", Offset = "0x153CF34", VA = "0x153CF34")]
		[MonoPInvokeCallback]
		private static void OnSettingsUpdateImpl(IntPtr ptr)
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class AchievementManager
	{
		[Token(Token = "0x200010F")]
		internal struct FFIEvents
		{
			[Token(Token = "0x2000217")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9FA8", Offset = "0xBD9FA8")]
			internal delegate void UserAchievementUpdateHandler(IntPtr ptr, ref UserAchievement userAchievement);

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal UserAchievementUpdateHandler OnUserAchievementUpdate;
		}

		[Token(Token = "0x2000110")]
		internal struct FFIMethods
		{
			[Token(Token = "0x2000218")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9FBC", Offset = "0xBD9FBC")]
			internal delegate void SetUserAchievementCallback(IntPtr ptr, Result result);

			[Token(Token = "0x2000219")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9FD0", Offset = "0xBD9FD0")]
			internal delegate void SetUserAchievementMethod(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback);

			[Token(Token = "0x200021A")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9FE4", Offset = "0xBD9FE4")]
			internal delegate void FetchUserAchievementsCallback(IntPtr ptr, Result result);

			[Token(Token = "0x200021B")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBD9FF8", Offset = "0xBD9FF8")]
			internal delegate void FetchUserAchievementsMethod(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback);

			[Token(Token = "0x200021C")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBDA00C", Offset = "0xBDA00C")]
			internal delegate void CountUserAchievementsMethod(IntPtr methodsPtr, ref int count);

			[Token(Token = "0x200021D")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBDA020", Offset = "0xBDA020")]
			internal delegate Result GetUserAchievementMethod(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement);

			[Token(Token = "0x200021E")]
			[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0xBDA034", Offset = "0xBDA034")]
			internal delegate Result GetUserAchievementAtMethod(IntPtr methodsPtr, int index, ref UserAchievement userAchievement);

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal SetUserAchievementMethod SetUserAchievement;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal FetchUserAchievementsMethod FetchUserAchievements;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal CountUserAchievementsMethod CountUserAchievements;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal GetUserAchievementMethod GetUserAchievement;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal GetUserAchievementAtMethod GetUserAchievementAt;
		}

		[Token(Token = "0x2000111")]
		public delegate void SetUserAchievementHandler(Result result);

		[Token(Token = "0x2000112")]
		public delegate void FetchUserAchievementsHandler(Result result);

		[Token(Token = "0x2000113")]
		public delegate void UserAchievementUpdateHandler(ref UserAchievement userAchievement);

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr MethodsPtr;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object MethodsStructure;

		[Token(Token = "0x1700004F")]
		private FFIMethods Methods
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x123F800", Offset = "0x123F800", VA = "0x123F800")]
			get
			{
				return default(FFIMethods);
			}
		}

		[Token(Token = "0x14000021")]
		public event UserAchievementUpdateHandler OnUserAchievementUpdate
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x123F90C", Offset = "0x123F90C", VA = "0x123F90C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAC80", Offset = "0xBDAC80")]
			add
			{
			}
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x123F9B0", Offset = "0x123F9B0", VA = "0x123F9B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBDAC90", Offset = "0xBDAC90")]
			remove
			{
			}
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x123FA54", Offset = "0x123FA54", VA = "0x123FA54")]
		internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x123FB28", Offset = "0x123FB28", VA = "0x123FB28")]
		private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x123F5F0", Offset = "0x123F5F0", VA = "0x123F5F0")]
		[MonoPInvokeCallback]
		private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x123FE5C", Offset = "0x123FE5C", VA = "0x123FE5C")]
		public void SetUserAchievement(long achievementId, byte percentComplete, SetUserAchievementHandler callback)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x123F698", Offset = "0x123F698", VA = "0x123F698")]
		[MonoPInvokeCallback]
		private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1240490", Offset = "0x1240490", VA = "0x1240490")]
		public void FetchUserAchievements(FetchUserAchievementsHandler callback)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1240804", Offset = "0x1240804", VA = "0x1240804")]
		public int CountUserAchievements()
		{
			return default(int);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1240ACC", Offset = "0x1240ACC", VA = "0x1240ACC")]
		public UserAchievement GetUserAchievement(long userAchievementId)
		{
			return default(UserAchievement);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1240E34", Offset = "0x1240E34", VA = "0x1240E34")]
		public UserAchievement GetUserAchievementAt(int index)
		{
			return default(UserAchievement);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x123F740", Offset = "0x123F740", VA = "0x123F740")]
		[MonoPInvokeCallback]
		private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement)
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000077")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8CF0", Offset = "0xBD8CF0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x12375EC", Offset = "0x12375EC", VA = "0x12375EC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x1237DAC", Offset = "0x1237DAC", VA = "0x1237DAC")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x1237DC8", Offset = "0x1237DC8", VA = "0x1237DC8")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D00", Offset = "0xBD8D00")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1237730", Offset = "0x1237730", VA = "0x1237730")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1237DE4", Offset = "0x1237DE4", VA = "0x1237DE4")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x1237E00", Offset = "0x1237E00", VA = "0x1237E00")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D10", Offset = "0xBD8D10")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x1237878", Offset = "0x1237878", VA = "0x1237878")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1237E1C", Offset = "0x1237E1C", VA = "0x1237E1C")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x1237E5C", Offset = "0x1237E5C", VA = "0x1237E5C")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1237488", Offset = "0x1237488", VA = "0x1237488")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x12375F4", Offset = "0x12375F4", VA = "0x12375F4")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1237738", Offset = "0x1237738", VA = "0x1237738")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1237880", Offset = "0x1237880", VA = "0x1237880")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x12378F8", Offset = "0x12378F8", VA = "0x12378F8")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1237970", Offset = "0x1237970", VA = "0x1237970")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x12379D8", Offset = "0x12379D8", VA = "0x12379D8")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1237A60", Offset = "0x1237A60", VA = "0x1237A60")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1237AC8", Offset = "0x1237AC8", VA = "0x1237AC8")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1237B30", Offset = "0x1237B30", VA = "0x1237B30")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1237B98", Offset = "0x1237B98", VA = "0x1237B98")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1237C00", Offset = "0x1237C00", VA = "0x1237C00")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1237C70", Offset = "0x1237C70", VA = "0x1237C70")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1237CDC", Offset = "0x1237CDC", VA = "0x1237CDC")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1237D44", Offset = "0x1237D44", VA = "0x1237D44")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000078")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000117")]
		public static class Utils
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x123D0DC", Offset = "0x123D0DC", VA = "0x123D0DC")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D20", Offset = "0xBD8D20")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1237FBC", Offset = "0x1237FBC", VA = "0x1237FBC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x123BEB8", Offset = "0x123BEB8", VA = "0x123BEB8")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x123BED4", Offset = "0x123BED4", VA = "0x123BED4")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D30", Offset = "0xBD8D30")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x1238128", Offset = "0x1238128", VA = "0x1238128")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0x123C128", Offset = "0x123C128", VA = "0x123C128")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x123C14C", Offset = "0x123C14C", VA = "0x123C14C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D40", Offset = "0xBD8D40")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x123826C", Offset = "0x123826C", VA = "0x123826C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x123C7B4", Offset = "0x123C7B4", VA = "0x123C7B4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x123C7D8", Offset = "0x123C7D8", VA = "0x123C7D8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D50", Offset = "0xBD8D50")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x12383D8", Offset = "0x12383D8", VA = "0x12383D8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0x123CC80", Offset = "0x123CC80", VA = "0x123CC80")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x123CCA4", Offset = "0x123CCA4", VA = "0x123CCA4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D60", Offset = "0xBD8D60")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x123851C", Offset = "0x123851C", VA = "0x123851C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x123CDC8", Offset = "0x123CDC8", VA = "0x123CDC8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x123CDEC", Offset = "0x123CDEC", VA = "0x123CDEC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D70", Offset = "0xBD8D70")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x1238684", Offset = "0x1238684", VA = "0x1238684")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x123CE10", Offset = "0x123CE10", VA = "0x123CE10")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x123CE2C", Offset = "0x123CE2C", VA = "0x123CE2C")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D80", Offset = "0xBD8D80")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x12389C8", Offset = "0x12389C8", VA = "0x12389C8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x123CE48", Offset = "0x123CE48", VA = "0x123CE48")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x123CEC8", Offset = "0x123CEC8", VA = "0x123CEC8")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8D90", Offset = "0xBD8D90")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1238B2C", Offset = "0x1238B2C", VA = "0x1238B2C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x123CF24", Offset = "0x123CF24", VA = "0x123CF24")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x123CFA4", Offset = "0x123CFA4", VA = "0x123CFA4")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8DA0", Offset = "0xBD8DA0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1238C90", Offset = "0x1238C90", VA = "0x1238C90")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x123D000", Offset = "0x123D000", VA = "0x123D000")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x123D080", Offset = "0x123D080", VA = "0x123D080")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8DB0", Offset = "0xBD8DB0")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1238DFC", Offset = "0x1238DFC", VA = "0x1238DFC")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x123BEF0", Offset = "0x123BEF0", VA = "0x123BEF0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x123BF10", Offset = "0x123BF10", VA = "0x123BF10")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8DC0", Offset = "0xBD8DC0")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1238F40", Offset = "0x1238F40", VA = "0x1238F40")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x123BF2C", Offset = "0x123BF2C", VA = "0x123BF2C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x123BF4C", Offset = "0x123BF4C", VA = "0x123BF4C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8DD0", Offset = "0xBD8DD0")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x1239094", Offset = "0x1239094", VA = "0x1239094")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x123BF68", Offset = "0x123BF68", VA = "0x123BF68")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x123BF84", Offset = "0x123BF84", VA = "0x123BF84")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8DE0", Offset = "0xBD8DE0")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x12391F8", Offset = "0x12391F8", VA = "0x12391F8")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x123BFA0", Offset = "0x123BFA0", VA = "0x123BFA0")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x123BFBC", Offset = "0x123BFBC", VA = "0x123BFBC")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8DF0", Offset = "0xBD8DF0")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x1239370", Offset = "0x1239370", VA = "0x1239370")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x123BFD8", Offset = "0x123BFD8", VA = "0x123BFD8")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x123BFF4", Offset = "0x123BFF4", VA = "0x123BFF4")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E00", Offset = "0xBD8E00")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x12394E8", Offset = "0x12394E8", VA = "0x12394E8")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x123C010", Offset = "0x123C010", VA = "0x123C010")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x123C02C", Offset = "0x123C02C", VA = "0x123C02C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E10", Offset = "0xBD8E10")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x1239654", Offset = "0x1239654", VA = "0x1239654")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x123C048", Offset = "0x123C048", VA = "0x123C048")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x123C064", Offset = "0x123C064", VA = "0x123C064")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E20", Offset = "0xBD8E20")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x12397D8", Offset = "0x12397D8", VA = "0x12397D8")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x123C080", Offset = "0x123C080", VA = "0x123C080")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x123C09C", Offset = "0x123C09C", VA = "0x123C09C")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E30", Offset = "0xBD8E30")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x123995C", Offset = "0x123995C", VA = "0x123995C")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x123C0B8", Offset = "0x123C0B8", VA = "0x123C0B8")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x123C0D4", Offset = "0x123C0D4", VA = "0x123C0D4")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E40", Offset = "0xBD8E40")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x1239AE0", Offset = "0x1239AE0", VA = "0x1239AE0")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x123C0F0", Offset = "0x123C0F0", VA = "0x123C0F0")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x123C10C", Offset = "0x123C10C", VA = "0x123C10C")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E50", Offset = "0xBD8E50")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x1239C44", Offset = "0x1239C44", VA = "0x1239C44")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x123C170", Offset = "0x123C170", VA = "0x123C170")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x123C18C", Offset = "0x123C18C", VA = "0x123C18C")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E60", Offset = "0xBD8E60")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x1239DA8", Offset = "0x1239DA8", VA = "0x1239DA8")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x123C1A8", Offset = "0x123C1A8", VA = "0x123C1A8")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x123C1C4", Offset = "0x123C1C4", VA = "0x123C1C4")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E70", Offset = "0xBD8E70")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1239EFC", Offset = "0x1239EFC", VA = "0x1239EFC")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x123C1E0", Offset = "0x123C1E0", VA = "0x123C1E0")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x123C1FC", Offset = "0x123C1FC", VA = "0x123C1FC")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E80", Offset = "0xBD8E80")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x123A068", Offset = "0x123A068", VA = "0x123A068")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x123C218", Offset = "0x123C218", VA = "0x123C218")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x123C234", Offset = "0x123C234", VA = "0x123C234")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8E90", Offset = "0xBD8E90")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x123A1D4", Offset = "0x123A1D4", VA = "0x123A1D4")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x123C250", Offset = "0x123C250", VA = "0x123C250")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x123C26C", Offset = "0x123C26C", VA = "0x123C26C")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8EA0", Offset = "0xBD8EA0")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x123A338", Offset = "0x123A338", VA = "0x123A338")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x123C288", Offset = "0x123C288", VA = "0x123C288")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x123C2A4", Offset = "0x123C2A4", VA = "0x123C2A4")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8EB0", Offset = "0xBD8EB0")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x123A4F0", Offset = "0x123A4F0", VA = "0x123A4F0")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x123C2C0", Offset = "0x123C2C0", VA = "0x123C2C0")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x123C350", Offset = "0x123C350", VA = "0x123C350")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8EC0", Offset = "0xBD8EC0")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x123A678", Offset = "0x123A678", VA = "0x123A678")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x123C3F4", Offset = "0x123C3F4", VA = "0x123C3F4")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x123C484", Offset = "0x123C484", VA = "0x123C484")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8ED0", Offset = "0xBD8ED0")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x123A84C", Offset = "0x123A84C", VA = "0x123A84C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x123C528", Offset = "0x123C528", VA = "0x123C528")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x123C5B8", Offset = "0x123C5B8", VA = "0x123C5B8")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8EE0", Offset = "0xBD8EE0")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x123ABD0", Offset = "0x123ABD0", VA = "0x123ABD0")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x123C65C", Offset = "0x123C65C", VA = "0x123C65C")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x123C678", Offset = "0x123C678", VA = "0x123C678")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x123C694", Offset = "0x123C694", VA = "0x123C694")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x123C6C8", Offset = "0x123C6C8", VA = "0x123C6C8")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x123C6E4", Offset = "0x123C6E4", VA = "0x123C6E4")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x123C700", Offset = "0x123C700", VA = "0x123C700")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8EF0", Offset = "0xBD8EF0")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x123AD28", Offset = "0x123AD28", VA = "0x123AD28")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x123C7FC", Offset = "0x123C7FC", VA = "0x123C7FC")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x123C86C", Offset = "0x123C86C", VA = "0x123C86C")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F00", Offset = "0xBD8F00")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x123AE70", Offset = "0x123AE70", VA = "0x123AE70")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x123C8B8", Offset = "0x123C8B8", VA = "0x123C8B8")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x123C8D4", Offset = "0x123C8D4", VA = "0x123C8D4")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F10", Offset = "0xBD8F10")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x123AFB8", Offset = "0x123AFB8", VA = "0x123AFB8")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x123C8F0", Offset = "0x123C8F0", VA = "0x123C8F0")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x123C90C", Offset = "0x123C90C", VA = "0x123C90C")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F20", Offset = "0xBD8F20")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x123B10C", Offset = "0x123B10C", VA = "0x123B10C")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x123C928", Offset = "0x123C928", VA = "0x123C928")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x123C94C", Offset = "0x123C94C", VA = "0x123C94C")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F30", Offset = "0xBD8F30")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x123B278", Offset = "0x123B278", VA = "0x123B278")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x123C970", Offset = "0x123C970", VA = "0x123C970")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x123C994", Offset = "0x123C994", VA = "0x123C994")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F40", Offset = "0xBD8F40")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x123B41C", Offset = "0x123B41C", VA = "0x123B41C")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x123C9B8", Offset = "0x123C9B8", VA = "0x123C9B8")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x123C9C0", Offset = "0x123C9C0", VA = "0x123C9C0")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F50", Offset = "0xBD8F50")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x123B560", Offset = "0x123B560", VA = "0x123B560")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x123CA60", Offset = "0x123CA60", VA = "0x123CA60")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x123CA84", Offset = "0x123CA84", VA = "0x123CA84")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F60", Offset = "0xBD8F60")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x123B73C", Offset = "0x123B73C", VA = "0x123B73C")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x123CAA8", Offset = "0x123CAA8", VA = "0x123CAA8")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x123CACC", Offset = "0x123CACC", VA = "0x123CACC")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F70", Offset = "0xBD8F70")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x123B930", Offset = "0x123B930", VA = "0x123B930")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x123CAF0", Offset = "0x123CAF0", VA = "0x123CAF0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x123CAFC", Offset = "0x123CAFC", VA = "0x123CAFC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F80", Offset = "0xBD8F80")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x123BB24", Offset = "0x123BB24", VA = "0x123BB24")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x123CBB8", Offset = "0x123CBB8", VA = "0x123CBB8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x123CBC4", Offset = "0x123CBC4", VA = "0x123CBC4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8F90", Offset = "0xBD8F90")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x123BD18", Offset = "0x123BD18", VA = "0x123BD18")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x123CCC8", Offset = "0x123CCC8", VA = "0x123CCC8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x123CCD4", Offset = "0x123CCD4", VA = "0x123CCD4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8FA0", Offset = "0xBD8FA0")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x123BEB0", Offset = "0x123BEB0", VA = "0x123BEB0")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x123CD90", Offset = "0x123CD90", VA = "0x123CD90")]
			internal Vector2 <DOShapeCircle>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x123CDAC", Offset = "0x123CDAC", VA = "0x123CDAC")]
			internal void <DOShapeCircle>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1237E80", Offset = "0x1237E80", VA = "0x1237E80")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1237FC4", Offset = "0x1237FC4", VA = "0x1237FC4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1238130", Offset = "0x1238130", VA = "0x1238130")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1238274", Offset = "0x1238274", VA = "0x1238274")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x12383E0", Offset = "0x12383E0", VA = "0x12383E0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1238524", Offset = "0x1238524", VA = "0x1238524")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x123868C", Offset = "0x123868C", VA = "0x123868C")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x123886C", Offset = "0x123886C", VA = "0x123886C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x12389D0", Offset = "0x12389D0", VA = "0x12389D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1238B34", Offset = "0x1238B34", VA = "0x1238B34")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1238C98", Offset = "0x1238C98", VA = "0x1238C98")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1238E04", Offset = "0x1238E04", VA = "0x1238E04")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1238F48", Offset = "0x1238F48", VA = "0x1238F48")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x123909C", Offset = "0x123909C", VA = "0x123909C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1239200", Offset = "0x1239200", VA = "0x1239200")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1239378", Offset = "0x1239378", VA = "0x1239378")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x12394F0", Offset = "0x12394F0", VA = "0x12394F0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x123965C", Offset = "0x123965C", VA = "0x123965C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x12397E0", Offset = "0x12397E0", VA = "0x12397E0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1239964", Offset = "0x1239964", VA = "0x1239964")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1239AE8", Offset = "0x1239AE8", VA = "0x1239AE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1239C4C", Offset = "0x1239C4C", VA = "0x1239C4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1239DB0", Offset = "0x1239DB0", VA = "0x1239DB0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1239F04", Offset = "0x1239F04", VA = "0x1239F04")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x123A070", Offset = "0x123A070", VA = "0x123A070")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x123A1DC", Offset = "0x123A1DC", VA = "0x123A1DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x123A340", Offset = "0x123A340", VA = "0x123A340")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x123A4F8", Offset = "0x123A4F8", VA = "0x123A4F8")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x123A680", Offset = "0x123A680", VA = "0x123A680")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x123A854", Offset = "0x123A854", VA = "0x123A854")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x123ABD8", Offset = "0x123ABD8", VA = "0x123ABD8")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x123AD30", Offset = "0x123AD30", VA = "0x123AD30")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x123AE78", Offset = "0x123AE78", VA = "0x123AE78")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x123AFC0", Offset = "0x123AFC0", VA = "0x123AFC0")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x123B114", Offset = "0x123B114", VA = "0x123B114")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x123B280", Offset = "0x123B280", VA = "0x123B280")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x123B424", Offset = "0x123B424", VA = "0x123B424")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x123B568", Offset = "0x123B568", VA = "0x123B568")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x123B744", Offset = "0x123B744", VA = "0x123B744")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x123B938", Offset = "0x123B938", VA = "0x123B938")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x123BB2C", Offset = "0x123BB2C", VA = "0x123BB2C")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x123BD20", Offset = "0x123BD20", VA = "0x123BD20")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000079")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8FB0", Offset = "0xBD8FB0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x123DDE4", Offset = "0x123DDE4", VA = "0x123DDE4")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x123E574", Offset = "0x123E574", VA = "0x123E574")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x123E598", Offset = "0x123E598", VA = "0x123E598")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8FC0", Offset = "0xBD8FC0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x123DFAC", Offset = "0x123DFAC", VA = "0x123DFAC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x123E5BC", Offset = "0x123E5BC", VA = "0x123E5BC")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x123E5E0", Offset = "0x123E5E0", VA = "0x123E5E0")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8FD0", Offset = "0xBD8FD0")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x123E604", Offset = "0x123E604", VA = "0x123E604", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x123E848", Offset = "0x123E848", VA = "0x123E848", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8FE0", Offset = "0xBD8FE0")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x123EF58", Offset = "0x123EF58", VA = "0x123EF58", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x123F1C0", Offset = "0x123F1C0", VA = "0x123F1C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD8FF0", Offset = "0xBD8FF0")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x123EAAC", Offset = "0x123EAAC", VA = "0x123EAAC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x123ECDC", Offset = "0x123ECDC", VA = "0x123ECDC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD9000", Offset = "0xBD9000")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x123E854", Offset = "0x123E854", VA = "0x123E854", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x123EAA0", Offset = "0x123EAA0", VA = "0x123EAA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD9010", Offset = "0xBD9010")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x123ECE8", Offset = "0x123ECE8", VA = "0x123ECE8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x123EF4C", Offset = "0x123EF4C", VA = "0x123EF4C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xBD9020", Offset = "0xBD9020")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x123F1CC", Offset = "0x123F1CC", VA = "0x123F1CC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x123F404", Offset = "0x123F404", VA = "0x123F404", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x123D388", Offset = "0x123D388", VA = "0x123D388")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x123D564", Offset = "0x123D564", VA = "0x123D564")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x123D754", Offset = "0x123D754", VA = "0x123D754")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x123D81C", Offset = "0x123D81C", VA = "0x123D81C")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x123D8E4", Offset = "0x123D8E4", VA = "0x123D8E4")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x123D9AC", Offset = "0x123D9AC", VA = "0x123D9AC")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x123DA84", Offset = "0x123DA84", VA = "0x123DA84")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x123DB5C", Offset = "0x123DB5C", VA = "0x123DB5C")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x123DC24", Offset = "0x123DC24", VA = "0x123DC24")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x123DDEC", Offset = "0x123DDEC", VA = "0x123DDEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x123DFB4", Offset = "0x123DFB4", VA = "0x123DFB4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBDB100", Offset = "0xBDB100")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x123E0A4", Offset = "0x123E0A4", VA = "0x123E0A4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBDB174", Offset = "0xBDB174")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x123E194", Offset = "0x123E194", VA = "0x123E194")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBDB1E8", Offset = "0xBDB1E8")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x123E284", Offset = "0x123E284", VA = "0x123E284")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBDB25C", Offset = "0xBDB25C")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x123E384", Offset = "0x123E384", VA = "0x123E384")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBDB2D0", Offset = "0xBDB2D0")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x123E484", Offset = "0x123E484", VA = "0x123E484")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xBDB344", Offset = "0xBDB344")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000149")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000059")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x12371C8", Offset = "0x12371C8", VA = "0x12371C8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x12371FC", Offset = "0x12371FC", VA = "0x12371FC")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200014A")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x1237398", Offset = "0x1237398", VA = "0x1237398", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x12373FC", Offset = "0x12373FC", VA = "0x12373FC")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x200014B")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x12372B0", Offset = "0x12372B0", VA = "0x12372B0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x12372CC", Offset = "0x12372CC", VA = "0x12372CC")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200014C")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700005C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x1237228", Offset = "0x1237228", VA = "0x1237228", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1237274", Offset = "0x1237274", VA = "0x1237274")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200014D")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700005D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x12372F8", Offset = "0x12372F8", VA = "0x12372F8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x123735C", Offset = "0x123735C", VA = "0x123735C")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200014E")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000624")]
				[Address(RVA = "0x1237428", Offset = "0x1237428", VA = "0x1237428", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000625")]
			[Address(RVA = "0x123745C", Offset = "0x123745C", VA = "0x123745C")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200007B")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200014F")]
		public static class Physics
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x123F554", Offset = "0x123F554", VA = "0x123F554")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x123F570", Offset = "0x123F570", VA = "0x123F570")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x123F578", Offset = "0x123F578", VA = "0x123F578")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x123F580", Offset = "0x123F580", VA = "0x123F580")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x123F410", Offset = "0x123F410", VA = "0x123F410")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x123F4B4", Offset = "0x123F4B4", VA = "0x123F4B4")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
