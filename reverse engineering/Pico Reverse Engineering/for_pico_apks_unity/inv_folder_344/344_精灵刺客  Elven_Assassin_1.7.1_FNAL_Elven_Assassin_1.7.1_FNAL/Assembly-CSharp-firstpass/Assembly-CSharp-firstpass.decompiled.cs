using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using Il2CppDummyDll;
using POpusCodec.Enums;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using VEAGames.LAM.Constants;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class PatchCulling : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer[] DetailPatches;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x80D4B4", Offset = "0x80D4B4", VA = "0x80D4B4")]
	public void DestroyPatch()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x80D520", Offset = "0x80D520", VA = "0x80D520")]
	public void RendererEnabled(bool enabled = true)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x80D614", Offset = "0x80D614", VA = "0x80D614")]
	public void ShadowCastingMode(ShadowCastingMode mode)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x80D704", Offset = "0x80D704", VA = "0x80D704")]
	public PatchCulling()
	{
	}
}
[Token(Token = "0x2000003")]
public class FlyController : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MouseLook MouseLook;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x80D70C", Offset = "0x80D70C", VA = "0x80D70C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x80D768", Offset = "0x80D768", VA = "0x80D768")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x80D96C", Offset = "0x80D96C", VA = "0x80D96C")]
	public FlyController()
	{
	}
}
namespace POpusCodec
{
	[Token(Token = "0x2000004")]
	public class OpusDecoder : IDisposable
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x4000006")]
		private const int MaxFrameSize = 5760;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _previousPacketInvalid;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _channelCount;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Bandwidth? _previousPacketBandwidth;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] lostDataFloats;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] tempData;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] pcm;

		[Token(Token = "0x17000001")]
		public string Version
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x80D9E8", Offset = "0x80D9E8", VA = "0x80D9E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x80D9F0", Offset = "0x80D9F0", VA = "0x80D9F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x80D9F8", Offset = "0x80D9F8", VA = "0x80D9F8")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x80DEA4", Offset = "0x80DEA4", VA = "0x80DEA4")]
		public short[] DecodePacketLost()
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x80E170", Offset = "0x80E170", VA = "0x80E170")]
		public float[] DecodePacketLostFloat()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x80E3C0", Offset = "0x80E3C0", VA = "0x80E3C0")]
		public short[] DecodePacket(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x80E584", Offset = "0x80E584", VA = "0x80E584")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x80E714", Offset = "0x80E714", VA = "0x80E714", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class OpusEncoder : IDisposable
	{
		[Token(Token = "0x400000D")]
		public const int BitrateMax = -1;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x4000010")]
		private const int RecommendedMaxPacketSize = 4000;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _frameSizePerChannel;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private SamplingRate _inputSamplingRate;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Channels _inputChannels;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] writePacket;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Delay _encoderDelay;

		[Token(Token = "0x17000003")]
		public SamplingRate InputSamplingRate
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x80E7C4", Offset = "0x80E7C4", VA = "0x80E7C4")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Token(Token = "0x17000004")]
		public Channels InputChannels
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x80E7CC", Offset = "0x80E7CC", VA = "0x80E7CC")]
			get
			{
				return default(Channels);
			}
		}

		[Token(Token = "0x17000005")]
		public string Version
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x80E7D4", Offset = "0x80E7D4", VA = "0x80E7D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public Delay EncoderDelay
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x80E8F0", Offset = "0x80E8F0", VA = "0x80E8F0")]
			get
			{
				return default(Delay);
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x80E7DC", Offset = "0x80E7DC", VA = "0x80E7DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public int FrameSizePerChannel
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x80E8F8", Offset = "0x80E8F8", VA = "0x80E8F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000008")]
		public int Bitrate
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x80E900", Offset = "0x80E900", VA = "0x80E900")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x80E9D0", Offset = "0x80E9D0", VA = "0x80E9D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Bandwidth MaxBandwidth
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x80EA98", Offset = "0x80EA98", VA = "0x80EA98")]
			get
			{
				return default(Bandwidth);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x80EAA4", Offset = "0x80EAA4", VA = "0x80EAA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Complexity Complexity
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x80EAB4", Offset = "0x80EAB4", VA = "0x80EAB4")]
			get
			{
				return default(Complexity);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x80EAC0", Offset = "0x80EAC0", VA = "0x80EAC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public int ExpectedPacketLossPercentage
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x80EAD0", Offset = "0x80EAD0", VA = "0x80EAD0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x80EADC", Offset = "0x80EADC", VA = "0x80EADC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public SignalHint SignalHint
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x80EAEC", Offset = "0x80EAEC", VA = "0x80EAEC")]
			get
			{
				return default(SignalHint);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x80EAF8", Offset = "0x80EAF8", VA = "0x80EAF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public ForceChannels ForceChannels
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x80EB08", Offset = "0x80EB08", VA = "0x80EB08")]
			get
			{
				return default(ForceChannels);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x80EB14", Offset = "0x80EB14", VA = "0x80EB14")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool UseInbandFEC
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x80EB24", Offset = "0x80EB24", VA = "0x80EB24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x80EB44", Offset = "0x80EB44", VA = "0x80EB44")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool UseUnconstrainedVBR
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x80EB54", Offset = "0x80EB54", VA = "0x80EB54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x80EB74", Offset = "0x80EB74", VA = "0x80EB74")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool DtxEnabled
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x80EB88", Offset = "0x80EB88", VA = "0x80EB88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x80EBA8", Offset = "0x80EBA8", VA = "0x80EBA8")]
			set
			{
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x80EBB8", Offset = "0x80EBB8", VA = "0x80EBB8")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x80F15C", Offset = "0x80F15C", VA = "0x80F15C")]
		public byte[] Encode(short[] pcmSamples)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x80F2FC", Offset = "0x80F2FC", VA = "0x80F2FC")]
		public byte[] Encode(float[] pcmSamples)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x80F49C", Offset = "0x80F49C", VA = "0x80F49C", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class OpusException : Exception
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private OpusStatusCode _statusCode;

		[Token(Token = "0x17000011")]
		public OpusStatusCode StatusCode
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x80F54C", Offset = "0x80F54C", VA = "0x80F54C")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x80DE30", Offset = "0x80DE30", VA = "0x80DE30")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Token(Token = "0x2000007")]
	internal class Wrapper
	{
		[PreserveSig]
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x80F554", Offset = "0x80F554", VA = "0x80F554")]
		private static extern int opus_encoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x80F5D0", Offset = "0x80F5D0", VA = "0x80F5D0")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[PreserveSig]
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x80DDCC", Offset = "0x80DDCC", VA = "0x80DDCC")]
		public static extern IntPtr opus_get_version_string();

		[PreserveSig]
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x80F66C", Offset = "0x80F66C", VA = "0x80F66C")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x80F728", Offset = "0x80F728", VA = "0x80F728")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x80F7E4", Offset = "0x80F7E4", VA = "0x80F7E4")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x80F878", Offset = "0x80F878", VA = "0x80F878")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x80F908", Offset = "0x80F908", VA = "0x80F908")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x80F99C", Offset = "0x80F99C", VA = "0x80F99C")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x80FA2C", Offset = "0x80FA2C", VA = "0x80FA2C")]
		private static extern int opus_decoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x80FAA8", Offset = "0x80FAA8", VA = "0x80FAA8")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x80FB3C", Offset = "0x80FB3C", VA = "0x80FB3C")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x80FC00", Offset = "0x80FC00", VA = "0x80FC00")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x80E500", Offset = "0x80E500", VA = "0x80E500")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[PreserveSig]
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x80FCC4", Offset = "0x80FCC4", VA = "0x80FCC4")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[PreserveSig]
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x80FD48", Offset = "0x80FD48", VA = "0x80FD48")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x80F020", Offset = "0x80F020", VA = "0x80F020")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x80F218", Offset = "0x80F218", VA = "0x80F218")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x80F3B8", Offset = "0x80F3B8", VA = "0x80F3B8")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x80F4F4", Offset = "0x80F4F4", VA = "0x80F4F4")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x80E90C", Offset = "0x80E90C", VA = "0x80E90C")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x80E9E0", Offset = "0x80E9E0", VA = "0x80E9E0")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x80DF88", Offset = "0x80DF88", VA = "0x80DF88")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x80FE40", Offset = "0x80FE40", VA = "0x80FE40")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x80DC98", Offset = "0x80DC98", VA = "0x80DC98")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x80E76C", Offset = "0x80E76C", VA = "0x80E76C")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x80E04C", Offset = "0x80E04C", VA = "0x80E04C")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x80E29C", Offset = "0x80E29C", VA = "0x80E29C")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x80FDC4", Offset = "0x80FDC4", VA = "0x80FDC4")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x80FEF8", Offset = "0x80FEF8", VA = "0x80FEF8")]
		public Wrapper()
		{
		}
	}
}
namespace POpusCodec.Enums
{
	[Token(Token = "0x2000008")]
	public enum Bandwidth
	{
		[Token(Token = "0x4000018")]
		Narrowband = 1101,
		[Token(Token = "0x4000019")]
		Mediumband,
		[Token(Token = "0x400001A")]
		Wideband,
		[Token(Token = "0x400001B")]
		SuperWideband,
		[Token(Token = "0x400001C")]
		Fullband
	}
	[Token(Token = "0x2000009")]
	public enum Channels
	{
		[Token(Token = "0x400001E")]
		Mono = 1,
		[Token(Token = "0x400001F")]
		Stereo
	}
	[Token(Token = "0x200000A")]
	public enum Complexity
	{
		[Token(Token = "0x4000021")]
		Complexity0,
		[Token(Token = "0x4000022")]
		Complexity1,
		[Token(Token = "0x4000023")]
		Complexity2,
		[Token(Token = "0x4000024")]
		Complexity3,
		[Token(Token = "0x4000025")]
		Complexity4,
		[Token(Token = "0x4000026")]
		Complexity5,
		[Token(Token = "0x4000027")]
		Complexity6,
		[Token(Token = "0x4000028")]
		Complexity7,
		[Token(Token = "0x4000029")]
		Complexity8,
		[Token(Token = "0x400002A")]
		Complexity9,
		[Token(Token = "0x400002B")]
		Complexity10
	}
	[Token(Token = "0x200000B")]
	public enum Delay
	{
		[Token(Token = "0x400002D")]
		Delay2dot5ms = 5,
		[Token(Token = "0x400002E")]
		Delay5ms = 10,
		[Token(Token = "0x400002F")]
		Delay10ms = 20,
		[Token(Token = "0x4000030")]
		Delay20ms = 40,
		[Token(Token = "0x4000031")]
		Delay40ms = 80,
		[Token(Token = "0x4000032")]
		Delay60ms = 120
	}
	[Token(Token = "0x200000C")]
	public enum ForceChannels
	{
		[Token(Token = "0x4000034")]
		NoForce = -1000,
		[Token(Token = "0x4000035")]
		Mono = 1,
		[Token(Token = "0x4000036")]
		Stereo = 2
	}
	[Token(Token = "0x200000D")]
	public enum OpusApplicationType
	{
		[Token(Token = "0x4000038")]
		Voip = 2048,
		[Token(Token = "0x4000039")]
		Audio = 2049,
		[Token(Token = "0x400003A")]
		RestrictedLowDelay = 2051
	}
	[Token(Token = "0x200000E")]
	internal enum OpusCtlGetRequest
	{
		[Token(Token = "0x400003C")]
		Application = 4001,
		[Token(Token = "0x400003D")]
		Bitrate = 4003,
		[Token(Token = "0x400003E")]
		MaxBandwidth = 4005,
		[Token(Token = "0x400003F")]
		VBR = 4007,
		[Token(Token = "0x4000040")]
		Bandwidth = 4009,
		[Token(Token = "0x4000041")]
		Complexity = 4011,
		[Token(Token = "0x4000042")]
		InbandFec = 4013,
		[Token(Token = "0x4000043")]
		PacketLossPercentage = 4015,
		[Token(Token = "0x4000044")]
		Dtx = 4017,
		[Token(Token = "0x4000045")]
		VBRConstraint = 4021,
		[Token(Token = "0x4000046")]
		ForceChannels = 4023,
		[Token(Token = "0x4000047")]
		Signal = 4025,
		[Token(Token = "0x4000048")]
		LookAhead = 4027,
		[Token(Token = "0x4000049")]
		SampleRate = 4029,
		[Token(Token = "0x400004A")]
		FinalRange = 4031,
		[Token(Token = "0x400004B")]
		Pitch = 4033,
		[Token(Token = "0x400004C")]
		Gain = 4035,
		[Token(Token = "0x400004D")]
		LsbDepth = 4037,
		[Token(Token = "0x400004E")]
		LastPacketDurationRequest = 4039
	}
	[Token(Token = "0x200000F")]
	internal enum OpusCtlSetRequest
	{
		[Token(Token = "0x4000050")]
		Application = 4000,
		[Token(Token = "0x4000051")]
		Bitrate = 4002,
		[Token(Token = "0x4000052")]
		MaxBandwidth = 4004,
		[Token(Token = "0x4000053")]
		VBR = 4006,
		[Token(Token = "0x4000054")]
		Bandwidth = 4008,
		[Token(Token = "0x4000055")]
		Complexity = 4010,
		[Token(Token = "0x4000056")]
		InbandFec = 4012,
		[Token(Token = "0x4000057")]
		PacketLossPercentage = 4014,
		[Token(Token = "0x4000058")]
		Dtx = 4016,
		[Token(Token = "0x4000059")]
		VBRConstraint = 4020,
		[Token(Token = "0x400005A")]
		ForceChannels = 4022,
		[Token(Token = "0x400005B")]
		Signal = 4024,
		[Token(Token = "0x400005C")]
		Gain = 4034,
		[Token(Token = "0x400005D")]
		LsbDepth = 4036
	}
	[Token(Token = "0x2000010")]
	public enum OpusStatusCode
	{
		[Token(Token = "0x400005F")]
		OK = 0,
		[Token(Token = "0x4000060")]
		BadArguments = -1,
		[Token(Token = "0x4000061")]
		BufferTooSmall = -2,
		[Token(Token = "0x4000062")]
		InternalError = -3,
		[Token(Token = "0x4000063")]
		InvalidPacket = -4,
		[Token(Token = "0x4000064")]
		Unimplemented = -5,
		[Token(Token = "0x4000065")]
		InvalidState = -6,
		[Token(Token = "0x4000066")]
		AllocFail = -7
	}
	[Token(Token = "0x2000011")]
	public enum SamplingRate
	{
		[Token(Token = "0x4000068")]
		Sampling08000 = 8000,
		[Token(Token = "0x4000069")]
		Sampling12000 = 12000,
		[Token(Token = "0x400006A")]
		Sampling16000 = 16000,
		[Token(Token = "0x400006B")]
		Sampling24000 = 24000,
		[Token(Token = "0x400006C")]
		Sampling48000 = 48000
	}
	[Token(Token = "0x2000012")]
	public enum SignalHint
	{
		[Token(Token = "0x400006E")]
		Auto = -1000,
		[Token(Token = "0x400006F")]
		Voice = 3001,
		[Token(Token = "0x4000070")]
		Music = 3002
	}
}
namespace ExitGames.Client.Photon
{
	[Token(Token = "0x2000013")]
	public class WebRpcResponse
	{
		[Token(Token = "0x17000012")]
		public string Name
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x80FF00", Offset = "0x80FF00", VA = "0x80FF00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x80FF08", Offset = "0x80FF08", VA = "0x80FF08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public int ReturnCode
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x80FF10", Offset = "0x80FF10", VA = "0x80FF10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x80FF18", Offset = "0x80FF18", VA = "0x80FF18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public string DebugMessage
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x80FF20", Offset = "0x80FF20", VA = "0x80FF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x80FF28", Offset = "0x80FF28", VA = "0x80FF28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Dictionary<string, object> Parameters
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x80FF30", Offset = "0x80FF30", VA = "0x80FF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x80FF38", Offset = "0x80FF38", VA = "0x80FF38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x80FF40", Offset = "0x80FF40", VA = "0x80FF40")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x810118", Offset = "0x810118", VA = "0x810118")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x2000014")]
	public class WebFlags
	{
		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly WebFlags Default;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte WebhookFlags;

		[Token(Token = "0x4000077")]
		public const byte HttpForwardConst = 1;

		[Token(Token = "0x4000078")]
		public const byte SendAuthCookieConst = 2;

		[Token(Token = "0x4000079")]
		public const byte SendSyncConst = 4;

		[Token(Token = "0x400007A")]
		public const byte SendStateConst = 8;

		[Token(Token = "0x17000016")]
		public bool HttpForward
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x8102E4", Offset = "0x8102E4", VA = "0x8102E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x8102F0", Offset = "0x8102F0", VA = "0x8102F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool SendAuthCookie
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x810300", Offset = "0x810300", VA = "0x810300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x81030C", Offset = "0x81030C", VA = "0x81030C")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool SendSync
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x81031C", Offset = "0x81031C", VA = "0x81031C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x810328", Offset = "0x810328", VA = "0x810328")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public bool SendState
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x810338", Offset = "0x810338", VA = "0x810338")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x810344", Offset = "0x810344", VA = "0x810344")]
			set
			{
			}
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x810354", Offset = "0x810354", VA = "0x810354")]
		public WebFlags(byte webhookFlags)
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Token(Token = "0x2000015")]
	public static class Extensions
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x8103F0", Offset = "0x8103F0", VA = "0x8103F0")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x810830", Offset = "0x810830", VA = "0x810830")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x810C98", Offset = "0x810C98", VA = "0x810C98")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x8110BC", Offset = "0x8110BC", VA = "0x8110BC")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x811364", Offset = "0x811364", VA = "0x811364")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000016")]
	public class FriendInfo
	{
		[Token(Token = "0x1700001A")]
		public string Name
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x8113B8", Offset = "0x8113B8", VA = "0x8113B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x8113C0", Offset = "0x8113C0", VA = "0x8113C0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool IsOnline
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x8113C8", Offset = "0x8113C8", VA = "0x8113C8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x8113D0", Offset = "0x8113D0", VA = "0x8113D0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public string Room
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x8113DC", Offset = "0x8113DC", VA = "0x8113DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x8113E4", Offset = "0x8113E4", VA = "0x8113E4")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool IsInRoom
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x8113EC", Offset = "0x8113EC", VA = "0x8113EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x811414", Offset = "0x811414", VA = "0x811414", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x8114D0", Offset = "0x8114D0", VA = "0x8114D0")]
		public FriendInfo()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public enum ClientState
	{
		[Token(Token = "0x400007F")]
		Uninitialized,
		[Token(Token = "0x4000080")]
		Queued,
		[Token(Token = "0x4000081")]
		Authenticated,
		[Token(Token = "0x4000082")]
		JoinedLobby,
		[Token(Token = "0x4000083")]
		DisconnectingFromMasterserver,
		[Token(Token = "0x4000084")]
		ConnectingToGameserver,
		[Token(Token = "0x4000085")]
		ConnectedToGameserver,
		[Token(Token = "0x4000086")]
		Joining,
		[Token(Token = "0x4000087")]
		Joined,
		[Token(Token = "0x4000088")]
		Leaving,
		[Token(Token = "0x4000089")]
		DisconnectingFromGameserver,
		[Token(Token = "0x400008A")]
		ConnectingToMasterserver,
		[Token(Token = "0x400008B")]
		QueuedComingFromGameserver,
		[Token(Token = "0x400008C")]
		Disconnecting,
		[Token(Token = "0x400008D")]
		Disconnected,
		[Token(Token = "0x400008E")]
		ConnectedToMaster,
		[Token(Token = "0x400008F")]
		ConnectingToNameServer,
		[Token(Token = "0x4000090")]
		ConnectedToNameServer,
		[Token(Token = "0x4000091")]
		DisconnectingFromNameServer,
		[Token(Token = "0x4000092")]
		Authenticating
	}
	[Token(Token = "0x2000018")]
	public enum JoinType
	{
		[Token(Token = "0x4000094")]
		CreateRoom,
		[Token(Token = "0x4000095")]
		JoinRoom,
		[Token(Token = "0x4000096")]
		JoinRandomRoom,
		[Token(Token = "0x4000097")]
		JoinOrCreateRoom
	}
	[Token(Token = "0x2000019")]
	public enum DisconnectCause
	{
		[Token(Token = "0x4000099")]
		None,
		[Token(Token = "0x400009A")]
		DisconnectByServerUserLimit,
		[Token(Token = "0x400009B")]
		ExceptionOnConnect,
		[Token(Token = "0x400009C")]
		DisconnectByServer,
		[Token(Token = "0x400009D")]
		TimeoutDisconnect,
		[Token(Token = "0x400009E")]
		Exception,
		[Token(Token = "0x400009F")]
		InvalidAuthentication,
		[Token(Token = "0x40000A0")]
		MaxCcuReached,
		[Token(Token = "0x40000A1")]
		InvalidRegion,
		[Token(Token = "0x40000A2")]
		OperationNotAllowedInCurrentState,
		[Token(Token = "0x40000A3")]
		CustomAuthenticationFailed
	}
	[Token(Token = "0x200001A")]
	public enum ServerConnection
	{
		[Token(Token = "0x40000A5")]
		MasterServer,
		[Token(Token = "0x40000A6")]
		GameServer,
		[Token(Token = "0x40000A7")]
		NameServer
	}
	[Token(Token = "0x200001B")]
	public enum EncryptionMode
	{
		[Token(Token = "0x40000A9")]
		PayloadEncryption = 0,
		[Token(Token = "0x40000AA")]
		DatagramEncryption = 10
	}
	[Token(Token = "0x200001C")]
	public static class EncryptionDataParameters
	{
		[Token(Token = "0x40000AB")]
		public const byte Mode = 0;

		[Token(Token = "0x40000AC")]
		public const byte Secret1 = 1;

		[Token(Token = "0x40000AD")]
		public const byte Secret2 = 2;
	}
	[Token(Token = "0x200001D")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LoadBalancingPeer loadBalancingPeer;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AuthModeOption AuthMode;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public EncryptionMode EncryptionMode;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ConnectionProtocol ExpectedProtocol;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string NameServerHost;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string NameServerHttp;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ClientState state;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool inLobby;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool autoJoinLobby;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool EnableLobbyStatistics;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Room CurrentRoom;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Player localPlayer;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private JoinType lastJoinType;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private EnterRoomParams enterRoomParamsCache;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool didAuthenticate;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string[] friendListRequested;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int friendListTimestamp;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool isFetchingFriendList;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private byte[] encryptionSecret;

		[Token(Token = "0x1700001E")]
		public string AppVersion
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x8114D8", Offset = "0x8114D8", VA = "0x8114D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x8114E0", Offset = "0x8114E0", VA = "0x8114E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public string AppId
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x8114E8", Offset = "0x8114E8", VA = "0x8114E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x8114F0", Offset = "0x8114F0", VA = "0x8114F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public AuthenticationValues AuthValues
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x8114F8", Offset = "0x8114F8", VA = "0x8114F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x811500", Offset = "0x811500", VA = "0x811500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		private string TokenForInit
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x811508", Offset = "0x811508", VA = "0x811508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public bool IsUsingNameServer
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x811528", Offset = "0x811528", VA = "0x811528")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x811530", Offset = "0x811530", VA = "0x811530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public string NameServerAddress
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x81153C", Offset = "0x81153C", VA = "0x81153C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public string CurrentServerAddress
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x8116E4", Offset = "0x8116E4", VA = "0x8116E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public string MasterServerAddress
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x811700", Offset = "0x811700", VA = "0x811700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x811708", Offset = "0x811708", VA = "0x811708")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public string GameServerAddress
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x811710", Offset = "0x811710", VA = "0x811710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x811718", Offset = "0x811718", VA = "0x811718")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public ServerConnection Server
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x811720", Offset = "0x811720", VA = "0x811720")]
			[CompilerGenerated]
			get
			{
				return default(ServerConnection);
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x811728", Offset = "0x811728", VA = "0x811728")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public ClientState State
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x811730", Offset = "0x811730", VA = "0x811730")]
			get
			{
				return default(ClientState);
			}
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x811738", Offset = "0x811738", VA = "0x811738")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool IsConnected
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x811758", Offset = "0x811758", VA = "0x811758")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public bool IsConnectedAndReady
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x811784", Offset = "0x811784", VA = "0x811784")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002B")]
		public Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x8117BC", Offset = "0x8117BC", VA = "0x8117BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x8117C4", Offset = "0x8117C4", VA = "0x8117C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Action<EventData> OnEventAction
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x8117CC", Offset = "0x8117CC", VA = "0x8117CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x8117D4", Offset = "0x8117D4", VA = "0x8117D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Action<OperationResponse> OnOpResponseAction
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x8117DC", Offset = "0x8117DC", VA = "0x8117DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x8117E4", Offset = "0x8117E4", VA = "0x8117E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public DisconnectCause DisconnectedCause
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x8117EC", Offset = "0x8117EC", VA = "0x8117EC")]
			[CompilerGenerated]
			get
			{
				return default(DisconnectCause);
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x8117F4", Offset = "0x8117F4", VA = "0x8117F4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public TypedLobby CurrentLobby
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x8117FC", Offset = "0x8117FC", VA = "0x8117FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x811804", Offset = "0x811804", VA = "0x811804")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public bool AutoJoinLobby
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x81180C", Offset = "0x81180C", VA = "0x81180C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x811814", Offset = "0x811814", VA = "0x811814")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		private bool requestLobbyStatistics
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x811820", Offset = "0x811820", VA = "0x811820")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x811840", Offset = "0x811840", VA = "0x811840")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x811848", Offset = "0x811848", VA = "0x811848")]
			private set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[Obsolete("Use NickName instead.")]
		public string PlayerName
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x811850", Offset = "0x811850", VA = "0x811850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x811888", Offset = "0x811888", VA = "0x811888")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public string NickName
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x81186C", Offset = "0x81186C", VA = "0x81186C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x81188C", Offset = "0x81188C", VA = "0x81188C")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public string UserId
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x8119DC", Offset = "0x8119DC", VA = "0x8119DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x8119F4", Offset = "0x8119F4", VA = "0x8119F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Player LocalPlayer
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x8118D0", Offset = "0x8118D0", VA = "0x8118D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x811A94", Offset = "0x811A94", VA = "0x811A94")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public int PlayersOnMasterCount
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x811A9C", Offset = "0x811A9C", VA = "0x811A9C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x811AA4", Offset = "0x811AA4", VA = "0x811AA4")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public int PlayersInRoomsCount
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x811AAC", Offset = "0x811AAC", VA = "0x811AAC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x811AB4", Offset = "0x811AB4", VA = "0x811AB4")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int RoomsCount
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x811ABC", Offset = "0x811ABC", VA = "0x811ABC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x811AC4", Offset = "0x811AC4", VA = "0x811AC4")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public List<FriendInfo> FriendList
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x811ACC", Offset = "0x811ACC", VA = "0x811ACC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x811AD4", Offset = "0x811AD4", VA = "0x811AD4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public int FriendListAge
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x811ADC", Offset = "0x811ADC", VA = "0x811ADC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003C")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x811B14", Offset = "0x811B14", VA = "0x811B14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public string[] AvailableRegions
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x811B3C", Offset = "0x811B3C", VA = "0x811B3C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x811B44", Offset = "0x811B44", VA = "0x811B44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public string[] AvailableRegionsServers
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x811B4C", Offset = "0x811B4C", VA = "0x811B4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x811B54", Offset = "0x811B54", VA = "0x811B54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public string CloudRegion
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x811B5C", Offset = "0x811B5C", VA = "0x811B5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x811B64", Offset = "0x811B64", VA = "0x811B64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x811B74", Offset = "0x811B74", VA = "0x811B74")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x811DB8", Offset = "0x811DB8", VA = "0x811DB8")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x811540", Offset = "0x811540", VA = "0x811540")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x811E18", Offset = "0x811E18", VA = "0x811E18")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x811EEC", Offset = "0x811EEC", VA = "0x811EEC", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x811F74", Offset = "0x811F74", VA = "0x811F74")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x81206C", Offset = "0x81206C", VA = "0x81206C")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x8121F8", Offset = "0x8121F8", VA = "0x8121F8")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x812198", Offset = "0x812198", VA = "0x812198")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x8122AC", Offset = "0x8122AC", VA = "0x8122AC")]
		public void Service()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x8122C4", Offset = "0x8122C4", VA = "0x8122C4")]
		private void DisconnectToReconnect()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x81236C", Offset = "0x81236C", VA = "0x81236C")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x8123F0", Offset = "0x8123F0", VA = "0x8123F0")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x81244C", Offset = "0x81244C", VA = "0x81244C")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x8124C4", Offset = "0x8124C4", VA = "0x8124C4")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x812568", Offset = "0x812568", VA = "0x812568")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x81258C", Offset = "0x81258C", VA = "0x81258C")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x8127D4", Offset = "0x8127D4", VA = "0x8127D4")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x81261C", Offset = "0x81261C", VA = "0x81261C")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x81287C", Offset = "0x81287C", VA = "0x81287C")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x812978", Offset = "0x812978", VA = "0x812978")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x812A68", Offset = "0x812A68", VA = "0x812A68")]
		[Obsolete("Joining a room with a pre-defined actorNumber is no longer best practice. Use ReJoinRoom() and userIDs.")]
		public bool OpJoinRoom(string roomName, int actorNumber, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x812A70", Offset = "0x812A70", VA = "0x812A70")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x812BB8", Offset = "0x812BB8", VA = "0x812BB8")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x812CF8", Offset = "0x812CF8", VA = "0x812CF8")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x812D00", Offset = "0x812D00", VA = "0x812D00")]
		public bool OpLeaveRoom(bool becomeInactive)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x812DC0", Offset = "0x812DC0", VA = "0x812DC0")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x812FEC", Offset = "0x812FEC", VA = "0x812FEC")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x813494", Offset = "0x813494", VA = "0x813494")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x813528", Offset = "0x813528", VA = "0x813528")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x8138C4", Offset = "0x8138C4", VA = "0x8138C4", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x8138E4", Offset = "0x8138E4", VA = "0x8138E4")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x813A1C", Offset = "0x813A1C", VA = "0x813A1C")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x813E04", Offset = "0x813E04", VA = "0x813E04")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x813F04", Offset = "0x813F04", VA = "0x813F04")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x8140A4", Offset = "0x8140A4", VA = "0x8140A4")]
		private void CleanCachedValues()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x814158", Offset = "0x814158", VA = "0x814158")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x8144A0", Offset = "0x8144A0", VA = "0x8144A0")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x814594", Offset = "0x814594", VA = "0x814594", Slot = "10")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x8146E0", Offset = "0x8146E0", VA = "0x8146E0", Slot = "11")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x8148BC", Offset = "0x8148BC", VA = "0x8148BC")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x814AAC", Offset = "0x814AAC", VA = "0x814AAC", Slot = "12")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x814AB0", Offset = "0x814AB0", VA = "0x814AB0", Slot = "13")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x815778", Offset = "0x815778", VA = "0x815778", Slot = "14")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x815CB8", Offset = "0x815CB8", VA = "0x815CB8", Slot = "15")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x81681C", Offset = "0x81681C", VA = "0x81681C", Slot = "16")]
		public virtual void OnMessage(object message)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<byte, object> opParameters;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x816988", Offset = "0x816988", VA = "0x816988")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x811CF4", Offset = "0x811CF4", VA = "0x811CF4")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x816A44", Offset = "0x816A44", VA = "0x816A44", Slot = "19")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x816B0C", Offset = "0x816B0C", VA = "0x816B0C", Slot = "20")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x816D04", Offset = "0x816D04", VA = "0x816D04", Slot = "21")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x816DF8", Offset = "0x816DF8", VA = "0x816DF8")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x817168", Offset = "0x817168", VA = "0x817168", Slot = "22")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x81741C", Offset = "0x81741C", VA = "0x81741C", Slot = "23")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x817720", Offset = "0x817720", VA = "0x817720", Slot = "24")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x817A34", Offset = "0x817A34", VA = "0x817A34", Slot = "25")]
		public virtual bool OpLeaveRoom(bool becomeInactive)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x817B30", Offset = "0x817B30", VA = "0x817B30", Slot = "26")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x813158", Offset = "0x813158", VA = "0x813158")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x81366C", Offset = "0x81366C", VA = "0x81366C")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x817C04", Offset = "0x817C04", VA = "0x817C04", Slot = "27")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x817F24", Offset = "0x817F24", VA = "0x817F24", Slot = "28")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x81827C", Offset = "0x81827C", VA = "0x81827C", Slot = "29")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x818404", Offset = "0x818404", VA = "0x818404", Slot = "30")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x81864C", Offset = "0x81864C", VA = "0x81864C", Slot = "31")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001F")]
	public class OpJoinRandomRoomParams
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hashtable ExpectedCustomRoomProperties;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte ExpectedMaxPlayers;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public MatchmakingMode MatchingType;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby TypedLobby;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string SqlLobbyFilter;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] ExpectedUsers;

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x812874", Offset = "0x812874", VA = "0x812874")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class EnterRoomParams
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string RoomName;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RoomOptions RoomOptions;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby Lobby;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hashtable PlayerProperties;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool OnGameServer;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool CreateIfNotExists;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool RejoinOnly;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] ExpectedUsers;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x812864", Offset = "0x812864", VA = "0x812864")]
		public EnterRoomParams()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class ErrorCode
	{
		[Token(Token = "0x40000E6")]
		public const int Ok = 0;

		[Token(Token = "0x40000E7")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x40000E8")]
		[Obsolete("Use InvalidOperation.")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x40000E9")]
		public const int InvalidOperation = -2;

		[Token(Token = "0x40000EA")]
		public const int InternalServerError = -1;

		[Token(Token = "0x40000EB")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x40000EC")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x40000ED")]
		public const int GameFull = 32765;

		[Token(Token = "0x40000EE")]
		public const int GameClosed = 32764;

		[Token(Token = "0x40000EF")]
		[Obsolete("No longer used, cause random matchmaking is no longer a process.")]
		public const int AlreadyMatched = 32763;

		[Token(Token = "0x40000F0")]
		public const int ServerFull = 32762;

		[Token(Token = "0x40000F1")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x40000F2")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x40000F3")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x40000F4")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x40000F5")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x40000F6")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x40000F7")]
		public const int AuthenticationTicketExpired = 32753;

		[Token(Token = "0x40000F8")]
		public const int PluginReportedError = 32752;

		[Token(Token = "0x40000F9")]
		public const int PluginMismatch = 32751;

		[Token(Token = "0x40000FA")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Token(Token = "0x40000FB")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Token(Token = "0x40000FC")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Token(Token = "0x40000FD")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Token(Token = "0x40000FE")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Token(Token = "0x40000FF")]
		public const int HttpLimitReached = 32745;

		[Token(Token = "0x4000100")]
		public const int ExternalHttpCallFailed = 32744;

		[Token(Token = "0x4000101")]
		public const int SlotError = 32742;

		[Token(Token = "0x4000102")]
		public const int InvalidEncryptionParameters = 32741;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x818804", Offset = "0x818804", VA = "0x818804")]
		public ErrorCode()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class ActorProperties
	{
		[Token(Token = "0x4000103")]
		public const byte PlayerName = byte.MaxValue;

		[Token(Token = "0x4000104")]
		public const byte IsInactive = 254;

		[Token(Token = "0x4000105")]
		public const byte UserId = 253;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x81880C", Offset = "0x81880C", VA = "0x81880C")]
		public ActorProperties()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class GamePropertyKey
	{
		[Token(Token = "0x4000106")]
		public const byte MaxPlayers = byte.MaxValue;

		[Token(Token = "0x4000107")]
		public const byte IsVisible = 254;

		[Token(Token = "0x4000108")]
		public const byte IsOpen = 253;

		[Token(Token = "0x4000109")]
		public const byte PlayerCount = 252;

		[Token(Token = "0x400010A")]
		public const byte Removed = 251;

		[Token(Token = "0x400010B")]
		public const byte PropsListedInLobby = 250;

		[Token(Token = "0x400010C")]
		public const byte CleanupCacheOnLeave = 249;

		[Token(Token = "0x400010D")]
		public const byte MasterClientId = 248;

		[Token(Token = "0x400010E")]
		public const byte ExpectedUsers = 247;

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x818814", Offset = "0x818814", VA = "0x818814")]
		public GamePropertyKey()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class EventCode
	{
		[Token(Token = "0x400010F")]
		public const byte GameList = 230;

		[Token(Token = "0x4000110")]
		public const byte GameListUpdate = 229;

		[Token(Token = "0x4000111")]
		public const byte QueueState = 228;

		[Token(Token = "0x4000112")]
		public const byte Match = 227;

		[Token(Token = "0x4000113")]
		public const byte AppStats = 226;

		[Token(Token = "0x4000114")]
		public const byte LobbyStats = 224;

		[Token(Token = "0x4000115")]
		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x4000116")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x4000117")]
		public const byte Leave = 254;

		[Token(Token = "0x4000118")]
		public const byte PropertiesChanged = 253;

		[Token(Token = "0x4000119")]
		[Obsolete("Use PropertiesChanged now.")]
		public const byte SetProperties = 253;

		[Token(Token = "0x400011A")]
		public const byte ErrorInfo = 251;

		[Token(Token = "0x400011B")]
		public const byte CacheSliceChanged = 250;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x81881C", Offset = "0x81881C", VA = "0x81881C")]
		public EventCode()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class ParameterCode
	{
		[Token(Token = "0x400011C")]
		public const byte SuppressRoomEvents = 237;

		[Token(Token = "0x400011D")]
		public const byte EmptyRoomTTL = 236;

		[Token(Token = "0x400011E")]
		public const byte PlayerTTL = 235;

		[Token(Token = "0x400011F")]
		public const byte EventForward = 234;

		[Token(Token = "0x4000120")]
		[Obsolete("Use: IsInactive")]
		public const byte IsComingBack = 233;

		[Token(Token = "0x4000121")]
		public const byte IsInactive = 233;

		[Token(Token = "0x4000122")]
		public const byte CheckUserOnJoin = 232;

		[Token(Token = "0x4000123")]
		public const byte ExpectedValues = 231;

		[Token(Token = "0x4000124")]
		public const byte Address = 230;

		[Token(Token = "0x4000125")]
		public const byte PeerCount = 229;

		[Token(Token = "0x4000126")]
		public const byte GameCount = 228;

		[Token(Token = "0x4000127")]
		public const byte MasterPeerCount = 227;

		[Token(Token = "0x4000128")]
		public const byte UserId = 225;

		[Token(Token = "0x4000129")]
		public const byte ApplicationId = 224;

		[Token(Token = "0x400012A")]
		public const byte Position = 223;

		[Token(Token = "0x400012B")]
		public const byte MatchMakingType = 223;

		[Token(Token = "0x400012C")]
		public const byte GameList = 222;

		[Token(Token = "0x400012D")]
		public const byte Secret = 221;

		[Token(Token = "0x400012E")]
		public const byte AppVersion = 220;

		[Token(Token = "0x400012F")]
		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x4000130")]
		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureLocalNodeId = 209;

		[Token(Token = "0x4000131")]
		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureMasterNodeId = 208;

		[Token(Token = "0x4000132")]
		public const byte RoomName = byte.MaxValue;

		[Token(Token = "0x4000133")]
		public const byte Broadcast = 250;

		[Token(Token = "0x4000134")]
		public const byte ActorList = 252;

		[Token(Token = "0x4000135")]
		public const byte ActorNr = 254;

		[Token(Token = "0x4000136")]
		public const byte PlayerProperties = 249;

		[Token(Token = "0x4000137")]
		public const byte CustomEventContent = 245;

		[Token(Token = "0x4000138")]
		public const byte Data = 245;

		[Token(Token = "0x4000139")]
		public const byte Code = 244;

		[Token(Token = "0x400013A")]
		public const byte GameProperties = 248;

		[Token(Token = "0x400013B")]
		public const byte Properties = 251;

		[Token(Token = "0x400013C")]
		public const byte TargetActorNr = 253;

		[Token(Token = "0x400013D")]
		public const byte ReceiverGroup = 246;

		[Token(Token = "0x400013E")]
		public const byte Cache = 247;

		[Token(Token = "0x400013F")]
		public const byte CleanupCacheOnLeave = 241;

		[Token(Token = "0x4000140")]
		public const byte Group = 240;

		[Token(Token = "0x4000141")]
		public const byte Remove = 239;

		[Token(Token = "0x4000142")]
		public const byte PublishUserId = 239;

		[Token(Token = "0x4000143")]
		public const byte Add = 238;

		[Token(Token = "0x4000144")]
		public const byte Info = 218;

		[Token(Token = "0x4000145")]
		public const byte ClientAuthenticationType = 217;

		[Token(Token = "0x4000146")]
		public const byte ClientAuthenticationParams = 216;

		[Token(Token = "0x4000147")]
		public const byte JoinMode = 215;

		[Token(Token = "0x4000148")]
		public const byte ClientAuthenticationData = 214;

		[Token(Token = "0x4000149")]
		public const byte MasterClientId = 203;

		[Token(Token = "0x400014A")]
		public const byte FindFriendsRequestList = 1;

		[Token(Token = "0x400014B")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Token(Token = "0x400014C")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Token(Token = "0x400014D")]
		public const byte LobbyName = 213;

		[Token(Token = "0x400014E")]
		public const byte LobbyType = 212;

		[Token(Token = "0x400014F")]
		public const byte LobbyStats = 211;

		[Token(Token = "0x4000150")]
		public const byte Region = 210;

		[Token(Token = "0x4000151")]
		public const byte UriPath = 209;

		[Token(Token = "0x4000152")]
		public const byte WebRpcParameters = 208;

		[Token(Token = "0x4000153")]
		public const byte WebRpcReturnCode = 207;

		[Token(Token = "0x4000154")]
		public const byte WebRpcReturnMessage = 206;

		[Token(Token = "0x4000155")]
		public const byte CacheSliceIndex = 205;

		[Token(Token = "0x4000156")]
		public const byte Plugins = 204;

		[Token(Token = "0x4000157")]
		public const byte NickName = 202;

		[Token(Token = "0x4000158")]
		public const byte PluginName = 201;

		[Token(Token = "0x4000159")]
		public const byte PluginVersion = 200;

		[Token(Token = "0x400015A")]
		public const byte ExpectedProtocol = 195;

		[Token(Token = "0x400015B")]
		public const byte CustomInitData = 194;

		[Token(Token = "0x400015C")]
		public const byte EncryptionMode = 193;

		[Token(Token = "0x400015D")]
		public const byte EncryptionData = 192;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x818824", Offset = "0x818824", VA = "0x818824")]
		public ParameterCode()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class OperationCode
	{
		[Token(Token = "0x400015E")]
		[Obsolete("Exchanging encrpytion keys is done internally in the lib now. Don't expect this operation-result.")]
		public const byte ExchangeKeysForEncryption = 250;

		[Token(Token = "0x400015F")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x4000160")]
		public const byte AuthenticateOnce = 231;

		[Token(Token = "0x4000161")]
		public const byte Authenticate = 230;

		[Token(Token = "0x4000162")]
		public const byte JoinLobby = 229;

		[Token(Token = "0x4000163")]
		public const byte LeaveLobby = 228;

		[Token(Token = "0x4000164")]
		public const byte CreateGame = 227;

		[Token(Token = "0x4000165")]
		public const byte JoinGame = 226;

		[Token(Token = "0x4000166")]
		public const byte JoinRandomGame = 225;

		[Token(Token = "0x4000167")]
		public const byte Leave = 254;

		[Token(Token = "0x4000168")]
		public const byte RaiseEvent = 253;

		[Token(Token = "0x4000169")]
		public const byte SetProperties = 252;

		[Token(Token = "0x400016A")]
		public const byte GetProperties = 251;

		[Token(Token = "0x400016B")]
		public const byte ChangeGroups = 248;

		[Token(Token = "0x400016C")]
		public const byte FindFriends = 222;

		[Token(Token = "0x400016D")]
		public const byte GetLobbyStats = 221;

		[Token(Token = "0x400016E")]
		public const byte GetRegions = 220;

		[Token(Token = "0x400016F")]
		public const byte WebRpc = 219;

		[Token(Token = "0x4000170")]
		public const byte ServerSettings = 218;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x81882C", Offset = "0x81882C", VA = "0x81882C")]
		public OperationCode()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public enum JoinMode : byte
	{
		[Token(Token = "0x4000172")]
		Default,
		[Token(Token = "0x4000173")]
		CreateIfNotExists,
		[Token(Token = "0x4000174")]
		JoinOrRejoin,
		[Token(Token = "0x4000175")]
		RejoinOnly
	}
	[Token(Token = "0x2000028")]
	public enum MatchmakingMode : byte
	{
		[Token(Token = "0x4000177")]
		FillRoom,
		[Token(Token = "0x4000178")]
		SerialMatching,
		[Token(Token = "0x4000179")]
		RandomMatching
	}
	[Token(Token = "0x2000029")]
	public enum ReceiverGroup : byte
	{
		[Token(Token = "0x400017B")]
		Others,
		[Token(Token = "0x400017C")]
		All,
		[Token(Token = "0x400017D")]
		MasterClient
	}
	[Token(Token = "0x200002A")]
	public enum EventCaching : byte
	{
		[Token(Token = "0x400017F")]
		DoNotCache = 0,
		[Token(Token = "0x4000180")]
		[Obsolete]
		MergeCache = 1,
		[Token(Token = "0x4000181")]
		[Obsolete]
		ReplaceCache = 2,
		[Token(Token = "0x4000182")]
		[Obsolete]
		RemoveCache = 3,
		[Token(Token = "0x4000183")]
		AddToRoomCache = 4,
		[Token(Token = "0x4000184")]
		AddToRoomCacheGlobal = 5,
		[Token(Token = "0x4000185")]
		RemoveFromRoomCache = 6,
		[Token(Token = "0x4000186")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Token(Token = "0x4000187")]
		SliceIncreaseIndex = 10,
		[Token(Token = "0x4000188")]
		SliceSetIndex = 11,
		[Token(Token = "0x4000189")]
		SlicePurgeIndex = 12,
		[Token(Token = "0x400018A")]
		SlicePurgeUpToIndex = 13
	}
	[Token(Token = "0x200002B")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Token(Token = "0x400018C")]
		None = 0,
		[Token(Token = "0x400018D")]
		Game = 1,
		[Token(Token = "0x400018E")]
		Actor = 2,
		[Token(Token = "0x400018F")]
		GameAndActor = 3
	}
	[Token(Token = "0x200002C")]
	public class RoomOptions
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isVisible;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool isOpen;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte MaxPlayers;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int PlayerTtl;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int EmptyRoomTtl;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool cleanupCacheOnLeave;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hashtable CustomRoomProperties;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] CustomRoomPropertiesForLobby;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] Plugins;

		[Token(Token = "0x17000040")]
		public bool IsVisible
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x818834", Offset = "0x818834", VA = "0x818834")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x81883C", Offset = "0x81883C", VA = "0x81883C")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public bool IsOpen
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x818848", Offset = "0x818848", VA = "0x818848")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x818850", Offset = "0x818850", VA = "0x818850")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool CheckUserOnJoin
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x81885C", Offset = "0x81885C", VA = "0x81885C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x818864", Offset = "0x818864", VA = "0x818864")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool CleanupCacheOnLeave
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x818870", Offset = "0x818870", VA = "0x818870")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x818878", Offset = "0x818878", VA = "0x818878")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool SuppressRoomEvents
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x818884", Offset = "0x818884", VA = "0x818884")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x81888C", Offset = "0x81888C", VA = "0x81888C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public bool PublishUserId
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x818898", Offset = "0x818898", VA = "0x818898")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x8188A0", Offset = "0x8188A0", VA = "0x8188A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x814774", Offset = "0x814774", VA = "0x814774")]
		public RoomOptions()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class RaiseEventOptions
	{
		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly RaiseEventOptions Default;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventCaching CachingOption;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte InterestGroup;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] TargetActors;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReceiverGroup Receivers;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public byte SequenceChannel;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WebFlags Flags;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x8188AC", Offset = "0x8188AC", VA = "0x8188AC")]
		public RaiseEventOptions()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public enum LobbyType : byte
	{
		[Token(Token = "0x40001A4")]
		Default = 0,
		[Token(Token = "0x40001A5")]
		SqlLobby = 2,
		[Token(Token = "0x40001A6")]
		AsyncRandomLobby = 3
	}
	[Token(Token = "0x200002F")]
	public class TypedLobby
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LobbyType Type;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypedLobby Default;

		[Token(Token = "0x17000046")]
		public bool IsDefault
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x816CE8", Offset = "0x816CE8", VA = "0x816CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x818988", Offset = "0x818988", VA = "0x818988")]
		public TypedLobby()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x8189F0", Offset = "0x8189F0", VA = "0x8189F0")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x818A2C", Offset = "0x818A2C", VA = "0x818A2C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000030")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int PlayerCount;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RoomCount;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x818B24", Offset = "0x818B24", VA = "0x818B24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x8167C8", Offset = "0x8167C8", VA = "0x8167C8")]
		public TypedLobbyInfo()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public enum AuthModeOption
	{
		[Token(Token = "0x40001AD")]
		Auth,
		[Token(Token = "0x40001AE")]
		AuthOnce,
		[Token(Token = "0x40001AF")]
		AuthOnceWss
	}
	[Token(Token = "0x2000032")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x40001B1")]
		Custom = 0,
		[Token(Token = "0x40001B2")]
		Steam = 1,
		[Token(Token = "0x40001B3")]
		Facebook = 2,
		[Token(Token = "0x40001B4")]
		None = byte.MaxValue
	}
	[Token(Token = "0x2000033")]
	public class AuthenticationValues
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CustomAuthenticationType authType;

		[Token(Token = "0x17000047")]
		public CustomAuthenticationType AuthType
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x818D00", Offset = "0x818D00", VA = "0x818D00")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x818D08", Offset = "0x818D08", VA = "0x818D08")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public string AuthGetParameters
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x818D10", Offset = "0x818D10", VA = "0x818D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x818D18", Offset = "0x818D18", VA = "0x818D18")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public object AuthPostData
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x818D20", Offset = "0x818D20", VA = "0x818D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x818D28", Offset = "0x818D28", VA = "0x818D28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public string Token
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x818D30", Offset = "0x818D30", VA = "0x818D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x818D38", Offset = "0x818D38", VA = "0x818D38")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public string UserId
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x818D40", Offset = "0x818D40", VA = "0x818D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x818D48", Offset = "0x818D48", VA = "0x818D48")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x811A84", Offset = "0x811A84", VA = "0x811A84")]
		public AuthenticationValues()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x818D50", Offset = "0x818D50", VA = "0x818D50")]
		public AuthenticationValues(string userId)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x818D88", Offset = "0x818D88", VA = "0x818D88", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x818DC8", Offset = "0x818DC8", VA = "0x818DC8", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x818DD0", Offset = "0x818DD0", VA = "0x818DD0", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x818FD4", Offset = "0x818FD4", VA = "0x818FD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000034")]
	public class Player
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int actorID;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly bool IsLocal;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string nickName;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object Tag;

		[Token(Token = "0x1700004C")]
		protected internal Room RoomReference
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x81906C", Offset = "0x81906C", VA = "0x81906C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x819074", Offset = "0x819074", VA = "0x819074")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public int ID
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x81907C", Offset = "0x81907C", VA = "0x81907C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004E")]
		public string NickName
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x819084", Offset = "0x819084", VA = "0x819084")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x811958", Offset = "0x811958", VA = "0x811958")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		[Obsolete("Use NickName")]
		public string Name
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x819168", Offset = "0x819168", VA = "0x819168")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x819170", Offset = "0x819170", VA = "0x819170")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public bool IsMasterClient
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x819174", Offset = "0x819174", VA = "0x819174")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000051")]
		public bool IsInactive
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x819198", Offset = "0x819198", VA = "0x819198")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x8191A0", Offset = "0x8191A0", VA = "0x8191A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x8191AC", Offset = "0x8191AC", VA = "0x8191AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x8191B4", Offset = "0x8191B4", VA = "0x8191B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public Hashtable AllProperties
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x8156C8", Offset = "0x8156C8", VA = "0x8156C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x8191BC", Offset = "0x8191BC", VA = "0x8191BC")]
		public Player Get(int id)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x8191D4", Offset = "0x8191D4", VA = "0x8191D4")]
		public Player GetNext()
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x8193D8", Offset = "0x8193D8", VA = "0x8193D8")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x8191DC", Offset = "0x8191DC", VA = "0x8191DC")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x8193EC", Offset = "0x8193EC", VA = "0x8193EC")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x81461C", Offset = "0x81461C", VA = "0x81461C")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x8193F8", Offset = "0x8193F8", VA = "0x8193F8", Slot = "4")]
		public virtual void CacheProperties(Hashtable properties)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x8195E8", Offset = "0x8195E8", VA = "0x8195E8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x819670", Offset = "0x819670", VA = "0x819670", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x819724", Offset = "0x819724", VA = "0x819724", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x814094", Offset = "0x814094", VA = "0x814094")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x812F5C", Offset = "0x812F5C", VA = "0x812F5C")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x81908C", Offset = "0x81908C", VA = "0x81908C")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Room : RoomInfo
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected internal int PlayerTTL;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected internal int RoomTTL;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<int, Player> players;

		[Token(Token = "0x17000054")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x81972C", Offset = "0x81972C", VA = "0x81972C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x819734", Offset = "0x819734", VA = "0x819734")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public new string Name
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x81973C", Offset = "0x81973C", VA = "0x81973C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x819744", Offset = "0x819744", VA = "0x819744")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public new bool IsOpen
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x81974C", Offset = "0x81974C", VA = "0x81974C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x819754", Offset = "0x819754", VA = "0x819754")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public new bool IsVisible
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x8198B0", Offset = "0x8198B0", VA = "0x8198B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x8198B8", Offset = "0x8198B8", VA = "0x8198B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public new byte MaxPlayers
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x819A14", Offset = "0x819A14", VA = "0x819A14")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x819A1C", Offset = "0x819A1C", VA = "0x819A1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public new byte PlayerCount
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x819B5C", Offset = "0x819B5C", VA = "0x819B5C")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x1700005A")]
		public Dictionary<int, Player> Players
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x819BAC", Offset = "0x819BAC", VA = "0x819BAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x819BB4", Offset = "0x819BB4", VA = "0x819BB4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public string[] ExpectedUsers
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x819BBC", Offset = "0x819BBC", VA = "0x819BBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public int MasterClientId
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x819BC4", Offset = "0x819BC4", VA = "0x819BC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005D")]
		public string[] PropsListedInLobby
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x819BCC", Offset = "0x819BCC", VA = "0x819BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x819BD4", Offset = "0x819BD4", VA = "0x819BD4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x819BDC", Offset = "0x819BDC", VA = "0x819BDC")]
		protected internal Room()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x819C68", Offset = "0x819C68", VA = "0x819C68")]
		protected internal Room(string roomName)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x8147E8", Offset = "0x8147E8", VA = "0x8147E8")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x819D00", Offset = "0x819D00", VA = "0x819D00", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x819DC0", Offset = "0x819DC0", VA = "0x819DC0")]
		public void SetPropertiesListedInLobby(string[] propsToListInLobby)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x819E90", Offset = "0x819E90", VA = "0x819E90", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x81A0C0", Offset = "0x81A0C0", VA = "0x81A0C0", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x81A0EC", Offset = "0x81A0EC", VA = "0x81A0EC", Slot = "8")]
		protected internal virtual void MarkAsInactive(int id)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x819F20", Offset = "0x819F20", VA = "0x819F20")]
		private void UpdateMasterClientId()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x81A110", Offset = "0x81A110", VA = "0x81A110")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x81A2F0", Offset = "0x81A2F0", VA = "0x81A2F0", Slot = "9")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x81A374", Offset = "0x81A374", VA = "0x81A374", Slot = "10")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x81A408", Offset = "0x81A408", VA = "0x81A408", Slot = "11")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x81A478", Offset = "0x81A478", VA = "0x81A478")]
		public void ClearExpectedUsers()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x81A59C", Offset = "0x81A59C", VA = "0x81A59C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x81A7FC", Offset = "0x81A7FC", VA = "0x81A7FC")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x2000036")]
	public class RoomInfo
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal bool removedFromList;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Hashtable customProperties;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected byte maxPlayers;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string[] expectedUsersField;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool isOpen;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isVisible;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected string name;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal int masterClientIdField;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected string[] propsListedInLobby;

		[Token(Token = "0x1700005E")]
		protected internal bool serverSideMasterClient
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x81AAC8", Offset = "0x81AAC8", VA = "0x81AAC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x81AAD0", Offset = "0x81AAD0", VA = "0x81AAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x81AADC", Offset = "0x81AADC", VA = "0x81AADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public string Name
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x81AAE4", Offset = "0x81AAE4", VA = "0x81AAE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public int PlayerCount
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x81AAEC", Offset = "0x81AAEC", VA = "0x81AAEC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x81AAF4", Offset = "0x81AAF4", VA = "0x81AAF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public bool IsLocalClientInside
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x81AAFC", Offset = "0x81AAFC", VA = "0x81AAFC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x81AB04", Offset = "0x81AB04", VA = "0x81AB04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public byte MaxPlayers
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x81AB10", Offset = "0x81AB10", VA = "0x81AB10")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000064")]
		public bool IsOpen
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x81AB18", Offset = "0x81AB18", VA = "0x81AB18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		public bool IsVisible
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x81AB20", Offset = "0x81AB20", VA = "0x81AB20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x816718", Offset = "0x816718", VA = "0x816718")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x81AB28", Offset = "0x81AB28", VA = "0x81AB28", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x81ABC8", Offset = "0x81ABC8", VA = "0x81ABC8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x81ABE8", Offset = "0x81ABE8", VA = "0x81ABE8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x81AE54", Offset = "0x81AE54", VA = "0x81AE54")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x81B12C", Offset = "0x81B12C", VA = "0x81B12C", Slot = "4")]
		protected internal virtual void CacheProperties(Hashtable propertiesToCache)
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000037")]
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x81B600", Offset = "0x81B600", VA = "0x81B600")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x81B6D8", Offset = "0x81B6D8", VA = "0x81B6D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x81BC44", Offset = "0x81BC44", VA = "0x81BC44")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x81C194", Offset = "0x81C194", VA = "0x81C194")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000066")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600016F")]
				[Address(RVA = "0x81C8C8", Offset = "0x81C8C8", VA = "0x81C8C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000171")]
				[Address(RVA = "0x81C910", Offset = "0x81C910", VA = "0x81C910", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600016C")]
			[Address(RVA = "0x81C21C", Offset = "0x81C21C", VA = "0x81C21C")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600016D")]
			[Address(RVA = "0x81C398", Offset = "0x81C398", VA = "0x81C398", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600016E")]
			[Address(RVA = "0x81C39C", Offset = "0x81C39C", VA = "0x81C39C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x81C8D0", Offset = "0x81C8D0", VA = "0x81C8D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x81C1A8", Offset = "0x81C1A8", VA = "0x81C1A8")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x81C244", Offset = "0x81C244", VA = "0x81C244")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x81C390", Offset = "0x81C390", VA = "0x81C390")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000068")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000177")]
				[Address(RVA = "0x81CDAC", Offset = "0x81CDAC", VA = "0x81CDAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000069")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000179")]
				[Address(RVA = "0x81CDF4", Offset = "0x81CDF4", VA = "0x81CDF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x81C98C", Offset = "0x81C98C", VA = "0x81C98C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x81C9C4", Offset = "0x81C9C4", VA = "0x81C9C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x81C9C8", Offset = "0x81C9C8", VA = "0x81C9C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000178")]
			[Address(RVA = "0x81CDB4", Offset = "0x81CDB4", VA = "0x81CDB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x81C918", Offset = "0x81C918", VA = "0x81C918")]
		[IteratorStateMachine(typeof(<Start>d__1))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x81C9B4", Offset = "0x81C9B4", VA = "0x81C9B4")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x81CDFC", Offset = "0x81CDFC", VA = "0x81CDFC")]
		private void Start()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x81CE54", Offset = "0x81CE54", VA = "0x81CE54")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x81CECC", Offset = "0x81CECC", VA = "0x81CECC")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x81CEDC", Offset = "0x81CEDC", VA = "0x81CEDC")]
		private void Start()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x81CF4C", Offset = "0x81CF4C", VA = "0x81CF4C")]
		private void Update()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x81D134", Offset = "0x81D134", VA = "0x81D134")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x81D15C", Offset = "0x81D15C", VA = "0x81D15C")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x81D16C", Offset = "0x81D16C", VA = "0x81D16C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x81D2B4", Offset = "0x81D2B4", VA = "0x81D2B4")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x81D2D0", Offset = "0x81D2D0", VA = "0x81D2D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x81D3FC", Offset = "0x81D3FC", VA = "0x81D3FC")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x81D40C", Offset = "0x81D40C", VA = "0x81D40C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x81D4BC", Offset = "0x81D4BC", VA = "0x81D4BC")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x81D4C4", Offset = "0x81D4C4", VA = "0x81D4C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x81D51C", Offset = "0x81D51C", VA = "0x81D51C")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x81D7FC", Offset = "0x81D7FC", VA = "0x81D7FC")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000042")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x81D890", Offset = "0x81D890", VA = "0x81D890")]
		private void Update()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x81DA8C", Offset = "0x81DA8C", VA = "0x81DA8C")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x81DA94", Offset = "0x81DA94", VA = "0x81DA94")]
		public void Awake()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x81DAB4", Offset = "0x81DAB4", VA = "0x81DAB4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x81DB18", Offset = "0x81DB18", VA = "0x81DB18")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x81DB7C", Offset = "0x81DB7C", VA = "0x81DB7C")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x81DB84", Offset = "0x81DB84", VA = "0x81DB84")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class MeshContainer
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x81DB8C", Offset = "0x81DB8C", VA = "0x81DB8C")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x81DBFC", Offset = "0x81DBFC", VA = "0x81DBFC")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x81DC34", Offset = "0x81DC34", VA = "0x81DC34")]
		public void Start()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x81DD30", Offset = "0x81DD30", VA = "0x81DD30")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x81E040", Offset = "0x81E040", VA = "0x81E040")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x81E0F4", Offset = "0x81E0F4", VA = "0x81E0F4")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x81E24C", Offset = "0x81E24C", VA = "0x81E24C")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x81EAC0", Offset = "0x81EAC0", VA = "0x81EAC0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x81EB18", Offset = "0x81EB18", VA = "0x81EB18")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x81EBF8", Offset = "0x81EBF8", VA = "0x81EBF8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x81EC5C", Offset = "0x81EC5C", VA = "0x81EC5C")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x81E408", Offset = "0x81E408", VA = "0x81E408")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x81ECC0", Offset = "0x81ECC0", VA = "0x81ECC0")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x81EF74", Offset = "0x81EF74", VA = "0x81EF74")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x81ED20", Offset = "0x81ED20", VA = "0x81ED20")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x81F0E0", Offset = "0x81F0E0", VA = "0x81F0E0")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x81EDC4", Offset = "0x81EDC4", VA = "0x81EDC4")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x81F100", Offset = "0x81F100", VA = "0x81F100")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[RequireComponent(typeof(WaterBase))]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x81F170", Offset = "0x81F170", VA = "0x81F170")]
		public void Start()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x81F298", Offset = "0x81F298", VA = "0x81F298")]
		public void Update()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x81F4B0", Offset = "0x81F4B0", VA = "0x81F4B0")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public enum WaterMode
		{
			[Token(Token = "0x4000211")]
			Simple,
			[Token(Token = "0x4000212")]
			Reflective,
			[Token(Token = "0x4000213")]
			Refractive
		}

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x81F4B8", Offset = "0x81F4B8", VA = "0x81F4B8")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x820DF8", Offset = "0x820DF8", VA = "0x820DF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x821160", Offset = "0x821160", VA = "0x821160")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x820978", Offset = "0x820978", VA = "0x820978")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x82000C", Offset = "0x82000C", VA = "0x82000C")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x81FFF8", Offset = "0x81FFF8", VA = "0x81FFF8")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x81FE8C", Offset = "0x81FE8C", VA = "0x81FE8C")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x820C48", Offset = "0x820C48", VA = "0x820C48")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x820BB4", Offset = "0x820BB4", VA = "0x820BB4")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x82140C", Offset = "0x82140C", VA = "0x82140C")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000215")]
		High = 2,
		[Token(Token = "0x4000216")]
		Medium = 1,
		[Token(Token = "0x4000217")]
		Low = 0
	}
	[Token(Token = "0x200004B")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x82150C", Offset = "0x82150C", VA = "0x82150C")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x821684", Offset = "0x821684", VA = "0x821684")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x821728", Offset = "0x821728", VA = "0x821728")]
		public void Update()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x82179C", Offset = "0x82179C", VA = "0x82179C")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x8217B4", Offset = "0x8217B4", VA = "0x8217B4")]
		public void Start()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x8217B8", Offset = "0x8217B8", VA = "0x8217B8")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x821978", Offset = "0x821978", VA = "0x821978")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x821A5C", Offset = "0x821A5C", VA = "0x821A5C")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200004D")]
	public enum AAMode
	{
		[Token(Token = "0x400021E")]
		FXAA2,
		[Token(Token = "0x400021F")]
		FXAA3Console,
		[Token(Token = "0x4000220")]
		FXAA1PresetA,
		[Token(Token = "0x4000221")]
		FXAA1PresetB,
		[Token(Token = "0x4000222")]
		NFAA,
		[Token(Token = "0x4000223")]
		SSAA,
		[Token(Token = "0x4000224")]
		DLAA
	}
	[Token(Token = "0x200004E")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x821A64", Offset = "0x821A64", VA = "0x821A64")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x821ACC", Offset = "0x821ACC", VA = "0x821ACC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x821C3C", Offset = "0x821C3C", VA = "0x821C3C")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x822100", Offset = "0x822100", VA = "0x822100")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000050")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x400025A")]
			Ghosting,
			[Token(Token = "0x400025B")]
			Anamorphic,
			[Token(Token = "0x400025C")]
			Combined
		}

		[Token(Token = "0x2000051")]
		public enum TweakMode
		{
			[Token(Token = "0x400025E")]
			Basic,
			[Token(Token = "0x400025F")]
			Complex
		}

		[Token(Token = "0x2000052")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000261")]
			Auto,
			[Token(Token = "0x4000262")]
			On,
			[Token(Token = "0x4000263")]
			Off
		}

		[Token(Token = "0x2000053")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x4000265")]
			Screen,
			[Token(Token = "0x4000266")]
			Add
		}

		[Token(Token = "0x2000054")]
		public enum BloomQuality
		{
			[Token(Token = "0x4000268")]
			Cheap,
			[Token(Token = "0x4000269")]
			High
		}

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x822124", Offset = "0x822124", VA = "0x822124", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x822210", Offset = "0x822210", VA = "0x822210")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x823380", Offset = "0x823380", VA = "0x823380")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x8231E8", Offset = "0x8231E8", VA = "0x8231E8")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x822F3C", Offset = "0x822F3C", VA = "0x822F3C")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x822E68", Offset = "0x822E68", VA = "0x822E68")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x822FFC", Offset = "0x822FFC", VA = "0x822FFC")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x823444", Offset = "0x823444", VA = "0x823444")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x400026B")]
		Ghosting,
		[Token(Token = "0x400026C")]
		Anamorphic,
		[Token(Token = "0x400026D")]
		Combined
	}
	[Token(Token = "0x2000056")]
	public enum TweakMode34
	{
		[Token(Token = "0x400026F")]
		Basic,
		[Token(Token = "0x4000270")]
		Complex
	}
	[Token(Token = "0x2000057")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000272")]
		Auto,
		[Token(Token = "0x4000273")]
		On,
		[Token(Token = "0x4000274")]
		Off
	}
	[Token(Token = "0x2000058")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000276")]
		Screen,
		[Token(Token = "0x4000277")]
		Add
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x8234D0", Offset = "0x8234D0", VA = "0x8234D0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x82362C", Offset = "0x82362C", VA = "0x82362C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x8243EC", Offset = "0x8243EC", VA = "0x8243EC")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x824264", Offset = "0x824264", VA = "0x824264")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x82400C", Offset = "0x82400C", VA = "0x82400C")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x824114", Offset = "0x824114", VA = "0x824114")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x82449C", Offset = "0x82449C", VA = "0x82449C")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x200005B")]
		public enum Resolution
		{
			[Token(Token = "0x40002A3")]
			Low,
			[Token(Token = "0x40002A4")]
			High
		}

		[Token(Token = "0x200005C")]
		public enum BlurType
		{
			[Token(Token = "0x40002A6")]
			Standard,
			[Token(Token = "0x40002A7")]
			Sgx
		}

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float threshold;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 2.5f)]
		public float intensity;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0.25f, 5.5f)]
		public float blurSize;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x824510", Offset = "0x824510", VA = "0x824510", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x824584", Offset = "0x824584", VA = "0x824584")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x824610", Offset = "0x824610", VA = "0x824610")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x824980", Offset = "0x824980", VA = "0x824980")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x1700006A")]
		protected Material material
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x8249A4", Offset = "0x8249A4", VA = "0x8249A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x824AAC", Offset = "0x824AAC", VA = "0x824AAC")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x824B58", Offset = "0x824B58", VA = "0x824B58")]
		protected void Start()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x824C08", Offset = "0x824C08", VA = "0x824C08")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x824D18", Offset = "0x824D18", VA = "0x824D18")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x824E14", Offset = "0x824E14", VA = "0x824E14")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x824F70", Offset = "0x824F70", VA = "0x824F70")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200005F")]
		public enum BlurType
		{
			[Token(Token = "0x40002B3")]
			StandardGauss,
			[Token(Token = "0x40002B4")]
			SgxGauss
		}

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 2f)]
		public int downsample;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		public float blurSize;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1f, 4f)]
		public int blurIterations;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x824F88", Offset = "0x824F88", VA = "0x824F88", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x824FFC", Offset = "0x824FFC", VA = "0x824FFC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x825088", Offset = "0x825088", VA = "0x825088")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x8253B0", Offset = "0x8253B0", VA = "0x8253B0")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000061")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40002D6")]
			CameraMotion,
			[Token(Token = "0x40002D7")]
			LocalBlur,
			[Token(Token = "0x40002D8")]
			Reconstruction,
			[Token(Token = "0x40002D9")]
			ReconstructionDX11,
			[Token(Token = "0x40002DA")]
			ReconstructionDisc
		}

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x8253CC", Offset = "0x8253CC", VA = "0x8253CC")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x82562C", Offset = "0x82562C", VA = "0x82562C")]
		private new void Start()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x8258BC", Offset = "0x8258BC", VA = "0x8258BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x82597C", Offset = "0x82597C", VA = "0x82597C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x825AE0", Offset = "0x825AE0", VA = "0x825AE0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x825B94", Offset = "0x825B94", VA = "0x825B94")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x82575C", Offset = "0x82575C", VA = "0x82575C")]
		private void Remember()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x8276E8", Offset = "0x8276E8", VA = "0x8276E8")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x827664", Offset = "0x827664", VA = "0x827664")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x8276D8", Offset = "0x8276D8", VA = "0x8276D8")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x827A7C", Offset = "0x827A7C", VA = "0x827A7C")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	[ExecuteInEditMode]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000063")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40002F4")]
			Simple,
			[Token(Token = "0x40002F5")]
			Advanced
		}

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x827C14", Offset = "0x827C14", VA = "0x827C14")]
		private new void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x827C34", Offset = "0x827C34", VA = "0x827C34")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x827C38", Offset = "0x827C38", VA = "0x827C38", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x827EFC", Offset = "0x827EFC", VA = "0x827EFC")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x8281F0", Offset = "0x8281F0", VA = "0x8281F0")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x8281F4", Offset = "0x8281F4", VA = "0x8281F4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x828500", Offset = "0x828500", VA = "0x828500")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x828B8C", Offset = "0x828B8C", VA = "0x828B8C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x828BFC", Offset = "0x828BFC", VA = "0x828BFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x828C98", Offset = "0x828C98", VA = "0x828C98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x828D28", Offset = "0x828D28", VA = "0x828D28")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x828F24", Offset = "0x828F24", VA = "0x828F24")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x829024", Offset = "0x829024", VA = "0x829024")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x82936C", Offset = "0x82936C", VA = "0x82936C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x829560", Offset = "0x829560", VA = "0x829560")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x8295B8", Offset = "0x8295B8", VA = "0x8295B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x829740", Offset = "0x829740", VA = "0x829740")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float intensity;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.999f)]
		public float threshold;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float blurSpread;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x829750", Offset = "0x829750", VA = "0x829750", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x8297EC", Offset = "0x8297EC", VA = "0x8297EC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x829B18", Offset = "0x829B18", VA = "0x829B18")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0.0001f, 1f)]
		public float adaptationSpeed;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float limitMinimum;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float limitMaximum;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x1700006B")]
		protected Material materialLum
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x829B30", Offset = "0x829B30", VA = "0x829B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		protected Material materialReduce
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x829C04", Offset = "0x829C04", VA = "0x829C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x829CD8", Offset = "0x829CD8", VA = "0x829CD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		protected Material materialApply
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x829DAC", Offset = "0x829DAC", VA = "0x829DAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x829E80", Offset = "0x829E80", VA = "0x829E80")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x829F04", Offset = "0x829F04", VA = "0x829F04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x82A050", Offset = "0x82A050", VA = "0x82A050")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x82A22C", Offset = "0x82A22C", VA = "0x82A22C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x82A46C", Offset = "0x82A46C", VA = "0x82A46C")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x82A624", Offset = "0x82A624", VA = "0x82A624")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x82A6A0", Offset = "0x82A6A0", VA = "0x82A6A0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x82A764", Offset = "0x82A764", VA = "0x82A764")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x82AADC", Offset = "0x82AADC", VA = "0x82AADC")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	[RequireComponent(typeof(Camera))]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x200006A")]
		public enum BlurType
		{
			[Token(Token = "0x4000332")]
			DiscBlur,
			[Token(Token = "0x4000333")]
			DX11
		}

		[Token(Token = "0x200006B")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000335")]
			Low,
			[Token(Token = "0x4000336")]
			Medium,
			[Token(Token = "0x4000337")]
			High
		}

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x82AAF8", Offset = "0x82AAF8", VA = "0x82AAF8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x82ACF8", Offset = "0x82ACF8", VA = "0x82ACF8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x82AD78", Offset = "0x82AD78", VA = "0x82AD78")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x82AE70", Offset = "0x82AE70", VA = "0x82AE70")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x82ABB0", Offset = "0x82ABB0", VA = "0x82ABB0")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x82AEC8", Offset = "0x82AEC8", VA = "0x82AEC8")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x82AFB4", Offset = "0x82AFB4", VA = "0x82AFB4")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x82B284", Offset = "0x82B284", VA = "0x82B284")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x82C584", Offset = "0x82C584", VA = "0x82C584")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x200006D")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x4000364")]
			OnlyBackground = 1,
			[Token(Token = "0x4000365")]
			BackgroundAndForeground
		}

		[Token(Token = "0x200006E")]
		public enum DofResolution
		{
			[Token(Token = "0x4000367")]
			High = 2,
			[Token(Token = "0x4000368")]
			Medium,
			[Token(Token = "0x4000369")]
			Low
		}

		[Token(Token = "0x200006F")]
		public enum DofBlurriness
		{
			[Token(Token = "0x400036B")]
			Low = 1,
			[Token(Token = "0x400036C")]
			High = 2,
			[Token(Token = "0x400036D")]
			VeryHigh = 4
		}

		[Token(Token = "0x2000070")]
		public enum BokehDestination
		{
			[Token(Token = "0x400036F")]
			Background = 1,
			[Token(Token = "0x4000370")]
			Foreground,
			[Token(Token = "0x4000371")]
			BackgroundAndForeground
		}

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x82C5DC", Offset = "0x82C5DC", VA = "0x82C5DC")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x82C6E8", Offset = "0x82C6E8", VA = "0x82C6E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x82C824", Offset = "0x82C824", VA = "0x82C824")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x82C82C", Offset = "0x82C82C", VA = "0x82C82C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x82C8AC", Offset = "0x82C8AC", VA = "0x82C8AC")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x82C998", Offset = "0x82C998", VA = "0x82C998")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x82C9BC", Offset = "0x82C9BC", VA = "0x82C9BC")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x82C9E0", Offset = "0x82C9E0", VA = "0x82C9E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x82D74C", Offset = "0x82D74C", VA = "0x82D74C")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x82DD00", Offset = "0x82DD00", VA = "0x82DD00")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x82E074", Offset = "0x82E074", VA = "0x82E074")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x82D624", Offset = "0x82D624", VA = "0x82D624")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x82D92C", Offset = "0x82D92C", VA = "0x82D92C")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x82DF0C", Offset = "0x82DF0C", VA = "0x82DF0C")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x82D274", Offset = "0x82D274", VA = "0x82D274")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x82E214", Offset = "0x82E214", VA = "0x82E214")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000072")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x400037E")]
			TriangleDepthNormals,
			[Token(Token = "0x400037F")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x4000380")]
			SobelDepth,
			[Token(Token = "0x4000381")]
			SobelDepthThin,
			[Token(Token = "0x4000382")]
			TriangleLuminance
		}

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x82E2DC", Offset = "0x82E2DC", VA = "0x82E2DC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x82E420", Offset = "0x82E420", VA = "0x82E420")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x82E370", Offset = "0x82E370", VA = "0x82E370")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x82E42C", Offset = "0x82E42C", VA = "0x82E42C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x82E430", Offset = "0x82E430", VA = "0x82E430")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x82E604", Offset = "0x82E604", VA = "0x82E604")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float strengthX;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1.5f)]
		public float strengthY;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x82E634", Offset = "0x82E634", VA = "0x82E634", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x82E6A8", Offset = "0x82E6A8", VA = "0x82E6A8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x82E7DC", Offset = "0x82E7DC", VA = "0x82E7DC")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x82E7F4", Offset = "0x82E7F4", VA = "0x82E7F4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x82E868", Offset = "0x82E868", VA = "0x82E868")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x82EDF8", Offset = "0x82EDF8", VA = "0x82EDF8")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-1f, 1f)]
		public float rampOffset;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x82EE1C", Offset = "0x82EE1C", VA = "0x82EE1C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x82EF00", Offset = "0x82EF00", VA = "0x82EF00")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700006F")]
		protected Material material
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x82966C", Offset = "0x82966C", VA = "0x82966C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x82EF08", Offset = "0x82EF08", VA = "0x82EF08", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x82EFA8", Offset = "0x82EFA8", VA = "0x82EFA8", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x829748", Offset = "0x829748", VA = "0x829748")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AddComponentMenu("")]
	public class ImageEffects
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x82F034", Offset = "0x82F034", VA = "0x82F034")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x82F2A4", Offset = "0x82F2A4", VA = "0x82F2A4")]
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x82F30C", Offset = "0x82F30C", VA = "0x82F30C")]
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x82F37C", Offset = "0x82F37C", VA = "0x82F37C")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[ExecuteInEditMode]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 0.92f)]
		public float blurAmount;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x82F384", Offset = "0x82F384", VA = "0x82F384", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x82F388", Offset = "0x82F388", VA = "0x82F388", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x82F3EC", Offset = "0x82F3EC", VA = "0x82F3EC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x82F754", Offset = "0x82F754", VA = "0x82F754")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x82F768", Offset = "0x82F768", VA = "0x82F768", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x82F814", Offset = "0x82F814", VA = "0x82F814")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x830014", Offset = "0x830014", VA = "0x830014")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x830354", Offset = "0x830354", VA = "0x830354")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float grainIntensityMin;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float grainIntensityMax;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0.1f, 50f)]
		public float grainSize;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float scratchIntensityMin;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		public float scratchIntensityMax;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1f, 30f)]
		public float scratchFPS;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float scratchJitter;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000070")]
		protected Material material
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x83050C", Offset = "0x83050C", VA = "0x83050C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x8303E0", Offset = "0x8303E0", VA = "0x8303E0")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x830674", Offset = "0x830674", VA = "0x830674")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x830744", Offset = "0x830744", VA = "0x830744")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8307E8", Offset = "0x8307E8", VA = "0x8307E8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x830B10", Offset = "0x830B10", VA = "0x830B10")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x830B44", Offset = "0x830B44", VA = "0x830B44")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x830FC0", Offset = "0x830FC0", VA = "0x830FC0")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x8311F8", Offset = "0x8311F8", VA = "0x8311F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x831204", Offset = "0x831204", VA = "0x831204")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x831208", Offset = "0x831208", VA = "0x831208")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x8312E8", Offset = "0x8312E8", VA = "0x8312E8")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x8313E8", Offset = "0x8313E8", VA = "0x8313E8", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x8314A8", Offset = "0x8314A8", VA = "0x8314A8")]
		protected void Start()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x8312F0", Offset = "0x8312F0", VA = "0x8312F0")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8314B4", Offset = "0x8314B4", VA = "0x8314B4")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x83150C", Offset = "0x83150C", VA = "0x83150C")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x831514", Offset = "0x831514", VA = "0x831514")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x8315CC", Offset = "0x8315CC", VA = "0x8315CC")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x830FA0", Offset = "0x830FA0", VA = "0x830FA0")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x831850", Offset = "0x831850", VA = "0x831850")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x831BC8", Offset = "0x831BC8", VA = "0x831BC8")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x831C5C", Offset = "0x831C5C", VA = "0x831C5C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x831CC4", Offset = "0x831CC4", VA = "0x831CC4")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x831F10", Offset = "0x831F10", VA = "0x831F10")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x832284", Offset = "0x832284", VA = "0x832284")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x832428", Offset = "0x832428", VA = "0x832428")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200007D")]
	internal class Quads
	{
		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x832430", Offset = "0x832430", VA = "0x832430")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x832500", Offset = "0x832500", VA = "0x832500")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x832664", Offset = "0x832664", VA = "0x832664")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x83289C", Offset = "0x83289C", VA = "0x83289C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x832C20", Offset = "0x832C20", VA = "0x832C20")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200007F")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40003C7")]
			Additive,
			[Token(Token = "0x40003C8")]
			ScreenBlend,
			[Token(Token = "0x40003C9")]
			Multiply,
			[Token(Token = "0x40003CA")]
			Overlay,
			[Token(Token = "0x40003CB")]
			AlphaBlend
		}

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x832C28", Offset = "0x832C28", VA = "0x832C28", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x832C90", Offset = "0x832C90", VA = "0x832C90")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x832DE0", Offset = "0x832DE0", VA = "0x832DE0")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000080")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 3f)]
		public float intensity;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.1f, 3f)]
		public float radius;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 3f)]
		public int blurIterations;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 5f)]
		public float blurFilterDistance;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x832DF0", Offset = "0x832DF0", VA = "0x832DF0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x832E58", Offset = "0x832E58", VA = "0x832E58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x832EE8", Offset = "0x832EE8", VA = "0x832EE8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x83369C", Offset = "0x83369C", VA = "0x83369C")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000081")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000082")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40003E0")]
			Low,
			[Token(Token = "0x40003E1")]
			Medium,
			[Token(Token = "0x40003E2")]
			High
		}

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0.05f, 1f)]
		public float m_Radius;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 4f)]
		public int m_Blur;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(1f, 6f)]
		public int m_Downsampling;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(1E-05f, 0.5f)]
		public float m_MinZ;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x8336B8", Offset = "0x8336B8", VA = "0x8336B8")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x833764", Offset = "0x833764", VA = "0x833764")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x8337E8", Offset = "0x8337E8", VA = "0x8337E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x8337F0", Offset = "0x8337F0", VA = "0x8337F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x833990", Offset = "0x833990", VA = "0x833990")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x8338B8", Offset = "0x8338B8", VA = "0x8338B8")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x8339FC", Offset = "0x8339FC", VA = "0x8339FC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x833FD0", Offset = "0x833FD0", VA = "0x833FD0")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Reflection")]
	[ExecuteInEditMode]
	public class ScreenSpaceReflection : PostEffectsBase
	{
		[Token(Token = "0x2000084")]
		public enum SSRDebugMode
		{
			[Token(Token = "0x40003F2")]
			None,
			[Token(Token = "0x40003F3")]
			IncomingRadiance,
			[Token(Token = "0x40003F4")]
			SSRResult,
			[Token(Token = "0x40003F5")]
			FinalGlossyTerm,
			[Token(Token = "0x40003F6")]
			SSRMask,
			[Token(Token = "0x40003F7")]
			Roughness,
			[Token(Token = "0x40003F8")]
			BaseColor,
			[Token(Token = "0x40003F9")]
			SpecColor,
			[Token(Token = "0x40003FA")]
			Reflectivity,
			[Token(Token = "0x40003FB")]
			ReflectionProbeOnly,
			[Token(Token = "0x40003FC")]
			ReflectionProbeMinusSSR,
			[Token(Token = "0x40003FD")]
			SSRMinusReflectionProbe,
			[Token(Token = "0x40003FE")]
			NoGlossy,
			[Token(Token = "0x40003FF")]
			NegativeNoGlossy,
			[Token(Token = "0x4000400")]
			MipLevel
		}

		[Token(Token = "0x2000085")]
		public enum SSRResolution
		{
			[Token(Token = "0x4000402")]
			FullResolution,
			[Token(Token = "0x4000403")]
			HalfTraceFullResolve,
			[Token(Token = "0x4000404")]
			HalfResolution
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public struct SSRSettings
		{
			[Token(Token = "0x2000087")]
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : Attribute
			{
				[Token(Token = "0x2000088")]
				public enum Category
				{
					[Token(Token = "0x4000425")]
					Basic,
					[Token(Token = "0x4000426")]
					Reflections,
					[Token(Token = "0x4000427")]
					Advanced,
					[Token(Token = "0x4000428")]
					Debug,
					[Token(Token = "0x4000429")]
					Undefined
				}

				[Token(Token = "0x4000422")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public readonly Category category;

				[Token(Token = "0x4000423")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public readonly int priority;

				[Token(Token = "0x6000278")]
				[Address(RVA = "0x83600C", Offset = "0x83600C", VA = "0x83600C")]
				public LayoutAttribute(Category category, int priority)
				{
				}
			}

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			[Layout(LayoutAttribute.Category.Basic, 1)]
			public float reflectionMultiplier;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0.5f, 1000f)]
			[Layout(LayoutAttribute.Category.Basic, 2)]
			[Tooltip("Maximum reflection distance in world units.")]
			public float maxDistance;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[Range(0f, 1000f)]
			[Layout(LayoutAttribute.Category.Basic, 3)]
			public float fadeDistance;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Layout(LayoutAttribute.Category.Basic, 4)]
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			public float screenEdgeFading;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Enable for better reflections of very bright objects at a performance cost")]
			[Layout(LayoutAttribute.Category.Basic, 5)]
			public bool enableHDR;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[Tooltip("Add reflections on top of existing ones. Not physically correct.")]
			[Layout(LayoutAttribute.Category.Basic, 6)]
			public bool additiveReflection;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Layout(LayoutAttribute.Category.Reflections, 1)]
			[Range(16f, 2048f)]
			[Tooltip("Max raytracing length.")]
			public int maxSteps;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Layout(LayoutAttribute.Category.Reflections, 2)]
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			[Range(0f, 4f)]
			public int rayStepSize;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Layout(LayoutAttribute.Category.Reflections, 3)]
			[Range(0.01f, 10f)]
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			public float widthModifier;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Layout(LayoutAttribute.Category.Reflections, 4)]
			[Tooltip("Increase if reflections flicker on very rough surfaces.")]
			[Range(0f, 1f)]
			public float smoothFallbackThreshold;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Layout(LayoutAttribute.Category.Reflections, 5)]
			[Tooltip("Start falling back to non-SSR value solution at smoothFallbackThreshold - smoothFallbackDistance, with full fallback occuring at smoothFallbackThreshold.")]
			[Range(0f, 0.2f)]
			public float smoothFallbackDistance;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[Layout(LayoutAttribute.Category.Reflections, 6)]
			[Range(0f, 1f)]
			public float fresnelFade;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[Layout(LayoutAttribute.Category.Reflections, 7)]
			[Range(0.1f, 10f)]
			public float fresnelFadePower;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Controls how blurry reflections get as objects are further from the camera. 0 is constant blur no matter trace distance or distance from camera. 1 fully takes into account both factors.")]
			[Range(0f, 1f)]
			[Layout(LayoutAttribute.Category.Reflections, 8)]
			public float distanceBlur;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Range(0f, 0.99f)]
			[Tooltip("Increase to decrease flicker in scenes; decrease to prevent ghosting (especially in dynamic scenes). 0 gives maximum performance.")]
			[Layout(LayoutAttribute.Category.Advanced, 1)]
			public float temporalFilterStrength;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Layout(LayoutAttribute.Category.Advanced, 2)]
			[Tooltip("Enable to limit ghosting from applying the temporal filter.")]
			public bool useTemporalConfidence;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			[Tooltip("Improves quality in scenes with varying smoothness, at a potential performance cost.")]
			[Layout(LayoutAttribute.Category.Advanced, 3)]
			public bool traceEverywhere;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
			[Tooltip("Enable to force more surfaces to use reflection probes if you see streaks on the sides of objects or bad reflections of their backs.")]
			[Layout(LayoutAttribute.Category.Advanced, 4)]
			public bool treatBackfaceHitAsMiss;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
			[Layout(LayoutAttribute.Category.Advanced, 5)]
			[Tooltip("Enable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave off for scenes with glossy vertical objects.")]
			public bool suppressBackwardsRays;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[Tooltip("Improve visual fidelity of reflections on rough surfaces near corners in the scene, at the cost of a small amount of performance.")]
			[Layout(LayoutAttribute.Category.Advanced, 6)]
			public bool improveCorners;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Half resolution SSRR is much faster, but less accurate. Quality can be reclaimed for some performance by doing the resolve at full resolution.")]
			[Layout(LayoutAttribute.Category.Advanced, 7)]
			public SSRResolution resolution;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Layout(LayoutAttribute.Category.Advanced, 8)]
			[Tooltip("Drastically improves reflection reconstruction quality at the expense of some performance.")]
			public bool bilateralUpsample;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			[Tooltip("Improve visual fidelity of mirror reflections at the cost of a small amount of performance.")]
			[Layout(LayoutAttribute.Category.Advanced, 9)]
			public bool reduceBanding;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
			[Tooltip("Enable to limit the effect a few bright pixels can have on rougher surfaces")]
			[Layout(LayoutAttribute.Category.Advanced, 10)]
			public bool highlightSuppression;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Layout(LayoutAttribute.Category.Debug, 1)]
			[Tooltip("Various Debug Visualizations")]
			public SSRDebugMode debugMode;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("Uncheck to disable SSR without disabling the entire component")]
			[Layout(LayoutAttribute.Category.Debug, 2)]
			public bool enable;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly SSRSettings s_Performance;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static readonly SSRSettings s_Default;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private static readonly SSRSettings s_HighQuality;

			[Token(Token = "0x17000071")]
			public static SSRSettings performanceSettings
			{
				[Token(Token = "0x6000274")]
				[Address(RVA = "0x835D88", Offset = "0x835D88", VA = "0x835D88")]
				get
				{
					return default(SSRSettings);
				}
			}

			[Token(Token = "0x17000072")]
			public static SSRSettings defaultSettings
			{
				[Token(Token = "0x6000275")]
				[Address(RVA = "0x835DE8", Offset = "0x835DE8", VA = "0x835DE8")]
				get
				{
					return default(SSRSettings);
				}
			}

			[Token(Token = "0x17000073")]
			public static SSRSettings highQualitySettings
			{
				[Token(Token = "0x6000276")]
				[Address(RVA = "0x835E4C", Offset = "0x835E4C", VA = "0x835E4C")]
				get
				{
					return default(SSRSettings);
				}
			}
		}

		[Token(Token = "0x2000089")]
		private enum PassIndex
		{
			[Token(Token = "0x400042B")]
			RayTraceStep1,
			[Token(Token = "0x400042C")]
			RayTraceStep2,
			[Token(Token = "0x400042D")]
			RayTraceStep4,
			[Token(Token = "0x400042E")]
			RayTraceStep8,
			[Token(Token = "0x400042F")]
			RayTraceStep16,
			[Token(Token = "0x4000430")]
			CompositeFinal,
			[Token(Token = "0x4000431")]
			Blur,
			[Token(Token = "0x4000432")]
			CompositeSSR,
			[Token(Token = "0x4000433")]
			Blit,
			[Token(Token = "0x4000434")]
			EdgeGeneration,
			[Token(Token = "0x4000435")]
			MinMipGeneration,
			[Token(Token = "0x4000436")]
			HitPointToReflections,
			[Token(Token = "0x4000437")]
			BilateralKeyPack,
			[Token(Token = "0x4000438")]
			BlitDepthAsCSZ,
			[Token(Token = "0x4000439")]
			TemporalFilter,
			[Token(Token = "0x400043A")]
			AverageRayDistanceGeneration
		}

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public SSRSettings settings;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Enable to try and bypass expensive bilateral upsampling away from edges. There is a slight performance hit for generating the edge buffers, but a potentially high performance savings from bypassing bilateral upsampling where it is unneeded. Test on your target platforms to see if performance improves.")]
		private bool useEdgeDetector;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(-4f, 4f)]
		private float mipBias;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool useOcclusion;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool fullResolutionFiltering;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		private bool fallbackToSky;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		private bool computeAverageRayDistance;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool m_HasInformationFromPreviousFrame;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Matrix4x4 m_PreviousWorldToCameraMatrix;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RenderTexture m_PreviousDepthBuffer;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RenderTexture m_PreviousHitBuffer;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture m_PreviousReflectionBuffer;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader ssrShader;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material ssrMaterial;

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x834004", Offset = "0x834004", VA = "0x834004", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x83406C", Offset = "0x83406C", VA = "0x83406C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x834214", Offset = "0x834214", VA = "0x834214")]
		private void PreparePreviousBuffers(int w, int h)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x834438", Offset = "0x834438", VA = "0x834438")]
		[ImageEffectOpaque]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x835CE4", Offset = "0x835CE4", VA = "0x835CE4")]
		public ScreenSpaceReflection()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	[ExecuteInEditMode]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x836038", Offset = "0x836038", VA = "0x836038")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x8360BC", Offset = "0x8360BC", VA = "0x8360BC")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x200008C")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x400044A")]
			Low,
			[Token(Token = "0x400044B")]
			Normal,
			[Token(Token = "0x400044C")]
			High
		}

		[Token(Token = "0x200008D")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x400044E")]
			Screen,
			[Token(Token = "0x400044F")]
			Add
		}

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x8360C4", Offset = "0x8360C4", VA = "0x8360C4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x836150", Offset = "0x836150", VA = "0x836150")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x83680C", Offset = "0x83680C", VA = "0x83680C")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	[RequireComponent(typeof(Camera))]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x200008F")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x4000458")]
			TiltShiftMode,
			[Token(Token = "0x4000459")]
			IrisMode
		}

		[Token(Token = "0x2000090")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x400045B")]
			Preview,
			[Token(Token = "0x400045C")]
			Low,
			[Token(Token = "0x400045D")]
			Normal,
			[Token(Token = "0x400045E")]
			High
		}

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 15f)]
		public float blurArea;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 25f)]
		public float maxBlurSize;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public int downsample;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x836850", Offset = "0x836850", VA = "0x836850", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x8368B8", Offset = "0x8368B8", VA = "0x8368B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x836B48", Offset = "0x836B48", VA = "0x836B48")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000092")]
		public enum TonemapperType
		{
			[Token(Token = "0x400046D")]
			SimpleReinhard,
			[Token(Token = "0x400046E")]
			UserCurve,
			[Token(Token = "0x400046F")]
			Hable,
			[Token(Token = "0x4000470")]
			Photographic,
			[Token(Token = "0x4000471")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000472")]
			AdaptiveReinhard,
			[Token(Token = "0x4000473")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000093")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000475")]
			Square16 = 0x10,
			[Token(Token = "0x4000476")]
			Square32 = 0x20,
			[Token(Token = "0x4000477")]
			Square64 = 0x40,
			[Token(Token = "0x4000478")]
			Square128 = 0x80,
			[Token(Token = "0x4000479")]
			Square256 = 0x100,
			[Token(Token = "0x400047A")]
			Square512 = 0x200,
			[Token(Token = "0x400047B")]
			Square1024 = 0x400
		}

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x836B60", Offset = "0x836B60", VA = "0x836B60", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x836CC4", Offset = "0x836CC4", VA = "0x836CC4")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x836F44", Offset = "0x836F44", VA = "0x836F44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x83709C", Offset = "0x83709C", VA = "0x83709C")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x83719C", Offset = "0x83719C", VA = "0x83719C")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x83793C", Offset = "0x83793C", VA = "0x83793C")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000094")]
	internal class Triangles
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x837968", Offset = "0x837968", VA = "0x837968")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x837A3C", Offset = "0x837A3C", VA = "0x837A3C")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x837BA0", Offset = "0x837BA0", VA = "0x837BA0")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x837DD8", Offset = "0x837DD8", VA = "0x837DD8")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x8380CC", Offset = "0x8380CC", VA = "0x8380CC")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 360f)]
		public float angle;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x8380D4", Offset = "0x8380D4", VA = "0x8380D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x838114", Offset = "0x838114", VA = "0x838114")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000097")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000490")]
			Simple,
			[Token(Token = "0x4000491")]
			Advanced
		}

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x83813C", Offset = "0x83813C", VA = "0x83813C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x8381EC", Offset = "0x8381EC", VA = "0x8381EC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x838740", Offset = "0x838740", VA = "0x838740")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x83876C", Offset = "0x83876C", VA = "0x83876C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x8387AC", Offset = "0x8387AC", VA = "0x8387AC")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x2000099")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x200009A")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x838F38", Offset = "0x838F38", VA = "0x838F38", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x838938", Offset = "0x838938", VA = "0x838938")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x17000074")]
		public bool protecting
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x8387D4", Offset = "0x8387D4", VA = "0x8387D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x8387DC", Offset = "0x8387DC", VA = "0x8387DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x8387E8", Offset = "0x8387E8", VA = "0x8387E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x838940", Offset = "0x838940", VA = "0x838940")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x838EC0", Offset = "0x838EC0", VA = "0x838EC0")]
		public ProtectCameraFromWallClip()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200009B")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x83902C", Offset = "0x83902C", VA = "0x83902C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x8392B4", Offset = "0x8392B4", VA = "0x8392B4")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x839438", Offset = "0x839438", VA = "0x839438")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x8394A8", Offset = "0x8394A8", VA = "0x8394A8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x839574", Offset = "0x839574", VA = "0x839574", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x8395D8", Offset = "0x8395D8", VA = "0x8395D8")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x839644", Offset = "0x839644", VA = "0x839644")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x839648", Offset = "0x839648", VA = "0x839648")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x839710", Offset = "0x839710", VA = "0x839710")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8397D8", Offset = "0x8397D8", VA = "0x8397D8")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8398A0", Offset = "0x8398A0", VA = "0x8398A0")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x839968", Offset = "0x839968", VA = "0x839968")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x839A30", Offset = "0x839A30", VA = "0x839A30")]
		public void Update()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x839A34", Offset = "0x839A34", VA = "0x839A34")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200009E")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40004AF")]
			Hardware,
			[Token(Token = "0x40004B0")]
			Touch
		}

		[Token(Token = "0x200009F")]
		public class VirtualAxis
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x17000076")]
			public string name
			{
				[Token(Token = "0x60002C1")]
				[Address(RVA = "0x83A814", Offset = "0x83A814", VA = "0x83A814")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60002C2")]
				[Address(RVA = "0x83A81C", Offset = "0x83A81C", VA = "0x83A81C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60002C3")]
				[Address(RVA = "0x83A824", Offset = "0x83A824", VA = "0x83A824")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x83A82C", Offset = "0x83A82C", VA = "0x83A82C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public float GetValue
			{
				[Token(Token = "0x60002C9")]
				[Address(RVA = "0x83A880", Offset = "0x83A880", VA = "0x83A880")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000079")]
			public float GetValueRaw
			{
				[Token(Token = "0x60002CA")]
				[Address(RVA = "0x83A888", Offset = "0x83A888", VA = "0x83A888")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x8391A8", Offset = "0x8391A8", VA = "0x8391A8")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x83A838", Offset = "0x83A838", VA = "0x83A838")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x839450", Offset = "0x839450", VA = "0x839450")]
			public void Remove()
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x83A878", Offset = "0x83A878", VA = "0x83A878")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x20000A0")]
		public class VirtualButton
		{
			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700007A")]
			public string name
			{
				[Token(Token = "0x60002CB")]
				[Address(RVA = "0x83A890", Offset = "0x83A890", VA = "0x83A890")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0x83A898", Offset = "0x83A898", VA = "0x83A898")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60002CD")]
				[Address(RVA = "0x83A8A0", Offset = "0x83A8A0", VA = "0x83A8A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0x83A8A8", Offset = "0x83A8A8", VA = "0x83A8A8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public bool GetButton
			{
				[Token(Token = "0x60002D4")]
				[Address(RVA = "0x83A9E4", Offset = "0x83A9E4", VA = "0x83A9E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700007D")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60002D5")]
				[Address(RVA = "0x83A9EC", Offset = "0x83A9EC", VA = "0x83A9EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700007E")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60002D6")]
				[Address(RVA = "0x83AA10", Offset = "0x83AA10", VA = "0x83AA10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x83A8B4", Offset = "0x83A8B4", VA = "0x83A8B4")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x83A8F8", Offset = "0x83A8F8", VA = "0x83A8F8")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x83A940", Offset = "0x83A940", VA = "0x83A940")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x83A96C", Offset = "0x83A96C", VA = "0x83A96C")]
			public void Released()
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x83A98C", Offset = "0x83A98C", VA = "0x83A98C")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000075")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x83A640", Offset = "0x83A640", VA = "0x83A640")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x839A3C", Offset = "0x839A3C", VA = "0x839A3C")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x839B14", Offset = "0x839B14", VA = "0x839B14")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x839140", Offset = "0x839140", VA = "0x839140")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x839C10", Offset = "0x839C10", VA = "0x839C10")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x8391E4", Offset = "0x8391E4", VA = "0x8391E4")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x839E68", Offset = "0x839E68", VA = "0x839E68")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x83A068", Offset = "0x83A068", VA = "0x83A068")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x83A1B0", Offset = "0x83A1B0", VA = "0x83A1B0")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x83924C", Offset = "0x83924C", VA = "0x83924C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x83A33C", Offset = "0x83A33C", VA = "0x83A33C")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x83A414", Offset = "0x83A414", VA = "0x83A414")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x83A394", Offset = "0x83A394", VA = "0x83A394")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x83A46C", Offset = "0x83A46C", VA = "0x83A46C")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x83A4DC", Offset = "0x83A4DC", VA = "0x83A4DC")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x83A54C", Offset = "0x83A54C", VA = "0x83A54C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x8396A0", Offset = "0x8396A0", VA = "0x8396A0")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x839768", Offset = "0x839768", VA = "0x839768")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x839830", Offset = "0x839830", VA = "0x839830")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x8399C0", Offset = "0x8399C0", VA = "0x8399C0")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8398F8", Offset = "0x8398F8", VA = "0x8398F8")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x83A5BC", Offset = "0x83A5BC", VA = "0x83A5BC")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x83A6AC", Offset = "0x83A6AC", VA = "0x83A6AC")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x83A724", Offset = "0x83A724", VA = "0x83A724")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x83A79C", Offset = "0x83A79C", VA = "0x83A79C")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x83AA34", Offset = "0x83AA34", VA = "0x83AA34")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x83AA38", Offset = "0x83AA38", VA = "0x83AA38")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x83AAA8", Offset = "0x83AAA8", VA = "0x83AAA8")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x20000A3")]
		public enum AxisOption
		{
			[Token(Token = "0x40004C4")]
			Both,
			[Token(Token = "0x40004C5")]
			OnlyHorizontal,
			[Token(Token = "0x40004C6")]
			OnlyVertical
		}

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x83AAB0", Offset = "0x83AAB0", VA = "0x83AAB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x83AC14", Offset = "0x83AC14", VA = "0x83AC14")]
		private void Start()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x83AC44", Offset = "0x83AC44", VA = "0x83AC44")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x83AAB4", Offset = "0x83AAB4", VA = "0x83AAB4")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x83ACA4", Offset = "0x83ACA4", VA = "0x83ACA4", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x83ADF0", Offset = "0x83ADF0", VA = "0x83ADF0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x83AE2C", Offset = "0x83AE2C", VA = "0x83AE2C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x83AE30", Offset = "0x83AE30", VA = "0x83AE30")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x83AE70", Offset = "0x83AE70", VA = "0x83AE70")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x83AEFC", Offset = "0x83AEFC", VA = "0x83AEFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x83AF0C", Offset = "0x83AF0C", VA = "0x83AF0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x83AF04", Offset = "0x83AF04", VA = "0x83AF04")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x83B014", Offset = "0x83B014", VA = "0x83B014")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x83B30C", Offset = "0x83B30C", VA = "0x83B30C")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		public enum AxisOptions
		{
			[Token(Token = "0x40004CD")]
			ForwardAxis,
			[Token(Token = "0x40004CE")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public class AxisMapping
		{
			[Token(Token = "0x20000A8")]
			public enum MappingType
			{
				[Token(Token = "0x40004D2")]
				NamedAxis,
				[Token(Token = "0x40004D3")]
				MousePositionX,
				[Token(Token = "0x40004D4")]
				MousePositionY,
				[Token(Token = "0x40004D5")]
				MousePositionZ
			}

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x83B668", Offset = "0x83B668", VA = "0x83B668")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x83B314", Offset = "0x83B314", VA = "0x83B314")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x83B3F0", Offset = "0x83B3F0", VA = "0x83B3F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x83B640", Offset = "0x83B640", VA = "0x83B640")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x83B658", Offset = "0x83B658", VA = "0x83B658")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x20000AA")]
		public enum AxisOption
		{
			[Token(Token = "0x40004E9")]
			Both,
			[Token(Token = "0x40004EA")]
			OnlyHorizontal,
			[Token(Token = "0x40004EB")]
			OnlyVertical
		}

		[Token(Token = "0x20000AB")]
		public enum ControlStyle
		{
			[Token(Token = "0x40004ED")]
			Absolute,
			[Token(Token = "0x40004EE")]
			Relative,
			[Token(Token = "0x40004EF")]
			Swipe
		}

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x83B670", Offset = "0x83B670", VA = "0x83B670")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x83B7D4", Offset = "0x83B7D4", VA = "0x83B7D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x83B674", Offset = "0x83B674", VA = "0x83B674")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x83B85C", Offset = "0x83B85C", VA = "0x83B85C")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x83B95C", Offset = "0x83B95C", VA = "0x83B95C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x83B994", Offset = "0x83B994", VA = "0x83B994")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x83BB6C", Offset = "0x83BB6C", VA = "0x83BB6C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x83BBCC", Offset = "0x83BBCC", VA = "0x83BBCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x83BC8C", Offset = "0x83BC8C", VA = "0x83BC8C")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700007F")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x83BD20", Offset = "0x83BD20", VA = "0x83BD20")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x83BD2C", Offset = "0x83BD2C", VA = "0x83BD2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x839BB8", Offset = "0x839BB8", VA = "0x839BB8")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x839C78", Offset = "0x839C78", VA = "0x839C78")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x839CD0", Offset = "0x839CD0", VA = "0x839CD0")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x839ED0", Offset = "0x839ED0", VA = "0x839ED0")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x83A120", Offset = "0x83A120", VA = "0x83A120")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x83A218", Offset = "0x83A218", VA = "0x83A218")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x83A2A8", Offset = "0x83A2A8", VA = "0x83A2A8")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x83A71C", Offset = "0x83A71C", VA = "0x83A71C")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x83A794", Offset = "0x83A794", VA = "0x83A794")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x83A80C", Offset = "0x83A80C", VA = "0x83A80C")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000302")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000303")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000304")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000305")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000306")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000307")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000308")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000309")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600030A")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600030B")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x600030C")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x83BD38", Offset = "0x83BD38", VA = "0x83BD38")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x20000AD")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x83BE60", Offset = "0x83BE60", VA = "0x83BE60")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x83BF10", Offset = "0x83BF10", VA = "0x83BF10")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x83BFB8", Offset = "0x83BFB8", VA = "0x83BFB8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x83C050", Offset = "0x83C050", VA = "0x83C050", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x83C104", Offset = "0x83C104", VA = "0x83C104", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x83C1AC", Offset = "0x83C1AC", VA = "0x83C1AC", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x83C248", Offset = "0x83C248", VA = "0x83C248", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x83C2E4", Offset = "0x83C2E4", VA = "0x83C2E4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x83C37C", Offset = "0x83C37C", VA = "0x83C37C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x83C420", Offset = "0x83C420", VA = "0x83C420", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x83C4CC", Offset = "0x83C4CC", VA = "0x83C4CC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x83C578", Offset = "0x83C578", VA = "0x83C578", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x83C610", Offset = "0x83C610", VA = "0x83C610", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x839B0C", Offset = "0x839B0C", VA = "0x839B0C")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x83C61C", Offset = "0x83C61C", VA = "0x83C61C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x83C630", Offset = "0x83C630", VA = "0x83C630", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x83C63C", Offset = "0x83C63C", VA = "0x83C63C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x83C648", Offset = "0x83C648", VA = "0x83C648", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x83C654", Offset = "0x83C654", VA = "0x83C654", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x83C6A4", Offset = "0x83C6A4", VA = "0x83C6A4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x83C6F4", Offset = "0x83C6F4", VA = "0x83C6F4", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x83C744", Offset = "0x83C744", VA = "0x83C744", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x83C794", Offset = "0x83C794", VA = "0x83C794", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x83C7E4", Offset = "0x83C7E4", VA = "0x83C7E4", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x83C834", Offset = "0x83C834", VA = "0x83C834", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x839B10", Offset = "0x839B10", VA = "0x839B10")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class MouseLook
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x83C83C", Offset = "0x83C83C", VA = "0x83C83C")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x83C88C", Offset = "0x83C88C", VA = "0x83C88C")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x83CC28", Offset = "0x83CC28", VA = "0x83CC28")]
		public Quaternion LookRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x83CBC4", Offset = "0x83CBC4", VA = "0x83CBC4")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x83CEAC", Offset = "0x83CEAC", VA = "0x83CEAC")]
		public MouseLook()
		{
		}
	}
}
namespace VEAGames.LAM
{
	[Token(Token = "0x20000B0")]
	public class BatchUpdateJob
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly LAMBatchedFoliage m_Foliage;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TerrainData m_TerrainData;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stopwatch m_Stopwatch;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_PatchIndex;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long m_Mask;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_TypeIndex;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_TypeInProgress;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_Complete;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_PlacesLeft;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_XStart;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_XEnd;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_YStart;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_YEnd;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_Stepx;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_Stepy;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_XCell;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_YCell;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_PlacesToFill;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rect m_PatchRect;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Matrix4x4 m_RotOffset;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject m_PatchRootObject;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private PatchType patchType;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly MeshBuilder m_MeshBuilder;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly PatchBuilder m_PatchBuilder;

		[Token(Token = "0x17000080")]
		public bool JobComplete
		{
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x83D030", Offset = "0x83D030", VA = "0x83D030")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x83CED8", Offset = "0x83CED8", VA = "0x83CED8")]
		public BatchUpdateJob(LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x83D038", Offset = "0x83D038", VA = "0x83D038")]
		public void Start(int patchIndex, long mask, PatchType type = PatchType.DynamicPatch)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x83D050", Offset = "0x83D050", VA = "0x83D050")]
		public float Update(float maxMs)
		{
			return default(float);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x83D0B4", Offset = "0x83D0B4", VA = "0x83D0B4")]
		private bool DoUpdate(float maxMs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x83D250", Offset = "0x83D250", VA = "0x83D250")]
		private void PrepareType(int typeIndex)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x83E1A0", Offset = "0x83E1A0", VA = "0x83E1A0")]
		private void BuildSomeMeshes(float maxMs)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x83F810", Offset = "0x83F810", VA = "0x83F810")]
		private GameObject InstantiatePrefab(Vector3 pos, Quaternion rotation, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x83F944", Offset = "0x83F944", VA = "0x83F944")]
		public void CancelJob()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[ExecuteInEditMode]
	public class LAMBatchedFoliage : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public class FoliageType
		{
			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LAMFoliageDefinition Definition;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool? _IsDefinitionCache;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LAMBatchedFoliage_PatchesHolder PatchesHolder;

			[NonSerialized]
			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool ForceDisableShadows;

			[NonSerialized]
			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float DensityAdjustment;

			[NonSerialized]
			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float OverrideCullDistance;

			[Token(Token = "0x17000081")]
			private bool IsDefinition
			{
				[Token(Token = "0x6000353")]
				[Address(RVA = "0x843110", Offset = "0x843110", VA = "0x843110")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000082")]
			public string Name
			{
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x8431FC", Offset = "0x8431FC", VA = "0x8431FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			public MeshFilter PatchPrefab
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x843268", Offset = "0x843268", VA = "0x843268")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			public GameObject InstancePrefab
			{
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x843298", Offset = "0x843298", VA = "0x843298")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			public float MinDistance
			{
				[Token(Token = "0x6000357")]
				[Address(RVA = "0x8432C8", Offset = "0x8432C8", VA = "0x8432C8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000086")]
			public float RotateToNormal
			{
				[Token(Token = "0x6000358")]
				[Address(RVA = "0x8432F8", Offset = "0x8432F8", VA = "0x8432F8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000087")]
			public bool RandomRotation
			{
				[Token(Token = "0x6000359")]
				[Address(RVA = "0x843324", Offset = "0x843324", VA = "0x843324")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000088")]
			public MinMax ScaleVariation
			{
				[Token(Token = "0x600035A")]
				[Address(RVA = "0x84335C", Offset = "0x84335C", VA = "0x84335C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			public Vector3 AdditionalRotation
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x8433E0", Offset = "0x8433E0", VA = "0x8433E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008A")]
			public Vector3 AdditionalOffset
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x843458", Offset = "0x843458", VA = "0x843458")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008B")]
			public int MaxPerPatch
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x8434D0", Offset = "0x8434D0", VA = "0x8434D0")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x1700008C")]
			public bool MergeGeometry
			{
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x843500", Offset = "0x843500", VA = "0x843500")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008D")]
			public PatchType PatchType
			{
				[Token(Token = "0x600035F")]
				[Address(RVA = "0x843538", Offset = "0x843538", VA = "0x843538")]
				get
				{
					return default(PatchType);
				}
			}

			[Token(Token = "0x1700008E")]
			public bool UpdateAtRuntime
			{
				[Token(Token = "0x6000360")]
				[Address(RVA = "0x843568", Offset = "0x843568", VA = "0x843568")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008F")]
			public bool RuntimeCulling
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x8435A0", Offset = "0x8435A0", VA = "0x8435A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000090")]
			public float ShadowCullDistance
			{
				[Token(Token = "0x6000362")]
				[Address(RVA = "0x8435D8", Offset = "0x8435D8", VA = "0x8435D8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000091")]
			public float CullDistance
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x843604", Offset = "0x843604", VA = "0x843604")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000092")]
			public Mesh Mesh
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0x843630", Offset = "0x843630", VA = "0x843630")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x8436E4", Offset = "0x8436E4", VA = "0x8436E4")]
			public FoliageType()
			{
			}
		}

		[Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class <UpdateTypesRoutine>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LAMBatchedFoliage <>4__this;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rect uvRect;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public long typeMask;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PatchType patchType;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int <myVersion>5__2;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <xs>5__3;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <ys>5__4;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <xe>5__5;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private int <ye>5__6;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <n>5__7;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private int <ii>5__8;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int <jj>5__9;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000369")]
				[Address(RVA = "0x843B08", Offset = "0x843B08", VA = "0x843B08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036B")]
				[Address(RVA = "0x843B50", Offset = "0x843B50", VA = "0x843B50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x8436F4", Offset = "0x8436F4", VA = "0x8436F4")]
			[DebuggerHidden]
			public <UpdateTypesRoutine>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x84371C", Offset = "0x84371C", VA = "0x84371C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x843720", Offset = "0x843720", VA = "0x843720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x843B10", Offset = "0x843B10", VA = "0x843B10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public int PatchesResolution;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RandomSeed;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(5f, 25f)]
		public float RuntimeFrameBudget;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public float GrassRebuildDistance;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float RuntimeRebuildDistance;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float MeshScaleMultiplier;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float RuntimeDensityMultiplier;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("Layers")]
		[HideInInspector]
		public FoliageType[] Types;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LAMBatchedFoliage_TypeDataHolder DataHolder;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public int MaxDetailResolution;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		public float TerrainHeigth;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public float TerrainPatchesRatio;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public float PatchesMultiplier;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public float DefaultDetailResolution;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public float DefaultPatchesResolution;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LAMDetailsAutoPainter dap;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Terrain m_Terrain;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Camera m_Spectator;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private long[,] m_PatchesValidity;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BatchUpdateJob m_Updater;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GameObject m_GrassPatcher;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int m_CurrentUpdateRoutineVersion;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<int> m_GrassListPatch;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<int> m_DynamicListPatch;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool isRebuild;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x83FA48", Offset = "0x83FA48", VA = "0x83FA48")]
		private GameObject GetPatchObject(int patchIndex, FoliageType type)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x83DE3C", Offset = "0x83DE3C", VA = "0x83DE3C")]
		public bool ClearPatch(int patchIndex, FoliageType type, bool alsoDestroyPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x83FAF8", Offset = "0x83FAF8", VA = "0x83FAF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x840330", Offset = "0x840330", VA = "0x840330")]
		private void Start()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x8406D8", Offset = "0x8406D8", VA = "0x8406D8")]
		public void CopyData(LAMBatchedFoliage_TypeDataHolder otherData)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x83FDD8", Offset = "0x83FDD8", VA = "0x83FDD8")]
		private void RecreateDataArrays(bool fromValidate = false)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x8401F4", Offset = "0x8401F4", VA = "0x8401F4")]
		private void RecreatePatchesValidity(bool newResolution = false)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x8407E0", Offset = "0x8407E0", VA = "0x8407E0")]
		private void CheckUpdatesOverlap()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x8408A4", Offset = "0x8408A4", VA = "0x8408A4")]
		public void UpdateTypesSync(long typeMask, Rect uvRect, PatchType type = PatchType.DynamicPatch)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x840BAC", Offset = "0x840BAC", VA = "0x840BAC")]
		[IteratorStateMachine(typeof(<UpdateTypesRoutine>d__35))]
		public IEnumerator UpdateTypesRoutine(long typeMask, Rect uvRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x83EF98", Offset = "0x83EF98", VA = "0x83EF98")]
		public Rect GetPatchRect(int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x83EFE8", Offset = "0x83EFE8", VA = "0x83EFE8")]
		public GameObject ResetPatchObject(int patchIndex, int typeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x840C60", Offset = "0x840C60", VA = "0x840C60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x840C88", Offset = "0x840C88", VA = "0x840C88")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x8414AC", Offset = "0x8414AC", VA = "0x8414AC")]
		private bool TryBuildPatchCycle(int cx, int cy, ref float budget, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x8412E4", Offset = "0x8412E4", VA = "0x8412E4")]
		private bool TryBuildPatchRuntime(int x, int y, ref float msLeft, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x8410AC", Offset = "0x8410AC", VA = "0x8410AC")]
		private bool TryDestroyPatchCycle(int cx, int cy, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x84177C", Offset = "0x84177C", VA = "0x84177C")]
		private bool TryDestroyListPatch(Rect buildRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x84193C", Offset = "0x84193C", VA = "0x84193C")]
		private bool TryDestroyPatchRuntime(int patchIndex, Rect buildRect, PatchType patchType = PatchType.DynamicPatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x83F788", Offset = "0x83F788", VA = "0x83F788")]
		public Vector3 UvToTerrain(Vector2 relativePos)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x841B1C", Offset = "0x841B1C", VA = "0x841B1C")]
		public void SetTypeData(int x, int y, int typeIndex, bool value)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x841BFC", Offset = "0x841BFC", VA = "0x841BFC")]
		public void SetTypeDataRect(int xStart, int yStart, int detailIndex, int[,] data)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x83EDAC", Offset = "0x83EDAC", VA = "0x83EDAC")]
		public string GetTypeName(int index)
		{
			return null;
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x841D08", Offset = "0x841D08", VA = "0x841D08")]
		public void Remove(int index)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x83E130", Offset = "0x83E130", VA = "0x83E130")]
		public void MarkValidity(int patchIndex, int typeIndex, bool valid)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x841F3C", Offset = "0x841F3C", VA = "0x841F3C")]
		public void ClearType(int typeIndex)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x840894", Offset = "0x840894", VA = "0x840894")]
		public void CancelPendingRebuild()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x84033C", Offset = "0x84033C", VA = "0x84033C")]
		public void RunDestroy(bool newResolution = false, bool destroyAll = false)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x841FF0", Offset = "0x841FF0", VA = "0x841FF0")]
		public LAMBatchedFoliage()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	internal class Timer : IDisposable
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string m_Text;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stopwatch m_Stopwatch;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x843BA4", Offset = "0x843BA4", VA = "0x843BA4")]
		public Timer(string text)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x843C30", Offset = "0x843C30", VA = "0x843C30", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class LAMBatchedFoliage_FoliageHolder : MonoBehaviour
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public LAMBatchedFoliage_PatchesHolder PatchesHolder;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x843D18", Offset = "0x843D18", VA = "0x843D18")]
		public LAMBatchedFoliage_FoliageHolder()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class LAMBatchedFoliage_PatchesHolder : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		private struct PatchCullData
		{
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MeshRenderer Renderer;
		}

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] PatchObjects;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool MergeGeometry;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public GameObject FoliageHolder;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<PatchCulling> LAMPatches;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PatchCullData[] m_PatchCull;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CullingGroup m_Culling;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LAMBatchedFoliage m_BatchedFoliage;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_LayerIndex;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_SpheresCount;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Initialized;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private ShadowCastingMode m_DefaultShadowMode;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x843D20", Offset = "0x843D20", VA = "0x843D20")]
		private void Initialize(LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x844014", Offset = "0x844014", VA = "0x844014")]
		private void SetupCullingGroup(float halfDistance, float maxDistance)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x8443C8", Offset = "0x8443C8", VA = "0x8443C8")]
		private void OnPatchCullingStateChanged(CullingGroupEvent evt)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x844410", Offset = "0x844410", VA = "0x844410")]
		private void Cull(int objIndex, int distance)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x844600", Offset = "0x844600", VA = "0x844600")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x844634", Offset = "0x844634", VA = "0x844634")]
		public void AddObject(int patchIndex, GameObject go)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x84469C", Offset = "0x84469C", VA = "0x84469C")]
		public void AddLAMPatch(PatchCulling pc)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x84474C", Offset = "0x84474C", VA = "0x84474C")]
		public void RemoveLAMPatch(PatchCulling pc)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x8447A4", Offset = "0x8447A4", VA = "0x8447A4")]
		public void PrepareCull(int patchIndex, LAMBatchedFoliage foliage)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x8448B4", Offset = "0x8448B4", VA = "0x8448B4")]
		public void UpdateCullDistances(float halfDistance, float maxDistance)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x844960", Offset = "0x844960", VA = "0x844960")]
		public void DestroyPatches()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x844A84", Offset = "0x844A84", VA = "0x844A84")]
		public LAMBatchedFoliage_PatchesHolder()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class LAMBatchedFoliage_TypeDataHolder : ScriptableObject
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public long[] Data;

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x844B78", Offset = "0x844B78", VA = "0x844B78")]
		public LAMBatchedFoliage_TypeDataHolder()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class LAMCopyTerrainMaterialProps : MonoBehaviour
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x844B80", Offset = "0x844B80", VA = "0x844B80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x844F60", Offset = "0x844F60", VA = "0x844F60")]
		public LAMCopyTerrainMaterialProps()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[ExecuteInEditMode]
	public class LAMDetailsAutoPainter : MonoBehaviour
	{
		[Token(Token = "0x20000BC")]
		public enum TextureChannelType
		{
			[Token(Token = "0x4000560")]
			Red,
			[Token(Token = "0x4000561")]
			Green,
			[Token(Token = "0x4000562")]
			Blue,
			[Token(Token = "0x4000563")]
			Alpha,
			[Token(Token = "0x4000564")]
			Black
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public class LayerDefinition
		{
			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public LAMMultiPaintLayer PaintLayer;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float[] TextureLayerWeights;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[CurveGraph(Start = 0f, End = 90f)]
			public TrapezoidCurve SlopeCutoff;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float Density;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Range(0f, 1f)]
			public float RandomVariation;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float MinWeight;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Texture2D MaskTexture;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float MaskTextureScale;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public TextureChannelType MaskChannel;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool DodgeUpperLayers;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
			public bool SkipRepaint;

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x846550", Offset = "0x846550", VA = "0x846550")]
			public LayerDefinition()
			{
			}
		}

		[Token(Token = "0x20000BE")]
		private class TerrainSample
		{
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector2 UV;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float[] LayerWeights;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 Normal;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float Height;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float SlopeAngle;

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x8465E8", Offset = "0x8465E8", VA = "0x8465E8")]
			public TerrainSample()
			{
			}
		}

		[Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private sealed class <Paint>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LAMDetailsAutoPainter <>4__this;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rect rect;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TerrainData <td>5__2;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <xStart>5__3;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int <yStart>5__4;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <w>5__5;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private int <h>5__6;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private TerrainSample <sample>5__7;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <ii>5__8;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private int <jj>5__9;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000397")]
				[Address(RVA = "0x847458", Offset = "0x847458", VA = "0x847458", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x8474A0", Offset = "0x8474A0", VA = "0x8474A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x8454F8", Offset = "0x8454F8", VA = "0x8454F8")]
			[DebuggerHidden]
			public <Paint>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x8466A0", Offset = "0x8466A0", VA = "0x8466A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x8466A4", Offset = "0x8466A4", VA = "0x8466A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x847460", Offset = "0x847460", VA = "0x847460", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int RandomSeed;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SplatMaskScaleMultiplier;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public LayerDefinition[] Layers;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private LAMMultiPaintLayer[] m_PaintLayers;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LAMDetailsAutoPainter_LayerDataHolder DataHolder;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float GlobalDensityAdjust;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Terrain m_Terrain;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private LAMTerrainTool m_TerrainTool;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float[,,] m_AlphaMaps;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public LAMBatchedFoliage Batched;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LatticeNoise m_Noise;

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x844F68", Offset = "0x844F68", VA = "0x844F68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x84504C", Offset = "0x84504C", VA = "0x84504C")]
		public void UpdateMaps()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x8450F8", Offset = "0x8450F8", VA = "0x8450F8")]
		private void RecreateDataHolder()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x845358", Offset = "0x845358", VA = "0x845358")]
		public void CopyData(LAMDetailsAutoPainter_LayerDataHolder otherData)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x84545C", Offset = "0x84545C", VA = "0x84545C")]
		[IteratorStateMachine(typeof(<Paint>d__18))]
		public IEnumerator Paint(Rect rect)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x845520", Offset = "0x845520", VA = "0x845520")]
		private bool LayerIsValid(LayerDefinition layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x8455D4", Offset = "0x8455D4", VA = "0x8455D4")]
		private int PaintSample(int layerIndex, int ii, int jj, TerrainSample sample, ref float sum)
		{
			return default(int);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x845968", Offset = "0x845968", VA = "0x845968")]
		private float GetChannel(Color color, TextureChannelType maskChannel)
		{
			return default(float);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x845B64", Offset = "0x845B64", VA = "0x845B64")]
		private void SampleTerrainData(float x, float y, TerrainSample result)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x845F80", Offset = "0x845F80", VA = "0x845F80")]
		private float SampleBilinear(int alphaIndex, Vector2 pos)
		{
			return default(float);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x845AE0", Offset = "0x845AE0", VA = "0x845AE0")]
		private int ProbRound(float v, float rnd)
		{
			return default(int);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x8461CC", Offset = "0x8461CC", VA = "0x8461CC")]
		public void ClearLayer(int index)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x84653C", Offset = "0x84653C", VA = "0x84653C")]
		public LAMDetailsAutoPainter()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class LAMDetailsAutoPainter_LayerDataHolder : ScriptableObject
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public byte[] Data;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x8474D8", Offset = "0x8474D8", VA = "0x8474D8")]
		public LAMDetailsAutoPainter_LayerDataHolder()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public sealed class LAMEditorSettings : ScriptableObject
	{
		[Token(Token = "0x4000587")]
		private const string GUID = "36ce4cc03e7f99943b402502e4164709";

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LAMEditorSettings _Instance;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _IsLoaded;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D _AutoLayerIcon;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture2D _MultiBrushIcon;

		[Token(Token = "0x17000097")]
		public static LAMEditorSettings Instance
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x8474F4", Offset = "0x8474F4", VA = "0x8474F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public static bool HasInstance
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x84757C", Offset = "0x84757C", VA = "0x84757C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public Texture2D AutoLayerIcon
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x847624", Offset = "0x847624", VA = "0x847624")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x84762C", Offset = "0x84762C", VA = "0x84762C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Texture2D MultiBrushIcon
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x847634", Offset = "0x847634", VA = "0x847634")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x84763C", Offset = "0x84763C", VA = "0x84763C")]
			set
			{
			}
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x8474E0", Offset = "0x8474E0", VA = "0x8474E0")]
		private LAMEditorSettings()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x8474E8", Offset = "0x8474E8", VA = "0x8474E8")]
		private void Awake()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[CreateAssetMenu(fileName = "new foliage", menuName = "LAM Foliage Type")]
	public class LAMFoliageDefinition : ScriptableObject
	{
		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshFilter PatchPrefab;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject InstancePrefab;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float MinDistance;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float RotateToNormal;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RandomRotation;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[MinMax(MinLimit = 0.5f, MaxLimit = 2.5f)]
		public MinMax ScaleVariation;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 AdditionalRotation;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 AdditionalOffset;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int MaxPerPatch;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[HideInInspector]
		public bool MergeGeometry;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public PatchType PatchType;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		public bool UpdateAtRuntime;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		[HideInInspector]
		public bool RuntimeCulling;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[FormerlySerializedAs("HalfCullDistance")]
		public float ShadowCullDistance;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		public float CullDistance;

		[Token(Token = "0x1700009B")]
		public Mesh Mesh
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x843660", Offset = "0x843660", VA = "0x843660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x847644", Offset = "0x847644", VA = "0x847644")]
		public LAMFoliageDefinition()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C5")]
	public class LAMMultiPaintLayer
	{
		[Token(Token = "0x20000C6")]
		public enum LayerType
		{
			[Token(Token = "0x40005A2")]
			BuiltInDetail,
			[Token(Token = "0x40005A3")]
			BuiltInTree,
			[Token(Token = "0x40005A4")]
			BatchedFoliage
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayerType Type;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int DetailIndex;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Gradient TreeColorVariation;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MinMax(MinLimit = 0.5f, MaxLimit = 2.5f)]
		public MinMax TreeScaleVariation;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[MinMax(MinLimit = 0.5f, MaxLimit = 2.5f)]
		public MinMax TreeHeightVariation;

		[NonSerialized]
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[XmlIgnore]
		public int[,] Data;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x8471CC", Offset = "0x8471CC", VA = "0x8471CC")]
		public static void ApplyLayers(LAMMultiPaintLayer[] layers, int xStart, int yStart, Terrain terrain, int treesSeed, out long batchedMask)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x847788", Offset = "0x847788", VA = "0x847788")]
		private static void SetDetailLayer(int xStart, int yStart, TerrainData td, LAMMultiPaintLayer layer)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x847070", Offset = "0x847070", VA = "0x847070")]
		public void InitData(int x, int y)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x847FB8", Offset = "0x847FB8", VA = "0x847FB8")]
		public static string[] GetLayerNames(LayerType type, Component ownerComponent)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x8480AC", Offset = "0x8480AC", VA = "0x8480AC")]
		public static string[] GetDetailLayerNames(Terrain terrain)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x8481F0", Offset = "0x8481F0", VA = "0x8481F0")]
		public static string[] GetTreeLayerNames(Terrain terrain)
		{
			return null;
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x848334", Offset = "0x848334", VA = "0x848334")]
		public static string[] GetFoliageLayerNames(LAMBatchedFoliage bf)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x8484A8", Offset = "0x8484A8", VA = "0x8484A8")]
		public string GetLayerName(Component ownerComponent)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x847190", Offset = "0x847190", VA = "0x847190")]
		public bool IsSameAs(LAMMultiPaintLayer other)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x84885C", Offset = "0x84885C", VA = "0x84885C")]
		public LAMMultiPaintLayer()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class LAMQualitySettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class QualityLevelData
		{
			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[QualityLevel]
			public int QualityLevel;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool DisableGrassShadows;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float GrassDrawDistance;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			public float GrassDensityMultiplier;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool DisableTerrainTesselation;

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x84A13C", Offset = "0x84A13C", VA = "0x84A13C")]
			public QualityLevelData()
			{
			}
		}

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public QualityLevelData[] Levels;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public LayerMask GrassLayers;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<Material> m_GrassFadingMaterials;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ShowGui;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool m_GuiVisible;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] m_Times;

		[Token(Token = "0x1700009C")]
		public int CurrentLevel
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x848B9C", Offset = "0x848B9C", VA = "0x848B9C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x848BA4", Offset = "0x848BA4", VA = "0x848BA4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x848BAC", Offset = "0x848BAC", VA = "0x848BAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x848C00", Offset = "0x848C00", VA = "0x848C00")]
		public int GetMatchingLevel(int unityQualityLevel)
		{
			return default(int);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x84923C", Offset = "0x84923C", VA = "0x84923C")]
		public void SetLevel(int index)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x848CF4", Offset = "0x848CF4", VA = "0x848CF4")]
		private void SetLevel(QualityLevelData levelData, bool force = false)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x849294", Offset = "0x849294", VA = "0x849294")]
		private void ApplyGrassSettings(LAMBatchedFoliage foliage, QualityLevelData levelData, bool force)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x84985C", Offset = "0x84985C", VA = "0x84985C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x8498C0", Offset = "0x8498C0", VA = "0x8498C0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x849E10", Offset = "0x849E10", VA = "0x849E10")]
		public static void RefreshGrassSettings(float GrassDrawDistance)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x84A038", Offset = "0x84A038", VA = "0x84A038")]
		public LAMQualitySettings()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class QualityLevelAttribute : PropertyAttribute
	{
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x84A144", Offset = "0x84A144", VA = "0x84A144")]
		public QualityLevelAttribute()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[ExecuteInEditMode]
	public class LAMTerrainTool : MonoBehaviour
	{
		[Token(Token = "0x20000CD")]
		public enum ShaderType
		{
			[Token(Token = "0x40005C4")]
			AdditiveWith3AutoLayers,
			[Token(Token = "0x40005C5")]
			DisplacementWith3Layers,
			[Token(Token = "0x40005C6")]
			DisplacementWith6Layers
		}

		[Token(Token = "0x20000CE")]
		public class ShaderTypeMetaData
		{
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string ShaderName;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Description;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int MaxLayers;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool HasAdditiveLayers;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			public bool HasTesselation;

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x84C214", Offset = "0x84C214", VA = "0x84C214")]
			public ShaderTypeMetaData()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CF")]
		public class LayerDefinition
		{
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D ColorTexture;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Texture2D NormalsTexture;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D SMOTexture;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float Scale;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float ScaleFar;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float ScaleMixStart;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float ScaleMixEnd;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool UseAuto;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public TrapezoidCurve Angle;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public TrapezoidCurve Height;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0.001f, 1f)]
			public float TextureBleed;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			public float DisplacementScale;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			public float Roughness;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public Color Specular;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public bool UseTriplanarProjection;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[FormerlySerializedAs("NoiseAmount")]
			public float OverlayStrength;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[FormerlySerializedAs("NoiseScale")]
			public float OverlayScale;

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x84C21C", Offset = "0x84C21C", VA = "0x84C21C")]
			public LayerDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class TessData
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float RangeMin;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float RangeMax;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Tesselation;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0.1f, 8f)]
			public float FalloffPower;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float GlobalScale;

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x84BF68", Offset = "0x84BF68", VA = "0x84BF68")]
			public TessData()
			{
			}
		}

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture2D IconAuto;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShaderType Shader;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerDefinition[] Layers;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("Noise")]
		public Texture2D ColorOverlay;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("NoiseScaleMultiplier")]
		public float OverlayScaleMultiplier;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TessData Displacement;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D ColorPaintTexture;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool AutoDebugMode;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GlobalScale;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialInstance;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Terrain m_Terrain;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Texture2D s_GrayTexture;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public SplatPrototype[] oldsp;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly ShaderTypeMetaData[] MetaData;

		[Token(Token = "0x1700009D")]
		private string CurrentShader
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x84A14C", Offset = "0x84A14C", VA = "0x84A14C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x84A1D4", Offset = "0x84A1D4", VA = "0x84A1D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x84A860", Offset = "0x84A860", VA = "0x84A860")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x84A254", Offset = "0x84A254", VA = "0x84A254")]
		private void EnsureInstance()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x84A9C0", Offset = "0x84A9C0", VA = "0x84A9C0")]
		public void EnsureLayerCount()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x84AEC8", Offset = "0x84AEC8", VA = "0x84AEC8")]
		public bool SplatPrototypesEquals(SplatPrototype[] arrOne, SplatPrototype[] arrTwo)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x84A480", Offset = "0x84A480", VA = "0x84A480")]
		public void ApplyMaterialProperties()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x84B21C", Offset = "0x84B21C", VA = "0x84B21C")]
		private void ApplyLayerDefinition(LayerDefinition layer, int index)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x84B9F8", Offset = "0x84B9F8", VA = "0x84B9F8")]
		private void ClearLayerDefinition(int index, bool alsoTextures = true)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x846190", Offset = "0x846190", VA = "0x846190")]
		public LayerDefinition GetLayer(int index)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x844E04", Offset = "0x844E04", VA = "0x844E04")]
		public static Texture2D GetGrayTexture()
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x84BD34", Offset = "0x84BD34", VA = "0x84BD34")]
		public void SetGrassShaderPropertiesGlobal()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x84BE6C", Offset = "0x84BE6C", VA = "0x84BE6C")]
		public LAMTerrainTool()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[ExecuteInEditMode]
	public class LAMWind : MonoBehaviour
	{
		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float WindStrength;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float WaveStrength;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float WaveFrequency;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x84C300", Offset = "0x84C300", VA = "0x84C300")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x84C3C8", Offset = "0x84C3C8", VA = "0x84C3C8")]
		public LAMWind()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public struct LatticeNoise
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int m_Seed;

		[Token(Token = "0x1700009E")]
		public int Seed
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x84C3E8", Offset = "0x84C3E8", VA = "0x84C3E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x84C3E0", Offset = "0x84C3E0", VA = "0x84C3E0")]
		public LatticeNoise(int seed)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x845A70", Offset = "0x845A70", VA = "0x845A70")]
		public float GetValue01(int x, int y)
		{
			return default(float);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x845A0C", Offset = "0x845A0C", VA = "0x845A0C")]
		public float GetValue(int x, int y)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000D3")]
	public class MeshBuilder
	{
		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<Vector3> m_Vertices;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<Vector3> m_Normals;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<Vector4> m_Tangents;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<int> m_Indices;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly List<Vector2> m_UVs;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<Vector2> m_UV2s;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<Vector2> m_UV3s;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<Vector2> m_UV4s;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<Color> m_Colors;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshTopology m_Topology;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Mesh m_LastMesh;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_InstanceIndex;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] m_LastVertices;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] m_LastNormals;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector4[] m_LastTangents;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int[] m_LastIndices;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2[] m_LastUVs;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2[] m_LastUV2s;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2[] m_LastUV3s;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector2[] m_LastUV4s;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Color[] m_LastColors;

		[Token(Token = "0x1700009F")]
		public int[] Indices
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x84C3F0", Offset = "0x84C3F0", VA = "0x84C3F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public int InstanceCount
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x84C440", Offset = "0x84C440", VA = "0x84C440")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x84C448", Offset = "0x84C448", VA = "0x84C448")]
		public void Clear()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x84C56C", Offset = "0x84C56C", VA = "0x84C56C")]
		public void AddMeshInstance(Matrix4x4 transform, Color colorModifier)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x84CD48", Offset = "0x84CD48", VA = "0x84CD48")]
		private static bool HasData(Array array)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x84CD68", Offset = "0x84CD68", VA = "0x84CD68")]
		public Mesh CreateMesh()
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x84CFFC", Offset = "0x84CFFC", VA = "0x84CFFC")]
		public void Reset(Mesh mesh)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x84D1A8", Offset = "0x84D1A8", VA = "0x84D1A8")]
		public MeshBuilder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D4")]
	public class MinMax
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Min;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Max;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x84D418", Offset = "0x84D418", VA = "0x84D418")]
		public float Get(float t)
		{
			return default(float);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x84D42C", Offset = "0x84D42C", VA = "0x84D42C")]
		public float Get()
		{
			return default(float);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x8433D8", Offset = "0x8433D8", VA = "0x8433D8")]
		public MinMax()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class MinMaxAttribute : PropertyAttribute
	{
		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float MinLimit;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxLimit;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x84D458", Offset = "0x84D458", VA = "0x84D458")]
		public MinMaxAttribute()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class PatchBuilder
	{
		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<MeshRenderer> m_Objects;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Mesh m_LastMesh;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] m_LastMaterials;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject m_LastRoot;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_InstanceIndex;

		[Token(Token = "0x170000A1")]
		public int InstanceCount
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x84D468", Offset = "0x84D468", VA = "0x84D468")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x84D470", Offset = "0x84D470", VA = "0x84D470")]
		public void Clear()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x84D4E4", Offset = "0x84D4E4", VA = "0x84D4E4")]
		public void AddPatchInstance(Vector3 patchPos, Quaternion patchRot, Vector3 patchScale)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x84D72C", Offset = "0x84D72C", VA = "0x84D72C")]
		private static bool HasData(Array array)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x84D74C", Offset = "0x84D74C", VA = "0x84D74C")]
		public MeshRenderer[] CreatePatch()
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x84D79C", Offset = "0x84D79C", VA = "0x84D79C")]
		public void Reset(Mesh mesh, Material[] mat, GameObject root)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x84D7F8", Offset = "0x84D7F8", VA = "0x84D7F8")]
		public PatchBuilder()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	[ExecuteInEditMode]
	public class SetLayerCullDistances : MonoBehaviour
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ApplyToEditorCamera;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public float[] LayerDistances;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Camera camera;

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x84D880", Offset = "0x84D880", VA = "0x84D880")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x84D960", Offset = "0x84D960", VA = "0x84D960")]
		public SetLayerCullDistances()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000D8")]
	public class TrapezoidCurve
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float From;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float To;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Smoothing;

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x845928", Offset = "0x845928", VA = "0x845928")]
		public float GetValue(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x8465E0", Offset = "0x8465E0", VA = "0x8465E0")]
		public TrapezoidCurve()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class CurveGraphAttribute : PropertyAttribute
	{
		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Start;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float End;

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x84D9C4", Offset = "0x84D9C4", VA = "0x84D9C4")]
		public CurveGraphAttribute()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class TreePainter
	{
		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Terrain m_Terrain;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<TreeInstance> m_Trees;

		[Token(Token = "0x170000A2")]
		public MinMax ScaleVariation
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x84D9D4", Offset = "0x84D9D4", VA = "0x84D9D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x84D9DC", Offset = "0x84D9DC", VA = "0x84D9DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public MinMax HeightVariation
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x84D9E4", Offset = "0x84D9E4", VA = "0x84D9E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x84D9EC", Offset = "0x84D9EC", VA = "0x84D9EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public Gradient ColorVariation
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x84D9F4", Offset = "0x84D9F4", VA = "0x84D9F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x84D9FC", Offset = "0x84D9FC", VA = "0x84D9FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x8476E4", Offset = "0x8476E4", VA = "0x8476E4")]
		public TreePainter(Terrain terrain)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x847904", Offset = "0x847904", VA = "0x847904")]
		public void SpawnTrees(int xStart, int yStart, int detailIndex, int[,] data, int seed)
		{
		}
	}
}
namespace VEAGames.LAM.Constants
{
	[Token(Token = "0x20000DC")]
	public enum PatchType
	{
		[Token(Token = "0x4000616")]
		DynamicPatch,
		[Token(Token = "0x4000617")]
		GrassPatch,
		[Token(Token = "0x4000618")]
		StaticPatch,
		[Token(Token = "0x4000619")]
		All
	}
}
