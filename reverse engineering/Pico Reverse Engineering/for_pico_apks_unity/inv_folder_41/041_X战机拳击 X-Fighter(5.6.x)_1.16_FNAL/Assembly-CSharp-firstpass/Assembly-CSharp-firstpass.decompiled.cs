using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Serialization;
using Crosstales.Common.Model.Enum;
using Crosstales.Common.Util;
using Crosstales.DJ.Model;
using Crosstales.DJ.Model.Enum;
using Crosstales.DJ.Provider;
using Crosstales.DJ.Set;
using Crosstales.NLayer;
using Crosstales.NVorbis;
using Crosstales.TagLib;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Crosstales
{
	[Token(Token = "0x2000002")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x2000003")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string str;

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x925350", Offset = "0x925350", VA = "0x925350")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x925ADC", Offset = "0x925ADC", VA = "0x925ADC")]
			internal bool <CTContainsAny>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 flat;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x925110", Offset = "0x925110", VA = "0x925110")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x9251B0", Offset = "0x9251B0", VA = "0x9251B0")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x9251C0", Offset = "0x9251C0", VA = "0x9251C0")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x9251E0", Offset = "0x9251E0", VA = "0x9251E0")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x925358", Offset = "0x925358", VA = "0x925358")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x9253AC", Offset = "0x9253AC", VA = "0x9253AC")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x925400", Offset = "0x925400", VA = "0x925400")]
		public static int CTLastIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x6000008")]
		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x9254A0", Offset = "0x9254A0", VA = "0x9254A0")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x925634", Offset = "0x925634", VA = "0x925634")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x925774", Offset = "0x925774", VA = "0x925774")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x925974", Offset = "0x925974", VA = "0x925974")]
		public static bool CTHasActiveClip(this AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x925618", Offset = "0x925618", VA = "0x925618")]
		private static float bytesToFloat(byte firstByte, byte secondByte)
		{
			return default(float);
		}
	}
}
namespace Crosstales.DJ
{
	[Token(Token = "0x2000004")]
	public abstract class BasePlayer : MonoBehaviour
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int playCount;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int audioCount;

		[Token(Token = "0x17000001")]
		public static bool isAnyPlayback
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x925B68", Offset = "0x925B68", VA = "0x925B68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public static bool isAnyAudioPlaying
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x925BB0", Offset = "0x925BB0", VA = "0x925BB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		protected static int playCounter
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x925BF8", Offset = "0x925BF8", VA = "0x925BF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x925C40", Offset = "0x925C40", VA = "0x925C40")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		protected static int audioCounter
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x925C90", Offset = "0x925C90", VA = "0x925C90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x925CD8", Offset = "0x925CD8", VA = "0x925CD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		protected abstract PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x6000018")]
			get;
		}

		[Token(Token = "0x17000006")]
		protected abstract PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x6000019")]
			get;
		}

		[Token(Token = "0x17000007")]
		protected abstract AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x600001A")]
			get;
		}

		[Token(Token = "0x17000008")]
		protected abstract AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x600001B")]
			get;
		}

		[Token(Token = "0x17000009")]
		protected abstract ErrorEvent onError
		{
			[Token(Token = "0x600001C")]
			get;
		}

		[Token(Token = "0x1700000A")]
		public abstract Record Record
		{
			[Token(Token = "0x6000031")]
			get;
			[Token(Token = "0x6000032")]
			set;
		}

		[Token(Token = "0x1700000B")]
		public abstract bool isLoop
		{
			[Token(Token = "0x6000033")]
			get;
			[Token(Token = "0x6000034")]
			set;
		}

		[Token(Token = "0x1700000C")]
		public abstract bool HandleFocus
		{
			[Token(Token = "0x6000035")]
			get;
			[Token(Token = "0x6000036")]
			set;
		}

		[Token(Token = "0x1700000D")]
		public abstract bool Caching
		{
			[Token(Token = "0x6000037")]
			get;
			[Token(Token = "0x6000038")]
			set;
		}

		[Token(Token = "0x1700000E")]
		public abstract bool Streaming
		{
			[Token(Token = "0x6000039")]
			get;
			[Token(Token = "0x600003A")]
			set;
		}

		[Token(Token = "0x1700000F")]
		public abstract int ChunkSize
		{
			[Token(Token = "0x600003B")]
			get;
			[Token(Token = "0x600003C")]
			set;
		}

		[Token(Token = "0x17000010")]
		public abstract int CacheStreamSize
		{
			[Token(Token = "0x600003D")]
			get;
			[Token(Token = "0x600003E")]
			set;
		}

		[Token(Token = "0x17000011")]
		public abstract int BufferSize
		{
			[Token(Token = "0x600003F")]
			get;
			[Token(Token = "0x6000040")]
			set;
		}

		[Token(Token = "0x17000012")]
		public abstract bool CaptureDataStream
		{
			[Token(Token = "0x6000041")]
			get;
			[Token(Token = "0x6000042")]
			set;
		}

		[Token(Token = "0x17000013")]
		public abstract bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000043")]
			get;
			[Token(Token = "0x6000044")]
			set;
		}

		[Token(Token = "0x17000014")]
		public abstract bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000045")]
			get;
			[Token(Token = "0x6000046")]
			set;
		}

		[Token(Token = "0x17000015")]
		public abstract AudioSource Source
		{
			[Token(Token = "0x6000047")]
			get;
			[Token(Token = "0x6000048")]
			protected set;
		}

		[Token(Token = "0x17000016")]
		public abstract float Position
		{
			[Token(Token = "0x6000049")]
			get;
			[Token(Token = "0x600004A")]
			set;
		}

		[Token(Token = "0x17000017")]
		public abstract int SamplePosition
		{
			[Token(Token = "0x600004B")]
			get;
			[Token(Token = "0x600004C")]
			set;
		}

		[Token(Token = "0x17000018")]
		public abstract float Elapsed
		{
			[Token(Token = "0x600004D")]
			get;
			[Token(Token = "0x600004E")]
			set;
		}

		[Token(Token = "0x17000019")]
		public abstract float Duration
		{
			[Token(Token = "0x600004F")]
			get;
		}

		[Token(Token = "0x1700001A")]
		public abstract int Samples
		{
			[Token(Token = "0x6000050")]
			get;
		}

		[Token(Token = "0x1700001B")]
		public abstract AudioCodec Codec
		{
			[Token(Token = "0x6000051")]
			get;
			[Token(Token = "0x6000052")]
			protected set;
		}

		[Token(Token = "0x1700001C")]
		public abstract float BufferProgress
		{
			[Token(Token = "0x6000053")]
			get;
			[Token(Token = "0x6000054")]
			protected set;
		}

		[Token(Token = "0x1700001D")]
		public abstract bool isBuffering
		{
			[Token(Token = "0x6000055")]
			get;
		}

		[Token(Token = "0x1700001E")]
		public abstract bool isPlayback
		{
			[Token(Token = "0x6000056")]
			get;
		}

		[Token(Token = "0x1700001F")]
		public abstract bool isAudioPlaying
		{
			[Token(Token = "0x6000057")]
			get;
			[Token(Token = "0x6000058")]
			protected set;
		}

		[Token(Token = "0x17000020")]
		public abstract bool isPaused
		{
			[Token(Token = "0x6000059")]
			get;
			[Token(Token = "0x600005A")]
			set;
		}

		[Token(Token = "0x17000021")]
		public abstract Stream DataStream
		{
			[Token(Token = "0x600005B")]
			get;
			[Token(Token = "0x600005C")]
			protected set;
		}

		[Token(Token = "0x17000022")]
		public abstract int Channels
		{
			[Token(Token = "0x600005D")]
			get;
		}

		[Token(Token = "0x17000023")]
		public abstract int SampleRate
		{
			[Token(Token = "0x600005E")]
			get;
		}

		[Token(Token = "0x17000024")]
		public abstract float Volume
		{
			[Token(Token = "0x600005F")]
			get;
			[Token(Token = "0x6000060")]
			set;
		}

		[Token(Token = "0x17000025")]
		public abstract float Pitch
		{
			[Token(Token = "0x6000061")]
			get;
			[Token(Token = "0x6000062")]
			set;
		}

		[Token(Token = "0x17000026")]
		public abstract float StereoPan
		{
			[Token(Token = "0x6000063")]
			get;
			[Token(Token = "0x6000064")]
			set;
		}

		[Token(Token = "0x17000027")]
		public abstract bool isMuted
		{
			[Token(Token = "0x6000065")]
			get;
			[Token(Token = "0x6000066")]
			set;
		}

		[Token(Token = "0x17000028")]
		public abstract List<Record> PlayedRecords
		{
			[Token(Token = "0x6000067")]
			get;
		}

		[Token(Token = "0x14000001")]
		public event PlaybackStart OnPlaybackStart
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x925D28", Offset = "0x925D28", VA = "0x925D28")]
			add
			{
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x925DC4", Offset = "0x925DC4", VA = "0x925DC4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event PlaybackEnd OnPlaybackEnd
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x925E60", Offset = "0x925E60", VA = "0x925E60")]
			add
			{
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x925EFC", Offset = "0x925EFC", VA = "0x925EFC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event BufferingStart OnBufferingStart
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x925F98", Offset = "0x925F98", VA = "0x925F98")]
			add
			{
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x926034", Offset = "0x926034", VA = "0x926034")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event BufferingEnd OnBufferingEnd
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x9260D0", Offset = "0x9260D0", VA = "0x9260D0")]
			add
			{
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x92616C", Offset = "0x92616C", VA = "0x92616C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event BufferingProgressUpdate OnBufferingProgressUpdate
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x926208", Offset = "0x926208", VA = "0x926208")]
			add
			{
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x9262A4", Offset = "0x9262A4", VA = "0x9262A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event AudioStart OnAudioStart
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x926340", Offset = "0x926340", VA = "0x926340")]
			add
			{
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x9263DC", Offset = "0x9263DC", VA = "0x9263DC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event AudioEnd OnAudioEnd
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x926478", Offset = "0x926478", VA = "0x926478")]
			add
			{
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x926514", Offset = "0x926514", VA = "0x926514")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event LoopPositionReached OnLoopPositionReached
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x9265B0", Offset = "0x9265B0", VA = "0x9265B0")]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x92664C", Offset = "0x92664C", VA = "0x92664C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event AudioPlayTimeUpdate OnAudioPlayTimeUpdate
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x9266E8", Offset = "0x9266E8", VA = "0x9266E8")]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x926784", Offset = "0x926784", VA = "0x926784")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x926820", Offset = "0x926820", VA = "0x926820")]
			add
			{
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x9268BC", Offset = "0x9268BC", VA = "0x9268BC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000068")]
		public abstract void Play();

		[Token(Token = "0x6000069")]
		public abstract void Next();

		[Token(Token = "0x600006A")]
		public abstract void Previous();

		[Token(Token = "0x600006B")]
		public abstract void Pause();

		[Token(Token = "0x600006C")]
		public abstract void UnPause();

		[Token(Token = "0x600006D")]
		public abstract void Stop();

		[Token(Token = "0x600006E")]
		public abstract void Restart();

		[Token(Token = "0x600006F")]
		public abstract void Mute();

		[Token(Token = "0x6000070")]
		public abstract void UnMute();

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x926958", Offset = "0x926958", VA = "0x926958", Slot = "73")]
		public virtual void PlayOrStop()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x926998", Offset = "0x926998", VA = "0x926998", Slot = "74")]
		public virtual void PauseOrUnPause()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x9269D8", Offset = "0x9269D8", VA = "0x9269D8", Slot = "75")]
		public virtual void MuteOrUnMute()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x926A18", Offset = "0x926A18", VA = "0x926A18", Slot = "76")]
		protected virtual void onPlaybackStart(Record record)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x926BE4", Offset = "0x926BE4", VA = "0x926BE4", Slot = "77")]
		protected virtual void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x926DB0", Offset = "0x926DB0", VA = "0x926DB0", Slot = "78")]
		protected virtual void onBufferingStart(Record record)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x926EC4", Offset = "0x926EC4", VA = "0x926EC4", Slot = "79")]
		protected virtual void onBufferingEnd(Record record)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x926FA0", Offset = "0x926FA0", VA = "0x926FA0", Slot = "80")]
		protected virtual void onBufferingProgressUpdate(Record record, float progress)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x926FBC", Offset = "0x926FBC", VA = "0x926FBC", Slot = "81")]
		protected virtual void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x927188", Offset = "0x927188", VA = "0x927188", Slot = "82")]
		protected virtual void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x927354", Offset = "0x927354", VA = "0x927354", Slot = "83")]
		protected virtual void onLoopPositionReached(Record record, LoopPoint lp)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x9274BC", Offset = "0x9274BC", VA = "0x9274BC", Slot = "84")]
		protected virtual void onAudioPlayTimeUpdate(Record record, float playtime)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x9274D8", Offset = "0x9274D8", VA = "0x9274D8", Slot = "85")]
		protected virtual void onErrorInfo(Record record, string info)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x927690", Offset = "0x927690", VA = "0x927690")]
		protected BasePlayer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public class PlaybackStartEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x927698", Offset = "0x927698", VA = "0x927698")]
		public PlaybackStartEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class PlaybackEndEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x9276E0", Offset = "0x9276E0", VA = "0x9276E0")]
		public PlaybackEndEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class AudioStartEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x927728", Offset = "0x927728", VA = "0x927728")]
		public AudioStartEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class AudioEndEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x927770", Offset = "0x927770", VA = "0x927770")]
		public AudioEndEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class ErrorEvent : UnityEvent<string, string, int, string>
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x9277B8", Offset = "0x9277B8", VA = "0x9277B8")]
		public ErrorEvent()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public delegate void PlaybackStart(Record record);
	[Token(Token = "0x200000B")]
	public delegate void PlaybackEnd(Record record);
	[Token(Token = "0x200000C")]
	public delegate void BufferingStart(Record record);
	[Token(Token = "0x200000D")]
	public delegate void BufferingEnd(Record record);
	[Token(Token = "0x200000E")]
	public delegate void BufferingProgressUpdate(Record record, float progress);
	[Token(Token = "0x200000F")]
	public delegate void AudioStart(Record record);
	[Token(Token = "0x2000010")]
	public delegate void AudioEnd(Record record);
	[Token(Token = "0x2000011")]
	public delegate void LoopPositionReached(Record record, LoopPoint loopPoint);
	[Token(Token = "0x2000012")]
	public delegate void AudioPlayTimeUpdate(Record record, float playtime);
	[Token(Token = "0x2000013")]
	public delegate void ErrorInfo(Record record, string info);
	[Token(Token = "0x2000014")]
	public delegate void Cached(Record record);
	[Serializable]
	[Token(Token = "0x2000015")]
	public class RecordChangeEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x928680", Offset = "0x928680", VA = "0x928680")]
		public RecordChangeEvent()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public delegate void RecordChange(Record record);
	[Serializable]
	[Token(Token = "0x2000017")]
	public class RecordsChangeEvent : UnityEvent
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x928818", Offset = "0x928818", VA = "0x928818")]
		public RecordsChangeEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class ErrorProviderEvent : UnityEvent<string>
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x928820", Offset = "0x928820", VA = "0x928820")]
		public ErrorProviderEvent()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public delegate void RecordsChange();
	[Token(Token = "0x200001A")]
	public delegate void ErrorProvider(string info);
	[Serializable]
	[Token(Token = "0x200001B")]
	public class FilterChangeEvent : UnityEvent
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x928A40", Offset = "0x928A40", VA = "0x928A40")]
		public FilterChangeEvent()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public delegate void FilterChange();
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class GlobalCache : Singleton<GlobalCache>
	{
		[Serializable]
		[Token(Token = "0x200001E")]
		private sealed class <>c
		{
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, byte[]>, int> <>9__14_0;

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, AudioClip>, int> <>9__16_0;

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x929CD0", Offset = "0x929CD0", VA = "0x929CD0")]
			public <>c()
			{
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x929CD8", Offset = "0x929CD8", VA = "0x929CD8")]
			internal int <get_CurrentDataCacheSize>b__14_0(KeyValuePair<string, byte[]> pair)
			{
				return default(int);
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x929D1C", Offset = "0x929D1C", VA = "0x929D1C")]
			internal int <get_CurrentClipCacheSize>b__16_0(KeyValuePair<string, AudioClip> pair)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(16f, 1024f)]
		[SerializeField]
		[FormerlySerializedAs("ClipCacheSize")]
		private int clipCacheSize;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("DataCacheSize")]
		[Range(16f, 1024f)]
		[SerializeField]
		private int dataCacheSize;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<string, AudioClip> Clips;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Dictionary<string, byte[]> AudioDatas;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<string> clipKeys;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<string> audioDataKeys;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform tf;

		[Token(Token = "0x17000029")]
		public int ClipCacheSize
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x928B28", Offset = "0x928B28", VA = "0x928B28")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x928B34", Offset = "0x928B34", VA = "0x928B34")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int DataCacheSize
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x928B68", Offset = "0x928B68", VA = "0x928B68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x928B74", Offset = "0x928B74", VA = "0x928B74")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int CurrentDataCacheSize
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x928BA8", Offset = "0x928BA8", VA = "0x928BA8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		public int CurrentClipCacheSize
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x928CD8", Offset = "0x928CD8", VA = "0x928CD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x928E08", Offset = "0x928E08", VA = "0x928E08")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x928E54", Offset = "0x928E54", VA = "0x928E54", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x928EB4", Offset = "0x928EB4", VA = "0x928EB4")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x928F18", Offset = "0x928F18", VA = "0x928F18")]
		public AudioClip GetClip(string key)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x928FB4", Offset = "0x928FB4", VA = "0x928FB4")]
		public void RemoveClip(string key)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x929120", Offset = "0x929120", VA = "0x929120")]
		public void AddClip(string key, AudioClip data)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x92933C", Offset = "0x92933C", VA = "0x92933C")]
		public byte[] GetData(string key)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x9293D8", Offset = "0x9293D8", VA = "0x9293D8")]
		public void RemoveData(string key)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x9294DC", Offset = "0x9294DC", VA = "0x9294DC")]
		public void AddData(string key, byte[] data)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x9296C4", Offset = "0x9296C4", VA = "0x9296C4")]
		public void ClearDataCache()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x9297B8", Offset = "0x9297B8", VA = "0x9297B8")]
		public void ClearClipCache()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x928EA4", Offset = "0x928EA4", VA = "0x928EA4")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x929A74", Offset = "0x929A74", VA = "0x929A74")]
		public GlobalCache()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[ExecuteInEditMode]
	public class SimplePlayer : BasePlayer
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("Turntable")]
		[SerializeField]
		private Turntable turntable;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[FormerlySerializedAs("Set")]
		[SerializeField]
		private BaseSet set;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("Filter")]
		[SerializeField]
		private RecordFilter filter;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[FormerlySerializedAs("PlayOnStart")]
		[SerializeField]
		private bool playOnStart;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		[FormerlySerializedAs("PlayEndless")]
		[SerializeField]
		private bool playEndless;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		[FormerlySerializedAs("PlayRandom")]
		[SerializeField]
		private bool playRandom;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		private bool playedOnStart;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool stopped;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastPlaytime;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool isDirectionNext;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RecordFilter currentFilter;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public PlaybackStartEvent OnPlaybackStarted;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PlaybackEndEvent OnPlaybackEnded;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioStartEvent OnAudioStarted;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEndEvent OnAudioEnded;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public RecordChangeEvent OnRecordChanged;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public FilterChangeEvent OnFilterChanged;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public ErrorEvent OnError;

		[Token(Token = "0x1700002D")]
		public Turntable Turntable
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x929D6C", Offset = "0x929D6C", VA = "0x929D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x92A1F8", Offset = "0x92A1F8", VA = "0x92A1F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public BaseSet Set
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x92A200", Offset = "0x92A200", VA = "0x92A200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x92A208", Offset = "0x92A208", VA = "0x92A208")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public RecordFilter Filter
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x92A210", Offset = "0x92A210", VA = "0x92A210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x92A218", Offset = "0x92A218", VA = "0x92A218")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool PlayOnStart
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x92A220", Offset = "0x92A220", VA = "0x92A220")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x92A228", Offset = "0x92A228", VA = "0x92A228")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool PlayEndless
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x92A234", Offset = "0x92A234", VA = "0x92A234")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x92A23C", Offset = "0x92A23C", VA = "0x92A23C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool PlayRandom
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x92A248", Offset = "0x92A248", VA = "0x92A248")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x92A250", Offset = "0x92A250", VA = "0x92A250")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		protected override PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x92A25C", Offset = "0x92A25C", VA = "0x92A25C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		protected override PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x92A264", Offset = "0x92A264", VA = "0x92A264", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		protected override AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x92A26C", Offset = "0x92A26C", VA = "0x92A26C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		protected override AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x92A274", Offset = "0x92A274", VA = "0x92A274", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		protected override ErrorEvent onError
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x92A27C", Offset = "0x92A27C", VA = "0x92A27C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public List<Record> Records
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x92C0E8", Offset = "0x92C0E8", VA = "0x92C0E8", Slot = "90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public List<Record> RandomRecords
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x92C1B4", Offset = "0x92C1B4", VA = "0x92C1B4", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public bool isReady
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x92C280", Offset = "0x92C280", VA = "0x92C280", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x92C30C", Offset = "0x92C30C", VA = "0x92C30C", Slot = "93")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700003C")]
		public long TotalSize
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x92C4B0", Offset = "0x92C4B0", VA = "0x92C4B0", Slot = "94")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700003D")]
		public int CurrentRecordIndex
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x92C650", Offset = "0x92C650", VA = "0x92C650", Slot = "95")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x92C6D0", Offset = "0x92C6D0", VA = "0x92C6D0", Slot = "96")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int CurrentRandomRecordIndex
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x92C7D4", Offset = "0x92C7D4", VA = "0x92C7D4", Slot = "97")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x92C854", Offset = "0x92C854", VA = "0x92C854", Slot = "98")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override Record Record
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x9348F8", Offset = "0x9348F8", VA = "0x9348F8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x934918", Offset = "0x934918", VA = "0x934918", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public override bool isLoop
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x934940", Offset = "0x934940", VA = "0x934940", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x934960", Offset = "0x934960", VA = "0x934960", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public override bool HandleFocus
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x934988", Offset = "0x934988", VA = "0x934988", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x9349AC", Offset = "0x9349AC", VA = "0x9349AC", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public override bool Caching
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x9349D8", Offset = "0x9349D8", VA = "0x9349D8", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x9349FC", Offset = "0x9349FC", VA = "0x9349FC", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public override bool Streaming
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x934A28", Offset = "0x934A28", VA = "0x934A28", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x934A4C", Offset = "0x934A4C", VA = "0x934A4C", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public override int ChunkSize
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x934A78", Offset = "0x934A78", VA = "0x934A78", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x934A9C", Offset = "0x934A9C", VA = "0x934A9C", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public override int CacheStreamSize
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x934AC8", Offset = "0x934AC8", VA = "0x934AC8", Slot = "21")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x934AEC", Offset = "0x934AEC", VA = "0x934AEC", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public override int BufferSize
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x934B18", Offset = "0x934B18", VA = "0x934B18", Slot = "23")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x934B3C", Offset = "0x934B3C", VA = "0x934B3C", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override bool CaptureDataStream
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x934B68", Offset = "0x934B68", VA = "0x934B68", Slot = "25")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x934B8C", Offset = "0x934B8C", VA = "0x934B8C", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public override bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x934BB8", Offset = "0x934BB8", VA = "0x934BB8", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x934BDC", Offset = "0x934BDC", VA = "0x934BDC", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public override bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x934C08", Offset = "0x934C08", VA = "0x934C08", Slot = "29")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x934C2C", Offset = "0x934C2C", VA = "0x934C2C", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public override AudioSource Source
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x934C58", Offset = "0x934C58", VA = "0x934C58", Slot = "31")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x934C7C", Offset = "0x934C7C", VA = "0x934C7C", Slot = "32")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public override float Position
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x934C80", Offset = "0x934C80", VA = "0x934C80", Slot = "33")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x934CA4", Offset = "0x934CA4", VA = "0x934CA4", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public override int SamplePosition
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x934CD8", Offset = "0x934CD8", VA = "0x934CD8", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x934CFC", Offset = "0x934CFC", VA = "0x934CFC", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public override float Elapsed
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x934D28", Offset = "0x934D28", VA = "0x934D28", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x934D4C", Offset = "0x934D4C", VA = "0x934D4C", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public override float Duration
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x934D80", Offset = "0x934D80", VA = "0x934D80", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public override int Samples
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x934DA4", Offset = "0x934DA4", VA = "0x934DA4", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public override AudioCodec Codec
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x934DC8", Offset = "0x934DC8", VA = "0x934DC8", Slot = "41")]
			get
			{
				return default(AudioCodec);
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x934DEC", Offset = "0x934DEC", VA = "0x934DEC", Slot = "42")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public override float BufferProgress
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x934DF0", Offset = "0x934DF0", VA = "0x934DF0", Slot = "43")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x934E14", Offset = "0x934E14", VA = "0x934E14", Slot = "44")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public override bool isPlayback
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x934E18", Offset = "0x934E18", VA = "0x934E18", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public override bool isAudioPlaying
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x934E3C", Offset = "0x934E3C", VA = "0x934E3C", Slot = "47")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x934E60", Offset = "0x934E60", VA = "0x934E60", Slot = "48")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public override bool isBuffering
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x934E64", Offset = "0x934E64", VA = "0x934E64", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public override bool isPaused
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x934E88", Offset = "0x934E88", VA = "0x934E88", Slot = "49")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x934EAC", Offset = "0x934EAC", VA = "0x934EAC", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public override Stream DataStream
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x934ED8", Offset = "0x934ED8", VA = "0x934ED8", Slot = "51")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x934EFC", Offset = "0x934EFC", VA = "0x934EFC", Slot = "52")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public override int Channels
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x934F00", Offset = "0x934F00", VA = "0x934F00", Slot = "53")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000058")]
		public override int SampleRate
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x934F24", Offset = "0x934F24", VA = "0x934F24", Slot = "54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000059")]
		public override float Volume
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x934F48", Offset = "0x934F48", VA = "0x934F48", Slot = "55")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x934F6C", Offset = "0x934F6C", VA = "0x934F6C", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public override float Pitch
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x934FA0", Offset = "0x934FA0", VA = "0x934FA0", Slot = "57")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x934FC4", Offset = "0x934FC4", VA = "0x934FC4", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public override float StereoPan
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x934FF8", Offset = "0x934FF8", VA = "0x934FF8", Slot = "59")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x93501C", Offset = "0x93501C", VA = "0x93501C", Slot = "60")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public override bool isMuted
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x935050", Offset = "0x935050", VA = "0x935050", Slot = "61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x935074", Offset = "0x935074", VA = "0x935074", Slot = "62")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public override List<Record> PlayedRecords
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x9350A0", Offset = "0x9350A0", VA = "0x9350A0", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000B")]
		public event RecordChange OnRecordChange
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x92A284", Offset = "0x92A284", VA = "0x92A284")]
			add
			{
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x92A320", Offset = "0x92A320", VA = "0x92A320")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event FilterChange OnFilterChange
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x92A3BC", Offset = "0x92A3BC", VA = "0x92A3BC")]
			add
			{
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x92A458", Offset = "0x92A458", VA = "0x92A458")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x92A4F4", Offset = "0x92A4F4", VA = "0x92A4F4")]
			add
			{
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x92A590", Offset = "0x92A590", VA = "0x92A590")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x92A62C", Offset = "0x92A62C", VA = "0x92A62C")]
			add
			{
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x92A6C8", Offset = "0x92A6C8", VA = "0x92A6C8")]
			remove
			{
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x92A764", Offset = "0x92A764", VA = "0x92A764")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x92AE88", Offset = "0x92AE88", VA = "0x92AE88")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x92AF60", Offset = "0x92AF60", VA = "0x92AF60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x92B5B4", Offset = "0x92B5B4", VA = "0x92B5B4")]
		private void play()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x92B5D8", Offset = "0x92B5D8", VA = "0x92B5D8")]
		private RecordFilter getFilter([Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x92B62C", Offset = "0x92B62C", VA = "0x92B62C")]
		private void playEndlessly()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x92B9A4", Offset = "0x92B9A4", VA = "0x92B9A4", Slot = "81")]
		protected override void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x92B9D8", Offset = "0x92B9D8", VA = "0x92B9D8", Slot = "82")]
		protected override void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x92BA30", Offset = "0x92BA30", VA = "0x92BA30", Slot = "85")]
		protected override void onErrorInfo(Record record, string info)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x92BA68", Offset = "0x92BA68", VA = "0x92BA68", Slot = "86")]
		protected virtual void onRecordChange(Record newRecord)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x92BC24", Offset = "0x92BC24", VA = "0x92BC24", Slot = "87")]
		protected virtual void onFilterChange()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x92BDD8", Offset = "0x92BDD8", VA = "0x92BDD8", Slot = "88")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x92BF9C", Offset = "0x92BF9C", VA = "0x92BF9C", Slot = "89")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x92C958", Offset = "0x92C958", VA = "0x92C958", Slot = "99")]
		public void Load()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x92B718", Offset = "0x92B718", VA = "0x92B718", Slot = "100")]
		public Record Next(bool random, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x92B860", Offset = "0x92B860", VA = "0x92B860", Slot = "101")]
		public Record Previous(bool random, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x92CA44", Offset = "0x92CA44", VA = "0x92CA44", Slot = "102")]
		public void RandomizeRecords(bool resetIndex = true)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x92CB7C", Offset = "0x92CB7C", VA = "0x92CB7C", Slot = "103")]
		public List<Record> GetRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x92CCDC", Offset = "0x92CCDC", VA = "0x92CCDC", Slot = "104")]
		public int CountRecords([Optional] RecordFilter _filter)
		{
			return default(int);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x92CDF0", Offset = "0x92CDF0", VA = "0x92CDF0", Slot = "105")]
		public double PlaytimeRecords([Optional] RecordFilter _filter)
		{
			return default(double);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x92CFC8", Offset = "0x92CFC8", VA = "0x92CFC8", Slot = "106")]
		public long SizeRecords([Optional] RecordFilter _filter)
		{
			return default(long);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x92D19C", Offset = "0x92D19C", VA = "0x92D19C", Slot = "107")]
		public Record RecordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x92D26C", Offset = "0x92D26C", VA = "0x92D26C", Slot = "108")]
		public Record RecordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x92D308", Offset = "0x92D308", VA = "0x92D308", Slot = "109")]
		public List<Record> RecordsByFilePath(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x92DBC8", Offset = "0x92DBC8", VA = "0x92DBC8", Slot = "110")]
		public List<Record> RecordsByName(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x92E46C", Offset = "0x92E46C", VA = "0x92E46C", Slot = "111")]
		public List<Record> RecordsByTitle(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x92ED10", Offset = "0x92ED10", VA = "0x92ED10", Slot = "112")]
		public List<Record> RecordsByArtist(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x92F868", Offset = "0x92F868", VA = "0x92F868", Slot = "113")]
		public List<Record> RecordsByAlbum(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x9303C4", Offset = "0x9303C4", VA = "0x9303C4", Slot = "114")]
		public List<Record> RecordsByGenre(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x930F28", Offset = "0x930F28", VA = "0x930F28", Slot = "115")]
		public List<Record> RecordsByRating(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x931AB8", Offset = "0x931AB8", VA = "0x931AB8", Slot = "116")]
		public List<Record> RecordsByYear(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x932648", Offset = "0x932648", VA = "0x932648", Slot = "117")]
		public List<Record> RecordsByDuration(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x9331D8", Offset = "0x9331D8", VA = "0x9331D8", Slot = "118")]
		public List<Record> RecordsByFileSize(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x933D68", Offset = "0x933D68", VA = "0x933D68", Slot = "119")]
		public List<Record> RecordsByFormat(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x9350C4", Offset = "0x9350C4", VA = "0x9350C4", Slot = "64")]
		public override void Play()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x93537C", Offset = "0x93537C", VA = "0x93537C", Slot = "65")]
		public override void Next()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x935388", Offset = "0x935388", VA = "0x935388", Slot = "66")]
		public override void Previous()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x935394", Offset = "0x935394", VA = "0x935394", Slot = "67")]
		public override void Pause()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x9353B8", Offset = "0x9353B8", VA = "0x9353B8", Slot = "68")]
		public override void UnPause()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x9353DC", Offset = "0x9353DC", VA = "0x9353DC", Slot = "69")]
		public override void Stop()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x9354AC", Offset = "0x9354AC", VA = "0x9354AC", Slot = "70")]
		public override void Restart()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x9354D0", Offset = "0x9354D0", VA = "0x9354D0", Slot = "71")]
		public override void Mute()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x9354F4", Offset = "0x9354F4", VA = "0x9354F4", Slot = "72")]
		public override void UnMute()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x935518", Offset = "0x935518", VA = "0x935518")]
		public SimplePlayer()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[RequireComponent(typeof(AudioSource))]
	[ExecuteInEditMode]
	public class Turntable : BasePlayer
	{
		[Token(Token = "0x2000021")]
		private sealed class <>c__DisplayClass200_0
		{
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Turntable <>4__this;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Record _record;

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x93B540", Offset = "0x93B540", VA = "0x93B540")]
			public <>c__DisplayClass200_0()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x93B548", Offset = "0x93B548", VA = "0x93B548")]
			internal void <ctPlayAudio>b__3()
			{
			}
		}

		[Token(Token = "0x2000022")]
		private sealed class <>c__DisplayClass200_1
		{
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] pcmData;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass200_0 CS$<>8__locals1;

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x93B564", Offset = "0x93B564", VA = "0x93B564")]
			public <>c__DisplayClass200_1()
			{
			}
		}

		[Token(Token = "0x2000023")]
		private sealed class <>c__DisplayClass200_2
		{
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int duration;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass200_1 CS$<>8__locals2;

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x93B56C", Offset = "0x93B56C", VA = "0x93B56C")]
			public <>c__DisplayClass200_2()
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x93B574", Offset = "0x93B574", VA = "0x93B574")]
			internal void <ctPlayAudio>b__0()
			{
			}
		}

		[Token(Token = "0x2000024")]
		private sealed class <>c__DisplayClass200_3
		{
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int duration;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass200_1 CS$<>8__locals3;

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x93B5A8", Offset = "0x93B5A8", VA = "0x93B5A8")]
			public <>c__DisplayClass200_3()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x93B5B0", Offset = "0x93B5B0", VA = "0x93B5B0")]
			internal void <ctPlayAudio>b__1()
			{
			}
		}

		[Token(Token = "0x2000025")]
		private sealed class <>c__DisplayClass200_4
		{
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool buffered;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass200_0 CS$<>8__locals4;

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x93B5E4", Offset = "0x93B5E4", VA = "0x93B5E4")]
			public <>c__DisplayClass200_4()
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x93B5EC", Offset = "0x93B5EC", VA = "0x93B5EC")]
			internal void <ctPlayAudio>b__2()
			{
			}
		}

		[Token(Token = "0x2000026")]
		private sealed class <>c__DisplayClass200_5
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] pcmData;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass200_0 CS$<>8__locals5;

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x93B628", Offset = "0x93B628", VA = "0x93B628")]
			public <>c__DisplayClass200_5()
			{
			}
		}

		[Token(Token = "0x2000027")]
		private sealed class <>c__DisplayClass200_6
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int duration;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass200_5 CS$<>8__locals6;

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x93B630", Offset = "0x93B630", VA = "0x93B630")]
			public <>c__DisplayClass200_6()
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x93B638", Offset = "0x93B638", VA = "0x93B638")]
			internal void <ctPlayAudio>b__4()
			{
			}
		}

		[Token(Token = "0x2000028")]
		private sealed class <>c__DisplayClass200_7
		{
			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int duration;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass200_5 CS$<>8__locals7;

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x93B66C", Offset = "0x93B66C", VA = "0x93B66C")]
			public <>c__DisplayClass200_7()
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x93B674", Offset = "0x93B674", VA = "0x93B674")]
			internal void <ctPlayAudio>b__5()
			{
			}
		}

		[Token(Token = "0x2000029")]
		private sealed class <ctPlayAudio>d__200 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Turntable <>4__this;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool cache;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] data;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass200_1 <>8__1;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass200_4 <>8__2;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass200_5 <>8__3;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass200_0 <>8__4;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private AudioClip <ac>5__2;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int <totalSamples>5__3;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private UnityWebRequest <www>5__4;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Stream <>7__wrap4;

			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private bool <success>5__6;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Thread <reader>5__7;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private float <bufferCurrentProgress>5__8;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private int <bufferSize>5__9;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private float <elapsed>5__10;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private long <currentSize>5__11;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x940B78", Offset = "0x940B78", VA = "0x940B78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x940BC0", Offset = "0x940BC0", VA = "0x940BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x93A270", Offset = "0x93A270", VA = "0x93A270")]
			[DebuggerHidden]
			public <ctPlayAudio>d__200(int <>1__state)
			{
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x93B6A8", Offset = "0x93B6A8", VA = "0x93B6A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x93B81C", Offset = "0x93B81C", VA = "0x93B81C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x940994", Offset = "0x940994", VA = "0x940994")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x940784", Offset = "0x940784", VA = "0x940784")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x9406D4", Offset = "0x9406D4", VA = "0x9406D4")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x940834", Offset = "0x940834", VA = "0x940834")]
			private void <>m__Finally4()
			{
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x9408E4", Offset = "0x9408E4", VA = "0x9408E4")]
			private void <>m__Finally5()
			{
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x940B80", Offset = "0x940B80", VA = "0x940B80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002A")]
		private sealed class <unityPlayAudio>d__209 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Turntable <>4__this;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool cache;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioClip clip;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Record <_record>5__2;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private AudioClip <ac>5__4;

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x941BA0", Offset = "0x941BA0", VA = "0x941BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x941BE8", Offset = "0x941BE8", VA = "0x941BE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x93AB34", Offset = "0x93AB34", VA = "0x93AB34")]
			[DebuggerHidden]
			public <unityPlayAudio>d__209(int <>1__state)
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x940BC8", Offset = "0x940BC8", VA = "0x940BC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x940BE8", Offset = "0x940BE8", VA = "0x940BE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x941AF0", Offset = "0x941AF0", VA = "0x941AF0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x941BA8", Offset = "0x941BA8", VA = "0x941BA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("Record")]
		[SerializeField]
		private Record record;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[FormerlySerializedAs("PlayOnStart")]
		private bool playOnStart;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[FormerlySerializedAs("Delay")]
		[SerializeField]
		private float delay;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("HandleFocus")]
		[SerializeField]
		private bool handleFocus;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[FormerlySerializedAs("Caching")]
		[SerializeField]
		private bool caching;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		[SerializeField]
		private bool streaming;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[FormerlySerializedAs("ChunkSize")]
		[SerializeField]
		private int chunkSize;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[FormerlySerializedAs("UseAutomaticCacheStreamSize")]
		private bool useAutomaticCacheStreamSize;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		[FormerlySerializedAs("CacheStreamSize")]
		private int cacheStreamSize;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool useAutomaticBufferSize;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int bufferSize;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[FormerlySerializedAs("CaptureDataStream")]
		[SerializeField]
		private bool captureDataStream;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		[SerializeField]
		private bool forceInternalMP3Codec;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		[SerializeField]
		private bool forceInternalOGGCodec;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		[SerializeField]
		private bool internalCodecsReadPCM;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool ctdecoder;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool error;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string errorMessage;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private VorbisReader nVorbisReader;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private MpegFile nLayerReader;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int oggCacheCleanFrameCount;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Thread worker;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Thread timer;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool stopped;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool bufferAvailable;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		private bool playback;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Stream ms;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float ctPosition;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private bool paused;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioClip lastClip;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string lastPath;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<Record> playedRecords;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private AudioSource source;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool existsSource;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float pitch;

		[Token(Token = "0x4000054")]
		private const int sampleReserve = 256;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Turntable instance;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private byte[] <AudioData>k__BackingField;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<string, string> <RequestHeaders>k__BackingField;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private AudioCodec <Codec>k__BackingField;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float <BufferProgress>k__BackingField;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool <isAudioPlaying>k__BackingField;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Stream <DataStream>k__BackingField;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public PlaybackStartEvent OnPlaybackStarted;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public PlaybackEndEvent OnPlaybackEnded;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioStartEvent OnAudioStarted;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEndEvent OnAudioEnded;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public ErrorEvent OnError;

		[Token(Token = "0x1700005E")]
		public static Turntable Instance
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x929DEC", Offset = "0x929DEC", VA = "0x929DEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x935538", Offset = "0x935538", VA = "0x935538")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public override Record Record
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x935590", Offset = "0x935590", VA = "0x935590", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x935598", Offset = "0x935598", VA = "0x935598", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool PlayOnStart
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x9355A0", Offset = "0x9355A0", VA = "0x9355A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x9355A8", Offset = "0x9355A8", VA = "0x9355A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public float Delay
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x9355B4", Offset = "0x9355B4", VA = "0x9355B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x9355BC", Offset = "0x9355BC", VA = "0x9355BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public byte[] AudioData
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x9355C8", Offset = "0x9355C8", VA = "0x9355C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x9355D0", Offset = "0x9355D0", VA = "0x9355D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Dictionary<string, string> RequestHeaders
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x9355E0", Offset = "0x9355E0", VA = "0x9355E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public override bool HandleFocus
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x9355E8", Offset = "0x9355E8", VA = "0x9355E8", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x9355F0", Offset = "0x9355F0", VA = "0x9355F0", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public override bool Caching
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x9355FC", Offset = "0x9355FC", VA = "0x9355FC", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x935604", Offset = "0x935604", VA = "0x935604", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public override bool Streaming
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x935610", Offset = "0x935610", VA = "0x935610", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x9356A4", Offset = "0x9356A4", VA = "0x9356A4", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public override int ChunkSize
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x9356B0", Offset = "0x9356B0", VA = "0x9356B0", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x9356BC", Offset = "0x9356BC", VA = "0x9356BC", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool UseAutomaticCacheStreamSize
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x935760", Offset = "0x935760", VA = "0x935760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x935768", Offset = "0x935768", VA = "0x935768")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public override int CacheStreamSize
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x935774", Offset = "0x935774", VA = "0x935774", Slot = "21")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x935780", Offset = "0x935780", VA = "0x935780", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public bool UseAutomaticBufferSize
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x93581C", Offset = "0x93581C", VA = "0x93581C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x935824", Offset = "0x935824", VA = "0x935824")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public override int BufferSize
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x935830", Offset = "0x935830", VA = "0x935830", Slot = "23")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x93583C", Offset = "0x93583C", VA = "0x93583C", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public override bool CaptureDataStream
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x9358D8", Offset = "0x9358D8", VA = "0x9358D8", Slot = "25")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x9358E0", Offset = "0x9358E0", VA = "0x9358E0", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public override bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x9358EC", Offset = "0x9358EC", VA = "0x9358EC", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x935978", Offset = "0x935978", VA = "0x935978", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public override bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x935984", Offset = "0x935984", VA = "0x935984", Slot = "29")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x935A20", Offset = "0x935A20", VA = "0x935A20", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public bool InternalCodecsReadPCM
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x935A2C", Offset = "0x935A2C", VA = "0x935A2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x935A34", Offset = "0x935A34", VA = "0x935A34")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public override bool isLoop
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x935A40", Offset = "0x935A40", VA = "0x935A40", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x935AD4", Offset = "0x935AD4", VA = "0x935AD4", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public override AudioSource Source
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x935B78", Offset = "0x935B78", VA = "0x935B78", Slot = "31")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x935B80", Offset = "0x935B80", VA = "0x935B80", Slot = "32")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public override float Position
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x935C00", Offset = "0x935C00", VA = "0x935C00", Slot = "33")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x935D8C", Offset = "0x935D8C", VA = "0x935D8C", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public override int SamplePosition
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x936020", Offset = "0x936020", VA = "0x936020", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x9361AC", Offset = "0x9361AC", VA = "0x9361AC", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public override float Elapsed
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x936348", Offset = "0x936348", VA = "0x936348", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x936584", Offset = "0x936584", VA = "0x936584", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public override float Duration
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x9367C0", Offset = "0x9367C0", VA = "0x9367C0", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000076")]
		public override int Samples
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x9367EC", Offset = "0x9367EC", VA = "0x9367EC", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000077")]
		public override int Channels
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x936968", Offset = "0x936968", VA = "0x936968", Slot = "53")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000078")]
		public override int SampleRate
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x936988", Offset = "0x936988", VA = "0x936988", Slot = "54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000079")]
		public override AudioCodec Codec
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x9369A8", Offset = "0x9369A8", VA = "0x9369A8", Slot = "41")]
			get
			{
				return default(AudioCodec);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x9369B0", Offset = "0x9369B0", VA = "0x9369B0", Slot = "42")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public override float BufferProgress
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x9369B8", Offset = "0x9369B8", VA = "0x9369B8", Slot = "43")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x9369C0", Offset = "0x9369C0", VA = "0x9369C0", Slot = "44")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public override bool isPlayback
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x9369C8", Offset = "0x9369C8", VA = "0x9369C8", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public override bool isAudioPlaying
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x9369D0", Offset = "0x9369D0", VA = "0x9369D0", Slot = "47")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x9369D8", Offset = "0x9369D8", VA = "0x9369D8", Slot = "48")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override bool isBuffering
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x9369E4", Offset = "0x9369E4", VA = "0x9369E4", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		public override bool isPaused
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x9369F4", Offset = "0x9369F4", VA = "0x9369F4", Slot = "49")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x9369FC", Offset = "0x9369FC", VA = "0x9369FC", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public override Stream DataStream
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x936A58", Offset = "0x936A58", VA = "0x936A58", Slot = "51")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x936A60", Offset = "0x936A60", VA = "0x936A60", Slot = "52")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public override float Volume
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x936A70", Offset = "0x936A70", VA = "0x936A70", Slot = "55")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x936AAC", Offset = "0x936AAC", VA = "0x936AAC", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public override float Pitch
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x936AF8", Offset = "0x936AF8", VA = "0x936AF8", Slot = "57")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x936B34", Offset = "0x936B34", VA = "0x936B34", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public override float StereoPan
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x936B80", Offset = "0x936B80", VA = "0x936B80", Slot = "59")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x936BBC", Offset = "0x936BBC", VA = "0x936BBC", Slot = "60")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public override bool isMuted
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x936C08", Offset = "0x936C08", VA = "0x936C08", Slot = "61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x936C44", Offset = "0x936C44", VA = "0x936C44", Slot = "62")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public override List<Record> PlayedRecords
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x936C84", Offset = "0x936C84", VA = "0x936C84", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		protected override PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x936C8C", Offset = "0x936C8C", VA = "0x936C8C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		protected override PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x936C94", Offset = "0x936C94", VA = "0x936C94", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		protected override AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x936C9C", Offset = "0x936C9C", VA = "0x936C9C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		protected override AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x936CA4", Offset = "0x936CA4", VA = "0x936CA4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		protected override ErrorEvent onError
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x936CAC", Offset = "0x936CAC", VA = "0x936CAC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000F")]
		public event Cached OnCached
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x936CB4", Offset = "0x936CB4", VA = "0x936CB4")]
			add
			{
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x936D54", Offset = "0x936D54", VA = "0x936D54")]
			remove
			{
			}
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x936DF4", Offset = "0x936DF4", VA = "0x936DF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x936FBC", Offset = "0x936FBC", VA = "0x936FBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x937050", Offset = "0x937050", VA = "0x937050")]
		private void Update()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x937358", Offset = "0x937358", VA = "0x937358")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x937368", Offset = "0x937368", VA = "0x937368")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x937504", Offset = "0x937504", VA = "0x937504")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x9375D8", Offset = "0x9375D8", VA = "0x9375D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x93781C", Offset = "0x93781C", VA = "0x93781C")]
		public void Play(Record _record)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x9378D0", Offset = "0x9378D0", VA = "0x9378D0", Slot = "64")]
		public override void Play()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x938448", Offset = "0x938448", VA = "0x938448")]
		public void Cache(Record _record)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x9384F0", Offset = "0x9384F0", VA = "0x9384F0")]
		public void Cache()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x938590", Offset = "0x938590", VA = "0x938590", Slot = "65")]
		public override void Next()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x9385A0", Offset = "0x9385A0", VA = "0x9385A0", Slot = "66")]
		public override void Previous()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x9385B0", Offset = "0x9385B0", VA = "0x9385B0", Slot = "67")]
		public override void Pause()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x938644", Offset = "0x938644", VA = "0x938644", Slot = "68")]
		public override void UnPause()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x9386D8", Offset = "0x9386D8", VA = "0x9386D8", Slot = "69")]
		public override void Stop()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x9387A8", Offset = "0x9387A8", VA = "0x9387A8", Slot = "70")]
		public override void Restart()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x9388BC", Offset = "0x9388BC", VA = "0x9388BC", Slot = "71")]
		public override void Mute()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x938950", Offset = "0x938950", VA = "0x938950", Slot = "72")]
		public override void UnMute()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x937958", Offset = "0x937958", VA = "0x937958")]
		private void playOrCache(bool cache = false)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x938CC4", Offset = "0x938CC4", VA = "0x938CC4")]
		private void logUnsupportedPlatform()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x938D80", Offset = "0x938D80", VA = "0x938D80")]
		private void logDataError(Exception ex)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x936394", Offset = "0x936394", VA = "0x936394")]
		private float elapsedDuration()
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x938FF0", Offset = "0x938FF0", VA = "0x938FF0")]
		private void resetReaderPosition()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x939158", Offset = "0x939158", VA = "0x939158")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x9393DC", Offset = "0x9393DC", VA = "0x9393DC")]
		private void timerTask(ref bool _playback)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x939524", Offset = "0x939524", VA = "0x939524")]
		private void readStream(ref Record _record, ref bool _playback, ref Stream _ms, ref bool _error, ref string _errorMessage, ref bool _buffered)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x93A0F0", Offset = "0x93A0F0", VA = "0x93A0F0")]
		private static AudioType determineAudioType(AudioFormat audioFormat)
		{
			return default(AudioType);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x938C64", Offset = "0x938C64", VA = "0x938C64")]
		private void ctPlay(bool cache)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x9389EC", Offset = "0x9389EC", VA = "0x9389EC")]
		private void ctPlayWithData(byte[] data, bool cache = false)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x93A1D4", Offset = "0x93A1D4", VA = "0x93A1D4")]
		private IEnumerator ctPlayAudio(byte[] data, bool cache)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x93A298", Offset = "0x93A298", VA = "0x93A298")]
		private void updateDuration()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x93A508", Offset = "0x93A508", VA = "0x93A508")]
		private void waitController(Record _record)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x93A754", Offset = "0x93A754", VA = "0x93A754")]
		private void readPCMNLayer(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x93A958", Offset = "0x93A958", VA = "0x93A958")]
		private void readPCMNAudio(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x93A968", Offset = "0x93A968", VA = "0x93A968")]
		private void readPCMNVorbis(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x93A884", Offset = "0x93A884", VA = "0x93A884")]
		private void writeDataStream(float[] pcmData)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x938C98", Offset = "0x938C98", VA = "0x938C98")]
		private void unityPlay(bool cache)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x938C70", Offset = "0x938C70", VA = "0x938C70")]
		private void unityPlayWithClip(AudioClip clip, bool cache = false)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x93AA98", Offset = "0x93AA98", VA = "0x93AA98")]
		private IEnumerator unityPlayAudio(AudioClip clip, bool cache)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x9376C0", Offset = "0x9376C0", VA = "0x9376C0")]
		protected void killWorker()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x93AB5C", Offset = "0x93AB5C", VA = "0x93AB5C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x93B068", Offset = "0x93B068", VA = "0x93B068", Slot = "76")]
		protected override void onPlaybackStart(Record _record)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x93B100", Offset = "0x93B100", VA = "0x93B100", Slot = "77")]
		protected override void onPlaybackEnd(Record _record)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x93B198", Offset = "0x93B198", VA = "0x93B198", Slot = "81")]
		protected override void onAudioStart(Record _record)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x93B23C", Offset = "0x93B23C", VA = "0x93B23C", Slot = "82")]
		protected override void onAudioEnd(Record _record)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x93B2E0", Offset = "0x93B2E0", VA = "0x93B2E0", Slot = "86")]
		protected virtual void onCached(Record _record)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x93B3F4", Offset = "0x93B3F4", VA = "0x93B3F4")]
		public Turntable()
		{
		}
	}
}
namespace Crosstales.DJ.Util
{
	[Token(Token = "0x200002B")]
	public static class Config
	{
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DEBUG;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int DEFAULT_CHUNKSIZE;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int DEFAULT_CACHESTREAMSIZE;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int MAX_CACHESTREAMSIZE;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int DEFAULT_BUFFERSIZE;
	}
	[Token(Token = "0x200002C")]
	public abstract class Constants : BaseConstants
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static AudioCodec DEFAULT_CODEC_MP3_WINDOWS;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float INVOKE_DELAY;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static float PLAY_CALL_SPEED;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string TEXT_BUFFER;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string TEXT_STOPPED;
	}
	[Token(Token = "0x200002D")]
	public static class Context
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int TotalRecordsPlayed;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static double TotalPlayTime;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly List<Record> AllPlayedRecords;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int NumberOfCachedData;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int NumberOfNonCachedData;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int NumberOfCachedClips;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int NumberOfNonCachedClips;
	}
	[Token(Token = "0x200002E")]
	public abstract class Helper : BaseHelper
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] mp3Bitrates;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] oggBitrates;

		[Token(Token = "0x1700008E")]
		public static bool isSupportedPlatform
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x9389E4", Offset = "0x9389E4", VA = "0x9389E4")]
			get
			{
				return default(bool);
			}
		}
	}
	[Token(Token = "0x200002F")]
	public class SetupProject
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x941F04", Offset = "0x941F04", VA = "0x941F04")]
		static SetupProject()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x941F08", Offset = "0x941F08", VA = "0x941F08")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void setup()
		{
		}
	}
}
namespace Crosstales.DJ.Set
{
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	public abstract class BaseSet : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000031")]
		private sealed class <>c
		{
			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<double, Record, double> <>9__83_0;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Record, long> <>9__85_0;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<double, Record, double> <>9__95_0;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Record, long> <>9__96_0;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<Record, string> <>9__97_0;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<Record, string> <>9__97_1;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<Record, string> <>9__97_2;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<Record, string> <>9__97_3;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<Record, string> <>9__98_0;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Func<Record, string> <>9__98_1;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<Record, string> <>9__98_2;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Func<Record, string> <>9__98_3;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static Func<Record, string> <>9__99_0;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static Func<Record, string> <>9__99_1;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static Func<Record, string> <>9__99_2;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static Func<Record, string> <>9__99_3;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static Func<Record, string> <>9__100_0;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static Func<Record, string> <>9__100_1;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static Func<Record, string> <>9__100_2;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static Func<Record, string> <>9__100_3;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static Func<Record, string> <>9__100_4;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static Func<Record, string> <>9__100_5;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static Func<Record, string> <>9__100_6;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static Func<Record, string> <>9__100_7;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static Func<Record, string> <>9__101_0;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static Func<Record, string> <>9__101_1;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public static Func<Record, string> <>9__101_2;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public static Func<Record, string> <>9__101_3;

			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public static Func<Record, string> <>9__101_4;

			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public static Func<Record, string> <>9__101_5;

			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public static Func<Record, string> <>9__101_6;

			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public static Func<Record, string> <>9__101_7;

			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public static Func<Record, string> <>9__102_0;

			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public static Func<Record, string> <>9__102_1;

			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public static Func<Record, string> <>9__102_2;

			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			public static Func<Record, string> <>9__102_3;

			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public static Func<Record, string> <>9__102_4;

			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public static Func<Record, string> <>9__102_5;

			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public static Func<Record, string> <>9__102_6;

			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			public static Func<Record, string> <>9__102_7;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public static Func<Record, float> <>9__103_0;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			public static Func<Record, string> <>9__103_1;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			public static Func<Record, float> <>9__103_2;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public static Func<Record, string> <>9__103_3;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public static Func<Record, float> <>9__103_4;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			public static Func<Record, string> <>9__103_5;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			public static Func<Record, float> <>9__103_6;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			public static Func<Record, string> <>9__103_7;

			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			public static Func<Record, int> <>9__104_0;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			public static Func<Record, string> <>9__104_1;

			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			public static Func<Record, int> <>9__104_2;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			public static Func<Record, string> <>9__104_3;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			public static Func<Record, int> <>9__104_4;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			public static Func<Record, string> <>9__104_5;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			public static Func<Record, int> <>9__104_6;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			public static Func<Record, string> <>9__104_7;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			public static Func<Record, float> <>9__105_0;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			public static Func<Record, string> <>9__105_1;

			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			public static Func<Record, float> <>9__105_2;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			public static Func<Record, string> <>9__105_3;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			public static Func<Record, float> <>9__105_4;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			public static Func<Record, string> <>9__105_5;

			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			public static Func<Record, float> <>9__105_6;

			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			public static Func<Record, string> <>9__105_7;

			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			public static Func<Record, long> <>9__106_0;

			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			public static Func<Record, string> <>9__106_1;

			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			public static Func<Record, long> <>9__106_2;

			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			public static Func<Record, string> <>9__106_3;

			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			public static Func<Record, long> <>9__106_4;

			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			public static Func<Record, string> <>9__106_5;

			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			public static Func<Record, long> <>9__106_6;

			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			public static Func<Record, string> <>9__106_7;

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			public static Func<Record, AudioFormat> <>9__107_0;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			public static Func<Record, string> <>9__107_1;

			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			public static Func<Record, AudioFormat> <>9__107_2;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
			public static Func<Record, string> <>9__107_3;

			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			public static Func<Record, AudioFormat> <>9__107_4;

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			public static Func<Record, string> <>9__107_5;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			public static Func<Record, AudioFormat> <>9__107_6;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			public static Func<Record, string> <>9__107_7;

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x944B58", Offset = "0x944B58", VA = "0x944B58")]
			public <>c()
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x944B60", Offset = "0x944B60", VA = "0x944B60")]
			internal double <get_TotalPlaytime>b__83_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x944D00", Offset = "0x944D00", VA = "0x944D00")]
			internal long <get_TotalSize>b__85_0(Record record)
			{
				return default(long);
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x944D70", Offset = "0x944D70", VA = "0x944D70")]
			internal double <PlaytimeRecords>b__95_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x944DA0", Offset = "0x944DA0", VA = "0x944DA0")]
			internal long <SizeRecords>b__96_0(Record record)
			{
				return default(long);
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x944DDC", Offset = "0x944DDC", VA = "0x944DDC")]
			internal string <RecordsByFilePath>b__97_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x944DF4", Offset = "0x944DF4", VA = "0x944DF4")]
			internal string <RecordsByFilePath>b__97_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x944E0C", Offset = "0x944E0C", VA = "0x944E0C")]
			internal string <RecordsByFilePath>b__97_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x944E24", Offset = "0x944E24", VA = "0x944E24")]
			internal string <RecordsByFilePath>b__97_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x944E3C", Offset = "0x944E3C", VA = "0x944E3C")]
			internal string <RecordsByName>b__98_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x94511C", Offset = "0x94511C", VA = "0x94511C")]
			internal string <RecordsByName>b__98_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x945130", Offset = "0x945130", VA = "0x945130")]
			internal string <RecordsByName>b__98_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x945144", Offset = "0x945144", VA = "0x945144")]
			internal string <RecordsByName>b__98_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x945158", Offset = "0x945158", VA = "0x945158")]
			internal string <RecordsByTitle>b__99_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x9451A8", Offset = "0x9451A8", VA = "0x9451A8")]
			internal string <RecordsByTitle>b__99_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x9451D4", Offset = "0x9451D4", VA = "0x9451D4")]
			internal string <RecordsByTitle>b__99_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x945200", Offset = "0x945200", VA = "0x945200")]
			internal string <RecordsByTitle>b__99_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x94522C", Offset = "0x94522C", VA = "0x94522C")]
			internal string <RecordsByArtist>b__100_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x94527C", Offset = "0x94527C", VA = "0x94527C")]
			internal string <RecordsByArtist>b__100_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x945290", Offset = "0x945290", VA = "0x945290")]
			internal string <RecordsByArtist>b__100_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000233")]
			[Address(RVA = "0x9452BC", Offset = "0x9452BC", VA = "0x9452BC")]
			internal string <RecordsByArtist>b__100_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x9452D0", Offset = "0x9452D0", VA = "0x9452D0")]
			internal string <RecordsByArtist>b__100_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x9452FC", Offset = "0x9452FC", VA = "0x9452FC")]
			internal string <RecordsByArtist>b__100_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x945310", Offset = "0x945310", VA = "0x945310")]
			internal string <RecordsByArtist>b__100_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x94533C", Offset = "0x94533C", VA = "0x94533C")]
			internal string <RecordsByArtist>b__100_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x945350", Offset = "0x945350", VA = "0x945350")]
			internal string <RecordsByAlbum>b__101_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x9453A0", Offset = "0x9453A0", VA = "0x9453A0")]
			internal string <RecordsByAlbum>b__101_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x9453B4", Offset = "0x9453B4", VA = "0x9453B4")]
			internal string <RecordsByAlbum>b__101_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x9453E0", Offset = "0x9453E0", VA = "0x9453E0")]
			internal string <RecordsByAlbum>b__101_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x9453F4", Offset = "0x9453F4", VA = "0x9453F4")]
			internal string <RecordsByAlbum>b__101_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x945420", Offset = "0x945420", VA = "0x945420")]
			internal string <RecordsByAlbum>b__101_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x945434", Offset = "0x945434", VA = "0x945434")]
			internal string <RecordsByAlbum>b__101_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x945460", Offset = "0x945460", VA = "0x945460")]
			internal string <RecordsByAlbum>b__101_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x945474", Offset = "0x945474", VA = "0x945474")]
			internal string <RecordsByGenre>b__102_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x9454C4", Offset = "0x9454C4", VA = "0x9454C4")]
			internal string <RecordsByGenre>b__102_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x9454D8", Offset = "0x9454D8", VA = "0x9454D8")]
			internal string <RecordsByGenre>b__102_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x945504", Offset = "0x945504", VA = "0x945504")]
			internal string <RecordsByGenre>b__102_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x945518", Offset = "0x945518", VA = "0x945518")]
			internal string <RecordsByGenre>b__102_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x945544", Offset = "0x945544", VA = "0x945544")]
			internal string <RecordsByGenre>b__102_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000246")]
			[Address(RVA = "0x945558", Offset = "0x945558", VA = "0x945558")]
			internal string <RecordsByGenre>b__102_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x945584", Offset = "0x945584", VA = "0x945584")]
			internal string <RecordsByGenre>b__102_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000248")]
			[Address(RVA = "0x945598", Offset = "0x945598", VA = "0x945598")]
			internal float <RecordsByRating>b__103_0(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0x9455B0", Offset = "0x9455B0", VA = "0x9455B0")]
			internal string <RecordsByRating>b__103_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024A")]
			[Address(RVA = "0x9455C4", Offset = "0x9455C4", VA = "0x9455C4")]
			internal float <RecordsByRating>b__103_2(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0x9455DC", Offset = "0x9455DC", VA = "0x9455DC")]
			internal string <RecordsByRating>b__103_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0x9455F0", Offset = "0x9455F0", VA = "0x9455F0")]
			internal float <RecordsByRating>b__103_4(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x945608", Offset = "0x945608", VA = "0x945608")]
			internal string <RecordsByRating>b__103_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x94561C", Offset = "0x94561C", VA = "0x94561C")]
			internal float <RecordsByRating>b__103_6(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x945634", Offset = "0x945634", VA = "0x945634")]
			internal string <RecordsByRating>b__103_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x945648", Offset = "0x945648", VA = "0x945648")]
			internal int <RecordsByYear>b__104_0(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x9456A0", Offset = "0x9456A0", VA = "0x9456A0")]
			internal string <RecordsByYear>b__104_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x9456B4", Offset = "0x9456B4", VA = "0x9456B4")]
			internal int <RecordsByYear>b__104_2(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x9456E4", Offset = "0x9456E4", VA = "0x9456E4")]
			internal string <RecordsByYear>b__104_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x9456F8", Offset = "0x9456F8", VA = "0x9456F8")]
			internal int <RecordsByYear>b__104_4(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x945728", Offset = "0x945728", VA = "0x945728")]
			internal string <RecordsByYear>b__104_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x94573C", Offset = "0x94573C", VA = "0x94573C")]
			internal int <RecordsByYear>b__104_6(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x94576C", Offset = "0x94576C", VA = "0x94576C")]
			internal string <RecordsByYear>b__104_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x945780", Offset = "0x945780", VA = "0x945780")]
			internal float <RecordsByDuration>b__105_0(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x945794", Offset = "0x945794", VA = "0x945794")]
			internal string <RecordsByDuration>b__105_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x9457A8", Offset = "0x9457A8", VA = "0x9457A8")]
			internal float <RecordsByDuration>b__105_2(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x9457BC", Offset = "0x9457BC", VA = "0x9457BC")]
			internal string <RecordsByDuration>b__105_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x9457D0", Offset = "0x9457D0", VA = "0x9457D0")]
			internal float <RecordsByDuration>b__105_4(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x9457E4", Offset = "0x9457E4", VA = "0x9457E4")]
			internal string <RecordsByDuration>b__105_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x9457F8", Offset = "0x9457F8", VA = "0x9457F8")]
			internal float <RecordsByDuration>b__105_6(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x94580C", Offset = "0x94580C", VA = "0x94580C")]
			internal string <RecordsByDuration>b__105_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x945820", Offset = "0x945820", VA = "0x945820")]
			internal long <RecordsByFileSize>b__106_0(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x94585C", Offset = "0x94585C", VA = "0x94585C")]
			internal string <RecordsByFileSize>b__106_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x945870", Offset = "0x945870", VA = "0x945870")]
			internal long <RecordsByFileSize>b__106_2(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x9458AC", Offset = "0x9458AC", VA = "0x9458AC")]
			internal string <RecordsByFileSize>b__106_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x9458C0", Offset = "0x9458C0", VA = "0x9458C0")]
			internal long <RecordsByFileSize>b__106_4(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x9458FC", Offset = "0x9458FC", VA = "0x9458FC")]
			internal string <RecordsByFileSize>b__106_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x945910", Offset = "0x945910", VA = "0x945910")]
			internal long <RecordsByFileSize>b__106_6(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x94594C", Offset = "0x94594C", VA = "0x94594C")]
			internal string <RecordsByFileSize>b__106_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x945960", Offset = "0x945960", VA = "0x945960")]
			internal AudioFormat <RecordsByFormat>b__107_0(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x945CD8", Offset = "0x945CD8", VA = "0x945CD8")]
			internal string <RecordsByFormat>b__107_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x945CEC", Offset = "0x945CEC", VA = "0x945CEC")]
			internal AudioFormat <RecordsByFormat>b__107_2(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x945D00", Offset = "0x945D00", VA = "0x945D00")]
			internal string <RecordsByFormat>b__107_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x945D14", Offset = "0x945D14", VA = "0x945D14")]
			internal AudioFormat <RecordsByFormat>b__107_4(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x945D28", Offset = "0x945D28", VA = "0x945D28")]
			internal string <RecordsByFormat>b__107_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x945D3C", Offset = "0x945D3C", VA = "0x945D3C")]
			internal AudioFormat <RecordsByFormat>b__107_6(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x945D50", Offset = "0x945D50", VA = "0x945D50")]
			internal string <RecordsByFormat>b__107_7(Record entry)
			{
				return null;
			}
		}

		[Token(Token = "0x2000032")]
		private sealed class <>c__DisplayClass114_0
		{
			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int hashCode;

			[Token(Token = "0x6000270")]
			[Address(RVA = "0x945D64", Offset = "0x945D64", VA = "0x945D64")]
			public <>c__DisplayClass114_0()
			{
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x945D6C", Offset = "0x945D6C", VA = "0x945D6C")]
			internal bool <recordFromHashCode>b__0(Record record)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000033")]
		private sealed class <>c__DisplayClass118_0
		{
			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RecordFilter _filter;

			[Token(Token = "0x6000272")]
			[Address(RVA = "0x945DA4", Offset = "0x945DA4", VA = "0x945DA4")]
			public <>c__DisplayClass118_0()
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x945DAC", Offset = "0x945DAC", VA = "0x945DAC")]
			internal bool <filterRecords>b__0(Record entry)
			{
				return default(bool);
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x9462D0", Offset = "0x9462D0", VA = "0x9462D0")]
			internal bool <filterRecords>b__1(Record entry)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("Filter")]
		[SerializeField]
		private RecordFilter filter;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int recordIndex;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int randomRecordIndex;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<Record> randomRecords;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<Record> allRecords;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool cleared;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool clearedRandom;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RecordFilter lastRecordFilter;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RecordFilter lastRandomRecordFilter;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Record> lastFilteredRecords;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Record> lastFilteredRandomRecords;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RecordFilter recordsByFilePathFilterDesc;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RecordFilter recordsByFilePathFilterAsc;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<Record> recordsByFilePathDesc;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Record> recordsByFilePathAsc;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RecordFilter recordsByNameFilterDesc;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RecordFilter recordsByNameFilterAsc;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<Record> recordsByNameDesc;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<Record> recordsByNameAsc;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RecordFilter recordsByTitleFilterDesc;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RecordFilter recordsByTitleFilterAsc;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<Record> recordsByTitleDesc;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<Record> recordsByTitleAsc;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RecordFilter recordsByArtistFilterDesc;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RecordFilter recordsByArtistFilterAsc;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Record> recordsByArtistDesc;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Record> recordsByArtistAsc;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RecordFilter recordsByAlbumFilterDesc;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RecordFilter recordsByAlbumFilterAsc;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<Record> recordsByAlbumDesc;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<Record> recordsByAlbumAsc;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RecordFilter recordsByGenreFilterDesc;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RecordFilter recordsByGenreFilterAsc;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<Record> recordsByGenreDesc;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<Record> recordsByGenreAsc;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RecordFilter recordsByRatingFilterDesc;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private RecordFilter recordsByRatingFilterAsc;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<Record> recordsByRatingDesc;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<Record> recordsByRatingAsc;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RecordFilter recordsByYearFilterDesc;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private RecordFilter recordsByYearFilterAsc;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private List<Record> recordsByYearDesc;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<Record> recordsByYearAsc;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RecordFilter recordsByDurationFilterDesc;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private RecordFilter recordsByDurationFilterAsc;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<Record> recordsByDurationDesc;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<Record> recordsByDurationAsc;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private RecordFilter recordsByFileSizeFilterDesc;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private RecordFilter recordsByFileSizeFilterAsc;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<Record> recordsByFileSizeDesc;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private List<Record> recordsByFileSizeAsc;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private RecordFilter recordsByFormatFilterDesc;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private RecordFilter recordsByFormatFilterAsc;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private List<Record> recordsByFormatDesc;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private List<Record> recordsByFormatAsc;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private RecordFilter currentFilter;

		[Token(Token = "0x1700008F")]
		public RecordFilter Filter
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x941F84", Offset = "0x941F84", VA = "0x941F84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x941F8C", Offset = "0x941F8C", VA = "0x941F8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		protected abstract RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60001E9")]
			get;
		}

		[Token(Token = "0x17000091")]
		protected abstract FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x60001EA")]
			get;
		}

		[Token(Token = "0x17000092")]
		protected abstract ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60001EB")]
			get;
		}

		[Token(Token = "0x17000093")]
		public abstract List<Record> Records
		{
			[Token(Token = "0x60001F4")]
			get;
		}

		[Token(Token = "0x17000094")]
		public abstract List<Record> RandomRecords
		{
			[Token(Token = "0x60001F5")]
			get;
		}

		[Token(Token = "0x17000095")]
		public abstract bool isReady
		{
			[Token(Token = "0x60001F6")]
			get;
		}

		[Token(Token = "0x17000096")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x92C390", Offset = "0x92C390", VA = "0x92C390", Slot = "10")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000097")]
		public long TotalSize
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x92C534", Offset = "0x92C534", VA = "0x92C534", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000098")]
		public int CurrentRecordIndex
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x942188", Offset = "0x942188", VA = "0x942188", Slot = "12")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x92C764", Offset = "0x92C764", VA = "0x92C764", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public int CurrentRandomRecordIndex
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x942190", Offset = "0x942190", VA = "0x942190", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x92C8E8", Offset = "0x92C8E8", VA = "0x92C8E8", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event FilterChange OnFilterChange
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x92ACA8", Offset = "0x92ACA8", VA = "0x92ACA8")]
			add
			{
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x92B3D4", Offset = "0x92B3D4", VA = "0x92B3D4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x92AD48", Offset = "0x92AD48", VA = "0x92AD48")]
			add
			{
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x92B474", Offset = "0x92B474", VA = "0x92B474")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x92ADE8", Offset = "0x92ADE8", VA = "0x92ADE8")]
			add
			{
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x92B514", Offset = "0x92B514", VA = "0x92B514")]
			remove
			{
			}
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x942030", Offset = "0x942030", VA = "0x942030")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x9420B0", Offset = "0x9420B0", VA = "0x9420B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FD")]
		public abstract void Load();

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x92CC6C", Offset = "0x92CC6C", VA = "0x92CC6C", Slot = "17")]
		public List<Record> GetRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x92CD84", Offset = "0x92CD84", VA = "0x92CD84", Slot = "18")]
		public int CountRecords([Optional] RecordFilter _filter)
		{
			return default(int);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x92CE98", Offset = "0x92CE98", VA = "0x92CE98", Slot = "19")]
		public double PlaytimeRecords([Optional] RecordFilter _filter)
		{
			return default(double);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x92D070", Offset = "0x92D070", VA = "0x92D070", Slot = "20")]
		public long SizeRecords([Optional] RecordFilter _filter)
		{
			return default(long);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x92D3F8", Offset = "0x92D3F8", VA = "0x92D3F8", Slot = "21")]
		public List<Record> RecordsByFilePath(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x92DCB8", Offset = "0x92DCB8", VA = "0x92DCB8", Slot = "22")]
		public List<Record> RecordsByName(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x92E55C", Offset = "0x92E55C", VA = "0x92E55C", Slot = "23")]
		public List<Record> RecordsByTitle(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x92EE00", Offset = "0x92EE00", VA = "0x92EE00", Slot = "24")]
		public List<Record> RecordsByArtist(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x92F958", Offset = "0x92F958", VA = "0x92F958", Slot = "25")]
		public List<Record> RecordsByAlbum(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x9304B4", Offset = "0x9304B4", VA = "0x9304B4", Slot = "26")]
		public List<Record> RecordsByGenre(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x931018", Offset = "0x931018", VA = "0x931018", Slot = "27")]
		public List<Record> RecordsByRating(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x931BA8", Offset = "0x931BA8", VA = "0x931BA8", Slot = "28")]
		public List<Record> RecordsByYear(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x932738", Offset = "0x932738", VA = "0x932738", Slot = "29")]
		public List<Record> RecordsByDuration(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x9332C8", Offset = "0x9332C8", VA = "0x9332C8", Slot = "30")]
		public List<Record> RecordsByFileSize(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x933E58", Offset = "0x933E58", VA = "0x933E58", Slot = "31")]
		public List<Record> RecordsByFormat(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x92BDA0", Offset = "0x92BDA0", VA = "0x92BDA0", Slot = "32")]
		public Record RecordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x92D304", Offset = "0x92D304", VA = "0x92D304", Slot = "33")]
		public Record RecordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x92C9E4", Offset = "0x92C9E4", VA = "0x92C9E4", Slot = "34")]
		public Record Next(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x92CA14", Offset = "0x92CA14", VA = "0x92CA14", Slot = "35")]
		public Record Previous(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x92CAD8", Offset = "0x92CAD8", VA = "0x92CAD8", Slot = "36")]
		public void RandomizeRecords(bool resetIndex = true)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x9427BC", Offset = "0x9427BC", VA = "0x9427BC")]
		private Record recordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x9428DC", Offset = "0x9428DC", VA = "0x9428DC")]
		private Record recordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x942A08", Offset = "0x942A08", VA = "0x942A08")]
		private Record next(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x942B3C", Offset = "0x942B3C", VA = "0x942B3C")]
		private Record previous(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x942198", Offset = "0x942198", VA = "0x942198")]
		private RecordFilter getFilter(RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x9421EC", Offset = "0x9421EC", VA = "0x9421EC")]
		private IEnumerable<Record> filterRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x942C60", Offset = "0x942C60", VA = "0x942C60")]
		protected void clearFilters(bool clearLastFilter = true, bool clearLastRandomFilter = true)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x942E28", Offset = "0x942E28", VA = "0x942E28")]
		protected void resetFilterLists()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x943234", Offset = "0x943234", VA = "0x943234", Slot = "37")]
		protected virtual void onFilterChange()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x9433C0", Offset = "0x9433C0", VA = "0x9433C0", Slot = "38")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x943554", Offset = "0x943554", VA = "0x943554", Slot = "39")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x9436AC", Offset = "0x9436AC", VA = "0x9436AC")]
		protected BaseSet()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	public class DJSet : BaseSet
	{
		[Token(Token = "0x2000035")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Record> result;

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Record, bool> <>9__3;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<BaseSet, IEnumerable<Record>> <>9__2;

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x947720", Offset = "0x947720", VA = "0x947720")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x9484CC", Offset = "0x9484CC", VA = "0x9484CC")]
			internal IEnumerable<Record> <get_Records>b__2(BaseSet rs)
			{
				return null;
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x9485A4", Offset = "0x9485A4", VA = "0x9485A4")]
			internal bool <get_Records>b__3(Record record)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		private sealed class <>c
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<BaseSet, bool> <>9__14_1;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Record, string> <>9__14_0;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<BaseSet, bool> <>9__16_1;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Record, string> <>9__16_0;

			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<BaseSet, bool> <>9__18_0;

			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<BaseSet, bool> <>9__21_0;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<BaseSet, bool> <>9__23_0;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<BaseSet, bool> <>9__24_0;

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x948678", Offset = "0x948678", VA = "0x948678")]
			public <>c()
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x948680", Offset = "0x948680", VA = "0x948680")]
			internal bool <get_Records>b__14_1(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x9486DC", Offset = "0x9486DC", VA = "0x9486DC")]
			internal string <get_Records>b__14_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x9486F4", Offset = "0x9486F4", VA = "0x9486F4")]
			internal bool <get_RandomRecords>b__16_1(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x948750", Offset = "0x948750", VA = "0x948750")]
			internal string <get_RandomRecords>b__16_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x948768", Offset = "0x948768", VA = "0x948768")]
			internal bool <get_isReady>b__18_0(BaseSet provider)
			{
				return default(bool);
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x9487F0", Offset = "0x9487F0", VA = "0x9487F0")]
			internal bool <Load>b__21_0(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x948874", Offset = "0x948874", VA = "0x948874")]
			internal bool <register>b__23_0(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x9488D0", Offset = "0x9488D0", VA = "0x9488D0")]
			internal bool <unregister>b__24_0(BaseSet rs)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000037")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Record> result;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Record, bool> <>9__3;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<BaseSet, IEnumerable<Record>> <>9__2;

			[Token(Token = "0x6000291")]
			[Address(RVA = "0x947DCC", Offset = "0x947DCC", VA = "0x947DCC")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x94892C", Offset = "0x94892C", VA = "0x94892C")]
			internal IEnumerable<Record> <get_RandomRecords>b__2(BaseSet rs)
			{
				return null;
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x948A04", Offset = "0x948A04", VA = "0x948A04")]
			internal bool <get_RandomRecords>b__3(Record record)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[FormerlySerializedAs("Sets")]
		public BaseSet[] sets;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public FilterChangeEvent OnFilterChanged;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x1700009A")]
		public BaseSet[] Sets
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x946698", Offset = "0x946698", VA = "0x946698")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x9466A0", Offset = "0x9466A0", VA = "0x9466A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x947064", Offset = "0x947064", VA = "0x947064", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		protected override FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x94706C", Offset = "0x94706C", VA = "0x94706C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x947074", Offset = "0x947074", VA = "0x947074", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public override List<Record> Records
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x94707C", Offset = "0x94707C", VA = "0x94707C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public override List<Record> RandomRecords
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x947728", Offset = "0x947728", VA = "0x947728", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public override bool isReady
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x947DD4", Offset = "0x947DD4", VA = "0x947DD4", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x947EF0", Offset = "0x947EF0", VA = "0x947EF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x947EF4", Offset = "0x947EF4", VA = "0x947EF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x947EF8", Offset = "0x947EF8", VA = "0x947EF8", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x9482AC", Offset = "0x9482AC", VA = "0x9482AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x946B9C", Offset = "0x946B9C", VA = "0x946B9C")]
		private void register()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x9466D4", Offset = "0x9466D4", VA = "0x9466D4")]
		private void unregister()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x9484C4", Offset = "0x9484C4", VA = "0x9484C4")]
		public DJSet()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[ExecuteInEditMode]
	public class RecordSet : BaseSet
	{
		[Token(Token = "0x2000039")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Record> result;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Record, bool> <>9__3;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<BaseRecordProvider, IEnumerable<Record>> <>9__2;

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x949A30", Offset = "0x949A30", VA = "0x949A30")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x94AA50", Offset = "0x94AA50", VA = "0x94AA50")]
			internal IEnumerable<Record> <get_Records>b__2(BaseRecordProvider rp)
			{
				return null;
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x94AB18", Offset = "0x94AB18", VA = "0x94AB18")]
			internal bool <get_Records>b__3(Record record)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200003A")]
		private sealed class <>c
		{
			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<BaseRecordProvider, bool> <>9__14_1;

			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Record, string> <>9__14_0;

			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<BaseRecordProvider, bool> <>9__16_1;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Record, string> <>9__16_0;

			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<BaseRecordProvider, bool> <>9__18_0;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<BaseRecordProvider, bool> <>9__21_0;

			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<BaseRecordProvider, bool> <>9__23_0;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<BaseRecordProvider, bool> <>9__24_0;

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x94ABEC", Offset = "0x94ABEC", VA = "0x94ABEC")]
			public <>c()
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x94ABF4", Offset = "0x94ABF4", VA = "0x94ABF4")]
			internal bool <get_Records>b__14_1(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x94AC74", Offset = "0x94AC74", VA = "0x94AC74")]
			internal string <get_Records>b__14_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x94AC8C", Offset = "0x94AC8C", VA = "0x94AC8C")]
			internal bool <get_RandomRecords>b__16_1(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x94AD0C", Offset = "0x94AD0C", VA = "0x94AD0C")]
			internal string <get_RandomRecords>b__16_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x94AD24", Offset = "0x94AD24", VA = "0x94AD24")]
			internal bool <get_isReady>b__18_0(BaseRecordProvider provider)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x94ADA4", Offset = "0x94ADA4", VA = "0x94ADA4")]
			internal bool <Load>b__21_0(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x94AE28", Offset = "0x94AE28", VA = "0x94AE28")]
			internal bool <register>b__23_0(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x94AE84", Offset = "0x94AE84", VA = "0x94AE84")]
			internal bool <unregister>b__24_0(BaseRecordProvider rp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200003B")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Record> result;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Record, bool> <>9__3;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<BaseRecordProvider, IEnumerable<Record>> <>9__2;

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x94A0DC", Offset = "0x94A0DC", VA = "0x94A0DC")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x94AEE0", Offset = "0x94AEE0", VA = "0x94AEE0")]
			internal IEnumerable<Record> <get_RandomRecords>b__2(BaseRecordProvider rp)
			{
				return null;
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x94AFA8", Offset = "0x94AFA8", VA = "0x94AFA8")]
			internal bool <get_RandomRecords>b__3(Record record)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[FormerlySerializedAs("RecordProviders")]
		[SerializeField]
		private BaseRecordProvider[] recordProviders;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public FilterChangeEvent OnFilterChanged;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x170000A1")]
		public BaseRecordProvider[] RecordProviders
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x948A68", Offset = "0x948A68", VA = "0x948A68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x948A70", Offset = "0x948A70", VA = "0x948A70")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x949374", Offset = "0x949374", VA = "0x949374", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		protected override FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x94937C", Offset = "0x94937C", VA = "0x94937C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x949384", Offset = "0x949384", VA = "0x949384", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public override List<Record> Records
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x94938C", Offset = "0x94938C", VA = "0x94938C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public override List<Record> RandomRecords
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x949A38", Offset = "0x949A38", VA = "0x949A38", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public override bool isReady
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x94A0E4", Offset = "0x94A0E4", VA = "0x94A0E4", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x94A200", Offset = "0x94A200", VA = "0x94A200")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x94A204", Offset = "0x94A204", VA = "0x94A204")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x94A208", Offset = "0x94A208", VA = "0x94A208", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x94A5C0", Offset = "0x94A5C0", VA = "0x94A5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x948F0C", Offset = "0x948F0C", VA = "0x948F0C")]
		private void register()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x948AA4", Offset = "0x948AA4", VA = "0x948AA4")]
		private void unregister()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x94AA48", Offset = "0x94AA48", VA = "0x94AA48")]
		public RecordSet()
		{
		}
	}
}
namespace Crosstales.DJ.Provider
{
	[Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	public abstract class BaseRecordProvider : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200003D")]
		private sealed class <>c
		{
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<double, Record, double> <>9__48_0;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Record, long> <>9__50_0;

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x94C204", Offset = "0x94C204", VA = "0x94C204")]
			public <>c()
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x94C20C", Offset = "0x94C20C", VA = "0x94C20C")]
			internal double <get_TotalPlaytime>b__48_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x94C23C", Offset = "0x94C23C", VA = "0x94C23C")]
			internal long <get_TotalSize>b__50_0(Record record)
			{
				return default(long);
			}
		}

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("LoadTag")]
		[SerializeField]
		private bool loadTag;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[FormerlySerializedAs("ReadFileSize")]
		[SerializeField]
		private bool readFileSize;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[FormerlySerializedAs("AutoUpdate")]
		[SerializeField]
		private bool autoUpdate;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[FormerlySerializedAs("AutoUpdateInEditor")]
		[SerializeField]
		private bool autoUpdateInEditor;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<Record> records;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected bool loading;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected string errorMessage;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool <isReady>k__BackingField;

		[Token(Token = "0x170000A8")]
		public bool LoadTag
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x94B00C", Offset = "0x94B00C", VA = "0x94B00C", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x94B014", Offset = "0x94B014", VA = "0x94B014", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool ReadFileSize
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x94B020", Offset = "0x94B020", VA = "0x94B020", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x94B028", Offset = "0x94B028", VA = "0x94B028", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public bool AutoUpdate
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x94B034", Offset = "0x94B034", VA = "0x94B034", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x94B03C", Offset = "0x94B03C", VA = "0x94B03C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool AutoUpdateInEditor
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x94B048", Offset = "0x94B048", VA = "0x94B048")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x94B050", Offset = "0x94B050", VA = "0x94B050")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		protected abstract RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002BB")]
			get;
		}

		[Token(Token = "0x170000AD")]
		protected abstract ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002BC")]
			get;
		}

		[Token(Token = "0x170000AE")]
		public bool isLoadTag
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x94B16C", Offset = "0x94B16C", VA = "0x94B16C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x94B174", Offset = "0x94B174", VA = "0x94B174")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool isReadFileSize
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x94B180", Offset = "0x94B180", VA = "0x94B180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x94B188", Offset = "0x94B188", VA = "0x94B188")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool isAutoUpdate
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x94B194", Offset = "0x94B194", VA = "0x94B194")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x94B19C", Offset = "0x94B19C", VA = "0x94B19C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool isReady
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x94B1A8", Offset = "0x94B1A8", VA = "0x94B1A8", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x94B1B0", Offset = "0x94B1B0", VA = "0x94B1B0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public List<Record> Records
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x94B1BC", Offset = "0x94B1BC", VA = "0x94B1BC", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x94B1C4", Offset = "0x94B1C4", VA = "0x94B1C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x94B1CC", Offset = "0x94B1CC", VA = "0x94B1CC", Slot = "17")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000B4")]
		public long TotalSize
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x94B2D4", Offset = "0x94B2D4", VA = "0x94B2D4", Slot = "18")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x14000013")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x94A7D8", Offset = "0x94A7D8", VA = "0x94A7D8")]
			add
			{
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x94A910", Offset = "0x94A910", VA = "0x94A910")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x94A874", Offset = "0x94A874", VA = "0x94A874")]
			add
			{
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x94A9AC", Offset = "0x94A9AC", VA = "0x94A9AC")]
			remove
			{
			}
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x94B05C", Offset = "0x94B05C", VA = "0x94B05C", Slot = "12")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x94B0C4", Offset = "0x94B0C4", VA = "0x94B0C4", Slot = "13")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x94B3D8", Offset = "0x94B3D8", VA = "0x94B3D8", Slot = "19")]
		public virtual void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x60002D0")]
		protected abstract void load();

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x94B4C0", Offset = "0x94B4C0", VA = "0x94B4C0")]
		protected static string determineAudioFormatExtension(AudioFormat audioFormat = AudioFormat.MP3)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x94B634", Offset = "0x94B634", VA = "0x94B634")]
		protected void fillRecords(string[] list)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x94BBC8", Offset = "0x94BBC8", VA = "0x94BBC8", Slot = "21")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x94BCE8", Offset = "0x94BCE8", VA = "0x94BCE8", Slot = "22")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x94BE40", Offset = "0x94BE40", VA = "0x94BE40")]
		protected BaseRecordProvider()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x94BED0", Offset = "0x94BED0", VA = "0x94BED0")]
		private Record <fillRecords>b__54_0(string entry)
		{
			return null;
		}
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	public abstract class BaseRecordProviderDB : BaseRecordProvider
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[FormerlySerializedAs("UseDatabase")]
		[SerializeField]
		private bool useDatabase;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string uid;

		[Token(Token = "0x170000B5")]
		public bool UseDatabase
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x94C278", Offset = "0x94C278", VA = "0x94C278")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x94C280", Offset = "0x94C280", VA = "0x94C280")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool hasDBFile
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x94C324", Offset = "0x94C324", VA = "0x94C324", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public string DBFilePath
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x94C338", Offset = "0x94C338", VA = "0x94C338", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x94C28C", Offset = "0x94C28C", VA = "0x94C28C", Slot = "23")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x94C3AC", Offset = "0x94C3AC", VA = "0x94C3AC", Slot = "19")]
		public override void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x94C500", Offset = "0x94C500", VA = "0x94C500", Slot = "26")]
		public virtual void SaveDB(string filePath = "")
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x94C578", Offset = "0x94C578", VA = "0x94C578", Slot = "27")]
		public virtual void LoadDB(string filePath = "")
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x94C620", Offset = "0x94C620", VA = "0x94C620", Slot = "28")]
		public void DeleteDB()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x94C4E4", Offset = "0x94C4E4", VA = "0x94C4E4")]
		private void loadFile()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x94C588", Offset = "0x94C588", VA = "0x94C588")]
		private void loadFile(string filePath)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x94C764", Offset = "0x94C764", VA = "0x94C764")]
		protected BaseRecordProviderDB()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class RecordProviderClip : BaseRecordProvider
	{
		[Serializable]
		[Token(Token = "0x2000040")]
		private sealed class <>c
		{
			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<AudioClip, bool> <>9__10_0;

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x94CE74", Offset = "0x94CE74", VA = "0x94CE74")]
			public <>c()
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x94CE7C", Offset = "0x94CE7C", VA = "0x94CE7C")]
			internal bool <load>b__10_0(AudioClip clip)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("Clips")]
		[SerializeField]
		private List<AudioClip> clips;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x170000B8")]
		public List<AudioClip> Clips
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x94C770", Offset = "0x94C770", VA = "0x94C770")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x94C778", Offset = "0x94C778", VA = "0x94C778")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x94C844", Offset = "0x94C844", VA = "0x94C844", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x94C84C", Offset = "0x94C84C", VA = "0x94C84C", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x94C854", Offset = "0x94C854", VA = "0x94C854", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x94CD80", Offset = "0x94CD80", VA = "0x94CD80")]
		public RecordProviderClip()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class RecordProviderFile : BaseRecordProvider
	{
		[Serializable]
		[Token(Token = "0x2000042")]
		private sealed class <>c
		{
			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__10_0;

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x94D580", Offset = "0x94D580", VA = "0x94D580")]
			public <>c()
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x94D588", Offset = "0x94D588", VA = "0x94D588")]
			internal bool <load>b__10_0(string url)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("Files")]
		[SerializeField]
		private List<string> files;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x170000BB")]
		public List<string> Files
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x94CED8", Offset = "0x94CED8", VA = "0x94CED8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x94CEE0", Offset = "0x94CEE0", VA = "0x94CEE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x94CFAC", Offset = "0x94CFAC", VA = "0x94CFAC", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x94CFB4", Offset = "0x94CFB4", VA = "0x94CFB4", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x94CFBC", Offset = "0x94CFBC", VA = "0x94CFBC", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x94D48C", Offset = "0x94D48C", VA = "0x94D48C")]
		public RecordProviderFile()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class RecordProviderPath : BaseRecordProviderDB
	{
		[Token(Token = "0x2000044")]
		private sealed class <scan>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPath <>4__this;

			[Token(Token = "0x170000C7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600031C")]
				[Address(RVA = "0x94F164", Offset = "0x94F164", VA = "0x94F164", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600031E")]
				[Address(RVA = "0x94F1AC", Offset = "0x94F1AC", VA = "0x94F1AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x94E1D0", Offset = "0x94E1D0", VA = "0x94E1D0")]
			[DebuggerHidden]
			public <scan>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x94EF64", Offset = "0x94EF64", VA = "0x94EF64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x94EF68", Offset = "0x94EF68", VA = "0x94EF68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x94F16C", Offset = "0x94F16C", VA = "0x94F16C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000045")]
		private sealed class <scanWindows>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPath <>4__this;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Process <>7__wrap1;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000323")]
				[Address(RVA = "0x94FA20", Offset = "0x94FA20", VA = "0x94FA20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000325")]
				[Address(RVA = "0x94FA68", Offset = "0x94FA68", VA = "0x94FA68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x94E1F8", Offset = "0x94E1F8", VA = "0x94E1F8")]
			[DebuggerHidden]
			public <scanWindows>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x94F1B4", Offset = "0x94F1B4", VA = "0x94F1B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x94F1D0", Offset = "0x94F1D0", VA = "0x94F1D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x94F970", Offset = "0x94F970", VA = "0x94F970")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x94FA28", Offset = "0x94FA28", VA = "0x94FA28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000046")]
		private sealed class <scanUnix>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPath <>4__this;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Process <>7__wrap1;

			[Token(Token = "0x170000CB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032A")]
				[Address(RVA = "0x9506D0", Offset = "0x9506D0", VA = "0x9506D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600032C")]
				[Address(RVA = "0x950718", Offset = "0x950718", VA = "0x950718", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x94E220", Offset = "0x94E220", VA = "0x94E220")]
			[DebuggerHidden]
			public <scanUnix>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x94FA70", Offset = "0x94FA70", VA = "0x94FA70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x94FA8C", Offset = "0x94FA8C", VA = "0x94FA8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x950620", Offset = "0x950620", VA = "0x950620")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x9506D8", Offset = "0x9506D8", VA = "0x9506D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("UseMusicLibrary")]
		[SerializeField]
		private bool useMusicLibrary;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("Path")]
		[SerializeField]
		private string path;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("Format")]
		[SerializeField]
		private AudioFormat format;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[FormerlySerializedAs("Recursive")]
		[SerializeField]
		private bool recursive;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[FormerlySerializedAs("SlowAndSave")]
		[SerializeField]
		private bool slowAndSave;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		[SerializeField]
		[FormerlySerializedAs("WatchDog")]
		private bool watchDog;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FileSystemWatcher watcher;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Process scanProcess;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Thread worker;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string KEY_PATH;

		[Token(Token = "0x170000BE")]
		public bool UseMusicLibrary
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x94D5A8", Offset = "0x94D5A8", VA = "0x94D5A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x94D5B0", Offset = "0x94D5B0", VA = "0x94D5B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public string Path
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x94D5BC", Offset = "0x94D5BC", VA = "0x94D5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x94D5C4", Offset = "0x94D5C4", VA = "0x94D5C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public AudioFormat Format
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x94D6F8", Offset = "0x94D6F8", VA = "0x94D6F8")]
			get
			{
				return default(AudioFormat);
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x94D700", Offset = "0x94D700", VA = "0x94D700")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public bool Recursive
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x94D7D8", Offset = "0x94D7D8", VA = "0x94D7D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x94D7E0", Offset = "0x94D7E0", VA = "0x94D7E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public bool SlowAndSave
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x94D7EC", Offset = "0x94D7EC", VA = "0x94D7EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x94D7F4", Offset = "0x94D7F4", VA = "0x94D7F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public bool WatchDog
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x94D800", Offset = "0x94D800", VA = "0x94D800")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x94D808", Offset = "0x94D808", VA = "0x94D808")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x94D814", Offset = "0x94D814", VA = "0x94D814", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x94D81C", Offset = "0x94D81C", VA = "0x94D81C", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public string Extension
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x94D824", Offset = "0x94D824", VA = "0x94D824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x94D82C", Offset = "0x94D82C", VA = "0x94D82C", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x94DB18", Offset = "0x94DB18", VA = "0x94DB18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x94DC8C", Offset = "0x94DC8C", VA = "0x94DC8C")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x94DD2C", Offset = "0x94DD2C", VA = "0x94DD2C", Slot = "19")]
		public override void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x94DDF0", Offset = "0x94DDF0", VA = "0x94DDF0", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x94D93C", Offset = "0x94D93C", VA = "0x94D93C")]
		private void setMusicLibrary()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x94E15C", Offset = "0x94E15C", VA = "0x94E15C")]
		private IEnumerator scan()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x94E074", Offset = "0x94E074", VA = "0x94E074")]
		private IEnumerator scanWindows()
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x94E0E8", Offset = "0x94E0E8", VA = "0x94E0E8")]
		private IEnumerator scanUnix()
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x94E248", Offset = "0x94E248", VA = "0x94E248")]
		private void watch()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x94E4A0", Offset = "0x94E4A0", VA = "0x94E4A0")]
		private void onDeleted(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x94E5E4", Offset = "0x94E5E4", VA = "0x94E5E4")]
		private void onCreated(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x94E728", Offset = "0x94E728", VA = "0x94E728")]
		private void onRenamed(object source, RenamedEventArgs e)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x94E86C", Offset = "0x94E86C", VA = "0x94E86C")]
		private void onChanged(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x94E9B0", Offset = "0x94E9B0", VA = "0x94E9B0")]
		private void scanOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x94EB14", Offset = "0x94EB14", VA = "0x94EB14")]
		private void readPath()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x94EF4C", Offset = "0x94EF4C", VA = "0x94EF4C")]
		public RecordProviderPath()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class RecordProviderPlaylist : BaseRecordProviderDB
	{
		[Token(Token = "0x2000048")]
		private sealed class <readFileM3U>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPlaylist <>4__this;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000D1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x952784", Offset = "0x952784", VA = "0x952784", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000341")]
				[Address(RVA = "0x9527CC", Offset = "0x9527CC", VA = "0x9527CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x950B40", Offset = "0x950B40", VA = "0x950B40")]
			[DebuggerHidden]
			public <readFileM3U>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x951FC8", Offset = "0x951FC8", VA = "0x951FC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x951FE4", Offset = "0x951FE4", VA = "0x951FE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x9526D4", Offset = "0x9526D4", VA = "0x9526D4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x95278C", Offset = "0x95278C", VA = "0x95278C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000049")]
		private sealed class <readFilePLS>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPlaylist <>4__this;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000D3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000346")]
				[Address(RVA = "0x952F90", Offset = "0x952F90", VA = "0x952F90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000348")]
				[Address(RVA = "0x952FD8", Offset = "0x952FD8", VA = "0x952FD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x9514E4", Offset = "0x9514E4", VA = "0x9514E4")]
			[DebuggerHidden]
			public <readFilePLS>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x9527D4", Offset = "0x9527D4", VA = "0x9527D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x9527F0", Offset = "0x9527F0", VA = "0x9527F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x952EE0", Offset = "0x952EE0", VA = "0x952EE0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x952F98", Offset = "0x952F98", VA = "0x952F98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("URL")]
		private string url;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] splitCharColon;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly char[] splitCharComma;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly char[] splitCharEquals;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string KEY_URL;

		[Token(Token = "0x400018D")]
		private const int timeout = 20;

		[Token(Token = "0x170000CD")]
		public string URL
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x950720", Offset = "0x950720", VA = "0x950720")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x950728", Offset = "0x950728", VA = "0x950728")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x9507F4", Offset = "0x9507F4", VA = "0x9507F4", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x9507FC", Offset = "0x9507FC", VA = "0x9507FC", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public PlayListFormat Format
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x950804", Offset = "0x950804", VA = "0x950804")]
			get
			{
				return default(PlayListFormat);
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x950930", Offset = "0x950930", VA = "0x950930", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x9509F0", Offset = "0x9509F0", VA = "0x9509F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x950A14", Offset = "0x950A14", VA = "0x950A14", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x950ACC", Offset = "0x950ACC", VA = "0x950ACC")]
		private IEnumerator readFileM3U()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x950B68", Offset = "0x950B68", VA = "0x950B68")]
		private void parseM3U(string text)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x950A58", Offset = "0x950A58", VA = "0x950A58")]
		private IEnumerator readFilePLS()
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x95150C", Offset = "0x95150C", VA = "0x95150C")]
		private void parsePLS(string text)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x951EC4", Offset = "0x951EC4", VA = "0x951EC4")]
		public RecordProviderPlaylist()
		{
		}
	}
}
namespace Crosstales.DJ.Model
{
	[Serializable]
	[Token(Token = "0x200004A")]
	public class EventPoint
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PointMode Mode;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float EventTimePosition;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("EventPosition")]
		[Range(0f, 1f)]
		[SerializeField]
		private float eventPosition;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int EventSamplePosition;

		[Token(Token = "0x170000D5")]
		public float EventPosition
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x952FE0", Offset = "0x952FE0", VA = "0x952FE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x952FE8", Offset = "0x952FE8", VA = "0x952FE8")]
			set
			{
			}
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x953004", Offset = "0x953004", VA = "0x953004", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x953260", Offset = "0x953260", VA = "0x953260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x9533DC", Offset = "0x9533DC", VA = "0x9533DC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x9533E4", Offset = "0x9533E4", VA = "0x9533E4")]
		public EventPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class LoopPoint
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PointMode Mode;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float StartTimePosition;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float EndTimePosition;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("StartPosition")]
		[SerializeField]
		[Range(0f, 0.999f)]
		private float startPosition;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0.001f, 1f)]
		[FormerlySerializedAs("EndPosition")]
		private float endPosition;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int StartSamplePosition;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int EndSamplePosition;

		[Token(Token = "0x170000D6")]
		public float StartPosition
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x953404", Offset = "0x953404", VA = "0x953404")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x95340C", Offset = "0x95340C", VA = "0x95340C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public float EndPosition
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x95342C", Offset = "0x95342C", VA = "0x95342C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x953434", Offset = "0x953434", VA = "0x953434")]
			set
			{
			}
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x953454", Offset = "0x953454", VA = "0x953454", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x9537A4", Offset = "0x9537A4", VA = "0x9537A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x953978", Offset = "0x953978", VA = "0x953978", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x953980", Offset = "0x953980", VA = "0x953980")]
		public LoopPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class M3UEntry
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Title;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Length;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x9539A0", Offset = "0x9539A0", VA = "0x9539A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x953B7C", Offset = "0x953B7C", VA = "0x953B7C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x953C9C", Offset = "0x953C9C", VA = "0x953C9C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x95148C", Offset = "0x95148C", VA = "0x95148C")]
		public M3UEntry()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class PLSEntry
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Title;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Length;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x953CF8", Offset = "0x953CF8", VA = "0x953CF8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x953ED4", Offset = "0x953ED4", VA = "0x953ED4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x953FF4", Offset = "0x953FF4", VA = "0x953FF4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x951E6C", Offset = "0x951E6C", VA = "0x951E6C")]
		public PLSEntry()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class Record
	{
		[Token(Token = "0x200004F")]
		private sealed class <readSize>d__101 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Record <>4__this;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000EC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000389")]
				[Address(RVA = "0x9568DC", Offset = "0x9568DC", VA = "0x9568DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600038B")]
				[Address(RVA = "0x956924", Offset = "0x956924", VA = "0x956924", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x955C0C", Offset = "0x955C0C", VA = "0x955C0C")]
			[DebuggerHidden]
			public <readSize>d__101(int <>1__state)
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x95659C", Offset = "0x95659C", VA = "0x95659C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x9565B8", Offset = "0x9565B8", VA = "0x9565B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x95682C", Offset = "0x95682C", VA = "0x95682C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x9568E4", Offset = "0x9568E4", VA = "0x9568E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[XmlIgnore]
		public AudioClip Clip;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float Rating;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[XmlIgnore]
		public Sprite Icon;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string IconUrl;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Channels;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int SampleRate;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int Samples;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string name;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string title;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string artist;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string album;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float duration;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string genre;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int year;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private AudioFormat format;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private long fileSize;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Tag tag;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool loadingTag;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string spotifyUrl;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string lyricsUrl;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] splitChar;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Regex lyricsRegex;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool loadingFileSize;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int bitrate;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Texture cachedTexture;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Sprite cachedSprite;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool <isTagLoaded>k__BackingField;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool <isFileSizeLoaded>k__BackingField;

		[Token(Token = "0x170000D8")]
		public bool isTagLoaded
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x954050", Offset = "0x954050", VA = "0x954050")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x954058", Offset = "0x954058", VA = "0x954058")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public bool isFileSizeLoaded
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x954064", Offset = "0x954064", VA = "0x954064")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x95406C", Offset = "0x95406C", VA = "0x95406C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public bool isLocalFile
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x954078", Offset = "0x954078", VA = "0x954078")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DB")]
		public string Name
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x944E50", Offset = "0x944E50", VA = "0x944E50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public string Title
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x945184", Offset = "0x945184", VA = "0x945184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public string Artist
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x945258", Offset = "0x945258", VA = "0x945258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public string Album
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x94537C", Offset = "0x94537C", VA = "0x94537C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		public float Duration
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x944B90", Offset = "0x944B90", VA = "0x944B90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x954754", Offset = "0x954754", VA = "0x954754")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public string Genre
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x9454A0", Offset = "0x9454A0", VA = "0x9454A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		public int Year
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x945678", Offset = "0x945678", VA = "0x945678")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E2")]
		public string Url
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x954760", Offset = "0x954760", VA = "0x954760")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		public long FileSize
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x944D3C", Offset = "0x944D3C", VA = "0x944D3C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000E4")]
		public bool HasTag
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x954D7C", Offset = "0x954D7C", VA = "0x954D7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E5")]
		public Tag Tag
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x954E08", Offset = "0x954E08", VA = "0x954E08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		public AudioFormat Format
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x945974", Offset = "0x945974", VA = "0x945974")]
			get
			{
				return default(AudioFormat);
			}
		}

		[Token(Token = "0x170000E7")]
		public string SpotifyUrl
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x9559EC", Offset = "0x9559EC", VA = "0x9559EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public int Bitrate
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x946174", Offset = "0x946174", VA = "0x946174")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x955B60", Offset = "0x955B60", VA = "0x955B60")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		private bool hasID3Tag
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x954DC0", Offset = "0x954DC0", VA = "0x954DC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		private bool hasXiphComment
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x954DD8", Offset = "0x954DD8", VA = "0x954DD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		private bool hasAiffTag
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x954DF0", Offset = "0x954DF0", VA = "0x954DF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x955B68", Offset = "0x955B68", VA = "0x955B68")]
		public Record()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x94BF54", Offset = "0x94BF54", VA = "0x94BF54")]
		public Record(string filePath, bool loadTag = false, bool readFileSize = false)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x951494", Offset = "0x951494", VA = "0x951494")]
		public Record(M3UEntry entry, bool loadTag, bool readFileSize)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x951E74", Offset = "0x951E74", VA = "0x951E74")]
		public Record(PLSEntry entry, bool loadTag, bool readFileSize)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x94CD38", Offset = "0x94CD38", VA = "0x94CD38")]
		public Record(AudioClip clip)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x9540F4", Offset = "0x9540F4", VA = "0x9540F4")]
		private void parseInfo()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x955A10", Offset = "0x955A10", VA = "0x955A10")]
		private void parseSpotifyUrl()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x9547D0", Offset = "0x9547D0", VA = "0x9547D0")]
		private void readFileSize()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x955B98", Offset = "0x955B98", VA = "0x955B98")]
		private IEnumerator readSize()
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x954E54", Offset = "0x954E54", VA = "0x954E54")]
		private void loadTag()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x955C34", Offset = "0x955C34", VA = "0x955C34", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x955D74", Offset = "0x955D74", VA = "0x955D74", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x955E68", Offset = "0x955E68", VA = "0x955E68", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class RecordFilter
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Title;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Artist;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Album;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Genres;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("RatingMin")]
		[SerializeField]
		[Range(0f, 4.9f)]
		private float ratingMin;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0.1f, 5f)]
		[FormerlySerializedAs("RatingMax")]
		private float ratingMax;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 9998f)]
		[FormerlySerializedAs("YearMin")]
		[SerializeField]
		private int yearMin;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("YearMax")]
		[SerializeField]
		[Range(1f, 9999f)]
		private int yearMax;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string Format;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Range(32f, 499f)]
		[FormerlySerializedAs("BitrateMin")]
		private int bitrateMin;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Range(33f, 500f)]
		[FormerlySerializedAs("BitrateMax")]
		private int bitrateMax;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 500f)]
		public int Limit;

		[Token(Token = "0x170000EE")]
		public float RatingMin
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x95692C", Offset = "0x95692C", VA = "0x95692C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x956934", Offset = "0x956934", VA = "0x956934")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float RatingMax
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x956954", Offset = "0x956954", VA = "0x956954")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x95695C", Offset = "0x95695C", VA = "0x95695C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public int YearMin
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x95697C", Offset = "0x95697C", VA = "0x95697C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x956984", Offset = "0x956984", VA = "0x956984")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public int YearMax
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x95699C", Offset = "0x95699C", VA = "0x95699C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x9569A4", Offset = "0x9569A4", VA = "0x9569A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public int BitrateMin
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x9569C0", Offset = "0x9569C0", VA = "0x9569C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x9569C8", Offset = "0x9569C8", VA = "0x9569C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public int BitrateMax
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x9569E8", Offset = "0x9569E8", VA = "0x9569E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x9569F0", Offset = "0x9569F0", VA = "0x9569F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool isFiltering
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x956A10", Offset = "0x956A10", VA = "0x956A10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x956AF4", Offset = "0x956AF4", VA = "0x956AF4")]
		public RecordFilter()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x956C00", Offset = "0x956C00", VA = "0x956C00")]
		public RecordFilter(RecordFilter filter)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x956E7C", Offset = "0x956E7C", VA = "0x956E7C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x9570AC", Offset = "0x9570AC", VA = "0x9570AC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x9570B4", Offset = "0x9570B4", VA = "0x9570B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Crosstales.DJ.Model.Enum
{
	[Token(Token = "0x2000051")]
	public enum AudioCodec
	{
		[Token(Token = "0x40001D7")]
		MP3_NLayer,
		[Token(Token = "0x40001D8")]
		MP3_NAudio,
		[Token(Token = "0x40001D9")]
		OGG_NVorbis,
		[Token(Token = "0x40001DA")]
		FMOD
	}
	[Token(Token = "0x2000052")]
	public enum AudioFormat
	{
		[Token(Token = "0x40001DC")]
		ALL,
		[Token(Token = "0x40001DD")]
		MP3,
		[Token(Token = "0x40001DE")]
		OGG,
		[Token(Token = "0x40001DF")]
		XM,
		[Token(Token = "0x40001E0")]
		IT,
		[Token(Token = "0x40001E1")]
		MOD,
		[Token(Token = "0x40001E2")]
		S3M,
		[Token(Token = "0x40001E3")]
		WAV,
		[Token(Token = "0x40001E4")]
		AIFF
	}
	[Token(Token = "0x2000053")]
	public enum PlayListFormat
	{
		[Token(Token = "0x40001E6")]
		UNKNOWN,
		[Token(Token = "0x40001E7")]
		M3U,
		[Token(Token = "0x40001E8")]
		PLS
	}
	[Token(Token = "0x2000054")]
	public enum PointMode
	{
		[Token(Token = "0x40001EA")]
		SECONDS,
		[Token(Token = "0x40001EB")]
		PERCENTAGE,
		[Token(Token = "0x40001EC")]
		SAMPLES
	}
}
namespace Crosstales.DJ.Tool
{
	[Token(Token = "0x2000055")]
	public class BPMAnalyzer : MonoBehaviour
	{
		[Token(Token = "0x2000056")]
		public struct BpmMatchData
		{
			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int BPM;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float Match;
		}

		[Serializable]
		[Token(Token = "0x2000057")]
		private sealed class <>c
		{
			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<BpmMatchData, float> <>9__18_1;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BpmMatchData> <>9__18_0;

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x95854C", Offset = "0x95854C", VA = "0x95854C")]
			public <>c()
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x958554", Offset = "0x958554", VA = "0x958554")]
			internal bool <searchBpm>b__18_0(BpmMatchData x)
			{
				return default(bool);
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x9586A4", Offset = "0x9586A4", VA = "0x9586A4")]
			internal float <searchBpm>b__18_1(BpmMatchData y)
			{
				return default(float);
			}
		}

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource Source;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(20f, 2000f)]
		public int SampleSplit;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool AutoAnalyze;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BasePlayer Player;

		[Token(Token = "0x40001F1")]
		private const int MIN_BPM = 50;

		[Token(Token = "0x40001F2")]
		private const int MAX_BPM = 500;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BpmMatchData[] bpmMatchDatas;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <LastBPM>k__BackingField;

		[Token(Token = "0x170000F5")]
		public int LastBPM
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x9575EC", Offset = "0x9575EC", VA = "0x9575EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x9575F4", Offset = "0x9575F4", VA = "0x9575F4")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9575FC", Offset = "0x9575FC", VA = "0x9575FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x9577F0", Offset = "0x9577F0", VA = "0x9577F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x9578C4", Offset = "0x9578C4", VA = "0x9578C4")]
		public int AnalyzeBPM()
		{
			return default(int);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x957A20", Offset = "0x957A20", VA = "0x957A20")]
		public static int AnalyzeBPM(float[] data, int frequency = 44100, int channels = 2, int sampleSplit = 100)
		{
			return default(int);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x9581E4", Offset = "0x9581E4", VA = "0x9581E4")]
		public static int AnalyzeBPM(AudioClip clip, int sampleSplit = 100)
		{
			return default(int);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x957990", Offset = "0x957990", VA = "0x957990")]
		private static float[] getData(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x957C1C", Offset = "0x957C1C", VA = "0x957C1C")]
		private static float[] createVolumeArray(float[] allSamples, int frequency, int channels, int splitFrameSize)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x957DE4", Offset = "0x957DE4", VA = "0x957DE4")]
		private static int searchBpm(float[] volumeArr, int frequency, int splitFrameSize)
		{
			return default(int);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x958348", Offset = "0x958348", VA = "0x958348")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x958458", Offset = "0x958458", VA = "0x958458")]
		public BPMAnalyzer()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class ChangeAudioCodec : MonoBehaviour
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioCodec Codec;

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x9586B0", Offset = "0x9586B0", VA = "0x9586B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x958710", Offset = "0x958710", VA = "0x958710")]
		public ChangeAudioCodec()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	public class CrossFader : MonoBehaviour
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource SourceA;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource SourceB;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float volumeA;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float volumeB;

		[Token(Token = "0x170000F6")]
		public float FaderPosition
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x958718", Offset = "0x958718", VA = "0x958718")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x958848", Offset = "0x958848", VA = "0x958848")]
			set
			{
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x958A1C", Offset = "0x958A1C", VA = "0x958A1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x958B84", Offset = "0x958B84", VA = "0x958B84")]
		public CrossFader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class EventPositionReachedEvent : UnityEvent
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x958B94", Offset = "0x958B94", VA = "0x958B94")]
		public EventPositionReachedEvent()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class Eventer : MonoBehaviour
	{
		[Token(Token = "0x200005C")]
		public delegate void EventPositionReached(Record record, EventPoint eventPoint);

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BasePlayer Player;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventPoint Event;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isEventFired;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventPositionReachedEvent OnEventPosition;

		[Token(Token = "0x170000F7")]
		public PointMode Mode
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x958B9C", Offset = "0x958B9C", VA = "0x958B9C")]
			get
			{
				return default(PointMode);
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x958BB4", Offset = "0x958BB4", VA = "0x958BB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public float StartTimePosition
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x958BC4", Offset = "0x958BC4", VA = "0x958BC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x958BDC", Offset = "0x958BDC", VA = "0x958BDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public float EventPosition
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x958BF0", Offset = "0x958BF0", VA = "0x958BF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x958C08", Offset = "0x958C08", VA = "0x958C08")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public int EventSamplePosition
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x958C30", Offset = "0x958C30", VA = "0x958C30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x958C48", Offset = "0x958C48", VA = "0x958C48")]
			set
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event EventPositionReached OnEventPositionReached
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x958CAC", Offset = "0x958CAC", VA = "0x958CAC")]
			add
			{
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x958D48", Offset = "0x958D48", VA = "0x958D48")]
			remove
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x958DE4", Offset = "0x958DE4", VA = "0x958DE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x958E9C", Offset = "0x958E9C", VA = "0x958E9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x95917C", Offset = "0x95917C", VA = "0x95917C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x958FC0", Offset = "0x958FC0", VA = "0x958FC0")]
		private void onEventPositionReached(Record record, EventPoint ep)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x9591CC", Offset = "0x9591CC", VA = "0x9591CC")]
		public Eventer()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class LoadAudioClip : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		public delegate void LoadClipStart(Record record);

		[Token(Token = "0x200005F")]
		public delegate void LoadClipEnd(Record record, AudioClip clip);

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Turntable player;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isRunning;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioClip <LastAudioClip>k__BackingField;

		[Token(Token = "0x170000FB")]
		public Turntable Player
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x959328", Offset = "0x959328", VA = "0x959328")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x959330", Offset = "0x959330", VA = "0x959330")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public AudioClip LastAudioClip
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x95978C", Offset = "0x95978C", VA = "0x95978C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x959794", Offset = "0x959794", VA = "0x959794")]
			private set
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event LoadClipStart OnLoadClipStart
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x95979C", Offset = "0x95979C", VA = "0x95979C")]
			add
			{
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x959838", Offset = "0x959838", VA = "0x959838")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event LoadClipEnd OnLoadClipEnd
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x9598D4", Offset = "0x9598D4", VA = "0x9598D4")]
			add
			{
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x959970", Offset = "0x959970", VA = "0x959970")]
			remove
			{
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x959A0C", Offset = "0x959A0C", VA = "0x959A0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x959B48", Offset = "0x959B48", VA = "0x959B48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x959B4C", Offset = "0x959B4C", VA = "0x959B4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x959B50", Offset = "0x959B50", VA = "0x959B50")]
		public void LoadClip(Record record)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x959C20", Offset = "0x959C20", VA = "0x959C20")]
		public void LoadClip(string filePath)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x9595EC", Offset = "0x9595EC", VA = "0x9595EC")]
		private void register()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x95944C", Offset = "0x95944C", VA = "0x95944C")]
		private void unregister()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x959C98", Offset = "0x959C98", VA = "0x959C98")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x959ED4", Offset = "0x959ED4", VA = "0x959ED4")]
		private void onPlaybackStart(Record record)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x959EF8", Offset = "0x959EF8", VA = "0x959EF8")]
		private void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x959F00", Offset = "0x959F00", VA = "0x959F00")]
		public LoadAudioClip()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class LoopPositionReachedEvent : UnityEvent
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x95A1AC", Offset = "0x95A1AC", VA = "0x95A1AC")]
		public LoopPositionReachedEvent()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class Looper : MonoBehaviour
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("Player")]
		private BasePlayer player;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("Loop")]
		[SerializeField]
		private LoopPoint loop;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("EnableStartPosition")]
		[SerializeField]
		private bool enableStartPosition;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LoopPositionReachedEvent OnLoopPosition;

		[Token(Token = "0x170000FD")]
		public BasePlayer Player
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x95A1B4", Offset = "0x95A1B4", VA = "0x95A1B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x95A1BC", Offset = "0x95A1BC", VA = "0x95A1BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public LoopPoint Loop
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x95A32C", Offset = "0x95A32C", VA = "0x95A32C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x95A334", Offset = "0x95A334", VA = "0x95A334")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public bool EnableStartPosition
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x95A33C", Offset = "0x95A33C", VA = "0x95A33C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x95A344", Offset = "0x95A344", VA = "0x95A344")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public PointMode Mode
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x95A350", Offset = "0x95A350", VA = "0x95A350")]
			get
			{
				return default(PointMode);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x95A368", Offset = "0x95A368", VA = "0x95A368")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public float StartTimePosition
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x95A378", Offset = "0x95A378", VA = "0x95A378")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x95A390", Offset = "0x95A390", VA = "0x95A390")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public float EndTimePosition
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x95A3A4", Offset = "0x95A3A4", VA = "0x95A3A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x95A3BC", Offset = "0x95A3BC", VA = "0x95A3BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public float StartPosition
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x95A3D0", Offset = "0x95A3D0", VA = "0x95A3D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x95A3E8", Offset = "0x95A3E8", VA = "0x95A3E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public float EndPosition
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x95A420", Offset = "0x95A420", VA = "0x95A420")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x95A438", Offset = "0x95A438", VA = "0x95A438")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public int StartSamplePosition
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x95A468", Offset = "0x95A468", VA = "0x95A468")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x95A480", Offset = "0x95A480", VA = "0x95A480")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public int EndSamplePosition
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x95A4E4", Offset = "0x95A4E4", VA = "0x95A4E4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x95A4FC", Offset = "0x95A4FC", VA = "0x95A4FC")]
			set
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event LoopPositionReached OnLoopPositionReached
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x95A560", Offset = "0x95A560", VA = "0x95A560")]
			add
			{
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x95A5FC", Offset = "0x95A5FC", VA = "0x95A5FC")]
			remove
			{
			}
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x95A698", Offset = "0x95A698", VA = "0x95A698")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x95A76C", Offset = "0x95A76C", VA = "0x95A76C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x95A840", Offset = "0x95A840", VA = "0x95A840")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x95ABB8", Offset = "0x95ABB8", VA = "0x95ABB8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x95AC80", Offset = "0x95AC80", VA = "0x95AC80")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x95AA00", Offset = "0x95AA00", VA = "0x95AA00")]
		private void onLoopPositionReached(Record record, LoopPoint lp)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x95AD0C", Offset = "0x95AD0C", VA = "0x95AD0C")]
		public Looper()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class RecordFader : MonoBehaviour
	{
		[Token(Token = "0x2000063")]
		private sealed class <faderA>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordFader <>4__this;

			[Token(Token = "0x1700010E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000416")]
				[Address(RVA = "0x95BB98", Offset = "0x95BB98", VA = "0x95BB98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x95BBE0", Offset = "0x95BBE0", VA = "0x95BBE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x95B818", Offset = "0x95B818", VA = "0x95B818")]
			[DebuggerHidden]
			public <faderA>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x95B920", Offset = "0x95B920", VA = "0x95B920", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x95B924", Offset = "0x95B924", VA = "0x95B924", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x95BBA0", Offset = "0x95BBA0", VA = "0x95BBA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000064")]
		private sealed class <faderB>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordFader <>4__this;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x95BE88", Offset = "0x95BE88", VA = "0x95BE88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x95BED0", Offset = "0x95BED0", VA = "0x95BED0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x95BBE8", Offset = "0x95BBE8", VA = "0x95BBE8")]
			[DebuggerHidden]
			public <faderB>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x95BC10", Offset = "0x95BC10", VA = "0x95BC10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x95BC14", Offset = "0x95BC14", VA = "0x95BC14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x95BE90", Offset = "0x95BE90", VA = "0x95BE90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("PlayerA")]
		private SimplePlayer playerA;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("PlayerB")]
		[SerializeField]
		private SimplePlayer playerB;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 90f)]
		[SerializeField]
		[FormerlySerializedAs("FadeTime")]
		private float fadeTime;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("AutoFade")]
		[SerializeField]
		private bool autoFade;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float volumeA;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float volumeB;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fadeA;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool fadeB;

		[Token(Token = "0x4000216")]
		private const float reserveTime = 0.3f;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool initialEndlessA;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool initialEndlessB;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <Progress>k__BackingField;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <Elapsed>k__BackingField;

		[Token(Token = "0x17000107")]
		public SimplePlayer PlayerA
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x95AD14", Offset = "0x95AD14", VA = "0x95AD14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x95AD1C", Offset = "0x95AD1C", VA = "0x95AD1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public SimplePlayer PlayerB
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x95AE8C", Offset = "0x95AE8C", VA = "0x95AE8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x95AE94", Offset = "0x95AE94", VA = "0x95AE94")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public float FadeTime
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x95B004", Offset = "0x95B004", VA = "0x95B004")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x95B00C", Offset = "0x95B00C", VA = "0x95B00C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public bool AutoFade
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x95B02C", Offset = "0x95B02C", VA = "0x95B02C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x95B034", Offset = "0x95B034", VA = "0x95B034")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public bool isFading
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x95B040", Offset = "0x95B040", VA = "0x95B040")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010C")]
		public float Progress
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x95B060", Offset = "0x95B060", VA = "0x95B060")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x95B068", Offset = "0x95B068", VA = "0x95B068")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public float Elapsed
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x95B070", Offset = "0x95B070", VA = "0x95B070")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x95B078", Offset = "0x95B078", VA = "0x95B078")]
			private set
			{
			}
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x95B080", Offset = "0x95B080", VA = "0x95B080")]
		private void Start()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x95B394", Offset = "0x95B394", VA = "0x95B394")]
		private void Update()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x95B5BC", Offset = "0x95B5BC", VA = "0x95B5BC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x95B5E4", Offset = "0x95B5E4", VA = "0x95B5E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x95B588", Offset = "0x95B588", VA = "0x95B588")]
		public void FadeA()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x95B554", Offset = "0x95B554", VA = "0x95B554")]
		public void FadeB()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x95B730", Offset = "0x95B730", VA = "0x95B730")]
		private IEnumerator faderA()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x95B7A4", Offset = "0x95B7A4", VA = "0x95B7A4")]
		private IEnumerator faderB()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x95B840", Offset = "0x95B840", VA = "0x95B840")]
		private void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x95B900", Offset = "0x95B900", VA = "0x95B900")]
		public RecordFader()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[RequireComponent(typeof(AudioSource))]
	public class RecordSaver : MonoBehaviour
	{
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("Player")]
		[SerializeField]
		private BasePlayer player;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("SilenceSource")]
		private bool silenceSource;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("OutputPath")]
		private string outputPath;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FileStream fileStream;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioSource audioSource;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool recOutput;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool stopped;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long dataPosition;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string fileName;

		[Token(Token = "0x400022A")]
		private const int HEADER_SIZE = 44;

		[Token(Token = "0x400022B")]
		private const float RESCALE_FACTOR = 32767f;

		[Token(Token = "0x400022C")]
		private const string extension = ".wav";

		[Token(Token = "0x17000112")]
		public BasePlayer Player
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x95BED8", Offset = "0x95BED8", VA = "0x95BED8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x95BEE0", Offset = "0x95BEE0", VA = "0x95BEE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public bool SilenceSource
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x95C264", Offset = "0x95C264", VA = "0x95C264")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x95C26C", Offset = "0x95C26C", VA = "0x95C26C")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public string OutputPath
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x95C29C", Offset = "0x95C29C", VA = "0x95C29C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x95C2A4", Offset = "0x95C2A4", VA = "0x95C2A4")]
			set
			{
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x95C52C", Offset = "0x95C52C", VA = "0x95C52C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x95C5AC", Offset = "0x95C5AC", VA = "0x95C5AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x95C704", Offset = "0x95C704", VA = "0x95C704")]
		private void Update()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x95C978", Offset = "0x95C978", VA = "0x95C978")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x95C97C", Offset = "0x95C97C", VA = "0x95C97C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x95D21C", Offset = "0x95D21C", VA = "0x95D21C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x95D2A4", Offset = "0x95D2A4", VA = "0x95D2A4")]
		public void SaveFile(Stream stream, [Optional] string fname)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x95D328", Offset = "0x95D328", VA = "0x95D328")]
		public void SaveFile(byte[] data, [Optional] string fname)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x95C124", Offset = "0x95C124", VA = "0x95C124")]
		private void register()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x95BFE4", Offset = "0x95BFE4", VA = "0x95BFE4")]
		private void unregister()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x95DAD8", Offset = "0x95DAD8", VA = "0x95DAD8")]
		private void openFile()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x95D950", Offset = "0x95D950", VA = "0x95D950")]
		private void write(byte[] bytesData, int count)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x95C9C8", Offset = "0x95C9C8", VA = "0x95C9C8")]
		private void closeFile()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x95DE04", Offset = "0x95DE04", VA = "0x95DE04")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x95DFE0", Offset = "0x95DFE0", VA = "0x95DFE0")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x95E22C", Offset = "0x95E22C", VA = "0x95E22C")]
		private void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x95E2D8", Offset = "0x95E2D8", VA = "0x95E2D8")]
		public RecordSaver()
		{
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x2000066")]
	public enum Platform
	{
		[Token(Token = "0x400022E")]
		Windows,
		[Token(Token = "0x400022F")]
		OSX,
		[Token(Token = "0x4000230")]
		Linux,
		[Token(Token = "0x4000231")]
		IOS,
		[Token(Token = "0x4000232")]
		Android,
		[Token(Token = "0x4000233")]
		WSA,
		[Token(Token = "0x4000234")]
		Web,
		[Token(Token = "0x4000235")]
		Unsupported
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x2000067")]
	[DisallowMultipleComponent]
	public class BackgroundController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000068")]
		private sealed class <>c
		{
			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__3_0;

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x95E8BC", Offset = "0x95E8BC", VA = "0x95E8BC")]
			public <>c()
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x95E8C4", Offset = "0x95E8C4", VA = "0x95E8C4")]
			internal bool <FixedUpdate>b__3_0(GameObject go)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] Objects;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isFocused;

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x95E2E8", Offset = "0x95E2E8", VA = "0x95E2E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x95E308", Offset = "0x95E308", VA = "0x95E308")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x95E844", Offset = "0x95E844", VA = "0x95E844")]
		public BackgroundController()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class PlatformController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006A")]
		private sealed class <>c
		{
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__8_0;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MonoBehaviour, bool> <>9__9_0;

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x95F2C8", Offset = "0x95F2C8", VA = "0x95F2C8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x95F2D0", Offset = "0x95F2D0", VA = "0x95F2D0")]
			internal bool <activateGameObjects>b__8_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x95F32C", Offset = "0x95F32C", VA = "0x95F32C")]
			internal bool <activateScripts>b__9_0(MonoBehaviour script)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Platform> Platforms;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Active;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] Objects;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MonoBehaviour[] Scripts;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Platform currentPlatform;

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x95E920", Offset = "0x95E920", VA = "0x95E920", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x95E948", Offset = "0x95E948", VA = "0x95E948")]
		protected void selectPlatform()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x95EA30", Offset = "0x95EA30", VA = "0x95EA30")]
		protected void activateGameObjects()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x95EE3C", Offset = "0x95EE3C", VA = "0x95EE3C")]
		protected void activateScripts()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x95F248", Offset = "0x95F248", VA = "0x95F248")]
		public PlatformController()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class RandomColor : MonoBehaviour
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseInterval;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 HueRange;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector2 SaturationRange;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 ValueRange;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector2 AlphaRange;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool GrayScale;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Material Material;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool RandomColorAtStart;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer currentRenderer;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Color32 startColor;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Color32 endColor;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float lerpProgress;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int colorID;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool existsMaterial;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x95F388", Offset = "0x95F388", VA = "0x95F388")]
		private void Start()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x95FCB4", Offset = "0x95FCB4", VA = "0x95FCB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x960660", Offset = "0x960660", VA = "0x960660")]
		public RandomColor()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[DisallowMultipleComponent]
	public class RandomRotator : MonoBehaviour
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseInterval;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 SpeedMin;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 SpeedMax;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool RandomRotationAtStart;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool RandomChangeIntervalPerAxis;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		public bool RandomDirectionPerAxis;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 speed;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 elapsedTimeAxis;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 changeTimeAxis;

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x9606F4", Offset = "0x9606F4", VA = "0x9606F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x9607AC", Offset = "0x9607AC", VA = "0x9607AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x960ACC", Offset = "0x960ACC", VA = "0x960ACC")]
		public RandomRotator()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[DisallowMultipleComponent]
	public class RandomScaler : MonoBehaviour
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseInterval;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 ScaleMin;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 ScaleMax;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool Uniform;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool RandomScaleAtStart;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 startScale;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 endScale;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float elapsedTime;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float changeTime;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lerpTime;

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x960B5C", Offset = "0x960B5C", VA = "0x960B5C")]
		private void Start()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x960C44", Offset = "0x960C44", VA = "0x960C44")]
		private void Update()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x960DAC", Offset = "0x960DAC", VA = "0x960DAC")]
		public RandomScaler()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[DisallowMultipleComponent]
	public class SurviveSceneSwitch : Singleton<SurviveSceneSwitch>
	{
		[Serializable]
		[Token(Token = "0x200006F")]
		private sealed class <>c
		{
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__5_0;

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x9612E4", Offset = "0x9612E4", VA = "0x9612E4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x9612EC", Offset = "0x9612EC", VA = "0x9612EC")]
			internal bool <Update>b__5_0(GameObject _go)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] Survivors;

		[Token(Token = "0x400026D")]
		private const float ensureParentTime = 1.5f;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float ensureParentTimer;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tf;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x960DE4", Offset = "0x960DE4", VA = "0x960DE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x960E10", Offset = "0x960E10", VA = "0x960E10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x961208", Offset = "0x961208", VA = "0x961208")]
		public SurviveSceneSwitch()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Regex REGEX_LINEENDINGS;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Regex REGEX_EMAIL;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Regex REGEX_CREDITCARD;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Regex REGEX_URL_WEB;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Regex REGEX_IP_ADDRESS;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Regex REGEX_INVALID_CHARS;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Regex REGEX_ALPHANUMERIC;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly Regex REGEX_CLEAN_SPACES;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly Regex REGEX_CLEAN_TAGS;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x17000115")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x961348", Offset = "0x961348", VA = "0x961348")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x2000071")]
	public abstract class BaseHelper
	{
		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool ApplicationIsPlaying;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string[] args;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int androidAPILevel;

		[Token(Token = "0x17000116")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x96180C", Offset = "0x96180C", VA = "0x96180C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x961814", Offset = "0x961814", VA = "0x961814")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000118")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x96181C", Offset = "0x96181C", VA = "0x96181C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x961824", Offset = "0x961824", VA = "0x961824")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x96182C", Offset = "0x96182C", VA = "0x96182C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x961834", Offset = "0x961834", VA = "0x961834")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x96183C", Offset = "0x96183C", VA = "0x96183C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011D")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x961844", Offset = "0x961844", VA = "0x961844")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x96184C", Offset = "0x96184C", VA = "0x96184C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x961854", Offset = "0x961854", VA = "0x961854")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000120")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x9613CC", Offset = "0x9613CC", VA = "0x9613CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000121")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x9618A4", Offset = "0x9618A4", VA = "0x9618A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000122")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x961904", Offset = "0x961904", VA = "0x961904")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000123")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x95E7F4", Offset = "0x95E7F4", VA = "0x95E7F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		public static bool isEditor
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x961964", Offset = "0x961964", VA = "0x961964")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x96143C", Offset = "0x96143C", VA = "0x96143C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x961444", Offset = "0x961444", VA = "0x961444")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x96144C", Offset = "0x96144C", VA = "0x96144C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x9619D4", Offset = "0x9619D4", VA = "0x9619D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000129")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x961A28", Offset = "0x961A28", VA = "0x961A28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012A")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x95E9B0", Offset = "0x95E9B0", VA = "0x95E9B0")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x961A30", Offset = "0x961A30", VA = "0x961A30")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x961D7C", Offset = "0x961D7C", VA = "0x961D7C")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x961DE4", Offset = "0x961DE4", VA = "0x961DE4")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x9620B8", Offset = "0x9620B8", VA = "0x9620B8")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x9624EC", Offset = "0x9624EC", VA = "0x9624EC")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x961B4C", Offset = "0x961B4C", VA = "0x961B4C")]
		public static string LanguageToISO639(SystemLanguage language)
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x96247C", Offset = "0x96247C", VA = "0x96247C")]
		private static string addLeadingZero(int value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000072")]
	public class CTHelper : MonoBehaviour
	{
		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CTHelper <Instance>k__BackingField;

		[Token(Token = "0x1700012B")]
		public static CTHelper Instance
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x96263C", Offset = "0x96263C", VA = "0x96263C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x962684", Offset = "0x962684", VA = "0x962684")]
			private set
			{
			}
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x9626DC", Offset = "0x9626DC", VA = "0x9626DC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x962738", Offset = "0x962738", VA = "0x962738")]
		[RuntimeInitializeOnLoadMethod]
		private static void create()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x96282C", Offset = "0x96282C", VA = "0x96282C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x962884", Offset = "0x962884", VA = "0x962884")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x9628DC", Offset = "0x9628DC", VA = "0x9628DC")]
		public CTHelper()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x9628E4", Offset = "0x9628E4", VA = "0x9628E4")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x962914", Offset = "0x962914", VA = "0x962914")]
		public static void Save()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x96291C", Offset = "0x96291C", VA = "0x96291C")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x96298C", Offset = "0x96298C", VA = "0x96298C")]
		public static void SetString(string key, string value)
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int <Timeout>k__BackingField;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int <ConnectionLimit>k__BackingField;

		[Token(Token = "0x1700012C")]
		public int Timeout
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x962A0C", Offset = "0x962A0C", VA = "0x962A0C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x962A14", Offset = "0x962A14", VA = "0x962A14")]
			set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public int ConnectionLimit
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x962A1C", Offset = "0x962A1C", VA = "0x962A1C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x962A24", Offset = "0x962A24", VA = "0x962A24")]
			set
			{
			}
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x962A2C", Offset = "0x962A2C", VA = "0x962A2C")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x962A9C", Offset = "0x962A9C", VA = "0x962A9C")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x962B18", Offset = "0x962B18", VA = "0x962B18", Slot = "8")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public abstract class FileHelper
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		private sealed class <>c
		{
			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__9_0;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, string> <>9__9_1;

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x9635AC", Offset = "0x9635AC", VA = "0x9635AC")]
			public <>c()
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x9635B4", Offset = "0x9635B4", VA = "0x9635B4")]
			internal bool <GetFilesForName>b__9_0(string extension)
			{
				return default(bool);
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x963640", Offset = "0x963640", VA = "0x963640")]
			internal string <GetFilesForName>b__9_1(string q)
			{
				return null;
			}
		}

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string applicationDataPath;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x962C78", Offset = "0x962C78", VA = "0x962C78")]
		static FileHelper()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x962CD8", Offset = "0x962CD8", VA = "0x962CD8")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x95C31C", Offset = "0x95C31C", VA = "0x95C31C")]
		public static string ValidatePath(string path, bool addEndDelimiter = true, bool preserveFile = true)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x95D6F0", Offset = "0x95D6F0", VA = "0x95D6F0")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x962E50", Offset = "0x962E50", VA = "0x962E50")]
		public static string[] GetFilesForName(string path, bool isRecursive = false, params string[] filenames)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x963374", Offset = "0x963374", VA = "0x963374")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}
	}
	[Token(Token = "0x2000077")]
	public class MemoryCacheStream : Stream
	{
		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] cache;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long writePosition;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long readPosition;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long length;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int size;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly int maxSize;

		[Token(Token = "0x1700012E")]
		public override bool CanRead
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x963788", Offset = "0x963788", VA = "0x963788", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012F")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x963790", Offset = "0x963790", VA = "0x963790", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000130")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x963798", Offset = "0x963798", VA = "0x963798", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000131")]
		public override long Position
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x9637A0", Offset = "0x9637A0", VA = "0x9637A0", Slot = "10")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x9637A8", Offset = "0x9637A8", VA = "0x9637A8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public override long Length
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x963824", Offset = "0x963824", VA = "0x963824", Slot = "9")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x963648", Offset = "0x963648", VA = "0x963648")]
		public MemoryCacheStream(int cacheSize = 65536, int maxCacheSize = 67108864)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x96382C", Offset = "0x96382C", VA = "0x96382C", Slot = "17")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x963830", Offset = "0x963830", VA = "0x963830", Slot = "26")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x963930", Offset = "0x963930", VA = "0x963930", Slot = "27")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x963AF4", Offset = "0x963AF4", VA = "0x963AF4", Slot = "30")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x963A3C", Offset = "0x963A3C", VA = "0x963A3C")]
		private int read(byte[] buff, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x963C34", Offset = "0x963C34", VA = "0x963C34")]
		private void write(byte[] buff, int offset, int count)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x9636C4", Offset = "0x9636C4", VA = "0x9636C4")]
		private void createCache()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public abstract class NetworkHelper
	{
		[Serializable]
		[Token(Token = "0x2000079")]
		private sealed class <>c
		{
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<X509ChainStatus, bool> <>9__5_0;

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x9643F0", Offset = "0x9643F0", VA = "0x9643F0")]
			public <>c()
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x9643F8", Offset = "0x9643F8", VA = "0x9643F8")]
			internal bool <RemoteCertificateValidationCallback>b__5_0(X509ChainStatus t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000133")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x963CE4", Offset = "0x963CE4", VA = "0x963CE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x963D00", Offset = "0x963D00", VA = "0x963D00")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x964218", Offset = "0x964218", VA = "0x964218")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x962D4C", Offset = "0x962D4C", VA = "0x962D4C")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007A")]
	[DisallowMultipleComponent]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool dontDestroy;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string PrefabPath;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string GameObjectName;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static T instance;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object lockObj;

		[Token(Token = "0x17000134")]
		public static T Instance
		{
			[Token(Token = "0x60004A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A5")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public bool DontDestroy
		{
			[Token(Token = "0x60004A6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A7")]
			set
			{
			}
		}

		[Token(Token = "0x60004A8")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004A9")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004AA")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60004AB")]
		public static void CreateInstance(bool searchExistingGameObject = true, bool deleteExistingInstance = false)
		{
		}

		[Token(Token = "0x60004AC")]
		public static void DeleteInstance()
		{
		}

		[Token(Token = "0x60004AD")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class SingletonHelper
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool <isQuitting>k__BackingField;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool isInitialized;

		[Token(Token = "0x17000136")]
		public static bool isQuitting
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x964404", Offset = "0x964404", VA = "0x964404")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x96445C", Offset = "0x96445C", VA = "0x96445C")]
			set
			{
			}
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x9644B8", Offset = "0x9644B8", VA = "0x9644B8")]
		static SingletonHelper()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x9645AC", Offset = "0x9645AC", VA = "0x9645AC")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x9648B4", Offset = "0x9648B4", VA = "0x9648B4")]
		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x964A38", Offset = "0x964A38", VA = "0x964A38")]
		private static void onQuitting()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public abstract class XmlHelper
	{
		[Token(Token = "0x60004B5")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x60004B6")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		public static byte[] SerializeToByteArray<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x60004B9")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}
	}
}
namespace Crosstales.Common.Audio
{
	[Token(Token = "0x200007D")]
	[DisallowMultipleComponent]
	public class FFTAnalyzer : MonoBehaviour
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] Samples;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public int Channel;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FFTWindow FFTMode;

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x964B8C", Offset = "0x964B8C", VA = "0x964B8C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x964BA0", Offset = "0x964BA0", VA = "0x964BA0")]
		public FFTAnalyzer()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class SpectrumVisualizer : MonoBehaviour
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FFTAnalyzer Analyzer;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject VisualPrefab;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Width;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float Gain;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool LeftToRight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float Opacity;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform tf;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform[] visualTransforms;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 visualPos;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int samplesPerChannel;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x964C0C", Offset = "0x964C0C", VA = "0x964C0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x964F50", Offset = "0x964F50", VA = "0x964F50")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x964FF4", Offset = "0x964FF4", VA = "0x964FF4")]
		public SpectrumVisualizer()
		{
		}
	}
}
