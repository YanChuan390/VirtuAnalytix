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
			[Address(RVA = "0x9752BC", Offset = "0x9752BC", VA = "0x9752BC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x975A48", Offset = "0x975A48", VA = "0x975A48")]
			internal bool <CTContainsAny>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 flat;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x97507C", Offset = "0x97507C", VA = "0x97507C")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x97511C", Offset = "0x97511C", VA = "0x97511C")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x97512C", Offset = "0x97512C", VA = "0x97512C")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x97514C", Offset = "0x97514C", VA = "0x97514C")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x9752C4", Offset = "0x9752C4", VA = "0x9752C4")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x975318", Offset = "0x975318", VA = "0x975318")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x97536C", Offset = "0x97536C", VA = "0x97536C")]
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
		[Address(RVA = "0x97540C", Offset = "0x97540C", VA = "0x97540C")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x9755A0", Offset = "0x9755A0", VA = "0x9755A0")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x9756E0", Offset = "0x9756E0", VA = "0x9756E0")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x9758E0", Offset = "0x9758E0", VA = "0x9758E0")]
		public static bool CTHasActiveClip(this AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x975584", Offset = "0x975584", VA = "0x975584")]
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
			[Address(RVA = "0x975AD4", Offset = "0x975AD4", VA = "0x975AD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public static bool isAnyAudioPlaying
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x975B1C", Offset = "0x975B1C", VA = "0x975B1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		protected static int playCounter
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x975B64", Offset = "0x975B64", VA = "0x975B64")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x975BAC", Offset = "0x975BAC", VA = "0x975BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		protected static int audioCounter
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x975BFC", Offset = "0x975BFC", VA = "0x975BFC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x975C44", Offset = "0x975C44", VA = "0x975C44")]
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
			[Address(RVA = "0x975C94", Offset = "0x975C94", VA = "0x975C94")]
			add
			{
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x975D30", Offset = "0x975D30", VA = "0x975D30")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event PlaybackEnd OnPlaybackEnd
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x975DCC", Offset = "0x975DCC", VA = "0x975DCC")]
			add
			{
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x975E68", Offset = "0x975E68", VA = "0x975E68")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event BufferingStart OnBufferingStart
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x975F04", Offset = "0x975F04", VA = "0x975F04")]
			add
			{
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x975FA0", Offset = "0x975FA0", VA = "0x975FA0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event BufferingEnd OnBufferingEnd
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x97603C", Offset = "0x97603C", VA = "0x97603C")]
			add
			{
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x9760D8", Offset = "0x9760D8", VA = "0x9760D8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event BufferingProgressUpdate OnBufferingProgressUpdate
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x976174", Offset = "0x976174", VA = "0x976174")]
			add
			{
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x976210", Offset = "0x976210", VA = "0x976210")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event AudioStart OnAudioStart
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x9762AC", Offset = "0x9762AC", VA = "0x9762AC")]
			add
			{
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x976348", Offset = "0x976348", VA = "0x976348")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event AudioEnd OnAudioEnd
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x9763E4", Offset = "0x9763E4", VA = "0x9763E4")]
			add
			{
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x976480", Offset = "0x976480", VA = "0x976480")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event LoopPositionReached OnLoopPositionReached
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x97651C", Offset = "0x97651C", VA = "0x97651C")]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x9765B8", Offset = "0x9765B8", VA = "0x9765B8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event AudioPlayTimeUpdate OnAudioPlayTimeUpdate
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x976654", Offset = "0x976654", VA = "0x976654")]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x9766F0", Offset = "0x9766F0", VA = "0x9766F0")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x97678C", Offset = "0x97678C", VA = "0x97678C")]
			add
			{
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x976828", Offset = "0x976828", VA = "0x976828")]
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
		[Address(RVA = "0x9768C4", Offset = "0x9768C4", VA = "0x9768C4", Slot = "73")]
		public virtual void PlayOrStop()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x976904", Offset = "0x976904", VA = "0x976904", Slot = "74")]
		public virtual void PauseOrUnPause()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x976944", Offset = "0x976944", VA = "0x976944", Slot = "75")]
		public virtual void MuteOrUnMute()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x976984", Offset = "0x976984", VA = "0x976984", Slot = "76")]
		protected virtual void onPlaybackStart(Record record)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x976B50", Offset = "0x976B50", VA = "0x976B50", Slot = "77")]
		protected virtual void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x976D1C", Offset = "0x976D1C", VA = "0x976D1C", Slot = "78")]
		protected virtual void onBufferingStart(Record record)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x976E30", Offset = "0x976E30", VA = "0x976E30", Slot = "79")]
		protected virtual void onBufferingEnd(Record record)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x976F0C", Offset = "0x976F0C", VA = "0x976F0C", Slot = "80")]
		protected virtual void onBufferingProgressUpdate(Record record, float progress)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x976F28", Offset = "0x976F28", VA = "0x976F28", Slot = "81")]
		protected virtual void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x9770F4", Offset = "0x9770F4", VA = "0x9770F4", Slot = "82")]
		protected virtual void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x9772C0", Offset = "0x9772C0", VA = "0x9772C0", Slot = "83")]
		protected virtual void onLoopPositionReached(Record record, LoopPoint lp)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x977428", Offset = "0x977428", VA = "0x977428", Slot = "84")]
		protected virtual void onAudioPlayTimeUpdate(Record record, float playtime)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x977444", Offset = "0x977444", VA = "0x977444", Slot = "85")]
		protected virtual void onErrorInfo(Record record, string info)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x9775FC", Offset = "0x9775FC", VA = "0x9775FC")]
		protected BasePlayer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public class PlaybackStartEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x977604", Offset = "0x977604", VA = "0x977604")]
		public PlaybackStartEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class PlaybackEndEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x97764C", Offset = "0x97764C", VA = "0x97764C")]
		public PlaybackEndEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class AudioStartEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x977694", Offset = "0x977694", VA = "0x977694")]
		public AudioStartEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class AudioEndEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x9776DC", Offset = "0x9776DC", VA = "0x9776DC")]
		public AudioEndEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class ErrorEvent : UnityEvent<string, string, int, string>
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x977724", Offset = "0x977724", VA = "0x977724")]
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
		[Address(RVA = "0x9785EC", Offset = "0x9785EC", VA = "0x9785EC")]
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
		[Address(RVA = "0x978784", Offset = "0x978784", VA = "0x978784")]
		public RecordsChangeEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class ErrorProviderEvent : UnityEvent<string>
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x97878C", Offset = "0x97878C", VA = "0x97878C")]
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
		[Address(RVA = "0x9789AC", Offset = "0x9789AC", VA = "0x9789AC")]
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
			[Address(RVA = "0x979C3C", Offset = "0x979C3C", VA = "0x979C3C")]
			public <>c()
			{
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x979C44", Offset = "0x979C44", VA = "0x979C44")]
			internal int <get_CurrentDataCacheSize>b__14_0(KeyValuePair<string, byte[]> pair)
			{
				return default(int);
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x979C88", Offset = "0x979C88", VA = "0x979C88")]
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
			[Address(RVA = "0x978A94", Offset = "0x978A94", VA = "0x978A94")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x978AA0", Offset = "0x978AA0", VA = "0x978AA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int DataCacheSize
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x978AD4", Offset = "0x978AD4", VA = "0x978AD4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x978AE0", Offset = "0x978AE0", VA = "0x978AE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public int CurrentDataCacheSize
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x978B14", Offset = "0x978B14", VA = "0x978B14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		public int CurrentClipCacheSize
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x978C44", Offset = "0x978C44", VA = "0x978C44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x978D74", Offset = "0x978D74", VA = "0x978D74")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x978DC0", Offset = "0x978DC0", VA = "0x978DC0", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x978E20", Offset = "0x978E20", VA = "0x978E20")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x978E84", Offset = "0x978E84", VA = "0x978E84")]
		public AudioClip GetClip(string key)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x978F20", Offset = "0x978F20", VA = "0x978F20")]
		public void RemoveClip(string key)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x97908C", Offset = "0x97908C", VA = "0x97908C")]
		public void AddClip(string key, AudioClip data)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x9792A8", Offset = "0x9792A8", VA = "0x9792A8")]
		public byte[] GetData(string key)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x979344", Offset = "0x979344", VA = "0x979344")]
		public void RemoveData(string key)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x979448", Offset = "0x979448", VA = "0x979448")]
		public void AddData(string key, byte[] data)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x979630", Offset = "0x979630", VA = "0x979630")]
		public void ClearDataCache()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x979724", Offset = "0x979724", VA = "0x979724")]
		public void ClearClipCache()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x978E10", Offset = "0x978E10", VA = "0x978E10")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9799E0", Offset = "0x9799E0", VA = "0x9799E0")]
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
			[Address(RVA = "0x979CD8", Offset = "0x979CD8", VA = "0x979CD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x97A164", Offset = "0x97A164", VA = "0x97A164")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public BaseSet Set
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x97A16C", Offset = "0x97A16C", VA = "0x97A16C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x97A174", Offset = "0x97A174", VA = "0x97A174")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public RecordFilter Filter
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x97A17C", Offset = "0x97A17C", VA = "0x97A17C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x97A184", Offset = "0x97A184", VA = "0x97A184")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool PlayOnStart
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x97A18C", Offset = "0x97A18C", VA = "0x97A18C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x97A194", Offset = "0x97A194", VA = "0x97A194")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool PlayEndless
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x97A1A0", Offset = "0x97A1A0", VA = "0x97A1A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x97A1A8", Offset = "0x97A1A8", VA = "0x97A1A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool PlayRandom
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x97A1B4", Offset = "0x97A1B4", VA = "0x97A1B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x97A1BC", Offset = "0x97A1BC", VA = "0x97A1BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		protected override PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x97A1C8", Offset = "0x97A1C8", VA = "0x97A1C8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		protected override PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x97A1D0", Offset = "0x97A1D0", VA = "0x97A1D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		protected override AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x97A1D8", Offset = "0x97A1D8", VA = "0x97A1D8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		protected override AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x97A1E0", Offset = "0x97A1E0", VA = "0x97A1E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		protected override ErrorEvent onError
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x97A1E8", Offset = "0x97A1E8", VA = "0x97A1E8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public List<Record> Records
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x97C054", Offset = "0x97C054", VA = "0x97C054", Slot = "90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public List<Record> RandomRecords
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x97C120", Offset = "0x97C120", VA = "0x97C120", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public bool isReady
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x97C1EC", Offset = "0x97C1EC", VA = "0x97C1EC", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x97C278", Offset = "0x97C278", VA = "0x97C278", Slot = "93")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700003C")]
		public long TotalSize
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x97C41C", Offset = "0x97C41C", VA = "0x97C41C", Slot = "94")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700003D")]
		public int CurrentRecordIndex
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x97C5BC", Offset = "0x97C5BC", VA = "0x97C5BC", Slot = "95")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x97C63C", Offset = "0x97C63C", VA = "0x97C63C", Slot = "96")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int CurrentRandomRecordIndex
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x97C740", Offset = "0x97C740", VA = "0x97C740", Slot = "97")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x97C7C0", Offset = "0x97C7C0", VA = "0x97C7C0", Slot = "98")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override Record Record
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x984864", Offset = "0x984864", VA = "0x984864", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x984884", Offset = "0x984884", VA = "0x984884", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public override bool isLoop
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x9848AC", Offset = "0x9848AC", VA = "0x9848AC", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x9848CC", Offset = "0x9848CC", VA = "0x9848CC", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public override bool HandleFocus
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x9848F4", Offset = "0x9848F4", VA = "0x9848F4", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x984918", Offset = "0x984918", VA = "0x984918", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public override bool Caching
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x984944", Offset = "0x984944", VA = "0x984944", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x984968", Offset = "0x984968", VA = "0x984968", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public override bool Streaming
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x984994", Offset = "0x984994", VA = "0x984994", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x9849B8", Offset = "0x9849B8", VA = "0x9849B8", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public override int ChunkSize
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x9849E4", Offset = "0x9849E4", VA = "0x9849E4", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x984A08", Offset = "0x984A08", VA = "0x984A08", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public override int CacheStreamSize
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x984A34", Offset = "0x984A34", VA = "0x984A34", Slot = "21")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x984A58", Offset = "0x984A58", VA = "0x984A58", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public override int BufferSize
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x984A84", Offset = "0x984A84", VA = "0x984A84", Slot = "23")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x984AA8", Offset = "0x984AA8", VA = "0x984AA8", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override bool CaptureDataStream
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x984AD4", Offset = "0x984AD4", VA = "0x984AD4", Slot = "25")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x984AF8", Offset = "0x984AF8", VA = "0x984AF8", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public override bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x984B24", Offset = "0x984B24", VA = "0x984B24", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x984B48", Offset = "0x984B48", VA = "0x984B48", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public override bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x984B74", Offset = "0x984B74", VA = "0x984B74", Slot = "29")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x984B98", Offset = "0x984B98", VA = "0x984B98", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public override AudioSource Source
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x984BC4", Offset = "0x984BC4", VA = "0x984BC4", Slot = "31")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x984BE8", Offset = "0x984BE8", VA = "0x984BE8", Slot = "32")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public override float Position
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x984BEC", Offset = "0x984BEC", VA = "0x984BEC", Slot = "33")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x984C10", Offset = "0x984C10", VA = "0x984C10", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public override int SamplePosition
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x984C44", Offset = "0x984C44", VA = "0x984C44", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x984C68", Offset = "0x984C68", VA = "0x984C68", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public override float Elapsed
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x984C94", Offset = "0x984C94", VA = "0x984C94", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x984CB8", Offset = "0x984CB8", VA = "0x984CB8", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public override float Duration
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x984CEC", Offset = "0x984CEC", VA = "0x984CEC", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public override int Samples
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x984D10", Offset = "0x984D10", VA = "0x984D10", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public override AudioCodec Codec
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x984D34", Offset = "0x984D34", VA = "0x984D34", Slot = "41")]
			get
			{
				return default(AudioCodec);
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x984D58", Offset = "0x984D58", VA = "0x984D58", Slot = "42")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public override float BufferProgress
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x984D5C", Offset = "0x984D5C", VA = "0x984D5C", Slot = "43")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x984D80", Offset = "0x984D80", VA = "0x984D80", Slot = "44")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public override bool isPlayback
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x984D84", Offset = "0x984D84", VA = "0x984D84", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public override bool isAudioPlaying
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x984DA8", Offset = "0x984DA8", VA = "0x984DA8", Slot = "47")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x984DCC", Offset = "0x984DCC", VA = "0x984DCC", Slot = "48")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public override bool isBuffering
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x984DD0", Offset = "0x984DD0", VA = "0x984DD0", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public override bool isPaused
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x984DF4", Offset = "0x984DF4", VA = "0x984DF4", Slot = "49")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x984E18", Offset = "0x984E18", VA = "0x984E18", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public override Stream DataStream
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x984E44", Offset = "0x984E44", VA = "0x984E44", Slot = "51")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x984E68", Offset = "0x984E68", VA = "0x984E68", Slot = "52")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public override int Channels
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x984E6C", Offset = "0x984E6C", VA = "0x984E6C", Slot = "53")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000058")]
		public override int SampleRate
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x984E90", Offset = "0x984E90", VA = "0x984E90", Slot = "54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000059")]
		public override float Volume
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x984EB4", Offset = "0x984EB4", VA = "0x984EB4", Slot = "55")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x984ED8", Offset = "0x984ED8", VA = "0x984ED8", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public override float Pitch
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x984F0C", Offset = "0x984F0C", VA = "0x984F0C", Slot = "57")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x984F30", Offset = "0x984F30", VA = "0x984F30", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public override float StereoPan
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x984F64", Offset = "0x984F64", VA = "0x984F64", Slot = "59")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x984F88", Offset = "0x984F88", VA = "0x984F88", Slot = "60")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public override bool isMuted
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x984FBC", Offset = "0x984FBC", VA = "0x984FBC", Slot = "61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x984FE0", Offset = "0x984FE0", VA = "0x984FE0", Slot = "62")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public override List<Record> PlayedRecords
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x98500C", Offset = "0x98500C", VA = "0x98500C", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000B")]
		public event RecordChange OnRecordChange
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x97A1F0", Offset = "0x97A1F0", VA = "0x97A1F0")]
			add
			{
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x97A28C", Offset = "0x97A28C", VA = "0x97A28C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event FilterChange OnFilterChange
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x97A328", Offset = "0x97A328", VA = "0x97A328")]
			add
			{
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x97A3C4", Offset = "0x97A3C4", VA = "0x97A3C4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x97A460", Offset = "0x97A460", VA = "0x97A460")]
			add
			{
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x97A4FC", Offset = "0x97A4FC", VA = "0x97A4FC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x97A598", Offset = "0x97A598", VA = "0x97A598")]
			add
			{
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x97A634", Offset = "0x97A634", VA = "0x97A634")]
			remove
			{
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x97A6D0", Offset = "0x97A6D0", VA = "0x97A6D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x97ADF4", Offset = "0x97ADF4", VA = "0x97ADF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x97AECC", Offset = "0x97AECC", VA = "0x97AECC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x97B520", Offset = "0x97B520", VA = "0x97B520")]
		private void play()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x97B544", Offset = "0x97B544", VA = "0x97B544")]
		private RecordFilter getFilter([Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x97B598", Offset = "0x97B598", VA = "0x97B598")]
		private void playEndlessly()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x97B910", Offset = "0x97B910", VA = "0x97B910", Slot = "81")]
		protected override void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x97B944", Offset = "0x97B944", VA = "0x97B944", Slot = "82")]
		protected override void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x97B99C", Offset = "0x97B99C", VA = "0x97B99C", Slot = "85")]
		protected override void onErrorInfo(Record record, string info)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x97B9D4", Offset = "0x97B9D4", VA = "0x97B9D4", Slot = "86")]
		protected virtual void onRecordChange(Record newRecord)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x97BB90", Offset = "0x97BB90", VA = "0x97BB90", Slot = "87")]
		protected virtual void onFilterChange()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x97BD44", Offset = "0x97BD44", VA = "0x97BD44", Slot = "88")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x97BF08", Offset = "0x97BF08", VA = "0x97BF08", Slot = "89")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x97C8C4", Offset = "0x97C8C4", VA = "0x97C8C4", Slot = "99")]
		public void Load()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x97B684", Offset = "0x97B684", VA = "0x97B684", Slot = "100")]
		public Record Next(bool random, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x97B7CC", Offset = "0x97B7CC", VA = "0x97B7CC", Slot = "101")]
		public Record Previous(bool random, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x97C9B0", Offset = "0x97C9B0", VA = "0x97C9B0", Slot = "102")]
		public void RandomizeRecords(bool resetIndex = true)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x97CAE8", Offset = "0x97CAE8", VA = "0x97CAE8", Slot = "103")]
		public List<Record> GetRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x97CC48", Offset = "0x97CC48", VA = "0x97CC48", Slot = "104")]
		public int CountRecords([Optional] RecordFilter _filter)
		{
			return default(int);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x97CD5C", Offset = "0x97CD5C", VA = "0x97CD5C", Slot = "105")]
		public double PlaytimeRecords([Optional] RecordFilter _filter)
		{
			return default(double);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x97CF34", Offset = "0x97CF34", VA = "0x97CF34", Slot = "106")]
		public long SizeRecords([Optional] RecordFilter _filter)
		{
			return default(long);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x97D108", Offset = "0x97D108", VA = "0x97D108", Slot = "107")]
		public Record RecordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x97D1D8", Offset = "0x97D1D8", VA = "0x97D1D8", Slot = "108")]
		public Record RecordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x97D274", Offset = "0x97D274", VA = "0x97D274", Slot = "109")]
		public List<Record> RecordsByFilePath(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x97DB34", Offset = "0x97DB34", VA = "0x97DB34", Slot = "110")]
		public List<Record> RecordsByName(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x97E3D8", Offset = "0x97E3D8", VA = "0x97E3D8", Slot = "111")]
		public List<Record> RecordsByTitle(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x97EC7C", Offset = "0x97EC7C", VA = "0x97EC7C", Slot = "112")]
		public List<Record> RecordsByArtist(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x97F7D4", Offset = "0x97F7D4", VA = "0x97F7D4", Slot = "113")]
		public List<Record> RecordsByAlbum(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x980330", Offset = "0x980330", VA = "0x980330", Slot = "114")]
		public List<Record> RecordsByGenre(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x980E94", Offset = "0x980E94", VA = "0x980E94", Slot = "115")]
		public List<Record> RecordsByRating(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x981A24", Offset = "0x981A24", VA = "0x981A24", Slot = "116")]
		public List<Record> RecordsByYear(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x9825B4", Offset = "0x9825B4", VA = "0x9825B4", Slot = "117")]
		public List<Record> RecordsByDuration(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x983144", Offset = "0x983144", VA = "0x983144", Slot = "118")]
		public List<Record> RecordsByFileSize(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x983CD4", Offset = "0x983CD4", VA = "0x983CD4", Slot = "119")]
		public List<Record> RecordsByFormat(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x985030", Offset = "0x985030", VA = "0x985030", Slot = "64")]
		public override void Play()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x9852E8", Offset = "0x9852E8", VA = "0x9852E8", Slot = "65")]
		public override void Next()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x9852F4", Offset = "0x9852F4", VA = "0x9852F4", Slot = "66")]
		public override void Previous()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x985300", Offset = "0x985300", VA = "0x985300", Slot = "67")]
		public override void Pause()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x985324", Offset = "0x985324", VA = "0x985324", Slot = "68")]
		public override void UnPause()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x985348", Offset = "0x985348", VA = "0x985348", Slot = "69")]
		public override void Stop()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x985418", Offset = "0x985418", VA = "0x985418", Slot = "70")]
		public override void Restart()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x98543C", Offset = "0x98543C", VA = "0x98543C", Slot = "71")]
		public override void Mute()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x985460", Offset = "0x985460", VA = "0x985460", Slot = "72")]
		public override void UnMute()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x985484", Offset = "0x985484", VA = "0x985484")]
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
			[Address(RVA = "0x98B4AC", Offset = "0x98B4AC", VA = "0x98B4AC")]
			public <>c__DisplayClass200_0()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x98B4B4", Offset = "0x98B4B4", VA = "0x98B4B4")]
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
			[Address(RVA = "0x98B4D0", Offset = "0x98B4D0", VA = "0x98B4D0")]
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
			[Address(RVA = "0x98B4D8", Offset = "0x98B4D8", VA = "0x98B4D8")]
			public <>c__DisplayClass200_2()
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x98B4E0", Offset = "0x98B4E0", VA = "0x98B4E0")]
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
			[Address(RVA = "0x98B514", Offset = "0x98B514", VA = "0x98B514")]
			public <>c__DisplayClass200_3()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x98B51C", Offset = "0x98B51C", VA = "0x98B51C")]
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
			[Address(RVA = "0x98B550", Offset = "0x98B550", VA = "0x98B550")]
			public <>c__DisplayClass200_4()
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x98B558", Offset = "0x98B558", VA = "0x98B558")]
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
			[Address(RVA = "0x98B594", Offset = "0x98B594", VA = "0x98B594")]
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
			[Address(RVA = "0x98B59C", Offset = "0x98B59C", VA = "0x98B59C")]
			public <>c__DisplayClass200_6()
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x98B5A4", Offset = "0x98B5A4", VA = "0x98B5A4")]
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
			[Address(RVA = "0x98B5D8", Offset = "0x98B5D8", VA = "0x98B5D8")]
			public <>c__DisplayClass200_7()
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x98B5E0", Offset = "0x98B5E0", VA = "0x98B5E0")]
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
				[Address(RVA = "0x990AE4", Offset = "0x990AE4", VA = "0x990AE4", Slot = "4")]
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
				[Address(RVA = "0x990B2C", Offset = "0x990B2C", VA = "0x990B2C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x98A1DC", Offset = "0x98A1DC", VA = "0x98A1DC")]
			[DebuggerHidden]
			public <ctPlayAudio>d__200(int <>1__state)
			{
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x98B614", Offset = "0x98B614", VA = "0x98B614", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x98B788", Offset = "0x98B788", VA = "0x98B788", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x990900", Offset = "0x990900", VA = "0x990900")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x9906F0", Offset = "0x9906F0", VA = "0x9906F0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x990640", Offset = "0x990640", VA = "0x990640")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x9907A0", Offset = "0x9907A0", VA = "0x9907A0")]
			private void <>m__Finally4()
			{
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x990850", Offset = "0x990850", VA = "0x990850")]
			private void <>m__Finally5()
			{
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x990AEC", Offset = "0x990AEC", VA = "0x990AEC", Slot = "8")]
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
				[Address(RVA = "0x991B0C", Offset = "0x991B0C", VA = "0x991B0C", Slot = "4")]
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
				[Address(RVA = "0x991B54", Offset = "0x991B54", VA = "0x991B54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x98AAA0", Offset = "0x98AAA0", VA = "0x98AAA0")]
			[DebuggerHidden]
			public <unityPlayAudio>d__209(int <>1__state)
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x990B34", Offset = "0x990B34", VA = "0x990B34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x990B54", Offset = "0x990B54", VA = "0x990B54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x991A5C", Offset = "0x991A5C", VA = "0x991A5C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x991B14", Offset = "0x991B14", VA = "0x991B14", Slot = "8")]
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
			[Address(RVA = "0x979D58", Offset = "0x979D58", VA = "0x979D58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x9854A4", Offset = "0x9854A4", VA = "0x9854A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public override Record Record
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x9854FC", Offset = "0x9854FC", VA = "0x9854FC", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x985504", Offset = "0x985504", VA = "0x985504", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public bool PlayOnStart
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x98550C", Offset = "0x98550C", VA = "0x98550C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x985514", Offset = "0x985514", VA = "0x985514")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public float Delay
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x985520", Offset = "0x985520", VA = "0x985520")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x985528", Offset = "0x985528", VA = "0x985528")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public byte[] AudioData
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x985534", Offset = "0x985534", VA = "0x985534")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x98553C", Offset = "0x98553C", VA = "0x98553C")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Dictionary<string, string> RequestHeaders
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x98554C", Offset = "0x98554C", VA = "0x98554C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public override bool HandleFocus
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x985554", Offset = "0x985554", VA = "0x985554", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x98555C", Offset = "0x98555C", VA = "0x98555C", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public override bool Caching
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x985568", Offset = "0x985568", VA = "0x985568", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x985570", Offset = "0x985570", VA = "0x985570", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public override bool Streaming
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x98557C", Offset = "0x98557C", VA = "0x98557C", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x985610", Offset = "0x985610", VA = "0x985610", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public override int ChunkSize
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x98561C", Offset = "0x98561C", VA = "0x98561C", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x985628", Offset = "0x985628", VA = "0x985628", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public bool UseAutomaticCacheStreamSize
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x9856CC", Offset = "0x9856CC", VA = "0x9856CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x9856D4", Offset = "0x9856D4", VA = "0x9856D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public override int CacheStreamSize
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x9856E0", Offset = "0x9856E0", VA = "0x9856E0", Slot = "21")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x9856EC", Offset = "0x9856EC", VA = "0x9856EC", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public bool UseAutomaticBufferSize
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x985788", Offset = "0x985788", VA = "0x985788")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x985790", Offset = "0x985790", VA = "0x985790")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public override int BufferSize
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x98579C", Offset = "0x98579C", VA = "0x98579C", Slot = "23")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x9857A8", Offset = "0x9857A8", VA = "0x9857A8", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public override bool CaptureDataStream
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x985844", Offset = "0x985844", VA = "0x985844", Slot = "25")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x98584C", Offset = "0x98584C", VA = "0x98584C", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public override bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x985858", Offset = "0x985858", VA = "0x985858", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x9858E4", Offset = "0x9858E4", VA = "0x9858E4", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public override bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x9858F0", Offset = "0x9858F0", VA = "0x9858F0", Slot = "29")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x98598C", Offset = "0x98598C", VA = "0x98598C", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public bool InternalCodecsReadPCM
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x985998", Offset = "0x985998", VA = "0x985998")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x9859A0", Offset = "0x9859A0", VA = "0x9859A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public override bool isLoop
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x9859AC", Offset = "0x9859AC", VA = "0x9859AC", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x985A40", Offset = "0x985A40", VA = "0x985A40", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public override AudioSource Source
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x985AE4", Offset = "0x985AE4", VA = "0x985AE4", Slot = "31")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x985AEC", Offset = "0x985AEC", VA = "0x985AEC", Slot = "32")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public override float Position
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x985B6C", Offset = "0x985B6C", VA = "0x985B6C", Slot = "33")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x985CF8", Offset = "0x985CF8", VA = "0x985CF8", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public override int SamplePosition
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x985F8C", Offset = "0x985F8C", VA = "0x985F8C", Slot = "35")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x986118", Offset = "0x986118", VA = "0x986118", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public override float Elapsed
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x9862B4", Offset = "0x9862B4", VA = "0x9862B4", Slot = "37")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x9864F0", Offset = "0x9864F0", VA = "0x9864F0", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public override float Duration
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x98672C", Offset = "0x98672C", VA = "0x98672C", Slot = "39")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000076")]
		public override int Samples
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x986758", Offset = "0x986758", VA = "0x986758", Slot = "40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000077")]
		public override int Channels
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x9868D4", Offset = "0x9868D4", VA = "0x9868D4", Slot = "53")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000078")]
		public override int SampleRate
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x9868F4", Offset = "0x9868F4", VA = "0x9868F4", Slot = "54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000079")]
		public override AudioCodec Codec
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x986914", Offset = "0x986914", VA = "0x986914", Slot = "41")]
			get
			{
				return default(AudioCodec);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x98691C", Offset = "0x98691C", VA = "0x98691C", Slot = "42")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public override float BufferProgress
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x986924", Offset = "0x986924", VA = "0x986924", Slot = "43")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x98692C", Offset = "0x98692C", VA = "0x98692C", Slot = "44")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public override bool isPlayback
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x986934", Offset = "0x986934", VA = "0x986934", Slot = "46")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public override bool isAudioPlaying
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x98693C", Offset = "0x98693C", VA = "0x98693C", Slot = "47")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x986944", Offset = "0x986944", VA = "0x986944", Slot = "48")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override bool isBuffering
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x986950", Offset = "0x986950", VA = "0x986950", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		public override bool isPaused
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x986960", Offset = "0x986960", VA = "0x986960", Slot = "49")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x986968", Offset = "0x986968", VA = "0x986968", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public override Stream DataStream
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x9869C4", Offset = "0x9869C4", VA = "0x9869C4", Slot = "51")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x9869CC", Offset = "0x9869CC", VA = "0x9869CC", Slot = "52")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public override float Volume
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x9869DC", Offset = "0x9869DC", VA = "0x9869DC", Slot = "55")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x986A18", Offset = "0x986A18", VA = "0x986A18", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public override float Pitch
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x986A64", Offset = "0x986A64", VA = "0x986A64", Slot = "57")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x986AA0", Offset = "0x986AA0", VA = "0x986AA0", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public override float StereoPan
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x986AEC", Offset = "0x986AEC", VA = "0x986AEC", Slot = "59")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x986B28", Offset = "0x986B28", VA = "0x986B28", Slot = "60")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public override bool isMuted
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x986B74", Offset = "0x986B74", VA = "0x986B74", Slot = "61")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x986BB0", Offset = "0x986BB0", VA = "0x986BB0", Slot = "62")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public override List<Record> PlayedRecords
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x986BF0", Offset = "0x986BF0", VA = "0x986BF0", Slot = "63")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		protected override PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x986BF8", Offset = "0x986BF8", VA = "0x986BF8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		protected override PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x986C00", Offset = "0x986C00", VA = "0x986C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		protected override AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x986C08", Offset = "0x986C08", VA = "0x986C08", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		protected override AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x986C10", Offset = "0x986C10", VA = "0x986C10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		protected override ErrorEvent onError
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x986C18", Offset = "0x986C18", VA = "0x986C18", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000F")]
		public event Cached OnCached
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x986C20", Offset = "0x986C20", VA = "0x986C20")]
			add
			{
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x986CC0", Offset = "0x986CC0", VA = "0x986CC0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x986D60", Offset = "0x986D60", VA = "0x986D60")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x986F28", Offset = "0x986F28", VA = "0x986F28")]
		private void Start()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x986FBC", Offset = "0x986FBC", VA = "0x986FBC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x9872C4", Offset = "0x9872C4", VA = "0x9872C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x9872D4", Offset = "0x9872D4", VA = "0x9872D4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x987470", Offset = "0x987470", VA = "0x987470")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x987544", Offset = "0x987544", VA = "0x987544")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x987788", Offset = "0x987788", VA = "0x987788")]
		public void Play(Record _record)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x98783C", Offset = "0x98783C", VA = "0x98783C", Slot = "64")]
		public override void Play()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x9883B4", Offset = "0x9883B4", VA = "0x9883B4")]
		public void Cache(Record _record)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x98845C", Offset = "0x98845C", VA = "0x98845C")]
		public void Cache()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x9884FC", Offset = "0x9884FC", VA = "0x9884FC", Slot = "65")]
		public override void Next()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x98850C", Offset = "0x98850C", VA = "0x98850C", Slot = "66")]
		public override void Previous()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x98851C", Offset = "0x98851C", VA = "0x98851C", Slot = "67")]
		public override void Pause()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x9885B0", Offset = "0x9885B0", VA = "0x9885B0", Slot = "68")]
		public override void UnPause()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x988644", Offset = "0x988644", VA = "0x988644", Slot = "69")]
		public override void Stop()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x988714", Offset = "0x988714", VA = "0x988714", Slot = "70")]
		public override void Restart()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x988828", Offset = "0x988828", VA = "0x988828", Slot = "71")]
		public override void Mute()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x9888BC", Offset = "0x9888BC", VA = "0x9888BC", Slot = "72")]
		public override void UnMute()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x9878C4", Offset = "0x9878C4", VA = "0x9878C4")]
		private void playOrCache(bool cache = false)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x988C30", Offset = "0x988C30", VA = "0x988C30")]
		private void logUnsupportedPlatform()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x988CEC", Offset = "0x988CEC", VA = "0x988CEC")]
		private void logDataError(Exception ex)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x986300", Offset = "0x986300", VA = "0x986300")]
		private float elapsedDuration()
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x988F5C", Offset = "0x988F5C", VA = "0x988F5C")]
		private void resetReaderPosition()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x9890C4", Offset = "0x9890C4", VA = "0x9890C4")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x989348", Offset = "0x989348", VA = "0x989348")]
		private void timerTask(ref bool _playback)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x989490", Offset = "0x989490", VA = "0x989490")]
		private void readStream(ref Record _record, ref bool _playback, ref Stream _ms, ref bool _error, ref string _errorMessage, ref bool _buffered)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x98A05C", Offset = "0x98A05C", VA = "0x98A05C")]
		private static AudioType determineAudioType(AudioFormat audioFormat)
		{
			return default(AudioType);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x988BD0", Offset = "0x988BD0", VA = "0x988BD0")]
		private void ctPlay(bool cache)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x988958", Offset = "0x988958", VA = "0x988958")]
		private void ctPlayWithData(byte[] data, bool cache = false)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x98A140", Offset = "0x98A140", VA = "0x98A140")]
		private IEnumerator ctPlayAudio(byte[] data, bool cache)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x98A204", Offset = "0x98A204", VA = "0x98A204")]
		private void updateDuration()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x98A474", Offset = "0x98A474", VA = "0x98A474")]
		private void waitController(Record _record)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x98A6C0", Offset = "0x98A6C0", VA = "0x98A6C0")]
		private void readPCMNLayer(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x98A8C4", Offset = "0x98A8C4", VA = "0x98A8C4")]
		private void readPCMNAudio(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x98A8D4", Offset = "0x98A8D4", VA = "0x98A8D4")]
		private void readPCMNVorbis(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x98A7F0", Offset = "0x98A7F0", VA = "0x98A7F0")]
		private void writeDataStream(float[] pcmData)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x988C04", Offset = "0x988C04", VA = "0x988C04")]
		private void unityPlay(bool cache)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x988BDC", Offset = "0x988BDC", VA = "0x988BDC")]
		private void unityPlayWithClip(AudioClip clip, bool cache = false)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x98AA04", Offset = "0x98AA04", VA = "0x98AA04")]
		private IEnumerator unityPlayAudio(AudioClip clip, bool cache)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x98762C", Offset = "0x98762C", VA = "0x98762C")]
		protected void killWorker()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x98AAC8", Offset = "0x98AAC8", VA = "0x98AAC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x98AFD4", Offset = "0x98AFD4", VA = "0x98AFD4", Slot = "76")]
		protected override void onPlaybackStart(Record _record)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x98B06C", Offset = "0x98B06C", VA = "0x98B06C", Slot = "77")]
		protected override void onPlaybackEnd(Record _record)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x98B104", Offset = "0x98B104", VA = "0x98B104", Slot = "81")]
		protected override void onAudioStart(Record _record)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x98B1A8", Offset = "0x98B1A8", VA = "0x98B1A8", Slot = "82")]
		protected override void onAudioEnd(Record _record)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x98B24C", Offset = "0x98B24C", VA = "0x98B24C", Slot = "86")]
		protected virtual void onCached(Record _record)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x98B360", Offset = "0x98B360", VA = "0x98B360")]
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
			[Address(RVA = "0x988950", Offset = "0x988950", VA = "0x988950")]
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
		[Address(RVA = "0x991E70", Offset = "0x991E70", VA = "0x991E70")]
		static SetupProject()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x991E74", Offset = "0x991E74", VA = "0x991E74")]
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
			[Address(RVA = "0x993AC4", Offset = "0x993AC4", VA = "0x993AC4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x993ACC", Offset = "0x993ACC", VA = "0x993ACC")]
			internal double <get_TotalPlaytime>b__83_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x993C6C", Offset = "0x993C6C", VA = "0x993C6C")]
			internal long <get_TotalSize>b__85_0(Record record)
			{
				return default(long);
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x993CDC", Offset = "0x993CDC", VA = "0x993CDC")]
			internal double <PlaytimeRecords>b__95_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x993D0C", Offset = "0x993D0C", VA = "0x993D0C")]
			internal long <SizeRecords>b__96_0(Record record)
			{
				return default(long);
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x993D48", Offset = "0x993D48", VA = "0x993D48")]
			internal string <RecordsByFilePath>b__97_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x993D60", Offset = "0x993D60", VA = "0x993D60")]
			internal string <RecordsByFilePath>b__97_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x993D78", Offset = "0x993D78", VA = "0x993D78")]
			internal string <RecordsByFilePath>b__97_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x993D90", Offset = "0x993D90", VA = "0x993D90")]
			internal string <RecordsByFilePath>b__97_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x993DA8", Offset = "0x993DA8", VA = "0x993DA8")]
			internal string <RecordsByName>b__98_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x994088", Offset = "0x994088", VA = "0x994088")]
			internal string <RecordsByName>b__98_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x99409C", Offset = "0x99409C", VA = "0x99409C")]
			internal string <RecordsByName>b__98_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x9940B0", Offset = "0x9940B0", VA = "0x9940B0")]
			internal string <RecordsByName>b__98_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x9940C4", Offset = "0x9940C4", VA = "0x9940C4")]
			internal string <RecordsByTitle>b__99_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x994114", Offset = "0x994114", VA = "0x994114")]
			internal string <RecordsByTitle>b__99_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x994140", Offset = "0x994140", VA = "0x994140")]
			internal string <RecordsByTitle>b__99_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x99416C", Offset = "0x99416C", VA = "0x99416C")]
			internal string <RecordsByTitle>b__99_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x994198", Offset = "0x994198", VA = "0x994198")]
			internal string <RecordsByArtist>b__100_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x9941E8", Offset = "0x9941E8", VA = "0x9941E8")]
			internal string <RecordsByArtist>b__100_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x9941FC", Offset = "0x9941FC", VA = "0x9941FC")]
			internal string <RecordsByArtist>b__100_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000233")]
			[Address(RVA = "0x994228", Offset = "0x994228", VA = "0x994228")]
			internal string <RecordsByArtist>b__100_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x99423C", Offset = "0x99423C", VA = "0x99423C")]
			internal string <RecordsByArtist>b__100_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x994268", Offset = "0x994268", VA = "0x994268")]
			internal string <RecordsByArtist>b__100_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x99427C", Offset = "0x99427C", VA = "0x99427C")]
			internal string <RecordsByArtist>b__100_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x9942A8", Offset = "0x9942A8", VA = "0x9942A8")]
			internal string <RecordsByArtist>b__100_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x9942BC", Offset = "0x9942BC", VA = "0x9942BC")]
			internal string <RecordsByAlbum>b__101_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x99430C", Offset = "0x99430C", VA = "0x99430C")]
			internal string <RecordsByAlbum>b__101_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x994320", Offset = "0x994320", VA = "0x994320")]
			internal string <RecordsByAlbum>b__101_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x99434C", Offset = "0x99434C", VA = "0x99434C")]
			internal string <RecordsByAlbum>b__101_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x994360", Offset = "0x994360", VA = "0x994360")]
			internal string <RecordsByAlbum>b__101_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x99438C", Offset = "0x99438C", VA = "0x99438C")]
			internal string <RecordsByAlbum>b__101_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x9943A0", Offset = "0x9943A0", VA = "0x9943A0")]
			internal string <RecordsByAlbum>b__101_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x9943CC", Offset = "0x9943CC", VA = "0x9943CC")]
			internal string <RecordsByAlbum>b__101_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x9943E0", Offset = "0x9943E0", VA = "0x9943E0")]
			internal string <RecordsByGenre>b__102_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x994430", Offset = "0x994430", VA = "0x994430")]
			internal string <RecordsByGenre>b__102_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x994444", Offset = "0x994444", VA = "0x994444")]
			internal string <RecordsByGenre>b__102_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x994470", Offset = "0x994470", VA = "0x994470")]
			internal string <RecordsByGenre>b__102_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x994484", Offset = "0x994484", VA = "0x994484")]
			internal string <RecordsByGenre>b__102_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x9944B0", Offset = "0x9944B0", VA = "0x9944B0")]
			internal string <RecordsByGenre>b__102_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000246")]
			[Address(RVA = "0x9944C4", Offset = "0x9944C4", VA = "0x9944C4")]
			internal string <RecordsByGenre>b__102_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x9944F0", Offset = "0x9944F0", VA = "0x9944F0")]
			internal string <RecordsByGenre>b__102_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000248")]
			[Address(RVA = "0x994504", Offset = "0x994504", VA = "0x994504")]
			internal float <RecordsByRating>b__103_0(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0x99451C", Offset = "0x99451C", VA = "0x99451C")]
			internal string <RecordsByRating>b__103_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024A")]
			[Address(RVA = "0x994530", Offset = "0x994530", VA = "0x994530")]
			internal float <RecordsByRating>b__103_2(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0x994548", Offset = "0x994548", VA = "0x994548")]
			internal string <RecordsByRating>b__103_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0x99455C", Offset = "0x99455C", VA = "0x99455C")]
			internal float <RecordsByRating>b__103_4(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x994574", Offset = "0x994574", VA = "0x994574")]
			internal string <RecordsByRating>b__103_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x994588", Offset = "0x994588", VA = "0x994588")]
			internal float <RecordsByRating>b__103_6(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x9945A0", Offset = "0x9945A0", VA = "0x9945A0")]
			internal string <RecordsByRating>b__103_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x9945B4", Offset = "0x9945B4", VA = "0x9945B4")]
			internal int <RecordsByYear>b__104_0(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x99460C", Offset = "0x99460C", VA = "0x99460C")]
			internal string <RecordsByYear>b__104_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x994620", Offset = "0x994620", VA = "0x994620")]
			internal int <RecordsByYear>b__104_2(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x994650", Offset = "0x994650", VA = "0x994650")]
			internal string <RecordsByYear>b__104_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x994664", Offset = "0x994664", VA = "0x994664")]
			internal int <RecordsByYear>b__104_4(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x994694", Offset = "0x994694", VA = "0x994694")]
			internal string <RecordsByYear>b__104_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x9946A8", Offset = "0x9946A8", VA = "0x9946A8")]
			internal int <RecordsByYear>b__104_6(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x9946D8", Offset = "0x9946D8", VA = "0x9946D8")]
			internal string <RecordsByYear>b__104_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x9946EC", Offset = "0x9946EC", VA = "0x9946EC")]
			internal float <RecordsByDuration>b__105_0(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x994700", Offset = "0x994700", VA = "0x994700")]
			internal string <RecordsByDuration>b__105_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x994714", Offset = "0x994714", VA = "0x994714")]
			internal float <RecordsByDuration>b__105_2(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x994728", Offset = "0x994728", VA = "0x994728")]
			internal string <RecordsByDuration>b__105_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x99473C", Offset = "0x99473C", VA = "0x99473C")]
			internal float <RecordsByDuration>b__105_4(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x994750", Offset = "0x994750", VA = "0x994750")]
			internal string <RecordsByDuration>b__105_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x994764", Offset = "0x994764", VA = "0x994764")]
			internal float <RecordsByDuration>b__105_6(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x994778", Offset = "0x994778", VA = "0x994778")]
			internal string <RecordsByDuration>b__105_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x99478C", Offset = "0x99478C", VA = "0x99478C")]
			internal long <RecordsByFileSize>b__106_0(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x9947C8", Offset = "0x9947C8", VA = "0x9947C8")]
			internal string <RecordsByFileSize>b__106_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x9947DC", Offset = "0x9947DC", VA = "0x9947DC")]
			internal long <RecordsByFileSize>b__106_2(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x994818", Offset = "0x994818", VA = "0x994818")]
			internal string <RecordsByFileSize>b__106_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x99482C", Offset = "0x99482C", VA = "0x99482C")]
			internal long <RecordsByFileSize>b__106_4(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x994868", Offset = "0x994868", VA = "0x994868")]
			internal string <RecordsByFileSize>b__106_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x99487C", Offset = "0x99487C", VA = "0x99487C")]
			internal long <RecordsByFileSize>b__106_6(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x9948B8", Offset = "0x9948B8", VA = "0x9948B8")]
			internal string <RecordsByFileSize>b__106_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x9948CC", Offset = "0x9948CC", VA = "0x9948CC")]
			internal AudioFormat <RecordsByFormat>b__107_0(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x6000269")]
			[Address(RVA = "0x994C44", Offset = "0x994C44", VA = "0x994C44")]
			internal string <RecordsByFormat>b__107_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0x994C58", Offset = "0x994C58", VA = "0x994C58")]
			internal AudioFormat <RecordsByFormat>b__107_2(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0x994C6C", Offset = "0x994C6C", VA = "0x994C6C")]
			internal string <RecordsByFormat>b__107_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x994C80", Offset = "0x994C80", VA = "0x994C80")]
			internal AudioFormat <RecordsByFormat>b__107_4(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x994C94", Offset = "0x994C94", VA = "0x994C94")]
			internal string <RecordsByFormat>b__107_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x994CA8", Offset = "0x994CA8", VA = "0x994CA8")]
			internal AudioFormat <RecordsByFormat>b__107_6(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x994CBC", Offset = "0x994CBC", VA = "0x994CBC")]
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
			[Address(RVA = "0x994CD0", Offset = "0x994CD0", VA = "0x994CD0")]
			public <>c__DisplayClass114_0()
			{
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0x994CD8", Offset = "0x994CD8", VA = "0x994CD8")]
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
			[Address(RVA = "0x994D10", Offset = "0x994D10", VA = "0x994D10")]
			public <>c__DisplayClass118_0()
			{
			}

			[Token(Token = "0x6000273")]
			[Address(RVA = "0x994D18", Offset = "0x994D18", VA = "0x994D18")]
			internal bool <filterRecords>b__0(Record entry)
			{
				return default(bool);
			}

			[Token(Token = "0x6000274")]
			[Address(RVA = "0x99523C", Offset = "0x99523C", VA = "0x99523C")]
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
			[Address(RVA = "0x991EF0", Offset = "0x991EF0", VA = "0x991EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x991EF8", Offset = "0x991EF8", VA = "0x991EF8")]
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
			[Address(RVA = "0x97C2FC", Offset = "0x97C2FC", VA = "0x97C2FC", Slot = "10")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000097")]
		public long TotalSize
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x97C4A0", Offset = "0x97C4A0", VA = "0x97C4A0", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000098")]
		public int CurrentRecordIndex
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x9920F4", Offset = "0x9920F4", VA = "0x9920F4", Slot = "12")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x97C6D0", Offset = "0x97C6D0", VA = "0x97C6D0", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public int CurrentRandomRecordIndex
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x9920FC", Offset = "0x9920FC", VA = "0x9920FC", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x97C854", Offset = "0x97C854", VA = "0x97C854", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event FilterChange OnFilterChange
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x97AC14", Offset = "0x97AC14", VA = "0x97AC14")]
			add
			{
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x97B340", Offset = "0x97B340", VA = "0x97B340")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x97ACB4", Offset = "0x97ACB4", VA = "0x97ACB4")]
			add
			{
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x97B3E0", Offset = "0x97B3E0", VA = "0x97B3E0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x97AD54", Offset = "0x97AD54", VA = "0x97AD54")]
			add
			{
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x97B480", Offset = "0x97B480", VA = "0x97B480")]
			remove
			{
			}
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x991F9C", Offset = "0x991F9C", VA = "0x991F9C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x99201C", Offset = "0x99201C", VA = "0x99201C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FD")]
		public abstract void Load();

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x97CBD8", Offset = "0x97CBD8", VA = "0x97CBD8", Slot = "17")]
		public List<Record> GetRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x97CCF0", Offset = "0x97CCF0", VA = "0x97CCF0", Slot = "18")]
		public int CountRecords([Optional] RecordFilter _filter)
		{
			return default(int);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x97CE04", Offset = "0x97CE04", VA = "0x97CE04", Slot = "19")]
		public double PlaytimeRecords([Optional] RecordFilter _filter)
		{
			return default(double);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x97CFDC", Offset = "0x97CFDC", VA = "0x97CFDC", Slot = "20")]
		public long SizeRecords([Optional] RecordFilter _filter)
		{
			return default(long);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x97D364", Offset = "0x97D364", VA = "0x97D364", Slot = "21")]
		public List<Record> RecordsByFilePath(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x97DC24", Offset = "0x97DC24", VA = "0x97DC24", Slot = "22")]
		public List<Record> RecordsByName(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x97E4C8", Offset = "0x97E4C8", VA = "0x97E4C8", Slot = "23")]
		public List<Record> RecordsByTitle(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x97ED6C", Offset = "0x97ED6C", VA = "0x97ED6C", Slot = "24")]
		public List<Record> RecordsByArtist(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x97F8C4", Offset = "0x97F8C4", VA = "0x97F8C4", Slot = "25")]
		public List<Record> RecordsByAlbum(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x980420", Offset = "0x980420", VA = "0x980420", Slot = "26")]
		public List<Record> RecordsByGenre(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x980F84", Offset = "0x980F84", VA = "0x980F84", Slot = "27")]
		public List<Record> RecordsByRating(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x981B14", Offset = "0x981B14", VA = "0x981B14", Slot = "28")]
		public List<Record> RecordsByYear(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x9826A4", Offset = "0x9826A4", VA = "0x9826A4", Slot = "29")]
		public List<Record> RecordsByDuration(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x983234", Offset = "0x983234", VA = "0x983234", Slot = "30")]
		public List<Record> RecordsByFileSize(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x983DC4", Offset = "0x983DC4", VA = "0x983DC4", Slot = "31")]
		public List<Record> RecordsByFormat(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x97BD0C", Offset = "0x97BD0C", VA = "0x97BD0C", Slot = "32")]
		public Record RecordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x97D270", Offset = "0x97D270", VA = "0x97D270", Slot = "33")]
		public Record RecordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x97C950", Offset = "0x97C950", VA = "0x97C950", Slot = "34")]
		public Record Next(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x97C980", Offset = "0x97C980", VA = "0x97C980", Slot = "35")]
		public Record Previous(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x97CA44", Offset = "0x97CA44", VA = "0x97CA44", Slot = "36")]
		public void RandomizeRecords(bool resetIndex = true)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x992728", Offset = "0x992728", VA = "0x992728")]
		private Record recordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x992848", Offset = "0x992848", VA = "0x992848")]
		private Record recordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x992974", Offset = "0x992974", VA = "0x992974")]
		private Record next(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x992AA8", Offset = "0x992AA8", VA = "0x992AA8")]
		private Record previous(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x992104", Offset = "0x992104", VA = "0x992104")]
		private RecordFilter getFilter(RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x992158", Offset = "0x992158", VA = "0x992158")]
		private IEnumerable<Record> filterRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x992BCC", Offset = "0x992BCC", VA = "0x992BCC")]
		protected void clearFilters(bool clearLastFilter = true, bool clearLastRandomFilter = true)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x992D94", Offset = "0x992D94", VA = "0x992D94")]
		protected void resetFilterLists()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x9931A0", Offset = "0x9931A0", VA = "0x9931A0", Slot = "37")]
		protected virtual void onFilterChange()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x99332C", Offset = "0x99332C", VA = "0x99332C", Slot = "38")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x9934C0", Offset = "0x9934C0", VA = "0x9934C0", Slot = "39")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x993618", Offset = "0x993618", VA = "0x993618")]
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
			[Address(RVA = "0x99668C", Offset = "0x99668C", VA = "0x99668C")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x997438", Offset = "0x997438", VA = "0x997438")]
			internal IEnumerable<Record> <get_Records>b__2(BaseSet rs)
			{
				return null;
			}

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x997510", Offset = "0x997510", VA = "0x997510")]
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
			[Address(RVA = "0x9975E4", Offset = "0x9975E4", VA = "0x9975E4")]
			public <>c()
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x9975EC", Offset = "0x9975EC", VA = "0x9975EC")]
			internal bool <get_Records>b__14_1(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x997648", Offset = "0x997648", VA = "0x997648")]
			internal string <get_Records>b__14_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x997660", Offset = "0x997660", VA = "0x997660")]
			internal bool <get_RandomRecords>b__16_1(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x9976BC", Offset = "0x9976BC", VA = "0x9976BC")]
			internal string <get_RandomRecords>b__16_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x9976D4", Offset = "0x9976D4", VA = "0x9976D4")]
			internal bool <get_isReady>b__18_0(BaseSet provider)
			{
				return default(bool);
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x99775C", Offset = "0x99775C", VA = "0x99775C")]
			internal bool <Load>b__21_0(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x9977E0", Offset = "0x9977E0", VA = "0x9977E0")]
			internal bool <register>b__23_0(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000290")]
			[Address(RVA = "0x99783C", Offset = "0x99783C", VA = "0x99783C")]
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
			[Address(RVA = "0x996D38", Offset = "0x996D38", VA = "0x996D38")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x997898", Offset = "0x997898", VA = "0x997898")]
			internal IEnumerable<Record> <get_RandomRecords>b__2(BaseSet rs)
			{
				return null;
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x997970", Offset = "0x997970", VA = "0x997970")]
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
			[Address(RVA = "0x995604", Offset = "0x995604", VA = "0x995604")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x99560C", Offset = "0x99560C", VA = "0x99560C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x995FD0", Offset = "0x995FD0", VA = "0x995FD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		protected override FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x995FD8", Offset = "0x995FD8", VA = "0x995FD8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x995FE0", Offset = "0x995FE0", VA = "0x995FE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public override List<Record> Records
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x995FE8", Offset = "0x995FE8", VA = "0x995FE8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public override List<Record> RandomRecords
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x996694", Offset = "0x996694", VA = "0x996694", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public override bool isReady
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x996D40", Offset = "0x996D40", VA = "0x996D40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x996E5C", Offset = "0x996E5C", VA = "0x996E5C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x996E60", Offset = "0x996E60", VA = "0x996E60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x996E64", Offset = "0x996E64", VA = "0x996E64", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x997218", Offset = "0x997218", VA = "0x997218", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x995B08", Offset = "0x995B08", VA = "0x995B08")]
		private void register()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x995640", Offset = "0x995640", VA = "0x995640")]
		private void unregister()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x997430", Offset = "0x997430", VA = "0x997430")]
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
			[Address(RVA = "0x99899C", Offset = "0x99899C", VA = "0x99899C")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x9999BC", Offset = "0x9999BC", VA = "0x9999BC")]
			internal IEnumerable<Record> <get_Records>b__2(BaseRecordProvider rp)
			{
				return null;
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x999A84", Offset = "0x999A84", VA = "0x999A84")]
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
			[Address(RVA = "0x999B58", Offset = "0x999B58", VA = "0x999B58")]
			public <>c()
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x999B60", Offset = "0x999B60", VA = "0x999B60")]
			internal bool <get_Records>b__14_1(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x999BE0", Offset = "0x999BE0", VA = "0x999BE0")]
			internal string <get_Records>b__14_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x999BF8", Offset = "0x999BF8", VA = "0x999BF8")]
			internal bool <get_RandomRecords>b__16_1(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x999C78", Offset = "0x999C78", VA = "0x999C78")]
			internal string <get_RandomRecords>b__16_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x999C90", Offset = "0x999C90", VA = "0x999C90")]
			internal bool <get_isReady>b__18_0(BaseRecordProvider provider)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x999D10", Offset = "0x999D10", VA = "0x999D10")]
			internal bool <Load>b__21_0(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x999D94", Offset = "0x999D94", VA = "0x999D94")]
			internal bool <register>b__23_0(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x999DF0", Offset = "0x999DF0", VA = "0x999DF0")]
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
			[Address(RVA = "0x999048", Offset = "0x999048", VA = "0x999048")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x999E4C", Offset = "0x999E4C", VA = "0x999E4C")]
			internal IEnumerable<Record> <get_RandomRecords>b__2(BaseRecordProvider rp)
			{
				return null;
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x999F14", Offset = "0x999F14", VA = "0x999F14")]
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
			[Address(RVA = "0x9979D4", Offset = "0x9979D4", VA = "0x9979D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x9979DC", Offset = "0x9979DC", VA = "0x9979DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x9982E0", Offset = "0x9982E0", VA = "0x9982E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		protected override FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x9982E8", Offset = "0x9982E8", VA = "0x9982E8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x9982F0", Offset = "0x9982F0", VA = "0x9982F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public override List<Record> Records
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x9982F8", Offset = "0x9982F8", VA = "0x9982F8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public override List<Record> RandomRecords
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x9989A4", Offset = "0x9989A4", VA = "0x9989A4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public override bool isReady
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x999050", Offset = "0x999050", VA = "0x999050", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x99916C", Offset = "0x99916C", VA = "0x99916C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x999170", Offset = "0x999170", VA = "0x999170")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x999174", Offset = "0x999174", VA = "0x999174", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x99952C", Offset = "0x99952C", VA = "0x99952C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x997E78", Offset = "0x997E78", VA = "0x997E78")]
		private void register()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x997A10", Offset = "0x997A10", VA = "0x997A10")]
		private void unregister()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x9999B4", Offset = "0x9999B4", VA = "0x9999B4")]
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
			[Address(RVA = "0x99B170", Offset = "0x99B170", VA = "0x99B170")]
			public <>c()
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x99B178", Offset = "0x99B178", VA = "0x99B178")]
			internal double <get_TotalPlaytime>b__48_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x99B1A8", Offset = "0x99B1A8", VA = "0x99B1A8")]
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
			[Address(RVA = "0x999F78", Offset = "0x999F78", VA = "0x999F78", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x999F80", Offset = "0x999F80", VA = "0x999F80", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool ReadFileSize
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x999F8C", Offset = "0x999F8C", VA = "0x999F8C", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x999F94", Offset = "0x999F94", VA = "0x999F94", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public bool AutoUpdate
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x999FA0", Offset = "0x999FA0", VA = "0x999FA0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x999FA8", Offset = "0x999FA8", VA = "0x999FA8", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool AutoUpdateInEditor
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x999FB4", Offset = "0x999FB4", VA = "0x999FB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x999FBC", Offset = "0x999FBC", VA = "0x999FBC")]
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
			[Address(RVA = "0x99A0D8", Offset = "0x99A0D8", VA = "0x99A0D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x99A0E0", Offset = "0x99A0E0", VA = "0x99A0E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public bool isReadFileSize
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x99A0EC", Offset = "0x99A0EC", VA = "0x99A0EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x99A0F4", Offset = "0x99A0F4", VA = "0x99A0F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool isAutoUpdate
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x99A100", Offset = "0x99A100", VA = "0x99A100")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x99A108", Offset = "0x99A108", VA = "0x99A108")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public bool isReady
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x99A114", Offset = "0x99A114", VA = "0x99A114", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x99A11C", Offset = "0x99A11C", VA = "0x99A11C", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public List<Record> Records
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x99A128", Offset = "0x99A128", VA = "0x99A128", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x99A130", Offset = "0x99A130", VA = "0x99A130")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x99A138", Offset = "0x99A138", VA = "0x99A138", Slot = "17")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000B4")]
		public long TotalSize
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x99A240", Offset = "0x99A240", VA = "0x99A240", Slot = "18")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x14000013")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x999744", Offset = "0x999744", VA = "0x999744")]
			add
			{
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x99987C", Offset = "0x99987C", VA = "0x99987C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x9997E0", Offset = "0x9997E0", VA = "0x9997E0")]
			add
			{
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x999918", Offset = "0x999918", VA = "0x999918")]
			remove
			{
			}
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x999FC8", Offset = "0x999FC8", VA = "0x999FC8", Slot = "12")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x99A030", Offset = "0x99A030", VA = "0x99A030", Slot = "13")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x99A344", Offset = "0x99A344", VA = "0x99A344", Slot = "19")]
		public virtual void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x60002D0")]
		protected abstract void load();

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x99A42C", Offset = "0x99A42C", VA = "0x99A42C")]
		protected static string determineAudioFormatExtension(AudioFormat audioFormat = AudioFormat.MP3)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x99A5A0", Offset = "0x99A5A0", VA = "0x99A5A0")]
		protected void fillRecords(string[] list)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x99AB34", Offset = "0x99AB34", VA = "0x99AB34", Slot = "21")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x99AC54", Offset = "0x99AC54", VA = "0x99AC54", Slot = "22")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x99ADAC", Offset = "0x99ADAC", VA = "0x99ADAC")]
		protected BaseRecordProvider()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x99AE3C", Offset = "0x99AE3C", VA = "0x99AE3C")]
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
			[Address(RVA = "0x99B1E4", Offset = "0x99B1E4", VA = "0x99B1E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x99B1EC", Offset = "0x99B1EC", VA = "0x99B1EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public bool hasDBFile
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x99B290", Offset = "0x99B290", VA = "0x99B290", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public string DBFilePath
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x99B2A4", Offset = "0x99B2A4", VA = "0x99B2A4", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x99B1F8", Offset = "0x99B1F8", VA = "0x99B1F8", Slot = "23")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x99B318", Offset = "0x99B318", VA = "0x99B318", Slot = "19")]
		public override void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x99B46C", Offset = "0x99B46C", VA = "0x99B46C", Slot = "26")]
		public virtual void SaveDB(string filePath = "")
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x99B4E4", Offset = "0x99B4E4", VA = "0x99B4E4", Slot = "27")]
		public virtual void LoadDB(string filePath = "")
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x99B58C", Offset = "0x99B58C", VA = "0x99B58C", Slot = "28")]
		public void DeleteDB()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x99B450", Offset = "0x99B450", VA = "0x99B450")]
		private void loadFile()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x99B4F4", Offset = "0x99B4F4", VA = "0x99B4F4")]
		private void loadFile(string filePath)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x99B6D0", Offset = "0x99B6D0", VA = "0x99B6D0")]
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
			[Address(RVA = "0x99BDE0", Offset = "0x99BDE0", VA = "0x99BDE0")]
			public <>c()
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x99BDE8", Offset = "0x99BDE8", VA = "0x99BDE8")]
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
			[Address(RVA = "0x99B6DC", Offset = "0x99B6DC", VA = "0x99B6DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x99B6E4", Offset = "0x99B6E4", VA = "0x99B6E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x99B7B0", Offset = "0x99B7B0", VA = "0x99B7B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x99B7B8", Offset = "0x99B7B8", VA = "0x99B7B8", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x99B7C0", Offset = "0x99B7C0", VA = "0x99B7C0", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x99BCEC", Offset = "0x99BCEC", VA = "0x99BCEC")]
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
			[Address(RVA = "0x99C4EC", Offset = "0x99C4EC", VA = "0x99C4EC")]
			public <>c()
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x99C4F4", Offset = "0x99C4F4", VA = "0x99C4F4")]
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
			[Address(RVA = "0x99BE44", Offset = "0x99BE44", VA = "0x99BE44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x99BE4C", Offset = "0x99BE4C", VA = "0x99BE4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x99BF18", Offset = "0x99BF18", VA = "0x99BF18", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x99BF20", Offset = "0x99BF20", VA = "0x99BF20", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x99BF28", Offset = "0x99BF28", VA = "0x99BF28", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x99C3F8", Offset = "0x99C3F8", VA = "0x99C3F8")]
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
				[Address(RVA = "0x99E0D0", Offset = "0x99E0D0", VA = "0x99E0D0", Slot = "4")]
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
				[Address(RVA = "0x99E118", Offset = "0x99E118", VA = "0x99E118", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x99D13C", Offset = "0x99D13C", VA = "0x99D13C")]
			[DebuggerHidden]
			public <scan>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x99DED0", Offset = "0x99DED0", VA = "0x99DED0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x99DED4", Offset = "0x99DED4", VA = "0x99DED4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x99E0D8", Offset = "0x99E0D8", VA = "0x99E0D8", Slot = "8")]
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
				[Address(RVA = "0x99E98C", Offset = "0x99E98C", VA = "0x99E98C", Slot = "4")]
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
				[Address(RVA = "0x99E9D4", Offset = "0x99E9D4", VA = "0x99E9D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x99D164", Offset = "0x99D164", VA = "0x99D164")]
			[DebuggerHidden]
			public <scanWindows>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x99E120", Offset = "0x99E120", VA = "0x99E120", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x99E13C", Offset = "0x99E13C", VA = "0x99E13C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x99E8DC", Offset = "0x99E8DC", VA = "0x99E8DC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x99E994", Offset = "0x99E994", VA = "0x99E994", Slot = "8")]
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
				[Address(RVA = "0x99F63C", Offset = "0x99F63C", VA = "0x99F63C", Slot = "4")]
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
				[Address(RVA = "0x99F684", Offset = "0x99F684", VA = "0x99F684", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x99D18C", Offset = "0x99D18C", VA = "0x99D18C")]
			[DebuggerHidden]
			public <scanUnix>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x99E9DC", Offset = "0x99E9DC", VA = "0x99E9DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x99E9F8", Offset = "0x99E9F8", VA = "0x99E9F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x99F58C", Offset = "0x99F58C", VA = "0x99F58C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x99F644", Offset = "0x99F644", VA = "0x99F644", Slot = "8")]
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
			[Address(RVA = "0x99C514", Offset = "0x99C514", VA = "0x99C514")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x99C51C", Offset = "0x99C51C", VA = "0x99C51C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public string Path
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x99C528", Offset = "0x99C528", VA = "0x99C528")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x99C530", Offset = "0x99C530", VA = "0x99C530")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public AudioFormat Format
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x99C664", Offset = "0x99C664", VA = "0x99C664")]
			get
			{
				return default(AudioFormat);
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x99C66C", Offset = "0x99C66C", VA = "0x99C66C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public bool Recursive
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x99C744", Offset = "0x99C744", VA = "0x99C744")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x99C74C", Offset = "0x99C74C", VA = "0x99C74C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public bool SlowAndSave
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x99C758", Offset = "0x99C758", VA = "0x99C758")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x99C760", Offset = "0x99C760", VA = "0x99C760")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public bool WatchDog
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x99C76C", Offset = "0x99C76C", VA = "0x99C76C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x99C774", Offset = "0x99C774", VA = "0x99C774")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x99C780", Offset = "0x99C780", VA = "0x99C780", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x99C788", Offset = "0x99C788", VA = "0x99C788", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public string Extension
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x99C790", Offset = "0x99C790", VA = "0x99C790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x99C798", Offset = "0x99C798", VA = "0x99C798", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x99CA84", Offset = "0x99CA84", VA = "0x99CA84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x99CBF8", Offset = "0x99CBF8", VA = "0x99CBF8")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x99CC98", Offset = "0x99CC98", VA = "0x99CC98", Slot = "19")]
		public override void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x99CD5C", Offset = "0x99CD5C", VA = "0x99CD5C", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x99C8A8", Offset = "0x99C8A8", VA = "0x99C8A8")]
		private void setMusicLibrary()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x99D0C8", Offset = "0x99D0C8", VA = "0x99D0C8")]
		private IEnumerator scan()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x99CFE0", Offset = "0x99CFE0", VA = "0x99CFE0")]
		private IEnumerator scanWindows()
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x99D054", Offset = "0x99D054", VA = "0x99D054")]
		private IEnumerator scanUnix()
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x99D1B4", Offset = "0x99D1B4", VA = "0x99D1B4")]
		private void watch()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x99D40C", Offset = "0x99D40C", VA = "0x99D40C")]
		private void onDeleted(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x99D550", Offset = "0x99D550", VA = "0x99D550")]
		private void onCreated(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x99D694", Offset = "0x99D694", VA = "0x99D694")]
		private void onRenamed(object source, RenamedEventArgs e)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x99D7D8", Offset = "0x99D7D8", VA = "0x99D7D8")]
		private void onChanged(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x99D91C", Offset = "0x99D91C", VA = "0x99D91C")]
		private void scanOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x99DA80", Offset = "0x99DA80", VA = "0x99DA80")]
		private void readPath()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x99DEB8", Offset = "0x99DEB8", VA = "0x99DEB8")]
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
				[Address(RVA = "0x9A16F0", Offset = "0x9A16F0", VA = "0x9A16F0", Slot = "4")]
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
				[Address(RVA = "0x9A1738", Offset = "0x9A1738", VA = "0x9A1738", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x99FAAC", Offset = "0x99FAAC", VA = "0x99FAAC")]
			[DebuggerHidden]
			public <readFileM3U>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x9A0F34", Offset = "0x9A0F34", VA = "0x9A0F34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x9A0F50", Offset = "0x9A0F50", VA = "0x9A0F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x9A1640", Offset = "0x9A1640", VA = "0x9A1640")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x9A16F8", Offset = "0x9A16F8", VA = "0x9A16F8", Slot = "8")]
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
				[Address(RVA = "0x9A1EFC", Offset = "0x9A1EFC", VA = "0x9A1EFC", Slot = "4")]
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
				[Address(RVA = "0x9A1F44", Offset = "0x9A1F44", VA = "0x9A1F44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x9A0450", Offset = "0x9A0450", VA = "0x9A0450")]
			[DebuggerHidden]
			public <readFilePLS>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0x9A1740", Offset = "0x9A1740", VA = "0x9A1740", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x9A175C", Offset = "0x9A175C", VA = "0x9A175C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0x9A1E4C", Offset = "0x9A1E4C", VA = "0x9A1E4C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x9A1F04", Offset = "0x9A1F04", VA = "0x9A1F04", Slot = "8")]
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
			[Address(RVA = "0x99F68C", Offset = "0x99F68C", VA = "0x99F68C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x99F694", Offset = "0x99F694", VA = "0x99F694")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x99F760", Offset = "0x99F760", VA = "0x99F760", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x99F768", Offset = "0x99F768", VA = "0x99F768", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public PlayListFormat Format
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x99F770", Offset = "0x99F770", VA = "0x99F770")]
			get
			{
				return default(PlayListFormat);
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x99F89C", Offset = "0x99F89C", VA = "0x99F89C", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x99F95C", Offset = "0x99F95C", VA = "0x99F95C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x99F980", Offset = "0x99F980", VA = "0x99F980", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x99FA38", Offset = "0x99FA38", VA = "0x99FA38")]
		private IEnumerator readFileM3U()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x99FAD4", Offset = "0x99FAD4", VA = "0x99FAD4")]
		private void parseM3U(string text)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x99F9C4", Offset = "0x99F9C4", VA = "0x99F9C4")]
		private IEnumerator readFilePLS()
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x9A0478", Offset = "0x9A0478", VA = "0x9A0478")]
		private void parsePLS(string text)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x9A0E30", Offset = "0x9A0E30", VA = "0x9A0E30")]
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
			[Address(RVA = "0x9A1F4C", Offset = "0x9A1F4C", VA = "0x9A1F4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x9A1F54", Offset = "0x9A1F54", VA = "0x9A1F54")]
			set
			{
			}
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x9A1F70", Offset = "0x9A1F70", VA = "0x9A1F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x9A21CC", Offset = "0x9A21CC", VA = "0x9A21CC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x9A2348", Offset = "0x9A2348", VA = "0x9A2348", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x9A2350", Offset = "0x9A2350", VA = "0x9A2350")]
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
			[Address(RVA = "0x9A2370", Offset = "0x9A2370", VA = "0x9A2370")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x9A2378", Offset = "0x9A2378", VA = "0x9A2378")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public float EndPosition
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x9A2398", Offset = "0x9A2398", VA = "0x9A2398")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x9A23A0", Offset = "0x9A23A0", VA = "0x9A23A0")]
			set
			{
			}
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x9A23C0", Offset = "0x9A23C0", VA = "0x9A23C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x9A2710", Offset = "0x9A2710", VA = "0x9A2710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x9A28E4", Offset = "0x9A28E4", VA = "0x9A28E4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x9A28EC", Offset = "0x9A28EC", VA = "0x9A28EC")]
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
		[Address(RVA = "0x9A290C", Offset = "0x9A290C", VA = "0x9A290C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x9A2AE8", Offset = "0x9A2AE8", VA = "0x9A2AE8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x9A2C08", Offset = "0x9A2C08", VA = "0x9A2C08", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x9A03F8", Offset = "0x9A03F8", VA = "0x9A03F8")]
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
		[Address(RVA = "0x9A2C64", Offset = "0x9A2C64", VA = "0x9A2C64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x9A2E40", Offset = "0x9A2E40", VA = "0x9A2E40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x9A2F60", Offset = "0x9A2F60", VA = "0x9A2F60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x9A0DD8", Offset = "0x9A0DD8", VA = "0x9A0DD8")]
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
				[Address(RVA = "0x9A5848", Offset = "0x9A5848", VA = "0x9A5848", Slot = "4")]
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
				[Address(RVA = "0x9A5890", Offset = "0x9A5890", VA = "0x9A5890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000385")]
			[Address(RVA = "0x9A4B78", Offset = "0x9A4B78", VA = "0x9A4B78")]
			[DebuggerHidden]
			public <readSize>d__101(int <>1__state)
			{
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x9A5508", Offset = "0x9A5508", VA = "0x9A5508", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000387")]
			[Address(RVA = "0x9A5524", Offset = "0x9A5524", VA = "0x9A5524", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x9A5798", Offset = "0x9A5798", VA = "0x9A5798")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x9A5850", Offset = "0x9A5850", VA = "0x9A5850", Slot = "8")]
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
			[Address(RVA = "0x9A2FBC", Offset = "0x9A2FBC", VA = "0x9A2FBC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x9A2FC4", Offset = "0x9A2FC4", VA = "0x9A2FC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public bool isFileSizeLoaded
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x9A2FD0", Offset = "0x9A2FD0", VA = "0x9A2FD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x9A2FD8", Offset = "0x9A2FD8", VA = "0x9A2FD8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public bool isLocalFile
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x9A2FE4", Offset = "0x9A2FE4", VA = "0x9A2FE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DB")]
		public string Name
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x993DBC", Offset = "0x993DBC", VA = "0x993DBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public string Title
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x9940F0", Offset = "0x9940F0", VA = "0x9940F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public string Artist
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x9941C4", Offset = "0x9941C4", VA = "0x9941C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public string Album
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x9942E8", Offset = "0x9942E8", VA = "0x9942E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		public float Duration
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x993AFC", Offset = "0x993AFC", VA = "0x993AFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x9A36C0", Offset = "0x9A36C0", VA = "0x9A36C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public string Genre
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x99440C", Offset = "0x99440C", VA = "0x99440C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		public int Year
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x9945E4", Offset = "0x9945E4", VA = "0x9945E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E2")]
		public string Url
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x9A36CC", Offset = "0x9A36CC", VA = "0x9A36CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		public long FileSize
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x993CA8", Offset = "0x993CA8", VA = "0x993CA8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000E4")]
		public bool HasTag
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x9A3CE8", Offset = "0x9A3CE8", VA = "0x9A3CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E5")]
		public Tag Tag
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x9A3D74", Offset = "0x9A3D74", VA = "0x9A3D74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		public AudioFormat Format
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x9948E0", Offset = "0x9948E0", VA = "0x9948E0")]
			get
			{
				return default(AudioFormat);
			}
		}

		[Token(Token = "0x170000E7")]
		public string SpotifyUrl
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x9A4958", Offset = "0x9A4958", VA = "0x9A4958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		public int Bitrate
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x9950E0", Offset = "0x9950E0", VA = "0x9950E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x9A4ACC", Offset = "0x9A4ACC", VA = "0x9A4ACC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		private bool hasID3Tag
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x9A3D2C", Offset = "0x9A3D2C", VA = "0x9A3D2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EA")]
		private bool hasXiphComment
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x9A3D44", Offset = "0x9A3D44", VA = "0x9A3D44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EB")]
		private bool hasAiffTag
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x9A3D5C", Offset = "0x9A3D5C", VA = "0x9A3D5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x9A4AD4", Offset = "0x9A4AD4", VA = "0x9A4AD4")]
		public Record()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x99AEC0", Offset = "0x99AEC0", VA = "0x99AEC0")]
		public Record(string filePath, bool loadTag = false, bool readFileSize = false)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x9A0400", Offset = "0x9A0400", VA = "0x9A0400")]
		public Record(M3UEntry entry, bool loadTag, bool readFileSize)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x9A0DE0", Offset = "0x9A0DE0", VA = "0x9A0DE0")]
		public Record(PLSEntry entry, bool loadTag, bool readFileSize)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x99BCA4", Offset = "0x99BCA4", VA = "0x99BCA4")]
		public Record(AudioClip clip)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x9A3060", Offset = "0x9A3060", VA = "0x9A3060")]
		private void parseInfo()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x9A497C", Offset = "0x9A497C", VA = "0x9A497C")]
		private void parseSpotifyUrl()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x9A373C", Offset = "0x9A373C", VA = "0x9A373C")]
		private void readFileSize()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x9A4B04", Offset = "0x9A4B04", VA = "0x9A4B04")]
		private IEnumerator readSize()
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x9A3DC0", Offset = "0x9A3DC0", VA = "0x9A3DC0")]
		private void loadTag()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x9A4BA0", Offset = "0x9A4BA0", VA = "0x9A4BA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x9A4CE0", Offset = "0x9A4CE0", VA = "0x9A4CE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x9A4DD4", Offset = "0x9A4DD4", VA = "0x9A4DD4", Slot = "3")]
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
			[Address(RVA = "0x9A5898", Offset = "0x9A5898", VA = "0x9A5898")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x9A58A0", Offset = "0x9A58A0", VA = "0x9A58A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float RatingMax
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x9A58C0", Offset = "0x9A58C0", VA = "0x9A58C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x9A58C8", Offset = "0x9A58C8", VA = "0x9A58C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public int YearMin
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x9A58E8", Offset = "0x9A58E8", VA = "0x9A58E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x9A58F0", Offset = "0x9A58F0", VA = "0x9A58F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public int YearMax
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x9A5908", Offset = "0x9A5908", VA = "0x9A5908")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x9A5910", Offset = "0x9A5910", VA = "0x9A5910")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public int BitrateMin
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x9A592C", Offset = "0x9A592C", VA = "0x9A592C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x9A5934", Offset = "0x9A5934", VA = "0x9A5934")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public int BitrateMax
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x9A5954", Offset = "0x9A5954", VA = "0x9A5954")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x9A595C", Offset = "0x9A595C", VA = "0x9A595C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool isFiltering
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x9A597C", Offset = "0x9A597C", VA = "0x9A597C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x9A5A60", Offset = "0x9A5A60", VA = "0x9A5A60")]
		public RecordFilter()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x9A5B6C", Offset = "0x9A5B6C", VA = "0x9A5B6C")]
		public RecordFilter(RecordFilter filter)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x9A5DE8", Offset = "0x9A5DE8", VA = "0x9A5DE8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x9A6018", Offset = "0x9A6018", VA = "0x9A6018", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x9A6020", Offset = "0x9A6020", VA = "0x9A6020", Slot = "3")]
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
			[Address(RVA = "0x9A74B8", Offset = "0x9A74B8", VA = "0x9A74B8")]
			public <>c()
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x9A74C0", Offset = "0x9A74C0", VA = "0x9A74C0")]
			internal bool <searchBpm>b__18_0(BpmMatchData x)
			{
				return default(bool);
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x9A7610", Offset = "0x9A7610", VA = "0x9A7610")]
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
			[Address(RVA = "0x9A6558", Offset = "0x9A6558", VA = "0x9A6558")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x9A6560", Offset = "0x9A6560", VA = "0x9A6560")]
			private set
			{
			}
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9A6568", Offset = "0x9A6568", VA = "0x9A6568")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x9A675C", Offset = "0x9A675C", VA = "0x9A675C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x9A6830", Offset = "0x9A6830", VA = "0x9A6830")]
		public int AnalyzeBPM()
		{
			return default(int);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x9A698C", Offset = "0x9A698C", VA = "0x9A698C")]
		public static int AnalyzeBPM(float[] data, int frequency = 44100, int channels = 2, int sampleSplit = 100)
		{
			return default(int);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x9A7150", Offset = "0x9A7150", VA = "0x9A7150")]
		public static int AnalyzeBPM(AudioClip clip, int sampleSplit = 100)
		{
			return default(int);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x9A68FC", Offset = "0x9A68FC", VA = "0x9A68FC")]
		private static float[] getData(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x9A6B88", Offset = "0x9A6B88", VA = "0x9A6B88")]
		private static float[] createVolumeArray(float[] allSamples, int frequency, int channels, int splitFrameSize)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x9A6D50", Offset = "0x9A6D50", VA = "0x9A6D50")]
		private static int searchBpm(float[] volumeArr, int frequency, int splitFrameSize)
		{
			return default(int);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x9A72B4", Offset = "0x9A72B4", VA = "0x9A72B4")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x9A73C4", Offset = "0x9A73C4", VA = "0x9A73C4")]
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
		[Address(RVA = "0x9A761C", Offset = "0x9A761C", VA = "0x9A761C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x9A767C", Offset = "0x9A767C", VA = "0x9A767C")]
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
			[Address(RVA = "0x9A7684", Offset = "0x9A7684", VA = "0x9A7684")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x9A77B4", Offset = "0x9A77B4", VA = "0x9A77B4")]
			set
			{
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x9A7988", Offset = "0x9A7988", VA = "0x9A7988")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x9A7AF0", Offset = "0x9A7AF0", VA = "0x9A7AF0")]
		public CrossFader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class EventPositionReachedEvent : UnityEvent
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x9A7B00", Offset = "0x9A7B00", VA = "0x9A7B00")]
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
			[Address(RVA = "0x9A7B08", Offset = "0x9A7B08", VA = "0x9A7B08")]
			get
			{
				return default(PointMode);
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x9A7B20", Offset = "0x9A7B20", VA = "0x9A7B20")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public float StartTimePosition
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x9A7B30", Offset = "0x9A7B30", VA = "0x9A7B30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x9A7B48", Offset = "0x9A7B48", VA = "0x9A7B48")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public float EventPosition
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x9A7B5C", Offset = "0x9A7B5C", VA = "0x9A7B5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x9A7B74", Offset = "0x9A7B74", VA = "0x9A7B74")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public int EventSamplePosition
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x9A7B9C", Offset = "0x9A7B9C", VA = "0x9A7B9C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x9A7BB4", Offset = "0x9A7BB4", VA = "0x9A7BB4")]
			set
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event EventPositionReached OnEventPositionReached
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x9A7C18", Offset = "0x9A7C18", VA = "0x9A7C18")]
			add
			{
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x9A7CB4", Offset = "0x9A7CB4", VA = "0x9A7CB4")]
			remove
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x9A7D50", Offset = "0x9A7D50", VA = "0x9A7D50")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x9A7E08", Offset = "0x9A7E08", VA = "0x9A7E08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x9A80E8", Offset = "0x9A80E8", VA = "0x9A80E8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x9A7F2C", Offset = "0x9A7F2C", VA = "0x9A7F2C")]
		private void onEventPositionReached(Record record, EventPoint ep)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x9A8138", Offset = "0x9A8138", VA = "0x9A8138")]
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
			[Address(RVA = "0x9A8294", Offset = "0x9A8294", VA = "0x9A8294")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x9A829C", Offset = "0x9A829C", VA = "0x9A829C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public AudioClip LastAudioClip
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x9A86F8", Offset = "0x9A86F8", VA = "0x9A86F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x9A8700", Offset = "0x9A8700", VA = "0x9A8700")]
			private set
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event LoadClipStart OnLoadClipStart
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x9A8708", Offset = "0x9A8708", VA = "0x9A8708")]
			add
			{
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x9A87A4", Offset = "0x9A87A4", VA = "0x9A87A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event LoadClipEnd OnLoadClipEnd
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x9A8840", Offset = "0x9A8840", VA = "0x9A8840")]
			add
			{
			}
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x9A88DC", Offset = "0x9A88DC", VA = "0x9A88DC")]
			remove
			{
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x9A8978", Offset = "0x9A8978", VA = "0x9A8978")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x9A8AB4", Offset = "0x9A8AB4", VA = "0x9A8AB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x9A8AB8", Offset = "0x9A8AB8", VA = "0x9A8AB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x9A8ABC", Offset = "0x9A8ABC", VA = "0x9A8ABC")]
		public void LoadClip(Record record)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x9A8B8C", Offset = "0x9A8B8C", VA = "0x9A8B8C")]
		public void LoadClip(string filePath)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x9A8558", Offset = "0x9A8558", VA = "0x9A8558")]
		private void register()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x9A83B8", Offset = "0x9A83B8", VA = "0x9A83B8")]
		private void unregister()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x9A8C04", Offset = "0x9A8C04", VA = "0x9A8C04")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x9A8E40", Offset = "0x9A8E40", VA = "0x9A8E40")]
		private void onPlaybackStart(Record record)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x9A8E64", Offset = "0x9A8E64", VA = "0x9A8E64")]
		private void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x9A8E6C", Offset = "0x9A8E6C", VA = "0x9A8E6C")]
		public LoadAudioClip()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class LoopPositionReachedEvent : UnityEvent
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x9A9118", Offset = "0x9A9118", VA = "0x9A9118")]
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
			[Address(RVA = "0x9A9120", Offset = "0x9A9120", VA = "0x9A9120")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x9A9128", Offset = "0x9A9128", VA = "0x9A9128")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public LoopPoint Loop
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x9A9298", Offset = "0x9A9298", VA = "0x9A9298")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x9A92A0", Offset = "0x9A92A0", VA = "0x9A92A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public bool EnableStartPosition
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x9A92A8", Offset = "0x9A92A8", VA = "0x9A92A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x9A92B0", Offset = "0x9A92B0", VA = "0x9A92B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public PointMode Mode
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x9A92BC", Offset = "0x9A92BC", VA = "0x9A92BC")]
			get
			{
				return default(PointMode);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x9A92D4", Offset = "0x9A92D4", VA = "0x9A92D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public float StartTimePosition
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x9A92E4", Offset = "0x9A92E4", VA = "0x9A92E4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x9A92FC", Offset = "0x9A92FC", VA = "0x9A92FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public float EndTimePosition
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x9A9310", Offset = "0x9A9310", VA = "0x9A9310")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x9A9328", Offset = "0x9A9328", VA = "0x9A9328")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public float StartPosition
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x9A933C", Offset = "0x9A933C", VA = "0x9A933C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x9A9354", Offset = "0x9A9354", VA = "0x9A9354")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public float EndPosition
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x9A938C", Offset = "0x9A938C", VA = "0x9A938C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x9A93A4", Offset = "0x9A93A4", VA = "0x9A93A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public int StartSamplePosition
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x9A93D4", Offset = "0x9A93D4", VA = "0x9A93D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x9A93EC", Offset = "0x9A93EC", VA = "0x9A93EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public int EndSamplePosition
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x9A9450", Offset = "0x9A9450", VA = "0x9A9450")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x9A9468", Offset = "0x9A9468", VA = "0x9A9468")]
			set
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event LoopPositionReached OnLoopPositionReached
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x9A94CC", Offset = "0x9A94CC", VA = "0x9A94CC")]
			add
			{
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x9A9568", Offset = "0x9A9568", VA = "0x9A9568")]
			remove
			{
			}
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x9A9604", Offset = "0x9A9604", VA = "0x9A9604")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x9A96D8", Offset = "0x9A96D8", VA = "0x9A96D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x9A97AC", Offset = "0x9A97AC", VA = "0x9A97AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x9A9B24", Offset = "0x9A9B24", VA = "0x9A9B24")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x9A9BEC", Offset = "0x9A9BEC", VA = "0x9A9BEC")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x9A996C", Offset = "0x9A996C", VA = "0x9A996C")]
		private void onLoopPositionReached(Record record, LoopPoint lp)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x9A9C78", Offset = "0x9A9C78", VA = "0x9A9C78")]
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
				[Address(RVA = "0x9AAB04", Offset = "0x9AAB04", VA = "0x9AAB04", Slot = "4")]
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
				[Address(RVA = "0x9AAB4C", Offset = "0x9AAB4C", VA = "0x9AAB4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x9AA784", Offset = "0x9AA784", VA = "0x9AA784")]
			[DebuggerHidden]
			public <faderA>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x9AA88C", Offset = "0x9AA88C", VA = "0x9AA88C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x9AA890", Offset = "0x9AA890", VA = "0x9AA890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x9AAB0C", Offset = "0x9AAB0C", VA = "0x9AAB0C", Slot = "8")]
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
				[Address(RVA = "0x9ABDF4", Offset = "0x9ABDF4", VA = "0x9ABDF4", Slot = "4")]
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
				[Address(RVA = "0x9ABE3C", Offset = "0x9ABE3C", VA = "0x9ABE3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x9ABB54", Offset = "0x9ABB54", VA = "0x9ABB54")]
			[DebuggerHidden]
			public <faderB>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x9ABB7C", Offset = "0x9ABB7C", VA = "0x9ABB7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x9ABB80", Offset = "0x9ABB80", VA = "0x9ABB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x9ABDFC", Offset = "0x9ABDFC", VA = "0x9ABDFC", Slot = "8")]
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
			[Address(RVA = "0x9A9C80", Offset = "0x9A9C80", VA = "0x9A9C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x9A9C88", Offset = "0x9A9C88", VA = "0x9A9C88")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public SimplePlayer PlayerB
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x9A9DF8", Offset = "0x9A9DF8", VA = "0x9A9DF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x9A9E00", Offset = "0x9A9E00", VA = "0x9A9E00")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public float FadeTime
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x9A9F70", Offset = "0x9A9F70", VA = "0x9A9F70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x9A9F78", Offset = "0x9A9F78", VA = "0x9A9F78")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public bool AutoFade
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x9A9F98", Offset = "0x9A9F98", VA = "0x9A9F98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x9A9FA0", Offset = "0x9A9FA0", VA = "0x9A9FA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public bool isFading
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x9A9FAC", Offset = "0x9A9FAC", VA = "0x9A9FAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010C")]
		public float Progress
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x9A9FCC", Offset = "0x9A9FCC", VA = "0x9A9FCC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x9A9FD4", Offset = "0x9A9FD4", VA = "0x9A9FD4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public float Elapsed
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x9A9FDC", Offset = "0x9A9FDC", VA = "0x9A9FDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x9A9FE4", Offset = "0x9A9FE4", VA = "0x9A9FE4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x9A9FEC", Offset = "0x9A9FEC", VA = "0x9A9FEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x9AA300", Offset = "0x9AA300", VA = "0x9AA300")]
		private void Update()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x9AA528", Offset = "0x9AA528", VA = "0x9AA528")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x9AA550", Offset = "0x9AA550", VA = "0x9AA550")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x9AA4F4", Offset = "0x9AA4F4", VA = "0x9AA4F4")]
		public void FadeA()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x9AA4C0", Offset = "0x9AA4C0", VA = "0x9AA4C0")]
		public void FadeB()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x9AA69C", Offset = "0x9AA69C", VA = "0x9AA69C")]
		private IEnumerator faderA()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x9AA710", Offset = "0x9AA710", VA = "0x9AA710")]
		private IEnumerator faderB()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x9AA7AC", Offset = "0x9AA7AC", VA = "0x9AA7AC")]
		private void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x9AA86C", Offset = "0x9AA86C", VA = "0x9AA86C")]
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
			[Address(RVA = "0x9ABE44", Offset = "0x9ABE44", VA = "0x9ABE44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x9ABE4C", Offset = "0x9ABE4C", VA = "0x9ABE4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public bool SilenceSource
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x9AC1D0", Offset = "0x9AC1D0", VA = "0x9AC1D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x9AC1D8", Offset = "0x9AC1D8", VA = "0x9AC1D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public string OutputPath
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x9AC208", Offset = "0x9AC208", VA = "0x9AC208")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x9AC210", Offset = "0x9AC210", VA = "0x9AC210")]
			set
			{
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x9AC498", Offset = "0x9AC498", VA = "0x9AC498")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x9AC518", Offset = "0x9AC518", VA = "0x9AC518")]
		private void Start()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x9AC670", Offset = "0x9AC670", VA = "0x9AC670")]
		private void Update()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x9AC8E4", Offset = "0x9AC8E4", VA = "0x9AC8E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x9AC8E8", Offset = "0x9AC8E8", VA = "0x9AC8E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x9AD188", Offset = "0x9AD188", VA = "0x9AD188")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x9AD210", Offset = "0x9AD210", VA = "0x9AD210")]
		public void SaveFile(Stream stream, [Optional] string fname)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x9AD294", Offset = "0x9AD294", VA = "0x9AD294")]
		public void SaveFile(byte[] data, [Optional] string fname)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x9AC090", Offset = "0x9AC090", VA = "0x9AC090")]
		private void register()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x9ABF50", Offset = "0x9ABF50", VA = "0x9ABF50")]
		private void unregister()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x9ADA44", Offset = "0x9ADA44", VA = "0x9ADA44")]
		private void openFile()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x9AD8BC", Offset = "0x9AD8BC", VA = "0x9AD8BC")]
		private void write(byte[] bytesData, int count)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x9AC934", Offset = "0x9AC934", VA = "0x9AC934")]
		private void closeFile()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x9ADD70", Offset = "0x9ADD70", VA = "0x9ADD70")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x9ADF4C", Offset = "0x9ADF4C", VA = "0x9ADF4C")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x9AE198", Offset = "0x9AE198", VA = "0x9AE198")]
		private void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x9AE244", Offset = "0x9AE244", VA = "0x9AE244")]
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
			[Address(RVA = "0x9AE828", Offset = "0x9AE828", VA = "0x9AE828")]
			public <>c()
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x9AE830", Offset = "0x9AE830", VA = "0x9AE830")]
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
		[Address(RVA = "0x9AE254", Offset = "0x9AE254", VA = "0x9AE254")]
		private void Start()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x9AE274", Offset = "0x9AE274", VA = "0x9AE274")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x9AE7B0", Offset = "0x9AE7B0", VA = "0x9AE7B0")]
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
			[Address(RVA = "0x9AF234", Offset = "0x9AF234", VA = "0x9AF234")]
			public <>c()
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x9AF23C", Offset = "0x9AF23C", VA = "0x9AF23C")]
			internal bool <activateGameObjects>b__8_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x9AF298", Offset = "0x9AF298", VA = "0x9AF298")]
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
		[Address(RVA = "0x9AE88C", Offset = "0x9AE88C", VA = "0x9AE88C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x9AE8B4", Offset = "0x9AE8B4", VA = "0x9AE8B4")]
		protected void selectPlatform()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x9AE99C", Offset = "0x9AE99C", VA = "0x9AE99C")]
		protected void activateGameObjects()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x9AEDA8", Offset = "0x9AEDA8", VA = "0x9AEDA8")]
		protected void activateScripts()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x9AF1B4", Offset = "0x9AF1B4", VA = "0x9AF1B4")]
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
		[Address(RVA = "0x9AF2F4", Offset = "0x9AF2F4", VA = "0x9AF2F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x9AFC20", Offset = "0x9AFC20", VA = "0x9AFC20")]
		private void Update()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x9B05CC", Offset = "0x9B05CC", VA = "0x9B05CC")]
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
		[Address(RVA = "0x9B0660", Offset = "0x9B0660", VA = "0x9B0660")]
		private void Start()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x9B0718", Offset = "0x9B0718", VA = "0x9B0718")]
		private void Update()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x9B0A38", Offset = "0x9B0A38", VA = "0x9B0A38")]
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
		[Address(RVA = "0x9B0AC8", Offset = "0x9B0AC8", VA = "0x9B0AC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x9B0BB0", Offset = "0x9B0BB0", VA = "0x9B0BB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x9B0D18", Offset = "0x9B0D18", VA = "0x9B0D18")]
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
			[Address(RVA = "0x9B1250", Offset = "0x9B1250", VA = "0x9B1250")]
			public <>c()
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x9B1258", Offset = "0x9B1258", VA = "0x9B1258")]
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
		[Address(RVA = "0x9B0D50", Offset = "0x9B0D50", VA = "0x9B0D50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x9B0D7C", Offset = "0x9B0D7C", VA = "0x9B0D7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x9B1174", Offset = "0x9B1174", VA = "0x9B1174")]
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
			[Address(RVA = "0x9B12B4", Offset = "0x9B12B4", VA = "0x9B12B4")]
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
			[Address(RVA = "0x9B1778", Offset = "0x9B1778", VA = "0x9B1778")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x9B1780", Offset = "0x9B1780", VA = "0x9B1780")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000118")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x9B1788", Offset = "0x9B1788", VA = "0x9B1788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x9B1790", Offset = "0x9B1790", VA = "0x9B1790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x9B1798", Offset = "0x9B1798", VA = "0x9B1798")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x9B17A0", Offset = "0x9B17A0", VA = "0x9B17A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x9B17A8", Offset = "0x9B17A8", VA = "0x9B17A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011D")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x9B17B0", Offset = "0x9B17B0", VA = "0x9B17B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x9B17B8", Offset = "0x9B17B8", VA = "0x9B17B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x9B17C0", Offset = "0x9B17C0", VA = "0x9B17C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000120")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x9B1338", Offset = "0x9B1338", VA = "0x9B1338")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000121")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x9B1810", Offset = "0x9B1810", VA = "0x9B1810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000122")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x9B1870", Offset = "0x9B1870", VA = "0x9B1870")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000123")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0x9AE760", Offset = "0x9AE760", VA = "0x9AE760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		public static bool isEditor
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x9B18D0", Offset = "0x9B18D0", VA = "0x9B18D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x9B13A8", Offset = "0x9B13A8", VA = "0x9B13A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x9B13B0", Offset = "0x9B13B0", VA = "0x9B13B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x9B13B8", Offset = "0x9B13B8", VA = "0x9B13B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x9B1940", Offset = "0x9B1940", VA = "0x9B1940")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000129")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x9B1994", Offset = "0x9B1994", VA = "0x9B1994")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012A")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x9AE91C", Offset = "0x9AE91C", VA = "0x9AE91C")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x9B199C", Offset = "0x9B199C", VA = "0x9B199C")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x9B1CE8", Offset = "0x9B1CE8", VA = "0x9B1CE8")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x9B1D50", Offset = "0x9B1D50", VA = "0x9B1D50")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x9B2024", Offset = "0x9B2024", VA = "0x9B2024")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x9B2458", Offset = "0x9B2458", VA = "0x9B2458")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x9B1AB8", Offset = "0x9B1AB8", VA = "0x9B1AB8")]
		public static string LanguageToISO639(SystemLanguage language)
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x9B23E8", Offset = "0x9B23E8", VA = "0x9B23E8")]
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
			[Address(RVA = "0x9B25A8", Offset = "0x9B25A8", VA = "0x9B25A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x9B25F0", Offset = "0x9B25F0", VA = "0x9B25F0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x9B2648", Offset = "0x9B2648", VA = "0x9B2648")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x9B26A4", Offset = "0x9B26A4", VA = "0x9B26A4")]
		[RuntimeInitializeOnLoadMethod]
		private static void create()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x9B2798", Offset = "0x9B2798", VA = "0x9B2798")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x9B27F0", Offset = "0x9B27F0", VA = "0x9B27F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x9B2848", Offset = "0x9B2848", VA = "0x9B2848")]
		public CTHelper()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x9B2850", Offset = "0x9B2850", VA = "0x9B2850")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x9B2880", Offset = "0x9B2880", VA = "0x9B2880")]
		public static void Save()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x9B2888", Offset = "0x9B2888", VA = "0x9B2888")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x9B28F8", Offset = "0x9B28F8", VA = "0x9B28F8")]
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
			[Address(RVA = "0x9B2978", Offset = "0x9B2978", VA = "0x9B2978")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x9B2980", Offset = "0x9B2980", VA = "0x9B2980")]
			set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public int ConnectionLimit
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x9B2988", Offset = "0x9B2988", VA = "0x9B2988")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x9B2990", Offset = "0x9B2990", VA = "0x9B2990")]
			set
			{
			}
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x9B2998", Offset = "0x9B2998", VA = "0x9B2998")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x9B2A08", Offset = "0x9B2A08", VA = "0x9B2A08")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x9B2A84", Offset = "0x9B2A84", VA = "0x9B2A84", Slot = "8")]
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
			[Address(RVA = "0x9B3518", Offset = "0x9B3518", VA = "0x9B3518")]
			public <>c()
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x9B3520", Offset = "0x9B3520", VA = "0x9B3520")]
			internal bool <GetFilesForName>b__9_0(string extension)
			{
				return default(bool);
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x9B35AC", Offset = "0x9B35AC", VA = "0x9B35AC")]
			internal string <GetFilesForName>b__9_1(string q)
			{
				return null;
			}
		}

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string applicationDataPath;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x9B2BE4", Offset = "0x9B2BE4", VA = "0x9B2BE4")]
		static FileHelper()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x9B2C44", Offset = "0x9B2C44", VA = "0x9B2C44")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x9AC288", Offset = "0x9AC288", VA = "0x9AC288")]
		public static string ValidatePath(string path, bool addEndDelimiter = true, bool preserveFile = true)
		{
			return null;
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x9AD65C", Offset = "0x9AD65C", VA = "0x9AD65C")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x9B2DBC", Offset = "0x9B2DBC", VA = "0x9B2DBC")]
		public static string[] GetFilesForName(string path, bool isRecursive = false, params string[] filenames)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x9B32E0", Offset = "0x9B32E0", VA = "0x9B32E0")]
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
			[Address(RVA = "0x9B36F4", Offset = "0x9B36F4", VA = "0x9B36F4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012F")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x9B36FC", Offset = "0x9B36FC", VA = "0x9B36FC", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000130")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x9B3704", Offset = "0x9B3704", VA = "0x9B3704", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000131")]
		public override long Position
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x9B370C", Offset = "0x9B370C", VA = "0x9B370C", Slot = "10")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x9B3714", Offset = "0x9B3714", VA = "0x9B3714", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public override long Length
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x9B3790", Offset = "0x9B3790", VA = "0x9B3790", Slot = "9")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x9B35B4", Offset = "0x9B35B4", VA = "0x9B35B4")]
		public MemoryCacheStream(int cacheSize = 65536, int maxCacheSize = 67108864)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x9B3798", Offset = "0x9B3798", VA = "0x9B3798", Slot = "17")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x9B379C", Offset = "0x9B379C", VA = "0x9B379C", Slot = "26")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x9B389C", Offset = "0x9B389C", VA = "0x9B389C", Slot = "27")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x9B3A60", Offset = "0x9B3A60", VA = "0x9B3A60", Slot = "30")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x9B39A8", Offset = "0x9B39A8", VA = "0x9B39A8")]
		private int read(byte[] buff, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x9B3BA0", Offset = "0x9B3BA0", VA = "0x9B3BA0")]
		private void write(byte[] buff, int offset, int count)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x9B3630", Offset = "0x9B3630", VA = "0x9B3630")]
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
			[Address(RVA = "0x9B435C", Offset = "0x9B435C", VA = "0x9B435C")]
			public <>c()
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x9B4364", Offset = "0x9B4364", VA = "0x9B4364")]
			internal bool <RemoteCertificateValidationCallback>b__5_0(X509ChainStatus t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000133")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x9B3C50", Offset = "0x9B3C50", VA = "0x9B3C50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x9B3C6C", Offset = "0x9B3C6C", VA = "0x9B3C6C")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x9B4184", Offset = "0x9B4184", VA = "0x9B4184")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x9B2CB8", Offset = "0x9B2CB8", VA = "0x9B2CB8")]
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
			[Address(RVA = "0x9B4370", Offset = "0x9B4370", VA = "0x9B4370")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x9B43C8", Offset = "0x9B43C8", VA = "0x9B43C8")]
			set
			{
			}
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x9B4424", Offset = "0x9B4424", VA = "0x9B4424")]
		static SingletonHelper()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x9B4518", Offset = "0x9B4518", VA = "0x9B4518")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x9B4820", Offset = "0x9B4820", VA = "0x9B4820")]
		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x9B49A4", Offset = "0x9B49A4", VA = "0x9B49A4")]
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
		[Address(RVA = "0x9B4AF8", Offset = "0x9B4AF8", VA = "0x9B4AF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x9B4B0C", Offset = "0x9B4B0C", VA = "0x9B4B0C")]
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
		[Address(RVA = "0x9B4B78", Offset = "0x9B4B78", VA = "0x9B4B78")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x9B4EBC", Offset = "0x9B4EBC", VA = "0x9B4EBC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x9B4F60", Offset = "0x9B4F60", VA = "0x9B4F60")]
		public SpectrumVisualizer()
		{
		}
	}
}
