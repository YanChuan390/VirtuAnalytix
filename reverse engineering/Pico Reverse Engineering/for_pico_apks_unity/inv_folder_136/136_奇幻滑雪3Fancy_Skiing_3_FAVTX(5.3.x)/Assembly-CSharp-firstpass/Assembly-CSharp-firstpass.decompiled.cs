using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Deps;
using Il2CppDummyDll;
using KBEngine;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class KBEMain : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public KBEngineApp gameapp;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public DEBUGLEVEL debugLevel;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool isMultiThreads;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ip;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int port;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public KBEngineApp.CLIENT_TYPE clientType;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public KBEngineApp.NETWORK_ENCRYPT_TYPE networkEncryptType;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int syncPlayerMS;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int threadUpdateHZ;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int serverHeartbeatTick;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int TCP_SEND_BUFFER_MAX;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int TCP_RECV_BUFFER_MAX;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int UDP_SEND_BUFFER_MAX;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int UDP_RECV_BUFFER_MAX;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool useAliasEntityID;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool isOnInitCallPropertysSetMethods;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
	public bool forceDisableUDP;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
	public bool automaticallyUpdateSDK;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE89D60", Offset = "0xE89D60", VA = "0xE89D60", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE89E04", Offset = "0xE89E04", VA = "0xE89E04", Slot = "5")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE89E84", Offset = "0xE89E84", VA = "0xE89E84", Slot = "6")]
	public virtual void installEvents()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE89F50", Offset = "0xE89F50", VA = "0xE89F50")]
	public void onVersionNotMatch(string verInfo, string serVerInfo)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE89F54", Offset = "0xE89F54", VA = "0xE89F54")]
	public void onScriptVersionNotMatch(string verInfo, string serVerInfo)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE89F58", Offset = "0xE89F58", VA = "0xE89F58", Slot = "7")]
	public virtual void initKBEngine()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE8A9EC", Offset = "0xE8A9EC", VA = "0xE8A9EC", Slot = "8")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE8AB5C", Offset = "0xE8AB5C", VA = "0xE8AB5C", Slot = "9")]
	protected virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE8AB6C", Offset = "0xE8AB6C", VA = "0xE8AB6C", Slot = "10")]
	public virtual void KBEUpdate()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE8AC10", Offset = "0xE8AC10", VA = "0xE8AC10")]
	public KBEMain()
	{
	}
}
namespace Deps
{
	[Token(Token = "0x2000003")]
	public class KCP
	{
		[Token(Token = "0x2000004")]
		public class TimeUtils
		{
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly DateTime epoch;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static readonly DateTime twepoch;

			[Token(Token = "0x6000032")]
			[Address(RVA = "0xECD2CC", Offset = "0xECD2CC", VA = "0xECD2CC")]
			public static uint iclock()
			{
				return default(uint);
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0xED63BC", Offset = "0xED63BC", VA = "0xED63BC")]
			public static long LocalUnixTime()
			{
				return default(long);
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0xED6528", Offset = "0xED6528", VA = "0xED6528")]
			public static long ToUnixTimestamp(DateTime t)
			{
				return default(long);
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0xED6684", Offset = "0xED6684", VA = "0xED6684")]
			public TimeUtils()
			{
			}
		}

		[Token(Token = "0x2000005")]
		internal class Segment
		{
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal uint conv;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal uint cmd;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal uint frg;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			internal uint wnd;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal uint ts;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal uint sn;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal uint una;

			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal uint resendts;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal uint rto;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal uint faskack;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal uint xmit;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal byte[] data;

			[Token(Token = "0x6000037")]
			[Address(RVA = "0xED6250", Offset = "0xED6250", VA = "0xED6250")]
			internal Segment(int size = 0)
			{
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0xED62C8", Offset = "0xED62C8", VA = "0xED62C8")]
			internal void Encode(byte[] ptr, ref int offset)
			{
			}
		}

		[Token(Token = "0x2000006")]
		public delegate void OutputDelegate(byte[] data, int size, object user);

		[Token(Token = "0x4000013")]
		public const int IKCP_RTO_NDL = 30;

		[Token(Token = "0x4000014")]
		public const int IKCP_RTO_MIN = 100;

		[Token(Token = "0x4000015")]
		public const int IKCP_RTO_DEF = 200;

		[Token(Token = "0x4000016")]
		public const int IKCP_RTO_MAX = 60000;

		[Token(Token = "0x4000017")]
		public const int IKCP_CMD_PUSH = 81;

		[Token(Token = "0x4000018")]
		public const int IKCP_CMD_ACK = 82;

		[Token(Token = "0x4000019")]
		public const int IKCP_CMD_WASK = 83;

		[Token(Token = "0x400001A")]
		public const int IKCP_CMD_WINS = 84;

		[Token(Token = "0x400001B")]
		public const int IKCP_ASK_SEND = 1;

		[Token(Token = "0x400001C")]
		public const int IKCP_ASK_TELL = 2;

		[Token(Token = "0x400001D")]
		public const int IKCP_WND_SND = 32;

		[Token(Token = "0x400001E")]
		public const int IKCP_WND_RCV = 32;

		[Token(Token = "0x400001F")]
		public const int IKCP_MTU_DEF = 1400;

		[Token(Token = "0x4000020")]
		public const int IKCP_ACK_FAST = 3;

		[Token(Token = "0x4000021")]
		public const int IKCP_INTERVAL = 100;

		[Token(Token = "0x4000022")]
		public const int IKCP_OVERHEAD = 24;

		[Token(Token = "0x4000023")]
		public const int IKCP_DEADLINK = 20;

		[Token(Token = "0x4000024")]
		public const int IKCP_THRESH_INIT = 2;

		[Token(Token = "0x4000025")]
		public const int IKCP_THRESH_MIN = 2;

		[Token(Token = "0x4000026")]
		public const int IKCP_PROBE_INIT = 7000;

		[Token(Token = "0x4000027")]
		public const int IKCP_PROBE_LIMIT = 120000;

		[Token(Token = "0x4000028")]
		public const int IKCP_LOG_OUTPUT = 1;

		[Token(Token = "0x4000029")]
		public const int IKCP_LOG_INPUT = 2;

		[Token(Token = "0x400002A")]
		public const int IKCP_LOG_SEND = 4;

		[Token(Token = "0x400002B")]
		public const int IKCP_LOG_RECV = 8;

		[Token(Token = "0x400002C")]
		public const int IKCP_LOG_IN_DATA = 16;

		[Token(Token = "0x400002D")]
		public const int IKCP_LOG_IN_ACK = 32;

		[Token(Token = "0x400002E")]
		public const int IKCP_LOG_IN_PROBE = 64;

		[Token(Token = "0x400002F")]
		public const int IKCP_LOG_IN_WINS = 128;

		[Token(Token = "0x4000030")]
		public const int IKCP_LOG_OUT_DATA = 256;

		[Token(Token = "0x4000031")]
		public const int IKCP_LOG_OUT_ACK = 512;

		[Token(Token = "0x4000032")]
		public const int IKCP_LOG_OUT_PROBE = 1024;

		[Token(Token = "0x4000033")]
		public const int IKCP_LOG_OUT_WINS = 2048;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private uint conv_;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private uint mtu_;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint mss_;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private uint state_;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint snd_una_;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private uint snd_nxt_;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint rcv_nxt_;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private uint ssthresh_;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int rx_rttval_;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int rx_srtt_;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int rx_rto_;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int rx_minrto_;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint snd_wnd_;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private uint rcv_wnd_;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint rmt_wnd_;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private uint cwnd_;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private uint probe_;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private uint current_;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private uint interval_;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private uint ts_flush_;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private uint xmit_;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private uint nrcv_buf_;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private uint nsnd_buf_;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private uint nrcv_que_;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private uint nsnd_que_;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private uint nodelay_;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private uint updated_;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private uint ts_probe_;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private uint probe_wait_;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private uint dead_link_;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private uint incr_;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private LinkedList<Segment> snd_queue_;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private LinkedList<Segment> rcv_queue_;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private LinkedList<Segment> snd_buf_;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private LinkedList<Segment> rcv_buf_;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private uint[] acklist_;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private uint ackcount_;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private uint ackblock_;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private byte[] buffer_;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private object user_;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int fastresend_;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int nocwnd_;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private OutputDelegate output_;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xE9DC90", Offset = "0xE9DC90", VA = "0xE9DC90")]
		public static void ikcp_encode8u(byte[] p, int offset, byte c)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xE9DCD4", Offset = "0xE9DCD4", VA = "0xE9DCD4")]
		public static byte ikcp_decode8u(byte[] p, ref int offset)
		{
			return default(byte);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xE9DD1C", Offset = "0xE9DD1C", VA = "0xE9DD1C")]
		public static void ikcp_encode16u(byte[] p, int offset, ushort v)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE9DD88", Offset = "0xE9DD88", VA = "0xE9DD88")]
		public static ushort ikcp_decode16u(byte[] p, ref int offset)
		{
			return default(ushort);
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xE9DDFC", Offset = "0xE9DDFC", VA = "0xE9DDFC")]
		public static void ikcp_encode32u(byte[] p, int offset, uint l)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xE9DEB8", Offset = "0xE9DEB8", VA = "0xE9DEB8")]
		public static uint ikcp_decode32u(byte[] p, ref int offset)
		{
			return default(uint);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xE9DF78", Offset = "0xE9DF78", VA = "0xE9DF78")]
		public static uint _imin_(uint a, uint b)
		{
			return default(uint);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xE9DF84", Offset = "0xE9DF84", VA = "0xE9DF84")]
		public static uint _imax_(uint a, uint b)
		{
			return default(uint);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xE9DF90", Offset = "0xE9DF90", VA = "0xE9DF90")]
		public static uint _ibound_(uint lower, uint middle, uint upper)
		{
			return default(uint);
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0xE9DFA4", Offset = "0xE9DFA4", VA = "0xE9DFA4")]
		public static int _itimediff(uint later, uint earlier)
		{
			return default(int);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE9DFB0", Offset = "0xE9DFB0", VA = "0xE9DFB0")]
		public KCP(uint conv, object user)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE9E15C", Offset = "0xE9E15C", VA = "0xE9E15C")]
		public void Release()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE9E250", Offset = "0xE9E250", VA = "0xE9E250")]
		public void SetOutput(OutputDelegate output)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE9E258", Offset = "0xE9E258", VA = "0xE9E258")]
		public int Recv(byte[] buffer, int offset, int len)
		{
			return default(int);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE9E6A8", Offset = "0xE9E6A8", VA = "0xE9E6A8")]
		public int PeekSize()
		{
			return default(int);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE9E81C", Offset = "0xE9E81C", VA = "0xE9E81C")]
		public int Send(byte[] buffer, int offset, int len)
		{
			return default(int);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE9E9B8", Offset = "0xE9E9B8", VA = "0xE9E9B8")]
		private void UpdateACK(int rtt)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE9EA58", Offset = "0xE9EA58", VA = "0xE9EA58")]
		private void ShrinkBuf()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE9EAE8", Offset = "0xE9EAE8", VA = "0xE9EAE8")]
		private void ParseACK(uint sn)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE9EC30", Offset = "0xE9EC30", VA = "0xE9EC30")]
		private void ParseUNA(uint una)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xE9ED4C", Offset = "0xE9ED4C", VA = "0xE9ED4C")]
		private void ParseFastACK(uint sn)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE9EE40", Offset = "0xE9EE40", VA = "0xE9EE40")]
		private void ACKPush(uint sn, uint ts)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE9F080", Offset = "0xE9F080", VA = "0xE9F080")]
		private void ACKGet(int pos, ref uint sn, ref uint ts)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xE9F10C", Offset = "0xE9F10C", VA = "0xE9F10C")]
		private void ParseData(Segment newseg)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xE9F3E0", Offset = "0xE9F3E0", VA = "0xE9F3E0")]
		public int Input(byte[] data, int offset, int size)
		{
			return default(int);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE9FCB8", Offset = "0xE9FCB8", VA = "0xE9FCB8")]
		private int WndUnused()
		{
			return default(int);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xE9FCD0", Offset = "0xE9FCD0", VA = "0xE9FCD0")]
		private void Flush()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xEA0620", Offset = "0xEA0620", VA = "0xEA0620")]
		public void Update(uint current)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xEA06A0", Offset = "0xEA06A0", VA = "0xEA06A0")]
		public uint Check(uint current)
		{
			return default(uint);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xEA07CC", Offset = "0xEA07CC", VA = "0xEA07CC")]
		public int SetMTU(int mtu)
		{
			return default(int);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xEA0858", Offset = "0xEA0858", VA = "0xEA0858")]
		public int Interval(int interval)
		{
			return default(int);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xEA0878", Offset = "0xEA0878", VA = "0xEA0878")]
		public int NoDelay(int nodelay, int interval, int resend, int nc)
		{
			return default(int);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xEA08CC", Offset = "0xEA08CC", VA = "0xEA08CC")]
		public int WndSize(int sndwnd, int rcvwnd)
		{
			return default(int);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xEA08E4", Offset = "0xEA08E4", VA = "0xEA08E4")]
		public int WaitSnd()
		{
			return default(int);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xEA08F4", Offset = "0xEA08F4", VA = "0xEA08F4")]
		public uint GetConv()
		{
			return default(uint);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xEA08FC", Offset = "0xEA08FC", VA = "0xEA08FC")]
		public uint GetState()
		{
			return default(uint);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xEA0904", Offset = "0xEA0904", VA = "0xEA0904")]
		public void SetMinRTO(int minrto)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xEA090C", Offset = "0xEA090C", VA = "0xEA090C")]
		public void SetFastResend(int resend)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xE9E818", Offset = "0xE9E818", VA = "0xE9E818")]
		private void Log(int mask, string format, params object[] args)
		{
		}
	}
}
namespace KBEngine
{
	[Token(Token = "0x2000007")]
	public abstract class AccountBase : Entity
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public EntityBaseEntityCall_AccountBase baseEntityCall;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public EntityCellEntityCall_AccountBase cellEntityCall;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ITEM_LIST bagItemList;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public EQUIP_DICT currentEquipDict;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EQUIP_DICT currentItemDict;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int gold;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public sbyte lastLoginDate;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public short lastLoginDayLoginTimes;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public short lastLoginDayPlayTime;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string nameS;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int progress;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int roomNo;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public short totalLoginTimes;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
		public short totalPlayTime;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xE542B8", Offset = "0xE542B8", VA = "0xE542B8", Slot = "28")]
		public virtual void onBagItemListChanged(ITEM_LIST oldValue)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xE542BC", Offset = "0xE542BC", VA = "0xE542BC", Slot = "29")]
		public virtual void onCurrentEquipDictChanged(EQUIP_DICT oldValue)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xE542C0", Offset = "0xE542C0", VA = "0xE542C0", Slot = "30")]
		public virtual void onCurrentItemDictChanged(EQUIP_DICT oldValue)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xE542C4", Offset = "0xE542C4", VA = "0xE542C4", Slot = "31")]
		public virtual void onGoldChanged(int oldValue)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xE542C8", Offset = "0xE542C8", VA = "0xE542C8", Slot = "32")]
		public virtual void onLastLoginDateChanged(sbyte oldValue)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE542CC", Offset = "0xE542CC", VA = "0xE542CC", Slot = "33")]
		public virtual void onLastLoginDayLoginTimesChanged(short oldValue)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xE542D0", Offset = "0xE542D0", VA = "0xE542D0", Slot = "34")]
		public virtual void onLastLoginDayPlayTimeChanged(short oldValue)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xE542D4", Offset = "0xE542D4", VA = "0xE542D4", Slot = "35")]
		public virtual void onNameSChanged(string oldValue)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xE542D8", Offset = "0xE542D8", VA = "0xE542D8", Slot = "36")]
		public virtual void onProgressChanged(int oldValue)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xE542DC", Offset = "0xE542DC", VA = "0xE542DC", Slot = "37")]
		public virtual void onRoomNoChanged(int oldValue)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xE542E0", Offset = "0xE542E0", VA = "0xE542E0", Slot = "38")]
		public virtual void onTotalLoginTimesChanged(short oldValue)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xE542E4", Offset = "0xE542E4", VA = "0xE542E4", Slot = "39")]
		public virtual void onTotalPlayTimeChanged(short oldValue)
		{
		}

		[Token(Token = "0x6000049")]
		public abstract void notifyCountDown(int arg1);

		[Token(Token = "0x600004A")]
		public abstract void onBuyEquip(int arg1, byte arg2);

		[Token(Token = "0x600004B")]
		public abstract void onChangeEquip(int arg1, byte arg2);

		[Token(Token = "0x600004C")]
		public abstract void onExitRoom(int arg1);

		[Token(Token = "0x600004D")]
		public abstract void onGetGold(int arg1);

		[Token(Token = "0x600004E")]
		public abstract void onGetPropsClient(int arg1, string arg2, int arg3);

		[Token(Token = "0x600004F")]
		public abstract void onLoginState(int arg1, int arg2, int arg3, int arg4, int arg5);

		[Token(Token = "0x6000050")]
		public abstract void onMapModeChanged(int arg1, int arg2);

		[Token(Token = "0x6000051")]
		public abstract void onMatchingFinish(int arg1);

		[Token(Token = "0x6000052")]
		public abstract void onRemovePropResult(int arg1, byte arg2);

		[Token(Token = "0x6000053")]
		public abstract void onUseProp(int arg1, int arg2, int arg3, Vector3 arg4);

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE542E8", Offset = "0xE542E8", VA = "0xE542E8")]
		public AccountBase()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE54498", Offset = "0xE54498", VA = "0xE54498", Slot = "10")]
		public override void onComponentsEnterworld()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE5449C", Offset = "0xE5449C", VA = "0xE5449C", Slot = "11")]
		public override void onComponentsLeaveworld()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE544A0", Offset = "0xE544A0", VA = "0xE544A0", Slot = "7")]
		public override void onGetBase()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE54540", Offset = "0xE54540", VA = "0xE54540", Slot = "8")]
		public override void onGetCell()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE545E0", Offset = "0xE545E0", VA = "0xE545E0", Slot = "9")]
		public override void onLoseCell()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE545F0", Offset = "0xE545F0", VA = "0xE545F0", Slot = "12")]
		public override EntityCall getBaseEntityCall()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE545F8", Offset = "0xE545F8", VA = "0xE545F8", Slot = "13")]
		public override EntityCall getCellEntityCall()
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE54600", Offset = "0xE54600", VA = "0xE54600", Slot = "16")]
		public override void attachComponents()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE54604", Offset = "0xE54604", VA = "0xE54604", Slot = "17")]
		public override void detachComponents()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE54608", Offset = "0xE54608", VA = "0xE54608", Slot = "5")]
		public override void onRemoteMethodCall(MemoryStream stream)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE54C6C", Offset = "0xE54C6C", VA = "0xE54C6C", Slot = "6")]
		public override void onUpdatePropertys(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE5594C", Offset = "0xE5594C", VA = "0xE5594C", Slot = "15")]
		public override void callPropertysSetMethods()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class Blowfish
	{
		[Token(Token = "0x400007B")]
		private const int N = 16;

		[Token(Token = "0x400007C")]
		private const int KEYBYTES = 8;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte[] _key;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private bool _isGood;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RNGCryptoServiceProvider rngCsp;

		[Token(Token = "0x4000080")]
		private const int MIN_KEY_SIZE = 4;

		[Token(Token = "0x4000081")]
		private const int MAX_KEY_SIZE = 56;

		[Token(Token = "0x4000082")]
		private const int DEFAULT_KEY_SIZE = 16;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static uint[] _P;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static uint[,] _S;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint[] P;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private uint[,] S;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE565A8", Offset = "0xE565A8", VA = "0xE565A8")]
		public Blowfish(byte[] key)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE56B20", Offset = "0xE56B20", VA = "0xE56B20")]
		public Blowfish(string key)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE56B70", Offset = "0xE56B70", VA = "0xE56B70")]
		public Blowfish(int keySize = 16)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE56C88", Offset = "0xE56C88", VA = "0xE56C88", Slot = "1")]
		~Blowfish()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE56C90", Offset = "0xE56C90", VA = "0xE56C90")]
		public bool isGood()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE56644", Offset = "0xE56644", VA = "0xE56644")]
		private void init()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE56EA0", Offset = "0xE56EA0", VA = "0xE56EA0")]
		private uint f(uint x)
		{
			return default(uint);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE57030", Offset = "0xE57030", VA = "0xE57030")]
		public void encipher(byte[] data, int length)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE56DBC", Offset = "0xE56DBC", VA = "0xE56DBC")]
		private void encipher(ref uint xl, ref uint xr)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE57558", Offset = "0xE57558", VA = "0xE57558")]
		public string encipher(string data)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE57624", Offset = "0xE57624", VA = "0xE57624")]
		public void decipher(byte[] data, int startIndex, int length)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE57B74", Offset = "0xE57B74", VA = "0xE57B74")]
		private void decipher(ref uint xl, ref uint xr)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xE57C58", Offset = "0xE57C58", VA = "0xE57C58")]
		public string decipher(string data)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE57D30", Offset = "0xE57D30", VA = "0xE57D30")]
		public byte[] key()
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	public class Bundle : ObjectPool<Bundle>
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MemoryStream stream;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public List<MemoryStream> streamList;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int numMessage;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int messageLength;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Message msgtype;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _curMsgStreamIndex;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xE58B60", Offset = "0xE58B60", VA = "0xE58B60")]
		public Bundle()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE58C98", Offset = "0xE58C98", VA = "0xE58C98")]
		public void clear()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE58E74", Offset = "0xE58E74", VA = "0xE58E74")]
		public void reclaimObject()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE58F10", Offset = "0xE58F10", VA = "0xE58F10")]
		public void newMessage(Message mt)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE59104", Offset = "0xE59104", VA = "0xE59104")]
		public void writeMsgLength()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE58FA4", Offset = "0xE58FA4", VA = "0xE58FA4")]
		public void fini(bool issend)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE59250", Offset = "0xE59250", VA = "0xE59250")]
		public void send(NetworkInterfaceBase networkInterface)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE593B0", Offset = "0xE593B0", VA = "0xE593B0")]
		public void checkStream(int v)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE594DC", Offset = "0xE594DC", VA = "0xE594DC")]
		public void writeInt8(sbyte v)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE59518", Offset = "0xE59518", VA = "0xE59518")]
		public void writeInt16(short v)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE59554", Offset = "0xE59554", VA = "0xE59554")]
		public void writeInt32(int v)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE59590", Offset = "0xE59590", VA = "0xE59590")]
		public void writeInt64(long v)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE595E0", Offset = "0xE595E0", VA = "0xE595E0")]
		public void writeUint8(byte v)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE590C8", Offset = "0xE590C8", VA = "0xE590C8")]
		public void writeUint16(ushort v)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE5961C", Offset = "0xE5961C", VA = "0xE5961C")]
		public void writeUint32(uint v)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE59658", Offset = "0xE59658", VA = "0xE59658")]
		public void writeUint64(ulong v)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE596A8", Offset = "0xE596A8", VA = "0xE596A8")]
		public void writeFloat(float v)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xE596E4", Offset = "0xE596E4", VA = "0xE596E4")]
		public void writeDouble(double v)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE59734", Offset = "0xE59734", VA = "0xE59734")]
		public void writeString(string v)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xE59784", Offset = "0xE59784", VA = "0xE59784")]
		public void writeUnicode(string v)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xE597D4", Offset = "0xE597D4", VA = "0xE597D4")]
		public void writeBlob(byte[] v)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE59824", Offset = "0xE59824", VA = "0xE59824")]
		public void writePython(byte[] v)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE59828", Offset = "0xE59828", VA = "0xE59828")]
		public void writeVector2(Vector2 v)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE5986C", Offset = "0xE5986C", VA = "0xE5986C")]
		public void writeVector3(Vector3 v)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE598C4", Offset = "0xE598C4", VA = "0xE598C4")]
		public void writeVector4(Vector4 v)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE59924", Offset = "0xE59924", VA = "0xE59924")]
		public void writeEntitycall(byte[] v)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class DATATYPE_PROP_LIST : DATATYPE_BASE
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE5CEC0", Offset = "0xE5CEC0", VA = "0xE5CEC0")]
		public PROP_LIST createFromStreamEx(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE5CFA8", Offset = "0xE5CFA8", VA = "0xE5CFA8")]
		public void addToStreamEx(Bundle stream, PROP_LIST v)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE5D078", Offset = "0xE5D078", VA = "0xE5D078")]
		public DATATYPE_PROP_LIST()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class DATATYPE_ITEM_LIST : DATATYPE_BASE
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE55748", Offset = "0xE55748", VA = "0xE55748")]
		public ITEM_LIST createFromStreamEx(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE5CDE8", Offset = "0xE5CDE8", VA = "0xE5CDE8")]
		public void addToStreamEx(Bundle stream, ITEM_LIST v)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE5CEB8", Offset = "0xE5CEB8", VA = "0xE5CEB8")]
		public DATATYPE_ITEM_LIST()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class DATATYPE_EQUIP_DICT : DATATYPE_BASE
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE55830", Offset = "0xE55830", VA = "0xE55830")]
		public EQUIP_DICT createFromStreamEx(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE5AC2C", Offset = "0xE5AC2C", VA = "0xE5AC2C")]
		public void addToStreamEx(Bundle stream, EQUIP_DICT v)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE5ACF0", Offset = "0xE5ACF0", VA = "0xE5ACF0")]
		public DATATYPE_EQUIP_DICT()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class DATATYPE_AnonymousArray_25 : DATATYPE_BASE
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE5A330", Offset = "0xE5A330", VA = "0xE5A330")]
		public List<int> createFromStreamEx(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE5A438", Offset = "0xE5A438", VA = "0xE5A438")]
		public void addToStreamEx(Bundle stream, List<int> v)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE5A508", Offset = "0xE5A508", VA = "0xE5A508")]
		public DATATYPE_AnonymousArray_25()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class DATATYPE_BASE
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE5A510", Offset = "0xE5A510", VA = "0xE5A510", Slot = "4")]
		public virtual void bind()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE5A514", Offset = "0xE5A514", VA = "0xE5A514", Slot = "5")]
		public virtual object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE5A51C", Offset = "0xE5A51C", VA = "0xE5A51C", Slot = "6")]
		public virtual void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE5A520", Offset = "0xE5A520", VA = "0xE5A520", Slot = "7")]
		public virtual object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE5A528", Offset = "0xE5A528", VA = "0xE5A528", Slot = "8")]
		public virtual bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE5A328", Offset = "0xE5A328", VA = "0xE5A328")]
		public DATATYPE_BASE()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class DATATYPE_INT8 : DATATYPE_BASE
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE5CA7C", Offset = "0xE5CA7C", VA = "0xE5CA7C", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xE5CAFC", Offset = "0xE5CAFC", VA = "0xE5CAFC", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xE5CB94", Offset = "0xE5CB94", VA = "0xE5CB94", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xE5CC14", Offset = "0xE5CC14", VA = "0xE5CC14", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xE5CDE0", Offset = "0xE5CDE0", VA = "0xE5CDE0")]
		public DATATYPE_INT8()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class DATATYPE_INT16 : DATATYPE_BASE
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE5C014", Offset = "0xE5C014", VA = "0xE5C014", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE5C094", Offset = "0xE5C094", VA = "0xE5C094", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE5C12C", Offset = "0xE5C12C", VA = "0xE5C12C", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xE5C1AC", Offset = "0xE5C1AC", VA = "0xE5C1AC", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE5C37C", Offset = "0xE5C37C", VA = "0xE5C37C")]
		public DATATYPE_INT16()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class DATATYPE_INT32 : DATATYPE_BASE
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE5C384", Offset = "0xE5C384", VA = "0xE5C384", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE5C404", Offset = "0xE5C404", VA = "0xE5C404", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE5C49C", Offset = "0xE5C49C", VA = "0xE5C49C", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE5C51C", Offset = "0xE5C51C", VA = "0xE5C51C", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xE5C6E8", Offset = "0xE5C6E8", VA = "0xE5C6E8")]
		public DATATYPE_INT32()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class DATATYPE_INT64 : DATATYPE_BASE
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE5C6F0", Offset = "0xE5C6F0", VA = "0xE5C6F0", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xE5C770", Offset = "0xE5C770", VA = "0xE5C770", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE5C818", Offset = "0xE5C818", VA = "0xE5C818", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE5C8A0", Offset = "0xE5C8A0", VA = "0xE5C8A0", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE5CA74", Offset = "0xE5CA74", VA = "0xE5CA74")]
		public DATATYPE_INT64()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class DATATYPE_UINT8 : DATATYPE_BASE
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE5DE54", Offset = "0xE5DE54", VA = "0xE5DE54", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE5DED4", Offset = "0xE5DED4", VA = "0xE5DED4", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE5DF6C", Offset = "0xE5DF6C", VA = "0xE5DF6C", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE5DFEC", Offset = "0xE5DFEC", VA = "0xE5DFEC", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE5E1B4", Offset = "0xE5E1B4", VA = "0xE5E1B4")]
		public DATATYPE_UINT8()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class DATATYPE_UINT16 : DATATYPE_BASE
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE5D400", Offset = "0xE5D400", VA = "0xE5D400", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE5D480", Offset = "0xE5D480", VA = "0xE5D480", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE5D518", Offset = "0xE5D518", VA = "0xE5D518", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE5D598", Offset = "0xE5D598", VA = "0xE5D598", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE5D760", Offset = "0xE5D760", VA = "0xE5D760")]
		public DATATYPE_UINT16()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class DATATYPE_UINT32 : DATATYPE_BASE
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE5D768", Offset = "0xE5D768", VA = "0xE5D768", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE5D7E8", Offset = "0xE5D7E8", VA = "0xE5D7E8", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE5D880", Offset = "0xE5D880", VA = "0xE5D880", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE5D900", Offset = "0xE5D900", VA = "0xE5D900", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE5DAC8", Offset = "0xE5DAC8", VA = "0xE5DAC8")]
		public DATATYPE_UINT32()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class DATATYPE_UINT64 : DATATYPE_BASE
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE5DAD0", Offset = "0xE5DAD0", VA = "0xE5DAD0", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE5DB50", Offset = "0xE5DB50", VA = "0xE5DB50", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE5DBF8", Offset = "0xE5DBF8", VA = "0xE5DBF8", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE5DC80", Offset = "0xE5DC80", VA = "0xE5DC80", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE5DE4C", Offset = "0xE5DE4C", VA = "0xE5DE4C")]
		public DATATYPE_UINT64()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class DATATYPE_FLOAT : DATATYPE_BASE
	{
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xE5BD0C", Offset = "0xE5BD0C", VA = "0xE5BD0C", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xE5BD8C", Offset = "0xE5BD8C", VA = "0xE5BD8C", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE5BE30", Offset = "0xE5BE30", VA = "0xE5BE30", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE5BEB0", Offset = "0xE5BEB0", VA = "0xE5BEB0", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE5C00C", Offset = "0xE5C00C", VA = "0xE5C00C")]
		public DATATYPE_FLOAT()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class DATATYPE_DOUBLE : DATATYPE_BASE
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE5A71C", Offset = "0xE5A71C", VA = "0xE5A71C", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE5A79C", Offset = "0xE5A79C", VA = "0xE5A79C", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xE5A844", Offset = "0xE5A844", VA = "0xE5A844", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE5A8E8", Offset = "0xE5A8E8", VA = "0xE5A8E8", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE5AA3C", Offset = "0xE5AA3C", VA = "0xE5AA3C")]
		public DATATYPE_DOUBLE()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class DATATYPE_STRING : DATATYPE_BASE
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE5D268", Offset = "0xE5D268", VA = "0xE5D268", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xE5D290", Offset = "0xE5D290", VA = "0xE5D290", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xE5D328", Offset = "0xE5D328", VA = "0xE5D328", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xE5D330", Offset = "0xE5D330", VA = "0xE5D330", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xE5D3F8", Offset = "0xE5D3F8", VA = "0xE5D3F8")]
		public DATATYPE_STRING()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class DATATYPE_VECTOR2 : DATATYPE_BASE
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xE5E3B8", Offset = "0xE5E3B8", VA = "0xE5E3B8", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xE5E46C", Offset = "0xE5E46C", VA = "0xE5E46C", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xE5E55C", Offset = "0xE5E55C", VA = "0xE5E55C", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE5E5C4", Offset = "0xE5E5C4", VA = "0xE5E5C4", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE5E68C", Offset = "0xE5E68C", VA = "0xE5E68C")]
		public DATATYPE_VECTOR2()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class DATATYPE_VECTOR3 : DATATYPE_BASE
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xE5E694", Offset = "0xE5E694", VA = "0xE5E694", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xE5E770", Offset = "0xE5E770", VA = "0xE5E770", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xE5E89C", Offset = "0xE5E89C", VA = "0xE5E89C", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xE5E908", Offset = "0xE5E908", VA = "0xE5E908", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xE5E9D0", Offset = "0xE5E9D0", VA = "0xE5E9D0")]
		public DATATYPE_VECTOR3()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class DATATYPE_VECTOR4 : DATATYPE_BASE
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xE5E9D8", Offset = "0xE5E9D8", VA = "0xE5E9D8", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xE5EAF0", Offset = "0xE5EAF0", VA = "0xE5EAF0", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE5EC58", Offset = "0xE5EC58", VA = "0xE5EC58", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE5ECE8", Offset = "0xE5ECE8", VA = "0xE5ECE8", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE5EDB0", Offset = "0xE5EDB0", VA = "0xE5EDB0")]
		public DATATYPE_VECTOR4()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class DATATYPE_PYTHON : DATATYPE_BASE
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE5D080", Offset = "0xE5D080", VA = "0xE5D080", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xE5D0A8", Offset = "0xE5D0A8", VA = "0xE5D0A8", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xE5D144", Offset = "0xE5D144", VA = "0xE5D144", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xE5D198", Offset = "0xE5D198", VA = "0xE5D198", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE5D260", Offset = "0xE5D260", VA = "0xE5D260")]
		public DATATYPE_PYTHON()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class DATATYPE_UNICODE : DATATYPE_BASE
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE5E1BC", Offset = "0xE5E1BC", VA = "0xE5E1BC", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xE5E218", Offset = "0xE5E218", VA = "0xE5E218", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xE5E2E0", Offset = "0xE5E2E0", VA = "0xE5E2E0", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xE5E2E8", Offset = "0xE5E2E8", VA = "0xE5E2E8", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xE5E3B0", Offset = "0xE5E3B0", VA = "0xE5E3B0")]
		public DATATYPE_UNICODE()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class DATATYPE_ENTITYCALL : DATATYPE_BASE
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xE5AA44", Offset = "0xE5AA44", VA = "0xE5AA44", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE5AA6C", Offset = "0xE5AA6C", VA = "0xE5AA6C", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE5AB08", Offset = "0xE5AB08", VA = "0xE5AB08", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE5AB5C", Offset = "0xE5AB5C", VA = "0xE5AB5C", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE5AC24", Offset = "0xE5AC24", VA = "0xE5AC24")]
		public DATATYPE_ENTITYCALL()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class DATATYPE_BLOB : DATATYPE_BASE
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE5A534", Offset = "0xE5A534", VA = "0xE5A534", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE5A55C", Offset = "0xE5A55C", VA = "0xE5A55C", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xE5A5F8", Offset = "0xE5A5F8", VA = "0xE5A5F8", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xE5A64C", Offset = "0xE5A64C", VA = "0xE5A64C", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xE5A714", Offset = "0xE5A714", VA = "0xE5A714")]
		public DATATYPE_BLOB()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class DATATYPE_ARRAY : DATATYPE_BASE
	{
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public object vtype;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE599CC", Offset = "0xE599CC", VA = "0xE599CC", Slot = "4")]
		public override void bind()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE59CD0", Offset = "0xE59CD0", VA = "0xE59CD0", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE59D6C", Offset = "0xE59D6C", VA = "0xE59D6C", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xE59ED4", Offset = "0xE59ED4", VA = "0xE59ED4", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE59F28", Offset = "0xE59F28", VA = "0xE59F28", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xE5A320", Offset = "0xE5A320", VA = "0xE5A320")]
		public DATATYPE_ARRAY()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class DATATYPE_FIXED_DICT : DATATYPE_BASE
	{
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string implementedBy;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Dictionary<string, object> dicttype;

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xE5ACF8", Offset = "0xE5ACF8", VA = "0xE5ACF8", Slot = "4")]
		public override void bind()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xE5B1E0", Offset = "0xE5B1E0", VA = "0xE5B1E0", Slot = "5")]
		public override object createFromStream(MemoryStream stream)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE5B3A0", Offset = "0xE5B3A0", VA = "0xE5B3A0", Slot = "6")]
		public override void addToStream(Bundle stream, object v)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE5B50C", Offset = "0xE5B50C", VA = "0xE5B50C", Slot = "7")]
		public override object parseDefaultValStr(string v)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE5B84C", Offset = "0xE5B84C", VA = "0xE5B84C", Slot = "8")]
		public override bool isSameType(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xE5BC44", Offset = "0xE5BC44", VA = "0xE5BC44")]
		public DATATYPE_FIXED_DICT()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public enum DEBUGLEVEL
	{
		[Token(Token = "0x4000091")]
		DEBUG,
		[Token(Token = "0x4000092")]
		INFO,
		[Token(Token = "0x4000093")]
		WARNING,
		[Token(Token = "0x4000094")]
		ERROR,
		[Token(Token = "0x4000095")]
		NOLOG
	}
	[Token(Token = "0x2000024")]
	public class Dbg
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static DEBUGLEVEL debugLevel;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE5EE90", Offset = "0xE5EE90", VA = "0xE5EE90")]
		public static string getHead()
		{
			return null;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE5EF9C", Offset = "0xE5EF9C", VA = "0xE5EF9C")]
		public static void INFO_MSG(object s)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE5F0C0", Offset = "0xE5F0C0", VA = "0xE5F0C0")]
		public static void DEBUG_MSG(object s)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE5F1E4", Offset = "0xE5F1E4", VA = "0xE5F1E4")]
		public static void WARNING_MSG(object s)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE56C98", Offset = "0xE56C98", VA = "0xE56C98")]
		public static void ERROR_MSG(object s)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE5F308", Offset = "0xE5F308", VA = "0xE5F308")]
		public static void profileStart(string name)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE5F30C", Offset = "0xE5F30C", VA = "0xE5F30C")]
		public static void profileEnd(string name)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE5F310", Offset = "0xE5F310", VA = "0xE5F310")]
		public Dbg()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public abstract class EncryptionFilter
	{
		[Token(Token = "0x600010B")]
		public abstract void encrypt(MemoryStream stream);

		[Token(Token = "0x600010C")]
		public abstract void decrypt(MemoryStream stream);

		[Token(Token = "0x600010D")]
		public abstract void decrypt(byte[] buffer, int startIndex, int length);

		[Token(Token = "0x600010E")]
		public abstract bool send(PacketSenderBase sender, MemoryStream stream);

		[Token(Token = "0x600010F")]
		public abstract bool recv(MessageReaderBase reader, byte[] buffer, uint rpos, uint len);

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xE57FA4", Offset = "0xE57FA4", VA = "0xE57FA4")]
		protected EncryptionFilter()
		{
		}
	}
	[Token(Token = "0x2000026")]
	internal class BlowfishFilter : EncryptionFilter
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Blowfish _blowfish;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private MemoryStream _packet;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MemoryStream _enctyptStrem;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private UINT8 _padSize;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		private ushort _packLen;

		[Token(Token = "0x400009C")]
		private const uint BLOCK_SIZE = 8u;

		[Token(Token = "0x400009D")]
		private const uint MIN_PACKET_SIZE = 11u;

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xE57EB4", Offset = "0xE57EB4", VA = "0xE57EB4")]
		public BlowfishFilter()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xE57FAC", Offset = "0xE57FAC", VA = "0xE57FAC", Slot = "1")]
		~BlowfishFilter()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xE57FB4", Offset = "0xE57FB4", VA = "0xE57FB4")]
		public byte[] key()
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE57FD4", Offset = "0xE57FD4", VA = "0xE57FD4", Slot = "4")]
		public override void encrypt(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE584DC", Offset = "0xE584DC", VA = "0xE584DC", Slot = "5")]
		public override void decrypt(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE58558", Offset = "0xE58558", VA = "0xE58558", Slot = "6")]
		public override void decrypt(byte[] buffer, int startIndex, int length)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE5859C", Offset = "0xE5859C", VA = "0xE5859C", Slot = "7")]
		public override bool send(PacketSenderBase sender, MemoryStream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE58694", Offset = "0xE58694", VA = "0xE58694", Slot = "8")]
		public override bool recv(MessageReaderBase reader, byte[] buffer, uint rpos, uint len)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000027")]
	public class Entity
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 _entityLastLocalPos;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 _entityLastLocalDir;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int id;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public string className;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 direction;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float velocity;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool isOnGround;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public object renderObj;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool inWorld;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool isControlled;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool inited;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE5F3F4", Offset = "0xE5F3F4", VA = "0xE5F3F4")]
		public static void clear()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE543F8", Offset = "0xE543F8", VA = "0xE543F8")]
		public Entity()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE5F3F8", Offset = "0xE5F3F8", VA = "0xE5F3F8")]
		public void destroy()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE5F430", Offset = "0xE5F430", VA = "0xE5F430", Slot = "4")]
		public virtual void onDestroy()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE56458", Offset = "0xE56458", VA = "0xE56458")]
		public bool isPlayer()
		{
			return default(bool);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE5F434", Offset = "0xE5F434", VA = "0xE5F434", Slot = "5")]
		public virtual void onRemoteMethodCall(MemoryStream stream)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE5F438", Offset = "0xE5F438", VA = "0xE5F438", Slot = "6")]
		public virtual void onUpdatePropertys(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE5F43C", Offset = "0xE5F43C", VA = "0xE5F43C", Slot = "7")]
		public virtual void onGetBase()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE5F440", Offset = "0xE5F440", VA = "0xE5F440", Slot = "8")]
		public virtual void onGetCell()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE5F444", Offset = "0xE5F444", VA = "0xE5F444", Slot = "9")]
		public virtual void onLoseCell()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE5F448", Offset = "0xE5F448", VA = "0xE5F448", Slot = "10")]
		public virtual void onComponentsEnterworld()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE5F44C", Offset = "0xE5F44C", VA = "0xE5F44C", Slot = "11")]
		public virtual void onComponentsLeaveworld()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xE5F450", Offset = "0xE5F450", VA = "0xE5F450", Slot = "12")]
		public virtual EntityCall getBaseEntityCall()
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE5F458", Offset = "0xE5F458", VA = "0xE5F458", Slot = "13")]
		public virtual EntityCall getCellEntityCall()
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xE5F460", Offset = "0xE5F460", VA = "0xE5F460", Slot = "14")]
		public virtual void __init__()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE5F464", Offset = "0xE5F464", VA = "0xE5F464", Slot = "15")]
		public virtual void callPropertysSetMethods()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE5F468", Offset = "0xE5F468", VA = "0xE5F468", Slot = "16")]
		public virtual void attachComponents()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE5F46C", Offset = "0xE5F46C", VA = "0xE5F46C", Slot = "17")]
		public virtual void detachComponents()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE5F470", Offset = "0xE5F470", VA = "0xE5F470")]
		public void baseCall(string methodname, params object[] arguments)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE6075C", Offset = "0xE6075C", VA = "0xE6075C")]
		public void cellCall(string methodname, params object[] arguments)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE6179C", Offset = "0xE6179C", VA = "0xE6179C")]
		public void enterWorld()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xE61AA4", Offset = "0xE61AA4", VA = "0xE61AA4", Slot = "18")]
		public virtual void onEnterWorld()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE61AA8", Offset = "0xE61AA8", VA = "0xE61AA8")]
		public void leaveWorld()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE61D14", Offset = "0xE61D14", VA = "0xE61D14", Slot = "19")]
		public virtual void onLeaveWorld()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE61D18", Offset = "0xE61D18", VA = "0xE61D18", Slot = "20")]
		public virtual void enterSpace()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE62090", Offset = "0xE62090", VA = "0xE62090", Slot = "21")]
		public virtual void onEnterSpace()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE62094", Offset = "0xE62094", VA = "0xE62094", Slot = "22")]
		public virtual void leaveSpace()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE622EC", Offset = "0xE622EC", VA = "0xE622EC", Slot = "23")]
		public virtual void onLeaveSpace()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE622F0", Offset = "0xE622F0", VA = "0xE622F0", Slot = "24")]
		public virtual void onPositionChanged(Vector3 oldValue)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE62494", Offset = "0xE62494", VA = "0xE62494", Slot = "25")]
		public virtual void onUpdateVolatileData()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE62498", Offset = "0xE62498", VA = "0xE62498", Slot = "26")]
		public virtual void onDirectionChanged(Vector3 oldValue)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE62618", Offset = "0xE62618", VA = "0xE62618", Slot = "27")]
		public virtual void onControlled(bool isControlled_)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class EntityCall
	{
		[Token(Token = "0x2000029")]
		public enum ENTITYCALL_TYPE
		{
			[Token(Token = "0x40000AF")]
			ENTITYCALL_TYPE_CELL,
			[Token(Token = "0x40000B0")]
			ENTITYCALL_TYPE_BASE
		}

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string className;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ENTITYCALL_TYPE type;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Bundle bundle;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE6261C", Offset = "0xE6261C", VA = "0xE6261C")]
		public EntityCall(int eid, string ename)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE6312C", Offset = "0xE6312C", VA = "0xE6312C", Slot = "4")]
		public virtual void __init__()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE63130", Offset = "0xE63130", VA = "0xE63130", Slot = "5")]
		public virtual bool isBase()
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE63144", Offset = "0xE63144", VA = "0xE63144", Slot = "6")]
		public virtual bool isCell()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE6047C", Offset = "0xE6047C", VA = "0xE6047C")]
		public Bundle newCall()
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE60690", Offset = "0xE60690", VA = "0xE60690")]
		public void sendCall(Bundle inbundle)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE62718", Offset = "0xE62718", VA = "0xE62718")]
		public Bundle newCall(string methodName, ushort entitycomponentPropertyID = 0)
		{
			return null;
		}
	}
	[Token(Token = "0x200002A")]
	public class EntityBaseEntityCall_AccountBase : EntityCall
	{
		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE54524", Offset = "0xE54524", VA = "0xE54524")]
		public EntityBaseEntityCall_AccountBase(int eid, string ename)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE626A4", Offset = "0xE626A4", VA = "0xE626A4")]
		public void onGameInitFinish()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE62C58", Offset = "0xE62C58", VA = "0xE62C58")]
		public void regAbortGaming()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE62CCC", Offset = "0xE62CCC", VA = "0xE62CCC")]
		public void regAbortMatching()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE62D40", Offset = "0xE62D40", VA = "0xE62D40")]
		public void regBuyEquip(int arg1)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE62DD4", Offset = "0xE62DD4", VA = "0xE62DD4")]
		public void regChangeEquip(int arg1)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE62E68", Offset = "0xE62E68", VA = "0xE62E68")]
		public void regContinueGaming()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xE62EDC", Offset = "0xE62EDC", VA = "0xE62EDC")]
		public void regGetGold(int arg1)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE62F70", Offset = "0xE62F70", VA = "0xE62F70")]
		public void regMapSection(int arg1)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE63004", Offset = "0xE63004", VA = "0xE63004")]
		public void regStartMatching(int arg1, int arg2, int arg3)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class EntityCellEntityCall_AccountBase : EntityCall
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0xE545C4", Offset = "0xE545C4", VA = "0xE545C4")]
		public EntityCellEntityCall_AccountBase(int eid, string ename)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE63154", Offset = "0xE63154", VA = "0xE63154")]
		public void regChangeEquipment(int arg1, List<int> arg2)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE63318", Offset = "0xE63318", VA = "0xE63318")]
		public void regDefaultEquipment(int arg1)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE633AC", Offset = "0xE633AC", VA = "0xE633AC")]
		public void regGetProps(string arg1, int arg2)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE63460", Offset = "0xE63460", VA = "0xE63460")]
		public void regProgress(int arg1)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE634F4", Offset = "0xE634F4", VA = "0xE634F4")]
		public void regPropResult(int arg1, int arg2, int arg3, byte arg4)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE635E8", Offset = "0xE635E8", VA = "0xE635E8")]
		public void regReachDestination()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE6365C", Offset = "0xE6365C", VA = "0xE6365C")]
		public void regRemoveProp(int arg1)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE636F0", Offset = "0xE636F0", VA = "0xE636F0")]
		public void regUseProp(int arg1, int arg2)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class EntityBaseEntityCall_HallsBase : EntityCall
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE630D8", Offset = "0xE630D8", VA = "0xE630D8")]
		public EntityBaseEntityCall_HallsBase(int eid, string ename)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class EntityCellEntityCall_HallsBase : EntityCall
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE637A4", Offset = "0xE637A4", VA = "0xE637A4")]
		public EntityCellEntityCall_HallsBase(int eid, string ename)
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class EntityBaseEntityCall_RobotBase : EntityCall
	{
		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE630F4", Offset = "0xE630F4", VA = "0xE630F4")]
		public EntityBaseEntityCall_RobotBase(int eid, string ename)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class EntityCellEntityCall_RobotBase : EntityCall
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE637C0", Offset = "0xE637C0", VA = "0xE637C0")]
		public EntityCellEntityCall_RobotBase(int eid, string ename)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE637DC", Offset = "0xE637DC", VA = "0xE637DC")]
		public void onControlledBy(byte[] arg1)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE63868", Offset = "0xE63868", VA = "0xE63868")]
		public void regGetProps(string arg1, int arg2)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE6391C", Offset = "0xE6391C", VA = "0xE6391C")]
		public void regPropResult(int arg1, int arg2, int arg3, byte arg4)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE63A10", Offset = "0xE63A10", VA = "0xE63A10")]
		public void regReachDestination()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE63A84", Offset = "0xE63A84", VA = "0xE63A84")]
		public void regUseProp(int arg1, int arg2)
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class EntityBaseEntityCall_RoomBase : EntityCall
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE63110", Offset = "0xE63110", VA = "0xE63110")]
		public EntityBaseEntityCall_RoomBase(int eid, string ename)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class EntityCellEntityCall_RoomBase : EntityCall
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE63B38", Offset = "0xE63B38", VA = "0xE63B38")]
		public EntityCellEntityCall_RoomBase(int eid, string ename)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class EntityComponent
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort entityComponentPropertyID;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort componentType;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int ownerID;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Entity owner;

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE63B54", Offset = "0xE63B54", VA = "0xE63B54", Slot = "4")]
		public virtual void onAttached(Entity ownerEntity)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE63B58", Offset = "0xE63B58", VA = "0xE63B58", Slot = "5")]
		public virtual void onDetached(Entity ownerEntity)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE63B5C", Offset = "0xE63B5C", VA = "0xE63B5C", Slot = "6")]
		public virtual void onEnterworld()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE63B60", Offset = "0xE63B60", VA = "0xE63B60", Slot = "7")]
		public virtual void onLeaveworld()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE63B64", Offset = "0xE63B64", VA = "0xE63B64", Slot = "8")]
		public virtual ScriptModule getScriptModule()
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE63B6C", Offset = "0xE63B6C", VA = "0xE63B6C", Slot = "9")]
		public virtual void onRemoteMethodCall(ushort methodUtype, MemoryStream stream)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE63B70", Offset = "0xE63B70", VA = "0xE63B70", Slot = "10")]
		public virtual void onUpdatePropertys(ushort propUtype, MemoryStream stream, int maxCount)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE63B74", Offset = "0xE63B74", VA = "0xE63B74", Slot = "11")]
		public virtual void callPropertysSetMethods()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE63B78", Offset = "0xE63B78", VA = "0xE63B78", Slot = "12")]
		public virtual void createFromStream(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE63C40", Offset = "0xE63C40", VA = "0xE63C40")]
		public EntityComponent()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class EntityDef
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, ushort> datatype2id;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Dictionary<string, DATATYPE_BASE> datatypes;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<ushort, DATATYPE_BASE> id2datatypes;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static Dictionary<string, int> entityclass;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Dictionary<string, ScriptModule> moduledefs;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static Dictionary<ushort, ScriptModule> idmoduledefs;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE63C48", Offset = "0xE63C48", VA = "0xE63C48")]
		public static bool init()
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE6E234", Offset = "0xE6E234", VA = "0xE6E234")]
		public static bool reset()
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE6E2A8", Offset = "0xE6E2A8", VA = "0xE6E2A8")]
		public static void clear()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE63CC0", Offset = "0xE63CC0", VA = "0xE63CC0")]
		public static void initDataTypes()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE66448", Offset = "0xE66448", VA = "0xE66448")]
		public static void initScriptModules()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE645B4", Offset = "0xE645B4", VA = "0xE645B4")]
		public static void initDefTypes()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE6E490", Offset = "0xE6E490", VA = "0xE6E490")]
		public EntityDef()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class EventOutTypes
	{
		[Token(Token = "0x40000BB")]
		public const string onKicked = "onKicked";

		[Token(Token = "0x40000BC")]
		public const string onDisconnected = "onDisconnected";

		[Token(Token = "0x40000BD")]
		public const string onConnectionState = "onConnectionState";

		[Token(Token = "0x40000BE")]
		public const string onCreateAccountResult = "onCreateAccountResult";

		[Token(Token = "0x40000BF")]
		public const string onVersionNotMatch = "onVersionNotMatch";

		[Token(Token = "0x40000C0")]
		public const string onScriptVersionNotMatch = "onScriptVersionNotMatch";

		[Token(Token = "0x40000C1")]
		public const string onLoginFailed = "onLoginFailed";

		[Token(Token = "0x40000C2")]
		public const string onLoginBaseapp = "onLoginBaseapp";

		[Token(Token = "0x40000C3")]
		public const string onLoginBaseappFailed = "onLoginBaseappFailed";

		[Token(Token = "0x40000C4")]
		public const string onReloginBaseapp = "onReloginBaseapp";

		[Token(Token = "0x40000C5")]
		public const string onReloginBaseappSuccessfully = "onReloginBaseappSuccessfully";

		[Token(Token = "0x40000C6")]
		public const string onReloginBaseappFailed = "onReloginBaseappFailed";

		[Token(Token = "0x40000C7")]
		public const string onEnterWorld = "onEnterWorld";

		[Token(Token = "0x40000C8")]
		public const string onLeaveWorld = "onLeaveWorld";

		[Token(Token = "0x40000C9")]
		public const string onEnterSpace = "onEnterSpace";

		[Token(Token = "0x40000CA")]
		public const string onLeaveSpace = "onLeaveSpace";

		[Token(Token = "0x40000CB")]
		public const string set_position = "set_position";

		[Token(Token = "0x40000CC")]
		public const string set_direction = "set_direction";

		[Token(Token = "0x40000CD")]
		public const string updatePosition = "updatePosition";

		[Token(Token = "0x40000CE")]
		public const string addSpaceGeometryMapping = "addSpaceGeometryMapping";

		[Token(Token = "0x40000CF")]
		public const string onSetSpaceData = "onSetSpaceData";

		[Token(Token = "0x40000D0")]
		public const string onDelSpaceData = "onDelSpaceData";

		[Token(Token = "0x40000D1")]
		public const string onControlled = "onControlled";

		[Token(Token = "0x40000D2")]
		public const string onLoseControlledEntity = "onLoseControlledEntity";

		[Token(Token = "0x40000D3")]
		public const string onStreamDataStarted = "onStreamDataStarted";

		[Token(Token = "0x40000D4")]
		public const string onStreamDataRecv = "onStreamDataRecv";

		[Token(Token = "0x40000D5")]
		public const string onStreamDataCompleted = "onStreamDataCompleted";

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE891C0", Offset = "0xE891C0", VA = "0xE891C0")]
		public EventOutTypes()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class EventInTypes
	{
		[Token(Token = "0x40000D6")]
		public const string createAccount = "createAccount";

		[Token(Token = "0x40000D7")]
		public const string login = "login";

		[Token(Token = "0x40000D8")]
		public const string logout = "logout";

		[Token(Token = "0x40000D9")]
		public const string reloginBaseapp = "reloginBaseapp";

		[Token(Token = "0x40000DA")]
		public const string resetPassword = "resetPassword";

		[Token(Token = "0x40000DB")]
		public const string newPassword = "newPassword";

		[Token(Token = "0x40000DC")]
		public const string bindAccountEmail = "bindAccountEmail";

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE891B8", Offset = "0xE891B8", VA = "0xE891B8")]
		public EventInTypes()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class Event
	{
		[Token(Token = "0x2000037")]
		public struct Pair
		{
			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public object obj;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public string funcname;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public MethodInfo method;
		}

		[Token(Token = "0x2000038")]
		public struct EventObj
		{
			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Pair info;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public string eventname;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object[] args;
		}

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, List<Pair>> events_out;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static bool outEventsImmediately;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static LinkedList<EventObj> firedEvents_out;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static LinkedList<EventObj> doingEvents_out;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<string, List<Pair>> events_in;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static LinkedList<EventObj> firedEvents_in;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static LinkedList<EventObj> doingEvents_in;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static bool _isPauseOut;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE6E738", Offset = "0xE6E738", VA = "0xE6E738")]
		public Event()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE6E740", Offset = "0xE6E740", VA = "0xE6E740")]
		public static void clear()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE6E810", Offset = "0xE6E810", VA = "0xE6E810")]
		public static void clearFiredEvents()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xE6EA94", Offset = "0xE6EA94", VA = "0xE6EA94")]
		public static void pause()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE6EB0C", Offset = "0xE6EB0C", VA = "0xE6EB0C")]
		public static void resume()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE6F428", Offset = "0xE6F428", VA = "0xE6F428")]
		public static bool isPause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE6E974", Offset = "0xE6E974", VA = "0xE6E974")]
		public static void monitor_Enter(object obj)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE6EA04", Offset = "0xE6EA04", VA = "0xE6EA04")]
		public static void monitor_Exit(object obj)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE6F49C", Offset = "0xE6F49C", VA = "0xE6F49C")]
		public static bool hasRegisterOut(string eventname)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE6F5DC", Offset = "0xE6F5DC", VA = "0xE6F5DC")]
		public static bool hasRegisterIn(string eventname)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE6F51C", Offset = "0xE6F51C", VA = "0xE6F51C")]
		private static bool _hasRegister(Dictionary<string, List<Pair>> events, string eventname)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xE6F65C", Offset = "0xE6F65C", VA = "0xE6F65C")]
		public static bool registerOut(string eventname, object obj, string funcname)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xE6FCC4", Offset = "0xE6FCC4", VA = "0xE6FCC4")]
		public static bool registerOut(string eventname, Action handler)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		public static bool registerOut<T1>(string eventname, Action<T1> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		public static bool registerOut<T1, T2>(string eventname, Action<T1, T2> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		public static bool registerOut<T1, T2, T3>(string eventname, Action<T1, T2, T3> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		public static bool registerOut<T1, T2, T3, T4>(string eventname, Action<T1, T2, T3, T4> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xE6FD98", Offset = "0xE6FD98", VA = "0xE6FD98")]
		public static bool registerIn(string eventname, object obj, string funcname)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE6FE30", Offset = "0xE6FE30", VA = "0xE6FE30")]
		public static bool registerIn(string eventname, Action handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		public static bool registerIn<T1>(string eventname, Action<T1> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		public static bool registerIn<T1, T2>(string eventname, Action<T1, T2> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		public static bool registerIn<T1, T2, T3>(string eventname, Action<T1, T2, T3> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		public static bool registerIn<T1, T2, T3, T4>(string eventname, Action<T1, T2, T3, T4> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xE6F6F4", Offset = "0xE6F6F4", VA = "0xE6F6F4")]
		private static bool register(Dictionary<string, List<Pair>> events, string eventname, object obj, string funcname)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE70140", Offset = "0xE70140", VA = "0xE70140")]
		public static bool deregisterOut(string eventname, object obj, string funcname)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE70280", Offset = "0xE70280", VA = "0xE70280")]
		public static bool deregisterOut(string eventname, Action handler)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE70354", Offset = "0xE70354", VA = "0xE70354")]
		public static bool deregisterIn(string eventname, object obj, string funcname)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE70494", Offset = "0xE70494", VA = "0xE70494")]
		public static bool deregisterIn(string eventname, Action handler)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xE6FF04", Offset = "0xE6FF04", VA = "0xE6FF04")]
		private static bool deregister(Dictionary<string, List<Pair>> events, string eventname, object obj, string funcname)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE70568", Offset = "0xE70568", VA = "0xE70568")]
		public static bool deregisterOut(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE708E0", Offset = "0xE708E0", VA = "0xE708E0")]
		public static bool deregisterIn(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE706A0", Offset = "0xE706A0", VA = "0xE706A0")]
		private static bool deregister(Dictionary<string, List<Pair>> events, object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE61A08", Offset = "0xE61A08", VA = "0xE61A08")]
		public static void fireOut(string eventname, params object[] args)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE711B8", Offset = "0xE711B8", VA = "0xE711B8")]
		public static void fireIn(string eventname, params object[] args)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE71254", Offset = "0xE71254", VA = "0xE71254")]
		public static void fireAll(string eventname, params object[] args)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE70A18", Offset = "0xE70A18", VA = "0xE70A18")]
		private static void fire_(Dictionary<string, List<Pair>> events, LinkedList<EventObj> firedEvents, string eventname, object[] args, bool eventsImmediately)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE6EB88", Offset = "0xE6EB88", VA = "0xE6EB88")]
		public static void processOutEvents()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE71310", Offset = "0xE71310", VA = "0xE71310")]
		public static void processInEvents()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE7096C", Offset = "0xE7096C", VA = "0xE7096C")]
		public static void removeAllFiredEventIn(object obj)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE705F4", Offset = "0xE705F4", VA = "0xE705F4")]
		public static void removeAllFiredEventOut(object obj)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE703FC", Offset = "0xE703FC", VA = "0xE703FC")]
		public static void removeFiredEventIn(object obj, string eventname, string funcname)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE701E8", Offset = "0xE701E8", VA = "0xE701E8")]
		public static void removeFiredEventOut(object obj, string eventname, string funcname)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE71B80", Offset = "0xE71B80", VA = "0xE71B80")]
		public static void removeFiredEvent(LinkedList<EventObj> firedEvents, object obj, string eventname = "", string funcname = "")
		{
		}
	}
	[Token(Token = "0x2000039")]
	public abstract class HallsBase : Entity
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public EntityBaseEntityCall_HallsBase baseEntityCall;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public EntityCellEntityCall_HallsBase cellEntityCall;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE8920C", Offset = "0xE8920C", VA = "0xE8920C")]
		public HallsBase()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE89214", Offset = "0xE89214", VA = "0xE89214", Slot = "10")]
		public override void onComponentsEnterworld()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE89218", Offset = "0xE89218", VA = "0xE89218", Slot = "11")]
		public override void onComponentsLeaveworld()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE8921C", Offset = "0xE8921C", VA = "0xE8921C", Slot = "7")]
		public override void onGetBase()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE8929C", Offset = "0xE8929C", VA = "0xE8929C", Slot = "8")]
		public override void onGetCell()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE8931C", Offset = "0xE8931C", VA = "0xE8931C", Slot = "9")]
		public override void onLoseCell()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE8932C", Offset = "0xE8932C", VA = "0xE8932C", Slot = "12")]
		public override EntityCall getBaseEntityCall()
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE89334", Offset = "0xE89334", VA = "0xE89334", Slot = "13")]
		public override EntityCall getCellEntityCall()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE8933C", Offset = "0xE8933C", VA = "0xE8933C", Slot = "16")]
		public override void attachComponents()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE89340", Offset = "0xE89340", VA = "0xE89340", Slot = "17")]
		public override void detachComponents()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE89344", Offset = "0xE89344", VA = "0xE89344", Slot = "5")]
		public override void onRemoteMethodCall(MemoryStream stream)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE895D8", Offset = "0xE895D8", VA = "0xE895D8", Slot = "6")]
		public override void onUpdatePropertys(MemoryStream stream)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE8996C", Offset = "0xE8996C", VA = "0xE8996C", Slot = "15")]
		public override void callPropertysSetMethods()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public struct UINT8
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte value;

		[Token(Token = "0x17000001")]
		public static byte MaxValue
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xED5A18", Offset = "0xED5A18", VA = "0xED5A18")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000002")]
		public static byte MinValue
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xED5A20", Offset = "0xED5A20", VA = "0xED5A20")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xED5A04", Offset = "0xED5A04", VA = "0xED5A04")]
		private UINT8(byte value)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xED5A0C", Offset = "0xED5A0C", VA = "0xED5A0C")]
		public static implicit operator byte(UINT8 value)
		{
			return default(byte);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xED5A14", Offset = "0xED5A14", VA = "0xED5A14")]
		public static implicit operator UINT8(byte value)
		{
			return default(UINT8);
		}
	}
	[Token(Token = "0x200003B")]
	public struct UINT16
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort value;

		[Token(Token = "0x17000003")]
		public static ushort MaxValue
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xED5998", Offset = "0xED5998", VA = "0xED5998")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000004")]
		public static ushort MinValue
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xED59A0", Offset = "0xED59A0", VA = "0xED59A0")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xED5984", Offset = "0xED5984", VA = "0xED5984")]
		private UINT16(ushort value)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xED598C", Offset = "0xED598C", VA = "0xED598C")]
		public static implicit operator ushort(UINT16 value)
		{
			return default(ushort);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xED5994", Offset = "0xED5994", VA = "0xED5994")]
		public static implicit operator UINT16(ushort value)
		{
			return default(UINT16);
		}
	}
	[Token(Token = "0x200003C")]
	public struct UINT64
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong value;

		[Token(Token = "0x17000005")]
		public static ulong MaxValue
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xED59EC", Offset = "0xED59EC", VA = "0xED59EC")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000006")]
		public static ulong MinValue
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xED59F8", Offset = "0xED59F8", VA = "0xED59F8")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xED59C8", Offset = "0xED59C8", VA = "0xED59C8")]
		private UINT64(ulong value)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xED59D8", Offset = "0xED59D8", VA = "0xED59D8")]
		public static implicit operator ulong(UINT64 value)
		{
			return default(ulong);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xED59DC", Offset = "0xED59DC", VA = "0xED59DC")]
		public static implicit operator UINT64(ulong value)
		{
			return default(UINT64);
		}
	}
	[Token(Token = "0x200003D")]
	public struct UINT32
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint value;

		[Token(Token = "0x17000007")]
		public static uint MaxValue
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xED59B8", Offset = "0xED59B8", VA = "0xED59B8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000008")]
		public static uint MinValue
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xED59C0", Offset = "0xED59C0", VA = "0xED59C0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xED59A8", Offset = "0xED59A8", VA = "0xED59A8")]
		private UINT32(uint value)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xED59B0", Offset = "0xED59B0", VA = "0xED59B0")]
		public static implicit operator uint(UINT32 value)
		{
			return default(uint);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xED59B4", Offset = "0xED59B4", VA = "0xED59B4")]
		public static implicit operator UINT32(uint value)
		{
			return default(UINT32);
		}
	}
	[Token(Token = "0x200003E")]
	public struct INT8
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private sbyte value;

		[Token(Token = "0x17000009")]
		public static sbyte MaxValue
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xE89C9C", Offset = "0xE89C9C", VA = "0xE89C9C")]
			get
			{
				return default(sbyte);
			}
		}

		[Token(Token = "0x1700000A")]
		public static sbyte MinValue
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xE89CA4", Offset = "0xE89CA4", VA = "0xE89CA4")]
			get
			{
				return default(sbyte);
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE89C88", Offset = "0xE89C88", VA = "0xE89C88")]
		private INT8(sbyte value)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE89C90", Offset = "0xE89C90", VA = "0xE89C90")]
		public static implicit operator sbyte(INT8 value)
		{
			return default(sbyte);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE89C98", Offset = "0xE89C98", VA = "0xE89C98")]
		public static implicit operator INT8(sbyte value)
		{
			return default(INT8);
		}
	}
	[Token(Token = "0x200003F")]
	public struct INT16
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private short value;

		[Token(Token = "0x1700000B")]
		public static short MaxValue
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xE89C18", Offset = "0xE89C18", VA = "0xE89C18")]
			get
			{
				return default(short);
			}
		}

		[Token(Token = "0x1700000C")]
		public static short MinValue
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xE89C20", Offset = "0xE89C20", VA = "0xE89C20")]
			get
			{
				return default(short);
			}
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE89C04", Offset = "0xE89C04", VA = "0xE89C04")]
		private INT16(short value)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE89C0C", Offset = "0xE89C0C", VA = "0xE89C0C")]
		public static implicit operator short(INT16 value)
		{
			return default(short);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE89C14", Offset = "0xE89C14", VA = "0xE89C14")]
		public static implicit operator INT16(short value)
		{
			return default(INT16);
		}
	}
	[Token(Token = "0x2000040")]
	public struct INT32
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int value;

		[Token(Token = "0x1700000D")]
		public static int MaxValue
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xE89C3C", Offset = "0xE89C3C", VA = "0xE89C3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700000E")]
		public static int MinValue
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xE89C44", Offset = "0xE89C44", VA = "0xE89C44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE89C2C", Offset = "0xE89C2C", VA = "0xE89C2C")]
		private INT32(int value)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE89C34", Offset = "0xE89C34", VA = "0xE89C34")]
		public static implicit operator int(INT32 value)
		{
			return default(int);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE89C38", Offset = "0xE89C38", VA = "0xE89C38")]
		public static implicit operator INT32(int value)
		{
			return default(INT32);
		}
	}
	[Token(Token = "0x2000041")]
	public struct INT64
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private long value;

		[Token(Token = "0x1700000F")]
		public static long MaxValue
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xE89C70", Offset = "0xE89C70", VA = "0xE89C70")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000010")]
		public static long MinValue
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xE89C7C", Offset = "0xE89C7C", VA = "0xE89C7C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE89C4C", Offset = "0xE89C4C", VA = "0xE89C4C")]
		private INT64(long value)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE89C5C", Offset = "0xE89C5C", VA = "0xE89C5C")]
		public static implicit operator long(INT64 value)
		{
			return default(long);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE89C60", Offset = "0xE89C60", VA = "0xE89C60")]
		public static implicit operator INT64(long value)
		{
			return default(INT64);
		}
	}
	[Token(Token = "0x2000042")]
	public struct STRING
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string value;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xED3418", Offset = "0xED3418", VA = "0xED3418")]
		private STRING(string value)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xED3420", Offset = "0xED3420", VA = "0xED3420")]
		public static implicit operator string(STRING value)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xED3424", Offset = "0xED3424", VA = "0xED3424")]
		public static implicit operator STRING(string value)
		{
			return default(STRING);
		}
	}
	[Token(Token = "0x2000043")]
	public struct UNICODE
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string value;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xED5A28", Offset = "0xED5A28", VA = "0xED5A28")]
		private UNICODE(string value)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xED5A30", Offset = "0xED5A30", VA = "0xED5A30")]
		public static implicit operator string(UNICODE value)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xED5A34", Offset = "0xED5A34", VA = "0xED5A34")]
		public static implicit operator UNICODE(string value)
		{
			return default(UNICODE);
		}
	}
	[Token(Token = "0x2000044")]
	public struct FLOAT
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float value;

		[Token(Token = "0x17000011")]
		public static float MaxValue
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0xE891D8", Offset = "0xE891D8", VA = "0xE891D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public static float MinValue
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE891E4", Offset = "0xE891E4", VA = "0xE891E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE891C8", Offset = "0xE891C8", VA = "0xE891C8")]
		private FLOAT(float value)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE891D0", Offset = "0xE891D0", VA = "0xE891D0")]
		public static implicit operator float(FLOAT value)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xE891D4", Offset = "0xE891D4", VA = "0xE891D4")]
		public static implicit operator FLOAT(float value)
		{
			return default(FLOAT);
		}
	}
	[Token(Token = "0x2000045")]
	public struct DOUBLE
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double value;

		[Token(Token = "0x17000013")]
		public static double MaxValue
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xE5EE60", Offset = "0xE5EE60", VA = "0xE5EE60")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000014")]
		public static double MinValue
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xE5EE78", Offset = "0xE5EE78", VA = "0xE5EE78")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xE5EE3C", Offset = "0xE5EE3C", VA = "0xE5EE3C")]
		private DOUBLE(double value)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE5EE4C", Offset = "0xE5EE4C", VA = "0xE5EE4C")]
		public static implicit operator double(DOUBLE value)
		{
			return default(double);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE5EE50", Offset = "0xE5EE50", VA = "0xE5EE50")]
		public static implicit operator DOUBLE(double value)
		{
			return default(DOUBLE);
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2C1A8C", Offset = "0x2C1A8C")]
	public struct PYTHON
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] value;

		[Token(Token = "0x17000015")]
		public byte Item
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xECEB9C", Offset = "0xECEB9C", VA = "0xECEB9C")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xECEBDC", Offset = "0xECEBDC", VA = "0xECEBDC")]
			set
			{
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xECEB68", Offset = "0xECEB68", VA = "0xECEB68")]
		private PYTHON(byte[] value)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xECEB70", Offset = "0xECEB70", VA = "0xECEB70")]
		public static implicit operator byte[](PYTHON value)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xECEB74", Offset = "0xECEB74", VA = "0xECEB74")]
		public static implicit operator PYTHON(byte[] value)
		{
			return default(PYTHON);
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2C1AC0", Offset = "0x2C1AC0")]
	public struct PY_DICT
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] value;

		[Token(Token = "0x17000016")]
		public byte Item
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xECEC54", Offset = "0xECEC54", VA = "0xECEC54")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xECEC94", Offset = "0xECEC94", VA = "0xECEC94")]
			set
			{
			}
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xECEC20", Offset = "0xECEC20", VA = "0xECEC20")]
		private PY_DICT(byte[] value)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xECEC28", Offset = "0xECEC28", VA = "0xECEC28")]
		public static implicit operator byte[](PY_DICT value)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xECEC2C", Offset = "0xECEC2C", VA = "0xECEC2C")]
		public static implicit operator PY_DICT(byte[] value)
		{
			return default(PY_DICT);
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2C1AF4", Offset = "0x2C1AF4")]
	public struct PY_TUPLE
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] value;

		[Token(Token = "0x17000017")]
		public byte Item
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xECEDC4", Offset = "0xECEDC4", VA = "0xECEDC4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xECEE04", Offset = "0xECEE04", VA = "0xECEE04")]
			set
			{
			}
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xECED90", Offset = "0xECED90", VA = "0xECED90")]
		private PY_TUPLE(byte[] value)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xECED98", Offset = "0xECED98", VA = "0xECED98")]
		public static implicit operator byte[](PY_TUPLE value)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xECED9C", Offset = "0xECED9C", VA = "0xECED9C")]
		public static implicit operator PY_TUPLE(byte[] value)
		{
			return default(PY_TUPLE);
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2C1B28", Offset = "0x2C1B28")]
	public struct PY_LIST
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] value;

		[Token(Token = "0x17000018")]
		public byte Item
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xECED0C", Offset = "0xECED0C", VA = "0xECED0C")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xECED4C", Offset = "0xECED4C", VA = "0xECED4C")]
			set
			{
			}
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xECECD8", Offset = "0xECECD8", VA = "0xECECD8")]
		private PY_LIST(byte[] value)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xECECE0", Offset = "0xECECE0", VA = "0xECECE0")]
		public static implicit operator byte[](PY_LIST value)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xECECE4", Offset = "0xECECE4", VA = "0xECECE4")]
		public static implicit operator PY_LIST(byte[] value)
		{
			return default(PY_LIST);
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2C1B5C", Offset = "0x2C1B5C")]
	public struct ENTITYCALL
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] value;

		[Token(Token = "0x17000019")]
		public byte Item
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xE5F350", Offset = "0xE5F350", VA = "0xE5F350")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xE5F390", Offset = "0xE5F390", VA = "0xE5F390")]
			set
			{
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE5F31C", Offset = "0xE5F31C", VA = "0xE5F31C")]
		private ENTITYCALL(byte[] value)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE5F324", Offset = "0xE5F324", VA = "0xE5F324")]
		public static implicit operator byte[](ENTITYCALL value)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE5F328", Offset = "0xE5F328", VA = "0xE5F328")]
		public static implicit operator ENTITYCALL(byte[] value)
		{
			return default(ENTITYCALL);
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2C1B90", Offset = "0x2C1B90")]
	public struct BLOB
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte[] value;

		[Token(Token = "0x1700001A")]
		public byte Item
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xE56524", Offset = "0xE56524", VA = "0xE56524")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0xE56564", Offset = "0xE56564", VA = "0xE56564")]
			set
			{
			}
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE564F0", Offset = "0xE564F0", VA = "0xE564F0")]
		private BLOB(byte[] value)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE564F8", Offset = "0xE564F8", VA = "0xE564F8")]
		public static implicit operator byte[](BLOB value)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE564FC", Offset = "0xE564FC", VA = "0xE564FC")]
		public static implicit operator BLOB(byte[] value)
		{
			return default(BLOB);
		}
	}
	[Token(Token = "0x200004C")]
	public struct VECTOR2
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector2 value;

		[Token(Token = "0x1700001B")]
		public float x
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xED5A74", Offset = "0xED5A74", VA = "0xED5A74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0xED5A7C", Offset = "0xED5A7C", VA = "0xED5A7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float y
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xED5A84", Offset = "0xED5A84", VA = "0xED5A84")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xED5A8C", Offset = "0xED5A8C", VA = "0xED5A8C")]
			set
			{
			}
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xED5A5C", Offset = "0xED5A5C", VA = "0xED5A5C")]
		private VECTOR2(Vector2 value)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xED5A64", Offset = "0xED5A64", VA = "0xED5A64")]
		public static implicit operator Vector2(VECTOR2 value)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xED5A6C", Offset = "0xED5A6C", VA = "0xED5A6C")]
		public static implicit operator VECTOR2(Vector2 value)
		{
			return default(VECTOR2);
		}
	}
	[Token(Token = "0x200004D")]
	public struct VECTOR3
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 value;

		[Token(Token = "0x1700001D")]
		public float x
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0xED5AAC", Offset = "0xED5AAC", VA = "0xED5AAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xED5AB4", Offset = "0xED5AB4", VA = "0xED5AB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public float y
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xED5ABC", Offset = "0xED5ABC", VA = "0xED5ABC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0xED5AC4", Offset = "0xED5AC4", VA = "0xED5AC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public float z
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xED5ACC", Offset = "0xED5ACC", VA = "0xED5ACC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0xED5AD4", Offset = "0xED5AD4", VA = "0xED5AD4")]
			set
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xED5A94", Offset = "0xED5A94", VA = "0xED5A94")]
		private VECTOR3(Vector3 value)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xED5A9C", Offset = "0xED5A9C", VA = "0xED5A9C")]
		public static implicit operator Vector3(VECTOR3 value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xED5AA4", Offset = "0xED5AA4", VA = "0xED5AA4")]
		public static implicit operator VECTOR3(Vector3 value)
		{
			return default(VECTOR3);
		}
	}
	[Token(Token = "0x200004E")]
	public struct VECTOR4
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector4 value;

		[Token(Token = "0x17000020")]
		public float x
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xED5B00", Offset = "0xED5B00", VA = "0xED5B00")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xED5B08", Offset = "0xED5B08", VA = "0xED5B08")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public float y
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0xED5B10", Offset = "0xED5B10", VA = "0xED5B10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0xED5B18", Offset = "0xED5B18", VA = "0xED5B18")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public float z
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0xED5B20", Offset = "0xED5B20", VA = "0xED5B20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xED5B28", Offset = "0xED5B28", VA = "0xED5B28")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public float w
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0xED5B30", Offset = "0xED5B30", VA = "0xED5B30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xED5B38", Offset = "0xED5B38", VA = "0xED5B38")]
			set
			{
			}
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xED5ADC", Offset = "0xED5ADC", VA = "0xED5ADC")]
		private VECTOR4(Vector4 value)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xED5AE8", Offset = "0xED5AE8", VA = "0xED5AE8")]
		public static implicit operator Vector4(VECTOR4 value)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xED5AF4", Offset = "0xED5AF4", VA = "0xED5AF4")]
		public static implicit operator VECTOR4(Vector4 value)
		{
			return default(VECTOR4);
		}
	}
	[Token(Token = "0x200004F")]
	public struct SUC
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte value;

		[Token(Token = "0x17000024")]
		public static byte MaxValue
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xED3460", Offset = "0xED3460", VA = "0xED3460")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000025")]
		public static byte MinValue
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xED3468", Offset = "0xED3468", VA = "0xED3468")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xED344C", Offset = "0xED344C", VA = "0xED344C")]
		private SUC(byte value)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xED3454", Offset = "0xED3454", VA = "0xED3454")]
		public static implicit operator byte(SUC value)
		{
			return default(byte);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xED345C", Offset = "0xED345C", VA = "0xED345C")]
		public static implicit operator SUC(byte value)
		{
			return default(SUC);
		}
	}
	[Token(Token = "0x2000050")]
	public struct DBID
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong value;

		[Token(Token = "0x17000026")]
		public static ulong MaxValue
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0xE5EDDC", Offset = "0xE5EDDC", VA = "0xE5EDDC")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000027")]
		public static ulong MinValue
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xE5EDE8", Offset = "0xE5EDE8", VA = "0xE5EDE8")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE5EDB8", Offset = "0xE5EDB8", VA = "0xE5EDB8")]
		private DBID(ulong value)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE5EDC8", Offset = "0xE5EDC8", VA = "0xE5EDC8")]
		public static implicit operator ulong(DBID value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE5EDCC", Offset = "0xE5EDCC", VA = "0xE5EDCC")]
		public static implicit operator DBID(ulong value)
		{
			return default(DBID);
		}
	}
	[Token(Token = "0x2000051")]
	public struct GOLD_NUM
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int value;

		[Token(Token = "0x17000028")]
		public static int MaxValue
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xE891FC", Offset = "0xE891FC", VA = "0xE891FC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000029")]
		public static int MinValue
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xE89204", Offset = "0xE89204", VA = "0xE89204")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE891EC", Offset = "0xE891EC", VA = "0xE891EC")]
		private GOLD_NUM(int value)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE891F4", Offset = "0xE891F4", VA = "0xE891F4")]
		public static implicit operator int(GOLD_NUM value)
		{
			return default(int);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE891F8", Offset = "0xE891F8", VA = "0xE891F8")]
		public static implicit operator GOLD_NUM(int value)
		{
			return default(GOLD_NUM);
		}
	}
	[Token(Token = "0x2000052")]
	public struct ENTITY_ID
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int value;

		[Token(Token = "0x1700002A")]
		public static int MaxValue
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xE5F3E4", Offset = "0xE5F3E4", VA = "0xE5F3E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		public static int MinValue
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0xE5F3EC", Offset = "0xE5F3EC", VA = "0xE5F3EC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE5F3D4", Offset = "0xE5F3D4", VA = "0xE5F3D4")]
		private ENTITY_ID(int value)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE5F3DC", Offset = "0xE5F3DC", VA = "0xE5F3DC")]
		public static implicit operator int(ENTITY_ID value)
		{
			return default(int);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE5F3E0", Offset = "0xE5F3E0", VA = "0xE5F3E0")]
		public static implicit operator ENTITY_ID(int value)
		{
			return default(ENTITY_ID);
		}
	}
	[Token(Token = "0x2000053")]
	public struct POSITION3D
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 value;

		[Token(Token = "0x1700002C")]
		public float x
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0xECEA50", Offset = "0xECEA50", VA = "0xECEA50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0xECEA58", Offset = "0xECEA58", VA = "0xECEA58")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public float y
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0xECEA60", Offset = "0xECEA60", VA = "0xECEA60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xECEA68", Offset = "0xECEA68", VA = "0xECEA68")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public float z
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xECEA70", Offset = "0xECEA70", VA = "0xECEA70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000238")]
			[Address(RVA = "0xECEA78", Offset = "0xECEA78", VA = "0xECEA78")]
			set
			{
			}
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xECEA38", Offset = "0xECEA38", VA = "0xECEA38")]
		private POSITION3D(Vector3 value)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xECEA40", Offset = "0xECEA40", VA = "0xECEA40")]
		public static implicit operator Vector3(POSITION3D value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xECEA48", Offset = "0xECEA48", VA = "0xECEA48")]
		public static implicit operator POSITION3D(Vector3 value)
		{
			return default(POSITION3D);
		}
	}
	[Token(Token = "0x2000054")]
	public struct DIRECTION3D
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector3 value;

		[Token(Token = "0x1700002F")]
		public float x
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0xE5EE0C", Offset = "0xE5EE0C", VA = "0xE5EE0C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xE5EE14", Offset = "0xE5EE14", VA = "0xE5EE14")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public float y
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xE5EE1C", Offset = "0xE5EE1C", VA = "0xE5EE1C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xE5EE24", Offset = "0xE5EE24", VA = "0xE5EE24")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public float z
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0xE5EE2C", Offset = "0xE5EE2C", VA = "0xE5EE2C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xE5EE34", Offset = "0xE5EE34", VA = "0xE5EE34")]
			set
			{
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE5EDF4", Offset = "0xE5EDF4", VA = "0xE5EDF4")]
		private DIRECTION3D(Vector3 value)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE5EDFC", Offset = "0xE5EDFC", VA = "0xE5EDFC")]
		public static implicit operator Vector3(DIRECTION3D value)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE5EE04", Offset = "0xE5EE04", VA = "0xE5EE04")]
		public static implicit operator DIRECTION3D(Vector3 value)
		{
			return default(DIRECTION3D);
		}
	}
	[Token(Token = "0x2000055")]
	public struct SPACE_KEY
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong value;

		[Token(Token = "0x17000032")]
		public static ulong MaxValue
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0xED3400", Offset = "0xED3400", VA = "0xED3400")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000033")]
		public static ulong MinValue
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xED340C", Offset = "0xED340C", VA = "0xED340C")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xED33DC", Offset = "0xED33DC", VA = "0xED33DC")]
		private SPACE_KEY(ulong value)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xED33EC", Offset = "0xED33EC", VA = "0xED33EC")]
		public static implicit operator ulong(SPACE_KEY value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xED33F0", Offset = "0xED33F0", VA = "0xED33F0")]
		public static implicit operator SPACE_KEY(ulong value)
		{
			return default(SPACE_KEY);
		}
	}
	[Token(Token = "0x2000056")]
	public struct ROOM_NUM
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ulong value;

		[Token(Token = "0x17000034")]
		public static ulong MaxValue
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xED1704", Offset = "0xED1704", VA = "0xED1704")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000035")]
		public static ulong MinValue
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0xED1710", Offset = "0xED1710", VA = "0xED1710")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xED16E0", Offset = "0xED16E0", VA = "0xED16E0")]
		private ROOM_NUM(ulong value)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xED16F0", Offset = "0xED16F0", VA = "0xED16F0")]
		public static implicit operator ulong(ROOM_NUM value)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xED16F4", Offset = "0xED16F4", VA = "0xED16F4")]
		public static implicit operator ROOM_NUM(ulong value)
		{
			return default(ROOM_NUM);
		}
	}
	[Token(Token = "0x2000057")]
	public struct MAP_NUM
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int value;

		[Token(Token = "0x17000036")]
		public static int MaxValue
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0xEA0924", Offset = "0xEA0924", VA = "0xEA0924")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000037")]
		public static int MinValue
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xEA092C", Offset = "0xEA092C", VA = "0xEA092C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xEA0914", Offset = "0xEA0914", VA = "0xEA0914")]
		private MAP_NUM(int value)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xEA091C", Offset = "0xEA091C", VA = "0xEA091C")]
		public static implicit operator int(MAP_NUM value)
		{
			return default(int);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xEA0920", Offset = "0xEA0920", VA = "0xEA0920")]
		public static implicit operator MAP_NUM(int value)
		{
			return default(MAP_NUM);
		}
	}
	[Token(Token = "0x2000058")]
	public struct MODE_NUM
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int value;

		[Token(Token = "0x17000038")]
		public static int MaxValue
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0xEA0964", Offset = "0xEA0964", VA = "0xEA0964")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000039")]
		public static int MinValue
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0xEA096C", Offset = "0xEA096C", VA = "0xEA096C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xEA0954", Offset = "0xEA0954", VA = "0xEA0954")]
		private MODE_NUM(int value)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xEA095C", Offset = "0xEA095C", VA = "0xEA095C")]
		public static implicit operator int(MODE_NUM value)
		{
			return default(int);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xEA0960", Offset = "0xEA0960", VA = "0xEA0960")]
		public static implicit operator MODE_NUM(int value)
		{
			return default(MODE_NUM);
		}
	}
	[Token(Token = "0x2000059")]
	public struct MATCH_CODE
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int value;

		[Token(Token = "0x1700003A")]
		public static int MaxValue
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0xEA0944", Offset = "0xEA0944", VA = "0xEA0944")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		public static int MinValue
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xEA094C", Offset = "0xEA094C", VA = "0xEA094C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xEA0934", Offset = "0xEA0934", VA = "0xEA0934")]
		private MATCH_CODE(int value)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xEA093C", Offset = "0xEA093C", VA = "0xEA093C")]
		public static implicit operator int(MATCH_CODE value)
		{
			return default(int);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xEA0940", Offset = "0xEA0940", VA = "0xEA0940")]
		public static implicit operator MATCH_CODE(int value)
		{
			return default(MATCH_CODE);
		}
	}
	[Token(Token = "0x200005A")]
	public struct PROP_TYPE
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int value;

		[Token(Token = "0x1700003C")]
		public static int MaxValue
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xECEB58", Offset = "0xECEB58", VA = "0xECEB58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		public static int MinValue
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0xECEB60", Offset = "0xECEB60", VA = "0xECEB60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xECEB48", Offset = "0xECEB48", VA = "0xECEB48")]
		private PROP_TYPE(int value)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xECEB50", Offset = "0xECEB50", VA = "0xECEB50")]
		public static implicit operator int(PROP_TYPE value)
		{
			return default(int);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xECEB54", Offset = "0xECEB54", VA = "0xECEB54")]
		public static implicit operator PROP_TYPE(int value)
		{
			return default(PROP_TYPE);
		}
	}
	[Token(Token = "0x200005B")]
	public struct PROP_KEY
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string value;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xECEA80", Offset = "0xECEA80", VA = "0xECEA80")]
		private PROP_KEY(string value)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xECEA88", Offset = "0xECEA88", VA = "0xECEA88")]
		public static implicit operator string(PROP_KEY value)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xECEA8C", Offset = "0xECEA8C", VA = "0xECEA8C")]
		public static implicit operator PROP_KEY(string value)
		{
			return default(PROP_KEY);
		}
	}
	[Token(Token = "0x200005C")]
	public class PROP_LIST : List<string>
	{
		[Token(Token = "0x6000263")]
		[Address(RVA = "0xECEAB4", Offset = "0xECEAB4", VA = "0xECEAB4")]
		public PROP_LIST()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public struct ITEM_ID
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int value;

		[Token(Token = "0x1700003E")]
		public static int MaxValue
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xE89CBC", Offset = "0xE89CBC", VA = "0xE89CBC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		public static int MinValue
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xE89CC4", Offset = "0xE89CC4", VA = "0xE89CC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE89CAC", Offset = "0xE89CAC", VA = "0xE89CAC")]
		private ITEM_ID(int value)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE89CB4", Offset = "0xE89CB4", VA = "0xE89CB4")]
		public static implicit operator int(ITEM_ID value)
		{
			return default(int);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xE89CB8", Offset = "0xE89CB8", VA = "0xE89CB8")]
		public static implicit operator ITEM_ID(int value)
		{
			return default(ITEM_ID);
		}
	}
	[Token(Token = "0x200005E")]
	public class ITEM_LIST : List<int>
	{
		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE89CCC", Offset = "0xE89CCC", VA = "0xE89CCC")]
		public ITEM_LIST()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class EQUIP_DICT
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int head;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int clothes;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int hand;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int shoe;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int bag;

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE543F0", Offset = "0xE543F0", VA = "0xE543F0")]
		public EQUIP_DICT()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class KBEngineApp
	{
		[Token(Token = "0x2000061")]
		public enum CLIENT_TYPE
		{
			[Token(Token = "0x400013D")]
			CLIENT_TYPE_MOBILE = 1,
			[Token(Token = "0x400013E")]
			CLIENT_TYPE_WIN,
			[Token(Token = "0x400013F")]
			CLIENT_TYPE_LINUX,
			[Token(Token = "0x4000140")]
			CLIENT_TYPE_MAC,
			[Token(Token = "0x4000141")]
			CLIENT_TYPE_BROWSER,
			[Token(Token = "0x4000142")]
			CLIENT_TYPE_BOTS,
			[Token(Token = "0x4000143")]
			CLIENT_TYPE_MINI
		}

		[Token(Token = "0x2000062")]
		public enum NETWORK_ENCRYPT_TYPE
		{
			[Token(Token = "0x4000145")]
			ENCRYPT_TYPE_NONE,
			[Token(Token = "0x4000146")]
			ENCRYPT_TYPE_BLOWFISH
		}

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static KBEngineApp app;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private NetworkInterfaceBase _networkInterface;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public KBEngineArgs _args;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string username;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string password;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string baseappIP;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ushort baseappTcpPort;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public ushort baseappUdpPort;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string currserver;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public string currstate;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] _serverdatas;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private byte[] _clientdatas;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] _encryptedKey;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public string serverVersion;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string clientVersion;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public string serverScriptVersion;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string clientScriptVersion;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public string serverProtocolMD5;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string serverEntitydefMD5;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ulong entity_uuid;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int entity_id;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public string entity_type;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Entity> _controlledEntities;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 _entityServerPos;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Dictionary<string, string> _spacedatas;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Dictionary<int, Entity> entities;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<int> _entityIDAliasIDList;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Dictionary<int, MemoryStream> _bufferedCreateEntityMessages;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ServerErrorDescrs _serverErrs;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DateTime _lastTickTime;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DateTime _lastTickCBTime;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DateTime _lastUpdateToServerTime;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _updatePlayerToServerPeroid;

		[Token(Token = "0x4000136")]
		private const int _1MS_TO_100NS = 10000;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private EncryptionFilter _filter;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public uint spaceID;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public string spaceResPath;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool isLoadedGeometry;

		[Token(Token = "0x400013B")]
		public const string component = "client";

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE8A398", Offset = "0xE8A398", VA = "0xE8A398")]
		public KBEngineApp(KBEngineArgs args)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE8B0B0", Offset = "0xE8B0B0", VA = "0xE8B0B0")]
		public static KBEngineApp getSingleton()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xE8B1B0", Offset = "0xE8B1B0", VA = "0xE8B1B0", Slot = "4")]
		public virtual bool initialize(KBEngineArgs args)
		{
			return default(bool);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xE8B26C", Offset = "0xE8B26C", VA = "0xE8B26C")]
		private void initNetwork()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xE8B334", Offset = "0xE8B334", VA = "0xE8B334")]
		private void installEvents()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xE8B520", Offset = "0xE8B520", VA = "0xE8B520")]
		public KBEngineArgs getInitArgs()
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xE8B528", Offset = "0xE8B528", VA = "0xE8B528", Slot = "5")]
		public virtual void destroy()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE8B9D4", Offset = "0xE8B9D4", VA = "0xE8B9D4")]
		public NetworkInterfaceBase networkInterface()
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xE8B9DC", Offset = "0xE8B9DC", VA = "0xE8B9DC")]
		public byte[] serverdatas()
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE8B9E4", Offset = "0xE8B9E4", VA = "0xE8B9E4")]
		public void entityServerPos(Vector3 pos)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE8B894", Offset = "0xE8B894", VA = "0xE8B894")]
		public void resetMessages()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xE8B9F0", Offset = "0xE8B9F0", VA = "0xE8B9F0", Slot = "6")]
		public virtual void reset()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xE8C0C4", Offset = "0xE8C0C4", VA = "0xE8C0C4")]
		public static bool validEmail(string strEmail)
		{
			return default(bool);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xE8C15C", Offset = "0xE8C15C", VA = "0xE8C15C", Slot = "7")]
		public virtual void process()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xE8C744", Offset = "0xE8C744", VA = "0xE8C744")]
		public Entity player()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE8C7D4", Offset = "0xE8C7D4", VA = "0xE8C7D4")]
		public void _closeNetwork(NetworkInterfaceBase networkInterface)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE8C1F4", Offset = "0xE8C1F4", VA = "0xE8C1F4")]
		public void sendTick()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE8D2CC", Offset = "0xE8D2CC", VA = "0xE8D2CC")]
		public void Client_onAppActiveTickCB()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE8D354", Offset = "0xE8D354", VA = "0xE8D354")]
		public void hello()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE8D728", Offset = "0xE8D728", VA = "0xE8D728")]
		public void Client_onHelloCB(MemoryStream stream)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE8E484", Offset = "0xE8E484", VA = "0xE8E484")]
		public void Client_onImportServerErrorsDescr(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE8E488", Offset = "0xE8E488", VA = "0xE8E488")]
		public void Client_onImportClientMessages(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE8E48C", Offset = "0xE8E48C", VA = "0xE8E48C")]
		public void Client_onImportClientEntityDef(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE8E490", Offset = "0xE8E490", VA = "0xE8E490")]
		public void Client_onImportClientSDK(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE8E83C", Offset = "0xE8E83C", VA = "0xE8E83C")]
		public void Client_onVersionNotMatch(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE8EC84", Offset = "0xE8EC84", VA = "0xE8EC84")]
		public void Client_onScriptVersionNotMatch(MemoryStream stream)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE8F0CC", Offset = "0xE8F0CC", VA = "0xE8F0CC")]
		public void Client_onKicked(ushort failedcode)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE8F52C", Offset = "0xE8F52C", VA = "0xE8F52C")]
		public void login(string username, string password, byte[] datas)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE8F63C", Offset = "0xE8F63C", VA = "0xE8F63C")]
		public void login_loginapp(bool noconnect)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE8FA08", Offset = "0xE8FA08", VA = "0xE8FA08")]
		private void onConnectTo_loginapp_callback(string ip, int port, bool success, object userData)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE8E3F0", Offset = "0xE8E3F0", VA = "0xE8E3F0")]
		private void onLogin_loginapp()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE8FC3C", Offset = "0xE8FC3C", VA = "0xE8FC3C")]
		public void login_baseapp(bool noconnect)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE900BC", Offset = "0xE900BC", VA = "0xE900BC")]
		private void onConnectTo_baseapp_callback(string ip, int port, bool success, object userData)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE8E35C", Offset = "0xE8E35C", VA = "0xE8E35C")]
		private void onLogin_baseapp()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE902F0", Offset = "0xE902F0", VA = "0xE902F0")]
		public void reloginBaseapp()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE90654", Offset = "0xE90654", VA = "0xE90654")]
		private void onReConnectTo_baseapp_callback(string ip, int port, bool success, object userData)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE8B6AC", Offset = "0xE8B6AC", VA = "0xE8B6AC")]
		public void logout()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE8F4FC", Offset = "0xE8F4FC", VA = "0xE8F4FC")]
		public string serverErr(ushort id)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE90A18", Offset = "0xE90A18", VA = "0xE90A18")]
		public void onOpenLoginapp_resetpassword()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE90DF4", Offset = "0xE90DF4", VA = "0xE90DF4")]
		public void resetPassword(string username)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE90B6C", Offset = "0xE90B6C", VA = "0xE90B6C")]
		public void resetpassword_loginapp(bool noconnect)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE90E98", Offset = "0xE90E98", VA = "0xE90E98")]
		private void onConnectTo_resetpassword_callback(string ip, int port, bool success, object userData)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE91064", Offset = "0xE91064", VA = "0xE91064")]
		public void Client_onReqAccountResetPasswordCB(ushort failcode)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE914C4", Offset = "0xE914C4", VA = "0xE914C4")]
		public void bindAccountEmail(string emailAddress)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE916BC", Offset = "0xE916BC", VA = "0xE916BC")]
		public void Client_onReqAccountBindEmailCB(ushort failcode)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE91B1C", Offset = "0xE91B1C", VA = "0xE91B1C")]
		public void newPassword(string old_password, string new_password)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE91D14", Offset = "0xE91D14", VA = "0xE91D14")]
		public void Client_onReqAccountNewPasswordCB(ushort failcode)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE92174", Offset = "0xE92174", VA = "0xE92174")]
		public void createAccount(string username, string password, byte[] datas)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE92284", Offset = "0xE92284", VA = "0xE92284")]
		public void createAccount_loginapp(bool noconnect)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE925B0", Offset = "0xE925B0", VA = "0xE925B0")]
		public void onOpenLoginapp_createAccount()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE92704", Offset = "0xE92704", VA = "0xE92704")]
		private void onConnectTo_createAccount_callback(string ip, int port, bool success, object userData)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE8E358", Offset = "0xE8E358", VA = "0xE8E358")]
		public void onServerDigest()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE928D0", Offset = "0xE928D0", VA = "0xE928D0")]
		public void Client_onLoginFailed(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE92E44", Offset = "0xE92E44", VA = "0xE92E44")]
		public void Client_onLoginSuccessfully(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE9349C", Offset = "0xE9349C", VA = "0xE9349C")]
		public void Client_onLoginBaseappFailed(ushort failedcode)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE938CC", Offset = "0xE938CC", VA = "0xE938CC")]
		public void Client_onReloginBaseappFailed(ushort failedcode)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE93CFC", Offset = "0xE93CFC", VA = "0xE93CFC")]
		public void Client_onReloginBaseappSuccessfully(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE93F8C", Offset = "0xE93F8C", VA = "0xE93F8C")]
		public void Client_onCreatedProxies(ulong rndUUID, int eid, string entityType)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE947EC", Offset = "0xE947EC", VA = "0xE947EC")]
		public Entity findEntity(int entityID)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE9487C", Offset = "0xE9487C", VA = "0xE9487C")]
		public int getViewEntityIDFromStream(MemoryStream stream)
		{
			return default(int);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE94988", Offset = "0xE94988", VA = "0xE94988")]
		public void Client_onUpdatePropertysOptimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE94718", Offset = "0xE94718", VA = "0xE94718")]
		public void Client_onUpdatePropertys(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE949B0", Offset = "0xE949B0", VA = "0xE949B0")]
		public void onUpdatePropertys_(int eid, MemoryStream stream)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE94C80", Offset = "0xE94C80", VA = "0xE94C80")]
		public void Client_onRemoteMethodCallOptimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE94E0C", Offset = "0xE94E0C", VA = "0xE94E0C")]
		public void Client_onRemoteMethodCall(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE94CA8", Offset = "0xE94CA8", VA = "0xE94CA8")]
		public void onRemoteMethodCall_(int eid, MemoryStream stream)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE94E44", Offset = "0xE94E44", VA = "0xE94E44")]
		public void Client_onEntityEnterWorld(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE9584C", Offset = "0xE9584C", VA = "0xE9584C")]
		public void Client_onEntityLeaveWorldOptimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE958F0", Offset = "0xE958F0", VA = "0xE958F0")]
		public void Client_onEntityLeaveWorld(int eid)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE95D3C", Offset = "0xE95D3C", VA = "0xE95D3C")]
		public void Client_onEntityEnterSpace(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE95F64", Offset = "0xE95F64", VA = "0xE95F64")]
		public void Client_onEntityLeaveSpace(int eid)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE960CC", Offset = "0xE960CC", VA = "0xE960CC")]
		public void Client_onCreateAccountResult(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE966E8", Offset = "0xE966E8", VA = "0xE966E8")]
		public void Client_onControlEntity(int eid, sbyte isControlled)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE8C808", Offset = "0xE8C808", VA = "0xE8C808")]
		public void updatePlayerToServer()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE96C04", Offset = "0xE96C04", VA = "0xE96C04")]
		public void addSpaceGeometryMapping(uint uspaceID, string respath)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE95C80", Offset = "0xE95C80", VA = "0xE95C80")]
		public void clearSpace(bool isall)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE8BCD8", Offset = "0xE8BCD8", VA = "0xE8BCD8")]
		public void clearEntities(bool isall)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE97000", Offset = "0xE97000", VA = "0xE97000")]
		public void Client_initSpaceData(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE973A4", Offset = "0xE973A4", VA = "0xE973A4")]
		public void Client_setSpaceData(uint spaceID, string key, string value)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE979A8", Offset = "0xE979A8", VA = "0xE979A8")]
		public void Client_delSpaceData(uint spaceID, string key)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xE97E44", Offset = "0xE97E44", VA = "0xE97E44")]
		public string getSpaceData(string key)
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE97EF4", Offset = "0xE97EF4", VA = "0xE97EF4")]
		public void Client_onEntityDestroyed(int eid)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE9828C", Offset = "0xE9828C", VA = "0xE9828C")]
		public void Client_onUpdateBasePos(float x, float y, float z)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE98410", Offset = "0xE98410", VA = "0xE98410")]
		public void Client_onUpdateBasePosXZ(float x, float z)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xE9858C", Offset = "0xE9858C", VA = "0xE9858C")]
		public void Client_onUpdateBaseDir(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xE98804", Offset = "0xE98804", VA = "0xE98804")]
		public void Client_onUpdateData(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xE98948", Offset = "0xE98948", VA = "0xE98948")]
		public void Client_onSetEntityPosAndDir(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xE98D3C", Offset = "0xE98D3C", VA = "0xE98D3C")]
		public void Client_onUpdateData_ypr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xE995FC", Offset = "0xE995FC", VA = "0xE995FC")]
		public void Client_onUpdateData_yp(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xE99708", Offset = "0xE99708", VA = "0xE99708")]
		public void Client_onUpdateData_yr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xE99814", Offset = "0xE99814", VA = "0xE99814")]
		public void Client_onUpdateData_pr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xE99920", Offset = "0xE99920", VA = "0xE99920")]
		public void Client_onUpdateData_y(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xE99A0C", Offset = "0xE99A0C", VA = "0xE99A0C")]
		public void Client_onUpdateData_p(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xE99AF8", Offset = "0xE99AF8", VA = "0xE99AF8")]
		public void Client_onUpdateData_r(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xE99BE4", Offset = "0xE99BE4", VA = "0xE99BE4")]
		public void Client_onUpdateData_xz(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xE99CF0", Offset = "0xE99CF0", VA = "0xE99CF0")]
		public void Client_onUpdateData_xz_ypr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xE99E4C", Offset = "0xE99E4C", VA = "0xE99E4C")]
		public void Client_onUpdateData_xz_yp(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xE99F90", Offset = "0xE99F90", VA = "0xE99F90")]
		public void Client_onUpdateData_xz_yr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xE9A0D4", Offset = "0xE9A0D4", VA = "0xE9A0D4")]
		public void Client_onUpdateData_xz_pr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xE9A218", Offset = "0xE9A218", VA = "0xE9A218")]
		public void Client_onUpdateData_xz_y(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xE9A340", Offset = "0xE9A340", VA = "0xE9A340")]
		public void Client_onUpdateData_xz_p(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xE9A468", Offset = "0xE9A468", VA = "0xE9A468")]
		public void Client_onUpdateData_xz_r(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xE9A590", Offset = "0xE9A590", VA = "0xE9A590")]
		public void Client_onUpdateData_xyz(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xE9A6B4", Offset = "0xE9A6B4", VA = "0xE9A6B4")]
		public void Client_onUpdateData_xyz_ypr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xE9A7B4", Offset = "0xE9A7B4", VA = "0xE9A7B4")]
		public void Client_onUpdateData_xyz_yp(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xE9A910", Offset = "0xE9A910", VA = "0xE9A910")]
		public void Client_onUpdateData_xyz_yr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xE9AA6C", Offset = "0xE9AA6C", VA = "0xE9AA6C")]
		public void Client_onUpdateData_xyz_pr(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xE9ABC8", Offset = "0xE9ABC8", VA = "0xE9ABC8")]
		public void Client_onUpdateData_xyz_y(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE9AD08", Offset = "0xE9AD08", VA = "0xE9AD08")]
		public void Client_onUpdateData_xyz_p(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xE9AE48", Offset = "0xE9AE48", VA = "0xE9AE48")]
		public void Client_onUpdateData_xyz_r(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xE9AF88", Offset = "0xE9AF88", VA = "0xE9AF88")]
		public void Client_onUpdateData_ypr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xE9B0BC", Offset = "0xE9B0BC", VA = "0xE9B0BC")]
		public void Client_onUpdateData_yp_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xE9B1CC", Offset = "0xE9B1CC", VA = "0xE9B1CC")]
		public void Client_onUpdateData_yr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xE9B2DC", Offset = "0xE9B2DC", VA = "0xE9B2DC")]
		public void Client_onUpdateData_pr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xE9B3EC", Offset = "0xE9B3EC", VA = "0xE9B3EC")]
		public void Client_onUpdateData_y_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xE9B4D4", Offset = "0xE9B4D4", VA = "0xE9B4D4")]
		public void Client_onUpdateData_p_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xE9B5BC", Offset = "0xE9B5BC", VA = "0xE9B5BC")]
		public void Client_onUpdateData_r_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xE9B6A4", Offset = "0xE9B6A4", VA = "0xE9B6A4")]
		public void Client_onUpdateData_xz_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xE9B850", Offset = "0xE9B850", VA = "0xE9B850")]
		public void Client_onUpdateData_xz_ypr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xE9B9EC", Offset = "0xE9B9EC", VA = "0xE9B9EC")]
		public void Client_onUpdateData_xz_yp_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xE9BB70", Offset = "0xE9BB70", VA = "0xE9BB70")]
		public void Client_onUpdateData_xz_yr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xE9BCF4", Offset = "0xE9BCF4", VA = "0xE9BCF4")]
		public void Client_onUpdateData_xz_pr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xE9BE78", Offset = "0xE9BE78", VA = "0xE9BE78")]
		public void Client_onUpdateData_xz_y_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xE9BFD8", Offset = "0xE9BFD8", VA = "0xE9BFD8")]
		public void Client_onUpdateData_xz_p_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xE9C138", Offset = "0xE9C138", VA = "0xE9C138")]
		public void Client_onUpdateData_xz_r_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xE9C298", Offset = "0xE9C298", VA = "0xE9C298")]
		public void Client_onUpdateData_xyz_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xE9C454", Offset = "0xE9C454", VA = "0xE9C454")]
		public void Client_onUpdateData_xyz_ypr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xE9C5C8", Offset = "0xE9C5C8", VA = "0xE9C5C8")]
		public void Client_onUpdateData_xyz_yp_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xE9C798", Offset = "0xE9C798", VA = "0xE9C798")]
		public void Client_onUpdateData_xyz_yr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xE9C968", Offset = "0xE9C968", VA = "0xE9C968")]
		public void Client_onUpdateData_xyz_pr_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xE9CB38", Offset = "0xE9CB38", VA = "0xE9CB38")]
		public void Client_onUpdateData_xyz_y_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xE9CCE0", Offset = "0xE9CCE0", VA = "0xE9CCE0")]
		public void Client_onUpdateData_xyz_p_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xE9CE88", Offset = "0xE9CE88", VA = "0xE9CE88")]
		public void Client_onUpdateData_xyz_r_optimized(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xE98E64", Offset = "0xE98E64", VA = "0xE98E64")]
		private void _updateVolatileData(int entityID, float x, float y, float z, float yaw, float pitch, float roll, sbyte isOnGround, bool isOptimized)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xE9D030", Offset = "0xE9D030", VA = "0xE9D030")]
		public void Client_onStreamDataStarted(short id, uint datasize, string descr)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xE9D26C", Offset = "0xE9D26C", VA = "0xE9D26C")]
		public void Client_onStreamDataRecv(MemoryStream stream)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xE9D4E0", Offset = "0xE9D4E0", VA = "0xE9D4E0")]
		public void Client_onStreamDataCompleted(short id)
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class KBEngineAppThread : KBEngineApp
	{
		[Token(Token = "0x2000064")]
		public class KBEThread
		{
			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private KBEngineApp app_;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool over;

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xED5B40", Offset = "0xED5B40", VA = "0xED5B40")]
			public KBEThread(KBEngineApp app)
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xED5B6C", Offset = "0xED5B6C", VA = "0xED5B6C")]
			public void run()
			{
			}
		}

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Thread _t;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public KBEThread kbethread;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int threadUpdateHZ;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float threadUpdatePeriod;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool _isbreak;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private DateTime _lasttime;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xE8A2C4", Offset = "0xE8A2C4", VA = "0xE8A2C4")]
		public KBEngineAppThread(KBEngineArgs args)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xE9D640", Offset = "0xE9D640", VA = "0xE9D640", Slot = "4")]
		public override bool initialize(KBEngineArgs args)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xE9D7FC", Offset = "0xE9D7FC", VA = "0xE9D7FC", Slot = "6")]
		public override void reset()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xE9D894", Offset = "0xE9D894", VA = "0xE9D894")]
		public void breakProcess()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xE9D8A0", Offset = "0xE9D8A0", VA = "0xE9D8A0")]
		public bool isbreak()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xE9D8A8", Offset = "0xE9D8A8", VA = "0xE9D8A8", Slot = "7")]
		public override void process()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xE9D960", Offset = "0xE9D960", VA = "0xE9D960")]
		private void _thread_wait()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xE9DAEC", Offset = "0xE9DAEC", VA = "0xE9DAEC", Slot = "5")]
		public override void destroy()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class KBEngineArgs
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string ip;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int port;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public KBEngineApp.CLIENT_TYPE clientType;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public KBEngineApp.NETWORK_ENCRYPT_TYPE networkEncryptType;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int syncPlayerMS;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useAliasEntityID;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isOnInitCallPropertysSetMethods;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint TCP_SEND_BUFFER_MAX;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint UDP_SEND_BUFFER_MAX;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint TCP_RECV_BUFFER_MAX;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public uint UDP_RECV_BUFFER_MAX;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isMultiThreads;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int threadUpdateHZ;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool forceDisableUDP;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int serverHeartbeatTick;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xE9DC70", Offset = "0xE9DC70", VA = "0xE9DC70")]
		public int getTCPRecvBufferSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xE9DC78", Offset = "0xE9DC78", VA = "0xE9DC78")]
		public int getTCPSendBufferSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xE9DC80", Offset = "0xE9DC80", VA = "0xE9DC80")]
		public int getUDPRecvBufferSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xE9DC88", Offset = "0xE9DC88", VA = "0xE9DC88")]
		public int getUDPSendBufferSize()
		{
			return default(int);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xE8A208", Offset = "0xE8A208", VA = "0xE8A208")]
		public KBEngineArgs()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class KBEMath
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float KBE_FLT_MAX;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xE8ACCC", Offset = "0xE8ACCC", VA = "0xE8ACCC")]
		public static float int82angle(sbyte angle, bool half)
		{
			return default(float);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xE8ACF8", Offset = "0xE8ACF8", VA = "0xE8ACF8")]
		public static bool almostEqual(float f1, float f2, float epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xE8AD98", Offset = "0xE8AD98", VA = "0xE8AD98")]
		public static bool isNumeric(object v)
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xE8B04C", Offset = "0xE8B04C", VA = "0xE8B04C")]
		public KBEMath()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class MemoryStream : ObjectPool<MemoryStream>
	{
		[StructLayout(2)]
		[Token(Token = "0x2000068")]
		private struct PackFloatXType
		{
			[Token(Token = "0x4000164")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float fv;

			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint uv;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int iv;
		}

		[Token(Token = "0x400015F")]
		public const int BUFFER_MAX = 5840;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int rpos;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int wpos;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] datas_;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ASCIIEncoding _converter;

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xEA0974", Offset = "0xEA0974", VA = "0xEA0974")]
		public byte[] setBuffer(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xEA0990", Offset = "0xEA0990", VA = "0xEA0990")]
		public void swap(MemoryStream stream)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xE94750", Offset = "0xE94750", VA = "0xE94750")]
		public void reclaimObject()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xEA0AC4", Offset = "0xEA0AC4", VA = "0xEA0AC4")]
		public byte[] data()
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xEA0ACC", Offset = "0xEA0ACC", VA = "0xEA0ACC")]
		public void setData(byte[] data)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xE95804", Offset = "0xE95804", VA = "0xE95804")]
		public sbyte readInt8()
		{
			return default(sbyte);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xE9D454", Offset = "0xE9D454", VA = "0xE9D454")]
		public short readInt16()
		{
			return default(short);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xE8E2CC", Offset = "0xE8E2CC", VA = "0xE8E2CC")]
		public int readInt32()
		{
			return default(int);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xEA0AD4", Offset = "0xEA0AD4", VA = "0xEA0AD4")]
		public long readInt64()
		{
			return default(long);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xE89504", Offset = "0xE89504", VA = "0xE89504")]
		public byte readUint8()
		{
			return default(byte);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xE8954C", Offset = "0xE8954C", VA = "0xE8954C")]
		public ushort readUint16()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xE898D0", Offset = "0xE898D0", VA = "0xE898D0")]
		public uint readUint32()
		{
			return default(uint);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xE93F00", Offset = "0xE93F00", VA = "0xE93F00")]
		public ulong readUint64()
		{
			return default(ulong);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xE98778", Offset = "0xE98778", VA = "0xE98778")]
		public float readFloat()
		{
			return default(float);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xEA0B60", Offset = "0xEA0B60", VA = "0xEA0B60")]
		public double readDouble()
		{
			return default(double);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xE8E1C0", Offset = "0xE8E1C0", VA = "0xE8E1C0")]
		public string readString()
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xEA0BEC", Offset = "0xEA0BEC", VA = "0xEA0BEC")]
		public string readUnicode()
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xE8E790", Offset = "0xE8E790", VA = "0xE8E790")]
		public byte[] readBlob()
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xEA0C38", Offset = "0xEA0C38", VA = "0xEA0C38")]
		public byte[] readEntitycall()
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xEA0CB0", Offset = "0xEA0CB0", VA = "0xEA0CB0")]
		public Vector2 readVector2()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xE89894", Offset = "0xE89894", VA = "0xE89894")]
		public Vector3 readVector3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xEA0CE0", Offset = "0xEA0CE0", VA = "0xEA0CE0")]
		public Vector4 readVector4()
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xEA0D4C", Offset = "0xEA0D4C", VA = "0xEA0D4C")]
		public byte[] readPython()
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xE9B7C0", Offset = "0xE9B7C0", VA = "0xE9B7C0")]
		public Vector2 readPackXZ()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xE9C424", Offset = "0xE9C424", VA = "0xE9C424")]
		public float readPackY()
		{
			return default(float);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xEA0D50", Offset = "0xEA0D50", VA = "0xEA0D50")]
		public void writeInt8(sbyte v)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xEA0D9C", Offset = "0xEA0D9C", VA = "0xEA0D9C")]
		public void writeInt16(short v)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xEA0DC4", Offset = "0xEA0DC4", VA = "0xEA0DC4")]
		public void writeInt32(int v)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xEA0DF8", Offset = "0xEA0DF8", VA = "0xEA0DF8")]
		public void writeInt64(long v)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xEA0F08", Offset = "0xEA0F08", VA = "0xEA0F08")]
		public void writeUint8(byte v)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xEA0F54", Offset = "0xEA0F54", VA = "0xEA0F54")]
		public void writeUint16(ushort v)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xEA0F7C", Offset = "0xEA0F7C", VA = "0xEA0F7C")]
		public void writeUint32(uint v)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xEA0FB0", Offset = "0xEA0FB0", VA = "0xEA0FB0")]
		public void writeUint64(ulong v)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xEA10C0", Offset = "0xEA10C0", VA = "0xEA10C0")]
		public void writeFloat(float v)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xEA11C8", Offset = "0xEA11C8", VA = "0xEA11C8")]
		public void writeDouble(double v)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xEA12D8", Offset = "0xEA12D8", VA = "0xEA12D8")]
		public void writeBlob(byte[] v)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xEA148C", Offset = "0xEA148C", VA = "0xEA148C")]
		public void writeString(string v)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xEA1654", Offset = "0xEA1654", VA = "0xEA1654")]
		public void writeVector2(Vector2 v)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xEA1678", Offset = "0xEA1678", VA = "0xEA1678")]
		public void writeVector3(Vector3 v)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xEA16AC", Offset = "0xEA16AC", VA = "0xEA16AC")]
		public void writeVector4(Vector4 v)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xEA16EC", Offset = "0xEA16EC", VA = "0xEA16EC")]
		public void writeEntitycall(byte[] v)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xEA1758", Offset = "0xEA1758", VA = "0xEA1758")]
		public void append(byte[] datas, uint offset, uint size)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xEA18B4", Offset = "0xEA18B4", VA = "0xEA18B4")]
		public void readSkip(uint v)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xEA1460", Offset = "0xEA1460", VA = "0xEA1460")]
		public uint space()
		{
			return default(uint);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xE8995C", Offset = "0xE8995C", VA = "0xE8995C")]
		public uint length()
		{
			return default(uint);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xEA18C4", Offset = "0xEA18C4", VA = "0xEA18C4")]
		public bool readEOF()
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xEA18E0", Offset = "0xEA18E0", VA = "0xEA18E0")]
		public void done()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xEA0A30", Offset = "0xEA0A30", VA = "0xEA0A30")]
		public void clear()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xEA18EC", Offset = "0xEA18EC", VA = "0xEA18EC")]
		public byte[] getbuffer()
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xEA1990", Offset = "0xEA1990", VA = "0xEA1990")]
		public string toString()
		{
			return null;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xEA1AA4", Offset = "0xEA1AA4", VA = "0xEA1AA4")]
		public MemoryStream()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public abstract class MessageReaderBase
	{
		[Token(Token = "0x600033E")]
		public abstract void process(byte[] datas, uint offset, uint length);

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xEA1C60", Offset = "0xEA1C60", VA = "0xEA1C60")]
		protected MessageReaderBase()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class MessageReaderKCP : MessageReaderTCP
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xEA1C68", Offset = "0xEA1C68", VA = "0xEA1C68")]
		public MessageReaderKCP()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class MessageReaderTCP : MessageReaderBase
	{
		[Token(Token = "0x200006C")]
		private enum READ_STATE
		{
			[Token(Token = "0x400016D")]
			READ_STATE_MSGID,
			[Token(Token = "0x400016E")]
			READ_STATE_MSGLEN,
			[Token(Token = "0x400016F")]
			READ_STATE_MSGLEN_EX,
			[Token(Token = "0x4000170")]
			READ_STATE_BODY
		}

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private ushort msgid;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private ushort msglen;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private uint expectSize;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private READ_STATE state;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private MemoryStream stream;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xEA1C6C", Offset = "0xEA1C6C", VA = "0xEA1C6C")]
		public MessageReaderTCP()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xEA1CEC", Offset = "0xEA1CEC", VA = "0xEA1CEC", Slot = "4")]
		public override void process(byte[] datas, uint offset, uint length)
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Message
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort id;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public string name;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public short msglen;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public List<byte> argtypes;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public sbyte argsType;

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xEA1BFC", Offset = "0xEA1BFC", VA = "0xEA1BFC")]
		public Message(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xEA1C5C", Offset = "0xEA1C5C", VA = "0xEA1C5C", Slot = "4")]
		public virtual void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class Message_Client_onReloginBaseappFailed : Message
	{
		[Token(Token = "0x6000345")]
		[Address(RVA = "0xEA346C", Offset = "0xEA346C", VA = "0xEA346C")]
		public Message_Client_onReloginBaseappFailed(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xEA3490", Offset = "0xEA3490", VA = "0xEA3490", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class Message_Client_onEntityLeaveWorldOptimized : Message
	{
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xEA2D68", Offset = "0xEA2D68", VA = "0xEA2D68")]
		public Message_Client_onEntityLeaveWorldOptimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xEA2D8C", Offset = "0xEA2D8C", VA = "0xEA2D8C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class Message_Client_onRemoteMethodCallOptimized : Message
	{
		[Token(Token = "0x6000349")]
		[Address(RVA = "0xEA36A0", Offset = "0xEA36A0", VA = "0xEA36A0")]
		public Message_Client_onRemoteMethodCallOptimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xEA36C4", Offset = "0xEA36C4", VA = "0xEA36C4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class Message_Client_onUpdatePropertysOptimized : Message
	{
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xEA6238", Offset = "0xEA6238", VA = "0xEA6238")]
		public Message_Client_onUpdatePropertysOptimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xEA625C", Offset = "0xEA625C", VA = "0xEA625C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class Message_Client_onSetEntityPosAndDir : Message
	{
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xEA3A7C", Offset = "0xEA3A7C", VA = "0xEA3A7C")]
		public Message_Client_onSetEntityPosAndDir(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xEA3AA0", Offset = "0xEA3AA0", VA = "0xEA3AA0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class Message_Client_onUpdateBasePos : Message
	{
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xEA3E70", Offset = "0xEA3E70", VA = "0xEA3E70")]
		public Message_Client_onUpdateBasePos(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xEA3E94", Offset = "0xEA3E94", VA = "0xEA3E94", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class Message_Client_onUpdateBaseDir : Message
	{
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xEA3DBC", Offset = "0xEA3DBC", VA = "0xEA3DBC")]
		public Message_Client_onUpdateBaseDir(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xEA3DE0", Offset = "0xEA3DE0", VA = "0xEA3DE0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class Message_Client_onUpdateBasePosXZ : Message
	{
		[Token(Token = "0x6000353")]
		[Address(RVA = "0xEA3F88", Offset = "0xEA3F88", VA = "0xEA3F88")]
		public Message_Client_onUpdateBasePosXZ(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xEA3FAC", Offset = "0xEA3FAC", VA = "0xEA3FAC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class Message_Client_onUpdateData : Message
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xEA4078", Offset = "0xEA4078", VA = "0xEA4078")]
		public Message_Client_onUpdateData(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xEA409C", Offset = "0xEA409C", VA = "0xEA409C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class Message_Client_onUpdateData_ypr : Message
	{
		[Token(Token = "0x6000357")]
		[Address(RVA = "0xEA5EB4", Offset = "0xEA5EB4", VA = "0xEA5EB4")]
		public Message_Client_onUpdateData_ypr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xEA5ED8", Offset = "0xEA5ED8", VA = "0xEA5ED8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class Message_Client_onUpdateData_yp : Message
	{
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xEA5D4C", Offset = "0xEA5D4C", VA = "0xEA5D4C")]
		public Message_Client_onUpdateData_yp(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xEA5D70", Offset = "0xEA5D70", VA = "0xEA5D70", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class Message_Client_onUpdateData_yr : Message
	{
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xEA601C", Offset = "0xEA601C", VA = "0xEA601C")]
		public Message_Client_onUpdateData_yr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xEA6040", Offset = "0xEA6040", VA = "0xEA6040", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class Message_Client_onUpdateData_pr : Message
	{
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xEA4294", Offset = "0xEA4294", VA = "0xEA4294")]
		public Message_Client_onUpdateData_pr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xEA42B8", Offset = "0xEA42B8", VA = "0xEA42B8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class Message_Client_onUpdateData_y : Message
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xEA5BE4", Offset = "0xEA5BE4", VA = "0xEA5BE4")]
		public Message_Client_onUpdateData_y(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xEA5C08", Offset = "0xEA5C08", VA = "0xEA5C08", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class Message_Client_onUpdateData_p : Message
	{
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xEA412C", Offset = "0xEA412C", VA = "0xEA412C")]
		public Message_Client_onUpdateData_p(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xEA4150", Offset = "0xEA4150", VA = "0xEA4150", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class Message_Client_onUpdateData_r : Message
	{
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xEA43FC", Offset = "0xEA43FC", VA = "0xEA43FC")]
		public Message_Client_onUpdateData_r(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xEA4420", Offset = "0xEA4420", VA = "0xEA4420", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class Message_Client_onUpdateData_xz : Message
	{
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xEA50A4", Offset = "0xEA50A4", VA = "0xEA50A4")]
		public Message_Client_onUpdateData_xz(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xEA50C8", Offset = "0xEA50C8", VA = "0xEA50C8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class Message_Client_onUpdateData_xz_ypr : Message
	{
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xEA5914", Offset = "0xEA5914", VA = "0xEA5914")]
		public Message_Client_onUpdateData_xz_ypr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xEA5938", Offset = "0xEA5938", VA = "0xEA5938", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class Message_Client_onUpdateData_xz_yp : Message
	{
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xEA57AC", Offset = "0xEA57AC", VA = "0xEA57AC")]
		public Message_Client_onUpdateData_xz_yp(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xEA57D0", Offset = "0xEA57D0", VA = "0xEA57D0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class Message_Client_onUpdateData_xz_yr : Message
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0xEA5A7C", Offset = "0xEA5A7C", VA = "0xEA5A7C")]
		public Message_Client_onUpdateData_xz_yr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xEA5AA0", Offset = "0xEA5AA0", VA = "0xEA5AA0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class Message_Client_onUpdateData_xz_pr : Message
	{
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xEA5374", Offset = "0xEA5374", VA = "0xEA5374")]
		public Message_Client_onUpdateData_xz_pr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xEA5398", Offset = "0xEA5398", VA = "0xEA5398", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class Message_Client_onUpdateData_xz_y : Message
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xEA5644", Offset = "0xEA5644", VA = "0xEA5644")]
		public Message_Client_onUpdateData_xz_y(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xEA5668", Offset = "0xEA5668", VA = "0xEA5668", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class Message_Client_onUpdateData_xz_p : Message
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xEA520C", Offset = "0xEA520C", VA = "0xEA520C")]
		public Message_Client_onUpdateData_xz_p(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xEA5230", Offset = "0xEA5230", VA = "0xEA5230", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class Message_Client_onUpdateData_xz_r : Message
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xEA54DC", Offset = "0xEA54DC", VA = "0xEA54DC")]
		public Message_Client_onUpdateData_xz_r(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xEA5500", Offset = "0xEA5500", VA = "0xEA5500", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class Message_Client_onUpdateData_xyz : Message
	{
		[Token(Token = "0x6000375")]
		[Address(RVA = "0xEA4564", Offset = "0xEA4564", VA = "0xEA4564")]
		public Message_Client_onUpdateData_xyz(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xEA4588", Offset = "0xEA4588", VA = "0xEA4588", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class Message_Client_onUpdateData_xyz_ypr : Message
	{
		[Token(Token = "0x6000377")]
		[Address(RVA = "0xEA4DD4", Offset = "0xEA4DD4", VA = "0xEA4DD4")]
		public Message_Client_onUpdateData_xyz_ypr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xEA4DF8", Offset = "0xEA4DF8", VA = "0xEA4DF8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class Message_Client_onUpdateData_xyz_yp : Message
	{
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xEA4C6C", Offset = "0xEA4C6C", VA = "0xEA4C6C")]
		public Message_Client_onUpdateData_xyz_yp(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xEA4C90", Offset = "0xEA4C90", VA = "0xEA4C90", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class Message_Client_onUpdateData_xyz_yr : Message
	{
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xEA4F3C", Offset = "0xEA4F3C", VA = "0xEA4F3C")]
		public Message_Client_onUpdateData_xyz_yr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xEA4F60", Offset = "0xEA4F60", VA = "0xEA4F60", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class Message_Client_onUpdateData_xyz_pr : Message
	{
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xEA4834", Offset = "0xEA4834", VA = "0xEA4834")]
		public Message_Client_onUpdateData_xyz_pr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xEA4858", Offset = "0xEA4858", VA = "0xEA4858", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class Message_Client_onUpdateData_xyz_y : Message
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0xEA4B04", Offset = "0xEA4B04", VA = "0xEA4B04")]
		public Message_Client_onUpdateData_xyz_y(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xEA4B28", Offset = "0xEA4B28", VA = "0xEA4B28", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class Message_Client_onUpdateData_xyz_p : Message
	{
		[Token(Token = "0x6000381")]
		[Address(RVA = "0xEA46CC", Offset = "0xEA46CC", VA = "0xEA46CC")]
		public Message_Client_onUpdateData_xyz_p(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xEA46F0", Offset = "0xEA46F0", VA = "0xEA46F0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class Message_Client_onUpdateData_xyz_r : Message
	{
		[Token(Token = "0x6000383")]
		[Address(RVA = "0xEA499C", Offset = "0xEA499C", VA = "0xEA499C")]
		public Message_Client_onUpdateData_xyz_r(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xEA49C0", Offset = "0xEA49C0", VA = "0xEA49C0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class Message_Client_onUpdateData_ypr_optimized : Message
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0xEA5F68", Offset = "0xEA5F68", VA = "0xEA5F68")]
		public Message_Client_onUpdateData_ypr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xEA5F8C", Offset = "0xEA5F8C", VA = "0xEA5F8C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class Message_Client_onUpdateData_yp_optimized : Message
	{
		[Token(Token = "0x6000387")]
		[Address(RVA = "0xEA5E00", Offset = "0xEA5E00", VA = "0xEA5E00")]
		public Message_Client_onUpdateData_yp_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xEA5E24", Offset = "0xEA5E24", VA = "0xEA5E24", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class Message_Client_onUpdateData_yr_optimized : Message
	{
		[Token(Token = "0x6000389")]
		[Address(RVA = "0xEA60D0", Offset = "0xEA60D0", VA = "0xEA60D0")]
		public Message_Client_onUpdateData_yr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xEA60F4", Offset = "0xEA60F4", VA = "0xEA60F4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class Message_Client_onUpdateData_pr_optimized : Message
	{
		[Token(Token = "0x600038B")]
		[Address(RVA = "0xEA4348", Offset = "0xEA4348", VA = "0xEA4348")]
		public Message_Client_onUpdateData_pr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xEA436C", Offset = "0xEA436C", VA = "0xEA436C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class Message_Client_onUpdateData_y_optimized : Message
	{
		[Token(Token = "0x600038D")]
		[Address(RVA = "0xEA5C98", Offset = "0xEA5C98", VA = "0xEA5C98")]
		public Message_Client_onUpdateData_y_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xEA5CBC", Offset = "0xEA5CBC", VA = "0xEA5CBC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class Message_Client_onUpdateData_p_optimized : Message
	{
		[Token(Token = "0x600038F")]
		[Address(RVA = "0xEA41E0", Offset = "0xEA41E0", VA = "0xEA41E0")]
		public Message_Client_onUpdateData_p_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xEA4204", Offset = "0xEA4204", VA = "0xEA4204", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class Message_Client_onUpdateData_r_optimized : Message
	{
		[Token(Token = "0x6000391")]
		[Address(RVA = "0xEA44B0", Offset = "0xEA44B0", VA = "0xEA44B0")]
		public Message_Client_onUpdateData_r_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xEA44D4", Offset = "0xEA44D4", VA = "0xEA44D4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class Message_Client_onUpdateData_xz_optimized : Message
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0xEA5158", Offset = "0xEA5158", VA = "0xEA5158")]
		public Message_Client_onUpdateData_xz_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xEA517C", Offset = "0xEA517C", VA = "0xEA517C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class Message_Client_onUpdateData_xz_ypr_optimized : Message
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0xEA59C8", Offset = "0xEA59C8", VA = "0xEA59C8")]
		public Message_Client_onUpdateData_xz_ypr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xEA59EC", Offset = "0xEA59EC", VA = "0xEA59EC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class Message_Client_onUpdateData_xz_yp_optimized : Message
	{
		[Token(Token = "0x6000397")]
		[Address(RVA = "0xEA5860", Offset = "0xEA5860", VA = "0xEA5860")]
		public Message_Client_onUpdateData_xz_yp_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xEA5884", Offset = "0xEA5884", VA = "0xEA5884", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class Message_Client_onUpdateData_xz_yr_optimized : Message
	{
		[Token(Token = "0x6000399")]
		[Address(RVA = "0xEA5B30", Offset = "0xEA5B30", VA = "0xEA5B30")]
		public Message_Client_onUpdateData_xz_yr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xEA5B54", Offset = "0xEA5B54", VA = "0xEA5B54", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class Message_Client_onUpdateData_xz_pr_optimized : Message
	{
		[Token(Token = "0x600039B")]
		[Address(RVA = "0xEA5428", Offset = "0xEA5428", VA = "0xEA5428")]
		public Message_Client_onUpdateData_xz_pr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xEA544C", Offset = "0xEA544C", VA = "0xEA544C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class Message_Client_onUpdateData_xz_y_optimized : Message
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0xEA56F8", Offset = "0xEA56F8", VA = "0xEA56F8")]
		public Message_Client_onUpdateData_xz_y_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xEA571C", Offset = "0xEA571C", VA = "0xEA571C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class Message_Client_onUpdateData_xz_p_optimized : Message
	{
		[Token(Token = "0x600039F")]
		[Address(RVA = "0xEA52C0", Offset = "0xEA52C0", VA = "0xEA52C0")]
		public Message_Client_onUpdateData_xz_p_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xEA52E4", Offset = "0xEA52E4", VA = "0xEA52E4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class Message_Client_onUpdateData_xz_r_optimized : Message
	{
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xEA5590", Offset = "0xEA5590", VA = "0xEA5590")]
		public Message_Client_onUpdateData_xz_r_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xEA55B4", Offset = "0xEA55B4", VA = "0xEA55B4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class Message_Client_onUpdateData_xyz_optimized : Message
	{
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xEA4618", Offset = "0xEA4618", VA = "0xEA4618")]
		public Message_Client_onUpdateData_xyz_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xEA463C", Offset = "0xEA463C", VA = "0xEA463C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class Message_Client_onUpdateData_xyz_ypr_optimized : Message
	{
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xEA4E88", Offset = "0xEA4E88", VA = "0xEA4E88")]
		public Message_Client_onUpdateData_xyz_ypr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xEA4EAC", Offset = "0xEA4EAC", VA = "0xEA4EAC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class Message_Client_onUpdateData_xyz_yp_optimized : Message
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xEA4D20", Offset = "0xEA4D20", VA = "0xEA4D20")]
		public Message_Client_onUpdateData_xyz_yp_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xEA4D44", Offset = "0xEA4D44", VA = "0xEA4D44", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class Message_Client_onUpdateData_xyz_yr_optimized : Message
	{
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xEA4FF0", Offset = "0xEA4FF0", VA = "0xEA4FF0")]
		public Message_Client_onUpdateData_xyz_yr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xEA5014", Offset = "0xEA5014", VA = "0xEA5014", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class Message_Client_onUpdateData_xyz_pr_optimized : Message
	{
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xEA48E8", Offset = "0xEA48E8", VA = "0xEA48E8")]
		public Message_Client_onUpdateData_xyz_pr_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xEA490C", Offset = "0xEA490C", VA = "0xEA490C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class Message_Client_onUpdateData_xyz_y_optimized : Message
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xEA4BB8", Offset = "0xEA4BB8", VA = "0xEA4BB8")]
		public Message_Client_onUpdateData_xyz_y_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xEA4BDC", Offset = "0xEA4BDC", VA = "0xEA4BDC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class Message_Client_onUpdateData_xyz_p_optimized : Message
	{
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xEA4780", Offset = "0xEA4780", VA = "0xEA4780")]
		public Message_Client_onUpdateData_xyz_p_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xEA47A4", Offset = "0xEA47A4", VA = "0xEA47A4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class Message_Client_onUpdateData_xyz_r_optimized : Message
	{
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xEA4A50", Offset = "0xEA4A50", VA = "0xEA4A50")]
		public Message_Client_onUpdateData_xyz_r_optimized(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xEA4A74", Offset = "0xEA4A74", VA = "0xEA4A74", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class Message_Client_onImportServerErrorsDescr : Message
	{
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xEA30C8", Offset = "0xEA30C8", VA = "0xEA30C8")]
		public Message_Client_onImportServerErrorsDescr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xEA30EC", Offset = "0xEA30EC", VA = "0xEA30EC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class Message_Client_onImportClientSDK : Message
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xEA3018", Offset = "0xEA3018", VA = "0xEA3018")]
		public Message_Client_onImportClientSDK(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xEA303C", Offset = "0xEA303C", VA = "0xEA303C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class Message_Client_initSpaceData : Message
	{
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xEA2574", Offset = "0xEA2574", VA = "0xEA2574")]
		public Message_Client_initSpaceData(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xEA2598", Offset = "0xEA2598", VA = "0xEA2598", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class Message_Client_setSpaceData : Message
	{
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xEA63B0", Offset = "0xEA63B0", VA = "0xEA63B0")]
		public Message_Client_setSpaceData(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xEA63D4", Offset = "0xEA63D4", VA = "0xEA63D4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class Message_Client_delSpaceData : Message
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xEA2484", Offset = "0xEA2484", VA = "0xEA2484")]
		public Message_Client_delSpaceData(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xEA24A8", Offset = "0xEA24A8", VA = "0xEA24A8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class Message_Client_onReqAccountResetPasswordCB : Message
	{
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xEA38FC", Offset = "0xEA38FC", VA = "0xEA38FC")]
		public Message_Client_onReqAccountResetPasswordCB(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xEA3920", Offset = "0xEA3920", VA = "0xEA3920", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class Message_Client_onReqAccountBindEmailCB : Message
	{
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xEA3764", Offset = "0xEA3764", VA = "0xEA3764")]
		public Message_Client_onReqAccountBindEmailCB(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xEA3788", Offset = "0xEA3788", VA = "0xEA3788", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class Message_Client_onReqAccountNewPasswordCB : Message
	{
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xEA3830", Offset = "0xEA3830", VA = "0xEA3830")]
		public Message_Client_onReqAccountNewPasswordCB(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xEA3854", Offset = "0xEA3854", VA = "0xEA3854", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class Message_Client_onReloginBaseappSuccessfully : Message
	{
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xEA3538", Offset = "0xEA3538", VA = "0xEA3538")]
		public Message_Client_onReloginBaseappSuccessfully(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xEA355C", Offset = "0xEA355C", VA = "0xEA355C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class Message_Client_onAppActiveTickCB : Message
	{
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xEA2628", Offset = "0xEA2628", VA = "0xEA2628")]
		public Message_Client_onAppActiveTickCB(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xEA264C", Offset = "0xEA264C", VA = "0xEA264C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class Message_Client_onCreateAccountResult : Message
	{
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xEA27C4", Offset = "0xEA27C4", VA = "0xEA27C4")]
		public Message_Client_onCreateAccountResult(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xEA27E8", Offset = "0xEA27E8", VA = "0xEA27E8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class Message_Client_onLoginSuccessfully : Message
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xEA33B8", Offset = "0xEA33B8", VA = "0xEA33B8")]
		public Message_Client_onLoginSuccessfully(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xEA33DC", Offset = "0xEA33DC", VA = "0xEA33DC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class Message_Client_onLoginFailed : Message
	{
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xEA3304", Offset = "0xEA3304", VA = "0xEA3304")]
		public Message_Client_onLoginFailed(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xEA3328", Offset = "0xEA3328", VA = "0xEA3328", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class Message_Client_onCreatedProxies : Message
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xEA2878", Offset = "0xEA2878", VA = "0xEA2878")]
		public Message_Client_onCreatedProxies(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xEA289C", Offset = "0xEA289C", VA = "0xEA289C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class Message_Client_onLoginBaseappFailed : Message
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xEA3238", Offset = "0xEA3238", VA = "0xEA3238")]
		public Message_Client_onLoginBaseappFailed(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xEA325C", Offset = "0xEA325C", VA = "0xEA325C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class Message_Client_onRemoteMethodCall : Message
	{
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xEA35EC", Offset = "0xEA35EC", VA = "0xEA35EC")]
		public Message_Client_onRemoteMethodCall(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xEA3610", Offset = "0xEA3610", VA = "0xEA3610", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class Message_Client_onEntityEnterWorld : Message
	{
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xEA2B1C", Offset = "0xEA2B1C", VA = "0xEA2B1C")]
		public Message_Client_onEntityEnterWorld(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xEA2B40", Offset = "0xEA2B40", VA = "0xEA2B40", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class Message_Client_onEntityLeaveWorld : Message
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xEA2C9C", Offset = "0xEA2C9C", VA = "0xEA2C9C")]
		public Message_Client_onEntityLeaveWorld(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xEA2CC0", Offset = "0xEA2CC0", VA = "0xEA2CC0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class Message_Client_onEntityEnterSpace : Message
	{
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xEA2A68", Offset = "0xEA2A68", VA = "0xEA2A68")]
		public Message_Client_onEntityEnterSpace(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xEA2A8C", Offset = "0xEA2A8C", VA = "0xEA2A8C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class Message_Client_onEntityLeaveSpace : Message
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xEA2BD0", Offset = "0xEA2BD0", VA = "0xEA2BD0")]
		public Message_Client_onEntityLeaveSpace(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xEA2BF4", Offset = "0xEA2BF4", VA = "0xEA2BF4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class Message_Client_onUpdatePropertys : Message
	{
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xEA6184", Offset = "0xEA6184", VA = "0xEA6184")]
		public Message_Client_onUpdatePropertys(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xEA61A8", Offset = "0xEA61A8", VA = "0xEA61A8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class Message_Client_onEntityDestroyed : Message
	{
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xEA299C", Offset = "0xEA299C", VA = "0xEA299C")]
		public Message_Client_onEntityDestroyed(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xEA29C0", Offset = "0xEA29C0", VA = "0xEA29C0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class Message_Client_onStreamDataStarted : Message
	{
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xEA3CA8", Offset = "0xEA3CA8", VA = "0xEA3CA8")]
		public Message_Client_onStreamDataStarted(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xEA3CCC", Offset = "0xEA3CCC", VA = "0xEA3CCC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class Message_Client_onStreamDataRecv : Message
	{
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xEA3BF8", Offset = "0xEA3BF8", VA = "0xEA3BF8")]
		public Message_Client_onStreamDataRecv(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xEA3C1C", Offset = "0xEA3C1C", VA = "0xEA3C1C", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class Message_Client_onStreamDataCompleted : Message
	{
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xEA3B30", Offset = "0xEA3B30", VA = "0xEA3B30")]
		public Message_Client_onStreamDataCompleted(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xEA3B54", Offset = "0xEA3B54", VA = "0xEA3B54", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class Message_Client_onKicked : Message
	{
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xEA316C", Offset = "0xEA316C", VA = "0xEA316C")]
		public Message_Client_onKicked(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xEA3190", Offset = "0xEA3190", VA = "0xEA3190", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class Message_Client_onImportClientMessages : Message
	{
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xEA2F74", Offset = "0xEA2F74", VA = "0xEA2F74")]
		public Message_Client_onImportClientMessages(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xEA2F98", Offset = "0xEA2F98", VA = "0xEA2F98", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class Message_Client_onImportClientEntityDef : Message
	{
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xEA2ED0", Offset = "0xEA2ED0", VA = "0xEA2ED0")]
		public Message_Client_onImportClientEntityDef(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xEA2EF4", Offset = "0xEA2EF4", VA = "0xEA2EF4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class Message_Client_onHelloCB : Message
	{
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xEA2E1C", Offset = "0xEA2E1C", VA = "0xEA2E1C")]
		public Message_Client_onHelloCB(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xEA2E40", Offset = "0xEA2E40", VA = "0xEA2E40", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class Message_Client_onScriptVersionNotMatch : Message
	{
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xEA39C8", Offset = "0xEA39C8", VA = "0xEA39C8")]
		public Message_Client_onScriptVersionNotMatch(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xEA39EC", Offset = "0xEA39EC", VA = "0xEA39EC", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class Message_Client_onVersionNotMatch : Message
	{
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xEA62FC", Offset = "0xEA62FC", VA = "0xEA62FC")]
		public Message_Client_onVersionNotMatch(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xEA6320", Offset = "0xEA6320", VA = "0xEA6320", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class Message_Client_onControlEntity : Message
	{
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xEA26D4", Offset = "0xEA26D4", VA = "0xEA26D4")]
		public Message_Client_onControlEntity(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xEA26F8", Offset = "0xEA26F8", VA = "0xEA26F8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class Message_Loginapp_reqCreateAccount : Message
	{
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xEC1A38", Offset = "0xEC1A38", VA = "0xEC1A38")]
		public Message_Loginapp_reqCreateAccount(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xEC1A64", Offset = "0xEC1A64", VA = "0xEC1A64", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class Message_Loginapp_login : Message
	{
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xEC19A8", Offset = "0xEC19A8", VA = "0xEC19A8")]
		public Message_Loginapp_login(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xEC19D4", Offset = "0xEC19D4", VA = "0xEC19D4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class Message_Loginapp_hello : Message
	{
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xEC18E8", Offset = "0xEC18E8", VA = "0xEC18E8")]
		public Message_Loginapp_hello(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xEC1914", Offset = "0xEC1914", VA = "0xEC1914", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class Message_Loginapp_importClientMessages : Message
	{
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xEC1918", Offset = "0xEC1918", VA = "0xEC1918")]
		public Message_Loginapp_importClientMessages(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xEC1944", Offset = "0xEC1944", VA = "0xEC1944", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class Message_Loginapp_reqCreateMailAccount : Message
	{
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xEC1A68", Offset = "0xEC1A68", VA = "0xEC1A68")]
		public Message_Loginapp_reqCreateMailAccount(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xEC1A94", Offset = "0xEC1A94", VA = "0xEC1A94", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class Message_Loginapp_importClientSDK : Message
	{
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xEC1948", Offset = "0xEC1948", VA = "0xEC1948")]
		public Message_Loginapp_importClientSDK(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xEC1974", Offset = "0xEC1974", VA = "0xEC1974", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class Message_Loginapp_importServerErrorsDescr : Message
	{
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xEC1978", Offset = "0xEC1978", VA = "0xEC1978")]
		public Message_Loginapp_importServerErrorsDescr(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEC19A4", Offset = "0xEC19A4", VA = "0xEC19A4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class Message_Loginapp_onClientActiveTick : Message
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0xEC19D8", Offset = "0xEC19D8", VA = "0xEC19D8")]
		public Message_Loginapp_onClientActiveTick(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xEC1A04", Offset = "0xEC1A04", VA = "0xEC1A04", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class Message_Loginapp_reqAccountResetPassword : Message
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0xEC1A08", Offset = "0xEC1A08", VA = "0xEC1A08")]
		public Message_Loginapp_reqAccountResetPassword(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xEC1A34", Offset = "0xEC1A34", VA = "0xEC1A34", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class Message_Baseapp_logoutBaseapp : Message
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0xEA2344", Offset = "0xEA2344", VA = "0xEA2344")]
		public Message_Baseapp_logoutBaseapp(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xEA2368", Offset = "0xEA2368", VA = "0xEA2368", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class Message_Baseapp_onUpdateDataFromClient : Message
	{
		[Token(Token = "0x6000407")]
		[Address(RVA = "0xEA23BC", Offset = "0xEA23BC", VA = "0xEA23BC")]
		public Message_Baseapp_onUpdateDataFromClient(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xEA23E0", Offset = "0xEA23E0", VA = "0xEA23E0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class Message_Baseapp_onUpdateDataFromClientForControlledEntity : Message
	{
		[Token(Token = "0x6000409")]
		[Address(RVA = "0xEA23E4", Offset = "0xEA23E4", VA = "0xEA23E4")]
		public Message_Baseapp_onUpdateDataFromClientForControlledEntity(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xEA2408", Offset = "0xEA2408", VA = "0xEA2408", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class Message_Baseapp_reqAccountBindEmail : Message
	{
		[Token(Token = "0x600040B")]
		[Address(RVA = "0xEA2434", Offset = "0xEA2434", VA = "0xEA2434")]
		public Message_Baseapp_reqAccountBindEmail(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xEA2458", Offset = "0xEA2458", VA = "0xEA2458", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class Message_Baseapp_reqAccountNewPassword : Message
	{
		[Token(Token = "0x600040D")]
		[Address(RVA = "0xEA245C", Offset = "0xEA245C", VA = "0xEA245C")]
		public Message_Baseapp_reqAccountNewPassword(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xEA2480", Offset = "0xEA2480", VA = "0xEA2480", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class Message_Entity_forwardEntityMessageToCellappFromClient : Message
	{
		[Token(Token = "0x600040F")]
		[Address(RVA = "0xEC1888", Offset = "0xEC1888", VA = "0xEC1888")]
		public Message_Entity_forwardEntityMessageToCellappFromClient(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xEC18B4", Offset = "0xEC18B4", VA = "0xEC18B4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class Message_Baseapp_hello : Message
	{
		[Token(Token = "0x6000411")]
		[Address(RVA = "0xEA22A4", Offset = "0xEA22A4", VA = "0xEA22A4")]
		public Message_Baseapp_hello(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xEA22C8", Offset = "0xEA22C8", VA = "0xEA22C8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class Message_Baseapp_loginBaseapp : Message
	{
		[Token(Token = "0x6000413")]
		[Address(RVA = "0xEA231C", Offset = "0xEA231C", VA = "0xEA231C")]
		public Message_Baseapp_loginBaseapp(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xEA2340", Offset = "0xEA2340", VA = "0xEA2340", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class Message_Baseapp_reloginBaseapp : Message
	{
		[Token(Token = "0x6000415")]
		[Address(RVA = "0xEA240C", Offset = "0xEA240C", VA = "0xEA240C")]
		public Message_Baseapp_reloginBaseapp(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xEA2430", Offset = "0xEA2430", VA = "0xEA2430", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class Message_Baseapp_onRemoteCallCellMethodFromClient : Message
	{
		[Token(Token = "0x6000417")]
		[Address(RVA = "0xEA2394", Offset = "0xEA2394", VA = "0xEA2394")]
		public Message_Baseapp_onRemoteCallCellMethodFromClient(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xEA23B8", Offset = "0xEA23B8", VA = "0xEA23B8", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class Message_Baseapp_onClientActiveTick : Message
	{
		[Token(Token = "0x6000419")]
		[Address(RVA = "0xEA236C", Offset = "0xEA236C", VA = "0xEA236C")]
		public Message_Baseapp_onClientActiveTick(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xEA2390", Offset = "0xEA2390", VA = "0xEA2390", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class Message_Baseapp_importClientMessages : Message
	{
		[Token(Token = "0x600041B")]
		[Address(RVA = "0xEA22F4", Offset = "0xEA22F4", VA = "0xEA22F4")]
		public Message_Baseapp_importClientMessages(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xEA2318", Offset = "0xEA2318", VA = "0xEA2318", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class Message_Baseapp_importClientEntityDef : Message
	{
		[Token(Token = "0x600041D")]
		[Address(RVA = "0xEA22CC", Offset = "0xEA22CC", VA = "0xEA22CC")]
		public Message_Baseapp_importClientEntityDef(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xEA22F0", Offset = "0xEA22F0", VA = "0xEA22F0", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class Message_Entity_onRemoteMethodCall : Message
	{
		[Token(Token = "0x600041F")]
		[Address(RVA = "0xEC18B8", Offset = "0xEC18B8", VA = "0xEC18B8")]
		public Message_Entity_onRemoteMethodCall(ushort msgid, string msgname, short length, sbyte argstype, List<byte> msgargtypes)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xEC18E4", Offset = "0xEC18E4", VA = "0xEC18E4", Slot = "4")]
		public override void handleMessage(MemoryStream msgstream)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class Messages
	{
		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<ushort, Message> loginappMessages;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static Dictionary<ushort, Message> baseappMessages;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<ushort, Message> clientMessages;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static Dictionary<string, Message> messages;

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xEC1A98", Offset = "0xEC1A98", VA = "0xEC1A98")]
		public static void clear()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xEC1C18", Offset = "0xEC1C18", VA = "0xEC1C18")]
		public static bool init()
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xECA498", Offset = "0xECA498", VA = "0xECA498")]
		public Messages()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class Method
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort methodUtype;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public short aliasID;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<DATATYPE_BASE> args;

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xECA5FC", Offset = "0xECA5FC", VA = "0xECA5FC")]
		public Method()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public abstract class NetworkInterfaceBase
	{
		[Token(Token = "0x20000DF")]
		public delegate void AsyncConnectMethod(ConnectState state);

		[Token(Token = "0x20000E0")]
		public delegate void ConnectCallback(string ip, int port, bool success, object userData);

		[Token(Token = "0x20000E1")]
		public class ConnectState
		{
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string connectIP;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int connectPort;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ConnectCallback connectCB;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public object userData;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Socket socket;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public NetworkInterfaceBase networkInterface;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string error;

			[Token(Token = "0x6000444")]
			[Address(RVA = "0xECC37C", Offset = "0xECC37C", VA = "0xECC37C")]
			public ConnectState()
			{
			}
		}

		[Token(Token = "0x400017E")]
		public const int TCP_PACKET_MAX = 1460;

		[Token(Token = "0x400017F")]
		public const int UDP_PACKET_MAX = 1472;

		[Token(Token = "0x4000180")]
		public const string UDP_HELLO = "62a559f3fa7748bc22f8e0766019d498";

		[Token(Token = "0x4000181")]
		public const string UDP_HELLO_ACK = "1432ad7c829170a76dd31982c3501eca";

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected Socket _socket;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected PacketReceiverBase _packetReceiver;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected PacketSenderBase _packetSender;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected EncryptionFilter _filter;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool connected;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xECA66C", Offset = "0xECA66C", VA = "0xECA66C")]
		public NetworkInterfaceBase()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xECA698", Offset = "0xECA698", VA = "0xECA698", Slot = "1")]
		~NetworkInterfaceBase()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xECA78C", Offset = "0xECA78C", VA = "0xECA78C", Slot = "4")]
		public virtual Socket sock()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xECA794", Offset = "0xECA794", VA = "0xECA794", Slot = "5")]
		public virtual void reset()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xECA994", Offset = "0xECA994", VA = "0xECA994", Slot = "6")]
		public virtual void close()
		{
		}

		[Token(Token = "0x600042B")]
		protected abstract PacketReceiverBase createPacketReceiver();

		[Token(Token = "0x600042C")]
		protected abstract PacketSenderBase createPacketSender();

		[Token(Token = "0x600042D")]
		protected abstract Socket createSocket();

		[Token(Token = "0x600042E")]
		protected abstract void onAsyncConnect(ConnectState state);

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xECAB2C", Offset = "0xECAB2C", VA = "0xECAB2C", Slot = "11")]
		public virtual PacketReceiverBase packetReceiver()
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xECAB34", Offset = "0xECAB34", VA = "0xECAB34", Slot = "12")]
		public virtual PacketSenderBase PacketSender()
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xECAB3C", Offset = "0xECAB3C", VA = "0xECAB3C", Slot = "13")]
		public virtual bool valid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xECAB5C", Offset = "0xECAB5C", VA = "0xECAB5C")]
		public void _onConnectionState(ConnectState state)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xECB368", Offset = "0xECB368", VA = "0xECB368")]
		private static void connectCB(IAsyncResult ar)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xECB754", Offset = "0xECB754", VA = "0xECB754")]
		private void _asyncConnect(ConnectState state)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xECB874", Offset = "0xECB874", VA = "0xECB874", Slot = "14")]
		protected virtual void onAsyncConnectCB(ConnectState state)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xECB878", Offset = "0xECB878", VA = "0xECB878")]
		private void _asyncConnectCB(IAsyncResult ar)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xECBCBC", Offset = "0xECBCBC", VA = "0xECBCBC")]
		public void connectTo(string ip, int port, ConnectCallback callback, object userData)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xECC42C", Offset = "0xECC42C", VA = "0xECC42C", Slot = "15")]
		public virtual bool send(MemoryStream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xECC538", Offset = "0xECC538", VA = "0xECC538", Slot = "16")]
		public virtual void process()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xECC57C", Offset = "0xECC57C", VA = "0xECC57C")]
		public EncryptionFilter fileter()
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xECC584", Offset = "0xECC584", VA = "0xECC584")]
		public void setFilter(EncryptionFilter filter)
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class NetworkInterfaceKCP : NetworkInterfaceBase
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private KCP kcp_;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint connID;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public uint nextTickKcpUpdate;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EndPoint remoteEndPint;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xECC58C", Offset = "0xECC58C", VA = "0xECC58C", Slot = "9")]
		protected override Socket createSocket()
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xECC608", Offset = "0xECC608", VA = "0xECC608", Slot = "7")]
		protected override PacketReceiverBase createPacketReceiver()
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xECC7DC", Offset = "0xECC7DC", VA = "0xECC7DC", Slot = "8")]
		protected override PacketSenderBase createPacketSender()
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xECC95C", Offset = "0xECC95C", VA = "0xECC95C", Slot = "5")]
		public override void reset()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xECC9F4", Offset = "0xECC9F4", VA = "0xECC9F4", Slot = "6")]
		public override void close()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xECCA10", Offset = "0xECCA10", VA = "0xECCA10", Slot = "13")]
		public override bool valid()
		{
			return default(bool);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xECCA40", Offset = "0xECCA40", VA = "0xECCA40")]
		protected void outputKCP(byte[] data, int size, object userData)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xECCE4C", Offset = "0xECCE4C", VA = "0xECCE4C")]
		private bool initKCP()
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xECC978", Offset = "0xECC978", VA = "0xECC978")]
		private bool finiKCP()
		{
			return default(bool);
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xECD098", Offset = "0xECD098", VA = "0xECD098")]
		public KCP kcp()
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xECD0A0", Offset = "0xECD0A0", VA = "0xECD0A0", Slot = "15")]
		public override bool send(MemoryStream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xECD1CC", Offset = "0xECD1CC", VA = "0xECD1CC", Slot = "16")]
		public override void process()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xECD438", Offset = "0xECD438", VA = "0xECD438", Slot = "14")]
		protected override void onAsyncConnectCB(ConnectState state)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xECD540", Offset = "0xECD540", VA = "0xECD540", Slot = "10")]
		protected override void onAsyncConnect(ConnectState state)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xECE31C", Offset = "0xECE31C", VA = "0xECE31C")]
		public NetworkInterfaceKCP()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class NetworkInterfaceTCP : NetworkInterfaceBase
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0xECE348", Offset = "0xECE348", VA = "0xECE348", Slot = "13")]
		public override bool valid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xECE368", Offset = "0xECE368", VA = "0xECE368", Slot = "9")]
		protected override Socket createSocket()
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xECE4FC", Offset = "0xECE4FC", VA = "0xECE4FC", Slot = "7")]
		protected override PacketReceiverBase createPacketReceiver()
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xECE68C", Offset = "0xECE68C", VA = "0xECE68C", Slot = "8")]
		protected override PacketSenderBase createPacketSender()
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xECE81C", Offset = "0xECE81C", VA = "0xECE81C", Slot = "10")]
		protected override void onAsyncConnect(ConnectState state)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xECEA0C", Offset = "0xECEA0C", VA = "0xECEA0C")]
		public NetworkInterfaceTCP()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class ObjectPool<T> where T : new()
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<T> _objects;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T v;

		[Token(Token = "0x600045A")]
		public static T createObject()
		{
			return (T)null;
		}

		[Token(Token = "0x600045B")]
		public static void reclaimObject(T item)
		{
		}

		[Token(Token = "0x600045C")]
		public ObjectPool()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public abstract class PacketReceiverBase
	{
		[Token(Token = "0x20000E6")]
		protected delegate void AsyncReceiveMethod();

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected MessageReaderBase _messageReader;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected NetworkInterfaceBase _networkInterface;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xECEE48", Offset = "0xECEE48", VA = "0xECEE48")]
		public PacketReceiverBase(NetworkInterfaceBase networkInterface)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xECEE74", Offset = "0xECEE74", VA = "0xECEE74", Slot = "1")]
		~PacketReceiverBase()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xECEE7C", Offset = "0xECEE7C", VA = "0xECEE7C")]
		public NetworkInterfaceBase networkInterface()
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		public abstract void process();

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xECEE84", Offset = "0xECEE84", VA = "0xECEE84", Slot = "5")]
		public virtual void startRecv()
		{
		}

		[Token(Token = "0x6000463")]
		protected abstract void _asyncReceive();

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xECEFD4", Offset = "0xECEFD4", VA = "0xECEFD4")]
		private void _onRecv(IAsyncResult ar)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class PacketReceiverKCP : PacketReceiverBase
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] _buffer;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private KCP kcp_;

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xECC66C", Offset = "0xECC66C", VA = "0xECC66C")]
		public PacketReceiverKCP(NetworkInterfaceBase networkInterface)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xECF130", Offset = "0xECF130", VA = "0xECF130", Slot = "1")]
		~PacketReceiverKCP()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xECF224", Offset = "0xECF224", VA = "0xECF224", Slot = "4")]
		public override void process()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xECF7B4", Offset = "0xECF7B4", VA = "0xECF7B4", Slot = "5")]
		public override void startRecv()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xECF7B8", Offset = "0xECF7B8", VA = "0xECF7B8", Slot = "6")]
		protected override void _asyncReceive()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class PacketReceiverTCP : PacketReceiverBase
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private byte[] _buffer;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _wpos;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _rpos;

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xECE560", Offset = "0xECE560", VA = "0xECE560")]
		public PacketReceiverTCP(NetworkInterfaceBase networkInterface)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xECF7BC", Offset = "0xECF7BC", VA = "0xECF7BC", Slot = "1")]
		~PacketReceiverTCP()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xECF89C", Offset = "0xECF89C", VA = "0xECF89C", Slot = "4")]
		public override void process()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xECFB1C", Offset = "0xECFB1C", VA = "0xECFB1C")]
		private int _free()
		{
			return default(int);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xECFBB8", Offset = "0xECFBB8", VA = "0xECFBB8", Slot = "6")]
		protected override void _asyncReceive()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public abstract class PacketSenderBase
	{
		[Token(Token = "0x20000EA")]
		public delegate void AsyncSendMethod();

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected NetworkInterfaceBase _networkInterface;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private AsyncCallback _asyncCallback;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AsyncSendMethod _asyncSendMethod;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xED01A0", Offset = "0xED01A0", VA = "0xED01A0")]
		public PacketSenderBase(NetworkInterfaceBase networkInterface)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xED02D4", Offset = "0xED02D4", VA = "0xED02D4", Slot = "1")]
		~PacketSenderBase()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xED02DC", Offset = "0xED02DC", VA = "0xED02DC")]
		public NetworkInterfaceBase networkInterface()
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		public abstract bool send(MemoryStream stream);

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xED02E4", Offset = "0xED02E4", VA = "0xED02E4")]
		protected void _startSend()
		{
		}

		[Token(Token = "0x6000478")]
		protected abstract void _asyncSend();

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xED0354", Offset = "0xED0354", VA = "0xED0354")]
		protected static void _onSent(IAsyncResult ar)
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class PacketSenderKCP : PacketSenderBase
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Socket socket_;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private EndPoint remoteEndPint_;

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xECC840", Offset = "0xECC840", VA = "0xECC840")]
		public PacketSenderKCP(NetworkInterfaceBase networkInterface)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xED04B0", Offset = "0xED04B0", VA = "0xED04B0", Slot = "1")]
		~PacketSenderKCP()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xED0590", Offset = "0xED0590", VA = "0xED0590", Slot = "4")]
		public override bool send(MemoryStream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xECCBE4", Offset = "0xECCBE4", VA = "0xECCBE4")]
		public bool sendto(byte[] packet, int size)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xED0598", Offset = "0xED0598", VA = "0xED0598", Slot = "5")]
		protected override void _asyncSend()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class PacketSenderTCP : PacketSenderBase
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private byte[] _buffer;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _wpos;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _spos;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object _sendingObj;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _sending;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xECE6F0", Offset = "0xECE6F0", VA = "0xECE6F0")]
		public PacketSenderTCP(NetworkInterfaceBase networkInterface)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xED059C", Offset = "0xED059C", VA = "0xED059C", Slot = "1")]
		~PacketSenderTCP()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xED067C", Offset = "0xED067C", VA = "0xED067C", Slot = "4")]
		public override bool send(MemoryStream stream)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xED0D48", Offset = "0xED0D48", VA = "0xED0D48", Slot = "5")]
		protected override void _asyncSend()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class Profile
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private DateTime startTime;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _name;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xED1160", Offset = "0xED1160", VA = "0xED1160")]
		public Profile(string name)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xED11E0", Offset = "0xED11E0", VA = "0xED11E0", Slot = "1")]
		~Profile()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xED11E8", Offset = "0xED11E8", VA = "0xED11E8")]
		public void start()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xED1270", Offset = "0xED1270", VA = "0xED1270")]
		public void end()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class Property
	{
		[Token(Token = "0x20000EF")]
		public enum EntityDataFlags
		{
			[Token(Token = "0x40001AD")]
			ED_FLAG_UNKOWN = 0,
			[Token(Token = "0x40001AE")]
			ED_FLAG_CELL_PUBLIC = 1,
			[Token(Token = "0x40001AF")]
			ED_FLAG_CELL_PRIVATE = 2,
			[Token(Token = "0x40001B0")]
			ED_FLAG_ALL_CLIENTS = 4,
			[Token(Token = "0x40001B1")]
			ED_FLAG_CELL_PUBLIC_AND_OWN = 8,
			[Token(Token = "0x40001B2")]
			ED_FLAG_OWN_CLIENT = 0x10,
			[Token(Token = "0x40001B3")]
			ED_FLAG_BASE_AND_CLIENT = 0x20,
			[Token(Token = "0x40001B4")]
			ED_FLAG_BASE = 0x40,
			[Token(Token = "0x40001B5")]
			ED_FLAG_OTHER_CLIENTS = 0x80
		}

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public ushort properUtype;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint properFlags;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public short aliasID;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object defaultVal;

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xED1614", Offset = "0xED1614", VA = "0xED1614")]
		public Property()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xED1684", Offset = "0xED1684", VA = "0xED1684")]
		public bool isBase()
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xED16A8", Offset = "0xED16A8", VA = "0xED16A8")]
		public bool isOwnerOnly()
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xED16CC", Offset = "0xED16CC", VA = "0xED16CC")]
		public bool isOtherOnly()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F0")]
	public abstract class RobotBase : Entity
	{
		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public EntityBaseEntityCall_RobotBase baseEntityCall;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public EntityCellEntityCall_RobotBase cellEntityCall;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EQUIP_DICT currentEquipDict;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public string nameS;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int progress;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int roomNo;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xED171C", Offset = "0xED171C", VA = "0xED171C", Slot = "28")]
		public virtual void onCurrentEquipDictChanged(EQUIP_DICT oldValue)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xED1720", Offset = "0xED1720", VA = "0xED1720", Slot = "29")]
		public virtual void onNameSChanged(string oldValue)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xED1724", Offset = "0xED1724", VA = "0xED1724", Slot = "30")]
		public virtual void onProgressChanged(int oldValue)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xED1728", Offset = "0xED1728", VA = "0xED1728", Slot = "31")]
		public virtual void onRoomNoChanged(int oldValue)
		{
		}

		[Token(Token = "0x6000493")]
		public abstract void onGetPropsClient(int arg1, string arg2, int arg3);

		[Token(Token = "0x6000494")]
		public abstract void onUseProp(int arg1, int arg2, int arg3, Vector3 arg4);

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xED172C", Offset = "0xED172C", VA = "0xED172C")]
		public RobotBase()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xED17DC", Offset = "0xED17DC", VA = "0xED17DC", Slot = "10")]
		public override void onComponentsEnterworld()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xED17E0", Offset = "0xED17E0", VA = "0xED17E0", Slot = "11")]
		public override void onComponentsLeaveworld()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xED17E4", Offset = "0xED17E4", VA = "0xED17E4", Slot = "7")]
		public override void onGetBase()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xED1864", Offset = "0xED1864", VA = "0xED1864", Slot = "8")]
		public override void onGetCell()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xED18E4", Offset = "0xED18E4", VA = "0xED18E4", Slot = "9")]
		public override void onLoseCell()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xED18F4", Offset = "0xED18F4", VA = "0xED18F4", Slot = "12")]
		public override EntityCall getBaseEntityCall()
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xED18FC", Offset = "0xED18FC", VA = "0xED18FC", Slot = "13")]
		public override EntityCall getCellEntityCall()
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xED1904", Offset = "0xED1904", VA = "0xED1904", Slot = "16")]
		public override void attachComponents()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xED1908", Offset = "0xED1908", VA = "0xED1908", Slot = "17")]
		public override void detachComponents()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xED190C", Offset = "0xED190C", VA = "0xED190C", Slot = "5")]
		public override void onRemoteMethodCall(MemoryStream stream)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xED1C4C", Offset = "0xED1C4C", VA = "0xED1C4C", Slot = "6")]
		public override void onUpdatePropertys(MemoryStream stream)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xED2268", Offset = "0xED2268", VA = "0xED2268", Slot = "15")]
		public override void callPropertysSetMethods()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public abstract class RoomBase : Entity
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public EntityBaseEntityCall_RoomBase baseEntityCall;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public EntityCellEntityCall_RoomBase cellEntityCall;

		[Token(Token = "0x60004A2")]
		public abstract void onEntityLoadingFinishLate(int arg1);

		[Token(Token = "0x60004A3")]
		public abstract void onLoadingFinish(int arg1);

		[Token(Token = "0x60004A4")]
		public abstract void onPropResult(int arg1, int arg2, int arg3, byte arg4);

		[Token(Token = "0x60004A5")]
		public abstract void onReachDestination(int arg1, float arg2);

		[Token(Token = "0x60004A6")]
		public abstract void onResetProps(PROP_LIST arg1);

		[Token(Token = "0x60004A7")]
		public abstract void onTimerChanged(int arg1);

		[Token(Token = "0x60004A8")]
		public abstract void onUpdateHostHeartTick(int arg1, int arg2);

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xED27E8", Offset = "0xED27E8", VA = "0xED27E8")]
		public RoomBase()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xED27F0", Offset = "0xED27F0", VA = "0xED27F0", Slot = "10")]
		public override void onComponentsEnterworld()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xED27F4", Offset = "0xED27F4", VA = "0xED27F4", Slot = "11")]
		public override void onComponentsLeaveworld()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xED27F8", Offset = "0xED27F8", VA = "0xED27F8", Slot = "7")]
		public override void onGetBase()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xED2878", Offset = "0xED2878", VA = "0xED2878", Slot = "8")]
		public override void onGetCell()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xED28F8", Offset = "0xED28F8", VA = "0xED28F8", Slot = "9")]
		public override void onLoseCell()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xED2908", Offset = "0xED2908", VA = "0xED2908", Slot = "12")]
		public override EntityCall getBaseEntityCall()
		{
			return null;
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xED2910", Offset = "0xED2910", VA = "0xED2910", Slot = "13")]
		public override EntityCall getCellEntityCall()
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xED2918", Offset = "0xED2918", VA = "0xED2918", Slot = "16")]
		public override void attachComponents()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xED291C", Offset = "0xED291C", VA = "0xED291C", Slot = "17")]
		public override void detachComponents()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xED2920", Offset = "0xED2920", VA = "0xED2920", Slot = "5")]
		public override void onRemoteMethodCall(MemoryStream stream)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xED2E38", Offset = "0xED2E38", VA = "0xED2E38", Slot = "6")]
		public override void onUpdatePropertys(MemoryStream stream)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xED3154", Offset = "0xED3154", VA = "0xED3154", Slot = "15")]
		public override void callPropertysSetMethods()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class ScriptModule
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool usePropertyDescrAlias;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool useMethodDescrAlias;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<string, Property> propertys;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Dictionary<ushort, Property> idpropertys;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, Method> methods;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Dictionary<string, Method> base_methods;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, Method> cell_methods;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Dictionary<ushort, Method> idmethods;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<ushort, Method> idbase_methods;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Dictionary<ushort, Method> idcell_methods;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Type entityScript;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xED3470", Offset = "0xED3470", VA = "0xED3470")]
		public ScriptModule(string modulename)
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public struct ServerErr
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public string descr;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort id;
	}
	[Token(Token = "0x20000F4")]
	public class ServerErrorDescrs
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<ushort, ServerErr> serverErrs;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xED3950", Offset = "0xED3950", VA = "0xED3950")]
		public ServerErrorDescrs()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xED5604", Offset = "0xED5604", VA = "0xED5604")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xED56AC", Offset = "0xED56AC", VA = "0xED56AC")]
		public string serverErrStr(ushort id)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xED57F8", Offset = "0xED57F8", VA = "0xED57F8")]
		public ServerErr serverErr(ushort id)
		{
			return default(ServerErr);
		}
	}
}
