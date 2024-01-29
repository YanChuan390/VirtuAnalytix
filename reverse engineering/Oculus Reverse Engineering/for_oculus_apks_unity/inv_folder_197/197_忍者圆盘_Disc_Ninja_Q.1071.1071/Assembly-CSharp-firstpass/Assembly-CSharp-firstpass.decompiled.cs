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
	[Address(RVA = "0x1B89CC4", Offset = "0x1B89CC4", VA = "0x1B89CC4")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam, bool faceCameraDirection = true)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1B8A4E8", Offset = "0x1B8A4E8", VA = "0x1B8A4E8")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1B8A430", Offset = "0x1B8A430", VA = "0x1B8A430")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1B8A5A4", Offset = "0x1B8A5A4", VA = "0x1B8A5A4")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1B8AED8", Offset = "0x1B8AED8", VA = "0x1B8AED8")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1B8AD1C", Offset = "0x1B8AD1C", VA = "0x1B8AD1C")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1B8AE90", Offset = "0x1B8AE90", VA = "0x1B8AE90")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1B8A990", Offset = "0x1B8A990", VA = "0x1B8A990")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1B8AFBC", Offset = "0x1B8AFBC", VA = "0x1B8AFBC")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1B8B30C", Offset = "0x1B8B30C", VA = "0x1B8B30C")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1B8B1FC", Offset = "0x1B8B1FC", VA = "0x1B8B1FC")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1B8B404", Offset = "0x1B8B404", VA = "0x1B8B404")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCAB5F8", Offset = "0xCAB5F8")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1B8B498", Offset = "0x1B8B498", VA = "0x1B8B498")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCAB60C", Offset = "0xCAB60C")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1B8B4A0", Offset = "0x1B8B4A0", VA = "0x1B8B4A0")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCAB620", Offset = "0xCAB620")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1B8B4A8", Offset = "0x1B8B4A8", VA = "0x1B8B4A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB6EC", Offset = "0xCAB6EC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1B7F9C8", Offset = "0x1B7F9C8", VA = "0x1B7F9C8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1B80188", Offset = "0x1B80188", VA = "0x1B80188")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x1B801A4", Offset = "0x1B801A4", VA = "0x1B801A4")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB6FC", Offset = "0xCAB6FC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1B7FB0C", Offset = "0x1B7FB0C", VA = "0x1B7FB0C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x1B801C0", Offset = "0x1B801C0", VA = "0x1B801C0")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1B801DC", Offset = "0x1B801DC", VA = "0x1B801DC")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB70C", Offset = "0xCAB70C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1B7FC54", Offset = "0x1B7FC54", VA = "0x1B7FC54")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1B801F8", Offset = "0x1B801F8", VA = "0x1B801F8")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x1B80238", Offset = "0x1B80238", VA = "0x1B80238")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1B7F864", Offset = "0x1B7F864", VA = "0x1B7F864")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1B7F9D0", Offset = "0x1B7F9D0", VA = "0x1B7F9D0")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1B7FB14", Offset = "0x1B7FB14", VA = "0x1B7FB14")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1B7FC5C", Offset = "0x1B7FC5C", VA = "0x1B7FC5C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1B7FCD4", Offset = "0x1B7FCD4", VA = "0x1B7FCD4")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1B7FD4C", Offset = "0x1B7FD4C", VA = "0x1B7FD4C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1B7FDB4", Offset = "0x1B7FDB4", VA = "0x1B7FDB4")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1B7FE3C", Offset = "0x1B7FE3C", VA = "0x1B7FE3C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1B7FEA4", Offset = "0x1B7FEA4", VA = "0x1B7FEA4")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1B7FF0C", Offset = "0x1B7FF0C", VA = "0x1B7FF0C")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1B7FF74", Offset = "0x1B7FF74", VA = "0x1B7FF74")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1B7FFDC", Offset = "0x1B7FFDC", VA = "0x1B7FFDC")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1B8004C", Offset = "0x1B8004C", VA = "0x1B8004C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1B800B8", Offset = "0x1B800B8", VA = "0x1B800B8")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1B80120", Offset = "0x1B80120", VA = "0x1B80120")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000007")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB71C", Offset = "0xCAB71C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1B8025C", Offset = "0x1B8025C", VA = "0x1B8025C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x1B8148C", Offset = "0x1B8148C", VA = "0x1B8148C")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB72C", Offset = "0xCAB72C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1B803EC", Offset = "0x1B803EC", VA = "0x1B803EC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1B815C8", Offset = "0x1B815C8", VA = "0x1B815C8")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB73C", Offset = "0xCAB73C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1B8057C", Offset = "0x1B8057C", VA = "0x1B8057C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1B815E4", Offset = "0x1B815E4", VA = "0x1B815E4")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB74C", Offset = "0xCAB74C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1B8070C", Offset = "0x1B8070C", VA = "0x1B8070C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x1B81600", Offset = "0x1B81600", VA = "0x1B81600")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB75C", Offset = "0xCAB75C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x1B80714", Offset = "0x1B80714", VA = "0x1B80714")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1B8161C", Offset = "0x1B8161C", VA = "0x1B8161C")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB76C", Offset = "0xCAB76C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x1B80900", Offset = "0x1B80900", VA = "0x1B80900")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x1B81638", Offset = "0x1B81638", VA = "0x1B81638")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB77C", Offset = "0xCAB77C")]
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
			[Address(RVA = "0x1B80D7C", Offset = "0x1B80D7C", VA = "0x1B80D7C")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1B81654", Offset = "0x1B81654", VA = "0x1B81654")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1B81670", Offset = "0x1B81670", VA = "0x1B81670")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1B816A4", Offset = "0x1B816A4", VA = "0x1B816A4")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1B816C0", Offset = "0x1B816C0", VA = "0x1B816C0")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1B816DC", Offset = "0x1B816DC", VA = "0x1B816DC")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB78C", Offset = "0xCAB78C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x1B80F70", Offset = "0x1B80F70", VA = "0x1B80F70")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1B8179C", Offset = "0x1B8179C", VA = "0x1B8179C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB79C", Offset = "0xCAB79C")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x1B81178", Offset = "0x1B81178", VA = "0x1B81178")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x1B817B8", Offset = "0x1B817B8", VA = "0x1B817B8")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1B817D4", Offset = "0x1B817D4", VA = "0x1B817D4")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB7AC", Offset = "0xCAB7AC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1B812F8", Offset = "0x1B812F8", VA = "0x1B812F8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1B818D8", Offset = "0x1B818D8", VA = "0x1B818D8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB7BC", Offset = "0xCAB7BC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1B81484", Offset = "0x1B81484", VA = "0x1B81484")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1B814A8", Offset = "0x1B814A8", VA = "0x1B814A8")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x1B814C4", Offset = "0x1B814C4", VA = "0x1B814C4")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1B7CE70", Offset = "0x1B7CE70", VA = "0x1B7CE70")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1B80264", Offset = "0x1B80264", VA = "0x1B80264")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1B803F4", Offset = "0x1B803F4", VA = "0x1B803F4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1B80584", Offset = "0x1B80584", VA = "0x1B80584")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1B7D148", Offset = "0x1B7D148", VA = "0x1B7D148")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1B8071C", Offset = "0x1B8071C", VA = "0x1B8071C")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1B80908", Offset = "0x1B80908", VA = "0x1B80908")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1B80D84", Offset = "0x1B80D84", VA = "0x1B80D84")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1B80F78", Offset = "0x1B80F78", VA = "0x1B80F78")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1B81180", Offset = "0x1B81180", VA = "0x1B81180")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1B81300", Offset = "0x1B81300", VA = "0x1B81300")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000008")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB7CC", Offset = "0xCAB7CC")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1B818F4", Offset = "0x1B818F4", VA = "0x1B818F4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1B824F4", Offset = "0x1B824F4", VA = "0x1B824F4")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB7DC", Offset = "0xCAB7DC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1B81A70", Offset = "0x1B81A70", VA = "0x1B81A70")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x1B82510", Offset = "0x1B82510", VA = "0x1B82510")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB7EC", Offset = "0xCAB7EC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1B81BEC", Offset = "0x1B81BEC", VA = "0x1B81BEC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1B8252C", Offset = "0x1B8252C", VA = "0x1B8252C")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB7FC", Offset = "0xCAB7FC")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1B81BF4", Offset = "0x1B81BF4", VA = "0x1B81BF4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1B82548", Offset = "0x1B82548", VA = "0x1B82548")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB80C", Offset = "0xCAB80C")]
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
			[Address(RVA = "0x1B81F74", Offset = "0x1B81F74", VA = "0x1B81F74")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1B82564", Offset = "0x1B82564", VA = "0x1B82564")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1B82580", Offset = "0x1B82580", VA = "0x1B82580")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x1B8259C", Offset = "0x1B8259C", VA = "0x1B8259C")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x1B825D0", Offset = "0x1B825D0", VA = "0x1B825D0")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1B825EC", Offset = "0x1B825EC", VA = "0x1B825EC")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1B82608", Offset = "0x1B82608", VA = "0x1B82608")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB81C", Offset = "0xCAB81C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1B82228", Offset = "0x1B82228", VA = "0x1B82228")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1B82730", Offset = "0x1B82730", VA = "0x1B82730")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1B827C0", Offset = "0x1B827C0", VA = "0x1B827C0")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB82C", Offset = "0xCAB82C")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x1B824EC", Offset = "0x1B824EC", VA = "0x1B824EC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1B82864", Offset = "0x1B82864", VA = "0x1B82864")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1B82880", Offset = "0x1B82880", VA = "0x1B82880")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1B7CFE0", Offset = "0x1B7CFE0", VA = "0x1B7CFE0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1B818FC", Offset = "0x1B818FC", VA = "0x1B818FC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1B81A78", Offset = "0x1B81A78", VA = "0x1B81A78")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1B7D2B4", Offset = "0x1B7D2B4", VA = "0x1B7D2B4")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1B81BFC", Offset = "0x1B81BFC", VA = "0x1B81BFC")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1B81F7C", Offset = "0x1B81F7C", VA = "0x1B81F7C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1B82230", Offset = "0x1B82230", VA = "0x1B82230")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x2000009")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB83C", Offset = "0xCAB83C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1B829AC", Offset = "0x1B829AC", VA = "0x1B829AC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1B82D80", Offset = "0x1B82D80", VA = "0x1B82D80")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1B82D9C", Offset = "0x1B82D9C", VA = "0x1B82D9C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB84C", Offset = "0xCAB84C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x1B829B4", Offset = "0x1B829B4", VA = "0x1B829B4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1B82DB8", Offset = "0x1B82DB8", VA = "0x1B82DB8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1B82DD4", Offset = "0x1B82DD4", VA = "0x1B82DD4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB85C", Offset = "0xCAB85C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x1B82D78", Offset = "0x1B82D78", VA = "0x1B82D78")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1B82DF0", Offset = "0x1B82DF0", VA = "0x1B82DF0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x1B82DFC", Offset = "0x1B82DFC", VA = "0x1B82DFC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1B7D550", Offset = "0x1B7D550", VA = "0x1B7D550")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1B7D97C", Offset = "0x1B7D97C", VA = "0x1B7D97C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1B829BC", Offset = "0x1B829BC", VA = "0x1B829BC")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1B82B94", Offset = "0x1B82B94", VA = "0x1B82B94")]
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
			[Address(RVA = "0x1B7CA60", Offset = "0x1B7CA60", VA = "0x1B7CA60")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB86C", Offset = "0xCAB86C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x1B82EA8", Offset = "0x1B82EA8", VA = "0x1B82EA8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x1B85EBC", Offset = "0x1B85EBC", VA = "0x1B85EBC")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1B85ED8", Offset = "0x1B85ED8", VA = "0x1B85ED8")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB87C", Offset = "0xCAB87C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x1B82EB0", Offset = "0x1B82EB0", VA = "0x1B82EB0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x1B8612C", Offset = "0x1B8612C", VA = "0x1B8612C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x1B86150", Offset = "0x1B86150", VA = "0x1B86150")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB88C", Offset = "0xCAB88C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1B82EB8", Offset = "0x1B82EB8", VA = "0x1B82EB8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1B867B8", Offset = "0x1B867B8", VA = "0x1B867B8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1B867DC", Offset = "0x1B867DC", VA = "0x1B867DC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB89C", Offset = "0xCAB89C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1B83024", Offset = "0x1B83024", VA = "0x1B83024")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1B86C84", Offset = "0x1B86C84", VA = "0x1B86C84")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1B86CA8", Offset = "0x1B86CA8", VA = "0x1B86CA8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB8AC", Offset = "0xCAB8AC")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1B83168", Offset = "0x1B83168", VA = "0x1B83168")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1B86D94", Offset = "0x1B86D94", VA = "0x1B86D94")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1B86DB8", Offset = "0x1B86DB8", VA = "0x1B86DB8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB8BC", Offset = "0xCAB8BC")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1B832D0", Offset = "0x1B832D0", VA = "0x1B832D0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1B86DDC", Offset = "0x1B86DDC", VA = "0x1B86DDC")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1B86DF8", Offset = "0x1B86DF8", VA = "0x1B86DF8")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB8CC", Offset = "0xCAB8CC")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1B83614", Offset = "0x1B83614", VA = "0x1B83614")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1B86E14", Offset = "0x1B86E14", VA = "0x1B86E14")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x1B86E94", Offset = "0x1B86E94", VA = "0x1B86E94")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB8DC", Offset = "0xCAB8DC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1B83778", Offset = "0x1B83778", VA = "0x1B83778")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1B86EF0", Offset = "0x1B86EF0", VA = "0x1B86EF0")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1B86F70", Offset = "0x1B86F70", VA = "0x1B86F70")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB8EC", Offset = "0xCAB8EC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1B838DC", Offset = "0x1B838DC", VA = "0x1B838DC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1B86FCC", Offset = "0x1B86FCC", VA = "0x1B86FCC")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1B8704C", Offset = "0x1B8704C", VA = "0x1B8704C")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB8FC", Offset = "0xCAB8FC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1B83A48", Offset = "0x1B83A48", VA = "0x1B83A48")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1B85EF4", Offset = "0x1B85EF4", VA = "0x1B85EF4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1B85F14", Offset = "0x1B85F14", VA = "0x1B85F14")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB90C", Offset = "0xCAB90C")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1B83B8C", Offset = "0x1B83B8C", VA = "0x1B83B8C")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1B85F30", Offset = "0x1B85F30", VA = "0x1B85F30")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1B85F50", Offset = "0x1B85F50", VA = "0x1B85F50")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000035")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB91C", Offset = "0xCAB91C")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x1B83CE0", Offset = "0x1B83CE0", VA = "0x1B83CE0")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1B85F6C", Offset = "0x1B85F6C", VA = "0x1B85F6C")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1B85F88", Offset = "0x1B85F88", VA = "0x1B85F88")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB92C", Offset = "0xCAB92C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1B83E44", Offset = "0x1B83E44", VA = "0x1B83E44")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1B85FA4", Offset = "0x1B85FA4", VA = "0x1B85FA4")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x1B85FC0", Offset = "0x1B85FC0", VA = "0x1B85FC0")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000037")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB93C", Offset = "0xCAB93C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x1B83FBC", Offset = "0x1B83FBC", VA = "0x1B83FBC")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0x1B85FDC", Offset = "0x1B85FDC", VA = "0x1B85FDC")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000107")]
			[Address(RVA = "0x1B85FF8", Offset = "0x1B85FF8", VA = "0x1B85FF8")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB94C", Offset = "0xCAB94C")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1B84134", Offset = "0x1B84134", VA = "0x1B84134")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000109")]
			[Address(RVA = "0x1B86014", Offset = "0x1B86014", VA = "0x1B86014")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0x1B86030", Offset = "0x1B86030", VA = "0x1B86030")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000039")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB95C", Offset = "0xCAB95C")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1B8413C", Offset = "0x1B8413C", VA = "0x1B8413C")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1B8604C", Offset = "0x1B8604C", VA = "0x1B8604C")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1B86068", Offset = "0x1B86068", VA = "0x1B86068")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB96C", Offset = "0xCAB96C")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1B842C0", Offset = "0x1B842C0", VA = "0x1B842C0")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1B86084", Offset = "0x1B86084", VA = "0x1B86084")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1B860A0", Offset = "0x1B860A0", VA = "0x1B860A0")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB97C", Offset = "0xCAB97C")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1B84444", Offset = "0x1B84444", VA = "0x1B84444")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1B860BC", Offset = "0x1B860BC", VA = "0x1B860BC")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1B860D8", Offset = "0x1B860D8", VA = "0x1B860D8")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB98C", Offset = "0xCAB98C")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1B845C8", Offset = "0x1B845C8", VA = "0x1B845C8")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1B860F4", Offset = "0x1B860F4", VA = "0x1B860F4")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0x1B86110", Offset = "0x1B86110", VA = "0x1B86110")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB99C", Offset = "0xCAB99C")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x1B8472C", Offset = "0x1B8472C", VA = "0x1B8472C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x1B86174", Offset = "0x1B86174", VA = "0x1B86174")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0x1B86190", Offset = "0x1B86190", VA = "0x1B86190")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200003E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB9AC", Offset = "0xCAB9AC")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x1B84890", Offset = "0x1B84890", VA = "0x1B84890")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1B861AC", Offset = "0x1B861AC", VA = "0x1B861AC")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1B861C8", Offset = "0x1B861C8", VA = "0x1B861C8")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200003F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB9BC", Offset = "0xCAB9BC")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1B849E4", Offset = "0x1B849E4", VA = "0x1B849E4")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x1B861E4", Offset = "0x1B861E4", VA = "0x1B861E4")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1B86200", Offset = "0x1B86200", VA = "0x1B86200")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB9CC", Offset = "0xCAB9CC")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1B84B50", Offset = "0x1B84B50", VA = "0x1B84B50")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000121")]
			[Address(RVA = "0x1B8621C", Offset = "0x1B8621C", VA = "0x1B8621C")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000122")]
			[Address(RVA = "0x1B86238", Offset = "0x1B86238", VA = "0x1B86238")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB9DC", Offset = "0xCAB9DC")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000123")]
			[Address(RVA = "0x1B84CBC", Offset = "0x1B84CBC", VA = "0x1B84CBC")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1B86254", Offset = "0x1B86254", VA = "0x1B86254")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1B86270", Offset = "0x1B86270", VA = "0x1B86270")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB9EC", Offset = "0xCAB9EC")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1B84CC4", Offset = "0x1B84CC4", VA = "0x1B84CC4")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1B8628C", Offset = "0x1B8628C", VA = "0x1B8628C")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1B862A8", Offset = "0x1B862A8", VA = "0x1B862A8")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAB9FC", Offset = "0xCAB9FC")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1B84CCC", Offset = "0x1B84CCC", VA = "0x1B84CCC")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1B862C4", Offset = "0x1B862C4", VA = "0x1B862C4")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1B86354", Offset = "0x1B86354", VA = "0x1B86354")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA0C", Offset = "0xCABA0C")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1B84E54", Offset = "0x1B84E54", VA = "0x1B84E54")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1B863F8", Offset = "0x1B863F8", VA = "0x1B863F8")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1B86488", Offset = "0x1B86488", VA = "0x1B86488")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA1C", Offset = "0xCABA1C")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600012F")]
			[Address(RVA = "0x1B84E5C", Offset = "0x1B84E5C", VA = "0x1B84E5C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000130")]
			[Address(RVA = "0x1B8652C", Offset = "0x1B8652C", VA = "0x1B8652C")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1B865BC", Offset = "0x1B865BC", VA = "0x1B865BC")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA2C", Offset = "0xCABA2C")]
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
			[Address(RVA = "0x1B851E0", Offset = "0x1B851E0", VA = "0x1B851E0")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1B86660", Offset = "0x1B86660", VA = "0x1B86660")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x1B8667C", Offset = "0x1B8667C", VA = "0x1B8667C")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1B86698", Offset = "0x1B86698", VA = "0x1B86698")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1B866CC", Offset = "0x1B866CC", VA = "0x1B866CC")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1B866E8", Offset = "0x1B866E8", VA = "0x1B866E8")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1B86704", Offset = "0x1B86704", VA = "0x1B86704")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA3C", Offset = "0xCABA3C")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1B85338", Offset = "0x1B85338", VA = "0x1B85338")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1B86800", Offset = "0x1B86800", VA = "0x1B86800")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1B86870", Offset = "0x1B86870", VA = "0x1B86870")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA4C", Offset = "0xCABA4C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1B85480", Offset = "0x1B85480", VA = "0x1B85480")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x600013D")]
			[Address(RVA = "0x1B868BC", Offset = "0x1B868BC", VA = "0x1B868BC")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1B868D8", Offset = "0x1B868D8", VA = "0x1B868D8")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000049")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA5C", Offset = "0xCABA5C")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1B855C8", Offset = "0x1B855C8", VA = "0x1B855C8")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1B868F4", Offset = "0x1B868F4", VA = "0x1B868F4")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1B86910", Offset = "0x1B86910", VA = "0x1B86910")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA6C", Offset = "0xCABA6C")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1B8571C", Offset = "0x1B8571C", VA = "0x1B8571C")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1B8692C", Offset = "0x1B8692C", VA = "0x1B8692C")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1B86950", Offset = "0x1B86950", VA = "0x1B86950")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA7C", Offset = "0xCABA7C")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1B85724", Offset = "0x1B85724", VA = "0x1B85724")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0x1B86974", Offset = "0x1B86974", VA = "0x1B86974")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1B86998", Offset = "0x1B86998", VA = "0x1B86998")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA8C", Offset = "0xCABA8C")]
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
			[Address(RVA = "0x1B858C8", Offset = "0x1B858C8", VA = "0x1B858C8")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1B869BC", Offset = "0x1B869BC", VA = "0x1B869BC")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1B869C4", Offset = "0x1B869C4", VA = "0x1B869C4")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200004D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABA9C", Offset = "0xCABA9C")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1B858D0", Offset = "0x1B858D0", VA = "0x1B858D0")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x1B86A64", Offset = "0x1B86A64", VA = "0x1B86A64")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x1B86A88", Offset = "0x1B86A88", VA = "0x1B86A88")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200004E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABAAC", Offset = "0xCABAAC")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1B858D8", Offset = "0x1B858D8", VA = "0x1B858D8")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1B86AAC", Offset = "0x1B86AAC", VA = "0x1B86AAC")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1B86AD0", Offset = "0x1B86AD0", VA = "0x1B86AD0")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x200004F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABABC", Offset = "0xCABABC")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1B85ACC", Offset = "0x1B85ACC", VA = "0x1B85ACC")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1B86AF4", Offset = "0x1B86AF4", VA = "0x1B86AF4")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1B86B00", Offset = "0x1B86B00", VA = "0x1B86B00")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABACC", Offset = "0xCABACC")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1B85CC0", Offset = "0x1B85CC0", VA = "0x1B85CC0")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1B86BBC", Offset = "0x1B86BBC", VA = "0x1B86BBC")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1B86BC8", Offset = "0x1B86BC8", VA = "0x1B86BC8")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000051")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABADC", Offset = "0xCABADC")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1B85EB4", Offset = "0x1B85EB4", VA = "0x1B85EB4")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1B86CCC", Offset = "0x1B86CCC", VA = "0x1B86CCC")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1B86CD8", Offset = "0x1B86CD8", VA = "0x1B86CD8")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1B7DD30", Offset = "0x1B7DD30", VA = "0x1B7DD30")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1B7D6B4", Offset = "0x1B7D6B4", VA = "0x1B7D6B4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1B7DAB8", Offset = "0x1B7DAB8", VA = "0x1B7DAB8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1B82EC0", Offset = "0x1B82EC0", VA = "0x1B82EC0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1B8302C", Offset = "0x1B8302C", VA = "0x1B8302C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1B83170", Offset = "0x1B83170", VA = "0x1B83170")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1B832D8", Offset = "0x1B832D8", VA = "0x1B832D8")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1B834B8", Offset = "0x1B834B8", VA = "0x1B834B8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1B8361C", Offset = "0x1B8361C", VA = "0x1B8361C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1B83780", Offset = "0x1B83780", VA = "0x1B83780")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1B838E4", Offset = "0x1B838E4", VA = "0x1B838E4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1B83A50", Offset = "0x1B83A50", VA = "0x1B83A50")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1B83B94", Offset = "0x1B83B94", VA = "0x1B83B94")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1B83CE8", Offset = "0x1B83CE8", VA = "0x1B83CE8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1B83E4C", Offset = "0x1B83E4C", VA = "0x1B83E4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1B83FC4", Offset = "0x1B83FC4", VA = "0x1B83FC4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1B7CD0C", Offset = "0x1B7CD0C", VA = "0x1B7CD0C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1B84144", Offset = "0x1B84144", VA = "0x1B84144")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1B842C8", Offset = "0x1B842C8", VA = "0x1B842C8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1B8444C", Offset = "0x1B8444C", VA = "0x1B8444C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1B845D0", Offset = "0x1B845D0", VA = "0x1B845D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1B84734", Offset = "0x1B84734", VA = "0x1B84734")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1B84898", Offset = "0x1B84898", VA = "0x1B84898")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1B849EC", Offset = "0x1B849EC", VA = "0x1B849EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1B84B58", Offset = "0x1B84B58", VA = "0x1B84B58")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1B7D3F4", Offset = "0x1B7D3F4", VA = "0x1B7D3F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1B7E040", Offset = "0x1B7E040", VA = "0x1B7E040")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1B84CD4", Offset = "0x1B84CD4", VA = "0x1B84CD4")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1B7E1F0", Offset = "0x1B7E1F0", VA = "0x1B7E1F0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1B84E64", Offset = "0x1B84E64", VA = "0x1B84E64")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1B851E8", Offset = "0x1B851E8", VA = "0x1B851E8")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1B85340", Offset = "0x1B85340", VA = "0x1B85340")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1B85488", Offset = "0x1B85488", VA = "0x1B85488")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1B855D0", Offset = "0x1B855D0", VA = "0x1B855D0")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1B7D818", Offset = "0x1B7D818", VA = "0x1B7D818")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1B8572C", Offset = "0x1B8572C", VA = "0x1B8572C")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1B7DBF4", Offset = "0x1B7DBF4", VA = "0x1B7DBF4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1B7DE6C", Offset = "0x1B7DE6C", VA = "0x1B7DE6C")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1B858E0", Offset = "0x1B858E0", VA = "0x1B858E0")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1B85AD4", Offset = "0x1B85AD4", VA = "0x1B85AD4")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1B85CC8", Offset = "0x1B85CC8", VA = "0x1B85CC8")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200000B")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABAEC", Offset = "0xCABAEC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600015A")]
			[Address(RVA = "0x1B87B04", Offset = "0x1B87B04", VA = "0x1B87B04")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x1B88294", Offset = "0x1B88294", VA = "0x1B88294")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600015C")]
			[Address(RVA = "0x1B882B8", Offset = "0x1B882B8", VA = "0x1B882B8")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000053")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABAFC", Offset = "0xCABAFC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x1B87CCC", Offset = "0x1B87CCC", VA = "0x1B87CCC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1B882DC", Offset = "0x1B882DC", VA = "0x1B882DC")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600015F")]
			[Address(RVA = "0x1B88300", Offset = "0x1B88300", VA = "0x1B88300")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000054")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABB0C", Offset = "0xCABB0C")]
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
			[Address(RVA = "0x1B88324", Offset = "0x1B88324", VA = "0x1B88324", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1B88568", Offset = "0x1B88568", VA = "0x1B88568", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABB1C", Offset = "0xCABB1C")]
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
			[Address(RVA = "0x1B88C78", Offset = "0x1B88C78", VA = "0x1B88C78", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1B88EE0", Offset = "0x1B88EE0", VA = "0x1B88EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000056")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABB2C", Offset = "0xCABB2C")]
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
			[Address(RVA = "0x1B887CC", Offset = "0x1B887CC", VA = "0x1B887CC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1B889FC", Offset = "0x1B889FC", VA = "0x1B889FC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABB3C", Offset = "0xCABB3C")]
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
			[Address(RVA = "0x1B88574", Offset = "0x1B88574", VA = "0x1B88574", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1B887C0", Offset = "0x1B887C0", VA = "0x1B887C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABB4C", Offset = "0xCABB4C")]
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
			[Address(RVA = "0x1B88A08", Offset = "0x1B88A08", VA = "0x1B88A08", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000169")]
			[Address(RVA = "0x1B88C6C", Offset = "0x1B88C6C", VA = "0x1B88C6C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000059")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABB5C", Offset = "0xCABB5C")]
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
			[Address(RVA = "0x1B88EEC", Offset = "0x1B88EEC", VA = "0x1B88EEC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1B89124", Offset = "0x1B89124", VA = "0x1B89124", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1B870A8", Offset = "0x1B870A8", VA = "0x1B870A8")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1B87284", Offset = "0x1B87284", VA = "0x1B87284")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1B87474", Offset = "0x1B87474", VA = "0x1B87474")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1B8753C", Offset = "0x1B8753C", VA = "0x1B8753C")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1B87604", Offset = "0x1B87604", VA = "0x1B87604")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1B876CC", Offset = "0x1B876CC", VA = "0x1B876CC")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1B877A4", Offset = "0x1B877A4", VA = "0x1B877A4")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1B8787C", Offset = "0x1B8787C", VA = "0x1B8787C")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1B87944", Offset = "0x1B87944", VA = "0x1B87944")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1B87B0C", Offset = "0x1B87B0C", VA = "0x1B87B0C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1B87CD4", Offset = "0x1B87CD4", VA = "0x1B87CD4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCAC11C", Offset = "0xCAC11C")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1B87DC4", Offset = "0x1B87DC4", VA = "0x1B87DC4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCAC190", Offset = "0xCAC190")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1B87EB4", Offset = "0x1B87EB4", VA = "0x1B87EB4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCAC204", Offset = "0xCAC204")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1B87FA4", Offset = "0x1B87FA4", VA = "0x1B87FA4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCAC278", Offset = "0xCAC278")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1B880A4", Offset = "0x1B880A4", VA = "0x1B880A4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCAC2EC", Offset = "0xCAC2EC")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1B881A4", Offset = "0x1B881A4", VA = "0x1B881A4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xCAC360", Offset = "0xCAC360")]
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
				[Address(RVA = "0x1B7F5A4", Offset = "0x1B7F5A4", VA = "0x1B7F5A4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1B7F5D8", Offset = "0x1B7F5D8", VA = "0x1B7F5D8")]
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
				[Address(RVA = "0x1B7F774", Offset = "0x1B7F774", VA = "0x1B7F774", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1B7F7D8", Offset = "0x1B7F7D8", VA = "0x1B7F7D8")]
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
				[Address(RVA = "0x1B7F68C", Offset = "0x1B7F68C", VA = "0x1B7F68C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1B7F6A8", Offset = "0x1B7F6A8", VA = "0x1B7F6A8")]
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
				[Address(RVA = "0x1B7F604", Offset = "0x1B7F604", VA = "0x1B7F604", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1B7F650", Offset = "0x1B7F650", VA = "0x1B7F650")]
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
				[Address(RVA = "0x1B7F6D4", Offset = "0x1B7F6D4", VA = "0x1B7F6D4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1B7F738", Offset = "0x1B7F738", VA = "0x1B7F738")]
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
				[Address(RVA = "0x1B7F804", Offset = "0x1B7F804", VA = "0x1B7F804", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1B7F838", Offset = "0x1B7F838", VA = "0x1B7F838")]
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
			[Address(RVA = "0x1B89274", Offset = "0x1B89274", VA = "0x1B89274")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1B8937C", Offset = "0x1B8937C", VA = "0x1B8937C")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1B8940C", Offset = "0x1B8940C", VA = "0x1B8940C")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1B8949C", Offset = "0x1B8949C", VA = "0x1B8949C")]
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
		[Address(RVA = "0x1B89130", Offset = "0x1B89130", VA = "0x1B89130")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1B891D4", Offset = "0x1B891D4", VA = "0x1B891D4")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCAB694", Offset = "0xCAB694")]
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
			[Address(RVA = "0x1B7B154", Offset = "0x1B7B154", VA = "0x1B7B154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAC3F4", Offset = "0xCAC3F4")]
			add
			{
			}
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x1B7B208", Offset = "0x1B7B208", VA = "0x1B7B208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAC404", Offset = "0xCAC404")]
			remove
			{
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1B7B2BC", Offset = "0x1B7B2BC", VA = "0x1B7B2BC")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1B7B330", Offset = "0x1B7B330", VA = "0x1B7B330")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1B7C800", Offset = "0x1B7C800", VA = "0x1B7C800")]
		private void Start()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1B7C844", Offset = "0x1B7C844", VA = "0x1B7C844")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1B7C848", Offset = "0x1B7C848", VA = "0x1B7C848")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1B7B380", Offset = "0x1B7B380", VA = "0x1B7B380")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1B7E3BC", Offset = "0x1B7E3BC", VA = "0x1B7E3BC", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1B7E438", Offset = "0x1B7E438", VA = "0x1B7E438", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1B7E4B4", Offset = "0x1B7E4B4", VA = "0x1B7E4B4", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1B7E530", Offset = "0x1B7E530", VA = "0x1B7E530", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1B7E5AC", Offset = "0x1B7E5AC", VA = "0x1B7E5AC", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1B7E628", Offset = "0x1B7E628", VA = "0x1B7E628", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1B7E724", Offset = "0x1B7E724", VA = "0x1B7E724", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1B7E734", Offset = "0x1B7E734", VA = "0x1B7E734", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1B7EAE8", Offset = "0x1B7EAE8", VA = "0x1B7EAE8", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1B7EB68", Offset = "0x1B7EB68", VA = "0x1B7EB68", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1B7EBF0", Offset = "0x1B7EBF0", VA = "0x1B7EBF0")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1B7EC7C", Offset = "0x1B7EC7C", VA = "0x1B7EC7C")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1B7ECE4", Offset = "0x1B7ECE4", VA = "0x1B7ECE4")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1B7ED4C", Offset = "0x1B7ED4C", VA = "0x1B7ED4C")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1B7EDD8", Offset = "0x1B7EDD8", VA = "0x1B7EDD8")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1B7EE40", Offset = "0x1B7EE40", VA = "0x1B7EE40")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1B7EECC", Offset = "0x1B7EECC", VA = "0x1B7EECC")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1B7EF34", Offset = "0x1B7EF34", VA = "0x1B7EF34")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1B7F068", Offset = "0x1B7F068", VA = "0x1B7F068")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1B7F0F8", Offset = "0x1B7F0F8", VA = "0x1B7F0F8")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1B7F178", Offset = "0x1B7F178", VA = "0x1B7F178")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1B7F214", Offset = "0x1B7F214", VA = "0x1B7F214")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1B7F298", Offset = "0x1B7F298", VA = "0x1B7F298")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1B7C8A4", Offset = "0x1B7C8A4", VA = "0x1B7C8A4")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1B7F384", Offset = "0x1B7F384", VA = "0x1B7F384")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1B7C88C", Offset = "0x1B7C88C", VA = "0x1B7C88C")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1B7E850", Offset = "0x1B7E850", VA = "0x1B7E850")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1B7F3C0", Offset = "0x1B7F3C0", VA = "0x1B7F3C0")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1B7F59C", Offset = "0x1B7F59C", VA = "0x1B7F59C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCAC414", Offset = "0xCAC414")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABB6C", Offset = "0xCABB6C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1B89944", Offset = "0x1B89944", VA = "0x1B89944")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1B89C70", Offset = "0x1B89C70", VA = "0x1B89C70")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1B89C8C", Offset = "0x1B89C8C", VA = "0x1B89C8C")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCABB7C", Offset = "0xCABB7C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1B89C68", Offset = "0x1B89C68", VA = "0x1B89C68")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1B89CA8", Offset = "0x1B89CA8", VA = "0x1B89CA8")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1B895E4", Offset = "0x1B895E4", VA = "0x1B895E4")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1B89634", Offset = "0x1B89634", VA = "0x1B89634")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1B8994C", Offset = "0x1B8994C", VA = "0x1B8994C")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
