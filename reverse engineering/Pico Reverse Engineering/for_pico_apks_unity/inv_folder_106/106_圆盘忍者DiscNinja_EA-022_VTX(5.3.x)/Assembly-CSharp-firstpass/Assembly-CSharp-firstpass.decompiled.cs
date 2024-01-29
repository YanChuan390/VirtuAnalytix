using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class I360Render
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material equirectangularConverter;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int paddingX;

	[Token(Token = "0x4000003")]
	private const string XMP_NAMESPACE_JPEG = "http://ns.adobe.com/xap/1.0/";

	[Token(Token = "0x4000004")]
	private const string XMP_CONTENT_TO_FORMAT_JPEG = "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" GPano:UsePanoramaViewer=\"True\" GPano:CaptureSoftware=\"Unity3D\" GPano:StitchingSoftware=\"Unity3D\" GPano:ProjectionType=\"equirectangular\" GPano:PoseHeadingDegrees=\"180.0\" GPano:InitialViewHeadingDegrees=\"0.0\" GPano:InitialViewPitchDegrees=\"0.0\" GPano:InitialViewRollDegrees=\"0.0\" GPano:InitialHorizontalFOVDegrees=\"{0}\" GPano:CroppedAreaLeftPixels=\"0\" GPano:CroppedAreaTopPixels=\"0\" GPano:CroppedAreaImageWidthPixels=\"{1}\" GPano:CroppedAreaImageHeightPixels=\"{2}\" GPano:FullPanoWidthPixels=\"{1}\" GPano:FullPanoHeightPixels=\"{2}\"/></rdf:RDF></x:xmpmeta>";

	[Token(Token = "0x4000005")]
	private const string XMP_CONTENT_TO_FORMAT_PNG = "XML:com.adobe.xmp\0\0\0\0\0<?xpacket begin=\"ï»¿\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\" xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"> <GPano:UsePanoramaViewer>True</GPano:UsePanoramaViewer> <GPano:CaptureSoftware>Unity3D</GPano:CaptureSoftware> <GPano:StitchingSoftware>Unity3D</GPano:StitchingSoftware> <GPano:ProjectionType>equirectangular</GPano:ProjectionType> <GPano:PoseHeadingDegrees>180.0</GPano:PoseHeadingDegrees> <GPano:InitialViewHeadingDegrees>0.0</GPano:InitialViewHeadingDegrees> <GPano:InitialViewPitchDegrees>0.0</GPano:InitialViewPitchDegrees> <GPano:InitialViewRollDegrees>0.0</GPano:InitialViewRollDegrees> <GPano:InitialHorizontalFOVDegrees>{0}</GPano:InitialHorizontalFOVDegrees> <GPano:CroppedAreaLeftPixels>0</GPano:CroppedAreaLeftPixels> <GPano:CroppedAreaTopPixels>0</GPano:CroppedAreaTopPixels> <GPano:CroppedAreaImageWidthPixels>{1}</GPano:CroppedAreaImageWidthPixels> <GPano:CroppedAreaImageHeightPixels>{2}</GPano:CroppedAreaImageHeightPixels> <GPano:FullPanoWidthPixels>{1}</GPano:FullPanoWidthPixels> <GPano:FullPanoHeightPixels>{2}</GPano:FullPanoHeightPixels> <tiff:Orientation>1</tiff:Orientation> <exif:PixelXDimension>{1}</exif:PixelXDimension> <exif:PixelYDimension>{2}</exif:PixelYDimension> </rdf:Description></rdf:RDF></x:xmpmeta><?xpacket end=\"w\"?>";

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static uint[] CRC_TABLE_PNG;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1BDB6CC", Offset = "0x1BDB6CC", VA = "0x1BDB6CC")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam, bool faceCameraDirection = true)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1BDBEF0", Offset = "0x1BDBEF0", VA = "0x1BDBEF0")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1BDBE38", Offset = "0x1BDBE38", VA = "0x1BDBE38")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1BDBFAC", Offset = "0x1BDBFAC", VA = "0x1BDBFAC")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1BDC8E0", Offset = "0x1BDC8E0", VA = "0x1BDC8E0")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1BDC724", Offset = "0x1BDC724", VA = "0x1BDC724")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1BDC898", Offset = "0x1BDC898", VA = "0x1BDC898")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1BDC398", Offset = "0x1BDC398", VA = "0x1BDC398")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1BDC9C4", Offset = "0x1BDC9C4", VA = "0x1BDC9C4")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1BDCD14", Offset = "0x1BDCD14", VA = "0x1BDCD14")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1BDCC04", Offset = "0x1BDCC04", VA = "0x1BDCC04")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1BDCE0C", Offset = "0x1BDCE0C", VA = "0x1BDCE0C")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCF4B48", Offset = "0xCF4B48")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1BDCEA0", Offset = "0x1BDCEA0", VA = "0x1BDCEA0")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCF4B5C", Offset = "0xCF4B5C")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1BDCEA8", Offset = "0x1BDCEA8", VA = "0x1BDCEA8")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCF4B70", Offset = "0xCF4B70")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1BDCEB0", Offset = "0x1BDCEB0", VA = "0x1BDCEB0")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000006")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4C3C", Offset = "0xCF4C3C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1BD13D0", Offset = "0x1BD13D0", VA = "0x1BD13D0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1BD1B90", Offset = "0x1BD1B90", VA = "0x1BD1B90")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x1BD1BAC", Offset = "0x1BD1BAC", VA = "0x1BD1BAC")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4C4C", Offset = "0xCF4C4C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1BD1514", Offset = "0x1BD1514", VA = "0x1BD1514")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x1BD1BC8", Offset = "0x1BD1BC8", VA = "0x1BD1BC8")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1BD1BE4", Offset = "0x1BD1BE4", VA = "0x1BD1BE4")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4C5C", Offset = "0xCF4C5C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1BD165C", Offset = "0x1BD165C", VA = "0x1BD165C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1BD1C00", Offset = "0x1BD1C00", VA = "0x1BD1C00")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x1BD1C40", Offset = "0x1BD1C40", VA = "0x1BD1C40")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1BD126C", Offset = "0x1BD126C", VA = "0x1BD126C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1BD13D8", Offset = "0x1BD13D8", VA = "0x1BD13D8")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1BD151C", Offset = "0x1BD151C", VA = "0x1BD151C")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1BD1664", Offset = "0x1BD1664", VA = "0x1BD1664")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1BD16DC", Offset = "0x1BD16DC", VA = "0x1BD16DC")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1BD1754", Offset = "0x1BD1754", VA = "0x1BD1754")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1BD17BC", Offset = "0x1BD17BC", VA = "0x1BD17BC")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1BD1844", Offset = "0x1BD1844", VA = "0x1BD1844")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1BD18AC", Offset = "0x1BD18AC", VA = "0x1BD18AC")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1BD1914", Offset = "0x1BD1914", VA = "0x1BD1914")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1BD197C", Offset = "0x1BD197C", VA = "0x1BD197C")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1BD19E4", Offset = "0x1BD19E4", VA = "0x1BD19E4")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1BD1A54", Offset = "0x1BD1A54", VA = "0x1BD1A54")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1BD1AC0", Offset = "0x1BD1AC0", VA = "0x1BD1AC0")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1BD1B28", Offset = "0x1BD1B28", VA = "0x1BD1B28")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000007")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4C6C", Offset = "0xCF4C6C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1BD1C64", Offset = "0x1BD1C64", VA = "0x1BD1C64")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x1BD2E94", Offset = "0x1BD2E94", VA = "0x1BD2E94")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4C7C", Offset = "0xCF4C7C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1BD1DF4", Offset = "0x1BD1DF4", VA = "0x1BD1DF4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1BD2FD0", Offset = "0x1BD2FD0", VA = "0x1BD2FD0")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4C8C", Offset = "0xCF4C8C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1BD1F84", Offset = "0x1BD1F84", VA = "0x1BD1F84")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1BD2FEC", Offset = "0x1BD2FEC", VA = "0x1BD2FEC")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4C9C", Offset = "0xCF4C9C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1BD2114", Offset = "0x1BD2114", VA = "0x1BD2114")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x1BD3008", Offset = "0x1BD3008", VA = "0x1BD3008")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4CAC", Offset = "0xCF4CAC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x1BD211C", Offset = "0x1BD211C", VA = "0x1BD211C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1BD3024", Offset = "0x1BD3024", VA = "0x1BD3024")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4CBC", Offset = "0xCF4CBC")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x1BD2308", Offset = "0x1BD2308", VA = "0x1BD2308")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x1BD3040", Offset = "0x1BD3040", VA = "0x1BD3040")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4CCC", Offset = "0xCF4CCC")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1BD2784", Offset = "0x1BD2784", VA = "0x1BD2784")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1BD305C", Offset = "0x1BD305C", VA = "0x1BD305C")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1BD3078", Offset = "0x1BD3078", VA = "0x1BD3078")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1BD30AC", Offset = "0x1BD30AC", VA = "0x1BD30AC")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1BD30C8", Offset = "0x1BD30C8", VA = "0x1BD30C8")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1BD30E4", Offset = "0x1BD30E4", VA = "0x1BD30E4")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4CDC", Offset = "0xCF4CDC")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x1BD2978", Offset = "0x1BD2978", VA = "0x1BD2978")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1BD31A4", Offset = "0x1BD31A4", VA = "0x1BD31A4")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4CEC", Offset = "0xCF4CEC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x1BD2B80", Offset = "0x1BD2B80", VA = "0x1BD2B80")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x1BD31C0", Offset = "0x1BD31C0", VA = "0x1BD31C0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1BD31DC", Offset = "0x1BD31DC", VA = "0x1BD31DC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4CFC", Offset = "0xCF4CFC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1BD2D00", Offset = "0x1BD2D00", VA = "0x1BD2D00")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1BD32E0", Offset = "0x1BD32E0", VA = "0x1BD32E0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D0C", Offset = "0xCF4D0C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1BD2E8C", Offset = "0x1BD2E8C", VA = "0x1BD2E8C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1BD2EB0", Offset = "0x1BD2EB0", VA = "0x1BD2EB0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x1BD2ECC", Offset = "0x1BD2ECC", VA = "0x1BD2ECC")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1BCE878", Offset = "0x1BCE878", VA = "0x1BCE878")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1BD1C6C", Offset = "0x1BD1C6C", VA = "0x1BD1C6C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1BD1DFC", Offset = "0x1BD1DFC", VA = "0x1BD1DFC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1BD1F8C", Offset = "0x1BD1F8C", VA = "0x1BD1F8C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1BCEB50", Offset = "0x1BCEB50", VA = "0x1BCEB50")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1BD2124", Offset = "0x1BD2124", VA = "0x1BD2124")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1BD2310", Offset = "0x1BD2310", VA = "0x1BD2310")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1BD278C", Offset = "0x1BD278C", VA = "0x1BD278C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1BD2980", Offset = "0x1BD2980", VA = "0x1BD2980")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1BD2B88", Offset = "0x1BD2B88", VA = "0x1BD2B88")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1BD2D08", Offset = "0x1BD2D08", VA = "0x1BD2D08")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000008")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D1C", Offset = "0xCF4D1C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1BD32FC", Offset = "0x1BD32FC", VA = "0x1BD32FC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1BD3EFC", Offset = "0x1BD3EFC", VA = "0x1BD3EFC")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D2C", Offset = "0xCF4D2C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1BD3478", Offset = "0x1BD3478", VA = "0x1BD3478")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x1BD3F18", Offset = "0x1BD3F18", VA = "0x1BD3F18")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D3C", Offset = "0xCF4D3C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1BD35F4", Offset = "0x1BD35F4", VA = "0x1BD35F4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1BD3F34", Offset = "0x1BD3F34", VA = "0x1BD3F34")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D4C", Offset = "0xCF4D4C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1BD35FC", Offset = "0x1BD35FC", VA = "0x1BD35FC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1BD3F50", Offset = "0x1BD3F50", VA = "0x1BD3F50")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D5C", Offset = "0xCF4D5C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1BD397C", Offset = "0x1BD397C", VA = "0x1BD397C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1BD3F6C", Offset = "0x1BD3F6C", VA = "0x1BD3F6C")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1BD3F88", Offset = "0x1BD3F88", VA = "0x1BD3F88")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x1BD3FA4", Offset = "0x1BD3FA4", VA = "0x1BD3FA4")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x1BD3FD8", Offset = "0x1BD3FD8", VA = "0x1BD3FD8")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1BD3FF4", Offset = "0x1BD3FF4", VA = "0x1BD3FF4")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1BD4010", Offset = "0x1BD4010", VA = "0x1BD4010")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D6C", Offset = "0xCF4D6C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1BD3C30", Offset = "0x1BD3C30", VA = "0x1BD3C30")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1BD4138", Offset = "0x1BD4138", VA = "0x1BD4138")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1BD41C8", Offset = "0x1BD41C8", VA = "0x1BD41C8")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D7C", Offset = "0xCF4D7C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x1BD3EF4", Offset = "0x1BD3EF4", VA = "0x1BD3EF4")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1BD426C", Offset = "0x1BD426C", VA = "0x1BD426C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1BD4288", Offset = "0x1BD4288", VA = "0x1BD4288")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1BCE9E8", Offset = "0x1BCE9E8", VA = "0x1BCE9E8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1BD3304", Offset = "0x1BD3304", VA = "0x1BD3304")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1BD3480", Offset = "0x1BD3480", VA = "0x1BD3480")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1BCECBC", Offset = "0x1BCECBC", VA = "0x1BCECBC")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1BD3604", Offset = "0x1BD3604", VA = "0x1BD3604")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1BD3984", Offset = "0x1BD3984", VA = "0x1BD3984")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1BD3C38", Offset = "0x1BD3C38", VA = "0x1BD3C38")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D8C", Offset = "0xCF4D8C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1BD43B4", Offset = "0x1BD43B4", VA = "0x1BD43B4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1BD4788", Offset = "0x1BD4788", VA = "0x1BD4788")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1BD47A4", Offset = "0x1BD47A4", VA = "0x1BD47A4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4D9C", Offset = "0xCF4D9C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x1BD43BC", Offset = "0x1BD43BC", VA = "0x1BD43BC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1BD47C0", Offset = "0x1BD47C0", VA = "0x1BD47C0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1BD47DC", Offset = "0x1BD47DC", VA = "0x1BD47DC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4DAC", Offset = "0xCF4DAC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x1BD4780", Offset = "0x1BD4780", VA = "0x1BD4780")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1BD47F8", Offset = "0x1BD47F8", VA = "0x1BD47F8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x1BD4804", Offset = "0x1BD4804", VA = "0x1BD4804")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1BCEF58", Offset = "0x1BCEF58", VA = "0x1BCEF58")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1BCF384", Offset = "0x1BCF384", VA = "0x1BCF384")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1BD43C4", Offset = "0x1BD43C4", VA = "0x1BD43C4")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1BD459C", Offset = "0x1BD459C", VA = "0x1BD459C")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200000A")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000029")]
		public static class Utils
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x1BCE468", Offset = "0x1BCE468", VA = "0x1BCE468")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4DBC", Offset = "0xCF4DBC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x1BD48B0", Offset = "0x1BD48B0", VA = "0x1BD48B0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x1BD78C4", Offset = "0x1BD78C4", VA = "0x1BD78C4")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1BD78E0", Offset = "0x1BD78E0", VA = "0x1BD78E0")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4DCC", Offset = "0xCF4DCC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x1BD48B8", Offset = "0x1BD48B8", VA = "0x1BD48B8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x1BD7B34", Offset = "0x1BD7B34", VA = "0x1BD7B34")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x1BD7B58", Offset = "0x1BD7B58", VA = "0x1BD7B58")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4DDC", Offset = "0xCF4DDC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1BD48C0", Offset = "0x1BD48C0", VA = "0x1BD48C0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1BD81C0", Offset = "0x1BD81C0", VA = "0x1BD81C0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1BD81E4", Offset = "0x1BD81E4", VA = "0x1BD81E4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4DEC", Offset = "0xCF4DEC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1BD4A2C", Offset = "0x1BD4A2C", VA = "0x1BD4A2C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1BD868C", Offset = "0x1BD868C", VA = "0x1BD868C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1BD86B0", Offset = "0x1BD86B0", VA = "0x1BD86B0")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4DFC", Offset = "0xCF4DFC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1BD4B70", Offset = "0x1BD4B70", VA = "0x1BD4B70")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1BD879C", Offset = "0x1BD879C", VA = "0x1BD879C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1BD87C0", Offset = "0x1BD87C0", VA = "0x1BD87C0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E0C", Offset = "0xCF4E0C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1BD4CD8", Offset = "0x1BD4CD8", VA = "0x1BD4CD8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1BD87E4", Offset = "0x1BD87E4", VA = "0x1BD87E4")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1BD8800", Offset = "0x1BD8800", VA = "0x1BD8800")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E1C", Offset = "0xCF4E1C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1BD501C", Offset = "0x1BD501C", VA = "0x1BD501C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1BD881C", Offset = "0x1BD881C", VA = "0x1BD881C")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x1BD889C", Offset = "0x1BD889C", VA = "0x1BD889C")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E2C", Offset = "0xCF4E2C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1BD5180", Offset = "0x1BD5180", VA = "0x1BD5180")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1BD88F8", Offset = "0x1BD88F8", VA = "0x1BD88F8")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1BD8978", Offset = "0x1BD8978", VA = "0x1BD8978")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E3C", Offset = "0xCF4E3C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1BD52E4", Offset = "0x1BD52E4", VA = "0x1BD52E4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1BD89D4", Offset = "0x1BD89D4", VA = "0x1BD89D4")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1BD8A54", Offset = "0x1BD8A54", VA = "0x1BD8A54")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E4C", Offset = "0xCF4E4C")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1BD5450", Offset = "0x1BD5450", VA = "0x1BD5450")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1BD78FC", Offset = "0x1BD78FC", VA = "0x1BD78FC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1BD791C", Offset = "0x1BD791C", VA = "0x1BD791C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E5C", Offset = "0xCF4E5C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1BD5594", Offset = "0x1BD5594", VA = "0x1BD5594")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1BD7938", Offset = "0x1BD7938", VA = "0x1BD7938")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1BD7958", Offset = "0x1BD7958", VA = "0x1BD7958")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E6C", Offset = "0xCF4E6C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x1BD56E8", Offset = "0x1BD56E8", VA = "0x1BD56E8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1BD7974", Offset = "0x1BD7974", VA = "0x1BD7974")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1BD7990", Offset = "0x1BD7990", VA = "0x1BD7990")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E7C", Offset = "0xCF4E7C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1BD584C", Offset = "0x1BD584C", VA = "0x1BD584C")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1BD79AC", Offset = "0x1BD79AC", VA = "0x1BD79AC")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x1BD79C8", Offset = "0x1BD79C8", VA = "0x1BD79C8")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E8C", Offset = "0xCF4E8C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x1BD59C4", Offset = "0x1BD59C4", VA = "0x1BD59C4")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1BD79E4", Offset = "0x1BD79E4", VA = "0x1BD79E4")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1BD7A00", Offset = "0x1BD7A00", VA = "0x1BD7A00")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4E9C", Offset = "0xCF4E9C")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1BD5B3C", Offset = "0x1BD5B3C", VA = "0x1BD5B3C")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1BD7A1C", Offset = "0x1BD7A1C", VA = "0x1BD7A1C")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1BD7A38", Offset = "0x1BD7A38", VA = "0x1BD7A38")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4EAC", Offset = "0xCF4EAC")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1BD5B44", Offset = "0x1BD5B44", VA = "0x1BD5B44")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1BD7A54", Offset = "0x1BD7A54", VA = "0x1BD7A54")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1BD7A70", Offset = "0x1BD7A70", VA = "0x1BD7A70")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4EBC", Offset = "0xCF4EBC")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1BD5CC8", Offset = "0x1BD5CC8", VA = "0x1BD5CC8")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1BD7A8C", Offset = "0x1BD7A8C", VA = "0x1BD7A8C")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1BD7AA8", Offset = "0x1BD7AA8", VA = "0x1BD7AA8")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4ECC", Offset = "0xCF4ECC")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1BD5E4C", Offset = "0x1BD5E4C", VA = "0x1BD5E4C")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1BD7AC4", Offset = "0x1BD7AC4", VA = "0x1BD7AC4")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1BD7AE0", Offset = "0x1BD7AE0", VA = "0x1BD7AE0")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4EDC", Offset = "0xCF4EDC")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1BD5FD0", Offset = "0x1BD5FD0", VA = "0x1BD5FD0")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1BD7AFC", Offset = "0x1BD7AFC", VA = "0x1BD7AFC")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x1BD7B18", Offset = "0x1BD7B18", VA = "0x1BD7B18")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4EEC", Offset = "0xCF4EEC")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1BD6134", Offset = "0x1BD6134", VA = "0x1BD6134")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1BD7B7C", Offset = "0x1BD7B7C", VA = "0x1BD7B7C")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1BD7B98", Offset = "0x1BD7B98", VA = "0x1BD7B98")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4EFC", Offset = "0xCF4EFC")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1BD6298", Offset = "0x1BD6298", VA = "0x1BD6298")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1BD7BB4", Offset = "0x1BD7BB4", VA = "0x1BD7BB4")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1BD7BD0", Offset = "0x1BD7BD0", VA = "0x1BD7BD0")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F0C", Offset = "0xCF4F0C")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1BD63EC", Offset = "0x1BD63EC", VA = "0x1BD63EC")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1BD7BEC", Offset = "0x1BD7BEC", VA = "0x1BD7BEC")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1BD7C08", Offset = "0x1BD7C08", VA = "0x1BD7C08")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F1C", Offset = "0xCF4F1C")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1BD6558", Offset = "0x1BD6558", VA = "0x1BD6558")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1BD7C24", Offset = "0x1BD7C24", VA = "0x1BD7C24")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1BD7C40", Offset = "0x1BD7C40", VA = "0x1BD7C40")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F2C", Offset = "0xCF4F2C")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1BD66C4", Offset = "0x1BD66C4", VA = "0x1BD66C4")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1BD7C5C", Offset = "0x1BD7C5C", VA = "0x1BD7C5C")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1BD7C78", Offset = "0x1BD7C78", VA = "0x1BD7C78")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F3C", Offset = "0xCF4F3C")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1BD66CC", Offset = "0x1BD66CC", VA = "0x1BD66CC")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1BD7C94", Offset = "0x1BD7C94", VA = "0x1BD7C94")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1BD7CB0", Offset = "0x1BD7CB0", VA = "0x1BD7CB0")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F4C", Offset = "0xCF4F4C")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1BD66D4", Offset = "0x1BD66D4", VA = "0x1BD66D4")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1BD7CCC", Offset = "0x1BD7CCC", VA = "0x1BD7CCC")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1BD7D5C", Offset = "0x1BD7D5C", VA = "0x1BD7D5C")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F5C", Offset = "0xCF4F5C")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1BD685C", Offset = "0x1BD685C", VA = "0x1BD685C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1BD7E00", Offset = "0x1BD7E00", VA = "0x1BD7E00")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1BD7E90", Offset = "0x1BD7E90", VA = "0x1BD7E90")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F6C", Offset = "0xCF4F6C")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1BD6864", Offset = "0x1BD6864", VA = "0x1BD6864")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1BD7F34", Offset = "0x1BD7F34", VA = "0x1BD7F34")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1BD7FC4", Offset = "0x1BD7FC4", VA = "0x1BD7FC4")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F7C", Offset = "0xCF4F7C")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1BD6BE8", Offset = "0x1BD6BE8", VA = "0x1BD6BE8")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1BD8068", Offset = "0x1BD8068", VA = "0x1BD8068")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1BD8084", Offset = "0x1BD8084", VA = "0x1BD8084")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1BD80A0", Offset = "0x1BD80A0", VA = "0x1BD80A0")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1BD80D4", Offset = "0x1BD80D4", VA = "0x1BD80D4")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1BD80F0", Offset = "0x1BD80F0", VA = "0x1BD80F0")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1BD810C", Offset = "0x1BD810C", VA = "0x1BD810C")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F8C", Offset = "0xCF4F8C")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1BD6D40", Offset = "0x1BD6D40", VA = "0x1BD6D40")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1BD8208", Offset = "0x1BD8208", VA = "0x1BD8208")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1BD8278", Offset = "0x1BD8278", VA = "0x1BD8278")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4F9C", Offset = "0xCF4F9C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1BD6E88", Offset = "0x1BD6E88", VA = "0x1BD6E88")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x600013D")]
			[Address(RVA = "0x1BD82C4", Offset = "0x1BD82C4", VA = "0x1BD82C4")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1BD82E0", Offset = "0x1BD82E0", VA = "0x1BD82E0")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4FAC", Offset = "0xCF4FAC")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1BD6FD0", Offset = "0x1BD6FD0", VA = "0x1BD6FD0")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1BD82FC", Offset = "0x1BD82FC", VA = "0x1BD82FC")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1BD8318", Offset = "0x1BD8318", VA = "0x1BD8318")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4FBC", Offset = "0xCF4FBC")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1BD7124", Offset = "0x1BD7124", VA = "0x1BD7124")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1BD8334", Offset = "0x1BD8334", VA = "0x1BD8334")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1BD8358", Offset = "0x1BD8358", VA = "0x1BD8358")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4FCC", Offset = "0xCF4FCC")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1BD712C", Offset = "0x1BD712C", VA = "0x1BD712C")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1BD837C", Offset = "0x1BD837C", VA = "0x1BD837C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1BD83A0", Offset = "0x1BD83A0", VA = "0x1BD83A0")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4FDC", Offset = "0xCF4FDC")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1BD72D0", Offset = "0x1BD72D0", VA = "0x1BD72D0")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1BD83C4", Offset = "0x1BD83C4", VA = "0x1BD83C4")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1BD83CC", Offset = "0x1BD83CC", VA = "0x1BD83CC")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4FEC", Offset = "0xCF4FEC")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1BD72D8", Offset = "0x1BD72D8", VA = "0x1BD72D8")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1BD846C", Offset = "0x1BD846C", VA = "0x1BD846C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1BD8490", Offset = "0x1BD8490", VA = "0x1BD8490")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF4FFC", Offset = "0xCF4FFC")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1BD72E0", Offset = "0x1BD72E0", VA = "0x1BD72E0")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1BD84B4", Offset = "0x1BD84B4", VA = "0x1BD84B4")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1BD84D8", Offset = "0x1BD84D8", VA = "0x1BD84D8")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF500C", Offset = "0xCF500C")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1BD74D4", Offset = "0x1BD74D4", VA = "0x1BD74D4")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1BD84FC", Offset = "0x1BD84FC", VA = "0x1BD84FC")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1BD8508", Offset = "0x1BD8508", VA = "0x1BD8508")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF501C", Offset = "0xCF501C")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1BD76C8", Offset = "0x1BD76C8", VA = "0x1BD76C8")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1BD85C4", Offset = "0x1BD85C4", VA = "0x1BD85C4")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1BD85D0", Offset = "0x1BD85D0", VA = "0x1BD85D0")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF502C", Offset = "0xCF502C")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1BD78BC", Offset = "0x1BD78BC", VA = "0x1BD78BC")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1BD86D4", Offset = "0x1BD86D4", VA = "0x1BD86D4")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1BD86E0", Offset = "0x1BD86E0", VA = "0x1BD86E0")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1BCF738", Offset = "0x1BCF738", VA = "0x1BCF738")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1BCF0BC", Offset = "0x1BCF0BC", VA = "0x1BCF0BC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1BCF4C0", Offset = "0x1BCF4C0", VA = "0x1BCF4C0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1BD48C8", Offset = "0x1BD48C8", VA = "0x1BD48C8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1BD4A34", Offset = "0x1BD4A34", VA = "0x1BD4A34")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1BD4B78", Offset = "0x1BD4B78", VA = "0x1BD4B78")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1BD4CE0", Offset = "0x1BD4CE0", VA = "0x1BD4CE0")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1BD4EC0", Offset = "0x1BD4EC0", VA = "0x1BD4EC0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1BD5024", Offset = "0x1BD5024", VA = "0x1BD5024")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1BD5188", Offset = "0x1BD5188", VA = "0x1BD5188")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1BD52EC", Offset = "0x1BD52EC", VA = "0x1BD52EC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1BD5458", Offset = "0x1BD5458", VA = "0x1BD5458")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1BD559C", Offset = "0x1BD559C", VA = "0x1BD559C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1BD56F0", Offset = "0x1BD56F0", VA = "0x1BD56F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1BD5854", Offset = "0x1BD5854", VA = "0x1BD5854")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1BD59CC", Offset = "0x1BD59CC", VA = "0x1BD59CC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1BCE714", Offset = "0x1BCE714", VA = "0x1BCE714")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1BD5B4C", Offset = "0x1BD5B4C", VA = "0x1BD5B4C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1BD5CD0", Offset = "0x1BD5CD0", VA = "0x1BD5CD0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1BD5E54", Offset = "0x1BD5E54", VA = "0x1BD5E54")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1BD5FD8", Offset = "0x1BD5FD8", VA = "0x1BD5FD8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1BD613C", Offset = "0x1BD613C", VA = "0x1BD613C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1BD62A0", Offset = "0x1BD62A0", VA = "0x1BD62A0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1BD63F4", Offset = "0x1BD63F4", VA = "0x1BD63F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1BD6560", Offset = "0x1BD6560", VA = "0x1BD6560")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1BCEDFC", Offset = "0x1BCEDFC", VA = "0x1BCEDFC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1BCFA48", Offset = "0x1BCFA48", VA = "0x1BCFA48")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1BD66DC", Offset = "0x1BD66DC", VA = "0x1BD66DC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1BCFBF8", Offset = "0x1BCFBF8", VA = "0x1BCFBF8")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1BD686C", Offset = "0x1BD686C", VA = "0x1BD686C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1BD6BF0", Offset = "0x1BD6BF0", VA = "0x1BD6BF0")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1BD6D48", Offset = "0x1BD6D48", VA = "0x1BD6D48")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1BD6E90", Offset = "0x1BD6E90", VA = "0x1BD6E90")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1BD6FD8", Offset = "0x1BD6FD8", VA = "0x1BD6FD8")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1BCF220", Offset = "0x1BCF220", VA = "0x1BCF220")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1BD7134", Offset = "0x1BD7134", VA = "0x1BD7134")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1BCF5FC", Offset = "0x1BCF5FC", VA = "0x1BCF5FC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1BCF874", Offset = "0x1BCF874", VA = "0x1BCF874")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1BD72E8", Offset = "0x1BD72E8", VA = "0x1BD72E8")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1BD74DC", Offset = "0x1BD74DC", VA = "0x1BD74DC")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1BD76D0", Offset = "0x1BD76D0", VA = "0x1BD76D0")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200000B")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF503C", Offset = "0xCF503C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x1BD950C", Offset = "0x1BD950C", VA = "0x1BD950C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1BD9C9C", Offset = "0x1BD9C9C", VA = "0x1BD9C9C")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1BD9CC0", Offset = "0x1BD9CC0", VA = "0x1BD9CC0")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF504C", Offset = "0xCF504C")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1BD96D4", Offset = "0x1BD96D4", VA = "0x1BD96D4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1BD9CE4", Offset = "0x1BD9CE4", VA = "0x1BD9CE4")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600015F")]
			[Address(RVA = "0x1BD9D08", Offset = "0x1BD9D08", VA = "0x1BD9D08")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF505C", Offset = "0xCF505C")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000091")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1BD9D2C", Offset = "0x1BD9D2C", VA = "0x1BD9D2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1BD9F70", Offset = "0x1BD9F70", VA = "0x1BD9F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF506C", Offset = "0xCF506C")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000092")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000093")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1BDA680", Offset = "0x1BDA680", VA = "0x1BDA680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1BDA8E8", Offset = "0x1BDA8E8", VA = "0x1BDA8E8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF507C", Offset = "0xCF507C")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1BDA1D4", Offset = "0x1BDA1D4", VA = "0x1BDA1D4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1BDA404", Offset = "0x1BDA404", VA = "0x1BDA404", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF508C", Offset = "0xCF508C")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1BD9F7C", Offset = "0x1BD9F7C", VA = "0x1BD9F7C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1BDA1C8", Offset = "0x1BDA1C8", VA = "0x1BDA1C8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF509C", Offset = "0xCF509C")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1BDA410", Offset = "0x1BDA410", VA = "0x1BDA410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000169")]
			[Address(RVA = "0x1BDA674", Offset = "0x1BDA674", VA = "0x1BDA674", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF50AC", Offset = "0xCF50AC")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600016A")]
			[Address(RVA = "0x1BDA8F4", Offset = "0x1BDA8F4", VA = "0x1BDA8F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1BDAB2C", Offset = "0x1BDAB2C", VA = "0x1BDAB2C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1BD8AB0", Offset = "0x1BD8AB0", VA = "0x1BD8AB0")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1BD8C8C", Offset = "0x1BD8C8C", VA = "0x1BD8C8C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1BD8E7C", Offset = "0x1BD8E7C", VA = "0x1BD8E7C")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1BD8F44", Offset = "0x1BD8F44", VA = "0x1BD8F44")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1BD900C", Offset = "0x1BD900C", VA = "0x1BD900C")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1BD90D4", Offset = "0x1BD90D4", VA = "0x1BD90D4")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1BD91AC", Offset = "0x1BD91AC", VA = "0x1BD91AC")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1BD9284", Offset = "0x1BD9284", VA = "0x1BD9284")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1BD934C", Offset = "0x1BD934C", VA = "0x1BD934C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1BD9514", Offset = "0x1BD9514", VA = "0x1BD9514")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1BD96DC", Offset = "0x1BD96DC", VA = "0x1BD96DC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCF566C", Offset = "0xCF566C")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1BD97CC", Offset = "0x1BD97CC", VA = "0x1BD97CC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCF56E0", Offset = "0xCF56E0")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1BD98BC", Offset = "0x1BD98BC", VA = "0x1BD98BC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCF5754", Offset = "0xCF5754")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1BD99AC", Offset = "0x1BD99AC", VA = "0x1BD99AC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCF57C8", Offset = "0xCF57C8")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1BD9AAC", Offset = "0x1BD9AAC", VA = "0x1BD9AAC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCF583C", Offset = "0xCF583C")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1BD9BAC", Offset = "0x1BD9BAC", VA = "0x1BD9BAC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCF58B0", Offset = "0xCF58B0")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200000C")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200005A")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000001")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600016C")]
				[Address(RVA = "0x1BD0FAC", Offset = "0x1BD0FAC", VA = "0x1BD0FAC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1BD0FE0", Offset = "0x1BD0FE0", VA = "0x1BD0FE0")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200005B")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000002")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600016E")]
				[Address(RVA = "0x1BD117C", Offset = "0x1BD117C", VA = "0x1BD117C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1BD11E0", Offset = "0x1BD11E0", VA = "0x1BD11E0")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x200005C")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000003")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000170")]
				[Address(RVA = "0x1BD1094", Offset = "0x1BD1094", VA = "0x1BD1094", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1BD10B0", Offset = "0x1BD10B0", VA = "0x1BD10B0")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200005D")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000004")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000172")]
				[Address(RVA = "0x1BD100C", Offset = "0x1BD100C", VA = "0x1BD100C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1BD1058", Offset = "0x1BD1058", VA = "0x1BD1058")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200005E")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000005")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000174")]
				[Address(RVA = "0x1BD10DC", Offset = "0x1BD10DC", VA = "0x1BD10DC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1BD1140", Offset = "0x1BD1140", VA = "0x1BD1140")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200005F")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000006")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000176")]
				[Address(RVA = "0x1BD120C", Offset = "0x1BD120C", VA = "0x1BD120C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1BD1240", Offset = "0x1BD1240", VA = "0x1BD1240")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200000D")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000060")]
		public static class Physics
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1BDAC7C", Offset = "0x1BDAC7C", VA = "0x1BDAC7C")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1BDAD84", Offset = "0x1BDAD84", VA = "0x1BDAD84")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1BDAE14", Offset = "0x1BDAE14", VA = "0x1BDAE14")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1BDAEA4", Offset = "0x1BDAEA4", VA = "0x1BDAEA4")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1BDAB38", Offset = "0x1BDAB38", VA = "0x1BDAB38")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1BDABDC", Offset = "0x1BDABDC", VA = "0x1BDABDC")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCF4BE4", Offset = "0xCF4BE4")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000061")]
		public enum AnimationType
		{
			[Token(Token = "0x40000B1")]
			None,
			[Token(Token = "0x40000B2")]
			Move,
			[Token(Token = "0x40000B3")]
			LocalMove,
			[Token(Token = "0x40000B4")]
			Rotate,
			[Token(Token = "0x40000B5")]
			LocalRotate,
			[Token(Token = "0x40000B6")]
			Scale,
			[Token(Token = "0x40000B7")]
			Color,
			[Token(Token = "0x40000B8")]
			Fade,
			[Token(Token = "0x40000B9")]
			Text,
			[Token(Token = "0x40000BA")]
			PunchPosition,
			[Token(Token = "0x40000BB")]
			PunchRotation,
			[Token(Token = "0x40000BC")]
			PunchScale,
			[Token(Token = "0x40000BD")]
			ShakePosition,
			[Token(Token = "0x40000BE")]
			ShakeRotation,
			[Token(Token = "0x40000BF")]
			ShakeScale,
			[Token(Token = "0x40000C0")]
			CameraAspect,
			[Token(Token = "0x40000C1")]
			CameraBackgroundColor,
			[Token(Token = "0x40000C2")]
			CameraFieldOfView,
			[Token(Token = "0x40000C3")]
			CameraOrthoSize,
			[Token(Token = "0x40000C4")]
			CameraPixelRect,
			[Token(Token = "0x40000C5")]
			CameraRect,
			[Token(Token = "0x40000C6")]
			UIWidthHeight
		}

		[Token(Token = "0x2000062")]
		public enum TargetType
		{
			[Token(Token = "0x40000C8")]
			Unset,
			[Token(Token = "0x40000C9")]
			Camera,
			[Token(Token = "0x40000CA")]
			CanvasGroup,
			[Token(Token = "0x40000CB")]
			Image,
			[Token(Token = "0x40000CC")]
			Light,
			[Token(Token = "0x40000CD")]
			RectTransform,
			[Token(Token = "0x40000CE")]
			Renderer,
			[Token(Token = "0x40000CF")]
			SpriteRenderer,
			[Token(Token = "0x40000D0")]
			Rigidbody,
			[Token(Token = "0x40000D1")]
			Rigidbody2D,
			[Token(Token = "0x40000D2")]
			Text,
			[Token(Token = "0x40000D3")]
			Transform,
			[Token(Token = "0x40000D4")]
			tk2dBaseSprite,
			[Token(Token = "0x40000D5")]
			tk2dTextMesh,
			[Token(Token = "0x40000D6")]
			TextMeshPro,
			[Token(Token = "0x40000D7")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x1BCCB5C", Offset = "0x1BCCB5C", VA = "0x1BCCB5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF5944", Offset = "0xCF5944")]
			add
			{
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x1BCCC10", Offset = "0x1BCCC10", VA = "0x1BCCC10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF5954", Offset = "0xCF5954")]
			remove
			{
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1BCCCC4", Offset = "0x1BCCCC4", VA = "0x1BCCCC4")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1BCCD38", Offset = "0x1BCCD38", VA = "0x1BCCD38")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1BCE208", Offset = "0x1BCE208", VA = "0x1BCE208")]
		private void Start()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1BCE24C", Offset = "0x1BCE24C", VA = "0x1BCE24C")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1BCE250", Offset = "0x1BCE250", VA = "0x1BCE250")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1BCCD88", Offset = "0x1BCCD88", VA = "0x1BCCD88")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1BCFDC4", Offset = "0x1BCFDC4", VA = "0x1BCFDC4", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1BCFE40", Offset = "0x1BCFE40", VA = "0x1BCFE40", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1BCFEBC", Offset = "0x1BCFEBC", VA = "0x1BCFEBC", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1BCFF38", Offset = "0x1BCFF38", VA = "0x1BCFF38", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1BCFFB4", Offset = "0x1BCFFB4", VA = "0x1BCFFB4", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1BD0030", Offset = "0x1BD0030", VA = "0x1BD0030", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1BD012C", Offset = "0x1BD012C", VA = "0x1BD012C", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1BD013C", Offset = "0x1BD013C", VA = "0x1BD013C", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1BD04F0", Offset = "0x1BD04F0", VA = "0x1BD04F0", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1BD0570", Offset = "0x1BD0570", VA = "0x1BD0570", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1BD05F8", Offset = "0x1BD05F8", VA = "0x1BD05F8")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1BD0684", Offset = "0x1BD0684", VA = "0x1BD0684")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1BD06EC", Offset = "0x1BD06EC", VA = "0x1BD06EC")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1BD0754", Offset = "0x1BD0754", VA = "0x1BD0754")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1BD07E0", Offset = "0x1BD07E0", VA = "0x1BD07E0")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1BD0848", Offset = "0x1BD0848", VA = "0x1BD0848")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1BD08D4", Offset = "0x1BD08D4", VA = "0x1BD08D4")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1BD093C", Offset = "0x1BD093C", VA = "0x1BD093C")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1BD0A70", Offset = "0x1BD0A70", VA = "0x1BD0A70")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1BD0B00", Offset = "0x1BD0B00", VA = "0x1BD0B00")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1BD0B80", Offset = "0x1BD0B80", VA = "0x1BD0B80")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1BD0C1C", Offset = "0x1BD0C1C", VA = "0x1BD0C1C")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1BD0CA0", Offset = "0x1BD0CA0", VA = "0x1BD0CA0")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1BCE2AC", Offset = "0x1BCE2AC", VA = "0x1BCE2AC")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1BD0D8C", Offset = "0x1BD0D8C", VA = "0x1BD0D8C")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1BCE294", Offset = "0x1BCE294", VA = "0x1BCE294")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1BD0258", Offset = "0x1BD0258", VA = "0x1BD0258")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1BD0DC8", Offset = "0x1BD0DC8", VA = "0x1BD0DC8")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1BD0FA4", Offset = "0x1BD0FA4", VA = "0x1BD0FA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF5964", Offset = "0xCF5964")]
		private void <CreateTween>b__47_0()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x6000096")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000010")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF50BC", Offset = "0xCF50BC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1BDB34C", Offset = "0x1BDB34C", VA = "0x1BDB34C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1BDB678", Offset = "0x1BDB678", VA = "0x1BDB678")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1BDB694", Offset = "0x1BDB694", VA = "0x1BDB694")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF50CC", Offset = "0xCF50CC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1BDB670", Offset = "0x1BDB670", VA = "0x1BDB670")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1BDB6B0", Offset = "0x1BDB6B0", VA = "0x1BDB6B0")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1BDAFEC", Offset = "0x1BDAFEC", VA = "0x1BDAFEC")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1BDB03C", Offset = "0x1BDB03C", VA = "0x1BDB03C")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1BDB354", Offset = "0x1BDB354", VA = "0x1BDB354")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
