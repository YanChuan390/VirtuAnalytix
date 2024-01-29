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
			[Address(RVA = "0x6D5C4C", Offset = "0x6D5C4C", VA = "0x6D5C4C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x6D63D8", Offset = "0x6D63D8", VA = "0x6D63D8")]
			internal bool <CTContainsAny>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 flat;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x6D5A0C", Offset = "0x6D5A0C", VA = "0x6D5A0C")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x6D5AAC", Offset = "0x6D5AAC", VA = "0x6D5AAC")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x6D5ABC", Offset = "0x6D5ABC", VA = "0x6D5ABC")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x6D5ADC", Offset = "0x6D5ADC", VA = "0x6D5ADC")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x6D5C54", Offset = "0x6D5C54", VA = "0x6D5C54")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x6D5CA8", Offset = "0x6D5CA8", VA = "0x6D5CA8")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x6D5CFC", Offset = "0x6D5CFC", VA = "0x6D5CFC")]
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
		[Address(RVA = "0x6D5D9C", Offset = "0x6D5D9C", VA = "0x6D5D9C")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x6D5F30", Offset = "0x6D5F30", VA = "0x6D5F30")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x600000B")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x6D6070", Offset = "0x6D6070", VA = "0x6D6070")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x6D6270", Offset = "0x6D6270", VA = "0x6D6270")]
		public static bool CTHasActiveClip(this AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x6D5F14", Offset = "0x6D5F14", VA = "0x6D5F14")]
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
			[Address(RVA = "0x6D6464", Offset = "0x6D6464", VA = "0x6D6464")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public static bool isAnyAudioPlaying
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x6D64AC", Offset = "0x6D64AC", VA = "0x6D64AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		protected static int playCounter
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x6D64F4", Offset = "0x6D64F4", VA = "0x6D64F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x6D653C", Offset = "0x6D653C", VA = "0x6D653C")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		protected static int audioCounter
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x6D658C", Offset = "0x6D658C", VA = "0x6D658C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x6D65D4", Offset = "0x6D65D4", VA = "0x6D65D4")]
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
			[Address(RVA = "0x6D6624", Offset = "0x6D6624", VA = "0x6D6624")]
			add
			{
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x6D66C0", Offset = "0x6D66C0", VA = "0x6D66C0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event PlaybackEnd OnPlaybackEnd
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x6D675C", Offset = "0x6D675C", VA = "0x6D675C")]
			add
			{
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x6D67F8", Offset = "0x6D67F8", VA = "0x6D67F8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event BufferingStart OnBufferingStart
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x6D6894", Offset = "0x6D6894", VA = "0x6D6894")]
			add
			{
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x6D6930", Offset = "0x6D6930", VA = "0x6D6930")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event BufferingEnd OnBufferingEnd
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x6D69CC", Offset = "0x6D69CC", VA = "0x6D69CC")]
			add
			{
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x6D6A68", Offset = "0x6D6A68", VA = "0x6D6A68")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event BufferingProgressUpdate OnBufferingProgressUpdate
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x6D6B04", Offset = "0x6D6B04", VA = "0x6D6B04")]
			add
			{
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x6D6BA0", Offset = "0x6D6BA0", VA = "0x6D6BA0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event AudioStart OnAudioStart
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x6D6C3C", Offset = "0x6D6C3C", VA = "0x6D6C3C")]
			add
			{
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x6D6CD8", Offset = "0x6D6CD8", VA = "0x6D6CD8")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event AudioEnd OnAudioEnd
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x6D6D74", Offset = "0x6D6D74", VA = "0x6D6D74")]
			add
			{
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x6D6E10", Offset = "0x6D6E10", VA = "0x6D6E10")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event LoopPositionReached OnLoopPositionReached
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x6D6EAC", Offset = "0x6D6EAC", VA = "0x6D6EAC")]
			add
			{
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x6D6F48", Offset = "0x6D6F48", VA = "0x6D6F48")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event AudioPlayTimeUpdate OnAudioPlayTimeUpdate
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x6D6FE4", Offset = "0x6D6FE4", VA = "0x6D6FE4")]
			add
			{
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x6D7080", Offset = "0x6D7080", VA = "0x6D7080")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event ErrorInfo OnErrorInfo
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x6D711C", Offset = "0x6D711C", VA = "0x6D711C")]
			add
			{
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x6D71B8", Offset = "0x6D71B8", VA = "0x6D71B8")]
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
		[Address(RVA = "0x6D7254", Offset = "0x6D7254", VA = "0x6D7254", Slot = "71")]
		public virtual void PlayOrStop()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x6D7294", Offset = "0x6D7294", VA = "0x6D7294", Slot = "72")]
		public virtual void PauseOrUnPause()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x6D72D4", Offset = "0x6D72D4", VA = "0x6D72D4", Slot = "73")]
		public virtual void MuteOrUnMute()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x6D7314", Offset = "0x6D7314", VA = "0x6D7314", Slot = "74")]
		protected virtual void onPlaybackStart(Record record)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x6D74E0", Offset = "0x6D74E0", VA = "0x6D74E0", Slot = "75")]
		protected virtual void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x6D76AC", Offset = "0x6D76AC", VA = "0x6D76AC", Slot = "76")]
		protected virtual void onBufferingStart(Record record)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x6D77C0", Offset = "0x6D77C0", VA = "0x6D77C0", Slot = "77")]
		protected virtual void onBufferingEnd(Record record)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x6D789C", Offset = "0x6D789C", VA = "0x6D789C", Slot = "78")]
		protected virtual void onBufferingProgressUpdate(Record record, float progress)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x6D78B8", Offset = "0x6D78B8", VA = "0x6D78B8", Slot = "79")]
		protected virtual void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x6D7A84", Offset = "0x6D7A84", VA = "0x6D7A84", Slot = "80")]
		protected virtual void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x6D7C50", Offset = "0x6D7C50", VA = "0x6D7C50", Slot = "81")]
		protected virtual void onLoopPositionReached(Record record, LoopPoint lp)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x6D7DB8", Offset = "0x6D7DB8", VA = "0x6D7DB8", Slot = "82")]
		protected virtual void onAudioPlayTimeUpdate(Record record, float playtime)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x6D7DD4", Offset = "0x6D7DD4", VA = "0x6D7DD4", Slot = "83")]
		protected virtual void onErrorInfo(Record record, string info)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x6D7F8C", Offset = "0x6D7F8C", VA = "0x6D7F8C")]
		protected BasePlayer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public class PlaybackStartEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x6D7F94", Offset = "0x6D7F94", VA = "0x6D7F94")]
		public PlaybackStartEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	public class PlaybackEndEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x6D7FDC", Offset = "0x6D7FDC", VA = "0x6D7FDC")]
		public PlaybackEndEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class AudioStartEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x6D8024", Offset = "0x6D8024", VA = "0x6D8024")]
		public AudioStartEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000008")]
	public class AudioEndEvent : UnityEvent<string, string, int>
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x6D806C", Offset = "0x6D806C", VA = "0x6D806C")]
		public AudioEndEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class ErrorEvent : UnityEvent<string, string, int, string>
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x6D80B4", Offset = "0x6D80B4", VA = "0x6D80B4")]
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
		[Address(RVA = "0x6D8F7C", Offset = "0x6D8F7C", VA = "0x6D8F7C")]
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
		[Address(RVA = "0x6D9114", Offset = "0x6D9114", VA = "0x6D9114")]
		public RecordsChangeEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class ErrorProviderEvent : UnityEvent<string>
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x6D911C", Offset = "0x6D911C", VA = "0x6D911C")]
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
		[Address(RVA = "0x6D933C", Offset = "0x6D933C", VA = "0x6D933C")]
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
			[Address(RVA = "0x6DA55C", Offset = "0x6DA55C", VA = "0x6DA55C")]
			public <>c()
			{
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x6DA564", Offset = "0x6DA564", VA = "0x6DA564")]
			internal int <get_CurrentDataCacheSize>b__14_0(KeyValuePair<string, byte[]> pair)
			{
				return default(int);
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x6DA5A8", Offset = "0x6DA5A8", VA = "0x6DA5A8")]
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
			[Address(RVA = "0x6D9424", Offset = "0x6D9424", VA = "0x6D9424")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x6D9430", Offset = "0x6D9430", VA = "0x6D9430")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public int DataCacheSize
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x6D9464", Offset = "0x6D9464", VA = "0x6D9464")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x6D9470", Offset = "0x6D9470", VA = "0x6D9470")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public int CurrentDataCacheSize
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x6D94A4", Offset = "0x6D94A4", VA = "0x6D94A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002B")]
		public int CurrentClipCacheSize
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x6D95D4", Offset = "0x6D95D4", VA = "0x6D95D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x6D9704", Offset = "0x6D9704", VA = "0x6D9704")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x6D9750", Offset = "0x6D9750", VA = "0x6D9750", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x6D97B0", Offset = "0x6D97B0", VA = "0x6D97B0")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x6D9814", Offset = "0x6D9814", VA = "0x6D9814")]
		public AudioClip GetClip(string key)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x6D98B0", Offset = "0x6D98B0", VA = "0x6D98B0")]
		public void RemoveClip(string key)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x6D9A1C", Offset = "0x6D9A1C", VA = "0x6D9A1C")]
		public void AddClip(string key, AudioClip data)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x6D9C38", Offset = "0x6D9C38", VA = "0x6D9C38")]
		public byte[] GetData(string key)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x6D9CD4", Offset = "0x6D9CD4", VA = "0x6D9CD4")]
		public void RemoveData(string key)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x6D9DD8", Offset = "0x6D9DD8", VA = "0x6D9DD8")]
		public void AddData(string key, byte[] data)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x6D9FC0", Offset = "0x6D9FC0", VA = "0x6D9FC0")]
		public void ClearDataCache()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x6DA0B4", Offset = "0x6DA0B4", VA = "0x6DA0B4")]
		public void ClearClipCache()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x6D97A0", Offset = "0x6D97A0", VA = "0x6D97A0")]
		public void ClearCache()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x6DA300", Offset = "0x6DA300", VA = "0x6DA300")]
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
			[Address(RVA = "0x6DA5F8", Offset = "0x6DA5F8", VA = "0x6DA5F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x6DAA68", Offset = "0x6DAA68", VA = "0x6DAA68")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public BaseSet Set
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x6DAA70", Offset = "0x6DAA70", VA = "0x6DAA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x6DAA78", Offset = "0x6DAA78", VA = "0x6DAA78")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public RecordFilter Filter
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x6DAA80", Offset = "0x6DAA80", VA = "0x6DAA80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x6DAA88", Offset = "0x6DAA88", VA = "0x6DAA88")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public bool PlayOnStart
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x6DAA90", Offset = "0x6DAA90", VA = "0x6DAA90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x6DAA98", Offset = "0x6DAA98", VA = "0x6DAA98")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool PlayEndless
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x6DAAA4", Offset = "0x6DAAA4", VA = "0x6DAAA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x6DAAAC", Offset = "0x6DAAAC", VA = "0x6DAAAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public bool PlayRandom
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x6DAAB8", Offset = "0x6DAAB8", VA = "0x6DAAB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x6DAAC0", Offset = "0x6DAAC0", VA = "0x6DAAC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		protected override PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x6DAACC", Offset = "0x6DAACC", VA = "0x6DAACC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		protected override PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x6DAAD4", Offset = "0x6DAAD4", VA = "0x6DAAD4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		protected override AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x6DAADC", Offset = "0x6DAADC", VA = "0x6DAADC", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		protected override AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x6DAAE4", Offset = "0x6DAAE4", VA = "0x6DAAE4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		protected override ErrorEvent onError
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x6DAAEC", Offset = "0x6DAAEC", VA = "0x6DAAEC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public List<Record> Records
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x6DC8C8", Offset = "0x6DC8C8", VA = "0x6DC8C8", Slot = "88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public List<Record> RandomRecords
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x6DC994", Offset = "0x6DC994", VA = "0x6DC994", Slot = "89")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public bool isReady
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x6DCA60", Offset = "0x6DCA60", VA = "0x6DCA60", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x6DCAEC", Offset = "0x6DCAEC", VA = "0x6DCAEC", Slot = "91")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700003B")]
		public long TotalSize
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x6DCC90", Offset = "0x6DCC90", VA = "0x6DCC90", Slot = "92")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700003C")]
		public int CurrentRecordIndex
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x6DCE30", Offset = "0x6DCE30", VA = "0x6DCE30", Slot = "93")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x6DCEB0", Offset = "0x6DCEB0", VA = "0x6DCEB0", Slot = "94")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public int CurrentRandomRecordIndex
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x6DCFB4", Offset = "0x6DCFB4", VA = "0x6DCFB4", Slot = "95")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x6DD034", Offset = "0x6DD034", VA = "0x6DD034", Slot = "96")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override Record Record
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x6E50D8", Offset = "0x6E50D8", VA = "0x6E50D8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x6E50F8", Offset = "0x6E50F8", VA = "0x6E50F8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public override bool isLoop
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x6E5120", Offset = "0x6E5120", VA = "0x6E5120", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x6E5140", Offset = "0x6E5140", VA = "0x6E5140", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public override bool HandleFocus
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x6E5168", Offset = "0x6E5168", VA = "0x6E5168", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x6E518C", Offset = "0x6E518C", VA = "0x6E518C", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public override bool Caching
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x6E51B8", Offset = "0x6E51B8", VA = "0x6E51B8", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x6E51DC", Offset = "0x6E51DC", VA = "0x6E51DC", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public override bool Streaming
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x6E5208", Offset = "0x6E5208", VA = "0x6E5208", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x6E522C", Offset = "0x6E522C", VA = "0x6E522C", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public override int ChunkSize
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x6E5258", Offset = "0x6E5258", VA = "0x6E5258", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x6E527C", Offset = "0x6E527C", VA = "0x6E527C", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public override int CacheStreamSize
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x6E52A8", Offset = "0x6E52A8", VA = "0x6E52A8", Slot = "21")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x6E52CC", Offset = "0x6E52CC", VA = "0x6E52CC", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public override bool CaptureDataStream
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x6E52F8", Offset = "0x6E52F8", VA = "0x6E52F8", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x6E531C", Offset = "0x6E531C", VA = "0x6E531C", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public override bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x6E5348", Offset = "0x6E5348", VA = "0x6E5348", Slot = "25")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x6E536C", Offset = "0x6E536C", VA = "0x6E536C", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public override bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x6E5398", Offset = "0x6E5398", VA = "0x6E5398", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x6E53BC", Offset = "0x6E53BC", VA = "0x6E53BC", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public override AudioSource Source
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x6E53E8", Offset = "0x6E53E8", VA = "0x6E53E8", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x6E540C", Offset = "0x6E540C", VA = "0x6E540C", Slot = "30")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public override float Position
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x6E5410", Offset = "0x6E5410", VA = "0x6E5410", Slot = "31")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x6E5434", Offset = "0x6E5434", VA = "0x6E5434", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public override int SamplePosition
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x6E5468", Offset = "0x6E5468", VA = "0x6E5468", Slot = "33")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x6E548C", Offset = "0x6E548C", VA = "0x6E548C", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public override float Elapsed
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x6E54B8", Offset = "0x6E54B8", VA = "0x6E54B8", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x6E54DC", Offset = "0x6E54DC", VA = "0x6E54DC", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public override float Duration
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x6E5510", Offset = "0x6E5510", VA = "0x6E5510", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004D")]
		public override int Samples
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x6E5534", Offset = "0x6E5534", VA = "0x6E5534", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004E")]
		public override AudioCodec Codec
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x6E5558", Offset = "0x6E5558", VA = "0x6E5558", Slot = "39")]
			get
			{
				return default(AudioCodec);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x6E557C", Offset = "0x6E557C", VA = "0x6E557C", Slot = "40")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public override float BufferProgress
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x6E5580", Offset = "0x6E5580", VA = "0x6E5580", Slot = "41")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x6E55A4", Offset = "0x6E55A4", VA = "0x6E55A4", Slot = "42")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public override bool isPlayback
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x6E55A8", Offset = "0x6E55A8", VA = "0x6E55A8", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public override bool isAudioPlaying
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x6E55CC", Offset = "0x6E55CC", VA = "0x6E55CC", Slot = "45")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x6E55F0", Offset = "0x6E55F0", VA = "0x6E55F0", Slot = "46")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public override bool isBuffering
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x6E55F4", Offset = "0x6E55F4", VA = "0x6E55F4", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public override bool isPaused
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x6E5618", Offset = "0x6E5618", VA = "0x6E5618", Slot = "47")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x6E563C", Offset = "0x6E563C", VA = "0x6E563C", Slot = "48")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public override Stream DataStream
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x6E5668", Offset = "0x6E5668", VA = "0x6E5668", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x6E568C", Offset = "0x6E568C", VA = "0x6E568C", Slot = "50")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public override int Channels
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x6E5690", Offset = "0x6E5690", VA = "0x6E5690", Slot = "51")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000056")]
		public override int SampleRate
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x6E56B4", Offset = "0x6E56B4", VA = "0x6E56B4", Slot = "52")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000057")]
		public override float Volume
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x6E56D8", Offset = "0x6E56D8", VA = "0x6E56D8", Slot = "53")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x6E56FC", Offset = "0x6E56FC", VA = "0x6E56FC", Slot = "54")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public override float Pitch
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x6E5730", Offset = "0x6E5730", VA = "0x6E5730", Slot = "55")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x6E5754", Offset = "0x6E5754", VA = "0x6E5754", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public override float StereoPan
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x6E5788", Offset = "0x6E5788", VA = "0x6E5788", Slot = "57")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x6E57AC", Offset = "0x6E57AC", VA = "0x6E57AC", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public override bool isMuted
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x6E57E0", Offset = "0x6E57E0", VA = "0x6E57E0", Slot = "59")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x6E5804", Offset = "0x6E5804", VA = "0x6E5804", Slot = "60")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public override List<Record> PlayedRecords
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x6E5830", Offset = "0x6E5830", VA = "0x6E5830", Slot = "61")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000B")]
		public event RecordChange OnRecordChange
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x6DAAF4", Offset = "0x6DAAF4", VA = "0x6DAAF4")]
			add
			{
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x6DAB90", Offset = "0x6DAB90", VA = "0x6DAB90")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event FilterChange OnFilterChange
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x6DAC2C", Offset = "0x6DAC2C", VA = "0x6DAC2C")]
			add
			{
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x6DACC8", Offset = "0x6DACC8", VA = "0x6DACC8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x6DAD64", Offset = "0x6DAD64", VA = "0x6DAD64")]
			add
			{
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x6DAE00", Offset = "0x6DAE00", VA = "0x6DAE00")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x6DAE9C", Offset = "0x6DAE9C", VA = "0x6DAE9C")]
			add
			{
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x6DAF38", Offset = "0x6DAF38", VA = "0x6DAF38")]
			remove
			{
			}
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x6DAFD4", Offset = "0x6DAFD4", VA = "0x6DAFD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x6DB6F8", Offset = "0x6DB6F8", VA = "0x6DB6F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x6DB7D0", Offset = "0x6DB7D0", VA = "0x6DB7D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x6DBE24", Offset = "0x6DBE24", VA = "0x6DBE24")]
		private void play()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x6DBE48", Offset = "0x6DBE48", VA = "0x6DBE48")]
		private RecordFilter getFilter([Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x6DBE9C", Offset = "0x6DBE9C", VA = "0x6DBE9C")]
		private void playEndlessly()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x6DC184", Offset = "0x6DC184", VA = "0x6DC184", Slot = "79")]
		protected override void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x6DC1B8", Offset = "0x6DC1B8", VA = "0x6DC1B8", Slot = "80")]
		protected override void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x6DC210", Offset = "0x6DC210", VA = "0x6DC210", Slot = "83")]
		protected override void onErrorInfo(Record record, string info)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x6DC248", Offset = "0x6DC248", VA = "0x6DC248", Slot = "84")]
		protected virtual void onRecordChange(Record newRecord)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x6DC404", Offset = "0x6DC404", VA = "0x6DC404", Slot = "85")]
		protected virtual void onFilterChange()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x6DC5B8", Offset = "0x6DC5B8", VA = "0x6DC5B8", Slot = "86")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x6DC77C", Offset = "0x6DC77C", VA = "0x6DC77C", Slot = "87")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x6DD138", Offset = "0x6DD138", VA = "0x6DD138", Slot = "97")]
		public void Load()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x6DBF88", Offset = "0x6DBF88", VA = "0x6DBF88", Slot = "98")]
		public Record Next(bool random, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x6DC088", Offset = "0x6DC088", VA = "0x6DC088", Slot = "99")]
		public Record Previous(bool random, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x6DD224", Offset = "0x6DD224", VA = "0x6DD224", Slot = "100")]
		public void RandomizeRecords(bool resetIndex = true)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x6DD35C", Offset = "0x6DD35C", VA = "0x6DD35C", Slot = "101")]
		public List<Record> GetRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x6DD4BC", Offset = "0x6DD4BC", VA = "0x6DD4BC", Slot = "102")]
		public int CountRecords([Optional] RecordFilter _filter)
		{
			return default(int);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x6DD5D0", Offset = "0x6DD5D0", VA = "0x6DD5D0", Slot = "103")]
		public double PlaytimeRecords([Optional] RecordFilter _filter)
		{
			return default(double);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x6DD7A8", Offset = "0x6DD7A8", VA = "0x6DD7A8", Slot = "104")]
		public long SizeRecords([Optional] RecordFilter _filter)
		{
			return default(long);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x6DD97C", Offset = "0x6DD97C", VA = "0x6DD97C", Slot = "105")]
		public Record RecordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x6DDA4C", Offset = "0x6DDA4C", VA = "0x6DDA4C", Slot = "106")]
		public Record RecordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x6DDAE8", Offset = "0x6DDAE8", VA = "0x6DDAE8", Slot = "107")]
		public List<Record> RecordsByFilePath(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x6DE3A8", Offset = "0x6DE3A8", VA = "0x6DE3A8", Slot = "108")]
		public List<Record> RecordsByName(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x6DEC4C", Offset = "0x6DEC4C", VA = "0x6DEC4C", Slot = "109")]
		public List<Record> RecordsByTitle(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x6DF4F0", Offset = "0x6DF4F0", VA = "0x6DF4F0", Slot = "110")]
		public List<Record> RecordsByArtist(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x6E0048", Offset = "0x6E0048", VA = "0x6E0048", Slot = "111")]
		public List<Record> RecordsByAlbum(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x6E0BA4", Offset = "0x6E0BA4", VA = "0x6E0BA4", Slot = "112")]
		public List<Record> RecordsByGenre(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x6E1708", Offset = "0x6E1708", VA = "0x6E1708", Slot = "113")]
		public List<Record> RecordsByRating(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x6E2298", Offset = "0x6E2298", VA = "0x6E2298", Slot = "114")]
		public List<Record> RecordsByYear(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x6E2E28", Offset = "0x6E2E28", VA = "0x6E2E28", Slot = "115")]
		public List<Record> RecordsByDuration(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x6E39B8", Offset = "0x6E39B8", VA = "0x6E39B8", Slot = "116")]
		public List<Record> RecordsByFileSize(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x6E4548", Offset = "0x6E4548", VA = "0x6E4548", Slot = "117")]
		public List<Record> RecordsByFormat(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x6E5854", Offset = "0x6E5854", VA = "0x6E5854", Slot = "62")]
		public override void Play()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x6E5AD8", Offset = "0x6E5AD8", VA = "0x6E5AD8", Slot = "63")]
		public override void Next()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x6E5AE4", Offset = "0x6E5AE4", VA = "0x6E5AE4", Slot = "64")]
		public override void Previous()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x6E5AF0", Offset = "0x6E5AF0", VA = "0x6E5AF0", Slot = "65")]
		public override void Pause()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x6E5B14", Offset = "0x6E5B14", VA = "0x6E5B14", Slot = "66")]
		public override void UnPause()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x6E5B38", Offset = "0x6E5B38", VA = "0x6E5B38", Slot = "67")]
		public override void Stop()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x6E5BD4", Offset = "0x6E5BD4", VA = "0x6E5BD4", Slot = "68")]
		public override void Restart()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x6E5BF8", Offset = "0x6E5BF8", VA = "0x6E5BF8", Slot = "69")]
		public override void Mute()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x6E5C1C", Offset = "0x6E5C1C", VA = "0x6E5C1C", Slot = "70")]
		public override void UnMute()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x6E5C40", Offset = "0x6E5C40", VA = "0x6E5C40")]
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
			[Address(RVA = "0x6EAFDC", Offset = "0x6EAFDC", VA = "0x6EAFDC")]
			public <>c__DisplayClass185_0()
			{
			}

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x6EAFE4", Offset = "0x6EAFE4", VA = "0x6EAFE4")]
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
			[Address(RVA = "0x6EB000", Offset = "0x6EB000", VA = "0x6EB000")]
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
			[Address(RVA = "0x6EB008", Offset = "0x6EB008", VA = "0x6EB008")]
			public <>c__DisplayClass185_2()
			{
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x6EB010", Offset = "0x6EB010", VA = "0x6EB010")]
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
			[Address(RVA = "0x6EB044", Offset = "0x6EB044", VA = "0x6EB044")]
			public <>c__DisplayClass185_3()
			{
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x6EB04C", Offset = "0x6EB04C", VA = "0x6EB04C")]
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
			[Address(RVA = "0x6EB080", Offset = "0x6EB080", VA = "0x6EB080")]
			public <>c__DisplayClass185_4()
			{
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x6EB088", Offset = "0x6EB088", VA = "0x6EB088")]
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
			[Address(RVA = "0x6EB0C4", Offset = "0x6EB0C4", VA = "0x6EB0C4")]
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
			[Address(RVA = "0x6EB0CC", Offset = "0x6EB0CC", VA = "0x6EB0CC")]
			public <>c__DisplayClass185_6()
			{
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x6EB0D4", Offset = "0x6EB0D4", VA = "0x6EB0D4")]
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
			[Address(RVA = "0x6EB108", Offset = "0x6EB108", VA = "0x6EB108")]
			public <>c__DisplayClass185_7()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x6EB110", Offset = "0x6EB110", VA = "0x6EB110")]
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
				[Address(RVA = "0x6F0270", Offset = "0x6F0270", VA = "0x6F0270", Slot = "4")]
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
				[Address(RVA = "0x6F02B8", Offset = "0x6F02B8", VA = "0x6F02B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x6E9FD8", Offset = "0x6E9FD8", VA = "0x6E9FD8")]
			[DebuggerHidden]
			public <ctPlayAudio>d__185(int <>1__state)
			{
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x6EB144", Offset = "0x6EB144", VA = "0x6EB144", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x6EB2B8", Offset = "0x6EB2B8", VA = "0x6EB2B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x6F008C", Offset = "0x6F008C", VA = "0x6F008C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x6EFE7C", Offset = "0x6EFE7C", VA = "0x6EFE7C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x6EFDCC", Offset = "0x6EFDCC", VA = "0x6EFDCC")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x6EFF2C", Offset = "0x6EFF2C", VA = "0x6EFF2C")]
			private void <>m__Finally4()
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x6EFFDC", Offset = "0x6EFFDC", VA = "0x6EFFDC")]
			private void <>m__Finally5()
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x6F0278", Offset = "0x6F0278", VA = "0x6F0278", Slot = "8")]
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
				[Address(RVA = "0x6F1264", Offset = "0x6F1264", VA = "0x6F1264", Slot = "4")]
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
				[Address(RVA = "0x6F12AC", Offset = "0x6F12AC", VA = "0x6F12AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x6EA62C", Offset = "0x6EA62C", VA = "0x6EA62C")]
			[DebuggerHidden]
			public <unityPlayAudio>d__193(int <>1__state)
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x6F02C0", Offset = "0x6F02C0", VA = "0x6F02C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x6F02E0", Offset = "0x6F02E0", VA = "0x6F02E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x6F11B4", Offset = "0x6F11B4", VA = "0x6F11B4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x6F126C", Offset = "0x6F126C", VA = "0x6F126C", Slot = "8")]
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
			[Address(RVA = "0x6DA678", Offset = "0x6DA678", VA = "0x6DA678")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x6E5C60", Offset = "0x6E5C60", VA = "0x6E5C60")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public override Record Record
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x6E5CB8", Offset = "0x6E5CB8", VA = "0x6E5CB8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x6E5CC0", Offset = "0x6E5CC0", VA = "0x6E5CC0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public bool PlayOnStart
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x6E5CC8", Offset = "0x6E5CC8", VA = "0x6E5CC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x6E5CD0", Offset = "0x6E5CD0", VA = "0x6E5CD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public float Delay
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x6E5CDC", Offset = "0x6E5CDC", VA = "0x6E5CDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x6E5CE4", Offset = "0x6E5CE4", VA = "0x6E5CE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public override bool HandleFocus
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x6E5CF0", Offset = "0x6E5CF0", VA = "0x6E5CF0", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x6E5CF8", Offset = "0x6E5CF8", VA = "0x6E5CF8", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public override bool Caching
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x6E5D04", Offset = "0x6E5D04", VA = "0x6E5D04", Slot = "15")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x6E5D0C", Offset = "0x6E5D0C", VA = "0x6E5D0C", Slot = "16")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public override bool Streaming
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x6E5D18", Offset = "0x6E5D18", VA = "0x6E5D18", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x6E5DAC", Offset = "0x6E5DAC", VA = "0x6E5DAC", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public override int ChunkSize
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x6E5DB8", Offset = "0x6E5DB8", VA = "0x6E5DB8", Slot = "19")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x6E5DC4", Offset = "0x6E5DC4", VA = "0x6E5DC4", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool UseAutomaticCacheStreamSize
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x6E5E68", Offset = "0x6E5E68", VA = "0x6E5E68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x6E5E70", Offset = "0x6E5E70", VA = "0x6E5E70")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public override int CacheStreamSize
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x6E5E7C", Offset = "0x6E5E7C", VA = "0x6E5E7C", Slot = "21")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x6E5E88", Offset = "0x6E5E88", VA = "0x6E5E88", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public override bool CaptureDataStream
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x6E5F24", Offset = "0x6E5F24", VA = "0x6E5F24", Slot = "23")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x6E5F2C", Offset = "0x6E5F2C", VA = "0x6E5F2C", Slot = "24")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public override bool ForceInternalMP3Codec
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x6E5F38", Offset = "0x6E5F38", VA = "0x6E5F38", Slot = "25")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x6E5FC4", Offset = "0x6E5FC4", VA = "0x6E5FC4", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public override bool ForceInternalOGGCodec
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x6E5FD0", Offset = "0x6E5FD0", VA = "0x6E5FD0", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x6E606C", Offset = "0x6E606C", VA = "0x6E606C", Slot = "28")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public bool InternalCodecsReadPCM
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x6E6078", Offset = "0x6E6078", VA = "0x6E6078")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x6E6080", Offset = "0x6E6080", VA = "0x6E6080")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public override bool isLoop
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x6E608C", Offset = "0x6E608C", VA = "0x6E608C", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x6E6120", Offset = "0x6E6120", VA = "0x6E6120", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public override AudioSource Source
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x6E61C4", Offset = "0x6E61C4", VA = "0x6E61C4", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x6E61CC", Offset = "0x6E61CC", VA = "0x6E61CC", Slot = "30")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public override float Position
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x6E624C", Offset = "0x6E624C", VA = "0x6E624C", Slot = "31")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x6E63D8", Offset = "0x6E63D8", VA = "0x6E63D8", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public override int SamplePosition
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x6E666C", Offset = "0x6E666C", VA = "0x6E666C", Slot = "33")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x6E67F8", Offset = "0x6E67F8", VA = "0x6E67F8", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public override float Elapsed
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x6E6994", Offset = "0x6E6994", VA = "0x6E6994", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x6E6BD0", Offset = "0x6E6BD0", VA = "0x6E6BD0", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public override float Duration
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x6E6E0C", Offset = "0x6E6E0C", VA = "0x6E6E0C", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000070")]
		public override int Samples
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x6E6E38", Offset = "0x6E6E38", VA = "0x6E6E38", Slot = "38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		public override int Channels
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x6E6FB4", Offset = "0x6E6FB4", VA = "0x6E6FB4", Slot = "51")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public override int SampleRate
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x6E6FD4", Offset = "0x6E6FD4", VA = "0x6E6FD4", Slot = "52")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000073")]
		public override AudioCodec Codec
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x6E6FF4", Offset = "0x6E6FF4", VA = "0x6E6FF4", Slot = "39")]
			get
			{
				return default(AudioCodec);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x6E6FFC", Offset = "0x6E6FFC", VA = "0x6E6FFC", Slot = "40")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public override float BufferProgress
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x6E7004", Offset = "0x6E7004", VA = "0x6E7004", Slot = "41")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x6E700C", Offset = "0x6E700C", VA = "0x6E700C", Slot = "42")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public override bool isPlayback
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x6E7014", Offset = "0x6E7014", VA = "0x6E7014", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		public override bool isAudioPlaying
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x6E701C", Offset = "0x6E701C", VA = "0x6E701C", Slot = "45")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x6E7024", Offset = "0x6E7024", VA = "0x6E7024", Slot = "46")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public override bool isBuffering
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x6E7030", Offset = "0x6E7030", VA = "0x6E7030", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public override bool isPaused
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x6E7040", Offset = "0x6E7040", VA = "0x6E7040", Slot = "47")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x6E7048", Offset = "0x6E7048", VA = "0x6E7048", Slot = "48")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public override Stream DataStream
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x6E70A4", Offset = "0x6E70A4", VA = "0x6E70A4", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x6E70AC", Offset = "0x6E70AC", VA = "0x6E70AC", Slot = "50")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public override float Volume
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x6E70BC", Offset = "0x6E70BC", VA = "0x6E70BC", Slot = "53")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x6E70F8", Offset = "0x6E70F8", VA = "0x6E70F8", Slot = "54")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public override float Pitch
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x6E7144", Offset = "0x6E7144", VA = "0x6E7144", Slot = "55")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x6E7180", Offset = "0x6E7180", VA = "0x6E7180", Slot = "56")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public override float StereoPan
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x6E71CC", Offset = "0x6E71CC", VA = "0x6E71CC", Slot = "57")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x6E7208", Offset = "0x6E7208", VA = "0x6E7208", Slot = "58")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public override bool isMuted
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x6E7254", Offset = "0x6E7254", VA = "0x6E7254", Slot = "59")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x6E7290", Offset = "0x6E7290", VA = "0x6E7290", Slot = "60")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public override List<Record> PlayedRecords
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x6E72D0", Offset = "0x6E72D0", VA = "0x6E72D0", Slot = "61")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		protected override PlaybackStartEvent onPlaybackStarted
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x6E72D8", Offset = "0x6E72D8", VA = "0x6E72D8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		protected override PlaybackEndEvent onPlaybackEnded
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x6E72E0", Offset = "0x6E72E0", VA = "0x6E72E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		protected override AudioStartEvent onAudioStarted
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x6E72E8", Offset = "0x6E72E8", VA = "0x6E72E8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		protected override AudioEndEvent onAudioEnded
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x6E72F0", Offset = "0x6E72F0", VA = "0x6E72F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		protected override ErrorEvent onError
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x6E72F8", Offset = "0x6E72F8", VA = "0x6E72F8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000F")]
		public event Cached OnCached
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x6E7300", Offset = "0x6E7300", VA = "0x6E7300")]
			add
			{
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x6E73A0", Offset = "0x6E73A0", VA = "0x6E73A0")]
			remove
			{
			}
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x6E7440", Offset = "0x6E7440", VA = "0x6E7440")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x6E7608", Offset = "0x6E7608", VA = "0x6E7608")]
		private void Start()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x6E769C", Offset = "0x6E769C", VA = "0x6E769C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x6E79A4", Offset = "0x6E79A4", VA = "0x6E79A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x6E79B4", Offset = "0x6E79B4", VA = "0x6E79B4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x6E7AB8", Offset = "0x6E7AB8", VA = "0x6E7AB8")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x6E7B8C", Offset = "0x6E7B8C", VA = "0x6E7B8C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x6E7DD0", Offset = "0x6E7DD0", VA = "0x6E7DD0")]
		public void Play(Record _record)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x6E7DFC", Offset = "0x6E7DFC", VA = "0x6E7DFC", Slot = "62")]
		public override void Play()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x6E88CC", Offset = "0x6E88CC", VA = "0x6E88CC")]
		public void Cache(Record _record)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x6E8908", Offset = "0x6E8908", VA = "0x6E8908")]
		public void Cache()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x6E8934", Offset = "0x6E8934", VA = "0x6E8934", Slot = "63")]
		public override void Next()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x6E8944", Offset = "0x6E8944", VA = "0x6E8944", Slot = "64")]
		public override void Previous()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x6E8954", Offset = "0x6E8954", VA = "0x6E8954", Slot = "65")]
		public override void Pause()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x6E8968", Offset = "0x6E8968", VA = "0x6E8968", Slot = "66")]
		public override void UnPause()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x6E897C", Offset = "0x6E897C", VA = "0x6E897C", Slot = "67")]
		public override void Stop()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x6E89E8", Offset = "0x6E89E8", VA = "0x6E89E8", Slot = "68")]
		public override void Restart()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x6E8AB4", Offset = "0x6E8AB4", VA = "0x6E8AB4", Slot = "69")]
		public override void Mute()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x6E8AC8", Offset = "0x6E8AC8", VA = "0x6E8AC8", Slot = "70")]
		public override void UnMute()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x6E7E04", Offset = "0x6E7E04", VA = "0x6E7E04")]
		private void playOrCache(bool cache = false)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x6E8DBC", Offset = "0x6E8DBC", VA = "0x6E8DBC")]
		private void logUnsupportedPlatform()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x6E8E78", Offset = "0x6E8E78", VA = "0x6E8E78")]
		private void logDataError(Exception ex)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x6E69E0", Offset = "0x6E69E0", VA = "0x6E69E0")]
		private float elapsedDuration()
		{
			return default(float);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x6E90E8", Offset = "0x6E90E8", VA = "0x6E90E8")]
		private void resetReaderPosition()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x6E9250", Offset = "0x6E9250", VA = "0x6E9250")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x6E94D4", Offset = "0x6E94D4", VA = "0x6E94D4")]
		private void timerTask(ref bool _playback)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x6E961C", Offset = "0x6E961C", VA = "0x6E961C")]
		private void readStream(ref Record _record, ref bool _playback, ref Stream _ms, ref bool _error, ref string _errorMessage, ref bool _buffered)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x6E9E4C", Offset = "0x6E9E4C", VA = "0x6E9E4C")]
		private static AudioType determineAudioType(AudioFormat audioFormat)
		{
			return default(AudioType);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x6E8D5C", Offset = "0x6E8D5C", VA = "0x6E8D5C")]
		private void ctPlay(bool cache)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x6E8AE4", Offset = "0x6E8AE4", VA = "0x6E8AE4")]
		private void ctPlayWithData(byte[] data, bool cache = false)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x6E9F3C", Offset = "0x6E9F3C", VA = "0x6E9F3C")]
		private IEnumerator ctPlayAudio(byte[] data, bool cache)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x6EA000", Offset = "0x6EA000", VA = "0x6EA000")]
		private void waitController(Record _record)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x6EA24C", Offset = "0x6EA24C", VA = "0x6EA24C")]
		private void readPCMNLayer(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x6EA450", Offset = "0x6EA450", VA = "0x6EA450")]
		private void readPCMNAudio(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x6EA460", Offset = "0x6EA460", VA = "0x6EA460")]
		private void readPCMNVorbis(out float[] pcmData, int duration)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x6EA37C", Offset = "0x6EA37C", VA = "0x6EA37C")]
		private void writeDataStream(float[] pcmData)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x6E8D90", Offset = "0x6E8D90", VA = "0x6E8D90")]
		private void unityPlay(bool cache)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x6E8D68", Offset = "0x6E8D68", VA = "0x6E8D68")]
		private void unityPlayWithClip(AudioClip clip, bool cache = false)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x6EA590", Offset = "0x6EA590", VA = "0x6EA590")]
		private IEnumerator unityPlayAudio(AudioClip clip, bool cache)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x6E7C74", Offset = "0x6E7C74", VA = "0x6E7C74")]
		protected void killWorker()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x6EA654", Offset = "0x6EA654", VA = "0x6EA654", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x6EAB60", Offset = "0x6EAB60", VA = "0x6EAB60", Slot = "74")]
		protected override void onPlaybackStart(Record _record)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x6EABF8", Offset = "0x6EABF8", VA = "0x6EABF8", Slot = "75")]
		protected override void onPlaybackEnd(Record _record)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x6EAC90", Offset = "0x6EAC90", VA = "0x6EAC90", Slot = "79")]
		protected override void onAudioStart(Record _record)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x6EAD34", Offset = "0x6EAD34", VA = "0x6EAD34", Slot = "80")]
		protected override void onAudioEnd(Record _record)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x6EADD8", Offset = "0x6EADD8", VA = "0x6EADD8", Slot = "84")]
		protected virtual void onCached(Record _record)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x6EAEEC", Offset = "0x6EAEEC", VA = "0x6EAEEC")]
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
			[Address(RVA = "0x6E8ADC", Offset = "0x6E8ADC", VA = "0x6E8ADC")]
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
		[Address(RVA = "0x6F15D0", Offset = "0x6F15D0", VA = "0x6F15D0")]
		static SetupProject()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x6F15D4", Offset = "0x6F15D4", VA = "0x6F15D4")]
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
			[Address(RVA = "0x6F4214", Offset = "0x6F4214", VA = "0x6F4214")]
			public <>c()
			{
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0x6F421C", Offset = "0x6F421C", VA = "0x6F421C")]
			internal double <get_TotalPlaytime>b__83_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0x6F43A0", Offset = "0x6F43A0", VA = "0x6F43A0")]
			internal long <get_TotalSize>b__85_0(Record record)
			{
				return default(long);
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x6F4410", Offset = "0x6F4410", VA = "0x6F4410")]
			internal double <PlaytimeRecords>b__95_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x6F4440", Offset = "0x6F4440", VA = "0x6F4440")]
			internal long <SizeRecords>b__96_0(Record record)
			{
				return default(long);
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x6F447C", Offset = "0x6F447C", VA = "0x6F447C")]
			internal string <RecordsByFilePath>b__97_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x6F4494", Offset = "0x6F4494", VA = "0x6F4494")]
			internal string <RecordsByFilePath>b__97_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021A")]
			[Address(RVA = "0x6F44AC", Offset = "0x6F44AC", VA = "0x6F44AC")]
			internal string <RecordsByFilePath>b__97_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x6F44C4", Offset = "0x6F44C4", VA = "0x6F44C4")]
			internal string <RecordsByFilePath>b__97_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x6F44DC", Offset = "0x6F44DC", VA = "0x6F44DC")]
			internal string <RecordsByName>b__98_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x6F47BC", Offset = "0x6F47BC", VA = "0x6F47BC")]
			internal string <RecordsByName>b__98_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x6F47D0", Offset = "0x6F47D0", VA = "0x6F47D0")]
			internal string <RecordsByName>b__98_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x6F47E4", Offset = "0x6F47E4", VA = "0x6F47E4")]
			internal string <RecordsByName>b__98_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x6F47F8", Offset = "0x6F47F8", VA = "0x6F47F8")]
			internal string <RecordsByTitle>b__99_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x6F4848", Offset = "0x6F4848", VA = "0x6F4848")]
			internal string <RecordsByTitle>b__99_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x6F4874", Offset = "0x6F4874", VA = "0x6F4874")]
			internal string <RecordsByTitle>b__99_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x6F48A0", Offset = "0x6F48A0", VA = "0x6F48A0")]
			internal string <RecordsByTitle>b__99_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x6F48CC", Offset = "0x6F48CC", VA = "0x6F48CC")]
			internal string <RecordsByArtist>b__100_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x6F491C", Offset = "0x6F491C", VA = "0x6F491C")]
			internal string <RecordsByArtist>b__100_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x6F4930", Offset = "0x6F4930", VA = "0x6F4930")]
			internal string <RecordsByArtist>b__100_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x6F495C", Offset = "0x6F495C", VA = "0x6F495C")]
			internal string <RecordsByArtist>b__100_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x6F4970", Offset = "0x6F4970", VA = "0x6F4970")]
			internal string <RecordsByArtist>b__100_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x6F499C", Offset = "0x6F499C", VA = "0x6F499C")]
			internal string <RecordsByArtist>b__100_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x6F49B0", Offset = "0x6F49B0", VA = "0x6F49B0")]
			internal string <RecordsByArtist>b__100_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x6F49DC", Offset = "0x6F49DC", VA = "0x6F49DC")]
			internal string <RecordsByArtist>b__100_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x6F49F0", Offset = "0x6F49F0", VA = "0x6F49F0")]
			internal string <RecordsByAlbum>b__101_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x6F4A40", Offset = "0x6F4A40", VA = "0x6F4A40")]
			internal string <RecordsByAlbum>b__101_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x6F4A54", Offset = "0x6F4A54", VA = "0x6F4A54")]
			internal string <RecordsByAlbum>b__101_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x6F4A80", Offset = "0x6F4A80", VA = "0x6F4A80")]
			internal string <RecordsByAlbum>b__101_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x6F4A94", Offset = "0x6F4A94", VA = "0x6F4A94")]
			internal string <RecordsByAlbum>b__101_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x6F4AC0", Offset = "0x6F4AC0", VA = "0x6F4AC0")]
			internal string <RecordsByAlbum>b__101_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x6F4AD4", Offset = "0x6F4AD4", VA = "0x6F4AD4")]
			internal string <RecordsByAlbum>b__101_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000233")]
			[Address(RVA = "0x6F4B00", Offset = "0x6F4B00", VA = "0x6F4B00")]
			internal string <RecordsByAlbum>b__101_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x6F4B14", Offset = "0x6F4B14", VA = "0x6F4B14")]
			internal string <RecordsByGenre>b__102_0(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x6F4B64", Offset = "0x6F4B64", VA = "0x6F4B64")]
			internal string <RecordsByGenre>b__102_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x6F4B78", Offset = "0x6F4B78", VA = "0x6F4B78")]
			internal string <RecordsByGenre>b__102_2(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x6F4BA4", Offset = "0x6F4BA4", VA = "0x6F4BA4")]
			internal string <RecordsByGenre>b__102_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x6F4BB8", Offset = "0x6F4BB8", VA = "0x6F4BB8")]
			internal string <RecordsByGenre>b__102_4(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x6F4BE4", Offset = "0x6F4BE4", VA = "0x6F4BE4")]
			internal string <RecordsByGenre>b__102_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x6F4BF8", Offset = "0x6F4BF8", VA = "0x6F4BF8")]
			internal string <RecordsByGenre>b__102_6(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x6F4C24", Offset = "0x6F4C24", VA = "0x6F4C24")]
			internal string <RecordsByGenre>b__102_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x6F4C38", Offset = "0x6F4C38", VA = "0x6F4C38")]
			internal float <RecordsByRating>b__103_0(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x6F4C50", Offset = "0x6F4C50", VA = "0x6F4C50")]
			internal string <RecordsByRating>b__103_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x6F4C64", Offset = "0x6F4C64", VA = "0x6F4C64")]
			internal float <RecordsByRating>b__103_2(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x6F4C7C", Offset = "0x6F4C7C", VA = "0x6F4C7C")]
			internal string <RecordsByRating>b__103_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x6F4C90", Offset = "0x6F4C90", VA = "0x6F4C90")]
			internal float <RecordsByRating>b__103_4(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x6F4CA8", Offset = "0x6F4CA8", VA = "0x6F4CA8")]
			internal string <RecordsByRating>b__103_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x6F4CBC", Offset = "0x6F4CBC", VA = "0x6F4CBC")]
			internal float <RecordsByRating>b__103_6(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x6F4CD4", Offset = "0x6F4CD4", VA = "0x6F4CD4")]
			internal string <RecordsByRating>b__103_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x6F4CE8", Offset = "0x6F4CE8", VA = "0x6F4CE8")]
			internal int <RecordsByYear>b__104_0(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x6F4D40", Offset = "0x6F4D40", VA = "0x6F4D40")]
			internal string <RecordsByYear>b__104_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000246")]
			[Address(RVA = "0x6F4D54", Offset = "0x6F4D54", VA = "0x6F4D54")]
			internal int <RecordsByYear>b__104_2(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x6F4D84", Offset = "0x6F4D84", VA = "0x6F4D84")]
			internal string <RecordsByYear>b__104_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000248")]
			[Address(RVA = "0x6F4D98", Offset = "0x6F4D98", VA = "0x6F4D98")]
			internal int <RecordsByYear>b__104_4(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0x6F4DC8", Offset = "0x6F4DC8", VA = "0x6F4DC8")]
			internal string <RecordsByYear>b__104_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024A")]
			[Address(RVA = "0x6F4DDC", Offset = "0x6F4DDC", VA = "0x6F4DDC")]
			internal int <RecordsByYear>b__104_6(Record entry)
			{
				return default(int);
			}

			[Token(Token = "0x600024B")]
			[Address(RVA = "0x6F4E0C", Offset = "0x6F4E0C", VA = "0x6F4E0C")]
			internal string <RecordsByYear>b__104_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0x6F4E20", Offset = "0x6F4E20", VA = "0x6F4E20")]
			internal float <RecordsByDuration>b__105_0(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024D")]
			[Address(RVA = "0x6F4E34", Offset = "0x6F4E34", VA = "0x6F4E34")]
			internal string <RecordsByDuration>b__105_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600024E")]
			[Address(RVA = "0x6F4E48", Offset = "0x6F4E48", VA = "0x6F4E48")]
			internal float <RecordsByDuration>b__105_2(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x6F4E5C", Offset = "0x6F4E5C", VA = "0x6F4E5C")]
			internal string <RecordsByDuration>b__105_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000250")]
			[Address(RVA = "0x6F4E70", Offset = "0x6F4E70", VA = "0x6F4E70")]
			internal float <RecordsByDuration>b__105_4(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x6F4E84", Offset = "0x6F4E84", VA = "0x6F4E84")]
			internal string <RecordsByDuration>b__105_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x6F4E98", Offset = "0x6F4E98", VA = "0x6F4E98")]
			internal float <RecordsByDuration>b__105_6(Record entry)
			{
				return default(float);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x6F4EAC", Offset = "0x6F4EAC", VA = "0x6F4EAC")]
			internal string <RecordsByDuration>b__105_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x6F4EC0", Offset = "0x6F4EC0", VA = "0x6F4EC0")]
			internal long <RecordsByFileSize>b__106_0(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x6F4EFC", Offset = "0x6F4EFC", VA = "0x6F4EFC")]
			internal string <RecordsByFileSize>b__106_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x6F4F10", Offset = "0x6F4F10", VA = "0x6F4F10")]
			internal long <RecordsByFileSize>b__106_2(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x6F4F4C", Offset = "0x6F4F4C", VA = "0x6F4F4C")]
			internal string <RecordsByFileSize>b__106_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x6F4F60", Offset = "0x6F4F60", VA = "0x6F4F60")]
			internal long <RecordsByFileSize>b__106_4(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x6F4F9C", Offset = "0x6F4F9C", VA = "0x6F4F9C")]
			internal string <RecordsByFileSize>b__106_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x6F4FB0", Offset = "0x6F4FB0", VA = "0x6F4FB0")]
			internal long <RecordsByFileSize>b__106_6(Record entry)
			{
				return default(long);
			}

			[Token(Token = "0x600025B")]
			[Address(RVA = "0x6F4FEC", Offset = "0x6F4FEC", VA = "0x6F4FEC")]
			internal string <RecordsByFileSize>b__106_7(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x6F5000", Offset = "0x6F5000", VA = "0x6F5000")]
			internal AudioFormat <RecordsByFormat>b__107_0(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x6F53C0", Offset = "0x6F53C0", VA = "0x6F53C0")]
			internal string <RecordsByFormat>b__107_1(Record entry)
			{
				return null;
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x6F53D4", Offset = "0x6F53D4", VA = "0x6F53D4")]
			internal AudioFormat <RecordsByFormat>b__107_2(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x6F53E8", Offset = "0x6F53E8", VA = "0x6F53E8")]
			internal string <RecordsByFormat>b__107_3(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x6F53FC", Offset = "0x6F53FC", VA = "0x6F53FC")]
			internal AudioFormat <RecordsByFormat>b__107_4(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x6F5410", Offset = "0x6F5410", VA = "0x6F5410")]
			internal string <RecordsByFormat>b__107_5(Record entry)
			{
				return null;
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x6F5424", Offset = "0x6F5424", VA = "0x6F5424")]
			internal AudioFormat <RecordsByFormat>b__107_6(Record entry)
			{
				return default(AudioFormat);
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x6F5438", Offset = "0x6F5438", VA = "0x6F5438")]
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
			[Address(RVA = "0x6F544C", Offset = "0x6F544C", VA = "0x6F544C")]
			public <>c__DisplayClass114_0()
			{
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x6F5454", Offset = "0x6F5454", VA = "0x6F5454")]
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
			[Address(RVA = "0x6F548C", Offset = "0x6F548C", VA = "0x6F548C")]
			public <>c__DisplayClass118_0()
			{
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x6F5494", Offset = "0x6F5494", VA = "0x6F5494")]
			internal bool <filterRecords>b__0(Record entry)
			{
				return default(bool);
			}

			[Token(Token = "0x6000268")]
			[Address(RVA = "0x6F59B8", Offset = "0x6F59B8", VA = "0x6F59B8")]
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
			[Address(RVA = "0x6F1650", Offset = "0x6F1650", VA = "0x6F1650")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x6F1658", Offset = "0x6F1658", VA = "0x6F1658")]
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
			[Address(RVA = "0x6DCB70", Offset = "0x6DCB70", VA = "0x6DCB70", Slot = "10")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000091")]
		public long TotalSize
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x6DCD14", Offset = "0x6DCD14", VA = "0x6DCD14", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000092")]
		public int CurrentRecordIndex
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x6F1854", Offset = "0x6F1854", VA = "0x6F1854", Slot = "12")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x6DCF44", Offset = "0x6DCF44", VA = "0x6DCF44", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public int CurrentRandomRecordIndex
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x6F185C", Offset = "0x6F185C", VA = "0x6F185C", Slot = "14")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x6DD0C8", Offset = "0x6DD0C8", VA = "0x6DD0C8", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event FilterChange OnFilterChange
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x6DB518", Offset = "0x6DB518", VA = "0x6DB518")]
			add
			{
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x6DBC44", Offset = "0x6DBC44", VA = "0x6DBC44")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x6DB5B8", Offset = "0x6DB5B8", VA = "0x6DB5B8")]
			add
			{
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x6DBCE4", Offset = "0x6DBCE4", VA = "0x6DBCE4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x6DB658", Offset = "0x6DB658", VA = "0x6DB658")]
			add
			{
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x6DBD84", Offset = "0x6DBD84", VA = "0x6DBD84")]
			remove
			{
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x6F16FC", Offset = "0x6F16FC", VA = "0x6F16FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x6F177C", Offset = "0x6F177C", VA = "0x6F177C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F1")]
		public abstract void Load();

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x6DD44C", Offset = "0x6DD44C", VA = "0x6DD44C", Slot = "17")]
		public List<Record> GetRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x6DD564", Offset = "0x6DD564", VA = "0x6DD564", Slot = "18")]
		public int CountRecords([Optional] RecordFilter _filter)
		{
			return default(int);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x6DD678", Offset = "0x6DD678", VA = "0x6DD678", Slot = "19")]
		public double PlaytimeRecords([Optional] RecordFilter _filter)
		{
			return default(double);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x6DD850", Offset = "0x6DD850", VA = "0x6DD850", Slot = "20")]
		public long SizeRecords([Optional] RecordFilter _filter)
		{
			return default(long);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x6DDBD8", Offset = "0x6DDBD8", VA = "0x6DDBD8", Slot = "21")]
		public List<Record> RecordsByFilePath(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x6DE498", Offset = "0x6DE498", VA = "0x6DE498", Slot = "22")]
		public List<Record> RecordsByName(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x6DED3C", Offset = "0x6DED3C", VA = "0x6DED3C", Slot = "23")]
		public List<Record> RecordsByTitle(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x6DF5E0", Offset = "0x6DF5E0", VA = "0x6DF5E0", Slot = "24")]
		public List<Record> RecordsByArtist(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x6E0138", Offset = "0x6E0138", VA = "0x6E0138", Slot = "25")]
		public List<Record> RecordsByAlbum(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x6E0C94", Offset = "0x6E0C94", VA = "0x6E0C94", Slot = "26")]
		public List<Record> RecordsByGenre(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x6E17F8", Offset = "0x6E17F8", VA = "0x6E17F8", Slot = "27")]
		public List<Record> RecordsByRating(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x6E2388", Offset = "0x6E2388", VA = "0x6E2388", Slot = "28")]
		public List<Record> RecordsByYear(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x6E2F18", Offset = "0x6E2F18", VA = "0x6E2F18", Slot = "29")]
		public List<Record> RecordsByDuration(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x6E3AA8", Offset = "0x6E3AA8", VA = "0x6E3AA8", Slot = "30")]
		public List<Record> RecordsByFileSize(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x6E4638", Offset = "0x6E4638", VA = "0x6E4638", Slot = "31")]
		public List<Record> RecordsByFormat(bool desc = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x6DC580", Offset = "0x6DC580", VA = "0x6DC580", Slot = "32")]
		public Record RecordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x6DDAE4", Offset = "0x6DDAE4", VA = "0x6DDAE4", Slot = "33")]
		public Record RecordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x6DD1C4", Offset = "0x6DD1C4", VA = "0x6DD1C4", Slot = "34")]
		public Record Next(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x6DD1F4", Offset = "0x6DD1F4", VA = "0x6DD1F4", Slot = "35")]
		public Record Previous(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x6DD2B8", Offset = "0x6DD2B8", VA = "0x6DD2B8", Slot = "36")]
		public void RandomizeRecords(bool resetIndex = true)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x6F1E88", Offset = "0x6F1E88", VA = "0x6F1E88")]
		private Record recordFromIndex(bool random = false, int index = -1, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x6F1FA8", Offset = "0x6F1FA8", VA = "0x6F1FA8")]
		private Record recordFromHashCode(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x6F20D4", Offset = "0x6F20D4", VA = "0x6F20D4")]
		private Record next(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x6F2208", Offset = "0x6F2208", VA = "0x6F2208")]
		private Record previous(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x6F1864", Offset = "0x6F1864", VA = "0x6F1864")]
		private RecordFilter getFilter(RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x6F18B8", Offset = "0x6F18B8", VA = "0x6F18B8")]
		private IEnumerable<Record> filterRecords(bool random = false, [Optional] RecordFilter _filter)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x6F232C", Offset = "0x6F232C", VA = "0x6F232C")]
		protected void clearFilters(bool clearLastFilter = true, bool clearLastRandomFilter = true)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x6F24F4", Offset = "0x6F24F4", VA = "0x6F24F4")]
		protected void resetFilterLists()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x6F2900", Offset = "0x6F2900", VA = "0x6F2900", Slot = "37")]
		protected virtual void onFilterChange()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x6F2A7C", Offset = "0x6F2A7C", VA = "0x6F2A7C", Slot = "38")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x6F2C10", Offset = "0x6F2C10", VA = "0x6F2C10", Slot = "39")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x6F2D68", Offset = "0x6F2D68", VA = "0x6F2D68")]
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
			[Address(RVA = "0x6F6E08", Offset = "0x6F6E08", VA = "0x6F6E08")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600027A")]
			[Address(RVA = "0x6F7BDC", Offset = "0x6F7BDC", VA = "0x6F7BDC")]
			internal IEnumerable<Record> <get_Records>b__2(BaseSet rs)
			{
				return null;
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x6F7CB4", Offset = "0x6F7CB4", VA = "0x6F7CB4")]
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
			[Address(RVA = "0x6F7D88", Offset = "0x6F7D88", VA = "0x6F7D88")]
			public <>c()
			{
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x6F7D90", Offset = "0x6F7D90", VA = "0x6F7D90")]
			internal bool <get_Records>b__14_1(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x6F7DEC", Offset = "0x6F7DEC", VA = "0x6F7DEC")]
			internal string <get_Records>b__14_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x6F7E04", Offset = "0x6F7E04", VA = "0x6F7E04")]
			internal bool <get_RandomRecords>b__16_1(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x6F7E60", Offset = "0x6F7E60", VA = "0x6F7E60")]
			internal string <get_RandomRecords>b__16_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x6F7E78", Offset = "0x6F7E78", VA = "0x6F7E78")]
			internal bool <get_isReady>b__18_0(BaseSet provider)
			{
				return default(bool);
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x6F7F00", Offset = "0x6F7F00", VA = "0x6F7F00")]
			internal bool <Load>b__21_0(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x6F7F84", Offset = "0x6F7F84", VA = "0x6F7F84")]
			internal bool <register>b__23_0(BaseSet rs)
			{
				return default(bool);
			}

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x6F7FE0", Offset = "0x6F7FE0", VA = "0x6F7FE0")]
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
			[Address(RVA = "0x6F74B4", Offset = "0x6F74B4", VA = "0x6F74B4")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x6F803C", Offset = "0x6F803C", VA = "0x6F803C")]
			internal IEnumerable<Record> <get_RandomRecords>b__2(BaseSet rs)
			{
				return null;
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x6F8114", Offset = "0x6F8114", VA = "0x6F8114")]
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
			[Address(RVA = "0x6F5D80", Offset = "0x6F5D80", VA = "0x6F5D80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x6F5D88", Offset = "0x6F5D88", VA = "0x6F5D88")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x6F674C", Offset = "0x6F674C", VA = "0x6F674C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		protected override FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x6F6754", Offset = "0x6F6754", VA = "0x6F6754", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x6F675C", Offset = "0x6F675C", VA = "0x6F675C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public override List<Record> Records
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x6F6764", Offset = "0x6F6764", VA = "0x6F6764", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public override List<Record> RandomRecords
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x6F6E10", Offset = "0x6F6E10", VA = "0x6F6E10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public override bool isReady
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x6F74BC", Offset = "0x6F74BC", VA = "0x6F74BC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x6F75D8", Offset = "0x6F75D8", VA = "0x6F75D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x6F75DC", Offset = "0x6F75DC", VA = "0x6F75DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x6F75E0", Offset = "0x6F75E0", VA = "0x6F75E0", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x6F7994", Offset = "0x6F7994", VA = "0x6F7994", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x6F6284", Offset = "0x6F6284", VA = "0x6F6284")]
		private void register()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x6F5DBC", Offset = "0x6F5DBC", VA = "0x6F5DBC")]
		private void unregister()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x6F7BAC", Offset = "0x6F7BAC", VA = "0x6F7BAC", Slot = "37")]
		protected override void onFilterChange()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x6F7BD4", Offset = "0x6F7BD4", VA = "0x6F7BD4")]
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
			[Address(RVA = "0x6F9140", Offset = "0x6F9140", VA = "0x6F9140")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x6FA210", Offset = "0x6FA210", VA = "0x6FA210")]
			internal IEnumerable<Record> <get_Records>b__2(BaseRecordProvider rp)
			{
				return null;
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x6FA2D8", Offset = "0x6FA2D8", VA = "0x6FA2D8")]
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
			[Address(RVA = "0x6FA3AC", Offset = "0x6FA3AC", VA = "0x6FA3AC")]
			public <>c()
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x6FA3B4", Offset = "0x6FA3B4", VA = "0x6FA3B4")]
			internal bool <get_Records>b__14_1(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x6FA434", Offset = "0x6FA434", VA = "0x6FA434")]
			internal string <get_Records>b__14_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x6FA44C", Offset = "0x6FA44C", VA = "0x6FA44C")]
			internal bool <get_RandomRecords>b__16_1(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x6FA4CC", Offset = "0x6FA4CC", VA = "0x6FA4CC")]
			internal string <get_RandomRecords>b__16_0(Record s)
			{
				return null;
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x6FA4E4", Offset = "0x6FA4E4", VA = "0x6FA4E4")]
			internal bool <get_isReady>b__18_0(BaseRecordProvider provider)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x6FA564", Offset = "0x6FA564", VA = "0x6FA564")]
			internal bool <Load>b__21_0(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x6FA5E8", Offset = "0x6FA5E8", VA = "0x6FA5E8")]
			internal bool <register>b__23_0(BaseRecordProvider rp)
			{
				return default(bool);
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x6FA644", Offset = "0x6FA644", VA = "0x6FA644")]
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
			[Address(RVA = "0x6F97EC", Offset = "0x6F97EC", VA = "0x6F97EC")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x6FA6A0", Offset = "0x6FA6A0", VA = "0x6FA6A0")]
			internal IEnumerable<Record> <get_RandomRecords>b__2(BaseRecordProvider rp)
			{
				return null;
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x6FA768", Offset = "0x6FA768", VA = "0x6FA768")]
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
			[Address(RVA = "0x6F8178", Offset = "0x6F8178", VA = "0x6F8178")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x6F8180", Offset = "0x6F8180", VA = "0x6F8180")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x6F8A84", Offset = "0x6F8A84", VA = "0x6F8A84", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		protected override FilterChangeEvent onFilterChanged
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x6F8A8C", Offset = "0x6F8A8C", VA = "0x6F8A8C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x6F8A94", Offset = "0x6F8A94", VA = "0x6F8A94", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public override List<Record> Records
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x6F8A9C", Offset = "0x6F8A9C", VA = "0x6F8A9C", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public override List<Record> RandomRecords
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x6F9148", Offset = "0x6F9148", VA = "0x6F9148", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public override bool isReady
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x6F97F4", Offset = "0x6F97F4", VA = "0x6F97F4", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x6F9910", Offset = "0x6F9910", VA = "0x6F9910")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x6F9914", Offset = "0x6F9914", VA = "0x6F9914")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x6F9918", Offset = "0x6F9918", VA = "0x6F9918", Slot = "16")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x6F9CD0", Offset = "0x6F9CD0", VA = "0x6F9CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x6F861C", Offset = "0x6F861C", VA = "0x6F861C")]
		private void register()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x6F81B4", Offset = "0x6F81B4", VA = "0x6F81B4")]
		private void unregister()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x6FA158", Offset = "0x6FA158", VA = "0x6FA158", Slot = "37")]
		protected override void onFilterChange()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x6FA208", Offset = "0x6FA208", VA = "0x6FA208")]
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
			[Address(RVA = "0x6FB9C4", Offset = "0x6FB9C4", VA = "0x6FB9C4")]
			public <>c()
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x6FB9CC", Offset = "0x6FB9CC", VA = "0x6FB9CC")]
			internal double <get_TotalPlaytime>b__48_0(double current, Record record)
			{
				return default(double);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x6FB9FC", Offset = "0x6FB9FC", VA = "0x6FB9FC")]
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
			[Address(RVA = "0x6FA7CC", Offset = "0x6FA7CC", VA = "0x6FA7CC", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x6FA7D4", Offset = "0x6FA7D4", VA = "0x6FA7D4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public bool ReadFileSize
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x6FA7E0", Offset = "0x6FA7E0", VA = "0x6FA7E0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x6FA7E8", Offset = "0x6FA7E8", VA = "0x6FA7E8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public bool AutoUpdate
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x6FA7F4", Offset = "0x6FA7F4", VA = "0x6FA7F4", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x6FA7FC", Offset = "0x6FA7FC", VA = "0x6FA7FC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool AutoUpdateInEditor
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x6FA808", Offset = "0x6FA808", VA = "0x6FA808")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x6FA810", Offset = "0x6FA810", VA = "0x6FA810")]
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
			[Address(RVA = "0x6FA92C", Offset = "0x6FA92C", VA = "0x6FA92C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x6FA934", Offset = "0x6FA934", VA = "0x6FA934")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public bool isReadFileSize
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x6FA940", Offset = "0x6FA940", VA = "0x6FA940")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x6FA948", Offset = "0x6FA948", VA = "0x6FA948")]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public bool isAutoUpdate
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x6FA954", Offset = "0x6FA954", VA = "0x6FA954")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x6FA95C", Offset = "0x6FA95C", VA = "0x6FA95C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public bool isReady
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x6FA968", Offset = "0x6FA968", VA = "0x6FA968", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x6FA970", Offset = "0x6FA970", VA = "0x6FA970", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public List<Record> Records
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x6FA97C", Offset = "0x6FA97C", VA = "0x6FA97C", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x6FA984", Offset = "0x6FA984", VA = "0x6FA984")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public double TotalPlaytime
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x6FA98C", Offset = "0x6FA98C", VA = "0x6FA98C", Slot = "17")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000AE")]
		public long TotalSize
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x6FAA94", Offset = "0x6FAA94", VA = "0x6FAA94", Slot = "18")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x14000013")]
		public event RecordsChange OnRecordsChange
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x6F9EE8", Offset = "0x6F9EE8", VA = "0x6F9EE8")]
			add
			{
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x6FA020", Offset = "0x6FA020", VA = "0x6FA020")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event ErrorProvider OnErrorProvider
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x6F9F84", Offset = "0x6F9F84", VA = "0x6F9F84")]
			add
			{
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x6FA0BC", Offset = "0x6FA0BC", VA = "0x6FA0BC")]
			remove
			{
			}
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x6FA81C", Offset = "0x6FA81C", VA = "0x6FA81C", Slot = "12")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x6FA884", Offset = "0x6FA884", VA = "0x6FA884", Slot = "13")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x6FAB98", Offset = "0x6FAB98", VA = "0x6FAB98", Slot = "19")]
		public virtual void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x60002C6")]
		protected abstract void load();

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x6FAC80", Offset = "0x6FAC80", VA = "0x6FAC80")]
		protected static string determineAudioFormatExtension(AudioFormat audioFormat = AudioFormat.MP3)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x6FADF4", Offset = "0x6FADF4", VA = "0x6FADF4")]
		protected void fillRecords(string[] list)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x6FB388", Offset = "0x6FB388", VA = "0x6FB388", Slot = "21")]
		protected virtual void onRecordsChange()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x6FB4A8", Offset = "0x6FB4A8", VA = "0x6FB4A8", Slot = "22")]
		protected virtual void onErrorProvider(string info)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x6FB600", Offset = "0x6FB600", VA = "0x6FB600")]
		protected BaseRecordProvider()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x6FB690", Offset = "0x6FB690", VA = "0x6FB690")]
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
			[Address(RVA = "0x6FBA38", Offset = "0x6FBA38", VA = "0x6FBA38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x6FBA40", Offset = "0x6FBA40", VA = "0x6FBA40")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public bool hasDBFile
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x6FBAE4", Offset = "0x6FBAE4", VA = "0x6FBAE4", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public string DBFilePath
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x6FBAF8", Offset = "0x6FBAF8", VA = "0x6FBAF8", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x6FBA4C", Offset = "0x6FBA4C", VA = "0x6FBA4C", Slot = "23")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x6FBB6C", Offset = "0x6FBB6C", VA = "0x6FBB6C", Slot = "19")]
		public override void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x6FBCC0", Offset = "0x6FBCC0", VA = "0x6FBCC0", Slot = "26")]
		public virtual void SaveDB(string filePath = "")
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x6FBD38", Offset = "0x6FBD38", VA = "0x6FBD38", Slot = "27")]
		public virtual void LoadDB(string filePath = "")
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x6FBDE0", Offset = "0x6FBDE0", VA = "0x6FBDE0", Slot = "28")]
		public void DeleteDB()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x6FBCA4", Offset = "0x6FBCA4", VA = "0x6FBCA4")]
		private void loadFile()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x6FBD48", Offset = "0x6FBD48", VA = "0x6FBD48")]
		private void loadFile(string filePath)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x6FBF24", Offset = "0x6FBF24", VA = "0x6FBF24")]
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
			[Address(RVA = "0x6FC634", Offset = "0x6FC634", VA = "0x6FC634")]
			public <>c()
			{
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x6FC63C", Offset = "0x6FC63C", VA = "0x6FC63C")]
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
			[Address(RVA = "0x6FBF30", Offset = "0x6FBF30", VA = "0x6FBF30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x6FBF38", Offset = "0x6FBF38", VA = "0x6FBF38")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x6FC004", Offset = "0x6FC004", VA = "0x6FC004", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x6FC00C", Offset = "0x6FC00C", VA = "0x6FC00C", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x6FC014", Offset = "0x6FC014", VA = "0x6FC014", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x6FC540", Offset = "0x6FC540", VA = "0x6FC540")]
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
			[Address(RVA = "0x6FCD40", Offset = "0x6FCD40", VA = "0x6FCD40")]
			public <>c()
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x6FCD48", Offset = "0x6FCD48", VA = "0x6FCD48")]
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
			[Address(RVA = "0x6FC698", Offset = "0x6FC698", VA = "0x6FC698")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x6FC6A0", Offset = "0x6FC6A0", VA = "0x6FC6A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x6FC76C", Offset = "0x6FC76C", VA = "0x6FC76C", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x6FC774", Offset = "0x6FC774", VA = "0x6FC774", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x6FC77C", Offset = "0x6FC77C", VA = "0x6FC77C", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x6FCC4C", Offset = "0x6FCC4C", VA = "0x6FCC4C")]
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
				[Address(RVA = "0x6FE900", Offset = "0x6FE900", VA = "0x6FE900", Slot = "4")]
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
				[Address(RVA = "0x6FE948", Offset = "0x6FE948", VA = "0x6FE948", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x6FD96C", Offset = "0x6FD96C", VA = "0x6FD96C")]
			[DebuggerHidden]
			public <scan>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x6FE700", Offset = "0x6FE700", VA = "0x6FE700", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x6FE704", Offset = "0x6FE704", VA = "0x6FE704", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x6FE908", Offset = "0x6FE908", VA = "0x6FE908", Slot = "8")]
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
				[Address(RVA = "0x6FF1BC", Offset = "0x6FF1BC", VA = "0x6FF1BC", Slot = "4")]
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
				[Address(RVA = "0x6FF204", Offset = "0x6FF204", VA = "0x6FF204", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x6FD994", Offset = "0x6FD994", VA = "0x6FD994")]
			[DebuggerHidden]
			public <scanWindows>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x6FE950", Offset = "0x6FE950", VA = "0x6FE950", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x6FE96C", Offset = "0x6FE96C", VA = "0x6FE96C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x6FF10C", Offset = "0x6FF10C", VA = "0x6FF10C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x6FF1C4", Offset = "0x6FF1C4", VA = "0x6FF1C4", Slot = "8")]
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
				[Address(RVA = "0x6FFE6C", Offset = "0x6FFE6C", VA = "0x6FFE6C", Slot = "4")]
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
				[Address(RVA = "0x6FFEB4", Offset = "0x6FFEB4", VA = "0x6FFEB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x6FD9BC", Offset = "0x6FD9BC", VA = "0x6FD9BC")]
			[DebuggerHidden]
			public <scanUnix>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x6FF20C", Offset = "0x6FF20C", VA = "0x6FF20C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x6FF228", Offset = "0x6FF228", VA = "0x6FF228", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x6FFDBC", Offset = "0x6FFDBC", VA = "0x6FFDBC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x6FFE74", Offset = "0x6FFE74", VA = "0x6FFE74", Slot = "8")]
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
			[Address(RVA = "0x6FCD68", Offset = "0x6FCD68", VA = "0x6FCD68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x6FCD70", Offset = "0x6FCD70", VA = "0x6FCD70")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public string Path
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x6FCD7C", Offset = "0x6FCD7C", VA = "0x6FCD7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x6FCD84", Offset = "0x6FCD84", VA = "0x6FCD84")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public AudioFormat Format
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x6FCE90", Offset = "0x6FCE90", VA = "0x6FCE90")]
			get
			{
				return default(AudioFormat);
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x6FCE98", Offset = "0x6FCE98", VA = "0x6FCE98")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public bool Recursive
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x6FCF70", Offset = "0x6FCF70", VA = "0x6FCF70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x6FCF78", Offset = "0x6FCF78", VA = "0x6FCF78")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public bool SlowAndSave
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x6FCF84", Offset = "0x6FCF84", VA = "0x6FCF84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x6FCF8C", Offset = "0x6FCF8C", VA = "0x6FCF8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public bool WatchDog
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x6FCF98", Offset = "0x6FCF98", VA = "0x6FCF98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x6FCFA0", Offset = "0x6FCFA0", VA = "0x6FCFA0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x6FCFAC", Offset = "0x6FCFAC", VA = "0x6FCFAC", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x6FCFB4", Offset = "0x6FCFB4", VA = "0x6FCFB4", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public string Extension
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x6FCFBC", Offset = "0x6FCFBC", VA = "0x6FCFBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x6FCFC4", Offset = "0x6FCFC4", VA = "0x6FCFC4", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x6FD2B0", Offset = "0x6FD2B0", VA = "0x6FD2B0", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x6FD42C", Offset = "0x6FD42C", VA = "0x6FD42C")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x6FD4C8", Offset = "0x6FD4C8", VA = "0x6FD4C8", Slot = "19")]
		public override void Load(bool forceReload = false)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x6FD58C", Offset = "0x6FD58C", VA = "0x6FD58C", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x6FD0D4", Offset = "0x6FD0D4", VA = "0x6FD0D4")]
		private void setMusicLibrary()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x6FD8F8", Offset = "0x6FD8F8", VA = "0x6FD8F8")]
		private IEnumerator scan()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x6FD810", Offset = "0x6FD810", VA = "0x6FD810")]
		private IEnumerator scanWindows()
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x6FD884", Offset = "0x6FD884", VA = "0x6FD884")]
		private IEnumerator scanUnix()
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x6FD9E4", Offset = "0x6FD9E4", VA = "0x6FD9E4")]
		private void watch()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x6FDC3C", Offset = "0x6FDC3C", VA = "0x6FDC3C")]
		private void onDeleted(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x6FDD80", Offset = "0x6FDD80", VA = "0x6FDD80")]
		private void onCreated(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x6FDEC4", Offset = "0x6FDEC4", VA = "0x6FDEC4")]
		private void onRenamed(object source, RenamedEventArgs e)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x6FE008", Offset = "0x6FE008", VA = "0x6FE008")]
		private void onChanged(object source, FileSystemEventArgs e)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x6FE14C", Offset = "0x6FE14C", VA = "0x6FE14C")]
		private void scanOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x6FE2B0", Offset = "0x6FE2B0", VA = "0x6FE2B0")]
		private void readPath()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x6FE6E8", Offset = "0x6FE6E8", VA = "0x6FE6E8")]
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
				[Address(RVA = "0x701F20", Offset = "0x701F20", VA = "0x701F20", Slot = "4")]
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
				[Address(RVA = "0x701F68", Offset = "0x701F68", VA = "0x701F68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x7002DC", Offset = "0x7002DC", VA = "0x7002DC")]
			[DebuggerHidden]
			public <readFileM3U>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0x701764", Offset = "0x701764", VA = "0x701764", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x701780", Offset = "0x701780", VA = "0x701780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x701E70", Offset = "0x701E70", VA = "0x701E70")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x701F28", Offset = "0x701F28", VA = "0x701F28", Slot = "8")]
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
				[Address(RVA = "0x70272C", Offset = "0x70272C", VA = "0x70272C", Slot = "4")]
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
				[Address(RVA = "0x702774", Offset = "0x702774", VA = "0x702774", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x700C80", Offset = "0x700C80", VA = "0x700C80")]
			[DebuggerHidden]
			public <readFilePLS>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x701F70", Offset = "0x701F70", VA = "0x701F70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x701F8C", Offset = "0x701F8C", VA = "0x701F8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x70267C", Offset = "0x70267C", VA = "0x70267C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x702734", Offset = "0x702734", VA = "0x702734", Slot = "8")]
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
			[Address(RVA = "0x6FFEBC", Offset = "0x6FFEBC", VA = "0x6FFEBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x6FFEC4", Offset = "0x6FFEC4", VA = "0x6FFEC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		protected override RecordsChangeEvent onRecordsChanged
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x6FFF90", Offset = "0x6FFF90", VA = "0x6FFF90", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		protected override ErrorProviderEvent onErrorProviderInfo
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x6FFF98", Offset = "0x6FFF98", VA = "0x6FFF98", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public PlayListFormat Format
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x6FFFA0", Offset = "0x6FFFA0", VA = "0x6FFFA0")]
			get
			{
				return default(PlayListFormat);
			}
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x7000CC", Offset = "0x7000CC", VA = "0x7000CC", Slot = "12")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x70018C", Offset = "0x70018C", VA = "0x70018C", Slot = "23")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x7001B0", Offset = "0x7001B0", VA = "0x7001B0", Slot = "20")]
		protected override void load()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x700268", Offset = "0x700268", VA = "0x700268")]
		private IEnumerator readFileM3U()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x700304", Offset = "0x700304", VA = "0x700304")]
		private void parseM3U(string text)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x7001F4", Offset = "0x7001F4", VA = "0x7001F4")]
		private IEnumerator readFilePLS()
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x700CA8", Offset = "0x700CA8", VA = "0x700CA8")]
		private void parsePLS(string text)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x701660", Offset = "0x701660", VA = "0x701660")]
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
			[Address(RVA = "0x70277C", Offset = "0x70277C", VA = "0x70277C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x702784", Offset = "0x702784", VA = "0x702784")]
			set
			{
			}
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x7027A0", Offset = "0x7027A0", VA = "0x7027A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x7029FC", Offset = "0x7029FC", VA = "0x7029FC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x702B78", Offset = "0x702B78", VA = "0x702B78", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x702BD0", Offset = "0x702BD0", VA = "0x702BD0")]
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
			[Address(RVA = "0x702BF0", Offset = "0x702BF0", VA = "0x702BF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x702BF8", Offset = "0x702BF8", VA = "0x702BF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public float EndPosition
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x702C18", Offset = "0x702C18", VA = "0x702C18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x702C20", Offset = "0x702C20", VA = "0x702C20")]
			set
			{
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x702C40", Offset = "0x702C40", VA = "0x702C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x702F90", Offset = "0x702F90", VA = "0x702F90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x703164", Offset = "0x703164", VA = "0x703164", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x7031F0", Offset = "0x7031F0", VA = "0x7031F0")]
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
		[Address(RVA = "0x703210", Offset = "0x703210", VA = "0x703210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x7033EC", Offset = "0x7033EC", VA = "0x7033EC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x70350C", Offset = "0x70350C", VA = "0x70350C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x700C28", Offset = "0x700C28", VA = "0x700C28")]
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
		[Address(RVA = "0x703568", Offset = "0x703568", VA = "0x703568", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x703744", Offset = "0x703744", VA = "0x703744", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x703864", Offset = "0x703864", VA = "0x703864", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x701608", Offset = "0x701608", VA = "0x701608")]
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
				[Address(RVA = "0x706138", Offset = "0x706138", VA = "0x706138", Slot = "4")]
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
				[Address(RVA = "0x706180", Offset = "0x706180", VA = "0x706180", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037B")]
			[Address(RVA = "0x705468", Offset = "0x705468", VA = "0x705468")]
			[DebuggerHidden]
			public <readSize>d__96(int <>1__state)
			{
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x705DF8", Offset = "0x705DF8", VA = "0x705DF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x705E14", Offset = "0x705E14", VA = "0x705E14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x706088", Offset = "0x706088", VA = "0x706088")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x706140", Offset = "0x706140", VA = "0x706140", Slot = "8")]
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
			[Address(RVA = "0x7038C0", Offset = "0x7038C0", VA = "0x7038C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x7038C8", Offset = "0x7038C8", VA = "0x7038C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public bool isFileSizeLoaded
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x7038D4", Offset = "0x7038D4", VA = "0x7038D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x7038DC", Offset = "0x7038DC", VA = "0x7038DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public bool isLocalFile
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x7038E8", Offset = "0x7038E8", VA = "0x7038E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D5")]
		public string Name
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x6F44F0", Offset = "0x6F44F0", VA = "0x6F44F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public string Title
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x6F4824", Offset = "0x6F4824", VA = "0x6F4824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public string Artist
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x6F48F8", Offset = "0x6F48F8", VA = "0x6F48F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public string Album
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x6F4A1C", Offset = "0x6F4A1C", VA = "0x6F4A1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public float Duration
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x6F424C", Offset = "0x6F424C", VA = "0x6F424C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x703FC4", Offset = "0x703FC4", VA = "0x703FC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public string Genre
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x6F4B40", Offset = "0x6F4B40", VA = "0x6F4B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public int Year
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x6F4D18", Offset = "0x6F4D18", VA = "0x6F4D18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000DC")]
		public string Url
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x703FD0", Offset = "0x703FD0", VA = "0x703FD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public long FileSize
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x6F43DC", Offset = "0x6F43DC", VA = "0x6F43DC")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170000DE")]
		public bool HasTag
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x704614", Offset = "0x704614", VA = "0x704614")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public Tag Tag
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x7046C8", Offset = "0x7046C8", VA = "0x7046C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		public AudioFormat Format
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x6F5014", Offset = "0x6F5014", VA = "0x6F5014")]
			get
			{
				return default(AudioFormat);
			}
		}

		[Token(Token = "0x170000E1")]
		public string SpotifyUrl
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x7052C0", Offset = "0x7052C0", VA = "0x7052C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		public int Bitrate
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x6F585C", Offset = "0x6F585C", VA = "0x6F585C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E3")]
		private bool hasID3Tag
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x704668", Offset = "0x704668", VA = "0x704668")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E4")]
		private bool hasXiphComment
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x704680", Offset = "0x704680", VA = "0x704680")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E5")]
		private bool hasM4ATag
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x7046B0", Offset = "0x7046B0", VA = "0x7046B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		private bool hasAiffTag
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x704698", Offset = "0x704698", VA = "0x704698")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x7053C4", Offset = "0x7053C4", VA = "0x7053C4")]
		public Record()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x6FB714", Offset = "0x6FB714", VA = "0x6FB714")]
		public Record(string filePath, bool loadTag = false, bool readFileSize = false)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x700C30", Offset = "0x700C30", VA = "0x700C30")]
		public Record(M3UEntry entry, bool loadTag, bool readFileSize)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x701610", Offset = "0x701610", VA = "0x701610")]
		public Record(PLSEntry entry, bool loadTag, bool readFileSize)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x6FC4F8", Offset = "0x6FC4F8", VA = "0x6FC4F8")]
		public Record(AudioClip clip)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x703964", Offset = "0x703964", VA = "0x703964")]
		private void parseInfo()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x7052E4", Offset = "0x7052E4", VA = "0x7052E4")]
		private void parseSpotifyUrl()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x704068", Offset = "0x704068", VA = "0x704068")]
		private void readFileSize()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x7053F4", Offset = "0x7053F4", VA = "0x7053F4")]
		private IEnumerator readSize()
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x704714", Offset = "0x704714", VA = "0x704714")]
		private void loadTag()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x705490", Offset = "0x705490", VA = "0x705490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x7055D0", Offset = "0x7055D0", VA = "0x7055D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x7056C4", Offset = "0x7056C4", VA = "0x7056C4", Slot = "3")]
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
			[Address(RVA = "0x706188", Offset = "0x706188", VA = "0x706188")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x706190", Offset = "0x706190", VA = "0x706190")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public float RatingMax
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x7061B0", Offset = "0x7061B0", VA = "0x7061B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x7061B8", Offset = "0x7061B8", VA = "0x7061B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public int YearMin
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x7061D8", Offset = "0x7061D8", VA = "0x7061D8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x7061E0", Offset = "0x7061E0", VA = "0x7061E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public int YearMax
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x7061F8", Offset = "0x7061F8", VA = "0x7061F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x706200", Offset = "0x706200", VA = "0x706200")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public int BitrateMin
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x70621C", Offset = "0x70621C", VA = "0x70621C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x706224", Offset = "0x706224", VA = "0x706224")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public int BitrateMax
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x706244", Offset = "0x706244", VA = "0x706244")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x70624C", Offset = "0x70624C", VA = "0x70624C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public bool isFiltering
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x70626C", Offset = "0x70626C", VA = "0x70626C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x706350", Offset = "0x706350", VA = "0x706350")]
		public RecordFilter()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x70645C", Offset = "0x70645C", VA = "0x70645C")]
		public RecordFilter(RecordFilter filter)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x7066D8", Offset = "0x7066D8", VA = "0x7066D8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x706908", Offset = "0x706908", VA = "0x706908", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x706A14", Offset = "0x706A14", VA = "0x706A14", Slot = "3")]
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
			[Address(RVA = "0x707EAC", Offset = "0x707EAC", VA = "0x707EAC")]
			public <>c()
			{
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x707EB4", Offset = "0x707EB4", VA = "0x707EB4")]
			internal bool <searchBpm>b__18_0(BpmMatchData x)
			{
				return default(bool);
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x708004", Offset = "0x708004", VA = "0x708004")]
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
			[Address(RVA = "0x706F4C", Offset = "0x706F4C", VA = "0x706F4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x706F54", Offset = "0x706F54", VA = "0x706F54")]
			private set
			{
			}
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x706F5C", Offset = "0x706F5C", VA = "0x706F5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x707150", Offset = "0x707150", VA = "0x707150")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x707224", Offset = "0x707224", VA = "0x707224")]
		public int AnalyzeBPM()
		{
			return default(int);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x707380", Offset = "0x707380", VA = "0x707380")]
		public static int AnalyzeBPM(float[] data, int frequency = 44100, int channels = 2, int sampleSplit = 100)
		{
			return default(int);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x707B44", Offset = "0x707B44", VA = "0x707B44")]
		public static int AnalyzeBPM(AudioClip clip, int sampleSplit = 100)
		{
			return default(int);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x7072F0", Offset = "0x7072F0", VA = "0x7072F0")]
		private static float[] getData(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x70757C", Offset = "0x70757C", VA = "0x70757C")]
		private static float[] createVolumeArray(float[] allSamples, int frequency, int channels, int splitFrameSize)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x707744", Offset = "0x707744", VA = "0x707744")]
		private static int searchBpm(float[] volumeArr, int frequency, int splitFrameSize)
		{
			return default(int);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x707CA8", Offset = "0x707CA8", VA = "0x707CA8")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x707DB8", Offset = "0x707DB8", VA = "0x707DB8")]
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
			[Address(RVA = "0x708010", Offset = "0x708010", VA = "0x708010")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x708018", Offset = "0x708018", VA = "0x708018")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public AudioClip LastAudioClip
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x708474", Offset = "0x708474", VA = "0x708474")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x70847C", Offset = "0x70847C", VA = "0x70847C")]
			private set
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event LoadClipStart OnLoadClipStart
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x708484", Offset = "0x708484", VA = "0x708484")]
			add
			{
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x708520", Offset = "0x708520", VA = "0x708520")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event LoadClipEnd OnLoadClipEnd
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x7085BC", Offset = "0x7085BC", VA = "0x7085BC")]
			add
			{
			}
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x708658", Offset = "0x708658", VA = "0x708658")]
			remove
			{
			}
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x7086F4", Offset = "0x7086F4", VA = "0x7086F4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x708830", Offset = "0x708830", VA = "0x708830")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x708834", Offset = "0x708834", VA = "0x708834")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x708838", Offset = "0x708838", VA = "0x708838")]
		public void LoadClip(Record record)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x708908", Offset = "0x708908", VA = "0x708908")]
		public void LoadClip(string filePath)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x7082D4", Offset = "0x7082D4", VA = "0x7082D4")]
		private void register()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x708134", Offset = "0x708134", VA = "0x708134")]
		private void unregister()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x708980", Offset = "0x708980", VA = "0x708980")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x708BBC", Offset = "0x708BBC", VA = "0x708BBC")]
		private void onPlaybackStart(Record record)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x708BE0", Offset = "0x708BE0", VA = "0x708BE0")]
		private void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x708BE8", Offset = "0x708BE8", VA = "0x708BE8")]
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
		[Address(RVA = "0x708E94", Offset = "0x708E94", VA = "0x708E94")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x708EF4", Offset = "0x708EF4", VA = "0x708EF4")]
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
			[Address(RVA = "0x708EFC", Offset = "0x708EFC", VA = "0x708EFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x70902C", Offset = "0x70902C", VA = "0x70902C")]
			set
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x709200", Offset = "0x709200", VA = "0x709200")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x709368", Offset = "0x709368", VA = "0x709368")]
		public CrossFader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class EventPositionReachedEvent : UnityEvent
	{
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x709378", Offset = "0x709378", VA = "0x709378")]
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
			[Address(RVA = "0x709380", Offset = "0x709380", VA = "0x709380")]
			get
			{
				return default(PointMode);
			}
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x709398", Offset = "0x709398", VA = "0x709398")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public float StartTimePosition
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x7093A8", Offset = "0x7093A8", VA = "0x7093A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x7093C0", Offset = "0x7093C0", VA = "0x7093C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public float EventPosition
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x7093D4", Offset = "0x7093D4", VA = "0x7093D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x7093EC", Offset = "0x7093EC", VA = "0x7093EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public int EventSamplePosition
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x709414", Offset = "0x709414", VA = "0x709414")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x70942C", Offset = "0x70942C", VA = "0x70942C")]
			set
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event EventPositionReached OnEventPositionReached
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x709490", Offset = "0x709490", VA = "0x709490")]
			add
			{
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x70952C", Offset = "0x70952C", VA = "0x70952C")]
			remove
			{
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x7095C8", Offset = "0x7095C8", VA = "0x7095C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x709680", Offset = "0x709680", VA = "0x709680")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x709960", Offset = "0x709960", VA = "0x709960")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x7097A4", Offset = "0x7097A4", VA = "0x7097A4")]
		private void onEventPositionReached(Record record, EventPoint ep)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x7099B0", Offset = "0x7099B0", VA = "0x7099B0")]
		public Eventer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class LoopPositionReachedEvent : UnityEvent
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x709B0C", Offset = "0x709B0C", VA = "0x709B0C")]
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
			[Address(RVA = "0x709B14", Offset = "0x709B14", VA = "0x709B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x709B1C", Offset = "0x709B1C", VA = "0x709B1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public LoopPoint Loop
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x709C8C", Offset = "0x709C8C", VA = "0x709C8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x709C94", Offset = "0x709C94", VA = "0x709C94")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public bool EnableStartPosition
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x709C9C", Offset = "0x709C9C", VA = "0x709C9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x709CA4", Offset = "0x709CA4", VA = "0x709CA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public PointMode Mode
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x709CB0", Offset = "0x709CB0", VA = "0x709CB0")]
			get
			{
				return default(PointMode);
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x709CC8", Offset = "0x709CC8", VA = "0x709CC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float StartTimePosition
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x709CD8", Offset = "0x709CD8", VA = "0x709CD8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x709CF0", Offset = "0x709CF0", VA = "0x709CF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public float EndTimePosition
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x709D04", Offset = "0x709D04", VA = "0x709D04")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x709D1C", Offset = "0x709D1C", VA = "0x709D1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public float StartPosition
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x709D30", Offset = "0x709D30", VA = "0x709D30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x709D48", Offset = "0x709D48", VA = "0x709D48")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public float EndPosition
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x709D80", Offset = "0x709D80", VA = "0x709D80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x709D98", Offset = "0x709D98", VA = "0x709D98")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public int StartSamplePosition
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x709DC8", Offset = "0x709DC8", VA = "0x709DC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x709DE0", Offset = "0x709DE0", VA = "0x709DE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public int EndSamplePosition
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x709E44", Offset = "0x709E44", VA = "0x709E44")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x709E5C", Offset = "0x709E5C", VA = "0x709E5C")]
			set
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event LoopPositionReached OnLoopPositionReached
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x709EC0", Offset = "0x709EC0", VA = "0x709EC0")]
			add
			{
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x709F5C", Offset = "0x709F5C", VA = "0x709F5C")]
			remove
			{
			}
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x709FF8", Offset = "0x709FF8", VA = "0x709FF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x70A0CC", Offset = "0x70A0CC", VA = "0x70A0CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x70A1A0", Offset = "0x70A1A0", VA = "0x70A1A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x70A518", Offset = "0x70A518", VA = "0x70A518")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x70A5E0", Offset = "0x70A5E0", VA = "0x70A5E0")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x70A360", Offset = "0x70A360", VA = "0x70A360")]
		private void onLoopPositionReached(Record record, LoopPoint lp)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x70A66C", Offset = "0x70A66C", VA = "0x70A66C")]
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
			[Address(RVA = "0x70A674", Offset = "0x70A674", VA = "0x70A674")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x70A67C", Offset = "0x70A67C", VA = "0x70A67C")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public bool SilenceSource
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x70A76C", Offset = "0x70A76C", VA = "0x70A76C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x70A774", Offset = "0x70A774", VA = "0x70A774")]
			set
			{
			}
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x70A7A4", Offset = "0x70A7A4", VA = "0x70A7A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x70A824", Offset = "0x70A824", VA = "0x70A824")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x70A8DC", Offset = "0x70A8DC", VA = "0x70A8DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x70AA14", Offset = "0x70AA14", VA = "0x70AA14")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x70ACD8", Offset = "0x70ACD8", VA = "0x70ACD8")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x70AEF8", Offset = "0x70AEF8", VA = "0x70AEF8")]
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
				[Address(RVA = "0x70BE00", Offset = "0x70BE00", VA = "0x70BE00", Slot = "4")]
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
				[Address(RVA = "0x70BE48", Offset = "0x70BE48", VA = "0x70BE48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x70BA58", Offset = "0x70BA58", VA = "0x70BA58")]
			[DebuggerHidden]
			public <faderA>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x70BB88", Offset = "0x70BB88", VA = "0x70BB88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x70BB8C", Offset = "0x70BB8C", VA = "0x70BB8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x70BE08", Offset = "0x70BE08", VA = "0x70BE08", Slot = "8")]
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
				[Address(RVA = "0x70C0C8", Offset = "0x70C0C8", VA = "0x70C0C8", Slot = "4")]
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
				[Address(RVA = "0x70C110", Offset = "0x70C110", VA = "0x70C110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x70BA80", Offset = "0x70BA80", VA = "0x70BA80")]
			[DebuggerHidden]
			public <faderB>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x70BE50", Offset = "0x70BE50", VA = "0x70BE50", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x70BE54", Offset = "0x70BE54", VA = "0x70BE54", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x70C0D0", Offset = "0x70C0D0", VA = "0x70C0D0", Slot = "8")]
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
			[Address(RVA = "0x70AF0C", Offset = "0x70AF0C", VA = "0x70AF0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x70AF14", Offset = "0x70AF14", VA = "0x70AF14")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public SimplePlayer PlayerB
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x70B084", Offset = "0x70B084", VA = "0x70B084")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x70B08C", Offset = "0x70B08C", VA = "0x70B08C")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public float FadeTime
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x70B1FC", Offset = "0x70B1FC", VA = "0x70B1FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x70B204", Offset = "0x70B204", VA = "0x70B204")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public bool AutoFade
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x70B224", Offset = "0x70B224", VA = "0x70B224")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x70B22C", Offset = "0x70B22C", VA = "0x70B22C")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool isFading
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x70B238", Offset = "0x70B238", VA = "0x70B238")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		public float Progress
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x70B258", Offset = "0x70B258", VA = "0x70B258")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x70B260", Offset = "0x70B260", VA = "0x70B260")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public float Elapsed
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x70B268", Offset = "0x70B268", VA = "0x70B268")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x70B270", Offset = "0x70B270", VA = "0x70B270")]
			private set
			{
			}
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x70B278", Offset = "0x70B278", VA = "0x70B278")]
		private void Start()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x70B5D4", Offset = "0x70B5D4", VA = "0x70B5D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x70B7FC", Offset = "0x70B7FC", VA = "0x70B7FC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x70B824", Offset = "0x70B824", VA = "0x70B824")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x70B7C8", Offset = "0x70B7C8", VA = "0x70B7C8")]
		public void FadeA()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x70B794", Offset = "0x70B794", VA = "0x70B794")]
		public void FadeB()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x70B970", Offset = "0x70B970", VA = "0x70B970")]
		private IEnumerator faderA()
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x70B9E4", Offset = "0x70B9E4", VA = "0x70B9E4")]
		private IEnumerator faderB()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x70BAA8", Offset = "0x70BAA8", VA = "0x70BAA8")]
		private void onPlaybackEnd(Record record)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x70BB68", Offset = "0x70BB68", VA = "0x70BB68")]
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
			[Address(RVA = "0x70C118", Offset = "0x70C118", VA = "0x70C118")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x70C120", Offset = "0x70C120", VA = "0x70C120")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public bool SilenceSource
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x70C4A4", Offset = "0x70C4A4", VA = "0x70C4A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x70C4AC", Offset = "0x70C4AC", VA = "0x70C4AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public string OutputPath
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x70C4DC", Offset = "0x70C4DC", VA = "0x70C4DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x70C4E4", Offset = "0x70C4E4", VA = "0x70C4E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x70C720", Offset = "0x70C720", VA = "0x70C720")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x70C7A0", Offset = "0x70C7A0", VA = "0x70C7A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x70C8F8", Offset = "0x70C8F8", VA = "0x70C8F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x70CB6C", Offset = "0x70CB6C", VA = "0x70CB6C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x70CB70", Offset = "0x70CB70", VA = "0x70CB70")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x70D410", Offset = "0x70D410", VA = "0x70D410")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x70D494", Offset = "0x70D494", VA = "0x70D494")]
		public void SaveFile(Stream stream, [Optional] string fname)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x70D518", Offset = "0x70D518", VA = "0x70D518")]
		public void SaveFile(byte[] data, [Optional] string fname)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x70C364", Offset = "0x70C364", VA = "0x70C364")]
		private void register()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x70C224", Offset = "0x70C224", VA = "0x70C224")]
		private void unregister()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x70DCC0", Offset = "0x70DCC0", VA = "0x70DCC0")]
		private void openFile()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x70DB38", Offset = "0x70DB38", VA = "0x70DB38")]
		private void write(byte[] bytesData, int count)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x70CBBC", Offset = "0x70CBBC", VA = "0x70CBBC")]
		private void closeFile()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x70DFEC", Offset = "0x70DFEC", VA = "0x70DFEC")]
		private void readPCMData(float[] data)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x70E1C8", Offset = "0x70E1C8", VA = "0x70E1C8")]
		private void onAudioStart(Record record)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x70E414", Offset = "0x70E414", VA = "0x70E414")]
		private void onAudioEnd(Record record)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x70E4C0", Offset = "0x70E4C0", VA = "0x70E4C0")]
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
		[Address(RVA = "0x70E4D0", Offset = "0x70E4D0", VA = "0x70E4D0")]
		public void Facebook()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x70E614", Offset = "0x70E614", VA = "0x70E614")]
		public void Twitter()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x70E678", Offset = "0x70E678", VA = "0x70E678")]
		public void LinkedIn()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x70E6DC", Offset = "0x70E6DC", VA = "0x70E6DC")]
		public void Youtube()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x70E740", Offset = "0x70E740", VA = "0x70E740")]
		public void Discord()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x70E7A4", Offset = "0x70E7A4", VA = "0x70E7A4")]
		public Social()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class StaticManager : MonoBehaviour
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x70E7AC", Offset = "0x70E7AC", VA = "0x70E7AC")]
		public void Quit()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x70E7B4", Offset = "0x70E7B4", VA = "0x70E7B4")]
		public void OpenCrosstales()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x70E818", Offset = "0x70E818", VA = "0x70E818")]
		public void OpenAssetstore()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x70E87C", Offset = "0x70E87C", VA = "0x70E87C")]
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
		[Address(RVA = "0x70E884", Offset = "0x70E884", VA = "0x70E884")]
		public void Start()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x70E8A8", Offset = "0x70E8A8", VA = "0x70E8A8")]
		public void BeginDrag()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x70E8FC", Offset = "0x70E8FC", VA = "0x70E8FC")]
		public void OnDrag()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x70E960", Offset = "0x70E960", VA = "0x70E960")]
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
		[Address(RVA = "0x70E968", Offset = "0x70E968", VA = "0x70E968")]
		public void Start()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x70EA4C", Offset = "0x70EA4C", VA = "0x70EA4C")]
		public void OnPanelEnter()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x70ED00", Offset = "0x70ED00", VA = "0x70ED00")]
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
				[Address(RVA = "0x70F17C", Offset = "0x70F17C", VA = "0x70F17C", Slot = "4")]
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
				[Address(RVA = "0x70F1C4", Offset = "0x70F1C4", VA = "0x70F1C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x70EF38", Offset = "0x70EF38", VA = "0x70EF38")]
			[DebuggerHidden]
			public <lerpAlphaDown>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x70EFA0", Offset = "0x70EFA0", VA = "0x70EFA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x70EFA4", Offset = "0x70EFA4", VA = "0x70EFA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x70F184", Offset = "0x70F184", VA = "0x70F184", Slot = "8")]
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
				[Address(RVA = "0x70F3A0", Offset = "0x70F3A0", VA = "0x70F3A0", Slot = "4")]
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
				[Address(RVA = "0x70F3E8", Offset = "0x70F3E8", VA = "0x70F3E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x70EF60", Offset = "0x70EF60", VA = "0x70EF60")]
			[DebuggerHidden]
			public <lerpAlphaUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x70F1CC", Offset = "0x70F1CC", VA = "0x70F1CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x70F1D0", Offset = "0x70F1D0", VA = "0x70F1D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x70F3A8", Offset = "0x70F3A8", VA = "0x70F3A8", Slot = "8")]
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
		[Address(RVA = "0x70ED58", Offset = "0x70ED58", VA = "0x70ED58")]
		public void Start()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x70ED98", Offset = "0x70ED98", VA = "0x70ED98")]
		public void FadeUp()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x70ED68", Offset = "0x70ED68", VA = "0x70ED68")]
		public void FadeDown()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x70EE80", Offset = "0x70EE80", VA = "0x70EE80")]
		private IEnumerator lerpAlphaDown(float startAlphaValue, float endAlphaValue, float time, float delay, Component gameObjectToFade)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x70EDC8", Offset = "0x70EDC8", VA = "0x70EDC8")]
		private IEnumerator lerpAlphaUp(float startAlphaValue, float endAlphaValue, float time, float delay, Component gameObjectToFade)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x70EF88", Offset = "0x70EF88", VA = "0x70EF88")]
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
		[Address(RVA = "0x70F3F0", Offset = "0x70F3F0", VA = "0x70F3F0")]
		public void Awake()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x70F4B8", Offset = "0x70F4B8", VA = "0x70F4B8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x70F56C", Offset = "0x70F56C", VA = "0x70F56C", Slot = "5")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x70F6DC", Offset = "0x70F6DC", VA = "0x70F6DC")]
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
		[Address(RVA = "0x70F6F0", Offset = "0x70F6F0", VA = "0x70F6F0")]
		public void Start()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x70EAFC", Offset = "0x70EAFC", VA = "0x70EAFC")]
		public void ChangeState(GameObject active)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x70F80C", Offset = "0x70F80C", VA = "0x70F80C")]
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
		[Address(RVA = "0x70F814", Offset = "0x70F814", VA = "0x70F814")]
		public void Start()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x70F964", Offset = "0x70F964", VA = "0x70F964")]
		public void Update()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x70FB04", Offset = "0x70FB04", VA = "0x70FB04")]
		public void SwitchPanel()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x70FB14", Offset = "0x70FB14", VA = "0x70FB14")]
		public void OpenPanel()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x70F92C", Offset = "0x70F92C", VA = "0x70F92C")]
		public void ClosePanel()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x70FC1C", Offset = "0x70FC1C", VA = "0x70FC1C")]
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
		[Address(RVA = "0x70FC2C", Offset = "0x70FC2C", VA = "0x70FC2C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x70FE58", Offset = "0x70FE58", VA = "0x70FE58")]
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
		[Address(RVA = "0x70FE60", Offset = "0x70FE60", VA = "0x70FE60")]
		public void Start()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x70FED4", Offset = "0x70FED4", VA = "0x70FED4")]
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
		[Address(RVA = "0x70FEE8", Offset = "0x70FEE8", VA = "0x70FEE8")]
		public void Start()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x71043C", Offset = "0x71043C", VA = "0x71043C")]
		public void Update()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x7104B0", Offset = "0x7104B0", VA = "0x7104B0")]
		public void FindAllAudioFilters()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x7107C0", Offset = "0x7107C0", VA = "0x7107C0")]
		public void ResetAudioFilters()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x710834", Offset = "0x710834", VA = "0x710834")]
		public void ReverbFilterDropdownChanged(int index)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x7108F0", Offset = "0x7108F0", VA = "0x7108F0")]
		public void ChorusFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x710958", Offset = "0x710958", VA = "0x710958")]
		public void EchoFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x7109C0", Offset = "0x7109C0", VA = "0x7109C0")]
		public void DistortionFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x710A28", Offset = "0x710A28", VA = "0x710A28")]
		public void DistortionFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x710B34", Offset = "0x710B34", VA = "0x710B34")]
		public void LowPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x710B9C", Offset = "0x710B9C", VA = "0x710B9C")]
		public void LowPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x710CA8", Offset = "0x710CA8", VA = "0x710CA8")]
		public void HighPassFilterEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x710D10", Offset = "0x710D10", VA = "0x710D10")]
		public void HighPassFilterChanged(float value)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x710E1C", Offset = "0x710E1C", VA = "0x710E1C")]
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
		[Address(RVA = "0x710EC8", Offset = "0x710EC8", VA = "0x710EC8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x710F3C", Offset = "0x710F3C", VA = "0x710F3C")]
		public void FindAllAudioSources()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x711028", Offset = "0x711028", VA = "0x711028")]
		public void ResetAllAudioSources()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x71106C", Offset = "0x71106C", VA = "0x71106C")]
		public void MuteEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x7110D4", Offset = "0x7110D4", VA = "0x7110D4")]
		public void LoopEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x71113C", Offset = "0x71113C", VA = "0x71113C")]
		public void VolumeChanged(float value)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x711248", Offset = "0x711248", VA = "0x711248")]
		public void PitchChanged(float value)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x711354", Offset = "0x711354", VA = "0x711354")]
		public void StereoPanChanged(float value)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x711460", Offset = "0x711460", VA = "0x711460")]
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
		[Address(RVA = "0x71147C", Offset = "0x71147C", VA = "0x71147C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x7114A0", Offset = "0x7114A0", VA = "0x7114A0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x711B54", Offset = "0x711B54", VA = "0x711B54")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x711B08", Offset = "0x711B08", VA = "0x711B08")]
		public void StartLooking()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x711B30", Offset = "0x711B30", VA = "0x711B30")]
		public void StopLooking()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x711B78", Offset = "0x711B78", VA = "0x711B78")]
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
		[Address(RVA = "0x711B94", Offset = "0x711B94", VA = "0x711B94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x711BA8", Offset = "0x711BA8", VA = "0x711BA8")]
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
		[Address(RVA = "0x711C14", Offset = "0x711C14", VA = "0x711C14")]
		private void Start()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x7120A8", Offset = "0x7120A8", VA = "0x7120A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x71214C", Offset = "0x71214C", VA = "0x71214C")]
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
		[Address(RVA = "0x7121C4", Offset = "0x7121C4", VA = "0x7121C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x7121F0", Offset = "0x7121F0", VA = "0x7121F0")]
		public void Capture()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x712408", Offset = "0x712408", VA = "0x712408")]
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
			[Address(RVA = "0x7129B8", Offset = "0x7129B8", VA = "0x7129B8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x7129C0", Offset = "0x7129C0", VA = "0x7129C0")]
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
		[Address(RVA = "0x7124B8", Offset = "0x7124B8", VA = "0x7124B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x7124E4", Offset = "0x7124E4", VA = "0x7124E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x7128DC", Offset = "0x7128DC", VA = "0x7128DC")]
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
			[Address(RVA = "0x712FF0", Offset = "0x712FF0", VA = "0x712FF0")]
			public <>c()
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x712FF8", Offset = "0x712FF8", VA = "0x712FF8")]
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
		[Address(RVA = "0x712A1C", Offset = "0x712A1C", VA = "0x712A1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x712A3C", Offset = "0x712A3C", VA = "0x712A3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x712F78", Offset = "0x712F78", VA = "0x712F78")]
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
			[Address(RVA = "0x713054", Offset = "0x713054", VA = "0x713054")]
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
			[Address(RVA = "0x714DBC", Offset = "0x714DBC", VA = "0x714DBC")]
			public <>c()
			{
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x714DC4", Offset = "0x714DC4", VA = "0x714DC4")]
			internal bool <RemoteCertificateValidationCallback>b__63_0(X509ChainStatus t)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x714DD0", Offset = "0x714DD0", VA = "0x714DD0")]
			internal bool <GetFiles>b__68_0(string extension)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x714E5C", Offset = "0x714E5C", VA = "0x714E5C")]
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
			[Address(RVA = "0x70FEC4", Offset = "0x70FEC4", VA = "0x70FEC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000118")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x70FECC", Offset = "0x70FECC", VA = "0x70FECC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x713518", Offset = "0x713518", VA = "0x713518")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x713520", Offset = "0x713520", VA = "0x713520")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x713590", Offset = "0x713590", VA = "0x713590")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x713598", Offset = "0x713598", VA = "0x713598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011D")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x7135A0", Offset = "0x7135A0", VA = "0x7135A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x7135A8", Offset = "0x7135A8", VA = "0x7135A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x7135B0", Offset = "0x7135B0", VA = "0x7135B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000120")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x7135B8", Offset = "0x7135B8", VA = "0x7135B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000121")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x7135C0", Offset = "0x7135C0", VA = "0x7135C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000122")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x7130D8", Offset = "0x7130D8", VA = "0x7130D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000123")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x713610", Offset = "0x713610", VA = "0x713610")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x713670", Offset = "0x713670", VA = "0x713670")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x712F28", Offset = "0x712F28", VA = "0x712F28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		public static bool isEditor
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x7136D0", Offset = "0x7136D0", VA = "0x7136D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x713148", Offset = "0x713148", VA = "0x713148")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x713150", Offset = "0x713150", VA = "0x713150")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000129")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x713158", Offset = "0x713158", VA = "0x713158")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012A")]
		public static bool isEditorMode
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x70B580", Offset = "0x70B580", VA = "0x70B580")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x713740", Offset = "0x713740", VA = "0x713740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x713748", Offset = "0x713748", VA = "0x713748")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x7137C8", Offset = "0x7137C8", VA = "0x7137C8")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x7138E0", Offset = "0x7138E0", VA = "0x7138E0")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x70E534", Offset = "0x70E534", VA = "0x70E534")]
		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x713A44", Offset = "0x713A44", VA = "0x713A44")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x70C558", Offset = "0x70C558", VA = "0x70C558")]
		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x70D8E0", Offset = "0x70D8E0", VA = "0x70D8E0")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x713F5C", Offset = "0x713F5C", VA = "0x713F5C")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x714470", Offset = "0x714470", VA = "0x714470")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x7145E8", Offset = "0x7145E8", VA = "0x7145E8")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x7148BC", Offset = "0x7148BC", VA = "0x7148BC")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x714918", Offset = "0x714918", VA = "0x714918")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x711F58", Offset = "0x711F58", VA = "0x711F58")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x713964", Offset = "0x713964", VA = "0x713964")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x712364", Offset = "0x712364", VA = "0x712364")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x714CDC", Offset = "0x714CDC", VA = "0x714CDC")]
		private static string addLeadingZero(int value)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x713A3C", Offset = "0x713A3C", VA = "0x713A3C")]
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
			[Address(RVA = "0x714E64", Offset = "0x714E64", VA = "0x714E64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x714EAC", Offset = "0x714EAC", VA = "0x714EAC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x714F04", Offset = "0x714F04", VA = "0x714F04")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x714F60", Offset = "0x714F60", VA = "0x714F60")]
		[RuntimeInitializeOnLoadMethod]
		private static void create()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x715054", Offset = "0x715054", VA = "0x715054")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x7150AC", Offset = "0x7150AC", VA = "0x7150AC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x715104", Offset = "0x715104", VA = "0x715104")]
		public CTHelper()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x71510C", Offset = "0x71510C", VA = "0x71510C")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x71513C", Offset = "0x71513C", VA = "0x71513C")]
		public static void Save()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x715144", Offset = "0x715144", VA = "0x715144")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x7151B4", Offset = "0x7151B4", VA = "0x7151B4")]
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
			[Address(RVA = "0x715374", Offset = "0x715374", VA = "0x715374", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012F")]
		public override bool CanSeek
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x71537C", Offset = "0x71537C", VA = "0x71537C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000130")]
		public override bool CanWrite
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x715384", Offset = "0x715384", VA = "0x715384", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000131")]
		public override long Position
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x71538C", Offset = "0x71538C", VA = "0x71538C", Slot = "10")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x715394", Offset = "0x715394", VA = "0x715394", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public override long Length
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x715410", Offset = "0x715410", VA = "0x715410", Slot = "9")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x715234", Offset = "0x715234", VA = "0x715234")]
		public MemoryCacheStream(int cacheSize = 65536, int maxCacheSize = 67108864)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x715418", Offset = "0x715418", VA = "0x715418", Slot = "17")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x71541C", Offset = "0x71541C", VA = "0x71541C", Slot = "26")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x71551C", Offset = "0x71551C", VA = "0x71551C", Slot = "27")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x7156E0", Offset = "0x7156E0", VA = "0x7156E0", Slot = "30")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x715628", Offset = "0x715628", VA = "0x715628")]
		private int read(byte[] buff, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x715820", Offset = "0x715820", VA = "0x715820")]
		private void write(byte[] buff, int offset, int count)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x7152B0", Offset = "0x7152B0", VA = "0x7152B0")]
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
			[Address(RVA = "0x7161F8", Offset = "0x7161F8", VA = "0x7161F8")]
			public <>c()
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x716200", Offset = "0x716200", VA = "0x716200")]
			internal bool <activateGameObjects>b__8_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x71625C", Offset = "0x71625C", VA = "0x71625C")]
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
		[Address(RVA = "0x7158D0", Offset = "0x7158D0", VA = "0x7158D0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x7158F8", Offset = "0x7158F8", VA = "0x7158F8")]
		protected void selectPlatform()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x715960", Offset = "0x715960", VA = "0x715960")]
		protected void activateGameObjects()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x715D6C", Offset = "0x715D6C", VA = "0x715D6C")]
		protected void activateScripts()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x716178", Offset = "0x716178", VA = "0x716178")]
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
		[Address(RVA = "0x7162B8", Offset = "0x7162B8", VA = "0x7162B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x716BE4", Offset = "0x716BE4", VA = "0x716BE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x717590", Offset = "0x717590", VA = "0x717590")]
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
		[Address(RVA = "0x717624", Offset = "0x717624", VA = "0x717624")]
		private void Start()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x7176DC", Offset = "0x7176DC", VA = "0x7176DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x7179DC", Offset = "0x7179DC", VA = "0x7179DC")]
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
		[Address(RVA = "0x717A68", Offset = "0x717A68", VA = "0x717A68")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x717B50", Offset = "0x717B50", VA = "0x717B50")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x717CB8", Offset = "0x717CB8", VA = "0x717CB8")]
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
			[Address(RVA = "0x717CF0", Offset = "0x717CF0", VA = "0x717CF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x717D48", Offset = "0x717D48", VA = "0x717D48")]
			set
			{
			}
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x717DA4", Offset = "0x717DA4", VA = "0x717DA4")]
		static SingletonHelper()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x717DA8", Offset = "0x717DA8", VA = "0x717DA8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x717F4C", Offset = "0x717F4C", VA = "0x717F4C")]
		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x718008", Offset = "0x718008", VA = "0x718008")]
		private static void onSceneUnloaded(Scene scene)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x7180C4", Offset = "0x7180C4", VA = "0x7180C4")]
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
