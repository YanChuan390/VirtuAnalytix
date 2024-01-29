using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
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
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

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
			[Address(RVA = "0x6DCFBC", Offset = "0x6DCFBC", VA = "0x6DCFBC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x6DD748", Offset = "0x6DD748", VA = "0x6DD748")]
			internal bool <CTContainsAny>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 flat;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x6DCD7C", Offset = "0x6DCD7C", VA = "0x6DCD7C")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x6DCE1C", Offset = "0x6DCE1C", VA = "0x6DCE1C")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x6DCE2C", Offset = "0x6DCE2C", VA = "0x6DCE2C")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x6DCE4C", Offset = "0x6DCE4C", VA = "0x6DCE4C")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x6DCFC4", Offset = "0x6DCFC4", VA = "0x6DCFC4")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x6DD018", Offset = "0x6DD018", VA = "0x6DD018")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x6DD06C", Offset = "0x6DD06C", VA = "0x6DD06C")]
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
		[Address(RVA = "0x6DD10C", Offset = "0x6DD10C", VA = "0x6DD10C")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x6DD2A0", Offset = "0x6DD2A0", VA = "0x6DD2A0")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x6DD3E0", Offset = "0x6DD3E0", VA = "0x6DD3E0")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x6DD5E0", Offset = "0x6DD5E0", VA = "0x6DD5E0")]
		public static bool CTHasActiveClip(this AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x6DD284", Offset = "0x6DD284", VA = "0x6DD284")]
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
			[Address(RVA = "0x6DD7D4", Offset = "0x6DD7D4", VA = "0x6DD7D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public static bool isAnyAudioPlaying
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x6DD81C", Offset = "0x6DD81C", VA = "0x6DD81C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		protected static int playCounter
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x6DD864", Offset = "0x6DD864", VA = "0x6DD864")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x6DD8AC", Offset = "0x6DD8AC", VA = "0x6DD8AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		protected static int audioCounter
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x6DD8FC", Offset = "0x6DD8FC", VA = "0x6DD8FC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x6DD944", Offset = "0x6DD944", VA = "0x6DD944")]
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
		public abstract bool CaptureDataStream
		{
			[Token(Token = "0x600003F")]
			get;
			[Token(Token = "0x6000040")]
			set;
		}

		[Token(Token = "0x17000012")]
		public abstract bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000041")]
			get;
			[Token(Token = "0x6000042")]
			set;
		}

		[Token(Token = "0x17000013")]
		public abstract bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000043")]
			get;
			[Token(Token = "0x6000044")]
			set;
		}

		[Token(Token = "0x17000014")]
		public abstract AudioSource Source
		{
			[Token(Token = "0x6000045")]
			get;
			[Token(Token = "0x6000046")]
			protected set;
		}

		[Token(Token = "0x17000015")]
		public abstract float Position
		{
			[Token(Token = "0x6000047")]
			get;
			[Token(Token = "0x6000048")]
			set;
		}

		[Token(Token = "0x17000016")]
		public abstract int SamplePosition
		{
			[Token(Token = "0x6000049")]
			get;
			[Token(Token = "0x600004A")]
			set;
		}

		[Token(Token = "0x17000017")]
		public abstract float Elapsed
		{
			[Token(Token = "0x600004B")]
			get;
			[Token(Token = "0x600004C")]
			set;
		}

		[Token(Token = "0x17000018")]
		public abstract float Duration
		{
			[Token(Token = "0x600004D")]
			get;
		}

		[Token(Token = "0x17000019")]
		public abstract int Samples
		{
			[Token(Token = "0x600004E")]
			get;
		}

		[Token(Token = "0x1700001A")]
		public abstract AudioCodec Codec
		{
			[Token(Token = "0x600004F")]
			get;
			[Token(Token = "0x6000050")]
			protected set;
		}

		[Token(Token = "0x1700001B")]
		public abstract float BufferProgress
		{
			[Token(Token = "0x6000051")]
			get;
			[Token(Token = "0x6000052")]
			protected set;
		}

		[Token(Token = "0x1700001C")]
		public abstract bool isBuffering
		{
			[Token(Token = "0x6000053")]
			get;
		}

		[Token(Token = "0x1700001D")]
		public abstract bool isPlayback
		{
			[Token(Token = "0x6000054")]
			get;
		}

		[Token(Token = "0x1700001E")]
		public abstract bool isAudioPlaying
		{
			[Token(Token = "0x6000055")]
			get;
			[Token(Token = "0x6000056")]
			protected set;
		}

		[Token(Token = "0x1700001F")]
		public abstract bool isPaused
		{
			[Token(Token = "0x6000057")]
			get;
			[Token(Token = "0x6000058")]
			set;
		}

		[Token(Token = "0x17000020")]
		public abstract Stream DataStream
		{
			[Token(Token = "0x6000059")]
			get;
			[Token(Token = "0x600005A")]
			protected set;
		}

		[Token(Token = "0x17000021")]
		public abstract int Channels
		{
			[Token(Token = "0x600005B")]
			get;
		}

		[Token(Token = "0x17000022")]
		public abstract int SampleRate
		{
			[Token(Token = "0x600005C")]
			get;
		}

		[Token(Token = "0x17000023")]
		public abstract float Volume
		{
			[Token(Token = "0x600005D")]
			get;
			[Token(Token = "0x600005E")]
			set;
		}

		[Token(Token = "0x17000024")]
		public abstract float Pitch
		{
			[Token(Token = "0x600005F")]
			get;
			[Token(Token = "0x6000060")]
			set;
		}

		[Token(Token = "0x17000025")]
		public abstract float StereoPan
		{
			[Token(Token = "0x6000061")]
			get;
			[Token(Token = "0x6000062")]
			set;
		}

		[Token(Token = "0x17000026")]
		public abstract bool isMuted
		{
			[Token(Token = "0x6000063")]
			get;
			[Token(Token = "0x6000064")]
			set;
		}

		[Token(Token = "0x17000027")]
		public abstract List<Record> PlayedRecords
		{
			[Token(Token = "0x6000065")]
			get;
		}

		[Token(Token = "0x14000001")]
		public event PlaybackStart OnPlaybackStart
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x6DD994", Offset = "0x6DD994", VA = "0x6DD994")]
			add
			{
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x6DDA30", Offset = "0x6DDA30", VA = "0x6DDA30")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event PlaybackEnd OnPlaybackEnd
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x6DDACC", Offset = "0x6DDACC", VA = "0x6DDACC")]
			add
			{
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x6DDB68", Offset = "0x6DDB68", VA = "0x6DDB68")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event BufferingStart OnBufferingStart
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x6DDC04", Offset = "0x6DDC04", VA = "0x6DDC04")]
			add
			{
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x6DDCA0", Offset = "0x6DDCA0", VA = "0x6DDCA0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event BufferingEnd OnBufferingEnd
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x6DDD3C", Offset = "0x6DDD3C", VA = "0x6DDD3C")]
			add
			{
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x6DDDD8", Offset = "0x6DDDD8", VA = "0x6DDDD8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event BufferingProgressUpdate OnBufferingProgressUpdate
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x6DDE74", Offset = "0x6DDE74", VA = "0x6DDE74")]
			add
			{
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x6DDF10", Offset = "0x6DDF10", VA = "0x6DDF10")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event AudioStart OnAudioStart
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x6DDFAC", Offset = "0x6DDFAC", VA = "0x6DDFAC")]
			add
			{
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x6DE048", Offset = "0x6DE048", VA = "0x6DE048")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event AudioEnd OnAudioEnd
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x6DE0E4", Offset = "0x6DE0E4", VA = "0x6DE0E4")]
			add
			{
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x6DE180", Offset = "0x6DE180", VA = "0x6DE180")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event LoopPositionReached OnLoopPositionReached
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x6DE21C", Offset = "0x6DE21C", VA = "0x6DE21C")]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x6DE2B8", Offset = "0x6DE2B8", VA = "0x6DE2B8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event AudioPlayTimeUpdate OnAudioPlayTimeUpdate
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x6DE354", Offset = "0x6DE354", VA = "0x6DE354")]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x6DE3F0", Offset = "0x6DE3F0", VA = "0x6DE3F0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x6DE48C", Offset = "0x6DE48C", VA = "0x6DE48C")]
			add
			{
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x6DE528", Offset = "0x6DE528", VA = "0x6DE528")]
			remove
			{
			}
		}

		[Token(Token = "0x6000066")]
		public abstract void Play();

		[Token(Token = "0x6000067")]
		public abstract void Next();

		[Token(Token = "0x6000068")]
		public abstract void Previous();

		[Token(Token = "0x6000069")]
		public abstract void Pause();

		[Token(Token = "0x600006A")]
		public abstract void UnPause();

		[Token(Token = "0x600006B")]
		public abstract void Stop();

		[Token(Token = "0x600006C")]
		public abstract void Restart();

		[Token(Token = "0x600006D")]
		public abstract void Mute();

		[Token(Token = "0x600006E")]
		public abstract void UnMute();

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x6DE5C4", Offset = "0x6DE5C4", VA = "0x6DE5C4", Slot = "71")]
		public virtual void PlayOrStop()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x6DE604", Offset = "0x6DE604", VA = "0x6DE604", Slot = "72")]
		public virtual void PauseOrUnPause()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x6DE644", Offset = "0x6DE644", VA = "0x6DE644", Slot = "73")]
		public virtual void MuteOrUnMute()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x6DE684", Offset = "0x6DE684", VA = "0x6DE684", Slot = "74")]
		protected virtual void onPlaybackStart(Record record)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x6DE850", Offset = "0x6DE850", VA = "0x6DE850", Slot = "75")]
		protected virtual void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x6DEA1C", Offset = "0x6DEA1C", VA = "0x6DEA1C", Slot = "76")]
		protected virtual void onBufferingStart(Record record)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x6DEB30", Offset = "0x6DEB30", VA = "0x6DEB30", Slot = "77")]
		protected virtual void onBufferingEnd(Record record)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x6DEC0C", Offset = "0x6DEC0C", VA = "0x6DEC0C", Slot = "78")]
		protected virtual void onBufferingProgressUpdate(Record record, float progress)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x6DEC28", Offset = "0x6DEC28", VA = "0x6DEC28", Slot = "79")]
		protected virtual void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x6DEDF4", Offset = "0x6DEDF4", VA = "0x6DEDF4", Slot = "80")]
		protected virtual void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x6DEFC0", Offset = "0x6DEFC0", VA = "0x6DEFC0", Slot = "81")]
		protected virtual void onLoopPositionReached(Record record, LoopPoint lp)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x6DF128", Offset = "0x6DF128", VA = "0x6DF128", Slot = "82")]
		protected virtual void onAudioPlayTimeUpdate(Record record, float playtime)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x6DF144", Offset = "0x6DF144", VA = "0x6DF144", Slot = "83")]
		protected virtual void onErrorInfo(Record record, string info)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x6DF2FC", Offset = "0x6DF2FC", VA = "0x6DF2FC")]
		protected BasePlayer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public class PlaybackStartEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x6DF304", Offset = "0x6DF304", VA = "0x6DF304")]
		public PlaybackStartEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class PlaybackEndEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x6DF34C", Offset = "0x6DF34C", VA = "0x6DF34C")]
		public PlaybackEndEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class AudioStartEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x6DF394", Offset = "0x6DF394", VA = "0x6DF394")]
		public AudioStartEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class AudioEndEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x6DF3DC", Offset = "0x6DF3DC", VA = "0x6DF3DC")]
		public AudioEndEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class ErrorEvent : UnityEvent<string, string, int, string>
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x6DF424", Offset = "0x6DF424", VA = "0x6DF424")]
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
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x6E02EC", Offset = "0x6E02EC", VA = "0x6E02EC")]
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
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x6E0484", Offset = "0x6E0484", VA = "0x6E0484")]
		public RecordsChangeEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class ErrorProviderEvent : UnityEvent<string>
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x6E048C", Offset = "0x6E048C", VA = "0x6E048C")]
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
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x6E06AC", Offset = "0x6E06AC", VA = "0x6E06AC")]
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

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x6E18CC", Offset = "0x6E18CC", VA = "0x6E18CC")]
			public <>c()
			{
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x6E18D4", Offset = "0x6E18D4", VA = "0x6E18D4")]
			internal int <get_CurrentDataCacheSize>b__14_0(KeyValuePair<string, byte[]> pair)
			{
				return default(int);
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x6E1918", Offset = "0x6E1918", VA = "0x6E1918")]
			internal int <get_CurrentClipCacheSize>b__16_0(KeyValuePair<string, AudioClip> pair)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("ClipCacheSize")]
		[SerializeField]
		private int clipCacheSize;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("DataCacheSize")]
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

		[Token(Token = "0x17000028")]
		public int ClipCacheSize
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x6E0794", Offset = "0x6E0794", VA = "0x6E0794")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x6E07A0", Offset = "0x6E07A0", VA = "0x6E07A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public int DataCacheSize
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x6E07D4", Offset = "0x6E07D4", VA = "0x6E07D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x6E07E0", Offset = "0x6E07E0", VA = "0x6E07E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int CurrentDataCacheSize
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x6E0814", Offset = "0x6E0814", VA = "0x6E0814")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		public int CurrentClipCacheSize
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x6E0944", Offset = "0x6E0944", VA = "0x6E0944")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x6E0A74", Offset = "0x6E0A74", VA = "0x6E0A74")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x6E0AC0", Offset = "0x6E0AC0", VA = "0x6E0AC0", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x6E0B20", Offset = "0x6E0B20", VA = "0x6E0B20")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x6E0B84", Offset = "0x6E0B84", VA = "0x6E0B84")]
		public AudioClip GetClip(string key)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x6E0C20", Offset = "0x6E0C20", VA = "0x6E0C20")]
		public void RemoveClip(string key)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x6E0D8C", Offset = "0x6E0D8C", VA = "0x6E0D8C")]
		public void AddClip(string key, AudioClip data)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x6E0FA8", Offset = "0x6E0FA8", VA = "0x6E0FA8")]
		public byte[] GetData(string key)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x6E1044", Offset = "0x6E1044", VA = "0x6E1044")]
		public void RemoveData(string key)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x6E1148", Offset = "0x6E1148", VA = "0x6E1148")]
		public void AddData(string key, byte[] data)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x6E1330", Offset = "0x6E1330", VA = "0x6E1330")]
		public void ClearDataCache()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x6E1424", Offset = "0x6E1424", VA = "0x6E1424")]
		public void ClearClipCache()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x6E0B10", Offset = "0x6E0B10", VA = "0x6E0B10")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x6E1670", Offset = "0x6E1670", VA = "0x6E1670")]
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

		[Token(Token = "0x1700002C")]
		public Turntable Turntable
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x6E1968", Offset = "0x6E1968", VA = "0x6E1968")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x6E1DD8", Offset = "0x6E1DD8", VA = "0x6E1DD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public BaseSet Set
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x6E1DE0", Offset = "0x6E1DE0", VA = "0x6E1DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x6E1DE8", Offset = "0x6E1DE8", VA = "0x6E1DE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public RecordFilter Filter
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x6E1DF0", Offset = "0x6E1DF0", VA = "0x6E1DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x6E1DF8", Offset = "0x6E1DF8", VA = "0x6E1DF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool PlayOnStart
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x6E1E00", Offset = "0x6E1E00", VA = "0x6E1E00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x6E1E08", Offset = "0x6E1E08", VA = "0x6E1E08")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool PlayEndless
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x6E1E14", Offset = "0x6E1E14", VA = "0x6E1E14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x6E1E1C", Offset = "0x6E1E1C", VA = "0x6E1E1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool PlayRandom
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x6E1E28", Offset = "0x6E1E28", VA = "0x6E1E28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x6E1E30", Offset = "0x6E1E30", VA = "0x6E1E30")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		protected override PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x6E1E3C", Offset = "0x6E1E3C", VA = "0x6E1E3C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		protected override PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x6E1E44", Offset = "0x6E1E44", VA = "0x6E1E44", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		protected override AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x6E1E4C", Offset = "0x6E1E4C", VA = "0x6E1E4C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		protected override AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x6E1E54", Offset = "0x6E1E54", VA = "0x6E1E54", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		protected override ErrorEvent onError
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x6E1E5C", Offset = "0x6E1E5C", VA = "0x6E1E5C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public List<Record> Records
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x6E3C38", Offset = "0x6E3C38", VA = "0x6E3C38", Slot = "88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public List<Record> RandomRecords
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x6E3D04", Offset = "0x6E3D04", VA = "0x6E3D04", Slot = "89")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public bool isReady
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x6E3DD0", Offset = "0x6E3DD0", VA = "0x6E3DD0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x6E3E5C", Offset = "0x6E3E5C", VA = "0x6E3E5C", Slot = "91")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700003B")]
		public long TotalSize
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x6E4000", Offset = "0x6E4000", VA = "0x6E4000", Slot = "92")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700003C")]
		public int CurrentRecordIndex
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x6E41A0", Offset = "0x6E41A0", VA = "0x6E41A0", Slot = "93")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x6E4220", Offset = "0x6E4220", VA = "0x6E4220", Slot = "94")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public int CurrentRandomRecordIndex
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x6E4324", Offset = "0x6E4324", VA = "0x6E4324", Slot = "95")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x6E43A4", Offset = "0x6E43A4", VA = "0x6E43A4", Slot = "96")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override Record Record
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x6EC448", Offset = "0x6EC448", VA = "0x6EC448", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x6EC468", Offset = "0x6EC468", VA = "0x6EC468", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override bool isLoop
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x6EC490", Offset = "0x6EC490", VA = "0x6EC490", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x6EC4B0", Offset = "0x6EC4B0", VA = "0x6EC4B0", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public override bool HandleFocus
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x6EC4D8", Offset = "0x6EC4D8", VA = "0x6EC4D8", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x6EC4FC", Offset = "0x6EC4FC", VA = "0x6EC4FC", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public override bool Caching
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x6EC528", Offset = "0x6EC528", VA = "0x6EC528", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x6EC54C", Offset = "0x6EC54C", VA = "0x6EC54C", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public override bool Streaming
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x6EC578", Offset = "0x6EC578", VA = "0x6EC578", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x6EC59C", Offset = "0x6EC59C", VA = "0x6EC59C", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public override int ChunkSize
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x6EC5C8", Offset = "0x6EC5C8", VA = "0x6EC5C8", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x6EC5EC", Offset = "0x6EC5EC", VA = "0x6EC5EC", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public override int CacheStreamSize
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x6EC618", Offset = "0x6EC618", VA = "0x6EC618", Slot = "21")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x6EC63C", Offset = "0x6EC63C", VA = "0x6EC63C", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public override bool CaptureDataStream
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x6EC668", Offset = "0x6EC668", VA = "0x6EC668", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x6EC68C", Offset = "0x6EC68C", VA = "0x6EC68C", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public override bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x6EC6B8", Offset = "0x6EC6B8", VA = "0x6EC6B8", Slot = "25")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x6EC6DC", Offset = "0x6EC6DC", VA = "0x6EC6DC", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x6EC708", Offset = "0x6EC708", VA = "0x6EC708", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x6EC72C", Offset = "0x6EC72C", VA = "0x6EC72C", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public override AudioSource Source
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x6EC758", Offset = "0x6EC758", VA = "0x6EC758", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x6EC77C", Offset = "0x6EC77C", VA = "0x6EC77C", Slot = "30")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public override float Position
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x6EC780", Offset = "0x6EC780", VA = "0x6EC780", Slot = "31")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x6EC7A4", Offset = "0x6EC7A4", VA = "0x6EC7A4", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public override int SamplePosition
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x6EC7D8", Offset = "0x6EC7D8", VA = "0x6EC7D8", Slot = "33")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x6EC7FC", Offset = "0x6EC7FC", VA = "0x6EC7FC", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public override float Elapsed
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x6EC828", Offset = "0x6EC828", VA = "0x6EC828", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x6EC84C", Offset = "0x6EC84C", VA = "0x6EC84C", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public override float Duration
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x6EC880", Offset = "0x6EC880", VA = "0x6EC880", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004D")]
		public override int Samples
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x6EC8A4", Offset = "0x6EC8A4", VA = "0x6EC8A4", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004E")]
		public override AudioCodec Codec
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x6EC8C8", Offset = "0x6EC8C8", VA = "0x6EC8C8", Slot = "39")]
			get
			{
				return default(AudioCodec);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x6EC8EC", Offset = "0x6EC8EC", VA = "0x6EC8EC", Slot = "40")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public override float BufferProgress
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x6EC8F0", Offset = "0x6EC8F0", VA = "0x6EC8F0", Slot = "41")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x6EC914", Offset = "0x6EC914", VA = "0x6EC914", Slot = "42")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public override bool isPlayback
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x6EC918", Offset = "0x6EC918", VA = "0x6EC918", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public override bool isAudioPlaying
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x6EC93C", Offset = "0x6EC93C", VA = "0x6EC93C", Slot = "45")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x6EC960", Offset = "0x6EC960", VA = "0x6EC960", Slot = "46")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public override bool isBuffering
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x6EC964", Offset = "0x6EC964", VA = "0x6EC964", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public override bool isPaused
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x6EC988", Offset = "0x6EC988", VA = "0x6EC988", Slot = "47")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x6EC9AC", Offset = "0x6EC9AC", VA = "0x6EC9AC", Slot = "48")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public override Stream DataStream
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x6EC9D8", Offset = "0x6EC9D8", VA = "0x6EC9D8", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x6EC9FC", Offset = "0x6EC9FC", VA = "0x6EC9FC", Slot = "50")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public override int Channels
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x6ECA00", Offset = "0x6ECA00", VA = "0x6ECA00", Slot = "51")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000056")]
		public override int SampleRate
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x6ECA24", Offset = "0x6ECA24", VA = "0x6ECA24", Slot = "52")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000057")]
		public override float Volume
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x6ECA48", Offset = "0x6ECA48", VA = "0x6ECA48", Slot = "53")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x6ECA6C", Offset = "0x6ECA6C", VA = "0x6ECA6C", Slot = "54")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public override float Pitch
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x6ECAA0", Offset = "0x6ECAA0", VA = "0x6ECAA0", Slot = "55")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x6ECAC4", Offset = "0x6ECAC4", VA = "0x6ECAC4", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public override float StereoPan
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x6ECAF8", Offset = "0x6ECAF8", VA = "0x6ECAF8", Slot = "57")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x6ECB1C", Offset = "0x6ECB1C", VA = "0x6ECB1C", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public override bool isMuted
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x6ECB50", Offset = "0x6ECB50", VA = "0x6ECB50", Slot = "59")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x6ECB74", Offset = "0x6ECB74", VA = "0x6ECB74", Slot = "60")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public override List<Record> PlayedRecords
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x6ECBA0", Offset = "0x6ECBA0", VA = "0x6ECBA0", Slot = "61")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000B")]
		public event RecordChange OnRecordChange
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x6E1E64", Offset = "0x6E1E64", VA = "0x6E1E64")]
			add
			{
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x6E1F00", Offset = "0x6E1F00", VA = "0x6E1F00")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event FilterChange OnFilterChange
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x6E1F9C", Offset = "0x6E1F9C", VA = "0x6E1F9C")]
			add
			{
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x6E2038", Offset = "0x6E2038", VA = "0x6E2038")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x6E20D4", Offset = "0x6E20D4", VA = "0x6E20D4")]
			add
			{
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x6E2170", Offset = "0x6E2170", VA = "0x6E2170")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x6E220C", Offset = "0x6E220C", VA = "0x6E220C")]
			add
			{
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x6E22A8", Offset = "0x6E22A8", VA = "0x6E22A8")]
			remove
			{
			}
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x6E2344", Offset = "0x6E2344", VA = "0x6E2344")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x6E2A68", Offset = "0x6E2A68", VA = "0x6E2A68")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x6E2B40", Offset = "0x6E2B40", VA = "0x6E2B40")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x6E3194", Offset = "0x6E3194", VA = "0x6E3194")]
		private void play()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x6E31B8", Offset = "0x6E31B8", VA = "0x6E31B8")]
		private RecordFilter getFilter([Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x6E320C", Offset = "0x6E320C", VA = "0x6E320C")]
		private void playEndlessly()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x6E34F4", Offset = "0x6E34F4", VA = "0x6E34F4", Slot = "79")]
		protected override void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x6E3528", Offset = "0x6E3528", VA = "0x6E3528", Slot = "80")]
		protected override void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x6E3580", Offset = "0x6E3580", VA = "0x6E3580", Slot = "83")]
		protected override void onErrorInfo(Record record, string info)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x6E35B8", Offset = "0x6E35B8", VA = "0x6E35B8", Slot = "84")]
		protected virtual void onRecordChange(Record newRecord)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x6E3774", Offset = "0x6E3774", VA = "0x6E3774", Slot = "85")]
		protected virtual void onFilterChange()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x6E3928", Offset = "0x6E3928", VA = "0x6E3928", Slot = "86")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x6E3AEC", Offset = "0x6E3AEC", VA = "0x6E3AEC", Slot = "87")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x6E44A8", Offset = "0x6E44A8", VA = "0x6E44A8", Slot = "97")]
		public void Load()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x6E32F8", Offset = "0x6E32F8", VA = "0x6E32F8", Slot = "98")]
		public Record Next(bool random, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x6E33F8", Offset = "0x6E33F8", VA = "0x6E33F8", Slot = "99")]
		public Record Previous(bool random, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x6E4594", Offset = "0x6E4594", VA = "0x6E4594", Slot = "100")]
		public void RandomizeRecords(bool resetIndex = true)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x6E46CC", Offset = "0x6E46CC", VA = "0x6E46CC", Slot = "101")]
		public List<Record> GetRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x6E482C", Offset = "0x6E482C", VA = "0x6E482C", Slot = "102")]
		public int CountRecords([Optional] RecordFilter _filter)
		{
			return default(int);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x6E4940", Offset = "0x6E4940", VA = "0x6E4940", Slot = "103")]
		public double PlaytimeRecords([Optional] RecordFilter _filter)
		{
			return default(double);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x6E4B18", Offset = "0x6E4B18", VA = "0x6E4B18", Slot = "104")]
		public long SizeRecords([Optional] RecordFilter _filter)
		{
			return default(long);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x6E4CEC", Offset = "0x6E4CEC", VA = "0x6E4CEC", Slot = "105")]
		public Record RecordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x6E4DBC", Offset = "0x6E4DBC", VA = "0x6E4DBC", Slot = "106")]
		public Record RecordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x6E4E58", Offset = "0x6E4E58", VA = "0x6E4E58", Slot = "107")]
		public List<Record> RecordsByFilePath(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x6E5718", Offset = "0x6E5718", VA = "0x6E5718", Slot = "108")]
		public List<Record> RecordsByName(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x6E5FBC", Offset = "0x6E5FBC", VA = "0x6E5FBC", Slot = "109")]
		public List<Record> RecordsByTitle(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x6E6860", Offset = "0x6E6860", VA = "0x6E6860", Slot = "110")]
		public List<Record> RecordsByArtist(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x6E73B8", Offset = "0x6E73B8", VA = "0x6E73B8", Slot = "111")]
		public List<Record> RecordsByAlbum(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x6E7F14", Offset = "0x6E7F14", VA = "0x6E7F14", Slot = "112")]
		public List<Record> RecordsByGenre(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x6E8A78", Offset = "0x6E8A78", VA = "0x6E8A78", Slot = "113")]
		public List<Record> RecordsByRating(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x6E9608", Offset = "0x6E9608", VA = "0x6E9608", Slot = "114")]
		public List<Record> RecordsByYear(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x6EA198", Offset = "0x6EA198", VA = "0x6EA198", Slot = "115")]
		public List<Record> RecordsByDuration(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x6EAD28", Offset = "0x6EAD28", VA = "0x6EAD28", Slot = "116")]
		public List<Record> RecordsByFileSize(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x6EB8B8", Offset = "0x6EB8B8", VA = "0x6EB8B8", Slot = "117")]
		public List<Record> RecordsByFormat(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x6ECBC4", Offset = "0x6ECBC4", VA = "0x6ECBC4", Slot = "62")]
		public override void Play()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x6ECE48", Offset = "0x6ECE48", VA = "0x6ECE48", Slot = "63")]
		public override void Next()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x6ECE54", Offset = "0x6ECE54", VA = "0x6ECE54", Slot = "64")]
		public override void Previous()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x6ECE60", Offset = "0x6ECE60", VA = "0x6ECE60", Slot = "65")]
		public override void Pause()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x6ECE84", Offset = "0x6ECE84", VA = "0x6ECE84", Slot = "66")]
		public override void UnPause()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x6ECEA8", Offset = "0x6ECEA8", VA = "0x6ECEA8", Slot = "67")]
		public override void Stop()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x6ECF44", Offset = "0x6ECF44", VA = "0x6ECF44", Slot = "68")]
		public override void Restart()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x6ECF68", Offset = "0x6ECF68", VA = "0x6ECF68", Slot = "69")]
		public override void Mute()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x6ECF8C", Offset = "0x6ECF8C", VA = "0x6ECF8C", Slot = "70")]
		public override void UnMute()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x6ECFB0", Offset = "0x6ECFB0", VA = "0x6ECFB0")]
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
		private sealed class <>c__DisplayClass185_0
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Turntable <>4__this;

			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Record _record;

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x6F234C", Offset = "0x6F234C", VA = "0x6F234C")]
			public <>c__DisplayClass185_0()
			{
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x6F2354", Offset = "0x6F2354", VA = "0x6F2354")]
			internal void <ctPlayAudio>b__3()
			{
			}
		}

		[Token(Token = "0x2000022")]
		private sealed class <>c__DisplayClass185_1
		{
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] pcmData;

			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass185_0 CS$<>8__locals1;

			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x6F2370", Offset = "0x6F2370", VA = "0x6F2370")]
			public <>c__DisplayClass185_1()
			{
			}
		}

		[Token(Token = "0x2000023")]
		private sealed class <>c__DisplayClass185_2
		{
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int duration;

			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass185_1 CS$<>8__locals2;

			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x6F2378", Offset = "0x6F2378", VA = "0x6F2378")]
			public <>c__DisplayClass185_2()
			{
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x6F2380", Offset = "0x6F2380", VA = "0x6F2380")]
			internal void <ctPlayAudio>b__0()
			{
			}
		}

		[Token(Token = "0x2000024")]
		private sealed class <>c__DisplayClass185_3
		{
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int duration;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass185_1 CS$<>8__locals3;

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x6F23B4", Offset = "0x6F23B4", VA = "0x6F23B4")]
			public <>c__DisplayClass185_3()
			{
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x6F23BC", Offset = "0x6F23BC", VA = "0x6F23BC")]
			internal void <ctPlayAudio>b__1()
			{
			}
		}

		[Token(Token = "0x2000025")]
		private sealed class <>c__DisplayClass185_4
		{
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool buffered;

			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass185_0 CS$<>8__locals4;

			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x6F23F0", Offset = "0x6F23F0", VA = "0x6F23F0")]
			public <>c__DisplayClass185_4()
			{
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x6F23F8", Offset = "0x6F23F8", VA = "0x6F23F8")]
			internal void <ctPlayAudio>b__2()
			{
			}
		}

		[Token(Token = "0x2000026")]
		private sealed class <>c__DisplayClass185_5
		{
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float[] pcmData;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass185_0 CS$<>8__locals5;

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x6F2434", Offset = "0x6F2434", VA = "0x6F2434")]
			public <>c__DisplayClass185_5()
			{
			}
		}

		[Token(Token = "0x2000027")]
		private sealed class <>c__DisplayClass185_6
		{
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int duration;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass185_5 CS$<>8__locals6;

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x6F243C", Offset = "0x6F243C", VA = "0x6F243C")]
			public <>c__DisplayClass185_6()
			{
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x6F2444", Offset = "0x6F2444", VA = "0x6F2444")]
			internal void <ctPlayAudio>b__4()
			{
			}
		}

		[Token(Token = "0x2000028")]
		private sealed class <>c__DisplayClass185_7
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int duration;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass185_5 CS$<>8__locals7;

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x6F2478", Offset = "0x6F2478", VA = "0x6F2478")]
			public <>c__DisplayClass185_7()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x6F2480", Offset = "0x6F2480", VA = "0x6F2480")]
			internal void <ctPlayAudio>b__5()
			{
			}
		}

		[Token(Token = "0x2000029")]
		private sealed class <ctPlayAudio>d__185 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Turntable <>4__this;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool cache;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] data;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass185_1 <>8__1;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass185_4 <>8__2;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass185_5 <>8__3;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass185_0 <>8__4;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private AudioClip <ac>5__2;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int <totalSamples>5__3;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private UnityWebRequest <www>5__4;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Stream <>7__wrap4;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private bool <success>5__6;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Thread <reader>5__7;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private float <bufferCurrentProgress>5__8;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private int <bufferSize>5__9;

			[Token(Token = "0x17000084")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x6F75E0", Offset = "0x6F75E0", VA = "0x6F75E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x6F7628", Offset = "0x6F7628", VA = "0x6F7628", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x6F1348", Offset = "0x6F1348", VA = "0x6F1348")]
			[DebuggerHidden]
			public <ctPlayAudio>d__185(int <>1__state)
			{
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x6F24B4", Offset = "0x6F24B4", VA = "0x6F24B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x6F2628", Offset = "0x6F2628", VA = "0x6F2628", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x6F73FC", Offset = "0x6F73FC", VA = "0x6F73FC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x6F71EC", Offset = "0x6F71EC", VA = "0x6F71EC")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x6F713C", Offset = "0x6F713C", VA = "0x6F713C")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x6F729C", Offset = "0x6F729C", VA = "0x6F729C")]
			private void <>m__Finally4()
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x6F734C", Offset = "0x6F734C", VA = "0x6F734C")]
			private void <>m__Finally5()
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x6F75E8", Offset = "0x6F75E8", VA = "0x6F75E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002A")]
		private sealed class <unityPlayAudio>d__193 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Turntable <>4__this;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool cache;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioClip clip;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Record <_record>5__2;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private AudioClip <ac>5__4;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x6F85D4", Offset = "0x6F85D4", VA = "0x6F85D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x6F861C", Offset = "0x6F861C", VA = "0x6F861C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x6F199C", Offset = "0x6F199C", VA = "0x6F199C")]
			[DebuggerHidden]
			public <unityPlayAudio>d__193(int <>1__state)
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x6F7630", Offset = "0x6F7630", VA = "0x6F7630", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x6F7650", Offset = "0x6F7650", VA = "0x6F7650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x6F8524", Offset = "0x6F8524", VA = "0x6F8524")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x6F85DC", Offset = "0x6F85DC", VA = "0x6F85DC", Slot = "8")]
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
		[FormerlySerializedAs("PlayOnStart")]
		[SerializeField]
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
		[SerializeField]
		[FormerlySerializedAs("ChunkSize")]
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
		[FormerlySerializedAs("CaptureDataStream")]
		[SerializeField]
		private bool captureDataStream;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[SerializeField]
		private bool forceInternalMP3Codec;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		[SerializeField]
		private bool forceInternalOGGCodec;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		[SerializeField]
		private bool internalCodecsReadPCM;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool ctdecoder;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		private bool error;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string errorMessage;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private VorbisReader nVorbisReader;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private MpegFile nLayerReader;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int oggCacheCleanFrameCount;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Thread worker;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Thread timer;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool stopped;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool bufferAvailable;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		private bool playback;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Stream ms;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float ctPosition;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool paused;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioClip lastClip;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string lastPath;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<Record> playedRecords;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private AudioSource source;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool existsSource;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float pitch;

		[Token(Token = "0x4000052")]
		private const int sampleReserve = 256;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Turntable instance;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private AudioCodec <Codec>k__BackingField;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float <BufferProgress>k__BackingField;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool <isAudioPlaying>k__BackingField;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Stream <DataStream>k__BackingField;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public PlaybackStartEvent OnPlaybackStarted;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public PlaybackEndEvent OnPlaybackEnded;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioStartEvent OnAudioStarted;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEndEvent OnAudioEnded;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public ErrorEvent OnError;

		[Token(Token = "0x1700005C")]
		public static Turntable Instance
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x6E19E8", Offset = "0x6E19E8", VA = "0x6E19E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x6ECFD0", Offset = "0x6ECFD0", VA = "0x6ECFD0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public override Record Record
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x6ED028", Offset = "0x6ED028", VA = "0x6ED028", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x6ED030", Offset = "0x6ED030", VA = "0x6ED030", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool PlayOnStart
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x6ED038", Offset = "0x6ED038", VA = "0x6ED038")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x6ED040", Offset = "0x6ED040", VA = "0x6ED040")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public float Delay
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x6ED04C", Offset = "0x6ED04C", VA = "0x6ED04C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x6ED054", Offset = "0x6ED054", VA = "0x6ED054")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public override bool HandleFocus
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x6ED060", Offset = "0x6ED060", VA = "0x6ED060", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x6ED068", Offset = "0x6ED068", VA = "0x6ED068", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public override bool Caching
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x6ED074", Offset = "0x6ED074", VA = "0x6ED074", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x6ED07C", Offset = "0x6ED07C", VA = "0x6ED07C", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public override bool Streaming
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x6ED088", Offset = "0x6ED088", VA = "0x6ED088", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x6ED11C", Offset = "0x6ED11C", VA = "0x6ED11C", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public override int ChunkSize
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x6ED128", Offset = "0x6ED128", VA = "0x6ED128", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x6ED134", Offset = "0x6ED134", VA = "0x6ED134", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool UseAutomaticCacheStreamSize
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x6ED1D8", Offset = "0x6ED1D8", VA = "0x6ED1D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x6ED1E0", Offset = "0x6ED1E0", VA = "0x6ED1E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public override int CacheStreamSize
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x6ED1EC", Offset = "0x6ED1EC", VA = "0x6ED1EC", Slot = "21")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x6ED1F8", Offset = "0x6ED1F8", VA = "0x6ED1F8", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public override bool CaptureDataStream
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x6ED294", Offset = "0x6ED294", VA = "0x6ED294", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x6ED29C", Offset = "0x6ED29C", VA = "0x6ED29C", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public override bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x6ED2A8", Offset = "0x6ED2A8", VA = "0x6ED2A8", Slot = "25")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x6ED334", Offset = "0x6ED334", VA = "0x6ED334", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public override bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x6ED340", Offset = "0x6ED340", VA = "0x6ED340", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x6ED3DC", Offset = "0x6ED3DC", VA = "0x6ED3DC", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool InternalCodecsReadPCM
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x6ED3E8", Offset = "0x6ED3E8", VA = "0x6ED3E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x6ED3F0", Offset = "0x6ED3F0", VA = "0x6ED3F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public override bool isLoop
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x6ED3FC", Offset = "0x6ED3FC", VA = "0x6ED3FC", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x6ED490", Offset = "0x6ED490", VA = "0x6ED490", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public override AudioSource Source
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x6ED534", Offset = "0x6ED534", VA = "0x6ED534", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x6ED53C", Offset = "0x6ED53C", VA = "0x6ED53C", Slot = "30")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public override float Position
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x6ED5BC", Offset = "0x6ED5BC", VA = "0x6ED5BC", Slot = "31")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x6ED748", Offset = "0x6ED748", VA = "0x6ED748", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public override int SamplePosition
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x6ED9DC", Offset = "0x6ED9DC", VA = "0x6ED9DC", Slot = "33")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x6EDB68", Offset = "0x6EDB68", VA = "0x6EDB68", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public override float Elapsed
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x6EDD04", Offset = "0x6EDD04", VA = "0x6EDD04", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x6EDF40", Offset = "0x6EDF40", VA = "0x6EDF40", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public override float Duration
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x6EE17C", Offset = "0x6EE17C", VA = "0x6EE17C", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000070")]
		public override int Samples
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x6EE1A8", Offset = "0x6EE1A8", VA = "0x6EE1A8", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		public override int Channels
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x6EE324", Offset = "0x6EE324", VA = "0x6EE324", Slot = "51")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public override int SampleRate
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x6EE344", Offset = "0x6EE344", VA = "0x6EE344", Slot = "52")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000073")]
		public override AudioCodec Codec
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x6EE364", Offset = "0x6EE364", VA = "0x6EE364", Slot = "39")]
			get
			{
				return default(AudioCodec);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x6EE36C", Offset = "0x6EE36C", VA = "0x6EE36C", Slot = "40")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public override float BufferProgress
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x6EE374", Offset = "0x6EE374", VA = "0x6EE374", Slot = "41")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x6EE37C", Offset = "0x6EE37C", VA = "0x6EE37C", Slot = "42")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public override bool isPlayback
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x6EE384", Offset = "0x6EE384", VA = "0x6EE384", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		public override bool isAudioPlaying
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x6EE38C", Offset = "0x6EE38C", VA = "0x6EE38C", Slot = "45")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x6EE394", Offset = "0x6EE394", VA = "0x6EE394", Slot = "46")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public override bool isBuffering
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x6EE3A0", Offset = "0x6EE3A0", VA = "0x6EE3A0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public override bool isPaused
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x6EE3B0", Offset = "0x6EE3B0", VA = "0x6EE3B0", Slot = "47")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x6EE3B8", Offset = "0x6EE3B8", VA = "0x6EE3B8", Slot = "48")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public override Stream DataStream
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x6EE414", Offset = "0x6EE414", VA = "0x6EE414", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x6EE41C", Offset = "0x6EE41C", VA = "0x6EE41C", Slot = "50")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public override float Volume
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x6EE42C", Offset = "0x6EE42C", VA = "0x6EE42C", Slot = "53")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x6EE468", Offset = "0x6EE468", VA = "0x6EE468", Slot = "54")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public override float Pitch
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x6EE4B4", Offset = "0x6EE4B4", VA = "0x6EE4B4", Slot = "55")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x6EE4F0", Offset = "0x6EE4F0", VA = "0x6EE4F0", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public override float StereoPan
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x6EE53C", Offset = "0x6EE53C", VA = "0x6EE53C", Slot = "57")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x6EE578", Offset = "0x6EE578", VA = "0x6EE578", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override bool isMuted
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x6EE5C4", Offset = "0x6EE5C4", VA = "0x6EE5C4", Slot = "59")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x6EE600", Offset = "0x6EE600", VA = "0x6EE600", Slot = "60")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public override List<Record> PlayedRecords
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x6EE640", Offset = "0x6EE640", VA = "0x6EE640", Slot = "61")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		protected override PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x6EE648", Offset = "0x6EE648", VA = "0x6EE648", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		protected override PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x6EE650", Offset = "0x6EE650", VA = "0x6EE650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		protected override AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x6EE658", Offset = "0x6EE658", VA = "0x6EE658", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		protected override AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x6EE660", Offset = "0x6EE660", VA = "0x6EE660", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		protected override ErrorEvent onError
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x6EE668", Offset = "0x6EE668", VA = "0x6EE668", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000F")]
		public event Cached OnCached
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x6EE670", Offset = "0x6EE670", VA = "0x6EE670")]
			add
			{
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x6EE710", Offset = "0x6EE710", VA = "0x6EE710")]
			remove
			{
			}
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x6EE7B0", Offset = "0x6EE7B0", VA = "0x6EE7B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x6EE978", Offset = "0x6EE978", VA = "0x6EE978")]
		private void Start()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x6EEA0C", Offset = "0x6EEA0C", VA = "0x6EEA0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x6EED14", Offset = "0x6EED14", VA = "0x6EED14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x6EED24", Offset = "0x6EED24", VA = "0x6EED24")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x6EEE28", Offset = "0x6EEE28", VA = "0x6EEE28")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x6EEEFC", Offset = "0x6EEEFC", VA = "0x6EEEFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x6EF140", Offset = "0x6EF140", VA = "0x6EF140")]
		public void Play(Record _record)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x6EF16C", Offset = "0x6EF16C", VA = "0x6EF16C", Slot = "62")]
		public override void Play()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x6EFC3C", Offset = "0x6EFC3C", VA = "0x6EFC3C")]
		public void Cache(Record _record)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x6EFC78", Offset = "0x6EFC78", VA = "0x6EFC78")]
		public void Cache()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x6EFCA4", Offset = "0x6EFCA4", VA = "0x6EFCA4", Slot = "63")]
		public override void Next()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x6EFCB4", Offset = "0x6EFCB4", VA = "0x6EFCB4", Slot = "64")]
		public override void Previous()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x6EFCC4", Offset = "0x6EFCC4", VA = "0x6EFCC4", Slot = "65")]
		public override void Pause()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x6EFCD8", Offset = "0x6EFCD8", VA = "0x6EFCD8", Slot = "66")]
		public override void UnPause()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x6EFCEC", Offset = "0x6EFCEC", VA = "0x6EFCEC", Slot = "67")]
		public override void Stop()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x6EFD58", Offset = "0x6EFD58", VA = "0x6EFD58", Slot = "68")]
		public override void Restart()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x6EFE24", Offset = "0x6EFE24", VA = "0x6EFE24", Slot = "69")]
		public override void Mute()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x6EFE38", Offset = "0x6EFE38", VA = "0x6EFE38", Slot = "70")]
		public override void UnMute()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x6EF174", Offset = "0x6EF174", VA = "0x6EF174")]
		private void playOrCache(bool cache = false)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x6F012C", Offset = "0x6F012C", VA = "0x6F012C")]
		private void logUnsupportedPlatform()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x6F01E8", Offset = "0x6F01E8", VA = "0x6F01E8")]
		private void logDataError(Exception ex)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x6EDD50", Offset = "0x6EDD50", VA = "0x6EDD50")]
		private float elapsedDuration()
		{
			return default(float);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x6F0458", Offset = "0x6F0458", VA = "0x6F0458")]
		private void resetReaderPosition()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x6F05C0", Offset = "0x6F05C0", VA = "0x6F05C0")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x6F0844", Offset = "0x6F0844", VA = "0x6F0844")]
		private void timerTask(ref bool _playback)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x6F098C", Offset = "0x6F098C", VA = "0x6F098C")]
		private void readStream(ref Record _record, ref bool _playback, ref Stream _ms, ref bool _error, ref string _errorMessage, ref bool _buffered)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x6F11BC", Offset = "0x6F11BC", VA = "0x6F11BC")]
		private static AudioType determineAudioType(AudioFormat audioFormat)
		{
			return default(AudioType);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x6F00CC", Offset = "0x6F00CC", VA = "0x6F00CC")]
		private void ctPlay(bool cache)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x6EFE54", Offset = "0x6EFE54", VA = "0x6EFE54")]
		private void ctPlayWithData(byte[] data, bool cache = false)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x6F12AC", Offset = "0x6F12AC", VA = "0x6F12AC")]
		private IEnumerator ctPlayAudio(byte[] data, bool cache)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x6F1370", Offset = "0x6F1370", VA = "0x6F1370")]
		private void waitController(Record _record)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x6F15BC", Offset = "0x6F15BC", VA = "0x6F15BC")]
		private void readPCMNLayer(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x6F17C0", Offset = "0x6F17C0", VA = "0x6F17C0")]
		private void readPCMNAudio(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x6F17D0", Offset = "0x6F17D0", VA = "0x6F17D0")]
		private void readPCMNVorbis(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x6F16EC", Offset = "0x6F16EC", VA = "0x6F16EC")]
		private void writeDataStream(float[] pcmData)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x6F0100", Offset = "0x6F0100", VA = "0x6F0100")]
		private void unityPlay(bool cache)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x6F00D8", Offset = "0x6F00D8", VA = "0x6F00D8")]
		private void unityPlayWithClip(AudioClip clip, bool cache = false)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x6F1900", Offset = "0x6F1900", VA = "0x6F1900")]
		private IEnumerator unityPlayAudio(AudioClip clip, bool cache)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x6EEFE4", Offset = "0x6EEFE4", VA = "0x6EEFE4")]
		protected void killWorker()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x6F19C4", Offset = "0x6F19C4", VA = "0x6F19C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x6F1ED0", Offset = "0x6F1ED0", VA = "0x6F1ED0", Slot = "74")]
		protected override void onPlaybackStart(Record _record)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x6F1F68", Offset = "0x6F1F68", VA = "0x6F1F68", Slot = "75")]
		protected override void onPlaybackEnd(Record _record)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x6F2000", Offset = "0x6F2000", VA = "0x6F2000", Slot = "79")]
		protected override void onAudioStart(Record _record)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x6F20A4", Offset = "0x6F20A4", VA = "0x6F20A4", Slot = "80")]
		protected override void onAudioEnd(Record _record)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x6F2148", Offset = "0x6F2148", VA = "0x6F2148", Slot = "84")]
		protected virtual void onCached(Record _record)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x6F225C", Offset = "0x6F225C", VA = "0x6F225C")]
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
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DEBUG;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int DEFAULT_CHUNKSIZE;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int DEFAULT_CACHESTREAMSIZE;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int MAX_CACHESTREAMSIZE;
	}
	[Token(Token = "0x200002C")]
	public abstract class Constants : BaseConstants
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static AudioCodec DEFAULT_CODEC_MP3_WINDOWS;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float INVOKE_DELAY;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static float PLAY_CALL_SPEED;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string TEXT_BUFFER;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string TEXT_STOPPED;
	}
	[Token(Token = "0x200002D")]
	public static class Context
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int TotalRecordsPlayed;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static double TotalPlayTime;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly List<Record> AllPlayedRecords;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int NumberOfCachedData;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int NumberOfNonCachedData;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int NumberOfCachedClips;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int NumberOfNonCachedClips;
	}
	[Token(Token = "0x200002E")]
	public abstract class Helper : BaseHelper
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] mp3Bitrates;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] oggBitrates;

		[Token(Token = "0x17000088")]
		public static bool isSupportedPlatform
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x6EFE4C", Offset = "0x6EFE4C", VA = "0x6EFE4C")]
			get
			{
				return default(bool);
			}
		}
	}
	[Token(Token = "0x200002F")]
	public class SetupProject
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x6F8940", Offset = "0x6F8940", VA = "0x6F8940")]
		static SetupProject()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x6F8944", Offset = "0x6F8944", VA = "0x6F8944")]
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
			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<double, Record, double> <>9__83_0;

			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Record, long> <>9__85_0;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<double, Record, double> <>9__95_0;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Record, long> <>9__96_0;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<Record, string> <>9__97_0;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<Record, string> <>9__97_1;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<Record, string> <>9__97_2;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<Record, string> <>9__97_3;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<Record, string> <>9__98_0;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Func<Record, string> <>9__98_1;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<Record, string> <>9__98_2;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Func<Record, string> <>9__98_3;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static Func<Record, string> <>9__99_0;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static Func<Record, string> <>9__99_1;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static Func<Record, string> <>9__99_2;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static Func<Record, string> <>9__99_3;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static Func<Record, string> <>9__100_0;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static Func<Record, string> <>9__100_1;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static Func<Record, string> <>9__100_2;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static Func<Record, string> <>9__100_3;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static Func<Record, string> <>9__100_4;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static Func<Record, string> <>9__100_5;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static Func<Record, string> <>9__100_6;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static Func<Record, string> <>9__100_7;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static Func<Record, string> <>9__101_0;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static Func<Record, string> <>9__101_1;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public static Func<Record, string> <>9__101_2;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public static Func<Record, string> <>9__101_3;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public static Func<Record, string> <>9__101_4;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public static Func<Record, string> <>9__101_5;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public static Func<Record, string> <>9__101_6;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public static Func<Record, string> <>9__101_7;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public static Func<Record, string> <>9__102_0;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public static Func<Record, string> <>9__102_1;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public static Func<Record, string> <>9__102_2;

			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			public static Func<Record, string> <>9__102_3;

			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public static Func<Record, string> <>9__102_4;

			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public static Func<Record, string> <>9__102_5;

			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public static Func<Record, string> <>9__102_6;

			[Token(Token = "0x40000FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			public static Func<Record, string> <>9__102_7;

			[Token(Token = "0x40000FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public static Func<Record, float> <>9__103_0;

			[Token(Token = "0x4000100")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			public static Func<Record, string> <>9__103_1;

			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			public static Func<Record, float> <>9__103_2;

			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public static Func<Record, string> <>9__103_3;

			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public static Func<Record, float> <>9__103_4;

			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			public static Func<Record, string> <>9__103_5;

			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			public static Func<Record, float> <>9__103_6;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			public static Func<Record, string> <>9__103_7;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			public static Func<Record, int> <>9__104_0;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			public static Func<Record, string> <>9__104_1;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			public static Func<Record, int> <>9__104_2;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			public static Func<Record, string> <>9__104_3;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			public static Func<Record, int> <>9__104_4;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			public static Func<Record, string> <>9__104_5;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			public static Func<Record, int> <>9__104_6;

			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			public static Func<Record, string> <>9__104_7;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			public static Func<Record, float> <>9__105_0;

			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			public static Func<Record, string> <>9__105_1;

			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			public static Func<Record, float> <>9__105_2;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			public static Func<Record, string> <>9__105_3;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			public static Func<Record, float> <>9__105_4;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			public static Func<Record, string> <>9__105_5;

			[Token(Token = "0x4000115")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			public static Func<Record, float> <>9__105_6;

			[Token(Token = "0x4000116")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			public static Func<Record, string> <>9__105_7;

			[Token(Token = "0x4000117")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			public static Func<Record, long> <>9__106_0;

			[Token(Token = "0x4000118")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			public static Func<Record, string> <>9__106_1;

			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			public static Func<Record, long> <>9__106_2;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			public static Func<Record, string> <>9__106_3;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
			public static Func<Record, long> <>9__106_4;

			[Token(Token = "0x400011C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
			public static Func<Record, string> <>9__106_5;

			[Token(Token = "0x400011D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
			public static Func<Record, long> <>9__106_6;

			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
			public static Func<Record, string> <>9__106_7;

			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
			public static Func<Record, AudioFormat> <>9__107_0;

			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
			public static Func<Record, string> <>9__107_1;

			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
			public static Func<Record, AudioFormat> <>9__107_2;

			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
			public static Func<Record, string> <>9__107_3;

			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
			public static Func<Record, AudioFormat> <>9__107_4;

			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
			public static Func<Record, string> <>9__107_5;

			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
			public static Func<Record, AudioFormat> <>9__107_6;

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
			public static Func<Record, string> <>9__107_7;

			[Token(Token = "0x6000213")]
			[Address(RVA = "0x6FA584", Offset = "0x6FA584", VA = "0x6FA584")]
			public <>c()
			{
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0x6FA58C", Offset = "0x6FA58C", VA = "0x6FA58C")]
			internal double <get_TotalPlaytime>b__83_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0x6FA710", Offset = "0x6FA710", VA = "0x6FA710")]
			internal long <get_TotalSize>b__85_0(Record record)
			{
				return default(long);
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x6FA780", Offset = "0x6FA780", VA = "0x6FA780")]
			internal double <PlaytimeRecords>b__95_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x6FA7B0", Offset = "0x6FA7B0", VA = "0x6FA7B0")]
			internal long <SizeRecords>b__96_0(Record record)
			{
				return default(long);
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x6FA7EC", Offset = "0x6FA7EC", VA = "0x6FA7EC")]
			internal string <RecordsByFilePath>b__97_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x6FA804", Offset = "0x6FA804", VA = "0x6FA804")]
			internal string <RecordsByFilePath>b__97_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x6FA81C", Offset = "0x6FA81C", VA = "0x6FA81C")]
			internal string <RecordsByFilePath>b__97_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x6FA834", Offset = "0x6FA834", VA = "0x6FA834")]
			internal string <RecordsByFilePath>b__97_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x6FA84C", Offset = "0x6FA84C", VA = "0x6FA84C")]
			internal string <RecordsByName>b__98_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x6FAB2C", Offset = "0x6FAB2C", VA = "0x6FAB2C")]
			internal string <RecordsByName>b__98_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x6FAB40", Offset = "0x6FAB40", VA = "0x6FAB40")]
			internal string <RecordsByName>b__98_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x6FAB54", Offset = "0x6FAB54", VA = "0x6FAB54")]
			internal string <RecordsByName>b__98_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x6FAB68", Offset = "0x6FAB68", VA = "0x6FAB68")]
			internal string <RecordsByTitle>b__99_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x6FABB8", Offset = "0x6FABB8", VA = "0x6FABB8")]
			internal string <RecordsByTitle>b__99_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x6FABE4", Offset = "0x6FABE4", VA = "0x6FABE4")]
			internal string <RecordsByTitle>b__99_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x6FAC10", Offset = "0x6FAC10", VA = "0x6FAC10")]
			internal string <RecordsByTitle>b__99_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x6FAC3C", Offset = "0x6FAC3C", VA = "0x6FAC3C")]
			internal string <RecordsByArtist>b__100_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x6FAC8C", Offset = "0x6FAC8C", VA = "0x6FAC8C")]
			internal string <RecordsByArtist>b__100_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x6FACA0", Offset = "0x6FACA0", VA = "0x6FACA0")]
			internal string <RecordsByArtist>b__100_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x6FACCC", Offset = "0x6FACCC", VA = "0x6FACCC")]
			internal string <RecordsByArtist>b__100_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x6FACE0", Offset = "0x6FACE0", VA = "0x6FACE0")]
			internal string <RecordsByArtist>b__100_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x6FAD0C", Offset = "0x6FAD0C", VA = "0x6FAD0C")]
			internal string <RecordsByArtist>b__100_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x6FAD20", Offset = "0x6FAD20", VA = "0x6FAD20")]
			internal string <RecordsByArtist>b__100_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x6FAD4C", Offset = "0x6FAD4C", VA = "0x6FAD4C")]
			internal string <RecordsByArtist>b__100_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x6FAD60", Offset = "0x6FAD60", VA = "0x6FAD60")]
			internal string <RecordsByAlbum>b__101_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x6FADB0", Offset = "0x6FADB0", VA = "0x6FADB0")]
			internal string <RecordsByAlbum>b__101_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x6FADC4", Offset = "0x6FADC4", VA = "0x6FADC4")]
			internal string <RecordsByAlbum>b__101_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x6FADF0", Offset = "0x6FADF0", VA = "0x6FADF0")]
			internal string <RecordsByAlbum>b__101_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x6FAE04", Offset = "0x6FAE04", VA = "0x6FAE04")]
			internal string <RecordsByAlbum>b__101_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x6FAE30", Offset = "0x6FAE30", VA = "0x6FAE30")]
			internal string <RecordsByAlbum>b__101_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x6FAE44", Offset = "0x6FAE44", VA = "0x6FAE44")]
			internal string <RecordsByAlbum>b__101_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000233")]
			[Address(RVA = "0x6FAE70", Offset = "0x6FAE70", VA = "0x6FAE70")]
			internal string <RecordsByAlbum>b__101_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x6FAE84", Offset = "0x6FAE84", VA = "0x6FAE84")]
			internal string <RecordsByGenre>b__102_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x6FAED4", Offset = "0x6FAED4", VA = "0x6FAED4")]
			internal string <RecordsByGenre>b__102_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x6FAEE8", Offset = "0x6FAEE8", VA = "0x6FAEE8")]
			internal string <RecordsByGenre>b__102_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x6FAF14", Offset = "0x6FAF14", VA = "0x6FAF14")]
			internal string <RecordsByGenre>b__102_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x6FAF28", Offset = "0x6FAF28", VA = "0x6FAF28")]
			internal string <RecordsByGenre>b__102_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x6FAF54", Offset = "0x6FAF54", VA = "0x6FAF54")]
			internal string <RecordsByGenre>b__102_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x6FAF68", Offset = "0x6FAF68", VA = "0x6FAF68")]
			internal string <RecordsByGenre>b__102_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x6FAF94", Offset = "0x6FAF94", VA = "0x6FAF94")]
			internal string <RecordsByGenre>b__102_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x6FAFA8", Offset = "0x6FAFA8", VA = "0x6FAFA8")]
			internal float <RecordsByRating>b__103_0(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x6FAFC0", Offset = "0x6FAFC0", VA = "0x6FAFC0")]
			internal string <RecordsByRating>b__103_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x6FAFD4", Offset = "0x6FAFD4", VA = "0x6FAFD4")]
			internal float <RecordsByRating>b__103_2(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x6FAFEC", Offset = "0x6FAFEC", VA = "0x6FAFEC")]
			internal string <RecordsByRating>b__103_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x6FB000", Offset = "0x6FB000", VA = "0x6FB000")]
			internal float <RecordsByRating>b__103_4(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x6FB018", Offset = "0x6FB018", VA = "0x6FB018")]
			internal string <RecordsByRating>b__103_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x6FB02C", Offset = "0x6FB02C", VA = "0x6FB02C")]
			internal float <RecordsByRating>b__103_6(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x6FB044", Offset = "0x6FB044", VA = "0x6FB044")]
			internal string <RecordsByRating>b__103_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x6FB058", Offset = "0x6FB058", VA = "0x6FB058")]
			internal int <RecordsByYear>b__104_0(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x6FB0B0", Offset = "0x6FB0B0", VA = "0x6FB0B0")]
			internal string <RecordsByYear>b__104_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000246")]
			[Address(RVA = "0x6FB0C4", Offset = "0x6FB0C4", VA = "0x6FB0C4")]
			internal int <RecordsByYear>b__104_2(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x6FB0F4", Offset = "0x6FB0F4", VA = "0x6FB0F4")]
			internal string <RecordsByYear>b__104_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000248")]
			[Address(RVA = "0x6FB108", Offset = "0x6FB108", VA = "0x6FB108")]
			internal int <RecordsByYear>b__104_4(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0x6FB138", Offset = "0x6FB138", VA = "0x6FB138")]
			internal string <RecordsByYear>b__104_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024A")]
			[Address(RVA = "0x6FB14C", Offset = "0x6FB14C", VA = "0x6FB14C")]
			internal int <RecordsByYear>b__104_6(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0x6FB17C", Offset = "0x6FB17C", VA = "0x6FB17C")]
			internal string <RecordsByYear>b__104_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0x6FB190", Offset = "0x6FB190", VA = "0x6FB190")]
			internal float <RecordsByDuration>b__105_0(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x6FB1A4", Offset = "0x6FB1A4", VA = "0x6FB1A4")]
			internal string <RecordsByDuration>b__105_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x6FB1B8", Offset = "0x6FB1B8", VA = "0x6FB1B8")]
			internal float <RecordsByDuration>b__105_2(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x6FB1CC", Offset = "0x6FB1CC", VA = "0x6FB1CC")]
			internal string <RecordsByDuration>b__105_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x6FB1E0", Offset = "0x6FB1E0", VA = "0x6FB1E0")]
			internal float <RecordsByDuration>b__105_4(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x6FB1F4", Offset = "0x6FB1F4", VA = "0x6FB1F4")]
			internal string <RecordsByDuration>b__105_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x6FB208", Offset = "0x6FB208", VA = "0x6FB208")]
			internal float <RecordsByDuration>b__105_6(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x6FB21C", Offset = "0x6FB21C", VA = "0x6FB21C")]
			internal string <RecordsByDuration>b__105_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x6FB230", Offset = "0x6FB230", VA = "0x6FB230")]
			internal long <RecordsByFileSize>b__106_0(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x6FB26C", Offset = "0x6FB26C", VA = "0x6FB26C")]
			internal string <RecordsByFileSize>b__106_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x6FB280", Offset = "0x6FB280", VA = "0x6FB280")]
			internal long <RecordsByFileSize>b__106_2(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x6FB2BC", Offset = "0x6FB2BC", VA = "0x6FB2BC")]
			internal string <RecordsByFileSize>b__106_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x6FB2D0", Offset = "0x6FB2D0", VA = "0x6FB2D0")]
			internal long <RecordsByFileSize>b__106_4(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x6FB30C", Offset = "0x6FB30C", VA = "0x6FB30C")]
			internal string <RecordsByFileSize>b__106_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x6FB320", Offset = "0x6FB320", VA = "0x6FB320")]
			internal long <RecordsByFileSize>b__106_6(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x6FB35C", Offset = "0x6FB35C", VA = "0x6FB35C")]
			internal string <RecordsByFileSize>b__106_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x6FB370", Offset = "0x6FB370", VA = "0x6FB370")]
			internal AudioFormat <RecordsByFormat>b__107_0(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x6FB730", Offset = "0x6FB730", VA = "0x6FB730")]
			internal string <RecordsByFormat>b__107_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x6FB744", Offset = "0x6FB744", VA = "0x6FB744")]
			internal AudioFormat <RecordsByFormat>b__107_2(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x6FB758", Offset = "0x6FB758", VA = "0x6FB758")]
			internal string <RecordsByFormat>b__107_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x6FB76C", Offset = "0x6FB76C", VA = "0x6FB76C")]
			internal AudioFormat <RecordsByFormat>b__107_4(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x6FB780", Offset = "0x6FB780", VA = "0x6FB780")]
			internal string <RecordsByFormat>b__107_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x6FB794", Offset = "0x6FB794", VA = "0x6FB794")]
			internal AudioFormat <RecordsByFormat>b__107_6(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x6FB7A8", Offset = "0x6FB7A8", VA = "0x6FB7A8")]
			internal string <RecordsByFormat>b__107_7(Record entry)
			{
				return null;
			}
		}

		[Token(Token = "0x2000032")]
		private sealed class <>c__DisplayClass114_0
		{
			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int hashCode;

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x6FB7BC", Offset = "0x6FB7BC", VA = "0x6FB7BC")]
			public <>c__DisplayClass114_0()
			{
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x6FB7C4", Offset = "0x6FB7C4", VA = "0x6FB7C4")]
			internal bool <recordFromHashCode>b__0(Record record)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000033")]
		private sealed class <>c__DisplayClass118_0
		{
			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RecordFilter _filter;

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x6FB7FC", Offset = "0x6FB7FC", VA = "0x6FB7FC")]
			public <>c__DisplayClass118_0()
			{
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x6FB804", Offset = "0x6FB804", VA = "0x6FB804")]
			internal bool <filterRecords>b__0(Record entry)
			{
				return default(bool);
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x6FBD28", Offset = "0x6FBD28", VA = "0x6FBD28")]
			internal bool <filterRecords>b__1(Record entry)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("Filter")]
		private RecordFilter filter;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int recordIndex;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int randomRecordIndex;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<Record> randomRecords;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<Record> allRecords;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool cleared;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool clearedRandom;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RecordFilter lastRecordFilter;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RecordFilter lastRandomRecordFilter;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Record> lastFilteredRecords;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Record> lastFilteredRandomRecords;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RecordFilter recordsByFilePathFilterDesc;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RecordFilter recordsByFilePathFilterAsc;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<Record> recordsByFilePathDesc;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Record> recordsByFilePathAsc;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RecordFilter recordsByNameFilterDesc;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RecordFilter recordsByNameFilterAsc;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<Record> recordsByNameDesc;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<Record> recordsByNameAsc;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RecordFilter recordsByTitleFilterDesc;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RecordFilter recordsByTitleFilterAsc;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<Record> recordsByTitleDesc;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<Record> recordsByTitleAsc;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RecordFilter recordsByArtistFilterDesc;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RecordFilter recordsByArtistFilterAsc;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<Record> recordsByArtistDesc;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<Record> recordsByArtistAsc;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RecordFilter recordsByAlbumFilterDesc;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RecordFilter recordsByAlbumFilterAsc;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<Record> recordsByAlbumDesc;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<Record> recordsByAlbumAsc;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RecordFilter recordsByGenreFilterDesc;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RecordFilter recordsByGenreFilterAsc;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<Record> recordsByGenreDesc;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<Record> recordsByGenreAsc;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RecordFilter recordsByRatingFilterDesc;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private RecordFilter recordsByRatingFilterAsc;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<Record> recordsByRatingDesc;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<Record> recordsByRatingAsc;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private RecordFilter recordsByYearFilterDesc;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private RecordFilter recordsByYearFilterAsc;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private List<Record> recordsByYearDesc;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private List<Record> recordsByYearAsc;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RecordFilter recordsByDurationFilterDesc;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private RecordFilter recordsByDurationFilterAsc;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private List<Record> recordsByDurationDesc;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<Record> recordsByDurationAsc;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private RecordFilter recordsByFileSizeFilterDesc;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private RecordFilter recordsByFileSizeFilterAsc;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<Record> recordsByFileSizeDesc;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private List<Record> recordsByFileSizeAsc;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private RecordFilter recordsByFormatFilterDesc;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private RecordFilter recordsByFormatFilterAsc;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private List<Record> recordsByFormatDesc;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private List<Record> recordsByFormatAsc;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private RecordFilter currentFilter;

		[Token(Token = "0x17000089")]
		public RecordFilter Filter
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x6F89C0", Offset = "0x6F89C0", VA = "0x6F89C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x6F89C8", Offset = "0x6F89C8", VA = "0x6F89C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		protected abstract RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60001DD")]
			get;
		}

		[Token(Token = "0x1700008B")]
		protected abstract FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x60001DE")]
			get;
		}

		[Token(Token = "0x1700008C")]
		protected abstract ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60001DF")]
			get;
		}

		[Token(Token = "0x1700008D")]
		public abstract List<Record> Records
		{
			[Token(Token = "0x60001E8")]
			get;
		}

		[Token(Token = "0x1700008E")]
		public abstract List<Record> RandomRecords
		{
			[Token(Token = "0x60001E9")]
			get;
		}

		[Token(Token = "0x1700008F")]
		public abstract bool isReady
		{
			[Token(Token = "0x60001EA")]
			get;
		}

		[Token(Token = "0x17000090")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x6E3EE0", Offset = "0x6E3EE0", VA = "0x6E3EE0", Slot = "10")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000091")]
		public long TotalSize
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x6E4084", Offset = "0x6E4084", VA = "0x6E4084", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000092")]
		public int CurrentRecordIndex
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x6F8BC4", Offset = "0x6F8BC4", VA = "0x6F8BC4", Slot = "12")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x6E42B4", Offset = "0x6E42B4", VA = "0x6E42B4", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public int CurrentRandomRecordIndex
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x6F8BCC", Offset = "0x6F8BCC", VA = "0x6F8BCC", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x6E4438", Offset = "0x6E4438", VA = "0x6E4438", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event FilterChange OnFilterChange
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x6E2888", Offset = "0x6E2888", VA = "0x6E2888")]
			add
			{
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x6E2FB4", Offset = "0x6E2FB4", VA = "0x6E2FB4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x6E2928", Offset = "0x6E2928", VA = "0x6E2928")]
			add
			{
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x6E3054", Offset = "0x6E3054", VA = "0x6E3054")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x6E29C8", Offset = "0x6E29C8", VA = "0x6E29C8")]
			add
			{
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x6E30F4", Offset = "0x6E30F4", VA = "0x6E30F4")]
			remove
			{
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x6F8A6C", Offset = "0x6F8A6C", VA = "0x6F8A6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x6F8AEC", Offset = "0x6F8AEC", VA = "0x6F8AEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F1")]
		public abstract void Load();

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x6E47BC", Offset = "0x6E47BC", VA = "0x6E47BC", Slot = "17")]
		public List<Record> GetRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x6E48D4", Offset = "0x6E48D4", VA = "0x6E48D4", Slot = "18")]
		public int CountRecords([Optional] RecordFilter _filter)
		{
			return default(int);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x6E49E8", Offset = "0x6E49E8", VA = "0x6E49E8", Slot = "19")]
		public double PlaytimeRecords([Optional] RecordFilter _filter)
		{
			return default(double);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x6E4BC0", Offset = "0x6E4BC0", VA = "0x6E4BC0", Slot = "20")]
		public long SizeRecords([Optional] RecordFilter _filter)
		{
			return default(long);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x6E4F48", Offset = "0x6E4F48", VA = "0x6E4F48", Slot = "21")]
		public List<Record> RecordsByFilePath(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x6E5808", Offset = "0x6E5808", VA = "0x6E5808", Slot = "22")]
		public List<Record> RecordsByName(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x6E60AC", Offset = "0x6E60AC", VA = "0x6E60AC", Slot = "23")]
		public List<Record> RecordsByTitle(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x6E6950", Offset = "0x6E6950", VA = "0x6E6950", Slot = "24")]
		public List<Record> RecordsByArtist(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x6E74A8", Offset = "0x6E74A8", VA = "0x6E74A8", Slot = "25")]
		public List<Record> RecordsByAlbum(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x6E8004", Offset = "0x6E8004", VA = "0x6E8004", Slot = "26")]
		public List<Record> RecordsByGenre(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x6E8B68", Offset = "0x6E8B68", VA = "0x6E8B68", Slot = "27")]
		public List<Record> RecordsByRating(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x6E96F8", Offset = "0x6E96F8", VA = "0x6E96F8", Slot = "28")]
		public List<Record> RecordsByYear(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x6EA288", Offset = "0x6EA288", VA = "0x6EA288", Slot = "29")]
		public List<Record> RecordsByDuration(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x6EAE18", Offset = "0x6EAE18", VA = "0x6EAE18", Slot = "30")]
		public List<Record> RecordsByFileSize(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x6EB9A8", Offset = "0x6EB9A8", VA = "0x6EB9A8", Slot = "31")]
		public List<Record> RecordsByFormat(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x6E38F0", Offset = "0x6E38F0", VA = "0x6E38F0", Slot = "32")]
		public Record RecordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x6E4E54", Offset = "0x6E4E54", VA = "0x6E4E54", Slot = "33")]
		public Record RecordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x6E4534", Offset = "0x6E4534", VA = "0x6E4534", Slot = "34")]
		public Record Next(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x6E4564", Offset = "0x6E4564", VA = "0x6E4564", Slot = "35")]
		public Record Previous(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x6E4628", Offset = "0x6E4628", VA = "0x6E4628", Slot = "36")]
		public void RandomizeRecords(bool resetIndex = true)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x6F91F8", Offset = "0x6F91F8", VA = "0x6F91F8")]
		private Record recordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x6F9318", Offset = "0x6F9318", VA = "0x6F9318")]
		private Record recordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x6F9444", Offset = "0x6F9444", VA = "0x6F9444")]
		private Record next(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x6F9578", Offset = "0x6F9578", VA = "0x6F9578")]
		private Record previous(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x6F8BD4", Offset = "0x6F8BD4", VA = "0x6F8BD4")]
		private RecordFilter getFilter(RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x6F8C28", Offset = "0x6F8C28", VA = "0x6F8C28")]
		private IEnumerable<Record> filterRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x6F969C", Offset = "0x6F969C", VA = "0x6F969C")]
		protected void clearFilters(bool clearLastFilter = true, bool clearLastRandomFilter = true)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x6F9864", Offset = "0x6F9864", VA = "0x6F9864")]
		protected void resetFilterLists()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x6F9C70", Offset = "0x6F9C70", VA = "0x6F9C70", Slot = "37")]
		protected virtual void onFilterChange()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x6F9DEC", Offset = "0x6F9DEC", VA = "0x6F9DEC", Slot = "38")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x6F9F80", Offset = "0x6F9F80", VA = "0x6F9F80", Slot = "39")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x6FA0D8", Offset = "0x6FA0D8", VA = "0x6FA0D8")]
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
			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Record> result;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Record, bool> <>9__3;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<BaseSet, IEnumerable<Record>> <>9__2;

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x6FD178", Offset = "0x6FD178", VA = "0x6FD178")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600027A")]
			[Address(RVA = "0x6FDF4C", Offset = "0x6FDF4C", VA = "0x6FDF4C")]
			internal IEnumerable<Record> <get_Records>b__2(BaseSet rs)
			{
				return null;
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x6FE024", Offset = "0x6FE024", VA = "0x6FE024")]
			internal bool <get_Records>b__3(Record record)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		private sealed class <>c
		{
			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<BaseSet, bool> <>9__14_1;

			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Record, string> <>9__14_0;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<BaseSet, bool> <>9__16_1;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Record, string> <>9__16_0;

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<BaseSet, bool> <>9__18_0;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<BaseSet, bool> <>9__21_0;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<BaseSet, bool> <>9__23_0;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<BaseSet, bool> <>9__24_0;

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x6FE0F8", Offset = "0x6FE0F8", VA = "0x6FE0F8")]
			public <>c()
			{
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x6FE100", Offset = "0x6FE100", VA = "0x6FE100")]
			internal bool <get_Records>b__14_1(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x6FE15C", Offset = "0x6FE15C", VA = "0x6FE15C")]
			internal string <get_Records>b__14_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x6FE174", Offset = "0x6FE174", VA = "0x6FE174")]
			internal bool <get_RandomRecords>b__16_1(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x6FE1D0", Offset = "0x6FE1D0", VA = "0x6FE1D0")]
			internal string <get_RandomRecords>b__16_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x6FE1E8", Offset = "0x6FE1E8", VA = "0x6FE1E8")]
			internal bool <get_isReady>b__18_0(BaseSet provider)
			{
				return default(bool);
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x6FE270", Offset = "0x6FE270", VA = "0x6FE270")]
			internal bool <Load>b__21_0(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x6FE2F4", Offset = "0x6FE2F4", VA = "0x6FE2F4")]
			internal bool <register>b__23_0(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x6FE350", Offset = "0x6FE350", VA = "0x6FE350")]
			internal bool <unregister>b__24_0(BaseSet rs)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000037")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Record> result;

			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Record, bool> <>9__3;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<BaseSet, IEnumerable<Record>> <>9__2;

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x6FD824", Offset = "0x6FD824", VA = "0x6FD824")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x6FE3AC", Offset = "0x6FE3AC", VA = "0x6FE3AC")]
			internal IEnumerable<Record> <get_RandomRecords>b__2(BaseSet rs)
			{
				return null;
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x6FE484", Offset = "0x6FE484", VA = "0x6FE484")]
			internal bool <get_RandomRecords>b__3(Record record)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[FormerlySerializedAs("Sets")]
		[SerializeField]
		public BaseSet[] sets;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public FilterChangeEvent OnFilterChanged;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x17000094")]
		public BaseSet[] Sets
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x6FC0F0", Offset = "0x6FC0F0", VA = "0x6FC0F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x6FC0F8", Offset = "0x6FC0F8", VA = "0x6FC0F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x6FCABC", Offset = "0x6FCABC", VA = "0x6FCABC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		protected override FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x6FCAC4", Offset = "0x6FCAC4", VA = "0x6FCAC4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x6FCACC", Offset = "0x6FCACC", VA = "0x6FCACC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public override List<Record> Records
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x6FCAD4", Offset = "0x6FCAD4", VA = "0x6FCAD4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public override List<Record> RandomRecords
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x6FD180", Offset = "0x6FD180", VA = "0x6FD180", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public override bool isReady
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x6FD82C", Offset = "0x6FD82C", VA = "0x6FD82C", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x6FD948", Offset = "0x6FD948", VA = "0x6FD948")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x6FD94C", Offset = "0x6FD94C", VA = "0x6FD94C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x6FD950", Offset = "0x6FD950", VA = "0x6FD950", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x6FDD04", Offset = "0x6FDD04", VA = "0x6FDD04", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x6FC5F4", Offset = "0x6FC5F4", VA = "0x6FC5F4")]
		private void register()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x6FC12C", Offset = "0x6FC12C", VA = "0x6FC12C")]
		private void unregister()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x6FDF1C", Offset = "0x6FDF1C", VA = "0x6FDF1C", Slot = "37")]
		protected override void onFilterChange()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x6FDF44", Offset = "0x6FDF44", VA = "0x6FDF44")]
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
			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Record> result;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Record, bool> <>9__3;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<BaseRecordProvider, IEnumerable<Record>> <>9__2;

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x6FF4B0", Offset = "0x6FF4B0", VA = "0x6FF4B0")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x700580", Offset = "0x700580", VA = "0x700580")]
			internal IEnumerable<Record> <get_Records>b__2(BaseRecordProvider rp)
			{
				return null;
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x700648", Offset = "0x700648", VA = "0x700648")]
			internal bool <get_Records>b__3(Record record)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200003A")]
		private sealed class <>c
		{
			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<BaseRecordProvider, bool> <>9__14_1;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Record, string> <>9__14_0;

			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<BaseRecordProvider, bool> <>9__16_1;

			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<Record, string> <>9__16_0;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<BaseRecordProvider, bool> <>9__18_0;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<BaseRecordProvider, bool> <>9__21_0;

			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<BaseRecordProvider, bool> <>9__23_0;

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<BaseRecordProvider, bool> <>9__24_0;

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x70071C", Offset = "0x70071C", VA = "0x70071C")]
			public <>c()
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x700724", Offset = "0x700724", VA = "0x700724")]
			internal bool <get_Records>b__14_1(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x7007A4", Offset = "0x7007A4", VA = "0x7007A4")]
			internal string <get_Records>b__14_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x7007BC", Offset = "0x7007BC", VA = "0x7007BC")]
			internal bool <get_RandomRecords>b__16_1(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x70083C", Offset = "0x70083C", VA = "0x70083C")]
			internal string <get_RandomRecords>b__16_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x700854", Offset = "0x700854", VA = "0x700854")]
			internal bool <get_isReady>b__18_0(BaseRecordProvider provider)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x7008D4", Offset = "0x7008D4", VA = "0x7008D4")]
			internal bool <Load>b__21_0(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x700958", Offset = "0x700958", VA = "0x700958")]
			internal bool <register>b__23_0(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x7009B4", Offset = "0x7009B4", VA = "0x7009B4")]
			internal bool <unregister>b__24_0(BaseRecordProvider rp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200003B")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Record> result;

			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<Record, bool> <>9__3;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<BaseRecordProvider, IEnumerable<Record>> <>9__2;

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x6FFB5C", Offset = "0x6FFB5C", VA = "0x6FFB5C")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x700A10", Offset = "0x700A10", VA = "0x700A10")]
			internal IEnumerable<Record> <get_RandomRecords>b__2(BaseRecordProvider rp)
			{
				return null;
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x700AD8", Offset = "0x700AD8", VA = "0x700AD8")]
			internal bool <get_RandomRecords>b__3(Record record)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[FormerlySerializedAs("RecordProviders")]
		[SerializeField]
		private BaseRecordProvider[] recordProviders;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public FilterChangeEvent OnFilterChanged;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x1700009B")]
		public BaseRecordProvider[] RecordProviders
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x6FE4E8", Offset = "0x6FE4E8", VA = "0x6FE4E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x6FE4F0", Offset = "0x6FE4F0", VA = "0x6FE4F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x6FEDF4", Offset = "0x6FEDF4", VA = "0x6FEDF4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		protected override FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x6FEDFC", Offset = "0x6FEDFC", VA = "0x6FEDFC", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x6FEE04", Offset = "0x6FEE04", VA = "0x6FEE04", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public override List<Record> Records
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x6FEE0C", Offset = "0x6FEE0C", VA = "0x6FEE0C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public override List<Record> RandomRecords
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x6FF4B8", Offset = "0x6FF4B8", VA = "0x6FF4B8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public override bool isReady
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x6FFB64", Offset = "0x6FFB64", VA = "0x6FFB64", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x6FFC80", Offset = "0x6FFC80", VA = "0x6FFC80")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x6FFC84", Offset = "0x6FFC84", VA = "0x6FFC84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x6FFC88", Offset = "0x6FFC88", VA = "0x6FFC88", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x700040", Offset = "0x700040", VA = "0x700040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x6FE98C", Offset = "0x6FE98C", VA = "0x6FE98C")]
		private void register()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x6FE524", Offset = "0x6FE524", VA = "0x6FE524")]
		private void unregister()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x7004C8", Offset = "0x7004C8", VA = "0x7004C8", Slot = "37")]
		protected override void onFilterChange()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x700578", Offset = "0x700578", VA = "0x700578")]
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
			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<double, Record, double> <>9__48_0;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Record, long> <>9__50_0;

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x701D34", Offset = "0x701D34", VA = "0x701D34")]
			public <>c()
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x701D3C", Offset = "0x701D3C", VA = "0x701D3C")]
			internal double <get_TotalPlaytime>b__48_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x701D6C", Offset = "0x701D6C", VA = "0x701D6C")]
			internal long <get_TotalSize>b__50_0(Record record)
			{
				return default(long);
			}
		}

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("LoadTag")]
		[SerializeField]
		private bool loadTag;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[FormerlySerializedAs("ReadFileSize")]
		[SerializeField]
		private bool readFileSize;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		[FormerlySerializedAs("AutoUpdate")]
		private bool autoUpdate;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[FormerlySerializedAs("AutoUpdateInEditor")]
		[SerializeField]
		private bool autoUpdateInEditor;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected List<Record> records;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected bool loading;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected string errorMessage;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool <isReady>k__BackingField;

		[Token(Token = "0x170000A2")]
		public bool LoadTag
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x700B3C", Offset = "0x700B3C", VA = "0x700B3C", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x700B44", Offset = "0x700B44", VA = "0x700B44", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool ReadFileSize
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x700B50", Offset = "0x700B50", VA = "0x700B50", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x700B58", Offset = "0x700B58", VA = "0x700B58", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool AutoUpdate
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x700B64", Offset = "0x700B64", VA = "0x700B64", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x700B6C", Offset = "0x700B6C", VA = "0x700B6C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool AutoUpdateInEditor
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x700B78", Offset = "0x700B78", VA = "0x700B78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x700B80", Offset = "0x700B80", VA = "0x700B80")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		protected abstract RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002B1")]
			get;
		}

		[Token(Token = "0x170000A7")]
		protected abstract ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002B2")]
			get;
		}

		[Token(Token = "0x170000A8")]
		public bool isLoadTag
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x700C9C", Offset = "0x700C9C", VA = "0x700C9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x700CA4", Offset = "0x700CA4", VA = "0x700CA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool isReadFileSize
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x700CB0", Offset = "0x700CB0", VA = "0x700CB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x700CB8", Offset = "0x700CB8", VA = "0x700CB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public bool isAutoUpdate
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x700CC4", Offset = "0x700CC4", VA = "0x700CC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x700CCC", Offset = "0x700CCC", VA = "0x700CCC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool isReady
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x700CD8", Offset = "0x700CD8", VA = "0x700CD8", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x700CE0", Offset = "0x700CE0", VA = "0x700CE0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public List<Record> Records
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x700CEC", Offset = "0x700CEC", VA = "0x700CEC", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x700CF4", Offset = "0x700CF4", VA = "0x700CF4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x700CFC", Offset = "0x700CFC", VA = "0x700CFC", Slot = "17")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000AE")]
		public long TotalSize
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x700E04", Offset = "0x700E04", VA = "0x700E04", Slot = "18")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x14000013")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x700258", Offset = "0x700258", VA = "0x700258")]
			add
			{
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x700390", Offset = "0x700390", VA = "0x700390")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x7002F4", Offset = "0x7002F4", VA = "0x7002F4")]
			add
			{
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x70042C", Offset = "0x70042C", VA = "0x70042C")]
			remove
			{
			}
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x700B8C", Offset = "0x700B8C", VA = "0x700B8C", Slot = "12")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x700BF4", Offset = "0x700BF4", VA = "0x700BF4", Slot = "13")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x700F08", Offset = "0x700F08", VA = "0x700F08", Slot = "19")]
		public virtual void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x60002C6")]
		protected abstract void load();

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x700FF0", Offset = "0x700FF0", VA = "0x700FF0")]
		protected static string determineAudioFormatExtension(AudioFormat audioFormat = AudioFormat.MP3)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x701164", Offset = "0x701164", VA = "0x701164")]
		protected void fillRecords(string[] list)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x7016F8", Offset = "0x7016F8", VA = "0x7016F8", Slot = "21")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x701818", Offset = "0x701818", VA = "0x701818", Slot = "22")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x701970", Offset = "0x701970", VA = "0x701970")]
		protected BaseRecordProvider()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x701A00", Offset = "0x701A00", VA = "0x701A00")]
		private Record <fillRecords>b__54_0(string entry)
		{
			return null;
		}
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	public abstract class BaseRecordProviderDB : BaseRecordProvider
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[FormerlySerializedAs("UseDatabase")]
		[SerializeField]
		private bool useDatabase;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string uid;

		[Token(Token = "0x170000AF")]
		public bool UseDatabase
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x701DA8", Offset = "0x701DA8", VA = "0x701DA8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x701DB0", Offset = "0x701DB0", VA = "0x701DB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool hasDBFile
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x701E54", Offset = "0x701E54", VA = "0x701E54", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public string DBFilePath
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x701E68", Offset = "0x701E68", VA = "0x701E68", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x701DBC", Offset = "0x701DBC", VA = "0x701DBC", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x701EDC", Offset = "0x701EDC", VA = "0x701EDC", Slot = "19")]
		public override void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x702030", Offset = "0x702030", VA = "0x702030", Slot = "26")]
		public virtual void SaveDB(string filePath = "")
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x7020A8", Offset = "0x7020A8", VA = "0x7020A8", Slot = "27")]
		public virtual void LoadDB(string filePath = "")
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x702150", Offset = "0x702150", VA = "0x702150", Slot = "28")]
		public void DeleteDB()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x702014", Offset = "0x702014", VA = "0x702014")]
		private void loadFile()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x7020B8", Offset = "0x7020B8", VA = "0x7020B8")]
		private void loadFile(string filePath)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x702294", Offset = "0x702294", VA = "0x702294")]
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
			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<AudioClip, bool> <>9__10_0;

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x7029A4", Offset = "0x7029A4", VA = "0x7029A4")]
			public <>c()
			{
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x7029AC", Offset = "0x7029AC", VA = "0x7029AC")]
			internal bool <load>b__10_0(AudioClip clip)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("Clips")]
		[SerializeField]
		private List<AudioClip> clips;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x170000B2")]
		public List<AudioClip> Clips
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x7022A0", Offset = "0x7022A0", VA = "0x7022A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x7022A8", Offset = "0x7022A8", VA = "0x7022A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x702374", Offset = "0x702374", VA = "0x702374", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x70237C", Offset = "0x70237C", VA = "0x70237C", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x702384", Offset = "0x702384", VA = "0x702384", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x7028B0", Offset = "0x7028B0", VA = "0x7028B0")]
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
			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> <>9__10_0;

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x7030B0", Offset = "0x7030B0", VA = "0x7030B0")]
			public <>c()
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x7030B8", Offset = "0x7030B8", VA = "0x7030B8")]
			internal bool <load>b__10_0(string url)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("Files")]
		private List<string> files;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x170000B5")]
		public List<string> Files
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x702A08", Offset = "0x702A08", VA = "0x702A08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x702A10", Offset = "0x702A10", VA = "0x702A10")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x702ADC", Offset = "0x702ADC", VA = "0x702ADC", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x702AE4", Offset = "0x702AE4", VA = "0x702AE4", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x702AEC", Offset = "0x702AEC", VA = "0x702AEC", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x702FBC", Offset = "0x702FBC", VA = "0x702FBC")]
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
			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPath <>4__this;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000312")]
				[Address(RVA = "0x704C70", Offset = "0x704C70", VA = "0x704C70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000314")]
				[Address(RVA = "0x704CB8", Offset = "0x704CB8", VA = "0x704CB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x703CDC", Offset = "0x703CDC", VA = "0x703CDC")]
			[DebuggerHidden]
			public <scan>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x704A70", Offset = "0x704A70", VA = "0x704A70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x704A74", Offset = "0x704A74", VA = "0x704A74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x704C78", Offset = "0x704C78", VA = "0x704C78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000045")]
		private sealed class <scanWindows>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPath <>4__this;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Process <>7__wrap1;

			[Token(Token = "0x170000C3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000319")]
				[Address(RVA = "0x70552C", Offset = "0x70552C", VA = "0x70552C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0x705574", Offset = "0x705574", VA = "0x705574", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x703D04", Offset = "0x703D04", VA = "0x703D04")]
			[DebuggerHidden]
			public <scanWindows>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x704CC0", Offset = "0x704CC0", VA = "0x704CC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x704CDC", Offset = "0x704CDC", VA = "0x704CDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x70547C", Offset = "0x70547C", VA = "0x70547C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x705534", Offset = "0x705534", VA = "0x705534", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000046")]
		private sealed class <scanUnix>d__44 : IEnumerator<object>, IEnumerator, IDisposable
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

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Process <>7__wrap1;

			[Token(Token = "0x170000C5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000320")]
				[Address(RVA = "0x7061DC", Offset = "0x7061DC", VA = "0x7061DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000322")]
				[Address(RVA = "0x706224", Offset = "0x706224", VA = "0x706224", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x703D2C", Offset = "0x703D2C", VA = "0x703D2C")]
			[DebuggerHidden]
			public <scanUnix>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x70557C", Offset = "0x70557C", VA = "0x70557C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x705598", Offset = "0x705598", VA = "0x705598", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x70612C", Offset = "0x70612C", VA = "0x70612C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x7061E4", Offset = "0x7061E4", VA = "0x7061E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("UseMusicLibrary")]
		[SerializeField]
		private bool useMusicLibrary;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("Path")]
		[SerializeField]
		private string path;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("Format")]
		[SerializeField]
		private AudioFormat format;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[FormerlySerializedAs("Recursive")]
		[SerializeField]
		private bool recursive;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[FormerlySerializedAs("SlowAndSave")]
		[SerializeField]
		private bool slowAndSave;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		[SerializeField]
		[FormerlySerializedAs("WatchDog")]
		private bool watchDog;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private FileSystemWatcher watcher;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Process scanProcess;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Thread worker;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string KEY_PATH;

		[Token(Token = "0x170000B8")]
		public bool UseMusicLibrary
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x7030D8", Offset = "0x7030D8", VA = "0x7030D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x7030E0", Offset = "0x7030E0", VA = "0x7030E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public string Path
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x7030EC", Offset = "0x7030EC", VA = "0x7030EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x7030F4", Offset = "0x7030F4", VA = "0x7030F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public AudioFormat Format
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x703200", Offset = "0x703200", VA = "0x703200")]
			get
			{
				return default(AudioFormat);
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x703208", Offset = "0x703208", VA = "0x703208")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public bool Recursive
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x7032E0", Offset = "0x7032E0", VA = "0x7032E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x7032E8", Offset = "0x7032E8", VA = "0x7032E8")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public bool SlowAndSave
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x7032F4", Offset = "0x7032F4", VA = "0x7032F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x7032FC", Offset = "0x7032FC", VA = "0x7032FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public bool WatchDog
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x703308", Offset = "0x703308", VA = "0x703308")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x703310", Offset = "0x703310", VA = "0x703310")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x70331C", Offset = "0x70331C", VA = "0x70331C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x703324", Offset = "0x703324", VA = "0x703324", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public string Extension
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x70332C", Offset = "0x70332C", VA = "0x70332C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x703334", Offset = "0x703334", VA = "0x703334", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x703620", Offset = "0x703620", VA = "0x703620", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x70379C", Offset = "0x70379C", VA = "0x70379C")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x703838", Offset = "0x703838", VA = "0x703838", Slot = "19")]
		public override void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x7038FC", Offset = "0x7038FC", VA = "0x7038FC", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x703444", Offset = "0x703444", VA = "0x703444")]
		private void setMusicLibrary()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x703C68", Offset = "0x703C68", VA = "0x703C68")]
		private IEnumerator scan()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x703B80", Offset = "0x703B80", VA = "0x703B80")]
		private IEnumerator scanWindows()
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x703BF4", Offset = "0x703BF4", VA = "0x703BF4")]
		private IEnumerator scanUnix()
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x703D54", Offset = "0x703D54", VA = "0x703D54")]
		private void watch()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x703FAC", Offset = "0x703FAC", VA = "0x703FAC")]
		private void onDeleted(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x7040F0", Offset = "0x7040F0", VA = "0x7040F0")]
		private void onCreated(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x704234", Offset = "0x704234", VA = "0x704234")]
		private void onRenamed(object source, RenamedEventArgs e)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x704378", Offset = "0x704378", VA = "0x704378")]
		private void onChanged(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x7044BC", Offset = "0x7044BC", VA = "0x7044BC")]
		private void scanOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x704620", Offset = "0x704620", VA = "0x704620")]
		private void readPath()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x704A58", Offset = "0x704A58", VA = "0x704A58")]
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
			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPlaylist <>4__this;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000CB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000335")]
				[Address(RVA = "0x708290", Offset = "0x708290", VA = "0x708290", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000337")]
				[Address(RVA = "0x7082D8", Offset = "0x7082D8", VA = "0x7082D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x70664C", Offset = "0x70664C", VA = "0x70664C")]
			[DebuggerHidden]
			public <readFileM3U>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x707AD4", Offset = "0x707AD4", VA = "0x707AD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x707AF0", Offset = "0x707AF0", VA = "0x707AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x7081E0", Offset = "0x7081E0", VA = "0x7081E0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x708298", Offset = "0x708298", VA = "0x708298", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000049")]
		private sealed class <readFilePLS>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordProviderPlaylist <>4__this;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600033C")]
				[Address(RVA = "0x708A9C", Offset = "0x708A9C", VA = "0x708A9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600033E")]
				[Address(RVA = "0x708AE4", Offset = "0x708AE4", VA = "0x708AE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x706FF0", Offset = "0x706FF0", VA = "0x706FF0")]
			[DebuggerHidden]
			public <readFilePLS>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x7082E0", Offset = "0x7082E0", VA = "0x7082E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x7082FC", Offset = "0x7082FC", VA = "0x7082FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x7089EC", Offset = "0x7089EC", VA = "0x7089EC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x708AA4", Offset = "0x708AA4", VA = "0x708AA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("URL")]
		private string url;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RecordsChangeEvent OnRecordsChanged;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ErrorProviderEvent OnErrorProviderInfo;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] splitCharColon;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly char[] splitCharComma;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly char[] splitCharEquals;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string KEY_URL;

		[Token(Token = "0x4000186")]
		private const int timeout = 20;

		[Token(Token = "0x170000C7")]
		public string URL
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x70622C", Offset = "0x70622C", VA = "0x70622C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x706234", Offset = "0x706234", VA = "0x706234")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x706300", Offset = "0x706300", VA = "0x706300", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x706308", Offset = "0x706308", VA = "0x706308", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public PlayListFormat Format
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x706310", Offset = "0x706310", VA = "0x706310")]
			get
			{
				return default(PlayListFormat);
			}
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x70643C", Offset = "0x70643C", VA = "0x70643C", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x7064FC", Offset = "0x7064FC", VA = "0x7064FC", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x706520", Offset = "0x706520", VA = "0x706520", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x7065D8", Offset = "0x7065D8", VA = "0x7065D8")]
		private IEnumerator readFileM3U()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x706674", Offset = "0x706674", VA = "0x706674")]
		private void parseM3U(string text)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x706564", Offset = "0x706564", VA = "0x706564")]
		private IEnumerator readFilePLS()
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x707018", Offset = "0x707018", VA = "0x707018")]
		private void parsePLS(string text)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x7079D0", Offset = "0x7079D0", VA = "0x7079D0")]
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
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PointMode Mode;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float EventTimePosition;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("EventPosition")]
		[SerializeField]
		private float eventPosition;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int EventSamplePosition;

		[Token(Token = "0x170000CF")]
		public float EventPosition
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x708AEC", Offset = "0x708AEC", VA = "0x708AEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x708AF4", Offset = "0x708AF4", VA = "0x708AF4")]
			set
			{
			}
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x708B10", Offset = "0x708B10", VA = "0x708B10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x708D6C", Offset = "0x708D6C", VA = "0x708D6C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x708EE8", Offset = "0x708EE8", VA = "0x708EE8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x708F40", Offset = "0x708F40", VA = "0x708F40")]
		public EventPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class LoopPoint
	{
		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PointMode Mode;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float StartTimePosition;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float EndTimePosition;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[FormerlySerializedAs("StartPosition")]
		private float startPosition;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("EndPosition")]
		[SerializeField]
		private float endPosition;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int StartSamplePosition;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int EndSamplePosition;

		[Token(Token = "0x170000D0")]
		public float StartPosition
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x708F60", Offset = "0x708F60", VA = "0x708F60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x708F68", Offset = "0x708F68", VA = "0x708F68")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public float EndPosition
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x708F88", Offset = "0x708F88", VA = "0x708F88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x708F90", Offset = "0x708F90", VA = "0x708F90")]
			set
			{
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x708FB0", Offset = "0x708FB0", VA = "0x708FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x709300", Offset = "0x709300", VA = "0x709300", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x7094D4", Offset = "0x7094D4", VA = "0x7094D4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x709560", Offset = "0x709560", VA = "0x709560")]
		public LoopPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class M3UEntry
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Title;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Length;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x709580", Offset = "0x709580", VA = "0x709580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x70975C", Offset = "0x70975C", VA = "0x70975C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x70987C", Offset = "0x70987C", VA = "0x70987C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x706F98", Offset = "0x706F98", VA = "0x706F98")]
		public M3UEntry()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class PLSEntry
	{
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Title;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Length;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x7098D8", Offset = "0x7098D8", VA = "0x7098D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x709AB4", Offset = "0x709AB4", VA = "0x709AB4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x709BD4", Offset = "0x709BD4", VA = "0x709BD4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x707978", Offset = "0x707978", VA = "0x707978")]
		public PLSEntry()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class Record
	{
		[Token(Token = "0x200004F")]
		private sealed class <readSize>d__96 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Record <>4__this;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000E7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600037F")]
				[Address(RVA = "0x70C4A8", Offset = "0x70C4A8", VA = "0x70C4A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000381")]
				[Address(RVA = "0x70C4F0", Offset = "0x70C4F0", VA = "0x70C4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037B")]
			[Address(RVA = "0x70B7D8", Offset = "0x70B7D8", VA = "0x70B7D8")]
			[DebuggerHidden]
			public <readSize>d__96(int <>1__state)
			{
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x70C168", Offset = "0x70C168", VA = "0x70C168", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x70C184", Offset = "0x70C184", VA = "0x70C184", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x70C3F8", Offset = "0x70C3F8", VA = "0x70C3F8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x70C4B0", Offset = "0x70C4B0", VA = "0x70C4B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[XmlIgnore]
		public AudioClip Clip;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Rating;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[XmlIgnore]
		public Sprite Icon;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string IconUrl;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int Channels;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int SampleRate;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int Samples;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string name;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string title;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string artist;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string album;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float duration;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string genre;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int year;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private AudioFormat format;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private long fileSize;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Tag tag;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool loadingTag;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string spotifyUrl;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string lyricsUrl;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] splitChar;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Regex lyricsRegex;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool loadingFileSize;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int bitrate;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool <isTagLoaded>k__BackingField;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool <isFileSizeLoaded>k__BackingField;

		[Token(Token = "0x170000D2")]
		public bool isTagLoaded
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x709C30", Offset = "0x709C30", VA = "0x709C30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x709C38", Offset = "0x709C38", VA = "0x709C38")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool isFileSizeLoaded
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x709C44", Offset = "0x709C44", VA = "0x709C44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x709C4C", Offset = "0x709C4C", VA = "0x709C4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public bool isLocalFile
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x709C58", Offset = "0x709C58", VA = "0x709C58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D5")]
		public string Name
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x6FA860", Offset = "0x6FA860", VA = "0x6FA860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public string Title
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x6FAB94", Offset = "0x6FAB94", VA = "0x6FAB94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public string Artist
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x6FAC68", Offset = "0x6FAC68", VA = "0x6FAC68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public string Album
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x6FAD8C", Offset = "0x6FAD8C", VA = "0x6FAD8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public float Duration
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x6FA5BC", Offset = "0x6FA5BC", VA = "0x6FA5BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x70A334", Offset = "0x70A334", VA = "0x70A334")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public string Genre
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x6FAEB0", Offset = "0x6FAEB0", VA = "0x6FAEB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public int Year
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x6FB088", Offset = "0x6FB088", VA = "0x6FB088")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DC")]
		public string Url
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x70A340", Offset = "0x70A340", VA = "0x70A340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public long FileSize
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x6FA74C", Offset = "0x6FA74C", VA = "0x6FA74C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000DE")]
		public bool HasTag
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x70A984", Offset = "0x70A984", VA = "0x70A984")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public Tag Tag
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x70AA38", Offset = "0x70AA38", VA = "0x70AA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		public AudioFormat Format
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x6FB384", Offset = "0x6FB384", VA = "0x6FB384")]
			get
			{
				return default(AudioFormat);
			}
		}

		[Token(Token = "0x170000E1")]
		public string SpotifyUrl
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x70B630", Offset = "0x70B630", VA = "0x70B630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		public int Bitrate
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x6FBBCC", Offset = "0x6FBBCC", VA = "0x6FBBCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E3")]
		private bool hasID3Tag
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x70A9D8", Offset = "0x70A9D8", VA = "0x70A9D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E4")]
		private bool hasXiphComment
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x70A9F0", Offset = "0x70A9F0", VA = "0x70A9F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E5")]
		private bool hasM4ATag
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x70AA20", Offset = "0x70AA20", VA = "0x70AA20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		private bool hasAiffTag
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x70AA08", Offset = "0x70AA08", VA = "0x70AA08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x70B734", Offset = "0x70B734", VA = "0x70B734")]
		public Record()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x701A84", Offset = "0x701A84", VA = "0x701A84")]
		public Record(string filePath, bool loadTag = false, bool readFileSize = false)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x706FA0", Offset = "0x706FA0", VA = "0x706FA0")]
		public Record(M3UEntry entry, bool loadTag, bool readFileSize)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x707980", Offset = "0x707980", VA = "0x707980")]
		public Record(PLSEntry entry, bool loadTag, bool readFileSize)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x702868", Offset = "0x702868", VA = "0x702868")]
		public Record(AudioClip clip)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x709CD4", Offset = "0x709CD4", VA = "0x709CD4")]
		private void parseInfo()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x70B654", Offset = "0x70B654", VA = "0x70B654")]
		private void parseSpotifyUrl()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x70A3D8", Offset = "0x70A3D8", VA = "0x70A3D8")]
		private void readFileSize()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x70B764", Offset = "0x70B764", VA = "0x70B764")]
		private IEnumerator readSize()
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x70AA84", Offset = "0x70AA84", VA = "0x70AA84")]
		private void loadTag()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x70B800", Offset = "0x70B800", VA = "0x70B800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x70B940", Offset = "0x70B940", VA = "0x70B940", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x70BA34", Offset = "0x70BA34", VA = "0x70BA34", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class RecordFilter
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string FilePath;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Title;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Artist;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Album;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Genres;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("RatingMin")]
		private float ratingMin;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[FormerlySerializedAs("RatingMax")]
		[SerializeField]
		private float ratingMax;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("YearMin")]
		[SerializeField]
		private int yearMin;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[FormerlySerializedAs("YearMax")]
		[SerializeField]
		private int yearMax;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string Format;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("BitrateMin")]
		private int bitrateMin;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[FormerlySerializedAs("BitrateMax")]
		private int bitrateMax;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int Limit;

		[Token(Token = "0x170000E9")]
		public float RatingMin
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x70C4F8", Offset = "0x70C4F8", VA = "0x70C4F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x70C500", Offset = "0x70C500", VA = "0x70C500")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public float RatingMax
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x70C520", Offset = "0x70C520", VA = "0x70C520")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x70C528", Offset = "0x70C528", VA = "0x70C528")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public int YearMin
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x70C548", Offset = "0x70C548", VA = "0x70C548")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x70C550", Offset = "0x70C550", VA = "0x70C550")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public int YearMax
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x70C568", Offset = "0x70C568", VA = "0x70C568")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x70C570", Offset = "0x70C570", VA = "0x70C570")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public int BitrateMin
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x70C58C", Offset = "0x70C58C", VA = "0x70C58C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x70C594", Offset = "0x70C594", VA = "0x70C594")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public int BitrateMax
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x70C5B4", Offset = "0x70C5B4", VA = "0x70C5B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x70C5BC", Offset = "0x70C5BC", VA = "0x70C5BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public bool isFiltering
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x70C5DC", Offset = "0x70C5DC", VA = "0x70C5DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x70C6C0", Offset = "0x70C6C0", VA = "0x70C6C0")]
		public RecordFilter()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x70C7CC", Offset = "0x70C7CC", VA = "0x70C7CC")]
		public RecordFilter(RecordFilter filter)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x70CA48", Offset = "0x70CA48", VA = "0x70CA48", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x70CC78", Offset = "0x70CC78", VA = "0x70CC78", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x70CD84", Offset = "0x70CD84", VA = "0x70CD84", Slot = "3")]
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
		[Token(Token = "0x40001CE")]
		MP3_NLayer,
		[Token(Token = "0x40001CF")]
		MP3_NAudio,
		[Token(Token = "0x40001D0")]
		OGG_NVorbis,
		[Token(Token = "0x40001D1")]
		FMOD
	}
	[Token(Token = "0x2000052")]
	public enum AudioFormat
	{
		[Token(Token = "0x40001D3")]
		ALL,
		[Token(Token = "0x40001D4")]
		MP3,
		[Token(Token = "0x40001D5")]
		M4A,
		[Token(Token = "0x40001D6")]
		OGG,
		[Token(Token = "0x40001D7")]
		XM,
		[Token(Token = "0x40001D8")]
		IT,
		[Token(Token = "0x40001D9")]
		MOD,
		[Token(Token = "0x40001DA")]
		S3M,
		[Token(Token = "0x40001DB")]
		WAV,
		[Token(Token = "0x40001DC")]
		AIFF
	}
	[Token(Token = "0x2000053")]
	public enum PlayListFormat
	{
		[Token(Token = "0x40001DE")]
		UNKNOWN,
		[Token(Token = "0x40001DF")]
		M3U,
		[Token(Token = "0x40001E0")]
		PLS
	}
	[Token(Token = "0x2000054")]
	public enum PointMode
	{
		[Token(Token = "0x40001E2")]
		SECONDS,
		[Token(Token = "0x40001E3")]
		PERCENTAGE,
		[Token(Token = "0x40001E4")]
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
			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int BPM;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float Match;
		}

		[Serializable]
		[Token(Token = "0x2000057")]
		private sealed class <>c
		{
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<BpmMatchData, float> <>9__18_1;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BpmMatchData> <>9__18_0;

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x70E21C", Offset = "0x70E21C", VA = "0x70E21C")]
			public <>c()
			{
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x70E224", Offset = "0x70E224", VA = "0x70E224")]
			internal bool <searchBpm>b__18_0(BpmMatchData x)
			{
				return default(bool);
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x70E374", Offset = "0x70E374", VA = "0x70E374")]
			internal float <searchBpm>b__18_1(BpmMatchData y)
			{
				return default(float);
			}
		}

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource Source;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int SampleSplit;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool AutoAnalyze;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BasePlayer Player;

		[Token(Token = "0x40001E9")]
		private const int MIN_BPM = 50;

		[Token(Token = "0x40001EA")]
		private const int MAX_BPM = 500;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static BpmMatchData[] bpmMatchDatas;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <LastBPM>k__BackingField;

		[Token(Token = "0x170000F0")]
		public int LastBPM
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x70D2BC", Offset = "0x70D2BC", VA = "0x70D2BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x70D2C4", Offset = "0x70D2C4", VA = "0x70D2C4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x70D2CC", Offset = "0x70D2CC", VA = "0x70D2CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x70D4C0", Offset = "0x70D4C0", VA = "0x70D4C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x70D594", Offset = "0x70D594", VA = "0x70D594")]
		public int AnalyzeBPM()
		{
			return default(int);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x70D6F0", Offset = "0x70D6F0", VA = "0x70D6F0")]
		public static int AnalyzeBPM(float[] data, int frequency = 44100, int channels = 2, int sampleSplit = 100)
		{
			return default(int);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x70DEB4", Offset = "0x70DEB4", VA = "0x70DEB4")]
		public static int AnalyzeBPM(AudioClip clip, int sampleSplit = 100)
		{
			return default(int);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x70D660", Offset = "0x70D660", VA = "0x70D660")]
		private static float[] getData(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x70D8EC", Offset = "0x70D8EC", VA = "0x70D8EC")]
		private static float[] createVolumeArray(float[] allSamples, int frequency, int channels, int splitFrameSize)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x70DAB4", Offset = "0x70DAB4", VA = "0x70DAB4")]
		private static int searchBpm(float[] volumeArr, int frequency, int splitFrameSize)
		{
			return default(int);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x70E018", Offset = "0x70E018", VA = "0x70E018")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x70E128", Offset = "0x70E128", VA = "0x70E128")]
		public BPMAnalyzer()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class LoadAudioClip : MonoBehaviour
	{
		[Token(Token = "0x2000059")]
		public delegate void LoadClipStart(Record record);

		[Token(Token = "0x200005A")]
		public delegate void LoadClipEnd(Record record, AudioClip clip);

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Turntable player;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isRunning;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioClip <LastAudioClip>k__BackingField;

		[Token(Token = "0x170000F1")]
		public Turntable Player
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x70E380", Offset = "0x70E380", VA = "0x70E380")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x70E388", Offset = "0x70E388", VA = "0x70E388")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public AudioClip LastAudioClip
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x70E7E4", Offset = "0x70E7E4", VA = "0x70E7E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x70E7EC", Offset = "0x70E7EC", VA = "0x70E7EC")]
			private set
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event LoadClipStart OnLoadClipStart
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x70E7F4", Offset = "0x70E7F4", VA = "0x70E7F4")]
			add
			{
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x70E890", Offset = "0x70E890", VA = "0x70E890")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event LoadClipEnd OnLoadClipEnd
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x70E92C", Offset = "0x70E92C", VA = "0x70E92C")]
			add
			{
			}
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x70E9C8", Offset = "0x70E9C8", VA = "0x70E9C8")]
			remove
			{
			}
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x70EA64", Offset = "0x70EA64", VA = "0x70EA64")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x70EBA0", Offset = "0x70EBA0", VA = "0x70EBA0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x70EBA4", Offset = "0x70EBA4", VA = "0x70EBA4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x70EBA8", Offset = "0x70EBA8", VA = "0x70EBA8")]
		public void LoadClip(Record record)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x70EC78", Offset = "0x70EC78", VA = "0x70EC78")]
		public void LoadClip(string filePath)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x70E644", Offset = "0x70E644", VA = "0x70E644")]
		private void register()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x70E4A4", Offset = "0x70E4A4", VA = "0x70E4A4")]
		private void unregister()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x70ECF0", Offset = "0x70ECF0", VA = "0x70ECF0")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x70EF2C", Offset = "0x70EF2C", VA = "0x70EF2C")]
		private void onPlaybackStart(Record record)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x70EF50", Offset = "0x70EF50", VA = "0x70EF50")]
		private void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x70EF58", Offset = "0x70EF58", VA = "0x70EF58")]
		public LoadAudioClip()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class ChangeAudioCodec : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioCodec Codec;

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x70F204", Offset = "0x70F204", VA = "0x70F204")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x70F264", Offset = "0x70F264", VA = "0x70F264")]
		public ChangeAudioCodec()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[ExecuteInEditMode]
	public class CrossFader : MonoBehaviour
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource SourceA;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource SourceB;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float volumeA;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float volumeB;

		[Token(Token = "0x170000F3")]
		public float FaderPosition
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x70F26C", Offset = "0x70F26C", VA = "0x70F26C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x70F39C", Offset = "0x70F39C", VA = "0x70F39C")]
			set
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x70F570", Offset = "0x70F570", VA = "0x70F570")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x70F6D8", Offset = "0x70F6D8", VA = "0x70F6D8")]
		public CrossFader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class EventPositionReachedEvent : UnityEvent
	{
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x70F6E8", Offset = "0x70F6E8", VA = "0x70F6E8")]
		public EventPositionReachedEvent()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class Eventer : MonoBehaviour
	{
		[Token(Token = "0x200005F")]
		public delegate void EventPositionReached(Record record, EventPoint eventPoint);

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BasePlayer Player;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventPoint Event;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isEventFired;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventPositionReachedEvent OnEventPosition;

		[Token(Token = "0x170000F4")]
		public PointMode Mode
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x70F6F0", Offset = "0x70F6F0", VA = "0x70F6F0")]
			get
			{
				return default(PointMode);
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x70F708", Offset = "0x70F708", VA = "0x70F708")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public float StartTimePosition
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x70F718", Offset = "0x70F718", VA = "0x70F718")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x70F730", Offset = "0x70F730", VA = "0x70F730")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public float EventPosition
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x70F744", Offset = "0x70F744", VA = "0x70F744")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x70F75C", Offset = "0x70F75C", VA = "0x70F75C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public int EventSamplePosition
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x70F784", Offset = "0x70F784", VA = "0x70F784")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x70F79C", Offset = "0x70F79C", VA = "0x70F79C")]
			set
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event EventPositionReached OnEventPositionReached
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x70F800", Offset = "0x70F800", VA = "0x70F800")]
			add
			{
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x70F89C", Offset = "0x70F89C", VA = "0x70F89C")]
			remove
			{
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x70F938", Offset = "0x70F938", VA = "0x70F938")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x70F9F0", Offset = "0x70F9F0", VA = "0x70F9F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x70FCD0", Offset = "0x70FCD0", VA = "0x70FCD0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x70FB14", Offset = "0x70FB14", VA = "0x70FB14")]
		private void onEventPositionReached(Record record, EventPoint ep)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x70FD20", Offset = "0x70FD20", VA = "0x70FD20")]
		public Eventer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class LoopPositionReachedEvent : UnityEvent
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x70FE7C", Offset = "0x70FE7C", VA = "0x70FE7C")]
		public LoopPositionReachedEvent()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class Looper : MonoBehaviour
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("Player")]
		[SerializeField]
		private BasePlayer player;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("Loop")]
		private LoopPoint loop;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("EnableStartPosition")]
		private bool enableStartPosition;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LoopPositionReachedEvent OnLoopPosition;

		[Token(Token = "0x170000F8")]
		public BasePlayer Player
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x70FE84", Offset = "0x70FE84", VA = "0x70FE84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x70FE8C", Offset = "0x70FE8C", VA = "0x70FE8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public LoopPoint Loop
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x70FFFC", Offset = "0x70FFFC", VA = "0x70FFFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x710004", Offset = "0x710004", VA = "0x710004")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public bool EnableStartPosition
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x71000C", Offset = "0x71000C", VA = "0x71000C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x710014", Offset = "0x710014", VA = "0x710014")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public PointMode Mode
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x710020", Offset = "0x710020", VA = "0x710020")]
			get
			{
				return default(PointMode);
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x710038", Offset = "0x710038", VA = "0x710038")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float StartTimePosition
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x710048", Offset = "0x710048", VA = "0x710048")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x710060", Offset = "0x710060", VA = "0x710060")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public float EndTimePosition
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x710074", Offset = "0x710074", VA = "0x710074")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x71008C", Offset = "0x71008C", VA = "0x71008C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public float StartPosition
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x7100A0", Offset = "0x7100A0", VA = "0x7100A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x7100B8", Offset = "0x7100B8", VA = "0x7100B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public float EndPosition
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x7100F0", Offset = "0x7100F0", VA = "0x7100F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x710108", Offset = "0x710108", VA = "0x710108")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public int StartSamplePosition
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x710138", Offset = "0x710138", VA = "0x710138")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x710150", Offset = "0x710150", VA = "0x710150")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public int EndSamplePosition
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x7101B4", Offset = "0x7101B4", VA = "0x7101B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x7101CC", Offset = "0x7101CC", VA = "0x7101CC")]
			set
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event LoopPositionReached OnLoopPositionReached
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x710230", Offset = "0x710230", VA = "0x710230")]
			add
			{
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x7102CC", Offset = "0x7102CC", VA = "0x7102CC")]
			remove
			{
			}
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x710368", Offset = "0x710368", VA = "0x710368")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x71043C", Offset = "0x71043C", VA = "0x71043C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x710510", Offset = "0x710510", VA = "0x710510")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x710888", Offset = "0x710888", VA = "0x710888")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x710950", Offset = "0x710950", VA = "0x710950")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x7106D0", Offset = "0x7106D0", VA = "0x7106D0")]
		private void onLoopPositionReached(Record record, LoopPoint lp)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x7109DC", Offset = "0x7109DC", VA = "0x7109DC")]
		public Looper()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[RequireComponent(typeof(AudioSource))]
	public class Loudspeaker : MonoBehaviour
	{
		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("Player")]
		[SerializeField]
		private BasePlayer player;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("SilenceSource")]
		private bool silenceSource;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AudioSource audioSource;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool stopped;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long dataPosition;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioClip clip;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource source;

		[Token(Token = "0x17000102")]
		public BasePlayer Player
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x7109E4", Offset = "0x7109E4", VA = "0x7109E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x7109EC", Offset = "0x7109EC", VA = "0x7109EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public bool SilenceSource
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x710ADC", Offset = "0x710ADC", VA = "0x710ADC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x710AE4", Offset = "0x710AE4", VA = "0x710AE4")]
			set
			{
			}
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x710B14", Offset = "0x710B14", VA = "0x710B14")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x710B94", Offset = "0x710B94", VA = "0x710B94")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x710C4C", Offset = "0x710C4C", VA = "0x710C4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x710D84", Offset = "0x710D84", VA = "0x710D84")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x711048", Offset = "0x711048", VA = "0x711048")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x711268", Offset = "0x711268", VA = "0x711268")]
		public Loudspeaker()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class RecordFader : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		private sealed class <faderA>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordFader <>4__this;

			[Token(Token = "0x1700010B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000416")]
				[Address(RVA = "0x713170", Offset = "0x713170", VA = "0x713170", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x7131B8", Offset = "0x7131B8", VA = "0x7131B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x712DC8", Offset = "0x712DC8", VA = "0x712DC8")]
			[DebuggerHidden]
			public <faderA>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x712EF8", Offset = "0x712EF8", VA = "0x712EF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x712EFC", Offset = "0x712EFC", VA = "0x712EFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x713178", Offset = "0x713178", VA = "0x713178", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000065")]
		private sealed class <faderB>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RecordFader <>4__this;

			[Token(Token = "0x1700010D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x713438", Offset = "0x713438", VA = "0x713438", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x713480", Offset = "0x713480", VA = "0x713480", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x712DF0", Offset = "0x712DF0", VA = "0x712DF0")]
			[DebuggerHidden]
			public <faderB>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x7131C0", Offset = "0x7131C0", VA = "0x7131C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x7131C4", Offset = "0x7131C4", VA = "0x7131C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x713440", Offset = "0x713440", VA = "0x713440", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("PlayerA")]
		private SimplePlayer playerA;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("PlayerB")]
		[SerializeField]
		private SimplePlayer playerB;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("FadeTime")]
		[SerializeField]
		private float fadeTime;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[FormerlySerializedAs("AutoFade")]
		[SerializeField]
		private bool autoFade;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float volumeA;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float volumeB;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fadeA;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool fadeB;

		[Token(Token = "0x4000215")]
		private const float reserveTime = 0.3f;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool initialEndlessA;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		private bool initialEndlessB;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <Progress>k__BackingField;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <Elapsed>k__BackingField;

		[Token(Token = "0x17000104")]
		public SimplePlayer PlayerA
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x71227C", Offset = "0x71227C", VA = "0x71227C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x712284", Offset = "0x712284", VA = "0x712284")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public SimplePlayer PlayerB
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x7123F4", Offset = "0x7123F4", VA = "0x7123F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x7123FC", Offset = "0x7123FC", VA = "0x7123FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public float FadeTime
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x71256C", Offset = "0x71256C", VA = "0x71256C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x712574", Offset = "0x712574", VA = "0x712574")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public bool AutoFade
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x712594", Offset = "0x712594", VA = "0x712594")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x71259C", Offset = "0x71259C", VA = "0x71259C")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool isFading
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x7125A8", Offset = "0x7125A8", VA = "0x7125A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		public float Progress
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x7125C8", Offset = "0x7125C8", VA = "0x7125C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x7125D0", Offset = "0x7125D0", VA = "0x7125D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public float Elapsed
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x7125D8", Offset = "0x7125D8", VA = "0x7125D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x7125E0", Offset = "0x7125E0", VA = "0x7125E0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x7125E8", Offset = "0x7125E8", VA = "0x7125E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x712944", Offset = "0x712944", VA = "0x712944")]
		private void Update()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x712B6C", Offset = "0x712B6C", VA = "0x712B6C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x712B94", Offset = "0x712B94", VA = "0x712B94")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x712B38", Offset = "0x712B38", VA = "0x712B38")]
		public void FadeA()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x712B04", Offset = "0x712B04", VA = "0x712B04")]
		public void FadeB()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x712CE0", Offset = "0x712CE0", VA = "0x712CE0")]
		private IEnumerator faderA()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x712D54", Offset = "0x712D54", VA = "0x712D54")]
		private IEnumerator faderB()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x712E18", Offset = "0x712E18", VA = "0x712E18")]
		private void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x712ED8", Offset = "0x712ED8", VA = "0x712ED8")]
		public RecordFader()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[RequireComponent(typeof(AudioSource))]
	public class RecordSaver : MonoBehaviour
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("Player")]
		[SerializeField]
		private BasePlayer player;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("SilenceSource")]
		private bool silenceSource;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("OutputPath")]
		private string outputPath;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FileStream fileStream;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioSource audioSource;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool recOutput;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool stopped;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private long dataPosition;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string fileName;

		[Token(Token = "0x4000229")]
		private const int HEADER_SIZE = 44;

		[Token(Token = "0x400022A")]
		private const float RESCALE_FACTOR = 32767f;

		[Token(Token = "0x400022B")]
		private const string extension = ".wav";

		[Token(Token = "0x1700010F")]
		public BasePlayer Player
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x713488", Offset = "0x713488", VA = "0x713488")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x713490", Offset = "0x713490", VA = "0x713490")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public bool SilenceSource
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x713814", Offset = "0x713814", VA = "0x713814")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x71381C", Offset = "0x71381C", VA = "0x71381C")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public string OutputPath
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x71384C", Offset = "0x71384C", VA = "0x71384C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x713854", Offset = "0x713854", VA = "0x713854")]
			set
			{
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x713A90", Offset = "0x713A90", VA = "0x713A90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x713B10", Offset = "0x713B10", VA = "0x713B10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x713C68", Offset = "0x713C68", VA = "0x713C68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x713EDC", Offset = "0x713EDC", VA = "0x713EDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x713EE0", Offset = "0x713EE0", VA = "0x713EE0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x714780", Offset = "0x714780", VA = "0x714780")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x714804", Offset = "0x714804", VA = "0x714804")]
		public void SaveFile(Stream stream, [Optional] string fname)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x714888", Offset = "0x714888", VA = "0x714888")]
		public void SaveFile(byte[] data, [Optional] string fname)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x7136D4", Offset = "0x7136D4", VA = "0x7136D4")]
		private void register()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x713594", Offset = "0x713594", VA = "0x713594")]
		private void unregister()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x715030", Offset = "0x715030", VA = "0x715030")]
		private void openFile()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x714EA8", Offset = "0x714EA8", VA = "0x714EA8")]
		private void write(byte[] bytesData, int count)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x713F2C", Offset = "0x713F2C", VA = "0x713F2C")]
		private void closeFile()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x71535C", Offset = "0x71535C", VA = "0x71535C")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x715538", Offset = "0x715538", VA = "0x715538")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x715784", Offset = "0x715784", VA = "0x715784")]
		private void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x715830", Offset = "0x715830", VA = "0x715830")]
		public RecordSaver()
		{
		}
	}
}
namespace Crosstales.UI
{
	[Token(Token = "0x2000067")]
	public class Social : MonoBehaviour
	{
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x715840", Offset = "0x715840", VA = "0x715840")]
		public void Facebook()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x715984", Offset = "0x715984", VA = "0x715984")]
		public void Twitter()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x7159E8", Offset = "0x7159E8", VA = "0x7159E8")]
		public void LinkedIn()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x715A4C", Offset = "0x715A4C", VA = "0x715A4C")]
		public void Youtube()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x715AB0", Offset = "0x715AB0", VA = "0x715AB0")]
		public void Discord()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x715B14", Offset = "0x715B14", VA = "0x715B14")]
		public Social()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class StaticManager : MonoBehaviour
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x715B1C", Offset = "0x715B1C", VA = "0x715B1C")]
		public void Quit()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x715B24", Offset = "0x715B24", VA = "0x715B24")]
		public void OpenCrosstales()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x715B88", Offset = "0x715B88", VA = "0x715B88")]
		public void OpenAssetstore()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x715BEC", Offset = "0x715BEC", VA = "0x715BEC")]
		public StaticManager()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class UIDrag : MonoBehaviour
	{
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float offsetX;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float offsetY;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform tf;

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x715BF4", Offset = "0x715BF4", VA = "0x715BF4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x715C18", Offset = "0x715C18", VA = "0x715C18")]
		public void BeginDrag()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x715C6C", Offset = "0x715C6C", VA = "0x715C6C")]
		public void OnDrag()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x715CD0", Offset = "0x715CD0", VA = "0x715CD0")]
		public UIDrag()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class UIFocus : MonoBehaviour
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ManagerName;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UIWindowManager manager;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image image;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tf;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x715CD8", Offset = "0x715CD8", VA = "0x715CD8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x715DBC", Offset = "0x715DBC", VA = "0x715DBC")]
		public void OnPanelEnter()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x716070", Offset = "0x716070", VA = "0x716070")]
		public UIFocus()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class UIHint : MonoBehaviour
	{
		[Token(Token = "0x200006C")]
		private sealed class <lerpAlphaDown>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Component gameObjectToFade;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIHint <>4__this;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float startAlphaValue;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float endAlphaValue;

			[Token(Token = "0x400023E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float delay;

			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float time;

			[Token(Token = "0x17000112")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x7164EC", Offset = "0x7164EC", VA = "0x7164EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000113")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x716534", Offset = "0x716534", VA = "0x716534", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x7162A8", Offset = "0x7162A8", VA = "0x7162A8")]
			[DebuggerHidden]
			public <lerpAlphaDown>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x716310", Offset = "0x716310", VA = "0x716310", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x716314", Offset = "0x716314", VA = "0x716314", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x7164F4", Offset = "0x7164F4", VA = "0x7164F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006D")]
		private sealed class <lerpAlphaUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Component gameObjectToFade;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIHint <>4__this;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float startAlphaValue;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float endAlphaValue;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float delay;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float time;

			[Token(Token = "0x17000114")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x716710", Offset = "0x716710", VA = "0x716710", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000115")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x716758", Offset = "0x716758", VA = "0x716758", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x7162D0", Offset = "0x7162D0", VA = "0x7162D0")]
			[DebuggerHidden]
			public <lerpAlphaUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x71653C", Offset = "0x71653C", VA = "0x71653C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x716540", Offset = "0x716540", VA = "0x716540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x716718", Offset = "0x716718", VA = "0x716718", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CanvasGroup Group;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float FadeTime;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool Disable;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool FadeAtStart;

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x7160C8", Offset = "0x7160C8", VA = "0x7160C8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x716108", Offset = "0x716108", VA = "0x716108")]
		public void FadeUp()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x7160D8", Offset = "0x7160D8", VA = "0x7160D8")]
		public void FadeDown()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x7161F0", Offset = "0x7161F0", VA = "0x7161F0")]
		private IEnumerator lerpAlphaDown(float startAlphaValue, float endAlphaValue, float time, float delay, Component gameObjectToFade)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x716138", Offset = "0x716138", VA = "0x716138")]
		private IEnumerator lerpAlphaUp(float startAlphaValue, float endAlphaValue, float time, float delay, Component gameObjectToFade)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x7162F8", Offset = "0x7162F8", VA = "0x7162F8")]
		public UIHint()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class UIResize : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 MinSize;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 MaxSize;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform panelRectTransform;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 originalLocalPointerPosition;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 originalSizeDelta;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector2 originalSize;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x716760", Offset = "0x716760", VA = "0x716760")]
		public void Awake()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x716828", Offset = "0x716828", VA = "0x716828", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x7168DC", Offset = "0x7168DC", VA = "0x7168DC", Slot = "5")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x716A4C", Offset = "0x716A4C", VA = "0x716A4C")]
		public UIResize()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class UIWindowManager : MonoBehaviour
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] Windows;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image image;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject DontTouch;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x716A60", Offset = "0x716A60", VA = "0x716A60")]
		public void Start()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x715E6C", Offset = "0x715E6C", VA = "0x715E6C")]
		public void ChangeState(GameObject active)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x716B7C", Offset = "0x716B7C", VA = "0x716B7C")]
		public UIWindowManager()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class WindowManager : MonoBehaviour
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Speed;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] Dependencies;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UIFocus focus;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool open;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool close;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 startPos;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 centerPos;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lerpPos;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float openProgress;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float closeProgress;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject panel;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform tf;

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x716B84", Offset = "0x716B84", VA = "0x716B84")]
		public void Start()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x716CD4", Offset = "0x716CD4", VA = "0x716CD4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x716E74", Offset = "0x716E74", VA = "0x716E74")]
		public void SwitchPanel()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x716E84", Offset = "0x716E84", VA = "0x716E84")]
		public void OpenPanel()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x716C9C", Offset = "0x716C9C", VA = "0x716C9C")]
		public void ClosePanel()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x716F8C", Offset = "0x716F8C", VA = "0x716F8C")]
		public WindowManager()
		{
		}
	}
}
namespace Crosstales.UI.Util
{
	[Token(Token = "0x2000071")]
	public class FPSDisplay : MonoBehaviour
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text FPS;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float deltaTime;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float elapsedTime;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float msec;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float fps;

		[Token(Token = "0x4000262")]
		private const string wait = "<i>...calculating <b>FPS</b>...</i>";

		[Token(Token = "0x4000263")]
		private const string red = "<color=#E57373><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x4000264")]
		private const string orange = "<color=#FFB74D><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x4000265")]
		private const string green = "<color=#81C784><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x716F9C", Offset = "0x716F9C", VA = "0x716F9C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x7171C8", Offset = "0x7171C8", VA = "0x7171C8")]
		public FPSDisplay()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class ScrollRectHandler : MonoBehaviour
	{
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScrollRect Scroll;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float WindowsSensitivity;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MacSensitivity;

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x7171D0", Offset = "0x7171D0", VA = "0x7171D0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x717244", Offset = "0x717244", VA = "0x717244")]
		public ScrollRectHandler()
		{
		}
	}
}
namespace Crosstales.UI.Audio
{
	[Token(Token = "0x2000073")]
	public class AudioFilterController : MonoBehaviour
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool FindAllAudioFiltersOnStart;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioReverbFilter[] ReverbFilters;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioChorusFilter[] ChorusFilters;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEchoFilter[] EchoFilters;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioDistortionFilter[] DistortionFilters;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioLowPassFilter[] LowPassFilters;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioHighPassFilter[] HighPassFilters;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool ResetAudioFiltersOnStart;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool ChorusFilter;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool EchoFilter;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool DistortionFilter;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float DistortionFilterValue;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool LowpassFilter;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float LowpassFilterValue;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool HighpassFilter;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float HighpassFilterValue;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dropdown ReverbFilterDropdown;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Text DistortionText;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Text LowpassText;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Text HighpassText;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<AudioReverbPreset> reverbPresets;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool initalized;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x717258", Offset = "0x717258", VA = "0x717258")]
		public void Start()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x7177AC", Offset = "0x7177AC", VA = "0x7177AC")]
		public void Update()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x717820", Offset = "0x717820", VA = "0x717820")]
		public void FindAllAudioFilters()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x717B30", Offset = "0x717B30", VA = "0x717B30")]
		public void ResetAudioFilters()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x717BA4", Offset = "0x717BA4", VA = "0x717BA4")]
		public void ReverbFilterDropdownChanged(int index)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x717C60", Offset = "0x717C60", VA = "0x717C60")]
		public void ChorusFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x717CC8", Offset = "0x717CC8", VA = "0x717CC8")]
		public void EchoFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x717D30", Offset = "0x717D30", VA = "0x717D30")]
		public void DistortionFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x717D98", Offset = "0x717D98", VA = "0x717D98")]
		public void DistortionFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x717EA4", Offset = "0x717EA4", VA = "0x717EA4")]
		public void LowPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x717F0C", Offset = "0x717F0C", VA = "0x717F0C")]
		public void LowPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x718018", Offset = "0x718018", VA = "0x718018")]
		public void HighPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x718080", Offset = "0x718080", VA = "0x718080")]
		public void HighPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x71818C", Offset = "0x71818C", VA = "0x71818C")]
		public AudioFilterController()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class AudioSourceController : MonoBehaviour
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool FindAllAudioSourcesOnStart;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource[] AudioSources;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ResetAudioSourcesOnStart;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool Mute;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool Loop;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float Volume;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Pitch;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float StereoPan;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text VolumeText;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Text PitchText;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Text StereoPanText;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool initalized;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x718238", Offset = "0x718238", VA = "0x718238")]
		public void Update()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x7182AC", Offset = "0x7182AC", VA = "0x7182AC")]
		public void FindAllAudioSources()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x718398", Offset = "0x718398", VA = "0x718398")]
		public void ResetAllAudioSources()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x7183DC", Offset = "0x7183DC", VA = "0x7183DC")]
		public void MuteEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x718444", Offset = "0x718444", VA = "0x718444")]
		public void LoopEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x7184AC", Offset = "0x7184AC", VA = "0x7184AC")]
		public void VolumeChanged(float value)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x7185B8", Offset = "0x7185B8", VA = "0x7185B8")]
		public void PitchChanged(float value)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x7186C4", Offset = "0x7186C4", VA = "0x7186C4")]
		public void StereoPanChanged(float value)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x7187D0", Offset = "0x7187D0", VA = "0x7187D0")]
		public AudioSourceController()
		{
		}
	}
}
namespace Crosstales.Common.Tool
{
	[Token(Token = "0x2000075")]
	public class FreeCam : MonoBehaviour
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MovementSpeed;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FastMovementSpeed;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float FreeLookSensitivity;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ZoomSensitivity;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float FastZoomSensitivity;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tf;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool looking;

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x7187EC", Offset = "0x7187EC", VA = "0x7187EC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x718810", Offset = "0x718810", VA = "0x718810")]
		public void Update()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x718EC4", Offset = "0x718EC4", VA = "0x718EC4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x718E78", Offset = "0x718E78", VA = "0x718E78")]
		public void StartLooking()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x718EA0", Offset = "0x718EA0", VA = "0x718EA0")]
		public void StopLooking()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x718EE8", Offset = "0x718EE8", VA = "0x718EE8")]
		public FreeCam()
		{
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x2000076")]
	public enum Platform
	{
		[Token(Token = "0x4000293")]
		Windows,
		[Token(Token = "0x4000294")]
		OSX,
		[Token(Token = "0x4000295")]
		Linux,
		[Token(Token = "0x4000296")]
		IOS,
		[Token(Token = "0x4000297")]
		Android,
		[Token(Token = "0x4000298")]
		WSA,
		[Token(Token = "0x4000299")]
		Web,
		[Token(Token = "0x400029A")]
		Unsupported
	}
}
namespace Crosstales.Common.Audio
{
	[Token(Token = "0x2000077")]
	[DisallowMultipleComponent]
	public class FFTAnalyzer : MonoBehaviour
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] Samples;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Channel;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FFTWindow FFTMode;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x718F04", Offset = "0x718F04", VA = "0x718F04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x718F18", Offset = "0x718F18", VA = "0x718F18")]
		public FFTAnalyzer()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class SpectrumVisualizer : MonoBehaviour
	{
		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FFTAnalyzer Analyzer;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject VisualPrefab;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Width;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float Gain;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool LeftToRight;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Opacity;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform tf;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform[] visualTransforms;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 visualPos;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int samplesPerChannel;

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x718F84", Offset = "0x718F84", VA = "0x718F84")]
		private void Start()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x719418", Offset = "0x719418", VA = "0x719418")]
		private void Update()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x7194BC", Offset = "0x7194BC", VA = "0x7194BC")]
		public SpectrumVisualizer()
		{
		}
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x2000079")]
	[DisallowMultipleComponent]
	public class CTScreenshot : Singleton<CTScreenshot>
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Prefix;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Scale;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public KeyCode KeyCode;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ShowFileLocation;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D texture;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool locationShown;

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x719534", Offset = "0x719534", VA = "0x719534")]
		private void Update()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x719560", Offset = "0x719560", VA = "0x719560")]
		public void Capture()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x719778", Offset = "0x719778", VA = "0x719778")]
		public CTScreenshot()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[DisallowMultipleComponent]
	public class SurviveSceneSwitch : Singleton<SurviveSceneSwitch>
	{
		[Serializable]
		[Token(Token = "0x200007B")]
		private sealed class <>c
		{
			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__5_0;

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x719D28", Offset = "0x719D28", VA = "0x719D28")]
			public <>c()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x719D30", Offset = "0x719D30", VA = "0x719D30")]
			internal bool <Update>b__5_0(GameObject _go)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] Survivors;

		[Token(Token = "0x40002AF")]
		private const float ensureParentTime = 1.5f;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float ensureParentTimer;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform tf;

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x719828", Offset = "0x719828", VA = "0x719828")]
		private void Start()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x719854", Offset = "0x719854", VA = "0x719854")]
		private void Update()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x719C4C", Offset = "0x719C4C", VA = "0x719C4C")]
		public SurviveSceneSwitch()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[DisallowMultipleComponent]
	public class BackgroundController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		private sealed class <>c
		{
			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__3_0;

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x71A360", Offset = "0x71A360", VA = "0x71A360")]
			public <>c()
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x71A368", Offset = "0x71A368", VA = "0x71A368")]
			internal bool <FixedUpdate>b__3_0(GameObject go)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] Objects;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isFocused;

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x719D8C", Offset = "0x719D8C", VA = "0x719D8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x719DAC", Offset = "0x719DAC", VA = "0x719DAC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x71A2E8", Offset = "0x71A2E8", VA = "0x71A2E8")]
		public BackgroundController()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Regex REGEX_LINEENDINGS;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Regex REGEX_EMAIL;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Regex REGEX_CREDITCARD;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Regex REGEX_URL_WEB;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Regex REGEX_IP_ADDRESS;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Regex REGEX_INVALID_CHARS;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Regex REGEX_ALPHANUMERIC;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly Regex REGEX_CLEAN_SPACES;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly Regex REGEX_CLEAN_TAGS;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x17000116")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x71A3C4", Offset = "0x71A3C4", VA = "0x71A3C4")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x200007F")]
	public abstract class BaseHelper
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		private sealed class <>c
		{
			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<X509ChainStatus, bool> <>9__63_0;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<string, bool> <>9__68_0;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<string, string> <>9__68_1;

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x71C12C", Offset = "0x71C12C", VA = "0x71C12C")]
			public <>c()
			{
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x71C134", Offset = "0x71C134", VA = "0x71C134")]
			internal bool <RemoteCertificateValidationCallback>b__63_0(X509ChainStatus t)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x71C140", Offset = "0x71C140", VA = "0x71C140")]
			internal bool <GetFiles>b__68_0(string extension)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x71C1CC", Offset = "0x71C1CC", VA = "0x71C1CC")]
			internal string <GetFiles>b__68_1(string q)
			{
				return null;
			}
		}

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool ApplicationIsPlaying;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string applicationDataPath;

		[Token(Token = "0x17000117")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x717234", Offset = "0x717234", VA = "0x717234")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000118")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x71723C", Offset = "0x71723C", VA = "0x71723C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x71A888", Offset = "0x71A888", VA = "0x71A888")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x71A890", Offset = "0x71A890", VA = "0x71A890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x71A900", Offset = "0x71A900", VA = "0x71A900")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x71A908", Offset = "0x71A908", VA = "0x71A908")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011D")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x71A910", Offset = "0x71A910", VA = "0x71A910")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x71A918", Offset = "0x71A918", VA = "0x71A918")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x71A920", Offset = "0x71A920", VA = "0x71A920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000120")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x71A928", Offset = "0x71A928", VA = "0x71A928")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000121")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x71A930", Offset = "0x71A930", VA = "0x71A930")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000122")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x71A448", Offset = "0x71A448", VA = "0x71A448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000123")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x71A980", Offset = "0x71A980", VA = "0x71A980")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x71A9E0", Offset = "0x71A9E0", VA = "0x71A9E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x71A298", Offset = "0x71A298", VA = "0x71A298")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		public static bool isEditor
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x71AA40", Offset = "0x71AA40", VA = "0x71AA40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x71A4B8", Offset = "0x71A4B8", VA = "0x71A4B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x71A4C0", Offset = "0x71A4C0", VA = "0x71A4C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000129")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x71A4C8", Offset = "0x71A4C8", VA = "0x71A4C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012A")]
		public static bool isEditorMode
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x7128F0", Offset = "0x7128F0", VA = "0x7128F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x71AAB0", Offset = "0x71AAB0", VA = "0x71AAB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x71AAB8", Offset = "0x71AAB8", VA = "0x71AAB8")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x71AB38", Offset = "0x71AB38", VA = "0x71AB38")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x71AC50", Offset = "0x71AC50", VA = "0x71AC50")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x7158A4", Offset = "0x7158A4", VA = "0x7158A4")]
		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x71ADB4", Offset = "0x71ADB4", VA = "0x71ADB4")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x7138C8", Offset = "0x7138C8", VA = "0x7138C8")]
		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x714C50", Offset = "0x714C50", VA = "0x714C50")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x71B2CC", Offset = "0x71B2CC", VA = "0x71B2CC")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x71B7E0", Offset = "0x71B7E0", VA = "0x71B7E0")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x71B958", Offset = "0x71B958", VA = "0x71B958")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x71BC2C", Offset = "0x71BC2C", VA = "0x71BC2C")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x71BC88", Offset = "0x71BC88", VA = "0x71BC88")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x7192C8", Offset = "0x7192C8", VA = "0x7192C8")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x71ACD4", Offset = "0x71ACD4", VA = "0x71ACD4")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x7196D4", Offset = "0x7196D4", VA = "0x7196D4")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x71C04C", Offset = "0x71C04C", VA = "0x71C04C")]
		private static string addLeadingZero(int value)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x71ADAC", Offset = "0x71ADAC", VA = "0x71ADAC")]
		private static void openURL(string url)
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class CTHelper : MonoBehaviour
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CTHelper <Instance>k__BackingField;

		[Token(Token = "0x1700012D")]
		public static CTHelper Instance
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x71C1D4", Offset = "0x71C1D4", VA = "0x71C1D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x71C21C", Offset = "0x71C21C", VA = "0x71C21C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x71C274", Offset = "0x71C274", VA = "0x71C274")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x71C2D0", Offset = "0x71C2D0", VA = "0x71C2D0")]
		[RuntimeInitializeOnLoadMethod]
		private static void create()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x71C3C4", Offset = "0x71C3C4", VA = "0x71C3C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x71C41C", Offset = "0x71C41C", VA = "0x71C41C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x71C474", Offset = "0x71C474", VA = "0x71C474")]
		public CTHelper()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x71C47C", Offset = "0x71C47C", VA = "0x71C47C")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x71C4AC", Offset = "0x71C4AC", VA = "0x71C4AC")]
		public static void Save()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x71C4B4", Offset = "0x71C4B4", VA = "0x71C4B4")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x71C524", Offset = "0x71C524", VA = "0x71C524")]
		public static void SetString(string key, string value)
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class MemoryCacheStream : Stream
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] cache;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long writePosition;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long readPosition;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long length;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int size;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly int maxSize;

		[Token(Token = "0x1700012E")]
		public override bool CanRead
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x71C6E4", Offset = "0x71C6E4", VA = "0x71C6E4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012F")]
		public override bool CanSeek
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x71C6EC", Offset = "0x71C6EC", VA = "0x71C6EC", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000130")]
		public override bool CanWrite
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x71C6F4", Offset = "0x71C6F4", VA = "0x71C6F4", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000131")]
		public override long Position
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x71C6FC", Offset = "0x71C6FC", VA = "0x71C6FC", Slot = "10")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x71C704", Offset = "0x71C704", VA = "0x71C704", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public override long Length
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x71C780", Offset = "0x71C780", VA = "0x71C780", Slot = "9")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x71C5A4", Offset = "0x71C5A4", VA = "0x71C5A4")]
		public MemoryCacheStream(int cacheSize = 65536, int maxCacheSize = 67108864)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x71C788", Offset = "0x71C788", VA = "0x71C788", Slot = "17")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x71C78C", Offset = "0x71C78C", VA = "0x71C78C", Slot = "26")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x71C88C", Offset = "0x71C88C", VA = "0x71C88C", Slot = "27")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x71CA50", Offset = "0x71CA50", VA = "0x71CA50", Slot = "30")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x71C998", Offset = "0x71C998", VA = "0x71C998")]
		private int read(byte[] buff, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x71CB90", Offset = "0x71CB90", VA = "0x71CB90")]
		private void write(byte[] buff, int offset, int count)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x71C620", Offset = "0x71C620", VA = "0x71C620")]
		private void createCache()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class PlatformController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		private sealed class <>c
		{
			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__8_0;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<MonoBehaviour, bool> <>9__9_0;

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x71D568", Offset = "0x71D568", VA = "0x71D568")]
			public <>c()
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x71D570", Offset = "0x71D570", VA = "0x71D570")]
			internal bool <activateGameObjects>b__8_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x71D5CC", Offset = "0x71D5CC", VA = "0x71D5CC")]
			internal bool <activateScripts>b__9_0(MonoBehaviour script)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Platform> Platforms;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Active;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] Objects;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MonoBehaviour[] Scripts;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Platform currentPlatform;

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x71CC40", Offset = "0x71CC40", VA = "0x71CC40", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x71CC68", Offset = "0x71CC68", VA = "0x71CC68")]
		protected void selectPlatform()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x71CCD0", Offset = "0x71CCD0", VA = "0x71CCD0")]
		protected void activateGameObjects()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x71D0DC", Offset = "0x71D0DC", VA = "0x71D0DC")]
		protected void activateScripts()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x71D4E8", Offset = "0x71D4E8", VA = "0x71D4E8")]
		public PlatformController()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class RandomColor : MonoBehaviour
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseInterval;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 HueRange;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector2 SaturationRange;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 ValueRange;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector2 AlphaRange;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool GrayScale;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Material Material;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool RandomColorAtStart;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer currentRenderer;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Color32 startColor;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Color32 endColor;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float lerpProgress;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int colorID;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool existsMaterial;

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x71D628", Offset = "0x71D628", VA = "0x71D628")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x71DF54", Offset = "0x71DF54", VA = "0x71DF54")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x71E900", Offset = "0x71E900", VA = "0x71E900")]
		public RandomColor()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[DisallowMultipleComponent]
	public class RandomRotator : MonoBehaviour
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseInterval;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 SpeedMin;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 SpeedMax;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool RandomRotationAtStart;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool RandomChangeIntervalPerAxis;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 speed;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float elapsedTime;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float changeTime;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 elapsedTimeAxis;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 changeTimeAxis;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x71E994", Offset = "0x71E994", VA = "0x71E994")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x71EA4C", Offset = "0x71EA4C", VA = "0x71EA4C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x71ED4C", Offset = "0x71ED4C", VA = "0x71ED4C")]
		public RandomRotator()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[DisallowMultipleComponent]
	public class RandomScaler : MonoBehaviour
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseInterval;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 ChangeInterval;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 ScaleMin;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 ScaleMax;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool Uniform;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool RandomScaleAtStart;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform tf;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 startScale;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 endScale;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float elapsedTime;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float changeTime;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float lerpTime;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x71EDD8", Offset = "0x71EDD8", VA = "0x71EDD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x71EEC0", Offset = "0x71EEC0", VA = "0x71EEC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x71F028", Offset = "0x71F028", VA = "0x71F028")]
		public RandomScaler()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[DisallowMultipleComponent]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool dontDestroy;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string PrefabPath;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string GameObjectName;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static T instance;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object lockObj;

		[Token(Token = "0x17000133")]
		public static T Instance
		{
			[Token(Token = "0x60004F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F5")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public bool DontDestroy
		{
			[Token(Token = "0x60004F6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004F7")]
			set
			{
			}
		}

		[Token(Token = "0x60004F8")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004F9")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004FA")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60004FB")]
		public static void CreateInstance(bool searchExistingGameObject = true, bool deleteExistingInstance = false)
		{
		}

		[Token(Token = "0x60004FC")]
		public static void DeleteInstance()
		{
		}

		[Token(Token = "0x60004FD")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class SingletonHelper
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool <isQuitting>k__BackingField;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool isInitialized;

		[Token(Token = "0x17000135")]
		public static bool isQuitting
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x71F060", Offset = "0x71F060", VA = "0x71F060")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x71F0B8", Offset = "0x71F0B8", VA = "0x71F0B8")]
			set
			{
			}
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x71F114", Offset = "0x71F114", VA = "0x71F114")]
		static SingletonHelper()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x71F118", Offset = "0x71F118", VA = "0x71F118")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x71F2BC", Offset = "0x71F2BC", VA = "0x71F2BC")]
		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x71F378", Offset = "0x71F378", VA = "0x71F378")]
		private static void onSceneUnloaded(Scene scene)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x71F434", Offset = "0x71F434", VA = "0x71F434")]
		private static void onQuitting()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public abstract class XmlHelper
	{
		[Token(Token = "0x6000506")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x6000507")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x6000508")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}
	}
}
