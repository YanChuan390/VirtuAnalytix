using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using FMOD;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class FMODAsset : ScriptableObject
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string path;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string id;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE632C8", Offset = "0xE632C8", VA = "0xE632C8")]
	public FMODAsset()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB311DC", Offset = "0xB311DC")]
public class FMOD_Listener : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB3151C", Offset = "0xB3151C")]
	public string[] pluginPaths;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE63488", Offset = "0xE63488", VA = "0xE63488")]
	public FMOD_Listener()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB31214", Offset = "0xB31214")]
public class FMOD_StudioEventEmitter : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB31554", Offset = "0xB31554")]
	public FMODAsset asset;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string path;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool startEventOnAwake;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE634F0", Offset = "0xE634F0", VA = "0xE634F0")]
	public FMOD_StudioEventEmitter()
	{
	}
}
namespace FMOD
{
	[Token(Token = "0x2000005")]
	public class VERSION
	{
		[Token(Token = "0x4000007")]
		public const int number = 131080;

		[Token(Token = "0x4000008")]
		public const string dll = "fmod";

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xE7CB40", Offset = "0xE7CB40", VA = "0xE7CB40")]
		public VERSION()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class CONSTANTS
	{
		[Token(Token = "0x4000009")]
		public const int MAX_CHANNEL_WIDTH = 32;

		[Token(Token = "0x400000A")]
		public const int MAX_LISTENERS = 8;

		[Token(Token = "0x400000B")]
		public const int REVERB_MAXINSTANCES = 4;

		[Token(Token = "0x400000C")]
		public const int MAX_SYSTEMS = 8;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xE4ABE0", Offset = "0xE4ABE0", VA = "0xE4ABE0")]
		public CONSTANTS()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public enum RESULT
	{
		[Token(Token = "0x400000E")]
		OK,
		[Token(Token = "0x400000F")]
		ERR_BADCOMMAND,
		[Token(Token = "0x4000010")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x4000011")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x4000012")]
		ERR_DMA,
		[Token(Token = "0x4000013")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x4000014")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x4000015")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x4000016")]
		ERR_DSP_INUSE,
		[Token(Token = "0x4000017")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x4000018")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x4000019")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x400001A")]
		ERR_DSP_TYPE,
		[Token(Token = "0x400001B")]
		ERR_FILE_BAD,
		[Token(Token = "0x400001C")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x400001D")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x400001E")]
		ERR_FILE_EOF,
		[Token(Token = "0x400001F")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x4000020")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x4000021")]
		ERR_FORMAT,
		[Token(Token = "0x4000022")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x4000023")]
		ERR_HTTP,
		[Token(Token = "0x4000024")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x4000025")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x4000026")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x4000027")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x4000028")]
		ERR_INITIALIZATION,
		[Token(Token = "0x4000029")]
		ERR_INITIALIZED,
		[Token(Token = "0x400002A")]
		ERR_INTERNAL,
		[Token(Token = "0x400002B")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x400002C")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x400002D")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x400002E")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x400002F")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x4000030")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x4000031")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x4000032")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x4000033")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x4000034")]
		ERR_MEMORY,
		[Token(Token = "0x4000035")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x4000036")]
		ERR_NEEDS3D,
		[Token(Token = "0x4000037")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x4000038")]
		ERR_NET_CONNECT,
		[Token(Token = "0x4000039")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x400003A")]
		ERR_NET_URL,
		[Token(Token = "0x400003B")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x400003C")]
		ERR_NOTREADY,
		[Token(Token = "0x400003D")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x400003E")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x400003F")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x4000040")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x4000041")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x4000042")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x4000043")]
		ERR_PLUGIN,
		[Token(Token = "0x4000044")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x4000045")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x4000046")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x4000047")]
		ERR_RECORD,
		[Token(Token = "0x4000048")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x4000049")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x400004A")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x400004B")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x400004C")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x400004D")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x400004E")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x400004F")]
		ERR_TRUNCATED,
		[Token(Token = "0x4000050")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x4000051")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x4000052")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x4000053")]
		ERR_VERSION,
		[Token(Token = "0x4000054")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x4000055")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x4000056")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x4000057")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x4000058")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x4000059")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x400005A")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x400005B")]
		ERR_INVALID_STRING,
		[Token(Token = "0x400005C")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x400005D")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x400005E")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x400005F")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x2000008")]
	public enum CHANNELCONTROL_TYPE
	{
		[Token(Token = "0x4000061")]
		CHANNEL,
		[Token(Token = "0x4000062")]
		CHANNELGROUP,
		[Token(Token = "0x4000063")]
		MAX
	}
	[Token(Token = "0x2000009")]
	public struct VECTOR
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x200000A")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x200000B")]
	public struct ASYNCREADINFO
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint offset;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int priority;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint bytesread;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
	[Token(Token = "0x200000C")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x4000074")]
		AUTODETECT,
		[Token(Token = "0x4000075")]
		UNKNOWN,
		[Token(Token = "0x4000076")]
		NOSOUND,
		[Token(Token = "0x4000077")]
		WAVWRITER,
		[Token(Token = "0x4000078")]
		NOSOUND_NRT,
		[Token(Token = "0x4000079")]
		WAVWRITER_NRT,
		[Token(Token = "0x400007A")]
		WASAPI,
		[Token(Token = "0x400007B")]
		ASIO,
		[Token(Token = "0x400007C")]
		PULSEAUDIO,
		[Token(Token = "0x400007D")]
		ALSA,
		[Token(Token = "0x400007E")]
		COREAUDIO,
		[Token(Token = "0x400007F")]
		AUDIOTRACK,
		[Token(Token = "0x4000080")]
		OPENSL,
		[Token(Token = "0x4000081")]
		AUDIOOUT,
		[Token(Token = "0x4000082")]
		AUDIO3D,
		[Token(Token = "0x4000083")]
		WEBAUDIO,
		[Token(Token = "0x4000084")]
		NNAUDIO,
		[Token(Token = "0x4000085")]
		WINSONIC,
		[Token(Token = "0x4000086")]
		AAUDIO,
		[Token(Token = "0x4000087")]
		MAX
	}
	[Token(Token = "0x200000D")]
	public enum DEBUG_MODE
	{
		[Token(Token = "0x4000089")]
		TTY,
		[Token(Token = "0x400008A")]
		FILE,
		[Token(Token = "0x400008B")]
		CALLBACK
	}
	[Token(Token = "0x200000E")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x400008D")]
		NONE = 0u,
		[Token(Token = "0x400008E")]
		ERROR = 1u,
		[Token(Token = "0x400008F")]
		WARNING = 2u,
		[Token(Token = "0x4000090")]
		LOG = 4u,
		[Token(Token = "0x4000091")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x4000092")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x4000093")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x4000094")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x4000095")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x4000096")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x4000097")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x200000F")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		[Token(Token = "0x4000099")]
		NORMAL = 0u,
		[Token(Token = "0x400009A")]
		STREAM_FILE = 1u,
		[Token(Token = "0x400009B")]
		STREAM_DECODE = 2u,
		[Token(Token = "0x400009C")]
		SAMPLEDATA = 4u,
		[Token(Token = "0x400009D")]
		DSP_BUFFER = 8u,
		[Token(Token = "0x400009E")]
		PLUGIN = 0x10u,
		[Token(Token = "0x400009F")]
		PERSISTENT = 0x200000u,
		[Token(Token = "0x40000A0")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000010")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x40000A2")]
		DEFAULT,
		[Token(Token = "0x40000A3")]
		RAW,
		[Token(Token = "0x40000A4")]
		MONO,
		[Token(Token = "0x40000A5")]
		STEREO,
		[Token(Token = "0x40000A6")]
		QUAD,
		[Token(Token = "0x40000A7")]
		SURROUND,
		[Token(Token = "0x40000A8")]
		_5POINT1,
		[Token(Token = "0x40000A9")]
		_7POINT1,
		[Token(Token = "0x40000AA")]
		_7POINT1POINT4,
		[Token(Token = "0x40000AB")]
		MAX
	}
	[Token(Token = "0x2000011")]
	public enum SPEAKER
	{
		[Token(Token = "0x40000AD")]
		NONE = -1,
		[Token(Token = "0x40000AE")]
		FRONT_LEFT,
		[Token(Token = "0x40000AF")]
		FRONT_RIGHT,
		[Token(Token = "0x40000B0")]
		FRONT_CENTER,
		[Token(Token = "0x40000B1")]
		LOW_FREQUENCY,
		[Token(Token = "0x40000B2")]
		SURROUND_LEFT,
		[Token(Token = "0x40000B3")]
		SURROUND_RIGHT,
		[Token(Token = "0x40000B4")]
		BACK_LEFT,
		[Token(Token = "0x40000B5")]
		BACK_RIGHT,
		[Token(Token = "0x40000B6")]
		TOP_FRONT_LEFT,
		[Token(Token = "0x40000B7")]
		TOP_FRONT_RIGHT,
		[Token(Token = "0x40000B8")]
		TOP_BACK_LEFT,
		[Token(Token = "0x40000B9")]
		TOP_BACK_RIGHT,
		[Token(Token = "0x40000BA")]
		MAX
	}
	[Token(Token = "0x2000012")]
	[Flags]
	public enum CHANNELMASK : uint
	{
		[Token(Token = "0x40000BC")]
		FRONT_LEFT = 1u,
		[Token(Token = "0x40000BD")]
		FRONT_RIGHT = 2u,
		[Token(Token = "0x40000BE")]
		FRONT_CENTER = 4u,
		[Token(Token = "0x40000BF")]
		LOW_FREQUENCY = 8u,
		[Token(Token = "0x40000C0")]
		SURROUND_LEFT = 0x10u,
		[Token(Token = "0x40000C1")]
		SURROUND_RIGHT = 0x20u,
		[Token(Token = "0x40000C2")]
		BACK_LEFT = 0x40u,
		[Token(Token = "0x40000C3")]
		BACK_RIGHT = 0x80u,
		[Token(Token = "0x40000C4")]
		BACK_CENTER = 0x100u,
		[Token(Token = "0x40000C5")]
		MONO = 1u,
		[Token(Token = "0x40000C6")]
		STEREO = 3u,
		[Token(Token = "0x40000C7")]
		LRC = 7u,
		[Token(Token = "0x40000C8")]
		QUAD = 0x33u,
		[Token(Token = "0x40000C9")]
		SURROUND = 0x37u,
		[Token(Token = "0x40000CA")]
		_5POINT1 = 0x3Fu,
		[Token(Token = "0x40000CB")]
		_5POINT1_REARS = 0xCFu,
		[Token(Token = "0x40000CC")]
		_7POINT0 = 0xF7u,
		[Token(Token = "0x40000CD")]
		_7POINT1 = 0xFFu
	}
	[Token(Token = "0x2000013")]
	public enum CHANNELORDER
	{
		[Token(Token = "0x40000CF")]
		DEFAULT,
		[Token(Token = "0x40000D0")]
		WAVEFORMAT,
		[Token(Token = "0x40000D1")]
		PROTOOLS,
		[Token(Token = "0x40000D2")]
		ALLMONO,
		[Token(Token = "0x40000D3")]
		ALLSTEREO,
		[Token(Token = "0x40000D4")]
		ALSA,
		[Token(Token = "0x40000D5")]
		MAX
	}
	[Token(Token = "0x2000014")]
	public enum PLUGINTYPE
	{
		[Token(Token = "0x40000D7")]
		OUTPUT,
		[Token(Token = "0x40000D8")]
		CODEC,
		[Token(Token = "0x40000D9")]
		DSP,
		[Token(Token = "0x40000DA")]
		MAX
	}
	[Token(Token = "0x2000015")]
	public struct PLUGINLIST
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PLUGINTYPE type;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr description;
	}
	[Token(Token = "0x2000016")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x40000DE")]
		NORMAL = 0u,
		[Token(Token = "0x40000DF")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x40000E0")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x40000E1")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x40000E2")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x40000E3")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x40000E4")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x40000E5")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x40000E6")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x40000E7")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x40000E8")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x40000E9")]
		PROFILE_METER_ALL = 0x200000u,
		[Token(Token = "0x40000EA")]
		MEMORY_TRACKING = 0x400000u
	}
	[Token(Token = "0x2000017")]
	public enum SOUND_TYPE
	{
		[Token(Token = "0x40000EC")]
		UNKNOWN,
		[Token(Token = "0x40000ED")]
		AIFF,
		[Token(Token = "0x40000EE")]
		ASF,
		[Token(Token = "0x40000EF")]
		DLS,
		[Token(Token = "0x40000F0")]
		FLAC,
		[Token(Token = "0x40000F1")]
		FSB,
		[Token(Token = "0x40000F2")]
		IT,
		[Token(Token = "0x40000F3")]
		MIDI,
		[Token(Token = "0x40000F4")]
		MOD,
		[Token(Token = "0x40000F5")]
		MPEG,
		[Token(Token = "0x40000F6")]
		OGGVORBIS,
		[Token(Token = "0x40000F7")]
		PLAYLIST,
		[Token(Token = "0x40000F8")]
		RAW,
		[Token(Token = "0x40000F9")]
		S3M,
		[Token(Token = "0x40000FA")]
		USER,
		[Token(Token = "0x40000FB")]
		WAV,
		[Token(Token = "0x40000FC")]
		XM,
		[Token(Token = "0x40000FD")]
		XMA,
		[Token(Token = "0x40000FE")]
		AUDIOQUEUE,
		[Token(Token = "0x40000FF")]
		AT9,
		[Token(Token = "0x4000100")]
		VORBIS,
		[Token(Token = "0x4000101")]
		MEDIA_FOUNDATION,
		[Token(Token = "0x4000102")]
		MEDIACODEC,
		[Token(Token = "0x4000103")]
		FADPCM,
		[Token(Token = "0x4000104")]
		OPUS,
		[Token(Token = "0x4000105")]
		MAX
	}
	[Token(Token = "0x2000018")]
	public enum SOUND_FORMAT
	{
		[Token(Token = "0x4000107")]
		NONE,
		[Token(Token = "0x4000108")]
		PCM8,
		[Token(Token = "0x4000109")]
		PCM16,
		[Token(Token = "0x400010A")]
		PCM24,
		[Token(Token = "0x400010B")]
		PCM32,
		[Token(Token = "0x400010C")]
		PCMFLOAT,
		[Token(Token = "0x400010D")]
		BITSTREAM,
		[Token(Token = "0x400010E")]
		MAX
	}
	[Token(Token = "0x2000019")]
	[Flags]
	public enum MODE : uint
	{
		[Token(Token = "0x4000110")]
		DEFAULT = 0u,
		[Token(Token = "0x4000111")]
		LOOP_OFF = 1u,
		[Token(Token = "0x4000112")]
		LOOP_NORMAL = 2u,
		[Token(Token = "0x4000113")]
		LOOP_BIDI = 4u,
		[Token(Token = "0x4000114")]
		_2D = 8u,
		[Token(Token = "0x4000115")]
		_3D = 0x10u,
		[Token(Token = "0x4000116")]
		CREATESTREAM = 0x80u,
		[Token(Token = "0x4000117")]
		CREATESAMPLE = 0x100u,
		[Token(Token = "0x4000118")]
		CREATECOMPRESSEDSAMPLE = 0x200u,
		[Token(Token = "0x4000119")]
		OPENUSER = 0x400u,
		[Token(Token = "0x400011A")]
		OPENMEMORY = 0x800u,
		[Token(Token = "0x400011B")]
		OPENMEMORY_POINT = 0x10000000u,
		[Token(Token = "0x400011C")]
		OPENRAW = 0x1000u,
		[Token(Token = "0x400011D")]
		OPENONLY = 0x2000u,
		[Token(Token = "0x400011E")]
		ACCURATETIME = 0x4000u,
		[Token(Token = "0x400011F")]
		MPEGSEARCH = 0x8000u,
		[Token(Token = "0x4000120")]
		NONBLOCKING = 0x10000u,
		[Token(Token = "0x4000121")]
		UNIQUE = 0x20000u,
		[Token(Token = "0x4000122")]
		_3D_HEADRELATIVE = 0x40000u,
		[Token(Token = "0x4000123")]
		_3D_WORLDRELATIVE = 0x80000u,
		[Token(Token = "0x4000124")]
		_3D_INVERSEROLLOFF = 0x100000u,
		[Token(Token = "0x4000125")]
		_3D_LINEARROLLOFF = 0x200000u,
		[Token(Token = "0x4000126")]
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		[Token(Token = "0x4000127")]
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		[Token(Token = "0x4000128")]
		_3D_CUSTOMROLLOFF = 0x4000000u,
		[Token(Token = "0x4000129")]
		_3D_IGNOREGEOMETRY = 0x40000000u,
		[Token(Token = "0x400012A")]
		IGNORETAGS = 0x2000000u,
		[Token(Token = "0x400012B")]
		LOWMEM = 0x8000000u,
		[Token(Token = "0x400012C")]
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	[Token(Token = "0x200001A")]
	public enum OPENSTATE
	{
		[Token(Token = "0x400012E")]
		READY,
		[Token(Token = "0x400012F")]
		LOADING,
		[Token(Token = "0x4000130")]
		ERROR,
		[Token(Token = "0x4000131")]
		CONNECTING,
		[Token(Token = "0x4000132")]
		BUFFERING,
		[Token(Token = "0x4000133")]
		SEEKING,
		[Token(Token = "0x4000134")]
		PLAYING,
		[Token(Token = "0x4000135")]
		SETPOSITION,
		[Token(Token = "0x4000136")]
		MAX
	}
	[Token(Token = "0x200001B")]
	public enum SOUNDGROUP_BEHAVIOR
	{
		[Token(Token = "0x4000138")]
		BEHAVIOR_FAIL,
		[Token(Token = "0x4000139")]
		BEHAVIOR_MUTE,
		[Token(Token = "0x400013A")]
		BEHAVIOR_STEALLOWEST,
		[Token(Token = "0x400013B")]
		MAX
	}
	[Token(Token = "0x200001C")]
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		[Token(Token = "0x400013D")]
		END,
		[Token(Token = "0x400013E")]
		VIRTUALVOICE,
		[Token(Token = "0x400013F")]
		SYNCPOINT,
		[Token(Token = "0x4000140")]
		OCCLUSION,
		[Token(Token = "0x4000141")]
		MAX
	}
	[Token(Token = "0x200001D")]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		[Token(Token = "0x4000142")]
		public const int HEAD = -1;

		[Token(Token = "0x4000143")]
		public const int FADER = -2;

		[Token(Token = "0x4000144")]
		public const int TAIL = -3;
	}
	[Token(Token = "0x200001E")]
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		[Token(Token = "0x4000146")]
		NONE,
		[Token(Token = "0x4000147")]
		SYSTEM,
		[Token(Token = "0x4000148")]
		CHANNEL,
		[Token(Token = "0x4000149")]
		CHANNELGROUP,
		[Token(Token = "0x400014A")]
		CHANNELCONTROL,
		[Token(Token = "0x400014B")]
		SOUND,
		[Token(Token = "0x400014C")]
		SOUNDGROUP,
		[Token(Token = "0x400014D")]
		DSP,
		[Token(Token = "0x400014E")]
		DSPCONNECTION,
		[Token(Token = "0x400014F")]
		GEOMETRY,
		[Token(Token = "0x4000150")]
		REVERB3D,
		[Token(Token = "0x4000151")]
		STUDIO_SYSTEM,
		[Token(Token = "0x4000152")]
		STUDIO_EVENTDESCRIPTION,
		[Token(Token = "0x4000153")]
		STUDIO_EVENTINSTANCE,
		[Token(Token = "0x4000154")]
		STUDIO_PARAMETERINSTANCE,
		[Token(Token = "0x4000155")]
		STUDIO_BUS,
		[Token(Token = "0x4000156")]
		STUDIO_VCA,
		[Token(Token = "0x4000157")]
		STUDIO_BANK,
		[Token(Token = "0x4000158")]
		STUDIO_COMMANDREPLAY
	}
	[Token(Token = "0x200001F")]
	public struct ERRORCALLBACK_INFO
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RESULT result;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
	[Token(Token = "0x2000020")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x400015F")]
		DEVICELISTCHANGED = 1u,
		[Token(Token = "0x4000160")]
		DEVICELOST = 2u,
		[Token(Token = "0x4000161")]
		MEMORYALLOCATIONFAILED = 4u,
		[Token(Token = "0x4000162")]
		THREADCREATED = 8u,
		[Token(Token = "0x4000163")]
		BADDSPCONNECTION = 0x10u,
		[Token(Token = "0x4000164")]
		PREMIX = 0x20u,
		[Token(Token = "0x4000165")]
		POSTMIX = 0x40u,
		[Token(Token = "0x4000166")]
		ERROR = 0x80u,
		[Token(Token = "0x4000167")]
		MIDMIX = 0x100u,
		[Token(Token = "0x4000168")]
		THREADDESTROYED = 0x200u,
		[Token(Token = "0x4000169")]
		PREUPDATE = 0x400u,
		[Token(Token = "0x400016A")]
		POSTUPDATE = 0x800u,
		[Token(Token = "0x400016B")]
		RECORDLISTCHANGED = 0x1000u,
		[Token(Token = "0x400016C")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x2000021")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x2000022")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	[Token(Token = "0x2000023")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
	[Token(Token = "0x2000024")]
	public delegate RESULT SOUND_NONBLOCK_CALLBACK(IntPtr sound, RESULT result);
	[Token(Token = "0x2000025")]
	public delegate RESULT SOUND_PCMREAD_CALLBACK(IntPtr sound, IntPtr data, uint datalen);
	[Token(Token = "0x2000026")]
	public delegate RESULT SOUND_PCMSETPOS_CALLBACK(IntPtr sound, int subsound, uint position, TIMEUNIT postype);
	[Token(Token = "0x2000027")]
	public delegate RESULT FILE_OPEN_CALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000028")]
	public delegate RESULT FILE_CLOSE_CALLBACK(IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000029")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	[Token(Token = "0x200002A")]
	public delegate RESULT FILE_SEEK_CALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	[Token(Token = "0x200002B")]
	public delegate RESULT FILE_ASYNCREAD_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x200002C")]
	public delegate RESULT FILE_ASYNCCANCEL_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x200002D")]
	public delegate RESULT FILE_ASYNCDONE_FUNC(IntPtr info, RESULT result);
	[Token(Token = "0x200002E")]
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200002F")]
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000030")]
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000031")]
	public delegate float CB_3D_ROLLOFF_CALLBACK(IntPtr channelcontrol, float distance);
	[Token(Token = "0x2000032")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x400016E")]
		DEFAULT,
		[Token(Token = "0x400016F")]
		NOINTERP,
		[Token(Token = "0x4000170")]
		LINEAR,
		[Token(Token = "0x4000171")]
		CUBIC,
		[Token(Token = "0x4000172")]
		SPLINE,
		[Token(Token = "0x4000173")]
		MAX
	}
	[Token(Token = "0x2000033")]
	public enum DSPCONNECTION_TYPE
	{
		[Token(Token = "0x4000175")]
		STANDARD,
		[Token(Token = "0x4000176")]
		SIDECHAIN,
		[Token(Token = "0x4000177")]
		SEND,
		[Token(Token = "0x4000178")]
		SEND_SIDECHAIN,
		[Token(Token = "0x4000179")]
		MAX
	}
	[Token(Token = "0x2000034")]
	public enum TAGTYPE
	{
		[Token(Token = "0x400017B")]
		UNKNOWN,
		[Token(Token = "0x400017C")]
		ID3V1,
		[Token(Token = "0x400017D")]
		ID3V2,
		[Token(Token = "0x400017E")]
		VORBISCOMMENT,
		[Token(Token = "0x400017F")]
		SHOUTCAST,
		[Token(Token = "0x4000180")]
		ICECAST,
		[Token(Token = "0x4000181")]
		ASF,
		[Token(Token = "0x4000182")]
		MIDI,
		[Token(Token = "0x4000183")]
		PLAYLIST,
		[Token(Token = "0x4000184")]
		FMOD,
		[Token(Token = "0x4000185")]
		USER,
		[Token(Token = "0x4000186")]
		MAX
	}
	[Token(Token = "0x2000035")]
	public enum TAGDATATYPE
	{
		[Token(Token = "0x4000188")]
		BINARY,
		[Token(Token = "0x4000189")]
		INT,
		[Token(Token = "0x400018A")]
		FLOAT,
		[Token(Token = "0x400018B")]
		STRING,
		[Token(Token = "0x400018C")]
		STRING_UTF16,
		[Token(Token = "0x400018D")]
		STRING_UTF16BE,
		[Token(Token = "0x400018E")]
		STRING_UTF8,
		[Token(Token = "0x400018F")]
		MAX
	}
	[Token(Token = "0x2000036")]
	public struct TAG
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr data;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint datalen;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
	[Token(Token = "0x2000037")]
	[Flags]
	public enum TIMEUNIT : uint
	{
		[Token(Token = "0x4000197")]
		MS = 1u,
		[Token(Token = "0x4000198")]
		PCM = 2u,
		[Token(Token = "0x4000199")]
		PCMBYTES = 4u,
		[Token(Token = "0x400019A")]
		RAWBYTES = 8u,
		[Token(Token = "0x400019B")]
		PCMFRACTION = 0x10u,
		[Token(Token = "0x400019C")]
		MODORDER = 0x100u,
		[Token(Token = "0x400019D")]
		MODROW = 0x200u,
		[Token(Token = "0x400019E")]
		MODPATTERN = 0x400u
	}
	[Token(Token = "0x2000038")]
	public struct PORT_INDEX
	{
		[Token(Token = "0x400019F")]
		public const ulong NONE = ulong.MaxValue;
	}
	[Token(Token = "0x2000039")]
	public struct CREATESOUNDEXINFO
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint length;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int numchannels;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FILE_OPEN_CALLBACK fileuseropen;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FILE_CLOSE_CALLBACK fileuserclose;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FILE_READ_CALLBACK fileuserread;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FILE_SEEK_CALLBACK fileuserseek;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;
	}
	[Token(Token = "0x200003A")]
	public struct REVERB_PROPERTIES
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DecayTime;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float LateDelay;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float HFReference;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Diffusion;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Density;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HighCut;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WetLevel;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xE64F80", Offset = "0xE64F80", VA = "0xE64F80")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class PRESET
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0xE64F5C", Offset = "0xE64F5C", VA = "0xE64F5C")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xE64FAC", Offset = "0xE64FAC", VA = "0xE64FAC")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xE64FD0", Offset = "0xE64FD0", VA = "0xE64FD0")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xE64FF4", Offset = "0xE64FF4", VA = "0xE64FF4")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xE65018", Offset = "0xE65018", VA = "0xE65018")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xE6503C", Offset = "0xE6503C", VA = "0xE6503C")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xE65060", Offset = "0xE65060", VA = "0xE65060")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xE65084", Offset = "0xE65084", VA = "0xE65084")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE650A8", Offset = "0xE650A8", VA = "0xE650A8")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE650CC", Offset = "0xE650CC", VA = "0xE650CC")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE650F0", Offset = "0xE650F0", VA = "0xE650F0")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE65114", Offset = "0xE65114", VA = "0xE65114")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE65138", Offset = "0xE65138", VA = "0xE65138")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE6515C", Offset = "0xE6515C", VA = "0xE6515C")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE65180", Offset = "0xE65180", VA = "0xE65180")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE651A4", Offset = "0xE651A4", VA = "0xE651A4")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xE651C8", Offset = "0xE651C8", VA = "0xE651C8")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE651EC", Offset = "0xE651EC", VA = "0xE651EC")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE65210", Offset = "0xE65210", VA = "0xE65210")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE65234", Offset = "0xE65234", VA = "0xE65234")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE65258", Offset = "0xE65258", VA = "0xE65258")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE6527C", Offset = "0xE6527C", VA = "0xE6527C")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE652A0", Offset = "0xE652A0", VA = "0xE652A0")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE652C4", Offset = "0xE652C4", VA = "0xE652C4")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE652E8", Offset = "0xE652E8", VA = "0xE652E8")]
		public PRESET()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x200003D")]
	[Flags]
	public enum DRIVER_STATE : uint
	{
		[Token(Token = "0x40001E9")]
		CONNECTED = 1u,
		[Token(Token = "0x40001EA")]
		DEFAULT = 2u
	}
	[Token(Token = "0x200003E")]
	public struct Factory
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE63554", Offset = "0xE63554", VA = "0xE63554")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE63558", Offset = "0xE63558", VA = "0xE63558")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[Token(Token = "0x200003F")]
	public struct Memory
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE64DD8", Offset = "0xE64DD8", VA = "0xE64DD8")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE64EBC", Offset = "0xE64EBC", VA = "0xE64EBC")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE64DDC", Offset = "0xE64DDC", VA = "0xE64DDC")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE64EC4", Offset = "0xE64EC4", VA = "0xE64EC4")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x2000040")]
	public struct Debug
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE5DC5C", Offset = "0xE5DC5C", VA = "0xE5DC5C")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE5DDF4", Offset = "0xE5DDF4", VA = "0xE5DDF4")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x2000041")]
	public struct System
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE73858", Offset = "0xE73858", VA = "0xE73858")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xE67C5C", Offset = "0xE67C5C", VA = "0xE67C5C")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE73970", Offset = "0xE73970", VA = "0xE73970")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xE73A08", Offset = "0xE73A08", VA = "0xE73A08")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xE73AA0", Offset = "0xE73AA0", VA = "0xE73AA0")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE73DB8", Offset = "0xE73DB8", VA = "0xE73DB8")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE73E4C", Offset = "0xE73E4C", VA = "0xE73E4C")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE73EE4", Offset = "0xE73EE4", VA = "0xE73EE4")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE67C64", Offset = "0xE67C64", VA = "0xE67C64")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE7400C", Offset = "0xE7400C", VA = "0xE7400C")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE67C6C", Offset = "0xE67C6C", VA = "0xE67C6C")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE7414C", Offset = "0xE7414C", VA = "0xE7414C")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE741FC", Offset = "0xE741FC", VA = "0xE741FC")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE7429C", Offset = "0xE7429C", VA = "0xE7429C")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE7433C", Offset = "0xE7433C", VA = "0xE7433C")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE74460", Offset = "0xE74460", VA = "0xE74460")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE67C74", Offset = "0xE67C74", VA = "0xE67C74")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE745D4", Offset = "0xE745D4", VA = "0xE745D4")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE74728", Offset = "0xE74728", VA = "0xE74728")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE747D0", Offset = "0xE747D0", VA = "0xE747D0")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE6CEE8", Offset = "0xE6CEE8", VA = "0xE6CEE8")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xE74AA4", Offset = "0xE74AA4", VA = "0xE74AA4")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE74B3C", Offset = "0xE74B3C", VA = "0xE74B3C")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xE74BDC", Offset = "0xE74BDC", VA = "0xE74BDC")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xE74C8C", Offset = "0xE74C8C", VA = "0xE74C8C")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE74D2C", Offset = "0xE74D2C", VA = "0xE74D2C")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE74DDC", Offset = "0xE74DDC", VA = "0xE74DDC")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE750BC", Offset = "0xE750BC", VA = "0xE750BC")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE7512C", Offset = "0xE7512C", VA = "0xE7512C")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE751C4", Offset = "0xE751C4", VA = "0xE751C4")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE7525C", Offset = "0xE7525C", VA = "0xE7525C")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE752FC", Offset = "0xE752FC", VA = "0xE752FC")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE7539C", Offset = "0xE7539C", VA = "0xE7539C")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE7549C", Offset = "0xE7549C", VA = "0xE7549C")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE7554C", Offset = "0xE7554C", VA = "0xE7554C")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE755D4", Offset = "0xE755D4", VA = "0xE755D4")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE7565C", Offset = "0xE7565C", VA = "0xE7565C")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE75718", Offset = "0xE75718", VA = "0xE75718")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE757E4", Offset = "0xE757E4", VA = "0xE757E4")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE75884", Offset = "0xE75884", VA = "0xE75884")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE75924", Offset = "0xE75924", VA = "0xE75924")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE759D4", Offset = "0xE759D4", VA = "0xE759D4")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE75A84", Offset = "0xE75A84", VA = "0xE75A84")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE75B1C", Offset = "0xE75B1C", VA = "0xE75B1C")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE75BB4", Offset = "0xE75BB4", VA = "0xE75BB4")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE75C7C", Offset = "0xE75C7C", VA = "0xE75C7C")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE75D44", Offset = "0xE75D44", VA = "0xE75D44")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE6A174", Offset = "0xE6A174", VA = "0xE6A174")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE6A17C", Offset = "0xE6A17C", VA = "0xE6A17C")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xE75EE4", Offset = "0xE75EE4", VA = "0xE75EE4")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xE75FA4", Offset = "0xE75FA4", VA = "0xE75FA4")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xE76044", Offset = "0xE76044", VA = "0xE76044")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xE760DC", Offset = "0xE760DC", VA = "0xE760DC")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE76174", Offset = "0xE76174", VA = "0xE76174")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE69ED8", Offset = "0xE69ED8", VA = "0xE69ED8")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE762F8", Offset = "0xE762F8", VA = "0xE762F8")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xE763C0", Offset = "0xE763C0", VA = "0xE763C0")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE76470", Offset = "0xE76470", VA = "0xE76470")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE7673C", Offset = "0xE7673C", VA = "0xE7673C")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE76744", Offset = "0xE76744", VA = "0xE76744")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE76860", Offset = "0xE76860", VA = "0xE76860")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE76950", Offset = "0xE76950", VA = "0xE76950")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xE76C1C", Offset = "0xE76C1C", VA = "0xE76C1C")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE76C24", Offset = "0xE76C24", VA = "0xE76C24")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xE76D40", Offset = "0xE76D40", VA = "0xE76D40")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE76E30", Offset = "0xE76E30", VA = "0xE76E30")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE76F34", Offset = "0xE76F34", VA = "0xE76F34")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE76FD4", Offset = "0xE76FD4", VA = "0xE76FD4")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE77208", Offset = "0xE77208", VA = "0xE77208")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE7743C", Offset = "0xE7743C", VA = "0xE7743C")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE774D4", Offset = "0xE774D4", VA = "0xE774D4")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE77590", Offset = "0xE77590", VA = "0xE77590")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE7764C", Offset = "0xE7764C", VA = "0xE7764C")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE69EC8", Offset = "0xE69EC8", VA = "0xE69EC8")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE7777C", Offset = "0xE7777C", VA = "0xE7777C")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE77814", Offset = "0xE77814", VA = "0xE77814")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE778D0", Offset = "0xE778D0", VA = "0xE778D0")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE77968", Offset = "0xE77968", VA = "0xE77968")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE77A08", Offset = "0xE77A08", VA = "0xE77A08")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE77AA8", Offset = "0xE77AA8", VA = "0xE77AA8")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE77B30", Offset = "0xE77B30", VA = "0xE77B30")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE77BB8", Offset = "0xE77BB8", VA = "0xE77BB8")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE77C58", Offset = "0xE77C58", VA = "0xE77C58")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE77F80", Offset = "0xE77F80", VA = "0xE77F80")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE7801C", Offset = "0xE7801C", VA = "0xE7801C")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE780BC", Offset = "0xE780BC", VA = "0xE780BC")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE7816C", Offset = "0xE7816C", VA = "0xE7816C")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE78204", Offset = "0xE78204", VA = "0xE78204")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xE782B8", Offset = "0xE782B8", VA = "0xE782B8")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xE78368", Offset = "0xE78368", VA = "0xE78368")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE78400", Offset = "0xE78400", VA = "0xE78400")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE78498", Offset = "0xE78498", VA = "0xE78498")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE78548", Offset = "0xE78548", VA = "0xE78548")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE78600", Offset = "0xE78600", VA = "0xE78600")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE78824", Offset = "0xE78824", VA = "0xE78824")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xE78AC4", Offset = "0xE78AC4", VA = "0xE78AC4")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE78B5C", Offset = "0xE78B5C", VA = "0xE78B5C")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE78BF4", Offset = "0xE78BF4", VA = "0xE78BF4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE78C8C", Offset = "0xE78C8C", VA = "0xE78C8C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xE73860", Offset = "0xE73860", VA = "0xE73860")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xE738E0", Offset = "0xE738E0", VA = "0xE738E0")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xE73978", Offset = "0xE73978", VA = "0xE73978")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xE73A10", Offset = "0xE73A10", VA = "0xE73A10")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xE73CE0", Offset = "0xE73CE0", VA = "0xE73CE0")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xE73E54", Offset = "0xE73E54", VA = "0xE73E54")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xE73EEC", Offset = "0xE73EEC", VA = "0xE73EEC")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE73F7C", Offset = "0xE73F7C", VA = "0xE73F7C")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE74014", Offset = "0xE74014", VA = "0xE74014")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xE740A4", Offset = "0xE740A4", VA = "0xE740A4")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xE74154", Offset = "0xE74154", VA = "0xE74154")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xE74204", Offset = "0xE74204", VA = "0xE74204")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xE742A4", Offset = "0xE742A4", VA = "0xE742A4")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xE74344", Offset = "0xE74344", VA = "0xE74344")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xE74468", Offset = "0xE74468", VA = "0xE74468")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xE74544", Offset = "0xE74544", VA = "0xE74544")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE74698", Offset = "0xE74698", VA = "0xE74698")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xE74730", Offset = "0xE74730", VA = "0xE74730")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE7495C", Offset = "0xE7495C", VA = "0xE7495C")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xE749F4", Offset = "0xE749F4", VA = "0xE749F4")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xE74AAC", Offset = "0xE74AAC", VA = "0xE74AAC")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xE74B44", Offset = "0xE74B44", VA = "0xE74B44")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xE74BE4", Offset = "0xE74BE4", VA = "0xE74BE4")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE74C94", Offset = "0xE74C94", VA = "0xE74C94")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE74D34", Offset = "0xE74D34", VA = "0xE74D34")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xE74FFC", Offset = "0xE74FFC", VA = "0xE74FFC")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xE75134", Offset = "0xE75134", VA = "0xE75134")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xE751CC", Offset = "0xE751CC", VA = "0xE751CC")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xE75264", Offset = "0xE75264", VA = "0xE75264")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xE75304", Offset = "0xE75304", VA = "0xE75304")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xE753A4", Offset = "0xE753A4", VA = "0xE753A4")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xE754A4", Offset = "0xE754A4", VA = "0xE754A4")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xE75554", Offset = "0xE75554", VA = "0xE75554")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xE755DC", Offset = "0xE755DC", VA = "0xE755DC")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xE75668", Offset = "0xE75668", VA = "0xE75668")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xE75720", Offset = "0xE75720", VA = "0xE75720")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xE757EC", Offset = "0xE757EC", VA = "0xE757EC")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xE7588C", Offset = "0xE7588C", VA = "0xE7588C")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xE7592C", Offset = "0xE7592C", VA = "0xE7592C")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE759DC", Offset = "0xE759DC", VA = "0xE759DC")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE75A8C", Offset = "0xE75A8C", VA = "0xE75A8C")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE75B24", Offset = "0xE75B24", VA = "0xE75B24")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xE75BBC", Offset = "0xE75BBC", VA = "0xE75BBC")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xE75C84", Offset = "0xE75C84", VA = "0xE75C84")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xE75D4C", Offset = "0xE75D4C", VA = "0xE75D4C")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xE75DE4", Offset = "0xE75DE4", VA = "0xE75DE4")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xE75E64", Offset = "0xE75E64", VA = "0xE75E64")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE75EEC", Offset = "0xE75EEC", VA = "0xE75EEC")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE75FAC", Offset = "0xE75FAC", VA = "0xE75FAC")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE7604C", Offset = "0xE7604C", VA = "0xE7604C")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xE760E4", Offset = "0xE760E4", VA = "0xE760E4")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xE761C8", Offset = "0xE761C8", VA = "0xE761C8")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0xE76260", Offset = "0xE76260", VA = "0xE76260")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xE76300", Offset = "0xE76300", VA = "0xE76300")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xE763C8", Offset = "0xE763C8", VA = "0xE763C8")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0xE7661C", Offset = "0xE7661C", VA = "0xE7661C")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0xE7674C", Offset = "0xE7674C", VA = "0xE7674C")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE76AFC", Offset = "0xE76AFC", VA = "0xE76AFC")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE76C2C", Offset = "0xE76C2C", VA = "0xE76C2C")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE76E38", Offset = "0xE76E38", VA = "0xE76E38")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE76F3C", Offset = "0xE76F3C", VA = "0xE76F3C")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE77168", Offset = "0xE77168", VA = "0xE77168")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0xE7739C", Offset = "0xE7739C", VA = "0xE7739C")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0xE77444", Offset = "0xE77444", VA = "0xE77444")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0xE774E0", Offset = "0xE774E0", VA = "0xE774E0")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000110")]
		[Address(RVA = "0xE7759C", Offset = "0xE7759C", VA = "0xE7759C")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000111")]
		[Address(RVA = "0xE77654", Offset = "0xE77654", VA = "0xE77654")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000112")]
		[Address(RVA = "0xE776EC", Offset = "0xE776EC", VA = "0xE776EC")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000113")]
		[Address(RVA = "0xE77784", Offset = "0xE77784", VA = "0xE77784")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE77820", Offset = "0xE77820", VA = "0xE77820")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE778D8", Offset = "0xE778D8", VA = "0xE778D8")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE77970", Offset = "0xE77970", VA = "0xE77970")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE77A10", Offset = "0xE77A10", VA = "0xE77A10")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE77AB0", Offset = "0xE77AB0", VA = "0xE77AB0")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE77B38", Offset = "0xE77B38", VA = "0xE77B38")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE77BC0", Offset = "0xE77BC0", VA = "0xE77BC0")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE77EA0", Offset = "0xE77EA0", VA = "0xE77EA0")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE78024", Offset = "0xE78024", VA = "0xE78024")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE780C8", Offset = "0xE780C8", VA = "0xE780C8")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE78174", Offset = "0xE78174", VA = "0xE78174")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE7820C", Offset = "0xE7820C", VA = "0xE7820C")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xE782C0", Offset = "0xE782C0", VA = "0xE782C0")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000121")]
		[Address(RVA = "0xE78370", Offset = "0xE78370", VA = "0xE78370")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000122")]
		[Address(RVA = "0xE78408", Offset = "0xE78408", VA = "0xE78408")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE784A0", Offset = "0xE784A0", VA = "0xE784A0")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0xE78550", Offset = "0xE78550", VA = "0xE78550")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x6000125")]
		[Address(RVA = "0xE7878C", Offset = "0xE7878C", VA = "0xE7878C")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE78A2C", Offset = "0xE78A2C", VA = "0xE78A2C")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x6000127")]
		[Address(RVA = "0xE78ACC", Offset = "0xE78ACC", VA = "0xE78ACC")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x6000128")]
		[Address(RVA = "0xE78B64", Offset = "0xE78B64", VA = "0xE78B64")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x6000129")]
		[Address(RVA = "0xE78BFC", Offset = "0xE78BFC", VA = "0xE78BFC")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600012A")]
		[Address(RVA = "0xE78C94", Offset = "0xE78C94", VA = "0xE78C94")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xE78D24", Offset = "0xE78D24", VA = "0xE78D24")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE78D6C", Offset = "0xE78D6C", VA = "0xE78D6C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public struct Sound
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE6EC74", Offset = "0xE6EC74", VA = "0xE6EC74")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xE6ECFC", Offset = "0xE6ECFC", VA = "0xE6ECFC")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE6ED94", Offset = "0xE6ED94", VA = "0xE6ED94")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE6EE64", Offset = "0xE6EE64", VA = "0xE6EE64")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE6EF1C", Offset = "0xE6EF1C", VA = "0xE6EF1C")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE6EFC4", Offset = "0xE6EFC4", VA = "0xE6EFC4")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE6F064", Offset = "0xE6F064", VA = "0xE6F064")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xE6F104", Offset = "0xE6F104", VA = "0xE6F104")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xE6F1A4", Offset = "0xE6F1A4", VA = "0xE6F1A4")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE6F254", Offset = "0xE6F254", VA = "0xE6F254")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE6F304", Offset = "0xE6F304", VA = "0xE6F304")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE6F3A4", Offset = "0xE6F3A4", VA = "0xE6F3A4")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE6F444", Offset = "0xE6F444", VA = "0xE6F444")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE6F4E4", Offset = "0xE6F4E4", VA = "0xE6F4E4")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE6F57C", Offset = "0xE6F57C", VA = "0xE6F57C")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE6F81C", Offset = "0xE6F81C", VA = "0xE6F81C")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE6F8BC", Offset = "0xE6F8BC", VA = "0xE6F8BC")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE6F974", Offset = "0xE6F974", VA = "0xE6F974")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE6FA0C", Offset = "0xE6FA0C", VA = "0xE6FA0C")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE6FAAC", Offset = "0xE6FAAC", VA = "0xE6FAAC")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE6FD2C", Offset = "0xE6FD2C", VA = "0xE6FD2C")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE6FE08", Offset = "0xE6FE08", VA = "0xE6FE08")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE6FEB8", Offset = "0xE6FEB8", VA = "0xE6FEB8")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE6FF50", Offset = "0xE6FF50", VA = "0xE6FF50")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE6FFE8", Offset = "0xE6FFE8", VA = "0xE6FFE8")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE70080", Offset = "0xE70080", VA = "0xE70080")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xE70118", Offset = "0xE70118", VA = "0xE70118")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE701B8", Offset = "0xE701B8", VA = "0xE701B8")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE70498", Offset = "0xE70498", VA = "0xE70498")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xE70508", Offset = "0xE70508", VA = "0xE70508")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE7076C", Offset = "0xE7076C", VA = "0xE7076C")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE70804", Offset = "0xE70804", VA = "0xE70804")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE7089C", Offset = "0xE7089C", VA = "0xE7089C")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE70934", Offset = "0xE70934", VA = "0xE70934")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE709CC", Offset = "0xE709CC", VA = "0xE709CC")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE70A64", Offset = "0xE70A64", VA = "0xE70A64")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE70B1C", Offset = "0xE70B1C", VA = "0xE70B1C")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE70BD4", Offset = "0xE70BD4", VA = "0xE70BD4")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE70C6C", Offset = "0xE70C6C", VA = "0xE70C6C")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE70D14", Offset = "0xE70D14", VA = "0xE70D14")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE70DB4", Offset = "0xE70DB4", VA = "0xE70DB4")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE70E4C", Offset = "0xE70E4C", VA = "0xE70E4C")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE70EE4", Offset = "0xE70EE4", VA = "0xE70EE4")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE70F7C", Offset = "0xE70F7C", VA = "0xE70F7C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE6EC7C", Offset = "0xE6EC7C", VA = "0xE6EC7C")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE6ED04", Offset = "0xE6ED04", VA = "0xE6ED04")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE6ED9C", Offset = "0xE6ED9C", VA = "0xE6ED9C")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xE6EE6C", Offset = "0xE6EE6C", VA = "0xE6EE6C")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xE6EF24", Offset = "0xE6EF24", VA = "0xE6EF24")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xE6EFCC", Offset = "0xE6EFCC", VA = "0xE6EFCC")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE6F06C", Offset = "0xE6F06C", VA = "0xE6F06C")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE6F10C", Offset = "0xE6F10C", VA = "0xE6F10C")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE6F1AC", Offset = "0xE6F1AC", VA = "0xE6F1AC")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE6F25C", Offset = "0xE6F25C", VA = "0xE6F25C")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE6F30C", Offset = "0xE6F30C", VA = "0xE6F30C")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE6F3AC", Offset = "0xE6F3AC", VA = "0xE6F3AC")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE6F44C", Offset = "0xE6F44C", VA = "0xE6F44C")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x6000166")]
		[Address(RVA = "0xE6F4EC", Offset = "0xE6F4EC", VA = "0xE6F4EC")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xE6F784", Offset = "0xE6F784", VA = "0xE6F784")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE6F824", Offset = "0xE6F824", VA = "0xE6F824")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE6F8C4", Offset = "0xE6F8C4", VA = "0xE6F8C4")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE6F97C", Offset = "0xE6F97C", VA = "0xE6F97C")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE6FA14", Offset = "0xE6FA14", VA = "0xE6FA14")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE6FC48", Offset = "0xE6FC48", VA = "0xE6FC48")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE6FD34", Offset = "0xE6FD34", VA = "0xE6FD34")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE6FE10", Offset = "0xE6FE10", VA = "0xE6FE10")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE6FEC0", Offset = "0xE6FEC0", VA = "0xE6FEC0")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE6FF58", Offset = "0xE6FF58", VA = "0xE6FF58")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE6FFF0", Offset = "0xE6FFF0", VA = "0xE6FFF0")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE70088", Offset = "0xE70088", VA = "0xE70088")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE70120", Offset = "0xE70120", VA = "0xE70120")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE703D8", Offset = "0xE703D8", VA = "0xE703D8")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x6000175")]
		[Address(RVA = "0xE706B4", Offset = "0xE706B4", VA = "0xE706B4")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE70774", Offset = "0xE70774", VA = "0xE70774")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE7080C", Offset = "0xE7080C", VA = "0xE7080C")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE708A4", Offset = "0xE708A4", VA = "0xE708A4")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE7093C", Offset = "0xE7093C", VA = "0xE7093C")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE709D4", Offset = "0xE709D4", VA = "0xE709D4")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE70A6C", Offset = "0xE70A6C", VA = "0xE70A6C")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE70B24", Offset = "0xE70B24", VA = "0xE70B24")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600017D")]
		[Address(RVA = "0xE70BDC", Offset = "0xE70BDC", VA = "0xE70BDC")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x600017E")]
		[Address(RVA = "0xE70C74", Offset = "0xE70C74", VA = "0xE70C74")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE70D1C", Offset = "0xE70D1C", VA = "0xE70D1C")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000180")]
		[Address(RVA = "0xE70DBC", Offset = "0xE70DBC", VA = "0xE70DBC")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x6000181")]
		[Address(RVA = "0xE70E54", Offset = "0xE70E54", VA = "0xE70E54")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000182")]
		[Address(RVA = "0xE70EEC", Offset = "0xE70EEC", VA = "0xE70EEC")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000183")]
		[Address(RVA = "0xE70F84", Offset = "0xE70F84", VA = "0xE70F84")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xE71014", Offset = "0xE71014", VA = "0xE71014")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xE7105C", Offset = "0xE7105C", VA = "0xE7105C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000043")]
	internal interface IChannelControl
	{
		[Token(Token = "0x6000186")]
		RESULT getSystemObject(out System system);

		[Token(Token = "0x6000187")]
		RESULT stop();

		[Token(Token = "0x6000188")]
		RESULT setPaused(bool paused);

		[Token(Token = "0x6000189")]
		RESULT getPaused(out bool paused);

		[Token(Token = "0x600018A")]
		RESULT setVolume(float volume);

		[Token(Token = "0x600018B")]
		RESULT getVolume(out float volume);

		[Token(Token = "0x600018C")]
		RESULT setVolumeRamp(bool ramp);

		[Token(Token = "0x600018D")]
		RESULT getVolumeRamp(out bool ramp);

		[Token(Token = "0x600018E")]
		RESULT getAudibility(out float audibility);

		[Token(Token = "0x600018F")]
		RESULT setPitch(float pitch);

		[Token(Token = "0x6000190")]
		RESULT getPitch(out float pitch);

		[Token(Token = "0x6000191")]
		RESULT setMute(bool mute);

		[Token(Token = "0x6000192")]
		RESULT getMute(out bool mute);

		[Token(Token = "0x6000193")]
		RESULT setReverbProperties(int instance, float wet);

		[Token(Token = "0x6000194")]
		RESULT getReverbProperties(int instance, out float wet);

		[Token(Token = "0x6000195")]
		RESULT setLowPassGain(float gain);

		[Token(Token = "0x6000196")]
		RESULT getLowPassGain(out float gain);

		[Token(Token = "0x6000197")]
		RESULT setMode(MODE mode);

		[Token(Token = "0x6000198")]
		RESULT getMode(out MODE mode);

		[Token(Token = "0x6000199")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		[Token(Token = "0x600019A")]
		RESULT isPlaying(out bool isplaying);

		[Token(Token = "0x600019B")]
		RESULT setPan(float pan);

		[Token(Token = "0x600019C")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[Token(Token = "0x600019D")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		[Token(Token = "0x600019E")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[Token(Token = "0x600019F")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[Token(Token = "0x60001A0")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		[Token(Token = "0x60001A1")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[Token(Token = "0x60001A2")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		[Token(Token = "0x60001A3")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[Token(Token = "0x60001A4")]
		RESULT addFadePoint(ulong dspclock, float volume);

		[Token(Token = "0x60001A5")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		[Token(Token = "0x60001A6")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		[Token(Token = "0x60001A7")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[Token(Token = "0x60001A8")]
		RESULT getDSP(int index, out DSP dsp);

		[Token(Token = "0x60001A9")]
		RESULT addDSP(int index, DSP dsp);

		[Token(Token = "0x60001AA")]
		RESULT removeDSP(DSP dsp);

		[Token(Token = "0x60001AB")]
		RESULT getNumDSPs(out int numdsps);

		[Token(Token = "0x60001AC")]
		RESULT setDSPIndex(DSP dsp, int index);

		[Token(Token = "0x60001AD")]
		RESULT getDSPIndex(DSP dsp, out int index);

		[Token(Token = "0x60001AE")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		[Token(Token = "0x60001AF")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		[Token(Token = "0x60001B0")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		[Token(Token = "0x60001B1")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		[Token(Token = "0x60001B2")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		[Token(Token = "0x60001B3")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[Token(Token = "0x60001B4")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		[Token(Token = "0x60001B5")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		[Token(Token = "0x60001B6")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		[Token(Token = "0x60001B7")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		[Token(Token = "0x60001B8")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		[Token(Token = "0x60001B9")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		[Token(Token = "0x60001BA")]
		RESULT set3DSpread(float angle);

		[Token(Token = "0x60001BB")]
		RESULT get3DSpread(out float angle);

		[Token(Token = "0x60001BC")]
		RESULT set3DLevel(float level);

		[Token(Token = "0x60001BD")]
		RESULT get3DLevel(out float level);

		[Token(Token = "0x60001BE")]
		RESULT set3DDopplerLevel(float level);

		[Token(Token = "0x60001BF")]
		RESULT get3DDopplerLevel(out float level);

		[Token(Token = "0x60001C0")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		[Token(Token = "0x60001C1")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		[Token(Token = "0x60001C2")]
		RESULT setUserData(IntPtr userdata);

		[Token(Token = "0x60001C3")]
		RESULT getUserData(out IntPtr userdata);
	}
	[Token(Token = "0x2000044")]
	public struct Channel : IChannelControl
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE4ABE8", Offset = "0xE4ABE8", VA = "0xE4ABE8")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE4AC80", Offset = "0xE4AC80", VA = "0xE4AC80")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE4AD18", Offset = "0xE4AD18", VA = "0xE4AD18")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE4ADB0", Offset = "0xE4ADB0", VA = "0xE4ADB0")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE4AE48", Offset = "0xE4AE48", VA = "0xE4AE48")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE4AEE8", Offset = "0xE4AEE8", VA = "0xE4AEE8")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE4AF88", Offset = "0xE4AF88", VA = "0xE4AF88")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE4B020", Offset = "0xE4B020", VA = "0xE4B020")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE4B0B8", Offset = "0xE4B0B8", VA = "0xE4B0B8")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE4B150", Offset = "0xE4B150", VA = "0xE4B150")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE4B1E8", Offset = "0xE4B1E8", VA = "0xE4B1E8")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE4B2A0", Offset = "0xE4B2A0", VA = "0xE4B2A0")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE4B358", Offset = "0xE4B358", VA = "0xE4B358")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE4B404", Offset = "0xE4B404", VA = "0xE4B404")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE4B49C", Offset = "0xE4B49C", VA = "0xE4B49C")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE4B534", Offset = "0xE4B534", VA = "0xE4B534", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE4B5CC", Offset = "0xE4B5CC", VA = "0xE4B5CC", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE4B654", Offset = "0xE4B654", VA = "0xE4B654", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE4B6F0", Offset = "0xE4B6F0", VA = "0xE4B6F0", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE4B79C", Offset = "0xE4B79C", VA = "0xE4B79C", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE4B834", Offset = "0xE4B834", VA = "0xE4B834", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE4B8CC", Offset = "0xE4B8CC", VA = "0xE4B8CC", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE4B968", Offset = "0xE4B968", VA = "0xE4B968", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xE4BA14", Offset = "0xE4BA14", VA = "0xE4BA14", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xE4BAAC", Offset = "0xE4BAAC", VA = "0xE4BAAC", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xE4BB44", Offset = "0xE4BB44", VA = "0xE4BB44", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xE4BBDC", Offset = "0xE4BBDC", VA = "0xE4BBDC", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE4BC78", Offset = "0xE4BC78", VA = "0xE4BC78", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE4BD24", Offset = "0xE4BD24", VA = "0xE4BD24", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE4BDCC", Offset = "0xE4BDCC", VA = "0xE4BDCC", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE4BE6C", Offset = "0xE4BE6C", VA = "0xE4BE6C", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE4BF04", Offset = "0xE4BF04", VA = "0xE4BF04", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE4BF9C", Offset = "0xE4BF9C", VA = "0xE4BF9C", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE4C034", Offset = "0xE4C034", VA = "0xE4C034", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE4C0CC", Offset = "0xE4C0CC", VA = "0xE4C0CC", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE4C16C", Offset = "0xE4C16C", VA = "0xE4C16C", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE4C218", Offset = "0xE4C218", VA = "0xE4C218", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE4C2B0", Offset = "0xE4C2B0", VA = "0xE4C2B0", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE4C398", Offset = "0xE4C398", VA = "0xE4C398", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE4C440", Offset = "0xE4C440", VA = "0xE4C440", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE4C500", Offset = "0xE4C500", VA = "0xE4C500", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xE4C5C0", Offset = "0xE4C5C0", VA = "0xE4C5C0", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xE4C660", Offset = "0xE4C660", VA = "0xE4C660", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE4C714", Offset = "0xE4C714", VA = "0xE4C714", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xE4C818", Offset = "0xE4C818", VA = "0xE4C818", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xE4C8DC", Offset = "0xE4C8DC", VA = "0xE4C8DC", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xE4C984", Offset = "0xE4C984", VA = "0xE4C984", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xE4CA2C", Offset = "0xE4CA2C", VA = "0xE4CA2C", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE4CACC", Offset = "0xE4CACC", VA = "0xE4CACC", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xE4CB8C", Offset = "0xE4CB8C", VA = "0xE4CB8C", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xE4CC28", Offset = "0xE4CC28", VA = "0xE4CC28", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE4CCC4", Offset = "0xE4CCC4", VA = "0xE4CCC4", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE4CD5C", Offset = "0xE4CD5C", VA = "0xE4CD5C", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE4CDF4", Offset = "0xE4CDF4", VA = "0xE4CDF4", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE4CE94", Offset = "0xE4CE94", VA = "0xE4CE94", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xE4CF34", Offset = "0xE4CF34", VA = "0xE4CF34", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE4CFD4", Offset = "0xE4CFD4", VA = "0xE4CFD4", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE4D074", Offset = "0xE4D074", VA = "0xE4D074", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE4D114", Offset = "0xE4D114", VA = "0xE4D114", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE4D1B4", Offset = "0xE4D1B4", VA = "0xE4D1B4", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE4D264", Offset = "0xE4D264", VA = "0xE4D264", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE4D314", Offset = "0xE4D314", VA = "0xE4D314", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE4D3AC", Offset = "0xE4D3AC", VA = "0xE4D3AC", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE4D444", Offset = "0xE4D444", VA = "0xE4D444", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE4D4E4", Offset = "0xE4D4E4", VA = "0xE4D4E4", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE4D584", Offset = "0xE4D584", VA = "0xE4D584", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE4D624", Offset = "0xE4D624", VA = "0xE4D624", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE4D6C4", Offset = "0xE4D6C4", VA = "0xE4D6C4", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE4D75C", Offset = "0xE4D75C", VA = "0xE4D75C", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE4D7F4", Offset = "0xE4D7F4", VA = "0xE4D7F4", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE4D88C", Offset = "0xE4D88C", VA = "0xE4D88C", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE4D924", Offset = "0xE4D924", VA = "0xE4D924", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE4D9BC", Offset = "0xE4D9BC", VA = "0xE4D9BC", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE4DA54", Offset = "0xE4DA54", VA = "0xE4DA54", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE4DB08", Offset = "0xE4DB08", VA = "0xE4DB08", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE4DBCC", Offset = "0xE4DBCC", VA = "0xE4DBCC", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE4DC64", Offset = "0xE4DC64", VA = "0xE4DC64", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE4ABF0", Offset = "0xE4ABF0", VA = "0xE4ABF0")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE4AC88", Offset = "0xE4AC88", VA = "0xE4AC88")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE4AD20", Offset = "0xE4AD20", VA = "0xE4AD20")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE4ADB8", Offset = "0xE4ADB8", VA = "0xE4ADB8")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE4AE50", Offset = "0xE4AE50", VA = "0xE4AE50")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE4AEF0", Offset = "0xE4AEF0", VA = "0xE4AEF0")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE4AF90", Offset = "0xE4AF90", VA = "0xE4AF90")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE4B028", Offset = "0xE4B028", VA = "0xE4B028")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000219")]
		[Address(RVA = "0xE4B0C0", Offset = "0xE4B0C0", VA = "0xE4B0C0")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x600021A")]
		[Address(RVA = "0xE4B158", Offset = "0xE4B158", VA = "0xE4B158")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x600021B")]
		[Address(RVA = "0xE4B1F0", Offset = "0xE4B1F0", VA = "0xE4B1F0")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600021C")]
		[Address(RVA = "0xE4B2A8", Offset = "0xE4B2A8", VA = "0xE4B2A8")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x600021D")]
		[Address(RVA = "0xE4B360", Offset = "0xE4B360", VA = "0xE4B360")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x600021E")]
		[Address(RVA = "0xE4B40C", Offset = "0xE4B40C", VA = "0xE4B40C")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE4B4A4", Offset = "0xE4B4A4", VA = "0xE4B4A4")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE4B53C", Offset = "0xE4B53C", VA = "0xE4B53C")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE4B5D4", Offset = "0xE4B5D4", VA = "0xE4B5D4")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE4B660", Offset = "0xE4B660", VA = "0xE4B660")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE4B6F8", Offset = "0xE4B6F8", VA = "0xE4B6F8")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE4B7A4", Offset = "0xE4B7A4", VA = "0xE4B7A4")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE4B83C", Offset = "0xE4B83C", VA = "0xE4B83C")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE4B8D8", Offset = "0xE4B8D8", VA = "0xE4B8D8")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE4B970", Offset = "0xE4B970", VA = "0xE4B970")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE4BA1C", Offset = "0xE4BA1C", VA = "0xE4BA1C")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE4BAB4", Offset = "0xE4BAB4", VA = "0xE4BAB4")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE4BB4C", Offset = "0xE4BB4C", VA = "0xE4BB4C")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE4BBE8", Offset = "0xE4BBE8", VA = "0xE4BBE8")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE4BC80", Offset = "0xE4BC80", VA = "0xE4BC80")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE4BD2C", Offset = "0xE4BD2C", VA = "0xE4BD2C")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE4BDD4", Offset = "0xE4BDD4", VA = "0xE4BDD4")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE4BE74", Offset = "0xE4BE74", VA = "0xE4BE74")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE4BF0C", Offset = "0xE4BF0C", VA = "0xE4BF0C")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE4BFA4", Offset = "0xE4BFA4", VA = "0xE4BFA4")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE4C03C", Offset = "0xE4C03C", VA = "0xE4C03C")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE4C0D4", Offset = "0xE4C0D4", VA = "0xE4C0D4")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE4C174", Offset = "0xE4C174", VA = "0xE4C174")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE4C220", Offset = "0xE4C220", VA = "0xE4C220")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE4C2B8", Offset = "0xE4C2B8", VA = "0xE4C2B8")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE4C3A0", Offset = "0xE4C3A0", VA = "0xE4C3A0")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE4C448", Offset = "0xE4C448", VA = "0xE4C448")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE4C508", Offset = "0xE4C508", VA = "0xE4C508")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE4C5C8", Offset = "0xE4C5C8", VA = "0xE4C5C8")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE4C66C", Offset = "0xE4C66C", VA = "0xE4C66C")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xE4C770", Offset = "0xE4C770", VA = "0xE4C770")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE4C820", Offset = "0xE4C820", VA = "0xE4C820")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x600023E")]
		[Address(RVA = "0xE4C8E4", Offset = "0xE4C8E4", VA = "0xE4C8E4")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE4C98C", Offset = "0xE4C98C", VA = "0xE4C98C")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000240")]
		[Address(RVA = "0xE4CA34", Offset = "0xE4CA34", VA = "0xE4CA34")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE4CAD4", Offset = "0xE4CAD4", VA = "0xE4CAD4")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x6000242")]
		[Address(RVA = "0xE4CB94", Offset = "0xE4CB94", VA = "0xE4CB94")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE4CC30", Offset = "0xE4CC30", VA = "0xE4CC30")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000244")]
		[Address(RVA = "0xE4CCCC", Offset = "0xE4CCCC", VA = "0xE4CCCC")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE4CD64", Offset = "0xE4CD64", VA = "0xE4CD64")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE4CDFC", Offset = "0xE4CDFC", VA = "0xE4CDFC")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE4CE9C", Offset = "0xE4CE9C", VA = "0xE4CE9C")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE4CF3C", Offset = "0xE4CF3C", VA = "0xE4CF3C")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE4CFDC", Offset = "0xE4CFDC", VA = "0xE4CFDC")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE4D07C", Offset = "0xE4D07C", VA = "0xE4D07C")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE4D11C", Offset = "0xE4D11C", VA = "0xE4D11C")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE4D1BC", Offset = "0xE4D1BC", VA = "0xE4D1BC")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE4D26C", Offset = "0xE4D26C", VA = "0xE4D26C")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE4D31C", Offset = "0xE4D31C", VA = "0xE4D31C")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xE4D3B4", Offset = "0xE4D3B4", VA = "0xE4D3B4")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE4D44C", Offset = "0xE4D44C", VA = "0xE4D44C")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xE4D4EC", Offset = "0xE4D4EC", VA = "0xE4D4EC")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xE4D58C", Offset = "0xE4D58C", VA = "0xE4D58C")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xE4D62C", Offset = "0xE4D62C", VA = "0xE4D62C")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE4D6CC", Offset = "0xE4D6CC", VA = "0xE4D6CC")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE4D764", Offset = "0xE4D764", VA = "0xE4D764")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE4D7FC", Offset = "0xE4D7FC", VA = "0xE4D7FC")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE4D894", Offset = "0xE4D894", VA = "0xE4D894")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xE4D92C", Offset = "0xE4D92C", VA = "0xE4D92C")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE4D9C4", Offset = "0xE4D9C4", VA = "0xE4D9C4")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE4DA60", Offset = "0xE4DA60", VA = "0xE4DA60")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE4DB10", Offset = "0xE4DB10", VA = "0xE4DB10")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE4DBD4", Offset = "0xE4DBD4", VA = "0xE4DBD4")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE4DC6C", Offset = "0xE4DC6C", VA = "0xE4DC6C")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xE4DCFC", Offset = "0xE4DCFC", VA = "0xE4DCFC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xE4DD44", Offset = "0xE4DD44", VA = "0xE4DD44")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public struct ChannelGroup : IChannelControl
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE4DD84", Offset = "0xE4DD84", VA = "0xE4DD84")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xE4DE0C", Offset = "0xE4DE0C", VA = "0xE4DE0C")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE4DF10", Offset = "0xE4DF10", VA = "0xE4DF10")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE4DFC4", Offset = "0xE4DFC4", VA = "0xE4DFC4")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE4E05C", Offset = "0xE4E05C", VA = "0xE4E05C")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE4E0FC", Offset = "0xE4E0FC", VA = "0xE4E0FC")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xE4E194", Offset = "0xE4E194", VA = "0xE4E194")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xE4E434", Offset = "0xE4E434", VA = "0xE4E434")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE4E4CC", Offset = "0xE4E4CC", VA = "0xE4E4CC")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE4E56C", Offset = "0xE4E56C", VA = "0xE4E56C", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE4E604", Offset = "0xE4E604", VA = "0xE4E604", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE4E68C", Offset = "0xE4E68C", VA = "0xE4E68C", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE4E728", Offset = "0xE4E728", VA = "0xE4E728", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xE4E7D4", Offset = "0xE4E7D4", VA = "0xE4E7D4", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xE4E86C", Offset = "0xE4E86C", VA = "0xE4E86C", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xE4E904", Offset = "0xE4E904", VA = "0xE4E904", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xE4E9A0", Offset = "0xE4E9A0", VA = "0xE4E9A0", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xE4EA4C", Offset = "0xE4EA4C", VA = "0xE4EA4C", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE4EAE4", Offset = "0xE4EAE4", VA = "0xE4EAE4", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xE4EB7C", Offset = "0xE4EB7C", VA = "0xE4EB7C", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE4EC14", Offset = "0xE4EC14", VA = "0xE4EC14", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE4ECB0", Offset = "0xE4ECB0", VA = "0xE4ECB0", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xE4ED5C", Offset = "0xE4ED5C", VA = "0xE4ED5C", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xE4EE04", Offset = "0xE4EE04", VA = "0xE4EE04", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xE4EEA4", Offset = "0xE4EEA4", VA = "0xE4EEA4", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xE4EF3C", Offset = "0xE4EF3C", VA = "0xE4EF3C", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE4EFD4", Offset = "0xE4EFD4", VA = "0xE4EFD4", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE4F06C", Offset = "0xE4F06C", VA = "0xE4F06C", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE4F104", Offset = "0xE4F104", VA = "0xE4F104", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE4F1A4", Offset = "0xE4F1A4", VA = "0xE4F1A4", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE4F250", Offset = "0xE4F250", VA = "0xE4F250", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE4F2E8", Offset = "0xE4F2E8", VA = "0xE4F2E8", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE4F3D0", Offset = "0xE4F3D0", VA = "0xE4F3D0", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE4F478", Offset = "0xE4F478", VA = "0xE4F478", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE4F538", Offset = "0xE4F538", VA = "0xE4F538", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE4F5F8", Offset = "0xE4F5F8", VA = "0xE4F5F8", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE4F698", Offset = "0xE4F698", VA = "0xE4F698", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE4F74C", Offset = "0xE4F74C", VA = "0xE4F74C", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE4F850", Offset = "0xE4F850", VA = "0xE4F850", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE4F914", Offset = "0xE4F914", VA = "0xE4F914", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE4F9BC", Offset = "0xE4F9BC", VA = "0xE4F9BC", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE4FA64", Offset = "0xE4FA64", VA = "0xE4FA64", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE4FB04", Offset = "0xE4FB04", VA = "0xE4FB04", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE4FBC0", Offset = "0xE4FBC0", VA = "0xE4FBC0", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE4FC60", Offset = "0xE4FC60", VA = "0xE4FC60", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE4FD00", Offset = "0xE4FD00", VA = "0xE4FD00", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE4FD98", Offset = "0xE4FD98", VA = "0xE4FD98", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE4FE30", Offset = "0xE4FE30", VA = "0xE4FE30", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE4FED0", Offset = "0xE4FED0", VA = "0xE4FED0", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE4FF70", Offset = "0xE4FF70", VA = "0xE4FF70", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE50010", Offset = "0xE50010", VA = "0xE50010", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE500B0", Offset = "0xE500B0", VA = "0xE500B0", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE50150", Offset = "0xE50150", VA = "0xE50150", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE501F0", Offset = "0xE501F0", VA = "0xE501F0", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE502A0", Offset = "0xE502A0", VA = "0xE502A0", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE50350", Offset = "0xE50350", VA = "0xE50350", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE503E8", Offset = "0xE503E8", VA = "0xE503E8", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE50480", Offset = "0xE50480", VA = "0xE50480", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE50520", Offset = "0xE50520", VA = "0xE50520", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE505C0", Offset = "0xE505C0", VA = "0xE505C0", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE50660", Offset = "0xE50660", VA = "0xE50660", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE50700", Offset = "0xE50700", VA = "0xE50700", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE50798", Offset = "0xE50798", VA = "0xE50798", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE50830", Offset = "0xE50830", VA = "0xE50830", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE508C8", Offset = "0xE508C8", VA = "0xE508C8", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE50960", Offset = "0xE50960", VA = "0xE50960", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE509F8", Offset = "0xE509F8", VA = "0xE509F8", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE50A90", Offset = "0xE50A90", VA = "0xE50A90", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE50B44", Offset = "0xE50B44", VA = "0xE50B44", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE50C08", Offset = "0xE50C08", VA = "0xE50C08", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE50CA0", Offset = "0xE50CA0", VA = "0xE50CA0", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE4DD8C", Offset = "0xE4DD8C", VA = "0xE4DD8C")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE4DE68", Offset = "0xE4DE68", VA = "0xE4DE68")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE4DF1C", Offset = "0xE4DF1C", VA = "0xE4DF1C")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE4DFCC", Offset = "0xE4DFCC", VA = "0xE4DFCC")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE4E064", Offset = "0xE4E064", VA = "0xE4E064")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE4E104", Offset = "0xE4E104", VA = "0xE4E104")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE4E39C", Offset = "0xE4E39C", VA = "0xE4E39C")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE4E43C", Offset = "0xE4E43C", VA = "0xE4E43C")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE4E4D4", Offset = "0xE4E4D4", VA = "0xE4E4D4")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE4E574", Offset = "0xE4E574", VA = "0xE4E574")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE4E60C", Offset = "0xE4E60C", VA = "0xE4E60C")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE4E698", Offset = "0xE4E698", VA = "0xE4E698")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE4E730", Offset = "0xE4E730", VA = "0xE4E730")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE4E7DC", Offset = "0xE4E7DC", VA = "0xE4E7DC")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE4E874", Offset = "0xE4E874", VA = "0xE4E874")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE4E910", Offset = "0xE4E910", VA = "0xE4E910")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE4E9A8", Offset = "0xE4E9A8", VA = "0xE4E9A8")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE4EA54", Offset = "0xE4EA54", VA = "0xE4EA54")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE4EAEC", Offset = "0xE4EAEC", VA = "0xE4EAEC")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE4EB84", Offset = "0xE4EB84", VA = "0xE4EB84")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xE4EC20", Offset = "0xE4EC20", VA = "0xE4EC20")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE4ECB8", Offset = "0xE4ECB8", VA = "0xE4ECB8")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE4ED64", Offset = "0xE4ED64", VA = "0xE4ED64")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE4EE0C", Offset = "0xE4EE0C", VA = "0xE4EE0C")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xE4EEAC", Offset = "0xE4EEAC", VA = "0xE4EEAC")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xE4EF44", Offset = "0xE4EF44", VA = "0xE4EF44")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xE4EFDC", Offset = "0xE4EFDC", VA = "0xE4EFDC")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xE4F074", Offset = "0xE4F074", VA = "0xE4F074")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xE4F10C", Offset = "0xE4F10C", VA = "0xE4F10C")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xE4F1AC", Offset = "0xE4F1AC", VA = "0xE4F1AC")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xE4F258", Offset = "0xE4F258", VA = "0xE4F258")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xE4F2F0", Offset = "0xE4F2F0", VA = "0xE4F2F0")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xE4F3D8", Offset = "0xE4F3D8", VA = "0xE4F3D8")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xE4F480", Offset = "0xE4F480", VA = "0xE4F480")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xE4F540", Offset = "0xE4F540", VA = "0xE4F540")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xE4F600", Offset = "0xE4F600", VA = "0xE4F600")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xE4F6A4", Offset = "0xE4F6A4", VA = "0xE4F6A4")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xE4F7A8", Offset = "0xE4F7A8", VA = "0xE4F7A8")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xE4F858", Offset = "0xE4F858", VA = "0xE4F858")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xE4F91C", Offset = "0xE4F91C", VA = "0xE4F91C")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xE4F9C4", Offset = "0xE4F9C4", VA = "0xE4F9C4")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xE4FA6C", Offset = "0xE4FA6C", VA = "0xE4FA6C")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xE4FB0C", Offset = "0xE4FB0C", VA = "0xE4FB0C")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xE4FBC8", Offset = "0xE4FBC8", VA = "0xE4FBC8")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xE4FC68", Offset = "0xE4FC68", VA = "0xE4FC68")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xE4FD08", Offset = "0xE4FD08", VA = "0xE4FD08")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xE4FDA0", Offset = "0xE4FDA0", VA = "0xE4FDA0")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xE4FE38", Offset = "0xE4FE38", VA = "0xE4FE38")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE4FED8", Offset = "0xE4FED8", VA = "0xE4FED8")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xE4FF78", Offset = "0xE4FF78", VA = "0xE4FF78")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xE50018", Offset = "0xE50018", VA = "0xE50018")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xE500B8", Offset = "0xE500B8", VA = "0xE500B8")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xE50158", Offset = "0xE50158", VA = "0xE50158")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xE501F8", Offset = "0xE501F8", VA = "0xE501F8")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xE502A8", Offset = "0xE502A8", VA = "0xE502A8")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xE50358", Offset = "0xE50358", VA = "0xE50358")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xE503F0", Offset = "0xE503F0", VA = "0xE503F0")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xE50488", Offset = "0xE50488", VA = "0xE50488")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xE50528", Offset = "0xE50528", VA = "0xE50528")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xE505C8", Offset = "0xE505C8", VA = "0xE505C8")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xE50668", Offset = "0xE50668", VA = "0xE50668")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xE50708", Offset = "0xE50708", VA = "0xE50708")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xE507A0", Offset = "0xE507A0", VA = "0xE507A0")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xE50838", Offset = "0xE50838", VA = "0xE50838")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xE508D0", Offset = "0xE508D0", VA = "0xE508D0")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xE50968", Offset = "0xE50968", VA = "0xE50968")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xE50A00", Offset = "0xE50A00", VA = "0xE50A00")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xE50A9C", Offset = "0xE50A9C", VA = "0xE50A9C")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xE50B4C", Offset = "0xE50B4C", VA = "0xE50B4C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xE50C10", Offset = "0xE50C10", VA = "0xE50C10")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xE50CA8", Offset = "0xE50CA8", VA = "0xE50CA8")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xE50D38", Offset = "0xE50D38", VA = "0xE50D38")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xE50D80", Offset = "0xE50D80", VA = "0xE50D80")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public struct SoundGroup
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xE7109C", Offset = "0xE7109C", VA = "0xE7109C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xE71124", Offset = "0xE71124", VA = "0xE71124")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xE711BC", Offset = "0xE711BC", VA = "0xE711BC")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xE71254", Offset = "0xE71254", VA = "0xE71254")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xE712EC", Offset = "0xE712EC", VA = "0xE712EC")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xE71384", Offset = "0xE71384", VA = "0xE71384")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xE7141C", Offset = "0xE7141C", VA = "0xE7141C")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xE714B4", Offset = "0xE714B4", VA = "0xE714B4")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xE7154C", Offset = "0xE7154C", VA = "0xE7154C")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xE715E4", Offset = "0xE715E4", VA = "0xE715E4")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xE7167C", Offset = "0xE7167C", VA = "0xE7167C")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xE71704", Offset = "0xE71704", VA = "0xE71704")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xE719A4", Offset = "0xE719A4", VA = "0xE719A4")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xE71A3C", Offset = "0xE71A3C", VA = "0xE71A3C")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xE71ADC", Offset = "0xE71ADC", VA = "0xE71ADC")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xE71B74", Offset = "0xE71B74", VA = "0xE71B74")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xE71C0C", Offset = "0xE71C0C", VA = "0xE71C0C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xE710A4", Offset = "0xE710A4", VA = "0xE710A4")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xE7112C", Offset = "0xE7112C", VA = "0xE7112C")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xE711C4", Offset = "0xE711C4", VA = "0xE711C4")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xE7125C", Offset = "0xE7125C", VA = "0xE7125C")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xE712F4", Offset = "0xE712F4", VA = "0xE712F4")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0xE7138C", Offset = "0xE7138C", VA = "0xE7138C")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000307")]
		[Address(RVA = "0xE71424", Offset = "0xE71424", VA = "0xE71424")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0xE714BC", Offset = "0xE714BC", VA = "0xE714BC")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000309")]
		[Address(RVA = "0xE71554", Offset = "0xE71554", VA = "0xE71554")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xE715EC", Offset = "0xE715EC", VA = "0xE715EC")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0xE71684", Offset = "0xE71684", VA = "0xE71684")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0xE7190C", Offset = "0xE7190C", VA = "0xE7190C")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x600030D")]
		[Address(RVA = "0xE719AC", Offset = "0xE719AC", VA = "0xE719AC")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0xE71A44", Offset = "0xE71A44", VA = "0xE71A44")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x600030F")]
		[Address(RVA = "0xE71AE4", Offset = "0xE71AE4", VA = "0xE71AE4")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xE71B7C", Offset = "0xE71B7C", VA = "0xE71B7C")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000311")]
		[Address(RVA = "0xE71C14", Offset = "0xE71C14", VA = "0xE71C14")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xE71CA4", Offset = "0xE71CA4", VA = "0xE71CA4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xE71CEC", Offset = "0xE71CEC", VA = "0xE71CEC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public struct DSP
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xE52544", Offset = "0xE52544", VA = "0xE52544")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xE525CC", Offset = "0xE525CC", VA = "0xE525CC")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xE52664", Offset = "0xE52664", VA = "0xE52664")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xE52764", Offset = "0xE52764", VA = "0xE52764")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xE52814", Offset = "0xE52814", VA = "0xE52814")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xE528B0", Offset = "0xE528B0", VA = "0xE528B0")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xE52958", Offset = "0xE52958", VA = "0xE52958")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xE529F0", Offset = "0xE529F0", VA = "0xE529F0")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xE52A88", Offset = "0xE52A88", VA = "0xE52A88")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xE52B38", Offset = "0xE52B38", VA = "0xE52B38")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xE52BE8", Offset = "0xE52BE8", VA = "0xE52BE8")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xE52C84", Offset = "0xE52C84", VA = "0xE52C84")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xE52D30", Offset = "0xE52D30", VA = "0xE52D30")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xE52DCC", Offset = "0xE52DCC", VA = "0xE52DCC")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xE52E78", Offset = "0xE52E78", VA = "0xE52E78")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xE52F28", Offset = "0xE52F28", VA = "0xE52F28")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xE52FD8", Offset = "0xE52FD8", VA = "0xE52FD8")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xE53088", Offset = "0xE53088", VA = "0xE53088")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xE53138", Offset = "0xE53138", VA = "0xE53138")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xE53208", Offset = "0xE53208", VA = "0xE53208")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xE53290", Offset = "0xE53290", VA = "0xE53290")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xE53338", Offset = "0xE53338", VA = "0xE53338")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xE533D8", Offset = "0xE533D8", VA = "0xE533D8")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xE5347C", Offset = "0xE5347C", VA = "0xE5347C")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xE535D0", Offset = "0xE535D0", VA = "0xE535D0")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xE536E0", Offset = "0xE536E0", VA = "0xE536E0")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xE537F0", Offset = "0xE537F0", VA = "0xE537F0")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xE53914", Offset = "0xE53914", VA = "0xE53914")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xE53A44", Offset = "0xE53A44", VA = "0xE53A44")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xE53ADC", Offset = "0xE53ADC", VA = "0xE53ADC")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xE53C5C", Offset = "0xE53C5C", VA = "0xE53C5C")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xE53CFC", Offset = "0xE53CFC", VA = "0xE53CFC")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xE53DA0", Offset = "0xE53DA0", VA = "0xE53DA0")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xE54080", Offset = "0xE54080", VA = "0xE54080")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xE540F4", Offset = "0xE540F4", VA = "0xE540F4")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xE5418C", Offset = "0xE5418C", VA = "0xE5418C")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xE54238", Offset = "0xE54238", VA = "0xE54238")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xE542D0", Offset = "0xE542D0", VA = "0xE542D0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xE54368", Offset = "0xE54368", VA = "0xE54368")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xE54410", Offset = "0xE54410", VA = "0xE54410")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xE544D4", Offset = "0xE544D4", VA = "0xE544D4")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xE545C4", Offset = "0xE545C4", VA = "0xE545C4")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xE546B4", Offset = "0xE546B4", VA = "0xE546B4")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xE547D4", Offset = "0xE547D4", VA = "0xE547D4")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000340")]
		[Address(RVA = "0xE5254C", Offset = "0xE5254C", VA = "0xE5254C")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000341")]
		[Address(RVA = "0xE525D4", Offset = "0xE525D4", VA = "0xE525D4")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000342")]
		[Address(RVA = "0xE526BC", Offset = "0xE526BC", VA = "0xE526BC")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000343")]
		[Address(RVA = "0xE5276C", Offset = "0xE5276C", VA = "0xE5276C")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xE5281C", Offset = "0xE5281C", VA = "0xE5281C")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x6000345")]
		[Address(RVA = "0xE528C0", Offset = "0xE528C0", VA = "0xE528C0")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x6000346")]
		[Address(RVA = "0xE52960", Offset = "0xE52960", VA = "0xE52960")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x6000347")]
		[Address(RVA = "0xE529F8", Offset = "0xE529F8", VA = "0xE529F8")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x6000348")]
		[Address(RVA = "0xE52A90", Offset = "0xE52A90", VA = "0xE52A90")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x6000349")]
		[Address(RVA = "0xE52B40", Offset = "0xE52B40", VA = "0xE52B40")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x600034A")]
		[Address(RVA = "0xE52BF4", Offset = "0xE52BF4", VA = "0xE52BF4")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x600034B")]
		[Address(RVA = "0xE52C8C", Offset = "0xE52C8C", VA = "0xE52C8C")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x600034C")]
		[Address(RVA = "0xE52D3C", Offset = "0xE52D3C", VA = "0xE52D3C")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x600034D")]
		[Address(RVA = "0xE52DD4", Offset = "0xE52DD4", VA = "0xE52DD4")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x600034E")]
		[Address(RVA = "0xE52E80", Offset = "0xE52E80", VA = "0xE52E80")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x600034F")]
		[Address(RVA = "0xE52F30", Offset = "0xE52F30", VA = "0xE52F30")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x6000350")]
		[Address(RVA = "0xE52FE0", Offset = "0xE52FE0", VA = "0xE52FE0")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000351")]
		[Address(RVA = "0xE53090", Offset = "0xE53090", VA = "0xE53090")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x6000352")]
		[Address(RVA = "0xE53140", Offset = "0xE53140", VA = "0xE53140")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x6000353")]
		[Address(RVA = "0xE53210", Offset = "0xE53210", VA = "0xE53210")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000354")]
		[Address(RVA = "0xE53298", Offset = "0xE53298", VA = "0xE53298")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x6000355")]
		[Address(RVA = "0xE53340", Offset = "0xE53340", VA = "0xE53340")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x6000356")]
		[Address(RVA = "0xE533E4", Offset = "0xE533E4", VA = "0xE533E4")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x6000357")]
		[Address(RVA = "0xE53528", Offset = "0xE53528", VA = "0xE53528")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000358")]
		[Address(RVA = "0xE53630", Offset = "0xE53630", VA = "0xE53630")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000359")]
		[Address(RVA = "0xE53740", Offset = "0xE53740", VA = "0xE53740")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600035A")]
		[Address(RVA = "0xE53850", Offset = "0xE53850", VA = "0xE53850")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600035B")]
		[Address(RVA = "0xE53984", Offset = "0xE53984", VA = "0xE53984")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xE53A4C", Offset = "0xE53A4C", VA = "0xE53A4C")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x600035D")]
		[Address(RVA = "0xE53BC4", Offset = "0xE53BC4", VA = "0xE53BC4")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out IntPtr desc);

		[PreserveSig]
		[Token(Token = "0x600035E")]
		[Address(RVA = "0xE53C64", Offset = "0xE53C64", VA = "0xE53C64")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x600035F")]
		[Address(RVA = "0xE53D08", Offset = "0xE53D08", VA = "0xE53D08")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xE53FC0", Offset = "0xE53FC0", VA = "0xE53FC0")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x6000361")]
		[Address(RVA = "0xE540FC", Offset = "0xE540FC", VA = "0xE540FC")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x6000362")]
		[Address(RVA = "0xE54194", Offset = "0xE54194", VA = "0xE54194")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x6000363")]
		[Address(RVA = "0xE54240", Offset = "0xE54240", VA = "0xE54240")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000364")]
		[Address(RVA = "0xE542D8", Offset = "0xE542D8", VA = "0xE542D8")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000365")]
		[Address(RVA = "0xE54378", Offset = "0xE54378", VA = "0xE54378")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000366")]
		[Address(RVA = "0xE54418", Offset = "0xE54418", VA = "0xE54418")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000367")]
		[Address(RVA = "0xE544DC", Offset = "0xE544DC", VA = "0xE544DC")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xE545CC", Offset = "0xE545CC", VA = "0xE545CC")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xE546BC", Offset = "0xE546BC", VA = "0xE546BC")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0xE547DC", Offset = "0xE547DC", VA = "0xE547DC")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xE54874", Offset = "0xE54874", VA = "0xE54874")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xE548BC", Offset = "0xE548BC", VA = "0xE548BC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public struct DSPConnection
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xE548FC", Offset = "0xE548FC", VA = "0xE548FC")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xE54994", Offset = "0xE54994", VA = "0xE54994")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xE54A2C", Offset = "0xE54A2C", VA = "0xE54A2C")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xE54AC4", Offset = "0xE54AC4", VA = "0xE54AC4")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xE54B5C", Offset = "0xE54B5C", VA = "0xE54B5C")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xE54C1C", Offset = "0xE54C1C", VA = "0xE54C1C")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xE54CDC", Offset = "0xE54CDC", VA = "0xE54CDC")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xE54D74", Offset = "0xE54D74", VA = "0xE54D74")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xE54E0C", Offset = "0xE54E0C", VA = "0xE54E0C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0xE54904", Offset = "0xE54904", VA = "0xE54904")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0xE5499C", Offset = "0xE5499C", VA = "0xE5499C")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xE54A34", Offset = "0xE54A34", VA = "0xE54A34")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0xE54ACC", Offset = "0xE54ACC", VA = "0xE54ACC")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x600037A")]
		[Address(RVA = "0xE54B64", Offset = "0xE54B64", VA = "0xE54B64")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0xE54C24", Offset = "0xE54C24", VA = "0xE54C24")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0xE54CE4", Offset = "0xE54CE4", VA = "0xE54CE4")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0xE54D7C", Offset = "0xE54D7C", VA = "0xE54D7C")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600037E")]
		[Address(RVA = "0xE54E14", Offset = "0xE54E14", VA = "0xE54E14")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xE54EA4", Offset = "0xE54EA4", VA = "0xE54EA4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xE54EEC", Offset = "0xE54EEC", VA = "0xE54EEC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public struct Geometry
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xE635D8", Offset = "0xE635D8", VA = "0xE635D8")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xE63660", Offset = "0xE63660", VA = "0xE63660")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xE6373C", Offset = "0xE6373C", VA = "0xE6373C")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xE637D4", Offset = "0xE637D4", VA = "0xE637D4")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xE63874", Offset = "0xE63874", VA = "0xE63874")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xE63914", Offset = "0xE63914", VA = "0xE63914")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xE639C4", Offset = "0xE639C4", VA = "0xE639C4")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xE63A74", Offset = "0xE63A74", VA = "0xE63A74")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xE63B30", Offset = "0xE63B30", VA = "0xE63B30")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xE63BFC", Offset = "0xE63BFC", VA = "0xE63BFC")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xE63C98", Offset = "0xE63C98", VA = "0xE63C98")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xE63D44", Offset = "0xE63D44", VA = "0xE63D44")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xE63DE4", Offset = "0xE63DE4", VA = "0xE63DE4")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xE63E84", Offset = "0xE63E84", VA = "0xE63E84")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xE63F1C", Offset = "0xE63F1C", VA = "0xE63F1C")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xE63FB4", Offset = "0xE63FB4", VA = "0xE63FB4")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xE6404C", Offset = "0xE6404C", VA = "0xE6404C")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xE640E4", Offset = "0xE640E4", VA = "0xE640E4")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xE64184", Offset = "0xE64184", VA = "0xE64184")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xE6421C", Offset = "0xE6421C", VA = "0xE6421C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000395")]
		[Address(RVA = "0xE635E0", Offset = "0xE635E0", VA = "0xE635E0")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0xE6366C", Offset = "0xE6366C", VA = "0xE6366C")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x6000397")]
		[Address(RVA = "0xE63744", Offset = "0xE63744", VA = "0xE63744")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x6000398")]
		[Address(RVA = "0xE637DC", Offset = "0xE637DC", VA = "0xE637DC")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x6000399")]
		[Address(RVA = "0xE6387C", Offset = "0xE6387C", VA = "0xE6387C")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x600039A")]
		[Address(RVA = "0xE6391C", Offset = "0xE6391C", VA = "0xE6391C")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x600039B")]
		[Address(RVA = "0xE639CC", Offset = "0xE639CC", VA = "0xE639CC")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x600039C")]
		[Address(RVA = "0xE63A80", Offset = "0xE63A80", VA = "0xE63A80")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x600039D")]
		[Address(RVA = "0xE63B38", Offset = "0xE63B38", VA = "0xE63B38")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x600039E")]
		[Address(RVA = "0xE63C08", Offset = "0xE63C08", VA = "0xE63C08")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x600039F")]
		[Address(RVA = "0xE63CA0", Offset = "0xE63CA0", VA = "0xE63CA0")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xE63D4C", Offset = "0xE63D4C", VA = "0xE63D4C")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xE63DEC", Offset = "0xE63DEC", VA = "0xE63DEC")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xE63E8C", Offset = "0xE63E8C", VA = "0xE63E8C")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xE63F24", Offset = "0xE63F24", VA = "0xE63F24")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xE63FBC", Offset = "0xE63FBC", VA = "0xE63FBC")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xE64054", Offset = "0xE64054", VA = "0xE64054")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xE640EC", Offset = "0xE640EC", VA = "0xE640EC")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xE6418C", Offset = "0xE6418C", VA = "0xE6418C")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xE64224", Offset = "0xE64224", VA = "0xE64224")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xE642B4", Offset = "0xE642B4", VA = "0xE642B4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xE642FC", Offset = "0xE642FC", VA = "0xE642FC")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public struct Reverb3D
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xE653EC", Offset = "0xE653EC", VA = "0xE653EC")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xE65474", Offset = "0xE65474", VA = "0xE65474")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xE65524", Offset = "0xE65524", VA = "0xE65524")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xE655D4", Offset = "0xE655D4", VA = "0xE655D4")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xE6566C", Offset = "0xE6566C", VA = "0xE6566C")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xE65704", Offset = "0xE65704", VA = "0xE65704")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xE657A0", Offset = "0xE657A0", VA = "0xE657A0")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xE6584C", Offset = "0xE6584C", VA = "0xE6584C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xE658E4", Offset = "0xE658E4", VA = "0xE658E4")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xE653F4", Offset = "0xE653F4", VA = "0xE653F4")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xE6547C", Offset = "0xE6547C", VA = "0xE6547C")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xE6552C", Offset = "0xE6552C", VA = "0xE6552C")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xE655DC", Offset = "0xE655DC", VA = "0xE655DC")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xE65674", Offset = "0xE65674", VA = "0xE65674")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xE65710", Offset = "0xE65710", VA = "0xE65710")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xE657A8", Offset = "0xE657A8", VA = "0xE657A8")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xE65854", Offset = "0xE65854", VA = "0xE65854")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xE658EC", Offset = "0xE658EC", VA = "0xE658EC")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xE6597C", Offset = "0xE6597C", VA = "0xE6597C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xE659C4", Offset = "0xE659C4", VA = "0xE659C4")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public struct StringWrapper
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xE65BB8", Offset = "0xE65BB8", VA = "0xE65BB8")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x200004C")]
	internal static class StringHelper
	{
		[Token(Token = "0x2000103")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private GCHandle gcHandle;

			[Token(Token = "0x600068B")]
			[Address(RVA = "0xE7CF48", Offset = "0xE7CF48", VA = "0xE7CF48")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xE71DFC", Offset = "0xE71DFC", VA = "0xE71DFC")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0xE7CF50", Offset = "0xE7CF50", VA = "0xE7CF50")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0xE515AC", Offset = "0xE515AC", VA = "0xE515AC")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0xE78FA4", Offset = "0xE78FA4", VA = "0xE78FA4")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0xE47060", Offset = "0xE47060", VA = "0xE47060")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0xE7CF68", Offset = "0xE7CF68", VA = "0xE7CF68", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0xE71D2C", Offset = "0xE71D2C", VA = "0xE71D2C")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xE46CEC", Offset = "0xE46CEC", VA = "0xE46CEC")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x200004D")]
	internal static class Android
	{
		[Token(Token = "0x2000104")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x2000105")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x400053A")]
			DEFAULT = 0u,
			[Token(Token = "0x400053B")]
			CORE0 = 1u,
			[Token(Token = "0x400053C")]
			CORE1 = 2u,
			[Token(Token = "0x400053D")]
			CORE2 = 4u,
			[Token(Token = "0x400053E")]
			CORE3 = 8u,
			[Token(Token = "0x400053F")]
			CORE4 = 0x10u,
			[Token(Token = "0x4000540")]
			CORE5 = 0x20u,
			[Token(Token = "0x4000541")]
			CORE6 = 0x40u,
			[Token(Token = "0x4000542")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xE46938", Offset = "0xE46938", VA = "0xE46938")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xE4693C", Offset = "0xE4693C", VA = "0xE4693C")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
	[Token(Token = "0x200004E")]
	public struct DSP_BUFFER_ARRAY
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numbuffers;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] buffernumchannels;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CHANNELMASK[] bufferchannelmask;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr[] buffers;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;
	}
	[Token(Token = "0x200004F")]
	public enum DSP_PROCESS_OPERATION
	{
		[Token(Token = "0x40001FC")]
		PROCESS_PERFORM,
		[Token(Token = "0x40001FD")]
		PROCESS_QUERY
	}
	[Token(Token = "0x2000050")]
	public struct COMPLEX
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float real;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float imag;
	}
	[Token(Token = "0x2000051")]
	public enum DSP_PAN_SURROUND_FLAGS
	{
		[Token(Token = "0x4000201")]
		DEFAULT,
		[Token(Token = "0x4000202")]
		ROTATION_NOT_BIASED
	}
	[Token(Token = "0x2000052")]
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000053")]
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000054")]
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000055")]
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	[Token(Token = "0x2000056")]
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	[Token(Token = "0x2000057")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	[Token(Token = "0x2000058")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	[Token(Token = "0x2000059")]
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	[Token(Token = "0x200005A")]
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	[Token(Token = "0x200005B")]
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	[Token(Token = "0x200005C")]
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	[Token(Token = "0x200005D")]
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	[Token(Token = "0x200005E")]
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	[Token(Token = "0x200005F")]
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	[Token(Token = "0x2000060")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	[Token(Token = "0x2000061")]
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000062")]
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000063")]
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	[Token(Token = "0x2000064")]
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000065")]
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000066")]
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000067")]
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	[Token(Token = "0x2000068")]
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	[Token(Token = "0x2000069")]
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	[Token(Token = "0x200006A")]
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	[Token(Token = "0x200006B")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	[Token(Token = "0x200006C")]
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	[Token(Token = "0x200006D")]
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	[Token(Token = "0x200006E")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	[Token(Token = "0x200006F")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	[Token(Token = "0x2000070")]
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	[Token(Token = "0x2000071")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x2000072")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	[Token(Token = "0x2000073")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x2000074")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x2000075")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	[Token(Token = "0x2000076")]
	public enum DSP_TYPE
	{
		[Token(Token = "0x4000204")]
		UNKNOWN,
		[Token(Token = "0x4000205")]
		MIXER,
		[Token(Token = "0x4000206")]
		OSCILLATOR,
		[Token(Token = "0x4000207")]
		LOWPASS,
		[Token(Token = "0x4000208")]
		ITLOWPASS,
		[Token(Token = "0x4000209")]
		HIGHPASS,
		[Token(Token = "0x400020A")]
		ECHO,
		[Token(Token = "0x400020B")]
		FADER,
		[Token(Token = "0x400020C")]
		FLANGE,
		[Token(Token = "0x400020D")]
		DISTORTION,
		[Token(Token = "0x400020E")]
		NORMALIZE,
		[Token(Token = "0x400020F")]
		LIMITER,
		[Token(Token = "0x4000210")]
		PARAMEQ,
		[Token(Token = "0x4000211")]
		PITCHSHIFT,
		[Token(Token = "0x4000212")]
		CHORUS,
		[Token(Token = "0x4000213")]
		VSTPLUGIN,
		[Token(Token = "0x4000214")]
		WINAMPPLUGIN,
		[Token(Token = "0x4000215")]
		ITECHO,
		[Token(Token = "0x4000216")]
		COMPRESSOR,
		[Token(Token = "0x4000217")]
		SFXREVERB,
		[Token(Token = "0x4000218")]
		LOWPASS_SIMPLE,
		[Token(Token = "0x4000219")]
		DELAY,
		[Token(Token = "0x400021A")]
		TREMOLO,
		[Token(Token = "0x400021B")]
		LADSPAPLUGIN,
		[Token(Token = "0x400021C")]
		SEND,
		[Token(Token = "0x400021D")]
		RETURN,
		[Token(Token = "0x400021E")]
		HIGHPASS_SIMPLE,
		[Token(Token = "0x400021F")]
		PAN,
		[Token(Token = "0x4000220")]
		THREE_EQ,
		[Token(Token = "0x4000221")]
		FFT,
		[Token(Token = "0x4000222")]
		LOUDNESS_METER,
		[Token(Token = "0x4000223")]
		ENVELOPEFOLLOWER,
		[Token(Token = "0x4000224")]
		CONVOLUTIONREVERB,
		[Token(Token = "0x4000225")]
		CHANNELMIX,
		[Token(Token = "0x4000226")]
		TRANSCEIVER,
		[Token(Token = "0x4000227")]
		OBJECTPAN,
		[Token(Token = "0x4000228")]
		MULTIBAND_EQ,
		[Token(Token = "0x4000229")]
		MAX
	}
	[Token(Token = "0x2000077")]
	public enum DSP_PARAMETER_TYPE
	{
		[Token(Token = "0x400022B")]
		FLOAT,
		[Token(Token = "0x400022C")]
		INT,
		[Token(Token = "0x400022D")]
		BOOL,
		[Token(Token = "0x400022E")]
		DATA,
		[Token(Token = "0x400022F")]
		MAX
	}
	[Token(Token = "0x2000078")]
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		[Token(Token = "0x4000231")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		[Token(Token = "0x4000232")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		[Token(Token = "0x4000233")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	[Token(Token = "0x2000079")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numpoints;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
	[Token(Token = "0x200007A")]
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	[Token(Token = "0x200007B")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float defaultval;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	[Token(Token = "0x200007C")]
	public struct DSP_PARAMETER_DESC_INT
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int defaultval;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x200007D")]
	public struct DSP_PARAMETER_DESC_BOOL
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool defaultval;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x200007E")]
	public struct DSP_PARAMETER_DESC_DATA
	{
		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int datatype;
	}
	[StructLayout(2)]
	[Token(Token = "0x200007F")]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	[Token(Token = "0x2000080")]
	public struct DSP_PARAMETER_DESC
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] name;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte[] label;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
	[Token(Token = "0x2000081")]
	public enum DSP_PARAMETER_DATA_TYPE
	{
		[Token(Token = "0x400024F")]
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		[Token(Token = "0x4000250")]
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		[Token(Token = "0x4000251")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		[Token(Token = "0x4000252")]
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		[Token(Token = "0x4000253")]
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		[Token(Token = "0x4000254")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	[Token(Token = "0x2000082")]
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linear_gain;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float linear_gain_additive;
	}
	[Token(Token = "0x2000083")]
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ATTRIBUTES_3D relative;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x2000084")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numlisteners;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] weight;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x2000085")]
	public struct DSP_PARAMETER_SIDECHAIN
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sidechainenable;
	}
	[Token(Token = "0x2000086")]
	public struct DSP_PARAMETER_FFT
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numchannels;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;

		[Token(Token = "0x17000001")]
		public float[][] spectrum
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0xE5A618", Offset = "0xE5A618", VA = "0xE5A618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xE5A7A8", Offset = "0xE5A7A8", VA = "0xE5A7A8")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xE5A88C", Offset = "0xE5A88C", VA = "0xE5A88C")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}
	}
	[Token(Token = "0x2000087")]
	public struct DSP_DESCRIPTION
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_CREATECALLBACK create;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_RELEASECALLBACK release;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DSP_RESETCALLBACK reset;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_READCALLBACK read;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITIONCALLBACK setposition;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int numparameters;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	[Token(Token = "0x2000088")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	[Token(Token = "0x2000089")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	[Token(Token = "0x200008A")]
	public struct DSP_STATE_FUNCTIONS
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_ALLOC_FUNC alloc;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_REALLOC_FUNC realloc;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_FREE_FUNC free;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_GETSAMPLERATE_FUNC getsamplerate;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_GETBLOCKSIZE_FUNC getblocksize;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr dft;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr pan;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_GETSPEAKERMODE_FUNC getspeakermode;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_GETCLOCK_FUNC getclock;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DSP_LOG_FUNC log;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public DSP_GETUSERDATA_FUNC getuserdata;
	}
	[Token(Token = "0x200008B")]
	public struct DSP_STATE
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint channelmask;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
	[Token(Token = "0x200008C")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x200008D")]
	public enum DSP_OSCILLATOR
	{
		[Token(Token = "0x400029C")]
		TYPE,
		[Token(Token = "0x400029D")]
		RATE
	}
	[Token(Token = "0x200008E")]
	public enum DSP_LOWPASS
	{
		[Token(Token = "0x400029F")]
		CUTOFF,
		[Token(Token = "0x40002A0")]
		RESONANCE
	}
	[Token(Token = "0x200008F")]
	public enum DSP_ITLOWPASS
	{
		[Token(Token = "0x40002A2")]
		CUTOFF,
		[Token(Token = "0x40002A3")]
		RESONANCE
	}
	[Token(Token = "0x2000090")]
	public enum DSP_HIGHPASS
	{
		[Token(Token = "0x40002A5")]
		CUTOFF,
		[Token(Token = "0x40002A6")]
		RESONANCE
	}
	[Token(Token = "0x2000091")]
	public enum DSP_ECHO
	{
		[Token(Token = "0x40002A8")]
		DELAY,
		[Token(Token = "0x40002A9")]
		FEEDBACK,
		[Token(Token = "0x40002AA")]
		DRYLEVEL,
		[Token(Token = "0x40002AB")]
		WETLEVEL
	}
	[Token(Token = "0x2000092")]
	public enum DSP_FADER
	{
		[Token(Token = "0x40002AD")]
		GAIN,
		[Token(Token = "0x40002AE")]
		OVERALL_GAIN
	}
	[Token(Token = "0x2000093")]
	public enum DSP_DELAY
	{
		[Token(Token = "0x40002B0")]
		CH0,
		[Token(Token = "0x40002B1")]
		CH1,
		[Token(Token = "0x40002B2")]
		CH2,
		[Token(Token = "0x40002B3")]
		CH3,
		[Token(Token = "0x40002B4")]
		CH4,
		[Token(Token = "0x40002B5")]
		CH5,
		[Token(Token = "0x40002B6")]
		CH6,
		[Token(Token = "0x40002B7")]
		CH7,
		[Token(Token = "0x40002B8")]
		CH8,
		[Token(Token = "0x40002B9")]
		CH9,
		[Token(Token = "0x40002BA")]
		CH10,
		[Token(Token = "0x40002BB")]
		CH11,
		[Token(Token = "0x40002BC")]
		CH12,
		[Token(Token = "0x40002BD")]
		CH13,
		[Token(Token = "0x40002BE")]
		CH14,
		[Token(Token = "0x40002BF")]
		CH15,
		[Token(Token = "0x40002C0")]
		MAXDELAY
	}
	[Token(Token = "0x2000094")]
	public enum DSP_FLANGE
	{
		[Token(Token = "0x40002C2")]
		MIX,
		[Token(Token = "0x40002C3")]
		DEPTH,
		[Token(Token = "0x40002C4")]
		RATE
	}
	[Token(Token = "0x2000095")]
	public enum DSP_TREMOLO
	{
		[Token(Token = "0x40002C6")]
		FREQUENCY,
		[Token(Token = "0x40002C7")]
		DEPTH,
		[Token(Token = "0x40002C8")]
		SHAPE,
		[Token(Token = "0x40002C9")]
		SKEW,
		[Token(Token = "0x40002CA")]
		DUTY,
		[Token(Token = "0x40002CB")]
		SQUARE,
		[Token(Token = "0x40002CC")]
		PHASE,
		[Token(Token = "0x40002CD")]
		SPREAD
	}
	[Token(Token = "0x2000096")]
	public enum DSP_DISTORTION
	{
		[Token(Token = "0x40002CF")]
		LEVEL
	}
	[Token(Token = "0x2000097")]
	public enum DSP_NORMALIZE
	{
		[Token(Token = "0x40002D1")]
		FADETIME,
		[Token(Token = "0x40002D2")]
		THRESHHOLD,
		[Token(Token = "0x40002D3")]
		MAXAMP
	}
	[Token(Token = "0x2000098")]
	public enum DSP_LIMITER
	{
		[Token(Token = "0x40002D5")]
		RELEASETIME,
		[Token(Token = "0x40002D6")]
		CEILING,
		[Token(Token = "0x40002D7")]
		MAXIMIZERGAIN,
		[Token(Token = "0x40002D8")]
		MODE
	}
	[Token(Token = "0x2000099")]
	public enum DSP_PARAMEQ
	{
		[Token(Token = "0x40002DA")]
		CENTER,
		[Token(Token = "0x40002DB")]
		BANDWIDTH,
		[Token(Token = "0x40002DC")]
		GAIN
	}
	[Token(Token = "0x200009A")]
	public enum DSP_MULTIBAND_EQ
	{
		[Token(Token = "0x40002DE")]
		A_FILTER,
		[Token(Token = "0x40002DF")]
		A_FREQUENCY,
		[Token(Token = "0x40002E0")]
		A_Q,
		[Token(Token = "0x40002E1")]
		A_GAIN,
		[Token(Token = "0x40002E2")]
		B_FILTER,
		[Token(Token = "0x40002E3")]
		B_FREQUENCY,
		[Token(Token = "0x40002E4")]
		B_Q,
		[Token(Token = "0x40002E5")]
		B_GAIN,
		[Token(Token = "0x40002E6")]
		C_FILTER,
		[Token(Token = "0x40002E7")]
		C_FREQUENCY,
		[Token(Token = "0x40002E8")]
		C_Q,
		[Token(Token = "0x40002E9")]
		C_GAIN,
		[Token(Token = "0x40002EA")]
		D_FILTER,
		[Token(Token = "0x40002EB")]
		D_FREQUENCY,
		[Token(Token = "0x40002EC")]
		D_Q,
		[Token(Token = "0x40002ED")]
		D_GAIN,
		[Token(Token = "0x40002EE")]
		E_FILTER,
		[Token(Token = "0x40002EF")]
		E_FREQUENCY,
		[Token(Token = "0x40002F0")]
		E_Q,
		[Token(Token = "0x40002F1")]
		E_GAIN
	}
	[Token(Token = "0x200009B")]
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		[Token(Token = "0x40002F3")]
		DISABLED,
		[Token(Token = "0x40002F4")]
		LOWPASS_12DB,
		[Token(Token = "0x40002F5")]
		LOWPASS_24DB,
		[Token(Token = "0x40002F6")]
		LOWPASS_48DB,
		[Token(Token = "0x40002F7")]
		HIGHPASS_12DB,
		[Token(Token = "0x40002F8")]
		HIGHPASS_24DB,
		[Token(Token = "0x40002F9")]
		HIGHPASS_48DB,
		[Token(Token = "0x40002FA")]
		LOWSHELF,
		[Token(Token = "0x40002FB")]
		HIGHSHELF,
		[Token(Token = "0x40002FC")]
		PEAKING,
		[Token(Token = "0x40002FD")]
		BANDPASS,
		[Token(Token = "0x40002FE")]
		NOTCH,
		[Token(Token = "0x40002FF")]
		ALLPASS
	}
	[Token(Token = "0x200009C")]
	public enum DSP_PITCHSHIFT
	{
		[Token(Token = "0x4000301")]
		PITCH,
		[Token(Token = "0x4000302")]
		FFTSIZE,
		[Token(Token = "0x4000303")]
		OVERLAP,
		[Token(Token = "0x4000304")]
		MAXCHANNELS
	}
	[Token(Token = "0x200009D")]
	public enum DSP_CHORUS
	{
		[Token(Token = "0x4000306")]
		MIX,
		[Token(Token = "0x4000307")]
		RATE,
		[Token(Token = "0x4000308")]
		DEPTH
	}
	[Token(Token = "0x200009E")]
	public enum DSP_ITECHO
	{
		[Token(Token = "0x400030A")]
		WETDRYMIX,
		[Token(Token = "0x400030B")]
		FEEDBACK,
		[Token(Token = "0x400030C")]
		LEFTDELAY,
		[Token(Token = "0x400030D")]
		RIGHTDELAY,
		[Token(Token = "0x400030E")]
		PANDELAY
	}
	[Token(Token = "0x200009F")]
	public enum DSP_COMPRESSOR
	{
		[Token(Token = "0x4000310")]
		THRESHOLD,
		[Token(Token = "0x4000311")]
		RATIO,
		[Token(Token = "0x4000312")]
		ATTACK,
		[Token(Token = "0x4000313")]
		RELEASE,
		[Token(Token = "0x4000314")]
		GAINMAKEUP,
		[Token(Token = "0x4000315")]
		USESIDECHAIN,
		[Token(Token = "0x4000316")]
		LINKED
	}
	[Token(Token = "0x20000A0")]
	public enum DSP_SFXREVERB
	{
		[Token(Token = "0x4000318")]
		DECAYTIME,
		[Token(Token = "0x4000319")]
		EARLYDELAY,
		[Token(Token = "0x400031A")]
		LATEDELAY,
		[Token(Token = "0x400031B")]
		HFREFERENCE,
		[Token(Token = "0x400031C")]
		HFDECAYRATIO,
		[Token(Token = "0x400031D")]
		DIFFUSION,
		[Token(Token = "0x400031E")]
		DENSITY,
		[Token(Token = "0x400031F")]
		LOWSHELFFREQUENCY,
		[Token(Token = "0x4000320")]
		LOWSHELFGAIN,
		[Token(Token = "0x4000321")]
		HIGHCUT,
		[Token(Token = "0x4000322")]
		EARLYLATEMIX,
		[Token(Token = "0x4000323")]
		WETLEVEL,
		[Token(Token = "0x4000324")]
		DRYLEVEL
	}
	[Token(Token = "0x20000A1")]
	public enum DSP_LOWPASS_SIMPLE
	{
		[Token(Token = "0x4000326")]
		CUTOFF
	}
	[Token(Token = "0x20000A2")]
	public enum DSP_SEND
	{
		[Token(Token = "0x4000328")]
		RETURNID,
		[Token(Token = "0x4000329")]
		LEVEL
	}
	[Token(Token = "0x20000A3")]
	public enum DSP_RETURN
	{
		[Token(Token = "0x400032B")]
		ID,
		[Token(Token = "0x400032C")]
		INPUT_SPEAKER_MODE
	}
	[Token(Token = "0x20000A4")]
	public enum DSP_HIGHPASS_SIMPLE
	{
		[Token(Token = "0x400032E")]
		CUTOFF
	}
	[Token(Token = "0x20000A5")]
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		[Token(Token = "0x4000330")]
		DISTRIBUTED,
		[Token(Token = "0x4000331")]
		DISCRETE
	}
	[Token(Token = "0x20000A6")]
	public enum DSP_PAN_MODE_TYPE
	{
		[Token(Token = "0x4000333")]
		MONO,
		[Token(Token = "0x4000334")]
		STEREO,
		[Token(Token = "0x4000335")]
		SURROUND
	}
	[Token(Token = "0x20000A7")]
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		[Token(Token = "0x4000337")]
		LINEARSQUARED,
		[Token(Token = "0x4000338")]
		LINEAR,
		[Token(Token = "0x4000339")]
		INVERSE,
		[Token(Token = "0x400033A")]
		INVERSETAPERED,
		[Token(Token = "0x400033B")]
		CUSTOM
	}
	[Token(Token = "0x20000A8")]
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		[Token(Token = "0x400033D")]
		AUTO,
		[Token(Token = "0x400033E")]
		USER,
		[Token(Token = "0x400033F")]
		OFF
	}
	[Token(Token = "0x20000A9")]
	public enum DSP_PAN
	{
		[Token(Token = "0x4000341")]
		MODE,
		[Token(Token = "0x4000342")]
		_2D_STEREO_POSITION,
		[Token(Token = "0x4000343")]
		_2D_DIRECTION,
		[Token(Token = "0x4000344")]
		_2D_EXTENT,
		[Token(Token = "0x4000345")]
		_2D_ROTATION,
		[Token(Token = "0x4000346")]
		_2D_LFE_LEVEL,
		[Token(Token = "0x4000347")]
		_2D_STEREO_MODE,
		[Token(Token = "0x4000348")]
		_2D_STEREO_SEPARATION,
		[Token(Token = "0x4000349")]
		_2D_STEREO_AXIS,
		[Token(Token = "0x400034A")]
		ENABLED_SPEAKERS,
		[Token(Token = "0x400034B")]
		_3D_POSITION,
		[Token(Token = "0x400034C")]
		_3D_ROLLOFF,
		[Token(Token = "0x400034D")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x400034E")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x400034F")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x4000350")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x4000351")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x4000352")]
		_3D_PAN_BLEND,
		[Token(Token = "0x4000353")]
		LFE_UPMIX_ENABLED,
		[Token(Token = "0x4000354")]
		OVERALL_GAIN,
		[Token(Token = "0x4000355")]
		SURROUND_SPEAKER_MODE,
		[Token(Token = "0x4000356")]
		_2D_HEIGHT_BLEND
	}
	[Token(Token = "0x20000AA")]
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		[Token(Token = "0x4000358")]
		_12DB,
		[Token(Token = "0x4000359")]
		_24DB,
		[Token(Token = "0x400035A")]
		_48DB
	}
	[Token(Token = "0x20000AB")]
	public enum DSP_THREE_EQ
	{
		[Token(Token = "0x400035C")]
		LOWGAIN,
		[Token(Token = "0x400035D")]
		MIDGAIN,
		[Token(Token = "0x400035E")]
		HIGHGAIN,
		[Token(Token = "0x400035F")]
		LOWCROSSOVER,
		[Token(Token = "0x4000360")]
		HIGHCROSSOVER,
		[Token(Token = "0x4000361")]
		CROSSOVERSLOPE
	}
	[Token(Token = "0x20000AC")]
	public enum DSP_FFT_WINDOW
	{
		[Token(Token = "0x4000363")]
		RECT,
		[Token(Token = "0x4000364")]
		TRIANGLE,
		[Token(Token = "0x4000365")]
		HAMMING,
		[Token(Token = "0x4000366")]
		HANNING,
		[Token(Token = "0x4000367")]
		BLACKMAN,
		[Token(Token = "0x4000368")]
		BLACKMANHARRIS
	}
	[Token(Token = "0x20000AD")]
	public enum DSP_FFT
	{
		[Token(Token = "0x400036A")]
		WINDOWSIZE,
		[Token(Token = "0x400036B")]
		WINDOWTYPE,
		[Token(Token = "0x400036C")]
		SPECTRUMDATA,
		[Token(Token = "0x400036D")]
		DOMINANT_FREQ
	}
	[Token(Token = "0x20000AE")]
	public enum DSP_ENVELOPEFOLLOWER
	{
		[Token(Token = "0x400036F")]
		ATTACK,
		[Token(Token = "0x4000370")]
		RELEASE,
		[Token(Token = "0x4000371")]
		ENVELOPE,
		[Token(Token = "0x4000372")]
		USESIDECHAIN
	}
	[Token(Token = "0x20000AF")]
	public enum DSP_CONVOLUTION_REVERB
	{
		[Token(Token = "0x4000374")]
		IR,
		[Token(Token = "0x4000375")]
		WET,
		[Token(Token = "0x4000376")]
		DRY,
		[Token(Token = "0x4000377")]
		LINKED
	}
	[Token(Token = "0x20000B0")]
	public enum DSP_CHANNELMIX_OUTPUT
	{
		[Token(Token = "0x4000379")]
		DEFAULT,
		[Token(Token = "0x400037A")]
		ALLMONO,
		[Token(Token = "0x400037B")]
		ALLSTEREO,
		[Token(Token = "0x400037C")]
		ALLQUAD,
		[Token(Token = "0x400037D")]
		ALL5POINT1,
		[Token(Token = "0x400037E")]
		ALL7POINT1,
		[Token(Token = "0x400037F")]
		ALLLFE,
		[Token(Token = "0x4000380")]
		ALL7POINT1POINT4
	}
	[Token(Token = "0x20000B1")]
	public enum DSP_CHANNELMIX
	{
		[Token(Token = "0x4000382")]
		OUTPUTGROUPING,
		[Token(Token = "0x4000383")]
		GAIN_CH0,
		[Token(Token = "0x4000384")]
		GAIN_CH1,
		[Token(Token = "0x4000385")]
		GAIN_CH2,
		[Token(Token = "0x4000386")]
		GAIN_CH3,
		[Token(Token = "0x4000387")]
		GAIN_CH4,
		[Token(Token = "0x4000388")]
		GAIN_CH5,
		[Token(Token = "0x4000389")]
		GAIN_CH6,
		[Token(Token = "0x400038A")]
		GAIN_CH7,
		[Token(Token = "0x400038B")]
		GAIN_CH8,
		[Token(Token = "0x400038C")]
		GAIN_CH9,
		[Token(Token = "0x400038D")]
		GAIN_CH10,
		[Token(Token = "0x400038E")]
		GAIN_CH11,
		[Token(Token = "0x400038F")]
		GAIN_CH12,
		[Token(Token = "0x4000390")]
		GAIN_CH13,
		[Token(Token = "0x4000391")]
		GAIN_CH14,
		[Token(Token = "0x4000392")]
		GAIN_CH15,
		[Token(Token = "0x4000393")]
		GAIN_CH16,
		[Token(Token = "0x4000394")]
		GAIN_CH17,
		[Token(Token = "0x4000395")]
		GAIN_CH18,
		[Token(Token = "0x4000396")]
		GAIN_CH19,
		[Token(Token = "0x4000397")]
		GAIN_CH20,
		[Token(Token = "0x4000398")]
		GAIN_CH21,
		[Token(Token = "0x4000399")]
		GAIN_CH22,
		[Token(Token = "0x400039A")]
		GAIN_CH23,
		[Token(Token = "0x400039B")]
		GAIN_CH24,
		[Token(Token = "0x400039C")]
		GAIN_CH25,
		[Token(Token = "0x400039D")]
		GAIN_CH26,
		[Token(Token = "0x400039E")]
		GAIN_CH27,
		[Token(Token = "0x400039F")]
		GAIN_CH28,
		[Token(Token = "0x40003A0")]
		GAIN_CH29,
		[Token(Token = "0x40003A1")]
		GAIN_CH30,
		[Token(Token = "0x40003A2")]
		GAIN_CH31,
		[Token(Token = "0x40003A3")]
		OUTPUT_CH0,
		[Token(Token = "0x40003A4")]
		OUTPUT_CH1,
		[Token(Token = "0x40003A5")]
		OUTPUT_CH2,
		[Token(Token = "0x40003A6")]
		OUTPUT_CH3,
		[Token(Token = "0x40003A7")]
		OUTPUT_CH4,
		[Token(Token = "0x40003A8")]
		OUTPUT_CH5,
		[Token(Token = "0x40003A9")]
		OUTPUT_CH6,
		[Token(Token = "0x40003AA")]
		OUTPUT_CH7,
		[Token(Token = "0x40003AB")]
		OUTPUT_CH8,
		[Token(Token = "0x40003AC")]
		OUTPUT_CH9,
		[Token(Token = "0x40003AD")]
		OUTPUT_CH10,
		[Token(Token = "0x40003AE")]
		OUTPUT_CH11,
		[Token(Token = "0x40003AF")]
		OUTPUT_CH12,
		[Token(Token = "0x40003B0")]
		OUTPUT_CH13,
		[Token(Token = "0x40003B1")]
		OUTPUT_CH14,
		[Token(Token = "0x40003B2")]
		OUTPUT_CH15,
		[Token(Token = "0x40003B3")]
		OUTPUT_CH16,
		[Token(Token = "0x40003B4")]
		OUTPUT_CH17,
		[Token(Token = "0x40003B5")]
		OUTPUT_CH18,
		[Token(Token = "0x40003B6")]
		OUTPUT_CH19,
		[Token(Token = "0x40003B7")]
		OUTPUT_CH20,
		[Token(Token = "0x40003B8")]
		OUTPUT_CH21,
		[Token(Token = "0x40003B9")]
		OUTPUT_CH22,
		[Token(Token = "0x40003BA")]
		OUTPUT_CH23,
		[Token(Token = "0x40003BB")]
		OUTPUT_CH24,
		[Token(Token = "0x40003BC")]
		OUTPUT_CH25,
		[Token(Token = "0x40003BD")]
		OUTPUT_CH26,
		[Token(Token = "0x40003BE")]
		OUTPUT_CH27,
		[Token(Token = "0x40003BF")]
		OUTPUT_CH28,
		[Token(Token = "0x40003C0")]
		OUTPUT_CH29,
		[Token(Token = "0x40003C1")]
		OUTPUT_CH30,
		[Token(Token = "0x40003C2")]
		OUTPUT_CH31
	}
	[Token(Token = "0x20000B2")]
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		[Token(Token = "0x40003C4")]
		AUTO = -1,
		[Token(Token = "0x40003C5")]
		MONO,
		[Token(Token = "0x40003C6")]
		STEREO,
		[Token(Token = "0x40003C7")]
		SURROUND
	}
	[Token(Token = "0x20000B3")]
	public enum DSP_TRANSCEIVER
	{
		[Token(Token = "0x40003C9")]
		TRANSMIT,
		[Token(Token = "0x40003CA")]
		GAIN,
		[Token(Token = "0x40003CB")]
		CHANNEL,
		[Token(Token = "0x40003CC")]
		TRANSMITSPEAKERMODE
	}
	[Token(Token = "0x20000B4")]
	public enum DSP_OBJECTPAN
	{
		[Token(Token = "0x40003CE")]
		_3D_POSITION,
		[Token(Token = "0x40003CF")]
		_3D_ROLLOFF,
		[Token(Token = "0x40003D0")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x40003D1")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x40003D2")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x40003D3")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x40003D4")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x40003D5")]
		OVERALL_GAIN,
		[Token(Token = "0x40003D6")]
		OUTPUTGAIN
	}
	[Token(Token = "0x20000B5")]
	public class Error
	{
		[Token(Token = "0x6000457")]
		[Address(RVA = "0xE48594", Offset = "0xE48594", VA = "0xE48594")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xE5E268", Offset = "0xE5E268", VA = "0xE5E268")]
		public Error()
		{
		}
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x20000B6")]
	public class STUDIO_VERSION
	{
		[Token(Token = "0x40003D7")]
		public const string dll = "fmodstudio";

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xE6DFB8", Offset = "0xE6DFB8", VA = "0xE6DFB8")]
		public STUDIO_VERSION()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public enum STOP_MODE
	{
		[Token(Token = "0x40003D9")]
		ALLOWFADEOUT,
		[Token(Token = "0x40003DA")]
		IMMEDIATE
	}
	[Token(Token = "0x20000B8")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x40003DC")]
		UNLOADING,
		[Token(Token = "0x40003DD")]
		UNLOADED,
		[Token(Token = "0x40003DE")]
		LOADING,
		[Token(Token = "0x40003DF")]
		LOADED,
		[Token(Token = "0x40003E0")]
		ERROR
	}
	[Token(Token = "0x20000B9")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
	[Token(Token = "0x20000BA")]
	public struct TIMELINE_MARKER_PROPERTIES
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;
	}
	[Token(Token = "0x20000BB")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int bar;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int beat;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float tempo;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
	[Token(Token = "0x20000BC")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x20000BD")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dspusage;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float streamusage;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometryusage;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float updateusage;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
	[Token(Token = "0x20000BE")]
	public struct BUFFER_INFO
	{
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentusage;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int peakusage;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int capacity;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int stallcount;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
	[Token(Token = "0x20000BF")]
	public struct BUFFER_USAGE
	{
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BUFFER_INFO studiocommandqueue;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BUFFER_INFO studiohandle;
	}
	[Token(Token = "0x20000C0")]
	public struct BANK_INFO
	{
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int size;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userdatalength;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
	[Token(Token = "0x20000C1")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000407")]
		PREUPDATE = 1u,
		[Token(Token = "0x4000408")]
		POSTUPDATE = 2u,
		[Token(Token = "0x4000409")]
		BANK_UNLOAD = 4u,
		[Token(Token = "0x400040A")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000C2")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata, IntPtr userdata);
	[Token(Token = "0x20000C3")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x400040C")]
		GAME_CONTROLLED,
		[Token(Token = "0x400040D")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x400040E")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x400040F")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x4000410")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x4000411")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x4000412")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x4000413")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x4000414")]
		MAX
	}
	[Token(Token = "0x20000C4")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x4000416")]
		READONLY = 1u,
		[Token(Token = "0x4000417")]
		AUTOMATIC = 2u,
		[Token(Token = "0x4000418")]
		GLOBAL = 4u
	}
	[Token(Token = "0x20000C5")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;
	}
	[Token(Token = "0x20000C6")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
	[Token(Token = "0x20000C7")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x4000423")]
		LOAD_MEMORY,
		[Token(Token = "0x4000424")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x20000C8")]
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		[Token(Token = "0x4000426")]
		VALUE = 0x20
	}
	[Token(Token = "0x20000C9")]
	public struct SOUND_INFO
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MODE mode;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int subsoundindex;

		[Token(Token = "0x17000002")]
		public string name
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xE6D39C", Offset = "0xE6D39C", VA = "0xE6D39C")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000CA")]
	public enum USER_PROPERTY_TYPE
	{
		[Token(Token = "0x400042C")]
		INTEGER,
		[Token(Token = "0x400042D")]
		BOOLEAN,
		[Token(Token = "0x400042E")]
		FLOAT,
		[Token(Token = "0x400042F")]
		STRING
	}
	[Token(Token = "0x20000CB")]
	public struct USER_PROPERTY
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xE7C36C", Offset = "0xE7C36C", VA = "0xE7C36C")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xE7C384", Offset = "0xE7C384", VA = "0xE7C384")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xE7C3A8", Offset = "0xE7C3A8", VA = "0xE7C3A8")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xE7C3C4", Offset = "0xE7C3C4", VA = "0xE7C3C4")]
		public string stringValue()
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x20000CC")]
	internal struct Union_IntBoolFloatString
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
	[Token(Token = "0x20000CD")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x4000438")]
		NORMAL = 0u,
		[Token(Token = "0x4000439")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x400043A")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x400043B")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x400043C")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x400043D")]
		LOAD_FROM_UPDATE = 0x10u,
		[Token(Token = "0x400043E")]
		MEMORY_TRACKING = 0x20u
	}
	[Token(Token = "0x20000CE")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x4000440")]
		NORMAL = 0u,
		[Token(Token = "0x4000441")]
		NONBLOCKING = 1u,
		[Token(Token = "0x4000442")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x4000443")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x20000CF")]
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		[Token(Token = "0x4000445")]
		NORMAL = 0u,
		[Token(Token = "0x4000446")]
		FILEFLUSH = 1u,
		[Token(Token = "0x4000447")]
		SKIP_INITIAL_STATE = 2u
	}
	[Token(Token = "0x20000D0")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		[Token(Token = "0x4000449")]
		NORMAL = 0u,
		[Token(Token = "0x400044A")]
		SKIP_CLEANUP = 1u,
		[Token(Token = "0x400044B")]
		FAST_FORWARD = 2u,
		[Token(Token = "0x400044C")]
		SKIP_BANK_LOAD = 4u
	}
	[Token(Token = "0x20000D1")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x400044E")]
		PLAYING,
		[Token(Token = "0x400044F")]
		SUSTAINING,
		[Token(Token = "0x4000450")]
		STOPPED,
		[Token(Token = "0x4000451")]
		STARTING,
		[Token(Token = "0x4000452")]
		STOPPING
	}
	[Token(Token = "0x20000D2")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x4000454")]
		CHANNELPRIORITY,
		[Token(Token = "0x4000455")]
		SCHEDULE_DELAY,
		[Token(Token = "0x4000456")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x4000457")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x4000458")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x4000459")]
		COOLDOWN,
		[Token(Token = "0x400045A")]
		MAX
	}
	[Token(Token = "0x20000D3")]
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr dsp;
	}
	[Token(Token = "0x20000D4")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x400045E")]
		CREATED = 1u,
		[Token(Token = "0x400045F")]
		DESTROYED = 2u,
		[Token(Token = "0x4000460")]
		STARTING = 4u,
		[Token(Token = "0x4000461")]
		STARTED = 8u,
		[Token(Token = "0x4000462")]
		RESTARTED = 0x10u,
		[Token(Token = "0x4000463")]
		STOPPED = 0x20u,
		[Token(Token = "0x4000464")]
		START_FAILED = 0x40u,
		[Token(Token = "0x4000465")]
		CREATE_PROGRAMMER_SOUND = 0x80u,
		[Token(Token = "0x4000466")]
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		[Token(Token = "0x4000467")]
		PLUGIN_CREATED = 0x200u,
		[Token(Token = "0x4000468")]
		PLUGIN_DESTROYED = 0x400u,
		[Token(Token = "0x4000469")]
		TIMELINE_MARKER = 0x800u,
		[Token(Token = "0x400046A")]
		TIMELINE_BEAT = 0x1000u,
		[Token(Token = "0x400046B")]
		SOUND_PLAYED = 0x2000u,
		[Token(Token = "0x400046C")]
		SOUND_STOPPED = 0x4000u,
		[Token(Token = "0x400046D")]
		REAL_TO_VIRTUAL = 0x8000u,
		[Token(Token = "0x400046E")]
		VIRTUAL_TO_REAL = 0x10000u,
		[Token(Token = "0x400046F")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000D5")]
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, EventInstance _event, IntPtr parameters);
	[Token(Token = "0x20000D6")]
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(CommandReplay replay, int commandindex, float currenttime, IntPtr userdata);
	[Token(Token = "0x20000D7")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, int commandindex, Guid bankguid, StringWrapper bankfilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
	[Token(Token = "0x20000D8")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, int commandindex, EventDescription eventdescription, out EventInstance instance, IntPtr userdata);
	[Token(Token = "0x20000D9")]
	public enum INSTANCETYPE
	{
		[Token(Token = "0x4000471")]
		NONE,
		[Token(Token = "0x4000472")]
		SYSTEM,
		[Token(Token = "0x4000473")]
		EVENTDESCRIPTION,
		[Token(Token = "0x4000474")]
		EVENTINSTANCE,
		[Token(Token = "0x4000475")]
		PARAMETERINSTANCE,
		[Token(Token = "0x4000476")]
		BUS,
		[Token(Token = "0x4000477")]
		VCA,
		[Token(Token = "0x4000478")]
		BANK,
		[Token(Token = "0x4000479")]
		COMMANDREPLAY
	}
	[Token(Token = "0x20000DA")]
	public struct COMMAND_INFO
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int framenumber;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frametime;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
	[Token(Token = "0x20000DB")]
	public struct MEMORY_USAGE
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int exclusive;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int inclusive;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int sampledata;
	}
	[Token(Token = "0x20000DC")]
	public struct Util
	{
		[Token(Token = "0x6000473")]
		[Address(RVA = "0xE6B270", Offset = "0xE6B270", VA = "0xE6B270")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000474")]
		[Address(RVA = "0xE7C428", Offset = "0xE7C428", VA = "0xE7C428")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x20000DD")]
	public struct System
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xE67C48", Offset = "0xE67C48", VA = "0xE67C48")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xE78E3C", Offset = "0xE78E3C", VA = "0xE78E3C")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xE67D38", Offset = "0xE67D38", VA = "0xE67D38")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xE7902C", Offset = "0xE7902C", VA = "0xE7902C")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xE67EE0", Offset = "0xE67EE0", VA = "0xE67EE0")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xE67334", Offset = "0xE67334", VA = "0xE67334")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xE67EF0", Offset = "0xE67EF0", VA = "0xE67EF0")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xE67C54", Offset = "0xE67C54", VA = "0xE67C54")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xE793D4", Offset = "0xE793D4", VA = "0xE793D4")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xE6C6DC", Offset = "0xE6C6DC", VA = "0xE6C6DC")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xE6C92C", Offset = "0xE6C92C", VA = "0xE6C92C")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xE79748", Offset = "0xE79748", VA = "0xE79748")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xE6BF28", Offset = "0xE6BF28", VA = "0xE6BF28")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xE79A14", Offset = "0xE79A14", VA = "0xE79A14")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xE79AD8", Offset = "0xE79AD8", VA = "0xE79AD8")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xE79B9C", Offset = "0xE79B9C", VA = "0xE79B9C")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xE79C60", Offset = "0xE79C60", VA = "0xE79C60")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xE72F44", Offset = "0xE72F44", VA = "0xE72F44")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xE79F90", Offset = "0xE79F90", VA = "0xE79F90")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xE7A030", Offset = "0xE7A030", VA = "0xE7A030")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xE7A058", Offset = "0xE7A058", VA = "0xE7A058")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xE73250", Offset = "0xE73250", VA = "0xE73250")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xE7A1B0", Offset = "0xE7A1B0", VA = "0xE7A1B0")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xE7A27C", Offset = "0xE7A27C", VA = "0xE7A27C")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xE7A2A0", Offset = "0xE7A2A0", VA = "0xE7A2A0")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xE7A4EC", Offset = "0xE7A4EC", VA = "0xE7A4EC")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xE6B3F4", Offset = "0xE6B3F4", VA = "0xE6B3F4")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xE7A7D8", Offset = "0xE7A7D8", VA = "0xE7A7D8")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xE7AB2C", Offset = "0xE7AB2C", VA = "0xE7AB2C")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xE68A34", Offset = "0xE68A34", VA = "0xE68A34")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xE7AC54", Offset = "0xE7AC54", VA = "0xE7AC54")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xE6C120", Offset = "0xE6C120", VA = "0xE6C120")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xE7AD8C", Offset = "0xE7AD8C", VA = "0xE7AD8C")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xE7AE2C", Offset = "0xE7AE2C", VA = "0xE7AE2C")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xE6AA04", Offset = "0xE6AA04", VA = "0xE6AA04")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xE6A974", Offset = "0xE6A974", VA = "0xE6A974")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xE7B044", Offset = "0xE7B044", VA = "0xE7B044")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xE7B23C", Offset = "0xE7B23C", VA = "0xE7B23C")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xE67EE8", Offset = "0xE67EE8", VA = "0xE67EE8")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xE6B12C", Offset = "0xE6B12C", VA = "0xE6B12C")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xE7B3C4", Offset = "0xE7B3C4", VA = "0xE7B3C4")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xE7B5F8", Offset = "0xE7B5F8", VA = "0xE7B5F8")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xE7B680", Offset = "0xE7B680", VA = "0xE7B680")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xE7B8CC", Offset = "0xE7B8CC", VA = "0xE7B8CC")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xE7B964", Offset = "0xE7B964", VA = "0xE7B964")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xE7BB84", Offset = "0xE7BB84", VA = "0xE7BB84")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xE7BC1C", Offset = "0xE7BC1C", VA = "0xE7BC1C")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xE69ED0", Offset = "0xE69ED0", VA = "0xE69ED0")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xE7BF0C", Offset = "0xE7BF0C", VA = "0xE7BF0C")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xE7BFA4", Offset = "0xE7BFA4", VA = "0xE7BFA4")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xE7C02C", Offset = "0xE7C02C", VA = "0xE7C02C")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xE7C0D4", Offset = "0xE7C0D4", VA = "0xE7C0D4")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xE7C16C", Offset = "0xE7C16C", VA = "0xE7C16C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xE7C204", Offset = "0xE7C204", VA = "0xE7C204")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xE78DAC", Offset = "0xE78DAC", VA = "0xE78DAC")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xE7C29C", Offset = "0xE7C29C", VA = "0xE7C29C")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xE78F14", Offset = "0xE78F14", VA = "0xE78F14")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xE79104", Offset = "0xE79104", VA = "0xE79104")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xE79194", Offset = "0xE79194", VA = "0xE79194")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xE79244", Offset = "0xE79244", VA = "0xE79244")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xE792C4", Offset = "0xE792C4", VA = "0xE792C4")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xE79344", Offset = "0xE79344", VA = "0xE79344")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xE79568", Offset = "0xE79568", VA = "0xE79568")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xE79608", Offset = "0xE79608", VA = "0xE79608")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xE796A8", Offset = "0xE796A8", VA = "0xE796A8")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xE798DC", Offset = "0xE798DC", VA = "0xE798DC")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xE7997C", Offset = "0xE7997C", VA = "0xE7997C")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xE79A40", Offset = "0xE79A40", VA = "0xE79A40")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xE79B04", Offset = "0xE79B04", VA = "0xE79B04")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xE79BC8", Offset = "0xE79BC8", VA = "0xE79BC8")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xE79DF4", Offset = "0xE79DF4", VA = "0xE79DF4")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xE79EF0", Offset = "0xE79EF0", VA = "0xE79EF0")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xE79F98", Offset = "0xE79F98", VA = "0xE79F98")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xE7A060", Offset = "0xE7A060", VA = "0xE7A060")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xE7A108", Offset = "0xE7A108", VA = "0xE7A108")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xE7A1BC", Offset = "0xE7A1BC", VA = "0xE7A1BC")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xE7A43C", Offset = "0xE7A43C", VA = "0xE7A43C")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xE7A688", Offset = "0xE7A688", VA = "0xE7A688")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xE7A738", Offset = "0xE7A738", VA = "0xE7A738")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xE7AA7C", Offset = "0xE7AA7C", VA = "0xE7AA7C")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xE7AB34", Offset = "0xE7AB34", VA = "0xE7AB34")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xE7ABC4", Offset = "0xE7ABC4", VA = "0xE7ABC4")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xE7AC5C", Offset = "0xE7AC5C", VA = "0xE7AC5C")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xE7ACF4", Offset = "0xE7ACF4", VA = "0xE7ACF4")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xE7AD94", Offset = "0xE7AD94", VA = "0xE7AD94")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xE7AE34", Offset = "0xE7AE34", VA = "0xE7AE34")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xE7AED4", Offset = "0xE7AED4", VA = "0xE7AED4")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xE7AF84", Offset = "0xE7AF84", VA = "0xE7AF84")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xE7B12C", Offset = "0xE7B12C", VA = "0xE7B12C")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xE7B244", Offset = "0xE7B244", VA = "0xE7B244")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xE7B2C4", Offset = "0xE7B2C4", VA = "0xE7B2C4")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xE7B344", Offset = "0xE7B344", VA = "0xE7B344")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xE7B558", Offset = "0xE7B558", VA = "0xE7B558")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xE7B600", Offset = "0xE7B600", VA = "0xE7B600")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xE7B81C", Offset = "0xE7B81C", VA = "0xE7B81C")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xE7B8D4", Offset = "0xE7B8D4", VA = "0xE7B8D4")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xE7BAD4", Offset = "0xE7BAD4", VA = "0xE7BAD4")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xE7BB8C", Offset = "0xE7BB8C", VA = "0xE7BB8C")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xE7BD2C", Offset = "0xE7BD2C", VA = "0xE7BD2C")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xE7BE7C", Offset = "0xE7BE7C", VA = "0xE7BE7C")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xE7BF14", Offset = "0xE7BF14", VA = "0xE7BF14")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xE7BFAC", Offset = "0xE7BFAC", VA = "0xE7BFAC")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xE7C034", Offset = "0xE7C034", VA = "0xE7C034")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xE7C0DC", Offset = "0xE7C0DC", VA = "0xE7C0DC")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xE7C174", Offset = "0xE7C174", VA = "0xE7C174")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xE7C20C", Offset = "0xE7C20C", VA = "0xE7C20C")]
		private static extern RESULT FMOD_Studio_System_GetMemoryUsage(IntPtr system, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xE7C324", Offset = "0xE7C324", VA = "0xE7C324")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xE6733C", Offset = "0xE6733C", VA = "0xE6733C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xE672FC", Offset = "0xE672FC", VA = "0xE672FC")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DE")]
	public struct EventDescription
	{
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xE5E270", Offset = "0xE5E270", VA = "0xE5E270")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xE5E308", Offset = "0xE5E308", VA = "0xE5E308")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xE5E648", Offset = "0xE5E648", VA = "0xE5E648")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xE5E6E0", Offset = "0xE5E6E0", VA = "0xE5E6E0")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xE5E780", Offset = "0xE5E780", VA = "0xE5E780")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xE5E9B4", Offset = "0xE5E9B4", VA = "0xE5E9B4")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xE5EA54", Offset = "0xE5EA54", VA = "0xE5EA54")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xE5EAEC", Offset = "0xE5EAEC", VA = "0xE5EAEC")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xE5EBBC", Offset = "0xE5EBBC", VA = "0xE5EBBC")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xE5EE20", Offset = "0xE5EE20", VA = "0xE5EE20")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xE5EEB8", Offset = "0xE5EEB8", VA = "0xE5EEB8")]
		public RESULT getMinimumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xE5EF50", Offset = "0xE5EF50", VA = "0xE5EF50")]
		public RESULT getMaximumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xE5EFE8", Offset = "0xE5EFE8", VA = "0xE5EFE8")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xE5F080", Offset = "0xE5F080", VA = "0xE5F080")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xE5F12C", Offset = "0xE5F12C", VA = "0xE5F12C")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xE5F1D8", Offset = "0xE5F1D8", VA = "0xE5F1D8")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xE5F284", Offset = "0xE5F284", VA = "0xE5F284")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xE5F330", Offset = "0xE5F330", VA = "0xE5F330")]
		public RESULT hasCue(out bool cue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xE5F3DC", Offset = "0xE5F3DC", VA = "0xE5F3DC")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xE5F474", Offset = "0xE5F474", VA = "0xE5F474")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xE5F50C", Offset = "0xE5F50C", VA = "0xE5F50C")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xE5F72C", Offset = "0xE5F72C", VA = "0xE5F72C")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xE5F7B4", Offset = "0xE5F7B4", VA = "0xE5F7B4")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xE5F83C", Offset = "0xE5F83C", VA = "0xE5F83C")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xE5F8D4", Offset = "0xE5F8D4", VA = "0xE5F8D4")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xE5F95C", Offset = "0xE5F95C", VA = "0xE5F95C")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xE5FA04", Offset = "0xE5FA04", VA = "0xE5FA04")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xE5FA9C", Offset = "0xE5FA9C", VA = "0xE5FA9C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xE5FB34", Offset = "0xE5FB34", VA = "0xE5FB34")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xE5E278", Offset = "0xE5E278", VA = "0xE5E278")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0xE5E5A0", Offset = "0xE5E5A0", VA = "0xE5E5A0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000501")]
		[Address(RVA = "0xE5E650", Offset = "0xE5E650", VA = "0xE5E650")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000502")]
		[Address(RVA = "0xE5E6E8", Offset = "0xE5E6E8", VA = "0xE5E6E8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000503")]
		[Address(RVA = "0xE5E914", Offset = "0xE5E914", VA = "0xE5E914")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000504")]
		[Address(RVA = "0xE5E9BC", Offset = "0xE5E9BC", VA = "0xE5E9BC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x6000505")]
		[Address(RVA = "0xE5EA5C", Offset = "0xE5EA5C", VA = "0xE5EA5C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000506")]
		[Address(RVA = "0xE5EAF4", Offset = "0xE5EAF4", VA = "0xE5EAF4")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000507")]
		[Address(RVA = "0xE5ED50", Offset = "0xE5ED50", VA = "0xE5ED50")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x6000508")]
		[Address(RVA = "0xE5EE28", Offset = "0xE5EE28", VA = "0xE5EE28")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x6000509")]
		[Address(RVA = "0xE5EEC0", Offset = "0xE5EEC0", VA = "0xE5EEC0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x600050A")]
		[Address(RVA = "0xE5EF58", Offset = "0xE5EF58", VA = "0xE5EF58")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x600050B")]
		[Address(RVA = "0xE5EFF0", Offset = "0xE5EFF0", VA = "0xE5EFF0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x600050C")]
		[Address(RVA = "0xE5F088", Offset = "0xE5F088", VA = "0xE5F088")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x600050D")]
		[Address(RVA = "0xE5F134", Offset = "0xE5F134", VA = "0xE5F134")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x600050E")]
		[Address(RVA = "0xE5F1E0", Offset = "0xE5F1E0", VA = "0xE5F1E0")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x600050F")]
		[Address(RVA = "0xE5F28C", Offset = "0xE5F28C", VA = "0xE5F28C")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x6000510")]
		[Address(RVA = "0xE5F338", Offset = "0xE5F338", VA = "0xE5F338")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[PreserveSig]
		[Token(Token = "0x6000511")]
		[Address(RVA = "0xE5F3E4", Offset = "0xE5F3E4", VA = "0xE5F3E4")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x6000512")]
		[Address(RVA = "0xE5F47C", Offset = "0xE5F47C", VA = "0xE5F47C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000513")]
		[Address(RVA = "0xE5F67C", Offset = "0xE5F67C", VA = "0xE5F67C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000514")]
		[Address(RVA = "0xE5F734", Offset = "0xE5F734", VA = "0xE5F734")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000515")]
		[Address(RVA = "0xE5F7BC", Offset = "0xE5F7BC", VA = "0xE5F7BC")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000516")]
		[Address(RVA = "0xE5F844", Offset = "0xE5F844", VA = "0xE5F844")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000517")]
		[Address(RVA = "0xE5F8DC", Offset = "0xE5F8DC", VA = "0xE5F8DC")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0xE5F964", Offset = "0xE5F964", VA = "0xE5F964")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0xE5FA0C", Offset = "0xE5FA0C", VA = "0xE5FA0C")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600051A")]
		[Address(RVA = "0xE5FAA4", Offset = "0xE5FAA4", VA = "0xE5FAA4")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xE5FBBC", Offset = "0xE5FBBC", VA = "0xE5FBBC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xE5FC04", Offset = "0xE5FC04", VA = "0xE5FC04")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xE5FC44", Offset = "0xE5FC44", VA = "0xE5FC44")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DF")]
	public struct EventInstance
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xE5FF18", Offset = "0xE5FF18", VA = "0xE5FF18")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xE5FFB0", Offset = "0xE5FFB0", VA = "0xE5FFB0")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xE5FFD8", Offset = "0xE5FFD8", VA = "0xE5FFD8")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xE60078", Offset = "0xE60078", VA = "0xE60078")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xE60110", Offset = "0xE60110", VA = "0xE60110")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xE60138", Offset = "0xE60138", VA = "0xE60138")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xE601D8", Offset = "0xE601D8", VA = "0xE601D8")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xE60270", Offset = "0xE60270", VA = "0xE60270")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xE60308", Offset = "0xE60308", VA = "0xE60308")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xE603A0", Offset = "0xE603A0", VA = "0xE603A0")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xE60438", Offset = "0xE60438", VA = "0xE60438")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xE604D0", Offset = "0xE604D0", VA = "0xE604D0")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xE60570", Offset = "0xE60570", VA = "0xE60570")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xE60618", Offset = "0xE60618", VA = "0xE60618")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xE606B8", Offset = "0xE606B8", VA = "0xE606B8")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xE60760", Offset = "0xE60760", VA = "0xE60760")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xE6080C", Offset = "0xE6080C", VA = "0xE6080C")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xE608A8", Offset = "0xE608A8", VA = "0xE608A8")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xE60930", Offset = "0xE60930", VA = "0xE60930")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xE609C8", Offset = "0xE609C8", VA = "0xE609C8")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xE60A60", Offset = "0xE60A60", VA = "0xE60A60")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xE60AF8", Offset = "0xE60AF8", VA = "0xE60AF8")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xE60B90", Offset = "0xE60B90", VA = "0xE60B90")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xE60C28", Offset = "0xE60C28", VA = "0xE60C28")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xE60CB0", Offset = "0xE60CB0", VA = "0xE60CB0")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xE60D5C", Offset = "0xE60D5C", VA = "0xE60D5C")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xE60D84", Offset = "0xE60D84", VA = "0xE60D84")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xE60E34", Offset = "0xE60E34", VA = "0xE60E34")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xE60EE8", Offset = "0xE60EE8", VA = "0xE60EE8")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xE60FB4", Offset = "0xE60FB4", VA = "0xE60FB4")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xE60FD8", Offset = "0xE60FD8", VA = "0xE60FD8")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xE61224", Offset = "0xE61224", VA = "0xE61224")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xE61470", Offset = "0xE61470", VA = "0xE61470")]
		public RESULT triggerCue()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xE614F8", Offset = "0xE614F8", VA = "0xE614F8")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xE615A0", Offset = "0xE615A0", VA = "0xE615A0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xE61638", Offset = "0xE61638", VA = "0xE61638")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xE616D0", Offset = "0xE616D0", VA = "0xE616D0")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xE61770", Offset = "0xE61770", VA = "0xE61770")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000544")]
		[Address(RVA = "0xE61808", Offset = "0xE61808", VA = "0xE61808")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000545")]
		[Address(RVA = "0xE5FF20", Offset = "0xE5FF20", VA = "0xE5FF20")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x6000546")]
		[Address(RVA = "0xE5FFE0", Offset = "0xE5FFE0", VA = "0xE5FFE0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000547")]
		[Address(RVA = "0xE60080", Offset = "0xE60080", VA = "0xE60080")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x6000548")]
		[Address(RVA = "0xE60140", Offset = "0xE60140", VA = "0xE60140")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x6000549")]
		[Address(RVA = "0xE601E0", Offset = "0xE601E0", VA = "0xE601E0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x600054A")]
		[Address(RVA = "0xE60278", Offset = "0xE60278", VA = "0xE60278")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600054B")]
		[Address(RVA = "0xE60310", Offset = "0xE60310", VA = "0xE60310")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x600054C")]
		[Address(RVA = "0xE603A8", Offset = "0xE603A8", VA = "0xE603A8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x600054D")]
		[Address(RVA = "0xE60440", Offset = "0xE60440", VA = "0xE60440")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x600054E")]
		[Address(RVA = "0xE604D8", Offset = "0xE604D8", VA = "0xE604D8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x600054F")]
		[Address(RVA = "0xE60578", Offset = "0xE60578", VA = "0xE60578")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x6000550")]
		[Address(RVA = "0xE60620", Offset = "0xE60620", VA = "0xE60620")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x6000551")]
		[Address(RVA = "0xE606C0", Offset = "0xE606C0", VA = "0xE606C0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x6000552")]
		[Address(RVA = "0xE60768", Offset = "0xE60768", VA = "0xE60768")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000553")]
		[Address(RVA = "0xE60818", Offset = "0xE60818", VA = "0xE60818")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000554")]
		[Address(RVA = "0xE608B0", Offset = "0xE608B0", VA = "0xE608B0")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000555")]
		[Address(RVA = "0xE60938", Offset = "0xE60938", VA = "0xE60938")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000556")]
		[Address(RVA = "0xE609D0", Offset = "0xE609D0", VA = "0xE609D0")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x6000557")]
		[Address(RVA = "0xE60A68", Offset = "0xE60A68", VA = "0xE60A68")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x6000558")]
		[Address(RVA = "0xE60B00", Offset = "0xE60B00", VA = "0xE60B00")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000559")]
		[Address(RVA = "0xE60B98", Offset = "0xE60B98", VA = "0xE60B98")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x600055A")]
		[Address(RVA = "0xE60C30", Offset = "0xE60C30", VA = "0xE60C30")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600055B")]
		[Address(RVA = "0xE60CB8", Offset = "0xE60CB8", VA = "0xE60CB8")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x600055C")]
		[Address(RVA = "0xE61174", Offset = "0xE61174", VA = "0xE61174")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x600055D")]
		[Address(RVA = "0xE613C0", Offset = "0xE613C0", VA = "0xE613C0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x600055E")]
		[Address(RVA = "0xE60D8C", Offset = "0xE60D8C", VA = "0xE60D8C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x600055F")]
		[Address(RVA = "0xE60E40", Offset = "0xE60E40", VA = "0xE60E40")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000560")]
		[Address(RVA = "0xE60EF4", Offset = "0xE60EF4", VA = "0xE60EF4")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000561")]
		[Address(RVA = "0xE61478", Offset = "0xE61478", VA = "0xE61478")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000562")]
		[Address(RVA = "0xE61500", Offset = "0xE61500", VA = "0xE61500")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000563")]
		[Address(RVA = "0xE615A8", Offset = "0xE615A8", VA = "0xE615A8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000564")]
		[Address(RVA = "0xE61640", Offset = "0xE61640", VA = "0xE61640")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000565")]
		[Address(RVA = "0xE616D8", Offset = "0xE616D8", VA = "0xE616D8")]
		private static extern RESULT FMOD_Studio_EventInstance_GetCPUUsage(IntPtr _event, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x6000566")]
		[Address(RVA = "0xE61778", Offset = "0xE61778", VA = "0xE61778")]
		private static extern RESULT FMOD_Studio_EventInstance_GetMemoryUsage(IntPtr _event, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xE61890", Offset = "0xE61890", VA = "0xE61890")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xE618D8", Offset = "0xE618D8", VA = "0xE618D8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xE61918", Offset = "0xE61918", VA = "0xE61918")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E0")]
	public struct Bus
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xE48A98", Offset = "0xE48A98", VA = "0xE48A98")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xE48B30", Offset = "0xE48B30", VA = "0xE48B30")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xE48E70", Offset = "0xE48E70", VA = "0xE48E70")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xE48E98", Offset = "0xE48E98", VA = "0xE48E98")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xE48F38", Offset = "0xE48F38", VA = "0xE48F38")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xE48FD0", Offset = "0xE48FD0", VA = "0xE48FD0")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xE4907C", Offset = "0xE4907C", VA = "0xE4907C")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xE49118", Offset = "0xE49118", VA = "0xE49118")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xE491C4", Offset = "0xE491C4", VA = "0xE491C4")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xE49260", Offset = "0xE49260", VA = "0xE49260")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xE492F8", Offset = "0xE492F8", VA = "0xE492F8")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xE49380", Offset = "0xE49380", VA = "0xE49380")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xE49408", Offset = "0xE49408", VA = "0xE49408")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xE494A0", Offset = "0xE494A0", VA = "0xE494A0")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xE49540", Offset = "0xE49540", VA = "0xE49540")]
		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0xE495D8", Offset = "0xE495D8", VA = "0xE495D8")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x600057A")]
		[Address(RVA = "0xE48AA0", Offset = "0xE48AA0", VA = "0xE48AA0")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0xE48DC8", Offset = "0xE48DC8", VA = "0xE48DC8")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600057C")]
		[Address(RVA = "0xE48EA0", Offset = "0xE48EA0", VA = "0xE48EA0")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x600057D")]
		[Address(RVA = "0xE48F40", Offset = "0xE48F40", VA = "0xE48F40")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x600057E")]
		[Address(RVA = "0xE48FD8", Offset = "0xE48FD8", VA = "0xE48FD8")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x600057F")]
		[Address(RVA = "0xE49088", Offset = "0xE49088", VA = "0xE49088")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000580")]
		[Address(RVA = "0xE49120", Offset = "0xE49120", VA = "0xE49120")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000581")]
		[Address(RVA = "0xE491D0", Offset = "0xE491D0", VA = "0xE491D0")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000582")]
		[Address(RVA = "0xE49268", Offset = "0xE49268", VA = "0xE49268")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x6000583")]
		[Address(RVA = "0xE49300", Offset = "0xE49300", VA = "0xE49300")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000584")]
		[Address(RVA = "0xE49388", Offset = "0xE49388", VA = "0xE49388")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x6000585")]
		[Address(RVA = "0xE49410", Offset = "0xE49410", VA = "0xE49410")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x6000586")]
		[Address(RVA = "0xE494A8", Offset = "0xE494A8", VA = "0xE494A8")]
		private static extern RESULT FMOD_Studio_Bus_GetCPUUsage(IntPtr bus, out uint exclusive, out uint inclusive);

		[PreserveSig]
		[Token(Token = "0x6000587")]
		[Address(RVA = "0xE49548", Offset = "0xE49548", VA = "0xE49548")]
		private static extern RESULT FMOD_Studio_Bus_GetMemoryUsage(IntPtr bus, out MEMORY_USAGE memoryusage);

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xE49660", Offset = "0xE49660", VA = "0xE49660")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xE496A8", Offset = "0xE496A8", VA = "0xE496A8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xE496E8", Offset = "0xE496E8", VA = "0xE496E8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E1")]
	public struct VCA
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xE7C4C0", Offset = "0xE7C4C0", VA = "0xE7C4C0")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xE7C558", Offset = "0xE7C558", VA = "0xE7C558")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xE7C898", Offset = "0xE7C898", VA = "0xE7C898")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xE7C8C0", Offset = "0xE7C8C0", VA = "0xE7C8C0")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xE7C960", Offset = "0xE7C960", VA = "0xE7C960")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000590")]
		[Address(RVA = "0xE7C9F8", Offset = "0xE7C9F8", VA = "0xE7C9F8")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x6000591")]
		[Address(RVA = "0xE7C4C8", Offset = "0xE7C4C8", VA = "0xE7C4C8")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE7C7F0", Offset = "0xE7C7F0", VA = "0xE7C7F0")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000593")]
		[Address(RVA = "0xE7C8C8", Offset = "0xE7C8C8", VA = "0xE7C8C8")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x6000594")]
		[Address(RVA = "0xE7C968", Offset = "0xE7C968", VA = "0xE7C968")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xE7CA80", Offset = "0xE7CA80", VA = "0xE7CA80")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xE7CAC8", Offset = "0xE7CAC8", VA = "0xE7CAC8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xE7CB08", Offset = "0xE7CB08", VA = "0xE7CB08")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E2")]
	public struct Bank
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xE469BC", Offset = "0xE469BC", VA = "0xE469BC")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xE46A54", Offset = "0xE46A54", VA = "0xE46A54")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xE472BC", Offset = "0xE472BC", VA = "0xE472BC")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xE47344", Offset = "0xE47344", VA = "0xE47344")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xE473CC", Offset = "0xE473CC", VA = "0xE473CC")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xE47454", Offset = "0xE47454", VA = "0xE47454")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xE474EC", Offset = "0xE474EC", VA = "0xE474EC")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xE47584", Offset = "0xE47584", VA = "0xE47584")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xE4761C", Offset = "0xE4761C", VA = "0xE4761C")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xE479D0", Offset = "0xE479D0", VA = "0xE479D0")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xE47A68", Offset = "0xE47A68", VA = "0xE47A68")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xE47C88", Offset = "0xE47C88", VA = "0xE47C88")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xE47D20", Offset = "0xE47D20", VA = "0xE47D20")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xE47F40", Offset = "0xE47F40", VA = "0xE47F40")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xE47FD8", Offset = "0xE47FD8", VA = "0xE47FD8")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xE481F8", Offset = "0xE481F8", VA = "0xE481F8")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xE48290", Offset = "0xE48290", VA = "0xE48290")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xE48328", Offset = "0xE48328", VA = "0xE48328")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xE469C4", Offset = "0xE469C4", VA = "0xE469C4")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xE46FB8", Offset = "0xE46FB8", VA = "0xE46FB8")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xE472C4", Offset = "0xE472C4", VA = "0xE472C4")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xE4734C", Offset = "0xE4734C", VA = "0xE4734C")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xE473D4", Offset = "0xE473D4", VA = "0xE473D4")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xE4745C", Offset = "0xE4745C", VA = "0xE4745C")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xE474F4", Offset = "0xE474F4", VA = "0xE474F4")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xE4758C", Offset = "0xE4758C", VA = "0xE4758C")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xE47910", Offset = "0xE47910", VA = "0xE47910")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xE479D8", Offset = "0xE479D8", VA = "0xE479D8")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE47BD8", Offset = "0xE47BD8", VA = "0xE47BD8")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xE47C90", Offset = "0xE47C90", VA = "0xE47C90")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xE47E90", Offset = "0xE47E90", VA = "0xE47E90")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xE47F48", Offset = "0xE47F48", VA = "0xE47F48")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xE48148", Offset = "0xE48148", VA = "0xE48148")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xE48200", Offset = "0xE48200", VA = "0xE48200")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xE48298", Offset = "0xE48298", VA = "0xE48298")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xE483B0", Offset = "0xE483B0", VA = "0xE483B0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xE483F8", Offset = "0xE483F8", VA = "0xE483F8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xE48438", Offset = "0xE48438", VA = "0xE48438")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E3")]
	public struct CommandReplay
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xE50DC0", Offset = "0xE50DC0", VA = "0xE50DC0")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xE50E58", Offset = "0xE50E58", VA = "0xE50E58")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xE50EF0", Offset = "0xE50EF0", VA = "0xE50EF0")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE50F88", Offset = "0xE50F88", VA = "0xE50F88")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xE51028", Offset = "0xE51028", VA = "0xE51028")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE51378", Offset = "0xE51378", VA = "0xE51378")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE51420", Offset = "0xE51420", VA = "0xE51420")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xE51790", Offset = "0xE51790", VA = "0xE51790")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xE51818", Offset = "0xE51818", VA = "0xE51818")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xE518A0", Offset = "0xE518A0", VA = "0xE518A0")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xE51938", Offset = "0xE51938", VA = "0xE51938")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xE519D0", Offset = "0xE519D0", VA = "0xE519D0")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xE51A7C", Offset = "0xE51A7C", VA = "0xE51A7C")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xE51B18", Offset = "0xE51B18", VA = "0xE51B18")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xE51BB0", Offset = "0xE51BB0", VA = "0xE51BB0")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xE51C50", Offset = "0xE51C50", VA = "0xE51C50")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xE51CD8", Offset = "0xE51CD8", VA = "0xE51CD8")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xE51D78", Offset = "0xE51D78", VA = "0xE51D78")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xE51E18", Offset = "0xE51E18", VA = "0xE51E18")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xE51EB8", Offset = "0xE51EB8", VA = "0xE51EB8")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xE51F50", Offset = "0xE51F50", VA = "0xE51F50")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xE51FE8", Offset = "0xE51FE8", VA = "0xE51FE8")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xE50DC8", Offset = "0xE50DC8", VA = "0xE50DC8")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xE50E60", Offset = "0xE50E60", VA = "0xE50E60")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xE50EF8", Offset = "0xE50EF8", VA = "0xE50EF8")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xE50F90", Offset = "0xE50F90", VA = "0xE50F90")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xE512D0", Offset = "0xE512D0", VA = "0xE512D0")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xE51380", Offset = "0xE51380", VA = "0xE51380")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xE516F8", Offset = "0xE516F8", VA = "0xE516F8")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xE51798", Offset = "0xE51798", VA = "0xE51798")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xE51820", Offset = "0xE51820", VA = "0xE51820")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xE518A8", Offset = "0xE518A8", VA = "0xE518A8")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE51940", Offset = "0xE51940", VA = "0xE51940")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xE519D8", Offset = "0xE519D8", VA = "0xE519D8")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xE51A88", Offset = "0xE51A88", VA = "0xE51A88")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xE51B20", Offset = "0xE51B20", VA = "0xE51B20")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xE51BB8", Offset = "0xE51BB8", VA = "0xE51BB8")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xE51C58", Offset = "0xE51C58", VA = "0xE51C58")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xE51CE0", Offset = "0xE51CE0", VA = "0xE51CE0")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xE51D80", Offset = "0xE51D80", VA = "0xE51D80")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xE51E20", Offset = "0xE51E20", VA = "0xE51E20")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xE51EC0", Offset = "0xE51EC0", VA = "0xE51EC0")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xE51F58", Offset = "0xE51F58", VA = "0xE51F58")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xE52070", Offset = "0xE52070", VA = "0xE52070")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xE520B8", Offset = "0xE520B8", VA = "0xE520B8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xE520F8", Offset = "0xE520F8", VA = "0xE520F8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
}
namespace FMODUnity
{
	[Token(Token = "0x20000E4")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xE48A90", Offset = "0xE48A90", VA = "0xE48A90")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xE61AEC", Offset = "0xE61AEC", VA = "0xE61AEC")]
		public EventRefAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000E6")]
	public class ParamRef
	{
		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xE652F0", Offset = "0xE652F0", VA = "0xE652F0")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3133C", Offset = "0xB3133C")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		private struct LoadedBank
		{
			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x2000107")]
		private class GuidComparer : IEqualityComparer<Guid>
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xE7CEEC", Offset = "0xE7CEEC", VA = "0xE7CEEC", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0xE7CF20", Offset = "0xE7CF20", VA = "0xE7CF20", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0xE6D290", Offset = "0xE6D290", VA = "0xE6D290")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x2000108")]
		private class AttachedInstance
		{
			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x6000696")]
			[Address(RVA = "0xE69694", Offset = "0xE69694", VA = "0xE69694")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314AC", Offset = "0xB314AC")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000697")]
			[Address(RVA = "0xE6968C", Offset = "0xE6968C", VA = "0xE6968C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0xE7CB48", Offset = "0xE7CB48", VA = "0xE7CB48")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314BC", Offset = "0xB314BC")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x6000699")]
			[Address(RVA = "0xE698A8", Offset = "0xE698A8", VA = "0xE698A8")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0xE7CB6C", Offset = "0xE7CB6C", VA = "0xE7CB6C")]
			internal bool <AttachInstanceToGameObject>b__0(AttachedInstance x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314CC", Offset = "0xB314CC")]
		private sealed class <loadFromWeb>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700000E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600069E")]
				[Address(RVA = "0xE7CE9C", Offset = "0xE7CE9C", VA = "0xE7CE9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A0")]
				[Address(RVA = "0xE7CEE4", Offset = "0xE7CEE4", VA = "0xE7CEE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0xE6A394", Offset = "0xE6A394", VA = "0xE6A394")]
			[DebuggerHidden]
			public <loadFromWeb>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xE7CB90", Offset = "0xE7CB90", VA = "0xE7CB90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0xE7CB94", Offset = "0xE7CB94", VA = "0xE7CB94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xE7CEA4", Offset = "0xE7CEA4", VA = "0xE7CEA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SystemNotInitializedException initException;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static RuntimeManager instance;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FMODPlatform fmodPlatform;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMOD.System coreSystem;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSP mixerHead;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long[] cachedPointers;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, uint> loadedPlugins;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Guid, EventDescription> cachedDescriptions;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool listenerWarningIssued;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect windowRect;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastDebugText;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastDebugUpdate;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<StudioListener> Listeners;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int numListeners;

		[Token(Token = "0x17000003")]
		public static RuntimeManager Instance
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0xE65D2C", Offset = "0xE65D2C", VA = "0xE65D2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0xE67198", Offset = "0xE67198", VA = "0xE67198")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x17000005")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0xE67200", Offset = "0xE67200", VA = "0xE67200")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x17000006")]
		public static bool IsInitialized
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0xE6CCDC", Offset = "0xE6CCDC", VA = "0xE6CCDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0xE6CB88", Offset = "0xE6CB88", VA = "0xE6CB88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xE65A04", Offset = "0xE65A04", VA = "0xE65A04")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xB3177C", Offset = "0xB3177C")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xE67268", Offset = "0xE67268", VA = "0xE67268")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xE669F8", Offset = "0xE669F8", VA = "0xE669F8")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xE685FC", Offset = "0xE685FC", VA = "0xE685FC")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xE68A3C", Offset = "0xE68A3C", VA = "0xE68A3C")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xE68D54", Offset = "0xE68D54", VA = "0xE68D54")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xE69490", Offset = "0xE69490", VA = "0xE69490")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xE6969C", Offset = "0xE6969C", VA = "0xE6969C")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xE698B0", Offset = "0xE698B0", VA = "0xE698B0")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE63358", Offset = "0xE63358", VA = "0xE63358")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xE699CC", Offset = "0xE699CC", VA = "0xE699CC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xE69A40", Offset = "0xE69A40", VA = "0xE69A40")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xE69EE0", Offset = "0xE69EE0", VA = "0xE69EE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xE69F50", Offset = "0xE69F50", VA = "0xE69F50")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xE6A00C", Offset = "0xE6A00C", VA = "0xE6A00C")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xE6A184", Offset = "0xE6A184", VA = "0xE6A184")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xE6A2D8", Offset = "0xE6A2D8", VA = "0xE6A2D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB317DC", Offset = "0xB317DC")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xE6A3C0", Offset = "0xE6A3C0", VA = "0xE6A3C0")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xE6ABA0", Offset = "0xE6ABA0", VA = "0xE6ABA0")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xE680D4", Offset = "0xE680D4", VA = "0xE680D4")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xE6AE60", Offset = "0xE6AE60", VA = "0xE6AE60")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xE6AFB4", Offset = "0xE6AFB4", VA = "0xE6AFB4")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xE6ADF8", Offset = "0xE6ADF8", VA = "0xE6ADF8")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xE6B134", Offset = "0xE6B134", VA = "0xE6B134")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xE6B588", Offset = "0xE6B588", VA = "0xE6B588")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xE6B698", Offset = "0xE6B698", VA = "0xE6B698")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xE6B938", Offset = "0xE6B938", VA = "0xE6B938")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xE6BAAC", Offset = "0xE6BAAC", VA = "0xE6BAAC")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xE6BBF0", Offset = "0xE6BBF0", VA = "0xE6BBF0")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xE6BD48", Offset = "0xE6BD48", VA = "0xE6BD48")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xE6BE18", Offset = "0xE6BE18", VA = "0xE6BE18")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xE6B71C", Offset = "0xE6B71C", VA = "0xE6B71C")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xE6BF54", Offset = "0xE6BF54", VA = "0xE6BF54")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xE6C128", Offset = "0xE6C128", VA = "0xE6C128")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xE6C300", Offset = "0xE6C300", VA = "0xE6C300")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xE6C43C", Offset = "0xE6C43C", VA = "0xE6C43C")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xE6C4E0", Offset = "0xE6C4E0", VA = "0xE6C4E0")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xE6C584", Offset = "0xE6C584", VA = "0xE6C584")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xE6C620", Offset = "0xE6C620", VA = "0xE6C620")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xE6C870", Offset = "0xE6C870", VA = "0xE6C870")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xE6A0B0", Offset = "0xE6A0B0", VA = "0xE6A0B0")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xE6CC18", Offset = "0xE6CC18", VA = "0xE6CC18")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xE6CDC4", Offset = "0xE6CDC4", VA = "0xE6CDC4")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xE67EF8", Offset = "0xE67EF8", VA = "0xE67EF8")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xE67B38", Offset = "0xE67B38", VA = "0xE67B38")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xE6D084", Offset = "0xE6D084", VA = "0xE6D084")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Guid Guid;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string Path;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xE61950", Offset = "0xE61950", VA = "0xE61950")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xE61A18", Offset = "0xE61A18", VA = "0xE61A18")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xE49720", Offset = "0xE49720", VA = "0xE49720")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xE6CAC0", Offset = "0xE6CAC0", VA = "0xE6CAC0")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RESULT Result;

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xE48470", Offset = "0xE48470", VA = "0xE48470")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xE489CC", Offset = "0xE489CC", VA = "0xE489CC")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RESULT Result;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xE67074", Offset = "0xE67074", VA = "0xE67074")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xE66FE8", Offset = "0xE66FE8", VA = "0xE66FE8")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x40004AB")]
		None,
		[Token(Token = "0x40004AC")]
		ObjectStart,
		[Token(Token = "0x40004AD")]
		ObjectDestroy,
		[Token(Token = "0x40004AE")]
		TriggerEnter,
		[Token(Token = "0x40004AF")]
		TriggerExit,
		[Token(Token = "0x40004B0")]
		TriggerEnter2D,
		[Token(Token = "0x40004B1")]
		TriggerExit2D,
		[Token(Token = "0x40004B2")]
		CollisionEnter,
		[Token(Token = "0x40004B3")]
		CollisionExit,
		[Token(Token = "0x40004B4")]
		CollisionEnter2D,
		[Token(Token = "0x40004B5")]
		CollisionExit2D,
		[Token(Token = "0x40004B6")]
		ObjectEnable,
		[Token(Token = "0x40004B7")]
		ObjectDisable,
		[Token(Token = "0x40004B8")]
		MouseEnter,
		[Token(Token = "0x40004B9")]
		MouseExit,
		[Token(Token = "0x40004BA")]
		MouseDown,
		[Token(Token = "0x40004BB")]
		MouseUp
	}
	[Token(Token = "0x20000EE")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x40004BD")]
		None,
		[Token(Token = "0x40004BE")]
		ObjectStart,
		[Token(Token = "0x40004BF")]
		ObjectDestroy,
		[Token(Token = "0x40004C0")]
		TriggerEnter,
		[Token(Token = "0x40004C1")]
		TriggerExit,
		[Token(Token = "0x40004C2")]
		TriggerEnter2D,
		[Token(Token = "0x40004C3")]
		TriggerExit2D
	}
	[Token(Token = "0x20000EF")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x40004C4")]
		private const string BankExtension = ".bank";

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xE6D348", Offset = "0xE6D348", VA = "0xE6D348")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xE6D398", Offset = "0xE6D398", VA = "0xE6D398")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xE6BB78", Offset = "0xE6BB78", VA = "0xE6BB78")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xE6C390", Offset = "0xE6C390", VA = "0xE6C390")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xE69244", Offset = "0xE69244", VA = "0xE69244")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xE6BFF4", Offset = "0xE6BFF4", VA = "0xE6BFF4")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xE69364", Offset = "0xE69364", VA = "0xE69364")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xE6C1C8", Offset = "0xE6C1C8", VA = "0xE6C1C8")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xE675DC", Offset = "0xE675DC", VA = "0xE675DC")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xE6A7FC", Offset = "0xE6A7FC", VA = "0xE6A7FC")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xE6CE58", Offset = "0xE6CE58", VA = "0xE6CE58")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xE66810", Offset = "0xE66810", VA = "0xE66810")]
		public static void EnforceLibraryOrder()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xE666C0", Offset = "0xE666C0", VA = "0xE666C0")]
		public static bool VerifyPlatformLibsExist()
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000F0")]
	public enum FMODPlatform
	{
		[Token(Token = "0x40004C6")]
		None,
		[Token(Token = "0x40004C7")]
		PlayInEditor,
		[Token(Token = "0x40004C8")]
		Default,
		[Token(Token = "0x40004C9")]
		Desktop,
		[Token(Token = "0x40004CA")]
		Mobile,
		[Token(Token = "0x40004CB")]
		MobileHigh,
		[Token(Token = "0x40004CC")]
		MobileLow,
		[Token(Token = "0x40004CD")]
		Console,
		[Token(Token = "0x40004CE")]
		Windows,
		[Token(Token = "0x40004CF")]
		Mac,
		[Token(Token = "0x40004D0")]
		Linux,
		[Token(Token = "0x40004D1")]
		iOS,
		[Token(Token = "0x40004D2")]
		Android,
		[Token(Token = "0x40004D3")]
		Deprecated_1,
		[Token(Token = "0x40004D4")]
		XboxOne,
		[Token(Token = "0x40004D5")]
		PS4,
		[Token(Token = "0x40004D6")]
		Deprecated_2,
		[Token(Token = "0x40004D7")]
		Deprecated_3,
		[Token(Token = "0x40004D8")]
		AppleTV,
		[Token(Token = "0x40004D9")]
		UWP,
		[Token(Token = "0x40004DA")]
		Switch,
		[Token(Token = "0x40004DB")]
		WebGL,
		[Token(Token = "0x40004DC")]
		Stadia,
		[Token(Token = "0x40004DD")]
		Count
	}
	[Serializable]
	[Token(Token = "0x20000F1")]
	public enum ImportType
	{
		[Token(Token = "0x40004DF")]
		StreamingAssets,
		[Token(Token = "0x40004E0")]
		AssetBundle
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public enum BankLoadType
	{
		[Token(Token = "0x40004E2")]
		All,
		[Token(Token = "0x40004E3")]
		Specified,
		[Token(Token = "0x40004E4")]
		None
	}
	[Token(Token = "0x20000F3")]
	public class PlatformSettingBase
	{
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FMODPlatform Platform;

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xE65398", Offset = "0xE65398", VA = "0xE65398")]
		public PlatformSettingBase()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x6000639")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x600063A")]
		[Address(RVA = "0xE6534C", Offset = "0xE6534C", VA = "0xE6534C")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F6")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x600063B")]
		[Address(RVA = "0xE653A0", Offset = "0xE653A0", VA = "0xE653A0")]
		public PlatformStringSetting()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public enum TriStateBool
	{
		[Token(Token = "0x40004E8")]
		Disabled,
		[Token(Token = "0x40004E9")]
		Enabled,
		[Token(Token = "0x40004EA")]
		Development
	}
	[Serializable]
	[Token(Token = "0x20000F8")]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
		[Token(Token = "0x600063C")]
		[Address(RVA = "0xE65300", Offset = "0xE65300", VA = "0xE65300")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314DC", Offset = "0xB314DC")]
		private sealed class <>c__DisplayClass37_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x60006A1")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60006A2")]
			internal bool <HasSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314EC", Offset = "0xB314EC")]
		private sealed class <>c__DisplayClass38_0<T, U> where T : PlatformSetting<U>
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x60006A3")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60006A4")]
			internal bool <GetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB314FC", Offset = "0xB314FC")]
		private sealed class <>c__DisplayClass39_0<T, U> where T : PlatformSetting<U>, new()
		{
			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x60006A5")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60006A6")]
			internal bool <SetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3150C", Offset = "0xB3150C")]
		private sealed class <>c__DisplayClass40_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x60006A7")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60006A8")]
			internal bool <RemoveSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool SwitchSettingsMigration;

		[Token(Token = "0x40004EC")]
		private const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string sourceBankPath;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string SourceBankPathUnformatted;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> Plugins;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x17000008")]
		public static Settings Instance
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0xE6737C", Offset = "0xE6737C", VA = "0xE6737C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public string SourceProjectPath
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0xE6E71C", Offset = "0xE6E71C", VA = "0xE6E71C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0xE6E724", Offset = "0xE6E724", VA = "0xE6E724")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public string SourceBankPath
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xE6E72C", Offset = "0xE6E72C", VA = "0xE6E72C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0xE6E734", Offset = "0xE6E734", VA = "0xE6E734")]
			set
			{
			}
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xE6E73C", Offset = "0xE6E73C", VA = "0xE6E73C")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000643")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x6000644")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000645")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x6000646")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xE67BAC", Offset = "0xE67BAC", VA = "0xE67BAC")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xE69A38", Offset = "0xE69A38", VA = "0xE69A38")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xE67988", Offset = "0xE67988", VA = "0xE67988")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xE67A18", Offset = "0xE67A18", VA = "0xE67A18")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xE67AA8", Offset = "0xE67AA8", VA = "0xE67AA8")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xE678F8", Offset = "0xE678F8", VA = "0xE678F8")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xE6E760", Offset = "0xE6E760", VA = "0xE6E760")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xE6E82C", Offset = "0xE6E82C", VA = "0xE6E82C")]
		private Settings()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB31384", Offset = "0xB31384")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xE71E98", Offset = "0xE71E98", VA = "0xE71E98")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xE722CC", Offset = "0xE722CC", VA = "0xE722CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xE722F4", Offset = "0xE722F4", VA = "0xE722F4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xE72300", Offset = "0xE72300", VA = "0xE72300")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xE72314", Offset = "0xE72314", VA = "0xE72314")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xE72374", Offset = "0xE72374", VA = "0xE72374")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xE723D4", Offset = "0xE723D4", VA = "0xE723D4")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xE72434", Offset = "0xE72434", VA = "0xE72434")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xE71EE8", Offset = "0xE71EE8", VA = "0xE71EE8")]
		public void Load()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xE7218C", Offset = "0xE7218C", VA = "0xE7218C")]
		public void Unload()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xE72494", Offset = "0xE72494", VA = "0xE72494")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB313BC", Offset = "0xB313BC")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static StudioEventEmitter staticInstance;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x400051D")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x1700000B")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0xE7249C", Offset = "0xE7249C", VA = "0xE7249C")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x1700000C")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0xE724A4", Offset = "0xE724A4", VA = "0xE724A4")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xE724AC", Offset = "0xE724AC", VA = "0xE724AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xE727DC", Offset = "0xE727DC", VA = "0xE727DC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xE727E8", Offset = "0xE727E8", VA = "0xE727E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xE728E0", Offset = "0xE728E0", VA = "0xE728E0", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xE726C4", Offset = "0xE726C4", VA = "0xE726C4")]
		private void Lookup()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE72930", Offset = "0xE72930", VA = "0xE72930")]
		public void Play()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE72C94", Offset = "0xE72C94", VA = "0xE72C94")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xE72CFC", Offset = "0xE72CFC", VA = "0xE72CFC")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xE72D64", Offset = "0xE72D64", VA = "0xE72D64")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xE72DCC", Offset = "0xE72DCC", VA = "0xE72DCC")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xE72E18", Offset = "0xE72E18", VA = "0xE72E18")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB313F4", Offset = "0xB313F4")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xE73260", Offset = "0xE73260", VA = "0xE73260")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xE73348", Offset = "0xE73348", VA = "0xE73348")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xE733A8", Offset = "0xE733A8", VA = "0xE733A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xE733BC", Offset = "0xE733BC", VA = "0xE733BC")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xE734C0", Offset = "0xE734C0", VA = "0xE734C0")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FD")]
	public class EmitterRef
	{
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xE5E260", Offset = "0xE5E260", VA = "0xE5E260")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB3142C", Offset = "0xB3142C")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE734D0", Offset = "0xE734D0", VA = "0xE734D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xE736C0", Offset = "0xE736C0", VA = "0xE736C0", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xE736D4", Offset = "0xE736D4", VA = "0xE736D4")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xE73854", Offset = "0xE73854", VA = "0xE73854")]
		public StudioParameterTrigger()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xE5FC7C", Offset = "0xE5FC7C", VA = "0xE5FC7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xE5FC8C", Offset = "0xE5FC8C", VA = "0xE5FC8C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xE5FC9C", Offset = "0xE5FC9C", VA = "0xE5FC9C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xE5FD04", Offset = "0xE5FD04", VA = "0xE5FD04")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xE5FD6C", Offset = "0xE5FD6C", VA = "0xE5FD6C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xE5FDD4", Offset = "0xE5FDD4", VA = "0xE5FDD4")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xE5FE3C", Offset = "0xE5FE3C", VA = "0xE5FE3C")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xE5FE4C", Offset = "0xE5FE4C", VA = "0xE5FE4C")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xE5FE5C", Offset = "0xE5FE5C", VA = "0xE5FE5C")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xE5FE6C", Offset = "0xE5FE6C", VA = "0xE5FE6C")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xE5FE7C", Offset = "0xE5FE7C", VA = "0xE5FE7C")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xE5FE8C", Offset = "0xE5FE8C", VA = "0xE5FE8C")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xE5FE9C", Offset = "0xE5FE9C", VA = "0xE5FE9C")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xE5FEAC", Offset = "0xE5FEAC", VA = "0xE5FEAC")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x6000680")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xE5FEBC", Offset = "0xE5FEBC", VA = "0xE5FEBC")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xE632D0", Offset = "0xE632D0", VA = "0xE632D0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xE63480", Offset = "0xE63480", VA = "0xE63480")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000684")]
		[Address(RVA = "0xE652F8", Offset = "0xE652F8", VA = "0xE652F8")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB31464", Offset = "0xB31464")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x1700000D")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0xE72EB0", Offset = "0xE72EB0", VA = "0xE72EB0")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xE72EC4", Offset = "0xE72EC4", VA = "0xE72EC4")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xE730D8", Offset = "0xE730D8", VA = "0xE730D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xE73118", Offset = "0xE73118", VA = "0xE73118", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xE7312C", Offset = "0xE7312C", VA = "0xE7312C")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xE7325C", Offset = "0xE7325C", VA = "0xE7325C")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
}
