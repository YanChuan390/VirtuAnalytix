using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: AssemblyVersion("0.0.0.0")]
[module: UnverifiableCode]
namespace FMOD
{
	public class VERSION
	{
		public const int number = 67841;

		public const string dll = "fmod";
	}
	public class CONSTANTS
	{
		public const int MAX_CHANNEL_WIDTH = 32;

		public const int MAX_LISTENERS = 8;

		public const int REVERB_MAXINSTANCES = 4;
	}
	public enum RESULT
	{
		OK,
		ERR_BADCOMMAND,
		ERR_CHANNEL_ALLOC,
		ERR_CHANNEL_STOLEN,
		ERR_DMA,
		ERR_DSP_CONNECTION,
		ERR_DSP_DONTPROCESS,
		ERR_DSP_FORMAT,
		ERR_DSP_INUSE,
		ERR_DSP_NOTFOUND,
		ERR_DSP_RESERVED,
		ERR_DSP_SILENCE,
		ERR_DSP_TYPE,
		ERR_FILE_BAD,
		ERR_FILE_COULDNOTSEEK,
		ERR_FILE_DISKEJECTED,
		ERR_FILE_EOF,
		ERR_FILE_ENDOFDATA,
		ERR_FILE_NOTFOUND,
		ERR_FORMAT,
		ERR_HEADER_MISMATCH,
		ERR_HTTP,
		ERR_HTTP_ACCESS,
		ERR_HTTP_PROXY_AUTH,
		ERR_HTTP_SERVER_ERROR,
		ERR_HTTP_TIMEOUT,
		ERR_INITIALIZATION,
		ERR_INITIALIZED,
		ERR_INTERNAL,
		ERR_INVALID_FLOAT,
		ERR_INVALID_HANDLE,
		ERR_INVALID_PARAM,
		ERR_INVALID_POSITION,
		ERR_INVALID_SPEAKER,
		ERR_INVALID_SYNCPOINT,
		ERR_INVALID_THREAD,
		ERR_INVALID_VECTOR,
		ERR_MAXAUDIBLE,
		ERR_MEMORY,
		ERR_MEMORY_CANTPOINT,
		ERR_NEEDS3D,
		ERR_NEEDSHARDWARE,
		ERR_NET_CONNECT,
		ERR_NET_SOCKET_ERROR,
		ERR_NET_URL,
		ERR_NET_WOULD_BLOCK,
		ERR_NOTREADY,
		ERR_OUTPUT_ALLOCATED,
		ERR_OUTPUT_CREATEBUFFER,
		ERR_OUTPUT_DRIVERCALL,
		ERR_OUTPUT_FORMAT,
		ERR_OUTPUT_INIT,
		ERR_OUTPUT_NODRIVERS,
		ERR_PLUGIN,
		ERR_PLUGIN_MISSING,
		ERR_PLUGIN_RESOURCE,
		ERR_PLUGIN_VERSION,
		ERR_RECORD,
		ERR_REVERB_CHANNELGROUP,
		ERR_REVERB_INSTANCE,
		ERR_SUBSOUNDS,
		ERR_SUBSOUND_ALLOCATED,
		ERR_SUBSOUND_CANTMOVE,
		ERR_TAGNOTFOUND,
		ERR_TOOMANYCHANNELS,
		ERR_TRUNCATED,
		ERR_UNIMPLEMENTED,
		ERR_UNINITIALIZED,
		ERR_UNSUPPORTED,
		ERR_VERSION,
		ERR_EVENT_ALREADY_LOADED,
		ERR_EVENT_LIVEUPDATE_BUSY,
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		ERR_EVENT_NOTFOUND,
		ERR_STUDIO_UNINITIALIZED,
		ERR_STUDIO_NOT_LOADED,
		ERR_INVALID_STRING,
		ERR_ALREADY_LOCKED,
		ERR_NOT_LOCKED,
		ERR_RECORD_DISCONNECTED,
		ERR_TOOMANYSAMPLES
	}
	public enum CHANNELCONTROL_TYPE
	{
		CHANNEL,
		CHANNELGROUP
	}
	public struct VECTOR
	{
		public float x;

		public float y;

		public float z;
	}
	public struct ATTRIBUTES_3D
	{
		public VECTOR position;

		public VECTOR velocity;

		public VECTOR forward;

		public VECTOR up;
	}
	public struct ASYNCREADINFO
	{
		public IntPtr handle;

		public uint offset;

		public uint sizebytes;

		public int priority;

		public IntPtr userdata;

		public IntPtr buffer;

		public uint bytesread;

		public ASYNCREADINFO_DONE_CALLBACK done;
	}
	public enum OUTPUTTYPE
	{
		AUTODETECT,
		UNKNOWN,
		NOSOUND,
		WAVWRITER,
		NOSOUND_NRT,
		WAVWRITER_NRT,
		DSOUND,
		WINMM,
		WASAPI,
		ASIO,
		PULSEAUDIO,
		ALSA,
		COREAUDIO,
		XAUDIO,
		PS3,
		AUDIOTRACK,
		OPENSL,
		WIIU,
		AUDIOOUT,
		AUDIO3D,
		ATMOS,
		WEBAUDIO,
		NNAUDIO,
		MAX
	}
	public enum DEBUG_MODE
	{
		TTY,
		FILE,
		CALLBACK
	}
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		NONE = 0u,
		ERROR = 1u,
		WARNING = 2u,
		LOG = 4u,
		TYPE_MEMORY = 0x100u,
		TYPE_FILE = 0x200u,
		TYPE_CODEC = 0x400u,
		TYPE_TRACE = 0x800u,
		DISPLAY_TIMESTAMPS = 0x10000u,
		DISPLAY_LINENUMBERS = 0x20000u,
		DISPLAY_THREAD = 0x40000u
	}
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		NORMAL = 0u,
		STREAM_FILE = 1u,
		STREAM_DECODE = 2u,
		SAMPLEDATA = 4u,
		DSP_BUFFER = 8u,
		PLUGIN = 0x10u,
		XBOX360_PHYSICAL = 0x100000u,
		PERSISTENT = 0x200000u,
		SECONDARY = 0x400000u,
		ALL = uint.MaxValue
	}
	public enum SPEAKERMODE
	{
		DEFAULT,
		RAW,
		MONO,
		STEREO,
		QUAD,
		SURROUND,
		_5POINT1,
		_7POINT1,
		MAX
	}
	public enum SPEAKER
	{
		FRONT_LEFT,
		FRONT_RIGHT,
		FRONT_CENTER,
		LOW_FREQUENCY,
		SURROUND_LEFT,
		SURROUND_RIGHT,
		BACK_LEFT,
		BACK_RIGHT,
		MAX
	}
	[Flags]
	public enum CHANNELMASK : uint
	{
		FRONT_LEFT = 1u,
		FRONT_RIGHT = 2u,
		FRONT_CENTER = 4u,
		LOW_FREQUENCY = 8u,
		SURROUND_LEFT = 0x10u,
		SURROUND_RIGHT = 0x20u,
		BACK_LEFT = 0x40u,
		BACK_RIGHT = 0x80u,
		BACK_CENTER = 0x100u,
		MONO = 1u,
		STEREO = 3u,
		LRC = 7u,
		QUAD = 0x33u,
		SURROUND = 0x37u,
		_5POINT1 = 0x3Fu,
		_5POINT1_REARS = 0xCFu,
		_7POINT0 = 0xF7u,
		_7POINT1 = 0xFFu
	}
	public enum CHANNELORDER
	{
		DEFAULT,
		WAVEFORMAT,
		PROTOOLS,
		ALLMONO,
		ALLSTEREO,
		ALSA,
		MAX
	}
	public enum PLUGINTYPE
	{
		OUTPUT,
		CODEC,
		DSP,
		MAX
	}
	public struct PLUGINLIST
	{
		private PLUGINTYPE type;

		private IntPtr description;
	}
	[Flags]
	public enum INITFLAGS : uint
	{
		NORMAL = 0u,
		STREAM_FROM_UPDATE = 1u,
		MIX_FROM_UPDATE = 2u,
		_3D_RIGHTHANDED = 4u,
		CHANNEL_LOWPASS = 0x100u,
		CHANNEL_DISTANCEFILTER = 0x200u,
		PROFILE_ENABLE = 0x10000u,
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		GEOMETRY_USECLOSEST = 0x40000u,
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		THREAD_UNSAFE = 0x100000u,
		PROFILE_METER_ALL = 0x200000u
	}
	public enum SOUND_TYPE
	{
		UNKNOWN,
		AIFF,
		ASF,
		DLS,
		FLAC,
		FSB,
		IT,
		MIDI,
		MOD,
		MPEG,
		OGGVORBIS,
		PLAYLIST,
		RAW,
		S3M,
		USER,
		WAV,
		XM,
		XMA,
		AUDIOQUEUE,
		AT9,
		VORBIS,
		MEDIA_FOUNDATION,
		MEDIACODEC,
		FADPCM,
		MAX
	}
	public enum SOUND_FORMAT
	{
		NONE,
		PCM8,
		PCM16,
		PCM24,
		PCM32,
		PCMFLOAT,
		BITSTREAM,
		MAX
	}
	[Flags]
	public enum MODE : uint
	{
		DEFAULT = 0u,
		LOOP_OFF = 1u,
		LOOP_NORMAL = 2u,
		LOOP_BIDI = 4u,
		_2D = 8u,
		_3D = 0x10u,
		CREATESTREAM = 0x80u,
		CREATESAMPLE = 0x100u,
		CREATECOMPRESSEDSAMPLE = 0x200u,
		OPENUSER = 0x400u,
		OPENMEMORY = 0x800u,
		OPENMEMORY_POINT = 0x10000000u,
		OPENRAW = 0x1000u,
		OPENONLY = 0x2000u,
		ACCURATETIME = 0x4000u,
		MPEGSEARCH = 0x8000u,
		NONBLOCKING = 0x10000u,
		UNIQUE = 0x20000u,
		_3D_HEADRELATIVE = 0x40000u,
		_3D_WORLDRELATIVE = 0x80000u,
		_3D_INVERSEROLLOFF = 0x100000u,
		_3D_LINEARROLLOFF = 0x200000u,
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		_3D_CUSTOMROLLOFF = 0x4000000u,
		_3D_IGNOREGEOMETRY = 0x40000000u,
		IGNORETAGS = 0x2000000u,
		LOWMEM = 0x8000000u,
		LOADSECONDARYRAM = 0x20000000u,
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	public enum OPENSTATE
	{
		READY,
		LOADING,
		ERROR,
		CONNECTING,
		BUFFERING,
		SEEKING,
		PLAYING,
		SETPOSITION,
		MAX
	}
	public enum SOUNDGROUP_BEHAVIOR
	{
		BEHAVIOR_FAIL,
		BEHAVIOR_MUTE,
		BEHAVIOR_STEALLOWEST,
		MAX
	}
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		END,
		VIRTUALVOICE,
		SYNCPOINT,
		OCCLUSION,
		MAX
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		public const int HEAD = -1;

		public const int FADER = -2;

		public const int TAIL = -3;
	}
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		NONE,
		SYSTEM,
		CHANNEL,
		CHANNELGROUP,
		CHANNELCONTROL,
		SOUND,
		SOUNDGROUP,
		DSP,
		DSPCONNECTION,
		GEOMETRY,
		REVERB3D,
		STUDIO_SYSTEM,
		STUDIO_EVENTDESCRIPTION,
		STUDIO_EVENTINSTANCE,
		STUDIO_PARAMETERINSTANCE,
		STUDIO_BUS,
		STUDIO_VCA,
		STUDIO_BANK,
		STUDIO_COMMANDREPLAY
	}
	public struct ERRORCALLBACK_INFO
	{
		public RESULT result;

		public ERRORCALLBACK_INSTANCETYPE instancetype;

		public IntPtr instance;

		private IntPtr functionname_internal;

		private IntPtr functionparams_internal;

		public string functionname => Marshal.PtrToStringAnsi(functionname_internal);

		public string functionparams => Marshal.PtrToStringAnsi(functionparams_internal);
	}
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		DEVICELISTCHANGED = 1u,
		DEVICELOST = 2u,
		MEMORYALLOCATIONFAILED = 4u,
		THREADCREATED = 8u,
		BADDSPCONNECTION = 0x10u,
		PREMIX = 0x20u,
		POSTMIX = 0x40u,
		ERROR = 0x80u,
		MIDMIX = 0x100u,
		THREADDESTROYED = 0x200u,
		PREUPDATE = 0x400u,
		POSTUPDATE = 0x800u,
		RECORDLISTCHANGED = 0x1000u,
		ALL = uint.MaxValue
	}
	public struct StringWrapper
	{
		private IntPtr nativeUtf8Ptr;

		public static implicit operator string(StringWrapper fstring)
		{
			if (fstring.nativeUtf8Ptr == IntPtr.Zero)
			{
				return string.Empty;
			}
			int i;
			for (i = 0; Marshal.ReadByte(fstring.nativeUtf8Ptr, i) != 0; i++)
			{
			}
			if (i > 0)
			{
				byte[] array = new byte[i];
				Marshal.Copy(fstring.nativeUtf8Ptr, array, 0, i);
				return Encoding.UTF8.GetString(array, 0, i);
			}
			return string.Empty;
		}
	}
	public delegate RESULT ASYNCREADINFO_DONE_CALLBACK(IntPtr info, RESULT result);
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, string file, int line, string func, string message);
	public delegate RESULT SYSTEM_CALLBACK(IntPtr systemraw, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	public delegate RESULT CHANNEL_CALLBACK(IntPtr channelraw, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2);
	public delegate RESULT SOUND_NONBLOCKCALLBACK(IntPtr soundraw, RESULT result);
	public delegate RESULT SOUND_PCMREADCALLBACK(IntPtr soundraw, IntPtr data, uint datalen);
	public delegate RESULT SOUND_PCMSETPOSCALLBACK(IntPtr soundraw, int subsound, uint position, TIMEUNIT postype);
	public delegate RESULT FILE_OPENCALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	public delegate RESULT FILE_CLOSECALLBACK(IntPtr handle, IntPtr userdata);
	public delegate RESULT FILE_READCALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	public delegate RESULT FILE_SEEKCALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	public delegate RESULT FILE_ASYNCREADCALLBACK(IntPtr handle, IntPtr info, IntPtr userdata);
	public delegate RESULT FILE_ASYNCCANCELCALLBACK(IntPtr handle, IntPtr userdata);
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate float CB_3D_ROLLOFFCALLBACK(IntPtr channelraw, float distance);
	public enum DSP_RESAMPLER
	{
		DEFAULT,
		NOINTERP,
		LINEAR,
		CUBIC,
		SPLINE,
		MAX
	}
	public enum DSPCONNECTION_TYPE
	{
		STANDARD,
		SIDECHAIN,
		SEND,
		SEND_SIDECHAIN,
		MAX
	}
	public enum TAGTYPE
	{
		UNKNOWN,
		ID3V1,
		ID3V2,
		VORBISCOMMENT,
		SHOUTCAST,
		ICECAST,
		ASF,
		MIDI,
		PLAYLIST,
		FMOD,
		USER,
		MAX
	}
	public enum TAGDATATYPE
	{
		BINARY,
		INT,
		FLOAT,
		STRING,
		STRING_UTF16,
		STRING_UTF16BE,
		STRING_UTF8,
		CDTOC,
		MAX
	}
	public struct TAG
	{
		public TAGTYPE type;

		public TAGDATATYPE datatype;

		private IntPtr name_internal;

		public IntPtr data;

		public uint datalen;

		public bool updated;

		public string name => Marshal.PtrToStringAnsi(name_internal);
	}
	[Flags]
	public enum TIMEUNIT : uint
	{
		MS = 1u,
		PCM = 2u,
		PCMBYTES = 4u,
		RAWBYTES = 8u,
		PCMFRACTION = 0x10u,
		MODORDER = 0x100u,
		MODROW = 0x200u,
		MODPATTERN = 0x400u,
		BUFFERED = 0x10000000u
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct PORT_INDEX
	{
		public const ulong NONE = ulong.MaxValue;
	}
	public struct CREATESOUNDEXINFO
	{
		public int cbsize;

		public uint length;

		public uint fileoffset;

		public int numchannels;

		public int defaultfrequency;

		public SOUND_FORMAT format;

		public uint decodebuffersize;

		public int initialsubsound;

		public int numsubsounds;

		public IntPtr inclusionlist;

		public int inclusionlistnum;

		public SOUND_PCMREADCALLBACK pcmreadcallback;

		public SOUND_PCMSETPOSCALLBACK pcmsetposcallback;

		public SOUND_NONBLOCKCALLBACK nonblockcallback;

		public IntPtr dlsname;

		public IntPtr encryptionkey;

		public int maxpolyphony;

		public IntPtr userdata;

		public SOUND_TYPE suggestedsoundtype;

		public FILE_OPENCALLBACK fileuseropen;

		public FILE_CLOSECALLBACK fileuserclose;

		public FILE_READCALLBACK fileuserread;

		public FILE_SEEKCALLBACK fileuserseek;

		public FILE_ASYNCREADCALLBACK fileuserasyncread;

		public FILE_ASYNCCANCELCALLBACK fileuserasynccancel;

		public IntPtr fileuserdata;

		public int filebuffersize;

		public CHANNELORDER channelorder;

		public CHANNELMASK channelmask;

		public IntPtr initialsoundgroup;

		public uint initialseekposition;

		public TIMEUNIT initialseekpostype;

		public int ignoresetfilesystem;

		public uint audioqueuepolicy;

		public uint minmidigranularity;

		public int nonblockthreadid;

		public IntPtr fsbguid;
	}
	public struct CREATESOUNDEXINFO_INTERNAL
	{
		public int cbsize;

		public uint length;

		public uint fileoffset;

		public int numchannels;

		public int defaultfrequency;

		public SOUND_FORMAT format;

		public uint decodebuffersize;

		public int initialsubsound;

		public int numsubsounds;

		public IntPtr inclusionlist;

		public int inclusionlistnum;

		public IntPtr pcmreadcallback;

		public IntPtr pcmsetposcallback;

		public IntPtr nonblockcallback;

		public IntPtr dlsname;

		public IntPtr encryptionkey;

		public int maxpolyphony;

		public IntPtr userdata;

		public SOUND_TYPE suggestedsoundtype;

		public IntPtr fileuseropen;

		public IntPtr fileuserclose;

		public IntPtr fileuserread;

		public IntPtr fileuserseek;

		public IntPtr fileuserasyncread;

		public IntPtr fileuserasynccancel;

		public IntPtr fileuserdata;

		public int filebuffersize;

		public CHANNELORDER channelorder;

		public CHANNELMASK channelmask;

		public IntPtr initialsoundgroup;

		public uint initialseekposition;

		public TIMEUNIT initialseekpostype;

		public int ignoresetfilesystem;

		public uint audioqueuepolicy;

		public uint minmidigranularity;

		public int nonblockthreadid;

		public IntPtr fsbguid;

		public static CREATESOUNDEXINFO_INTERNAL CreateFromExternal(ref CREATESOUNDEXINFO exinfoExt)
		{
			CREATESOUNDEXINFO_INTERNAL result = default(CREATESOUNDEXINFO_INTERNAL);
			result.cbsize = Marshal.SizeOf(typeof(CREATESOUNDEXINFO_INTERNAL));
			result.length = exinfoExt.length;
			result.fileoffset = exinfoExt.fileoffset;
			result.numchannels = exinfoExt.numchannels;
			result.defaultfrequency = exinfoExt.defaultfrequency;
			result.format = exinfoExt.format;
			result.decodebuffersize = exinfoExt.decodebuffersize;
			result.initialsubsound = exinfoExt.initialsubsound;
			result.numsubsounds = exinfoExt.numsubsounds;
			result.inclusionlist = exinfoExt.inclusionlist;
			result.inclusionlistnum = exinfoExt.inclusionlistnum;
			result.pcmreadcallback = ((exinfoExt.pcmreadcallback == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.pcmreadcallback));
			result.pcmsetposcallback = ((exinfoExt.pcmsetposcallback == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.pcmsetposcallback));
			result.nonblockcallback = ((exinfoExt.nonblockcallback == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.nonblockcallback));
			result.dlsname = exinfoExt.dlsname;
			result.encryptionkey = exinfoExt.encryptionkey;
			result.maxpolyphony = exinfoExt.maxpolyphony;
			result.userdata = exinfoExt.userdata;
			result.suggestedsoundtype = exinfoExt.suggestedsoundtype;
			result.fileuseropen = ((exinfoExt.fileuseropen == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.fileuseropen));
			result.fileuserclose = ((exinfoExt.fileuserclose == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.fileuserclose));
			result.fileuserread = ((exinfoExt.fileuserread == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.fileuserread));
			result.fileuserseek = ((exinfoExt.fileuserseek == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.fileuserseek));
			result.fileuserasyncread = ((exinfoExt.fileuserasyncread == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.fileuserasyncread));
			result.fileuserasynccancel = ((exinfoExt.fileuserasynccancel == null) ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(exinfoExt.fileuserasynccancel));
			result.fileuserdata = exinfoExt.fileuserdata;
			result.filebuffersize = exinfoExt.filebuffersize;
			result.channelorder = exinfoExt.channelorder;
			result.channelmask = exinfoExt.channelmask;
			result.initialsoundgroup = exinfoExt.initialsoundgroup;
			result.initialseekposition = exinfoExt.initialseekposition;
			result.initialseekpostype = exinfoExt.initialseekpostype;
			result.ignoresetfilesystem = exinfoExt.ignoresetfilesystem;
			result.audioqueuepolicy = exinfoExt.audioqueuepolicy;
			result.minmidigranularity = exinfoExt.minmidigranularity;
			result.nonblockthreadid = exinfoExt.nonblockthreadid;
			result.fsbguid = exinfoExt.fsbguid;
			return result;
		}

		public static CREATESOUNDEXINFO CreateFromInternal(ref CREATESOUNDEXINFO_INTERNAL exinfoInt)
		{
			CREATESOUNDEXINFO result = default(CREATESOUNDEXINFO);
			result.cbsize = Marshal.SizeOf(typeof(CREATESOUNDEXINFO_INTERNAL));
			result.length = exinfoInt.length;
			result.fileoffset = exinfoInt.fileoffset;
			result.numchannels = exinfoInt.numchannels;
			result.defaultfrequency = exinfoInt.defaultfrequency;
			result.format = exinfoInt.format;
			result.decodebuffersize = exinfoInt.decodebuffersize;
			result.initialsubsound = exinfoInt.initialsubsound;
			result.numsubsounds = exinfoInt.numsubsounds;
			result.inclusionlist = exinfoInt.inclusionlist;
			result.inclusionlistnum = exinfoInt.inclusionlistnum;
			result.pcmreadcallback = ((!(exinfoInt.pcmreadcallback != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.pcmreadcallback, typeof(SOUND_PCMREADCALLBACK)) as SOUND_PCMREADCALLBACK));
			result.pcmsetposcallback = ((!(exinfoInt.pcmsetposcallback != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.pcmsetposcallback, typeof(SOUND_PCMSETPOSCALLBACK)) as SOUND_PCMSETPOSCALLBACK));
			result.nonblockcallback = ((!(exinfoInt.nonblockcallback != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.nonblockcallback, typeof(SOUND_NONBLOCKCALLBACK)) as SOUND_NONBLOCKCALLBACK));
			result.dlsname = exinfoInt.dlsname;
			result.encryptionkey = exinfoInt.encryptionkey;
			result.maxpolyphony = exinfoInt.maxpolyphony;
			result.userdata = exinfoInt.userdata;
			result.suggestedsoundtype = exinfoInt.suggestedsoundtype;
			result.fileuseropen = ((!(exinfoInt.fileuseropen != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.fileuseropen, typeof(FILE_OPENCALLBACK)) as FILE_OPENCALLBACK));
			result.fileuserclose = ((!(exinfoInt.fileuserclose != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.fileuserclose, typeof(FILE_CLOSECALLBACK)) as FILE_CLOSECALLBACK));
			result.fileuserread = ((!(exinfoInt.fileuserread != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.fileuserread, typeof(FILE_READCALLBACK)) as FILE_READCALLBACK));
			result.fileuserseek = ((!(exinfoInt.fileuserseek != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.fileuserseek, typeof(FILE_SEEKCALLBACK)) as FILE_SEEKCALLBACK));
			result.fileuserasyncread = ((!(exinfoInt.fileuserasyncread != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.fileuserasyncread, typeof(FILE_ASYNCREADCALLBACK)) as FILE_ASYNCREADCALLBACK));
			result.fileuserasynccancel = ((!(exinfoInt.fileuserasynccancel != IntPtr.Zero)) ? null : (Marshal.GetDelegateForFunctionPointer(exinfoInt.fileuserasynccancel, typeof(FILE_ASYNCCANCELCALLBACK)) as FILE_ASYNCCANCELCALLBACK));
			result.fileuserdata = exinfoInt.fileuserdata;
			result.filebuffersize = exinfoInt.filebuffersize;
			result.channelorder = exinfoInt.channelorder;
			result.channelmask = exinfoInt.channelmask;
			result.initialsoundgroup = exinfoInt.initialsoundgroup;
			result.initialseekposition = exinfoInt.initialseekposition;
			result.initialseekpostype = exinfoInt.initialseekpostype;
			result.ignoresetfilesystem = exinfoInt.ignoresetfilesystem;
			result.audioqueuepolicy = exinfoInt.audioqueuepolicy;
			result.minmidigranularity = exinfoInt.minmidigranularity;
			result.nonblockthreadid = exinfoInt.nonblockthreadid;
			result.fsbguid = exinfoInt.fsbguid;
			return result;
		}
	}
	public struct REVERB_PROPERTIES
	{
		public float DecayTime;

		public float EarlyDelay;

		public float LateDelay;

		public float HFReference;

		public float HFDecayRatio;

		public float Diffusion;

		public float Density;

		public float LowShelfFrequency;

		public float LowShelfGain;

		public float HighCut;

		public float EarlyLateMix;

		public float WetLevel;

		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
			DecayTime = decayTime;
			EarlyDelay = earlyDelay;
			LateDelay = lateDelay;
			HFReference = hfReference;
			HFDecayRatio = hfDecayRatio;
			Diffusion = diffusion;
			Density = density;
			LowShelfFrequency = lowShelfFrequency;
			LowShelfGain = lowShelfGain;
			HighCut = highCut;
			EarlyLateMix = earlyLateMix;
			WetLevel = wetLevel;
		}
	}
	public class PRESET
	{
		public static REVERB_PROPERTIES OFF()
		{
			return new REVERB_PROPERTIES(1000f, 7f, 11f, 5000f, 100f, 100f, 100f, 250f, 0f, 20f, 96f, -80f);
		}

		public static REVERB_PROPERTIES GENERIC()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 83f, 100f, 100f, 250f, 0f, 14500f, 96f, -8f);
		}

		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return new REVERB_PROPERTIES(170f, 1f, 2f, 5000f, 10f, 100f, 100f, 250f, 0f, 160f, 84f, -7.8f);
		}

		public static REVERB_PROPERTIES ROOM()
		{
			return new REVERB_PROPERTIES(400f, 2f, 3f, 5000f, 83f, 100f, 100f, 250f, 0f, 6050f, 88f, -9.4f);
		}

		public static REVERB_PROPERTIES BATHROOM()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 54f, 100f, 60f, 250f, 0f, 2900f, 83f, 0.5f);
		}

		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return new REVERB_PROPERTIES(500f, 3f, 4f, 5000f, 10f, 100f, 100f, 250f, 0f, 160f, 58f, -19f);
		}

		public static REVERB_PROPERTIES STONEROOM()
		{
			return new REVERB_PROPERTIES(2300f, 12f, 17f, 5000f, 64f, 100f, 100f, 250f, 0f, 7800f, 71f, -8.5f);
		}

		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return new REVERB_PROPERTIES(4300f, 20f, 30f, 5000f, 59f, 100f, 100f, 250f, 0f, 5850f, 64f, -11.7f);
		}

		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return new REVERB_PROPERTIES(3900f, 20f, 29f, 5000f, 70f, 100f, 100f, 250f, 0f, 5650f, 80f, -9.8f);
		}

		public static REVERB_PROPERTIES CAVE()
		{
			return new REVERB_PROPERTIES(2900f, 15f, 22f, 5000f, 100f, 100f, 100f, 250f, 0f, 20000f, 59f, -11.3f);
		}

		public static REVERB_PROPERTIES ARENA()
		{
			return new REVERB_PROPERTIES(7200f, 20f, 30f, 5000f, 33f, 100f, 100f, 250f, 0f, 4500f, 80f, -9.6f);
		}

		public static REVERB_PROPERTIES HANGAR()
		{
			return new REVERB_PROPERTIES(10000f, 20f, 30f, 5000f, 23f, 100f, 100f, 250f, 0f, 3400f, 72f, -7.4f);
		}

		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return new REVERB_PROPERTIES(300f, 2f, 30f, 5000f, 10f, 100f, 100f, 250f, 0f, 500f, 56f, -24f);
		}

		public static REVERB_PROPERTIES HALLWAY()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 59f, 100f, 100f, 250f, 0f, 7800f, 87f, -5.5f);
		}

		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return new REVERB_PROPERTIES(270f, 13f, 20f, 5000f, 79f, 100f, 100f, 250f, 0f, 9000f, 86f, -6f);
		}

		public static REVERB_PROPERTIES ALLEY()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 86f, 100f, 100f, 250f, 0f, 8300f, 80f, -9.8f);
		}

		public static REVERB_PROPERTIES FOREST()
		{
			return new REVERB_PROPERTIES(1500f, 162f, 88f, 5000f, 54f, 79f, 100f, 250f, 0f, 760f, 94f, -12.3f);
		}

		public static REVERB_PROPERTIES CITY()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 67f, 50f, 100f, 250f, 0f, 4050f, 66f, -26f);
		}

		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return new REVERB_PROPERTIES(1500f, 300f, 100f, 5000f, 21f, 27f, 100f, 250f, 0f, 1220f, 82f, -24f);
		}

		public static REVERB_PROPERTIES QUARRY()
		{
			return new REVERB_PROPERTIES(1500f, 61f, 25f, 5000f, 83f, 100f, 100f, 250f, 0f, 3400f, 100f, -5f);
		}

		public static REVERB_PROPERTIES PLAIN()
		{
			return new REVERB_PROPERTIES(1500f, 179f, 100f, 5000f, 50f, 21f, 100f, 250f, 0f, 1670f, 65f, -28f);
		}

		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return new REVERB_PROPERTIES(1700f, 8f, 12f, 5000f, 100f, 100f, 100f, 250f, 0f, 20000f, 56f, -19.5f);
		}

		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return new REVERB_PROPERTIES(2800f, 14f, 21f, 5000f, 14f, 80f, 60f, 250f, 0f, 3400f, 66f, 1.2f);
		}

		public static REVERB_PROPERTIES UNDERWATER()
		{
			return new REVERB_PROPERTIES(1500f, 7f, 11f, 5000f, 10f, 100f, 100f, 250f, 0f, 500f, 92f, 7f);
		}
	}
	public struct ADVANCEDSETTINGS
	{
		public int cbSize;

		public int maxMPEGCodecs;

		public int maxADPCMCodecs;

		public int maxXMACodecs;

		public int maxVorbisCodecs;

		public int maxAT9Codecs;

		public int maxFADPCMCodecs;

		public int maxPCMCodecs;

		public int ASIONumChannels;

		public IntPtr ASIOChannelList;

		public IntPtr ASIOSpeakerList;

		public float HRTFMinAngle;

		public float HRTFMaxAngle;

		public float HRTFFreq;

		public float vol0virtualvol;

		public uint defaultDecodeBufferSize;

		public ushort profilePort;

		public uint geometryMaxFadeTime;

		public float distanceFilterCenterFreq;

		public int reverb3Dinstance;

		public int DSPBufferPoolSize;

		public uint stackSizeStream;

		public uint stackSizeNonBlocking;

		public uint stackSizeMixer;

		public DSP_RESAMPLER resamplerMethod;

		public uint commandQueueSize;

		public uint randomSeed;
	}
	[Flags]
	public enum DRIVER_STATE : uint
	{
		CONNECTED = 1u,
		DEFAULT = 2u
	}
	public class Factory
	{
		public static RESULT System_Create(out System system)
		{
			system = null;
			RESULT rESULT = RESULT.OK;
			IntPtr system2 = default(IntPtr);
			rESULT = FMOD5_System_Create(out system2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			system = new System(system2);
			return rESULT;
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	public class Memory
	{
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags)
		{
			return FMOD5_Memory_Initialize(poolmem, poollen, useralloc, userrealloc, userfree, memtypeflags);
		}

		public static RESULT GetStats(out int currentalloced, out int maxalloced)
		{
			return GetStats(out currentalloced, out maxalloced, blocking: false);
		}

		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking)
		{
			return FMOD5_Memory_GetStats(out currentalloced, out maxalloced, blocking);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	public class Debug
	{
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, string filename)
		{
			return FMOD5_Debug_Initialize(flags, mode, callback, filename);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, string filename);
	}
	public class HandleBase
	{
		protected IntPtr rawPtr;

		public HandleBase(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero;
		}

		public IntPtr getRaw()
		{
			return rawPtr;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as HandleBase);
		}

		public bool Equals(HandleBase p)
		{
			return (object)p != null && rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.ToInt32();
		}

		public static bool operator ==(HandleBase a, HandleBase b)
		{
			if (object.ReferenceEquals(a, b))
			{
				return true;
			}
			if ((object)a == null || (object)b == null)
			{
				return false;
			}
			return a.rawPtr == b.rawPtr;
		}

		public static bool operator !=(HandleBase a, HandleBase b)
		{
			return !(a == b);
		}
	}
	public class System : HandleBase
	{
		public System(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT release()
		{
			RESULT rESULT = FMOD5_System_Release(rawPtr);
			if (rESULT == RESULT.OK)
			{
				rawPtr = IntPtr.Zero;
			}
			return rESULT;
		}

		public RESULT setOutput(OUTPUTTYPE output)
		{
			return FMOD5_System_SetOutput(rawPtr, output);
		}

		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return FMOD5_System_GetOutput(rawPtr, out output);
		}

		public RESULT getNumDrivers(out int numdrivers)
		{
			return FMOD5_System_GetNumDrivers(rawPtr, out numdrivers);
		}

		public RESULT getDriverInfo(int id, StringBuilder name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(name.Capacity);
			RESULT result = FMOD5_System_GetDriverInfo(rawPtr, id, intPtr, namelen, out guid, out systemrate, out speakermode, out speakermodechannels);
			StringMarshalHelper.NativeToBuilder(name, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT setDriver(int driver)
		{
			return FMOD5_System_SetDriver(rawPtr, driver);
		}

		public RESULT getDriver(out int driver)
		{
			return FMOD5_System_GetDriver(rawPtr, out driver);
		}

		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return FMOD5_System_SetSoftwareChannels(rawPtr, numsoftwarechannels);
		}

		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return FMOD5_System_GetSoftwareChannels(rawPtr, out numsoftwarechannels);
		}

		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return FMOD5_System_SetSoftwareFormat(rawPtr, samplerate, speakermode, numrawspeakers);
		}

		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return FMOD5_System_GetSoftwareFormat(rawPtr, out samplerate, out speakermode, out numrawspeakers);
		}

		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return FMOD5_System_SetDSPBufferSize(rawPtr, bufferlength, numbuffers);
		}

		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return FMOD5_System_GetDSPBufferSize(rawPtr, out bufferlength, out numbuffers);
		}

		public RESULT setFileSystem(FILE_OPENCALLBACK useropen, FILE_CLOSECALLBACK userclose, FILE_READCALLBACK userread, FILE_SEEKCALLBACK userseek, FILE_ASYNCREADCALLBACK userasyncread, FILE_ASYNCCANCELCALLBACK userasynccancel, int blockalign)
		{
			return FMOD5_System_SetFileSystem(rawPtr, useropen, userclose, userread, userseek, userasyncread, userasynccancel, blockalign);
		}

		public RESULT attachFileSystem(FILE_OPENCALLBACK useropen, FILE_CLOSECALLBACK userclose, FILE_READCALLBACK userread, FILE_SEEKCALLBACK userseek)
		{
			return FMOD5_System_AttachFileSystem(rawPtr, useropen, userclose, userread, userseek);
		}

		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			settings.cbSize = Marshal.SizeOf(settings);
			return FMOD5_System_SetAdvancedSettings(rawPtr, ref settings);
		}

		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			settings.cbSize = Marshal.SizeOf(settings);
			return FMOD5_System_GetAdvancedSettings(rawPtr, ref settings);
		}

		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask)
		{
			return FMOD5_System_SetCallback(rawPtr, callback, callbackmask);
		}

		public RESULT setPluginPath(string path)
		{
			return FMOD5_System_SetPluginPath(rawPtr, Encoding.UTF8.GetBytes(path + '\0'));
		}

		public RESULT loadPlugin(string filename, out uint handle, uint priority)
		{
			return FMOD5_System_LoadPlugin(rawPtr, Encoding.UTF8.GetBytes(filename + '\0'), out handle, priority);
		}

		public RESULT loadPlugin(string filename, out uint handle)
		{
			return loadPlugin(filename, out handle, 0u);
		}

		public RESULT unloadPlugin(uint handle)
		{
			return FMOD5_System_UnloadPlugin(rawPtr, handle);
		}

		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return FMOD5_System_GetNumNestedPlugins(rawPtr, handle, out count);
		}

		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return FMOD5_System_GetNestedPlugin(rawPtr, handle, index, out nestedhandle);
		}

		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return FMOD5_System_GetNumPlugins(rawPtr, plugintype, out numplugins);
		}

		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return FMOD5_System_GetPluginHandle(rawPtr, plugintype, index, out handle);
		}

		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, StringBuilder name, int namelen, out uint version)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(name.Capacity);
			RESULT result = FMOD5_System_GetPluginInfo(rawPtr, handle, out plugintype, intPtr, namelen, out version);
			StringMarshalHelper.NativeToBuilder(name, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT setOutputByPlugin(uint handle)
		{
			return FMOD5_System_SetOutputByPlugin(rawPtr, handle);
		}

		public RESULT getOutputByPlugin(out uint handle)
		{
			return FMOD5_System_GetOutputByPlugin(rawPtr, out handle);
		}

		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			dsp = null;
			IntPtr dsp2;
			RESULT result = FMOD5_System_CreateDSPByPlugin(rawPtr, handle, out dsp2);
			dsp = new DSP(dsp2);
			return result;
		}

		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return FMOD5_System_GetDSPInfoByPlugin(rawPtr, handle, out description);
		}

		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return FMOD5_System_RegisterDSP(rawPtr, ref description, out handle);
		}

		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return FMOD5_System_Init(rawPtr, maxchannels, flags, extradriverdata);
		}

		public RESULT close()
		{
			return FMOD5_System_Close(rawPtr);
		}

		public RESULT update()
		{
			return FMOD5_System_Update(rawPtr);
		}

		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return FMOD5_System_SetSpeakerPosition(rawPtr, speaker, x, y, active);
		}

		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return FMOD5_System_GetSpeakerPosition(rawPtr, speaker, out x, out y, out active);
		}

		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return FMOD5_System_SetStreamBufferSize(rawPtr, filebuffersize, filebuffersizetype);
		}

		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return FMOD5_System_GetStreamBufferSize(rawPtr, out filebuffersize, out filebuffersizetype);
		}

		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return FMOD5_System_Set3DSettings(rawPtr, dopplerscale, distancefactor, rolloffscale);
		}

		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return FMOD5_System_Get3DSettings(rawPtr, out dopplerscale, out distancefactor, out rolloffscale);
		}

		public RESULT set3DNumListeners(int numlisteners)
		{
			return FMOD5_System_Set3DNumListeners(rawPtr, numlisteners);
		}

		public RESULT get3DNumListeners(out int numlisteners)
		{
			return FMOD5_System_Get3DNumListeners(rawPtr, out numlisteners);
		}

		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return FMOD5_System_Set3DListenerAttributes(rawPtr, listener, ref pos, ref vel, ref forward, ref up);
		}

		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return FMOD5_System_Get3DListenerAttributes(rawPtr, listener, out pos, out vel, out forward, out up);
		}

		public RESULT set3DRolloffCallback(CB_3D_ROLLOFFCALLBACK callback)
		{
			return FMOD5_System_Set3DRolloffCallback(rawPtr, callback);
		}

		public RESULT mixerSuspend()
		{
			return FMOD5_System_MixerSuspend(rawPtr);
		}

		public RESULT mixerResume()
		{
			return FMOD5_System_MixerResume(rawPtr);
		}

		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return FMOD5_System_GetDefaultMixMatrix(rawPtr, sourcespeakermode, targetspeakermode, matrix, matrixhop);
		}

		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return FMOD5_System_GetSpeakerModeChannels(rawPtr, mode, out channels);
		}

		public RESULT getVersion(out uint version)
		{
			return FMOD5_System_GetVersion(rawPtr, out version);
		}

		public RESULT getOutputHandle(out IntPtr handle)
		{
			return FMOD5_System_GetOutputHandle(rawPtr, out handle);
		}

		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return FMOD5_System_GetChannelsPlaying(rawPtr, out channels, out realchannels);
		}

		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return FMOD5_System_GetCPUUsage(rawPtr, out dsp, out stream, out geometry, out update, out total);
		}

		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return FMOD5_System_GetFileUsage(rawPtr, out sampleBytesRead, out streamBytesRead, out otherBytesRead);
		}

		public RESULT getSoundRAM(out int currentalloced, out int maxalloced, out int total)
		{
			return FMOD5_System_GetSoundRAM(rawPtr, out currentalloced, out maxalloced, out total);
		}

		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			sound = null;
			byte[] bytes = Encoding.UTF8.GetBytes(name + '\0');
			CREATESOUNDEXINFO_INTERNAL exinfo2 = CREATESOUNDEXINFO_INTERNAL.CreateFromExternal(ref exinfo);
			IntPtr sound2;
			RESULT result = FMOD5_System_CreateSound(rawPtr, bytes, mode, ref exinfo2, out sound2);
			sound = new Sound(sound2);
			return result;
		}

		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			sound = null;
			CREATESOUNDEXINFO_INTERNAL exinfo2 = CREATESOUNDEXINFO_INTERNAL.CreateFromExternal(ref exinfo);
			IntPtr sound2;
			RESULT result = FMOD5_System_CreateSound(rawPtr, data, mode, ref exinfo2, out sound2);
			sound = new Sound(sound2);
			return result;
		}

		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			CREATESOUNDEXINFO exinfo = default(CREATESOUNDEXINFO);
			exinfo.cbsize = Marshal.SizeOf(exinfo);
			return createSound(name, mode, ref exinfo, out sound);
		}

		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			sound = null;
			byte[] bytes = Encoding.UTF8.GetBytes(name + '\0');
			CREATESOUNDEXINFO_INTERNAL exinfo2 = CREATESOUNDEXINFO_INTERNAL.CreateFromExternal(ref exinfo);
			IntPtr sound2;
			RESULT result = FMOD5_System_CreateStream(rawPtr, bytes, mode, ref exinfo2, out sound2);
			sound = new Sound(sound2);
			return result;
		}

		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			sound = null;
			CREATESOUNDEXINFO_INTERNAL exinfo2 = CREATESOUNDEXINFO_INTERNAL.CreateFromExternal(ref exinfo);
			IntPtr sound2;
			RESULT result = FMOD5_System_CreateStream(rawPtr, data, mode, ref exinfo2, out sound2);
			sound = new Sound(sound2);
			return result;
		}

		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			CREATESOUNDEXINFO exinfo = default(CREATESOUNDEXINFO);
			exinfo.cbsize = Marshal.SizeOf(exinfo);
			return createStream(name, mode, ref exinfo, out sound);
		}

		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			dsp = null;
			IntPtr dsp2;
			RESULT result = FMOD5_System_CreateDSP(rawPtr, ref description, out dsp2);
			dsp = new DSP(dsp2);
			return result;
		}

		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			dsp = null;
			IntPtr dsp2;
			RESULT result = FMOD5_System_CreateDSPByType(rawPtr, type, out dsp2);
			dsp = new DSP(dsp2);
			return result;
		}

		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			channelgroup = null;
			byte[] bytes = Encoding.UTF8.GetBytes(name + '\0');
			IntPtr channelgroup2;
			RESULT result = FMOD5_System_CreateChannelGroup(rawPtr, bytes, out channelgroup2);
			channelgroup = new ChannelGroup(channelgroup2);
			return result;
		}

		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			soundgroup = null;
			byte[] bytes = Encoding.UTF8.GetBytes(name + '\0');
			IntPtr soundgroup2;
			RESULT result = FMOD5_System_CreateSoundGroup(rawPtr, bytes, out soundgroup2);
			soundgroup = new SoundGroup(soundgroup2);
			return result;
		}

		public RESULT createReverb3D(out Reverb3D reverb)
		{
			IntPtr reverb2;
			RESULT result = FMOD5_System_CreateReverb3D(rawPtr, out reverb2);
			reverb = new Reverb3D(reverb2);
			return result;
		}

		public RESULT playSound(Sound sound, ChannelGroup channelGroup, bool paused, out Channel channel)
		{
			channel = null;
			IntPtr channelGroup2 = ((!(channelGroup != null)) ? IntPtr.Zero : channelGroup.getRaw());
			IntPtr channel2;
			RESULT result = FMOD5_System_PlaySound(rawPtr, sound.getRaw(), channelGroup2, paused, out channel2);
			channel = new Channel(channel2);
			return result;
		}

		public RESULT playDSP(DSP dsp, ChannelGroup channelGroup, bool paused, out Channel channel)
		{
			channel = null;
			IntPtr channelGroup2 = ((!(channelGroup != null)) ? IntPtr.Zero : channelGroup.getRaw());
			IntPtr channel2;
			RESULT result = FMOD5_System_PlayDSP(rawPtr, dsp.getRaw(), channelGroup2, paused, out channel2);
			channel = new Channel(channel2);
			return result;
		}

		public RESULT getChannel(int channelid, out Channel channel)
		{
			channel = null;
			IntPtr channel2;
			RESULT result = FMOD5_System_GetChannel(rawPtr, channelid, out channel2);
			channel = new Channel(channel2);
			return result;
		}

		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			channelgroup = null;
			IntPtr channelgroup2;
			RESULT result = FMOD5_System_GetMasterChannelGroup(rawPtr, out channelgroup2);
			channelgroup = new ChannelGroup(channelgroup2);
			return result;
		}

		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			soundgroup = null;
			IntPtr soundgroup2;
			RESULT result = FMOD5_System_GetMasterSoundGroup(rawPtr, out soundgroup2);
			soundgroup = new SoundGroup(soundgroup2);
			return result;
		}

		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return FMOD5_System_AttachChannelGroupToPort(rawPtr, portType, portIndex, channelgroup.getRaw(), passThru);
		}

		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return FMOD5_System_DetachChannelGroupFromPort(rawPtr, channelgroup.getRaw());
		}

		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return FMOD5_System_SetReverbProperties(rawPtr, instance, ref prop);
		}

		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return FMOD5_System_GetReverbProperties(rawPtr, instance, out prop);
		}

		public RESULT lockDSP()
		{
			return FMOD5_System_LockDSP(rawPtr);
		}

		public RESULT unlockDSP()
		{
			return FMOD5_System_UnlockDSP(rawPtr);
		}

		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return FMOD5_System_GetRecordNumDrivers(rawPtr, out numdrivers, out numconnected);
		}

		public RESULT getRecordDriverInfo(int id, StringBuilder name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(name.Capacity);
			RESULT result = FMOD5_System_GetRecordDriverInfo(rawPtr, id, intPtr, namelen, out guid, out systemrate, out speakermode, out speakermodechannels, out state);
			StringMarshalHelper.NativeToBuilder(name, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getRecordPosition(int id, out uint position)
		{
			return FMOD5_System_GetRecordPosition(rawPtr, id, out position);
		}

		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return FMOD5_System_RecordStart(rawPtr, id, sound.getRaw(), loop);
		}

		public RESULT recordStop(int id)
		{
			return FMOD5_System_RecordStop(rawPtr, id);
		}

		public RESULT isRecording(int id, out bool recording)
		{
			return FMOD5_System_IsRecording(rawPtr, id, out recording);
		}

		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			geometry = null;
			IntPtr geometry2;
			RESULT result = FMOD5_System_CreateGeometry(rawPtr, maxpolygons, maxvertices, out geometry2);
			geometry = new Geometry(geometry2);
			return result;
		}

		public RESULT setGeometrySettings(float maxworldsize)
		{
			return FMOD5_System_SetGeometrySettings(rawPtr, maxworldsize);
		}

		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return FMOD5_System_GetGeometrySettings(rawPtr, out maxworldsize);
		}

		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			geometry = null;
			IntPtr geometry2;
			RESULT result = FMOD5_System_LoadGeometry(rawPtr, data, datasize, out geometry2);
			geometry = new Geometry(geometry2);
			return result;
		}

		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return FMOD5_System_GetGeometryOcclusion(rawPtr, ref listener, ref source, out direct, out reverb);
		}

		public RESULT setNetworkProxy(string proxy)
		{
			return FMOD5_System_SetNetworkProxy(rawPtr, Encoding.UTF8.GetBytes(proxy + '\0'));
		}

		public RESULT getNetworkProxy(StringBuilder proxy, int proxylen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(proxy.Capacity);
			RESULT result = FMOD5_System_GetNetworkProxy(rawPtr, intPtr, proxylen);
			StringMarshalHelper.NativeToBuilder(proxy, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT setNetworkTimeout(int timeout)
		{
			return FMOD5_System_SetNetworkTimeout(rawPtr, timeout);
		}

		public RESULT getNetworkTimeout(out int timeout)
		{
			return FMOD5_System_GetNetworkTimeout(rawPtr, out timeout);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_System_SetUserData(rawPtr, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_System_GetUserData(rawPtr, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPENCALLBACK useropen, FILE_CLOSECALLBACK userclose, FILE_READCALLBACK userread, FILE_SEEKCALLBACK userseek, FILE_ASYNCREADCALLBACK userasyncread, FILE_ASYNCCANCELCALLBACK userasynccancel, int blockalign);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPENCALLBACK useropen, FILE_CLOSECALLBACK userclose, FILE_READCALLBACK userread, FILE_SEEKCALLBACK userseek);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFFCALLBACK callback);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetSoundRAM(IntPtr system, out int currentalloced, out int maxalloced, out int total);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO_INTERNAL exinfo, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO_INTERNAL exinfo, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelGroup, bool paused, out IntPtr channel);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelGroup, bool paused, out IntPtr channel);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);
	}
	public class Sound : HandleBase
	{
		public Sound(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT release()
		{
			RESULT rESULT = FMOD5_Sound_Release(rawPtr);
			if (rESULT == RESULT.OK)
			{
				rawPtr = IntPtr.Zero;
			}
			return rESULT;
		}

		public RESULT getSystemObject(out System system)
		{
			system = null;
			IntPtr system2;
			RESULT result = FMOD5_Sound_GetSystemObject(rawPtr, out system2);
			system = new System(system2);
			return result;
		}

		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return FMOD5_Sound_Lock(rawPtr, offset, length, out ptr1, out ptr2, out len1, out len2);
		}

		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return FMOD5_Sound_Unlock(rawPtr, ptr1, ptr2, len1, len2);
		}

		public RESULT setDefaults(float frequency, int priority)
		{
			return FMOD5_Sound_SetDefaults(rawPtr, frequency, priority);
		}

		public RESULT getDefaults(out float frequency, out int priority)
		{
			return FMOD5_Sound_GetDefaults(rawPtr, out frequency, out priority);
		}

		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return FMOD5_Sound_Set3DMinMaxDistance(rawPtr, min, max);
		}

		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return FMOD5_Sound_Get3DMinMaxDistance(rawPtr, out min, out max);
		}

		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return FMOD5_Sound_Set3DConeSettings(rawPtr, insideconeangle, outsideconeangle, outsidevolume);
		}

		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return FMOD5_Sound_Get3DConeSettings(rawPtr, out insideconeangle, out outsideconeangle, out outsidevolume);
		}

		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return FMOD5_Sound_Set3DCustomRolloff(rawPtr, ref points, numpoints);
		}

		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return FMOD5_Sound_Get3DCustomRolloff(rawPtr, out points, out numpoints);
		}

		public RESULT getSubSound(int index, out Sound subsound)
		{
			subsound = null;
			IntPtr subsound2;
			RESULT result = FMOD5_Sound_GetSubSound(rawPtr, index, out subsound2);
			subsound = new Sound(subsound2);
			return result;
		}

		public RESULT getSubSoundParent(out Sound parentsound)
		{
			parentsound = null;
			IntPtr parentsound2;
			RESULT result = FMOD5_Sound_GetSubSoundParent(rawPtr, out parentsound2);
			parentsound = new Sound(parentsound2);
			return result;
		}

		public RESULT getName(StringBuilder name, int namelen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(name.Capacity);
			RESULT result = FMOD5_Sound_GetName(rawPtr, intPtr, namelen);
			StringMarshalHelper.NativeToBuilder(name, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return FMOD5_Sound_GetLength(rawPtr, out length, lengthtype);
		}

		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return FMOD5_Sound_GetFormat(rawPtr, out type, out format, out channels, out bits);
		}

		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return FMOD5_Sound_GetNumSubSounds(rawPtr, out numsubsounds);
		}

		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return FMOD5_Sound_GetNumTags(rawPtr, out numtags, out numtagsupdated);
		}

		public RESULT getTag(string name, int index, out TAG tag)
		{
			return FMOD5_Sound_GetTag(rawPtr, name, index, out tag);
		}

		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return FMOD5_Sound_GetOpenState(rawPtr, out openstate, out percentbuffered, out starving, out diskbusy);
		}

		public RESULT readData(IntPtr buffer, uint lenbytes, out uint read)
		{
			return FMOD5_Sound_ReadData(rawPtr, buffer, lenbytes, out read);
		}

		public RESULT seekData(uint pcm)
		{
			return FMOD5_Sound_SeekData(rawPtr, pcm);
		}

		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return FMOD5_Sound_SetSoundGroup(rawPtr, soundgroup.getRaw());
		}

		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			soundgroup = null;
			IntPtr soundgroup2;
			RESULT result = FMOD5_Sound_GetSoundGroup(rawPtr, out soundgroup2);
			soundgroup = new SoundGroup(soundgroup2);
			return result;
		}

		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return FMOD5_Sound_GetNumSyncPoints(rawPtr, out numsyncpoints);
		}

		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return FMOD5_Sound_GetSyncPoint(rawPtr, index, out point);
		}

		public RESULT getSyncPointInfo(IntPtr point, StringBuilder name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(name.Capacity);
			RESULT result = FMOD5_Sound_GetSyncPointInfo(rawPtr, point, intPtr, namelen, out offset, offsettype);
			StringMarshalHelper.NativeToBuilder(name, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return FMOD5_Sound_AddSyncPoint(rawPtr, offset, offsettype, name, out point);
		}

		public RESULT deleteSyncPoint(IntPtr point)
		{
			return FMOD5_Sound_DeleteSyncPoint(rawPtr, point);
		}

		public RESULT setMode(MODE mode)
		{
			return FMOD5_Sound_SetMode(rawPtr, mode);
		}

		public RESULT getMode(out MODE mode)
		{
			return FMOD5_Sound_GetMode(rawPtr, out mode);
		}

		public RESULT setLoopCount(int loopcount)
		{
			return FMOD5_Sound_SetLoopCount(rawPtr, loopcount);
		}

		public RESULT getLoopCount(out int loopcount)
		{
			return FMOD5_Sound_GetLoopCount(rawPtr, out loopcount);
		}

		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return FMOD5_Sound_SetLoopPoints(rawPtr, loopstart, loopstarttype, loopend, loopendtype);
		}

		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return FMOD5_Sound_GetLoopPoints(rawPtr, out loopstart, loopstarttype, out loopend, loopendtype);
		}

		public RESULT getMusicNumChannels(out int numchannels)
		{
			return FMOD5_Sound_GetMusicNumChannels(rawPtr, out numchannels);
		}

		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return FMOD5_Sound_SetMusicChannelVolume(rawPtr, channel, volume);
		}

		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return FMOD5_Sound_GetMusicChannelVolume(rawPtr, channel, out volume);
		}

		public RESULT setMusicSpeed(float speed)
		{
			return FMOD5_Sound_SetMusicSpeed(rawPtr, speed);
		}

		public RESULT getMusicSpeed(out float speed)
		{
			return FMOD5_Sound_GetMusicSpeed(rawPtr, out speed);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_Sound_SetUserData(rawPtr, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_Sound_GetUserData(rawPtr, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, string name, int index, out TAG tag);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint lenbytes, out uint read);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, string name, out IntPtr point);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);
	}
	public class ChannelControl : HandleBase
	{
		protected ChannelControl(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT getSystemObject(out System system)
		{
			system = null;
			IntPtr system2;
			RESULT result = FMOD5_ChannelGroup_GetSystemObject(rawPtr, out system2);
			system = new System(system2);
			return result;
		}

		public RESULT stop()
		{
			return FMOD5_ChannelGroup_Stop(rawPtr);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD5_ChannelGroup_SetPaused(rawPtr, paused);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD5_ChannelGroup_GetPaused(rawPtr, out paused);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD5_ChannelGroup_SetVolume(rawPtr, volume);
		}

		public RESULT getVolume(out float volume)
		{
			return FMOD5_ChannelGroup_GetVolume(rawPtr, out volume);
		}

		public RESULT setVolumeRamp(bool ramp)
		{
			return FMOD5_ChannelGroup_SetVolumeRamp(rawPtr, ramp);
		}

		public RESULT getVolumeRamp(out bool ramp)
		{
			return FMOD5_ChannelGroup_GetVolumeRamp(rawPtr, out ramp);
		}

		public RESULT getAudibility(out float audibility)
		{
			return FMOD5_ChannelGroup_GetAudibility(rawPtr, out audibility);
		}

		public RESULT setPitch(float pitch)
		{
			return FMOD5_ChannelGroup_SetPitch(rawPtr, pitch);
		}

		public RESULT getPitch(out float pitch)
		{
			return FMOD5_ChannelGroup_GetPitch(rawPtr, out pitch);
		}

		public RESULT setMute(bool mute)
		{
			return FMOD5_ChannelGroup_SetMute(rawPtr, mute);
		}

		public RESULT getMute(out bool mute)
		{
			return FMOD5_ChannelGroup_GetMute(rawPtr, out mute);
		}

		public RESULT setReverbProperties(int instance, float wet)
		{
			return FMOD5_ChannelGroup_SetReverbProperties(rawPtr, instance, wet);
		}

		public RESULT getReverbProperties(int instance, out float wet)
		{
			return FMOD5_ChannelGroup_GetReverbProperties(rawPtr, instance, out wet);
		}

		public RESULT setLowPassGain(float gain)
		{
			return FMOD5_ChannelGroup_SetLowPassGain(rawPtr, gain);
		}

		public RESULT getLowPassGain(out float gain)
		{
			return FMOD5_ChannelGroup_GetLowPassGain(rawPtr, out gain);
		}

		public RESULT setMode(MODE mode)
		{
			return FMOD5_ChannelGroup_SetMode(rawPtr, mode);
		}

		public RESULT getMode(out MODE mode)
		{
			return FMOD5_ChannelGroup_GetMode(rawPtr, out mode);
		}

		public RESULT setCallback(CHANNEL_CALLBACK callback)
		{
			return FMOD5_ChannelGroup_SetCallback(rawPtr, callback);
		}

		public RESULT isPlaying(out bool isplaying)
		{
			return FMOD5_ChannelGroup_IsPlaying(rawPtr, out isplaying);
		}

		public RESULT setPan(float pan)
		{
			return FMOD5_ChannelGroup_SetPan(rawPtr, pan);
		}

		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return FMOD5_ChannelGroup_SetMixLevelsOutput(rawPtr, frontleft, frontright, center, lfe, surroundleft, surroundright, backleft, backright);
		}

		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return FMOD5_ChannelGroup_SetMixLevelsInput(rawPtr, levels, numlevels);
		}

		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return FMOD5_ChannelGroup_SetMixMatrix(rawPtr, matrix, outchannels, inchannels, inchannel_hop);
		}

		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return FMOD5_ChannelGroup_GetMixMatrix(rawPtr, matrix, out outchannels, out inchannels, inchannel_hop);
		}

		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return FMOD5_ChannelGroup_GetDSPClock(rawPtr, out dspclock, out parentclock);
		}

		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return FMOD5_ChannelGroup_SetDelay(rawPtr, dspclock_start, dspclock_end, stopchannels);
		}

		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return FMOD5_ChannelGroup_GetDelay(rawPtr, out dspclock_start, out dspclock_end, out stopchannels);
		}

		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return FMOD5_ChannelGroup_AddFadePoint(rawPtr, dspclock, volume);
		}

		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return FMOD5_ChannelGroup_SetFadePointRamp(rawPtr, dspclock, volume);
		}

		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return FMOD5_ChannelGroup_RemoveFadePoints(rawPtr, dspclock_start, dspclock_end);
		}

		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return FMOD5_ChannelGroup_GetFadePoints(rawPtr, ref numpoints, point_dspclock, point_volume);
		}

		public RESULT getDSP(int index, out DSP dsp)
		{
			dsp = null;
			IntPtr dsp2;
			RESULT result = FMOD5_ChannelGroup_GetDSP(rawPtr, index, out dsp2);
			dsp = new DSP(dsp2);
			return result;
		}

		public RESULT addDSP(int index, DSP dsp)
		{
			return FMOD5_ChannelGroup_AddDSP(rawPtr, index, dsp.getRaw());
		}

		public RESULT removeDSP(DSP dsp)
		{
			return FMOD5_ChannelGroup_RemoveDSP(rawPtr, dsp.getRaw());
		}

		public RESULT getNumDSPs(out int numdsps)
		{
			return FMOD5_ChannelGroup_GetNumDSPs(rawPtr, out numdsps);
		}

		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return FMOD5_ChannelGroup_SetDSPIndex(rawPtr, dsp.getRaw(), index);
		}

		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return FMOD5_ChannelGroup_GetDSPIndex(rawPtr, dsp.getRaw(), out index);
		}

		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel, ref VECTOR alt_pan_pos)
		{
			return FMOD5_ChannelGroup_Set3DAttributes(rawPtr, ref pos, ref vel, ref alt_pan_pos);
		}

		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel, out VECTOR alt_pan_pos)
		{
			return FMOD5_ChannelGroup_Get3DAttributes(rawPtr, out pos, out vel, out alt_pan_pos);
		}

		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return FMOD5_ChannelGroup_Set3DMinMaxDistance(rawPtr, mindistance, maxdistance);
		}

		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return FMOD5_ChannelGroup_Get3DMinMaxDistance(rawPtr, out mindistance, out maxdistance);
		}

		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return FMOD5_ChannelGroup_Set3DConeSettings(rawPtr, insideconeangle, outsideconeangle, outsidevolume);
		}

		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return FMOD5_ChannelGroup_Get3DConeSettings(rawPtr, out insideconeangle, out outsideconeangle, out outsidevolume);
		}

		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return FMOD5_ChannelGroup_Set3DConeOrientation(rawPtr, ref orientation);
		}

		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return FMOD5_ChannelGroup_Get3DConeOrientation(rawPtr, out orientation);
		}

		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return FMOD5_ChannelGroup_Set3DCustomRolloff(rawPtr, ref points, numpoints);
		}

		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return FMOD5_ChannelGroup_Get3DCustomRolloff(rawPtr, out points, out numpoints);
		}

		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return FMOD5_ChannelGroup_Set3DOcclusion(rawPtr, directocclusion, reverbocclusion);
		}

		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return FMOD5_ChannelGroup_Get3DOcclusion(rawPtr, out directocclusion, out reverbocclusion);
		}

		public RESULT set3DSpread(float angle)
		{
			return FMOD5_ChannelGroup_Set3DSpread(rawPtr, angle);
		}

		public RESULT get3DSpread(out float angle)
		{
			return FMOD5_ChannelGroup_Get3DSpread(rawPtr, out angle);
		}

		public RESULT set3DLevel(float level)
		{
			return FMOD5_ChannelGroup_Set3DLevel(rawPtr, level);
		}

		public RESULT get3DLevel(out float level)
		{
			return FMOD5_ChannelGroup_Get3DLevel(rawPtr, out level);
		}

		public RESULT set3DDopplerLevel(float level)
		{
			return FMOD5_ChannelGroup_Set3DDopplerLevel(rawPtr, level);
		}

		public RESULT get3DDopplerLevel(out float level)
		{
			return FMOD5_ChannelGroup_Get3DDopplerLevel(rawPtr, out level);
		}

		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return FMOD5_ChannelGroup_Set3DDistanceFilter(rawPtr, custom, customLevel, centerFreq);
		}

		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return FMOD5_ChannelGroup_Get3DDistanceFilter(rawPtr, out custom, out customLevel, out centerFreq);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_ChannelGroup_SetUserData(rawPtr, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_ChannelGroup_GetUserData(rawPtr, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNEL_CALLBACK callback);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel, ref VECTOR alt_pan_pos);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel, out VECTOR alt_pan_pos);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);
	}
	public class Channel : ChannelControl
	{
		public Channel(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT setFrequency(float frequency)
		{
			return FMOD5_Channel_SetFrequency(getRaw(), frequency);
		}

		public RESULT getFrequency(out float frequency)
		{
			return FMOD5_Channel_GetFrequency(getRaw(), out frequency);
		}

		public RESULT setPriority(int priority)
		{
			return FMOD5_Channel_SetPriority(getRaw(), priority);
		}

		public RESULT getPriority(out int priority)
		{
			return FMOD5_Channel_GetPriority(getRaw(), out priority);
		}

		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return FMOD5_Channel_SetPosition(getRaw(), position, postype);
		}

		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return FMOD5_Channel_GetPosition(getRaw(), out position, postype);
		}

		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return FMOD5_Channel_SetChannelGroup(getRaw(), channelgroup.getRaw());
		}

		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			channelgroup = null;
			IntPtr channelgroup2;
			RESULT result = FMOD5_Channel_GetChannelGroup(getRaw(), out channelgroup2);
			channelgroup = new ChannelGroup(channelgroup2);
			return result;
		}

		public RESULT setLoopCount(int loopcount)
		{
			return FMOD5_Channel_SetLoopCount(getRaw(), loopcount);
		}

		public RESULT getLoopCount(out int loopcount)
		{
			return FMOD5_Channel_GetLoopCount(getRaw(), out loopcount);
		}

		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return FMOD5_Channel_SetLoopPoints(getRaw(), loopstart, loopstarttype, loopend, loopendtype);
		}

		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return FMOD5_Channel_GetLoopPoints(getRaw(), out loopstart, loopstarttype, out loopend, loopendtype);
		}

		public RESULT isVirtual(out bool isvirtual)
		{
			return FMOD5_Channel_IsVirtual(getRaw(), out isvirtual);
		}

		public RESULT getCurrentSound(out Sound sound)
		{
			sound = null;
			IntPtr sound2;
			RESULT result = FMOD5_Channel_GetCurrentSound(getRaw(), out sound2);
			sound = new Sound(sound2);
			return result;
		}

		public RESULT getIndex(out int index)
		{
			return FMOD5_Channel_GetIndex(getRaw(), out index);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);
	}
	public class ChannelGroup : ChannelControl
	{
		public ChannelGroup(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT release()
		{
			RESULT rESULT = FMOD5_ChannelGroup_Release(getRaw());
			if (rESULT == RESULT.OK)
			{
				rawPtr = IntPtr.Zero;
			}
			return rESULT;
		}

		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			connection = null;
			IntPtr connection2;
			RESULT result = FMOD5_ChannelGroup_AddGroup(getRaw(), group.getRaw(), propagatedspclock, out connection2);
			connection = new DSPConnection(connection2);
			return result;
		}

		public RESULT getNumGroups(out int numgroups)
		{
			return FMOD5_ChannelGroup_GetNumGroups(getRaw(), out numgroups);
		}

		public RESULT getGroup(int index, out ChannelGroup group)
		{
			group = null;
			IntPtr group2;
			RESULT result = FMOD5_ChannelGroup_GetGroup(getRaw(), index, out group2);
			group = new ChannelGroup(group2);
			return result;
		}

		public RESULT getParentGroup(out ChannelGroup group)
		{
			group = null;
			IntPtr group2;
			RESULT result = FMOD5_ChannelGroup_GetParentGroup(getRaw(), out group2);
			group = new ChannelGroup(group2);
			return result;
		}

		public RESULT getName(StringBuilder name, int namelen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(name.Capacity);
			RESULT result = FMOD5_ChannelGroup_GetName(getRaw(), intPtr, namelen);
			StringMarshalHelper.NativeToBuilder(name, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getNumChannels(out int numchannels)
		{
			return FMOD5_ChannelGroup_GetNumChannels(getRaw(), out numchannels);
		}

		public RESULT getChannel(int index, out Channel channel)
		{
			channel = null;
			IntPtr channel2;
			RESULT result = FMOD5_ChannelGroup_GetChannel(getRaw(), index, out channel2);
			channel = new Channel(channel2);
			return result;
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propogatedspclocks, out IntPtr connection);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);
	}
	public class SoundGroup : HandleBase
	{
		public SoundGroup(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT release()
		{
			RESULT rESULT = FMOD5_SoundGroup_Release(getRaw());
			if (rESULT == RESULT.OK)
			{
				rawPtr = IntPtr.Zero;
			}
			return rESULT;
		}

		public RESULT getSystemObject(out System system)
		{
			system = null;
			IntPtr system2;
			RESULT result = FMOD5_SoundGroup_GetSystemObject(rawPtr, out system2);
			system = new System(system2);
			return result;
		}

		public RESULT setMaxAudible(int maxaudible)
		{
			return FMOD5_SoundGroup_SetMaxAudible(rawPtr, maxaudible);
		}

		public RESULT getMaxAudible(out int maxaudible)
		{
			return FMOD5_SoundGroup_GetMaxAudible(rawPtr, out maxaudible);
		}

		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return FMOD5_SoundGroup_SetMaxAudibleBehavior(rawPtr, behavior);
		}

		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return FMOD5_SoundGroup_GetMaxAudibleBehavior(rawPtr, out behavior);
		}

		public RESULT setMuteFadeSpeed(float speed)
		{
			return FMOD5_SoundGroup_SetMuteFadeSpeed(rawPtr, speed);
		}

		public RESULT getMuteFadeSpeed(out float speed)
		{
			return FMOD5_SoundGroup_GetMuteFadeSpeed(rawPtr, out speed);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD5_SoundGroup_SetVolume(rawPtr, volume);
		}

		public RESULT getVolume(out float volume)
		{
			return FMOD5_SoundGroup_GetVolume(rawPtr, out volume);
		}

		public RESULT stop()
		{
			return FMOD5_SoundGroup_Stop(rawPtr);
		}

		public RESULT getName(StringBuilder name, int namelen)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(name.Capacity);
			RESULT result = FMOD5_SoundGroup_GetName(rawPtr, intPtr, namelen);
			StringMarshalHelper.NativeToBuilder(name, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getNumSounds(out int numsounds)
		{
			return FMOD5_SoundGroup_GetNumSounds(rawPtr, out numsounds);
		}

		public RESULT getSound(int index, out Sound sound)
		{
			sound = null;
			IntPtr sound2;
			RESULT result = FMOD5_SoundGroup_GetSound(rawPtr, index, out sound2);
			sound = new Sound(sound2);
			return result;
		}

		public RESULT getNumPlaying(out int numplaying)
		{
			return FMOD5_SoundGroup_GetNumPlaying(rawPtr, out numplaying);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_SoundGroup_SetUserData(rawPtr, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_SoundGroup_GetUserData(rawPtr, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);
	}
	public class DSP : HandleBase
	{
		public DSP(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT release()
		{
			RESULT rESULT = FMOD5_DSP_Release(getRaw());
			if (rESULT == RESULT.OK)
			{
				rawPtr = IntPtr.Zero;
			}
			return rESULT;
		}

		public RESULT getSystemObject(out System system)
		{
			system = null;
			IntPtr system2;
			RESULT result = FMOD5_DSP_GetSystemObject(rawPtr, out system2);
			system = new System(system2);
			return result;
		}

		public RESULT addInput(DSP target, out DSPConnection connection, DSPCONNECTION_TYPE type)
		{
			connection = null;
			IntPtr connection2;
			RESULT result = FMOD5_DSP_AddInput(rawPtr, target.getRaw(), out connection2, type);
			connection = new DSPConnection(connection2);
			return result;
		}

		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return FMOD5_DSP_DisconnectFrom(rawPtr, target.getRaw(), connection.getRaw());
		}

		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return FMOD5_DSP_DisconnectAll(rawPtr, inputs, outputs);
		}

		public RESULT getNumInputs(out int numinputs)
		{
			return FMOD5_DSP_GetNumInputs(rawPtr, out numinputs);
		}

		public RESULT getNumOutputs(out int numoutputs)
		{
			return FMOD5_DSP_GetNumOutputs(rawPtr, out numoutputs);
		}

		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			input = null;
			inputconnection = null;
			IntPtr input2;
			IntPtr inputconnection2;
			RESULT result = FMOD5_DSP_GetInput(rawPtr, index, out input2, out inputconnection2);
			input = new DSP(input2);
			inputconnection = new DSPConnection(inputconnection2);
			return result;
		}

		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			output = null;
			outputconnection = null;
			IntPtr output2;
			IntPtr outputconnection2;
			RESULT result = FMOD5_DSP_GetOutput(rawPtr, index, out output2, out outputconnection2);
			output = new DSP(output2);
			outputconnection = new DSPConnection(outputconnection2);
			return result;
		}

		public RESULT setActive(bool active)
		{
			return FMOD5_DSP_SetActive(rawPtr, active);
		}

		public RESULT getActive(out bool active)
		{
			return FMOD5_DSP_GetActive(rawPtr, out active);
		}

		public RESULT setBypass(bool bypass)
		{
			return FMOD5_DSP_SetBypass(rawPtr, bypass);
		}

		public RESULT getBypass(out bool bypass)
		{
			return FMOD5_DSP_GetBypass(rawPtr, out bypass);
		}

		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return FMOD5_DSP_SetWetDryMix(rawPtr, prewet, postwet, dry);
		}

		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return FMOD5_DSP_GetWetDryMix(rawPtr, out prewet, out postwet, out dry);
		}

		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return FMOD5_DSP_SetChannelFormat(rawPtr, channelmask, numchannels, source_speakermode);
		}

		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return FMOD5_DSP_GetChannelFormat(rawPtr, out channelmask, out numchannels, out source_speakermode);
		}

		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return FMOD5_DSP_GetOutputChannelFormat(rawPtr, inmask, inchannels, inspeakermode, out outmask, out outchannels, out outspeakermode);
		}

		public RESULT reset()
		{
			return FMOD5_DSP_Reset(rawPtr);
		}

		public RESULT setParameterFloat(int index, float value)
		{
			return FMOD5_DSP_SetParameterFloat(rawPtr, index, value);
		}

		public RESULT setParameterInt(int index, int value)
		{
			return FMOD5_DSP_SetParameterInt(rawPtr, index, value);
		}

		public RESULT setParameterBool(int index, bool value)
		{
			return FMOD5_DSP_SetParameterBool(rawPtr, index, value);
		}

		public RESULT setParameterData(int index, byte[] data)
		{
			return FMOD5_DSP_SetParameterData(rawPtr, index, Marshal.UnsafeAddrOfPinnedArrayElement(data, 0), (uint)data.Length);
		}

		public RESULT getParameterFloat(int index, out float value)
		{
			IntPtr zero = IntPtr.Zero;
			return FMOD5_DSP_GetParameterFloat(rawPtr, index, out value, zero, 0);
		}

		public RESULT getParameterInt(int index, out int value)
		{
			IntPtr zero = IntPtr.Zero;
			return FMOD5_DSP_GetParameterInt(rawPtr, index, out value, zero, 0);
		}

		public RESULT getParameterBool(int index, out bool value)
		{
			return FMOD5_DSP_GetParameterBool(rawPtr, index, out value, IntPtr.Zero, 0);
		}

		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return FMOD5_DSP_GetParameterData(rawPtr, index, out data, out length, IntPtr.Zero, 0);
		}

		public RESULT getNumParameters(out int numparams)
		{
			return FMOD5_DSP_GetNumParameters(rawPtr, out numparams);
		}

		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			IntPtr desc2;
			RESULT rESULT = FMOD5_DSP_GetParameterInfo(rawPtr, index, out desc2);
			if (rESULT == RESULT.OK)
			{
				desc = (DSP_PARAMETER_DESC)Marshal.PtrToStructure(desc2, typeof(DSP_PARAMETER_DESC));
			}
			else
			{
				desc = default(DSP_PARAMETER_DESC);
			}
			return rESULT;
		}

		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return FMOD5_DSP_GetDataParameterIndex(rawPtr, datatype, out index);
		}

		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return FMOD5_DSP_ShowConfigDialog(rawPtr, hwnd, show);
		}

		public RESULT getInfo(StringBuilder name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(32);
			RESULT result = FMOD5_DSP_GetInfo(rawPtr, intPtr, out version, out channels, out configwidth, out configheight);
			StringMarshalHelper.NativeToBuilder(name, intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}

		public RESULT getType(out DSP_TYPE type)
		{
			return FMOD5_DSP_GetType(rawPtr, out type);
		}

		public RESULT getIdle(out bool idle)
		{
			return FMOD5_DSP_GetIdle(rawPtr, out idle);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_DSP_SetUserData(rawPtr, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_DSP_GetUserData(rawPtr, out userdata);
		}

		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return FMOD5_DSP_SetMeteringEnabled(rawPtr, inputEnabled, outputEnabled);
		}

		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return FMOD5_DSP_GetMeteringEnabled(rawPtr, out inputEnabled, out outputEnabled);
		}

		public RESULT getMeteringInfo(DSP_METERING_INFO inputInfo, DSP_METERING_INFO outputInfo)
		{
			return FMOD5_DSP_GetMeteringInfo(rawPtr, inputInfo, outputInfo);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr target, out IntPtr connection, DSPCONNECTION_TYPE type);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out IntPtr desc);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[DllImport("fmod")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[DllImport("fmod")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[DllImport("fmod")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, [Out] DSP_METERING_INFO inputInfo, [Out] DSP_METERING_INFO outputInfo);
	}
	public class DSPConnection : HandleBase
	{
		public DSPConnection(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT getInput(out DSP input)
		{
			input = null;
			IntPtr input2;
			RESULT result = FMOD5_DSPConnection_GetInput(rawPtr, out input2);
			input = new DSP(input2);
			return result;
		}

		public RESULT getOutput(out DSP output)
		{
			output = null;
			IntPtr output2;
			RESULT result = FMOD5_DSPConnection_GetOutput(rawPtr, out output2);
			output = new DSP(output2);
			return result;
		}

		public RESULT setMix(float volume)
		{
			return FMOD5_DSPConnection_SetMix(rawPtr, volume);
		}

		public RESULT getMix(out float volume)
		{
			return FMOD5_DSPConnection_GetMix(rawPtr, out volume);
		}

		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return FMOD5_DSPConnection_SetMixMatrix(rawPtr, matrix, outchannels, inchannels, inchannel_hop);
		}

		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return FMOD5_DSPConnection_GetMixMatrix(rawPtr, matrix, out outchannels, out inchannels, inchannel_hop);
		}

		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return FMOD5_DSPConnection_GetType(rawPtr, out type);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_DSPConnection_SetUserData(rawPtr, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_DSPConnection_GetUserData(rawPtr, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);
	}
	public class Geometry : HandleBase
	{
		public Geometry(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT release()
		{
			RESULT rESULT = FMOD5_Geometry_Release(getRaw());
			if (rESULT == RESULT.OK)
			{
				rawPtr = IntPtr.Zero;
			}
			return rESULT;
		}

		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return FMOD5_Geometry_AddPolygon(rawPtr, directocclusion, reverbocclusion, doublesided, numvertices, vertices, out polygonindex);
		}

		public RESULT getNumPolygons(out int numpolygons)
		{
			return FMOD5_Geometry_GetNumPolygons(rawPtr, out numpolygons);
		}

		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return FMOD5_Geometry_GetMaxPolygons(rawPtr, out maxpolygons, out maxvertices);
		}

		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return FMOD5_Geometry_GetPolygonNumVertices(rawPtr, index, out numvertices);
		}

		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return FMOD5_Geometry_SetPolygonVertex(rawPtr, index, vertexindex, ref vertex);
		}

		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return FMOD5_Geometry_GetPolygonVertex(rawPtr, index, vertexindex, out vertex);
		}

		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return FMOD5_Geometry_SetPolygonAttributes(rawPtr, index, directocclusion, reverbocclusion, doublesided);
		}

		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return FMOD5_Geometry_GetPolygonAttributes(rawPtr, index, out directocclusion, out reverbocclusion, out doublesided);
		}

		public RESULT setActive(bool active)
		{
			return FMOD5_Geometry_SetActive(rawPtr, active);
		}

		public RESULT getActive(out bool active)
		{
			return FMOD5_Geometry_GetActive(rawPtr, out active);
		}

		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return FMOD5_Geometry_SetRotation(rawPtr, ref forward, ref up);
		}

		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return FMOD5_Geometry_GetRotation(rawPtr, out forward, out up);
		}

		public RESULT setPosition(ref VECTOR position)
		{
			return FMOD5_Geometry_SetPosition(rawPtr, ref position);
		}

		public RESULT getPosition(out VECTOR position)
		{
			return FMOD5_Geometry_GetPosition(rawPtr, out position);
		}

		public RESULT setScale(ref VECTOR scale)
		{
			return FMOD5_Geometry_SetScale(rawPtr, ref scale);
		}

		public RESULT getScale(out VECTOR scale)
		{
			return FMOD5_Geometry_GetScale(rawPtr, out scale);
		}

		public RESULT save(IntPtr data, out int datasize)
		{
			return FMOD5_Geometry_Save(rawPtr, data, out datasize);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_Geometry_SetUserData(rawPtr, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_Geometry_GetUserData(rawPtr, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);
	}
	public class Reverb3D : HandleBase
	{
		public Reverb3D(IntPtr raw)
			: base(raw)
		{
		}

		public RESULT release()
		{
			RESULT rESULT = FMOD5_Reverb3D_Release(getRaw());
			if (rESULT == RESULT.OK)
			{
				rawPtr = IntPtr.Zero;
			}
			return rESULT;
		}

		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return FMOD5_Reverb3D_Set3DAttributes(rawPtr, ref position, mindistance, maxdistance);
		}

		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return FMOD5_Reverb3D_Get3DAttributes(rawPtr, ref position, ref mindistance, ref maxdistance);
		}

		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return FMOD5_Reverb3D_SetProperties(rawPtr, ref properties);
		}

		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return FMOD5_Reverb3D_GetProperties(rawPtr, ref properties);
		}

		public RESULT setActive(bool active)
		{
			return FMOD5_Reverb3D_SetActive(rawPtr, active);
		}

		public RESULT getActive(out bool active)
		{
			return FMOD5_Reverb3D_GetActive(rawPtr, out active);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD5_Reverb3D_SetUserData(rawPtr, userdata);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD5_Reverb3D_GetUserData(rawPtr, out userdata);
		}

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb, ref VECTOR position, float mindistance, float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb, ref REVERB_PROPERTIES properties);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb, ref REVERB_PROPERTIES properties);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb, bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb, out bool active);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb, IntPtr userdata);

		[DllImport("fmod")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb, out IntPtr userdata);
	}
	internal class StringMarshalHelper
	{
		internal static void NativeToBuilder(StringBuilder builder, IntPtr nativeMem)
		{
			byte[] array = new byte[builder.Capacity];
			Marshal.Copy(nativeMem, array, 0, builder.Capacity);
			int num = Array.IndexOf(array, (byte)0);
			if (num > 0)
			{
				string @string = Encoding.UTF8.GetString(array, 0, num);
				builder.Append(@string);
			}
		}
	}
	public struct DSP_BUFFER_ARRAY
	{
		public int numbuffers;

		public int[] buffernumchannels;

		public CHANNELMASK[] bufferchannelmask;

		public IntPtr[] buffers;

		public SPEAKERMODE speakermode;
	}
	public enum DSP_PROCESS_OPERATION
	{
		PROCESS_PERFORM,
		PROCESS_QUERY
	}
	public struct COMPLEX
	{
		public float real;

		public float imag;
	}
	public enum DSP_PAN_SURROUND_FLAGS
	{
		DEFAULT,
		ROTATION_NOT_BIASED
	}
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	public enum DSP_TYPE
	{
		UNKNOWN,
		MIXER,
		OSCILLATOR,
		LOWPASS,
		ITLOWPASS,
		HIGHPASS,
		ECHO,
		FADER,
		FLANGE,
		DISTORTION,
		NORMALIZE,
		LIMITER,
		PARAMEQ,
		PITCHSHIFT,
		CHORUS,
		VSTPLUGIN,
		WINAMPPLUGIN,
		ITECHO,
		COMPRESSOR,
		SFXREVERB,
		LOWPASS_SIMPLE,
		DELAY,
		TREMOLO,
		LADSPAPLUGIN,
		SEND,
		RETURN,
		HIGHPASS_SIMPLE,
		PAN,
		THREE_EQ,
		FFT,
		LOUDNESS_METER,
		ENVELOPEFOLLOWER,
		CONVOLUTIONREVERB,
		CHANNELMIX,
		TRANSCEIVER,
		OBJECTPAN,
		MULTIBAND_EQ
	}
	public enum DSP_PARAMETER_TYPE
	{
		FLOAT,
		INT,
		BOOL,
		DATA
	}
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		public int numpoints;

		public IntPtr pointparamvalues;

		public IntPtr pointpositions;
	}
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		public float min;

		public float max;

		public float defaultval;

		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	public struct DSP_PARAMETER_DESC_INT
	{
		public int min;

		public int max;

		public int defaultval;

		public bool goestoinf;

		public IntPtr valuenames;
	}
	public struct DSP_PARAMETER_DESC_BOOL
	{
		public bool defaultval;

		public IntPtr valuenames;
	}
	public struct DSP_PARAMETER_DESC_DATA
	{
		public int datatype;
	}
	[StructLayout(LayoutKind.Explicit)]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[FieldOffset(0)]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[FieldOffset(0)]
		public DSP_PARAMETER_DESC_INT intdesc;

		[FieldOffset(0)]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[FieldOffset(0)]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	public struct DSP_PARAMETER_DESC
	{
		public DSP_PARAMETER_TYPE type;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] name;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public char[] label;

		public string description;

		public DSP_PARAMETER_DESC_UNION desc;
	}
	public enum DSP_PARAMETER_DATA_TYPE
	{
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		public float linear_gain;

		public float linear_gain_additive;
	}
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		public ATTRIBUTES_3D relative;

		public ATTRIBUTES_3D absolute;
	}
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		public int numlisteners;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public ATTRIBUTES_3D[] relative;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public float[] weight;

		public ATTRIBUTES_3D absolute;
	}
	public struct DSP_PARAMETER_SIDECHAIN
	{
		public int sidechainenable;
	}
	public struct DSP_PARAMETER_FFT
	{
		public int length;

		public int numchannels;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private IntPtr[] spectrum_internal;

		public float[][] spectrum
		{
			get
			{
				float[][] array = new float[numchannels][];
				for (int i = 0; i < numchannels; i++)
				{
					array[i] = new float[length];
					Marshal.Copy(spectrum_internal[i], array[i], 0, length);
				}
				return array;
			}
		}
	}
	public struct DSP_DESCRIPTION
	{
		public uint pluginsdkversion;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public char[] name;

		public uint version;

		public int numinputbuffers;

		public int numoutputbuffers;

		public DSP_CREATECALLBACK create;

		public DSP_RELEASECALLBACK release;

		public DSP_RESETCALLBACK reset;

		public DSP_READCALLBACK read;

		public DSP_PROCESS_CALLBACK process;

		public DSP_SETPOSITIONCALLBACK setposition;

		public int numparameters;

		public IntPtr paramdesc;

		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		public IntPtr userdata;

		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		public DSP_DFT_FFTREAL_FUNC fftreal;

		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	public struct DSP_STATE_FUNCTIONS
	{
		private DSP_ALLOC_FUNC alloc;

		private DSP_REALLOC_FUNC realloc;

		private DSP_FREE_FUNC free;

		private DSP_GETSAMPLERATE_FUNC getsamplerate;

		private DSP_GETBLOCKSIZE_FUNC getblocksize;

		private IntPtr dft;

		private IntPtr pan;

		private DSP_GETSPEAKERMODE_FUNC getspeakermode;

		private DSP_GETCLOCK_FUNC getclock;

		private DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		private DSP_LOG_FUNC log;

		private DSP_GETUSERDATA_FUNC getuserdata;
	}
	public struct DSP_STATE
	{
		public IntPtr instance;

		public IntPtr plugindata;

		public uint channelmask;

		public int source_speakermode;

		public IntPtr sidechaindata;

		public int sidechainchannels;

		public IntPtr functions;

		public int systemobject;
	}
	[StructLayout(LayoutKind.Sequential)]
	public class DSP_METERING_INFO
	{
		public int numsamples;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public float[] peaklevel;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public float[] rmslevel;

		public short numchannels;
	}
	public enum DSP_OSCILLATOR
	{
		TYPE,
		RATE
	}
	public enum DSP_LOWPASS
	{
		CUTOFF,
		RESONANCE
	}
	public enum DSP_ITLOWPASS
	{
		CUTOFF,
		RESONANCE
	}
	public enum DSP_HIGHPASS
	{
		CUTOFF,
		RESONANCE
	}
	public enum DSP_ECHO
	{
		DELAY,
		FEEDBACK,
		DRYLEVEL,
		WETLEVEL
	}
	public enum DSP_DELAY
	{
		CH0,
		CH1,
		CH2,
		CH3,
		CH4,
		CH5,
		CH6,
		CH7,
		CH8,
		CH9,
		CH10,
		CH11,
		CH12,
		CH13,
		CH14,
		CH15,
		MAXDELAY
	}
	public enum DSP_FLANGE
	{
		MIX,
		DEPTH,
		RATE
	}
	public enum DSP_TREMOLO
	{
		FREQUENCY,
		DEPTH,
		SHAPE,
		SKEW,
		DUTY,
		SQUARE,
		PHASE,
		SPREAD
	}
	public enum DSP_DISTORTION
	{
		LEVEL
	}
	public enum DSP_NORMALIZE
	{
		FADETIME,
		THRESHHOLD,
		MAXAMP
	}
	public enum DSP_LIMITER
	{
		RELEASETIME,
		CEILING,
		MAXIMIZERGAIN,
		MODE
	}
	public enum DSP_PARAMEQ
	{
		CENTER,
		BANDWIDTH,
		GAIN
	}
	public enum DSP_MULTIBAND_EQ
	{
		A_FILTER,
		A_FREQUENCY,
		A_Q,
		A_GAIN,
		B_FILTER,
		B_FREQUENCY,
		B_Q,
		B_GAIN,
		C_FILTER,
		C_FREQUENCY,
		C_Q,
		C_GAIN,
		D_FILTER,
		D_FREQUENCY,
		D_Q,
		D_GAIN,
		E_FILTER,
		E_FREQUENCY,
		E_Q,
		E_GAIN
	}
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		DISABLED,
		LOWPASS_12DB,
		LOWPASS_24DB,
		LOWPASS_48DB,
		HIGHPASS_12DB,
		HIGHPASS_24DB,
		HIGHPASS_48DB,
		LOWSHELF,
		HIGHSHELF,
		PEAKING,
		BANDPASS,
		NOTCH,
		ALLPASS
	}
	public enum DSP_PITCHSHIFT
	{
		PITCH,
		FFTSIZE,
		OVERLAP,
		MAXCHANNELS
	}
	public enum DSP_CHORUS
	{
		MIX,
		RATE,
		DEPTH
	}
	public enum DSP_ITECHO
	{
		WETDRYMIX,
		FEEDBACK,
		LEFTDELAY,
		RIGHTDELAY,
		PANDELAY
	}
	public enum DSP_COMPRESSOR
	{
		THRESHOLD,
		RATIO,
		ATTACK,
		RELEASE,
		GAINMAKEUP,
		USESIDECHAIN,
		LINKED
	}
	public enum DSP_SFXREVERB
	{
		DECAYTIME,
		EARLYDELAY,
		LATEDELAY,
		HFREFERENCE,
		HFDECAYRATIO,
		DIFFUSION,
		DENSITY,
		LOWSHELFFREQUENCY,
		LOWSHELFGAIN,
		HIGHCUT,
		EARLYLATEMIX,
		WETLEVEL,
		DRYLEVEL
	}
	public enum DSP_LOWPASS_SIMPLE
	{
		CUTOFF
	}
	public enum DSP_SEND
	{
		RETURNID,
		LEVEL
	}
	public enum DSP_RETURN
	{
		ID,
		INPUT_SPEAKER_MODE
	}
	public enum DSP_HIGHPASS_SIMPLE
	{
		CUTOFF
	}
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		DISTRIBUTED,
		DISCRETE
	}
	public enum DSP_PAN_MODE_TYPE
	{
		MONO,
		STEREO,
		SURROUND
	}
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		LINEARSQUARED,
		LINEAR,
		INVERSE,
		INVERSETAPERED,
		CUSTOM
	}
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		AUTO,
		USER,
		OFF
	}
	public enum DSP_PAN
	{
		MODE,
		_2D_STEREO_POSITION,
		_2D_DIRECTION,
		_2D_EXTENT,
		_2D_ROTATION,
		_2D_LFE_LEVEL,
		_2D_STEREO_MODE,
		_2D_STEREO_SEPARATION,
		_2D_STEREO_AXIS,
		ENABLED_SPEAKERS,
		_3D_POSITION,
		_3D_ROLLOFF,
		_3D_MIN_DISTANCE,
		_3D_MAX_DISTANCE,
		_3D_EXTENT_MODE,
		_3D_SOUND_SIZE,
		_3D_MIN_EXTENT,
		_3D_PAN_BLEND,
		LFE_UPMIX_ENABLED,
		OVERALL_GAIN,
		SURROUND_SPEAKER_MODE
	}
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		_12DB,
		_24DB,
		_48DB
	}
	public enum DSP_THREE_EQ
	{
		LOWGAIN,
		MIDGAIN,
		HIGHGAIN,
		LOWCROSSOVER,
		HIGHCROSSOVER,
		CROSSOVERSLOPE
	}
	public enum DSP_FFT_WINDOW
	{
		RECT,
		TRIANGLE,
		HAMMING,
		HANNING,
		BLACKMAN,
		BLACKMANHARRIS
	}
	public enum DSP_FFT
	{
		WINDOWSIZE,
		WINDOWTYPE,
		SPECTRUMDATA,
		DOMINANT_FREQ
	}
	public enum DSP_ENVELOPEFOLLOWER
	{
		ATTACK,
		RELEASE,
		ENVELOPE,
		USESIDECHAIN
	}
	public enum DSP_CONVOLUTION_REVERB
	{
		IR,
		WET,
		DRY,
		LINKED
	}
	public enum DSP_CHANNELMIX_OUTPUT
	{
		DEFAULT,
		ALLMONO,
		ALLSTEREO,
		ALLQUAD,
		ALL5POINT1,
		ALL7POINT1,
		ALLLFE
	}
	public enum DSP_CHANNELMIX
	{
		OUTPUTGROUPING,
		GAIN_CH0,
		GAIN_CH1,
		GAIN_CH2,
		GAIN_CH3,
		GAIN_CH4,
		GAIN_CH5,
		GAIN_CH6,
		GAIN_CH7,
		GAIN_CH8,
		GAIN_CH9,
		GAIN_CH10,
		GAIN_CH11,
		GAIN_CH12,
		GAIN_CH13,
		GAIN_CH14,
		GAIN_CH15,
		GAIN_CH16,
		GAIN_CH17,
		GAIN_CH18,
		GAIN_CH19,
		GAIN_CH20,
		GAIN_CH21,
		GAIN_CH22,
		GAIN_CH23,
		GAIN_CH24,
		GAIN_CH25,
		GAIN_CH26,
		GAIN_CH27,
		GAIN_CH28,
		GAIN_CH29,
		GAIN_CH30,
		GAIN_CH31
	}
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		AUTO = -1,
		MONO,
		STEREO,
		SURROUND
	}
	public enum DSP_TRANSCEIVER
	{
		TRANSMIT,
		GAIN,
		CHANNEL,
		TRANSMITSPEAKERMODE
	}
	public enum DSP_OBJECTPAN
	{
		_3D_POSITION,
		_3D_ROLLOFF,
		_3D_MIN_DISTANCE,
		_3D_MAX_DISTANCE,
		_3D_EXTENT_MODE,
		_3D_SOUND_SIZE,
		_3D_MIN_EXTENT,
		OVERALL_GAIN,
		OUTPUTGAIN
	}
	public class Error
	{
		public static string String(RESULT errcode)
		{
			return errcode switch
			{
				RESULT.OK => "No errors.", 
				RESULT.ERR_BADCOMMAND => "Tried to call a function on a data type that does not allow this type of functionality (ie calling Sound::lock on a streaming sound).", 
				RESULT.ERR_CHANNEL_ALLOC => "Error trying to allocate a channel.", 
				RESULT.ERR_CHANNEL_STOLEN => "The specified channel has been reused to play another sound.", 
				RESULT.ERR_DMA => "DMA Failure.  See debug output for more information.", 
				RESULT.ERR_DSP_CONNECTION => "DSP connection error.  Connection possibly caused a cyclic dependency or connected dsps with incompatible buffer counts.", 
				RESULT.ERR_DSP_DONTPROCESS => "DSP return code from a DSP process query callback.  Tells mixer not to call the process callback and therefore not consume CPU.  Use this to optimize the DSP graph.", 
				RESULT.ERR_DSP_FORMAT => "DSP Format error.  A DSP unit may have attempted to connect to this network with the wrong format, or a matrix may have been set with the wrong size if the target unit has a specified channel map.", 
				RESULT.ERR_DSP_INUSE => "DSP is already in the mixer's DSP network. It must be removed before being reinserted or released.", 
				RESULT.ERR_DSP_NOTFOUND => "DSP connection error.  Couldn't find the DSP unit specified.", 
				RESULT.ERR_DSP_RESERVED => "DSP operation error.  Cannot perform operation on this DSP as it is reserved by the system.", 
				RESULT.ERR_DSP_SILENCE => "DSP return code from a DSP process query callback.  Tells mixer silence would be produced from read, so go idle and not consume CPU.  Use this to optimize the DSP graph.", 
				RESULT.ERR_DSP_TYPE => "DSP operation cannot be performed on a DSP of this type.", 
				RESULT.ERR_FILE_BAD => "Error loading file.", 
				RESULT.ERR_FILE_COULDNOTSEEK => "Couldn't perform seek operation.  This is a limitation of the medium (ie netstreams) or the file format.", 
				RESULT.ERR_FILE_DISKEJECTED => "Media was ejected while reading.", 
				RESULT.ERR_FILE_EOF => "End of file unexpectedly reached while trying to read essential data (truncated?).", 
				RESULT.ERR_FILE_ENDOFDATA => "End of current chunk reached while trying to read data.", 
				RESULT.ERR_FILE_NOTFOUND => "File not found.", 
				RESULT.ERR_FORMAT => "Unsupported file or audio format.", 
				RESULT.ERR_HEADER_MISMATCH => "There is a version mismatch between the FMOD header and either the FMOD Studio library or the FMOD Low Level library.", 
				RESULT.ERR_HTTP => "A HTTP error occurred. This is a catch-all for HTTP errors not listed elsewhere.", 
				RESULT.ERR_HTTP_ACCESS => "The specified resource requires authentication or is forbidden.", 
				RESULT.ERR_HTTP_PROXY_AUTH => "Proxy authentication is required to access the specified resource.", 
				RESULT.ERR_HTTP_SERVER_ERROR => "A HTTP server error occurred.", 
				RESULT.ERR_HTTP_TIMEOUT => "The HTTP request timed out.", 
				RESULT.ERR_INITIALIZATION => "FMOD was not initialized correctly to support this function.", 
				RESULT.ERR_INITIALIZED => "Cannot call this command after System::init.", 
				RESULT.ERR_INTERNAL => "An error occurred that wasn't supposed to.  Contact support.", 
				RESULT.ERR_INVALID_FLOAT => "Value passed in was a NaN, Inf or denormalized float.", 
				RESULT.ERR_INVALID_HANDLE => "An invalid object handle was used.", 
				RESULT.ERR_INVALID_PARAM => "An invalid parameter was passed to this function.", 
				RESULT.ERR_INVALID_POSITION => "An invalid seek position was passed to this function.", 
				RESULT.ERR_INVALID_SPEAKER => "An invalid speaker was passed to this function based on the current speaker mode.", 
				RESULT.ERR_INVALID_SYNCPOINT => "The syncpoint did not come from this sound handle.", 
				RESULT.ERR_INVALID_THREAD => "Tried to call a function on a thread that is not supported.", 
				RESULT.ERR_INVALID_VECTOR => "The vectors passed in are not unit length, or perpendicular.", 
				RESULT.ERR_MAXAUDIBLE => "Reached maximum audible playback count for this sound's soundgroup.", 
				RESULT.ERR_MEMORY => "Not enough memory or resources.", 
				RESULT.ERR_MEMORY_CANTPOINT => "Can't use FMOD_OPENMEMORY_POINT on non PCM source data, or non mp3/xma/adpcm data if FMOD_CREATECOMPRESSEDSAMPLE was used.", 
				RESULT.ERR_NEEDS3D => "Tried to call a command on a 2d sound when the command was meant for 3d sound.", 
				RESULT.ERR_NEEDSHARDWARE => "Tried to use a feature that requires hardware support.", 
				RESULT.ERR_NET_CONNECT => "Couldn't connect to the specified host.", 
				RESULT.ERR_NET_SOCKET_ERROR => "A socket error occurred.  This is a catch-all for socket-related errors not listed elsewhere.", 
				RESULT.ERR_NET_URL => "The specified URL couldn't be resolved.", 
				RESULT.ERR_NET_WOULD_BLOCK => "Operation on a non-blocking socket could not complete immediately.", 
				RESULT.ERR_NOTREADY => "Operation could not be performed because specified sound/DSP connection is not ready.", 
				RESULT.ERR_OUTPUT_ALLOCATED => "Error initializing output device, but more specifically, the output device is already in use and cannot be reused.", 
				RESULT.ERR_OUTPUT_CREATEBUFFER => "Error creating hardware sound buffer.", 
				RESULT.ERR_OUTPUT_DRIVERCALL => "A call to a standard soundcard driver failed, which could possibly mean a bug in the driver or resources were missing or exhausted.", 
				RESULT.ERR_OUTPUT_FORMAT => "Soundcard does not support the specified format.", 
				RESULT.ERR_OUTPUT_INIT => "Error initializing output device.", 
				RESULT.ERR_OUTPUT_NODRIVERS => "The output device has no drivers installed.  If pre-init, FMOD_OUTPUT_NOSOUND is selected as the output mode.  If post-init, the function just fails.", 
				RESULT.ERR_PLUGIN => "An unspecified error has been returned from a plugin.", 
				RESULT.ERR_PLUGIN_MISSING => "A requested output, dsp unit type or codec was not available.", 
				RESULT.ERR_PLUGIN_RESOURCE => "A resource that the plugin requires cannot be found. (ie the DLS file for MIDI playback)", 
				RESULT.ERR_PLUGIN_VERSION => "A plugin was built with an unsupported SDK version.", 
				RESULT.ERR_RECORD => "An error occurred trying to initialize the recording device.", 
				RESULT.ERR_REVERB_CHANNELGROUP => "Reverb properties cannot be set on this channel because a parent channelgroup owns the reverb connection.", 
				RESULT.ERR_REVERB_INSTANCE => "Specified instance in FMOD_REVERB_PROPERTIES couldn't be set. Most likely because it is an invalid instance number or the reverb doesn't exist.", 
				RESULT.ERR_SUBSOUNDS => "The error occurred because the sound referenced contains subsounds when it shouldn't have, or it doesn't contain subsounds when it should have.  The operation may also not be able to be performed on a parent sound.", 
				RESULT.ERR_SUBSOUND_ALLOCATED => "This subsound is already being used by another sound, you cannot have more than one parent to a sound.  Null out the other parent's entry first.", 
				RESULT.ERR_SUBSOUND_CANTMOVE => "Shared subsounds cannot be replaced or moved from their parent stream, such as when the parent stream is an FSB file.", 
				RESULT.ERR_TAGNOTFOUND => "The specified tag could not be found or there are no tags.", 
				RESULT.ERR_TOOMANYCHANNELS => "The sound created exceeds the allowable input channel count.  This can be increased using the 'maxinputchannels' parameter in System::setSoftwareFormat.", 
				RESULT.ERR_TRUNCATED => "The retrieved string is too long to fit in the supplied buffer and has been truncated.", 
				RESULT.ERR_UNIMPLEMENTED => "Something in FMOD hasn't been implemented when it should be! contact support!", 
				RESULT.ERR_UNINITIALIZED => "This command failed because System::init or System::setDriver was not called.", 
				RESULT.ERR_UNSUPPORTED => "A command issued was not supported by this object.  Possibly a plugin without certain callbacks specified.", 
				RESULT.ERR_VERSION => "The version number of this file format is not supported.", 
				RESULT.ERR_EVENT_ALREADY_LOADED => "The specified bank has already been loaded.", 
				RESULT.ERR_EVENT_LIVEUPDATE_BUSY => "The live update connection failed due to the game already being connected.", 
				RESULT.ERR_EVENT_LIVEUPDATE_MISMATCH => "The live update connection failed due to the game data being out of sync with the tool.", 
				RESULT.ERR_EVENT_LIVEUPDATE_TIMEOUT => "The live update connection timed out.", 
				RESULT.ERR_EVENT_NOTFOUND => "The requested event, bus or vca could not be found.", 
				RESULT.ERR_STUDIO_UNINITIALIZED => "The Studio::System object is not yet initialized.", 
				RESULT.ERR_STUDIO_NOT_LOADED => "The specified resource is not loaded, so it can't be unloaded.", 
				RESULT.ERR_INVALID_STRING => "An invalid string was passed to this function.", 
				RESULT.ERR_ALREADY_LOCKED => "The specified resource is already locked.", 
				RESULT.ERR_NOT_LOCKED => "The specified resource is not locked, so it can't be unlocked.", 
				RESULT.ERR_RECORD_DISCONNECTED => "The specified recording driver has been disconnected.", 
				RESULT.ERR_TOOMANYSAMPLES => "The length provided exceed the allowable limit.", 
				_ => "Unknown error.", 
			};
		}
	}
}
namespace FMOD.Studio
{
	public class STUDIO_VERSION
	{
		public const string dll = "fmodstudio";
	}
	public enum STOP_MODE
	{
		ALLOWFADEOUT,
		IMMEDIATE
	}
	public enum LOADING_STATE
	{
		UNLOADING,
		UNLOADED,
		LOADING,
		LOADED,
		ERROR
	}
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		public StringWrapper name;

		public IntPtr sound;

		public int subsoundIndex;
	}
	public struct TIMELINE_MARKER_PROPERTIES
	{
		public StringWrapper name;

		public int position;
	}
	public struct TIMELINE_BEAT_PROPERTIES
	{
		public int bar;

		public int beat;

		public int position;

		public float tempo;

		public int timesignatureupper;

		public int timesignaturelower;
	}
	public struct ADVANCEDSETTINGS
	{
		public int cbsize;

		public int commandqueuesize;

		public int handleinitialsize;

		public int studioupdateperiod;

		public int idlesampledatapoolsize;
	}
	public struct CPU_USAGE
	{
		public float dspusage;

		public float streamusage;

		public float geometryusage;

		public float updateusage;

		public float studiousage;
	}
	public struct BUFFER_INFO
	{
		public int currentusage;

		public int peakusage;

		public int capacity;

		public int stallcount;

		public float stalltime;
	}
	public struct BUFFER_USAGE
	{
		public BUFFER_INFO studiocommandqueue;

		public BUFFER_INFO studiohandle;
	}
	public struct BANK_INFO
	{
		public int size;

		public IntPtr userdata;

		public int userdatalength;

		public FILE_OPENCALLBACK opencallback;

		public FILE_CLOSECALLBACK closecallback;

		public FILE_READCALLBACK readcallback;

		public FILE_SEEKCALLBACK seekcallback;
	}
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		PREUPDATE = 1u,
		POSTUPDATE = 2u,
		BANK_UNLOAD = 4u,
		ALL = uint.MaxValue
	}
	public delegate RESULT SYSTEM_CALLBACK(IntPtr systemraw, SYSTEM_CALLBACK_TYPE type, IntPtr parameters, IntPtr userdata);
	public enum PARAMETER_TYPE
	{
		GAME_CONTROLLED,
		AUTOMATIC_DISTANCE,
		AUTOMATIC_EVENT_CONE_ANGLE,
		AUTOMATIC_EVENT_ORIENTATION,
		AUTOMATIC_DIRECTION,
		AUTOMATIC_ELEVATION,
		AUTOMATIC_LISTENER_ORIENTATION
	}
	public struct PARAMETER_DESCRIPTION
	{
		public string name;

		public int index;

		public float minimum;

		public float maximum;

		public float defaultvalue;

		public PARAMETER_TYPE type;
	}
	internal struct PARAMETER_DESCRIPTION_INTERNAL
	{
		public IntPtr name;

		public int index;

		public float minimum;

		public float maximum;

		public float defaultvalue;

		public PARAMETER_TYPE type;

		public void assign(out PARAMETER_DESCRIPTION publicDesc)
		{
			publicDesc.name = MarshallingHelper.stringFromNativeUtf8(name);
			publicDesc.index = index;
			publicDesc.minimum = minimum;
			publicDesc.maximum = maximum;
			publicDesc.defaultvalue = defaultvalue;
			publicDesc.type = type;
		}
	}
	internal enum LOAD_MEMORY_MODE
	{
		LOAD_MEMORY,
		LOAD_MEMORY_POINT
	}
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		VALUE = 0x20
	}
	public class SOUND_INFO
	{
		public byte[] name_or_data;

		public MODE mode;

		public CREATESOUNDEXINFO exinfo;

		public int subsoundindex;

		public string name
		{
			get
			{
				if ((mode & (MODE.OPENMEMORY | MODE.OPENMEMORY_POINT)) == 0 && name_or_data != null)
				{
					int num = Array.IndexOf(name_or_data, (byte)0);
					if (num > 0)
					{
						return Encoding.UTF8.GetString(name_or_data, 0, num);
					}
					return null;
				}
				return null;
			}
		}

		~SOUND_INFO()
		{
			if (exinfo.inclusionlist != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(exinfo.inclusionlist);
			}
		}
	}
	public struct SOUND_INFO_INTERNAL
	{
		private IntPtr name_or_data;

		private MODE mode;

		private CREATESOUNDEXINFO_INTERNAL exinfo;

		private int subsoundindex;

		public void assign(out SOUND_INFO publicInfo)
		{
			publicInfo = new SOUND_INFO();
			publicInfo.mode = mode;
			publicInfo.exinfo = CREATESOUNDEXINFO_INTERNAL.CreateFromInternal(ref exinfo);
			publicInfo.exinfo.inclusionlist = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(int)));
			Marshal.WriteInt32(publicInfo.exinfo.inclusionlist, subsoundindex);
			publicInfo.exinfo.inclusionlistnum = 1;
			publicInfo.subsoundindex = subsoundindex;
			if (name_or_data != IntPtr.Zero)
			{
				int num;
				int num2;
				if ((mode & (MODE.OPENMEMORY | MODE.OPENMEMORY_POINT)) != 0)
				{
					publicInfo.mode = (publicInfo.mode & ~MODE.OPENMEMORY_POINT) | MODE.OPENMEMORY;
					num = (int)exinfo.fileoffset;
					publicInfo.exinfo.fileoffset = 0u;
					num2 = (int)exinfo.length;
				}
				else
				{
					num = 0;
					num2 = MarshallingHelper.stringLengthUtf8(name_or_data) + 1;
				}
				publicInfo.name_or_data = new byte[num2];
				Marshal.Copy(new IntPtr(name_or_data.ToInt64() + num), publicInfo.name_or_data, 0, num2);
			}
			else
			{
				publicInfo.name_or_data = null;
			}
		}
	}
	public enum USER_PROPERTY_TYPE
	{
		INTEGER,
		BOOLEAN,
		FLOAT,
		STRING
	}
	public struct USER_PROPERTY
	{
		public string name;

		public USER_PROPERTY_TYPE type;

		public int intvalue;

		public bool boolvalue;

		public float floatvalue;

		public string stringvalue;
	}
	internal struct USER_PROPERTY_INTERNAL
	{
		private IntPtr name;

		private USER_PROPERTY_TYPE type;

		private Union_IntBoolFloatString value;

		public USER_PROPERTY createPublic()
		{
			USER_PROPERTY result = default(USER_PROPERTY);
			result.name = MarshallingHelper.stringFromNativeUtf8(name);
			result.type = type;
			switch (type)
			{
			case USER_PROPERTY_TYPE.INTEGER:
				result.intvalue = value.intvalue;
				break;
			case USER_PROPERTY_TYPE.BOOLEAN:
				result.boolvalue = value.boolvalue;
				break;
			case USER_PROPERTY_TYPE.FLOAT:
				result.floatvalue = value.floatvalue;
				break;
			case USER_PROPERTY_TYPE.STRING:
				result.stringvalue = MarshallingHelper.stringFromNativeUtf8(value.stringvalue);
				break;
			}
			return result;
		}
	}
	internal struct COMMAND_INFO_INTERNAL
	{
		public IntPtr commandname;

		public int parentcommandindex;

		public int framenumber;

		public float frametime;

		public INSTANCETYPE instancetype;

		public INSTANCETYPE outputtype;

		public uint instancehandle;

		public uint outputhandle;

		public COMMAND_INFO createPublic()
		{
			COMMAND_INFO result = default(COMMAND_INFO);
			result.commandname = MarshallingHelper.stringFromNativeUtf8(commandname);
			result.parentcommandindex = parentcommandindex;
			result.framenumber = framenumber;
			result.frametime = frametime;
			result.instancetype = instancetype;
			result.outputtype = outputtype;
			result.instancehandle = instancehandle;
			result.outputhandle = outputhandle;
			return result;
		}
	}
	[StructLayout(LayoutKind.Explicit)]
	internal struct Union_IntBoolFloatString
	{
		[FieldOffset(0)]
		public int intvalue;

		[FieldOffset(0)]
		public bool boolvalue;

		[FieldOffset(0)]
		public float floatvalue;

		[FieldOffset(0)]
		public IntPtr stringvalue;
	}
	[Flags]
	public enum INITFLAGS : uint
	{
		NORMAL = 0u,
		LIVEUPDATE = 1u,
		ALLOW_MISSING_PLUGINS = 2u,
		SYNCHRONOUS_UPDATE = 4u,
		DEFERRED_CALLBACKS = 8u,
		LOAD_FROM_UPDATE = 0x10u
	}
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		NORMAL = 0u,
		NONBLOCKING = 1u,
		DECOMPRESS_SAMPLES = 2u
	}
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		NORMAL = 0u,
		FILEFLUSH = 1u,
		SKIP_INITIAL_STATE = 2u
	}
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		NORMAL = 0u,
		SKIP_CLEANUP = 1u,
		FAST_FORWARD = 2u
	}
	public enum PLAYBACK_STATE
	{
		PLAYING,
		SUSTAINING,
		STOPPED,
		STARTING,
		STOPPING
	}
	public enum EVENT_PROPERTY
	{
		CHANNELPRIORITY,
		SCHEDULE_DELAY,
		SCHEDULE_LOOKAHEAD,
		MINIMUM_DISTANCE,
		MAXIMUM_DISTANCE
	}
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		public IntPtr name;

		public IntPtr dsp;
	}
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		CREATED = 1u,
		DESTROYED = 2u,
		STARTING = 4u,
		STARTED = 8u,
		RESTARTED = 0x10u,
		STOPPED = 0x20u,
		START_FAILED = 0x40u,
		CREATE_PROGRAMMER_SOUND = 0x80u,
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		PLUGIN_CREATED = 0x200u,
		PLUGIN_DESTROYED = 0x400u,
		TIMELINE_MARKER = 0x800u,
		TIMELINE_BEAT = 0x1000u,
		SOUND_PLAYED = 0x2000u,
		SOUND_STOPPED = 0x4000u,
		ALL = uint.MaxValue
	}
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, IntPtr eventInstance, IntPtr parameters);
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(IntPtr replay, int commandIndex, float currentTime, IntPtr userdata);
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(IntPtr replay, IntPtr guid, StringWrapper bankFilename, LOAD_BANK_FLAGS flags, out IntPtr bank, IntPtr userdata);
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(IntPtr replay, IntPtr eventDescription, IntPtr originalHandle, out IntPtr instance, IntPtr userdata);
	public enum INSTANCETYPE
	{
		NONE,
		SYSTEM,
		EVENTDESCRIPTION,
		EVENTINSTANCE,
		PARAMETERINSTANCE,
		BUS,
		VCA,
		BANK,
		COMMANDREPLAY
	}
	public struct COMMAND_INFO
	{
		public string commandname;

		public int parentcommandindex;

		public int framenumber;

		public float frametime;

		public INSTANCETYPE instancetype;

		public INSTANCETYPE outputtype;

		public uint instancehandle;

		public uint outputhandle;
	}
	public class Util
	{
		public static RESULT ParseID(string idString, out Guid id)
		{
			RESULT result = FMOD_Studio_ParseID(MarshallingHelper.StringAsBytes(idString), MarshallingHelper.rawguid);
			id = new Guid(MarshallingHelper.rawguid);
			return result;
		}

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, byte[] id);
	}
	public struct System
	{
		public IntPtr rawPtr;

		public System(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero && FMOD_Studio_System_IsValid(rawPtr);
		}

		public override bool Equals(object obj)
		{
			return obj is System && Equals((System)obj);
		}

		public bool Equals(System p)
		{
			return rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.GetHashCode();
		}

		public static bool operator ==(System a, System b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(System a, System b)
		{
			return !a.Equals(b);
		}

		public static RESULT create(out System studiosystem)
		{
			return FMOD_Studio_System_Create(out studiosystem.rawPtr, 67841u);
		}

		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			settings.cbsize = Marshal.SizeOf(typeof(ADVANCEDSETTINGS));
			return FMOD_Studio_System_SetAdvancedSettings(rawPtr, ref settings);
		}

		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			settings.cbsize = Marshal.SizeOf(typeof(ADVANCEDSETTINGS));
			return FMOD_Studio_System_GetAdvancedSettings(rawPtr, out settings);
		}

		public RESULT initialize(int maxchannels, INITFLAGS studioFlags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return FMOD_Studio_System_Initialize(rawPtr, maxchannels, studioFlags, flags, extradriverdata);
		}

		public RESULT release()
		{
			return FMOD_Studio_System_Release(rawPtr);
		}

		public RESULT update()
		{
			return FMOD_Studio_System_Update(rawPtr);
		}

		public RESULT getLowLevelSystem(out FMOD.System system)
		{
			system = null;
			IntPtr system2;
			RESULT rESULT = FMOD_Studio_System_GetLowLevelSystem(rawPtr, out system2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			system = new FMOD.System(system2);
			return rESULT;
		}

		public RESULT getEvent(string path, out EventDescription _event)
		{
			return FMOD_Studio_System_GetEvent(rawPtr, MarshallingHelper.StringAsBytes(path), out _event.rawPtr);
		}

		public RESULT getBus(string path, out Bus bus)
		{
			return FMOD_Studio_System_GetBus(rawPtr, MarshallingHelper.StringAsBytes(path), out bus.rawPtr);
		}

		public RESULT getVCA(string path, out VCA vca)
		{
			return FMOD_Studio_System_GetVCA(rawPtr, MarshallingHelper.StringAsBytes(path), out vca.rawPtr);
		}

		public RESULT getBank(string path, out Bank bank)
		{
			return FMOD_Studio_System_GetBank(rawPtr, MarshallingHelper.StringAsBytes(path), out bank.rawPtr);
		}

		public RESULT getEventByID(Guid guid, out EventDescription _event)
		{
			return FMOD_Studio_System_GetEventByID(rawPtr, MarshallingHelper.GuidAsBytes(guid), out _event.rawPtr);
		}

		public RESULT getBusByID(Guid guid, out Bus bus)
		{
			return FMOD_Studio_System_GetBusByID(rawPtr, MarshallingHelper.GuidAsBytes(guid), out bus.rawPtr);
		}

		public RESULT getVCAByID(Guid guid, out VCA vca)
		{
			return FMOD_Studio_System_GetVCAByID(rawPtr, MarshallingHelper.GuidAsBytes(guid), out vca.rawPtr);
		}

		public RESULT getBankByID(Guid guid, out Bank bank)
		{
			return FMOD_Studio_System_GetBankByID(rawPtr, MarshallingHelper.GuidAsBytes(guid), out bank.rawPtr);
		}

		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			int cb = Marshal.SizeOf(typeof(SOUND_INFO_INTERNAL));
			IntPtr intPtr = Marshal.AllocHGlobal(cb);
			RESULT rESULT = FMOD_Studio_System_GetSoundInfo(rawPtr, MarshallingHelper.StringAsBytes(key), intPtr);
			if (rESULT != 0)
			{
				Marshal.FreeHGlobal(intPtr);
				info = new SOUND_INFO();
				return rESULT;
			}
			((SOUND_INFO_INTERNAL)Marshal.PtrToStructure(intPtr, typeof(SOUND_INFO_INTERNAL))).assign(out info);
			Marshal.FreeHGlobal(intPtr);
			return rESULT;
		}

		public RESULT lookupID(string path, out Guid guid)
		{
			RESULT result = FMOD_Studio_System_LookupID(rawPtr, MarshallingHelper.StringAsBytes(path), MarshallingHelper.rawguid);
			guid = new Guid(MarshallingHelper.rawguid);
			return result;
		}

		public RESULT lookupPath(Guid guid, out string path)
		{
			path = null;
			byte[] tempBuffer = MarshallingHelper.GetTempBuffer();
			byte[] guid2 = MarshallingHelper.GuidAsBytes(guid);
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_System_LookupPath(rawPtr, guid2, tempBuffer, tempBuffer.Length, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				tempBuffer = MarshallingHelper.GetTempBuffer(retrieved);
				rESULT = FMOD_Studio_System_LookupPath(rawPtr, guid2, tempBuffer, tempBuffer.Length, out retrieved);
			}
			if (rESULT == RESULT.OK)
			{
				path = Encoding.UTF8.GetString(tempBuffer, 0, retrieved - 1);
			}
			return rESULT;
		}

		public RESULT getNumListeners(out int numlisteners)
		{
			return FMOD_Studio_System_GetNumListeners(rawPtr, out numlisteners);
		}

		public RESULT setNumListeners(int numlisteners)
		{
			return FMOD_Studio_System_SetNumListeners(rawPtr, numlisteners);
		}

		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return FMOD_Studio_System_GetListenerAttributes(rawPtr, listener, out attributes);
		}

		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return FMOD_Studio_System_SetListenerAttributes(rawPtr, listener, ref attributes);
		}

		public RESULT getListenerWeight(int listener, out float weight)
		{
			return FMOD_Studio_System_GetListenerWeight(rawPtr, listener, out weight);
		}

		public RESULT setListenerWeight(int listener, float weight)
		{
			return FMOD_Studio_System_SetListenerWeight(rawPtr, listener, weight);
		}

		public RESULT loadBankFile(string name, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return FMOD_Studio_System_LoadBankFile(rawPtr, MarshallingHelper.StringAsBytes(name), flags, out bank.rawPtr);
		}

		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
			IntPtr buffer2 = gCHandle.AddrOfPinnedObject();
			RESULT result = FMOD_Studio_System_LoadBankMemory(rawPtr, buffer2, buffer.Length, LOAD_MEMORY_MODE.LOAD_MEMORY, flags, out bank.rawPtr);
			gCHandle.Free();
			return result;
		}

		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			info.size = Marshal.SizeOf(info);
			return FMOD_Studio_System_LoadBankCustom(rawPtr, ref info, flags, out bank.rawPtr);
		}

		public RESULT unloadAll()
		{
			return FMOD_Studio_System_UnloadAll(rawPtr);
		}

		public RESULT flushCommands()
		{
			return FMOD_Studio_System_FlushCommands(rawPtr);
		}

		public RESULT flushSampleLoading()
		{
			return FMOD_Studio_System_FlushSampleLoading(rawPtr);
		}

		public RESULT startCommandCapture(string path, COMMANDCAPTURE_FLAGS flags)
		{
			return FMOD_Studio_System_StartCommandCapture(rawPtr, MarshallingHelper.StringAsBytes(path), flags);
		}

		public RESULT stopCommandCapture()
		{
			return FMOD_Studio_System_StopCommandCapture(rawPtr);
		}

		public RESULT loadCommandReplay(string path, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return FMOD_Studio_System_LoadCommandReplay(rawPtr, MarshallingHelper.StringAsBytes(path), flags, out replay.rawPtr);
		}

		public RESULT getBankCount(out int count)
		{
			return FMOD_Studio_System_GetBankCount(rawPtr, out count);
		}

		public RESULT getBankList(out Bank[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_System_GetBankCount(rawPtr, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new Bank[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_System_GetBankList(rawPtr, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new Bank[count2];
			for (int i = 0; i < count2; i++)
			{
				ref Bank reference = ref array[i];
				reference = new Bank(array2[i]);
			}
			return RESULT.OK;
		}

		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return FMOD_Studio_System_GetCPUUsage(rawPtr, out usage);
		}

		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return FMOD_Studio_System_GetBufferUsage(rawPtr, out usage);
		}

		public RESULT resetBufferUsage()
		{
			return FMOD_Studio_System_ResetBufferUsage(rawPtr);
		}

		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return FMOD_Studio_System_SetCallback(rawPtr, callback, callbackmask);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_System_GetUserData(rawPtr, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_System_SetUserData(rawPtr, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr studiosystem, uint headerversion);

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr studiosystem, ref ADVANCEDSETTINGS settings);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr studiosystem, out ADVANCEDSETTINGS settings);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr studiosystem, int maxchannels, INITFLAGS studioFlags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetLowLevelSystem(IntPtr studiosystem, out IntPtr system);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr studiosystem, byte[] path, out IntPtr description);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr studiosystem, byte[] path, out IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr studiosystem, byte[] path, out IntPtr vca);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr studiosystem, byte[] path, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr studiosystem, byte[] guid, out IntPtr description);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr studiosystem, byte[] guid, out IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr studiosystem, byte[] guid, out IntPtr vca);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr studiosystem, byte[] guid, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr studiosystem, byte[] key, IntPtr info);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr studiosystem, byte[] path, [Out] byte[] guid);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr studiosystem, byte[] guid, [Out] byte[] path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr studiosystem, out int numlisteners);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr studiosystem, int numlisteners);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr studiosystem, int listener, out ATTRIBUTES_3D attributes);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr studiosystem, int listener, ref ATTRIBUTES_3D attributes);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr studiosystem, int listener, out float weight);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr studiosystem, int listener, float weight);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr studiosystem, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr studiosystem, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr studiosystem, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr studiosystem, byte[] path, COMMANDCAPTURE_FLAGS flags);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr studiosystem, byte[] path, COMMANDREPLAY_FLAGS flags, out IntPtr commandReplay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr studiosystem, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr studiosystem, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr studiosystem, out CPU_USAGE usage);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr studiosystem, out BUFFER_USAGE usage);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr studiosystem);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr studiosystem, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr studiosystem, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr studiosystem, IntPtr userdata);
	}
	public struct EventDescription
	{
		public IntPtr rawPtr;

		public EventDescription(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero && FMOD_Studio_EventDescription_IsValid(rawPtr);
		}

		public override bool Equals(object obj)
		{
			return obj is EventDescription && Equals((EventDescription)obj);
		}

		public bool Equals(EventDescription p)
		{
			return rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.GetHashCode();
		}

		public static bool operator ==(EventDescription a, EventDescription b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(EventDescription a, EventDescription b)
		{
			return !a.Equals(b);
		}

		public RESULT getID(out Guid id)
		{
			RESULT result = FMOD_Studio_EventDescription_GetID(rawPtr, MarshallingHelper.rawguid);
			id = new Guid(MarshallingHelper.rawguid);
			return result;
		}

		public RESULT getPath(out string path)
		{
			byte[] tempBuffer = MarshallingHelper.GetTempBuffer();
			int retrieved;
			RESULT rESULT = FMOD_Studio_EventDescription_GetPath(rawPtr, tempBuffer, tempBuffer.Length, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				tempBuffer = MarshallingHelper.GetTempBuffer(retrieved);
				rESULT = FMOD_Studio_EventDescription_GetPath(rawPtr, tempBuffer, tempBuffer.Length, out retrieved);
			}
			path = ((rESULT != 0) ? null : Encoding.UTF8.GetString(tempBuffer, 0, retrieved - 1));
			return rESULT;
		}

		public RESULT getParameterCount(out int count)
		{
			return FMOD_Studio_EventDescription_GetParameterCount(rawPtr, out count);
		}

		public RESULT getParameterByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			PARAMETER_DESCRIPTION_INTERNAL parameter2;
			RESULT rESULT = FMOD_Studio_EventDescription_GetParameterByIndex(rawPtr, index, out parameter2);
			if (rESULT != 0)
			{
				parameter = default(PARAMETER_DESCRIPTION);
				return rESULT;
			}
			parameter2.assign(out parameter);
			return rESULT;
		}

		public RESULT getParameter(string name, out PARAMETER_DESCRIPTION parameter)
		{
			PARAMETER_DESCRIPTION_INTERNAL parameter2;
			RESULT rESULT = FMOD_Studio_EventDescription_GetParameter(rawPtr, MarshallingHelper.StringAsBytes(name), out parameter2);
			if (rESULT != 0)
			{
				parameter = default(PARAMETER_DESCRIPTION);
				return rESULT;
			}
			parameter2.assign(out parameter);
			return rESULT;
		}

		public RESULT getUserPropertyCount(out int count)
		{
			return FMOD_Studio_EventDescription_GetUserPropertyCount(rawPtr, out count);
		}

		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			USER_PROPERTY_INTERNAL property2;
			RESULT rESULT = FMOD_Studio_EventDescription_GetUserPropertyByIndex(rawPtr, index, out property2);
			if (rESULT != 0)
			{
				property = default(USER_PROPERTY);
				return rESULT;
			}
			property = property2.createPublic();
			return RESULT.OK;
		}

		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			USER_PROPERTY_INTERNAL property2;
			RESULT rESULT = FMOD_Studio_EventDescription_GetUserProperty(rawPtr, MarshallingHelper.StringAsBytes(name), out property2);
			if (rESULT != 0)
			{
				property = default(USER_PROPERTY);
				return rESULT;
			}
			property = property2.createPublic();
			return RESULT.OK;
		}

		public RESULT getLength(out int length)
		{
			return FMOD_Studio_EventDescription_GetLength(rawPtr, out length);
		}

		public RESULT getMinimumDistance(out float distance)
		{
			return FMOD_Studio_EventDescription_GetMinimumDistance(rawPtr, out distance);
		}

		public RESULT getMaximumDistance(out float distance)
		{
			return FMOD_Studio_EventDescription_GetMaximumDistance(rawPtr, out distance);
		}

		public RESULT getSoundSize(out float size)
		{
			return FMOD_Studio_EventDescription_GetSoundSize(rawPtr, out size);
		}

		public RESULT isSnapshot(out bool snapshot)
		{
			return FMOD_Studio_EventDescription_IsSnapshot(rawPtr, out snapshot);
		}

		public RESULT isOneshot(out bool oneshot)
		{
			return FMOD_Studio_EventDescription_IsOneshot(rawPtr, out oneshot);
		}

		public RESULT isStream(out bool isStream)
		{
			return FMOD_Studio_EventDescription_IsStream(rawPtr, out isStream);
		}

		public RESULT is3D(out bool is3D)
		{
			return FMOD_Studio_EventDescription_Is3D(rawPtr, out is3D);
		}

		public RESULT hasCue(out bool cue)
		{
			return FMOD_Studio_EventDescription_HasCue(rawPtr, out cue);
		}

		public RESULT createInstance(out EventInstance instance)
		{
			return FMOD_Studio_EventDescription_CreateInstance(rawPtr, out instance.rawPtr);
		}

		public RESULT getInstanceCount(out int count)
		{
			return FMOD_Studio_EventDescription_GetInstanceCount(rawPtr, out count);
		}

		public RESULT getInstanceList(out EventInstance[] array)
		{
			RESULT rESULT = FMOD_Studio_EventDescription_GetInstanceCount(rawPtr, out var count);
			if (rESULT != 0)
			{
				array = null;
				return rESULT;
			}
			if (count == 0)
			{
				array = new EventInstance[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_EventDescription_GetInstanceList(rawPtr, array2, count, out var count2);
			if (rESULT != 0)
			{
				array = null;
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new EventInstance[count2];
			for (int i = 0; i < count2; i++)
			{
				ref EventInstance reference = ref array[i];
				reference = new EventInstance(array2[i]);
			}
			return RESULT.OK;
		}

		public RESULT loadSampleData()
		{
			return FMOD_Studio_EventDescription_LoadSampleData(rawPtr);
		}

		public RESULT unloadSampleData()
		{
			return FMOD_Studio_EventDescription_UnloadSampleData(rawPtr);
		}

		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return FMOD_Studio_EventDescription_GetSampleLoadingState(rawPtr, out state);
		}

		public RESULT releaseAllInstances()
		{
			return FMOD_Studio_EventDescription_ReleaseAllInstances(rawPtr);
		}

		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return FMOD_Studio_EventDescription_SetCallback(rawPtr, callback, callbackmask);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_EventDescription_GetUserData(rawPtr, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_EventDescription_SetUserData(rawPtr, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, [Out] byte[] id);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, [Out] byte[] path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterCount(IntPtr eventdescription, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION_INTERNAL parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameter(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION_INTERNAL parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY_INTERNAL property);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY_INTERNAL property);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);
	}
	public struct EventInstance
	{
		public IntPtr rawPtr;

		public EventInstance(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero && FMOD_Studio_EventInstance_IsValid(rawPtr);
		}

		public override bool Equals(object obj)
		{
			return obj is EventInstance && Equals((EventInstance)obj);
		}

		public bool Equals(EventInstance p)
		{
			return rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.GetHashCode();
		}

		public static bool operator ==(EventInstance a, EventInstance b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(EventInstance a, EventInstance b)
		{
			return !a.Equals(b);
		}

		public RESULT getDescription(out EventDescription description)
		{
			return FMOD_Studio_EventInstance_GetDescription(rawPtr, out description.rawPtr);
		}

		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return FMOD_Studio_EventInstance_GetVolume(rawPtr, out volume, out finalvolume);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD_Studio_EventInstance_SetVolume(rawPtr, volume);
		}

		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return FMOD_Studio_EventInstance_GetPitch(rawPtr, out pitch, out finalpitch);
		}

		public RESULT setPitch(float pitch)
		{
			return FMOD_Studio_EventInstance_SetPitch(rawPtr, pitch);
		}

		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return FMOD_Studio_EventInstance_Get3DAttributes(rawPtr, out attributes);
		}

		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return FMOD_Studio_EventInstance_Set3DAttributes(rawPtr, ref attributes);
		}

		public RESULT getListenerMask(out uint mask)
		{
			return FMOD_Studio_EventInstance_GetListenerMask(rawPtr, out mask);
		}

		public RESULT setListenerMask(uint mask)
		{
			return FMOD_Studio_EventInstance_SetListenerMask(rawPtr, mask);
		}

		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return FMOD_Studio_EventInstance_GetProperty(rawPtr, index, out value);
		}

		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return FMOD_Studio_EventInstance_SetProperty(rawPtr, index, value);
		}

		public RESULT getReverbLevel(int index, out float level)
		{
			return FMOD_Studio_EventInstance_GetReverbLevel(rawPtr, index, out level);
		}

		public RESULT setReverbLevel(int index, float level)
		{
			return FMOD_Studio_EventInstance_SetReverbLevel(rawPtr, index, level);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD_Studio_EventInstance_GetPaused(rawPtr, out paused);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD_Studio_EventInstance_SetPaused(rawPtr, paused);
		}

		public RESULT start()
		{
			return FMOD_Studio_EventInstance_Start(rawPtr);
		}

		public RESULT stop(STOP_MODE mode)
		{
			return FMOD_Studio_EventInstance_Stop(rawPtr, mode);
		}

		public RESULT getTimelinePosition(out int position)
		{
			return FMOD_Studio_EventInstance_GetTimelinePosition(rawPtr, out position);
		}

		public RESULT setTimelinePosition(int position)
		{
			return FMOD_Studio_EventInstance_SetTimelinePosition(rawPtr, position);
		}

		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return FMOD_Studio_EventInstance_GetPlaybackState(rawPtr, out state);
		}

		public RESULT getChannelGroup(out ChannelGroup group)
		{
			group = null;
			IntPtr group2 = default(IntPtr);
			RESULT rESULT = FMOD_Studio_EventInstance_GetChannelGroup(rawPtr, out group2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			group = new ChannelGroup(group2);
			return rESULT;
		}

		public RESULT release()
		{
			return FMOD_Studio_EventInstance_Release(rawPtr);
		}

		public RESULT isVirtual(out bool virtualState)
		{
			return FMOD_Studio_EventInstance_IsVirtual(rawPtr, out virtualState);
		}

		public RESULT getParameter(string name, out ParameterInstance instance)
		{
			return FMOD_Studio_EventInstance_GetParameter(rawPtr, MarshallingHelper.StringAsBytes(name), out instance.rawPtr);
		}

		public RESULT getParameterCount(out int count)
		{
			return FMOD_Studio_EventInstance_GetParameterCount(rawPtr, out count);
		}

		public RESULT getParameterByIndex(int index, out ParameterInstance instance)
		{
			return FMOD_Studio_EventInstance_GetParameterByIndex(rawPtr, index, out instance.rawPtr);
		}

		public RESULT getParameterValue(string name, out float value, out float finalvalue)
		{
			return FMOD_Studio_EventInstance_GetParameterValue(rawPtr, MarshallingHelper.StringAsBytes(name), out value, out finalvalue);
		}

		public RESULT setParameterValue(string name, float value)
		{
			return FMOD_Studio_EventInstance_SetParameterValue(rawPtr, MarshallingHelper.StringAsBytes(name), value);
		}

		public RESULT getParameterValueByIndex(int index, out float value, out float finalvalue)
		{
			return FMOD_Studio_EventInstance_GetParameterValueByIndex(rawPtr, index, out value, out finalvalue);
		}

		public RESULT setParameterValueByIndex(int index, float value)
		{
			return FMOD_Studio_EventInstance_SetParameterValueByIndex(rawPtr, index, value);
		}

		public RESULT triggerCue()
		{
			return FMOD_Studio_EventInstance_TriggerCue(rawPtr);
		}

		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return FMOD_Studio_EventInstance_SetCallback(rawPtr, callback, callbackmask);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_EventInstance_GetUserData(rawPtr, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_EventInstance_SetUserData(rawPtr, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualState);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameter(IntPtr _event, byte[] name, out IntPtr parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByIndex(IntPtr _event, int index, out IntPtr parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterCount(IntPtr _event, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterValue(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterValue(IntPtr _event, byte[] name, float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterValueByIndex(IntPtr _event, int index, out float value, out float finalvalue);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterValueByIndex(IntPtr _event, int index, float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);
	}
	public struct ParameterInstance
	{
		public IntPtr rawPtr;

		public ParameterInstance(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero && FMOD_Studio_ParameterInstance_IsValid(rawPtr);
		}

		public override bool Equals(object obj)
		{
			return obj is ParameterInstance && Equals((ParameterInstance)obj);
		}

		public bool Equals(ParameterInstance p)
		{
			return rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.GetHashCode();
		}

		public static bool operator ==(ParameterInstance a, ParameterInstance b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(ParameterInstance a, ParameterInstance b)
		{
			return !a.Equals(b);
		}

		public RESULT getDescription(out PARAMETER_DESCRIPTION description)
		{
			PARAMETER_DESCRIPTION_INTERNAL description2;
			RESULT rESULT = FMOD_Studio_ParameterInstance_GetDescription(rawPtr, out description2);
			if (rESULT != 0)
			{
				description = default(PARAMETER_DESCRIPTION);
				return rESULT;
			}
			description2.assign(out description);
			return rESULT;
		}

		public RESULT getValue(out float value)
		{
			return FMOD_Studio_ParameterInstance_GetValue(rawPtr, out value);
		}

		public RESULT setValue(float value)
		{
			return FMOD_Studio_ParameterInstance_SetValue(rawPtr, value);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_ParameterInstance_IsValid(IntPtr parameter);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_ParameterInstance_GetDescription(IntPtr parameter, out PARAMETER_DESCRIPTION_INTERNAL description);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_ParameterInstance_GetValue(IntPtr parameter, out float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_ParameterInstance_SetValue(IntPtr parameter, float value);
	}
	public struct Bus
	{
		public IntPtr rawPtr;

		public Bus(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero && FMOD_Studio_Bus_IsValid(rawPtr);
		}

		public override bool Equals(object obj)
		{
			return obj is Bus && Equals((Bus)obj);
		}

		public bool Equals(Bus p)
		{
			return rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.GetHashCode();
		}

		public static bool operator ==(Bus a, Bus b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(Bus a, Bus b)
		{
			return !a.Equals(b);
		}

		public RESULT getID(out Guid id)
		{
			RESULT result = FMOD_Studio_Bus_GetID(rawPtr, MarshallingHelper.rawguid);
			id = new Guid(MarshallingHelper.rawguid);
			return result;
		}

		public RESULT getPath(out string path)
		{
			byte[] tempBuffer = MarshallingHelper.GetTempBuffer();
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_Bus_GetPath(rawPtr, tempBuffer, tempBuffer.Length, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				tempBuffer = MarshallingHelper.GetTempBuffer(retrieved);
				rESULT = FMOD_Studio_Bus_GetPath(rawPtr, tempBuffer, tempBuffer.Length, out retrieved);
			}
			path = ((rESULT != 0) ? null : Encoding.UTF8.GetString(tempBuffer, 0, retrieved - 1));
			return rESULT;
		}

		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return FMOD_Studio_Bus_GetVolume(rawPtr, out volume, out finalvolume);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD_Studio_Bus_SetVolume(rawPtr, volume);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD_Studio_Bus_GetPaused(rawPtr, out paused);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD_Studio_Bus_SetPaused(rawPtr, paused);
		}

		public RESULT getMute(out bool mute)
		{
			return FMOD_Studio_Bus_GetMute(rawPtr, out mute);
		}

		public RESULT setMute(bool mute)
		{
			return FMOD_Studio_Bus_SetMute(rawPtr, mute);
		}

		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return FMOD_Studio_Bus_StopAllEvents(rawPtr, mode);
		}

		public RESULT lockChannelGroup()
		{
			return FMOD_Studio_Bus_LockChannelGroup(rawPtr);
		}

		public RESULT unlockChannelGroup()
		{
			return FMOD_Studio_Bus_UnlockChannelGroup(rawPtr);
		}

		public RESULT getChannelGroup(out ChannelGroup group)
		{
			IntPtr group2 = default(IntPtr);
			RESULT rESULT = FMOD_Studio_Bus_GetChannelGroup(rawPtr, out group2);
			if (rESULT != 0)
			{
				group = null;
				return rESULT;
			}
			group = new ChannelGroup(group2);
			return rESULT;
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, [Out] byte[] id);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, [Out] byte[] path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float value);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);
	}
	public struct VCA
	{
		public IntPtr rawPtr;

		public VCA(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero && FMOD_Studio_VCA_IsValid(rawPtr);
		}

		public override bool Equals(object obj)
		{
			return obj is VCA && Equals((VCA)obj);
		}

		public bool Equals(VCA p)
		{
			return rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.GetHashCode();
		}

		public static bool operator ==(VCA a, VCA b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(VCA a, VCA b)
		{
			return !a.Equals(b);
		}

		public RESULT getID(out Guid id)
		{
			RESULT result = FMOD_Studio_VCA_GetID(rawPtr, MarshallingHelper.rawguid);
			id = new Guid(MarshallingHelper.rawguid);
			return result;
		}

		public RESULT getPath(out string path)
		{
			byte[] tempBuffer = MarshallingHelper.GetTempBuffer();
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_VCA_GetPath(rawPtr, tempBuffer, tempBuffer.Length, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				tempBuffer = MarshallingHelper.GetTempBuffer(retrieved);
				rESULT = FMOD_Studio_VCA_GetPath(rawPtr, tempBuffer, tempBuffer.Length, out retrieved);
			}
			path = ((rESULT != 0) ? null : Encoding.UTF8.GetString(tempBuffer, 0, retrieved - 1));
			return rESULT;
		}

		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return FMOD_Studio_VCA_GetVolume(rawPtr, out volume, out finalvolume);
		}

		public RESULT setVolume(float volume)
		{
			return FMOD_Studio_VCA_SetVolume(rawPtr, volume);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, [Out] byte[] id);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, [Out] byte[] path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float value);
	}
	public struct Bank
	{
		public IntPtr rawPtr;

		public Bank(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero && FMOD_Studio_Bank_IsValid(rawPtr);
		}

		public override bool Equals(object obj)
		{
			return obj is Bank && Equals((Bank)obj);
		}

		public bool Equals(Bank p)
		{
			return rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.GetHashCode();
		}

		public static bool operator ==(Bank a, Bank b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(Bank a, Bank b)
		{
			return !a.Equals(b);
		}

		public RESULT getID(out Guid id)
		{
			RESULT result = FMOD_Studio_Bank_GetID(rawPtr, MarshallingHelper.rawguid);
			id = new Guid(MarshallingHelper.rawguid);
			return result;
		}

		public RESULT getPath(out string path)
		{
			byte[] tempBuffer = MarshallingHelper.GetTempBuffer();
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_Bank_GetPath(rawPtr, tempBuffer, tempBuffer.Length, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				tempBuffer = MarshallingHelper.GetTempBuffer(retrieved);
				rESULT = FMOD_Studio_Bank_GetPath(rawPtr, tempBuffer, tempBuffer.Length, out retrieved);
			}
			path = ((rESULT != 0) ? null : Encoding.UTF8.GetString(tempBuffer, 0, retrieved - 1));
			return rESULT;
		}

		public RESULT unload()
		{
			RESULT rESULT = FMOD_Studio_Bank_Unload(rawPtr);
			if (rESULT == RESULT.OK)
			{
				rawPtr = IntPtr.Zero;
			}
			return rESULT;
		}

		public RESULT loadSampleData()
		{
			return FMOD_Studio_Bank_LoadSampleData(rawPtr);
		}

		public RESULT unloadSampleData()
		{
			return FMOD_Studio_Bank_UnloadSampleData(rawPtr);
		}

		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return FMOD_Studio_Bank_GetLoadingState(rawPtr, out state);
		}

		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return FMOD_Studio_Bank_GetSampleLoadingState(rawPtr, out state);
		}

		public RESULT getStringCount(out int count)
		{
			return FMOD_Studio_Bank_GetStringCount(rawPtr, out count);
		}

		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			byte[] tempBuffer = MarshallingHelper.GetTempBuffer();
			int retrieved = 0;
			RESULT rESULT = FMOD_Studio_Bank_GetStringInfo(rawPtr, index, MarshallingHelper.rawguid, tempBuffer, tempBuffer.Length, out retrieved);
			if (rESULT == RESULT.ERR_TRUNCATED)
			{
				tempBuffer = MarshallingHelper.GetTempBuffer(retrieved);
				rESULT = FMOD_Studio_Bank_GetStringInfo(rawPtr, index, MarshallingHelper.rawguid, tempBuffer, tempBuffer.Length, out retrieved);
			}
			if (rESULT == RESULT.OK)
			{
				path = Encoding.UTF8.GetString(tempBuffer, 0, retrieved - 1);
				id = new Guid(MarshallingHelper.rawguid);
			}
			else
			{
				path = null;
				id = Guid.Empty;
			}
			return rESULT;
		}

		public RESULT getEventCount(out int count)
		{
			return FMOD_Studio_Bank_GetEventCount(rawPtr, out count);
		}

		public RESULT getEventList(out EventDescription[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_Bank_GetEventCount(rawPtr, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new EventDescription[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_Bank_GetEventList(rawPtr, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new EventDescription[count2];
			for (int i = 0; i < count2; i++)
			{
				ref EventDescription reference = ref array[i];
				reference = new EventDescription(array2[i]);
			}
			return RESULT.OK;
		}

		public RESULT getBusCount(out int count)
		{
			return FMOD_Studio_Bank_GetBusCount(rawPtr, out count);
		}

		public RESULT getBusList(out Bus[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_Bank_GetBusCount(rawPtr, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new Bus[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_Bank_GetBusList(rawPtr, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new Bus[count2];
			for (int i = 0; i < count2; i++)
			{
				ref Bus reference = ref array[i];
				reference = new Bus(array2[i]);
			}
			return RESULT.OK;
		}

		public RESULT getVCACount(out int count)
		{
			return FMOD_Studio_Bank_GetVCACount(rawPtr, out count);
		}

		public RESULT getVCAList(out VCA[] array)
		{
			array = null;
			RESULT rESULT = FMOD_Studio_Bank_GetVCACount(rawPtr, out var count);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count == 0)
			{
				array = new VCA[0];
				return rESULT;
			}
			IntPtr[] array2 = new IntPtr[count];
			rESULT = FMOD_Studio_Bank_GetVCAList(rawPtr, array2, count, out var count2);
			if (rESULT != 0)
			{
				return rESULT;
			}
			if (count2 > count)
			{
				count2 = count;
			}
			array = new VCA[count2];
			for (int i = 0; i < count2; i++)
			{
				ref VCA reference = ref array[i];
				reference = new VCA(array2[i]);
			}
			return RESULT.OK;
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_Bank_GetUserData(rawPtr, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_Bank_SetUserData(rawPtr, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, [Out] byte[] id);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, [Out] byte[] path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, [Out] byte[] id, [Out] byte[] path, int size, out int retrieved);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr studiosystem, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr studiosystem, IntPtr userdata);
	}
	public struct CommandReplay
	{
		public IntPtr rawPtr;

		public CommandReplay(IntPtr newPtr)
		{
			rawPtr = newPtr;
		}

		public bool isValid()
		{
			return rawPtr != IntPtr.Zero && FMOD_Studio_CommandReplay_IsValid(rawPtr);
		}

		public override bool Equals(object obj)
		{
			return obj is CommandReplay && Equals((CommandReplay)obj);
		}

		public bool Equals(CommandReplay p)
		{
			return rawPtr == p.rawPtr;
		}

		public override int GetHashCode()
		{
			return rawPtr.GetHashCode();
		}

		public static bool operator ==(CommandReplay a, CommandReplay b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(CommandReplay a, CommandReplay b)
		{
			return !a.Equals(b);
		}

		public RESULT getSystem(out System system)
		{
			return FMOD_Studio_CommandReplay_GetSystem(rawPtr, out system.rawPtr);
		}

		public RESULT getLength(out float totalTime)
		{
			return FMOD_Studio_CommandReplay_GetLength(rawPtr, out totalTime);
		}

		public RESULT getCommandCount(out int count)
		{
			return FMOD_Studio_CommandReplay_GetCommandCount(rawPtr, out count);
		}

		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			COMMAND_INFO_INTERNAL info2 = default(COMMAND_INFO_INTERNAL);
			RESULT rESULT = FMOD_Studio_CommandReplay_GetCommandInfo(rawPtr, commandIndex, out info2);
			if (rESULT != 0)
			{
				info = default(COMMAND_INFO);
				return rESULT;
			}
			info = info2.createPublic();
			return rESULT;
		}

		public RESULT getCommandString(int commandIndex, out string description)
		{
			description = null;
			byte[] tempBuffer = MarshallingHelper.GetTempBuffer();
			RESULT rESULT;
			while (true)
			{
				rESULT = FMOD_Studio_CommandReplay_GetCommandString(rawPtr, commandIndex, tempBuffer, tempBuffer.Length);
				switch (rESULT)
				{
				case RESULT.ERR_TRUNCATED:
					goto IL_0023;
				case RESULT.OK:
				{
					int i;
					for (i = 0; tempBuffer[i] != 0; i++)
					{
					}
					description = Encoding.UTF8.GetString(tempBuffer, 0, i);
					break;
				}
				}
				break;
				IL_0023:
				tempBuffer = MarshallingHelper.GetTempBuffer(2 * tempBuffer.Length);
			}
			return rESULT;
		}

		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return FMOD_Studio_CommandReplay_GetCommandAtTime(rawPtr, time, out commandIndex);
		}

		public RESULT setBankPath(string bankPath)
		{
			return FMOD_Studio_CommandReplay_SetBankPath(rawPtr, MarshallingHelper.StringAsBytes(bankPath));
		}

		public RESULT start()
		{
			return FMOD_Studio_CommandReplay_Start(rawPtr);
		}

		public RESULT stop()
		{
			return FMOD_Studio_CommandReplay_Stop(rawPtr);
		}

		public RESULT seekToTime(float time)
		{
			return FMOD_Studio_CommandReplay_SeekToTime(rawPtr, time);
		}

		public RESULT seekToCommand(int commandIndex)
		{
			return FMOD_Studio_CommandReplay_SeekToCommand(rawPtr, commandIndex);
		}

		public RESULT getPaused(out bool paused)
		{
			return FMOD_Studio_CommandReplay_GetPaused(rawPtr, out paused);
		}

		public RESULT setPaused(bool paused)
		{
			return FMOD_Studio_CommandReplay_SetPaused(rawPtr, paused);
		}

		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return FMOD_Studio_CommandReplay_GetPlaybackState(rawPtr, out state);
		}

		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return FMOD_Studio_CommandReplay_GetCurrentCommand(rawPtr, out commandIndex, out currentTime);
		}

		public RESULT release()
		{
			return FMOD_Studio_CommandReplay_Release(rawPtr);
		}

		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return FMOD_Studio_CommandReplay_SetFrameCallback(rawPtr, callback);
		}

		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return FMOD_Studio_CommandReplay_SetLoadBankCallback(rawPtr, callback);
		}

		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return FMOD_Studio_CommandReplay_SetCreateInstanceCallback(rawPtr, callback);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return FMOD_Studio_CommandReplay_GetUserData(rawPtr, out userdata);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return FMOD_Studio_CommandReplay_SetUserData(rawPtr, userdata);
		}

		[DllImport("fmodstudio")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float totalTime);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandIndex, out COMMAND_INFO_INTERNAL info);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, [Out] byte[] description, int capacity);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[DllImport("fmodstudio")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);
	}
	internal class MarshallingHelper
	{
		[StructLayout(LayoutKind.Explicit)]
		private struct Union_GuidBytes
		{
			[FieldOffset(0)]
			public Guid guid;

			[FieldOffset(0)]
			public byte b0;

			[FieldOffset(1)]
			public byte b1;

			[FieldOffset(2)]
			public byte b2;

			[FieldOffset(3)]
			public byte b3;

			[FieldOffset(4)]
			public byte b4;

			[FieldOffset(5)]
			public byte b5;

			[FieldOffset(6)]
			public byte b6;

			[FieldOffset(7)]
			public byte b7;

			[FieldOffset(8)]
			public byte b8;

			[FieldOffset(9)]
			public byte b9;

			[FieldOffset(10)]
			public byte b10;

			[FieldOffset(11)]
			public byte b11;

			[FieldOffset(12)]
			public byte b12;

			[FieldOffset(13)]
			public byte b13;

			[FieldOffset(14)]
			public byte b14;

			[FieldOffset(15)]
			public byte b15;
		}

		private const int initialSize = 1024;

		[ThreadStatic]
		private static byte[] tempBuffer;

		[ThreadStatic]
		private static byte[] _rawguid;

		public static byte[] rawguid
		{
			get
			{
				if (_rawguid == null)
				{
					_rawguid = new byte[16];
				}
				return _rawguid;
			}
		}

		public static byte[] GetTempBuffer(int size = -1)
		{
			if (tempBuffer == null)
			{
				tempBuffer = new byte[Math.Max(1024, size)];
			}
			else if (tempBuffer.Length < size)
			{
				tempBuffer = new byte[size];
			}
			else
			{
				Array.Clear(tempBuffer, 0, (size != -1) ? size : tempBuffer.Length);
			}
			return tempBuffer;
		}

		public static byte[] StringAsBytes(string str)
		{
			int length = str.Length;
			int size = Encoding.UTF8.GetMaxByteCount(length) + 1;
			byte[] array = GetTempBuffer(size);
			Encoding.UTF8.GetBytes(str, 0, length, array, 0);
			return array;
		}

		public static byte[] GuidAsBytes(Guid guid)
		{
			Union_GuidBytes union_GuidBytes = default(Union_GuidBytes);
			byte[] array = rawguid;
			union_GuidBytes.guid = guid;
			array[0] = union_GuidBytes.b0;
			array[1] = union_GuidBytes.b1;
			array[2] = union_GuidBytes.b2;
			array[3] = union_GuidBytes.b3;
			array[4] = union_GuidBytes.b4;
			array[5] = union_GuidBytes.b5;
			array[6] = union_GuidBytes.b6;
			array[7] = union_GuidBytes.b7;
			array[8] = union_GuidBytes.b8;
			array[9] = union_GuidBytes.b9;
			array[10] = union_GuidBytes.b10;
			array[11] = union_GuidBytes.b11;
			array[12] = union_GuidBytes.b12;
			array[13] = union_GuidBytes.b13;
			array[14] = union_GuidBytes.b14;
			array[15] = union_GuidBytes.b15;
			return array;
		}

		public static int stringLengthUtf8(IntPtr nativeUtf8)
		{
			int i;
			for (i = 0; Marshal.ReadByte(nativeUtf8, i) != 0; i++)
			{
			}
			return i;
		}

		public static string stringFromNativeUtf8(IntPtr nativeUtf8)
		{
			int num = stringLengthUtf8(nativeUtf8);
			if (num == 0)
			{
				return string.Empty;
			}
			byte[] array = GetTempBuffer(num);
			Marshal.Copy(nativeUtf8, array, 0, num);
			return Encoding.UTF8.GetString(array, 0, num);
		}
	}
}
